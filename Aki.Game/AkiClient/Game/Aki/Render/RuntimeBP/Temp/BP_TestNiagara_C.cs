using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Temp
{
	// Token: 0x02003ABC RID: 15036
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Temp/BP_TestNiagara.BP_TestNiagara_C")]
	[UnrealStructLayout(1096, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1096)]
	public class BP_TestNiagara_C : AKuroEffectActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020429 RID: 132137 RVA: 0x008CE06D File Offset: 0x008CC26D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TestNiagara_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Temp/BP_TestNiagara.BP_TestNiagara_C");
			}
			return BP_TestNiagara_C._ClassPtr;
		}

		// Token: 0x0602042A RID: 132138 RVA: 0x008CE094 File Offset: 0x008CC294
		public BP_TestNiagara_C() : this(BuiltinUtils.AllocNativeUObject(BP_TestNiagara_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602042B RID: 132139 RVA: 0x008CE0BC File Offset: 0x008CC2BC
		[NullableContext(1)]
		public BP_TestNiagara_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TestNiagara_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0602042C RID: 132140 RVA: 0x008CE0EF File Offset: 0x008CC2EF
		// (set) Token: 0x0602042D RID: 132141 RVA: 0x008CE103 File Offset: 0x008CC303
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0602042E RID: 132142 RVA: 0x008CE118 File Offset: 0x008CC318
		// (set) Token: 0x0602042F RID: 132143 RVA: 0x008CE12C File Offset: 0x008CC32C
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06020430 RID: 132144 RVA: 0x008CE141 File Offset: 0x008CC341
		// (set) Token: 0x06020431 RID: 132145 RVA: 0x008CE155 File Offset: 0x008CC355
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TestNiagara_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06020432 RID: 132146 RVA: 0x008CE16A File Offset: 0x008CC36A
		// (set) Token: 0x06020433 RID: 132147 RVA: 0x008CE17A File Offset: 0x008CC37A
		public unsafe float TriggerInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestNiagara_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestNiagara_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06020434 RID: 132148 RVA: 0x008CE18B File Offset: 0x008CC38B
		// (set) Token: 0x06020435 RID: 132149 RVA: 0x008CE19B File Offset: 0x008CC39B
		public unsafe float Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_TestNiagara_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_TestNiagara_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x06020436 RID: 132150 RVA: 0x008CE1AC File Offset: 0x008CC3AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestNiagara_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020437 RID: 132151 RVA: 0x008CE1C0 File Offset: 0x008CC3C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TestNiagara_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020438 RID: 132152 RVA: 0x008CE1D8 File Offset: 0x008CC3D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_TestNiagara_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TestNiagara_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestNiagara_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020439 RID: 132153 RVA: 0x008CE220 File Offset: 0x008CC420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_TestNiagara_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_TestNiagara_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestNiagara_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TestNiagara_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602043A RID: 132154 RVA: 0x008CE268 File Offset: 0x008CC468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_TestNiagara_C.__EditorTick_FunctionParams* ptr = stackalloc BP_TestNiagara_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestNiagara_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestNiagara_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TestNiagara_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602043B RID: 132155 RVA: 0x008CE2B0 File Offset: 0x008CC4B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_TestNiagara_C.__EditorTick_FunctionParams* ptr = stackalloc BP_TestNiagara_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_TestNiagara_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_TestNiagara_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_TestNiagara_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602043C RID: 132156 RVA: 0x008CE2F7 File Offset: 0x008CC4F7
		protected BP_TestNiagara_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F999 RID: 63897
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Temp/BP_TestNiagara.BP_TestNiagara_C";

		// Token: 0x0400F99A RID: 63898
		private static IntPtr _ClassPtr;

		// Token: 0x0400F99B RID: 63899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F99C RID: 63900
		internal static int __PropertyOffset_1;

		// Token: 0x0400F99D RID: 63901
		internal static int __PropertyOffset_2;

		// Token: 0x0400F99E RID: 63902
		internal static int __PropertyOffset_3;

		// Token: 0x0400F99F RID: 63903
		internal static int __PropertyOffset_4;

		// Token: 0x0400F9A0 RID: 63904
		internal static int __PropertyOffset_5;

		// Token: 0x0400F9A1 RID: 63905
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F9A2 RID: 63906
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F9A3 RID: 63907
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009B9A RID: 39834
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311EE RID: 201198
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B9B RID: 39835
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040311EF RID: 201199
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
