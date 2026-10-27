using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CFF RID: 7423
public class PinballBattleLevelStartTips : PinballBattleTipsBase
{
	// Token: 0x0600E0AA RID: 57514 RVA: 0x0034B052 File Offset: 0x00349252
	[NullableContext(1)]
	public PinballBattleLevelStartTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0AB RID: 57515 RVA: 0x0034B05C File Offset: 0x0034925C
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

	// Token: 0x0600E0AC RID: 57516 RVA: 0x0034B0A4 File Offset: 0x003492A4
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
