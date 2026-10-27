using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002242 RID: 8770
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeListScrollItem : GridProxyAbstract<IMotorTechOverviewData>
{
	// Token: 0x060111BE RID: 70078 RVA: 0x0042C9F0 File Offset: 0x0042ABF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x060111BF RID: 70079 RVA: 0x0042CA60 File Offset: 0x0042AC60
	[NullableContext(1)]
	public override void Refresh(IMotorTechOverviewData data, bool isSelected, int gridIndex)
	{
		MotorTech? motorTechConfig = MotorConfig.Instance.GetMotorTechConfig(data.TechId);
		if (motorTechConfig != null)
		{
			base.SetTextureByPath(motorTechConfig.Value.Icon, base.GetTexture(1), null, null);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(motorTechConfig.Value.Title, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MotorBike_CurrentTechTree_TechLevelInfo", new <>z__ReadOnlyArray<object>(new object[]
			{
				data.Level,
				localTextNew
			}));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), motorTechConfig.Value.DescSimple, Array.Empty<object>());
		}
		UUIItem item = base.GetItem(0);
		UUIItem uuiitem = item;
		bool bUseChangeColor = gridIndex % 2 != 0;
		FColor? fcolor = new FColor?(item.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0200877E RID: 34686
	private class EMotorTreeOverviewItemComponent
	{
		// Token: 0x0402C0A3 RID: 180387
		public const int BgItem = 0;

		// Token: 0x0402C0A4 RID: 180388
		public const int TexIcon = 1;

		// Token: 0x0402C0A5 RID: 180389
		public const int TxtAttr = 2;

		// Token: 0x0402C0A6 RID: 180390
		public const int TxtDesc = 3;
	}
}
