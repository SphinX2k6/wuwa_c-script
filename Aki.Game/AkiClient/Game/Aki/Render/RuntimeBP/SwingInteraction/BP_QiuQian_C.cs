using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.Physics_Actor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SwingInteraction
{
	// Token: 0x02003AC0 RID: 15040
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1716)]
	public class BP_QiuQian_C : BP_PhysicsActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060204F3 RID: 132339 RVA: 0x008CF41B File Offset: 0x008CD61B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_QiuQian_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C");
			}
			return BP_QiuQian_C._ClassPtr;
		}

		// Token: 0x060204F4 RID: 132340 RVA: 0x008CF440 File Offset: 0x008CD640
		public BP_QiuQian_C() : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060204F5 RID: 132341 RVA: 0x008CF468 File Offset: 0x008CD668
		[NullableContext(1)]
		public BP_QiuQian_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_QiuQian_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x060204F6 RID: 132342 RVA: 0x008CF49B File Offset: 0x008CD69B
		// (set) Token: 0x060204F7 RID: 132343 RVA: 0x008CF4AF File Offset: 0x008CD6AF
		public unsafe UStaticMeshComponent SM_SwingSingleRopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x060204F8 RID: 132344 RVA: 0x008CF4C4 File Offset: 0x008CD6C4
		// (set) Token: 0x060204F9 RID: 132345 RVA: 0x008CF4D8 File Offset: 0x008CD6D8
		public unsafe UStaticMeshComponent SM_SwingSingleRopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x060204FA RID: 132346 RVA: 0x008CF4ED File Offset: 0x008CD6ED
		// (set) Token: 0x060204FB RID: 132347 RVA: 0x008CF501 File Offset: 0x008CD701
		public unsafe UStaticMeshComponent SM_SwingTop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x060204FC RID: 132348 RVA: 0x008CF516 File Offset: 0x008CD716
		// (set) Token: 0x060204FD RID: 132349 RVA: 0x008CF52A File Offset: 0x008CD72A
		public unsafe UStaticMeshComponent StaticMesh_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x060204FE RID: 132350 RVA: 0x008CF540 File Offset: 0x008CD740
		// (set) Token: 0x060204FF RID: 132351 RVA: 0x008CF579 File Offset: 0x008CD779
		[Nullable(1)]
		public TArray<FName> NameList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._NameList) == null)
				{
					result = (this._NameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NameList.CopyAssign(value);
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06020500 RID: 132352 RVA: 0x008CF587 File Offset: 0x008CD787
		// (set) Token: 0x06020501 RID: 132353 RVA: 0x008CF597 File Offset: 0x008CD797
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06020502 RID: 132354 RVA: 0x008CF5A8 File Offset: 0x008CD7A8
		// (set) Token: 0x06020503 RID: 132355 RVA: 0x008CF5B8 File Offset: 0x008CD7B8
		public unsafe bool bUseConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06020504 RID: 132356 RVA: 0x008CF5C9 File Offset: 0x008CD7C9
		// (set) Token: 0x06020505 RID: 132357 RVA: 0x008CF5D9 File Offset: 0x008CD7D9
		public unsafe float ConstantDt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06020506 RID: 132358 RVA: 0x008CF5EA File Offset: 0x008CD7EA
		// (set) Token: 0x06020507 RID: 132359 RVA: 0x008CF5FE File Offset: 0x008CD7FE
		public unsafe FVector StartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06020508 RID: 132360 RVA: 0x008CF613 File Offset: 0x008CD813
		// (set) Token: 0x06020509 RID: 132361 RVA: 0x008CF623 File Offset: 0x008CD823
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0602050A RID: 132362 RVA: 0x008CF634 File Offset: 0x008CD834
		// (set) Token: 0x0602050B RID: 132363 RVA: 0x008CF644 File Offset: 0x008CD844
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x0602050C RID: 132364 RVA: 0x008CF655 File Offset: 0x008CD855
		// (set) Token: 0x0602050D RID: 132365 RVA: 0x008CF669 File Offset: 0x008CD869
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003019 RID: 12313
		// (get) Token: 0x0602050E RID: 132366 RVA: 0x008CF67E File Offset: 0x008CD87E
		// (set) Token: 0x0602050F RID: 132367 RVA: 0x008CF68E File Offset: 0x008CD88E
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700301A RID: 12314
		// (get) Token: 0x06020510 RID: 132368 RVA: 0x008CF69F File Offset: 0x008CD89F
		// (set) Token: 0x06020511 RID: 132369 RVA: 0x008CF6AF File Offset: 0x008CD8AF
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700301B RID: 12315
		// (get) Token: 0x06020512 RID: 132370 RVA: 0x008CF6C0 File Offset: 0x008CD8C0
		// (set) Token: 0x06020513 RID: 132371 RVA: 0x008CF6D4 File Offset: 0x008CD8D4
		public unsafe FVector startPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x1700301C RID: 12316
		// (get) Token: 0x06020514 RID: 132372 RVA: 0x008CF6E9 File Offset: 0x008CD8E9
		// (set) Token: 0x06020515 RID: 132373 RVA: 0x008CF6FD File Offset: 0x008CD8FD
		public unsafe FVector endPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700301D RID: 12317
		// (get) Token: 0x06020516 RID: 132374 RVA: 0x008CF712 File Offset: 0x008CD912
		// (set) Token: 0x06020517 RID: 132375 RVA: 0x008CF726 File Offset: 0x008CD926
		public unsafe FVector leftPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700301E RID: 12318
		// (get) Token: 0x06020518 RID: 132376 RVA: 0x008CF73B File Offset: 0x008CD93B
		// (set) Token: 0x06020519 RID: 132377 RVA: 0x008CF74F File Offset: 0x008CD94F
		public unsafe FVector rightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700301F RID: 12319
		// (get) Token: 0x0602051A RID: 132378 RVA: 0x008CF764 File Offset: 0x008CD964
		// (set) Token: 0x0602051B RID: 132379 RVA: 0x008CF778 File Offset: 0x008CD978
		public unsafe FVector leftNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003020 RID: 12320
		// (get) Token: 0x0602051C RID: 132380 RVA: 0x008CF790 File Offset: 0x008CD990
		// (set) Token: 0x0602051D RID: 132381 RVA: 0x008CF7C9 File Offset: 0x008CD9C9
		[Nullable(1)]
		public TArray<FParticle_QiuQian> particleArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FParticle_QiuQian> result;
				if ((result = this._particleArr) == null)
				{
					result = (this._particleArr = new TArray<FParticle_QiuQian>(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.particleArr.CopyAssign(value);
			}
		}

		// Token: 0x17003021 RID: 12321
		// (get) Token: 0x0602051E RID: 132382 RVA: 0x008CF7D7 File Offset: 0x008CD9D7
		// (set) Token: 0x0602051F RID: 132383 RVA: 0x008CF7EB File Offset: 0x008CD9EB
		public unsafe FVector rightNorm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06020520 RID: 132384 RVA: 0x008CF800 File Offset: 0x008CDA00
		// (set) Token: 0x06020521 RID: 132385 RVA: 0x008CF810 File Offset: 0x008CDA10
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06020522 RID: 132386 RVA: 0x008CF821 File Offset: 0x008CDA21
		// (set) Token: 0x06020523 RID: 132387 RVA: 0x008CF831 File Offset: 0x008CDA31
		public unsafe float endParticleMassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06020524 RID: 132388 RVA: 0x008CF842 File Offset: 0x008CDA42
		// (set) Token: 0x06020525 RID: 132389 RVA: 0x008CF852 File Offset: 0x008CDA52
		public unsafe float debugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06020526 RID: 132390 RVA: 0x008CF863 File Offset: 0x008CDA63
		// (set) Token: 0x06020527 RID: 132391 RVA: 0x008CF873 File Offset: 0x008CDA73
		public unsafe bool IsEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06020528 RID: 132392 RVA: 0x008CF884 File Offset: 0x008CDA84
		// (set) Token: 0x06020529 RID: 132393 RVA: 0x008CF894 File Offset: 0x008CDA94
		public unsafe bool IsPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x0602052A RID: 132394 RVA: 0x008CF8A5 File Offset: 0x008CDAA5
		// (set) Token: 0x0602052B RID: 132395 RVA: 0x008CF8B9 File Offset: 0x008CDAB9
		public unsafe UMaterialInstanceDynamic DMI_RopeL
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0602052C RID: 132396 RVA: 0x008CF8CE File Offset: 0x008CDACE
		// (set) Token: 0x0602052D RID: 132397 RVA: 0x008CF8E2 File Offset: 0x008CDAE2
		public unsafe UMaterialInstanceDynamic DMI_RopeR
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_QiuQian_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0602052E RID: 132398 RVA: 0x008CF8F7 File Offset: 0x008CDAF7
		// (set) Token: 0x0602052F RID: 132399 RVA: 0x008CF907 File Offset: 0x008CDB07
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x1700302A RID: 12330
		// (get) Token: 0x06020530 RID: 132400 RVA: 0x008CF918 File Offset: 0x008CDB18
		// (set) Token: 0x06020531 RID: 132401 RVA: 0x008CF928 File Offset: 0x008CDB28
		public unsafe bool IsWarm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x06020532 RID: 132402 RVA: 0x008CF939 File Offset: 0x008CDB39
		// (set) Token: 0x06020533 RID: 132403 RVA: 0x008CF949 File Offset: 0x008CDB49
		public unsafe float WarmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_QiuQian_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x06020534 RID: 132404 RVA: 0x008CF95A File Offset: 0x008CDB5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeParticleArr()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__InitializeParticleArr_NativeFunctionPtr, null);
		}

		// Token: 0x06020535 RID: 132405 RVA: 0x008CF970 File Offset: 0x008CDB70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetDMIOffsetEnable(bool OffsetEnable)
		{
			BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams* ptr = stackalloc BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(BP_QiuQian_C.__SetDMIOffsetEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OffsetEnable = OffsetEnable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__SetDMIOffsetEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x008CF9B6 File Offset: 0x008CDBB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateaDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__UpdateaDMI_NativeFunctionPtr, null);
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x008CF9CA File Offset: 0x008CDBCA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializeDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__InitializeDMI_NativeFunctionPtr, null);
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x008CF9E0 File Offset: 0x008CDBE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_QiuQian_C.__solve_FunctionParams* ptr = stackalloc BP_QiuQian_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_QiuQian_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x06020539 RID: 132409 RVA: 0x008CFA61 File Offset: 0x008CDC61
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602053A RID: 132410 RVA: 0x008CFA75 File Offset: 0x008CDC75
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602053B RID: 132411 RVA: 0x008CFA8A File Offset: 0x008CDC8A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602053C RID: 132412 RVA: 0x008CFA9E File Offset: 0x008CDC9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602053D RID: 132413 RVA: 0x008CFAB4 File Offset: 0x008CDCB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_QiuQian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602053E RID: 132414 RVA: 0x008CFAFC File Offset: 0x008CDCFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_QiuQian_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_QiuQian_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_QiuQian_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602053F RID: 132415 RVA: 0x008CFB43 File Offset: 0x008CDD43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void place_plank_event()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__place_plank_event_NativeFunctionPtr, null);
		}

		// Token: 0x06020540 RID: 132416 RVA: 0x008CFB57 File Offset: 0x008CDD57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06020541 RID: 132417 RVA: 0x008CFB6B File Offset: 0x008CDD6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020542 RID: 132418 RVA: 0x008CFB80 File Offset: 0x008CDD80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06020543 RID: 132419 RVA: 0x008CFB94 File Offset: 0x008CDD94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_QiuQian_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020544 RID: 132420 RVA: 0x008CFBA9 File Offset: 0x008CDDA9
		protected BP_QiuQian_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FA0E RID: 64014
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SwingInteraction/BP_QiuQian.BP_QiuQian_C";

		// Token: 0x0400FA0F RID: 64015
		private static IntPtr _ClassPtr;

		// Token: 0x0400FA10 RID: 64016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FA11 RID: 64017
		internal new static int __PropertyOffset_1;

		// Token: 0x0400FA12 RID: 64018
		internal static int __PropertyOffset_2;

		// Token: 0x0400FA13 RID: 64019
		internal static int __PropertyOffset_3;

		// Token: 0x0400FA14 RID: 64020
		internal static int __PropertyOffset_4;

		// Token: 0x0400FA15 RID: 64021
		internal static int __PropertyOffset_5;

		// Token: 0x0400FA16 RID: 64022
		private TArray<FName> _NameList;

		// Token: 0x0400FA17 RID: 64023
		internal static int __PropertyOffset_6;

		// Token: 0x0400FA18 RID: 64024
		internal static int __PropertyOffset_7;

		// Token: 0x0400FA19 RID: 64025
		internal static int __PropertyOffset_8;

		// Token: 0x0400FA1A RID: 64026
		internal static int __PropertyOffset_9;

		// Token: 0x0400FA1B RID: 64027
		internal static int __PropertyOffset_10;

		// Token: 0x0400FA1C RID: 64028
		internal static int __PropertyOffset_11;

		// Token: 0x0400FA1D RID: 64029
		internal static int __PropertyOffset_12;

		// Token: 0x0400FA1E RID: 64030
		internal static int __PropertyOffset_13;

		// Token: 0x0400FA1F RID: 64031
		internal static int __PropertyOffset_14;

		// Token: 0x0400FA20 RID: 64032
		internal static int __PropertyOffset_15;

		// Token: 0x0400FA21 RID: 64033
		internal static int __PropertyOffset_16;

		// Token: 0x0400FA22 RID: 64034
		internal static int __PropertyOffset_17;

		// Token: 0x0400FA23 RID: 64035
		internal static int __PropertyOffset_18;

		// Token: 0x0400FA24 RID: 64036
		internal static int __PropertyOffset_19;

		// Token: 0x0400FA25 RID: 64037
		internal static int __PropertyOffset_20;

		// Token: 0x0400FA26 RID: 64038
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticle_QiuQian> _particleArr;

		// Token: 0x0400FA27 RID: 64039
		internal static int __PropertyOffset_21;

		// Token: 0x0400FA28 RID: 64040
		internal static int __PropertyOffset_22;

		// Token: 0x0400FA29 RID: 64041
		internal static int __PropertyOffset_23;

		// Token: 0x0400FA2A RID: 64042
		internal static int __PropertyOffset_24;

		// Token: 0x0400FA2B RID: 64043
		internal static int __PropertyOffset_25;

		// Token: 0x0400FA2C RID: 64044
		internal static int __PropertyOffset_26;

		// Token: 0x0400FA2D RID: 64045
		internal static int __PropertyOffset_27;

		// Token: 0x0400FA2E RID: 64046
		internal static int __PropertyOffset_28;

		// Token: 0x0400FA2F RID: 64047
		internal static int __PropertyOffset_29;

		// Token: 0x0400FA30 RID: 64048
		internal static int __PropertyOffset_30;

		// Token: 0x0400FA31 RID: 64049
		internal static int __PropertyOffset_31;

		// Token: 0x0400FA32 RID: 64050
		private static IntPtr __InitializeParticleArr_NativeFunctionPtr;

		// Token: 0x0400FA33 RID: 64051
		private static IntPtr __SetDMIOffsetEnable_NativeFunctionPtr;

		// Token: 0x0400FA34 RID: 64052
		private static IntPtr __UpdateaDMI_NativeFunctionPtr;

		// Token: 0x0400FA35 RID: 64053
		private static IntPtr __InitializeDMI_NativeFunctionPtr;

		// Token: 0x0400FA36 RID: 64054
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x0400FA37 RID: 64055
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FA38 RID: 64056
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FA39 RID: 64057
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FA3A RID: 64058
		private static IntPtr __place_plank_event_NativeFunctionPtr;

		// Token: 0x0400FA3B RID: 64059
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x0400FA3C RID: 64060
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x02009BA2 RID: 39842
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __SetDMIOffsetEnable_FunctionParams
		{
			// Token: 0x04031200 RID: 201216
			[FieldOffset(0)]
			public bool OffsetEnable;
		}

		// Token: 0x02009BA3 RID: 39843
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x04031201 RID: 201217
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x04031202 RID: 201218
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x04031203 RID: 201219
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x04031204 RID: 201220
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x04031205 RID: 201221
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x04031206 RID: 201222
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009BA4 RID: 39844
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031207 RID: 201223
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
