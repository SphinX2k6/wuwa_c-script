using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200427A RID: 17018
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C")]
	[UnrealStructLayout(2376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2376)]
	public class BP_CharacterController_C : __TsCharacterController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602C29E RID: 180894 RVA: 0x00A189AF File Offset: 0x00A16BAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C");
			}
			return BP_CharacterController_C._ClassPtr;
		}

		// Token: 0x0602C29F RID: 180895 RVA: 0x00A189D4 File Offset: 0x00A16BD4
		public BP_CharacterController_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602C2A0 RID: 180896 RVA: 0x00A189FC File Offset: 0x00A16BFC
		[NullableContext(1)]
		public BP_CharacterController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DEA RID: 28138
		// (get) Token: 0x0602C2A1 RID: 180897 RVA: 0x00A18A2F File Offset: 0x00A16C2F
		// (set) Token: 0x0602C2A2 RID: 180898 RVA: 0x00A18A43 File Offset: 0x00A16C43
		public unsafe TsBaseCharacter 当前操作角色
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x0602C2A3 RID: 180899 RVA: 0x00A18A58 File Offset: 0x00A16C58
		// (set) Token: 0x0602C2A4 RID: 180900 RVA: 0x00A18A68 File Offset: 0x00A16C68
		public unsafe bool GmIsOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterController_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterController_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x0602C2A5 RID: 180901 RVA: 0x00A18A79 File Offset: 0x00A16C79
		// (set) Token: 0x0602C2A6 RID: 180902 RVA: 0x00A18A8D File Offset: 0x00A16C8D
		public unsafe BP_KuroCheatManager_C KuroCheatManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroCheatManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602C2A7 RID: 180903 RVA: 0x00A18AA4 File Offset: 0x00A16CA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveUnPossess(APawn UnpossessedPawn)
		{
			BP_CharacterController_C.__ReceiveUnPossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceiveUnPossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceiveUnPossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UnpossessedPawn = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C2A8 RID: 180904 RVA: 0x00A18AFC File Offset: 0x00A16CFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceiveUnPossess_Implementation(APawn UnpossessedPawn)
		{
			BP_CharacterController_C.__ReceiveUnPossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceiveUnPossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceiveUnPossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UnpossessedPawn = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C2A9 RID: 180905 RVA: 0x00A18B54 File Offset: 0x00A16D54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceivePossess(APawn PossessedPawn)
		{
			BP_CharacterController_C.__ReceivePossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceivePossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceivePossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PossessedPawn = ((PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602C2AA RID: 180906 RVA: 0x00A18BAC File Offset: 0x00A16DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void ReceivePossess_Implementation(APawn PossessedPawn)
		{
			BP_CharacterController_C.__ReceivePossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceivePossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceivePossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PossessedPawn = ((PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602C2AB RID: 180907 RVA: 0x00A18C02 File Offset: 0x00A16E02
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602C2AC RID: 180908 RVA: 0x00A18C16 File Offset: 0x00A16E16
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602C2AD RID: 180909 RVA: 0x00A18C2C File Offset: 0x00A16E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnPressAnyKey(FKey key)
		{
			BP_CharacterController_C.__OnPressAnyKey_FunctionParams* ptr = stackalloc BP_CharacterController_C.__OnPressAnyKey_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterController_C.__OnPressAnyKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__OnPressAnyKey_NativeFunctionPtr, (void*)ptr, 1);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__OnPressAnyKey_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CharacterController_C.__OnPressAnyKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C2AE RID: 180910 RVA: 0x00A18CA0 File Offset: 0x00A16EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnReleaseAnyKey(FKey key)
		{
			BP_CharacterController_C.__OnReleaseAnyKey_FunctionParams* ptr = stackalloc BP_CharacterController_C.__OnReleaseAnyKey_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_CharacterController_C.__OnReleaseAnyKey_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__OnReleaseAnyKey_NativeFunctionPtr, (void*)ptr, 1);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__OnReleaseAnyKey_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_CharacterController_C.__OnReleaseAnyKey_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602C2AF RID: 180911 RVA: 0x00A18D12 File Offset: 0x00A16F12
		protected BP_CharacterController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040171BE RID: 94654
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C";

		// Token: 0x040171BF RID: 94655
		private static IntPtr _ClassPtr;

		// Token: 0x040171C0 RID: 94656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040171C1 RID: 94657
		internal static int __PropertyOffset_1;

		// Token: 0x040171C2 RID: 94658
		internal static int __PropertyOffset_2;

		// Token: 0x040171C3 RID: 94659
		internal static int __PropertyOffset_3;

		// Token: 0x040171C4 RID: 94660
		private static IntPtr __ReceiveUnPossess_NativeFunctionPtr;

		// Token: 0x040171C5 RID: 94661
		private static IntPtr __ReceivePossess_NativeFunctionPtr;

		// Token: 0x040171C6 RID: 94662
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040171C7 RID: 94663
		private static IntPtr __OnPressAnyKey_NativeFunctionPtr;

		// Token: 0x040171C8 RID: 94664
		private static IntPtr __OnReleaseAnyKey_NativeFunctionPtr;

		// Token: 0x0200A665 RID: 42597
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveUnPossess_FunctionParams
		{
			// Token: 0x0403259F RID: 206239
			[FieldOffset(0)]
			public IntPtr UnpossessedPawn;
		}

		// Token: 0x0200A666 RID: 42598
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceivePossess_FunctionParams
		{
			// Token: 0x040325A0 RID: 206240
			[FieldOffset(0)]
			public IntPtr PossessedPawn;
		}

		// Token: 0x0200A667 RID: 42599
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __OnPressAnyKey_FunctionParams
		{
			// Token: 0x040325A1 RID: 206241
			[FieldOffset(0)]
			public byte key;
		}

		// Token: 0x0200A668 RID: 42600
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __OnReleaseAnyKey_FunctionParams
		{
			// Token: 0x040325A2 RID: 206242
			[FieldOffset(0)]
			public byte key;
		}
	}
}
