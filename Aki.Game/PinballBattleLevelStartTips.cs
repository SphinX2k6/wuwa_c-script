using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011C1 RID: 4545
public class PinballBattleLevelStartTips : PinballBattleTipsBase
{
	// Token: 0x0600B4C7 RID: 46279 RVA: 0x00356A82 File Offset: 0x00354C82
	[NullableContext(1)]
	public PinballBattleLevelStartTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B4C8 RID: 46280 RVA: 0x00356A8C File Offset: 0x00354C8C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B4C9 RID: 46281 RVA: 0x00356AD4 File Offset: 0x00354CD4
	protected override void OnStart()
	{
		base.OnStart();
		IPinballBattleLevelStartTipsParam pinballBattleLevelStartTipsParam = this.OpenParam as IPinballBattleLevelStartTipsParam;
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(pinballBattleLevelStartTipsParam.CurWave.ToString() + "/" + pinballBattleLevelStartTipsParam.MaxWave.ToString(), true);
	}
}
