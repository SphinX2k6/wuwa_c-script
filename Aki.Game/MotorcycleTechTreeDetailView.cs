using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002270 RID: 8816
public class MotorcycleTechTreeDetailView : UiViewBase
{
	// Token: 0x0601136E RID: 70510 RVA: 0x004326CF File Offset: 0x004308CF
	[NullableContext(1)]
	public MotorcycleTechTreeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601136F RID: 70511 RVA: 0x004326D8 File Offset: 0x004308D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout))
		};
	}

	// Token: 0x06011370 RID: 70512 RVA: 0x00432748 File Offset: 0x00430948
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
		this.Layout = new GenericLayout<MotorcycleTechTreeListScrollItem, IMotorTechOverviewData>(base.GetVerticalLayout(3), new Func<MotorcycleTechTreeListScrollItem>(this.InitListItem), null, false, true);
		int? num = this.OpenParam as int?;
		if (num == null)
		{
			return;
		}
		MotorTechTree? motorTechTreeConfig = MotorConfig.Instance.GetMotorTechTreeConfig(num.Value);
		if (motorTechTreeConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorTechTreeConfig.Value.Icon, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), motorTechTreeConfig.Value.Name, Array.Empty<object>());
		List<IMotorTechOverviewData> list = new List<IMotorTechOverviewData>();
		foreach (MotorTech motorTech in MotorConfig.Instance.GetMotorTechConfigList(num.Value))
		{
			MotorTechTreeNode techNodeById = MotorcycleDevelopModel.Instance.GetTechNodeById(motorTech.Id);
			if (techNodeById != null && techNodeById.Status == EMotorTechTreeNodeStatus.Activated)
			{
				MotorTechOverviewData item = new MotorTechOverviewData
				{
					TechId = motorTech.Id,
					Level = techNodeById.NodeLevel
				};
				list.Add(item);
			}
		}
		list.Sort(delegate(IMotorTechOverviewData a, IMotorTechOverviewData b)
		{
			MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(a.TechId);
			MotorTech? motorTechConfig2 = MotorConfig.Instance.GetMotorTechConfig(b.TechId);
			return motorTechConfig.Value.DetailOrder - motorTechConfig2.Value.DetailOrder;
		});
		this.Layout.RefreshByData(list, null, false);
	}

	// Token: 0x06011371 RID: 70513 RVA: 0x004328F0 File Offset: 0x00430AF0
	[NullableContext(1)]
	private MotorcycleTechTreeListScrollItem InitListItem()
	{
		return new MotorcycleTechTreeListScrollItem();
	}

	// Token: 0x06011372 RID: 70514 RVA: 0x004328F7 File Offset: 0x00430AF7
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040082FE RID: 33534
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040082FF RID: 33535
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeListScrollItem, IMotorTechOverviewData> Layout;

	// Token: 0x020087A4 RID: 34724
	private class EMotorTechTreeDetailComponent
	{
		// Token: 0x0402C14E RID: 180558
		public const int CaptionItem = 0;

		// Token: 0x0402C14F RID: 180559
		public const int TexIcon = 1;

		// Token: 0x0402C150 RID: 180560
		public const int TxtAttr = 2;

		// Token: 0x0402C151 RID: 180561
		public const int Layout = 3;
	}
}
