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
	// Token: 0x0200414A RID: 16714
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Shachong.GA_Motor_Shachong_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1548)]
	public class GA_Motor_Shachong_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B17D RID: 176509 RVA: 0x009F5B05 File Offset: 0x009F3D05
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Shachong_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Shachong.GA_Motor_Shachong_C");
			}
			return GA_Motor_Shachong_C._ClassPtr;
		}

		// Token: 0x0602B17E RID: 176510 RVA: 0x009F5B2C File Offset: 0x009F3D2C
		public GA_Motor_Shachong_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Shachong_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B17F RID: 176511 RVA: 0x009F5B54 File Offset: 0x009F3D54
		[NullableContext(1)]
		public GA_Motor_Shachong_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Shachong_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006A1B RID: 27163
		// (get) Token: 0x0602B180 RID: 176512 RVA: 0x009F5B87 File Offset: 0x009F3D87
		// (set) Token: 0x0602B181 RID: 176513 RVA: 0x009F5B9B File Offset: 0x009F3D9B
		[Nullable(2)]
		public unsafe BP_Motor_BaseVehicle_C 摩托车对象缓存
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_Motor_BaseVehicle_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Shachong_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Shachong_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006A1C RID: 27164
		// (get) Token: 0x0602B182 RID: 176514 RVA: 0x009F5BB0 File Offset: 0x009F3DB0
		// (set) Token: 0x0602B183 RID: 176515 RVA: 0x009F5BC0 File Offset: 0x009F3DC0
		public unsafe int 摩托车对象entity_Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006A1D RID: 27165
		// (get) Token: 0x0602B184 RID: 176516 RVA: 0x009F5BD1 File Offset: 0x009F3DD1
		// (set) Token: 0x0602B185 RID: 176517 RVA: 0x009F5BE5 File Offset: 0x009F3DE5
		public unsafe FVector In_Out_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006A1E RID: 27166
		// (get) Token: 0x0602B186 RID: 176518 RVA: 0x009F5BFA File Offset: 0x009F3DFA
		// (set) Token: 0x0602B187 RID: 176519 RVA: 0x009F5C0E File Offset: 0x009F3E0E
		public unsafe FRotator Out_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Shachong_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x0602B188 RID: 176520 RVA: 0x009F5C23 File Offset: 0x009F3E23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Shachong_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B189 RID: 176521 RVA: 0x009F5C37 File Offset: 0x009F3E37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Shachong_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B18A RID: 176522 RVA: 0x009F5C4C File Offset: 0x009F3E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Shachong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Shachong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602B18B RID: 176523 RVA: 0x009F5C94 File Offset: 0x009F3E94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Shachong_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Shachong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Shachong_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602B18C RID: 176524 RVA: 0x009F5CDB File Offset: 0x009F3EDB
		protected GA_Motor_Shachong_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040165DB RID: 91611
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_Motor_Shachong.GA_Motor_Shachong_C";

		// Token: 0x040165DC RID: 91612
		private static IntPtr _ClassPtr;

		// Token: 0x040165DD RID: 91613
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040165DE RID: 91614
		internal new static int __PropertyOffset_1;

		// Token: 0x040165DF RID: 91615
		internal new static int __PropertyOffset_2;

		// Token: 0x040165E0 RID: 91616
		internal new static int __PropertyOffset_3;

		// Token: 0x040165E1 RID: 91617
		internal static int __PropertyOffset_4;

		// Token: 0x040165E2 RID: 91618
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x040165E3 RID: 91619
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A47F RID: 42111
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x040322D1 RID: 205521
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
