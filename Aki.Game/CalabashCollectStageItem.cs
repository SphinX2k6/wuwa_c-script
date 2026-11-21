using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000BFA RID: 3066
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashCollectStageItem : GridProxyAbstract<ICalabashDevelopRewardInfoData>
{
	// Token: 0x06008026 RID: 32806 RVA: 0x00274058 File Offset: 0x00272258
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

	// Token: 0x06008027 RID: 32807 RVA: 0x002740C8 File Offset: 0x002722C8
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

	// Token: 0x02006EB0 RID: 28336
	private enum EComponent
	{
		// Token: 0x04024304 RID: 148228
		StageText,
		// Token: 0x04024305 RID: 148229
		ExpText,
		// Token: 0x04024306 RID: 148230
		UnlockItem,
		// Token: 0x04024307 RID: 148231
		LockItem
	}
}
