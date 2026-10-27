using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.JadeMaterialEffect.BP
{
	// Token: 0x02003D07 RID: 15623
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_ChangeMaterial.BP_ChangeMaterial_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_ChangeMaterial_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060255C7 RID: 153031 RVA: 0x00957E21 File Offset: 0x00956021
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ChangeMaterial_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_ChangeMaterial.BP_ChangeMaterial_C");
			}
			return BP_ChangeMaterial_C._ClassPtr;
		}

		// Token: 0x060255C8 RID: 153032 RVA: 0x00957E48 File Offset: 0x00956048
		public BP_ChangeMaterial_C() : this(BuiltinUtils.AllocNativeUObject(BP_ChangeMaterial_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060255C9 RID: 153033 RVA: 0x00957E70 File Offset: 0x00956070
		[NullableContext(1)]
		public BP_ChangeMaterial_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ChangeMaterial_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C3B RID: 19515
		// (get) Token: 0x060255CA RID: 153034 RVA: 0x00957EA3 File Offset: 0x009560A3
		// (set) Token: 0x060255CB RID: 153035 RVA: 0x00957EB7 File Offset: 0x009560B7
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChangeMaterial_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ChangeMaterial_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060255CC RID: 153036 RVA: 0x00957ECC File Offset: 0x009560CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChangeMaterial_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060255CD RID: 153037 RVA: 0x00957EE0 File Offset: 0x009560E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChangeMaterial_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060255CE RID: 153038 RVA: 0x00957EF8 File Offset: 0x009560F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_ChangeMaterial_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ChangeMaterial_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChangeMaterial_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChangeMaterial_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChangeMaterial_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060255CF RID: 153039 RVA: 0x00957F40 File Offset: 0x00956140
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_ChangeMaterial_C.__EditorTick_FunctionParams* ptr = stackalloc BP_ChangeMaterial_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_ChangeMaterial_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ChangeMaterial_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChangeMaterial_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060255D0 RID: 153040 RVA: 0x00957F87 File Offset: 0x00956187
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ChangeMaterial_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060255D1 RID: 153041 RVA: 0x00957F9B File Offset: 0x0095619B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ChangeMaterial_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060255D2 RID: 153042 RVA: 0x00957FB0 File Offset: 0x009561B0
		protected BP_ChangeMaterial_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A1F RID: 76319
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_ChangeMaterial.BP_ChangeMaterial_C";

		// Token: 0x04012A20 RID: 76320
		private static IntPtr _ClassPtr;

		// Token: 0x04012A21 RID: 76321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A22 RID: 76322
		internal static int __PropertyOffset_1;

		// Token: 0x04012A23 RID: 76323
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012A24 RID: 76324
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012A25 RID: 76325
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009FEB RID: 40939
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031A86 RID: 203398
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
