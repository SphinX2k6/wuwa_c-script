using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneInteraction
{
	// Token: 0x02003C1A RID: 15386
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_MoonBuiDissipate.BP_MoonBuiDissipate_C")]
	[UnrealStructLayout(1504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1504)]
	public class BP_MoonBuiDissipate_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233CE RID: 144334 RVA: 0x0091E602 File Offset: 0x0091C802
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MoonBuiDissipate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_MoonBuiDissipate.BP_MoonBuiDissipate_C");
			}
			return BP_MoonBuiDissipate_C._ClassPtr;
		}

		// Token: 0x060233CF RID: 144335 RVA: 0x0091E628 File Offset: 0x0091C828
		public BP_MoonBuiDissipate_C() : this(BuiltinUtils.AllocNativeUObject(BP_MoonBuiDissipate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233D0 RID: 144336 RVA: 0x0091E650 File Offset: 0x0091C850
		[NullableContext(1)]
		public BP_MoonBuiDissipate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MoonBuiDissipate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x060233D1 RID: 144337 RVA: 0x0091E683 File Offset: 0x0091C883
		// (set) Token: 0x060233D2 RID: 144338 RVA: 0x0091E697 File Offset: 0x0091C897
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x060233D3 RID: 144339 RVA: 0x0091E6AC File Offset: 0x0091C8AC
		// (set) Token: 0x060233D4 RID: 144340 RVA: 0x0091E6C0 File Offset: 0x0091C8C0
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x060233D5 RID: 144341 RVA: 0x0091E6D5 File Offset: 0x0091C8D5
		// (set) Token: 0x060233D6 RID: 144342 RVA: 0x0091E6E9 File Offset: 0x0091C8E9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x060233D7 RID: 144343 RVA: 0x0091E6FE File Offset: 0x0091C8FE
		// (set) Token: 0x060233D8 RID: 144344 RVA: 0x0091E70E File Offset: 0x0091C90E
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoonBuiDissipate_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoonBuiDissipate_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004041 RID: 16449
		// (get) Token: 0x060233D9 RID: 144345 RVA: 0x0091E71F File Offset: 0x0091C91F
		// (set) Token: 0x060233DA RID: 144346 RVA: 0x0091E72F File Offset: 0x0091C92F
		public unsafe bool IsDone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MoonBuiDissipate_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MoonBuiDissipate_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004042 RID: 16450
		// (get) Token: 0x060233DB RID: 144347 RVA: 0x0091E740 File Offset: 0x0091C940
		// (set) Token: 0x060233DC RID: 144348 RVA: 0x0091E754 File Offset: 0x0091C954
		public unsafe UStaticMesh 模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MoonBuiDissipate_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x060233DD RID: 144349 RVA: 0x0091E769 File Offset: 0x0091C969
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MoonBuiDissipate_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060233DE RID: 144350 RVA: 0x0091E77D File Offset: 0x0091C97D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MoonBuiDissipate_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060233DF RID: 144351 RVA: 0x0091E794 File Offset: 0x0091C994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MoonBuiDissipate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MoonBuiDissipate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233E0 RID: 144352 RVA: 0x0091E7DC File Offset: 0x0091C9DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MoonBuiDissipate_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MoonBuiDissipate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MoonBuiDissipate_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060233E1 RID: 144353 RVA: 0x0091E824 File Offset: 0x0091CA24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_MoonBuiDissipate_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_MoonBuiDissipate_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_MoonBuiDissipate_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MoonBuiDissipate_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MoonBuiDissipate_C.__BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060233E2 RID: 144354 RVA: 0x0091E8DE File Offset: 0x0091CADE
		protected BP_MoonBuiDissipate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115FD RID: 71165
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneInteraction/BP_MoonBuiDissipate.BP_MoonBuiDissipate_C";

		// Token: 0x040115FE RID: 71166
		private static IntPtr _ClassPtr;

		// Token: 0x040115FF RID: 71167
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011600 RID: 71168
		internal static int __PropertyOffset_1;

		// Token: 0x04011601 RID: 71169
		internal static int __PropertyOffset_2;

		// Token: 0x04011602 RID: 71170
		internal static int __PropertyOffset_3;

		// Token: 0x04011603 RID: 71171
		internal static int __PropertyOffset_4;

		// Token: 0x04011604 RID: 71172
		internal static int __PropertyOffset_5;

		// Token: 0x04011605 RID: 71173
		internal static int __PropertyOffset_6;

		// Token: 0x04011606 RID: 71174
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011607 RID: 71175
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011608 RID: 71176
		private static IntPtr __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E3D RID: 40509
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316A2 RID: 202402
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E3E RID: 40510
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__NewBlueprint_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040316A3 RID: 202403
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040316A4 RID: 202404
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040316A5 RID: 202405
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040316A6 RID: 202406
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040316A7 RID: 202407
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040316A8 RID: 202408
			[FieldOffset(32)]
			public byte SweepResult;
		}
	}
}
