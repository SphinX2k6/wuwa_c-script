using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200272F RID: 10031
[NullableContext(2)]
[Nullable(0)]
public class MonsterFlowComponent : CharacterFlowComponent
{
	// Token: 0x0601926B RID: 103019 RVA: 0x007AB3DD File Offset: 0x007A95DD
	protected override bool OnStart()
	{
		this.UnifiedStateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.SensoryComp = base.Entity.GetComponent<PawnSensoryInfoComponent>();
		base.OnStart();
		return true;
	}

	// Token: 0x0601926C RID: 103020 RVA: 0x007AB409 File Offset: 0x007A9609
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

	// Token: 0x0601926D RID: 103021 RVA: 0x007AB438 File Offset: 0x007A9638
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

	// Token: 0x0601926E RID: 103022 RVA: 0x007AB484 File Offset: 0x007A9684
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterFlowComponent monsterFlowComponent = (MonsterFlowComponent)componentTemplate;
		if (monsterFlowComponent.SensoryComp == null)
		{
			this.SensoryComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SensoryComp), "SensoryComp"))
		{
			return false;
		}
		if (monsterFlowComponent.UnifiedStateComp == null)
		{
			this.UnifiedStateComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComp), "UnifiedStateComp"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170027FE RID: 10238
	// (get) Token: 0x0601926F RID: 103023 RVA: 0x007AB4FA File Offset: 0x007A96FA
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170027FF RID: 10239
	// (get) Token: 0x06019270 RID: 103024 RVA: 0x007AB4FD File Offset: 0x007A96FD
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002800 RID: 10240
	// (get) Token: 0x06019271 RID: 103025 RVA: 0x007AB500 File Offset: 0x007A9700
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002801 RID: 10241
	// (get) Token: 0x06019272 RID: 103026 RVA: 0x007AB503 File Offset: 0x007A9703
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DBD4 RID: 56276
	private PawnSensoryInfoComponent SensoryComp;

	// Token: 0x0400DBD5 RID: 56277
	private CharacterUnifiedStateComponent UnifiedStateComp;
}
