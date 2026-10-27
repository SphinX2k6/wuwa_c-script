using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.BlueprintLevel
{
	// Token: 0x02003BA5 RID: 15269
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneSequenceEffect.BP_SceneSequenceEffect_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1528)]
	public class BP_SceneSequenceEffect_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022030 RID: 139312 RVA: 0x008FCA00 File Offset: 0x008FAC00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SceneSequenceEffect_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneSequenceEffect.BP_SceneSequenceEffect_C");
			}
			return BP_SceneSequenceEffect_C._ClassPtr;
		}

		// Token: 0x06022031 RID: 139313 RVA: 0x008FCA24 File Offset: 0x008FAC24
		public BP_SceneSequenceEffect_C() : this(BuiltinUtils.AllocNativeUObject(BP_SceneSequenceEffect_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022032 RID: 139314 RVA: 0x008FCA4C File Offset: 0x008FAC4C
		[NullableContext(1)]
		public BP_SceneSequenceEffect_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SceneSequenceEffect_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x06022033 RID: 139315 RVA: 0x008FCA7F File Offset: 0x008FAC7F
		// (set) Token: 0x06022034 RID: 139316 RVA: 0x008FCA93 File Offset: 0x008FAC93
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x06022035 RID: 139317 RVA: 0x008FCAA8 File Offset: 0x008FACA8
		// (set) Token: 0x06022036 RID: 139318 RVA: 0x008FCAB8 File Offset: 0x008FACB8
		public unsafe float DissolveProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SceneSequenceEffect_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SceneSequenceEffect_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x06022037 RID: 139319 RVA: 0x008FCAC9 File Offset: 0x008FACC9
		// (set) Token: 0x06022038 RID: 139320 RVA: 0x008FCADD File Offset: 0x008FACDD
		public unsafe AActor DissolveActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x06022039 RID: 139321 RVA: 0x008FCAF2 File Offset: 0x008FACF2
		// (set) Token: 0x0602203A RID: 139322 RVA: 0x008FCB06 File Offset: 0x008FAD06
		public unsafe AActor DissolveActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0602203B RID: 139323 RVA: 0x008FCB1B File Offset: 0x008FAD1B
		// (set) Token: 0x0602203C RID: 139324 RVA: 0x008FCB2F File Offset: 0x008FAD2F
		public unsafe AActor DissolveActor3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0602203D RID: 139325 RVA: 0x008FCB44 File Offset: 0x008FAD44
		// (set) Token: 0x0602203E RID: 139326 RVA: 0x008FCB58 File Offset: 0x008FAD58
		public unsafe AActor DissolveActor4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0602203F RID: 139327 RVA: 0x008FCB6D File Offset: 0x008FAD6D
		// (set) Token: 0x06022040 RID: 139328 RVA: 0x008FCB81 File Offset: 0x008FAD81
		public unsafe AActor DissolveActor5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x06022041 RID: 139329 RVA: 0x008FCB96 File Offset: 0x008FAD96
		// (set) Token: 0x06022042 RID: 139330 RVA: 0x008FCBAA File Offset: 0x008FADAA
		public unsafe AActor DissolveActor6
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x06022043 RID: 139331 RVA: 0x008FCBBF File Offset: 0x008FADBF
		// (set) Token: 0x06022044 RID: 139332 RVA: 0x008FCBD3 File Offset: 0x008FADD3
		public unsafe AActor DissolveActor7
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SceneSequenceEffect_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x06022045 RID: 139333 RVA: 0x008FCBE8 File Offset: 0x008FADE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateSM(AActor SM, float Dissolve)
		{
			BP_SceneSequenceEffect_C.__UpdateSM_FunctionParams* ptr = stackalloc BP_SceneSequenceEffect_C.__UpdateSM_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_SceneSequenceEffect_C.__UpdateSM_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneSequenceEffect_C.__UpdateSM_NativeFunctionPtr, (void*)ptr, 1);
			ptr->SM = ((SM != null) ? SM.NativePtr : IntPtr.Zero);
			ptr->Dissolve = Dissolve;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__UpdateSM_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022046 RID: 139334 RVA: 0x008FCC44 File Offset: 0x008FAE44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDissolveProcess()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__UpdateDissolveProcess_NativeFunctionPtr, null);
		}

		// Token: 0x06022047 RID: 139335 RVA: 0x008FCC58 File Offset: 0x008FAE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022048 RID: 139336 RVA: 0x008FCC6C File Offset: 0x008FAE6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022049 RID: 139337 RVA: 0x008FCC84 File Offset: 0x008FAE84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneSequenceEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602204A RID: 139338 RVA: 0x008FCCCC File Offset: 0x008FAECC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneSequenceEffect_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneSequenceEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602204B RID: 139339 RVA: 0x008FCD14 File Offset: 0x008FAF14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SceneSequenceEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneSequenceEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneSequenceEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneSequenceEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602204C RID: 139340 RVA: 0x008FCD5C File Offset: 0x008FAF5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SceneSequenceEffect_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SceneSequenceEffect_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SceneSequenceEffect_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SceneSequenceEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602204D RID: 139341 RVA: 0x008FCDA3 File Offset: 0x008FAFA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602204E RID: 139342 RVA: 0x008FCDB7 File Offset: 0x008FAFB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SceneSequenceEffect_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602204F RID: 139343 RVA: 0x008FCDCC File Offset: 0x008FAFCC
		protected BP_SceneSequenceEffect_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A48 RID: 68168
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/BlueprintLevel/BP_SceneSequenceEffect.BP_SceneSequenceEffect_C";

		// Token: 0x04010A49 RID: 68169
		private static IntPtr _ClassPtr;

		// Token: 0x04010A4A RID: 68170
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A4B RID: 68171
		internal static int __PropertyOffset_1;

		// Token: 0x04010A4C RID: 68172
		internal static int __PropertyOffset_2;

		// Token: 0x04010A4D RID: 68173
		internal static int __PropertyOffset_3;

		// Token: 0x04010A4E RID: 68174
		internal static int __PropertyOffset_4;

		// Token: 0x04010A4F RID: 68175
		internal static int __PropertyOffset_5;

		// Token: 0x04010A50 RID: 68176
		internal static int __PropertyOffset_6;

		// Token: 0x04010A51 RID: 68177
		internal static int __PropertyOffset_7;

		// Token: 0x04010A52 RID: 68178
		internal static int __PropertyOffset_8;

		// Token: 0x04010A53 RID: 68179
		internal static int __PropertyOffset_9;

		// Token: 0x04010A54 RID: 68180
		private static IntPtr __UpdateSM_NativeFunctionPtr;

		// Token: 0x04010A55 RID: 68181
		private static IntPtr __UpdateDissolveProcess_NativeFunctionPtr;

		// Token: 0x04010A56 RID: 68182
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010A57 RID: 68183
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010A58 RID: 68184
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010A59 RID: 68185
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009D11 RID: 40209
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __UpdateSM_FunctionParams
		{
			// Token: 0x04031436 RID: 201782
			[FieldOffset(0)]
			public IntPtr SM;

			// Token: 0x04031437 RID: 201783
			[FieldOffset(8)]
			public float Dissolve;
		}

		// Token: 0x02009D12 RID: 40210
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031438 RID: 201784
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D13 RID: 40211
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031439 RID: 201785
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
