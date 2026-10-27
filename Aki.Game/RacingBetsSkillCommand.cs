using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020026DA RID: 9946
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSkillCommand : RacingBetsCommandBase
{
	// Token: 0x17001A73 RID: 6771
	// (get) Token: 0x06014649 RID: 83529 RVA: 0x00528550 File Offset: 0x00526750
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.DangoSkill;
		}
	}

	// Token: 0x0601464A RID: 83530 RVA: 0x00528553 File Offset: 0x00526753
	public void Init(RacingBetsDangoActionSkill skillAction)
	{
		this.SkillAction = skillAction;
	}

	// Token: 0x0601464B RID: 83531 RVA: 0x0052855C File Offset: 0x0052675C
	public override UniTask OnExecute()
	{
		RacingBetsSkillCommand.<OnExecute>d__4 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsSkillCommand.<OnExecute>d__4>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x0601464C RID: 83532 RVA: 0x0052859F File Offset: 0x0052679F
	public override string LogInfo()
	{
		return "RacingBetsSkillCommand";
	}

	// Token: 0x04009933 RID: 39219
	private RacingBetsDangoActionSkill SkillAction;
}
