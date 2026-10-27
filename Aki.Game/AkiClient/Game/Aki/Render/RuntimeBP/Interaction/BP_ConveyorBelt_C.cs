using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D0D RID: 15629
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1496)]
	public class BP_ConveyorBelt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602571F RID: 153375 RVA: 0x00959EBD File Offset: 0x009580BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ConveyorBelt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C");
			}
			return BP_ConveyorBelt_C._ClassPtr;
		}

		// Token: 0x06025720 RID: 153376 RVA: 0x00959EE4 File Offset: 0x009580E4
		public BP_ConveyorBelt_C() : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025721 RID: 153377 RVA: 0x00959F0C File Offset: 0x0095810C
		[NullableContext(1)]
		public BP_ConveyorBelt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ConveyorBelt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x06025722 RID: 153378 RVA: 0x00959F3F File Offset: 0x0095813F
		// (set) Token: 0x06025723 RID: 153379 RVA: 0x00959F53 File Offset: 0x00958153
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x06025724 RID: 153380 RVA: 0x00959F68 File Offset: 0x00958168
		// (set) Token: 0x06025725 RID: 153381 RVA: 0x00959F7C File Offset: 0x0095817C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x06025726 RID: 153382 RVA: 0x00959F91 File Offset: 0x00958191
		// (set) Token: 0x06025727 RID: 153383 RVA: 0x00959FA5 File Offset: 0x009581A5
		public unsafe UStaticMesh ConveyorBeltMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x06025728 RID: 153384 RVA: 0x00959FBA File Offset: 0x009581BA
		// (set) Token: 0x06025729 RID: 153385 RVA: 0x00959FCA File Offset: 0x009581CA
		public unsafe int ConveyorBeltMaterialElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x0602572A RID: 153386 RVA: 0x00959FDB File Offset: 0x009581DB
		// (set) Token: 0x0602572B RID: 153387 RVA: 0x00959FEB File Offset: 0x009581EB
		public unsafe float RunningSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ConveyorBelt_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x0602572C RID: 153388 RVA: 0x00959FFC File Offset: 0x009581FC
		// (set) Token: 0x0602572D RID: 153389 RVA: 0x0095A010 File Offset: 0x00958210
		public unsafe UMaterialInstanceDynamic ConveyorBeltDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ConveyorBelt_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x0602572E RID: 153390 RVA: 0x0095A025 File Offset: 0x00958225
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CreateDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__CreateDMI_NativeFunctionPtr, null);
		}

		// Token: 0x0602572F RID: 153391 RVA: 0x0095A039 File Offset: 0x00958239
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025730 RID: 153392 RVA: 0x0095A04D File Offset: 0x0095824D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025731 RID: 153393 RVA: 0x0095A062 File Offset: 0x00958262
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025732 RID: 153394 RVA: 0x0095A076 File Offset: 0x00958276
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025733 RID: 153395 RVA: 0x0095A08C File Offset: 0x0095828C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025734 RID: 153396 RVA: 0x0095A0D4 File Offset: 0x009582D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025735 RID: 153397 RVA: 0x0095A11C File Offset: 0x0095831C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025736 RID: 153398 RVA: 0x0095A164 File Offset: 0x00958364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ConveyorBelt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ConveyorBelt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ConveyorBelt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ConveyorBelt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025737 RID: 153399 RVA: 0x0095A1AB File Offset: 0x009583AB
		protected BP_ConveyorBelt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012AEA RID: 76522
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_ConveyorBelt.BP_ConveyorBelt_C";

		// Token: 0x04012AEB RID: 76523
		private static IntPtr _ClassPtr;

		// Token: 0x04012AEC RID: 76524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012AED RID: 76525
		internal static int __PropertyOffset_1;

		// Token: 0x04012AEE RID: 76526
		internal static int __PropertyOffset_2;

		// Token: 0x04012AEF RID: 76527
		internal static int __PropertyOffset_3;

		// Token: 0x04012AF0 RID: 76528
		internal static int __PropertyOffset_4;

		// Token: 0x04012AF1 RID: 76529
		internal static int __PropertyOffset_5;

		// Token: 0x04012AF2 RID: 76530
		internal static int __PropertyOffset_6;

		// Token: 0x04012AF3 RID: 76531
		private static IntPtr __CreateDMI_NativeFunctionPtr;

		// Token: 0x04012AF4 RID: 76532
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012AF5 RID: 76533
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012AF6 RID: 76534
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012AF7 RID: 76535
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FFA RID: 40954
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A95 RID: 203413
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FFB RID: 40955
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A96 RID: 203414
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
