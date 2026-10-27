using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.MeshDissolve
{
	// Token: 0x02003C50 RID: 15440
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C")]
	[UnrealStructLayout(1704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1704)]
	public class BP_MeshDissolveInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06023CAC RID: 146604 RVA: 0x0092CE1E File Offset: 0x0092B01E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshDissolveInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C");
			}
			return BP_MeshDissolveInteraction_C._ClassPtr;
		}

		// Token: 0x06023CAD RID: 146605 RVA: 0x0092CE42 File Offset: 0x0092B042
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return BP_MeshDissolveInteraction_C.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x06023CAE RID: 146606 RVA: 0x0092CE4C File Offset: 0x0092B04C
		public BP_MeshDissolveInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshDissolveInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023CAF RID: 146607 RVA: 0x0092CE74 File Offset: 0x0092B074
		[NullableContext(1)]
		public BP_MeshDissolveInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshDissolveInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x06023CB0 RID: 146608 RVA: 0x0092CEA7 File Offset: 0x0092B0A7
		// (set) Token: 0x06023CB1 RID: 146609 RVA: 0x0092CEBB File Offset: 0x0092B0BB
		[Nullable(2)]
		public unsafe UNiagaraComponent NS_Fx_MeshDissolve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x06023CB2 RID: 146610 RVA: 0x0092CED0 File Offset: 0x0092B0D0
		// (set) Token: 0x06023CB3 RID: 146611 RVA: 0x0092CEE4 File Offset: 0x0092B0E4
		[Nullable(2)]
		public unsafe UStaticMeshComponent Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x06023CB4 RID: 146612 RVA: 0x0092CEF9 File Offset: 0x0092B0F9
		// (set) Token: 0x06023CB5 RID: 146613 RVA: 0x0092CF0D File Offset: 0x0092B10D
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshDissolveInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x06023CB6 RID: 146614 RVA: 0x0092CF24 File Offset: 0x0092B124
		// (set) Token: 0x06023CB7 RID: 146615 RVA: 0x0092CF5D File Offset: 0x0092B15D
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DMI
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DMI) == null)
				{
					result = (this._DMI = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DMI.CopyAssign(value);
			}
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x06023CB8 RID: 146616 RVA: 0x0092CF6B File Offset: 0x0092B16B
		// (set) Token: 0x06023CB9 RID: 146617 RVA: 0x0092CF7B File Offset: 0x0092B17B
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x06023CBA RID: 146618 RVA: 0x0092CF8C File Offset: 0x0092B18C
		// (set) Token: 0x06023CBB RID: 146619 RVA: 0x0092CF9C File Offset: 0x0092B19C
		public unsafe bool Dissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x06023CBC RID: 146620 RVA: 0x0092CFAD File Offset: 0x0092B1AD
		// (set) Token: 0x06023CBD RID: 146621 RVA: 0x0092CFBD File Offset: 0x0092B1BD
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170043A2 RID: 17314
		// (get) Token: 0x06023CBE RID: 146622 RVA: 0x0092CFCE File Offset: 0x0092B1CE
		// (set) Token: 0x06023CBF RID: 146623 RVA: 0x0092CFE2 File Offset: 0x0092B1E2
		public unsafe TEnumAsByte<E_MeshDissolveType> StaticMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170043A3 RID: 17315
		// (get) Token: 0x06023CC0 RID: 146624 RVA: 0x0092CFF8 File Offset: 0x0092B1F8
		// (set) Token: 0x06023CC1 RID: 146625 RVA: 0x0092D031 File Offset: 0x0092B231
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> MeshMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> result;
				if ((result = this._MeshMap) == null)
				{
					result = (this._MeshMap = new TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh>(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.MeshMap.CopyAssign(value);
			}
		}

		// Token: 0x170043A4 RID: 17316
		// (get) Token: 0x06023CC2 RID: 146626 RVA: 0x0092D03F File Offset: 0x0092B23F
		// (set) Token: 0x06023CC3 RID: 146627 RVA: 0x0092D053 File Offset: 0x0092B253
		public unsafe FVector BulletPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x06023CC4 RID: 146628 RVA: 0x0092D068 File Offset: 0x0092B268
		// (set) Token: 0x06023CC5 RID: 146629 RVA: 0x0092D078 File Offset: 0x0092B278
		public unsafe bool Visbility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x06023CC6 RID: 146630 RVA: 0x0092D089 File Offset: 0x0092B289
		// (set) Token: 0x06023CC7 RID: 146631 RVA: 0x0092D099 File Offset: 0x0092B299
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x06023CC8 RID: 146632 RVA: 0x0092D0AC File Offset: 0x0092B2AC
		// (set) Token: 0x06023CC9 RID: 146633 RVA: 0x0092D0E5 File Offset: 0x0092B2E5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> NiagaraMeshMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> result;
				if ((result = this._NiagaraMeshMap) == null)
				{
					result = (this._NiagaraMeshMap = new TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh>(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.NiagaraMeshMap.CopyAssign(value);
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x06023CCA RID: 146634 RVA: 0x0092D0F3 File Offset: 0x0092B2F3
		// (set) Token: 0x06023CCB RID: 146635 RVA: 0x0092D107 File Offset: 0x0092B307
		public unsafe FLinearColor DissolveColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshDissolveInteraction_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x06023CCC RID: 146636 RVA: 0x0092D11C File Offset: 0x0092B31C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void StartDissolve(FVectorDouble HitPos)
		{
			BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__StartDissolve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__StartDissolve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitPos = HitPos;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__StartDissolve_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CCD RID: 146637 RVA: 0x0092D165 File Offset: 0x0092B365
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06023CCE RID: 146638 RVA: 0x0092D17C File Offset: 0x0092B37C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateParams(float dt)
		{
			BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__UpdateParams_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UpdateParams_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CCF RID: 146639 RVA: 0x0092D1C2 File Offset: 0x0092B3C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023CD0 RID: 146640 RVA: 0x0092D1D6 File Offset: 0x0092B3D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023CD1 RID: 146641 RVA: 0x0092D1EC File Offset: 0x0092B3EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CD2 RID: 146642 RVA: 0x0092D234 File Offset: 0x0092B434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023CD3 RID: 146643 RVA: 0x0092D27C File Offset: 0x0092B47C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnBulletHit(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023CD4 RID: 146644 RVA: 0x0092D2D0 File Offset: 0x0092B4D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnBulletHit_Implementation(int BulletEntityId, in FVectorDouble HitPoint)
		{
			BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams* ptr = stackalloc BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_MeshDissolveInteraction_C.__OnBulletHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BulletEntityId = BulletEntityId;
			ptr->HitPoint = HitPoint;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshDissolveInteraction_C.__OnBulletHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023CD5 RID: 146645 RVA: 0x0092D323 File Offset: 0x0092B523
		protected BP_MeshDissolveInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B0A RID: 72458
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x04011B0B RID: 72459
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/MeshDissolve/BP_MeshDissolveInteraction.BP_MeshDissolveInteraction_C";

		// Token: 0x04011B0C RID: 72460
		private static IntPtr _ClassPtr;

		// Token: 0x04011B0D RID: 72461
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B0E RID: 72462
		internal static int __PropertyOffset_1;

		// Token: 0x04011B0F RID: 72463
		internal static int __PropertyOffset_2;

		// Token: 0x04011B10 RID: 72464
		internal static int __PropertyOffset_3;

		// Token: 0x04011B11 RID: 72465
		internal static int __PropertyOffset_4;

		// Token: 0x04011B12 RID: 72466
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DMI;

		// Token: 0x04011B13 RID: 72467
		internal static int __PropertyOffset_5;

		// Token: 0x04011B14 RID: 72468
		internal static int __PropertyOffset_6;

		// Token: 0x04011B15 RID: 72469
		internal static int __PropertyOffset_7;

		// Token: 0x04011B16 RID: 72470
		internal static int __PropertyOffset_8;

		// Token: 0x04011B17 RID: 72471
		internal static int __PropertyOffset_9;

		// Token: 0x04011B18 RID: 72472
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> _MeshMap;

		// Token: 0x04011B19 RID: 72473
		internal static int __PropertyOffset_10;

		// Token: 0x04011B1A RID: 72474
		internal static int __PropertyOffset_11;

		// Token: 0x04011B1B RID: 72475
		internal static int __PropertyOffset_12;

		// Token: 0x04011B1C RID: 72476
		internal static int __PropertyOffset_13;

		// Token: 0x04011B1D RID: 72477
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<E_MeshDissolveType>, UStaticMesh> _NiagaraMeshMap;

		// Token: 0x04011B1E RID: 72478
		internal static int __PropertyOffset_14;

		// Token: 0x04011B1F RID: 72479
		private static IntPtr __StartDissolve_NativeFunctionPtr;

		// Token: 0x04011B20 RID: 72480
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04011B21 RID: 72481
		private static IntPtr __UpdateParams_NativeFunctionPtr;

		// Token: 0x04011B22 RID: 72482
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011B23 RID: 72483
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011B24 RID: 72484
		private static IntPtr __OnBulletHit_NativeFunctionPtr;

		// Token: 0x02009E9F RID: 40607
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __StartDissolve_FunctionParams
		{
			// Token: 0x04031765 RID: 202597
			[FieldOffset(0)]
			public FVectorDouble HitPos;
		}

		// Token: 0x02009EA0 RID: 40608
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateParams_FunctionParams
		{
			// Token: 0x04031766 RID: 202598
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009EA1 RID: 40609
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031767 RID: 202599
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EA2 RID: 40610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnBulletHit_FunctionParams
		{
			// Token: 0x04031768 RID: 202600
			[FieldOffset(0)]
			public int BulletEntityId;

			// Token: 0x04031769 RID: 202601
			[FieldOffset(8)]
			public FVectorDouble HitPoint;
		}
	}
}
