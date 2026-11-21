using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011BE RID: 4542
public class PinballBattleBossSkillTips : PinballBattleTipsBase
{
	// Token: 0x0600B4C2 RID: 46274 RVA: 0x003569FB File Offset: 0x00354BFB
	[NullableContext(1)]
	public PinballBattleBossSkillTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B4C3 RID: 46275 RVA: 0x00356A04 File Offset: 0x00354C04
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

	// Token: 0x0600B4C4 RID: 46276 RVA: 0x00356A4C File Offset: 0x00354C4C
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
