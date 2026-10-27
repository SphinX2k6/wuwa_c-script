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
	// Token: 0x0200416E RID: 16750
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End.GA_Super_Sprint_End_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Super_Sprint_End_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B53A RID: 177466 RVA: 0x009FD09C File Offset: 0x009FB29C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_End_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End.GA_Super_Sprint_End_C");
			}
			return GA_Super_Sprint_End_C._ClassPtr;
		}

		// Token: 0x0602B53B RID: 177467 RVA: 0x009FD0C0 File Offset: 0x009FB2C0
		public GA_Super_Sprint_End_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_End_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B53C RID: 177468 RVA: 0x009FD0E8 File Offset: 0x009FB2E8
		[NullableContext(1)]
		public GA_Super_Sprint_End_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_End_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602B53D RID: 177469 RVA: 0x009FD11B File Offset: 0x009FB31B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81E600A766()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__OnTick_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr, null);
		}

		// Token: 0x0602B53E RID: 177470 RVA: 0x009FD12F File Offset: 0x009FB32F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81E600A766()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__OnCancelled_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr, null);
		}

		// Token: 0x0602B53F RID: 177471 RVA: 0x009FD143 File Offset: 0x009FB343
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81E600A766()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__OnInterrupted_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr, null);
		}

		// Token: 0x0602B540 RID: 177472 RVA: 0x009FD157 File Offset: 0x009FB357
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81E600A766()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__OnBlendOut_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr, null);
		}

		// Token: 0x0602B541 RID: 177473 RVA: 0x009FD16B File Offset: 0x009FB36B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81E600A766()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__OnCompleted_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr, null);
		}

		// Token: 0x0602B542 RID: 177474 RVA: 0x009FD17F File Offset: 0x009FB37F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B543 RID: 177475 RVA: 0x009FD193 File Offset: 0x009FB393
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_End_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B544 RID: 177476 RVA: 0x009FD1A8 File Offset: 0x009FB3A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B545 RID: 177477 RVA: 0x009FD1F0 File Offset: 0x009FB3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B546 RID: 177478 RVA: 0x009FD237 File Offset: 0x009FB437
		protected GA_Super_Sprint_End_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016877 RID: 92279
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_End.GA_Super_Sprint_End_C";

		// Token: 0x04016878 RID: 92280
		private static IntPtr _ClassPtr;

		// Token: 0x04016879 RID: 92281
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401687A RID: 92282
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr;

		// Token: 0x0401687B RID: 92283
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr;

		// Token: 0x0401687C RID: 92284
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr;

		// Token: 0x0401687D RID: 92285
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr;

		// Token: 0x0401687E RID: 92286
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81E600A766_NativeFunctionPtr;

		// Token: 0x0401687F RID: 92287
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016880 RID: 92288
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4E1 RID: 42209
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403234F RID: 205647
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
