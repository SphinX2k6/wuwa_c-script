using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WuwaGo.Controller;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.View
{
	// Token: 0x02003652 RID: 13906
	public class WuWaGoPauseView : UiViewBase
	{
		// Token: 0x06024127 RID: 147751 RVA: 0x00A35629 File Offset: 0x00A33829
		[NullableContext(1)]
		public WuWaGoPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06024128 RID: 147752 RVA: 0x00A35634 File Offset: 0x00A33834
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnMaskButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnReturnButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnExitButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnGotoButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06024129 RID: 147753 RVA: 0x00A357A8 File Offset: 0x00A339A8
		protected override UniTask OnBeforeStartAsync()
		{
			WuWaGoPauseView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WuWaGoPauseView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602412A RID: 147754 RVA: 0x00A357EB File Offset: 0x00A339EB
		protected override void OnAddEventListener()
		{
			this.TimeStopToken = new int?(WuWaGoTimeStop.Begin("PauseView"));
			WuWaGoController.Instance.SetMainControlInputAccepting(false);
		}

		// Token: 0x0602412B RID: 147755 RVA: 0x00A3580D File Offset: 0x00A33A0D
		protected override void OnRemoveEventListener()
		{
			if (this.TimeStopToken != null)
			{
				WuWaGoTimeStop.End(this.TimeStopToken.Value);
				this.TimeStopToken = null;
			}
			WuWaGoController.Instance.SetMainControlInputAccepting(true);
		}

		// Token: 0x0602412C RID: 147756 RVA: 0x00A35843 File Offset: 0x00A33A43
		private void OnMaskButtonClick()
		{
		}

		// Token: 0x0602412D RID: 147757 RVA: 0x00A35845 File Offset: 0x00A33A45
		private void OnReturnButtonClick()
		{
			this.CloseMeAsync().ContinueWith(delegate(bool _)
			{
				EventSystem.Instance.Emit(EEventName.OnWuWaGoUserRequestRollbackToSavePoint);
			}).Forget();
		}

		// Token: 0x0602412E RID: 147758 RVA: 0x00A35878 File Offset: 0x00A33A78
		private void OnExitButtonClick()
		{
			Log.Instance.Info(ELogModule.WuWaGo, ELogAuthor.YSQ, "玩家主动退出玩法", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CloseMeAsync().ContinueWith(delegate(bool _)
			{
				WuWaGoController.Instance.EndGameplay(false);
			}).Forget();
		}

		// Token: 0x0602412F RID: 147759 RVA: 0x00A358D3 File Offset: 0x00A33AD3
		private void OnGotoButtonClick()
		{
			UiManager.Instance.CloseView(EUiViewName.WuWaGoPauseView, null);
		}

		// Token: 0x040141D2 RID: 82386
		private int? TimeStopToken;

		// Token: 0x040141D3 RID: 82387
		[Nullable(2)]
		private WuWaGoPauseCaptionPanel CaptionPanel;

		// Token: 0x0200932A RID: 37674
		private enum EViewComponent
		{
			// Token: 0x0402E0B9 RID: 188601
			BtnMask,
			// Token: 0x0402E0BA RID: 188602
			BtnReturn,
			// Token: 0x0402E0BB RID: 188603
			BtnExit,
			// Token: 0x0402E0BC RID: 188604
			BtnGoto,
			// Token: 0x0402E0BD RID: 188605
			ItemCaption
		}
	}
}
