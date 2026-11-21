using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001725 RID: 5925
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleTechTreeListLevelItem : GridProxyAbstract<IMotorTechLevelPoint>
{
	// Token: 0x0600E651 RID: 58961 RVA: 0x00439424 File Offset: 0x00437624
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x0600E652 RID: 58962 RVA: 0x00439494 File Offset: 0x00437694
	[NullableContext(1)]
	public override void Refresh(IMotorTechLevelPoint data, bool isSelected, int gridIndex)
	{
		int targetLevel = data.TargetLevel;
		int curLevel = data.CurLevel;
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(2);
		UUIText text = base.GetText(0);
		UUIText text2 = base.GetText(1);
		UUIItem uuiitem = item;
		bool bUseChangeColor = gridIndex % 2 != 0;
		FColor? fcolor = new FColor?(item.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		bool flag = curLevel > targetLevel;
		bool flag2 = curLevel == targetLevel;
		bool flag3 = curLevel < targetLevel;
		string hexStr = "";
		if (flag)
		{
			hexStr = "ece5d8";
		}
		else if (flag2)
		{
			hexStr = "fff7b4";
		}
		else if (flag3)
		{
			hexStr = "adadad";
		}
		text.SetColor(FColor.FromHex(hexStr));
		item2.SetUIActive(flag2);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(data.Title, null);
		LguiUtil.Instance.SetLocalTextNew(text, "MotorBike_CurrentTechTree_TechLevelInfo", new <>z__ReadOnlyArray<object>(new object[]
		{
			targetLevel,
			localTextNew
		}));
		LguiUtil.Instance.SetLocalTextNew(text2, data.Desc, Array.Empty<object>());
	}

	// Token: 0x02007906 RID: 30982
	private class EMotorTechLevelItemComponent
	{
		// Token: 0x040273B7 RID: 160695
		public const int TxtLevelTitle = 0;

		// Token: 0x040273B8 RID: 160696
		public const int TxtDesc = 1;

		// Token: 0x040273B9 RID: 160697
		public const int CurLevelItem = 2;

		// Token: 0x040273BA RID: 160698
		public const int BgItem = 3;
	}
}
