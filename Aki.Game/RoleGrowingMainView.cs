using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012A9 RID: 4777
public class RoleGrowingMainView : UiViewBase
{
	// Token: 0x06008318 RID: 33560 RVA: 0x001BE146 File Offset: 0x001BC346
	[NullableContext(1)]
	public RoleGrowingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008319 RID: 33561 RVA: 0x001BE15C File Offset: 0x001BC35C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600831A RID: 33562 RVA: 0x001BE228 File Offset: 0x001BC428
	protected override UniTask OnBeforeStartAsync()
	{
		RoleGrowingMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleGrowingMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600831B RID: 33563 RVA: 0x001BE26C File Offset: 0x001BC46C
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.OnDataUpdate();
	}

	// Token: 0x0600831C RID: 33564 RVA: 0x001BE2A2 File Offset: 0x001BC4A2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x0600831D RID: 33565 RVA: 0x001BE2C0 File Offset: 0x001BC4C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x0600831E RID: 33566 RVA: 0x001BE2E0 File Offset: 0x001BC4E0
	private void OnDataUpdate()
	{
		foreach (RoleGrowingStageItem roleGrowingStageItem in this.StageItems)
		{
			roleGrowingStageItem.Refresh(this.ActivityBaseData);
		}
	}

	// Token: 0x0600831F RID: 33567 RVA: 0x001BE338 File Offset: 0x001BC538
	private void OnClickStageDetail(int stageId)
	{
		if (this.ActivityBaseData.GetStageInfoById(stageId) != null)
		{
			UiManager.Instance.OpenView(EUiViewName.RoleGrowingTaskView, new object[]
			{
				this.ActivityBaseData,
				stageId
			}, null);
			return;
		}
		ActivityLongShanController.Instance.ShowUnlockTip(stageId);
	}

	// Token: 0x04003B15 RID: 15125
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003B16 RID: 15126
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003B17 RID: 15127
	[Nullable(1)]
	private readonly List<RoleGrowingStageItem> StageItems = new List<RoleGrowingStageItem>();

	// Token: 0x020078C5 RID: 30917
	private class EComponents
	{
		// Token: 0x04027C99 RID: 162969
		public const int Caption = 0;

		// Token: 0x04027C9A RID: 162970
		public const int Stage1 = 1;

		// Token: 0x04027C9B RID: 162971
		public const int Stage2 = 2;

		// Token: 0x04027C9C RID: 162972
		public const int Stage3 = 3;

		// Token: 0x04027C9D RID: 162973
		public const int Stage4 = 4;
	}
}
