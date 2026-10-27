using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Foliage
{
	// Token: 0x02003D83 RID: 15747
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Foliage/BP_TranslucentFoliage.BP_TranslucentFoliage_C")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class BP_TranslucentFoliage_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B13 RID: 158483 RVA: 0x0097C220 File Offset: 0x0097A420
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TranslucentFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Foliage/BP_TranslucentFoliage.BP_TranslucentFoliage_C");
			}
			return BP_TranslucentFoliage_C._ClassPtr;
		}

		// Token: 0x06026B14 RID: 158484 RVA: 0x0097C244 File Offset: 0x0097A444
		public BP_TranslucentFoliage_C() : this(BuiltinUtils.AllocNativeUObject(BP_TranslucentFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B15 RID: 158485 RVA: 0x0097C26C File Offset: 0x0097A46C
		public BP_TranslucentFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TranslucentFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170053A3 RID: 21411
		// (get) Token: 0x06026B16 RID: 158486 RVA: 0x0097C29F File Offset: 0x0097A49F
		// (set) Token: 0x06026B17 RID: 158487 RVA: 0x0097C2B3 File Offset: 0x0097A4B3
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TranslucentFoliage_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TranslucentFoliage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170053A4 RID: 21412
		// (get) Token: 0x06026B18 RID: 158488 RVA: 0x0097C2C8 File Offset: 0x0097A4C8
		// (set) Token: 0x06026B19 RID: 158489 RVA: 0x0097C2DC File Offset: 0x0097A4DC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TranslucentFoliage_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TranslucentFoliage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170053A5 RID: 21413
		// (get) Token: 0x06026B1A RID: 158490 RVA: 0x0097C2F1 File Offset: 0x0097A4F1
		// (set) Token: 0x06026B1B RID: 158491 RVA: 0x0097C301 File Offset: 0x0097A501
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x06026B1C RID: 158492 RVA: 0x0097C312 File Offset: 0x0097A512
		// (set) Token: 0x06026B1D RID: 158493 RVA: 0x0097C322 File Offset: 0x0097A522
		public unsafe bool bVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053A7 RID: 21415
		// (get) Token: 0x06026B1E RID: 158494 RVA: 0x0097C333 File Offset: 0x0097A533
		// (set) Token: 0x06026B1F RID: 158495 RVA: 0x0097C343 File Offset: 0x0097A543
		public unsafe bool bDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170053A8 RID: 21416
		// (get) Token: 0x06026B20 RID: 158496 RVA: 0x0097C354 File Offset: 0x0097A554
		// (set) Token: 0x06026B21 RID: 158497 RVA: 0x0097C38D File Offset: 0x0097A58D
		public TArray<UMaterialInterface> MaterialsWithDissolve
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MaterialsWithDissolve) == null)
				{
					result = (this._MaterialsWithDissolve = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.MaterialsWithDissolve.CopyAssign(value);
			}
		}

		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x06026B22 RID: 158498 RVA: 0x0097C39C File Offset: 0x0097A59C
		// (set) Token: 0x06026B23 RID: 158499 RVA: 0x0097C3D5 File Offset: 0x0097A5D5
		public TArray<UMaterialInterface> MaterialsWithoutDissolve
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MaterialsWithoutDissolve) == null)
				{
					result = (this._MaterialsWithoutDissolve = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_TranslucentFoliage_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.MaterialsWithoutDissolve.CopyAssign(value);
			}
		}

		// Token: 0x06026B24 RID: 158500 RVA: 0x0097C3E3 File Offset: 0x0097A5E3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TranslucentFoliage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06026B25 RID: 158501 RVA: 0x0097C3F7 File Offset: 0x0097A5F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TranslucentFoliage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B26 RID: 158502 RVA: 0x0097C40C File Offset: 0x0097A60C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TranslucentFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06026B27 RID: 158503 RVA: 0x0097C420 File Offset: 0x0097A620
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TranslucentFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06026B28 RID: 158504 RVA: 0x0097C438 File Offset: 0x0097A638
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TranslucentFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TranslucentFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06026B29 RID: 158505 RVA: 0x0097C480 File Offset: 0x0097A680
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TranslucentFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TranslucentFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TranslucentFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06026B2A RID: 158506 RVA: 0x0097C4C7 File Offset: 0x0097A6C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TranslucentFoliage_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06026B2B RID: 158507 RVA: 0x0097C4DB File Offset: 0x0097A6DB
		protected BP_TranslucentFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401374D RID: 79693
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Foliage/BP_TranslucentFoliage.BP_TranslucentFoliage_C";

		// Token: 0x0401374E RID: 79694
		private static IntPtr _ClassPtr;

		// Token: 0x0401374F RID: 79695
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013750 RID: 79696
		internal static int __PropertyOffset_1;

		// Token: 0x04013751 RID: 79697
		internal static int __PropertyOffset_2;

		// Token: 0x04013752 RID: 79698
		internal static int __PropertyOffset_3;

		// Token: 0x04013753 RID: 79699
		internal static int __PropertyOffset_4;

		// Token: 0x04013754 RID: 79700
		internal static int __PropertyOffset_5;

		// Token: 0x04013755 RID: 79701
		internal static int __PropertyOffset_6;

		// Token: 0x04013756 RID: 79702
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MaterialsWithDissolve;

		// Token: 0x04013757 RID: 79703
		internal static int __PropertyOffset_7;

		// Token: 0x04013758 RID: 79704
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MaterialsWithoutDissolve;

		// Token: 0x04013759 RID: 79705
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401375A RID: 79706
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401375B RID: 79707
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401375C RID: 79708
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A148 RID: 41288
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031CEA RID: 204010
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
