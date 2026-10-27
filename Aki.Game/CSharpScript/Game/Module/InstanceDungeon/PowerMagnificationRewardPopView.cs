using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02005889 RID: 22665
	[NullableContext(2)]
	[Nullable(0)]
	public class PowerMagnificationRewardPopView : UiViewBase
	{
		// Token: 0x06039ADD RID: 236253 RVA: 0x00DB5724 File Offset: 0x00DB3924
		[NullableContext(1)]
		public PowerMagnificationRewardPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039ADE RID: 236254 RVA: 0x00DB5730 File Offset: 0x00DB3930
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnHelpButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039ADF RID: 236255 RVA: 0x00DB587C File Offset: 0x00DB3A7C
		protected override UniTask OnBeforeStartAsync()
		{
			PowerMagnificationRewardPopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PowerMagnificationRewardPopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039AE0 RID: 236256 RVA: 0x00DB58BF File Offset: 0x00DB3ABF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		}

		// Token: 0x06039AE1 RID: 236257 RVA: 0x00DB58DD File Offset: 0x00DB3ADD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		}

		// Token: 0x06039AE2 RID: 236258 RVA: 0x00DB58FC File Offset: 0x00DB3AFC
		protected override void OnBeforeShow()
		{
			PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
			if (overPowerCurrencyItem != null)
			{
				UUIItem originalItem = overPowerCurrencyItem.GetOriginalItem();
				if (originalItem != null)
				{
					IUiPopFrameInterface childPopView = this.ChildPopView;
					UUIItem inParent;
					if (childPopView == null)
					{
						inParent = null;
					}
					else
					{
						CommonPopViewBase popItem = childPopView.PopItem;
						inParent = ((popItem != null) ? popItem.GetCostParent() : null);
					}
					originalItem.SetUIParent(inParent, false);
				}
			}
			PowerCurrencyItem powerCurrencyItem = this.PowerCurrencyItem;
			if (powerCurrencyItem != null)
			{
				UUIItem originalItem2 = powerCurrencyItem.GetOriginalItem();
				if (originalItem2 != null)
				{
					IUiPopFrameInterface childPopView2 = this.ChildPopView;
					UUIItem inParent2;
					if (childPopView2 == null)
					{
						inParent2 = null;
					}
					else
					{
						CommonPopViewBase popItem2 = childPopView2.PopItem;
						inParent2 = ((popItem2 != null) ? popItem2.GetCostParent() : null);
					}
					originalItem2.SetUIParent(inParent2, false);
				}
			}
			this.PowerCurrencyItem.ShowWithoutText(5);
			PowerCurrencyItem powerCurrencyItem2 = this.PowerCurrencyItem;
			if (powerCurrencyItem2 == null)
			{
				return;
			}
			powerCurrencyItem2.SetButtonFunction(delegate(int _)
			{
				PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
			});
		}

		// Token: 0x06039AE3 RID: 236259 RVA: 0x00DB59BA File Offset: 0x00DB3BBA
		private void OnPowerChange()
		{
			PowerRewardButtonItem singleButtonItem = this.SingleButtonItem;
			if (singleButtonItem != null)
			{
				singleButtonItem.RefreshPowerState();
			}
			PowerRewardButtonItem doubleButtonItem = this.DoubleButtonItem;
			if (doubleButtonItem == null)
			{
				return;
			}
			doubleButtonItem.RefreshPowerState();
		}

		// Token: 0x06039AE4 RID: 236260 RVA: 0x00DB59DD File Offset: 0x00DB3BDD
		private void OnHelpButtonClick()
		{
			HelpController.Instance.OpenHelpById(128);
		}

		// Token: 0x06039AE5 RID: 236261 RVA: 0x00DB59F0 File Offset: 0x00DB3BF0
		private UniTask InitCurrency()
		{
			PowerMagnificationRewardPopView.<InitCurrency>d__15 <InitCurrency>d__;
			<InitCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurrency>d__.<>4__this = this;
			<InitCurrency>d__.<>1__state = -1;
			<InitCurrency>d__.<>t__builder.Start<PowerMagnificationRewardPopView.<InitCurrency>d__15>(ref <InitCurrency>d__);
			return <InitCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x06039AE6 RID: 236262 RVA: 0x00DB5A34 File Offset: 0x00DB3C34
		private bool RewardByCount(int count)
		{
			if (this.Data == null)
			{
				return false;
			}
			int value = count * this.Data.SinglePowerCost;
			if (!PowerModel.Instance.IsPowerEnough(new int?(value)))
			{
				string textById = TextConfig.Instance.GetTextById("ReceiveLevelPlayPowerNotEnough");
				ScrollingTipsController.Instance.ShowTipsByText(textById);
				PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, PowerModel.Instance.GetCurrentNeedPower(new int?(value)));
				return false;
			}
			this.Data.RewardCallBack(count);
			base.CloseMe(null);
			return true;
		}

		// Token: 0x06039AE7 RID: 236263 RVA: 0x00DB5ABC File Offset: 0x00DB3CBC
		protected override void OnBeforeDestroy()
		{
			PowerMagnificationRewardPopViewData data = this.Data;
			if (data != null && data.NeedResetLevelPlayModelRewardFlag.GetValueOrDefault())
			{
				LevelPlayModel.Instance.IsInReceiveReward = false;
			}
			PowerMagnificationRewardPopViewData data2 = this.Data;
			if (data2 == null)
			{
				return;
			}
			Action closeCallBack = data2.CloseCallBack;
			if (closeCallBack == null)
			{
				return;
			}
			closeCallBack();
		}

		// Token: 0x0401E233 RID: 123443
		private PowerMagnificationRewardPopViewData Data;

		// Token: 0x0401E234 RID: 123444
		private PowerCurrencyItem PowerCurrencyItem;

		// Token: 0x0401E235 RID: 123445
		private PowerCurrencyItem OverPowerCurrencyItem;

		// Token: 0x0401E236 RID: 123446
		private PowerRewardButtonItem SingleButtonItem;

		// Token: 0x0401E237 RID: 123447
		private PowerRewardButtonItem DoubleButtonItem;

		// Token: 0x0401E238 RID: 123448
		private const int POWER_MAGIFICATION_REWARD_HELPID = 128;

		// Token: 0x0200BAE5 RID: 47845
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04038793 RID: 231315
			public const int TitleText = 0;

			// Token: 0x04038794 RID: 231316
			public const int ContentText = 1;

			// Token: 0x04038795 RID: 231317
			public const int LeftButtonItem = 2;

			// Token: 0x04038796 RID: 231318
			public const int RightButtonItem = 3;

			// Token: 0x04038797 RID: 231319
			public const int HelpButton = 4;

			// Token: 0x04038798 RID: 231320
			public const int DoubleCountItem = 5;

			// Token: 0x04038799 RID: 231321
			public const int DoubleCountText = 6;
		}
	}
}
