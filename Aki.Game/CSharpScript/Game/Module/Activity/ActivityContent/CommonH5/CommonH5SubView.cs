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
	// Token: 0x020068F6 RID: 26870
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonH5SubView : ActivitySubViewBase
	{
		// Token: 0x06043040 RID: 274496 RVA: 0x01052A50 File Offset: 0x01050C50
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

		// Token: 0x06043041 RID: 274497 RVA: 0x01052ABC File Offset: 0x01050CBC
		protected override UniTask OnBeforeStartAsync()
		{
			CommonH5SubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonH5SubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043042 RID: 274498 RVA: 0x01052B00 File Offset: 0x01050D00
		protected override void OnBeforeShow()
		{
			this.RefreshRedDot();
			this.CommonInfoPanel.SetBtnText("Activity_Exploration_Go", Array.Empty<object>());
			this.UiSequencePlayer.PlaySequenceAsync("Start", new CustomPromise<bool>(), false, false, null).Forget();
		}

		// Token: 0x06043043 RID: 274499 RVA: 0x01052B4D File Offset: 0x01050D4D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RefreshCommonH5ActivityRedDot, new Action(this.OnDataUpdate));
		}

		// Token: 0x06043044 RID: 274500 RVA: 0x01052B6B File Offset: 0x01050D6B
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonH5ActivityRedDot, new Action(this.OnDataUpdate));
		}

		// Token: 0x06043045 RID: 274501 RVA: 0x01052B89 File Offset: 0x01050D89
		private void OnDataUpdate()
		{
			this.RefreshRedDot();
		}

		// Token: 0x06043046 RID: 274502 RVA: 0x01052B94 File Offset: 0x01050D94
		private void RefreshRedDot()
		{
			bool redPointShowState = (this.ActivityBaseData as CommonH5Data).RedPointShowState;
			this.CommonInfoPanel.SetFunctionRedDotVisible(redPointShowState);
		}

		// Token: 0x06043047 RID: 274503 RVA: 0x01052BBE File Offset: 0x01050DBE
		private void ClickCommonInfo(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				CommonH5Data activityData = this.ActivityBaseData as CommonH5Data;
				CommonH5Controller.Instance.HandleOnEnterClick(activityData);
			});
		}

		// Token: 0x06043048 RID: 274504 RVA: 0x01052BDC File Offset: 0x01050DDC
		private bool ShowReceivedCallBack(TItem _)
		{
			return (this.ActivityBaseData as CommonH5Data).GetRewardClaimState();
		}

		// Token: 0x04022E35 RID: 142901
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x04022E36 RID: 142902
		private UiSequencePlayer UiSequencePlayer;
	}
}
