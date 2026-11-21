using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.NPC.GPUNPC;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200275A RID: 10074
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class CrowdAiController : ControllerBase
{
	// Token: 0x1700285C RID: 10332
	// (get) Token: 0x06019497 RID: 103575 RVA: 0x007B9641 File Offset: 0x007B7841
	public bool IsCrowdAiEnable
	{
		get
		{
			UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
			return crowdAiSubsystem != null && crowdAiSubsystem.IsValid() && this.CrowdAiSwitch;
		}
	}

	// Token: 0x06019498 RID: 103576 RVA: 0x007B965F File Offset: 0x007B785F
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06019499 RID: 103577 RVA: 0x007B9664 File Offset: 0x007B7864
	protected override void OnTick(float delta)
	{
		float num = delta * 0.001f;
		this.HandleDelayRemoveActors(num);
		this.TryUpdateBoidActorSystemBounds((double)num);
		foreach (BP_CrowdAiBoidActorSystemBase_C bp_CrowdAiBoidActorSystemBase_C in this.BoidActorSystemPool)
		{
			UBakedBoneMeshComponent bakedBoneMeshComp = bp_CrowdAiBoidActorSystemBase_C.BakedBoneMeshComp;
			if (bakedBoneMeshComp != null)
			{
				bakedBoneMeshComp.KuroTickComponentOutside(num);
			}
		}
		AKuroCrowdAiManagerProxyActor proxyActor = this.ProxyActor;
		if (proxyActor == null)
		{
			return;
		}
		proxyActor.KuroTickActorOutside(num);
	}

	// Token: 0x0601949A RID: 103578 RVA: 0x007B96E8 File Offset: 0x007B78E8
	protected override bool OnClear()
	{
		this.DisableCrowdAiSystem(true);
		return true;
	}

	// Token: 0x0601949B RID: 103579 RVA: 0x007B96F2 File Offset: 0x007B78F2
	protected void InitCrowdAiConfigByPath(string path)
	{
		if (path == "" || path == "None")
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<BP_CrowdAiConfig_C>(path, delegate([Nullable(2)] BP_CrowdAiConfig_C asset, string _)
		{
			if (asset == null || !asset.IsValid())
			{
				return;
			}
			this.InitCrowdAiConfigByAsset(asset);
		}, 100, "js_undefined");
	}

	// Token: 0x0601949C RID: 103580 RVA: 0x007B9730 File Offset: 0x007B7930
	protected void InitCrowdAiConfigByAsset(BP_CrowdAiConfig_C asset)
	{
		if (asset == null || !asset.IsValid())
		{
			return;
		}
		this.CrowdAiSubsystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroCrowdAiSubsystem.StaticClass()) as UKuroCrowdAiSubsystem);
		this.InitCrowdAiSubsystem(asset);
		this.InitRoleBoidParams(asset);
		int num = asset.Boid种类配置.Num();
		for (int i = 0; i < num; i++)
		{
			BP_Struct_CrowdAiBoidConfig config = asset.Boid种类配置.Get(i);
			if (!this.CreateBoidActorSystemFromConfig(config))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "CrowdAiActorSystem初始化错误!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Index", i);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}
	}

	// Token: 0x0601949D RID: 103581 RVA: 0x007B97DC File Offset: 0x007B79DC
	protected bool CreateBoidActorSystemFromConfig(BP_Struct_CrowdAiBoidConfig config)
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null || !crowdAiSubsystem.IsValid())
		{
			return false;
		}
		GPUNPCData_C gpuNpcDa = config.GpuNpcDa;
		if (gpuNpcDa == null || !gpuNpcDa.IsValid())
		{
			return false;
		}
		this.TmpVector1.Set((double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS, (double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS, (double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS);
		BP_CrowdAiBoidActorSystemBase_C bp_CrowdAiBoidActorSystemBase_C = ActorSystem.Instance.Get(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_CrowdAiBoidActorSystemBase_C;
		bp_CrowdAiBoidActorSystemBase_C.SetActorTickEnabled(false);
		UBakedBoneMeshComponent bakedBoneMeshComp = bp_CrowdAiBoidActorSystemBase_C.BakedBoneMeshComp;
		if (bakedBoneMeshComp != null)
		{
			bakedBoneMeshComp.SetComponentTickEnabled(false);
		}
		UBakedBoneMeshComponent bakedBoneMeshComp2 = bp_CrowdAiBoidActorSystemBase_C.BakedBoneMeshComp;
		if (bakedBoneMeshComp2 != null)
		{
			FVector fvector = this.BoundsOrigin.ToUeVectorOld();
			FVector fvector2 = this.TmpVector1.ToUeVectorOld();
			FBoxSphereBounds fboxSphereBounds = new FBoxSphereBounds(ref fvector, ref fvector2, this.DEFAULT_ACTOR_SYSTEM_BOUNDS);
			bakedBoneMeshComp2.SetCustomBounds(fboxSphereBounds);
		}
		if (!this.InitBoidActorSystem(bp_CrowdAiBoidActorSystemBase_C, config))
		{
			ActorSystem.Instance.Put("CreateBoidActorSystemFromConfig初始化错误", bp_CrowdAiBoidActorSystemBase_C, null);
			return false;
		}
		this.BoidActorSystemPool.Add(bp_CrowdAiBoidActorSystemBase_C);
		return true;
	}

	// Token: 0x0601949E RID: 103582 RVA: 0x007B98DC File Offset: 0x007B7ADC
	protected void InitCrowdAiSubsystem(BP_CrowdAiConfig_C asset)
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null || !crowdAiSubsystem.IsValid())
		{
			return;
		}
		this.CrowdAiSubsystem.GroupNavigationInterval = asset.组寻路间隔;
		this.CrowdAiSubsystem.GroupSplitRadius = asset.分组最大距离;
		this.CrowdAiSubsystem.PauseSeekMinDist = asset.停驻最小目标距离;
		this.CrowdAiSubsystem.PauseSeekMaxTime = asset.停驻计时时间;
		this.CrowdAiSubsystem.PauseSeekMaxSpeed = asset.停驻最大速度;
		this.CrowdAiSubsystem.bEnableTeleport = asset.启用传送;
		this.CrowdAiSubsystem.TeleportMinPlanarDist = asset.触发传送最小水平距离;
		this.CrowdAiSubsystem.TeleportMinVerticalDist = asset.触发传送最小垂直距离;
		this.CrowdAiSubsystem.PauseTeleportMaxPlanarSpeed = asset.暂停传送最大水平速度;
		this.CrowdAiSubsystem.TeleportMinTime = asset.传送最小计数时间;
		this.CrowdAiSubsystem.TeleportMaxTime = asset.传送最大计数时间;
		this.CrowdAiSubsystem.TeleportTargetMaxRadius = asset.传送目标最大半径;
		this.CrowdAiSubsystem.TeleportTargetMinRadius = asset.传送目标最小半径;
		this.CrowdAiSubsystem.TeleportTryCount = asset.最大尝试寻点次数;
		this.CrowdAiSubsystem.bEnableFollowLimitation = asset.启用跟随区域限制;
		this.CrowdAiSubsystem.FanWingEdgesAngle = asset.跟随扇形区域夹角;
		this.CrowdAiSubsystem.FanWingEdgesLen = asset.跟随扇形区域两边长度;
		this.CrowdAiSubsystem.FanBottomEdgeHalfLen = asset.跟随扇形区域底边半长;
		this.CrowdAiSubsystem.FanBottomEdgeDistToWatchingBoid = asset.跟随扇形区域底边距离;
		this.CrowdAiSubsystem.bStickToGround = asset.启用Navmesh贴地修正;
		this.CrowdAiSubsystem.BornDelayMaxTime = asset.出生最大随机延迟时间;
		this.CrowdAiSubsystem.DestroyDelayMaxTime = asset.销毁最大随机延迟时间;
		this.ProxyActor = this.GetNewProxyActor();
		this.ProxyActor.SetActorTickEnabled(false);
		this.ProxyActor.SetEnableParallelUpdate(this.UseParallelUpdate);
	}

	// Token: 0x0601949F RID: 103583 RVA: 0x007B9AA0 File Offset: 0x007B7CA0
	protected void InitRoleBoidParams(BP_CrowdAiConfig_C asset)
	{
		this.RoleParams = new RoleBoidParams();
		this.RoleParams.MinRadius = asset.玩家移动半径;
		this.RoleParams.MaxRadius = asset.玩家待机半径;
		this.RoleParams.MaxRadiusChangeTime = asset.玩家半径变化时间;
	}

	// Token: 0x060194A0 RID: 103584 RVA: 0x007B9AE0 File Offset: 0x007B7CE0
	protected bool InitBoidActorSystem(BP_CrowdAiBoidActorSystemBase_C actorSystem, BP_Struct_CrowdAiBoidConfig config)
	{
		actorSystem.Radius = config.半径;
		actorSystem.HalfHeight = config.半高;
		actorSystem.RelativeTrans = config.相对变换;
		actorSystem.MaxSpeed = config.最大速度;
		actorSystem.MaxAccel = config.最大加速度;
		actorSystem.GroundFriction = config.地面转向摩擦力;
		actorSystem.MovingRadiusFactor = config.移动半径缩放系数;
		actorSystem.WalkMinSpeed = config.移动表现阈值速度;
		actorSystem.IdleMaxSpeed = config.待机表现阈值速度;
		actorSystem.TurnInterpSpeed = config.转向插值速度;
		actorSystem.IdlePerformMinCD = config.待机表演最小冷却时间;
		actorSystem.IdlePerformMaxCD = config.待机表演最大冷却时间;
		actorSystem.IdlePerformMaxPortion = config.待机表演最大比例;
		actorSystem.FleeRadius = config.斥力额外半径;
		actorSystem.MovingFleeRadiusFactor = config.移动斥力额外半径缩放系数;
		actorSystem.ArrivalRadius = config.临近目标减速距离;
		actorSystem.MinDistToNavEdge = config.边界空气墙距离;
		actorSystem.ExtraQueryOffset = config.额外探测距离;
		actorSystem.AnimSequenceConfig = config.动画配置;
		actorSystem.AnimStateConfig = config.状态配置;
		actorSystem.MaterialEffectWithTextureConfig = config.材质贴图DA配置;
		actorSystem.Data = config.GpuNpcDa;
		return actorSystem.InitGpuNpc();
	}

	// Token: 0x060194A1 RID: 103585 RVA: 0x007B9BFC File Offset: 0x007B7DFC
	[NullableContext(2)]
	public void EnableCrowdAiSystemByConfigPath(string path = null)
	{
		if (path == null)
		{
			path = this.SUN_SPIRIT_CONFIG_PATH;
		}
		if (this.CrowdAiSwitch)
		{
			return;
		}
		this.CrowdAiSwitch = true;
		this.BoundsOrigin.Reset();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null && baseCharacter.IsValid())
		{
			this.BoundsOrigin.DeepCopy(Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy);
			this.ToWorldRelativeLocation(this.BoundsOrigin);
		}
		this.InitCrowdAiConfigByPath(path);
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.YJX, "[KuroCrowdAi] 启用CrowdAiSystem", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Emit<bool>(EEventName.OnEnableCrowdAiSystem, true);
	}

	// Token: 0x060194A2 RID: 103586 RVA: 0x007B9CF4 File Offset: 0x007B7EF4
	public void EnableCrowdAiSystemByConfigAsset(BP_CrowdAiConfig_C config)
	{
		if (this.CrowdAiSwitch)
		{
			return;
		}
		this.CrowdAiSwitch = true;
		this.BoundsOrigin.Reset();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null && baseCharacter.IsValid())
		{
			this.BoundsOrigin.DeepCopy(Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy);
			this.ToWorldRelativeLocation(this.BoundsOrigin);
		}
		this.InitCrowdAiConfigByAsset(config);
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.YJX, "[KuroCrowdAi] 启用CrowdAiSystem", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
		EventSystem.Instance.Emit<bool>(EEventName.OnEnableCrowdAiSystem, true);
	}

	// Token: 0x060194A3 RID: 103587 RVA: 0x007B9DE0 File Offset: 0x007B7FE0
	public void DisableCrowdAiSystem(bool bForce = false)
	{
		if (!this.CrowdAiSwitch)
		{
			return;
		}
		this.CrowdAiSwitch = false;
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.YJX, "[KuroCrowdAi] 关闭CrowdAiSystem", default(ReadOnlySpan<ValueTuple<string, object>>));
		EventSystem.Instance.Emit<bool>(EEventName.OnEnableCrowdAiSystem, false);
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
		foreach (int boidId in this.CrowdAiBoidIdSet)
		{
			this.DestroyCrowdAiBoid(boidId, bForce);
		}
		this.CrowdAiBoidIdSet.Clear();
		if (!bForce)
		{
			this.DelayRemovedProxyActorInfo = new DelayRemoveInfo(this.ProxyActor);
			this.DelayRemovedItemSet.Add(this.DelayRemovedProxyActorInfo);
			using (List<BP_CrowdAiBoidActorSystemBase_C>.Enumerator enumerator2 = this.BoidActorSystemPool.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					BP_CrowdAiBoidActorSystemBase_C actor = enumerator2.Current;
					this.DelayRemovedItemSet.Add(new DelayRemoveInfo(actor));
				}
				goto IL_1F8;
			}
		}
		ActorSystem.Instance.Put("DisableCrowdAiSystem", this.ProxyActor, null);
		foreach (BP_CrowdAiBoidActorSystemBase_C actor2 in this.BoidActorSystemPool)
		{
			ActorSystem.Instance.Put("DisableCrowdAiSystem", actor2, null);
		}
		foreach (DelayRemoveInfo delayRemoveInfo in this.DelayRemovedItemSet)
		{
			ActorSystem.Instance.Put("OnWorldDone", delayRemoveInfo.Actor, null);
		}
		this.DelayRemovedItemSet.Clear();
		this.DelayRemovedProxyActorInfo = null;
		IL_1F8:
		this.CurPlayerEntityId = 0;
		this.ProxyActor = null;
		this.BoidActorSystemPool.Clear();
	}

	// Token: 0x060194A4 RID: 103588 RVA: 0x007BA034 File Offset: 0x007B8234
	public int SpawnCrowdAiBoid(int actorSystemIndex, global::Transform transform, bool force = true)
	{
		if (!this.IsCrowdAiEnable)
		{
			return 0;
		}
		if (actorSystemIndex >= this.BoidActorSystemPool.Count)
		{
			return 0;
		}
		AKuroCrowdAiBoidActorSystem akuroCrowdAiBoidActorSystem = this.BoidActorSystemPool[actorSystemIndex];
		FTransform ftransform = transform.ToUeTransformOld();
		int num = akuroCrowdAiBoidActorSystem.SpawnBoidActor(ftransform, force);
		if (num == 0)
		{
			return 0;
		}
		this.CrowdAiBoidIdSet.Add(num);
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null && baseCharacter.IsValid())
		{
			CharacterActorComponent characterActorComponent = Global.BaseCharacter.CharacterActorComponent;
			CharacterCrowdAiComponent characterCrowdAiComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterCrowdAiComponent>() : null;
			UKuroCrowdAiBoidComponent ukuroCrowdAiBoidComponent = (characterCrowdAiComponent != null) ? characterCrowdAiComponent.BoidComponent : null;
			int num2 = (ukuroCrowdAiBoidComponent != null) ? ukuroCrowdAiBoidComponent.BoidId : 0;
			if (num2 != 0)
			{
				this.CurPlayerEntityId = characterActorComponent.Entity.Id;
				UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
				if (crowdAiSubsystem != null)
				{
					crowdAiSubsystem.SetWatchingBoidAndJoinGroup(num, num2);
				}
			}
		}
		return num;
	}

	// Token: 0x060194A5 RID: 103589 RVA: 0x007BA0FC File Offset: 0x007B82FC
	public int GetRandomExistBoidId()
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null || !crowdAiSubsystem.IsValid())
		{
			return 0;
		}
		List<int> array = new List<int>(this.CrowdAiBoidIdSet);
		return MathUtils.Instance.GetRandomItem<int>(array);
	}

	// Token: 0x060194A6 RID: 103590 RVA: 0x007BA13C File Offset: 0x007B833C
	public bool DestroyCrowdAiBoid(int boidId, bool bForce = false)
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null || !crowdAiSubsystem.IsValid())
		{
			return false;
		}
		if (!this.CrowdAiBoidIdSet.Contains(boidId))
		{
			return false;
		}
		this.CrowdAiSubsystem.RemoveBoid(boidId, bForce);
		this.CrowdAiBoidIdSet.Remove(boidId);
		return true;
	}

	// Token: 0x060194A7 RID: 103591 RVA: 0x007BA18E File Offset: 0x007B838E
	public bool HasCrowdAiBoid(int boidId)
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		return crowdAiSubsystem != null && crowdAiSubsystem.IsValid() && this.CrowdAiBoidIdSet.Contains(boidId);
	}

	// Token: 0x060194A8 RID: 103592 RVA: 0x007BA1B5 File Offset: 0x007B83B5
	public void NotifyBoidsAround()
	{
		if (this.CrowdAiSubsystem == null)
		{
			return;
		}
		this.CrowdAiSubsystem.NotifyBoidsAround();
	}

	// Token: 0x060194A9 RID: 103593 RVA: 0x007BA1CC File Offset: 0x007B83CC
	public void NotifyBoidsMoveTo(global::Vector targetLoc)
	{
		if (this.CrowdAiSubsystem == null)
		{
			return;
		}
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		FVector fvector = targetLoc.ToUeVectorOld();
		crowdAiSubsystem.NotifyBoidsMoveTo(fvector);
	}

	// Token: 0x060194AA RID: 103594 RVA: 0x007BA1F6 File Offset: 0x007B83F6
	public void EnableParallelUpdateCrowdAi(bool enable)
	{
		if (this.UseParallelUpdate == enable)
		{
			return;
		}
		this.UseParallelUpdate = enable;
		AKuroCrowdAiManagerProxyActor proxyActor = this.ProxyActor;
		if (proxyActor == null)
		{
			return;
		}
		proxyActor.SetEnableParallelUpdate(enable);
	}

	// Token: 0x060194AB RID: 103595 RVA: 0x007BA21A File Offset: 0x007B841A
	public void EnableCrowdAiDebugMode(bool enable)
	{
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null)
		{
			return;
		}
		crowdAiSubsystem.EnableDebugMode(enable);
	}

	// Token: 0x060194AC RID: 103596 RVA: 0x007BA230 File Offset: 0x007B8430
	public void UpdateDebugNavMeshEdges(double rangeDist)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			return;
		}
		global::Vector actorLocationProxy = characterActorComponent.ActorLocationProxy;
		global::Vector vector = global::Vector.Create(actorLocationProxy);
		global::Vector vector2 = global::Vector.Create(actorLocationProxy);
		global::Vector inB = global::Vector.Create(rangeDist, rangeDist, 500.0);
		vector.AdditionEqual(inB);
		vector2.SubtractionEqual(inB);
		FBox fbox = new FBox();
		fbox.Min = vector2.ToUeVectorOld();
		fbox.Max = vector.ToUeVectorOld();
		fbox.IsValid = 1;
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem == null)
		{
			return;
		}
		crowdAiSubsystem.UpdateDebugNavMeshEdges(fbox);
	}

	// Token: 0x060194AD RID: 103597 RVA: 0x007BA2C4 File Offset: 0x007B84C4
	protected void ToWorldRelativeLocation(global::Vector inOut)
	{
		FIntVector worldOriginLocation = UGameplayStatics.GetWorldOriginLocation(GlobalData.World.GetWorld());
		inOut.X -= (double)worldOriginLocation.X;
		inOut.Y -= (double)worldOriginLocation.Y;
		inOut.Z -= (double)worldOriginLocation.Z;
	}

	// Token: 0x060194AE RID: 103598 RVA: 0x007BA320 File Offset: 0x007B8520
	protected void TryUpdateBoidActorSystemBounds(double deltaSeconds)
	{
		if (this.BoidActorSystemPool.Count == 0)
		{
			this.BoundsUpdateCounter = 0.0;
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null || !baseCharacter.IsValid())
		{
			return;
		}
		this.BoundsUpdateCounter += deltaSeconds;
		if (this.BoundsUpdateCounter > this.BOUNDS_UPDATE_INTERVAL)
		{
			this.BoundsUpdateCounter = 0.0;
			this.BoundsOrigin.DeepCopy(Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy);
			this.ToWorldRelativeLocation(this.BoundsOrigin);
			this.TmpVector1.Set((double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS, (double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS, (double)this.DEFAULT_ACTOR_SYSTEM_BOUNDS);
			foreach (BP_CrowdAiBoidActorSystemBase_C bp_CrowdAiBoidActorSystemBase_C in this.BoidActorSystemPool)
			{
				UBakedBoneMeshComponent bakedBoneMeshComp = bp_CrowdAiBoidActorSystemBase_C.BakedBoneMeshComp;
				if (bakedBoneMeshComp != null)
				{
					FVector fvector = this.BoundsOrigin.ToUeVectorOld();
					FVector fvector2 = this.TmpVector1.ToUeVectorOld();
					FBoxSphereBounds fboxSphereBounds = new FBoxSphereBounds(ref fvector, ref fvector2, this.DEFAULT_ACTOR_SYSTEM_BOUNDS);
					bakedBoneMeshComp.SetCustomBounds(fboxSphereBounds);
				}
			}
		}
	}

	// Token: 0x060194AF RID: 103599 RVA: 0x007BA450 File Offset: 0x007B8650
	protected AKuroCrowdAiManagerProxyActor GetNewProxyActor()
	{
		DelayRemoveInfo delayRemovedProxyActorInfo = this.DelayRemovedProxyActorInfo;
		bool flag;
		if (delayRemovedProxyActorInfo == null)
		{
			flag = false;
		}
		else
		{
			AActor actor = delayRemovedProxyActorInfo.Actor;
			flag = ((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			AKuroCrowdAiManagerProxyActor result = this.DelayRemovedProxyActorInfo.Actor as AKuroCrowdAiManagerProxyActor;
			this.DelayRemovedItemSet.Remove(this.DelayRemovedProxyActorInfo);
			this.DelayRemovedProxyActorInfo = null;
			return result;
		}
		return ActorSystem.Instance.Get(AKuroCrowdAiManagerProxyActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as AKuroCrowdAiManagerProxyActor;
	}

	// Token: 0x060194B0 RID: 103600 RVA: 0x007BA4DC File Offset: 0x007B86DC
	protected BP_CrowdAiBoidActorSystemBase_C GetNewActorSystem()
	{
		int num = (this.DelayRemovedProxyActorInfo != null) ? 2 : 1;
		if (this.DelayRemovedItemSet.Count >= num)
		{
			foreach (DelayRemoveInfo delayRemoveInfo in this.DelayRemovedItemSet)
			{
				if (delayRemoveInfo != this.DelayRemovedProxyActorInfo)
				{
					AActor actor = delayRemoveInfo.Actor;
					if (actor != null && actor.IsValid())
					{
						BP_CrowdAiBoidActorSystemBase_C bp_CrowdAiBoidActorSystemBase_C = delayRemoveInfo.Actor as BP_CrowdAiBoidActorSystemBase_C;
						if (bp_CrowdAiBoidActorSystemBase_C != null)
						{
							this.DelayRemovedItemSet.Remove(delayRemoveInfo);
							return bp_CrowdAiBoidActorSystemBase_C;
						}
					}
				}
			}
		}
		return ActorSystem.Instance.Get(BP_CrowdAiBoidActorSystemBase_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_CrowdAiBoidActorSystemBase_C;
	}

	// Token: 0x060194B1 RID: 103601 RVA: 0x007BA5A8 File Offset: 0x007B87A8
	protected void HandleDelayRemoveActors(float deltaSeconds)
	{
		if (this.DelayRemovedItemSet.Count == 0)
		{
			return;
		}
		List<DelayRemoveInfo> list = new List<DelayRemoveInfo>();
		foreach (DelayRemoveInfo delayRemoveInfo in this.DelayRemovedItemSet)
		{
			delayRemoveInfo.Counter += (double)deltaSeconds;
			AActor actor = delayRemoveInfo.Actor;
			if (actor == null || !actor.IsValid() || delayRemoveInfo.Counter > this.DEFAULT_DELAY_REMOVE_TIME)
			{
				ActorSystem.Instance.Put("HandleDelayRemoveActors", delayRemoveInfo.Actor, null);
				list.Add(delayRemoveInfo);
			}
			else if (delayRemoveInfo != this.DelayRemovedProxyActorInfo)
			{
				BP_CrowdAiBoidActorSystemBase_C bp_CrowdAiBoidActorSystemBase_C = delayRemoveInfo.Actor as BP_CrowdAiBoidActorSystemBase_C;
				if (bp_CrowdAiBoidActorSystemBase_C != null)
				{
					UBakedBoneMeshComponent bakedBoneMeshComp = bp_CrowdAiBoidActorSystemBase_C.BakedBoneMeshComp;
					if (bakedBoneMeshComp != null)
					{
						bakedBoneMeshComp.KuroTickComponentOutside(deltaSeconds);
					}
				}
			}
		}
		foreach (DelayRemoveInfo delayRemoveInfo2 in list)
		{
			if (delayRemoveInfo2 == this.DelayRemovedProxyActorInfo)
			{
				this.DelayRemovedProxyActorInfo = null;
			}
			this.DelayRemovedItemSet.Remove(delayRemoveInfo2);
		}
		DelayRemoveInfo delayRemovedProxyActorInfo = this.DelayRemovedProxyActorInfo;
		if (delayRemovedProxyActorInfo == null)
		{
			return;
		}
		AActor actor2 = delayRemovedProxyActorInfo.Actor;
		if (actor2 == null)
		{
			return;
		}
		actor2.KuroTickActorOutside(deltaSeconds);
	}

	// Token: 0x060194B2 RID: 103602 RVA: 0x007BA700 File Offset: 0x007B8900
	protected unsafe void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (!this.IsCrowdAiEnable || this.CrowdAiBoidIdSet.Count == 0)
		{
			return;
		}
		WorldEntity entity = newEntity.Entity;
		CharacterCrowdAiComponent characterCrowdAiComponent = (entity != null) ? entity.GetComponent<CharacterCrowdAiComponent>() : null;
		UKuroCrowdAiBoidComponent ukuroCrowdAiBoidComponent = (characterCrowdAiComponent != null) ? characterCrowdAiComponent.BoidComponent : null;
		if (ukuroCrowdAiBoidComponent == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[KuroCrowdAi] 切换玩家实体，更换跟随对象";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("oldEntityId", (oldEntity != null) ? new int?(oldEntity.Id) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newEntityId", newEntity.Id);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.CurPlayerEntityId = newEntity.Id;
		int boidId = ukuroCrowdAiBoidComponent.BoidId;
		TArray<int> tarray = new TArray<int>();
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem != null)
		{
			crowdAiSubsystem.GetAllGroupIds(ref tarray);
		}
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			this.CrowdAiSubsystem.ChangeGroupWatchingBoid(tarray.Get(i), boidId);
		}
		foreach (int boidId2 in this.CrowdAiBoidIdSet)
		{
			if (this.CrowdAiSubsystem.GetBoidGroupId(boidId2) == 0)
			{
				this.CrowdAiSubsystem.SetWatchingBoidAndJoinGroup(boidId2, boidId);
			}
		}
	}

	// Token: 0x060194B3 RID: 103603 RVA: 0x007BA87C File Offset: 0x007B8A7C
	protected void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (!this.IsCrowdAiEnable || this.CrowdAiBoidIdSet.Count == 0)
		{
			return;
		}
		if (this.CurPlayerEntityId != handle.Id)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.YJX;
		string message = "[KuroCrowdAi] 玩家实体销毁，取消所有Boid跟随";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", handle.Id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TArray<int> tarray = new TArray<int>();
		UKuroCrowdAiSubsystem crowdAiSubsystem = this.CrowdAiSubsystem;
		if (crowdAiSubsystem != null)
		{
			crowdAiSubsystem.GetAllGroupIds(ref tarray);
		}
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			this.CrowdAiSubsystem.ChangeGroupWatchingBoid(tarray.Get(i), 0);
		}
	}

	// Token: 0x060194B4 RID: 103604 RVA: 0x007BA924 File Offset: 0x007B8B24
	protected void OnClearWorld()
	{
		Log.Instance.Info(ELogModule.NPC, ELogAuthor.YJX, "[KuroCrowdAi] 切换地图清空数据", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.CrowdAiSubsystem = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroCrowdAiSubsystem.StaticClass()) as UKuroCrowdAiSubsystem);
		this.DisableCrowdAiSystem(true);
		this.CurPlayerEntityId = 0;
		this.ProxyActor = null;
		this.BoidActorSystemPool.Clear();
		this.DelayRemovedItemSet.Clear();
		this.DelayRemovedProxyActorInfo = null;
	}

	// Token: 0x1700285D RID: 10333
	// (get) Token: 0x060194B5 RID: 103605 RVA: 0x007BA9A1 File Offset: 0x007B8BA1
	public static CrowdAiController Instance
	{
		get
		{
			return CrowdAiController._Instance;
		}
	}

	// Token: 0x060194B6 RID: 103606 RVA: 0x007BA9A8 File Offset: 0x007B8BA8
	public static CrowdAiController GetOrCreateInstance()
	{
		if (CrowdAiController._Instance == null)
		{
			CrowdAiController.CreateInstance();
		}
		return CrowdAiController._Instance;
	}

	// Token: 0x060194B7 RID: 103607 RVA: 0x007BA9BC File Offset: 0x007B8BBC
	public static bool CreateInstance()
	{
		if (CrowdAiController._Instance != null)
		{
			return true;
		}
		CrowdAiController._Instance = new CrowdAiController();
		return true;
	}

	// Token: 0x060194B8 RID: 103608 RVA: 0x007BA9D2 File Offset: 0x007B8BD2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060194B9 RID: 103609 RVA: 0x007BA9D4 File Offset: 0x007B8BD4
	public static void ResetStaticDefaultValue()
	{
		CrowdAiController._Instance = null;
	}

	// Token: 0x060194BA RID: 103610 RVA: 0x007BA9DC File Offset: 0x007B8BDC
	static CrowdAiController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CrowdAiController.CreateStaticDefaultValue), new Action(CrowdAiController.ResetStaticDefaultValue));
	}

	// Token: 0x0400DD55 RID: 56661
	private readonly float DEFAULT_ACTOR_SYSTEM_BOUNDS = 100000f;

	// Token: 0x0400DD56 RID: 56662
	private readonly double BOUNDS_UPDATE_INTERVAL = 3.0;

	// Token: 0x0400DD57 RID: 56663
	private readonly double DEFAULT_DELAY_REMOVE_TIME = 10.0;

	// Token: 0x0400DD58 RID: 56664
	private readonly string SUN_SPIRIT_CONFIG_PATH = "/Game/Aki/Character/NPC/GPUNPC/BP/CrowdAi/DA_SunSpiritConfig.DA_SunSpiritConfig";

	// Token: 0x0400DD59 RID: 56665
	[Nullable(2)]
	public UKuroCrowdAiSubsystem CrowdAiSubsystem;

	// Token: 0x0400DD5A RID: 56666
	public bool UseParallelUpdate;

	// Token: 0x0400DD5B RID: 56667
	[Nullable(2)]
	protected AKuroCrowdAiManagerProxyActor ProxyActor;

	// Token: 0x0400DD5C RID: 56668
	protected List<BP_CrowdAiBoidActorSystemBase_C> BoidActorSystemPool = new List<BP_CrowdAiBoidActorSystemBase_C>();

	// Token: 0x0400DD5D RID: 56669
	protected HashSet<int> CrowdAiBoidIdSet = new HashSet<int>();

	// Token: 0x0400DD5E RID: 56670
	protected bool CrowdAiSwitch;

	// Token: 0x0400DD5F RID: 56671
	[Nullable(2)]
	public RoleBoidParams RoleParams;

	// Token: 0x0400DD60 RID: 56672
	protected int CurPlayerEntityId;

	// Token: 0x0400DD61 RID: 56673
	protected double BoundsUpdateCounter;

	// Token: 0x0400DD62 RID: 56674
	protected global::Vector BoundsOrigin = global::Vector.Create();

	// Token: 0x0400DD63 RID: 56675
	[Nullable(2)]
	protected DelayRemoveInfo DelayRemovedProxyActorInfo;

	// Token: 0x0400DD64 RID: 56676
	protected HashSet<DelayRemoveInfo> DelayRemovedItemSet = new HashSet<DelayRemoveInfo>();

	// Token: 0x0400DD65 RID: 56677
	protected global::Vector TmpVector1 = global::Vector.Create();

	// Token: 0x0400DD66 RID: 56678
	[Nullable(2)]
	private static CrowdAiController _Instance;
}
