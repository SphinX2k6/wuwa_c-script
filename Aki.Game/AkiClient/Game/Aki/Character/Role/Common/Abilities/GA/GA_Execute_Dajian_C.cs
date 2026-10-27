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
	// Token: 0x0200412E RID: 16686
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Dajian.GA_Execute_Dajian_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Execute_Dajian_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B001 RID: 176129 RVA: 0x009F29B9 File Offset: 0x009F0BB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Execute_Dajian_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Dajian.GA_Execute_Dajian_C");
			}
			return GA_Execute_Dajian_C._ClassPtr;
		}

		// Token: 0x0602B002 RID: 176130 RVA: 0x009F29E0 File Offset: 0x009F0BE0
		public GA_Execute_Dajian_C() : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Dajian_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B003 RID: 176131 RVA: 0x009F2A08 File Offset: 0x009F0C08
		[NullableContext(1)]
		public GA_Execute_Dajian_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Dajian_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069F5 RID: 27125
		// (get) Token: 0x0602B004 RID: 176132 RVA: 0x009F2A3B File Offset: 0x009F0C3B
		// (set) Token: 0x0602B005 RID: 176133 RVA: 0x009F2A4B File Offset: 0x009F0C4B
		public unsafe bool 落地攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069F6 RID: 27126
		// (get) Token: 0x0602B006 RID: 176134 RVA: 0x009F2A5C File Offset: 0x009F0C5C
		// (set) Token: 0x0602B007 RID: 176135 RVA: 0x009F2A6C File Offset: 0x009F0C6C
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069F7 RID: 27127
		// (get) Token: 0x0602B008 RID: 176136 RVA: 0x009F2A7D File Offset: 0x009F0C7D
		// (set) Token: 0x0602B009 RID: 176137 RVA: 0x009F2A91 File Offset: 0x009F0C91
		public unsafe FName 追踪插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170069F8 RID: 27128
		// (get) Token: 0x0602B00A RID: 176138 RVA: 0x009F2AA6 File Offset: 0x009F0CA6
		// (set) Token: 0x0602B00B RID: 176139 RVA: 0x009F2AB6 File Offset: 0x009F0CB6
		public unsafe int 特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Dajian_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B00C RID: 176140 RVA: 0x009F2AC7 File Offset: 0x009F0CC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E8171BB25F0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__OnTick_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B00D RID: 176141 RVA: 0x009F2ADB File Offset: 0x009F0CDB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E8171BB25F0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__OnCancelled_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B00E RID: 176142 RVA: 0x009F2AEF File Offset: 0x009F0CEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E8171BB25F0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__OnInterrupted_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B00F RID: 176143 RVA: 0x009F2B03 File Offset: 0x009F0D03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E8171BB25F0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__OnBlendOut_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B010 RID: 176144 RVA: 0x009F2B17 File Offset: 0x009F0D17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E8171BB25F0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__OnCompleted_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr, null);
		}

		// Token: 0x0602B011 RID: 176145 RVA: 0x009F2B2C File Offset: 0x009F0D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Dajian_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B012 RID: 176146 RVA: 0x009F2B74 File Offset: 0x009F0D74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Dajian_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Dajian_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Dajian_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B013 RID: 176147 RVA: 0x009F2BBB File Offset: 0x009F0DBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Dajian_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B014 RID: 176148 RVA: 0x009F2BCF File Offset: 0x009F0DCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Dajian_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B015 RID: 176149 RVA: 0x009F2BE4 File Offset: 0x009F0DE4
		protected GA_Execute_Dajian_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164CF RID: 91343
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Dajian.GA_Execute_Dajian_C";

		// Token: 0x040164D0 RID: 91344
		private static IntPtr _ClassPtr;

		// Token: 0x040164D1 RID: 91345
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164D2 RID: 91346
		internal new static int __PropertyOffset_1;

		// Token: 0x040164D3 RID: 91347
		internal new static int __PropertyOffset_2;

		// Token: 0x040164D4 RID: 91348
		internal new static int __PropertyOffset_3;

		// Token: 0x040164D5 RID: 91349
		internal static int __PropertyOffset_4;

		// Token: 0x040164D6 RID: 91350
		private static IntPtr __OnTick_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr;

		// Token: 0x040164D7 RID: 91351
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr;

		// Token: 0x040164D8 RID: 91352
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr;

		// Token: 0x040164D9 RID: 91353
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr;

		// Token: 0x040164DA RID: 91354
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E8171BB25F0_NativeFunctionPtr;

		// Token: 0x040164DB RID: 91355
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040164DC RID: 91356
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A45C RID: 42076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A0 RID: 205472
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
