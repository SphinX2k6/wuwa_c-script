using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004183 RID: 16771
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2__Environment.GA_WuYinQu_HuangShiGaoDi2__Environment_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_WuYinQu_HuangShiGaoDi2__Environment_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6DB RID: 177883 RVA: 0x00A00697 File Offset: 0x009FE897
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_HuangShiGaoDi2__Environment_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2__Environment.GA_WuYinQu_HuangShiGaoDi2__Environment_C");
			}
			return GA_WuYinQu_HuangShiGaoDi2__Environment_C._ClassPtr;
		}

		// Token: 0x0602B6DC RID: 177884 RVA: 0x00A006BC File Offset: 0x009FE8BC
		public GA_WuYinQu_HuangShiGaoDi2__Environment_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi2__Environment_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B6DD RID: 177885 RVA: 0x00A006E4 File Offset: 0x009FE8E4
		[NullableContext(1)]
		public GA_WuYinQu_HuangShiGaoDi2__Environment_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_HuangShiGaoDi2__Environment_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B1C RID: 27420
		// (get) Token: 0x0602B6DE RID: 177886 RVA: 0x00A00717 File Offset: 0x009FE917
		// (set) Token: 0x0602B6DF RID: 177887 RVA: 0x00A00727 File Offset: 0x009FE927
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2__Environment_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2__Environment_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B1D RID: 27421
		// (get) Token: 0x0602B6E0 RID: 177888 RVA: 0x00A00738 File Offset: 0x009FE938
		// (set) Token: 0x0602B6E1 RID: 177889 RVA: 0x00A00748 File Offset: 0x009FE948
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2__Environment_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_HuangShiGaoDi2__Environment_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B6E2 RID: 177890 RVA: 0x00A00759 File Offset: 0x009FE959
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi2__Environment_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B6E3 RID: 177891 RVA: 0x00A0076D File Offset: 0x009FE96D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_HuangShiGaoDi2__Environment_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B6E4 RID: 177892 RVA: 0x00A00782 File Offset: 0x009FE982
		protected GA_WuYinQu_HuangShiGaoDi2__Environment_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169A4 RID: 92580
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_HuangShiGaoDi2__Environment.GA_WuYinQu_HuangShiGaoDi2__Environment_C";

		// Token: 0x040169A5 RID: 92581
		private static IntPtr _ClassPtr;

		// Token: 0x040169A6 RID: 92582
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169A7 RID: 92583
		internal new static int __PropertyOffset_1;

		// Token: 0x040169A8 RID: 92584
		internal new static int __PropertyOffset_2;

		// Token: 0x040169A9 RID: 92585
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
