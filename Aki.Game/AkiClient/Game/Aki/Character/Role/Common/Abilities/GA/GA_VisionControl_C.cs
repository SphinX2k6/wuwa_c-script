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
	// Token: 0x02004181 RID: 16769
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_VisionControl.GA_VisionControl_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1516)]
	public class GA_VisionControl_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6C7 RID: 177863 RVA: 0x00A00438 File Offset: 0x009FE638
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_VisionControl_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_VisionControl.GA_VisionControl_C");
			}
			return GA_VisionControl_C._ClassPtr;
		}

		// Token: 0x0602B6C8 RID: 177864 RVA: 0x00A0045C File Offset: 0x009FE65C
		public GA_VisionControl_C() : this(BuiltinUtils.AllocNativeUObject(GA_VisionControl_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6C9 RID: 177865 RVA: 0x00A00484 File Offset: 0x009FE684
		[NullableContext(1)]
		public GA_VisionControl_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_VisionControl_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B19 RID: 27417
		// (get) Token: 0x0602B6CA RID: 177866 RVA: 0x00A004B7 File Offset: 0x009FE6B7
		// (set) Token: 0x0602B6CB RID: 177867 RVA: 0x00A004C7 File Offset: 0x009FE6C7
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_VisionControl_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_VisionControl_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x0602B6CC RID: 177868 RVA: 0x00A004D8 File Offset: 0x009FE6D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_VisionControl_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_VisionControl_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_VisionControl_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_VisionControl_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_VisionControl_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B6CD RID: 177869 RVA: 0x00A00520 File Offset: 0x009FE720
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_VisionControl_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_VisionControl_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_VisionControl_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_VisionControl_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_VisionControl_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B6CE RID: 177870 RVA: 0x00A00567 File Offset: 0x009FE767
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_VisionControl_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6CF RID: 177871 RVA: 0x00A0057B File Offset: 0x009FE77B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_VisionControl_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6D0 RID: 177872 RVA: 0x00A00590 File Offset: 0x009FE790
		protected GA_VisionControl_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016998 RID: 92568
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_VisionControl.GA_VisionControl_C";

		// Token: 0x04016999 RID: 92569
		private static IntPtr _ClassPtr;

		// Token: 0x0401699A RID: 92570
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401699B RID: 92571
		internal new static int __PropertyOffset_1;

		// Token: 0x0401699C RID: 92572
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0401699D RID: 92573
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A522 RID: 42274
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032390 RID: 205712
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
