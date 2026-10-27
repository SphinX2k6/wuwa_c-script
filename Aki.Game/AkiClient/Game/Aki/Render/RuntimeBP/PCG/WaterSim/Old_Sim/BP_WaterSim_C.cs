using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.Old_Sim
{
	// Token: 0x02003BD2 RID: 15314
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/Old_Sim/BP_WaterSim.BP_WaterSim_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1593)]
	public class BP_WaterSim_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225CE RID: 140750 RVA: 0x00906E8C File Offset: 0x0090508C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSim_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/Old_Sim/BP_WaterSim.BP_WaterSim_C");
			}
			return BP_WaterSim_C._ClassPtr;
		}

		// Token: 0x060225CF RID: 140751 RVA: 0x00906EB0 File Offset: 0x009050B0
		public BP_WaterSim_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSim_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225D0 RID: 140752 RVA: 0x00906ED8 File Offset: 0x009050D8
		[NullableContext(1)]
		public BP_WaterSim_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSim_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x060225D1 RID: 140753 RVA: 0x00906F0B File Offset: 0x0090510B
		// (set) Token: 0x060225D2 RID: 140754 RVA: 0x00906F1F File Offset: 0x0090511F
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x060225D3 RID: 140755 RVA: 0x00906F34 File Offset: 0x00905134
		// (set) Token: 0x060225D4 RID: 140756 RVA: 0x00906F48 File Offset: 0x00905148
		public unsafe UStaticMeshComponent SM_Plane512x512
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x060225D5 RID: 140757 RVA: 0x00906F5D File Offset: 0x0090515D
		// (set) Token: 0x060225D6 RID: 140758 RVA: 0x00906F71 File Offset: 0x00905171
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x060225D7 RID: 140759 RVA: 0x00906F86 File Offset: 0x00905186
		// (set) Token: 0x060225D8 RID: 140760 RVA: 0x00906F9A File Offset: 0x0090519A
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x060225D9 RID: 140761 RVA: 0x00906FAF File Offset: 0x009051AF
		// (set) Token: 0x060225DA RID: 140762 RVA: 0x00906FC3 File Offset: 0x009051C3
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x060225DB RID: 140763 RVA: 0x00906FD8 File Offset: 0x009051D8
		// (set) Token: 0x060225DC RID: 140764 RVA: 0x00906FE8 File Offset: 0x009051E8
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSim_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSim_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x060225DD RID: 140765 RVA: 0x00906FF9 File Offset: 0x009051F9
		// (set) Token: 0x060225DE RID: 140766 RVA: 0x0090700D File Offset: 0x0090520D
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x060225DF RID: 140767 RVA: 0x00907022 File Offset: 0x00905222
		// (set) Token: 0x060225E0 RID: 140768 RVA: 0x00907036 File Offset: 0x00905236
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x060225E1 RID: 140769 RVA: 0x0090704B File Offset: 0x0090524B
		// (set) Token: 0x060225E2 RID: 140770 RVA: 0x0090705F File Offset: 0x0090525F
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x060225E3 RID: 140771 RVA: 0x00907074 File Offset: 0x00905274
		// (set) Token: 0x060225E4 RID: 140772 RVA: 0x00907088 File Offset: 0x00905288
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x060225E5 RID: 140773 RVA: 0x0090709D File Offset: 0x0090529D
		// (set) Token: 0x060225E6 RID: 140774 RVA: 0x009070B1 File Offset: 0x009052B1
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x060225E7 RID: 140775 RVA: 0x009070C6 File Offset: 0x009052C6
		// (set) Token: 0x060225E8 RID: 140776 RVA: 0x009070DA File Offset: 0x009052DA
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x060225E9 RID: 140777 RVA: 0x009070EF File Offset: 0x009052EF
		// (set) Token: 0x060225EA RID: 140778 RVA: 0x00907103 File Offset: 0x00905303
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x060225EB RID: 140779 RVA: 0x00907118 File Offset: 0x00905318
		// (set) Token: 0x060225EC RID: 140780 RVA: 0x0090712C File Offset: 0x0090532C
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x060225ED RID: 140781 RVA: 0x00907141 File Offset: 0x00905341
		// (set) Token: 0x060225EE RID: 140782 RVA: 0x00907155 File Offset: 0x00905355
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x060225EF RID: 140783 RVA: 0x0090716A File Offset: 0x0090536A
		// (set) Token: 0x060225F0 RID: 140784 RVA: 0x0090717E File Offset: 0x0090537E
		public unsafe UTextureRenderTarget RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x060225F1 RID: 140785 RVA: 0x00907193 File Offset: 0x00905393
		// (set) Token: 0x060225F2 RID: 140786 RVA: 0x009071A7 File Offset: 0x009053A7
		public unsafe UTextureRenderTarget RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x060225F3 RID: 140787 RVA: 0x009071BC File Offset: 0x009053BC
		// (set) Token: 0x060225F4 RID: 140788 RVA: 0x009071D0 File Offset: 0x009053D0
		public unsafe UTextureRenderTarget RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSim_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x060225F5 RID: 140789 RVA: 0x009071E5 File Offset: 0x009053E5
		// (set) Token: 0x060225F6 RID: 140790 RVA: 0x009071F5 File Offset: 0x009053F5
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSim_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSim_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x060225F7 RID: 140791 RVA: 0x00907206 File Offset: 0x00905406
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSim_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x060225F8 RID: 140792 RVA: 0x0090721A File Offset: 0x0090541A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSim_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060225F9 RID: 140793 RVA: 0x0090722E File Offset: 0x0090542E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSim_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060225FA RID: 140794 RVA: 0x00907244 File Offset: 0x00905444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060225FB RID: 140795 RVA: 0x0090728C File Offset: 0x0090548C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSim_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSim_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSim_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSim_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060225FC RID: 140796 RVA: 0x009072D3 File Offset: 0x009054D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSim_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060225FD RID: 140797 RVA: 0x009072E7 File Offset: 0x009054E7
		protected BP_WaterSim_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DC8 RID: 69064
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/Old_Sim/BP_WaterSim.BP_WaterSim_C";

		// Token: 0x04010DC9 RID: 69065
		private static IntPtr _ClassPtr;

		// Token: 0x04010DCA RID: 69066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DCB RID: 69067
		internal static int __PropertyOffset_1;

		// Token: 0x04010DCC RID: 69068
		internal static int __PropertyOffset_2;

		// Token: 0x04010DCD RID: 69069
		internal static int __PropertyOffset_3;

		// Token: 0x04010DCE RID: 69070
		internal static int __PropertyOffset_4;

		// Token: 0x04010DCF RID: 69071
		internal static int __PropertyOffset_5;

		// Token: 0x04010DD0 RID: 69072
		internal static int __PropertyOffset_6;

		// Token: 0x04010DD1 RID: 69073
		internal static int __PropertyOffset_7;

		// Token: 0x04010DD2 RID: 69074
		internal static int __PropertyOffset_8;

		// Token: 0x04010DD3 RID: 69075
		internal static int __PropertyOffset_9;

		// Token: 0x04010DD4 RID: 69076
		internal static int __PropertyOffset_10;

		// Token: 0x04010DD5 RID: 69077
		internal static int __PropertyOffset_11;

		// Token: 0x04010DD6 RID: 69078
		internal static int __PropertyOffset_12;

		// Token: 0x04010DD7 RID: 69079
		internal static int __PropertyOffset_13;

		// Token: 0x04010DD8 RID: 69080
		internal static int __PropertyOffset_14;

		// Token: 0x04010DD9 RID: 69081
		internal static int __PropertyOffset_15;

		// Token: 0x04010DDA RID: 69082
		internal static int __PropertyOffset_16;

		// Token: 0x04010DDB RID: 69083
		internal static int __PropertyOffset_17;

		// Token: 0x04010DDC RID: 69084
		internal static int __PropertyOffset_18;

		// Token: 0x04010DDD RID: 69085
		internal static int __PropertyOffset_19;

		// Token: 0x04010DDE RID: 69086
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010DDF RID: 69087
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010DE0 RID: 69088
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010DE1 RID: 69089
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009D6F RID: 40303
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314ED RID: 201965
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
