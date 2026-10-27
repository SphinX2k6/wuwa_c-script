using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.Item;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004180 RID: 16768
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Sword_TotalAttack.GA_Sword_TotalAttack_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class GA_Sword_TotalAttack_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6B0 RID: 177840 RVA: 0x00A00121 File Offset: 0x009FE321
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Sword_TotalAttack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Sword_TotalAttack.GA_Sword_TotalAttack_C");
			}
			return GA_Sword_TotalAttack_C._ClassPtr;
		}

		// Token: 0x0602B6B1 RID: 177841 RVA: 0x00A00148 File Offset: 0x009FE348
		public GA_Sword_TotalAttack_C() : this(BuiltinUtils.AllocNativeUObject(GA_Sword_TotalAttack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6B2 RID: 177842 RVA: 0x00A00170 File Offset: 0x009FE370
		public GA_Sword_TotalAttack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Sword_TotalAttack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B15 RID: 27413
		// (get) Token: 0x0602B6B3 RID: 177843 RVA: 0x00A001A4 File Offset: 0x009FE3A4
		// (set) Token: 0x0602B6B4 RID: 177844 RVA: 0x00A001DD File Offset: 0x009FE3DD
		public TArray<BP_BaseItem_C> 目标列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BP_BaseItem_C> result;
				if ((result = this._目标列表) == null)
				{
					result = (this._目标列表 = new TArray<BP_BaseItem_C>(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.目标列表.CopyAssign(value);
			}
		}

		// Token: 0x17006B16 RID: 27414
		// (get) Token: 0x0602B6B5 RID: 177845 RVA: 0x00A001EB File Offset: 0x009FE3EB
		// (set) Token: 0x0602B6B6 RID: 177846 RVA: 0x00A001FF File Offset: 0x009FE3FF
		public unsafe FVectorDouble 玩家摄像机朝向
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006B17 RID: 27415
		// (get) Token: 0x0602B6B7 RID: 177847 RVA: 0x00A00214 File Offset: 0x009FE414
		// (set) Token: 0x0602B6B8 RID: 177848 RVA: 0x00A00228 File Offset: 0x009FE428
		public unsafe FVectorDouble 目标朝向点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006B18 RID: 27416
		// (get) Token: 0x0602B6B9 RID: 177849 RVA: 0x00A00240 File Offset: 0x009FE440
		// (set) Token: 0x0602B6BA RID: 177850 RVA: 0x00A00279 File Offset: 0x009FE479
		public TArray<FVectorDouble> 目标位置列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._目标位置列表) == null)
				{
					result = (this._目标位置列表 = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)GA_Sword_TotalAttack_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.目标位置列表.CopyAssign(value);
			}
		}

		// Token: 0x0602B6BB RID: 177851 RVA: 0x00A00287 File Offset: 0x009FE487
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置朝向黑板值()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__设置朝向黑板值_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6BC RID: 177852 RVA: 0x00A0029C File Offset: 0x009FE49C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88DCBF967C(FGameplayEventData Payload)
		{
			GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_FunctionParams* ptr = stackalloc GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Sword_TotalAttack_C.__EventReceived_18B59F5945020DB23C42FD88DCBF967C_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B6BD RID: 177853 RVA: 0x00A00311 File Offset: 0x009FE511
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_5D118C384AE61F1C80292E813CBC8B4D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__OnTick_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6BE RID: 177854 RVA: 0x00A00325 File Offset: 0x009FE525
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_5D118C384AE61F1C80292E813CBC8B4D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__OnCancelled_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6BF RID: 177855 RVA: 0x00A00339 File Offset: 0x009FE539
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_5D118C384AE61F1C80292E813CBC8B4D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__OnInterrupted_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6C0 RID: 177856 RVA: 0x00A0034D File Offset: 0x009FE54D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_5D118C384AE61F1C80292E813CBC8B4D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__OnBlendOut_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6C1 RID: 177857 RVA: 0x00A00361 File Offset: 0x009FE561
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_5D118C384AE61F1C80292E813CBC8B4D()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__OnCompleted_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6C2 RID: 177858 RVA: 0x00A00375 File Offset: 0x009FE575
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6C3 RID: 177859 RVA: 0x00A00389 File Offset: 0x009FE589
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6C4 RID: 177860 RVA: 0x00A003A0 File Offset: 0x009FE5A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Sword_TotalAttack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B6C5 RID: 177861 RVA: 0x00A003E8 File Offset: 0x009FE5E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Sword_TotalAttack_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Sword_TotalAttack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Sword_TotalAttack_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B6C6 RID: 177862 RVA: 0x00A0042F File Offset: 0x009FE62F
		protected GA_Sword_TotalAttack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016986 RID: 92550
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Sword_TotalAttack.GA_Sword_TotalAttack_C";

		// Token: 0x04016987 RID: 92551
		private static IntPtr _ClassPtr;

		// Token: 0x04016988 RID: 92552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016989 RID: 92553
		internal new static int __PropertyOffset_1;

		// Token: 0x0401698A RID: 92554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_BaseItem_C> _目标列表;

		// Token: 0x0401698B RID: 92555
		internal new static int __PropertyOffset_2;

		// Token: 0x0401698C RID: 92556
		internal new static int __PropertyOffset_3;

		// Token: 0x0401698D RID: 92557
		internal static int __PropertyOffset_4;

		// Token: 0x0401698E RID: 92558
		[Nullable(2)]
		private TArray<FVectorDouble> _目标位置列表;

		// Token: 0x0401698F RID: 92559
		private static IntPtr __设置朝向黑板值_NativeFunctionPtr;

		// Token: 0x04016990 RID: 92560
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88DCBF967C_NativeFunctionPtr;

		// Token: 0x04016991 RID: 92561
		private static IntPtr __OnTick_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr;

		// Token: 0x04016992 RID: 92562
		private static IntPtr __OnCancelled_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr;

		// Token: 0x04016993 RID: 92563
		private static IntPtr __OnInterrupted_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr;

		// Token: 0x04016994 RID: 92564
		private static IntPtr __OnBlendOut_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr;

		// Token: 0x04016995 RID: 92565
		private static IntPtr __OnCompleted_5D118C384AE61F1C80292E813CBC8B4D_NativeFunctionPtr;

		// Token: 0x04016996 RID: 92566
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04016997 RID: 92567
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A520 RID: 42272
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88DCBF967C_FunctionParams
		{
			// Token: 0x0403238E RID: 205710
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A521 RID: 42273
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403238F RID: 205711
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
