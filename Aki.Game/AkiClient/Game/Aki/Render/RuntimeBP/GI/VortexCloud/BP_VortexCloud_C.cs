using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.VortexCloud
{
	// Token: 0x02003D34 RID: 15668
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/VortexCloud/BP_VortexCloud.BP_VortexCloud_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1562)]
	public class BP_VortexCloud_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025FD1 RID: 155601 RVA: 0x00968562 File Offset: 0x00966762
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VortexCloud_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/VortexCloud/BP_VortexCloud.BP_VortexCloud_C");
			}
			return BP_VortexCloud_C._ClassPtr;
		}

		// Token: 0x06025FD2 RID: 155602 RVA: 0x00968588 File Offset: 0x00966788
		public BP_VortexCloud_C() : this(BuiltinUtils.AllocNativeUObject(BP_VortexCloud_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025FD3 RID: 155603 RVA: 0x009685B0 File Offset: 0x009667B0
		[NullableContext(1)]
		public BP_VortexCloud_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VortexCloud_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x06025FD4 RID: 155604 RVA: 0x009685E3 File Offset: 0x009667E3
		// (set) Token: 0x06025FD5 RID: 155605 RVA: 0x009685F7 File Offset: 0x009667F7
		public unsafe UStaticMeshComponent SM_StromCloud_ES3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004FE0 RID: 20448
		// (get) Token: 0x06025FD6 RID: 155606 RVA: 0x0096860C File Offset: 0x0096680C
		// (set) Token: 0x06025FD7 RID: 155607 RVA: 0x00968620 File Offset: 0x00966820
		public unsafe UStaticMeshComponent SM_VortexCloud
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x06025FD8 RID: 155608 RVA: 0x00968635 File Offset: 0x00966835
		// (set) Token: 0x06025FD9 RID: 155609 RVA: 0x00968649 File Offset: 0x00966849
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004FE2 RID: 20450
		// (get) Token: 0x06025FDA RID: 155610 RVA: 0x0096865E File Offset: 0x0096685E
		// (set) Token: 0x06025FDB RID: 155611 RVA: 0x0096866E File Offset: 0x0096686E
		public unsafe bool Updata
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06025FDC RID: 155612 RVA: 0x0096867F File Offset: 0x0096687F
		// (set) Token: 0x06025FDD RID: 155613 RVA: 0x00968693 File Offset: 0x00966893
		public unsafe UMaterialInstanceDynamic DMI_VortexCloud_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x06025FDE RID: 155614 RVA: 0x009686A8 File Offset: 0x009668A8
		// (set) Token: 0x06025FDF RID: 155615 RVA: 0x009686BC File Offset: 0x009668BC
		public unsafe UMaterialInstanceDynamic DMI_VortexCloud_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x06025FE0 RID: 155616 RVA: 0x009686D1 File Offset: 0x009668D1
		// (set) Token: 0x06025FE1 RID: 155617 RVA: 0x009686E5 File Offset: 0x009668E5
		public unsafe UStaticMesh VortexCloudMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x06025FE2 RID: 155618 RVA: 0x009686FA File Offset: 0x009668FA
		// (set) Token: 0x06025FE3 RID: 155619 RVA: 0x0096870E File Offset: 0x0096690E
		public unsafe UMaterialInstance Cloud_MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06025FE4 RID: 155620 RVA: 0x00968723 File Offset: 0x00966923
		// (set) Token: 0x06025FE5 RID: 155621 RVA: 0x00968733 File Offset: 0x00966933
		public unsafe float Scaler
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06025FE6 RID: 155622 RVA: 0x00968744 File Offset: 0x00966944
		// (set) Token: 0x06025FE7 RID: 155623 RVA: 0x00968754 File Offset: 0x00966954
		public unsafe float WorldOffsetIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06025FE8 RID: 155624 RVA: 0x00968765 File Offset: 0x00966965
		// (set) Token: 0x06025FE9 RID: 155625 RVA: 0x00968775 File Offset: 0x00966975
		public unsafe float FlowMap_DistortIntansity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x06025FEA RID: 155626 RVA: 0x00968786 File Offset: 0x00966986
		// (set) Token: 0x06025FEB RID: 155627 RVA: 0x00968796 File Offset: 0x00966996
		public unsafe float FlowMap_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x06025FEC RID: 155628 RVA: 0x009687A7 File Offset: 0x009669A7
		// (set) Token: 0x06025FED RID: 155629 RVA: 0x009687BB File Offset: 0x009669BB
		public unsafe AKuroPostProcessVolume Current_PostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x06025FEE RID: 155630 RVA: 0x009687D0 File Offset: 0x009669D0
		// (set) Token: 0x06025FEF RID: 155631 RVA: 0x009687E4 File Offset: 0x009669E4
		public unsafe BP_GlobalGI_C BP_Global_GI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VortexCloud_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06025FF0 RID: 155632 RVA: 0x009687F9 File Offset: 0x009669F9
		// (set) Token: 0x06025FF1 RID: 155633 RVA: 0x00968809 File Offset: 0x00966A09
		public unsafe bool Is_Android
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06025FF2 RID: 155634 RVA: 0x0096881A File Offset: 0x00966A1A
		// (set) Token: 0x06025FF3 RID: 155635 RVA: 0x0096882A File Offset: 0x00966A2A
		public unsafe bool Is_Haidao
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VortexCloud_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025FF4 RID: 155636 RVA: 0x0096883B File Offset: 0x00966A3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Is_PC_Or_Android()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__Is_PC_Or_Android_NativeFunctionPtr, null);
		}

		// Token: 0x06025FF5 RID: 155637 RVA: 0x0096884F File Offset: 0x00966A4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_VortexParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__Set_VortexParameters_NativeFunctionPtr, null);
		}

		// Token: 0x06025FF6 RID: 155638 RVA: 0x00968863 File Offset: 0x00966A63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Current_Post_Process_Weight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__Set_Current_Post_Process_Weight_NativeFunctionPtr, null);
		}

		// Token: 0x06025FF7 RID: 155639 RVA: 0x00968877 File Offset: 0x00966A77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025FF8 RID: 155640 RVA: 0x0096888B File Offset: 0x00966A8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VortexCloud_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025FF9 RID: 155641 RVA: 0x009688A0 File Offset: 0x00966AA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025FFA RID: 155642 RVA: 0x009688B4 File Offset: 0x00966AB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VortexCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025FFB RID: 155643 RVA: 0x009688CC File Offset: 0x00966ACC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_VortexCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VortexCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VortexCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VortexCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FFC RID: 155644 RVA: 0x00968914 File Offset: 0x00966B14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_VortexCloud_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_VortexCloud_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VortexCloud_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VortexCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VortexCloud_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025FFD RID: 155645 RVA: 0x0096895C File Offset: 0x00966B5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_VortexCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VortexCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VortexCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VortexCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_VortexCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025FFE RID: 155646 RVA: 0x009689A4 File Offset: 0x00966BA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_VortexCloud_C.__EditorTick_FunctionParams* ptr = stackalloc BP_VortexCloud_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_VortexCloud_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_VortexCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_VortexCloud_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025FFF RID: 155647 RVA: 0x009689EB File Offset: 0x00966BEB
		protected BP_VortexCloud_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013014 RID: 77844
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/VortexCloud/BP_VortexCloud.BP_VortexCloud_C";

		// Token: 0x04013015 RID: 77845
		private static IntPtr _ClassPtr;

		// Token: 0x04013016 RID: 77846
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013017 RID: 77847
		internal static int __PropertyOffset_1;

		// Token: 0x04013018 RID: 77848
		internal static int __PropertyOffset_2;

		// Token: 0x04013019 RID: 77849
		internal static int __PropertyOffset_3;

		// Token: 0x0401301A RID: 77850
		internal static int __PropertyOffset_4;

		// Token: 0x0401301B RID: 77851
		internal static int __PropertyOffset_5;

		// Token: 0x0401301C RID: 77852
		internal static int __PropertyOffset_6;

		// Token: 0x0401301D RID: 77853
		internal static int __PropertyOffset_7;

		// Token: 0x0401301E RID: 77854
		internal static int __PropertyOffset_8;

		// Token: 0x0401301F RID: 77855
		internal static int __PropertyOffset_9;

		// Token: 0x04013020 RID: 77856
		internal static int __PropertyOffset_10;

		// Token: 0x04013021 RID: 77857
		internal static int __PropertyOffset_11;

		// Token: 0x04013022 RID: 77858
		internal static int __PropertyOffset_12;

		// Token: 0x04013023 RID: 77859
		internal static int __PropertyOffset_13;

		// Token: 0x04013024 RID: 77860
		internal static int __PropertyOffset_14;

		// Token: 0x04013025 RID: 77861
		internal static int __PropertyOffset_15;

		// Token: 0x04013026 RID: 77862
		internal static int __PropertyOffset_16;

		// Token: 0x04013027 RID: 77863
		private static IntPtr __Is_PC_Or_Android_NativeFunctionPtr;

		// Token: 0x04013028 RID: 77864
		private static IntPtr __Set_VortexParameters_NativeFunctionPtr;

		// Token: 0x04013029 RID: 77865
		private static IntPtr __Set_Current_Post_Process_Weight_NativeFunctionPtr;

		// Token: 0x0401302A RID: 77866
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401302B RID: 77867
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401302C RID: 77868
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401302D RID: 77869
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A081 RID: 41089
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031B79 RID: 203641
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A082 RID: 41090
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031B7A RID: 203642
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
