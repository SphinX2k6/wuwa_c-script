using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001741 RID: 5953
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashCollectStageItem : GridProxyAbstract<ICalabashDevelopRewardInfoData>
{
	// Token: 0x0600AC3F RID: 44095 RVA: 0x00269C1C File Offset: 0x00267E1C
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

	// Token: 0x0600AC40 RID: 44096 RVA: 0x00269C8C File Offset: 0x00267E8C
	[NullableContext(1)]
	public override void Refresh(ICalabashDevelopRewardInfoData data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(0);
		text.ShowTextNew(data.Info);
		UUIItem uuiitem = text;
		bool isUnlock = data.IsUnlock;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(isUnlock, fcolor);
		UUIText text2 = base.GetText(1);
		text2.SetText(data.Num.ToString(), true);
		UUIItem uuiitem2 = text2;
		bool isUnlock2 = data.IsUnlock;
		fcolor = new FColor?(text2.changeColor);
		uuiitem2.SetChangeColor(isUnlock2, fcolor);
		base.GetItem(2).SetUIActive(data.IsUnlock);
		base.GetItem(3).SetUIActive(!data.IsUnlock);
	}

	// Token: 0x02007D2A RID: 32042
	private enum EComponent
	{
		// Token: 0x04028FDA RID: 167898
		StageText,
		// Token: 0x04028FDB RID: 167899
		ExpText,
		// Token: 0x04028FDC RID: 167900
		UnlockItem,
		// Token: 0x04028FDD RID: 167901
		LockItem
	}
}
