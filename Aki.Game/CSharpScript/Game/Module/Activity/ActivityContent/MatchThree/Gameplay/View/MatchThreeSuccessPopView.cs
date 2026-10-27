using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E5 RID: 25829
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSuccessPopView : UiViewBase
	{
		// Token: 0x06040D67 RID: 265575 RVA: 0x00FB4AF5 File Offset: 0x00FB2CF5
		[NullableContext(1)]
		public MatchThreeSuccessPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040D68 RID: 265576 RVA: 0x00FB4B00 File Offset: 0x00FB2D00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickExit));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRetry));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040D69 RID: 265577 RVA: 0x00FB4CB4 File Offset: 0x00FB2EB4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeSuccessPopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeSuccessPopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D6A RID: 265578 RVA: 0x00FB4CF8 File Offset: 0x00FB2EF8
		protected override void OnStart()
		{
			MatchThreeSuccessPopParams parameters = this.Parameters;
			bool flag = parameters != null && parameters.IsEndless;
			bool uiactive = this.RewardLayout != null && this.RewardLayout.GetDisplayGridNum() > 0;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(true);
				}
			}
			UUIButtonComponent button2 = base.GetButton(5);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag);
				}
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				bool uiactive2;
				if (flag)
				{
					MatchThreeSuccessPopParams parameters2 = this.Parameters;
					uiactive2 = (parameters2 != null && parameters2.IsNewRecord);
				}
				else
				{
					uiactive2 = false;
				}
				text.SetUIActive(uiactive2);
			}
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(uiactive);
			}
			LguiUtil instance = LguiUtil.Instance;
			UUIText text2 = base.GetText(2);
			string textStringId = EMatchThreeTextId.FinalScore.ToEnumString();
			MatchThreeSuccessPopParams parameters3 = this.Parameters;
			instance.TrySetLocalTextNew(text2, textStringId, new <>z__ReadOnlySingleElementList<object>((parameters3 != null) ? parameters3.Score : 0));
		}

		// Token: 0x06040D6B RID: 265579 RVA: 0x00FB4E17 File Offset: 0x00FB3017
		protected override void OnBeforeDestroy()
		{
			this.RewardLayout = null;
			this.Parameters = null;
		}

		// Token: 0x06040D6C RID: 265580 RVA: 0x00FB4E27 File Offset: 0x00FB3027
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06040D6D RID: 265581 RVA: 0x00FB4E2E File Offset: 0x00FB302E
		private void OnClickExit()
		{
			if (this.ClickInProgress)
			{
				return;
			}
			this.ClickInProgress = true;
			MatchThreeSuccessPopParams parameters = this.Parameters;
			this.PendingExitCallback = ((parameters != null) ? parameters.OnExit : null);
			base.CloseMe(new Action<bool>(this.OnExitCloseFinished));
		}

		// Token: 0x06040D6E RID: 265582 RVA: 0x00FB4E6A File Offset: 0x00FB306A
		private void OnExitCloseFinished(bool success)
		{
			if (!success)
			{
				this.ClickInProgress = false;
				return;
			}
			Action pendingExitCallback = this.PendingExitCallback;
			this.PendingExitCallback = null;
			if (pendingExitCallback == null)
			{
				return;
			}
			pendingExitCallback();
		}

		// Token: 0x06040D6F RID: 265583 RVA: 0x00FB4E8E File Offset: 0x00FB308E
		private void OnClickRetry()
		{
			if (!this.ClickInProgress)
			{
				MatchThreeSuccessPopParams parameters = this.Parameters;
				if (((parameters != null) ? parameters.OnPrepareRetry : null) != null)
				{
					this.ClickInProgress = true;
					this.RetryAsync().Forget();
					return;
				}
			}
		}

		// Token: 0x06040D70 RID: 265584 RVA: 0x00FB4EC0 File Offset: 0x00FB30C0
		private UniTask RetryAsync()
		{
			MatchThreeSuccessPopView.<RetryAsync>d__15 <RetryAsync>d__;
			<RetryAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RetryAsync>d__.<>4__this = this;
			<RetryAsync>d__.<>1__state = -1;
			<RetryAsync>d__.<>t__builder.Start<MatchThreeSuccessPopView.<RetryAsync>d__15>(ref <RetryAsync>d__);
			return <RetryAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D71 RID: 265585 RVA: 0x00FB4F03 File Offset: 0x00FB3103
		private void OnRetryCloseFinished(bool success)
		{
			if (!success)
			{
				this.PendingRetryCallback = null;
				this.ClickInProgress = false;
				return;
			}
			Action pendingRetryCallback = this.PendingRetryCallback;
			this.PendingRetryCallback = null;
			if (pendingRetryCallback == null)
			{
				return;
			}
			pendingRetryCallback();
		}

		// Token: 0x04021C77 RID: 138359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04021C78 RID: 138360
		private MatchThreeSuccessPopParams Parameters;

		// Token: 0x04021C79 RID: 138361
		private Action PendingExitCallback;

		// Token: 0x04021C7A RID: 138362
		private Action PendingRetryCallback;

		// Token: 0x04021C7B RID: 138363
		private bool ClickInProgress;

		// Token: 0x0200C724 RID: 50980
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403C29A RID: 246426
			PnlSuccess,
			// Token: 0x0403C29B RID: 246427
			PnlScore,
			// Token: 0x0403C29C RID: 246428
			TxtScore,
			// Token: 0x0403C29D RID: 246429
			TxtNewRecord,
			// Token: 0x0403C29E RID: 246430
			BtnExit,
			// Token: 0x0403C29F RID: 246431
			BtnRetry,
			// Token: 0x0403C2A0 RID: 246432
			PnlReward,
			// Token: 0x0403C2A1 RID: 246433
			PnlRewardLayout,
			// Token: 0x0403C2A2 RID: 246434
			RewardItemTemplate
		}
	}
}
