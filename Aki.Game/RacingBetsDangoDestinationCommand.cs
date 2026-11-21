using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BBA RID: 7098
public class RacingBetsDangoDestinationCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA0 RID: 6816
	// (get) Token: 0x06011AEB RID: 72427 RVA: 0x0053631A File Offset: 0x0053451A
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoDestination;
		}
	}

	// Token: 0x06011AEC RID: 72428 RVA: 0x0053631E File Offset: 0x0053451E
	public void Init(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x06011AED RID: 72429 RVA: 0x00536328 File Offset: 0x00534528
	public override UniTask OnExecute()
	{
		RacingBetsDangoDestinationCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoDestinationCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011AEE RID: 72430 RVA: 0x0053636B File Offset: 0x0053456B
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDangoDestinationCommand";
	}

	// Token: 0x04009A72 RID: 39538
	private int DangoId;
}
