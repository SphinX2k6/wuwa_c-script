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
	// Token: 0x02005C9F RID: 23711
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleUiRoleData
	{
		// Token: 0x0603BE82 RID: 245378 RVA: 0x00E500E0 File Offset: 0x00E4E2E0
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

		// Token: 0x0603BE83 RID: 245379 RVA: 0x00E5038E File Offset: 0x00E4E58E
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

		// Token: 0x0603BE84 RID: 245380 RVA: 0x00E503A8 File Offset: 0x00E4E5A8
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

		// Token: 0x0603BE85 RID: 245381 RVA: 0x00E504B8 File Offset: 0x00E4E6B8
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

		// Token: 0x0603BE86 RID: 245382 RVA: 0x00E5074C File Offset: 0x00E4E94C
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

		// Token: 0x0603BE87 RID: 245383 RVA: 0x00E508D8 File Offset: 0x00E4EAD8
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

		// Token: 0x0603BE88 RID: 245384 RVA: 0x00E50929 File Offset: 0x00E4EB29
		private void OnElementEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiElementEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE89 RID: 245385 RVA: 0x00E50946 File Offset: 0x00E4EB46
		private void OnEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE8A RID: 245386 RVA: 0x00E50963 File Offset: 0x00E4EB63
		private void OnElementHideTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiElementHideTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE8B RID: 245387 RVA: 0x00E50982 File Offset: 0x00E4EB82
		private void OnDeadTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiDeadTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE8C RID: 245388 RVA: 0x00E509A1 File Offset: 0x00E4EBA1
		private void OnQteEnableTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiQteEnableTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE8D RID: 245389 RVA: 0x00E509C0 File Offset: 0x00E4EBC0
		private void OnQteCdTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiQteCdTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE8E RID: 245390 RVA: 0x00E509DF File Offset: 0x00E4EBDF
		private void OnUseQteTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiUseQteTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE8F RID: 245391 RVA: 0x00E509FE File Offset: 0x00E4EBFE
		private void OnConcertoEnableTagChanged(int tagId, bool tagExist)
		{
			EventSystem.Instance.Emit<int, int, bool>(EEventName.BattleUiConcertoEnableTagChanged, this.EntityHandle.Id, tagId, tagExist);
		}

		// Token: 0x0603BE90 RID: 245392 RVA: 0x00E50A1D File Offset: 0x00E4EC1D
		private void OnMigrationTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.MigrationStrength);
			}
		}

		// Token: 0x0603BE91 RID: 245393 RVA: 0x00E50A2D File Offset: 0x00E4EC2D
		private void OnFlyRaceTagChanged(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				HudUnitController.Instance.TryCreateHud(EHudUnitType.FlyRaceStrength);
			}
		}

		// Token: 0x0603BE92 RID: 245394 RVA: 0x00E50A40 File Offset: 0x00E4EC40
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

		// Token: 0x0603BE93 RID: 245395 RVA: 0x00E50A7C File Offset: 0x00E4EC7C
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

		// Token: 0x0603BE94 RID: 245396 RVA: 0x00E50A9C File Offset: 0x00E4EC9C
		private void OnShieldChanged(float shield)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiShieldChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE95 RID: 245397 RVA: 0x00E50AB9 File Offset: 0x00E4ECB9
		private void OnQteTagRowNameChanged()
		{
			this.UpdateQteCdTagListen();
		}

		// Token: 0x0603BE96 RID: 245398 RVA: 0x00E50AC4 File Offset: 0x00E4ECC4
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

		// Token: 0x0603BE97 RID: 245399 RVA: 0x00E50B68 File Offset: 0x00E4ED68
		private void OnHealthChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiHealthChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE98 RID: 245400 RVA: 0x00E50B85 File Offset: 0x00E4ED85
		private void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			EventSystem.Instance.Emit<int>(EEventName.BattleUiLevelChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE99 RID: 245401 RVA: 0x00E50BA4 File Offset: 0x00E4EDA4
		public bool GetTopButtonVisible()
		{
			return this.RoleBattleViewInfo == null || this.RoleBattleViewInfo.Value.TopButtonVisible;
		}

		// Token: 0x0603BE9A RID: 245402 RVA: 0x00E50BD4 File Offset: 0x00E4EDD4
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

		// Token: 0x0603BE9B RID: 245403 RVA: 0x00E50C18 File Offset: 0x00E4EE18
		public bool IsPhantom()
		{
			return this.RoleConfig != null && this.RoleConfig.GetValueOrDefault().RoleType == 2;
		}

		// Token: 0x0603BE9C RID: 245404 RVA: 0x00E50C48 File Offset: 0x00E4EE48
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

		// Token: 0x0603BE9D RID: 245405 RVA: 0x00E50C89 File Offset: 0x00E4EE89
		public void SetHasEnergyTag(bool tagExist)
		{
			if (this.HasEnergyTag == tagExist)
			{
				return;
			}
			this.HasEnergyTag = tagExist;
			EventSystem.Instance.Emit<int>(EEventName.BattleUiEnergyChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BE9E RID: 245406 RVA: 0x00E50CB7 File Offset: 0x00E4EEB7
		public void SetOverrideRoleHeadIcon(string headIconPath)
		{
			this.OverrideRoleHeadIcon = headIconPath;
			EventSystem.Instance.Emit<int>(EEventName.BattleUiRoleHeadChanged, this.EntityHandle.Id);
		}

		// Token: 0x0603BEA0 RID: 245408 RVA: 0x00E50D00 File Offset: 0x00E4EF00
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

		// Token: 0x0401F3FC RID: 127996
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

		// Token: 0x0401F3FD RID: 127997
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<int, ERoleSpecialState> SpecialStateTagMap;

		// Token: 0x0401F3FE RID: 127998
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<int, Func<BattleUiSpecialRoleDataBase>> SpecialRoleDataClassMap;

		// Token: 0x0401F3FF RID: 127999
		public bool IsCurEntity;

		// Token: 0x0401F400 RID: 128000
		public EntityHandle EntityHandle;

		// Token: 0x0401F401 RID: 128001
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x0401F402 RID: 128002
		public BaseTagComponent GameplayTagComponent;

		// Token: 0x0401F403 RID: 128003
		public RoleElementComponent RoleElementComponent;

		// Token: 0x0401F404 RID: 128004
		public CharacterBuffComponent BuffComponent;

		// Token: 0x0401F405 RID: 128005
		public CharacterShieldComponent ShieldComponent;

		// Token: 0x0401F406 RID: 128006
		public RoleQteComponent RoleQteComponent;

		// Token: 0x0401F407 RID: 128007
		public CreatureDataComponent CreatureDataComponent;

		// Token: 0x0401F408 RID: 128008
		public BaseDeathComponent BaseDeathComponent;

		// Token: 0x0401F409 RID: 128009
		public CharacterActorComponent ActorComp;

		// Token: 0x0401F40A RID: 128010
		public EElementType? ElementType;

		// Token: 0x0401F40B RID: 128011
		public ElementInfo? ElementConfig;

		// Token: 0x0401F40C RID: 128012
		public FColor? ElementColor;

		// Token: 0x0401F40D RID: 128013
		public FLinearColor? ElementLinearColor;

		// Token: 0x0401F40E RID: 128014
		public FColor? UltimateSkillColor;

		// Token: 0x0401F40F RID: 128015
		public long CreatureDataId;

		// Token: 0x0401F410 RID: 128016
		public int CreatureRoleId;

		// Token: 0x0401F411 RID: 128017
		public int? CreatureSkinId;

		// Token: 0x0401F412 RID: 128018
		public RoleInfo? RoleConfig;

		// Token: 0x0401F413 RID: 128019
		public RoleBattleViewInfo? RoleBattleViewInfo;

		// Token: 0x0401F414 RID: 128020
		public HeadIconEnergyBar? HeadIconEnergyBarConfig;

		// Token: 0x0401F415 RID: 128021
		public int QteCdTagId;

		// Token: 0x0401F416 RID: 128022
		private ITagTask QteCdTagTask;

		// Token: 0x0401F417 RID: 128023
		[Nullable(1)]
		public Dictionary<ERoleSpecialState, bool> SpecialStateMap = new Dictionary<ERoleSpecialState, bool>();

		// Token: 0x0401F418 RID: 128024
		public bool MorphShowSpecialEnergyBar = true;

		// Token: 0x0401F419 RID: 128025
		public bool OnlyBattleInput;

		// Token: 0x0401F41A RID: 128026
		public bool HasEnergyTag;

		// Token: 0x0401F41B RID: 128027
		public bool CheckEnergyTag;

		// Token: 0x0401F41C RID: 128028
		public string OverrideRoleHeadIcon;

		// Token: 0x0401F41D RID: 128029
		[Nullable(1)]
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x0401F41E RID: 128030
		private BattleUiSpecialRoleDataBase SpecialData;
	}
}
