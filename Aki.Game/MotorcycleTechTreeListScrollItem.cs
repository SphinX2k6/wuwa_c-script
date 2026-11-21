using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001726 RID: 5926
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeListScrollItem : GridProxyAbstract<IMotorTechOverviewData>
{
	// Token: 0x0600E654 RID: 58964 RVA: 0x00439594 File Offset: 0x00437794
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

	// Token: 0x0600E655 RID: 58965 RVA: 0x00439604 File Offset: 0x00437804
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

	// Token: 0x02007907 RID: 30983
	private class EMotorTreeOverviewItemComponent
	{
		// Token: 0x040273BB RID: 160699
		public const int BgItem = 0;

		// Token: 0x040273BC RID: 160700
		public const int TexIcon = 1;

		// Token: 0x040273BD RID: 160701
		public const int TxtAttr = 2;

		// Token: 0x040273BE RID: 160702
		public const int TxtDesc = 3;
	}
}
