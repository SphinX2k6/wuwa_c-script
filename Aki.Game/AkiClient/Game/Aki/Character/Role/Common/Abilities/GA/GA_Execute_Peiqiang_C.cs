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
	// Token: 0x0200412F RID: 16687
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Peiqiang.GA_Execute_Peiqiang_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Execute_Peiqiang_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B016 RID: 176150 RVA: 0x009F2BED File Offset: 0x009F0DED
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Execute_Peiqiang_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Peiqiang.GA_Execute_Peiqiang_C");
			}
			return GA_Execute_Peiqiang_C._ClassPtr;
		}

		// Token: 0x0602B017 RID: 176151 RVA: 0x009F2C14 File Offset: 0x009F0E14
		public GA_Execute_Peiqiang_C() : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Peiqiang_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B018 RID: 176152 RVA: 0x009F2C3C File Offset: 0x009F0E3C
		[NullableContext(1)]
		public GA_Execute_Peiqiang_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Execute_Peiqiang_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170069F9 RID: 27129
		// (get) Token: 0x0602B019 RID: 176153 RVA: 0x009F2C6F File Offset: 0x009F0E6F
		// (set) Token: 0x0602B01A RID: 176154 RVA: 0x009F2C7F File Offset: 0x009F0E7F
		public unsafe bool 落地攻击
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170069FA RID: 27130
		// (get) Token: 0x0602B01B RID: 176155 RVA: 0x009F2C90 File Offset: 0x009F0E90
		// (set) Token: 0x0602B01C RID: 176156 RVA: 0x009F2CA0 File Offset: 0x009F0EA0
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170069FB RID: 27131
		// (get) Token: 0x0602B01D RID: 176157 RVA: 0x009F2CB1 File Offset: 0x009F0EB1
		// (set) Token: 0x0602B01E RID: 176158 RVA: 0x009F2CC5 File Offset: 0x009F0EC5
		public unsafe FName 追踪插槽
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170069FC RID: 27132
		// (get) Token: 0x0602B01F RID: 176159 RVA: 0x009F2CDA File Offset: 0x009F0EDA
		// (set) Token: 0x0602B020 RID: 176160 RVA: 0x009F2CEA File Offset: 0x009F0EEA
		public unsafe int 特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Execute_Peiqiang_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B021 RID: 176161 RVA: 0x009F2CFB File Offset: 0x009F0EFB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E815C4E2C76()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__OnTick_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr, null);
		}

		// Token: 0x0602B022 RID: 176162 RVA: 0x009F2D0F File Offset: 0x009F0F0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E815C4E2C76()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__OnCancelled_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr, null);
		}

		// Token: 0x0602B023 RID: 176163 RVA: 0x009F2D23 File Offset: 0x009F0F23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E815C4E2C76()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__OnInterrupted_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr, null);
		}

		// Token: 0x0602B024 RID: 176164 RVA: 0x009F2D37 File Offset: 0x009F0F37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E815C4E2C76()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__OnBlendOut_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr, null);
		}

		// Token: 0x0602B025 RID: 176165 RVA: 0x009F2D4B File Offset: 0x009F0F4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E815C4E2C76()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__OnCompleted_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr, null);
		}

		// Token: 0x0602B026 RID: 176166 RVA: 0x009F2D60 File Offset: 0x009F0F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Peiqiang_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B027 RID: 176167 RVA: 0x009F2DA8 File Offset: 0x009F0FA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Execute_Peiqiang_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Execute_Peiqiang_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B028 RID: 176168 RVA: 0x009F2DEF File Offset: 0x009F0FEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B029 RID: 176169 RVA: 0x009F2E03 File Offset: 0x009F1003
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Execute_Peiqiang_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B02A RID: 176170 RVA: 0x009F2E18 File Offset: 0x009F1018
		protected GA_Execute_Peiqiang_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040164DD RID: 91357
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Execute_Peiqiang.GA_Execute_Peiqiang_C";

		// Token: 0x040164DE RID: 91358
		private static IntPtr _ClassPtr;

		// Token: 0x040164DF RID: 91359
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040164E0 RID: 91360
		internal new static int __PropertyOffset_1;

		// Token: 0x040164E1 RID: 91361
		internal new static int __PropertyOffset_2;

		// Token: 0x040164E2 RID: 91362
		internal new static int __PropertyOffset_3;

		// Token: 0x040164E3 RID: 91363
		internal static int __PropertyOffset_4;

		// Token: 0x040164E4 RID: 91364
		private static IntPtr __OnTick_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr;

		// Token: 0x040164E5 RID: 91365
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr;

		// Token: 0x040164E6 RID: 91366
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr;

		// Token: 0x040164E7 RID: 91367
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr;

		// Token: 0x040164E8 RID: 91368
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E815C4E2C76_NativeFunctionPtr;

		// Token: 0x040164E9 RID: 91369
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x040164EA RID: 91370
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A45D RID: 42077
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322A1 RID: 205473
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
