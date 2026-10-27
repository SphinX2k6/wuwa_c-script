using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.RayTracing
{
	// Token: 0x02003BBC RID: 15292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/RayTracing/BP_RaytracingFeatureTriggerVolume.BP_RaytracingFeatureTriggerVolume_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_RaytracingFeatureTriggerVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060222BF RID: 139967 RVA: 0x009018AF File Offset: 0x008FFAAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RaytracingFeatureTriggerVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/RayTracing/BP_RaytracingFeatureTriggerVolume.BP_RaytracingFeatureTriggerVolume_C");
			}
			return BP_RaytracingFeatureTriggerVolume_C._ClassPtr;
		}

		// Token: 0x060222C0 RID: 139968 RVA: 0x009018D4 File Offset: 0x008FFAD4
		public BP_RaytracingFeatureTriggerVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_RaytracingFeatureTriggerVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060222C1 RID: 139969 RVA: 0x009018FC File Offset: 0x008FFAFC
		public BP_RaytracingFeatureTriggerVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RaytracingFeatureTriggerVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x060222C2 RID: 139970 RVA: 0x0090192F File Offset: 0x008FFB2F
		// (set) Token: 0x060222C3 RID: 139971 RVA: 0x00901943 File Offset: 0x008FFB43
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RaytracingFeatureTriggerVolume_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RaytracingFeatureTriggerVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x060222C4 RID: 139972 RVA: 0x00901958 File Offset: 0x008FFB58
		// (set) Token: 0x060222C5 RID: 139973 RVA: 0x00901991 File Offset: 0x008FFB91
		public TArray<int> PreValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PreValues) == null)
				{
					result = (this._PreValues = new TArray<int>(base.NativePtr + (IntPtr)BP_RaytracingFeatureTriggerVolume_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.PreValues.CopyAssign(value);
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x060222C6 RID: 139974 RVA: 0x009019A0 File Offset: 0x008FFBA0
		// (set) Token: 0x060222C7 RID: 139975 RVA: 0x009019D9 File Offset: 0x008FFBD9
		public TArray<string> RaytracingCmd
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._RaytracingCmd) == null)
				{
					result = (this._RaytracingCmd = new TArray<string>(base.NativePtr + (IntPtr)BP_RaytracingFeatureTriggerVolume_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.RaytracingCmd.CopyAssign(value);
			}
		}

		// Token: 0x060222C8 RID: 139976 RVA: 0x009019E8 File Offset: 0x008FFBE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060222C9 RID: 139977 RVA: 0x00901AA4 File Offset: 0x008FFCA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RaytracingFeatureTriggerVolume_C.__BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060222CA RID: 139978 RVA: 0x00901B2D File Offset: 0x008FFD2D
		protected BP_RaytracingFeatureTriggerVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BDF RID: 68575
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/RayTracing/BP_RaytracingFeatureTriggerVolume.BP_RaytracingFeatureTriggerVolume_C";

		// Token: 0x04010BE0 RID: 68576
		private static IntPtr _ClassPtr;

		// Token: 0x04010BE1 RID: 68577
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BE2 RID: 68578
		internal static int __PropertyOffset_1;

		// Token: 0x04010BE3 RID: 68579
		internal static int __PropertyOffset_2;

		// Token: 0x04010BE4 RID: 68580
		[Nullable(2)]
		private TArray<int> _PreValues;

		// Token: 0x04010BE5 RID: 68581
		internal static int __PropertyOffset_3;

		// Token: 0x04010BE6 RID: 68582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _RaytracingCmd;

		// Token: 0x04010BE7 RID: 68583
		private static IntPtr __BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010BE8 RID: 68584
		private static IntPtr __BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D4B RID: 40267
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040314B6 RID: 201910
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040314B7 RID: 201911
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040314B8 RID: 201912
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040314B9 RID: 201913
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040314BA RID: 201914
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040314BB RID: 201915
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D4C RID: 40268
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RaytracingFeatureTrigger_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040314BC RID: 201916
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040314BD RID: 201917
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040314BE RID: 201918
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040314BF RID: 201919
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
