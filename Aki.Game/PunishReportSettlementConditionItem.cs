using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001263 RID: 4707
[NullableContext(1)]
[Nullable(0)]
public class PunishReportSettlementConditionItem : UiPanelBase
{
	// Token: 0x0600BA5A RID: 47706 RVA: 0x0037011C File Offset: 0x0036E31C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x00370185 File Offset: 0x0036E385
	protected override void OnStart()
	{
		base.OnStart();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x003701B8 File Offset: 0x0036E3B8
	public void Init(string conditionTextId, EPunishReportTargetState historyState, EPunishReportTargetState state)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, conditionTextId, Array.Empty<object>());
		UUISprite sprite = base.GetSprite(0);
		if (sprite != null)
		{
			sprite.SetUIActive(historyState == EPunishReportTargetState.Achieve);
		}
		this.StateChanged = (historyState != state && state == EPunishReportTargetState.Achieve);
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x00370208 File Offset: 0x0036E408
	public UniTask PlaySequence()
	{
		PunishReportSettlementConditionItem.<PlaySequence>d__7 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<PunishReportSettlementConditionItem.<PlaySequence>d__7>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x0037024B File Offset: 0x0036E44B
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Finish")
		{
			this.CustomPromise.SetResult(true);
		}
	}

	// Token: 0x04006B6B RID: 27499
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006B6C RID: 27500
	private readonly CustomPromise<bool> CustomPromise = new CustomPromise<bool>();

	// Token: 0x04006B6D RID: 27501
	private bool StateChanged;

	// Token: 0x02007506 RID: 29958
	[NullableContext(0)]
	private static class EViewComponent
	{
		// Token: 0x040260C1 RID: 155841
		public const int CorrectSprite = 0;

		// Token: 0x040260C2 RID: 155842
		public const int ConditionText = 1;
	}
}
