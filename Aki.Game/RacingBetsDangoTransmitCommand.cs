using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BBE RID: 7102
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoTransmitCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA4 RID: 6820
	// (get) Token: 0x06011AFF RID: 72447 RVA: 0x00536478 File Offset: 0x00534678
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoTransmit;
		}
	}

	// Token: 0x06011B00 RID: 72448 RVA: 0x0053647C File Offset: 0x0053467C
	public void Init(RacingBetsDangoActionTransmit transmitAction)
	{
		this.TransmitAction = transmitAction;
	}

	// Token: 0x06011B01 RID: 72449 RVA: 0x00536488 File Offset: 0x00534688
	public override UniTask OnExecute()
	{
		RacingBetsDangoTransmitCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoTransmitCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B02 RID: 72450 RVA: 0x005364CB File Offset: 0x005346CB
	public override string LogInfo()
	{
		return "RacingBetsDangoTransmitCommand";
	}

	// Token: 0x04009A77 RID: 39543
	private RacingBetsDangoActionTransmit TransmitAction;
}
