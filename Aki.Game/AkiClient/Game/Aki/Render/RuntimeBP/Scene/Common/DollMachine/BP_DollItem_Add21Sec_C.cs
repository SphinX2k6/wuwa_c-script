using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B8A RID: 15242
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add21Sec.BP_DollItem_Add21Sec_C")]
	[UnrealStructLayout(1736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1736)]
	public class BP_DollItem_Add21Sec_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EAF RID: 138927 RVA: 0x008F982E File Offset: 0x008F7A2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_Add21Sec_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add21Sec.BP_DollItem_Add21Sec_C");
			}
			return BP_DollItem_Add21Sec_C._ClassPtr;
		}

		// Token: 0x06021EB0 RID: 138928 RVA: 0x008F9854 File Offset: 0x008F7A54
		public BP_DollItem_Add21Sec_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_Add21Sec_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EB1 RID: 138929 RVA: 0x008F987C File Offset: 0x008F7A7C
		[NullableContext(1)]
		public BP_DollItem_Add21Sec_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_Add21Sec_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x06021EB2 RID: 138930 RVA: 0x008F98AF File Offset: 0x008F7AAF
		// (set) Token: 0x06021EB3 RID: 138931 RVA: 0x008F98C3 File Offset: 0x008F7AC3
		[Nullable(2)]
		public unsafe UChildActorComponent BP_EffectActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_Add21Sec_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_Add21Sec_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x06021EB4 RID: 138932 RVA: 0x008F98D8 File Offset: 0x008F7AD8
		// (set) Token: 0x06021EB5 RID: 138933 RVA: 0x008F98ED File Offset: 0x008F7AED
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> TimeGrabEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollItem_Add21Sec_C.__PropertyOffset_2, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollItem_Add21Sec_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021EB6 RID: 138934 RVA: 0x008F9914 File Offset: 0x008F7B14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TogglePlayEffect(bool Enable)
		{
			BP_DollItem_Add21Sec_C.__TogglePlayEffect_FunctionParams* ptr = stackalloc BP_DollItem_Add21Sec_C.__TogglePlayEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollItem_Add21Sec_C.__TogglePlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_Add21Sec_C.__TogglePlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add21Sec_C.__TogglePlayEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021EB7 RID: 138935 RVA: 0x008F995A File Offset: 0x008F7B5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add21Sec_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021EB8 RID: 138936 RVA: 0x008F996E File Offset: 0x008F7B6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_Add21Sec_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021EB9 RID: 138937 RVA: 0x008F9984 File Offset: 0x008F7B84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			BP_DollItem_Add21Sec_C.__SetVisible_FunctionParams* ptr = stackalloc BP_DollItem_Add21Sec_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DollItem_Add21Sec_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_Add21Sec_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add21Sec_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021EBA RID: 138938 RVA: 0x008F99D1 File Offset: 0x008F7BD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add21Sec_C.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021EBB RID: 138939 RVA: 0x008F99E5 File Offset: 0x008F7BE5
		protected BP_DollItem_Add21Sec_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401094A RID: 67914
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add21Sec.BP_DollItem_Add21Sec_C";

		// Token: 0x0401094B RID: 67915
		private static IntPtr _ClassPtr;

		// Token: 0x0401094C RID: 67916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401094D RID: 67917
		internal new static int __PropertyOffset_1;

		// Token: 0x0401094E RID: 67918
		internal new static int __PropertyOffset_2;

		// Token: 0x0401094F RID: 67919
		private static IntPtr __TogglePlayEffect_NativeFunctionPtr;

		// Token: 0x04010950 RID: 67920
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010951 RID: 67921
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x04010952 RID: 67922
		private static IntPtr __PlayTimeEffect_NativeFunctionPtr;

		// Token: 0x02009CF2 RID: 40178
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TogglePlayEffect_FunctionParams
		{
			// Token: 0x040313F2 RID: 201714
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02009CF3 RID: 40179
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected new ref struct __SetVisible_FunctionParams
		{
			// Token: 0x040313F3 RID: 201715
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x040313F4 RID: 201716
			[FieldOffset(1)]
			public bool TogglePhysics;
		}
	}
}
