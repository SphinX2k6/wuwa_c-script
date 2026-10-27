using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026CF RID: 9935
public class RacingBetsDangoDestinationCommand : RacingBetsCommandBase
{
	// Token: 0x17001A68 RID: 6760
	// (get) Token: 0x06014609 RID: 83465 RVA: 0x005275E2 File Offset: 0x005257E2
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoDestination;
		}
	}

	// Token: 0x0601460A RID: 83466 RVA: 0x005275E6 File Offset: 0x005257E6
	public void Init(int dangoId)
	{
		this.DangoId = dangoId;
	}

	// Token: 0x0601460B RID: 83467 RVA: 0x005275F0 File Offset: 0x005257F0
	public override UniTask OnExecute()
	{
		RacingBetsDangoDestinationCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDangoDestinationCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0601460C RID: 83468 RVA: 0x00527633 File Offset: 0x00525833
	[NullableContext(1)]
	public override string LogInfo()
	{
		return "RacingBetsDangoDestinationCommand";
	}

	// Token: 0x0400991A RID: 39194
	private int DangoId;
}
