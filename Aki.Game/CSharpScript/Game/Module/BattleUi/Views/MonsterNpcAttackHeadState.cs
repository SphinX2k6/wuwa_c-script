using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D2D RID: 19757
	[NullableContext(1)]
	[Nullable(0)]
	public class MonsterNpcAttackHeadState : HeadStateViewBase
	{
		// Token: 0x06031960 RID: 203104 RVA: 0x00DDD354 File Offset: 0x00DDB554
		protected unsafe override void OnRegisterComponent()
		{
			int num = 27;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.ScaleToleration = 0.003f;
		}

		// Token: 0x06031961 RID: 203105 RVA: 0x00DDD714 File Offset: 0x00DDB914
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.RefreshNeedCorrectionOutside();
			this.RefreshHpAndShield(false);
			this.RefreshLevelText();
			base.RefreshHeadStateRotation();
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.RefreshBuff();
			this.RefreshHpColor();
			this.RefreshSpecialEnergy4(false);
			this.RefreshSlowChargeState(null);
			this.RefreshFastChargeState(null);
			this.RefreshAttackReadyState(null);
			this.RefreshAttackBeginState(null);
			this.RefreshAttackEndState(null);
			this.RefreshAttackBrokenState(null);
		}

		// Token: 0x06031962 RID: 203106 RVA: 0x00DDD7C0 File Offset: 0x00DDB9C0
		protected override void OnStart()
		{
			this.InitAllTweenAnim();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargeBufferPercent").Value / 10000f;
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(16);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(18);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			UUINiagara uiNiagara3 = base.GetUiNiagara(17);
			if (uiNiagara3 != null)
			{
				uiNiagara3.SetUIActive(false);
			}
			UUINiagara uiNiagara4 = base.GetUiNiagara(19);
			if (uiNiagara4 != null)
			{
				uiNiagara4.SetUIActive(false);
			}
			this.BuffItemContainer.Init(base.GetItem(8), 6, true, false, false, null);
		}

		// Token: 0x06031963 RID: 203107 RVA: 0x00DDD895 File Offset: 0x00DDBA95
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06031964 RID: 203108 RVA: 0x00DDD8A9 File Offset: 0x00DDBAA9
		protected override void ResetBattleHeadState()
		{
			this.BuffItemContainer.ClearAll();
			base.ResetBattleHeadState();
		}

		// Token: 0x06031965 RID: 203109 RVA: 0x00DDD8BC File Offset: 0x00DDBABC
		protected override string GetResourceId()
		{
			return "UiItem_EnergyBarAogusita";
		}

		// Token: 0x06031966 RID: 203110 RVA: 0x00DDD8C3 File Offset: 0x00DDBAC3
		public override void OnRefresh(float distance, float scale, float delta)
		{
			base.OnRefresh(distance, scale, delta);
			if (!this.IsActivated)
			{
				return;
			}
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.TickBuffItem(delta);
			this.LerpAttackPercent(delta);
		}

		// Token: 0x06031967 RID: 203111 RVA: 0x00DDD8F7 File Offset: 0x00DDBAF7
		protected override void OnAddOrRemoveBuff(int entityId, in GameplayCue cueConfig, bool isAdd, int handleId)
		{
			if (this.HeadStateData.GetEntityId() != entityId)
			{
				return;
			}
			if (isAdd)
			{
				this.BuffItemContainer.AddBuffByCue(cueConfig, handleId, true);
				return;
			}
			this.BuffItemContainer.RemoveBuffByCue(cueConfig, handleId, true);
		}

		// Token: 0x06031968 RID: 203112 RVA: 0x00DDD930 File Offset: 0x00DDBB30
		private void RefreshBuff()
		{
			if (this.HeadStateData == null)
			{
				this.BuffItemContainer.ClearAll();
				return;
			}
			EntityHandle handle = CharacterModel.Instance.GetHandle(this.HeadStateData.GetEntityId());
			this.BuffItemContainer.RefreshBuff(handle);
		}

		// Token: 0x06031969 RID: 203113 RVA: 0x00DDD974 File Offset: 0x00DDBB74
		private void RefreshHeadStateDetail()
		{
			bool uiactive = base.IsDetailVisible();
			base.GetItem(5).SetUIActive(uiactive);
		}

		// Token: 0x0603196A RID: 203114 RVA: 0x00DDD998 File Offset: 0x00DDBB98
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(4).SetUIActive(uiactive);
		}

		// Token: 0x0603196B RID: 203115 RVA: 0x00DDD9BC File Offset: 0x00DDBBBC
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(8).SetUIActive(uiactive);
		}

		// Token: 0x0603196C RID: 203116 RVA: 0x00DDD9DD File Offset: 0x00DDBBDD
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x0603196D RID: 203117 RVA: 0x00DDD9F4 File Offset: 0x00DDBBF4
		private void LerpAttackPercent(float delta)
		{
			this.AttackMachine.UpdatePercent(delta);
			if (this.AttackMachine.HasUpdate())
			{
				this.RefreshEnergyBar(this.AttackMachine.CurrentPercent);
			}
		}

		// Token: 0x0603196E RID: 203118 RVA: 0x00DDDA24 File Offset: 0x00DDBC24
		private void RefreshNeedCorrectionOutside()
		{
			CharacterActorComponent characterActorComponent = this.HeadStateData.ActorComponent as CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.HalfHeight > this.HeadStateData.CommonParam.OutMonsterHalfHeight)
			{
				this.NeedCorrectionOutside = true;
			}
		}

		// Token: 0x0603196F RID: 203119 RVA: 0x00DDDA64 File Offset: 0x00DDBC64
		public void RefreshHpAndShield(bool bPlayBarAnimation = false)
		{
			ValueTuple<float, float> hpAndShieldPercent = base.GetHpAndShieldPercent();
			float item = hpAndShieldPercent.Item1;
			float item2 = hpAndShieldPercent.Item2;
			this.SetHpBarPercent(item);
			this.SetShieldBarPercent(item2);
			if (bPlayBarAnimation)
			{
				if (item < this.CurrentBarPercent)
				{
					float num = this.CurrentBarPercent - item;
					float hitLargePercent = this.HitLargePercent;
				}
				this.PlayBarAnimation(item);
				return;
			}
			this.StopBarLerpAnimation();
		}

		// Token: 0x06031970 RID: 203120 RVA: 0x00DDDABC File Offset: 0x00DDBCBC
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x06031971 RID: 203121 RVA: 0x00DDDAC5 File Offset: 0x00DDBCC5
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x06031972 RID: 203122 RVA: 0x00DDDADA File Offset: 0x00DDBCDA
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x06031973 RID: 203123 RVA: 0x00DDDAE3 File Offset: 0x00DDBCE3
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
		}

		// Token: 0x06031974 RID: 203124 RVA: 0x00DDDAF4 File Offset: 0x00DDBCF4
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x06031975 RID: 203125 RVA: 0x00DDDB50 File Offset: 0x00DDBD50
		private void SetShieldBarPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(3);
			if (percent > 0f)
			{
				sprite.SetFillAmount(percent);
				sprite.SetUIActive(true);
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x06031976 RID: 203126 RVA: 0x00DDDB84 File Offset: 0x00DDBD84
		protected override void BindCallback()
		{
			base.BindCallback();
			if (this.HeadStateData == null)
			{
				return;
			}
			MonsterNpcAttackHeadStateData monsterNpcAttackHeadStateData = (MonsterNpcAttackHeadStateData)this.HeadStateData;
			monsterNpcAttackHeadStateData.BindOnSpecialEnergy4Changed(new Action<EAttributeType, float, float>(this.OnSpecialEnergy4Changed));
			monsterNpcAttackHeadStateData.BindOnSlowChargeStateChanged(new Action<int, bool>(this.OnSlowChargeStateChanged));
			monsterNpcAttackHeadStateData.BindOnFastChargeStateChanged(new Action<int, bool>(this.OnFastChargeStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackReadyStateChanged(new Action<int, bool>(this.OnAttackReadyStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackBeginStateChanged(new Action<int, bool>(this.OnAttackBeginStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackEndStateChanged(new Action<int, bool>(this.OnAttackEndStateChanged));
			monsterNpcAttackHeadStateData.BindOnAttackBrokenStateChanged(new Action<int, bool>(this.OnAttackBrokenStateChanged));
		}

		// Token: 0x06031977 RID: 203127 RVA: 0x00DDDC28 File Offset: 0x00DDBE28
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x06031978 RID: 203128 RVA: 0x00DDDC31 File Offset: 0x00DDBE31
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x06031979 RID: 203129 RVA: 0x00DDDC39 File Offset: 0x00DDBE39
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603197A RID: 203130 RVA: 0x00DDDC41 File Offset: 0x00DDBE41
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603197B RID: 203131 RVA: 0x00DDDC49 File Offset: 0x00DDBE49
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603197C RID: 203132 RVA: 0x00DDDC52 File Offset: 0x00DDBE52
		private void OnSpecialEnergy4Changed(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshSpecialEnergy4(true);
		}

		// Token: 0x0603197D RID: 203133 RVA: 0x00DDDC5B File Offset: 0x00DDBE5B
		private void OnSlowChargeStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshSlowChargeState(new bool?(bTagExists));
		}

		// Token: 0x0603197E RID: 203134 RVA: 0x00DDDC69 File Offset: 0x00DDBE69
		private void OnFastChargeStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshFastChargeState(new bool?(bTagExists));
		}

		// Token: 0x0603197F RID: 203135 RVA: 0x00DDDC77 File Offset: 0x00DDBE77
		private void OnAttackReadyStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackReadyState(new bool?(bTagExists));
		}

		// Token: 0x06031980 RID: 203136 RVA: 0x00DDDC85 File Offset: 0x00DDBE85
		private void OnAttackBeginStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackBeginState(new bool?(bTagExists));
		}

		// Token: 0x06031981 RID: 203137 RVA: 0x00DDDC93 File Offset: 0x00DDBE93
		private void OnAttackEndStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackEndState(new bool?(bTagExists));
		}

		// Token: 0x06031982 RID: 203138 RVA: 0x00DDDCA1 File Offset: 0x00DDBEA1
		private void OnAttackBrokenStateChanged(int tagId, bool bTagExists)
		{
			this.RefreshAttackBrokenState(new bool?(bTagExists));
		}

		// Token: 0x06031983 RID: 203139 RVA: 0x00DDDCB0 File Offset: 0x00DDBEB0
		private void RefreshLevelText()
		{
			if (this.HeadStateData == null)
			{
				return;
			}
			int level = this.GetLevel();
			UUIText text = base.GetText(4);
			string threadColor = BattleUiConfig.Instance.GetThreadColor(level, this.HeadStateData.Camp);
			text.SetColor(FColor.FromHex(threadColor));
			LguiUtil.Instance.SetLocalText(text, "LevelShow", new <>z__ReadOnlySingleElementList<object>(level));
		}

		// Token: 0x06031984 RID: 203140 RVA: 0x00DDDD13 File Offset: 0x00DDBF13
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x06031985 RID: 203141 RVA: 0x00DDDD24 File Offset: 0x00DDBF24
		private void RefreshHpColor()
		{
			string hpColor = base.GetHpColor();
			if (string.IsNullOrEmpty(hpColor))
			{
				return;
			}
			FColor color = FColor.FromHex(hpColor);
			UUISprite sprite = base.GetSprite(0);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(color);
		}

		// Token: 0x06031986 RID: 203142 RVA: 0x00DDDD5C File Offset: 0x00DDBF5C
		private void RefreshEnergyBar(float percent)
		{
			if (percent > 0f)
			{
				UUIItem item = base.GetItem(21);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUISliderComponent slider = base.GetSlider(10);
				if (slider != null)
				{
					slider.SetValue(percent, true);
				}
				UUISliderComponent slider2 = base.GetSlider(12);
				if (slider2 != null)
				{
					slider2.SetValue(percent, true);
				}
				if (this.EnergyPercent >= 1f)
				{
					UUINiagara uiNiagara = base.GetUiNiagara(16);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(false);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(18);
					if (uiNiagara2 != null)
					{
						uiNiagara2.SetUIActive(false);
					}
					UUINiagara uiNiagara3 = base.GetUiNiagara(17);
					if (uiNiagara3 != null)
					{
						uiNiagara3.SetUIActive(false);
					}
					UUINiagara uiNiagara4 = base.GetUiNiagara(19);
					if (uiNiagara4 == null)
					{
						return;
					}
					uiNiagara4.SetUIActive(false);
				}
				return;
			}
			UUIItem item2 = base.GetItem(21);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06031987 RID: 203143 RVA: 0x00DDDE20 File Offset: 0x00DDC020
		private void RefreshSpecialEnergy4(bool lerp)
		{
			float attributeCurrentValueById = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.SpecialEnergy4);
			float attributeCurrentValueById2 = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.SpecialEnergy4Max);
			float num = (attributeCurrentValueById2 == 0f) ? 0f : (attributeCurrentValueById / attributeCurrentValueById2);
			if (num == this.EnergyPercent)
			{
				return;
			}
			this.EnergyPercent = num;
			this.AttackMachine.SetTargetPercent(num, lerp ? 200f : 0f);
		}

		// Token: 0x06031988 RID: 203144 RVA: 0x00DDDE88 File Offset: 0x00DDC088
		private void RefreshSlowChargeState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_慢充"]))
			{
				if (!this.IsFullEnergy())
				{
					UUINiagara uiNiagara = base.GetUiNiagara(16);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(true);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(18);
					if (uiNiagara2 == null)
					{
						return;
					}
					uiNiagara2.SetUIActive(true);
					return;
				}
			}
			else
			{
				UUINiagara uiNiagara3 = base.GetUiNiagara(16);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				UUINiagara uiNiagara4 = base.GetUiNiagara(18);
				if (uiNiagara4 == null)
				{
					return;
				}
				uiNiagara4.SetUIActive(false);
			}
		}

		// Token: 0x06031989 RID: 203145 RVA: 0x00DDDF1C File Offset: 0x00DDC11C
		private void RefreshFastChargeState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.未出手状态_快充"]))
			{
				if (!this.IsFullEnergy())
				{
					UUINiagara uiNiagara = base.GetUiNiagara(17);
					if (uiNiagara != null)
					{
						uiNiagara.SetUIActive(true);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(19);
					if (uiNiagara2 == null)
					{
						return;
					}
					uiNiagara2.SetUIActive(true);
					return;
				}
			}
			else
			{
				UUINiagara uiNiagara3 = base.GetUiNiagara(17);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				UUINiagara uiNiagara4 = base.GetUiNiagara(19);
				if (uiNiagara4 == null)
				{
					return;
				}
				uiNiagara4.SetUIActive(false);
			}
		}

		// Token: 0x0603198A RID: 203146 RVA: 0x00DDDFB0 File Offset: 0x00DDC1B0
		private void RefreshAttackReadyState(bool? isInState = null)
		{
			bool flag = isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.准备状态"]);
			UUIItem item = base.GetItem(20);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				this.PlayTweenAnim(25);
				return;
			}
			this.StopTweenAnim(25);
			this.PlayTweenAnim(26);
		}

		// Token: 0x0603198B RID: 203147 RVA: 0x00DDE01C File Offset: 0x00DDC21C
		private void RefreshAttackBeginState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态"]))
			{
				this.PlayTweenAnim(22);
				return;
			}
			this.StopTweenAnim(22);
		}

		// Token: 0x0603198C RID: 203148 RVA: 0x00DDE06C File Offset: 0x00DDC26C
		private void RefreshAttackEndState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_弱"]))
			{
				this.PlayTweenAnim(23);
				return;
			}
			this.StopTweenAnim(23);
		}

		// Token: 0x0603198D RID: 203149 RVA: 0x00DDE0BC File Offset: 0x00DDC2BC
		private void RefreshAttackBrokenState(bool? isInState = null)
		{
			if (isInState ?? this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["怪物.角色怪.出手状态退出_强"]))
			{
				this.PlayTweenAnim(24);
				return;
			}
			this.StopTweenAnim(24);
		}

		// Token: 0x0603198E RID: 203150 RVA: 0x00DDE10A File Offset: 0x00DDC30A
		private bool IsFullEnergy()
		{
			return this.EnergyPercent >= 1f;
		}

		// Token: 0x0603198F RID: 203151 RVA: 0x00DDE11C File Offset: 0x00DDC31C
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(22);
			this.InitTweenAnim(23);
			this.InitTweenAnim(24);
			this.InitTweenAnim(25);
			this.InitTweenAnim(26);
		}

		// Token: 0x06031990 RID: 203152 RVA: 0x00DDE148 File Offset: 0x00DDC348
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			foreach (UActorComponent uactorComponent in base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass()))
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x06031991 RID: 203153 RVA: 0x00DDE1C8 File Offset: 0x00DDC3C8
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06031992 RID: 203154 RVA: 0x00DDE224 File Offset: 0x00DDC424
		private void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0401A404 RID: 107524
		private const float SCALE_TOLERATION = 0.003f;

		// Token: 0x0401A405 RID: 107525
		private const float LERP_ANIM_TIME = 200f;

		// Token: 0x0401A406 RID: 107526
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A407 RID: 107527
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401A408 RID: 107528
		private readonly MonsterNpcAttackMachine AttackMachine = new MonsterNpcAttackMachine();

		// Token: 0x0401A409 RID: 107529
		private float HitLargePercent;

		// Token: 0x0401A40A RID: 107530
		private float HpParentWidth;

		// Token: 0x0401A40B RID: 107531
		private float EnergyPercent;

		// Token: 0x0401A40C RID: 107532
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200A9F5 RID: 43509
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034874 RID: 215156
			NormalHpBarSprite,
			// Token: 0x04034875 RID: 215157
			BarBufferSprite,
			// Token: 0x04034876 RID: 215158
			HpLight,
			// Token: 0x04034877 RID: 215159
			ShieldBarSprite,
			// Token: 0x04034878 RID: 215160
			LevelText,
			// Token: 0x04034879 RID: 215161
			DetailItem,
			// Token: 0x0403487A RID: 215162
			HpItem,
			// Token: 0x0403487B RID: 215163
			HpBarItem,
			// Token: 0x0403487C RID: 215164
			BuffHorizontalItem,
			// Token: 0x0403487D RID: 215165
			EnergyItem,
			// Token: 0x0403487E RID: 215166
			EnergySliderLeft,
			// Token: 0x0403487F RID: 215167
			EnergyFullSpriteLeft,
			// Token: 0x04034880 RID: 215168
			EnergySliderRight,
			// Token: 0x04034881 RID: 215169
			EnergyFullSpriteRight,
			// Token: 0x04034882 RID: 215170
			EnergyCenterPoint,
			// Token: 0x04034883 RID: 215171
			BrokenItem,
			// Token: 0x04034884 RID: 215172
			SlowChargeLeft,
			// Token: 0x04034885 RID: 215173
			FastChargeLeft,
			// Token: 0x04034886 RID: 215174
			SlowChargeRight,
			// Token: 0x04034887 RID: 215175
			FastChargeRight,
			// Token: 0x04034888 RID: 215176
			EnergyFullItem,
			// Token: 0x04034889 RID: 215177
			EnergyBarItem,
			// Token: 0x0403488A RID: 215178
			AnimWarningStart,
			// Token: 0x0403488B RID: 215179
			AnimWarningClose,
			// Token: 0x0403488C RID: 215180
			AnimWarningBreak,
			// Token: 0x0403488D RID: 215181
			AnimWarningReady,
			// Token: 0x0403488E RID: 215182
			AnimWarningReadyClose
		}
	}
}
