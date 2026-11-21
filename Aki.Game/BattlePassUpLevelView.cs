using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200181E RID: 6174
public class BattlePassUpLevelView : UiViewBase
{
	// Token: 0x0600F251 RID: 62033 RVA: 0x00472F84 File Offset: 0x00471184
	[NullableContext(1)]
	public BattlePassUpLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F252 RID: 62034 RVA: 0x00472F90 File Offset: 0x00471190
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

	// Token: 0x0600F253 RID: 62035 RVA: 0x00472FFC File Offset: 0x004711FC
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

	// Token: 0x0600F254 RID: 62036 RVA: 0x0047307A File Offset: 0x0047127A
	protected override void OnAfterHide()
	{
		if (((IBattlePassUpLevelViewData)this.OpenParam).FirstUnlockPass)
		{
			EventSystem.Instance.Emit(EEventName.BattlePassFirstUnlockAnime);
		}
	}

	// Token: 0x02007A48 RID: 31304
	private enum EBpUpgradeComponents
	{
		// Token: 0x04027A28 RID: 162344
		PreLevel,
		// Token: 0x04027A29 RID: 162345
		NowLevel
	}
}
