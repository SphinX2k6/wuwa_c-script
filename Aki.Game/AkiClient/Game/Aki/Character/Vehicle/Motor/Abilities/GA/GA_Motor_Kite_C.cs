using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200407C RID: 16508
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Kite.GA_Motor_Kite_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1544)]
	public class GA_Motor_Kite_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A770 RID: 173936 RVA: 0x009E17D0 File Offset: 0x009DF9D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Kite_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Kite.GA_Motor_Kite_C");
			}
			return GA_Motor_Kite_C._ClassPtr;
		}

		// Token: 0x0602A771 RID: 173937 RVA: 0x009E17F4 File Offset: 0x009DF9F4
		public GA_Motor_Kite_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Kite_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A772 RID: 173938 RVA: 0x009E181C File Offset: 0x009DFA1C
		[NullableContext(1)]
		public GA_Motor_Kite_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Kite_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006826 RID: 26662
		// (get) Token: 0x0602A773 RID: 173939 RVA: 0x009E184F File Offset: 0x009DFA4F
		// (set) Token: 0x0602A774 RID: 173940 RVA: 0x009E1863 File Offset: 0x009DFA63
		public unsafe AActor 被控物
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Kite_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Kite_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006827 RID: 26663
		// (get) Token: 0x0602A775 RID: 173941 RVA: 0x009E1878 File Offset: 0x009DFA78
		// (set) Token: 0x0602A776 RID: 173942 RVA: 0x009E188C File Offset: 0x009DFA8C
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Kite_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Kite_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17006828 RID: 26664
		// (get) Token: 0x0602A777 RID: 173943 RVA: 0x009E18A1 File Offset: 0x009DFAA1
		// (set) Token: 0x0602A778 RID: 173944 RVA: 0x009E18B1 File Offset: 0x009DFAB1
		public unsafe int 驾驶员EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006829 RID: 26665
		// (get) Token: 0x0602A779 RID: 173945 RVA: 0x009E18C2 File Offset: 0x009DFAC2
		// (set) Token: 0x0602A77A RID: 173946 RVA: 0x009E18D2 File Offset: 0x009DFAD2
		public unsafe int 钩锁Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x0602A77B RID: 173947 RVA: 0x009E18E3 File Offset: 0x009DFAE3
		// (set) Token: 0x0602A77C RID: 173948 RVA: 0x009E18F3 File Offset: 0x009DFAF3
		public unsafe bool IsStartGetOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x0602A77D RID: 173949 RVA: 0x009E1904 File Offset: 0x009DFB04
		// (set) Token: 0x0602A77E RID: 173950 RVA: 0x009E1914 File Offset: 0x009DFB14
		public unsafe int 载具EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Kite_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x0602A77F RID: 173951 RVA: 0x009E1925 File Offset: 0x009DFB25
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InterruptHookSkill()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__InterruptHookSkill_NativeFunctionPtr, null);
		}

		// Token: 0x0602A780 RID: 173952 RVA: 0x009E193C File Offset: 0x009DFB3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Init(ref bool InitSuccess)
		{
			GA_Motor_Kite_C.__Init_FunctionParams* ptr = stackalloc GA_Motor_Kite_C.__Init_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Kite_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Kite_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InitSuccess = InitSuccess;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__Init_NativeFunctionPtr, (void*)ptr);
			InitSuccess = ptr->InitSuccess;
		}

		// Token: 0x0602A781 RID: 173953 RVA: 0x009E198B File Offset: 0x009DFB8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09BC6114B3E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__OnTick_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A782 RID: 173954 RVA: 0x009E199F File Offset: 0x009DFB9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09BC6114B3E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__OnCancelled_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A783 RID: 173955 RVA: 0x009E19B3 File Offset: 0x009DFBB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09BC6114B3E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A784 RID: 173956 RVA: 0x009E19C7 File Offset: 0x009DFBC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09BC6114B3E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A785 RID: 173957 RVA: 0x009E19DB File Offset: 0x009DFBDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09BC6114B3E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__OnCompleted_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A786 RID: 173958 RVA: 0x009E19EF File Offset: 0x009DFBEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A787 RID: 173959 RVA: 0x009E1A03 File Offset: 0x009DFC03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Kite_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A788 RID: 173960 RVA: 0x009E1A18 File Offset: 0x009DFC18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A789 RID: 173961 RVA: 0x009E1A60 File Offset: 0x009DFC60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Kite_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Kite_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A78A RID: 173962 RVA: 0x009E1AA7 File Offset: 0x009DFCA7
		protected GA_Motor_Kite_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015EF5 RID: 89845
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Kite.GA_Motor_Kite_C";

		// Token: 0x04015EF6 RID: 89846
		private static IntPtr _ClassPtr;

		// Token: 0x04015EF7 RID: 89847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015EF8 RID: 89848
		internal new static int __PropertyOffset_1;

		// Token: 0x04015EF9 RID: 89849
		internal new static int __PropertyOffset_2;

		// Token: 0x04015EFA RID: 89850
		internal new static int __PropertyOffset_3;

		// Token: 0x04015EFB RID: 89851
		internal static int __PropertyOffset_4;

		// Token: 0x04015EFC RID: 89852
		internal static int __PropertyOffset_5;

		// Token: 0x04015EFD RID: 89853
		internal static int __PropertyOffset_6;

		// Token: 0x04015EFE RID: 89854
		private static IntPtr __InterruptHookSkill_NativeFunctionPtr;

		// Token: 0x04015EFF RID: 89855
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04015F00 RID: 89856
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr;

		// Token: 0x04015F01 RID: 89857
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr;

		// Token: 0x04015F02 RID: 89858
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr;

		// Token: 0x04015F03 RID: 89859
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr;

		// Token: 0x04015F04 RID: 89860
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09BC6114B3E_NativeFunctionPtr;

		// Token: 0x04015F05 RID: 89861
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015F06 RID: 89862
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A3B1 RID: 41905
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x0403219E RID: 205214
			[FieldOffset(0)]
			public bool InitSuccess;
		}

		// Token: 0x0200A3B2 RID: 41906
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403219F RID: 205215
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
