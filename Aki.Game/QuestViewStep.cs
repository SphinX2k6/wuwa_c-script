using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002668 RID: 9832
public class QuestViewStep : StepBaseItem
{
	// Token: 0x0601420E RID: 82446 RVA: 0x00515D0F File Offset: 0x00513F0F
	public QuestViewStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
	{
	}

	// Token: 0x0601420F RID: 82447 RVA: 0x00515D24 File Offset: 0x00513F24
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
	}

	// Token: 0x06014210 RID: 82448 RVA: 0x00515D88 File Offset: 0x00513F88
	protected override UniTask OnBeforeStartAsync()
	{
		QuestViewStep.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestViewStep.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014211 RID: 82449 RVA: 0x00515DCB File Offset: 0x00513FCB
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06014212 RID: 82450 RVA: 0x00515DD0 File Offset: 0x00513FD0
	[NullableContext(2)]
	public UniTask Update(BehaviorTreeViewShowData showData)
	{
		QuestViewStep.<Update>d__6 <Update>d__;
		<Update>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Update>d__.<>4__this = this;
		<Update>d__.showData = showData;
		<Update>d__.<>1__state = -1;
		<Update>d__.<>t__builder.Start<QuestViewStep.<Update>d__6>(ref <Update>d__);
		return <Update>d__.<>t__builder.Task;
	}

	// Token: 0x06014213 RID: 82451 RVA: 0x00515E1C File Offset: 0x0051401C
	[return: TupleElementNames(new string[]
	{
		"Count",
		"LastActiveStep"
	})]
	[return: Nullable(new byte[]
	{
		0,
		0,
		2
	})]
	private UniTask<ValueTuple<int, QuestViewChildStep>> UpdateChildSteps()
	{
		QuestViewStep.<UpdateChildSteps>d__7 <UpdateChildSteps>d__;
		<UpdateChildSteps>d__.<>t__builder = AsyncUniTaskMethodBuilder<ValueTuple<int, QuestViewChildStep>>.Create();
		<UpdateChildSteps>d__.<>4__this = this;
		<UpdateChildSteps>d__.<>1__state = -1;
		<UpdateChildSteps>d__.<>t__builder.Start<QuestViewStep.<UpdateChildSteps>d__7>(ref <UpdateChildSteps>d__);
		return <UpdateChildSteps>d__.<>t__builder.Task;
	}

	// Token: 0x040097AE RID: 38830
	[Nullable(1)]
	private readonly List<QuestViewChildStep> ChildSteps = new List<QuestViewChildStep>();

	// Token: 0x02008CAC RID: 36012
	private static class EChildComponent
	{
		// Token: 0x0402DA86 RID: 187014
		public const int ChildStep = 2;

		// Token: 0x0402DA87 RID: 187015
		public const int HorizontalNode = 3;

		// Token: 0x0402DA88 RID: 187016
		public const int PanelLine = 4;
	}
}
