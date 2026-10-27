using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E00 RID: 24064
	public class SpecialEnergyBarSuisui : SpecialEnergyBarBase
	{
		// Token: 0x0603D2EC RID: 250604 RVA: 0x00EBCB80 File Offset: 0x00EBAD80
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
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
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D2ED RID: 250605 RVA: 0x00EBCE03 File Offset: 0x00EBB003
		protected override void OnInitData()
		{
			this.EnhancedStateConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(111002);
		}

		// Token: 0x0603D2EE RID: 250606 RVA: 0x00EBCE20 File Offset: 0x00EBB020
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuisui.EnhancedStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnEnhancedStateTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuisui.UltStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnUltStateTagChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnEnhancedEnergyChanged));
		}

		// Token: 0x0603D2EF RID: 250607 RVA: 0x00EBCE75 File Offset: 0x00EBB075
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnEnhancedEnergyChanged));
		}

		// Token: 0x0603D2F0 RID: 250608 RVA: 0x00EBCE94 File Offset: 0x00EBB094
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuisui.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2F1 RID: 250609 RVA: 0x00EBCED8 File Offset: 0x00EBB0D8
		private UniTask InitBarItem()
		{
			SpecialEnergyBarSuisui.<InitBarItem>d__23 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<InitBarItem>d__23>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2F2 RID: 250610 RVA: 0x00EBCF1C File Offset: 0x00EBB11C
		private UniTask InitEnhancedStateBarItem()
		{
			SpecialEnergyBarSuisui.<InitEnhancedStateBarItem>d__24 <InitEnhancedStateBarItem>d__;
			<InitEnhancedStateBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEnhancedStateBarItem>d__.<>4__this = this;
			<InitEnhancedStateBarItem>d__.<>1__state = -1;
			<InitEnhancedStateBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<InitEnhancedStateBarItem>d__24>(ref <InitEnhancedStateBarItem>d__);
			return <InitEnhancedStateBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2F3 RID: 250611 RVA: 0x00EBCF60 File Offset: 0x00EBB160
		protected override void OnStart()
		{
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			base.InitTweenAnim(17);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			this.RefreshState(true);
		}

		// Token: 0x0603D2F4 RID: 250612 RVA: 0x00EBCFF6 File Offset: 0x00EBB1F6
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(17);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D2F5 RID: 250613 RVA: 0x00EBD006 File Offset: 0x00EBB206
		private void OnEnhancedStateTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarSuisui.EState.Enhanced : SpecialEnergyBarSuisui.EState.Normal, false);
		}

		// Token: 0x0603D2F6 RID: 250614 RVA: 0x00EBD016 File Offset: 0x00EBB216
		protected override void OnBarPercentChanged()
		{
			this.SetFullState(false);
		}

		// Token: 0x0603D2F7 RID: 250615 RVA: 0x00EBD01F File Offset: 0x00EBB21F
		private void OnEnhancedEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SetEnhancedEnergyState(this.CalcEnhancedEnergyState(newValue), false);
		}

		// Token: 0x0603D2F8 RID: 250616 RVA: 0x00EBD02F File Offset: 0x00EBB22F
		private void OnUltStateTagChanged(int tagId, bool tagExist)
		{
			this.SetUltState(tagExist, false);
		}

		// Token: 0x0603D2F9 RID: 250617 RVA: 0x00EBD03C File Offset: 0x00EBB23C
		private void RefreshState(bool isForced = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuisui.EnhancedStateTagId)) ? SpecialEnergyBarSuisui.EState.Enhanced : SpecialEnergyBarSuisui.EState.Normal, isForced);
		}

		// Token: 0x0603D2FA RID: 250618 RVA: 0x00EBD06F File Offset: 0x00EBB26F
		private void RefreshEnergy(bool isForced = false)
		{
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				this.RefreshEnhancedEnergyState(isForced);
				return;
			}
			this.SetFullState(isForced);
		}

		// Token: 0x0603D2FB RID: 250619 RVA: 0x00EBD08C File Offset: 0x00EBB28C
		private void RefreshEnhancedEnergyState(bool isForced = false)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float enhancedEnergy = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) : 0f;
			this.SetEnhancedEnergyState(this.CalcEnhancedEnergyState(enhancedEnergy), isForced);
		}

		// Token: 0x0603D2FC RID: 250620 RVA: 0x00EBD0C0 File Offset: 0x00EBB2C0
		private void RefreshUltState(bool isForced = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool isInUltState = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuisui.UltStateTagId);
			this.SetUltState(isInUltState, isForced);
		}

		// Token: 0x0603D2FD RID: 250621 RVA: 0x00EBD0F0 File Offset: 0x00EBB2F0
		private SpecialEnergyBarSuisui.EEnhancedEnergyState CalcEnhancedEnergyState(float enhancedEnergy)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max) : 0f;
			if (num <= 0f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird;
			}
			float num2 = enhancedEnergy / num;
			if (num2 >= 1f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.Full;
			}
			if (num2 >= 0.6666667f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.TwoThirdToFull;
			}
			if (num2 >= 0.33333334f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.OneThirdToTwoThird;
			}
			return SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird;
		}

		// Token: 0x0603D2FE RID: 250622 RVA: 0x00EBD144 File Offset: 0x00EBB344
		private void SetState(SpecialEnergyBarSuisui.EState state, bool isForced = false)
		{
			if (this.CurState == state && !isForced)
			{
				return;
			}
			this.CurState = state;
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				base.StopTweenAnim(5);
				base.PlayTweenAnim(4);
			}
			else
			{
				base.StopTweenAnim(4);
				base.PlayTweenAnim(5);
				this.PlayWarnAnim(false);
			}
			this.RefreshEnergy(true);
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				this.RefreshUltState(true);
			}
		}

		// Token: 0x0603D2FF RID: 250623 RVA: 0x00EBD1AC File Offset: 0x00EBB3AC
		private void SetFullState(bool isForced = false)
		{
			bool flag = this.PercentMachine.GetCurPercent() >= 1f;
			if (this.IsFull == flag && !isForced)
			{
				return;
			}
			this.IsFull = flag;
			if (flag)
			{
				base.StopTweenAnim(7);
				base.PlayTweenAnim(6);
				return;
			}
			base.StopTweenAnim(6);
			base.PlayTweenAnim(7);
		}

		// Token: 0x0603D300 RID: 250624 RVA: 0x00EBD204 File Offset: 0x00EBB404
		private void SetEnhancedEnergyState(SpecialEnergyBarSuisui.EEnhancedEnergyState state, bool isForced = false)
		{
			if (this.CurEnhancedEnergyState == state && !isForced)
			{
				return;
			}
			this.CurEnhancedEnergyState = state;
			switch (state)
			{
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird:
				base.PlayTweenAnim(8);
				return;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.OneThirdToTwoThird:
				base.PlayTweenAnim(9);
				if (!isForced)
				{
					base.PlayTweenAnim(12);
					return;
				}
				break;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.TwoThirdToFull:
				base.PlayTweenAnim(10);
				if (!isForced)
				{
					base.PlayTweenAnim(13);
					return;
				}
				break;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.Full:
				base.PlayTweenAnim(11);
				if (!isForced)
				{
					base.PlayTweenAnim(14);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0603D301 RID: 250625 RVA: 0x00EBD27F File Offset: 0x00EBB47F
		private void SetUltState(bool isInUltState, bool isForced = false)
		{
			if (this.IsInUltState == isInUltState && !isForced)
			{
				return;
			}
			this.IsInUltState = isInUltState;
			if (isInUltState)
			{
				base.StopTweenAnim(16);
				base.PlayTweenAnim(15);
				return;
			}
			base.StopTweenAnim(15);
			base.PlayTweenAnim(16);
		}

		// Token: 0x0603D302 RID: 250626 RVA: 0x00EBD2BC File Offset: 0x00EBB4BC
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			SpecialEnergyBarSlot enhancedStateBarItem = this.EnhancedStateBarItem;
			if (enhancedStateBarItem != null)
			{
				enhancedStateBarItem.Tick(delta);
			}
			if (this.CurState == SpecialEnergyBarSuisui.EState.Normal)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_63;
				}
			}
			this.RefreshBuff();
			IL_63:
			if (this.Buff != null)
			{
				this.PlayWarnAnim(this.Buff.GetRemainDuration() < this.EnhancedStateConfig.ExtraFloatParams[0]);
				return;
			}
			this.PlayWarnAnim(false);
		}

		// Token: 0x0603D303 RID: 250627 RVA: 0x00EBD360 File Offset: 0x00EBB560
		private void RefreshBuff()
		{
			if (this.EnhancedStateConfig != null && this.EnhancedStateConfig.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.EnhancedStateConfig.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603D304 RID: 250628 RVA: 0x00EBD3CC File Offset: 0x00EBB5CC
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(17);
				return;
			}
			base.StopTweenAnim(17);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x0401FE72 RID: 130674
		private const int EnhancedStateConfigId = 111002;

		// Token: 0x0401FE73 RID: 130675
		private const EAttributeType EnhancedEnergyAttrId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FE74 RID: 130676
		private const EAttributeType EnhancedEnergyMaxAttrId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FE75 RID: 130677
		[StaticVariableRuleIgnore]
		private static readonly int EnhancedStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.形态.强化"];

		// Token: 0x0401FE76 RID: 130678
		[StaticVariableRuleIgnore]
		private static readonly int UltStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.领域.领域生效中"];

		// Token: 0x0401FE77 RID: 130679
		[Nullable(2)]
		private SpecialEnergyBarInfo EnhancedStateConfig;

		// Token: 0x0401FE78 RID: 130680
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401FE79 RID: 130681
		[Nullable(2)]
		private SpecialEnergyBarSlot EnhancedStateBarItem;

		// Token: 0x0401FE7A RID: 130682
		private bool IsFull;

		// Token: 0x0401FE7B RID: 130683
		private bool IsInUltState;

		// Token: 0x0401FE7C RID: 130684
		private SpecialEnergyBarSuisui.EState CurState;

		// Token: 0x0401FE7D RID: 130685
		private SpecialEnergyBarSuisui.EEnhancedEnergyState CurEnhancedEnergyState;

		// Token: 0x0401FE7E RID: 130686
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401FE7F RID: 130687
		private int BuffHandle;

		// Token: 0x0401FE80 RID: 130688
		private bool IsPlayWarnAnim;

		// Token: 0x0200C152 RID: 49490
		private enum EChildType
		{
			// Token: 0x0403A65F RID: 239199
			PnlState01,
			// Token: 0x0403A660 RID: 239200
			BarSlotState01,
			// Token: 0x0403A661 RID: 239201
			PnlState02,
			// Token: 0x0403A662 RID: 239202
			BarSlotState02,
			// Token: 0x0403A663 RID: 239203
			AnimState01To02,
			// Token: 0x0403A664 RID: 239204
			AnimState02To01,
			// Token: 0x0403A665 RID: 239205
			AnimState01ToFull,
			// Token: 0x0403A666 RID: 239206
			AnimState01ToNotFull,
			// Token: 0x0403A667 RID: 239207
			AnimState2Zero,
			// Token: 0x0403A668 RID: 239208
			AnimState2OneThird,
			// Token: 0x0403A669 RID: 239209
			AnimState2TwoThird,
			// Token: 0x0403A66A RID: 239210
			AnimState2Full,
			// Token: 0x0403A66B RID: 239211
			AniState2ZeroToOneThird,
			// Token: 0x0403A66C RID: 239212
			AniState2OneToTwoThird,
			// Token: 0x0403A66D RID: 239213
			AniState2TwoThirdToFull,
			// Token: 0x0403A66E RID: 239214
			AnimState02R,
			// Token: 0x0403A66F RID: 239215
			AnimState02NotR,
			// Token: 0x0403A670 RID: 239216
			AnimWarning
		}

		// Token: 0x0200C153 RID: 49491
		private enum EState
		{
			// Token: 0x0403A672 RID: 239218
			Normal,
			// Token: 0x0403A673 RID: 239219
			Enhanced
		}

		// Token: 0x0200C154 RID: 49492
		private enum EEnhancedEnergyState
		{
			// Token: 0x0403A675 RID: 239221
			ZeroToOneThird,
			// Token: 0x0403A676 RID: 239222
			OneThirdToTwoThird,
			// Token: 0x0403A677 RID: 239223
			TwoThirdToFull,
			// Token: 0x0403A678 RID: 239224
			Full
		}
	}
}
