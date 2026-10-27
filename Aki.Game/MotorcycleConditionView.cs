using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002269 RID: 8809
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleConditionView : UiViewBase
{
	// Token: 0x06011300 RID: 70400 RVA: 0x0043062B File Offset: 0x0042E82B
	public MotorcycleConditionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011301 RID: 70401 RVA: 0x00430640 File Offset: 0x0042E840
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

	// Token: 0x06011302 RID: 70402 RVA: 0x004306B0 File Offset: 0x0042E8B0
	protected override void OnStart()
	{
		this.ConditionDataList = ((this.OpenParam as List<IMotorLevelConditionData>) ?? new List<IMotorLevelConditionData>());
		this.CreateConditionLayout();
	}

	// Token: 0x06011303 RID: 70403 RVA: 0x004306D4 File Offset: 0x0042E8D4
	protected override void OnBeforeShow()
	{
		this.ConditionLayout.RefreshByData(this.ConditionDataList, false, null, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "MotorBike_ExpGuide", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "MotorBike_ExpGuide_Title", Array.Empty<object>());
	}

	// Token: 0x06011304 RID: 70404 RVA: 0x0043072C File Offset: 0x0042E92C
	protected void CreateConditionLayout()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
		UUIItem item = base.GetItem(3);
		this.ConditionLayout = new LoopScrollView<MotorcycleConditionItem, IMotorLevelConditionData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, new Func<MotorcycleConditionItem>(this.CreateConditionItem), false);
	}

	// Token: 0x06011305 RID: 70405 RVA: 0x0043076D File Offset: 0x0042E96D
	private MotorcycleConditionItem CreateConditionItem()
	{
		return new MotorcycleConditionItem();
	}

	// Token: 0x040082D2 RID: 33490
	private List<IMotorLevelConditionData> ConditionDataList = new List<IMotorLevelConditionData>();

	// Token: 0x040082D3 RID: 33491
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<MotorcycleConditionItem, IMotorLevelConditionData> ConditionLayout;

	// Token: 0x0200878E RID: 34702
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C0F0 RID: 180464
		public const int TxtTitle = 0;

		// Token: 0x0402C0F1 RID: 180465
		public const int TxtTips = 1;

		// Token: 0x0402C0F2 RID: 180466
		public const int ConditionLayout = 2;

		// Token: 0x0402C0F3 RID: 180467
		public const int ConditionItem = 3;
	}
}
