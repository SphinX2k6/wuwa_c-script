using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Spindrift
{
	// Token: 0x02003BEE RID: 15342
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1546)]
	public class BP_FX_Sprindrigt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06022D8C RID: 142732 RVA: 0x00913DB0 File Offset: 0x00911FB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FX_Sprindrigt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C");
			}
			return BP_FX_Sprindrigt_C._ClassPtr;
		}

		// Token: 0x06022D8D RID: 142733 RVA: 0x00913DD4 File Offset: 0x00911FD4
		public BP_FX_Sprindrigt_C() : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrigt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D8E RID: 142734 RVA: 0x00913DFC File Offset: 0x00911FFC
		[NullableContext(1)]
		public BP_FX_Sprindrigt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrigt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x06022D8F RID: 142735 RVA: 0x00913E2F File Offset: 0x0091202F
		// (set) Token: 0x06022D90 RID: 142736 RVA: 0x00913E43 File Offset: 0x00912043
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x06022D91 RID: 142737 RVA: 0x00913E58 File Offset: 0x00912058
		// (set) Token: 0x06022D92 RID: 142738 RVA: 0x00913E6C File Offset: 0x0091206C
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x06022D93 RID: 142739 RVA: 0x00913E81 File Offset: 0x00912081
		// (set) Token: 0x06022D94 RID: 142740 RVA: 0x00913E95 File Offset: 0x00912095
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x06022D95 RID: 142741 RVA: 0x00913EAA File Offset: 0x009120AA
		// (set) Token: 0x06022D96 RID: 142742 RVA: 0x00913EBE File Offset: 0x009120BE
		public unsafe UNiagaraSystem 粒子特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x06022D97 RID: 142743 RVA: 0x00913ED3 File Offset: 0x009120D3
		// (set) Token: 0x06022D98 RID: 142744 RVA: 0x00913EE3 File Offset: 0x009120E3
		public unsafe int 全局时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x06022D99 RID: 142745 RVA: 0x00913EF4 File Offset: 0x009120F4
		// (set) Token: 0x06022D9A RID: 142746 RVA: 0x00913F04 File Offset: 0x00912104
		public unsafe int 浪花数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x06022D9B RID: 142747 RVA: 0x00913F15 File Offset: 0x00912115
		// (set) Token: 0x06022D9C RID: 142748 RVA: 0x00913F25 File Offset: 0x00912125
		public unsafe float 浪花范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x06022D9D RID: 142749 RVA: 0x00913F36 File Offset: 0x00912136
		// (set) Token: 0x06022D9E RID: 142750 RVA: 0x00913F4A File Offset: 0x0091214A
		public unsafe FLinearColor 浪花颜色_白天_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x06022D9F RID: 142751 RVA: 0x00913F5F File Offset: 0x0091215F
		// (set) Token: 0x06022DA0 RID: 142752 RVA: 0x00913F73 File Offset: 0x00912173
		public unsafe FLinearColor 浪花颜色_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x06022DA1 RID: 142753 RVA: 0x00913F88 File Offset: 0x00912188
		// (set) Token: 0x06022DA2 RID: 142754 RVA: 0x00913F98 File Offset: 0x00912198
		public unsafe float 浪花周期
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x06022DA3 RID: 142755 RVA: 0x00913FA9 File Offset: 0x009121A9
		// (set) Token: 0x06022DA4 RID: 142756 RVA: 0x00913FBD File Offset: 0x009121BD
		public unsafe FVector2D 周期偏移_白天_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x06022DA5 RID: 142757 RVA: 0x00913FD2 File Offset: 0x009121D2
		// (set) Token: 0x06022DA6 RID: 142758 RVA: 0x00913FE2 File Offset: 0x009121E2
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x06022DA7 RID: 142759 RVA: 0x00913FF3 File Offset: 0x009121F3
		// (set) Token: 0x06022DA8 RID: 142760 RVA: 0x00914003 File Offset: 0x00912203
		public unsafe bool IsDayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022DA9 RID: 142761 RVA: 0x00914014 File Offset: 0x00912214
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_FX_Sprindrigt_C.__GetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x06022DAA RID: 142762 RVA: 0x00914064 File Offset: 0x00912264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DayAndNight(bool IsDayTime)
		{
			BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__DayAndNight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDayTime = IsDayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__DayAndNight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022DAB RID: 142763 RVA: 0x009140AD File Offset: 0x009122AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022DAC RID: 142764 RVA: 0x009140C1 File Offset: 0x009122C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022DAD RID: 142765 RVA: 0x009140D8 File Offset: 0x009122D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_FX_Sprindrigt_C.__SetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022DAE RID: 142766 RVA: 0x0091411E File Offset: 0x0091231E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x06022DAF RID: 142767 RVA: 0x00914132 File Offset: 0x00912332
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022DB0 RID: 142768 RVA: 0x00914146 File Offset: 0x00912346
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022DB1 RID: 142769 RVA: 0x0091415C File Offset: 0x0091235C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022DB2 RID: 142770 RVA: 0x009141A4 File Offset: 0x009123A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022DB3 RID: 142771 RVA: 0x009141EC File Offset: 0x009123EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022DB4 RID: 142772 RVA: 0x00914234 File Offset: 0x00912434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022DB5 RID: 142773 RVA: 0x0091427B File Offset: 0x0091247B
		protected BP_FX_Sprindrigt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011253 RID: 70227
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C";

		// Token: 0x04011254 RID: 70228
		private static IntPtr _ClassPtr;

		// Token: 0x04011255 RID: 70229
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011256 RID: 70230
		internal static int __PropertyOffset_1;

		// Token: 0x04011257 RID: 70231
		internal static int __PropertyOffset_2;

		// Token: 0x04011258 RID: 70232
		internal static int __PropertyOffset_3;

		// Token: 0x04011259 RID: 70233
		internal static int __PropertyOffset_4;

		// Token: 0x0401125A RID: 70234
		internal static int __PropertyOffset_5;

		// Token: 0x0401125B RID: 70235
		internal static int __PropertyOffset_6;

		// Token: 0x0401125C RID: 70236
		internal static int __PropertyOffset_7;

		// Token: 0x0401125D RID: 70237
		internal static int __PropertyOffset_8;

		// Token: 0x0401125E RID: 70238
		internal static int __PropertyOffset_9;

		// Token: 0x0401125F RID: 70239
		internal static int __PropertyOffset_10;

		// Token: 0x04011260 RID: 70240
		internal static int __PropertyOffset_11;

		// Token: 0x04011261 RID: 70241
		internal static int __PropertyOffset_12;

		// Token: 0x04011262 RID: 70242
		internal static int __PropertyOffset_13;

		// Token: 0x04011263 RID: 70243
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x04011264 RID: 70244
		private static IntPtr __DayAndNight_NativeFunctionPtr;

		// Token: 0x04011265 RID: 70245
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011266 RID: 70246
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x04011267 RID: 70247
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x04011268 RID: 70248
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011269 RID: 70249
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401126A RID: 70250
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009DE0 RID: 40416
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x040315E3 RID: 202211
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02009DE1 RID: 40417
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DayAndNight_FunctionParams
		{
			// Token: 0x040315E4 RID: 202212
			[FieldOffset(0)]
			public bool IsDayTime;
		}

		// Token: 0x02009DE2 RID: 40418
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x040315E5 RID: 202213
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02009DE3 RID: 40419
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315E6 RID: 202214
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DE4 RID: 40420
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040315E7 RID: 202215
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
