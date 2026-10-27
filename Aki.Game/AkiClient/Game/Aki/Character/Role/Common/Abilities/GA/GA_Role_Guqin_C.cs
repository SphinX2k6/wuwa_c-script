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
	// Token: 0x02004158 RID: 16728
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Guqin.GA_Role_Guqin_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1532)]
	public class GA_Role_Guqin_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B303 RID: 176899 RVA: 0x009F8559 File Offset: 0x009F6759
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Guqin_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Guqin.GA_Role_Guqin_C");
			}
			return GA_Role_Guqin_C._ClassPtr;
		}

		// Token: 0x0602B304 RID: 176900 RVA: 0x009F8580 File Offset: 0x009F6780
		public GA_Role_Guqin_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Guqin_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B305 RID: 176901 RVA: 0x009F85A8 File Offset: 0x009F67A8
		[NullableContext(1)]
		public GA_Role_Guqin_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Guqin_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A7A RID: 27258
		// (get) Token: 0x0602B306 RID: 176902 RVA: 0x009F85DB File Offset: 0x009F67DB
		// (set) Token: 0x0602B307 RID: 176903 RVA: 0x009F85EF File Offset: 0x009F67EF
		[Nullable(2)]
		public unsafe UBaseAbilitySystemComponent AbilitySystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBaseAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Guqin_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Guqin_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A7B RID: 27259
		// (get) Token: 0x0602B308 RID: 176904 RVA: 0x009F8604 File Offset: 0x009F6804
		// (set) Token: 0x0602B309 RID: 176905 RVA: 0x009F8618 File Offset: 0x009F6818
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Guqin_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Guqin_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B30A RID: 176906 RVA: 0x009F8630 File Offset: 0x009F6830
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override bool K2_CanActivateAbility(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B30B RID: 176907 RVA: 0x009F86F4 File Offset: 0x009F68F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override bool K2_CanActivateAbility_Implementation(FGameplayAbilityActorInfo ActorInfo, ref FGameplayTagContainer RelevantTags)
		{
			GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams* ptr = stackalloc GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams[(UIntPtr)215] + 15L / (long)sizeof(GA_Role_Guqin_C.__K2_CanActivateAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			if (ActorInfo != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilityActorInfo.StaticStruct(), &ptr->ActorInfo, ActorInfo.NativePtr, 1, false);
			}
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), &ptr->RelevantTags, RelevantTags.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 0);
			if (RelevantTags != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), RelevantTags.NativePtr, &ptr->RelevantTags, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(GA_Role_Guqin_C.__K2_CanActivateAbility_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0602B30C RID: 176908 RVA: 0x009F87B8 File Offset: 0x009F69B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81265D3DA7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnTick_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B30D RID: 176909 RVA: 0x009F87CC File Offset: 0x009F69CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81265D3DA7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCancelled_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B30E RID: 176910 RVA: 0x009F87E0 File Offset: 0x009F69E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81265D3DA7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnInterrupted_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B30F RID: 176911 RVA: 0x009F87F4 File Offset: 0x009F69F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81265D3DA7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnBlendOut_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B310 RID: 176912 RVA: 0x009F8808 File Offset: 0x009F6A08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81265D3DA7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCompleted_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B311 RID: 176913 RVA: 0x009F881C File Offset: 0x009F6A1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81E2F3D5F7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnTick_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B312 RID: 176914 RVA: 0x009F8830 File Offset: 0x009F6A30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81E2F3D5F7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCancelled_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B313 RID: 176915 RVA: 0x009F8844 File Offset: 0x009F6A44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81E2F3D5F7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnInterrupted_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B314 RID: 176916 RVA: 0x009F8858 File Offset: 0x009F6A58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81E2F3D5F7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnBlendOut_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B315 RID: 176917 RVA: 0x009F886C File Offset: 0x009F6A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81E2F3D5F7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCompleted_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B316 RID: 176918 RVA: 0x009F8880 File Offset: 0x009F6A80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3B7128487(in FGameplayTag Tag)
		{
			GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3B7128487_FunctionParams* ptr = stackalloc GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3B7128487_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3B7128487_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3B7128487_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3B7128487_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B317 RID: 176919 RVA: 0x009F88CB File Offset: 0x009F6ACB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E814B8FA4E5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnTick_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B318 RID: 176920 RVA: 0x009F88DF File Offset: 0x009F6ADF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E814B8FA4E5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCancelled_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B319 RID: 176921 RVA: 0x009F88F3 File Offset: 0x009F6AF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E814B8FA4E5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnInterrupted_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31A RID: 176922 RVA: 0x009F8907 File Offset: 0x009F6B07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E814B8FA4E5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnBlendOut_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31B RID: 176923 RVA: 0x009F891B File Offset: 0x009F6B1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E814B8FA4E5()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCompleted_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31C RID: 176924 RVA: 0x009F892F File Offset: 0x009F6B2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81D2544D50()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnTick_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31D RID: 176925 RVA: 0x009F8943 File Offset: 0x009F6B43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81D2544D50()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCancelled_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31E RID: 176926 RVA: 0x009F8957 File Offset: 0x009F6B57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81D2544D50()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnInterrupted_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr, null);
		}

		// Token: 0x0602B31F RID: 176927 RVA: 0x009F896B File Offset: 0x009F6B6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81D2544D50()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnBlendOut_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr, null);
		}

		// Token: 0x0602B320 RID: 176928 RVA: 0x009F897F File Offset: 0x009F6B7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81D2544D50()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__OnCompleted_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr, null);
		}

		// Token: 0x0602B321 RID: 176929 RVA: 0x009F8994 File Offset: 0x009F6B94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Added_21071CB943CD992BF8EFD6A3C86BB420(in FGameplayTag Tag)
		{
			GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3C86BB420_FunctionParams* ptr = stackalloc GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3C86BB420_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3C86BB420_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3C86BB420_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__Added_21071CB943CD992BF8EFD6A3C86BB420_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B322 RID: 176930 RVA: 0x009F89DF File Offset: 0x009F6BDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Guqin_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B323 RID: 176931 RVA: 0x009F89F3 File Offset: 0x009F6BF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Guqin_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B324 RID: 176932 RVA: 0x009F8A08 File Offset: 0x009F6C08
		protected GA_Role_Guqin_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040166E7 RID: 91879
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Guqin.GA_Role_Guqin_C";

		// Token: 0x040166E8 RID: 91880
		private static IntPtr _ClassPtr;

		// Token: 0x040166E9 RID: 91881
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040166EA RID: 91882
		internal new static int __PropertyOffset_1;

		// Token: 0x040166EB RID: 91883
		internal new static int __PropertyOffset_2;

		// Token: 0x040166EC RID: 91884
		private static IntPtr __K2_CanActivateAbility_NativeFunctionPtr;

		// Token: 0x040166ED RID: 91885
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr;

		// Token: 0x040166EE RID: 91886
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr;

		// Token: 0x040166EF RID: 91887
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr;

		// Token: 0x040166F0 RID: 91888
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr;

		// Token: 0x040166F1 RID: 91889
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81265D3DA7_NativeFunctionPtr;

		// Token: 0x040166F2 RID: 91890
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr;

		// Token: 0x040166F3 RID: 91891
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr;

		// Token: 0x040166F4 RID: 91892
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr;

		// Token: 0x040166F5 RID: 91893
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr;

		// Token: 0x040166F6 RID: 91894
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81E2F3D5F7_NativeFunctionPtr;

		// Token: 0x040166F7 RID: 91895
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3B7128487_NativeFunctionPtr;

		// Token: 0x040166F8 RID: 91896
		private static IntPtr __OnTick_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr;

		// Token: 0x040166F9 RID: 91897
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr;

		// Token: 0x040166FA RID: 91898
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr;

		// Token: 0x040166FB RID: 91899
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr;

		// Token: 0x040166FC RID: 91900
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E814B8FA4E5_NativeFunctionPtr;

		// Token: 0x040166FD RID: 91901
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr;

		// Token: 0x040166FE RID: 91902
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr;

		// Token: 0x040166FF RID: 91903
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr;

		// Token: 0x04016700 RID: 91904
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr;

		// Token: 0x04016701 RID: 91905
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81D2544D50_NativeFunctionPtr;

		// Token: 0x04016702 RID: 91906
		private static IntPtr __Added_21071CB943CD992BF8EFD6A3C86BB420_NativeFunctionPtr;

		// Token: 0x04016703 RID: 91907
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A499 RID: 42137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 200)]
		protected new ref struct __K2_CanActivateAbility_FunctionParams
		{
			// Token: 0x040322F5 RID: 205557
			[FieldOffset(0)]
			public byte ActorInfo;

			// Token: 0x040322F6 RID: 205558
			[FieldOffset(80)]
			public byte RelevantTags;

			// Token: 0x040322F7 RID: 205559
			[FieldOffset(112)]
			public bool __Result;
		}

		// Token: 0x0200A49A RID: 42138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3B7128487_FunctionParams
		{
			// Token: 0x040322F8 RID: 205560
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}

		// Token: 0x0200A49B RID: 42139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Added_21071CB943CD992BF8EFD6A3C86BB420_FunctionParams
		{
			// Token: 0x040322F9 RID: 205561
			[FieldOffset(0)]
			public FGameplayTag Tag;
		}
	}
}
