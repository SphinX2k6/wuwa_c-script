using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001AE6 RID: 6886
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGroupActionData : FloroRanchAsyncActionBase
{
	// Token: 0x0600CC20 RID: 52256 RVA: 0x002E9528 File Offset: 0x002E7728
	public void InitActionData(List<FloroRanchUnitActionMsg> actionDataList)
	{
		this.ActionDataList.Clear();
		foreach (FloroRanchUnitActionMsg actionData in actionDataList)
		{
			FloroRanchActionDataBase item = FloroRanchEntityActionSystem.CreateActionData(actionData);
			this.ActionDataList.Add(item);
		}
	}

	// Token: 0x0600CC21 RID: 52257 RVA: 0x002E958C File Offset: 0x002E778C
	public override UniTask OnExecute()
	{
		FloroRanchGroupActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchGroupActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600CC22 RID: 52258 RVA: 0x002E95CF File Offset: 0x002E77CF
	protected override void OnPause()
	{
		if (this.CurActionData != null)
		{
			this.CurActionData.Pause();
		}
	}

	// Token: 0x0600CC23 RID: 52259 RVA: 0x002E95E4 File Offset: 0x002E77E4
	protected override void OnResume()
	{
		if (this.CurActionData != null)
		{
			this.CurActionData.Resume();
		}
	}

	// Token: 0x0600CC24 RID: 52260 RVA: 0x002E95FC File Offset: 0x002E77FC
	protected override void OnExit()
	{
		if (this.CurActionData != null)
		{
			this.CurActionData.Exit();
		}
		foreach (FloroRanchAsyncActionBase floroRanchAsyncActionBase in this.ActionDataList)
		{
			floroRanchAsyncActionBase.Exit();
		}
		this.ActionDataList.Clear();
	}

	// Token: 0x0600CC25 RID: 52261 RVA: 0x002E966C File Offset: 0x002E786C
	public void SetIgnoreCasterEntityAnim(int entityId)
	{
		foreach (FloroRanchAsyncActionBase floroRanchAsyncActionBase in this.ActionDataList)
		{
			if (floroRanchAsyncActionBase is FloroRanchActionDataBase)
			{
				((FloroRanchActionDataBase)floroRanchAsyncActionBase).SetIgnoreCasterEntityAnim(entityId);
			}
		}
	}

	// Token: 0x04005DD5 RID: 24021
	private readonly List<FloroRanchAsyncActionBase> ActionDataList = new List<FloroRanchAsyncActionBase>();

	// Token: 0x04005DD6 RID: 24022
	[Nullable(2)]
	private FloroRanchAsyncActionBase CurActionData;
}
