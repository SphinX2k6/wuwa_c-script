using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x0200038A RID: 906
public class TowerDefenseSubController : KscSubControllerBase
{
	// Token: 0x06003248 RID: 12872 RVA: 0x00121955 File Offset: 0x0011FB55
	protected override void OnInit()
	{
		TowerDefensePlayerController.OnInit();
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x0012195D File Offset: 0x0011FB5D
	protected override void OnClear()
	{
		TowerDefensePlayerController.OnClear();
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x00121965 File Offset: 0x0011FB65
	protected override void OnTick(float delta)
	{
		TowerDefenseEventController.Instance.ControllerTick(delta);
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00121972 File Offset: 0x0011FB72
	protected override void CreateModel()
	{
		this.SubModel = new TowerDefenseSubModel();
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x0012197F File Offset: 0x0011FB7F
	public override bool IsTargetMap(int instSubType)
	{
		return instSubType == 37;
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00121986 File Offset: 0x0011FB86
	protected override void OnInitMap()
	{
		TowerDefenseEventController.Instance.InitMap();
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x00121992 File Offset: 0x0011FB92
	protected override void OnWorldDone()
	{
		TowerDefensePlayerController.OnStart();
		TowerDefenseInputController.OnStart();
		TrapDefensePsFeedbackManager.Initialize();
		TrapDefenseBattleGuideManager.Initialize();
		TowerDefenseEventController.Instance.OnWorldDone();
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x001219B4 File Offset: 0x0011FBB4
	protected override void OnWorldReset()
	{
		TowerDefenseEventController.Instance.OnWorldReset();
		TowerDefensePlayerController.OnStop();
		TowerDefenseInputController.OnStop();
		TrapDefensePsFeedbackManager.Clear();
		TrapDefenseBattleGuideManager.Clear();
	}

	// Token: 0x06003250 RID: 12880 RVA: 0x001219D6 File Offset: 0x0011FBD6
	[NullableContext(1)]
	public override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
		TowerDefenseEventController.Instance.OnEntityRemoved(context, protoContexts);
	}

	// Token: 0x06003251 RID: 12881 RVA: 0x001219E4 File Offset: 0x0011FBE4
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = TowerDefenseEventController.Instance.EntityRedirectFilter;
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x001219F6 File Offset: 0x0011FBF6
	protected override void AddKscPlayerEntity()
	{
	}
}
