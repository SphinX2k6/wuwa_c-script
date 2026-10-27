using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using AkiClient.Game.Aki.Data.Fight.FollowShooter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004064 RID: 16484
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_DroneBase.GA_Motor_DroneBase_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_Motor_DroneBase_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A582 RID: 173442 RVA: 0x009DD9CC File Offset: 0x009DBBCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_DroneBase_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_DroneBase.GA_Motor_DroneBase_C");
			}
			return GA_Motor_DroneBase_C._ClassPtr;
		}

		// Token: 0x0602A583 RID: 173443 RVA: 0x009DD9F0 File Offset: 0x009DBBF0
		public GA_Motor_DroneBase_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_DroneBase_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A584 RID: 173444 RVA: 0x009DDA18 File Offset: 0x009DBC18
		[NullableContext(1)]
		public GA_Motor_DroneBase_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_DroneBase_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x0602A585 RID: 173445 RVA: 0x009DDA4B File Offset: 0x009DBC4B
		// (set) Token: 0x0602A586 RID: 173446 RVA: 0x009DDA5B File Offset: 0x009DBC5B
		public unsafe int Drone_Entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_DroneBase_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_DroneBase_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170067CE RID: 26574
		// (get) Token: 0x0602A587 RID: 173447 RVA: 0x009DDA6C File Offset: 0x009DBC6C
		// (set) Token: 0x0602A588 RID: 173448 RVA: 0x009DDA80 File Offset: 0x009DBC80
		public unsafe BP_FollowShooterConfig_C FollowShooterConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_FollowShooterConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_DroneBase_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_DroneBase_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170067CF RID: 26575
		// (get) Token: 0x0602A589 RID: 173449 RVA: 0x009DDA95 File Offset: 0x009DBC95
		// (set) Token: 0x0602A58A RID: 173450 RVA: 0x009DDAA9 File Offset: 0x009DBCA9
		public unsafe AActor DroneEntity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_DroneBase_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_DroneBase_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602A58B RID: 173451 RVA: 0x009DDAC0 File Offset: 0x009DBCC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 删除Tags(ref TArray<FGameplayTag> Tags)
		{
			GA_Motor_DroneBase_C.__删除Tags_FunctionParams* ptr = stackalloc GA_Motor_DroneBase_C.__删除Tags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Motor_DroneBase_C.__删除Tags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_DroneBase_C.__删除Tags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = Tags;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Tags);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__删除Tags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = Tags;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Tags);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Motor_DroneBase_C.__删除Tags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A58C RID: 173452 RVA: 0x009DDB38 File Offset: 0x009DBD38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 添加Tags(ref TArray<FGameplayTag> Tags)
		{
			GA_Motor_DroneBase_C.__添加Tags_FunctionParams* ptr = stackalloc GA_Motor_DroneBase_C.__添加Tags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Motor_DroneBase_C.__添加Tags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_DroneBase_C.__添加Tags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = Tags;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Tags);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__添加Tags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = Tags;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Tags);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Motor_DroneBase_C.__添加Tags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A58D RID: 173453 RVA: 0x009DDBB0 File Offset: 0x009DBDB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 删除禁止瞄准Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__删除禁止瞄准Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A58E RID: 173454 RVA: 0x009DDBC4 File Offset: 0x009DBDC4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加禁止瞄准Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__添加禁止瞄准Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A58F RID: 173455 RVA: 0x009DDBD8 File Offset: 0x009DBDD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 校验浮游炮有效性(ref bool Valid)
		{
			GA_Motor_DroneBase_C.__校验浮游炮有效性_FunctionParams* ptr = stackalloc GA_Motor_DroneBase_C.__校验浮游炮有效性_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(GA_Motor_DroneBase_C.__校验浮游炮有效性_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_DroneBase_C.__校验浮游炮有效性_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Valid = Valid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__校验浮游炮有效性_NativeFunctionPtr, (void*)ptr);
			Valid = ptr->Valid;
		}

		// Token: 0x0602A590 RID: 173456 RVA: 0x009DDC27 File Offset: 0x009DBE27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 反转浮游炮()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__反转浮游炮_NativeFunctionPtr, null);
		}

		// Token: 0x0602A591 RID: 173457 RVA: 0x009DDC3B File Offset: 0x009DBE3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 关闭浮游炮()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__关闭浮游炮_NativeFunctionPtr, null);
		}

		// Token: 0x0602A592 RID: 173458 RVA: 0x009DDC4F File Offset: 0x009DBE4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 删除常驻挂点_Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__删除常驻挂点_Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A593 RID: 173459 RVA: 0x009DDC63 File Offset: 0x009DBE63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 添加常驻挂点Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__添加常驻挂点Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602A594 RID: 173460 RVA: 0x009DDC77 File Offset: 0x009DBE77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 开启浮游炮()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__开启浮游炮_NativeFunctionPtr, null);
		}

		// Token: 0x0602A595 RID: 173461 RVA: 0x009DDC8B File Offset: 0x009DBE8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_DroneBase_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A596 RID: 173462 RVA: 0x009DDC9F File Offset: 0x009DBE9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_DroneBase_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A597 RID: 173463 RVA: 0x009DDCB4 File Offset: 0x009DBEB4
		protected GA_Motor_DroneBase_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D9C RID: 89500
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_DroneBase.GA_Motor_DroneBase_C";

		// Token: 0x04015D9D RID: 89501
		private static IntPtr _ClassPtr;

		// Token: 0x04015D9E RID: 89502
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D9F RID: 89503
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DA0 RID: 89504
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DA1 RID: 89505
		internal new static int __PropertyOffset_3;

		// Token: 0x04015DA2 RID: 89506
		private static IntPtr __删除Tags_NativeFunctionPtr;

		// Token: 0x04015DA3 RID: 89507
		private static IntPtr __添加Tags_NativeFunctionPtr;

		// Token: 0x04015DA4 RID: 89508
		private static IntPtr __删除禁止瞄准Tag_NativeFunctionPtr;

		// Token: 0x04015DA5 RID: 89509
		private static IntPtr __添加禁止瞄准Tag_NativeFunctionPtr;

		// Token: 0x04015DA6 RID: 89510
		private static IntPtr __校验浮游炮有效性_NativeFunctionPtr;

		// Token: 0x04015DA7 RID: 89511
		private static IntPtr __反转浮游炮_NativeFunctionPtr;

		// Token: 0x04015DA8 RID: 89512
		private static IntPtr __关闭浮游炮_NativeFunctionPtr;

		// Token: 0x04015DA9 RID: 89513
		private static IntPtr __删除常驻挂点_Tag_NativeFunctionPtr;

		// Token: 0x04015DAA RID: 89514
		private static IntPtr __添加常驻挂点Tag_NativeFunctionPtr;

		// Token: 0x04015DAB RID: 89515
		private static IntPtr __开启浮游炮_NativeFunctionPtr;

		// Token: 0x04015DAC RID: 89516
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A37C RID: 41852
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __删除Tags_FunctionParams
		{
			// Token: 0x04032160 RID: 205152
			[FieldOffset(0)]
			public byte Tags;
		}

		// Token: 0x0200A37D RID: 41853
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __添加Tags_FunctionParams
		{
			// Token: 0x04032161 RID: 205153
			[FieldOffset(0)]
			public byte Tags;
		}

		// Token: 0x0200A37E RID: 41854
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __校验浮游炮有效性_FunctionParams
		{
			// Token: 0x04032162 RID: 205154
			[FieldOffset(0)]
			public bool Valid;
		}
	}
}
