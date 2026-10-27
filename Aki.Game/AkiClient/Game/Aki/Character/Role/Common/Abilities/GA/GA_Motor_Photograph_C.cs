using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004148 RID: 16712
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Photograph.GA_Motor_Photograph_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1548)]
	public class GA_Motor_Photograph_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B161 RID: 176481 RVA: 0x009F56F8 File Offset: 0x009F38F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Photograph_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Photograph.GA_Motor_Photograph_C");
			}
			return GA_Motor_Photograph_C._ClassPtr;
		}

		// Token: 0x0602B162 RID: 176482 RVA: 0x009F571C File Offset: 0x009F391C
		public GA_Motor_Photograph_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Photograph_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B163 RID: 176483 RVA: 0x009F5744 File Offset: 0x009F3944
		[NullableContext(1)]
		public GA_Motor_Photograph_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Photograph_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A16 RID: 27158
		// (get) Token: 0x0602B164 RID: 176484 RVA: 0x009F5777 File Offset: 0x009F3977
		// (set) Token: 0x0602B165 RID: 176485 RVA: 0x009F578B File Offset: 0x009F398B
		[Nullable(2)]
		public unsafe BP_Motor_BaseVehicle_C 摩托车对象缓存
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Motor_BaseVehicle_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Photograph_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Photograph_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A17 RID: 27159
		// (get) Token: 0x0602B166 RID: 176486 RVA: 0x009F57A0 File Offset: 0x009F39A0
		// (set) Token: 0x0602B167 RID: 176487 RVA: 0x009F57B0 File Offset: 0x009F39B0
		public unsafe int 摩托车对象entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A18 RID: 27160
		// (get) Token: 0x0602B168 RID: 176488 RVA: 0x009F57C1 File Offset: 0x009F39C1
		// (set) Token: 0x0602B169 RID: 176489 RVA: 0x009F57D5 File Offset: 0x009F39D5
		public unsafe FVector In_Out_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A19 RID: 27161
		// (get) Token: 0x0602B16A RID: 176490 RVA: 0x009F57EA File Offset: 0x009F39EA
		// (set) Token: 0x0602B16B RID: 176491 RVA: 0x009F57FE File Offset: 0x009F39FE
		public unsafe FRotator Out_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Photograph_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B16C RID: 176492 RVA: 0x009F5814 File Offset: 0x009F3A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TraceTest(FVectorDouble Start, FVectorDouble End, ref bool Block)
		{
			GA_Motor_Photograph_C.__TraceTest_FunctionParams* ptr = stackalloc GA_Motor_Photograph_C.__TraceTest_FunctionParams[(UIntPtr)407] + 15L / (long)sizeof(GA_Motor_Photograph_C.__TraceTest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Photograph_C.__TraceTest_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Start = Start;
			ptr->End = End;
			ptr->Block = Block;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Photograph_C.__TraceTest_NativeFunctionPtr, (void*)ptr);
			Block = ptr->Block;
		}

		// Token: 0x0602B16D RID: 176493 RVA: 0x009F5874 File Offset: 0x009F3A74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FinishSummon(string Reason, bool ShowFloat)
		{
			GA_Motor_Photograph_C.__FinishSummon_FunctionParams* ptr = stackalloc GA_Motor_Photograph_C.__FinishSummon_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Photograph_C.__FinishSummon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Photograph_C.__FinishSummon_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			ptr->ShowFloat = ShowFloat;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Photograph_C.__FinishSummon_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Motor_Photograph_C.__FinishSummon_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602B16E RID: 176494 RVA: 0x009F58D8 File Offset: 0x009F3AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Photograph_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B16F RID: 176495 RVA: 0x009F58EC File Offset: 0x009F3AEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Photograph_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B170 RID: 176496 RVA: 0x009F5904 File Offset: 0x009F3B04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Photograph_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Photograph_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B171 RID: 176497 RVA: 0x009F594C File Offset: 0x009F3B4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Photograph_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Photograph_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Photograph_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B172 RID: 176498 RVA: 0x009F5993 File Offset: 0x009F3B93
		protected GA_Motor_Photograph_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165CA RID: 91594
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Photograph.GA_Motor_Photograph_C";

		// Token: 0x040165CB RID: 91595
		private static IntPtr _ClassPtr;

		// Token: 0x040165CC RID: 91596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165CD RID: 91597
		internal new static int __PropertyOffset_1;

		// Token: 0x040165CE RID: 91598
		internal new static int __PropertyOffset_2;

		// Token: 0x040165CF RID: 91599
		internal new static int __PropertyOffset_3;

		// Token: 0x040165D0 RID: 91600
		internal static int __PropertyOffset_4;

		// Token: 0x040165D1 RID: 91601
		private static IntPtr __TraceTest_NativeFunctionPtr;

		// Token: 0x040165D2 RID: 91602
		private static IntPtr __FinishSummon_NativeFunctionPtr;

		// Token: 0x040165D3 RID: 91603
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165D4 RID: 91604
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A47B RID: 42107
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 392)]
		protected ref struct __TraceTest_FunctionParams
		{
			// Token: 0x040322CA RID: 205514
			[FieldOffset(0)]
			public FVectorDouble Start;

			// Token: 0x040322CB RID: 205515
			[FieldOffset(24)]
			public FVectorDouble End;

			// Token: 0x040322CC RID: 205516
			[FieldOffset(48)]
			public bool Block;
		}

		// Token: 0x0200A47C RID: 42108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FinishSummon_FunctionParams
		{
			// Token: 0x040322CD RID: 205517
			[FieldOffset(0)]
			public FString Reason;

			// Token: 0x040322CE RID: 205518
			[FieldOffset(16)]
			public bool ShowFloat;
		}

		// Token: 0x0200A47D RID: 42109
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322CF RID: 205519
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
