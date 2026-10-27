using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026C6 RID: 9926
[NullableContext(1)]
[Nullable(0)]
public class DangoDungeonCommandQueue
{
	// Token: 0x060145C3 RID: 83395 RVA: 0x00526F9F File Offset: 0x0052519F
	public void Init()
	{
		this.Reset();
	}

	// Token: 0x060145C4 RID: 83396 RVA: 0x00526FA7 File Offset: 0x005251A7
	public void AddCommand(IDangoDungeonCommand command)
	{
		if (this.IsAborted)
		{
			return;
		}
		this.CommandQueue.Push(command);
	}

	// Token: 0x060145C5 RID: 83397 RVA: 0x00526FBE File Offset: 0x005251BE
	public void Abort()
	{
		if (this.CurCommand != null)
		{
			this.CurCommand.IsAborted = true;
		}
		this.IsAborted = true;
	}

	// Token: 0x060145C6 RID: 83398 RVA: 0x00526FDC File Offset: 0x005251DC
	public UniTask Execute()
	{
		DangoDungeonCommandQueue.<Execute>d__10 <Execute>d__;
		<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Execute>d__.<>4__this = this;
		<Execute>d__.<>1__state = -1;
		<Execute>d__.<>t__builder.Start<DangoDungeonCommandQueue.<Execute>d__10>(ref <Execute>d__);
		return <Execute>d__.<>t__builder.Task;
	}

	// Token: 0x060145C7 RID: 83399 RVA: 0x00527020 File Offset: 0x00525220
	private void RecordCommandExecuteTime(ERacingBetsCommandType commandType, double time)
	{
	}

	// Token: 0x060145C8 RID: 83400 RVA: 0x00527030 File Offset: 0x00525230
	private void PrintStatsInfo()
	{
	}

	// Token: 0x060145C9 RID: 83401 RVA: 0x0052703D File Offset: 0x0052523D
	public void OnEnd(bool isAborted)
	{
		Action<bool> onCommandQueueEndCallBack = this.OnCommandQueueEndCallBack;
		if (onCommandQueueEndCallBack != null)
		{
			onCommandQueueEndCallBack(isAborted);
		}
		this.Reset();
	}

	// Token: 0x060145CA RID: 83402 RVA: 0x00527057 File Offset: 0x00525257
	private void Reset()
	{
		this.TotalTime = 0.0;
		this.CurCommandActionIndex = 0;
		this.Stats.Clear();
		this.IsAborted = false;
		this.CommandQueue.Clear();
		this.OnCommandQueueEndCallBack = null;
	}

	// Token: 0x060145CB RID: 83403 RVA: 0x00527093 File Offset: 0x00525293
	public void BindCommandQueueEndCallBack(Action<bool> callBack)
	{
		this.OnCommandQueueEndCallBack = callBack;
	}

	// Token: 0x04009909 RID: 39177
	public int CurCommandActionIndex;

	// Token: 0x0400990A RID: 39178
	private bool IsAborted;

	// Token: 0x0400990B RID: 39179
	private Queue<IDangoDungeonCommand> CommandQueue = new Queue<IDangoDungeonCommand>(4);

	// Token: 0x0400990C RID: 39180
	[Nullable(2)]
	private Action<bool> OnCommandQueueEndCallBack;

	// Token: 0x0400990D RID: 39181
	private readonly Dictionary<ERacingBetsCommandType, IDangoDungeonCommandStats> Stats = new Dictionary<ERacingBetsCommandType, IDangoDungeonCommandStats>();

	// Token: 0x0400990E RID: 39182
	[Nullable(2)]
	private IDangoDungeonCommand CurCommand;

	// Token: 0x0400990F RID: 39183
	private double TotalTime;
}
