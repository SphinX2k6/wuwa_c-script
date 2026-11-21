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
	// Token: 0x02004D25 RID: 19749
	[NullableContext(1)]
	[Nullable(0)]
	public class EliteMonsterHeadStateView : HeadStateViewBase
	{
		// Token: 0x06031875 RID: 202869 RVA: 0x00DD9478 File Offset: 0x00DD7678
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

		// Token: 0x06031876 RID: 202870 RVA: 0x00DD98E4 File Offset: 0x00DD7AE4
		protected override UniTask OnBeforeStartAsync()
		{
			EliteMonsterHeadStateView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EliteMonsterHeadStateView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031877 RID: 202871 RVA: 0x00DD9928 File Offset: 0x00DD7B28
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

		// Token: 0x06031878 RID: 202872 RVA: 0x00DD9A2C File Offset: 0x00DD7C2C
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

		// Token: 0x06031879 RID: 202873 RVA: 0x00DD9B20 File Offset: 0x00DD7D20
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

		// Token: 0x0603187A RID: 202874 RVA: 0x00DD9B84 File Offset: 0x00DD7D84
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

		// Token: 0x0603187B RID: 202875 RVA: 0x00DD9BCF File Offset: 0x00DD7DCF
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

		// Token: 0x0603187C RID: 202876 RVA: 0x00DD9C09 File Offset: 0x00DD7E09
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

		// Token: 0x0603187D RID: 202877 RVA: 0x00DD9C30 File Offset: 0x00DD7E30
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

		// Token: 0x0603187E RID: 202878 RVA: 0x00DD9C95 File Offset: 0x00DD7E95
		private void RefreshHpWeaknessPercent()
		{
			if (this.WeaknessItem != null && this.WeaknessItem.IsFullState(true))
			{
				base.GetSprite(28).SetFillAmount(this.CurrentBarPercent);
			}
		}

		// Token: 0x0603187F RID: 202879 RVA: 0x00DD9CC0 File Offset: 0x00DD7EC0
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

		// Token: 0x06031880 RID: 202880 RVA: 0x00DD9D2A File Offset: 0x00DD7F2A
		private void OnWeaknessStateChanged()
		{
			this.RefreshHpWeaknessPercent();
			this.RefreshHpWeaknessState(false);
		}

		// Token: 0x06031881 RID: 202881 RVA: 0x00DD9D39 File Offset: 0x00DD7F39
		protected override string GetResourceId()
		{
			return "UiItem_EliteMonsterState_Prefab";
		}

		// Token: 0x06031882 RID: 202882 RVA: 0x00DD9D40 File Offset: 0x00DD7F40
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

		// Token: 0x06031883 RID: 202883 RVA: 0x00DD9D9C File Offset: 0x00DD7F9C
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

		// Token: 0x06031884 RID: 202884 RVA: 0x00DD9DD4 File Offset: 0x00DD7FD4
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

		// Token: 0x06031885 RID: 202885 RVA: 0x00DD9E18 File Offset: 0x00DD8018
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

		// Token: 0x06031886 RID: 202886 RVA: 0x00DD9E58 File Offset: 0x00DD8058
		private void RefreshLevelTextVisible()
		{
			bool uiactive = base.IsLevelTextVisible();
			base.GetText(4).SetUIActive(uiactive);
		}

		// Token: 0x06031887 RID: 202887 RVA: 0x00DD9E7C File Offset: 0x00DD807C
		private void RefreshBuffVisible()
		{
			bool uiactive = base.IsBuffVisible();
			base.GetItem(9).SetUIActive(uiactive);
		}

		// Token: 0x06031888 RID: 202888 RVA: 0x00DD9E9E File Offset: 0x00DD809E
		private void TickBuffItem(float delta)
		{
			if (!base.IsBuffVisible())
			{
				return;
			}
			this.BuffItemContainer.Tick(delta);
		}

		// Token: 0x06031889 RID: 202889 RVA: 0x00DD9EB5 File Offset: 0x00DD80B5
		protected override void OnEliteStateChange()
		{
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x0603188A RID: 202890 RVA: 0x00DD9EC4 File Offset: 0x00DD80C4
		private void RefreshNeedCorrectionOutside()
		{
			CharacterActorComponent characterActorComponent = this.HeadStateData.ActorComponent as CharacterActorComponent;
			if (characterActorComponent != null && characterActorComponent.HalfHeight > this.HeadStateData.CommonParam.OutMonsterHalfHeight)
			{
				this.NeedCorrectionOutside = true;
			}
		}

		// Token: 0x0603188B RID: 202891 RVA: 0x00DD9F04 File Offset: 0x00DD8104
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

		// Token: 0x0603188C RID: 202892 RVA: 0x00DD9F75 File Offset: 0x00DD8175
		protected override void OnBeginBarAnimation(float hpPercent)
		{
			this.SetBarBufferPercent(hpPercent);
		}

		// Token: 0x0603188D RID: 202893 RVA: 0x00DD9F7E File Offset: 0x00DD817E
		protected override void StopBarLerpAnimation()
		{
			base.StopBarLerpAnimation();
			base.GetSprite(1).SetUIActive(false);
		}

		// Token: 0x0603188E RID: 202894 RVA: 0x00DD9F93 File Offset: 0x00DD8193
		protected override void OnLerpBarBufferPercent(float percent)
		{
			this.SetBarBufferPercent(percent);
		}

		// Token: 0x0603188F RID: 202895 RVA: 0x00DD9F9C File Offset: 0x00DD819C
		private void SetHpBarPercent(float percent)
		{
			base.GetSprite(0).SetFillAmount(percent);
			if (this.HpFlickerVisible)
			{
				base.GetSprite(15).SetFillAmount(percent);
			}
		}

		// Token: 0x06031890 RID: 202896 RVA: 0x00DD9FC4 File Offset: 0x00DD81C4
		private void SetBarBufferPercent(float percent)
		{
			UUISprite sprite = base.GetSprite(1);
			sprite.SetFillAmount(percent);
			sprite.SetUIActive(true);
			UUISprite sprite2 = base.GetSprite(2);
			sprite2.SetStretchLeft(this.HpParentWidth * this.CurrentBarPercent - 2f);
			sprite2.SetStretchRight(this.HpParentWidth * (1f - percent) - 2f);
		}

		// Token: 0x06031891 RID: 202897 RVA: 0x00DDA020 File Offset: 0x00DD8220
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

		// Token: 0x06031892 RID: 202898 RVA: 0x00DDA053 File Offset: 0x00DD8253
		protected override void OnShieldChanged(float shield)
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x06031893 RID: 202899 RVA: 0x00DDA05C File Offset: 0x00DD825C
		protected override void OnHardnessHideChanged(bool bTagExists)
		{
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x06031894 RID: 202900 RVA: 0x00DDA06A File Offset: 0x00DD826A
		protected override void OnHardnessAttributeChanged()
		{
			base.OnHardnessAttributeChanged();
			this.RefreshRage();
		}

		// Token: 0x06031895 RID: 202901 RVA: 0x00DDA078 File Offset: 0x00DD8278
		protected override void OnHardnessChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			if (attributeId != this.HardnessAttributeId && attributeId != this.MaxHardnessAttributeId)
			{
				return;
			}
			this.RefreshRage();
		}

		// Token: 0x06031896 RID: 202902 RVA: 0x00DDA094 File Offset: 0x00DD8294
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

		// Token: 0x06031897 RID: 202903 RVA: 0x00DDA10D File Offset: 0x00DD830D
		protected override void OnLevelChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshLevelText();
		}

		// Token: 0x06031898 RID: 202904 RVA: 0x00DDA115 File Offset: 0x00DD8315
		protected override void OnRoleLevelChange(int configId, int exp, int level)
		{
			this.RefreshLevelText();
		}

		// Token: 0x06031899 RID: 202905 RVA: 0x00DDA11D File Offset: 0x00DD831D
		protected override void OnChangeTeam()
		{
			this.RefreshLevelText();
		}

		// Token: 0x0603189A RID: 202906 RVA: 0x00DDA125 File Offset: 0x00DD8325
		protected override void OnHealthChanged()
		{
			this.RefreshHpAndShield(true);
		}

		// Token: 0x0603189B RID: 202907 RVA: 0x00DDA130 File Offset: 0x00DD8330
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

		// Token: 0x0603189C RID: 202908 RVA: 0x00DDA193 File Offset: 0x00DD8393
		protected override void RefreshOnCampChanged()
		{
			this.RefreshLevelText();
			this.RefreshHpColor();
		}

		// Token: 0x0603189D RID: 202909 RVA: 0x00DDA1A4 File Offset: 0x00DD83A4
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

		// Token: 0x0603189E RID: 202910 RVA: 0x00DDA1F9 File Offset: 0x00DD83F9
		private void OnToughRealVisibleChanged(bool visible)
		{
			base.GetItem(8).SetUIActive(visible);
		}

		// Token: 0x0603189F RID: 202911 RVA: 0x00DDA208 File Offset: 0x00DD8408
		private void OnPlayToughVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.PlayTweenAnim(21);
				return;
			}
			this.PlayTweenAnim(24);
		}

		// Token: 0x060318A0 RID: 202912 RVA: 0x00DDA21E File Offset: 0x00DD841E
		private void OnStopToughVisibleAnim(bool visible)
		{
			if (visible)
			{
				this.StopTweenAnim(21);
				return;
			}
			this.StopTweenAnim(24);
		}

		// Token: 0x060318A1 RID: 202913 RVA: 0x00DDA234 File Offset: 0x00DD8434
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

		// Token: 0x060318A2 RID: 202914 RVA: 0x00DDA2A8 File Offset: 0x00DD84A8
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

		// Token: 0x060318A3 RID: 202915 RVA: 0x00DDA300 File Offset: 0x00DD8500
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

		// Token: 0x060318A4 RID: 202916 RVA: 0x00DDA358 File Offset: 0x00DD8558
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

		// Token: 0x060318A5 RID: 202917 RVA: 0x00DDA3D8 File Offset: 0x00DD85D8
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

		// Token: 0x060318A6 RID: 202918 RVA: 0x00DDA42B File Offset: 0x00DD862B
		private void StopRageLittleReduceAnimation()
		{
			base.GetSprite(14).SetUIActive(false);
		}

		// Token: 0x060318A7 RID: 202919 RVA: 0x00DDA43B File Offset: 0x00DD863B
		private void PlayRageLargeReduceAnimation(float curPercent, float targetPercent)
		{
			this.PlayTweenAnim(20);
		}

		// Token: 0x060318A8 RID: 202920 RVA: 0x00DDA448 File Offset: 0x00DD8648
		private void PlayRageEmptyAnimation()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(18);
			if (!uiNiagara.bIsUIActive)
			{
				uiNiagara.SetUIActive(true);
			}
			uiNiagara.ActivateSystem(true);
		}

		// Token: 0x060318A9 RID: 202921 RVA: 0x00DDA474 File Offset: 0x00DD8674
		private void StopRageEmptyAnimation()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(18);
			if (uiNiagara.bIsUIActive)
			{
				uiNiagara.SetUIActive(false);
			}
		}

		// Token: 0x060318AA RID: 202922 RVA: 0x00DDA499 File Offset: 0x00DD8699
		private void SetFallDownBar(bool state)
		{
			this.IsShowFallDownBar = state;
			this.RefreshFallDownBarVisible();
			this.RefreshRageVisible();
			this.RefreshToughItemVisible();
		}

		// Token: 0x060318AB RID: 202923 RVA: 0x00DDA4B4 File Offset: 0x00DD86B4
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

		// Token: 0x060318AC RID: 202924 RVA: 0x00DDA508 File Offset: 0x00DD8708
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

		// Token: 0x060318AD RID: 202925 RVA: 0x00DDA5D0 File Offset: 0x00DD87D0
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

		// Token: 0x060318AE RID: 202926 RVA: 0x00DDA608 File Offset: 0x00DD8808
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

		// Token: 0x060318AF RID: 202927 RVA: 0x00DDA658 File Offset: 0x00DD8858
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

		// Token: 0x060318B0 RID: 202928 RVA: 0x00DDA6E0 File Offset: 0x00DD88E0
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

		// Token: 0x060318B1 RID: 202929 RVA: 0x00DDA73C File Offset: 0x00DD893C
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

		// Token: 0x0401A375 RID: 107381
		private const float SCALE_TOLERATION = 0.003f;

		// Token: 0x0401A376 RID: 107382
		private const float FALL_DOWN_DISAPPEAR_PERCENT = 0.8f;

		// Token: 0x0401A377 RID: 107383
		private const float FALL_DOWN_DISAPPEAR_TAIL_COUNT_FACTOR = 5f;

		// Token: 0x0401A378 RID: 107384
		private const float TOUGH_ANIM_TIME = 250f;

		// Token: 0x0401A379 RID: 107385
		private const EAttributeType fallDownAttributeId = EAttributeType.ParalysisTime;

		// Token: 0x0401A37A RID: 107386
		private const EAttributeType fallDownMaxAttributeId = EAttributeType.ParalysisTimeMax;

		// Token: 0x0401A37B RID: 107387
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401A37C RID: 107388
		[Nullable(2)]
		private VisibleAnimMachine ToughVisibleMachine;

		// Token: 0x0401A37D RID: 107389
		private float HitLargePercent;

		// Token: 0x0401A37E RID: 107390
		private bool IsMaxHardnessEffectVisible;

		// Token: 0x0401A37F RID: 107391
		private readonly BuffItemContainer BuffItemContainer = new BuffItemContainer();

		// Token: 0x0401A380 RID: 107392
		private readonly RageBufferStateMachine RageMachine = new RageBufferStateMachine();

		// Token: 0x0401A381 RID: 107393
		private float CurRage = 1f;

		// Token: 0x0401A382 RID: 107394
		private float HpParentWidth;

		// Token: 0x0401A383 RID: 107395
		private float RageWidth = 1f;

		// Token: 0x0401A384 RID: 107396
		private bool ToughItemVisible = true;

		// Token: 0x0401A385 RID: 107397
		private bool IsShowFallDownBar;

		// Token: 0x0401A386 RID: 107398
		private bool FallDownBarVisible;

		// Token: 0x0401A387 RID: 107399
		private bool IsShowRage = true;

		// Token: 0x0401A388 RID: 107400
		private bool RageVisible = true;

		// Token: 0x0401A389 RID: 107401
		private bool RefreshRageEffectNextVisible;

		// Token: 0x0401A38A RID: 107402
		private bool HpFlickerVisible;

		// Token: 0x0401A38B RID: 107403
		private float FallDownBarWidth;

		// Token: 0x0401A38C RID: 107404
		private float TailCount;

		// Token: 0x0401A38D RID: 107405
		[Nullable(2)]
		private UUIItem WeaknessContainer;

		// Token: 0x0401A38E RID: 107406
		[Nullable(2)]
		private HeadStateWeaknessItem WeaknessItem;

		// Token: 0x0401A38F RID: 107407
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0200A9EC RID: 43500
		[NullableContext(0)]
		private enum EChildComponentType
		{
			// Token: 0x04034815 RID: 215061
			NormalHpBarSprite,
			// Token: 0x04034816 RID: 215062
			BarBufferSprite,
			// Token: 0x04034817 RID: 215063
			HpLight,
			// Token: 0x04034818 RID: 215064
			ShieldBarSprite,
			// Token: 0x04034819 RID: 215065
			LevelText,
			// Token: 0x0403481A RID: 215066
			RageItem,
			// Token: 0x0403481B RID: 215067
			MaxHardnessEffect,
			// Token: 0x0403481C RID: 215068
			DetailItem,
			// Token: 0x0403481D RID: 215069
			ToughItem,
			// Token: 0x0403481E RID: 215070
			BuffHorizontalItem,
			// Token: 0x0403481F RID: 215071
			RageBar,
			// Token: 0x04034820 RID: 215072
			FallDownItem,
			// Token: 0x04034821 RID: 215073
			FallDownBar,
			// Token: 0x04034822 RID: 215074
			FallDownBarSign,
			// Token: 0x04034823 RID: 215075
			RageReduceLittle,
			// Token: 0x04034824 RID: 215076
			HpFlicker,
			// Token: 0x04034825 RID: 215077
			RageReduceLargeCanvas,
			// Token: 0x04034826 RID: 215078
			RageReduceLarge,
			// Token: 0x04034827 RID: 215079
			RageEmpty,
			// Token: 0x04034828 RID: 215080
			AnimSmallHit,
			// Token: 0x04034829 RID: 215081
			AnimBigHit,
			// Token: 0x0403482A RID: 215082
			AnimToughStart,
			// Token: 0x0403482B RID: 215083
			AnimToughHit,
			// Token: 0x0403482C RID: 215084
			AnimToughFlick,
			// Token: 0x0403482D RID: 215085
			AnimToughClose,
			// Token: 0x0403482E RID: 215086
			MoraleLevelItem,
			// Token: 0x0403482F RID: 215087
			WeaknessContainer,
			// Token: 0x04034830 RID: 215088
			HpWeaknessNode,
			// Token: 0x04034831 RID: 215089
			HpWeaknessSprite1,
			// Token: 0x04034832 RID: 215090
			HpWeaknessEffect,
			// Token: 0x04034833 RID: 215091
			AniHpWeaknessFull,
			// Token: 0x04034834 RID: 215092
			AniHpWeaknessBreak
		}
	}
}
