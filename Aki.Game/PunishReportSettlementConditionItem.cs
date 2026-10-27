using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001DA1 RID: 7585
[NullableContext(1)]
[Nullable(0)]
public class PunishReportSettlementConditionItem : UiPanelBase
{
	// Token: 0x0600E63C RID: 58940 RVA: 0x003644BC File Offset: 0x003626BC
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

	// Token: 0x0600E63D RID: 58941 RVA: 0x00364525 File Offset: 0x00362725
	protected override void OnStart()
	{
		base.OnStart();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600E63E RID: 58942 RVA: 0x00364558 File Offset: 0x00362758
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

	// Token: 0x0600E63F RID: 58943 RVA: 0x003645A8 File Offset: 0x003627A8
	public UniTask PlaySequence()
	{
		PunishReportSettlementConditionItem.<PlaySequence>d__7 <PlaySequence>d__;
		<PlaySequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequence>d__.<>4__this = this;
		<PlaySequence>d__.<>1__state = -1;
		<PlaySequence>d__.<>t__builder.Start<PunishReportSettlementConditionItem.<PlaySequence>d__7>(ref <PlaySequence>d__);
		return <PlaySequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600E640 RID: 58944 RVA: 0x003645EB File Offset: 0x003627EB
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Finish")
		{
			this.CustomPromise.SetResult(true);
		}
	}

	// Token: 0x04006A8A RID: 27274
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006A8B RID: 27275
	private readonly CustomPromise<bool> CustomPromise = new CustomPromise<bool>();

	// Token: 0x04006A8C RID: 27276
	private bool StateChanged;

	// Token: 0x0200837E RID: 33662
	[NullableContext(0)]
	private static class EViewComponent
	{
		// Token: 0x0402AD9B RID: 175515
		public const int CorrectSprite = 0;

		// Token: 0x0402AD9C RID: 175516
		public const int ConditionText = 1;
	}
}
