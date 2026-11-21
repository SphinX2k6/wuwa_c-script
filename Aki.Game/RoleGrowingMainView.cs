using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200075D RID: 1885
public class RoleGrowingMainView : UiViewBase
{
	// Token: 0x060056AF RID: 22191 RVA: 0x001C6ED6 File Offset: 0x001C50D6
	[NullableContext(1)]
	public RoleGrowingMainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060056B0 RID: 22192 RVA: 0x001C6EEC File Offset: 0x001C50EC
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

	// Token: 0x060056B1 RID: 22193 RVA: 0x001C6FB8 File Offset: 0x001C51B8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleGrowingMainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleGrowingMainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060056B2 RID: 22194 RVA: 0x001C6FFC File Offset: 0x001C51FC
	protected override void OnBeforeShow()
	{
		ActivityController.Instance.CheckIsActivityClose(null, new int?(this.ActivityBaseData.Id));
		this.OnDataUpdate();
	}

	// Token: 0x060056B3 RID: 22195 RVA: 0x001C7032 File Offset: 0x001C5232
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060056B4 RID: 22196 RVA: 0x001C7050 File Offset: 0x001C5250
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.LongShanUpdate, new Action(this.OnDataUpdate));
	}

	// Token: 0x060056B5 RID: 22197 RVA: 0x001C7070 File Offset: 0x001C5270
	private void OnDataUpdate()
	{
		foreach (RoleGrowingStageItem roleGrowingStageItem in this.StageItems)
		{
			roleGrowingStageItem.Refresh(this.ActivityBaseData);
		}
	}

	// Token: 0x060056B6 RID: 22198 RVA: 0x001C70C8 File Offset: 0x001C52C8
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

	// Token: 0x04003BAD RID: 15277
	[Nullable(2)]
	protected ActivityLongShanData ActivityBaseData;

	// Token: 0x04003BAE RID: 15278
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003BAF RID: 15279
	[Nullable(1)]
	private readonly List<RoleGrowingStageItem> StageItems = new List<RoleGrowingStageItem>();

	// Token: 0x02006A4F RID: 27215
	private class EComponents
	{
		// Token: 0x04022FC7 RID: 143303
		public const int Caption = 0;

		// Token: 0x04022FC8 RID: 143304
		public const int Stage1 = 1;

		// Token: 0x04022FC9 RID: 143305
		public const int Stage2 = 2;

		// Token: 0x04022FCA RID: 143306
		public const int Stage3 = 3;

		// Token: 0x04022FCB RID: 143307
		public const int Stage4 = 4;
	}
}
