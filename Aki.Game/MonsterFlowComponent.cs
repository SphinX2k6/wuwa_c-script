using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x020031C0 RID: 12736
[NullableContext(2)]
[Nullable(0)]
public class MonsterFlowComponent : CharacterFlowComponent
{
	// Token: 0x0601B737 RID: 112439 RVA: 0x007831D1 File Offset: 0x007813D1
	protected override bool OnStart()
	{
		this.UnifiedStateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.SensoryComp = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		base.OnStart();
		return true;
	}

	// Token: 0x0601B738 RID: 112440 RVA: 0x007831FD File Offset: 0x007813FD
	protected override bool InitFlowLogicRange(float? enterRange, float? leaveRange, IBubbleRangeCylinderConfig config)
	{
		if (!base.InitFlowLogicRange(enterRange, leaveRange, config))
		{
			return false;
		}
		PawnSensoryInfoComponent sensoryComp = this.SensoryComp;
		if (sensoryComp != null)
		{
			sensoryComp.SetLogicRange(leaveRange.GetValueOrDefault(1500f));
		}
		return true;
	}

	// Token: 0x0601B739 RID: 112441 RVA: 0x0078322C File Offset: 0x0078142C
	protected override bool CheckCondition()
	{
		if (!base.CheckCondition())
		{
			return false;
		}
		if (this.SensoryComp == null)
		{
			return false;
		}
		if (!this.SensoryComp.IsInLogicRange)
		{
			base.ForceStopFlow();
			return false;
		}
		if (this.UnifiedStateComp.IsInFightState())
		{
			base.ForceStopFlow();
			return false;
		}
		return true;
	}

	// Token: 0x0601B73A RID: 112442 RVA: 0x00783278 File Offset: 0x00781478
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterFlowComponent monsterFlowComponent = (MonsterFlowComponent)componentTemplate;
		if (base.CanResetComponentProperty("SensoryComp"))
		{
			if (monsterFlowComponent.SensoryComp == null)
			{
				this.SensoryComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnSensoryInfoComponent>(this.SensoryComp), "SensoryComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComp"))
		{
			if (monsterFlowComponent.UnifiedStateComp == null)
			{
				this.UnifiedStateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComp), "UnifiedStateComp"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400D74D RID: 55117
	private PawnSensoryInfoComponent SensoryComp;

	// Token: 0x0400D74E RID: 55118
	private CharacterUnifiedStateComponent UnifiedStateComp;
}
