using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.SpecialRoleData;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi
{
	// Token: 0x02004C81 RID: 19585
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiRoleData
	{
		// Token: 0x06030DD5 RID: 200149 RVA: 0x00DA0768 File Offset: 0x00D9E968
		[NullableContext(1)]
		public void Init(EntityHandle handle, bool isCurEntity)
		{
			this.EntityHandle = handle;
			this.IsCurEntity = isCurEntity;
			this.AttributeComponent = handle.Entity.GetComponent<BaseAttributeComponent>();
			this.GameplayTagComponent = handle.Entity.GetComponent<BaseTagComponent>();
			this.RoleElementComponent = handle.Entity.GetComponent<RoleElementComponent>();
			this.BuffComponent = handle.Entity.GetComponent<CharacterBuffComponent>();
			this.ShieldComponent = handle.Entity.GetComponent<CharacterShieldComponent>();
			this.RoleQteComponent = handle.Entity.GetComponent<RoleQteComponent>();
			this.CreatureDataComponent = handle.Entity.GetComponent<CreatureDataComponent>();
			this.BaseDeathComponent = handle.Entity.GetComponent<BaseDeathComponent>();
			this.ActorComp = handle.Entity.GetComponent<CharacterActorComponent>();
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float? num = (attributeComponent != null) ? new float?(attributeComponent.GetCurrentValue(EAttributeType.ElementPropertyType)) : null;
			this.ElementType = new EElementType?(((num != null) ? new EElementType?((EElementType)num.GetValueOrDefault()) : null).GetValueOrDefault());
			this.ElementConfig = ElementInfoConfig.Instance.GetElementInfo((int)this.ElementType.Value);
			this.ElementColor = new FColor?(FColor.FromHex(this.ElementConfig.Value.ElementColor));
			FColor value = this.ElementColor.Value;
			this.ElementLinearColor = new FLinearColor?(new FLinearColor(ref value));
			this.UltimateSkillColor = new FColor?(FColor.FromHex(this.ElementConfig.Value.UltimateSkillColor));
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			this.CreatureRoleId = ((creatureDataComponent != null) ? creatureDataComponent.GetRoleId() : 0);
			CreatureDataComponent creatureDataComponent2 = this.CreatureDataComponent;
			this.CreatureDataId = ((creatureDataComponent2 != null) ? creatureDataComponent2.GetCreatureDataId() : 0L);
			CreatureDataComponent creatureDataComponent3 = this.CreatureDataComponent;
			this.CreatureSkinId = ((creatureDataComponent3 != null) ? new int?(creatureDataComponent3.GetSkinId()) : null);
			CreatureDataComponent creatureDataComponent4 = this.CreatureDataComponent;
			this.RoleConfig = ((creatureDataComponent4 != null) ? creatureDataComponent4.GetRoleConfig() : null);
			if (this.RoleConfig != null)
			{
				if (this.RoleConfig.Value.RoleType == 2)
				{
					this.RoleBattleViewInfo = ConfigRoleBattleViewInfoById.GetConfig(this.RoleConfig.Value.Id, true);
				}
				this.HeadIconEnergyBarConfig = BattleUiModel.Instance.GetHeadIconEnergyBarConfig(this.RoleConfig.Value.Id);
				Func<BattleUiSpecialRoleDataBase> func;
				if (BattleUiRoleData.SpecialRoleDataClassMap.TryGetValue(this.RoleConfig.Value.Id, out func))
				{
					this.SpecialData = func();
					this.SpecialData.Init(this);
				}
			}
			this.AddEntityEvents();
		}

		// Token: 0x06030DD6 RID: 200150 RVA: 0x00DA0A16 File Offset: 0x00D9EC16
		public void OnChangeRole(bool isCurEntity)
		{
			this.IsCurEntity = isCurEntity;
			BattleUiSpecialRoleDataBase specialData = this.SpecialData;
			if (specialData == null)
			{
				return;
			}
			specialData.OnChangeRole(isCurEntity);
		}

		// Token: 0x06030DD7 RID: 200151 RVA: 0x00DA0A30 File Offset: 0x00D9EC30
		public void Clear()
		{
			this.RemoveEntityEvents();
			if (this.SpecialData != null)
			{
				this.SpecialData.Clear();
				this.SpecialData = null;
			}
			if (this.IsCurEntity)
			{
				this.SpecialStateMap.Clear();
				BattleUiModel.Instance.RefreshAllRoleSpecialState();
			}
			this.AttributeComponent = null;
			this.GameplayTagComponent = null;
			this.RoleElementComponent = null;
			this.BuffComponent = null;
			this.ShieldComponent = null;
			this.RoleQteComponent = null;
			this.CreatureDataComponent = null;
			this.BaseDeathComponent = null;
			this.ActorComp = null;
			this.ElementType = null;
			this.ElementConfig = null;
			this.ElementColor = null;
			this.ElementLinearColor = null;
			this.UltimateSkillColor = null;
			this.CreatureDataId = 0L;
			this.CreatureRoleId = 0;
			this.RoleConfig = null;
			this.RoleBattleViewInfo = null;
			this.HeadIconEnergyBarConfig = null;
			this.QteCdTagId = 0;
			this.CheckEnergyTag = false;
			this.HasEnergyTag = false;
		}

		// Token: 0x06030DD8 RID: 200152 RVA: 0x00DA0B40 File Offset: 0x00D9ED40
		private void AddEntityEvents()
		{
			foreach (int tagId in BattleUiRoleData.HideElementTagList)
			{
				this.ListenForTagSignificantChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnElementHideTagChanged), false);
			}
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"], new BaseTagComponent.TTagSwitchedCallback(this.OnDeadTagChanged), false);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE"], new BaseTagComponent.TTagSwitchedCallback(this.OnQteEnableTagChanged), false);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["功能.功能制作.QTE.激活QTE.不消耗能量"], new BaseTagComponent.TTagSwitchedCallback(this.OnQteEnableTagChanged), false);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.QTE"], new BaseTagComponent.TTagSwitchedCallback(this.OnUseQteTagChanged), false);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.协奏充能完成"], new BaseTagComponent.TTagSwitchedCallback(this.OnConcertoEnableTagChanged), false);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["关卡.滑水.专用UI"], new BaseTagComponent.TTagSwitchedCallback(this.OnMigrationTagChanged), true);
			this.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["关卡.圣火追逐.专用ui"], new BaseTagComponent.TTagSwitchedCallback(this.OnFlyRaceTagChanged), true);
			foreach (int tagId2 in BattleUiRoleData.SpecialStateTagMap.Keys)
			{
				this.ListenForTagSignificantChanged(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.OnRoleSpecialStateTagChanged), true);
			}
			EventSystem.Instance.AddWithTarget(this.EntityHandle.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.CharOnDirectionStateChanged));
			EventSystem.Instance.AddWithTarget<float>(this.EntityHandle.Entity, EEventName.CharShieldChange, new Action<float>(this.OnShieldChanged));
			this.UpdateQteCdTagListen();
			EventSystem.Instance.AddWithTarget(this.EntityHandle.Entity, EEventName.CharQteTagRowNameChanged, new Action(this.OnQteTagRowNameChanged));
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent != null)
			{
				attributeComponent.AddListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
				attributeComponent.AddListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged), null);
				attributeComponent.AddListener(EAttributeType.Lv, new Action<EAttributeType, float, float>(this.OnLevelChanged), null);
				attributeComponent.AddListener(EAttributeType.ElementEnergy, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged), null);
				attributeComponent.AddListener(EAttributeType.ElementEnergyMax, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged), null);
				attributeComponent.AddListener(EAttributeType.Energy, new Action<EAttributeType, float, float>(this.OnEnergyChanged), null);
				attributeComponent.AddListener(EAttributeType.EnergyMax, new Action<EAttributeType, float, float>(this.OnEnergyChanged), null);
			}
		}

		// Token: 0x06030DD9 RID: 200153 RVA: 0x00DA0DD4 File Offset: 0x00D9EFD4
		private void RemoveEntityEvents()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
			if (this.QteCdTagTask != null)
			{
				this.QteCdTagTask.EndTask();
				this.QteCdTagTask = null;
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				EventSystem.Instance.RemoveWithTarget(this.EntityHandle.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.CharOnDirectionStateChanged));
				EventSystem.Instance.RemoveWithTarget<float>(this.EntityHandle.Entity, EEventName.CharShieldChange, new Action<float>(this.OnShieldChanged));
				EventSystem.Instance.RemoveWithTarget(this.EntityHandle.Entity, EEventName.CharQteTagRowNameChanged, new Action(this.OnQteTagRowNameChanged));
				BaseAttributeComponent attributeComponent = this.AttributeComponent;
				if (attributeComponent != null)
				{
					attributeComponent.RemoveListener(EAttributeType.Life, new Action<EAttributeType, float, float>(this.OnHealthChanged));
					attributeComponent.RemoveListener(EAttributeType.LifeMax, new Action<EAttributeType, float, float>(this.OnHealthChanged));
					attributeComponent.RemoveListener(EAttributeType.Lv, new Action<EAttributeType, float, float>(this.OnLevelChanged));
					attributeComponent.RemoveListener(EAttributeType.ElementEnergy, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged));
					attributeComponent.RemoveListener(EAttributeType.ElementEnergyMax, new Action<EAttributeType, float, float>(this.OnElementEnergyChanged));
					return;
				}
			}
			else
			{
				Log.Instance.Info(ELogModule.Battle, ELogAuthor.CFT, "BattelUi清理RoleData时，Entity不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x06030DDA RID: 200154 RVA: 0x00DA0F60 File Offset: 0x00D9F160
		[NullableContext(1)]
		public void ListenForTagSignificantChanged(int tagId, BaseTagComponent.TTagSwitchedCallback callback, bool checkExistImmediately = false)
		{
			if (checkExistImmediately)
			{
				BaseTagComponent gameplayTagComponent = this.GameplayTagComponent;
				if (gameplayTagComponent != null && gameplayTagComponent.HasTag(tagId))
				{
					callback(tagId, true);
				}
			}
			ITagTask tagTask = this.GameplayTagComponent.ListenForTagAddOrRemove(new int?(tagId), callback, null);
			if (tagTask == null)
			{
				return;
			}
			this.TagSignificantChangedTaskList.Add(tagTask);
		}

		// Token: 0x06030DDB RID: 200155 RVA: 0x00DA0FB1 File Offset: 0x00D9F1B1
		private void OnElementEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiElementEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DDC RID: 200156 RVA: 0x00DA0FCE File Offset: 0x00D9F1CE
		private void OnEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DDD RID: 200157 RVA: 0x00DA0FEB File Offset: 0x00D9F1EB
		private void OnElementHideTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiElementHideTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DDE RID: 200158 RVA: 0x00DA100A File Offset: 0x00D9F20A
		private void OnDeadTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiDeadTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DDF RID: 200159 RVA: 0x00DA1029 File Offset: 0x00D9F229
		private void OnQteEnableTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiQteEnableTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DE0 RID: 200160 RVA: 0x00DA1048 File Offset: 0x00D9F248
		private void OnQteCdTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiQteCdTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DE1 RID: 200161 RVA: 0x00DA1067 File Offset: 0x00D9F267
		private void OnUseQteTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiUseQteTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DE2 RID: 200162 RVA: 0x00DA1086 File Offset: 0x00D9F286
		private void OnConcertoEnableTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiConcertoEnableTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x06030DE3 RID: 200163 RVA: 0x00DA10A5 File Offset: 0x00D9F2A5
		private void OnMigrationTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.MigrationStrength);
			}
		}

		// Token: 0x06030DE4 RID: 200164 RVA: 0x00DA10B5 File Offset: 0x00D9F2B5
		private void OnFlyRaceTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.FlyRaceStrength);
			}
		}

		// Token: 0x06030DE5 RID: 200165 RVA: 0x00DA10C8 File Offset: 0x00D9F2C8
		private void OnRoleSpecialStateTagChanged(int tagId, bool tagExist)
		{
			ERoleSpecialState eroleSpecialState;
			if (BattleUiRoleData.SpecialStateTagMap.TryGetValue(tagId, out eroleSpecialState))
			{
				this.SpecialStateMap[eroleSpecialState] = tagExist;
				if (this.IsCurEntity)
				{
					BattleUiModel.Instance.RefreshRoleSpecialState(eroleSpecialState);
				}
			}
		}

		// Token: 0x06030DE6 RID: 200166 RVA: 0x00DA1104 File Offset: 0x00D9F304
		private void CharOnDirectionStateChanged(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
		{
			if (!this.IsCurEntity)
			{
				return;
			}
			if (oldDirectionState == newDirectionState)
			{
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnAimStateChanged);
		}

		// Token: 0x06030DE7 RID: 200167 RVA: 0x00DA1124 File Offset: 0x00D9F324
		private void OnShieldChanged(float shield)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiShieldChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DE8 RID: 200168 RVA: 0x00DA1141 File Offset: 0x00D9F341
		private void OnQteTagRowNameChanged()
		{
			this.UpdateQteCdTagListen();
		}

		// Token: 0x06030DE9 RID: 200169 RVA: 0x00DA114C File Offset: 0x00D9F34C
		private void UpdateQteCdTagListen()
		{
			RoleQteComponent roleQteComponent = this.RoleQteComponent;
			int? num;
			if (roleQteComponent == null)
			{
				num = null;
			}
			else
			{
				SQteTag qteTagData = roleQteComponent.GetQteTagData();
				num = ((qteTagData != null) ? new int?(qteTagData.NoTag.TagId()) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (valueOrDefault != this.QteCdTagId)
			{
				if (this.QteCdTagTask != null)
				{
					this.QteCdTagTask.EndTask();
					this.QteCdTagTask = null;
				}
				this.QteCdTagId = valueOrDefault;
				if (this.QteCdTagId != 0)
				{
					this.QteCdTagTask = this.GameplayTagComponent.ListenForTagAddOrRemove(new int?(valueOrDefault), new BaseTagComponent.TTagSwitchedCallback(this.OnQteCdTagChanged), null);
				}
			}
		}

		// Token: 0x06030DEA RID: 200170 RVA: 0x00DA11F0 File Offset: 0x00D9F3F0
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiHealthChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DEB RID: 200171 RVA: 0x00DA120D File Offset: 0x00D9F40D
		private void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiLevelChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DEC RID: 200172 RVA: 0x00DA122C File Offset: 0x00D9F42C
		public bool GetTopButtonVisible()
		{
			return this.RoleBattleViewInfo == null || this.RoleBattleViewInfo.Value.TopButtonVisible;
		}

		// Token: 0x06030DED RID: 200173 RVA: 0x00DA125C File Offset: 0x00D9F45C
		public float GetElementAttributePercent()
		{
			if (this.RoleElementComponent == null)
			{
				return 0f;
			}
			float roleElementEnergy = this.RoleElementComponent.RoleElementEnergy;
			float roleElementEnergyMax = this.RoleElementComponent.RoleElementEnergyMax;
			if (roleElementEnergyMax <= 0f)
			{
				return 0f;
			}
			return roleElementEnergy / roleElementEnergyMax;
		}

		// Token: 0x06030DEE RID: 200174 RVA: 0x00DA12A0 File Offset: 0x00D9F4A0
		public bool IsPhantom()
		{
			return this.RoleConfig != null && this.RoleConfig.GetValueOrDefault().RoleType == 2;
		}

		// Token: 0x06030DEF RID: 200175 RVA: 0x00DA12D0 File Offset: 0x00D9F4D0
		public bool CanUseUltraSkill()
		{
			if (this.CheckEnergyTag)
			{
				return this.HasEnergyTag;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent == null)
			{
				return false;
			}
			float currentValue = attributeComponent.GetCurrentValue(EAttributeType.Energy);
			float currentValue2 = attributeComponent.GetCurrentValue(EAttributeType.EnergyMax);
			return currentValue >= currentValue2;
		}

		// Token: 0x06030DF0 RID: 200176 RVA: 0x00DA1311 File Offset: 0x00D9F511
		public void SetHasEnergyTag(bool tagExist)
		{
			if (this.HasEnergyTag == tagExist)
			{
				return;
			}
			this.HasEnergyTag = tagExist;
			EventSystem.Instance.Emit<int>(EEventName.BattleUiEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DF1 RID: 200177 RVA: 0x00DA133F File Offset: 0x00D9F53F
		public void SetOverrideRoleHeadIcon(string headIconPath)
		{
			this.OverrideRoleHeadIcon = headIconPath;
			EventSystem.Instance.Emit<int>(EEventName.BattleUiRoleHeadChanged, this.EntityHandle.Id);
		}

		// Token: 0x06030DF3 RID: 200179 RVA: 0x00DA1388 File Offset: 0x00D9F588
		// Note: this type is marked as 'beforefieldinit'.
		static BattleUiRoleData()
		{
			Dictionary<int, ERoleSpecialState> dictionary = new Dictionary<int, ERoleSpecialState>();
			int key = GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑轨"];
			dictionary[key] = ERoleSpecialState.RailSlide;
			int key2 = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.滑轨移动中"];
			dictionary[key2] = ERoleSpecialState.MotorcycleRailMove;
			int key3 = GameplayTagDefine.EGameplayTagId["关卡.海底试验场.UI显示标识"];
			dictionary[key3] = ERoleSpecialState.SlowTimeWorld;
			int key4 = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.移动端浮游炮攻击按钮"];
			dictionary[key4] = ERoleSpecialState.MotorcycleCannon;
			int key5 = GameplayTagDefine.EGameplayTagId["功能.逻辑状态标识.弱点机制.新手教程.屏蔽弱点"];
			dictionary[key5] = ERoleSpecialState.ForbidWeakness;
			int key6 = GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用第一人称"];
			dictionary[key6] = ERoleSpecialState.MotorcycleFirstPersonDisabled;
			int key7 = GameplayTagDefine.EGameplayTagId["功能.功能制作.隐藏状态功能.隐藏战斗UI仅允许战斗输入"];
			dictionary[key7] = ERoleSpecialState.OnlyAllowFightInput;
			int key8 = GameplayTagDefine.EGameplayTagId["关卡.副本.3_8花瓣玩法"];
			dictionary[key8] = ERoleSpecialState.PetalMechanic;
			BattleUiRoleData.SpecialStateTagMap = dictionary;
			BattleUiRoleData.SpecialRoleDataClassMap = new Dictionary<int, Func<BattleUiSpecialRoleDataBase>>
			{
				{
					1207,
					() => new BattleUiSpecialRoleDataLuPa()
				},
				{
					1608,
					() => new BattleUiSpecialRoleDataFuLuoLuo()
				},
				{
					1210,
					() => new BattleUiSpecialRoleDataAiMiSi()
				},
				{
					1109,
					() => new BattleUiSpecialRoleDataLuoSeLa()
				},
				{
					1413,
					() => new BattleUiSpecialRoleDataQingXiao()
				},
				{
					1312,
					() => new BattleUiSpecialRoleDataSuoMing()
				},
				{
					1311,
					() => new BattleUiSpecialRoleDataXinYueHu()
				},
				{
					5051,
					() => new BattleUiSpecialRoleDataLittleFox()
				}
			};
		}

		// Token: 0x04019EB5 RID: 106165
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly int[] HideElementTagList = new int[]
		{
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定冷凝能量"],
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定导电能量"],
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定气动能量"],
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定衍射能量"],
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定解离能量"],
			GameplayTagDefine.EGameplayTagId["功能.人物属性.锁定高温能量"]
		};

		// Token: 0x04019EB6 RID: 106166
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, ERoleSpecialState> SpecialStateTagMap;

		// Token: 0x04019EB7 RID: 106167
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Func<BattleUiSpecialRoleDataBase>> SpecialRoleDataClassMap;

		// Token: 0x04019EB8 RID: 106168
		public bool IsCurEntity;

		// Token: 0x04019EB9 RID: 106169
		public EntityHandle EntityHandle;

		// Token: 0x04019EBA RID: 106170
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x04019EBB RID: 106171
		public BaseTagComponent GameplayTagComponent;

		// Token: 0x04019EBC RID: 106172
		public RoleElementComponent RoleElementComponent;

		// Token: 0x04019EBD RID: 106173
		public CharacterBuffComponent BuffComponent;

		// Token: 0x04019EBE RID: 106174
		public CharacterShieldComponent ShieldComponent;

		// Token: 0x04019EBF RID: 106175
		public RoleQteComponent RoleQteComponent;

		// Token: 0x04019EC0 RID: 106176
		public CreatureDataComponent CreatureDataComponent;

		// Token: 0x04019EC1 RID: 106177
		public BaseDeathComponent BaseDeathComponent;

		// Token: 0x04019EC2 RID: 106178
		public CharacterActorComponent ActorComp;

		// Token: 0x04019EC3 RID: 106179
		public EElementType? ElementType;

		// Token: 0x04019EC4 RID: 106180
		public ElementInfo? ElementConfig;

		// Token: 0x04019EC5 RID: 106181
		public FColor? ElementColor;

		// Token: 0x04019EC6 RID: 106182
		public FLinearColor? ElementLinearColor;

		// Token: 0x04019EC7 RID: 106183
		public FColor? UltimateSkillColor;

		// Token: 0x04019EC8 RID: 106184
		public long CreatureDataId;

		// Token: 0x04019EC9 RID: 106185
		public int CreatureRoleId;

		// Token: 0x04019ECA RID: 106186
		public int? CreatureSkinId;

		// Token: 0x04019ECB RID: 106187
		public RoleInfo? RoleConfig;

		// Token: 0x04019ECC RID: 106188
		public RoleBattleViewInfo? RoleBattleViewInfo;

		// Token: 0x04019ECD RID: 106189
		public HeadIconEnergyBar? HeadIconEnergyBarConfig;

		// Token: 0x04019ECE RID: 106190
		public int QteCdTagId;

		// Token: 0x04019ECF RID: 106191
		private ITagTask QteCdTagTask;

		// Token: 0x04019ED0 RID: 106192
		[Nullable(1)]
		public Dictionary<ERoleSpecialState, bool> SpecialStateMap = new Dictionary<ERoleSpecialState, bool>();

		// Token: 0x04019ED1 RID: 106193
		public bool MorphShowSpecialEnergyBar = true;

		// Token: 0x04019ED2 RID: 106194
		public bool OnlyBattleInput;

		// Token: 0x04019ED3 RID: 106195
		public bool HasEnergyTag;

		// Token: 0x04019ED4 RID: 106196
		public bool CheckEnergyTag;

		// Token: 0x04019ED5 RID: 106197
		public string OverrideRoleHeadIcon;

		// Token: 0x04019ED6 RID: 106198
		[Nullable(1)]
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x04019ED7 RID: 106199
		private BattleUiSpecialRoleDataBase SpecialData;
	}
}
