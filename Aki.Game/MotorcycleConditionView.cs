using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200174D RID: 5965
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleConditionView : UiViewBase
{
	// Token: 0x0600E796 RID: 59286 RVA: 0x0043D237 File Offset: 0x0043B437
	public MotorcycleConditionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E797 RID: 59287 RVA: 0x0043D24C File Offset: 0x0043B44C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600E798 RID: 59288 RVA: 0x0043D2BC File Offset: 0x0043B4BC
	protected override void OnStart()
	{
		this.ConditionDataList = ((this.OpenParam as List<IMotorLevelConditionData>) ?? new List<IMotorLevelConditionData>());
		this.CreateConditionLayout();
	}

	// Token: 0x0600E799 RID: 59289 RVA: 0x0043D2E0 File Offset: 0x0043B4E0
	protected override void OnBeforeShow()
	{
		this.ConditionLayout.RefreshByData(this.ConditionDataList, false, null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "MotorBike_ExpGuide", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MotorBike_ExpGuide_Title", Array.Empty<object>());
	}

	// Token: 0x0600E79A RID: 59290 RVA: 0x0043D338 File Offset: 0x0043B538
	protected void CreateConditionLayout()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
		UUIItem item = base.GetItem(3);
		this.ConditionLayout = new LoopScrollView<MotorcycleConditionItem, IMotorLevelConditionData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, new Func<MotorcycleConditionItem>(this.CreateConditionItem), false);
	}

	// Token: 0x0600E79B RID: 59291 RVA: 0x0043D379 File Offset: 0x0043B579
	private MotorcycleConditionItem CreateConditionItem()
	{
		return new MotorcycleConditionItem();
	}

	// Token: 0x04008410 RID: 33808
	private List<IMotorLevelConditionData> ConditionDataList = new List<IMotorLevelConditionData>();

	// Token: 0x04008411 RID: 33809
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleConditionItem, IMotorLevelConditionData> ConditionLayout;

	// Token: 0x02007917 RID: 30999
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027408 RID: 160776
		public const int TxtTitle = 0;

		// Token: 0x04027409 RID: 160777
		public const int TxtTips = 1;

		// Token: 0x0402740A RID: 160778
		public const int ConditionLayout = 2;

		// Token: 0x0402740B RID: 160779
		public const int ConditionItem = 3;
	}
}
