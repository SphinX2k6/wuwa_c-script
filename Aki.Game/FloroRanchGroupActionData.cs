using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FA5 RID: 4005
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGroupActionData : FloroRanchAsyncActionBase
{
	// Token: 0x0600A031 RID: 41009 RVA: 0x002F46BC File Offset: 0x002F28BC
	public void InitActionData(List<FloroRanchUnitActionMsg> actionDataList)
	{
		this.ActionDataList.Clear();
		foreach (FloroRanchUnitActionMsg actionData in actionDataList)
		{
			FloroRanchActionDataBase item = FloroRanchEntityActionSystem.CreateActionData(actionData);
			this.ActionDataList.Add(item);
		}
	}

	// Token: 0x0600A032 RID: 41010 RVA: 0x002F4720 File Offset: 0x002F2920
	public override UniTask OnExecute()
	{
		FloroRanchGroupActionData.<OnExecute>d__3 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchGroupActionData.<OnExecute>d__3>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0600A033 RID: 41011 RVA: 0x002F4763 File Offset: 0x002F2963
	protected override void OnPause()
	{
		if (this.CurActionData != null)
		{
			this.CurActionData.Pause();
		}
	}

	// Token: 0x0600A034 RID: 41012 RVA: 0x002F4778 File Offset: 0x002F2978
	protected override void OnResume()
	{
		if (this.CurActionData != null)
		{
			this.CurActionData.Resume();
		}
	}

	// Token: 0x0600A035 RID: 41013 RVA: 0x002F4790 File Offset: 0x002F2990
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

	// Token: 0x0600A036 RID: 41014 RVA: 0x002F4800 File Offset: 0x002F2A00
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

	// Token: 0x04005EA4 RID: 24228
	private readonly List<FloroRanchAsyncActionBase> ActionDataList = new List<FloroRanchAsyncActionBase>();

	// Token: 0x04005EA5 RID: 24229
	[Nullable(2)]
	private FloroRanchAsyncActionBase CurActionData;
}
