using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B53 RID: 6995
public class QuestViewStep : StepBaseItem
{
	// Token: 0x060116F0 RID: 71408 RVA: 0x005249C7 File Offset: 0x00522BC7
	public QuestViewStep(EMissionItemView viewId, int stepId) : base(viewId, stepId)
	{
	}

	// Token: 0x060116F1 RID: 71409 RVA: 0x005249DC File Offset: 0x00522BDC
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
	}

	// Token: 0x060116F2 RID: 71410 RVA: 0x00524A40 File Offset: 0x00522C40
	protected override UniTask OnBeforeStartAsync()
	{
		QuestViewStep.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestViewStep.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060116F3 RID: 71411 RVA: 0x00524A83 File Offset: 0x00522C83
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x060116F4 RID: 71412 RVA: 0x00524A88 File Offset: 0x00522C88
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

	// Token: 0x060116F5 RID: 71413 RVA: 0x00524AD4 File Offset: 0x00522CD4
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

	// Token: 0x04009906 RID: 39174
	[Nullable(1)]
	private readonly List<QuestViewChildStep> ChildSteps = new List<QuestViewChildStep>();

	// Token: 0x02007E35 RID: 32309
	private static class EChildComponent
	{
		// Token: 0x04028D9D RID: 167325
		public const int ChildStep = 2;

		// Token: 0x04028D9E RID: 167326
		public const int HorizontalNode = 3;

		// Token: 0x04028D9F RID: 167327
		public const int PanelLine = 4;
	}
}
