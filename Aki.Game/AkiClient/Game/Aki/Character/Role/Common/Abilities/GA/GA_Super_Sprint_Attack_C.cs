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
	// Token: 0x0200416D RID: 16749
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Attack.GA_Super_Sprint_Attack_C")]
	[UnrealStructLayout(1528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1521)]
	public class GA_Super_Sprint_Attack_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B522 RID: 177442 RVA: 0x009FCD8D File Offset: 0x009FAF8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Attack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Attack.GA_Super_Sprint_Attack_C");
			}
			return GA_Super_Sprint_Attack_C._ClassPtr;
		}

		// Token: 0x0602B523 RID: 177443 RVA: 0x009FCDB4 File Offset: 0x009FAFB4
		public GA_Super_Sprint_Attack_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Attack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B524 RID: 177444 RVA: 0x009FCDDC File Offset: 0x009FAFDC
		[NullableContext(1)]
		public GA_Super_Sprint_Attack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Attack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006ADD RID: 27357
		// (get) Token: 0x0602B525 RID: 177445 RVA: 0x009FCE0F File Offset: 0x009FB00F
		// (set) Token: 0x0602B526 RID: 177446 RVA: 0x009FCE1F File Offset: 0x009FB01F
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ADE RID: 27358
		// (get) Token: 0x0602B527 RID: 177447 RVA: 0x009FCE30 File Offset: 0x009FB030
		// (set) Token: 0x0602B528 RID: 177448 RVA: 0x009FCE40 File Offset: 0x009FB040
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ADF RID: 27359
		// (get) Token: 0x0602B529 RID: 177449 RVA: 0x009FCE51 File Offset: 0x009FB051
		// (set) Token: 0x0602B52A RID: 177450 RVA: 0x009FCE61 File Offset: 0x009FB061
		public unsafe float Block_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006AE0 RID: 27360
		// (get) Token: 0x0602B52B RID: 177451 RVA: 0x009FCE72 File Offset: 0x009FB072
		// (set) Token: 0x0602B52C RID: 177452 RVA: 0x009FCE82 File Offset: 0x009FB082
		public unsafe bool 是否结束技能
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Attack_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602B52D RID: 177453 RVA: 0x009FCE94 File Offset: 0x009FB094
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A38029BF44(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A38029BF44_FunctionParams* ptr = stackalloc GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A38029BF44_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A38029BF44_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A38029BF44_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A38029BF44_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B52E RID: 177454 RVA: 0x009FCEE0 File Offset: 0x009FB0E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A39046F616(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A39046F616_FunctionParams* ptr = stackalloc GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A39046F616_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A39046F616_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A39046F616_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A39046F616_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B52F RID: 177455 RVA: 0x009FCF2C File Offset: 0x009FB12C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3E8E5B10F(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A3E8E5B10F_FunctionParams* ptr = stackalloc GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A3E8E5B10F_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A3E8E5B10F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A3E8E5B10F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__Added_21071CB943CD992BF8EFD6A3E8E5B10F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B530 RID: 177456 RVA: 0x009FCF77 File Offset: 0x009FB177
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E812A9F4E59()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__OnTick_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr, null);
		}

		// Token: 0x0602B531 RID: 177457 RVA: 0x009FCF8B File Offset: 0x009FB18B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E812A9F4E59()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__OnCancelled_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr, null);
		}

		// Token: 0x0602B532 RID: 177458 RVA: 0x009FCF9F File Offset: 0x009FB19F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E812A9F4E59()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__OnInterrupted_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr, null);
		}

		// Token: 0x0602B533 RID: 177459 RVA: 0x009FCFB3 File Offset: 0x009FB1B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E812A9F4E59()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__OnBlendOut_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr, null);
		}

		// Token: 0x0602B534 RID: 177460 RVA: 0x009FCFC7 File Offset: 0x009FB1C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E812A9F4E59()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__OnCompleted_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr, null);
		}

		// Token: 0x0602B535 RID: 177461 RVA: 0x009FCFDB File Offset: 0x009FB1DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B536 RID: 177462 RVA: 0x009FCFEF File Offset: 0x009FB1EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B537 RID: 177463 RVA: 0x009FD004 File Offset: 0x009FB204
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Attack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B538 RID: 177464 RVA: 0x009FD04C File Offset: 0x009FB24C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Attack_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Attack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Attack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B539 RID: 177465 RVA: 0x009FD093 File Offset: 0x009FB293
		protected GA_Super_Sprint_Attack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016866 RID: 92262
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Attack.GA_Super_Sprint_Attack_C";

		// Token: 0x04016867 RID: 92263
		private static IntPtr _ClassPtr;

		// Token: 0x04016868 RID: 92264
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016869 RID: 92265
		internal new static int __PropertyOffset_1;

		// Token: 0x0401686A RID: 92266
		internal new static int __PropertyOffset_2;

		// Token: 0x0401686B RID: 92267
		internal new static int __PropertyOffset_3;

		// Token: 0x0401686C RID: 92268
		internal static int __PropertyOffset_4;

		// Token: 0x0401686D RID: 92269
		private static IntPtr __Added_21071CB943CD992BF8EFD6A38029BF44_NativeFunctionPtr;

		// Token: 0x0401686E RID: 92270
		private static IntPtr __Added_21071CB943CD992BF8EFD6A39046F616_NativeFunctionPtr;

		// Token: 0x0401686F RID: 92271
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3E8E5B10F_NativeFunctionPtr;

		// Token: 0x04016870 RID: 92272
		private static IntPtr __OnTick_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr;

		// Token: 0x04016871 RID: 92273
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr;

		// Token: 0x04016872 RID: 92274
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr;

		// Token: 0x04016873 RID: 92275
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr;

		// Token: 0x04016874 RID: 92276
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E812A9F4E59_NativeFunctionPtr;

		// Token: 0x04016875 RID: 92277
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016876 RID: 92278
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4DD RID: 42205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A38029BF44_FunctionParams
		{
			// Token: 0x0403234B RID: 205643
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4DE RID: 42206
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A39046F616_FunctionParams
		{
			// Token: 0x0403234C RID: 205644
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4DF RID: 42207
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3E8E5B10F_FunctionParams
		{
			// Token: 0x0403234D RID: 205645
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E0 RID: 42208
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403234E RID: 205646
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
