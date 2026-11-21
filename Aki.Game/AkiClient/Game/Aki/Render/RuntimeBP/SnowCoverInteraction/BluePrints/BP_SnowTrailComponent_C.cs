using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x020030AD RID: 12461
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 764)]
	public class BP_SnowTrailComponent_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE0C RID: 122380 RVA: 0x0090498C File Offset: 0x00902B8C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTrailComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C");
			}
			return BP_SnowTrailComponent_C._ClassPtr;
		}

		// Token: 0x0601DE0D RID: 122381 RVA: 0x009049B0 File Offset: 0x00902BB0
		public BP_SnowTrailComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE0E RID: 122382 RVA: 0x009049D8 File Offset: 0x00902BD8
		[NullableContext(1)]
		public BP_SnowTrailComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0601DE0F RID: 122383 RVA: 0x00904A0B File Offset: 0x00902C0B
		// (set) Token: 0x0601DE10 RID: 122384 RVA: 0x00904A1B File Offset: 0x00902C1B
		public unsafe bool UseActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseActorPos) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseActorPos) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0601DE11 RID: 122385 RVA: 0x00904A2C File Offset: 0x00902C2C
		// (set) Token: 0x0601DE12 RID: 122386 RVA: 0x00904A3C File Offset: 0x00902C3C
		public unsafe bool UseEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseEffect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseEffect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0601DE13 RID: 122387 RVA: 0x00904A4D File Offset: 0x00902C4D
		// (set) Token: 0x0601DE14 RID: 122388 RVA: 0x00904A5D File Offset: 0x00902C5D
		public unsafe bool UseSimplePrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseSimplePrint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_UseSimplePrint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0601DE15 RID: 122389 RVA: 0x00904A6E File Offset: 0x00902C6E
		// (set) Token: 0x0601DE16 RID: 122390 RVA: 0x00904A7E File Offset: 0x00902C7E
		public unsafe int NFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_NFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_NFrame) = value;
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0601DE17 RID: 122391 RVA: 0x00904A8F File Offset: 0x00902C8F
		// (set) Token: 0x0601DE18 RID: 122392 RVA: 0x00904A9F File Offset: 0x00902C9F
		public unsafe float Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Hardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Hardness) = value;
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0601DE19 RID: 122393 RVA: 0x00904AB0 File Offset: 0x00902CB0
		// (set) Token: 0x0601DE1A RID: 122394 RVA: 0x00904AC0 File Offset: 0x00902CC0
		public unsafe float RayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_RayLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_RayLength) = value;
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0601DE1B RID: 122395 RVA: 0x00904AD1 File Offset: 0x00902CD1
		// (set) Token: 0x0601DE1C RID: 122396 RVA: 0x00904AE1 File Offset: 0x00902CE1
		public unsafe float TrailRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_TrailRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_TrailRadius) = value;
			}
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0601DE1D RID: 122397 RVA: 0x00904AF2 File Offset: 0x00902CF2
		// (set) Token: 0x0601DE1E RID: 122398 RVA: 0x00904B02 File Offset: 0x00902D02
		public unsafe float DistanceTraveld2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_DistanceTraveld2D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_DistanceTraveld2D) = value;
			}
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0601DE1F RID: 122399 RVA: 0x00904B13 File Offset: 0x00902D13
		// (set) Token: 0x0601DE20 RID: 122400 RVA: 0x00904B27 File Offset: 0x00902D27
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_LastUpdateLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_LastUpdateLocation) = value;
			}
		}

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0601DE21 RID: 122401 RVA: 0x00904B3C File Offset: 0x00902D3C
		// (set) Token: 0x0601DE22 RID: 122402 RVA: 0x00904B50 File Offset: 0x00902D50
		public unsafe FVector LastCheckLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_LastCheckLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_LastCheckLocation) = value;
			}
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0601DE23 RID: 122403 RVA: 0x00904B65 File Offset: 0x00902D65
		// (set) Token: 0x0601DE24 RID: 122404 RVA: 0x00904B79 File Offset: 0x00902D79
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0601DE25 RID: 122405 RVA: 0x00904B8E File Offset: 0x00902D8E
		// (set) Token: 0x0601DE26 RID: 122406 RVA: 0x00904BA2 File Offset: 0x00902DA2
		public unsafe FVector BoneTransOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneTransOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneTransOffset) = value;
			}
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0601DE27 RID: 122407 RVA: 0x00904BB7 File Offset: 0x00902DB7
		// (set) Token: 0x0601DE28 RID: 122408 RVA: 0x00904BCB File Offset: 0x00902DCB
		public unsafe FVector BoneLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BoneLocation) = value;
			}
		}

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0601DE29 RID: 122409 RVA: 0x00904BE0 File Offset: 0x00902DE0
		// (set) Token: 0x0601DE2A RID: 122410 RVA: 0x00904BF4 File Offset: 0x00902DF4
		[Nullable(2)]
		public unsafe BP_SceneBattleInteract_C Config
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_Config);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0601DE2B RID: 122411 RVA: 0x00904C09 File Offset: 0x00902E09
		// (set) Token: 0x0601DE2C RID: 122412 RVA: 0x00904C19 File Offset: 0x00902E19
		public unsafe double Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0601DE2D RID: 122413 RVA: 0x00904C2A File Offset: 0x00902E2A
		// (set) Token: 0x0601DE2E RID: 122414 RVA: 0x00904C3A File Offset: 0x00902E3A
		public unsafe float BulletLastHitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletLastHitTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletLastHitTime) = value;
			}
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0601DE2F RID: 122415 RVA: 0x00904C4C File Offset: 0x00902E4C
		// (set) Token: 0x0601DE30 RID: 122416 RVA: 0x00904C85 File Offset: 0x00902E85
		[Nullable(1)]
		public TArray<FVectorDouble> BulletHitList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletHitList) == null)
				{
					result = (this._BulletHitList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletHitList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletHitList.CopyAssign(value);
			}
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0601DE31 RID: 122417 RVA: 0x00904C93 File Offset: 0x00902E93
		// (set) Token: 0x0601DE32 RID: 122418 RVA: 0x00904CA3 File Offset: 0x00902EA3
		public unsafe double Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0601DE33 RID: 122419 RVA: 0x00904CB4 File Offset: 0x00902EB4
		// (set) Token: 0x0601DE34 RID: 122420 RVA: 0x00904CC4 File Offset: 0x00902EC4
		public unsafe double BulletMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletMaxConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletMaxConnectDistance) = value;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0601DE35 RID: 122421 RVA: 0x00904CD5 File Offset: 0x00902ED5
		// (set) Token: 0x0601DE36 RID: 122422 RVA: 0x00904CE5 File Offset: 0x00902EE5
		public unsafe double BulletMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletMinConnectDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_BulletMinConnectDistance) = value;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0601DE37 RID: 122423 RVA: 0x00904CF6 File Offset: 0x00902EF6
		// (set) Token: 0x0601DE38 RID: 122424 RVA: 0x00904D06 File Offset: 0x00902F06
		public unsafe int Step
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Step);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_Step) = value;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0601DE39 RID: 122425 RVA: 0x00904D17 File Offset: 0x00902F17
		// (set) Token: 0x0601DE3A RID: 122426 RVA: 0x00904D27 File Offset: 0x00902F27
		public unsafe bool SelfEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_SelfEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_SelfEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0601DE3B RID: 122427 RVA: 0x00904D38 File Offset: 0x00902F38
		// (set) Token: 0x0601DE3C RID: 122428 RVA: 0x00904D48 File Offset: 0x00902F48
		public unsafe int FrameConter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_FrameConter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_FrameConter) = value;
			}
		}

		// Token: 0x0601DE3D RID: 122429 RVA: 0x00904D5C File Offset: 0x00902F5C
		[SkipLocalsInit]
		public unsafe virtual void UpdateDeltaTime(float DeltaTime)
		{
			BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE3E RID: 122430 RVA: 0x00904DA4 File Offset: 0x00902FA4
		[SkipLocalsInit]
		public unsafe virtual void CompareNewPointWeapon(FVectorDouble V2, ref bool Valid)
		{
			BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__CompareNewPointWeapon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Valid = Valid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__CompareNewPointWeapon_NativeFunctionPtr, (void*)ptr);
			Valid = ptr->Valid;
		}

		// Token: 0x0601DE3F RID: 122431 RVA: 0x00904DFC File Offset: 0x00902FFC
		[SkipLocalsInit]
		public unsafe virtual void SnowCollisionEffect(FVectorDouble AvailablePoint, float TrailRadius, float TrailDepth)
		{
			BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__SnowCollisionEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AvailablePoint = AvailablePoint;
			ptr->TrailRadius = TrailRadius;
			ptr->TrailDepth = TrailDepth;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE40 RID: 122432 RVA: 0x00904E53 File Offset: 0x00903053
		[SkipLocalsInit]
		public virtual void SnowCollisionActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionActor_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE41 RID: 122433 RVA: 0x00904E67 File Offset: 0x00903067
		[SkipLocalsInit]
		public virtual void SnowCollisionBone()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionBone_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE42 RID: 122434 RVA: 0x00904E7C File Offset: 0x0090307C
		[SkipLocalsInit]
		public unsafe virtual void RegisterTrailComp(float Radius, float Depth, float Hardness, float TrailRotation, FVector TrailLocation)
		{
			BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Radius = Radius;
			ptr->Depth = Depth;
			ptr->Hardness = Hardness;
			ptr->TrailRotation = TrailRotation;
			ptr->TrailLocation = TrailLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE43 RID: 122435 RVA: 0x00904EE0 File Offset: 0x009030E0
		[SkipLocalsInit]
		public virtual void FindTrailManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__FindTrailManager_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE44 RID: 122436 RVA: 0x00904EF4 File Offset: 0x009030F4
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE45 RID: 122437 RVA: 0x00904F08 File Offset: 0x00903108
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DE46 RID: 122438 RVA: 0x00904F1C File Offset: 0x0090311C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE47 RID: 122439 RVA: 0x00904F64 File Offset: 0x00903164
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE48 RID: 122440 RVA: 0x00904FAC File Offset: 0x009031AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DE49 RID: 122441 RVA: 0x0090500F File Offset: 0x0090320F
		protected BP_SnowTrailComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC59 RID: 64601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C";

		// Token: 0x0400FC5A RID: 64602
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC5B RID: 64603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC5C RID: 64604
		internal static int __PropertyOffset_UseActorPos;

		// Token: 0x0400FC5D RID: 64605
		internal static int __PropertyOffset_UseEffect;

		// Token: 0x0400FC5E RID: 64606
		internal static int __PropertyOffset_UseSimplePrint;

		// Token: 0x0400FC5F RID: 64607
		internal static int __PropertyOffset_NFrame;

		// Token: 0x0400FC60 RID: 64608
		internal static int __PropertyOffset_Hardness;

		// Token: 0x0400FC61 RID: 64609
		internal static int __PropertyOffset_RayLength;

		// Token: 0x0400FC62 RID: 64610
		internal static int __PropertyOffset_TrailRadius;

		// Token: 0x0400FC63 RID: 64611
		internal static int __PropertyOffset_DistanceTraveld2D;

		// Token: 0x0400FC64 RID: 64612
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x0400FC65 RID: 64613
		internal static int __PropertyOffset_LastCheckLocation;

		// Token: 0x0400FC66 RID: 64614
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400FC67 RID: 64615
		internal static int __PropertyOffset_BoneTransOffset;

		// Token: 0x0400FC68 RID: 64616
		internal static int __PropertyOffset_BoneLocation;

		// Token: 0x0400FC69 RID: 64617
		internal static int __PropertyOffset_Config;

		// Token: 0x0400FC6A RID: 64618
		internal static int __PropertyOffset_Height;

		// Token: 0x0400FC6B RID: 64619
		internal static int __PropertyOffset_BulletLastHitTime;

		// Token: 0x0400FC6C RID: 64620
		internal static int __PropertyOffset_BulletHitList;

		// Token: 0x0400FC6D RID: 64621
		[Nullable(2)]
		private TArray<FVectorDouble> _BulletHitList;

		// Token: 0x0400FC6E RID: 64622
		internal static int __PropertyOffset_Distance;

		// Token: 0x0400FC6F RID: 64623
		internal static int __PropertyOffset_BulletMaxConnectDistance;

		// Token: 0x0400FC70 RID: 64624
		internal static int __PropertyOffset_BulletMinConnectDistance;

		// Token: 0x0400FC71 RID: 64625
		internal static int __PropertyOffset_Step;

		// Token: 0x0400FC72 RID: 64626
		internal static int __PropertyOffset_SelfEnable;

		// Token: 0x0400FC73 RID: 64627
		internal static int __PropertyOffset_FrameConter;

		// Token: 0x0400FC74 RID: 64628
		private static IntPtr __UpdateDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FC75 RID: 64629
		private static IntPtr __CompareNewPointWeapon_NativeFunctionPtr;

		// Token: 0x0400FC76 RID: 64630
		private static IntPtr __SnowCollisionEffect_NativeFunctionPtr;

		// Token: 0x0400FC77 RID: 64631
		private static IntPtr __SnowCollisionActor_NativeFunctionPtr;

		// Token: 0x0400FC78 RID: 64632
		private static IntPtr __SnowCollisionBone_NativeFunctionPtr;

		// Token: 0x0400FC79 RID: 64633
		private static IntPtr __RegisterTrailComp_NativeFunctionPtr;

		// Token: 0x0400FC7A RID: 64634
		private static IntPtr __FindTrailManager_NativeFunctionPtr;

		// Token: 0x0400FC7B RID: 64635
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FC7C RID: 64636
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FC7D RID: 64637
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02008DCB RID: 36299
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateDeltaTime_FunctionParams
		{
			// Token: 0x0402C9D0 RID: 182736
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02008DCC RID: 36300
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CompareNewPointWeapon_FunctionParams
		{
			// Token: 0x0402C9D1 RID: 182737
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x0402C9D2 RID: 182738
			[FieldOffset(24)]
			public bool Valid;
		}

		// Token: 0x02008DCD RID: 36301
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __SnowCollisionEffect_FunctionParams
		{
			// Token: 0x0402C9D3 RID: 182739
			[FieldOffset(0)]
			public FVectorDouble AvailablePoint;

			// Token: 0x0402C9D4 RID: 182740
			[FieldOffset(24)]
			public float TrailRadius;

			// Token: 0x0402C9D5 RID: 182741
			[FieldOffset(28)]
			public float TrailDepth;
		}

		// Token: 0x02008DCE RID: 36302
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __RegisterTrailComp_FunctionParams
		{
			// Token: 0x0402C9D6 RID: 182742
			[FieldOffset(0)]
			public float Radius;

			// Token: 0x0402C9D7 RID: 182743
			[FieldOffset(4)]
			public float Depth;

			// Token: 0x0402C9D8 RID: 182744
			[FieldOffset(8)]
			public float Hardness;

			// Token: 0x0402C9D9 RID: 182745
			[FieldOffset(12)]
			public float TrailRotation;

			// Token: 0x0402C9DA RID: 182746
			[FieldOffset(16)]
			public FVector TrailLocation;
		}

		// Token: 0x02008DCF RID: 36303
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C9DB RID: 182747
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008DD0 RID: 36304
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0402C9DC RID: 182748
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0402C9DD RID: 182749
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0402C9DE RID: 182750
			[FieldOffset(32)]
			public int Id;
		}
	}
}
