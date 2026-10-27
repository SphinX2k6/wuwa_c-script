using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B89 RID: 15241
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add10Sec.BP_DollItem_Add10Sec_C")]
	[UnrealStructLayout(1736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1736)]
	public class BP_DollItem_Add10Sec_C : BP_DollActor_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021EA2 RID: 138914 RVA: 0x008F966E File Offset: 0x008F786E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItem_Add10Sec_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add10Sec.BP_DollItem_Add10Sec_C");
			}
			return BP_DollItem_Add10Sec_C._ClassPtr;
		}

		// Token: 0x06021EA3 RID: 138915 RVA: 0x008F9694 File Offset: 0x008F7894
		public BP_DollItem_Add10Sec_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_Add10Sec_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021EA4 RID: 138916 RVA: 0x008F96BC File Offset: 0x008F78BC
		[NullableContext(1)]
		public BP_DollItem_Add10Sec_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItem_Add10Sec_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x06021EA5 RID: 138917 RVA: 0x008F96EF File Offset: 0x008F78EF
		// (set) Token: 0x06021EA6 RID: 138918 RVA: 0x008F9703 File Offset: 0x008F7903
		[Nullable(2)]
		public unsafe UChildActorComponent BP_EffectActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_Add10Sec_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItem_Add10Sec_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x06021EA7 RID: 138919 RVA: 0x008F9718 File Offset: 0x008F7918
		// (set) Token: 0x06021EA8 RID: 138920 RVA: 0x008F972D File Offset: 0x008F792D
		[Nullable(1)]
		public TSoftObjectPtr<EffectModelGroup> TimeGrabEffect
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<EffectModelGroup>(base.NativePtr + (IntPtr)BP_DollItem_Add10Sec_C.__PropertyOffset_2, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_DollItem_Add10Sec_C.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021EA9 RID: 138921 RVA: 0x008F9754 File Offset: 0x008F7954
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TogglePlayEffect(bool Enable)
		{
			BP_DollItem_Add10Sec_C.__TogglePlayEffect_FunctionParams* ptr = stackalloc BP_DollItem_Add10Sec_C.__TogglePlayEffect_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_DollItem_Add10Sec_C.__TogglePlayEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_Add10Sec_C.__TogglePlayEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add10Sec_C.__TogglePlayEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021EAA RID: 138922 RVA: 0x008F979A File Offset: 0x008F799A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add10Sec_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021EAB RID: 138923 RVA: 0x008F97AE File Offset: 0x008F79AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DollItem_Add10Sec_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021EAC RID: 138924 RVA: 0x008F97C4 File Offset: 0x008F79C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void SetVisible(bool ToggleVisibility, bool TogglePhysics)
		{
			BP_DollItem_Add10Sec_C.__SetVisible_FunctionParams* ptr = stackalloc BP_DollItem_Add10Sec_C.__SetVisible_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_DollItem_Add10Sec_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DollItem_Add10Sec_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ToggleVisibility = ToggleVisibility;
			ptr->TogglePhysics = TogglePhysics;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add10Sec_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021EAD RID: 138925 RVA: 0x008F9811 File Offset: 0x008F7A11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void PlayTimeEffect()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItem_Add10Sec_C.__PlayTimeEffect_NativeFunctionPtr, null);
		}

		// Token: 0x06021EAE RID: 138926 RVA: 0x008F9825 File Offset: 0x008F7A25
		protected BP_DollItem_Add10Sec_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010941 RID: 67905
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItem_Add10Sec.BP_DollItem_Add10Sec_C";

		// Token: 0x04010942 RID: 67906
		private static IntPtr _ClassPtr;

		// Token: 0x04010943 RID: 67907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010944 RID: 67908
		internal new static int __PropertyOffset_1;

		// Token: 0x04010945 RID: 67909
		internal new static int __PropertyOffset_2;

		// Token: 0x04010946 RID: 67910
		private static IntPtr __TogglePlayEffect_NativeFunctionPtr;

		// Token: 0x04010947 RID: 67911
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010948 RID: 67912
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x04010949 RID: 67913
		private static IntPtr __PlayTimeEffect_NativeFunctionPtr;

		// Token: 0x02009CF0 RID: 40176
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __TogglePlayEffect_FunctionParams
		{
			// Token: 0x040313EF RID: 201711
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02009CF1 RID: 40177
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected new ref struct __SetVisible_FunctionParams
		{
			// Token: 0x040313F0 RID: 201712
			[FieldOffset(0)]
			public bool ToggleVisibility;

			// Token: 0x040313F1 RID: 201713
			[FieldOffset(1)]
			public bool TogglePhysics;
		}
	}
}
