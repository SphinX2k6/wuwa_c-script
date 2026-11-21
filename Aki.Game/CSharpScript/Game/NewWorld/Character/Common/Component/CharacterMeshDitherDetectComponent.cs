using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006330 RID: 25392
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterMeshDitherDetectComponent : EntityComponent
	{
		// Token: 0x170074BC RID: 29884
		// (get) Token: 0x0603D84C RID: 251980 RVA: 0x011CFB92 File Offset: 0x011CDD92
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(CharacterActorComponent),
					typeof(CharacterMoveComponent)
				};
			}
		}

		// Token: 0x0603D84D RID: 251981 RVA: 0x011CFBB4 File Offset: 0x011CDDB4
		private static int CompareMeshDitherDetectConfigPriority(MeshDitherDetectConfig a, MeshDitherDetectConfig b)
		{
			if (a.Priority == b.Priority)
			{
				return -1;
			}
			return b.Priority - a.Priority;
		}

		// Token: 0x170074BD RID: 29885
		// (get) Token: 0x0603D84E RID: 251982 RVA: 0x011CFBD4 File Offset: 0x011CDDD4
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

		// Token: 0x170074BE RID: 29886
		// (get) Token: 0x0603D84F RID: 251983 RVA: 0x011CFC44 File Offset: 0x011CDE44
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

		// Token: 0x0603D850 RID: 251984 RVA: 0x011CFCB4 File Offset: 0x011CDEB4
		protected override bool OnStart()
		{
			base.OnStart();
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
			this.EntityHandle = CharacterModel.Instance.GetHandleByEntity(base.Entity);
			this.ComponentDisableHandle = base.Disable("[Mesh虚化检测]组件默认禁用");
			return true;
		}

		// Token: 0x0603D851 RID: 251985 RVA: 0x011CFD14 File Offset: 0x011CDF14
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

		// Token: 0x0603D852 RID: 251986 RVA: 0x011CFD64 File Offset: 0x011CDF64
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

		// Token: 0x0603D853 RID: 251987 RVA: 0x011CFD90 File Offset: 0x011CDF90
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

		// Token: 0x0603D854 RID: 251988 RVA: 0x011CFE08 File Offset: 0x011CE008
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

		// Token: 0x0603D855 RID: 251989 RVA: 0x011CFEA4 File Offset: 0x011CE0A4
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

		// Token: 0x0603D856 RID: 251990 RVA: 0x011D01FC File Offset: 0x011CE3FC
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

		// Token: 0x0603D857 RID: 251991 RVA: 0x011D02B8 File Offset: 0x011CE4B8
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

		// Token: 0x0603D858 RID: 251992 RVA: 0x011D0364 File Offset: 0x011CE564
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

		// Token: 0x0603D859 RID: 251993 RVA: 0x011D03BC File Offset: 0x011CE5BC
		private void UpdateDitherCharacterValue()
		{
			float dither = this.MeshDitherDetectConfig.OverrideDitherConfig ? MathUtils.Instance.RangeClamp(this.CharacterDitherDistance, this.MeshDitherDetectConfig.CompleteHideDistance, this.MeshDitherDetectConfig.StartHideDistance, 0.01f, this.MeshDitherDetectConfig.StartDitherValue) : MathUtils.Instance.RangeClamp(this.CharacterDitherDistance, this.ActorComp.CompleteHideDistance, this.ActorComp.StartHideDistance, 0.01f, this.ActorComp.StartDitherValue);
			this.ActorComp.Actor.SetDitherEffect(dither, ECharacterDitherType.Fight);
		}

		// Token: 0x0603D85A RID: 251994 RVA: 0x011D0457 File Offset: 0x011CE657
		private void RecoverDither()
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.SetDitherEffect(1f, ECharacterDitherType.Fight);
		}

		// Token: 0x0603D85B RID: 251995 RVA: 0x011D0474 File Offset: 0x011CE674
		private void ClearMeshDitherDetectConfig()
		{
			this.MeshDitherDetectConfig = null;
			this.MeshDitherDetectConfigList.Clear();
			this.MeshDitherDetectConfigMap.Clear();
		}

		// Token: 0x0603D85C RID: 251996 RVA: 0x011D0493 File Offset: 0x011CE693
		protected override bool OnEnd()
		{
			base.OnEnd();
			this.ClearMeshDitherDetectConfig();
			this.ActorComp = null;
			this.MoveComp = null;
			return true;
		}

		// Token: 0x0603D85D RID: 251997 RVA: 0x011D04B4 File Offset: 0x011CE6B4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterMeshDitherDetectComponent characterMeshDitherDetectComponent = (CharacterMeshDitherDetectComponent)componentTemplate;
			if (characterMeshDitherDetectComponent.MeshDitherDetectConfig == null)
			{
				this.MeshDitherDetectConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MeshDitherDetectConfig), "MeshDitherDetectConfig"))
			{
				return false;
			}
			this.MeshDitherDetectConfigId = characterMeshDitherDetectComponent.MeshDitherDetectConfigId;
			if (characterMeshDitherDetectComponent.MeshDitherDetectConfigMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MeshDitherDetectConfigMap), "MeshDitherDetectConfigMap"))
			{
				return false;
			}
			if (characterMeshDitherDetectComponent.MeshDitherDetectConfigList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.MeshDitherDetectConfigList), "MeshDitherDetectConfigList"))
			{
				return false;
			}
			if (characterMeshDitherDetectComponent.EntityHandle == null)
			{
				this.EntityHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.EntityHandle), "EntityHandle"))
			{
				return false;
			}
			if (characterMeshDitherDetectComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterMeshDitherDetectComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (characterMeshDitherDetectComponent.TraceElement == null)
			{
				this.TraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceElement), "TraceElement"))
			{
				return false;
			}
			this.ComponentDisableHandle = characterMeshDitherDetectComponent.ComponentDisableHandle;
			this.EnableDither = characterMeshDitherDetectComponent.EnableDither;
			this.CharacterDitherDistance = characterMeshDitherDetectComponent.CharacterDitherDistance;
			return (characterMeshDitherDetectComponent.GravityQuat == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityQuat), "GravityQuat")) && (characterMeshDitherDetectComponent.GravityQuatInverse == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityQuatInverse), "GravityQuatInverse")) && (characterMeshDitherDetectComponent.GravityQuat1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityQuat1), "GravityQuat1")) && (characterMeshDitherDetectComponent.GravityQuatInverse1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityQuatInverse1), "GravityQuatInverse1")) && (characterMeshDitherDetectComponent.TraceStartLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceStartLocation), "TraceStartLocation")) && (characterMeshDitherDetectComponent.TraceEndLocation == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceEndLocation), "TraceEndLocation")) && (characterMeshDitherDetectComponent.TmpVector == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector")) && (characterMeshDitherDetectComponent.TmpVector1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector1), "TmpVector1")) && (characterMeshDitherDetectComponent.TmpVector2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2")) && (characterMeshDitherDetectComponent.TmpRotator == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator")) && (characterMeshDitherDetectComponent.TmpRotator1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator1), "TmpRotator1")) && (characterMeshDitherDetectComponent.TmpRotator2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator2), "TmpRotator2")) && (characterMeshDitherDetectComponent.TmpQuat2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat2), "TmpQuat2"));
		}

		// Token: 0x170074BF RID: 29887
		// (get) Token: 0x0603D85E RID: 251998 RVA: 0x011D07D9 File Offset: 0x011CE9D9
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C0 RID: 29888
		// (get) Token: 0x0603D85F RID: 251999 RVA: 0x011D07DC File Offset: 0x011CE9DC
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074C1 RID: 29889
		// (get) Token: 0x0603D860 RID: 252000 RVA: 0x011D07DF File Offset: 0x011CE9DF
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603D861 RID: 252001 RVA: 0x011D07E4 File Offset: 0x011CE9E4
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

		// Token: 0x04020A0C RID: 133644
		private const float MIN_DITHER = 0.01f;

		// Token: 0x04020A0D RID: 133645
		private const float MAX_VALUE = 9999999f;

		// Token: 0x04020A0E RID: 133646
		private const int COMPONENT_DISABLE_KEY = -1;

		// Token: 0x04020A0F RID: 133647
		private const string PROFILE_KEY = "MeshDitherDetectTrace";

		// Token: 0x04020A10 RID: 133648
		[Nullable(2)]
		public MeshDitherDetectConfig MeshDitherDetectConfig;

		// Token: 0x04020A11 RID: 133649
		private int MeshDitherDetectConfigId;

		// Token: 0x04020A12 RID: 133650
		private readonly Dictionary<int, MeshDitherDetectConfig> MeshDitherDetectConfigMap = new Dictionary<int, MeshDitherDetectConfig>();

		// Token: 0x04020A13 RID: 133651
		private readonly PriorityQueue<MeshDitherDetectConfig> MeshDitherDetectConfigList;

		// Token: 0x04020A14 RID: 133652
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x04020A15 RID: 133653
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04020A16 RID: 133654
		[Nullable(2)]
		private CharacterMoveComponent MoveComp;

		// Token: 0x04020A17 RID: 133655
		[Nullable(2)]
		private UTraceCapsuleElement TraceElement;

		// Token: 0x04020A18 RID: 133656
		private int ComponentDisableHandle;

		// Token: 0x04020A19 RID: 133657
		private bool EnableDither;

		// Token: 0x04020A1A RID: 133658
		private float CharacterDitherDistance;

		// Token: 0x04020A1B RID: 133659
		private readonly Quat GravityQuat;

		// Token: 0x04020A1C RID: 133660
		private readonly Quat GravityQuatInverse;

		// Token: 0x04020A1D RID: 133661
		private readonly Quat GravityQuat1;

		// Token: 0x04020A1E RID: 133662
		private readonly Quat GravityQuatInverse1;

		// Token: 0x04020A1F RID: 133663
		private readonly Vector TraceStartLocation;

		// Token: 0x04020A20 RID: 133664
		private readonly Vector TraceEndLocation;

		// Token: 0x04020A21 RID: 133665
		private readonly Vector TmpVector;

		// Token: 0x04020A22 RID: 133666
		private readonly Vector TmpVector1;

		// Token: 0x04020A23 RID: 133667
		private readonly Vector TmpVector2;

		// Token: 0x04020A24 RID: 133668
		private readonly Rotator TmpRotator;

		// Token: 0x04020A25 RID: 133669
		private readonly Rotator TmpRotator1;

		// Token: 0x04020A26 RID: 133670
		private readonly Rotator TmpRotator2;

		// Token: 0x04020A27 RID: 133671
		private readonly Quat TmpQuat2;

		// Token: 0x0200BB41 RID: 47937
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403997A RID: 235898
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<MeshDitherDetectConfig> <0>__CompareMeshDitherDetectConfigPriority;
		}
	}
}
