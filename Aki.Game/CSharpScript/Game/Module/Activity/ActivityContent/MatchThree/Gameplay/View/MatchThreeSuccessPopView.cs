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
	// Token: 0x02005463 RID: 21603
	[NullableContext(2)]
	[Nullable(0)]
	public class MatchThreeSuccessPopView : UiViewBase
	{
		// Token: 0x06035A2B RID: 219691 RVA: 0x00EFBB25 File Offset: 0x00EF9D25
		[NullableContext(1)]
		public MatchThreeSuccessPopView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035A2C RID: 219692 RVA: 0x00EFBB30 File Offset: 0x00EF9D30
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

		// Token: 0x06035A2D RID: 219693 RVA: 0x00EFBCE4 File Offset: 0x00EF9EE4
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeSuccessPopView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeSuccessPopView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035A2E RID: 219694 RVA: 0x00EFBD28 File Offset: 0x00EF9F28
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

		// Token: 0x06035A2F RID: 219695 RVA: 0x00EFBE47 File Offset: 0x00EFA047
		protected override void OnBeforeDestroy()
		{
			this.RewardLayout = null;
			this.Parameters = null;
		}

		// Token: 0x06035A30 RID: 219696 RVA: 0x00EFBE57 File Offset: 0x00EFA057
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06035A31 RID: 219697 RVA: 0x00EFBE5E File Offset: 0x00EFA05E
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

		// Token: 0x06035A32 RID: 219698 RVA: 0x00EFBE9A File Offset: 0x00EFA09A
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

		// Token: 0x06035A33 RID: 219699 RVA: 0x00EFBEBE File Offset: 0x00EFA0BE
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

		// Token: 0x06035A34 RID: 219700 RVA: 0x00EFBEF0 File Offset: 0x00EFA0F0
		private UniTask RetryAsync()
		{
			MatchThreeSuccessPopView.<RetryAsync>d__15 <RetryAsync>d__;
			<RetryAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RetryAsync>d__.<>4__this = this;
			<RetryAsync>d__.<>1__state = -1;
			<RetryAsync>d__.<>t__builder.Start<MatchThreeSuccessPopView.<RetryAsync>d__15>(ref <RetryAsync>d__);
			return <RetryAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035A35 RID: 219701 RVA: 0x00EFBF33 File Offset: 0x00EFA133
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

		// Token: 0x0401C5A8 RID: 116136
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401C5A9 RID: 116137
		private MatchThreeSuccessPopParams Parameters;

		// Token: 0x0401C5AA RID: 116138
		private Action PendingExitCallback;

		// Token: 0x0401C5AB RID: 116139
		private Action PendingRetryCallback;

		// Token: 0x0401C5AC RID: 116140
		private bool ClickInProgress;

		// Token: 0x0200B10A RID: 45322
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036BF5 RID: 224245
			PnlSuccess,
			// Token: 0x04036BF6 RID: 224246
			PnlScore,
			// Token: 0x04036BF7 RID: 224247
			TxtScore,
			// Token: 0x04036BF8 RID: 224248
			TxtNewRecord,
			// Token: 0x04036BF9 RID: 224249
			BtnExit,
			// Token: 0x04036BFA RID: 224250
			BtnRetry,
			// Token: 0x04036BFB RID: 224251
			PnlReward,
			// Token: 0x04036BFC RID: 224252
			PnlRewardLayout,
			// Token: 0x04036BFD RID: 224253
			RewardItemTemplate
		}
	}
}
