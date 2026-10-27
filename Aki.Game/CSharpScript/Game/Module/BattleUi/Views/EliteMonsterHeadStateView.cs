using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D43 RID: 23875
	[NullableContext(1)]
	[Nullable(0)]
	public class EliteMonsterHeadStateView : HeadStateViewBase
	{
		// Token: 0x0603C91C RID: 248092 RVA: 0x00E88CD0 File Offset: 0x00E86ED0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 32;
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.ScaleToleration = 0.003f;
		}

		// Token: 0x0603C91D RID: 248093 RVA: 0x00E8913C File Offset: 0x00E8733C
		protected override UniTask OnBeforeStartAsync()
		{
			EliteMonsterHeadStateView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EliteMonsterHeadStateView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C91E RID: 248094 RVA: 0x00E89180 File Offset: 0x00E87380
		protected override void ActiveBattleHeadState(HeadStateData headStateData)
		{
			base.ActiveBattleHeadState(headStateData);
			this.ToughItemVisible = base.GetItem(8).bIsUIActive;
			this.RageVisible = base.GetItem(5).bIsUIActive;
			this.FallDownBarVisible = base.GetSprite(12).bIsUIActive;
			this.ToughVisibleMachine.InitVisible(this.ToughItemVisible);
			base.GetItem(8).SetAlpha(1f);
			this.HpFlickerVisible = headStateData.HasTag(GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪易伤"]);
			base.GetSprite(15).SetUIActive(this.HpFlickerVisible);
			this.IsShowFallDownBar = headStateData.HasFallDownTag;
			this.RefreshNeedCorrectionOutside();
			this.RefreshHpAndShield(false);
			this.RefreshLevelText();
			base.RefreshHeadStateRotation();
			this.RefreshHeadStateDetail();
			this.RefreshLevelTextVisible();
			this.RefreshBuffVisible();
			this.RefreshFallDownBarVisible();
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
			this.RefreshRage();
			this.StopRageEmptyAnimation();
			this.RefreshBuff();
			this.RefreshHpColor();
			this.RefreshWeaknessItem(true);
		}

		// Token: 0x0603C91F RID: 248095 RVA: 0x00E89284 File Offset: 0x00E87484
		protected override void OnStart()
		{
			this.InitAllTweenAnim();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.HitLargePercent = (float)ConfigCommonParamById.GetIntConfig("HitLargeBufferPercent").Value / 10000f;
			this.RageMachine.SetUpdateCallback(new RageBufferStateMachine.OnUpdateLittleReduce(this.PlayRageLittleReduceAnimation), new RageBufferStateMachine.OnUpdateLargeReduce(this.PlayRageLargeReduceAnimation), new Action(this.PlayRageEmptyAnimation));
			this.HpParentWidth = base.GetSprite(2).GetParentAsUIItem().GetWidth();
			this.RageWidth = base.GetSprite(14).GetParentAsUIItem().GetWidth();
			this.ToughVisibleMachine = new VisibleAnimMachine();
			this.ToughVisibleMachine.InitCallback(new Action<bool>(this.OnToughRealVisibleChanged), new Action<bool>(this.OnPlayToughVisibleAnim), new Action<bool>(this.OnStopToughVisibleAnim));
			this.BuffItemContainer.Init(base.GetItem(9), 6, true, false, false, null);
		}

		// Token: 0x0603C920 RID: 248096 RVA: 0x00E89378 File Offset: 0x00E87578
		protected override void OnBeforeDestroy()
		{
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.StopRageLittleReduceAnimation();
			this.StopRageEmptyAnimation();
			this.RageMachine.Reset();
			this.ToughVisibleMachine.Deactivate();
			this.ToughVisibleMachine = null;
			if (this.WeaknessItem != null)
			{
				this.WeaknessItem.Destroy(null);
				this.WeaknessItem = null;
			}
		}

		// Token: 0x0603C921 RID: 248097 RVA: 0x00E893DC File Offset: 0x00E875DC
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			UUIItem item = base.GetItem(25);
			if (this.ExtraItem != null)
			{
				this.ExtraItem.GetRootItem().SetUIParent(item, false);
				if (item != null)
				{
					item.SetUIActive(true);
					return;
				}
			}
			else if (item != null)
			{
				item.SetUIActive(false);
			}
		}

		// Token: 0x0603C922 RID: 248098 RVA: 0x00E89427 File Offset: 0x00E87627
		protected override void OnFallDownVisibleChange()
		{
			if (this.HeadStateData.HasFallDownTag)
			{
				this.RageMachine.GetHit(0f, this.CurRage);
				this.RefreshFallDownBar();
				this.SetFallDownBar(true);
				return;
			}
			this.SetFallDownBar(false);
		}

		// Token: 0x0603C923 RID: 248099 RVA: 0x00E89461 File Offset: 0x00E87661
		protected override void ResetBattleHeadState()
		{
			this.BuffItemContainer.ClearAll();
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			if (weaknessItem != null)
			{
				weaknessItem.Refresh(null);
			}
			base.ResetBattleHeadState();
		}

		// Token: 0x0603C924 RID: 248100 RVA: 0x00E89488 File Offset: 0x00E87688
		private void RefreshWeaknessItem(bool isStart = false)
		{
			base.GetUiNiagara(29).SetUIActive(false);
			if (this.WeaknessItem == null)
			{
				return;
			}
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			HeadStateData headStateData = this.HeadStateData;
			weaknessItem.Refresh((headStateData != null) ? headStateData.GetEntity() : null);
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(isStart);
			this.WeaknessItem.SetStateChangeCallback(new Action(this.OnWeaknessStateChanged));
		}

		// Token: 0x0603C925 RID: 248101 RVA: 0x00E894ED File Offset: 0x00E876ED
		private void RefreshHpWeaknessPercent()
		{
			if (this.WeaknessItem != null && this.WeaknessItem.IsFullState(true))
			{
				base.GetSprite(28).SetFillAmount(this.CurrentBarPercent);
			}
		}

		// Token: 0x0603C926 RID: 248102 RVA: 0x00E89518 File Offset: 0x00E87718
		private void RefreshHpWeaknessState(bool isStart = false)
		{
			if (this.WeaknessItem.IsInBreakAnim())
			{
				base.GetItem(27).SetUIActive(true);
				if (!isStart)
				{
					this.PlayTweenAnim(31);
					return;
				}
			}
			else if (this.WeaknessItem.IsFullState(true))
			{
				base.GetItem(27).SetUIActive(true);
				if (!isStart)
				{
					this.PlayTweenAnim(30);
					return;
				}
			}
			else
			{
				base.GetItem(27).SetUIActive(false);
			}
		}

		// Token: 0x0603C927 RID: 248103 RVA: 0x00E89582 File Offset: 0x00E87782
		private void OnWeaknessStateChanged()
		{
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(false);
		}

		// Token: 0x0603C928 RID: 248104 RVA: 0x00E89591 File Offset: 0x00E87791
		protected override string GetResourceId()
		{
			return "UiItem_EliteMonsterState_Prefab";
		}

		// Token: 0x0603C929 RID: 248105 RVA: 0x00E89598 File Offset: 0x00E87798
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
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			if (weaknessItem != null)
			{
				weaknessItem.Tick(delta);
			}
			this.RageMachine.Update(delta);
			this.RefreshFallDownBar();
		}

		// Token: 0x0603C92A RID: 248106 RVA: 0x00E895F4 File Offset: 0x00E877F4
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

		// Token: 0x0603C92B RID: 248107 RVA: 0x00E8962C File Offset: 0x00E8782C
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

		// Token: 0x0603C92C RID: 248108 RVA: 0x00E89670 File Offset: 0x00E87870
		private void RefreshHeadStateDetail()
		{
			bool flag = base.IsDetailVisible();
			base.GetItem(7).SetUIActive(flag);
			StateExtraItemBase extraItem = this.ExtraItem;
			if (extraItem != null)
			{
				extraItem.SetUiActive(flag);
			}
			this.WeaknessContainer.SetUIActive(flag);
		}

		// Token: 0x0603C92D RID: 248109 RVA: 0x00E896B0 File Offset: 0x00E878B0
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(4).SetUIActive(uiactive);
		}

		// Token: 0x0603C92E RID: 248110 RVA: 0x00E896D4 File Offset: 0x00E878D4
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(9).SetUIActive(uiactive);
		}

		// Token: 0x0603C92F RID: 248111 RVA: 0x00E896F6 File Offset: 0x00E878F6
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x0603C930 RID: 248112 RVA: 0x00E8970D File Offset: 0x00E8790D
		protected override void OnEliteStateChange()
		{
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x0603C931 RID: 248113 RVA: 0x00E8971C File Offset: 0x00E8791C
		private void RefreshNeedCorrectionOutside()
		{
			CharacterActorComponent characterActorComponent = this.HeadStateData.ActorComponent as CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.HalfHeight > this.HeadStateData.CommonParam.OutMonsterHalfHeight)
			{
				this.NeedCorrectionOutside = true;
			}
		}

		// Token: 0x0603C932 RID: 248114 RVA: 0x00E8975C File Offset: 0x00E8795C
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
					if (this.CurrentBarPercent - item < this.HitLargePercent)
					{
						this.PlayTweenAnim(19);
					}
					else
					{
						this.PlayTweenAnim(20);
					}
				}
				this.PlayBarAnimation(item);
			}
			else
			{
				this.StopBarLerpAnimation();
			}
			this.RefreshHpWeaknessPercent();
		}

		// Token: 0x0603C933 RID: 248115 RVA: 0x00E897CD File Offset: 0x00E879CD
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603C934 RID: 248116 RVA: 0x00E897D6 File Offset: 0x00E879D6
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603C935 RID: 248117 RVA: 0x00E897EB File Offset: 0x00E879EB
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603C936 RID: 248118 RVA: 0x00E897F4 File Offset: 0x00E879F4
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
			if (this.HpFlickerVisible)
			{
				base.GetSprite(15).SetFillAmount(percent);
			}
		}

		// Token: 0x0603C937 RID: 248119 RVA: 0x00E8981C File Offset: 0x00E87A1C
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x0603C938 RID: 248120 RVA: 0x00E89878 File Offset: 0x00E87A78
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

		// Token: 0x0603C939 RID: 248121 RVA: 0x00E898AB File Offset: 0x00E87AAB
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603C93A RID: 248122 RVA: 0x00E898B4 File Offset: 0x00E87AB4
		protected override void OnHardnessHideChanged(bool bTagExists)
		{
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x0603C93B RID: 248123 RVA: 0x00E898C2 File Offset: 0x00E87AC2
		protected override void OnHardnessAttributeChanged()
		{
			base.OnHardnessAttributeChanged();
			this.RefreshRage();
		}

		// Token: 0x0603C93C RID: 248124 RVA: 0x00E898D0 File Offset: 0x00E87AD0
		protected override void OnHardnessChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (attributeId != this.HardnessAttributeId && attributeId != this.MaxHardnessAttributeId)
			{
				return;
			}
			this.RefreshRage();
		}

		// Token: 0x0603C93D RID: 248125 RVA: 0x00E898EC File Offset: 0x00E87AEC
		protected override void VulnerabilityActivated(bool bTagExists)
		{
			this.HpFlickerVisible = bTagExists;
			UUISprite sprite = base.GetSprite(15);
			sprite.SetUIActive(bTagExists);
			if (this.HpFlickerVisible)
			{
				float item = base.GetHpAndShieldPercent().Item1;
				sprite.SetFillAmount(item);
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlaySequencePurely("Flicker", false, false, null, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.StopSequenceByKey("Flicker", false, false);
				return;
			}
		}

		// Token: 0x0603C93E RID: 248126 RVA: 0x00E89965 File Offset: 0x00E87B65
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C93F RID: 248127 RVA: 0x00E8996D File Offset: 0x00E87B6D
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C940 RID: 248128 RVA: 0x00E89975 File Offset: 0x00E87B75
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603C941 RID: 248129 RVA: 0x00E8997D File Offset: 0x00E87B7D
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603C942 RID: 248130 RVA: 0x00E89988 File Offset: 0x00E87B88
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

		// Token: 0x0603C943 RID: 248131 RVA: 0x00E899EB File Offset: 0x00E87BEB
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x0603C944 RID: 248132 RVA: 0x00E899FC File Offset: 0x00E87BFC
		private void RefreshToughItemVisible()
		{
			bool flag = this.IsShowFallDownBar || this.IsShowRage;
			if (this.ToughItemVisible == flag)
			{
				return;
			}
			this.ToughItemVisible = flag;
			this.ToughVisibleMachine.SetVisible(flag, 250f);
			if (flag)
			{
				base.GetItem(8).SetAlpha(1f);
			}
		}

		// Token: 0x0603C945 RID: 248133 RVA: 0x00E89A51 File Offset: 0x00E87C51
		private void OnToughRealVisibleChanged(bool visible)
		{
			base.GetItem(8).SetUIActive(visible);
		}

		// Token: 0x0603C946 RID: 248134 RVA: 0x00E89A60 File Offset: 0x00E87C60
		private void OnPlayToughVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.PlayTweenAnim(21);
				return;
			}
			this.PlayTweenAnim(24);
		}

		// Token: 0x0603C947 RID: 248135 RVA: 0x00E89A76 File Offset: 0x00E87C76
		private void OnStopToughVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.StopTweenAnim(21);
				return;
			}
			this.StopTweenAnim(24);
		}

		// Token: 0x0603C948 RID: 248136 RVA: 0x00E89A8C File Offset: 0x00E87C8C
		private void RefreshRage()
		{
			if (this.HardnessAttributeId != EAttributeType.Rage)
			{
				return;
			}
			float attributeCurrentValueById = this.HeadStateData.GetAttributeCurrentValueById(this.MaxHardnessAttributeId);
			float attributeCurrentValueById2 = this.HeadStateData.GetAttributeCurrentValueById(this.HardnessAttributeId);
			float num = attributeCurrentValueById2 / attributeCurrentValueById;
			base.GetSprite(10).SetFillAmount(num);
			this.RageMachine.GetHit(num, this.CurRage);
			this.CurRage = attributeCurrentValueById2 / attributeCurrentValueById;
			this.SetRageEffect(num);
		}

		// Token: 0x0603C949 RID: 248137 RVA: 0x00E89B00 File Offset: 0x00E87D00
		private void SetRageEffect(float percent)
		{
			if (percent < 1f)
			{
				this.IsMaxHardnessEffectVisible = false;
				return;
			}
			if (this.IsMaxHardnessEffectVisible)
			{
				return;
			}
			if (!this.IsShowRage)
			{
				this.RefreshRageEffectNextVisible = true;
				return;
			}
			this.RefreshRageEffectNextVisible = false;
			this.IsMaxHardnessEffectVisible = true;
			base.GetUiNiagara(6).ActivateSystem(true);
			this.StopRageEmptyAnimation();
		}

		// Token: 0x0603C94A RID: 248138 RVA: 0x00E89B58 File Offset: 0x00E87D58
		private void RefreshRageVisible()
		{
			this.RefreshIsShowRage();
			if (this.RageVisible == this.IsShowRage)
			{
				return;
			}
			this.RageVisible = this.IsShowRage;
			base.GetItem(5).SetUIActive(this.RageVisible);
			if (this.RageVisible && this.RefreshRageEffectNextVisible)
			{
				this.RefreshRage();
			}
		}

		// Token: 0x0603C94B RID: 248139 RVA: 0x00E89BB0 File Offset: 0x00E87DB0
		private void RefreshIsShowRage()
		{
			if (this.IsShowFallDownBar)
			{
				this.IsShowRage = false;
				return;
			}
			if (this.HardnessAttributeId != EAttributeType.Rage)
			{
				this.IsShowRage = false;
				return;
			}
			if (this.HeadStateData.ContainsTagById(GameplayTagDefine.EGameplayTagId["功能.功能制作.白条隐藏"]))
			{
				this.IsShowRage = false;
				return;
			}
			if (this.HeadStateData.GetAttributeCurrentValueById(this.MaxHardnessAttributeId) <= 0f)
			{
				this.IsShowRage = false;
				return;
			}
			this.IsShowRage = true;
		}

		// Token: 0x0603C94C RID: 248140 RVA: 0x00E89C30 File Offset: 0x00E87E30
		private void PlayRageLittleReduceAnimation(float curPercent, float targetPercent, bool isNewHit)
		{
			if (curPercent <= targetPercent)
			{
				this.StopRageLittleReduceAnimation();
				return;
			}
			UUISprite sprite = base.GetSprite(14);
			sprite.SetUIActive(true);
			sprite.SetStretchRight(this.RageWidth * (1f - curPercent));
			sprite.SetStretchLeft(this.RageWidth * targetPercent);
			if (isNewHit)
			{
				this.PlayTweenAnim(22);
			}
		}

		// Token: 0x0603C94D RID: 248141 RVA: 0x00E89C83 File Offset: 0x00E87E83
		private void StopRageLittleReduceAnimation()
		{
			base.GetSprite(14).SetUIActive(false);
		}

		// Token: 0x0603C94E RID: 248142 RVA: 0x00E89C93 File Offset: 0x00E87E93
		private void PlayRageLargeReduceAnimation(float curPercent, float targetPercent)
		{
			this.PlayTweenAnim(20);
		}

		// Token: 0x0603C94F RID: 248143 RVA: 0x00E89CA0 File Offset: 0x00E87EA0
		private void PlayRageEmptyAnimation()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(18);
			if (!uiNiagara.bIsUIActive)
			{
				uiNiagara.SetUIActive(true);
			}
			uiNiagara.ActivateSystem(true);
		}

		// Token: 0x0603C950 RID: 248144 RVA: 0x00E89CCC File Offset: 0x00E87ECC
		private void StopRageEmptyAnimation()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(18);
			if (uiNiagara.bIsUIActive)
			{
				uiNiagara.SetUIActive(false);
			}
		}

		// Token: 0x0603C951 RID: 248145 RVA: 0x00E89CF1 File Offset: 0x00E87EF1
		private void SetFallDownBar(bool state)
		{
			this.IsShowFallDownBar = state;
			this.RefreshFallDownBarVisible();
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x0603C952 RID: 248146 RVA: 0x00E89D0C File Offset: 0x00E87F0C
		private void RefreshFallDownBarVisible()
		{
			if (this.IsShowFallDownBar == this.FallDownBarVisible)
			{
				return;
			}
			this.FallDownBarVisible = this.IsShowFallDownBar;
			base.GetSprite(12).SetUIActive(this.FallDownBarVisible);
			if (this.FallDownBarVisible)
			{
				this.PlayTweenAnim(23);
				return;
			}
			this.StopTweenAnim(23);
		}

		// Token: 0x0603C953 RID: 248147 RVA: 0x00E89D60 File Offset: 0x00E87F60
		private void RefreshFallDownBar()
		{
			if (!this.IsShowFallDownBar)
			{
				return;
			}
			float attributeCurrentValueById = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.ParalysisTime);
			float attributeCurrentValueById2 = this.HeadStateData.GetAttributeCurrentValueById(EAttributeType.ParalysisTimeMax);
			float num = 1f - attributeCurrentValueById / attributeCurrentValueById2;
			if (num >= 0f && num <= 1f)
			{
				UUIItem sprite = base.GetSprite(12);
				if (this.FallDownBarWidth == 0f)
				{
					this.FallDownBarWidth = base.GetItem(11).GetWidth();
				}
				sprite.SetStretchRight(this.FallDownBarWidth * num);
				float num2 = 1f;
				if (num > 0.8f)
				{
					num2 = (1f - num) * 5f;
				}
				if (this.TailCount != num2)
				{
					this.TailCount = num2;
					base.GetUiNiagara(13).SetNiagaraVarFloat("Count", num2);
				}
			}
		}

		// Token: 0x0603C954 RID: 248148 RVA: 0x00E89E28 File Offset: 0x00E88028
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

		// Token: 0x0603C955 RID: 248149 RVA: 0x00E89E60 File Offset: 0x00E88060
		private void InitAllTweenAnim()
		{
			this.InitTweenAnim(19);
			this.InitTweenAnim(20);
			this.InitTweenAnim(21);
			this.InitTweenAnim(22);
			this.InitTweenAnim(23);
			this.InitTweenAnim(24);
			this.InitTweenAnim(30);
			this.InitTweenAnim(31);
		}

		// Token: 0x0603C956 RID: 248150 RVA: 0x00E89EB0 File Offset: 0x00E880B0
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>(tarray.Count);
			foreach (UActorComponent uactorComponent in tarray)
			{
				list.Add((ULGUIPlayTweenComponent)uactorComponent);
			}
			this.TweenAnimMap[componentType] = list;
		}

		// Token: 0x0603C957 RID: 248151 RVA: 0x00E89F30 File Offset: 0x00E88130
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

		// Token: 0x0603C958 RID: 248152 RVA: 0x00E89F8C File Offset: 0x00E8818C
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

		// Token: 0x0401F8BC RID: 129212
		private const float SCALE_TOLERATION = 0.003f;

		// Token: 0x0401F8BD RID: 129213
		private const float FALL_DOWN_DISAPPEAR_PERCENT = 0.8f;

		// Token: 0x0401F8BE RID: 129214
		private const float FALL_DOWN_DISAPPEAR_TAIL_COUNT_FACTOR = 5f;

		// Token: 0x0401F8BF RID: 129215
		private const float TOUGH_ANIM_TIME = 250f;

		// Token: 0x0401F8C0 RID: 129216
		private const EAttributeType fallDownAttributeId = EAttributeType.ParalysisTime;

		// Token: 0x0401F8C1 RID: 129217
		private const EAttributeType fallDownMaxAttributeId = EAttributeType.ParalysisTimeMax;

		// Token: 0x0401F8C2 RID: 129218
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F8C3 RID: 129219
		[Nullable(2)]
		private VisibleAnimMachine ToughVisibleMachine;

		// Token: 0x0401F8C4 RID: 129220
		private float HitLargePercent;

		// Token: 0x0401F8C5 RID: 129221
		private bool IsMaxHardnessEffectVisible;

		// Token: 0x0401F8C6 RID: 129222
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401F8C7 RID: 129223
		private readonly RageBufferStateMachine RageMachine = new RageBufferStateMachine();

		// Token: 0x0401F8C8 RID: 129224
		private float CurRage = 1f;

		// Token: 0x0401F8C9 RID: 129225
		private float HpParentWidth;

		// Token: 0x0401F8CA RID: 129226
		private float RageWidth = 1f;

		// Token: 0x0401F8CB RID: 129227
		private bool ToughItemVisible = true;

		// Token: 0x0401F8CC RID: 129228
		private bool IsShowFallDownBar;

		// Token: 0x0401F8CD RID: 129229
		private bool FallDownBarVisible;

		// Token: 0x0401F8CE RID: 129230
		private bool IsShowRage = true;

		// Token: 0x0401F8CF RID: 129231
		private bool RageVisible = true;

		// Token: 0x0401F8D0 RID: 129232
		private bool RefreshRageEffectNextVisible;

		// Token: 0x0401F8D1 RID: 129233
		private bool HpFlickerVisible;

		// Token: 0x0401F8D2 RID: 129234
		private float FallDownBarWidth;

		// Token: 0x0401F8D3 RID: 129235
		private float TailCount;

		// Token: 0x0401F8D4 RID: 129236
		[Nullable(2)]
		private UUIItem WeaknessContainer;

		// Token: 0x0401F8D5 RID: 129237
		[Nullable(2)]
		private HeadStateWeaknessItem WeaknessItem;

		// Token: 0x0401F8D6 RID: 129238
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200BFE6 RID: 49126
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04039E53 RID: 237139
			NormalHpBarSprite,
			// Token: 0x04039E54 RID: 237140
			BarBufferSprite,
			// Token: 0x04039E55 RID: 237141
			HpLight,
			// Token: 0x04039E56 RID: 237142
			ShieldBarSprite,
			// Token: 0x04039E57 RID: 237143
			LevelText,
			// Token: 0x04039E58 RID: 237144
			RageItem,
			// Token: 0x04039E59 RID: 237145
			MaxHardnessEffect,
			// Token: 0x04039E5A RID: 237146
			DetailItem,
			// Token: 0x04039E5B RID: 237147
			ToughItem,
			// Token: 0x04039E5C RID: 237148
			BuffHorizontalItem,
			// Token: 0x04039E5D RID: 237149
			RageBar,
			// Token: 0x04039E5E RID: 237150
			FallDownItem,
			// Token: 0x04039E5F RID: 237151
			FallDownBar,
			// Token: 0x04039E60 RID: 237152
			FallDownBarSign,
			// Token: 0x04039E61 RID: 237153
			RageReduceLittle,
			// Token: 0x04039E62 RID: 237154
			HpFlicker,
			// Token: 0x04039E63 RID: 237155
			RageReduceLargeCanvas,
			// Token: 0x04039E64 RID: 237156
			RageReduceLarge,
			// Token: 0x04039E65 RID: 237157
			RageEmpty,
			// Token: 0x04039E66 RID: 237158
			AnimSmallHit,
			// Token: 0x04039E67 RID: 237159
			AnimBigHit,
			// Token: 0x04039E68 RID: 237160
			AnimToughStart,
			// Token: 0x04039E69 RID: 237161
			AnimToughHit,
			// Token: 0x04039E6A RID: 237162
			AnimToughFlick,
			// Token: 0x04039E6B RID: 237163
			AnimToughClose,
			// Token: 0x04039E6C RID: 237164
			MoraleLevelItem,
			// Token: 0x04039E6D RID: 237165
			WeaknessContainer,
			// Token: 0x04039E6E RID: 237166
			HpWeaknessNode,
			// Token: 0x04039E6F RID: 237167
			HpWeaknessSprite1,
			// Token: 0x04039E70 RID: 237168
			HpWeaknessEffect,
			// Token: 0x04039E71 RID: 237169
			AniHpWeaknessFull,
			// Token: 0x04039E72 RID: 237170
			AniHpWeaknessBreak
		}
	}
}
