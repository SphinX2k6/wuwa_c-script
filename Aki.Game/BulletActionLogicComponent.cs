using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.TypeScript.Game.NewWorld.Bullet.LogicDataClass;
using UnrealEngine;

// Token: 0x02002348 RID: 9032
[NullableContext(1)]
[Nullable(0)]
public class BulletActionLogicComponent : EntityComponent
{
	// Token: 0x1700221A RID: 8730
	// (get) Token: 0x060163A9 RID: 91049 RVA: 0x0067C4ED File Offset: 0x0067A6ED
	public bool ObstaclesDetect
	{
		get
		{
			return this.ObstaclesDetectInternal;
		}
	}

	// Token: 0x060163AA RID: 91050 RVA: 0x0067C4F8 File Offset: 0x0067A6F8
	protected override bool OnStart()
	{
		BulletEntity bulletEntity = base.Entity as BulletEntity;
		this.BulletInfo = ((bulletEntity != null) ? bulletEntity.GetBulletInfo() : null);
		this.BulletInfo.ActionLogicComponent = this;
		this.BulletData = this.BulletInfo.BulletDataMain;
		this.BulletIsProcessByTime = (this.BulletData.Base.ContinuesCollision && (this.BulletInfo.CollisionInfo.IntervalMs > 0f || this.BulletData.Base.CollisionActiveDelay > 0f));
		List<LogicDataBase> gbDataList = this.BulletData.Execution.GbDataList;
		if (gbDataList != null && gbDataList.Count > 0)
		{
			foreach (LogicDataBase logicDataBase in gbDataList)
			{
				BulletLogicControllerBase bulletLogicControllerBase = this.NewController(logicDataBase);
				if (bulletLogicControllerBase != null)
				{
					if (logicDataBase.ExecuteStage == EBulletLogicStage.OnBegin)
					{
						if (this.OnBeginController == null)
						{
							this.OnBeginController = new List<BulletLogicControllerBase>();
						}
						this.OnBeginController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnDestroy)
					{
						if (this.OnDestroyController == null)
						{
							this.OnDestroyController = new List<BulletLogicControllerBase>();
						}
						this.OnDestroyController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnHit)
					{
						if (this.OnHitController == null)
						{
							this.OnHitController = new List<BulletLogicControllerBase>();
						}
						this.OnHitController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnRebound)
					{
						if (this.OnReboundController == null)
						{
							this.OnReboundController = new List<BulletLogicReboundController>();
						}
						this.OnReboundController.Add(bulletLogicControllerBase as BulletLogicReboundController);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnSupport)
					{
						if (this.OnSupportController == null)
						{
							this.OnSupportController = new List<BulletLogicControllerBase>();
						}
						this.OnSupportController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.ReplaceMove)
					{
						if (this.OnMovementController == null)
						{
							this.OnMovementController = new List<BulletLogicControllerBase>();
						}
						this.OnMovementController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnHitBullet)
					{
						if (this.OnHitBulletController == null)
						{
							this.OnHitBulletController = new List<BulletLogicControllerBase>();
						}
						this.OnHitBulletController.Add(bulletLogicControllerBase);
					}
					else if (logicDataBase.ExecuteStage == EBulletLogicStage.OnBulletCollision)
					{
						if (this.OnCollisionController == null)
						{
							this.OnCollisionController = new List<BulletLogicBulletCollisionController>();
						}
						this.OnCollisionController.Add(bulletLogicControllerBase as BulletLogicBulletCollisionController);
					}
					if (bulletLogicControllerBase.NeedTick)
					{
						if (this.OnTickController == null)
						{
							this.OnTickController = new List<BulletLogicControllerBase>();
						}
						this.OnTickController.Add(bulletLogicControllerBase);
					}
				}
			}
		}
		return true;
	}

	// Token: 0x060163AB RID: 91051 RVA: 0x0067C798 File Offset: 0x0067A998
	public void OnAfterInit()
	{
		if (this.OnBeginController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnBeginController)
			{
				bulletLogicControllerBase.OnInit();
				bulletLogicControllerBase.BulletLogicActionFromBase(null);
			}
		}
		if (this.OnDestroyController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase2 in this.OnDestroyController)
			{
				bulletLogicControllerBase2.OnInit();
			}
		}
		if (this.OnHitController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase3 in this.OnHitController)
			{
				bulletLogicControllerBase3.OnInit();
			}
		}
		if (this.OnReboundController != null)
		{
			foreach (BulletLogicReboundController bulletLogicReboundController in this.OnReboundController)
			{
				bulletLogicReboundController.OnInit();
			}
		}
		if (this.OnCollisionController != null)
		{
			foreach (BulletLogicBulletCollisionController bulletLogicBulletCollisionController in this.OnCollisionController)
			{
				bulletLogicBulletCollisionController.OnInit();
			}
		}
		if (this.OnSupportController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase4 in this.OnSupportController)
			{
				bulletLogicControllerBase4.OnInit();
			}
		}
		if (this.OnMovementController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase5 in this.OnMovementController)
			{
				bulletLogicControllerBase5.OnInit();
			}
		}
		if (this.OnHitBulletController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase6 in this.OnHitBulletController)
			{
				bulletLogicControllerBase6.OnInit();
			}
		}
	}

	// Token: 0x060163AC RID: 91052 RVA: 0x0067C9E8 File Offset: 0x0067ABE8
	protected override void OnTick(float delta)
	{
		if (!this.BulletInfo.IsInit)
		{
			return;
		}
		if (this.BulletIsProcessByTime && this.BulletInfo.CollisionInfo.HaveCharacterInBullet && this.OnHitController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnHitController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(null);
			}
		}
		if (!this.BulletInfo.NeedDestroy && this.OnTickController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase2 in this.OnTickController)
			{
				bulletLogicControllerBase2.Tick(delta);
			}
		}
	}

	// Token: 0x060163AD RID: 91053 RVA: 0x0067CAC0 File Offset: 0x0067ACC0
	protected override bool OnEnd()
	{
		if (this.OnBeginController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnBeginController)
			{
				bulletLogicControllerBase.OnBulletDestroy();
			}
		}
		if (this.OnHitController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase2 in this.OnHitController)
			{
				bulletLogicControllerBase2.OnBulletDestroy();
			}
		}
		if (this.OnDestroyController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase3 in this.OnDestroyController)
			{
				bulletLogicControllerBase3.OnBulletDestroy();
			}
		}
		if (this.OnReboundController != null)
		{
			foreach (BulletLogicReboundController bulletLogicReboundController in this.OnReboundController)
			{
				bulletLogicReboundController.OnBulletDestroy();
			}
		}
		if (this.OnCollisionController != null)
		{
			foreach (BulletLogicBulletCollisionController bulletLogicBulletCollisionController in this.OnCollisionController)
			{
				bulletLogicBulletCollisionController.OnBulletDestroy();
			}
		}
		if (this.OnSupportController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase4 in this.OnSupportController)
			{
				bulletLogicControllerBase4.OnBulletDestroy();
			}
		}
		if (this.OnMovementController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase5 in this.OnMovementController)
			{
				bulletLogicControllerBase5.OnBulletDestroy();
			}
		}
		if (this.OnHitBulletController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase6 in this.OnHitBulletController)
			{
				bulletLogicControllerBase6.OnBulletDestroy();
			}
		}
		this.ObstaclesDetectInternal = false;
		return true;
	}

	// Token: 0x060163AE RID: 91054 RVA: 0x0067CD14 File Offset: 0x0067AF14
	public void ActionDestroy()
	{
		if (this.OnDestroyController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnDestroyController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(null);
			}
		}
	}

	// Token: 0x060163AF RID: 91055 RVA: 0x0067CD70 File Offset: 0x0067AF70
	public void ActionHit(BulletHitActorData hitActorData)
	{
		if (!this.BulletInfo.IsInit || this.BulletIsProcessByTime)
		{
			return;
		}
		if (this.OnHitController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnHitController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(hitActorData);
			}
		}
	}

	// Token: 0x060163B0 RID: 91056 RVA: 0x0067CDE0 File Offset: 0x0067AFE0
	public void ActionHitObstacles(BulletHitActorData hitActorData)
	{
		if (!this.BulletInfo.IsInit)
		{
			return;
		}
		if (this.OnHitController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnHitController)
			{
				bulletLogicControllerBase.BulletLogicActionOnHitObstaclesFromBase(hitActorData);
			}
		}
	}

	// Token: 0x060163B1 RID: 91057 RVA: 0x0067CE48 File Offset: 0x0067B048
	public void ActionRebound(BulletInfo otherBulletInfo)
	{
		if (this.OnReboundController != null)
		{
			foreach (BulletLogicReboundController bulletLogicReboundController in this.OnReboundController)
			{
				bulletLogicReboundController.BulletLogicAction(otherBulletInfo);
			}
		}
	}

	// Token: 0x060163B2 RID: 91058 RVA: 0x0067CEA4 File Offset: 0x0067B0A4
	public void ActionCollision(BulletInfo otherBulletInfo)
	{
		if (this.OnCollisionController != null)
		{
			foreach (BulletLogicBulletCollisionController bulletLogicBulletCollisionController in this.OnCollisionController)
			{
				bulletLogicBulletCollisionController.BulletLogicAction(otherBulletInfo);
			}
		}
	}

	// Token: 0x060163B3 RID: 91059 RVA: 0x0067CF00 File Offset: 0x0067B100
	public unsafe void ActionSupport(Entity otherBullet)
	{
		if ((this.OnSupportController == null || this.OnSupportController.Count <= 0) && BulletConstant.Instance.OpenCollisionLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "与子弹碰撞, 执行Support";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("This.Id", this.BulletInfo.BulletRowName);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "this.OnSupportController.Len";
			List<BulletLogicControllerBase> onSupportController = this.OnSupportController;
			ptr = new ValueTuple<string, object>(item, (onSupportController != null) ? new int?(onSupportController.Count) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (this.OnSupportController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnSupportController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(otherBullet);
			}
		}
	}

	// Token: 0x060163B4 RID: 91060 RVA: 0x0067D004 File Offset: 0x0067B204
	public void ActionTickMovement(float delta)
	{
		if (this.OnMovementController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnMovementController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(delta);
			}
		}
	}

	// Token: 0x060163B5 RID: 91061 RVA: 0x0067D064 File Offset: 0x0067B264
	public void ActionHitBullet(BulletInfo otherBulletInfo)
	{
		if (this.OnHitBulletController != null)
		{
			foreach (BulletLogicControllerBase bulletLogicControllerBase in this.OnHitBulletController)
			{
				bulletLogicControllerBase.BulletLogicActionFromBase(otherBulletInfo);
			}
		}
	}

	// Token: 0x060163B6 RID: 91062 RVA: 0x0067D0C0 File Offset: 0x0067B2C0
	[return: Nullable(2)]
	private BulletLogicControllerBase NewController(UKuroBpDataAsset bulletLogicBase)
	{
		LogicDataCreateBullet logicDataCreateBullet = bulletLogicBase as LogicDataCreateBullet;
		if (logicDataCreateBullet != null)
		{
			return new BulletLogicCreateBulletController(logicDataCreateBullet, base.Entity);
		}
		LogicDataDestroyBullet logicDataDestroyBullet = bulletLogicBase as LogicDataDestroyBullet;
		if (logicDataDestroyBullet != null)
		{
			return new BulletLogicDestroyBulletController(logicDataDestroyBullet, base.Entity);
		}
		LogicDataForce logicDataForce = bulletLogicBase as LogicDataForce;
		if (logicDataForce != null)
		{
			return new BulletLogicForceController(logicDataForce, base.Entity);
		}
		LogicDataSpeedReduce logicDataSpeedReduce = bulletLogicBase as LogicDataSpeedReduce;
		if (logicDataSpeedReduce != null)
		{
			this.ObstaclesDetectInternal = true;
			return new BulletLogicSpeedReduceController(logicDataSpeedReduce, base.Entity);
		}
		LogicDataAdditiveAccelerate logicDataAdditiveAccelerate = bulletLogicBase as LogicDataAdditiveAccelerate;
		if (logicDataAdditiveAccelerate != null)
		{
			return new BulletLogicAdditiveAccelerateController(logicDataAdditiveAccelerate, base.Entity);
		}
		LogicDataFreeze logicDataFreeze = bulletLogicBase as LogicDataFreeze;
		if (logicDataFreeze != null)
		{
			return new BulletLogicFreezeController(logicDataFreeze, base.Entity);
		}
		LogicDataRebound logicDataRebound = bulletLogicBase as LogicDataRebound;
		if (logicDataRebound != null)
		{
			return new BulletLogicReboundController(logicDataRebound, base.Entity);
		}
		LogicDataBulletCollision logicDataBulletCollision = bulletLogicBase as LogicDataBulletCollision;
		if (logicDataBulletCollision != null)
		{
			return new BulletLogicBulletCollisionController(logicDataBulletCollision, base.Entity);
		}
		LogicDataSupport logicDataSupport = bulletLogicBase as LogicDataSupport;
		if (logicDataSupport != null)
		{
			return new BulletLogicSupportController(logicDataSupport, base.Entity);
		}
		LogicDataSplineMovement logicDataSplineMovement = bulletLogicBase as LogicDataSplineMovement;
		if (logicDataSplineMovement != null)
		{
			return new BulletLogicCurveMovementController(logicDataSplineMovement, base.Entity);
		}
		LogicDataShakeScreen logicDataShakeScreen = bulletLogicBase as LogicDataShakeScreen;
		if (logicDataShakeScreen != null)
		{
			return new BulletLogicShakeCameraController(logicDataShakeScreen, base.Entity);
		}
		LogicDataShowMesh logicDataShowMesh = bulletLogicBase as LogicDataShowMesh;
		if (logicDataShowMesh != null)
		{
			return new BulletLogicShowMesh(logicDataShowMesh, base.Entity);
		}
		LogicDataSuiGuang logicDataSuiGuang = bulletLogicBase as LogicDataSuiGuang;
		if (logicDataSuiGuang != null)
		{
			return new BulletLogicSuiGuang(logicDataSuiGuang, base.Entity);
		}
		LogicDataSpawnObstacles logicDataSpawnObstacles = bulletLogicBase as LogicDataSpawnObstacles;
		if (logicDataSpawnObstacles != null)
		{
			return new BulletLogicSpawnObstacles(logicDataSpawnObstacles, base.Entity);
		}
		LogicDataManipulatableCreateBullet logicDataManipulatableCreateBullet = bulletLogicBase as LogicDataManipulatableCreateBullet;
		if (logicDataManipulatableCreateBullet != null)
		{
			return new BulletLogicManipulatableCreateBullet(logicDataManipulatableCreateBullet, base.Entity);
		}
		LogicDataManipulatableTagsChange logicDataManipulatableTagsChange = bulletLogicBase as LogicDataManipulatableTagsChange;
		if (logicDataManipulatableTagsChange != null)
		{
			return new BulletLogicManipulatableTagsChange(logicDataManipulatableTagsChange, base.Entity);
		}
		LogicDataWhirlpool logicDataWhirlpool = bulletLogicBase as LogicDataWhirlpool;
		if (logicDataWhirlpool != null)
		{
			return new BulletLogicWhirlpool(logicDataWhirlpool, base.Entity);
		}
		LogicDataSpherePull logicDataSpherePull = bulletLogicBase as LogicDataSpherePull;
		if (logicDataSpherePull != null)
		{
			return new BulletLogicSpherePull(logicDataSpherePull, base.Entity);
		}
		LogicDataDestroyOtherBullet logicDataDestroyOtherBullet = bulletLogicBase as LogicDataDestroyOtherBullet;
		if (logicDataDestroyOtherBullet != null)
		{
			return new BulletLogicDestroyOtherBullet(logicDataDestroyOtherBullet, base.Entity);
		}
		LogicDataShield logicDataShield = bulletLogicBase as LogicDataShield;
		if (logicDataShield != null)
		{
			return new BulletLogicShieldController(logicDataShield, base.Entity);
		}
		LogicDataSummonRandom logicDataSummonRandom = bulletLogicBase as LogicDataSummonRandom;
		if (logicDataSummonRandom != null)
		{
			return new BulletLogicSummonRandom(logicDataSummonRandom, base.Entity);
		}
		LogicDataCameraModify logicDataCameraModify = bulletLogicBase as LogicDataCameraModify;
		if (logicDataCameraModify != null)
		{
			return new BulletLogicCameraModify(logicDataCameraModify, base.Entity);
		}
		LogicDataEffectSave logicDataEffectSave = bulletLogicBase as LogicDataEffectSave;
		if (logicDataEffectSave != null)
		{
			return new BulletLogicEffectSave(logicDataEffectSave, base.Entity);
		}
		LogicDataAddBuff logicDataAddBuff = bulletLogicBase as LogicDataAddBuff;
		if (logicDataAddBuff != null)
		{
			return new BulletLogicAddBuff(logicDataAddBuff, base.Entity);
		}
		return null;
	}

	// Token: 0x060163B7 RID: 91063 RVA: 0x0067D33C File Offset: 0x0067B53C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BulletActionLogicComponent bulletActionLogicComponent = (BulletActionLogicComponent)componentTemplate;
		if (bulletActionLogicComponent.BulletInfo == null)
		{
			this.BulletInfo = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletInfo), "BulletInfo"))
		{
			return false;
		}
		if (bulletActionLogicComponent.BulletData == null)
		{
			this.BulletData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BulletData), "BulletData"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnBeginController == null)
		{
			this.OnBeginController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnBeginController), "OnBeginController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnHitController == null)
		{
			this.OnHitController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnHitController), "OnHitController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnDestroyController == null)
		{
			this.OnDestroyController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnDestroyController), "OnDestroyController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnReboundController == null)
		{
			this.OnReboundController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnReboundController), "OnReboundController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnCollisionController == null)
		{
			this.OnCollisionController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnCollisionController), "OnCollisionController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnSupportController == null)
		{
			this.OnSupportController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnSupportController), "OnSupportController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnMovementController == null)
		{
			this.OnMovementController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnMovementController), "OnMovementController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnHitBulletController == null)
		{
			this.OnHitBulletController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnHitBulletController), "OnHitBulletController"))
		{
			return false;
		}
		if (bulletActionLogicComponent.OnTickController == null)
		{
			this.OnTickController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OnTickController), "OnTickController"))
		{
			return false;
		}
		this.ObstaclesDetectInternal = bulletActionLogicComponent.ObstaclesDetectInternal;
		this.BulletIsProcessByTime = bulletActionLogicComponent.BulletIsProcessByTime;
		return true;
	}

	// Token: 0x1700221B RID: 8731
	// (get) Token: 0x060163B8 RID: 91064 RVA: 0x0067D54D File Offset: 0x0067B74D
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700221C RID: 8732
	// (get) Token: 0x060163B9 RID: 91065 RVA: 0x0067D550 File Offset: 0x0067B750
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700221D RID: 8733
	// (get) Token: 0x060163BA RID: 91066 RVA: 0x0067D553 File Offset: 0x0067B753
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400BB95 RID: 48021
	[Nullable(2)]
	private BulletInfo BulletInfo;

	// Token: 0x0400BB96 RID: 48022
	[Nullable(2)]
	private BulletDataMain BulletData;

	// Token: 0x0400BB97 RID: 48023
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnBeginController;

	// Token: 0x0400BB98 RID: 48024
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnHitController;

	// Token: 0x0400BB99 RID: 48025
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnDestroyController;

	// Token: 0x0400BB9A RID: 48026
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicReboundController> OnReboundController;

	// Token: 0x0400BB9B RID: 48027
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicBulletCollisionController> OnCollisionController;

	// Token: 0x0400BB9C RID: 48028
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnSupportController;

	// Token: 0x0400BB9D RID: 48029
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnMovementController;

	// Token: 0x0400BB9E RID: 48030
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnHitBulletController;

	// Token: 0x0400BB9F RID: 48031
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<BulletLogicControllerBase> OnTickController;

	// Token: 0x0400BBA0 RID: 48032
	private bool ObstaclesDetectInternal;

	// Token: 0x0400BBA1 RID: 48033
	private bool BulletIsProcessByTime;
}
