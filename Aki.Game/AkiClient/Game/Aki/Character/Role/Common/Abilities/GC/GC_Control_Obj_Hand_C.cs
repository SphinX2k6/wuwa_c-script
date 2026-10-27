using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Effect.BluePrint.BP_FX_Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GC
{
	// Token: 0x0200411E RID: 16670
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GC/GC_Control_Obj_Hand.GC_Control_Obj_Hand_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1228)]
	public class GC_Control_Obj_Hand_C : AGameplayCueNotify_Actor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AEF0 RID: 175856 RVA: 0x009F0300 File Offset: 0x009EE500
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GC_Control_Obj_Hand_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GC/GC_Control_Obj_Hand.GC_Control_Obj_Hand_C");
			}
			return GC_Control_Obj_Hand_C._ClassPtr;
		}

		// Token: 0x0602AEF1 RID: 175857 RVA: 0x009F0324 File Offset: 0x009EE524
		public GC_Control_Obj_Hand_C() : this(BuiltinUtils.AllocNativeUObject(GC_Control_Obj_Hand_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AEF2 RID: 175858 RVA: 0x009F034C File Offset: 0x009EE54C
		[NullableContext(1)]
		public GC_Control_Obj_Hand_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GC_Control_Obj_Hand_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069C3 RID: 27075
		// (get) Token: 0x0602AEF3 RID: 175859 RVA: 0x009F037F File Offset: 0x009EE57F
		// (set) Token: 0x0602AEF4 RID: 175860 RVA: 0x009F0393 File Offset: 0x009EE593
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170069C4 RID: 27076
		// (get) Token: 0x0602AEF5 RID: 175861 RVA: 0x009F03A8 File Offset: 0x009EE5A8
		// (set) Token: 0x0602AEF6 RID: 175862 RVA: 0x009F03BC File Offset: 0x009EE5BC
		public unsafe EffectModelGroup 手部特效DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectModelGroup>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170069C5 RID: 27077
		// (get) Token: 0x0602AEF7 RID: 175863 RVA: 0x009F03D1 File Offset: 0x009EE5D1
		// (set) Token: 0x0602AEF8 RID: 175864 RVA: 0x009F03E5 File Offset: 0x009EE5E5
		public unsafe TsBaseCharacter As_Ts_Base_Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170069C6 RID: 27078
		// (get) Token: 0x0602AEF9 RID: 175865 RVA: 0x009F03FA File Offset: 0x009EE5FA
		// (set) Token: 0x0602AEFA RID: 175866 RVA: 0x009F040E File Offset: 0x009EE60E
		public unsafe BP_Fx_Control_Obj_C 连线特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Fx_Control_Obj_C>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170069C7 RID: 27079
		// (get) Token: 0x0602AEFB RID: 175867 RVA: 0x009F0423 File Offset: 0x009EE623
		// (set) Token: 0x0602AEFC RID: 175868 RVA: 0x009F0437 File Offset: 0x009EE637
		public unsafe AActor Effect_Causer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170069C8 RID: 27080
		// (get) Token: 0x0602AEFD RID: 175869 RVA: 0x009F044C File Offset: 0x009EE64C
		// (set) Token: 0x0602AEFE RID: 175870 RVA: 0x009F0460 File Offset: 0x009EE660
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<BP_Fx_Control_Obj_C> 连线特效BP
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)GC_Control_Obj_Hand_C.__PropertyOffset_6);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)GC_Control_Obj_Hand_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170069C9 RID: 27081
		// (get) Token: 0x0602AEFF RID: 175871 RVA: 0x009F0475 File Offset: 0x009EE675
		// (set) Token: 0x0602AF00 RID: 175872 RVA: 0x009F0489 File Offset: 0x009EE689
		public unsafe EffectModelGroup 物体控制中特效DA
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectModelGroup>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170069CA RID: 27082
		// (get) Token: 0x0602AF01 RID: 175873 RVA: 0x009F049E File Offset: 0x009EE69E
		// (set) Token: 0x0602AF02 RID: 175874 RVA: 0x009F04B2 File Offset: 0x009EE6B2
		public unsafe EffectViewComponent 物体控制中特效handle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<EffectViewComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GC_Control_Obj_Hand_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170069CB RID: 27083
		// (get) Token: 0x0602AF03 RID: 175875 RVA: 0x009F04C7 File Offset: 0x009EE6C7
		// (set) Token: 0x0602AF04 RID: 175876 RVA: 0x009F04D7 File Offset: 0x009EE6D7
		public unsafe int 手部特效句柄
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GC_Control_Obj_Hand_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GC_Control_Obj_Hand_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x0602AF05 RID: 175877 RVA: 0x009F04E8 File Offset: 0x009EE6E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成手特效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__生成手特效_NativeFunctionPtr, null);
		}

		// Token: 0x0602AF06 RID: 175878 RVA: 0x009F04FC File Offset: 0x009EE6FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool OnRemove(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			GC_Control_Obj_Hand_C.__OnRemove_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__OnRemove_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__OnRemove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MyTarget = ((MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero);
			if (Parameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), &ptr->Parameters, Parameters.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602AF07 RID: 175879 RVA: 0x009F0590 File Offset: 0x009EE790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool OnRemove_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			GC_Control_Obj_Hand_C.__OnRemove_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__OnRemove_FunctionParams[(UIntPtr)223] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__OnRemove_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MyTarget = ((MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero);
			if (Parameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), &ptr->Parameters, Parameters.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GC_Control_Obj_Hand_C.__OnRemove_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602AF08 RID: 175880 RVA: 0x009F0624 File Offset: 0x009EE824
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool OnActive(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			GC_Control_Obj_Hand_C.__OnActive_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__OnActive_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__OnActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MyTarget = ((MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero);
			if (Parameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), &ptr->Parameters, Parameters.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602AF09 RID: 175881 RVA: 0x009F06B8 File Offset: 0x009EE8B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool OnActive_Implementation(AActor MyTarget, in FGameplayCueParameters Parameters)
		{
			GC_Control_Obj_Hand_C.__OnActive_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__OnActive_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__OnActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MyTarget = ((MyTarget != null) ? MyTarget.NativePtr : IntPtr.Zero);
			if (Parameters != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), &ptr->Parameters, Parameters.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GC_Control_Obj_Hand_C.__OnActive_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602AF0A RID: 175882 RVA: 0x009F074C File Offset: 0x009EE94C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF0B RID: 175883 RVA: 0x009F0794 File Offset: 0x009EE994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams* ptr = stackalloc GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(GC_Control_Obj_Hand_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GC_Control_Obj_Hand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GC_Control_Obj_Hand_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AF0C RID: 175884 RVA: 0x009F07DB File Offset: 0x009EE9DB
		protected GC_Control_Obj_Hand_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016419 RID: 91161
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GC/GC_Control_Obj_Hand.GC_Control_Obj_Hand_C";

		// Token: 0x0401641A RID: 91162
		private static IntPtr _ClassPtr;

		// Token: 0x0401641B RID: 91163
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401641C RID: 91164
		internal static int __PropertyOffset_1;

		// Token: 0x0401641D RID: 91165
		internal static int __PropertyOffset_2;

		// Token: 0x0401641E RID: 91166
		internal static int __PropertyOffset_3;

		// Token: 0x0401641F RID: 91167
		internal static int __PropertyOffset_4;

		// Token: 0x04016420 RID: 91168
		internal static int __PropertyOffset_5;

		// Token: 0x04016421 RID: 91169
		internal static int __PropertyOffset_6;

		// Token: 0x04016422 RID: 91170
		internal static int __PropertyOffset_7;

		// Token: 0x04016423 RID: 91171
		internal static int __PropertyOffset_8;

		// Token: 0x04016424 RID: 91172
		internal static int __PropertyOffset_9;

		// Token: 0x04016425 RID: 91173
		private static IntPtr __生成手特效_NativeFunctionPtr;

		// Token: 0x04016426 RID: 91174
		private static IntPtr __OnRemove_NativeFunctionPtr;

		// Token: 0x04016427 RID: 91175
		private static IntPtr __OnActive_NativeFunctionPtr;

		// Token: 0x04016428 RID: 91176
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A435 RID: 42037
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 208)]
		protected new ref struct __OnRemove_FunctionParams
		{
			// Token: 0x04032270 RID: 205424
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x04032271 RID: 205425
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x04032272 RID: 205426
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x0200A436 RID: 42038
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 512)]
		protected new ref struct __OnActive_FunctionParams
		{
			// Token: 0x04032273 RID: 205427
			[FieldOffset(0)]
			public IntPtr MyTarget;

			// Token: 0x04032274 RID: 205428
			[FieldOffset(8)]
			public byte Parameters;

			// Token: 0x04032275 RID: 205429
			[FieldOffset(200)]
			public bool __Result;
		}

		// Token: 0x0200A437 RID: 42039
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032276 RID: 205430
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
