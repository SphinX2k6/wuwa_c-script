using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026D8 RID: 9944
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsOrganEffectCommand : RacingBetsCommandBase
{
	// Token: 0x17001A71 RID: 6769
	// (get) Token: 0x06014641 RID: 83521 RVA: 0x005284DE File Offset: 0x005266DE
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.OrganEffect;
		}
	}

	// Token: 0x06014642 RID: 83522 RVA: 0x005284E2 File Offset: 0x005266E2
	public void Init(RacingBetsOrganEffect organEffectAction)
	{
		this.OrganEffectAction = organEffectAction;
	}

	// Token: 0x06014643 RID: 83523 RVA: 0x005284EC File Offset: 0x005266EC
	public override UniTask OnExecute()
	{
		RacingBetsOrganEffectCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsOrganEffectCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014644 RID: 83524 RVA: 0x0052852F File Offset: 0x0052672F
	public override string LogInfo()
	{
		return "RacingBetsOrganEffectCommand";
	}

	// Token: 0x04009932 RID: 39218
	private RacingBetsOrganEffect OrganEffectAction;
}
