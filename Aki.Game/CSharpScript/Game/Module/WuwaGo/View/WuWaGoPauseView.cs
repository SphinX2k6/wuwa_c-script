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
	// Token: 0x02004722 RID: 18210
	public class WuWaGoPauseView : UiViewBase
	{
		// Token: 0x0602F961 RID: 194913 RVA: 0x00B05959 File Offset: 0x00B03B59
		[NullableContext(1)]
		public WuWaGoPauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602F962 RID: 194914 RVA: 0x00B05964 File Offset: 0x00B03B64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
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

		// Token: 0x0602F963 RID: 194915 RVA: 0x00B05AB8 File Offset: 0x00B03CB8
		protected override UniTask OnBeforeStartAsync()
		{
			WuWaGoPauseView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WuWaGoPauseView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F964 RID: 194916 RVA: 0x00B05AFB File Offset: 0x00B03CFB
		protected override void OnAddEventListener()
		{
			this.TimeStopToken = new int?(WuWaGoTimeStop.Begin("PauseView"));
			WuWaGoController.Instance.SetMainControlInputAccepting(false);
		}

		// Token: 0x0602F965 RID: 194917 RVA: 0x00B05B1D File Offset: 0x00B03D1D
		protected override void OnRemoveEventListener()
		{
			if (this.TimeStopToken != null)
			{
				WuWaGoTimeStop.End(this.TimeStopToken.Value);
				this.TimeStopToken = null;
			}
			WuWaGoController.Instance.SetMainControlInputAccepting(true);
		}

		// Token: 0x0602F966 RID: 194918 RVA: 0x00B05B53 File Offset: 0x00B03D53
		private void OnMaskButtonClick()
		{
		}

		// Token: 0x0602F967 RID: 194919 RVA: 0x00B05B55 File Offset: 0x00B03D55
		private void OnReturnButtonClick()
		{
			this.CloseMeAsync().ContinueWith(delegate(bool _)
			{
				EventSystem.Instance.Emit(EEventName.OnWuWaGoUserRequestRollbackToSavePoint);
			}).Forget();
		}

		// Token: 0x0602F968 RID: 194920 RVA: 0x00B05B88 File Offset: 0x00B03D88
		private void OnExitButtonClick()
		{
			Log.Instance.Info(ELogModule.WuWaGo, ELogAuthor.YSQ, "玩家主动退出玩法", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CloseMeAsync().ContinueWith(delegate(bool _)
			{
				WuWaGoController.Instance.EndGameplay(false);
			}).Forget();
		}

		// Token: 0x0602F969 RID: 194921 RVA: 0x00B05BE3 File Offset: 0x00B03DE3
		private void OnGotoButtonClick()
		{
			UiManager.Instance.CloseView(EUiViewName.WuWaGoPauseView, null);
		}

		// Token: 0x04019B23 RID: 105251
		private int? TimeStopToken;

		// Token: 0x0200A970 RID: 43376
		private enum EViewComponent
		{
			// Token: 0x04033929 RID: 211241
			BtnMask,
			// Token: 0x0403392A RID: 211242
			BtnReturn,
			// Token: 0x0403392B RID: 211243
			BtnExit,
			// Token: 0x0403392C RID: 211244
			BtnGoto
		}
	}
}
