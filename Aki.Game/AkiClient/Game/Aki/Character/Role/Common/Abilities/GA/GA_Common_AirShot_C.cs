using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004127 RID: 16679
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AirShot.GA_Common_AirShot_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1516)]
	public class GA_Common_AirShot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AF98 RID: 176024 RVA: 0x009F1C70 File Offset: 0x009EFE70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Common_AirShot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AirShot.GA_Common_AirShot_C");
			}
			return GA_Common_AirShot_C._ClassPtr;
		}

		// Token: 0x0602AF99 RID: 176025 RVA: 0x009F1C94 File Offset: 0x009EFE94
		public GA_Common_AirShot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Common_AirShot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AF9A RID: 176026 RVA: 0x009F1CBC File Offset: 0x009EFEBC
		[NullableContext(1)]
		public GA_Common_AirShot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Common_AirShot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069E3 RID: 27107
		// (get) Token: 0x0602AF9B RID: 176027 RVA: 0x009F1CEF File Offset: 0x009EFEEF
		// (set) Token: 0x0602AF9C RID: 176028 RVA: 0x009F1CFF File Offset: 0x009EFEFF
		public unsafe int 层数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Common_AirShot_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Common_AirShot_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602AF9D RID: 176029 RVA: 0x009F1D10 File Offset: 0x009EFF10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_672DF730488FF3847426B2B0B4DDBA8C(in FGameplayTag Tag)
		{
			GA_Common_AirShot_C.__Removed_672DF730488FF3847426B2B0B4DDBA8C_FunctionParams* ptr = stackalloc GA_Common_AirShot_C.__Removed_672DF730488FF3847426B2B0B4DDBA8C_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Common_AirShot_C.__Removed_672DF730488FF3847426B2B0B4DDBA8C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AirShot_C.__Removed_672DF730488FF3847426B2B0B4DDBA8C_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AirShot_C.__Removed_672DF730488FF3847426B2B0B4DDBA8C_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF9E RID: 176030 RVA: 0x009F1D5C File Offset: 0x009EFF5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_8BFB30E14403CD30B6735ABFFDD5C4B2(in FGameplayTag Tag)
		{
			GA_Common_AirShot_C.__Added_8BFB30E14403CD30B6735ABFFDD5C4B2_FunctionParams* ptr = stackalloc GA_Common_AirShot_C.__Added_8BFB30E14403CD30B6735ABFFDD5C4B2_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Common_AirShot_C.__Added_8BFB30E14403CD30B6735ABFFDD5C4B2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AirShot_C.__Added_8BFB30E14403CD30B6735ABFFDD5C4B2_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AirShot_C.__Added_8BFB30E14403CD30B6735ABFFDD5C4B2_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AF9F RID: 176031 RVA: 0x009F1DA8 File Offset: 0x009EFFA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_FFBD6C384BB1FB51A97536A87C7A0267(in FGameplayTag Tag)
		{
			GA_Common_AirShot_C.__Added_FFBD6C384BB1FB51A97536A87C7A0267_FunctionParams* ptr = stackalloc GA_Common_AirShot_C.__Added_FFBD6C384BB1FB51A97536A87C7A0267_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Common_AirShot_C.__Added_FFBD6C384BB1FB51A97536A87C7A0267_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AirShot_C.__Added_FFBD6C384BB1FB51A97536A87C7A0267_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AirShot_C.__Added_FFBD6C384BB1FB51A97536A87C7A0267_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFA0 RID: 176032 RVA: 0x009F1DF4 File Offset: 0x009EFFF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AirShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AirShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFA1 RID: 176033 RVA: 0x009F1E3C File Offset: 0x009F003C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Common_AirShot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Common_AirShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_AirShot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AFA2 RID: 176034 RVA: 0x009F1E83 File Offset: 0x009F0083
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Common_AirShot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFA3 RID: 176035 RVA: 0x009F1E97 File Offset: 0x009F0097
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Common_AirShot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFA4 RID: 176036 RVA: 0x009F1EAC File Offset: 0x009F00AC
		protected GA_Common_AirShot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016489 RID: 91273
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Common_AirShot.GA_Common_AirShot_C";

		// Token: 0x0401648A RID: 91274
		private static IntPtr _ClassPtr;

		// Token: 0x0401648B RID: 91275
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401648C RID: 91276
		internal new static int __PropertyOffset_1;

		// Token: 0x0401648D RID: 91277
		private static IntPtr __Removed_672DF730488FF3847426B2B0B4DDBA8C_NativeFunctionPtr;

		// Token: 0x0401648E RID: 91278
		private static IntPtr __Added_8BFB30E14403CD30B6735ABFFDD5C4B2_NativeFunctionPtr;

		// Token: 0x0401648F RID: 91279
		private static IntPtr __Added_FFBD6C384BB1FB51A97536A87C7A0267_NativeFunctionPtr;

		// Token: 0x04016490 RID: 91280
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016491 RID: 91281
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A452 RID: 42066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_672DF730488FF3847426B2B0B4DDBA8C_FunctionParams
		{
			// Token: 0x04032291 RID: 205457
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A453 RID: 42067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_8BFB30E14403CD30B6735ABFFDD5C4B2_FunctionParams
		{
			// Token: 0x04032292 RID: 205458
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A454 RID: 42068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_FFBD6C384BB1FB51A97536A87C7A0267_FunctionParams
		{
			// Token: 0x04032293 RID: 205459
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A455 RID: 42069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032294 RID: 205460
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
