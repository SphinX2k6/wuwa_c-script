using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001BC5 RID: 7109
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSkillCommand : RacingBetsCommandBase
{
	// Token: 0x17001AAB RID: 6827
	// (get) Token: 0x06011B2B RID: 72491 RVA: 0x00537288 File Offset: 0x00535488
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoSkill;
		}
	}

	// Token: 0x06011B2C RID: 72492 RVA: 0x0053728B File Offset: 0x0053548B
	public void Init(RacingBetsDangoActionSkill skillAction)
	{
		this.SkillAction = skillAction;
	}

	// Token: 0x06011B2D RID: 72493 RVA: 0x00537294 File Offset: 0x00535494
	public override UniTask OnExecute()
	{
		RacingBetsSkillCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsSkillCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B2E RID: 72494 RVA: 0x005372D7 File Offset: 0x005354D7
	public override string LogInfo()
	{
		return "RacingBetsSkillCommand";
	}

	// Token: 0x04009A8B RID: 39563
	private RacingBetsDangoActionSkill SkillAction;
}
