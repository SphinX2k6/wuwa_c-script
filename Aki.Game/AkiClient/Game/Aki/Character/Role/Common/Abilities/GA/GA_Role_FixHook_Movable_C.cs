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
	// Token: 0x02004155 RID: 16725
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Movable.GA_Role_FixHook_Movable_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class GA_Role_FixHook_Movable_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B2D8 RID: 176856 RVA: 0x009F8097 File Offset: 0x009F6297
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Role_FixHook_Movable_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Movable.GA_Role_FixHook_Movable_C");
			}
			return GA_Role_FixHook_Movable_C._ClassPtr;
		}

		// Token: 0x0602B2D9 RID: 176857 RVA: 0x009F80BC File Offset: 0x009F62BC
		public GA_Role_FixHook_Movable_C() : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Movable_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B2DA RID: 176858 RVA: 0x009F80E4 File Offset: 0x009F62E4
		[NullableContext(1)]
		public GA_Role_FixHook_Movable_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Role_FixHook_Movable_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A72 RID: 27250
		// (get) Token: 0x0602B2DB RID: 176859 RVA: 0x009F8117 File Offset: 0x009F6317
		// (set) Token: 0x0602B2DC RID: 176860 RVA: 0x009F812B File Offset: 0x009F632B
		public unsafe TsBaseCharacter 施法者_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Movable_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Movable_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A73 RID: 27251
		// (get) Token: 0x0602B2DD RID: 176861 RVA: 0x009F8140 File Offset: 0x009F6340
		// (set) Token: 0x0602B2DE RID: 176862 RVA: 0x009F8154 File Offset: 0x009F6354
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A74 RID: 27252
		// (get) Token: 0x0602B2DF RID: 176863 RVA: 0x009F8169 File Offset: 0x009F6369
		// (set) Token: 0x0602B2E0 RID: 176864 RVA: 0x009F817D File Offset: 0x009F637D
		public unsafe FVectorDouble 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A75 RID: 27253
		// (get) Token: 0x0602B2E1 RID: 176865 RVA: 0x009F8192 File Offset: 0x009F6392
		// (set) Token: 0x0602B2E2 RID: 176866 RVA: 0x009F81A2 File Offset: 0x009F63A2
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006A76 RID: 27254
		// (get) Token: 0x0602B2E3 RID: 176867 RVA: 0x009F81B3 File Offset: 0x009F63B3
		// (set) Token: 0x0602B2E4 RID: 176868 RVA: 0x009F81C3 File Offset: 0x009F63C3
		public unsafe float 角色胶囊体半高
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006A77 RID: 27255
		// (get) Token: 0x0602B2E5 RID: 176869 RVA: 0x009F81D4 File Offset: 0x009F63D4
		// (set) Token: 0x0602B2E6 RID: 176870 RVA: 0x009F81E8 File Offset: 0x009F63E8
		public unsafe FVectorDouble LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006A78 RID: 27256
		// (get) Token: 0x0602B2E7 RID: 176871 RVA: 0x009F81FD File Offset: 0x009F63FD
		// (set) Token: 0x0602B2E8 RID: 176872 RVA: 0x009F8211 File Offset: 0x009F6411
		public unsafe AActor FixHookActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Movable_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Role_FixHook_Movable_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006A79 RID: 27257
		// (get) Token: 0x0602B2E9 RID: 176873 RVA: 0x009F8226 File Offset: 0x009F6426
		// (set) Token: 0x0602B2EA RID: 176874 RVA: 0x009F823A File Offset: 0x009F643A
		public unsafe FVectorDouble FixHookLocation_NUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Role_FixHook_Movable_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0602B2EB RID: 176875 RVA: 0x009F824F File Offset: 0x009F644F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshFixHookLocation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__RefreshFixHookLocation_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2EC RID: 176876 RVA: 0x009F8263 File Offset: 0x009F6463
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 是否继承速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__是否继承速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2ED RID: 176877 RVA: 0x009F8277 File Offset: 0x009F6477
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__FixHookTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2EE RID: 176878 RVA: 0x009F828B File Offset: 0x009F648B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2EF RID: 176879 RVA: 0x009F829F File Offset: 0x009F649F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_1F93562B4ABB3E70057EE3B61762403F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__OnFinish_1F93562B4ABB3E70057EE3B61762403F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2F0 RID: 176880 RVA: 0x009F82B3 File Offset: 0x009F64B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_1F93562B4ABB3E70057EE3B61762403F()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__OnTick_1F93562B4ABB3E70057EE3B61762403F_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2F1 RID: 176881 RVA: 0x009F82C8 File Offset: 0x009F64C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			GA_Role_FixHook_Movable_C.__MovementModeChange_FunctionParams* ptr = stackalloc GA_Role_FixHook_Movable_C.__MovementModeChange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(GA_Role_FixHook_Movable_C.__MovementModeChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Movable_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__MovementModeChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B2F2 RID: 176882 RVA: 0x009F8330 File Offset: 0x009F6530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Movable_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B2F3 RID: 176883 RVA: 0x009F8378 File Offset: 0x009F6578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Role_FixHook_Movable_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Role_FixHook_Movable_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B2F4 RID: 176884 RVA: 0x009F83BF File Offset: 0x009F65BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B2F5 RID: 176885 RVA: 0x009F83D3 File Offset: 0x009F65D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Role_FixHook_Movable_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B2F6 RID: 176886 RVA: 0x009F83E8 File Offset: 0x009F65E8
		protected GA_Role_FixHook_Movable_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040166CB RID: 91851
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Role_FixHook_Movable.GA_Role_FixHook_Movable_C";

		// Token: 0x040166CC RID: 91852
		private static IntPtr _ClassPtr;

		// Token: 0x040166CD RID: 91853
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040166CE RID: 91854
		internal new static int __PropertyOffset_1;

		// Token: 0x040166CF RID: 91855
		internal new static int __PropertyOffset_2;

		// Token: 0x040166D0 RID: 91856
		internal new static int __PropertyOffset_3;

		// Token: 0x040166D1 RID: 91857
		internal static int __PropertyOffset_4;

		// Token: 0x040166D2 RID: 91858
		internal static int __PropertyOffset_5;

		// Token: 0x040166D3 RID: 91859
		internal static int __PropertyOffset_6;

		// Token: 0x040166D4 RID: 91860
		internal static int __PropertyOffset_7;

		// Token: 0x040166D5 RID: 91861
		internal static int __PropertyOffset_8;

		// Token: 0x040166D6 RID: 91862
		private static IntPtr __RefreshFixHookLocation_NativeFunctionPtr;

		// Token: 0x040166D7 RID: 91863
		private static IntPtr __是否继承速度_NativeFunctionPtr;

		// Token: 0x040166D8 RID: 91864
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x040166D9 RID: 91865
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x040166DA RID: 91866
		private static IntPtr __OnFinish_1F93562B4ABB3E70057EE3B61762403F_NativeFunctionPtr;

		// Token: 0x040166DB RID: 91867
		private static IntPtr __OnTick_1F93562B4ABB3E70057EE3B61762403F_NativeFunctionPtr;

		// Token: 0x040166DC RID: 91868
		private static IntPtr __MovementModeChange_NativeFunctionPtr;

		// Token: 0x040166DD RID: 91869
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040166DE RID: 91870
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A497 RID: 42135
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __MovementModeChange_FunctionParams
		{
			// Token: 0x040322F1 RID: 205553
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x040322F2 RID: 205554
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040322F3 RID: 205555
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x0200A498 RID: 42136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322F4 RID: 205556
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
