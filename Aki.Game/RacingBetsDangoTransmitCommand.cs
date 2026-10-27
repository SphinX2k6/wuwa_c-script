using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D3 RID: 9939
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoTransmitCommand : RacingBetsCommandBase
{
	// Token: 0x17001A6C RID: 6764
	// (get) Token: 0x0601461D RID: 83485 RVA: 0x00527740 File Offset: 0x00525940
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoTransmit;
		}
	}

	// Token: 0x0601461E RID: 83486 RVA: 0x00527744 File Offset: 0x00525944
	public void Init(RacingBetsDangoActionTransmit transmitAction)
	{
		this.TransmitAction = transmitAction;
	}

	// Token: 0x0601461F RID: 83487 RVA: 0x00527750 File Offset: 0x00525950
	public override UniTask OnExecute()
	{
		RacingBetsDangoTransmitCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoTransmitCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014620 RID: 83488 RVA: 0x00527793 File Offset: 0x00525993
	public override string LogInfo()
	{
		return "RacingBetsDangoTransmitCommand";
	}

	// Token: 0x0400991F RID: 39199
	private RacingBetsDangoActionTransmit TransmitAction;
}
