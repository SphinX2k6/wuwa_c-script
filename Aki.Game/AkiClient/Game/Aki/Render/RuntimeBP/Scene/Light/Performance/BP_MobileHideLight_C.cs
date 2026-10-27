using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light.Performance
{
	// Token: 0x02003B32 RID: 15154
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_MobileHideLight.BP_MobileHideLight_C")]
	[UnrealStructLayout(1464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1464)]
	public class BP_MobileHideLight_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060217C4 RID: 137156 RVA: 0x008ED96B File Offset: 0x008EBB6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MobileHideLight_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_MobileHideLight.BP_MobileHideLight_C");
			}
			return BP_MobileHideLight_C._ClassPtr;
		}

		// Token: 0x060217C5 RID: 137157 RVA: 0x008ED990 File Offset: 0x008EBB90
		public BP_MobileHideLight_C() : this(BuiltinUtils.AllocNativeUObject(BP_MobileHideLight_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060217C6 RID: 137158 RVA: 0x008ED9B8 File Offset: 0x008EBBB8
		[NullableContext(1)]
		public BP_MobileHideLight_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MobileHideLight_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x060217C7 RID: 137159 RVA: 0x008ED9EB File Offset: 0x008EBBEB
		// (set) Token: 0x060217C8 RID: 137160 RVA: 0x008ED9FF File Offset: 0x008EBBFF
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MobileHideLight_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MobileHideLight_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060217C9 RID: 137161 RVA: 0x008EDA14 File Offset: 0x008EBC14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MobileHideLight_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060217CA RID: 137162 RVA: 0x008EDA28 File Offset: 0x008EBC28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MobileHideLight_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060217CB RID: 137163 RVA: 0x008EDA40 File Offset: 0x008EBC40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MobileHideLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MobileHideLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MobileHideLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileHideLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MobileHideLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060217CC RID: 137164 RVA: 0x008EDA88 File Offset: 0x008EBC88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MobileHideLight_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MobileHideLight_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MobileHideLight_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileHideLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MobileHideLight_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060217CD RID: 137165 RVA: 0x008EDAD0 File Offset: 0x008EBCD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MobileHideLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MobileHideLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MobileHideLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileHideLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MobileHideLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060217CE RID: 137166 RVA: 0x008EDB18 File Offset: 0x008EBD18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MobileHideLight_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MobileHideLight_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MobileHideLight_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MobileHideLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MobileHideLight_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060217CF RID: 137167 RVA: 0x008EDB5F File Offset: 0x008EBD5F
		protected BP_MobileHideLight_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401050B RID: 66827
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/Performance/BP_MobileHideLight.BP_MobileHideLight_C";

		// Token: 0x0401050C RID: 66828
		private static IntPtr _ClassPtr;

		// Token: 0x0401050D RID: 66829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401050E RID: 66830
		internal static int __PropertyOffset_1;

		// Token: 0x0401050F RID: 66831
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010510 RID: 66832
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010511 RID: 66833
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C97 RID: 40087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031355 RID: 201557
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C98 RID: 40088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031356 RID: 201558
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
