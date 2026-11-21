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
	// Token: 0x02004861 RID: 18529
	[NullableContext(2)]
	[Nullable(0)]
	public class PowerMagnificationRewardPopView : UiViewBase
	{
		// Token: 0x0602EA00 RID: 190976 RVA: 0x00D0463C File Offset: 0x00D0283C
		[NullableContext(1)]
		public PowerMagnificationRewardPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602EA01 RID: 190977 RVA: 0x00D04648 File Offset: 0x00D02848
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

		// Token: 0x0602EA02 RID: 190978 RVA: 0x00D04794 File Offset: 0x00D02994
		protected override UniTask OnBeforeStartAsync()
		{
			PowerMagnificationRewardPopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PowerMagnificationRewardPopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA03 RID: 190979 RVA: 0x00D047D7 File Offset: 0x00D029D7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		}

		// Token: 0x0602EA04 RID: 190980 RVA: 0x00D047F5 File Offset: 0x00D029F5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		}

		// Token: 0x0602EA05 RID: 190981 RVA: 0x00D04814 File Offset: 0x00D02A14
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

		// Token: 0x0602EA06 RID: 190982 RVA: 0x00D048D2 File Offset: 0x00D02AD2
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

		// Token: 0x0602EA07 RID: 190983 RVA: 0x00D048F5 File Offset: 0x00D02AF5
		private void OnHelpButtonClick()
		{
			HelpController.Instance.OpenHelpById(128);
		}

		// Token: 0x0602EA08 RID: 190984 RVA: 0x00D04908 File Offset: 0x00D02B08
		private UniTask InitCurrency()
		{
			PowerMagnificationRewardPopView.<InitCurrency>d__15 <InitCurrency>d__;
			<InitCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurrency>d__.<>4__this = this;
			<InitCurrency>d__.<>1__state = -1;
			<InitCurrency>d__.<>t__builder.Start<PowerMagnificationRewardPopView.<InitCurrency>d__15>(ref <InitCurrency>d__);
			return <InitCurrency>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA09 RID: 190985 RVA: 0x00D0494C File Offset: 0x00D02B4C
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

		// Token: 0x0602EA0A RID: 190986 RVA: 0x00D049D4 File Offset: 0x00D02BD4
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

		// Token: 0x04018CD0 RID: 101584
		private PowerMagnificationRewardPopViewData Data;

		// Token: 0x04018CD1 RID: 101585
		private PowerCurrencyItem PowerCurrencyItem;

		// Token: 0x04018CD2 RID: 101586
		private PowerCurrencyItem OverPowerCurrencyItem;

		// Token: 0x04018CD3 RID: 101587
		private PowerRewardButtonItem SingleButtonItem;

		// Token: 0x04018CD4 RID: 101588
		private PowerRewardButtonItem DoubleButtonItem;

		// Token: 0x04018CD5 RID: 101589
		private const int POWER_MAGIFICATION_REWARD_HELPID = 128;

		// Token: 0x0200A4FE RID: 42238
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04033194 RID: 209300
			public const int TitleText = 0;

			// Token: 0x04033195 RID: 209301
			public const int ContentText = 1;

			// Token: 0x04033196 RID: 209302
			public const int LeftButtonItem = 2;

			// Token: 0x04033197 RID: 209303
			public const int RightButtonItem = 3;

			// Token: 0x04033198 RID: 209304
			public const int HelpButton = 4;

			// Token: 0x04033199 RID: 209305
			public const int DoubleCountItem = 5;

			// Token: 0x0403319A RID: 209306
			public const int DoubleCountText = 6;
		}
	}
}
