using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BB9 RID: 7097
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoChangeHighCommand : RacingBetsCommandBase
{
	// Token: 0x17001A9F RID: 6815
	// (get) Token: 0x06011AE6 RID: 72422 RVA: 0x005362BA File Offset: 0x005344BA
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoChangeHigh;
		}
	}

	// Token: 0x06011AE7 RID: 72423 RVA: 0x005362BD File Offset: 0x005344BD
	public void Init(RacingBetsDangoActionChangeHigh changeHighAction)
	{
		this.ChangeHighAction = changeHighAction;
	}

	// Token: 0x06011AE8 RID: 72424 RVA: 0x005362C8 File Offset: 0x005344C8
	public override UniTask OnExecute()
	{
		RacingBetsDangoChangeHighCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoChangeHighCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AE9 RID: 72425 RVA: 0x0053630B File Offset: 0x0053450B
	public override string LogInfo()
	{
		return "RacingBetsDangoChangeHighCommand";
	}

	// Token: 0x04009A71 RID: 39537
	private RacingBetsDangoActionChangeHigh ChangeHighAction;
}
