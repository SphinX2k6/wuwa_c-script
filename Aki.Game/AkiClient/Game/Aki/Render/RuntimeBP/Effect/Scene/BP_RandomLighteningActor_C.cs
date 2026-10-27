using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene
{
	// Token: 0x02003DCB RID: 15819
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_RandomLighteningActor.BP_RandomLighteningActor_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1517)]
	public class BP_RandomLighteningActor_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027693 RID: 161427 RVA: 0x009905D0 File Offset: 0x0098E7D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_RandomLighteningActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_RandomLighteningActor.BP_RandomLighteningActor_C");
			}
			return BP_RandomLighteningActor_C._ClassPtr;
		}

		// Token: 0x06027694 RID: 161428 RVA: 0x009905F4 File Offset: 0x0098E7F4
		public BP_RandomLighteningActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_RandomLighteningActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027695 RID: 161429 RVA: 0x0099061C File Offset: 0x0098E81C
		[NullableContext(1)]
		public BP_RandomLighteningActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_RandomLighteningActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x06027696 RID: 161430 RVA: 0x0099064F File Offset: 0x0098E84F
		// (set) Token: 0x06027697 RID: 161431 RVA: 0x00990663 File Offset: 0x0098E863
		public unsafe USpotLightComponent SpotLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpotLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x06027698 RID: 161432 RVA: 0x00990678 File Offset: 0x0098E878
		// (set) Token: 0x06027699 RID: 161433 RVA: 0x0099068C File Offset: 0x0098E88C
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x0602769A RID: 161434 RVA: 0x009906A1 File Offset: 0x0098E8A1
		// (set) Token: 0x0602769B RID: 161435 RVA: 0x009906B5 File Offset: 0x0098E8B5
		public unsafe UPointLightComponent PointLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x0602769C RID: 161436 RVA: 0x009906CA File Offset: 0x0098E8CA
		// (set) Token: 0x0602769D RID: 161437 RVA: 0x009906DE File Offset: 0x0098E8DE
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x0602769E RID: 161438 RVA: 0x009906F3 File Offset: 0x0098E8F3
		// (set) Token: 0x0602769F RID: 161439 RVA: 0x00990703 File Offset: 0x0098E903
		public unsafe float Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x060276A0 RID: 161440 RVA: 0x00990714 File Offset: 0x0098E914
		// (set) Token: 0x060276A1 RID: 161441 RVA: 0x00990724 File Offset: 0x0098E924
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x060276A2 RID: 161442 RVA: 0x00990735 File Offset: 0x0098E935
		// (set) Token: 0x060276A3 RID: 161443 RVA: 0x00990745 File Offset: 0x0098E945
		public unsafe float Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17005807 RID: 22535
		// (get) Token: 0x060276A4 RID: 161444 RVA: 0x00990756 File Offset: 0x0098E956
		// (set) Token: 0x060276A5 RID: 161445 RVA: 0x0099076A File Offset: 0x0098E96A
		public unsafe PDA_RandomLightening_C 配置
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_RandomLightening_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_RandomLighteningActor_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17005808 RID: 22536
		// (get) Token: 0x060276A6 RID: 161446 RVA: 0x0099077F File Offset: 0x0098E97F
		// (set) Token: 0x060276A7 RID: 161447 RVA: 0x0099078F File Offset: 0x0098E98F
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17005809 RID: 22537
		// (get) Token: 0x060276A8 RID: 161448 RVA: 0x009907A0 File Offset: 0x0098E9A0
		// (set) Token: 0x060276A9 RID: 161449 RVA: 0x009907B0 File Offset: 0x0098E9B0
		public unsafe bool bDisableSpotLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_RandomLighteningActor_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x060276AA RID: 161450 RVA: 0x009907C1 File Offset: 0x0098E9C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Spawn()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomLighteningActor_C.__Spawn_NativeFunctionPtr, null);
		}

		// Token: 0x060276AB RID: 161451 RVA: 0x009907D5 File Offset: 0x0098E9D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomLighteningActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060276AC RID: 161452 RVA: 0x009907E9 File Offset: 0x0098E9E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomLighteningActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060276AD RID: 161453 RVA: 0x00990800 File Offset: 0x0098EA00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomLighteningActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomLighteningActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060276AE RID: 161454 RVA: 0x00990848 File Offset: 0x0098EA48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomLighteningActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomLighteningActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomLighteningActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060276AF RID: 161455 RVA: 0x00990890 File Offset: 0x0098EA90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_RandomLighteningActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_RandomLighteningActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomLighteningActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomLighteningActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_RandomLighteningActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060276B0 RID: 161456 RVA: 0x009908D8 File Offset: 0x0098EAD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_RandomLighteningActor_C.__EditorTick_FunctionParams* ptr = stackalloc BP_RandomLighteningActor_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_RandomLighteningActor_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_RandomLighteningActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_RandomLighteningActor_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060276B1 RID: 161457 RVA: 0x0099091F File Offset: 0x0098EB1F
		protected BP_RandomLighteningActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E5A RID: 81498
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/Scene/BP_RandomLighteningActor.BP_RandomLighteningActor_C";

		// Token: 0x04013E5B RID: 81499
		private static IntPtr _ClassPtr;

		// Token: 0x04013E5C RID: 81500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E5D RID: 81501
		internal static int __PropertyOffset_1;

		// Token: 0x04013E5E RID: 81502
		internal static int __PropertyOffset_2;

		// Token: 0x04013E5F RID: 81503
		internal static int __PropertyOffset_3;

		// Token: 0x04013E60 RID: 81504
		internal static int __PropertyOffset_4;

		// Token: 0x04013E61 RID: 81505
		internal static int __PropertyOffset_5;

		// Token: 0x04013E62 RID: 81506
		internal static int __PropertyOffset_6;

		// Token: 0x04013E63 RID: 81507
		internal static int __PropertyOffset_7;

		// Token: 0x04013E64 RID: 81508
		internal static int __PropertyOffset_8;

		// Token: 0x04013E65 RID: 81509
		internal static int __PropertyOffset_9;

		// Token: 0x04013E66 RID: 81510
		internal static int __PropertyOffset_10;

		// Token: 0x04013E67 RID: 81511
		private static IntPtr __Spawn_NativeFunctionPtr;

		// Token: 0x04013E68 RID: 81512
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013E69 RID: 81513
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013E6A RID: 81514
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A223 RID: 41507
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E8D RID: 204429
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A224 RID: 41508
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031E8E RID: 204430
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
