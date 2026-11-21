using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CommonH5
{
	// Token: 0x02005846 RID: 22598
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonH5SubView : ActivitySubViewBase
	{
		// Token: 0x06037B98 RID: 228248 RVA: 0x00F94078 File Offset: 0x00F92278
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037B99 RID: 228249 RVA: 0x00F940E4 File Offset: 0x00F922E4
		protected override UniTask OnBeforeStartAsync()
		{
			CommonH5SubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonH5SubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037B9A RID: 228250 RVA: 0x00F94128 File Offset: 0x00F92328
		protected override void OnBeforeShow()
		{
			this.RefreshRedDot();
			this.CommonInfoPanel.SetBtnText("Activity_Exploration_Go", Array.Empty<object>());
			this.UiSequencePlayer.PlaySequenceAsync("Start", new CustomPromise<bool>(), false, false, null).Forget();
		}

		// Token: 0x06037B9B RID: 228251 RVA: 0x00F94175 File Offset: 0x00F92375
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonH5ActivityRedDot, new Action(this.OnDataUpdate));
		}

		// Token: 0x06037B9C RID: 228252 RVA: 0x00F94193 File Offset: 0x00F92393
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonH5ActivityRedDot, new Action(this.OnDataUpdate));
		}

		// Token: 0x06037B9D RID: 228253 RVA: 0x00F941B1 File Offset: 0x00F923B1
		private void OnDataUpdate()
		{
			this.RefreshRedDot();
		}

		// Token: 0x06037B9E RID: 228254 RVA: 0x00F941BC File Offset: 0x00F923BC
		private void RefreshRedDot()
		{
			bool redPointShowState = (this.ActivityBaseData as CommonH5Data).RedPointShowState;
			this.CommonInfoPanel.SetFunctionRedDotVisible(redPointShowState);
		}

		// Token: 0x06037B9F RID: 228255 RVA: 0x00F941E6 File Offset: 0x00F923E6
		private void ClickCommonInfo(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				CommonH5Data activityData = this.ActivityBaseData as CommonH5Data;
				CommonH5Controller.Instance.HandleOnEnterClick(activityData);
			});
		}

		// Token: 0x06037BA0 RID: 228256 RVA: 0x00F94204 File Offset: 0x00F92404
		private bool ShowReceivedCallBack(TItem _)
		{
			return (this.ActivityBaseData as CommonH5Data).GetRewardClaimState();
		}

		// Token: 0x0401D691 RID: 120465
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401D692 RID: 120466
		private UiSequencePlayer UiSequencePlayer;
	}
}
