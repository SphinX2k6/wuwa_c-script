using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004182 RID: 16770
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2_Attack.GA_WuYinQu_HuangShiGaoDi2_Attack_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1536)]
	public class GA_WuYinQu_HuangShiGaoDi2_Attack_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6D1 RID: 177873 RVA: 0x00A00599 File Offset: 0x009FE799
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_HuangShiGaoDi2_Attack_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2_Attack.GA_WuYinQu_HuangShiGaoDi2_Attack_C");
			}
			return GA_WuYinQu_HuangShiGaoDi2_Attack_C._ClassPtr;
		}

		// Token: 0x0602B6D2 RID: 177874 RVA: 0x00A005C0 File Offset: 0x009FE7C0
		public GA_WuYinQu_HuangShiGaoDi2_Attack_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi2_Attack_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6D3 RID: 177875 RVA: 0x00A005E8 File Offset: 0x009FE7E8
		public GA_WuYinQu_HuangShiGaoDi2_Attack_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi2_Attack_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B1A RID: 27418
		// (get) Token: 0x0602B6D4 RID: 177876 RVA: 0x00A0061B File Offset: 0x009FE81B
		// (set) Token: 0x0602B6D5 RID: 177877 RVA: 0x00A0062B File Offset: 0x009FE82B
		public unsafe int 落雷次数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2_Attack_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2_Attack_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B1B RID: 27419
		// (get) Token: 0x0602B6D6 RID: 177878 RVA: 0x00A0063C File Offset: 0x009FE83C
		// (set) Token: 0x0602B6D7 RID: 177879 RVA: 0x00A00650 File Offset: 0x009FE850
		public unsafe string 子弹_ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_HuangShiGaoDi2_Attack_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GA_WuYinQu_HuangShiGaoDi2_Attack_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x0602B6D8 RID: 177880 RVA: 0x00A00665 File Offset: 0x009FE865
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi2_Attack_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6D9 RID: 177881 RVA: 0x00A00679 File Offset: 0x009FE879
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi2_Attack_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6DA RID: 177882 RVA: 0x00A0068E File Offset: 0x009FE88E
		protected GA_WuYinQu_HuangShiGaoDi2_Attack_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401699E RID: 92574
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2_Attack.GA_WuYinQu_HuangShiGaoDi2_Attack_C";

		// Token: 0x0401699F RID: 92575
		private static IntPtr _ClassPtr;

		// Token: 0x040169A0 RID: 92576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169A1 RID: 92577
		internal new static int __PropertyOffset_1;

		// Token: 0x040169A2 RID: 92578
		internal new static int __PropertyOffset_2;

		// Token: 0x040169A3 RID: 92579
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
