using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB1 RID: 7089
[NullableContext(1)]
[Nullable(0)]
public class DangoDungeonCommandQueue
{
	// Token: 0x06011AA5 RID: 72357 RVA: 0x00535CD7 File Offset: 0x00533ED7
	public void Init()
	{
		this.Reset();
	}

	// Token: 0x06011AA6 RID: 72358 RVA: 0x00535CDF File Offset: 0x00533EDF
	public void AddCommand(IDangoDungeonCommand command)
	{
		if (this.IsAborted)
		{
			return;
		}
		this.CommandQueue.Push(command);
	}

	// Token: 0x06011AA7 RID: 72359 RVA: 0x00535CF6 File Offset: 0x00533EF6
	public void Abort()
	{
		if (this.CurCommand != null)
		{
			this.CurCommand.IsAborted = true;
		}
		this.IsAborted = true;
	}

	// Token: 0x06011AA8 RID: 72360 RVA: 0x00535D14 File Offset: 0x00533F14
	public UniTask Execute()
	{
		DangoDungeonCommandQueue.<Execute>d__10 <Execute>d__;
		<Execute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Execute>d__.<>4__this = this;
		<Execute>d__.<>1__state = -1;
		<Execute>d__.<>t__builder.Start<DangoDungeonCommandQueue.<Execute>d__10>(ref <Execute>d__);
		return <Execute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AA9 RID: 72361 RVA: 0x00535D58 File Offset: 0x00533F58
	private void RecordCommandExecuteTime(ERacingBetsCommandType commandType, double time)
	{
	}

	// Token: 0x06011AAA RID: 72362 RVA: 0x00535D68 File Offset: 0x00533F68
	private void PrintStatsInfo()
	{
	}

	// Token: 0x06011AAB RID: 72363 RVA: 0x00535D75 File Offset: 0x00533F75
	public void OnEnd(bool isAborted)
	{
		Action<bool> onCommandQueueEndCallBack = this.OnCommandQueueEndCallBack;
		if (onCommandQueueEndCallBack != null)
		{
			onCommandQueueEndCallBack(isAborted);
		}
		this.Reset();
	}

	// Token: 0x06011AAC RID: 72364 RVA: 0x00535D8F File Offset: 0x00533F8F
	private void Reset()
	{
		this.TotalTime = 0.0;
		this.CurCommandActionIndex = 0;
		this.Stats.Clear();
		this.IsAborted = false;
		this.CommandQueue.Clear();
		this.OnCommandQueueEndCallBack = null;
	}

	// Token: 0x06011AAD RID: 72365 RVA: 0x00535DCB File Offset: 0x00533FCB
	public void BindCommandQueueEndCallBack(Action<bool> callBack)
	{
		this.OnCommandQueueEndCallBack = callBack;
	}

	// Token: 0x04009A61 RID: 39521
	public int CurCommandActionIndex;

	// Token: 0x04009A62 RID: 39522
	private bool IsAborted;

	// Token: 0x04009A63 RID: 39523
	private Queue<IDangoDungeonCommand> CommandQueue = new Queue<IDangoDungeonCommand>(4);

	// Token: 0x04009A64 RID: 39524
	[Nullable(2)]
	private Action<bool> OnCommandQueueEndCallBack;

	// Token: 0x04009A65 RID: 39525
	private readonly Dictionary<ERacingBetsCommandType, IDangoDungeonCommandStats> Stats = new Dictionary<ERacingBetsCommandType, IDangoDungeonCommandStats>();

	// Token: 0x04009A66 RID: 39526
	[Nullable(2)]
	private IDangoDungeonCommand CurCommand;

	// Token: 0x04009A67 RID: 39527
	private double TotalTime;
}
