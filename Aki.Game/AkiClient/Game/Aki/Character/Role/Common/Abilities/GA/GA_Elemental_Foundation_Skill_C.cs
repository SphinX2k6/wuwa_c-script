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
	// Token: 0x0200412A RID: 16682
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Foundation_Skill.GA_Elemental_Foundation_Skill_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Elemental_Foundation_Skill_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AFCC RID: 176076 RVA: 0x009F22F0 File Offset: 0x009F04F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Elemental_Foundation_Skill_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Foundation_Skill.GA_Elemental_Foundation_Skill_C");
			}
			return GA_Elemental_Foundation_Skill_C._ClassPtr;
		}

		// Token: 0x0602AFCD RID: 176077 RVA: 0x009F2314 File Offset: 0x009F0514
		public GA_Elemental_Foundation_Skill_C() : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Foundation_Skill_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AFCE RID: 176078 RVA: 0x009F233C File Offset: 0x009F053C
		[NullableContext(1)]
		public GA_Elemental_Foundation_Skill_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Elemental_Foundation_Skill_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069F0 RID: 27120
		// (get) Token: 0x0602AFCF RID: 176079 RVA: 0x009F236F File Offset: 0x009F056F
		// (set) Token: 0x0602AFD0 RID: 176080 RVA: 0x009F2383 File Offset: 0x009F0583
		public unsafe FVectorDouble TargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Elemental_Foundation_Skill_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Elemental_Foundation_Skill_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602AFD1 RID: 176081 RVA: 0x009F2398 File Offset: 0x009F0598
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E81C814049C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__OnTick_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD2 RID: 176082 RVA: 0x009F23AC File Offset: 0x009F05AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E81C814049C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__OnCancelled_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD3 RID: 176083 RVA: 0x009F23C0 File Offset: 0x009F05C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E81C814049C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__OnInterrupted_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD4 RID: 176084 RVA: 0x009F23D4 File Offset: 0x009F05D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E81C814049C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__OnBlendOut_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD5 RID: 176085 RVA: 0x009F23E8 File Offset: 0x009F05E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E81C814049C()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__OnCompleted_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD6 RID: 176086 RVA: 0x009F23FC File Offset: 0x009F05FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602AFD7 RID: 176087 RVA: 0x009F2410 File Offset: 0x009F0610
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602AFD8 RID: 176088 RVA: 0x009F2428 File Offset: 0x009F0628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFD9 RID: 176089 RVA: 0x009F2470 File Offset: 0x009F0670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AFDA RID: 176090 RVA: 0x009F24B8 File Offset: 0x009F06B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AfterRequest(bool bContent)
		{
			GA_Elemental_Foundation_Skill_C.__AfterRequest_FunctionParams* ptr = stackalloc GA_Elemental_Foundation_Skill_C.__AfterRequest_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Elemental_Foundation_Skill_C.__AfterRequest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Elemental_Foundation_Skill_C.__AfterRequest_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bContent = bContent;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Elemental_Foundation_Skill_C.__AfterRequest_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AFDB RID: 176091 RVA: 0x009F24FE File Offset: 0x009F06FE
		protected GA_Elemental_Foundation_Skill_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164AB RID: 91307
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Elemental_Foundation_Skill.GA_Elemental_Foundation_Skill_C";

		// Token: 0x040164AC RID: 91308
		private static IntPtr _ClassPtr;

		// Token: 0x040164AD RID: 91309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164AE RID: 91310
		internal new static int __PropertyOffset_1;

		// Token: 0x040164AF RID: 91311
		private static IntPtr __OnTick_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr;

		// Token: 0x040164B0 RID: 91312
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr;

		// Token: 0x040164B1 RID: 91313
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr;

		// Token: 0x040164B2 RID: 91314
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr;

		// Token: 0x040164B3 RID: 91315
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E81C814049C_NativeFunctionPtr;

		// Token: 0x040164B4 RID: 91316
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040164B5 RID: 91317
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040164B6 RID: 91318
		private static IntPtr __AfterRequest_NativeFunctionPtr;

		// Token: 0x0200A457 RID: 42071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403229B RID: 205467
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A458 RID: 42072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __AfterRequest_FunctionParams
		{
			// Token: 0x0403229C RID: 205468
			[FieldOffset(0)]
			public bool bContent;
		}
	}
}
