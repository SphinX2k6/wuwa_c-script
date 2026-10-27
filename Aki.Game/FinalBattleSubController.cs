using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000E74 RID: 3700
[NullableContext(1)]
[Nullable(0)]
public class FinalBattleSubController : KscSubControllerBase
{
	// Token: 0x06005A0C RID: 23052 RVA: 0x00106A34 File Offset: 0x00104C34
	protected override void CreateModel()
	{
		this.SubModel = new FinalBattleSubModel();
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x00106A41 File Offset: 0x00104C41
	public FinalBattleSubModel GetModel()
	{
		return (FinalBattleSubModel)this.SubModel;
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x00106A4E File Offset: 0x00104C4E
	public override bool IsTargetMap(int instSubType)
	{
		return false;
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x00106A51 File Offset: 0x00104C51
	protected override void CreateEntityFilter()
	{
		this.RedirectFilter = this.EntityRedirectFilter;
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x00106A5F File Offset: 0x00104C5F
	protected override void OnInitMap()
	{
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x00106A61 File Offset: 0x00104C61
	protected override void OnMapLoaded()
	{
		this.InitBulletWorld();
		this.LoadBulletDataTable();
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x00106A6F File Offset: 0x00104C6F
	protected override void OnWorldDone()
	{
		DamageUiController.Instance.UpdateKscWorld();
	}

	// Token: 0x06005A13 RID: 23059 RVA: 0x00106A7B File Offset: 0x00104C7B
	protected override void OnWorldReset()
	{
		this.ClearBulletWorld();
		this.GetModel().BulletDataTable = null;
	}

	// Token: 0x06005A14 RID: 23060 RVA: 0x00106A8F File Offset: 0x00104C8F
	protected override void AddKscPlayerEntity()
	{
	}

	// Token: 0x06005A15 RID: 23061 RVA: 0x00106A94 File Offset: 0x00104C94
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

	// Token: 0x06005A16 RID: 23062 RVA: 0x00106B2C File Offset: 0x00104D2C
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

	// Token: 0x06005A17 RID: 23063 RVA: 0x00106BF0 File Offset: 0x00104DF0
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

	// Token: 0x04002927 RID: 10535
	private readonly FinalBattleEntityRedirectFilter EntityRedirectFilter = new FinalBattleEntityRedirectFilter();
}
