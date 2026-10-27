using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D91 RID: 15761
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_Utilities.NinjaLive_Utilities_C")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1164)]
	public class NinjaLive_Utilities_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602703E RID: 159806 RVA: 0x009847BF File Offset: 0x009829BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (NinjaLive_Utilities_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_Utilities.NinjaLive_Utilities_C");
			}
			return NinjaLive_Utilities_C._ClassPtr;
		}

		// Token: 0x0602703F RID: 159807 RVA: 0x009847E4 File Offset: 0x009829E4
		public NinjaLive_Utilities_C() : this(BuiltinUtils.AllocNativeUObject(NinjaLive_Utilities_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027040 RID: 159808 RVA: 0x0098480C File Offset: 0x00982A0C
		[NullableContext(1)]
		public NinjaLive_Utilities_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(NinjaLive_Utilities_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170055DC RID: 21980
		// (get) Token: 0x06027041 RID: 159809 RVA: 0x0098483F File Offset: 0x00982A3F
		// (set) Token: 0x06027042 RID: 159810 RVA: 0x00984853 File Offset: 0x00982A53
		public unsafe UMaterialBillboardComponent EditorIcon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170055DD RID: 21981
		// (get) Token: 0x06027043 RID: 159811 RVA: 0x00984868 File Offset: 0x00982A68
		// (set) Token: 0x06027044 RID: 159812 RVA: 0x0098487C File Offset: 0x00982A7C
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170055DE RID: 21982
		// (get) Token: 0x06027045 RID: 159813 RVA: 0x00984891 File Offset: 0x00982A91
		// (set) Token: 0x06027046 RID: 159814 RVA: 0x009848A1 File Offset: 0x00982AA1
		public unsafe bool DisableBlueprint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055DF RID: 21983
		// (get) Token: 0x06027047 RID: 159815 RVA: 0x009848B2 File Offset: 0x00982AB2
		// (set) Token: 0x06027048 RID: 159816 RVA: 0x009848C2 File Offset: 0x00982AC2
		public unsafe bool OverrideEditor120_FPS_Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055E0 RID: 21984
		// (get) Token: 0x06027049 RID: 159817 RVA: 0x009848D3 File Offset: 0x00982AD3
		// (set) Token: 0x0602704A RID: 159818 RVA: 0x009848E3 File Offset: 0x00982AE3
		public unsafe int MaxEditorFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170055E1 RID: 21985
		// (get) Token: 0x0602704B RID: 159819 RVA: 0x009848F4 File Offset: 0x00982AF4
		// (set) Token: 0x0602704C RID: 159820 RVA: 0x00984904 File Offset: 0x00982B04
		public unsafe bool CameraAndCursorSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055E2 RID: 21986
		// (get) Token: 0x0602704D RID: 159821 RVA: 0x00984915 File Offset: 0x00982B15
		// (set) Token: 0x0602704E RID: 159822 RVA: 0x00984925 File Offset: 0x00982B25
		public unsafe int MaxCameraMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170055E3 RID: 21987
		// (get) Token: 0x0602704F RID: 159823 RVA: 0x00984936 File Offset: 0x00982B36
		// (set) Token: 0x06027050 RID: 159824 RVA: 0x00984946 File Offset: 0x00982B46
		public unsafe bool PossessNearestPawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055E4 RID: 21988
		// (get) Token: 0x06027051 RID: 159825 RVA: 0x00984958 File Offset: 0x00982B58
		// (set) Token: 0x06027052 RID: 159826 RVA: 0x00984991 File Offset: 0x00982B91
		[Nullable(1)]
		public TArray<int> TempArray1
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TempArray1) == null)
				{
					result = (this._TempArray1 = new TArray<int>(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempArray1.CopyAssign(value);
			}
		}

		// Token: 0x170055E5 RID: 21989
		// (get) Token: 0x06027053 RID: 159827 RVA: 0x009849A0 File Offset: 0x00982BA0
		// (set) Token: 0x06027054 RID: 159828 RVA: 0x009849D9 File Offset: 0x00982BD9
		[Nullable(1)]
		public TArray<APawn> TempArray2
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<APawn> result;
				if ((result = this._TempArray2) == null)
				{
					result = (this._TempArray2 = new TArray<APawn>(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TempArray2.CopyAssign(value);
			}
		}

		// Token: 0x170055E6 RID: 21990
		// (get) Token: 0x06027055 RID: 159829 RVA: 0x009849E7 File Offset: 0x00982BE7
		// (set) Token: 0x06027056 RID: 159830 RVA: 0x009849F7 File Offset: 0x00982BF7
		public unsafe bool ShowMouseCursor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170055E7 RID: 21991
		// (get) Token: 0x06027057 RID: 159831 RVA: 0x00984A08 File Offset: 0x00982C08
		// (set) Token: 0x06027058 RID: 159832 RVA: 0x00984A1C File Offset: 0x00982C1C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> WidgetToRotateDirectionalLight
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_12);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x06027059 RID: 159833 RVA: 0x00984A31 File Offset: 0x00982C31
		// (set) Token: 0x0602705A RID: 159834 RVA: 0x00984A45 File Offset: 0x00982C45
		public unsafe ADirectionalLight WidgetTargetDirectionalLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + NinjaLive_Utilities_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x0602705B RID: 159835 RVA: 0x00984A5A File Offset: 0x00982C5A
		// (set) Token: 0x0602705C RID: 159836 RVA: 0x00984A6A File Offset: 0x00982C6A
		public unsafe int AntialiasingQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x0602705D RID: 159837 RVA: 0x00984A7B File Offset: 0x00982C7B
		// (set) Token: 0x0602705E RID: 159838 RVA: 0x00984A8B File Offset: 0x00982C8B
		public unsafe int DepthOfFieldQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x0602705F RID: 159839 RVA: 0x00984A9C File Offset: 0x00982C9C
		// (set) Token: 0x06027060 RID: 159840 RVA: 0x00984AAC File Offset: 0x00982CAC
		public unsafe int MotionBlurQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)NinjaLive_Utilities_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06027061 RID: 159841 RVA: 0x00984ABD File Offset: 0x00982CBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027062 RID: 159842 RVA: 0x00984AD1 File Offset: 0x00982CD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_Utilities_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027063 RID: 159843 RVA: 0x00984AE8 File Offset: 0x00982CE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027064 RID: 159844 RVA: 0x00984B5C File Offset: 0x00982D5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027065 RID: 159845 RVA: 0x00984BD0 File Offset: 0x00982DD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027066 RID: 159846 RVA: 0x00984C44 File Offset: 0x00982E44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027067 RID: 159847 RVA: 0x00984CB8 File Offset: 0x00982EB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x00984D2C File Offset: 0x00982F2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06027069 RID: 159849 RVA: 0x00984DA0 File Offset: 0x00982FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Add_K2Node_InputKeyEvent_1(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_Add_K2Node_InputKeyEvent_1_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602706A RID: 159850 RVA: 0x00984E14 File Offset: 0x00983014
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void InpActEvt_Subtract_K2Node_InputKeyEvent_0(FKey Key)
		{
			NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_FunctionParams* ptr = stackalloc NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLive_Utilities_C.__InpActEvt_Subtract_K2Node_InputKeyEvent_0_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602706B RID: 159851 RVA: 0x00984E86 File Offset: 0x00983086
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, NinjaLive_Utilities_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602706C RID: 159852 RVA: 0x00984E9A File Offset: 0x0098309A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, NinjaLive_Utilities_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602706D RID: 159853 RVA: 0x00984EAF File Offset: 0x009830AF
		protected NinjaLive_Utilities_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A67 RID: 80487
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive_Utilities.NinjaLive_Utilities_C";

		// Token: 0x04013A68 RID: 80488
		private static IntPtr _ClassPtr;

		// Token: 0x04013A69 RID: 80489
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A6A RID: 80490
		internal static int __PropertyOffset_1;

		// Token: 0x04013A6B RID: 80491
		internal static int __PropertyOffset_2;

		// Token: 0x04013A6C RID: 80492
		internal static int __PropertyOffset_3;

		// Token: 0x04013A6D RID: 80493
		internal static int __PropertyOffset_4;

		// Token: 0x04013A6E RID: 80494
		internal static int __PropertyOffset_5;

		// Token: 0x04013A6F RID: 80495
		internal static int __PropertyOffset_6;

		// Token: 0x04013A70 RID: 80496
		internal static int __PropertyOffset_7;

		// Token: 0x04013A71 RID: 80497
		internal static int __PropertyOffset_8;

		// Token: 0x04013A72 RID: 80498
		internal static int __PropertyOffset_9;

		// Token: 0x04013A73 RID: 80499
		private TArray<int> _TempArray1;

		// Token: 0x04013A74 RID: 80500
		internal static int __PropertyOffset_10;

		// Token: 0x04013A75 RID: 80501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APawn> _TempArray2;

		// Token: 0x04013A76 RID: 80502
		internal static int __PropertyOffset_11;

		// Token: 0x04013A77 RID: 80503
		internal static int __PropertyOffset_12;

		// Token: 0x04013A78 RID: 80504
		internal static int __PropertyOffset_13;

		// Token: 0x04013A79 RID: 80505
		internal static int __PropertyOffset_14;

		// Token: 0x04013A7A RID: 80506
		internal static int __PropertyOffset_15;

		// Token: 0x04013A7B RID: 80507
		internal static int __PropertyOffset_16;

		// Token: 0x04013A7C RID: 80508
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013A7D RID: 80509
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_NativeFunctionPtr;

		// Token: 0x04013A7E RID: 80510
		private static IntPtr __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_NativeFunctionPtr;

		// Token: 0x04013A7F RID: 80511
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_NativeFunctionPtr;

		// Token: 0x04013A80 RID: 80512
		private static IntPtr __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_NativeFunctionPtr;

		// Token: 0x04013A81 RID: 80513
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_NativeFunctionPtr;

		// Token: 0x04013A82 RID: 80514
		private static IntPtr __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_NativeFunctionPtr;

		// Token: 0x04013A83 RID: 80515
		private static IntPtr __InpActEvt_Add_K2Node_InputKeyEvent_1_NativeFunctionPtr;

		// Token: 0x04013A84 RID: 80516
		private static IntPtr __InpActEvt_Subtract_K2Node_InputKeyEvent_0_NativeFunctionPtr;

		// Token: 0x04013A85 RID: 80517
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A181 RID: 41345
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_7_FunctionParams
		{
			// Token: 0x04031D64 RID: 204132
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A182 RID: 41346
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_LeftMouseButton_K2Node_InputKeyEvent_6_FunctionParams
		{
			// Token: 0x04031D65 RID: 204133
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A183 RID: 41347
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_5_FunctionParams
		{
			// Token: 0x04031D66 RID: 204134
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A184 RID: 41348
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_RightMouseButton_K2Node_InputKeyEvent_4_FunctionParams
		{
			// Token: 0x04031D67 RID: 204135
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A185 RID: 41349
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_3_FunctionParams
		{
			// Token: 0x04031D68 RID: 204136
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A186 RID: 41350
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_MiddleMouseButton_K2Node_InputKeyEvent_2_FunctionParams
		{
			// Token: 0x04031D69 RID: 204137
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A187 RID: 41351
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Add_K2Node_InputKeyEvent_1_FunctionParams
		{
			// Token: 0x04031D6A RID: 204138
			[FieldOffset(0)]
			public byte Key;
		}

		// Token: 0x0200A188 RID: 41352
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __InpActEvt_Subtract_K2Node_InputKeyEvent_0_FunctionParams
		{
			// Token: 0x04031D6B RID: 204139
			[FieldOffset(0)]
			public byte Key;
		}
	}
}
