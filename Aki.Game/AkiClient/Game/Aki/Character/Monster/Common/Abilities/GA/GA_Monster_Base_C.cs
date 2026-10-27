using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Monster.Common.Abilities.GA
{
	// Token: 0x02004253 RID: 16979
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/Abilities/GA/GA_Monster_Base.GA_Monster_Base_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_Monster_Base_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BFC7 RID: 180167 RVA: 0x00A1105B File Offset: 0x00A0F25B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Monster_Base_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Monster/Common/Abilities/GA/GA_Monster_Base.GA_Monster_Base_C");
			}
			return GA_Monster_Base_C._ClassPtr;
		}

		// Token: 0x0602BFC8 RID: 180168 RVA: 0x00A11080 File Offset: 0x00A0F280
		public GA_Monster_Base_C() : this(BuiltinUtils.AllocNativeUObject(GA_Monster_Base_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BFC9 RID: 180169 RVA: 0x00A110A8 File Offset: 0x00A0F2A8
		[NullableContext(1)]
		public GA_Monster_Base_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Monster_Base_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D2D RID: 27949
		// (get) Token: 0x0602BFCA RID: 180170 RVA: 0x00A110DB File Offset: 0x00A0F2DB
		// (set) Token: 0x0602BFCB RID: 180171 RVA: 0x00A110EF File Offset: 0x00A0F2EF
		[Nullable(2)]
		public unsafe TsBaseCharacter 施法者_0
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Monster_Base_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Monster_Base_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602BFCC RID: 180172 RVA: 0x00A11104 File Offset: 0x00A0F304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Monster_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602BFCD RID: 180173 RVA: 0x00A11118 File Offset: 0x00A0F318
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Monster_Base_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BFCE RID: 180174 RVA: 0x00A11130 File Offset: 0x00A0F330
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Monster_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Monster_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BFCF RID: 180175 RVA: 0x00A11178 File Offset: 0x00A0F378
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Monster_Base_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Monster_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Monster_Base_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602BFD0 RID: 180176 RVA: 0x00A111BF File Offset: 0x00A0F3BF
		protected GA_Monster_Base_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F94 RID: 94100
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Monster/Common/Abilities/GA/GA_Monster_Base.GA_Monster_Base_C";

		// Token: 0x04016F95 RID: 94101
		private static IntPtr _ClassPtr;

		// Token: 0x04016F96 RID: 94102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F97 RID: 94103
		internal new static int __PropertyOffset_1;

		// Token: 0x04016F98 RID: 94104
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016F99 RID: 94105
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A5AD RID: 42413
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032441 RID: 205889
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
