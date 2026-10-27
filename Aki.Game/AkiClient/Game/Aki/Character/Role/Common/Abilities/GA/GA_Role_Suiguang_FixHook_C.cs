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
	// Token: 0x02004165 RID: 16741
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Suiguang_FixHook.GA_Role_Suiguang_FixHook_C")]
	[UnrealStructLayout(1616, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public class GA_Role_Suiguang_FixHook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B4A2 RID: 177314 RVA: 0x009FBBB1 File Offset: 0x009F9DB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_Suiguang_FixHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Suiguang_FixHook.GA_Role_Suiguang_FixHook_C");
			}
			return GA_Role_Suiguang_FixHook_C._ClassPtr;
		}

		// Token: 0x0602B4A3 RID: 177315 RVA: 0x009FBBD8 File Offset: 0x009F9DD8
		public GA_Role_Suiguang_FixHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_Suiguang_FixHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B4A4 RID: 177316 RVA: 0x009FBC00 File Offset: 0x009F9E00
		[NullableContext(1)]
		public GA_Role_Suiguang_FixHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_Suiguang_FixHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006AC8 RID: 27336
		// (get) Token: 0x0602B4A5 RID: 177317 RVA: 0x009FBC33 File Offset: 0x009F9E33
		// (set) Token: 0x0602B4A6 RID: 177318 RVA: 0x009FBC47 File Offset: 0x009F9E47
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Suiguang_FixHook_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Suiguang_FixHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006AC9 RID: 27337
		// (get) Token: 0x0602B4A7 RID: 177319 RVA: 0x009FBC5C File Offset: 0x009F9E5C
		// (set) Token: 0x0602B4A8 RID: 177320 RVA: 0x009FBC70 File Offset: 0x009F9E70
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006ACA RID: 27338
		// (get) Token: 0x0602B4A9 RID: 177321 RVA: 0x009FBC85 File Offset: 0x009F9E85
		// (set) Token: 0x0602B4AA RID: 177322 RVA: 0x009FBC99 File Offset: 0x009F9E99
		public unsafe FVector 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006ACB RID: 27339
		// (get) Token: 0x0602B4AB RID: 177323 RVA: 0x009FBCAE File Offset: 0x009F9EAE
		// (set) Token: 0x0602B4AC RID: 177324 RVA: 0x009FBCBE File Offset: 0x009F9EBE
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006ACC RID: 27340
		// (get) Token: 0x0602B4AD RID: 177325 RVA: 0x009FBCCF File Offset: 0x009F9ECF
		// (set) Token: 0x0602B4AE RID: 177326 RVA: 0x009FBCDF File Offset: 0x009F9EDF
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006ACD RID: 27341
		// (get) Token: 0x0602B4AF RID: 177327 RVA: 0x009FBCF0 File Offset: 0x009F9EF0
		// (set) Token: 0x0602B4B0 RID: 177328 RVA: 0x009FBD04 File Offset: 0x009F9F04
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006ACE RID: 27342
		// (get) Token: 0x0602B4B1 RID: 177329 RVA: 0x009FBD19 File Offset: 0x009F9F19
		// (set) Token: 0x0602B4B2 RID: 177330 RVA: 0x009FBD29 File Offset: 0x009F9F29
		public unsafe bool IsSuiGuangType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006ACF RID: 27343
		// (get) Token: 0x0602B4B3 RID: 177331 RVA: 0x009FBD3A File Offset: 0x009F9F3A
		// (set) Token: 0x0602B4B4 RID: 177332 RVA: 0x009FBD4E File Offset: 0x009F9F4E
		public unsafe AActor FixHookActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Suiguang_FixHook_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_Suiguang_FixHook_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006AD0 RID: 27344
		// (get) Token: 0x0602B4B5 RID: 177333 RVA: 0x009FBD63 File Offset: 0x009F9F63
		// (set) Token: 0x0602B4B6 RID: 177334 RVA: 0x009FBD77 File Offset: 0x009F9F77
		public unsafe FVectorDouble FixHookLocation_NUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_Suiguang_FixHook_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x0602B4B7 RID: 177335 RVA: 0x009FBD8C File Offset: 0x009F9F8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshFixHookLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__RefreshFixHookLocation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4B8 RID: 177336 RVA: 0x009FBDA0 File Offset: 0x009F9FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4B9 RID: 177337 RVA: 0x009FBDB4 File Offset: 0x009F9FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4BA RID: 177338 RVA: 0x009FBDC8 File Offset: 0x009F9FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4BB RID: 177339 RVA: 0x009FBDDC File Offset: 0x009F9FDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_AD5ADDBF47997B989A9016A78CAC22E7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__OnFinish_AD5ADDBF47997B989A9016A78CAC22E7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4BC RID: 177340 RVA: 0x009FBDF0 File Offset: 0x009F9FF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_AD5ADDBF47997B989A9016A78CAC22E7()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__OnTick_AD5ADDBF47997B989A9016A78CAC22E7_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4BD RID: 177341 RVA: 0x009FBE04 File Offset: 0x009FA004
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_Suiguang_FixHook_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_Suiguang_FixHook_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_Suiguang_FixHook_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Suiguang_FixHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B4BE RID: 177342 RVA: 0x009FBE6C File Offset: 0x009FA06C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B4BF RID: 177343 RVA: 0x009FBEB4 File Offset: 0x009FA0B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B4C0 RID: 177344 RVA: 0x009FBEFB File Offset: 0x009FA0FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B4C1 RID: 177345 RVA: 0x009FBF0F File Offset: 0x009FA10F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_Suiguang_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B4C2 RID: 177346 RVA: 0x009FBF24 File Offset: 0x009FA124
		protected GA_Role_Suiguang_FixHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401680D RID: 92173
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_Suiguang_FixHook.GA_Role_Suiguang_FixHook_C";

		// Token: 0x0401680E RID: 92174
		private static IntPtr _ClassPtr;

		// Token: 0x0401680F RID: 92175
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016810 RID: 92176
		internal new static int __PropertyOffset_1;

		// Token: 0x04016811 RID: 92177
		internal new static int __PropertyOffset_2;

		// Token: 0x04016812 RID: 92178
		internal new static int __PropertyOffset_3;

		// Token: 0x04016813 RID: 92179
		internal static int __PropertyOffset_4;

		// Token: 0x04016814 RID: 92180
		internal static int __PropertyOffset_5;

		// Token: 0x04016815 RID: 92181
		internal static int __PropertyOffset_6;

		// Token: 0x04016816 RID: 92182
		internal static int __PropertyOffset_7;

		// Token: 0x04016817 RID: 92183
		internal static int __PropertyOffset_8;

		// Token: 0x04016818 RID: 92184
		internal static int __PropertyOffset_9;

		// Token: 0x04016819 RID: 92185
		private static IntPtr __RefreshFixHookLocation_NativeFunctionPtr;

		// Token: 0x0401681A RID: 92186
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x0401681B RID: 92187
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x0401681C RID: 92188
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x0401681D RID: 92189
		private static IntPtr __OnFinish_AD5ADDBF47997B989A9016A78CAC22E7_NativeFunctionPtr;

		// Token: 0x0401681E RID: 92190
		private static IntPtr __OnTick_AD5ADDBF47997B989A9016A78CAC22E7_NativeFunctionPtr;

		// Token: 0x0401681F RID: 92191
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x04016820 RID: 92192
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04016821 RID: 92193
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A4C6 RID: 42182
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x04032332 RID: 205618
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x04032333 RID: 205619
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x04032334 RID: 205620
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A4C7 RID: 42183
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032335 RID: 205621
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
