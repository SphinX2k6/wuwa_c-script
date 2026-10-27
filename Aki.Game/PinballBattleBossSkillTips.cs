using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CFC RID: 7420
public class PinballBattleBossSkillTips : PinballBattleTipsBase
{
	// Token: 0x0600E0A5 RID: 57509 RVA: 0x0034AFCB File Offset: 0x003491CB
	[NullableContext(1)]
	public PinballBattleBossSkillTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0A6 RID: 57510 RVA: 0x0034AFD4 File Offset: 0x003491D4
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

	// Token: 0x0600E0A7 RID: 57511 RVA: 0x0034B01C File Offset: 0x0034921C
	protected override void OnStart()
	{
		base.OnStart();
		IPinballBattleBossSkillTipsParam pinballBattleBossSkillTipsParam = this.OpenParam as IPinballBattleBossSkillTipsParam;
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(pinballBattleBossSkillTipsParam.TextId);
	}
}
