using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002339 RID: 9017
public class BattlePassUpLevelView : UiViewBase
{
	// Token: 0x06011DA1 RID: 73121 RVA: 0x00465EBC File Offset: 0x004640BC
	[NullableContext(1)]
	public BattlePassUpLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011DA2 RID: 73122 RVA: 0x00465EC8 File Offset: 0x004640C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011DA3 RID: 73123 RVA: 0x00465F34 File Offset: 0x00464134
	protected override void OnStart()
	{
		int battlePassLevel = BattlePassModel.Instance.BattlePassLevel;
		int increasedLevelToShow = BattlePassModel.Instance.IncreasedLevelToShow;
		BattlePassModel.Instance.IncreasedLevelToShow = 0;
		base.GetText(1).SetText(battlePassLevel.ToString(), true);
		base.GetText(0).SetText((battlePassLevel - increasedLevelToShow).ToString(), true);
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UiManager.Instance.CloseView(this.ViewInfo.Name, null);
		}, 2000f, null, null, true, 1f);
	}

	// Token: 0x06011DA4 RID: 73124 RVA: 0x00465FB2 File Offset: 0x004641B2
	protected override void OnAfterHide()
	{
		if (((IBattlePassUpLevelViewData)this.OpenParam).FirstUnlockPass)
		{
			EventSystem.Instance.Emit(EEventName.BattlePassFirstUnlockAnime);
		}
	}

	// Token: 0x020088BF RID: 35007
	private enum EBpUpgradeComponents
	{
		// Token: 0x0402C714 RID: 182036
		PreLevel,
		// Token: 0x0402C715 RID: 182037
		NowLevel
	}
}
