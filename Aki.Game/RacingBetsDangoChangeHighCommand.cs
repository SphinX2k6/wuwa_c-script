using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CE RID: 9934
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoChangeHighCommand : RacingBetsCommandBase
{
	// Token: 0x17001A67 RID: 6759
	// (get) Token: 0x06014604 RID: 83460 RVA: 0x00527582 File Offset: 0x00525782
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoChangeHigh;
		}
	}

	// Token: 0x06014605 RID: 83461 RVA: 0x00527585 File Offset: 0x00525785
	public void Init(RacingBetsDangoActionChangeHigh changeHighAction)
	{
		this.ChangeHighAction = changeHighAction;
	}

	// Token: 0x06014606 RID: 83462 RVA: 0x00527590 File Offset: 0x00525790
	public override UniTask OnExecute()
	{
		RacingBetsDangoChangeHighCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoChangeHighCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014607 RID: 83463 RVA: 0x005275D3 File Offset: 0x005257D3
	public override string LogInfo()
	{
		return "RacingBetsDangoChangeHighCommand";
	}

	// Token: 0x04009919 RID: 39193
	private RacingBetsDangoActionChangeHigh ChangeHighAction;
}
