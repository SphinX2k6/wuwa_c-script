using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000329 RID: 809
[NullableContext(1)]
[Nullable(0)]
public class FinalBattleSubController : KscSubControllerBase
{
	// Token: 0x06002DA3 RID: 11683 RVA: 0x0010E6E4 File Offset: 0x0010C8E4
	protected override void CreateModel()
	{
		this.SubModel = new FinalBattleSubModel();
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x0010E6F1 File Offset: 0x0010C8F1
	public FinalBattleSubModel GetModel()
	{
		return (FinalBattleSubModel)this.SubModel;
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x0010E6FE File Offset: 0x0010C8FE
	public override bool IsTargetMap(int instSubType)
	{
		return false;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x0010E701 File Offset: 0x0010C901
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = this.EntityRedirectFilter;
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x0010E70F File Offset: 0x0010C90F
	protected override void OnInitMap()
	{
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x0010E711 File Offset: 0x0010C911
	protected override void OnMapLoaded()
	{
		this.InitBulletWorld();
		this.LoadBulletDataTable();
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x0010E71F File Offset: 0x0010C91F
	protected override void OnWorldDone()
	{
		DamageUiController.Instance.UpdateKscWorld();
	}

	// Token: 0x06002DAA RID: 11690 RVA: 0x0010E72B File Offset: 0x0010C92B
	protected override void OnWorldReset()
	{
		this.ClearBulletWorld();
		this.GetModel().BulletDataTable = null;
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x0010E73F File Offset: 0x0010C93F
	protected override void AddKscPlayerEntity()
	{
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x0010E744 File Offset: 0x0010C944
	private void LoadBulletDataTable()
	{
		FinalBattleSubModel model = this.GetModel();
		string bulletDtPath = model.GetBulletDtPath();
		if (string.IsNullOrEmpty(bulletDtPath))
		{
			model.BulletDataTable = null;
			return;
		}
		UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(bulletDtPath, "js_undefined");
		if (udataTable == null || !udataTable.IsValid())
		{
			model.BulletDataTable = null;
			KscLog.EModule flag = KscLog.EModule.Common;
			ELogAuthor author = ELogAuthor.CFT;
			UObject kscWorld = KscEnv.Instance.KscWorld;
			string log = "FinalBattle加载子弹DT失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", bulletDtPath);
			KscLog.Warn(flag, author, kscWorld, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		model.BulletDataTable = udataTable;
		UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
		if (kuroBulletWorld != null)
		{
			kuroBulletWorld.AddCommonBulletDataTable(udataTable);
		}
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x0010E7DC File Offset: 0x0010C9DC
	public override void OnEntityRemoved(KscRemoveContext context, Dictionary<long, SimpleCombatEntityDieContext> protoContexts)
	{
		IFinalBattleCombatInfo entity = this.GetModel().GetEntity((int)context.CreatureDataId);
		if (entity == null)
		{
			return;
		}
		SimpleCombatEntityDieContext simpleCombatEntityDieContext = SimpleCombatEntityDieContext.Create();
		Aki.Protocol.Vector vector = Aki.Protocol.Vector.Create();
		vector.X = (float)context.Location.X;
		vector.Y = (float)context.Location.Y;
		vector.Z = (float)context.Location.Z;
		simpleCombatEntityDieContext.DiePos = vector;
		if (entity.EntityType == EFinalBattleEntityType.Monster)
		{
			GPUMonsterKilledCtxPb gpumonsterKilledCtxPb = GPUMonsterKilledCtxPb.Create();
			gpumonsterKilledCtxPb.EntityId = context.CreatureDataId;
			simpleCombatEntityDieContext.GPUMonsterKilledCtx = gpumonsterKilledCtxPb;
		}
		else if (entity.EntityType == EFinalBattleEntityType.Role)
		{
			GPURoleKilledCtxPb gpuroleKilledCtxPb = GPURoleKilledCtxPb.Create();
			gpuroleKilledCtxPb.EntityId = context.CreatureDataId;
			simpleCombatEntityDieContext.GPURoleKilledCtx = gpuroleKilledCtxPb;
		}
		protoContexts[context.CreatureDataId] = simpleCombatEntityDieContext;
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x0010E8A0 File Offset: 0x0010CAA0
	protected override void SyncPlayerTransform()
	{
		if (this.GetModel().KscPlayerEntity == null)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || getCurrentEntity.Entity == null)
		{
			return;
		}
		FTransformDouble ftransformDouble = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>().Actor.D_GetTransform();
		AKSC_Entity kscPlayerEntity = this.GetModel().KscPlayerEntity;
		if (kscPlayerEntity == null)
		{
			return;
		}
		kscPlayerEntity.SetTransformByWorld(ftransformDouble);
	}

	// Token: 0x040029C2 RID: 10690
	private readonly FinalBattleEntityRedirectFilter EntityRedirectFilter = new FinalBattleEntityRedirectFilter();
}
