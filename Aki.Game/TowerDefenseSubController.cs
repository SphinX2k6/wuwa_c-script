using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02000ED5 RID: 3797
public class TowerDefenseSubController : KscSubControllerBase
{
	// Token: 0x06005EB1 RID: 24241 RVA: 0x00119C75 File Offset: 0x00117E75
	protected override void OnInit()
	{
		TowerDefensePlayerController.OnInit();
	}

	// Token: 0x06005EB2 RID: 24242 RVA: 0x00119C7D File Offset: 0x00117E7D
	protected override void OnClear()
	{
		TowerDefensePlayerController.OnClear();
	}

	// Token: 0x06005EB3 RID: 24243 RVA: 0x00119C85 File Offset: 0x00117E85
	protected override void OnTick(float delta)
	{
		TowerDefenseEventController.Instance.ControllerTick(delta);
	}

	// Token: 0x06005EB4 RID: 24244 RVA: 0x00119C92 File Offset: 0x00117E92
	protected override void CreateModel()
	{
		this.SubModel = new TowerDefenseSubModel();
	}

	// Token: 0x06005EB5 RID: 24245 RVA: 0x00119C9F File Offset: 0x00117E9F
	public override bool IsTargetMap(int instSubType)
	{
		return instSubType == 37;
	}

	// Token: 0x06005EB6 RID: 24246 RVA: 0x00119CA6 File Offset: 0x00117EA6
	protected override void OnInitMap()
	{
		TowerDefenseEventController.Instance.InitMap();
	}

	// Token: 0x06005EB7 RID: 24247 RVA: 0x00119CB2 File Offset: 0x00117EB2
	protected override void OnWorldDone()
	{
		TowerDefensePlayerController.OnStart();
		TowerDefenseInputController.OnStart();
		TrapDefensePsFeedbackManager.Initialize();
		TrapDefenseBattleGuideManager.Initialize();
		TowerDefenseEventController.Instance.OnWorldDone();
	}

	// Token: 0x06005EB8 RID: 24248 RVA: 0x00119CD4 File Offset: 0x00117ED4
	protected override void OnWorldReset()
	{
		TowerDefenseEventController.Instance.OnWorldReset();
		TowerDefensePlayerController.OnStop();
		TowerDefenseInputController.OnStop();
		TrapDefensePsFeedbackManager.Clear();
		TrapDefenseBattleGuideManager.Clear();
	}

	// Token: 0x06005EB9 RID: 24249 RVA: 0x00119CF6 File Offset: 0x00117EF6
	[NullableContext(1)]
	public override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
		TowerDefenseEventController.Instance.OnEntityRemoved(context, protoContexts);
	}

	// Token: 0x06005EBA RID: 24250 RVA: 0x00119D04 File Offset: 0x00117F04
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = TowerDefenseEventController.Instance.EntityRedirectFilter;
	}

	// Token: 0x06005EBB RID: 24251 RVA: 0x00119D16 File Offset: 0x00117F16
	protected override void AddKscPlayerEntity()
	{
	}
}
