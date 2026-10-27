using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B62 RID: 7010
public class FloroRanchDungeonSuccessSettleView : UiViewBase
{
	// Token: 0x0600D00E RID: 53262 RVA: 0x002F70B7 File Offset: 0x002F52B7
	[NullableContext(1)]
	public FloroRanchDungeonSuccessSettleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600D00F RID: 53263 RVA: 0x002F70C0 File Offset: 0x002F52C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnEndlessModeButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnExitGameButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D010 RID: 53264 RVA: 0x002F71AC File Offset: 0x002F53AC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchDungeonSuccessSettleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchDungeonSuccessSettleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D011 RID: 53265 RVA: 0x002F71F0 File Offset: 0x002F53F0
	protected override void OnBeforeShow()
	{
		FloroRanchSettleDataResponse floroRanchSettleDataResponse = this.OpenParam as FloroRanchSettleDataResponse;
		FloroRanchPlaySettleData floroRanchPlaySettleData = (floroRanchSettleDataResponse != null) ? floroRanchSettleDataResponse.SettleData : null;
		if (floroRanchSettleDataResponse == null || floroRanchPlaySettleData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.BB, "弗洛洛牧场副本成功结算界面参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SettleItem.RefreshAsync(floroRanchPlaySettleData);
		base.GetButton(1).RootUIComp.Get().SetUIActive(floroRanchPlaySettleData.EnableUnlimitedMode);
		EventSystem.Instance.Emit<bool>(EEventName.OnFloroRanchSuccessSettleViewOpen, floroRanchPlaySettleData.EnableUnlimitedMode);
	}

	// Token: 0x0600D012 RID: 53266 RVA: 0x002F7280 File Offset: 0x002F5480
	private void OnEndlessModeButton()
	{
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return;
		}
		int id = currentActivityData.Id;
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		FloroRanchController.Instance.SendFloroRanchPlayUnlimitedModeRequest(id, subInstanceId, delegate(FloroRanchPlayUnlimitedModeResponse response)
		{
			if (response == null)
			{
				return;
			}
			base.CloseMe(delegate(bool success)
			{
				if (!success)
				{
					return;
				}
				FloroRanchGamePlayModel.Instance.ChangeState(EFloroRanchStageStateType.DailyInStage);
			});
		});
	}

	// Token: 0x0600D013 RID: 53267 RVA: 0x002F72C6 File Offset: 0x002F54C6
	private void OnExitGameButton()
	{
		FloroRanchGamePlayModel.Instance.ExitGame(true);
	}

	// Token: 0x04005F9A RID: 24474
	[Nullable(1)]
	private FloroRanchDungeonSettleItem SettleItem;

	// Token: 0x020080BB RID: 32955
	private class EComponent
	{
		// Token: 0x04029FCB RID: 171979
		public const int DungeonSettleItem = 0;

		// Token: 0x04029FCC RID: 171980
		public const int EndlessModeButton = 1;

		// Token: 0x04029FCD RID: 171981
		public const int ExitGameButton = 2;
	}
}
