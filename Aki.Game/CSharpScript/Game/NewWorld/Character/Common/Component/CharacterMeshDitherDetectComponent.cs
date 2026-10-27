using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CC RID: 28876
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterMeshDitherDetectComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009CAB RID: 40107
		// (get) Token: 0x06046758 RID: 288600 RVA: 0x011B0816 File Offset: 0x011AEA16
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Type[] Dependencies
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x06046759 RID: 288601 RVA: 0x011B0838 File Offset: 0x011AEA38
		private static int CompareMeshDitherDetectConfigPriority(MeshDitherDetectConfig a, MeshDitherDetectConfig b)
		{
			if (a.Priority == b.Priority)
			{
				return -1;
			}
			return b.Priority - a.Priority;
		}

		// Token: 0x17009CAC RID: 40108
		// (get) Token: 0x0604675A RID: 288602 RVA: 0x011B0858 File Offset: 0x011AEA58
		public float TraceCapsuleWidth
		{
			get
			{
				float val = 0f;
				CharacterActorComponent actorComp = this.ActorComp;
				float? num;
				if (actorComp == null)
				{
					num = null;
				}
				else
				{
					UCapsuleComponent capsuleComponent = actorComp.Actor.CapsuleComponent;
					num = ((capsuleComponent != null) ? new float?(capsuleComponent.GetScaledCapsuleRadius()) : null);
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault();
				MeshDitherDetectConfig meshDitherDetectConfig = this.MeshDitherDetectConfig;
				return Math.Max(val, valueOrDefault + ((meshDitherDetectConfig != null) ? meshDitherDetectConfig.CapsuleAdditionRadius : 0f));
			}
		}

		// Token: 0x17009CAD RID: 40109
		// (get) Token: 0x0604675B RID: 288603 RVA: 0x011B08C8 File Offset: 0x011AEAC8
		public float TraceCapsuleHeight
		{
			get
			{
				float val = 0f;
				CharacterActorComponent actorComp = this.ActorComp;
				float? num;
				if (actorComp == null)
				{
					num = null;
				}
				else
				{
					UCapsuleComponent capsuleComponent = actorComp.Actor.CapsuleComponent;
					num = ((capsuleComponent != null) ? new float?(capsuleComponent.GetScaledCapsuleHalfHeight()) : null);
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault();
				MeshDitherDetectConfig meshDitherDetectConfig = this.MeshDitherDetectConfig;
				return Math.Max(val, valueOrDefault + ((meshDitherDetectConfig != null) ? meshDitherDetectConfig.CapsuleAdditionHeight : 0f));
			}
		}

		// Token: 0x0604675C RID: 288604 RVA: 0x011B0938 File Offset: 0x011AEB38
		protected override bool OnStart()
		{
			base.OnStart();
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			this.EntityHandle = CharacterModel.Instance.GetHandleByEntity(base.Entity);
			this.ComponentDisableHandle = base.Disable("[Mesh虚化检测]组件默认禁用");
			return true;
		}

		// Token: 0x0604675D RID: 288605 RVA: 0x011B0998 File Offset: 0x011AEB98
		public int EnableDetectDither(SMeshDitherDetectConfig config)
		{
			int num = this.MeshDitherDetectConfigId + 1;
			this.MeshDitherDetectConfigId = num;
			MeshDitherDetectConfig meshDitherDetectConfig = new MeshDitherDetectConfig(config, num);
			this.MeshDitherDetectConfigList.Push(meshDitherDetectConfig);
			this.MeshDitherDetectConfigMap[meshDitherDetectConfig.Id] = meshDitherDetectConfig;
			this.UpdateValidMeshDitherDetectConfig();
			return meshDitherDetectConfig.Id;
		}

		// Token: 0x0604675E RID: 288606 RVA: 0x011B09E8 File Offset: 0x011AEBE8
		public void DisableDetectDither(int id)
		{
			MeshDitherDetectConfig meshDitherDetectConfig;
			if (!this.MeshDitherDetectConfigMap.TryGetValue(id, out meshDitherDetectConfig))
			{
				return;
			}
			meshDitherDetectConfig.MarkDelete = true;
			this.UpdateValidMeshDitherDetectConfig();
		}

		// Token: 0x0604675F RID: 288607 RVA: 0x011B0A14 File Offset: 0x011AEC14
		protected override void OnTick(float delta)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.Valid)
			{
				return;
			}
			if (!this.EnableDither)
			{
				this.RecoverDither();
				return;
			}
			this.InitTraceElement();
			this.UpdateTraceElement();
			if (!TraceElementCommon.Instance.CapsuleTrace(this.TraceElement, "MeshDitherDetectTrace"))
			{
				this.RecoverDither();
				return;
			}
			UKuroHitResult hitResult = this.TraceElement.HitResult;
			this.UpdateDitherDistance(hitResult);
			this.UpdateDitherCharacterValue();
		}

		// Token: 0x06046760 RID: 288608 RVA: 0x011B0A8C File Offset: 0x011AEC8C
		private void InitTraceElement()
		{
			if (this.TraceElement != null)
			{
				return;
			}
			this.TraceElement = new UTraceCapsuleElement();
			this.TraceElement.bIsSingle = false;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.WorldContextObject = this.ActorComp.Owner;
			this.TraceElement.ActorsToIgnore.Add(this.ActorComp.Actor);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldDynamic);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.Vehicle);
		}

		// Token: 0x06046761 RID: 288609 RVA: 0x011B0B28 File Offset: 0x011AED28
		private void UpdateTraceElement()
		{
			if (!this.MoveComp.IsStandardGravity)
			{
				Quat.FindBetween(Vector.UpVectorProxy, this.MoveComp.GravityUp, this.GravityQuat);
				this.GravityQuat.Inverse(this.GravityQuatInverse);
			}
			CameraUtility.GetSocketLocation(null, new FName?(this.MeshDitherDetectConfig.BasisBoneName), this.TmpVector, this.EntityHandle);
			if (this.MoveComp.IsStandardGravity)
			{
				this.ActorComp.ActorQuatProxy.RotateVector(this.MeshDitherDetectConfig.CapsuleAdditionOffset, this.TmpVector2);
				this.TmpVector.AdditionEqual(this.TmpVector2);
			}
			else
			{
				this.GravityQuatInverse.Multiply(this.ActorComp.ActorQuatProxy, this.TmpQuat2);
				this.TmpQuat2.RotateVector(this.MeshDitherDetectConfig.CapsuleAdditionOffset, this.TmpVector2);
				this.GravityQuat.RotateVector(this.TmpVector2, this.TmpVector1);
				this.TmpVector.AdditionEqual(this.TmpVector1);
			}
			this.TraceStartLocation.DeepCopy(this.TmpVector);
			this.TraceEndLocation.DeepCopy(this.TmpVector);
			TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.TraceStartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.TraceEndLocation);
			CameraUtility.GetSocketLocation(null, new FName?(this.MeshDitherDetectConfig.BaseBoneName), this.TmpVector, this.EntityHandle);
			CameraUtility.GetSocketLocation(null, new FName?(this.MeshDitherDetectConfig.TargetBoneName), this.TmpVector1, this.EntityHandle);
			this.TmpVector1.SubtractionEqual(this.TmpVector);
			MathUtils.Instance.LookRotationUpFirst(this.ActorComp.ActorForwardProxy, this.TmpVector1, this.TmpRotator);
			if (this.MoveComp.IsStandardGravity)
			{
				Quat.FindBetween(Vector.UpVectorProxy, this.TmpVector1, this.GravityQuat);
				this.GravityQuat.Inverse(this.GravityQuatInverse);
				GravityUtils.Instance.GetRotatorInGravity(this.TmpRotator, this.GravityQuatInverse, this.TmpRotator1);
				this.TmpRotator1.AdditionEqual(this.MeshDitherDetectConfig.CapsuleAdditionRotator);
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator1, this.GravityQuat, this.TmpRotator);
			}
			else
			{
				GravityUtils.Instance.GetRotatorInGravity(this.TmpRotator, this.GravityQuatInverse, this.TmpRotator1);
				Quat.FindBetween(this.MoveComp.GravityUp, this.TmpVector1, this.GravityQuat1);
				this.GravityQuat1.Inverse(this.GravityQuatInverse1);
				GravityUtils.Instance.GetRotatorInGravity(this.TmpRotator1, this.GravityQuatInverse1, this.TmpRotator2);
				this.TmpRotator2.AdditionEqual(this.MeshDitherDetectConfig.CapsuleAdditionRotator);
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.GravityQuat1, this.TmpRotator1);
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator1, this.GravityQuat, this.TmpRotator);
			}
			TraceElementCommon.Instance.SetCapsuleOrientation(this.TraceElement, this.TmpRotator.Normalize(this.TmpRotator));
			this.TraceElement.Radius = this.TraceCapsuleWidth;
			this.TraceElement.HalfHeight = this.TraceCapsuleHeight;
		}

		// Token: 0x06046762 RID: 288610 RVA: 0x011B0E80 File Offset: 0x011AF080
		private void UpdateDitherDistance(UKuroHitResult hitResult)
		{
			int hitCount = hitResult.GetHitCount();
			this.CharacterDitherDistance = 9999999f;
			for (int i = 0; i < hitCount; i++)
			{
				hitResult.Actors.Get(i);
				TArray<TWeakObjectPtr<UPrimitiveComponent>> components = hitResult.Components;
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (components != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components.Get(i)) : null;
				if (tweakObjectPtr == null || !tweakObjectPtr.GetValueOrDefault().IsValid(false, false))
				{
					return;
				}
				TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TmpVector);
				double num = Vector.Dist(this.TmpVector, this.TraceStartLocation);
				if (num < (double)this.CharacterDitherDistance)
				{
					this.CharacterDitherDistance = (float)num;
				}
			}
		}

		// Token: 0x06046763 RID: 288611 RVA: 0x011B0F3C File Offset: 0x011AF13C
		private void UpdateValidMeshDitherDetectConfig()
		{
			MeshDitherDetectConfig meshDitherDetectConfig = this.GetMeshDitherDetectConfig();
			this.EnableDither = (meshDitherDetectConfig != null);
			this.MeshDitherDetectConfig = meshDitherDetectConfig;
			if (this.EnableDither)
			{
				if (this.ComponentDisableHandle != -1)
				{
					base.Enable(new int?(this.ComponentDisableHandle), "[Mesh虚化检测]开启组件Tick功能");
					this.ComponentDisableHandle = -1;
				}
				CameraController.Instance.MainModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(false);
				return;
			}
			if (this.ComponentDisableHandle == -1)
			{
				this.ComponentDisableHandle = base.Disable("[Mesh虚化检测]关闭组件Tick功能");
			}
			this.RecoverDither();
			CameraController.Instance.MainModel.FightCamera.LogicComponent.SetIsDitherEffectEnable(true);
		}

		// Token: 0x06046764 RID: 288612 RVA: 0x011B0FE8 File Offset: 0x011AF1E8
		[NullableContext(2)]
		private MeshDitherDetectConfig GetMeshDitherDetectConfig()
		{
			while (!this.MeshDitherDetectConfigList.Empty)
			{
				MeshDitherDetectConfig top = this.MeshDitherDetectConfigList.Top;
				if (top == null)
				{
					return null;
				}
				if (!top.MarkDelete)
				{
					return top;
				}
				this.MeshDitherDetectConfigList.Pop();
				this.MeshDitherDetectConfigMap.Remove(top.Id);
			}
			return null;
		}

		// Token: 0x06046765 RID: 288613 RVA: 0x011B1040 File Offset: 0x011AF240
		private void UpdateDitherCharacterValue()
		{
			float dither = this.MeshDitherDetectConfig.OverrideDitherConfig ? MathUtils.Instance.RangeClamp(this.CharacterDitherDistance, this.MeshDitherDetectConfig.CompleteHideDistance, this.MeshDitherDetectConfig.StartHideDistance, 0.01f, this.MeshDitherDetectConfig.StartDitherValue) : MathUtils.Instance.RangeClamp(this.CharacterDitherDistance, this.ActorComp.CompleteHideDistance, this.ActorComp.StartHideDistance, 0.01f, this.ActorComp.StartDitherValue);
			this.ActorComp.Actor.SetDitherEffect(dither, ECharacterDitherType.Fight);
		}

		// Token: 0x06046766 RID: 288614 RVA: 0x011B10DB File Offset: 0x011AF2DB
		private void RecoverDither()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.SetDitherEffect(1f, ECharacterDitherType.Fight);
		}

		// Token: 0x06046767 RID: 288615 RVA: 0x011B10F8 File Offset: 0x011AF2F8
		private void ClearMeshDitherDetectConfig()
		{
			this.MeshDitherDetectConfig = null;
			this.MeshDitherDetectConfigList.Clear();
			this.MeshDitherDetectConfigMap.Clear();
		}

		// Token: 0x06046768 RID: 288616 RVA: 0x011B1117 File Offset: 0x011AF317
		protected override bool OnEnd()
		{
			base.OnEnd();
			this.ClearMeshDitherDetectConfig();
			this.ActorComp = null;
			this.MoveComp = null;
			return true;
		}

		// Token: 0x06046769 RID: 288617 RVA: 0x011B1138 File Offset: 0x011AF338
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterMeshDitherDetectComponent characterMeshDitherDetectComponent = (CharacterMeshDitherDetectComponent)componentTemplate;
			if (base.CanResetComponentProperty("MeshDitherDetectConfig"))
			{
				if (characterMeshDitherDetectComponent.MeshDitherDetectConfig == null)
				{
					this.MeshDitherDetectConfig = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MeshDitherDetectConfig>(this.MeshDitherDetectConfig), "MeshDitherDetectConfig"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MeshDitherDetectConfigId"))
			{
				this.MeshDitherDetectConfigId = characterMeshDitherDetectComponent.MeshDitherDetectConfigId;
			}
			if (base.CanResetComponentProperty("MeshDitherDetectConfigMap") && characterMeshDitherDetectComponent.MeshDitherDetectConfigMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, MeshDitherDetectConfig>>(this.MeshDitherDetectConfigMap), "MeshDitherDetectConfigMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("MeshDitherDetectConfigList") && characterMeshDitherDetectComponent.MeshDitherDetectConfigList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PriorityQueue<MeshDitherDetectConfig>>(this.MeshDitherDetectConfigList), "MeshDitherDetectConfigList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("EntityHandle"))
			{
				if (characterMeshDitherDetectComponent.EntityHandle == null)
				{
					this.EntityHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.EntityHandle), "EntityHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterMeshDitherDetectComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (characterMeshDitherDetectComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TraceElement"))
			{
				if (characterMeshDitherDetectComponent.TraceElement == null)
				{
					this.TraceElement = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceCapsuleElement>(this.TraceElement), "TraceElement"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ComponentDisableHandle"))
			{
				this.ComponentDisableHandle = characterMeshDitherDetectComponent.ComponentDisableHandle;
			}
			if (base.CanResetComponentProperty("EnableDither"))
			{
				this.EnableDither = characterMeshDitherDetectComponent.EnableDither;
			}
			if (base.CanResetComponentProperty("CharacterDitherDistance"))
			{
				this.CharacterDitherDistance = characterMeshDitherDetectComponent.CharacterDitherDistance;
			}
			return (!base.CanResetComponentProperty("GravityQuat") || characterMeshDitherDetectComponent.GravityQuat == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.GravityQuat), "GravityQuat")) && (!base.CanResetComponentProperty("GravityQuatInverse") || characterMeshDitherDetectComponent.GravityQuatInverse == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.GravityQuatInverse), "GravityQuatInverse")) && (!base.CanResetComponentProperty("GravityQuat1") || characterMeshDitherDetectComponent.GravityQuat1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.GravityQuat1), "GravityQuat1")) && (!base.CanResetComponentProperty("GravityQuatInverse1") || characterMeshDitherDetectComponent.GravityQuatInverse1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.GravityQuatInverse1), "GravityQuatInverse1")) && (!base.CanResetComponentProperty("TraceStartLocation") || characterMeshDitherDetectComponent.TraceStartLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TraceStartLocation), "TraceStartLocation")) && (!base.CanResetComponentProperty("TraceEndLocation") || characterMeshDitherDetectComponent.TraceEndLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TraceEndLocation), "TraceEndLocation")) && (!base.CanResetComponentProperty("TmpVector") || characterMeshDitherDetectComponent.TmpVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector), "TmpVector")) && (!base.CanResetComponentProperty("TmpVector1") || characterMeshDitherDetectComponent.TmpVector1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector1), "TmpVector1")) && (!base.CanResetComponentProperty("TmpVector2") || characterMeshDitherDetectComponent.TmpVector2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector2), "TmpVector2")) && (!base.CanResetComponentProperty("TmpRotator") || characterMeshDitherDetectComponent.TmpRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator), "TmpRotator")) && (!base.CanResetComponentProperty("TmpRotator1") || characterMeshDitherDetectComponent.TmpRotator1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator1), "TmpRotator1")) && (!base.CanResetComponentProperty("TmpRotator2") || characterMeshDitherDetectComponent.TmpRotator2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator2), "TmpRotator2")) && (!base.CanResetComponentProperty("TmpQuat2") || characterMeshDitherDetectComponent.TmpQuat2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat2), "TmpQuat2"));
		}

		// Token: 0x0604676A RID: 288618 RVA: 0x011B1598 File Offset: 0x011AF798
		public CharacterMeshDitherDetectComponent()
		{
			Comparison<MeshDitherDetectConfig> compare;
			if ((compare = CharacterMeshDitherDetectComponent.<>O.<0>__CompareMeshDitherDetectConfigPriority) == null)
			{
				compare = (CharacterMeshDitherDetectComponent.<>O.<0>__CompareMeshDitherDetectConfigPriority = new Comparison<MeshDitherDetectConfig>(CharacterMeshDitherDetectComponent.CompareMeshDitherDetectConfigPriority));
			}
			this.MeshDitherDetectConfigList = new PriorityQueue<MeshDitherDetectConfig>(compare);
			this.ComponentDisableHandle = -1;
			this.CharacterDitherDistance = 9999999f;
			this.GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.GravityQuatInverse = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.GravityQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.GravityQuatInverse1 = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.TraceStartLocation = Vector.Create();
			this.TraceEndLocation = Vector.Create();
			this.TmpVector = Vector.Create();
			this.TmpVector1 = Vector.Create();
			this.TmpVector2 = Vector.Create();
			this.TmpRotator = Rotator.Create();
			this.TmpRotator1 = Rotator.Create();
			this.TmpRotator2 = Rotator.Create();
			this.TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
			base..ctor();
		}

		// Token: 0x04024ECD RID: 151245
		private const float MIN_DITHER = 0.01f;

		// Token: 0x04024ECE RID: 151246
		private const float MAX_VALUE = 9999999f;

		// Token: 0x04024ECF RID: 151247
		private const int COMPONENT_DISABLE_KEY = -1;

		// Token: 0x04024ED0 RID: 151248
		private const string PROFILE_KEY = "MeshDitherDetectTrace";

		// Token: 0x04024ED1 RID: 151249
		[Nullable(2)]
		public MeshDitherDetectConfig MeshDitherDetectConfig;

		// Token: 0x04024ED2 RID: 151250
		private int MeshDitherDetectConfigId;

		// Token: 0x04024ED3 RID: 151251
		private readonly Dictionary<int, MeshDitherDetectConfig> MeshDitherDetectConfigMap = new Dictionary<int, MeshDitherDetectConfig>();

		// Token: 0x04024ED4 RID: 151252
		private readonly PriorityQueue<MeshDitherDetectConfig> MeshDitherDetectConfigList;

		// Token: 0x04024ED5 RID: 151253
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x04024ED6 RID: 151254
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04024ED7 RID: 151255
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04024ED8 RID: 151256
		[Nullable(2)]
		private UTraceCapsuleElement TraceElement;

		// Token: 0x04024ED9 RID: 151257
		private int ComponentDisableHandle;

		// Token: 0x04024EDA RID: 151258
		private bool EnableDither;

		// Token: 0x04024EDB RID: 151259
		private float CharacterDitherDistance;

		// Token: 0x04024EDC RID: 151260
		private readonly Quat GravityQuat;

		// Token: 0x04024EDD RID: 151261
		private readonly Quat GravityQuatInverse;

		// Token: 0x04024EDE RID: 151262
		private readonly Quat GravityQuat1;

		// Token: 0x04024EDF RID: 151263
		private readonly Quat GravityQuatInverse1;

		// Token: 0x04024EE0 RID: 151264
		private readonly Vector TraceStartLocation;

		// Token: 0x04024EE1 RID: 151265
		private readonly Vector TraceEndLocation;

		// Token: 0x04024EE2 RID: 151266
		private readonly Vector TmpVector;

		// Token: 0x04024EE3 RID: 151267
		private readonly Vector TmpVector1;

		// Token: 0x04024EE4 RID: 151268
		private readonly Vector TmpVector2;

		// Token: 0x04024EE5 RID: 151269
		private readonly Rotator TmpRotator;

		// Token: 0x04024EE6 RID: 151270
		private readonly Rotator TmpRotator1;

		// Token: 0x04024EE7 RID: 151271
		private readonly Rotator TmpRotator2;

		// Token: 0x04024EE8 RID: 151272
		private readonly Quat TmpQuat2;

		// Token: 0x0200CE6C RID: 52844
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E246 RID: 254534
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<MeshDitherDetectConfig> <0>__CompareMeshDitherDetectConfigPriority;
		}
	}
}
