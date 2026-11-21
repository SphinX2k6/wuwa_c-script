using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001754 RID: 5972
public class MotorcycleTechTreeDetailView : UiViewBase
{
	// Token: 0x0600E804 RID: 59396 RVA: 0x0043F2DB File Offset: 0x0043D4DB
	[NullableContext(1)]
	public MotorcycleTechTreeDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E805 RID: 59397 RVA: 0x0043F2E4 File Offset: 0x0043D4E4
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

	// Token: 0x0600E806 RID: 59398 RVA: 0x0043F354 File Offset: 0x0043D554
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

	// Token: 0x0600E807 RID: 59399 RVA: 0x0043F4FC File Offset: 0x0043D6FC
	[NullableContext(1)]
	private MotorcycleTechTreeListScrollItem InitListItem()
	{
		return new MotorcycleTechTreeListScrollItem();
	}

	// Token: 0x0600E808 RID: 59400 RVA: 0x0043F503 File Offset: 0x0043D703
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400843C RID: 33852
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400843D RID: 33853
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<MotorcycleTechTreeListScrollItem, IMotorTechOverviewData> Layout;

	// Token: 0x0200792D RID: 31021
	private class EMotorTechTreeDetailComponent
	{
		// Token: 0x04027466 RID: 160870
		public const int CaptionItem = 0;

		// Token: 0x04027467 RID: 160871
		public const int TexIcon = 1;

		// Token: 0x04027468 RID: 160872
		public const int TxtAttr = 2;

		// Token: 0x04027469 RID: 160873
		public const int Layout = 3;
	}
}
