using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E1 RID: 13025
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C")]
	[UnrealStructLayout(2416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2416)]
	public class BP_CharacterController_C : __TsCharacterController_InheritProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021128 RID: 135464 RVA: 0x009584E3 File Offset: 0x009566E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CharacterController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C");
			}
			return BP_CharacterController_C._ClassPtr;
		}

		// Token: 0x06021129 RID: 135465 RVA: 0x00958508 File Offset: 0x00956708
		public BP_CharacterController_C() : this(BuiltinUtils.AllocNativeUObject(BP_CharacterController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602112A RID: 135466 RVA: 0x00958530 File Offset: 0x00956730
		[NullableContext(1)]
		public BP_CharacterController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CharacterController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0602112B RID: 135467 RVA: 0x00958563 File Offset: 0x00956763
		// (set) Token: 0x0602112C RID: 135468 RVA: 0x00958577 File Offset: 0x00956777
		public unsafe TsBaseCharacter 当前操作角色
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_当前操作角色);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_当前操作角色, value);
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0602112D RID: 135469 RVA: 0x0095858C File Offset: 0x0095678C
		// (set) Token: 0x0602112E RID: 135470 RVA: 0x0095859C File Offset: 0x0095679C
		public unsafe bool GmIsOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CharacterController_C.__PropertyOffset_GmIsOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CharacterController_C.__PropertyOffset_GmIsOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0602112F RID: 135471 RVA: 0x009585AD File Offset: 0x009567AD
		// (set) Token: 0x06021130 RID: 135472 RVA: 0x009585C1 File Offset: 0x009567C1
		public unsafe BP_KuroCheatManager_C KuroCheatManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_KuroCheatManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_KuroCheatManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CharacterController_C.__PropertyOffset_KuroCheatManager, value);
			}
		}

		// Token: 0x06021131 RID: 135473 RVA: 0x009585D8 File Offset: 0x009567D8
		[SkipLocalsInit]
		public unsafe override void ReceiveUnPossess(APawn UnpossessedPawn)
		{
			BP_CharacterController_C.__ReceiveUnPossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceiveUnPossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceiveUnPossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UnpossessedPawn = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021132 RID: 135474 RVA: 0x00958630 File Offset: 0x00956830
		[SkipLocalsInit]
		protected unsafe override void ReceiveUnPossess_Implementation(APawn UnpossessedPawn)
		{
			BP_CharacterController_C.__ReceiveUnPossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceiveUnPossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceiveUnPossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->UnpossessedPawn = ((UnpossessedPawn != null) ? UnpossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveUnPossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021133 RID: 135475 RVA: 0x00958688 File Offset: 0x00956888
		[SkipLocalsInit]
		public unsafe override void ReceivePossess(APawn PossessedPawn)
		{
			BP_CharacterController_C.__ReceivePossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceivePossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceivePossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PossessedPawn = ((PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021134 RID: 135476 RVA: 0x009586E0 File Offset: 0x009568E0
		[SkipLocalsInit]
		protected unsafe override void ReceivePossess_Implementation(APawn PossessedPawn)
		{
			BP_CharacterController_C.__ReceivePossess_FunctionParams* ptr = stackalloc BP_CharacterController_C.__ReceivePossess_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CharacterController_C.__ReceivePossess_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PossessedPawn = ((PossessedPawn != null) ? PossessedPawn.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceivePossess_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021135 RID: 135477 RVA: 0x00958735 File Offset: 0x00956935
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021136 RID: 135478 RVA: 0x00958749 File Offset: 0x00956949
		[SkipLocalsInit]
		protected override void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CharacterController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021137 RID: 135479 RVA: 0x00958760 File Offset: 0x00956960
		[SkipLocalsInit]
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

		// Token: 0x06021138 RID: 135480 RVA: 0x009587D4 File Offset: 0x009569D4
		[SkipLocalsInit]
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

		// Token: 0x06021139 RID: 135481 RVA: 0x00958846 File Offset: 0x00956A46
		protected BP_CharacterController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F14 RID: 73492
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_CharacterController.BP_CharacterController_C";

		// Token: 0x04011F15 RID: 73493
		private static IntPtr _ClassPtr;

		// Token: 0x04011F16 RID: 73494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F17 RID: 73495
		internal static int __PropertyOffset_当前操作角色;

		// Token: 0x04011F18 RID: 73496
		internal static int __PropertyOffset_GmIsOpen;

		// Token: 0x04011F19 RID: 73497
		internal static int __PropertyOffset_KuroCheatManager;

		// Token: 0x04011F1A RID: 73498
		private static IntPtr __ReceiveUnPossess_NativeFunctionPtr;

		// Token: 0x04011F1B RID: 73499
		private static IntPtr __ReceivePossess_NativeFunctionPtr;

		// Token: 0x04011F1C RID: 73500
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011F1D RID: 73501
		private static IntPtr __OnPressAnyKey_NativeFunctionPtr;

		// Token: 0x04011F1E RID: 73502
		private static IntPtr __OnReleaseAnyKey_NativeFunctionPtr;

		// Token: 0x0200907F RID: 36991
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveUnPossess_FunctionParams
		{
			// Token: 0x0402CE92 RID: 183954
			[FieldOffset(0)]
			public IntPtr UnpossessedPawn;
		}

		// Token: 0x02009080 RID: 36992
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceivePossess_FunctionParams
		{
			// Token: 0x0402CE93 RID: 183955
			[FieldOffset(0)]
			public IntPtr PossessedPawn;
		}

		// Token: 0x02009081 RID: 36993
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __OnPressAnyKey_FunctionParams
		{
			// Token: 0x0402CE94 RID: 183956
			[FieldOffset(0)]
			public byte key;
		}

		// Token: 0x02009082 RID: 36994
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected new ref struct __OnReleaseAnyKey_FunctionParams
		{
			// Token: 0x0402CE95 RID: 183957
			[FieldOffset(0)]
			public byte key;
		}
	}
}
