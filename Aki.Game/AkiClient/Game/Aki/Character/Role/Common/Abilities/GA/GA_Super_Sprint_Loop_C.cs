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
	// Token: 0x02004171 RID: 16753
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop.GA_Super_Sprint_Loop_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Super_Sprint_Loop_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B568 RID: 177512 RVA: 0x009FD6B0 File Offset: 0x009FB8B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Super_Sprint_Loop_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop.GA_Super_Sprint_Loop_C");
			}
			return GA_Super_Sprint_Loop_C._ClassPtr;
		}

		// Token: 0x0602B569 RID: 177513 RVA: 0x009FD6D4 File Offset: 0x009FB8D4
		public GA_Super_Sprint_Loop_C() : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Loop_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B56A RID: 177514 RVA: 0x009FD6FC File Offset: 0x009FB8FC
		[NullableContext(1)]
		public GA_Super_Sprint_Loop_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Super_Sprint_Loop_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AE3 RID: 27363
		// (get) Token: 0x0602B56B RID: 177515 RVA: 0x009FD72F File Offset: 0x009FB92F
		// (set) Token: 0x0602B56C RID: 177516 RVA: 0x009FD73F File Offset: 0x009FB93F
		public unsafe bool 是否被打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AE4 RID: 27364
		// (get) Token: 0x0602B56D RID: 177517 RVA: 0x009FD750 File Offset: 0x009FB950
		// (set) Token: 0x0602B56E RID: 177518 RVA: 0x009FD760 File Offset: 0x009FB960
		public unsafe bool 是否空中打断
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006AE5 RID: 27365
		// (get) Token: 0x0602B56F RID: 177519 RVA: 0x009FD771 File Offset: 0x009FB971
		// (set) Token: 0x0602B570 RID: 177520 RVA: 0x009FD781 File Offset: 0x009FB981
		public unsafe float Block_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Super_Sprint_Loop_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602B571 RID: 177521 RVA: 0x009FD792 File Offset: 0x009FB992
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81A76D2917()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__OnTick_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr, null);
		}

		// Token: 0x0602B572 RID: 177522 RVA: 0x009FD7A6 File Offset: 0x009FB9A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81A76D2917()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__OnCancelled_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr, null);
		}

		// Token: 0x0602B573 RID: 177523 RVA: 0x009FD7BA File Offset: 0x009FB9BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81A76D2917()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__OnInterrupted_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr, null);
		}

		// Token: 0x0602B574 RID: 177524 RVA: 0x009FD7CE File Offset: 0x009FB9CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81A76D2917()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__OnBlendOut_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr, null);
		}

		// Token: 0x0602B575 RID: 177525 RVA: 0x009FD7E2 File Offset: 0x009FB9E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81A76D2917()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__OnCompleted_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr, null);
		}

		// Token: 0x0602B576 RID: 177526 RVA: 0x009FD7F8 File Offset: 0x009FB9F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Removed_DB9F64004F8908FEAD99D381321E83EA(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_C.__Removed_DB9F64004F8908FEAD99D381321E83EA_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__Removed_DB9F64004F8908FEAD99D381321E83EA_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__Removed_DB9F64004F8908FEAD99D381321E83EA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__Removed_DB9F64004F8908FEAD99D381321E83EA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__Removed_DB9F64004F8908FEAD99D381321E83EA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B577 RID: 177527 RVA: 0x009FD844 File Offset: 0x009FBA44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3DA1F3AFA(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A3DA1F3AFA_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A3DA1F3AFA_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A3DA1F3AFA_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A3DA1F3AFA_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A3DA1F3AFA_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B578 RID: 177528 RVA: 0x009FD890 File Offset: 0x009FBA90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A347A7B2A4(in FGameplayTag Tag)
		{
			GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A347A7B2A4_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A347A7B2A4_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A347A7B2A4_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A347A7B2A4_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__Added_21071CB943CD992BF8EFD6A347A7B2A4_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B579 RID: 177529 RVA: 0x009FD8DC File Offset: 0x009FBADC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88D50560FF(FGameplayEventData Payload)
		{
			GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Super_Sprint_Loop_C.__EventReceived_18B59F5945020DB23C42FD88D50560FF_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B57A RID: 177530 RVA: 0x009FD951 File Offset: 0x009FBB51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B57B RID: 177531 RVA: 0x009FD965 File Offset: 0x009FBB65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B57C RID: 177532 RVA: 0x009FD97C File Offset: 0x009FBB7C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B57D RID: 177533 RVA: 0x009FD9C4 File Offset: 0x009FBBC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Super_Sprint_Loop_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Super_Sprint_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Super_Sprint_Loop_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B57E RID: 177534 RVA: 0x009FDA0B File Offset: 0x009FBC0B
		protected GA_Super_Sprint_Loop_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401689A RID: 92314
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Super_Sprint_Loop.GA_Super_Sprint_Loop_C";

		// Token: 0x0401689B RID: 92315
		private static IntPtr _ClassPtr;

		// Token: 0x0401689C RID: 92316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401689D RID: 92317
		internal new static int __PropertyOffset_1;

		// Token: 0x0401689E RID: 92318
		internal new static int __PropertyOffset_2;

		// Token: 0x0401689F RID: 92319
		internal new static int __PropertyOffset_3;

		// Token: 0x040168A0 RID: 92320
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr;

		// Token: 0x040168A1 RID: 92321
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr;

		// Token: 0x040168A2 RID: 92322
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr;

		// Token: 0x040168A3 RID: 92323
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr;

		// Token: 0x040168A4 RID: 92324
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81A76D2917_NativeFunctionPtr;

		// Token: 0x040168A5 RID: 92325
		private static IntPtr __Removed_DB9F64004F8908FEAD99D381321E83EA_NativeFunctionPtr;

		// Token: 0x040168A6 RID: 92326
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3DA1F3AFA_NativeFunctionPtr;

		// Token: 0x040168A7 RID: 92327
		private static IntPtr __Added_21071CB943CD992BF8EFD6A347A7B2A4_NativeFunctionPtr;

		// Token: 0x040168A8 RID: 92328
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88D50560FF_NativeFunctionPtr;

		// Token: 0x040168A9 RID: 92329
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040168AA RID: 92330
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A4E7 RID: 42215
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Removed_DB9F64004F8908FEAD99D381321E83EA_FunctionParams
		{
			// Token: 0x04032355 RID: 205653
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E8 RID: 42216
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3DA1F3AFA_FunctionParams
		{
			// Token: 0x04032356 RID: 205654
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4E9 RID: 42217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A347A7B2A4_FunctionParams
		{
			// Token: 0x04032357 RID: 205655
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A4EA RID: 42218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88D50560FF_FunctionParams
		{
			// Token: 0x04032358 RID: 205656
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A4EB RID: 42219
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032359 RID: 205657
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
