using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.InteractiveLighting
{
	// Token: 0x02003C9A RID: 15514
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis_Instance.BP_SimpleCollisionAxis_Instance_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1648)]
	public class BP_SimpleCollisionAxis_Instance_C : AKuroCSSimpleCollisionAxisInstanced, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245A8 RID: 148904 RVA: 0x0093C382 File Offset: 0x0093A582
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SimpleCollisionAxis_Instance_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis_Instance.BP_SimpleCollisionAxis_Instance_C");
			}
			return BP_SimpleCollisionAxis_Instance_C._ClassPtr;
		}

		// Token: 0x060245A9 RID: 148905 RVA: 0x0093C3A8 File Offset: 0x0093A5A8
		public BP_SimpleCollisionAxis_Instance_C() : this(BuiltinUtils.AllocNativeUObject(BP_SimpleCollisionAxis_Instance_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245AA RID: 148906 RVA: 0x0093C3D0 File Offset: 0x0093A5D0
		[NullableContext(1)]
		public BP_SimpleCollisionAxis_Instance_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SimpleCollisionAxis_Instance_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x060245AB RID: 148907 RVA: 0x0093C403 File Offset: 0x0093A603
		// (set) Token: 0x060245AC RID: 148908 RVA: 0x0093C417 File Offset: 0x0093A617
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x060245AD RID: 148909 RVA: 0x0093C42C File Offset: 0x0093A62C
		// (set) Token: 0x060245AE RID: 148910 RVA: 0x0093C440 File Offset: 0x0093A640
		public unsafe UTextureRenderTarget2D T_Particle_Pivot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x060245AF RID: 148911 RVA: 0x0093C455 File Offset: 0x0093A655
		// (set) Token: 0x060245B0 RID: 148912 RVA: 0x0093C465 File Offset: 0x0093A665
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x060245B1 RID: 148913 RVA: 0x0093C476 File Offset: 0x0093A676
		// (set) Token: 0x060245B2 RID: 148914 RVA: 0x0093C486 File Offset: 0x0093A686
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700469A RID: 18074
		// (get) Token: 0x060245B3 RID: 148915 RVA: 0x0093C497 File Offset: 0x0093A697
		// (set) Token: 0x060245B4 RID: 148916 RVA: 0x0093C4AB File Offset: 0x0093A6AB
		public unsafe UMaterialInterface CopyTexMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x060245B5 RID: 148917 RVA: 0x0093C4C0 File Offset: 0x0093A6C0
		// (set) Token: 0x060245B6 RID: 148918 RVA: 0x0093C4F9 File Offset: 0x0093A6F9
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> RenderMID
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._RenderMID) == null)
				{
					result = (this._RenderMID = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RenderMID.CopyAssign(value);
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x060245B7 RID: 148919 RVA: 0x0093C507 File Offset: 0x0093A707
		// (set) Token: 0x060245B8 RID: 148920 RVA: 0x0093C51B File Offset: 0x0093A71B
		public unsafe UStaticMesh SM_Ice1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x060245B9 RID: 148921 RVA: 0x0093C530 File Offset: 0x0093A730
		// (set) Token: 0x060245BA RID: 148922 RVA: 0x0093C544 File Offset: 0x0093A744
		public unsafe UStaticMesh SM_Ice2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x060245BB RID: 148923 RVA: 0x0093C559 File Offset: 0x0093A759
		// (set) Token: 0x060245BC RID: 148924 RVA: 0x0093C56D File Offset: 0x0093A76D
		public unsafe UStaticMesh SM_Ice3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x060245BD RID: 148925 RVA: 0x0093C582 File Offset: 0x0093A782
		// (set) Token: 0x060245BE RID: 148926 RVA: 0x0093C596 File Offset: 0x0093A796
		public unsafe UTexture2D Input_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170046A0 RID: 18080
		// (get) Token: 0x060245BF RID: 148927 RVA: 0x0093C5AB File Offset: 0x0093A7AB
		// (set) Token: 0x060245C0 RID: 148928 RVA: 0x0093C5BF File Offset: 0x0093A7BF
		public unsafe UTexture2D Input_Texture_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170046A1 RID: 18081
		// (get) Token: 0x060245C1 RID: 148929 RVA: 0x0093C5D4 File Offset: 0x0093A7D4
		// (set) Token: 0x060245C2 RID: 148930 RVA: 0x0093C5E8 File Offset: 0x0093A7E8
		public unsafe UTexture2D Input_Texture_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_Instance_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x060245C3 RID: 148931 RVA: 0x0093C5FD File Offset: 0x0093A7FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 重构ism()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__重构ism_NativeFunctionPtr, null);
		}

		// Token: 0x060245C4 RID: 148932 RVA: 0x0093C611 File Offset: 0x0093A811
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 应用贴图材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__应用贴图材质_NativeFunctionPtr, null);
		}

		// Token: 0x060245C5 RID: 148933 RVA: 0x0093C625 File Offset: 0x0093A825
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060245C6 RID: 148934 RVA: 0x0093C639 File Offset: 0x0093A839
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060245C7 RID: 148935 RVA: 0x0093C64E File Offset: 0x0093A84E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060245C8 RID: 148936 RVA: 0x0093C662 File Offset: 0x0093A862
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060245C9 RID: 148937 RVA: 0x0093C678 File Offset: 0x0093A878
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245CA RID: 148938 RVA: 0x0093C6C0 File Offset: 0x0093A8C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060245CB RID: 148939 RVA: 0x0093C708 File Offset: 0x0093A908
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245CC RID: 148940 RVA: 0x0093C7C4 File Offset: 0x0093A9C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245CD RID: 148941 RVA: 0x0093C850 File Offset: 0x0093AA50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InstanceRebuilt(int InstanceCount)
		{
			BP_SimpleCollisionAxis_Instance_C.__InstanceRebuilt_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_Instance_C.__InstanceRebuilt_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleCollisionAxis_Instance_C.__InstanceRebuilt_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_Instance_C.__InstanceRebuilt_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InstanceCount = InstanceCount;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_Instance_C.__InstanceRebuilt_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245CE RID: 148942 RVA: 0x0093C896 File Offset: 0x0093AA96
		protected BP_SimpleCollisionAxis_Instance_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012085 RID: 73861
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis_Instance.BP_SimpleCollisionAxis_Instance_C";

		// Token: 0x04012086 RID: 73862
		private static IntPtr _ClassPtr;

		// Token: 0x04012087 RID: 73863
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012088 RID: 73864
		internal static int __PropertyOffset_1;

		// Token: 0x04012089 RID: 73865
		internal static int __PropertyOffset_2;

		// Token: 0x0401208A RID: 73866
		internal static int __PropertyOffset_3;

		// Token: 0x0401208B RID: 73867
		internal static int __PropertyOffset_4;

		// Token: 0x0401208C RID: 73868
		internal static int __PropertyOffset_5;

		// Token: 0x0401208D RID: 73869
		internal static int __PropertyOffset_6;

		// Token: 0x0401208E RID: 73870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _RenderMID;

		// Token: 0x0401208F RID: 73871
		internal static int __PropertyOffset_7;

		// Token: 0x04012090 RID: 73872
		internal static int __PropertyOffset_8;

		// Token: 0x04012091 RID: 73873
		internal static int __PropertyOffset_9;

		// Token: 0x04012092 RID: 73874
		internal static int __PropertyOffset_10;

		// Token: 0x04012093 RID: 73875
		internal static int __PropertyOffset_11;

		// Token: 0x04012094 RID: 73876
		internal static int __PropertyOffset_12;

		// Token: 0x04012095 RID: 73877
		private static IntPtr __重构ism_NativeFunctionPtr;

		// Token: 0x04012096 RID: 73878
		private static IntPtr __应用贴图材质_NativeFunctionPtr;

		// Token: 0x04012097 RID: 73879
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012098 RID: 73880
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012099 RID: 73881
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401209A RID: 73882
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401209B RID: 73883
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401209C RID: 73884
		private static IntPtr __InstanceRebuilt_NativeFunctionPtr;

		// Token: 0x02009F07 RID: 40711
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031847 RID: 202823
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F08 RID: 40712
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031848 RID: 202824
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031849 RID: 202825
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403184A RID: 202826
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403184B RID: 202827
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403184C RID: 202828
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403184D RID: 202829
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F09 RID: 40713
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403184E RID: 202830
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403184F RID: 202831
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031850 RID: 202832
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031851 RID: 202833
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F0A RID: 40714
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __InstanceRebuilt_FunctionParams
		{
			// Token: 0x04031852 RID: 202834
			[FieldOffset(0)]
			public int InstanceCount;
		}
	}
}
