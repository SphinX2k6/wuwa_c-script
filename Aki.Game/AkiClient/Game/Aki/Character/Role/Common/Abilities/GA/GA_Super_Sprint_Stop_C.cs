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
	// Token: 0x0200417D RID: 16765
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Stop.GA_Super_Sprint_Stop_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Super_Sprint_Stop_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B697 RID: 177815 RVA: 0x009FFE18 File Offset: 0x009FE018
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Stop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Stop.GA_Super_Sprint_Stop_C");
			}
			return GA_Super_Sprint_Stop_C._ClassPtr;
		}

		// Token: 0x0602B698 RID: 177816 RVA: 0x009FFE3C File Offset: 0x009FE03C
		public GA_Super_Sprint_Stop_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Stop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B699 RID: 177817 RVA: 0x009FFE64 File Offset: 0x009FE064
		[NullableContext(1)]
		public GA_Super_Sprint_Stop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Stop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B69A RID: 177818 RVA: 0x009FFE97 File Offset: 0x009FE097
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81F9A9D532()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__OnTick_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr, null);
		}

		// Token: 0x0602B69B RID: 177819 RVA: 0x009FFEAB File Offset: 0x009FE0AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81F9A9D532()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__OnCancelled_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr, null);
		}

		// Token: 0x0602B69C RID: 177820 RVA: 0x009FFEBF File Offset: 0x009FE0BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81F9A9D532()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__OnInterrupted_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr, null);
		}

		// Token: 0x0602B69D RID: 177821 RVA: 0x009FFED3 File Offset: 0x009FE0D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81F9A9D532()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__OnBlendOut_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr, null);
		}

		// Token: 0x0602B69E RID: 177822 RVA: 0x009FFEE7 File Offset: 0x009FE0E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81F9A9D532()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__OnCompleted_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr, null);
		}

		// Token: 0x0602B69F RID: 177823 RVA: 0x009FFEFB File Offset: 0x009FE0FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6A0 RID: 177824 RVA: 0x009FFF0F File Offset: 0x009FE10F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6A1 RID: 177825 RVA: 0x009FFF24 File Offset: 0x009FE124
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Stop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B6A2 RID: 177826 RVA: 0x009FFF6C File Offset: 0x009FE16C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Stop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Stop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Stop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B6A3 RID: 177827 RVA: 0x009FFFB3 File Offset: 0x009FE1B3
		protected GA_Super_Sprint_Stop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016974 RID: 92532
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Stop.GA_Super_Sprint_Stop_C";

		// Token: 0x04016975 RID: 92533
		private static IntPtr _ClassPtr;

		// Token: 0x04016976 RID: 92534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016977 RID: 92535
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr;

		// Token: 0x04016978 RID: 92536
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr;

		// Token: 0x04016979 RID: 92537
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr;

		// Token: 0x0401697A RID: 92538
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr;

		// Token: 0x0401697B RID: 92539
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81F9A9D532_NativeFunctionPtr;

		// Token: 0x0401697C RID: 92540
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0401697D RID: 92541
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A51F RID: 42271
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403238D RID: 205709
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
