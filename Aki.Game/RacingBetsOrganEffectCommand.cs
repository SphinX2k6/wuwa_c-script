using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BC3 RID: 7107
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsOrganEffectCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA9 RID: 6825
	// (get) Token: 0x06011B23 RID: 72483 RVA: 0x00537216 File Offset: 0x00535416
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.OrganEffect;
		}
	}

	// Token: 0x06011B24 RID: 72484 RVA: 0x0053721A File Offset: 0x0053541A
	public void Init(RacingBetsOrganEffect organEffectAction)
	{
		this.OrganEffectAction = organEffectAction;
	}

	// Token: 0x06011B25 RID: 72485 RVA: 0x00537224 File Offset: 0x00535424
	public override UniTask OnExecute()
	{
		RacingBetsOrganEffectCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsOrganEffectCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B26 RID: 72486 RVA: 0x00537267 File Offset: 0x00535467
	public override string LogInfo()
	{
		return "RacingBetsOrganEffectCommand";
	}

	// Token: 0x04009A8A RID: 39562
	private RacingBetsOrganEffect OrganEffectAction;
}
