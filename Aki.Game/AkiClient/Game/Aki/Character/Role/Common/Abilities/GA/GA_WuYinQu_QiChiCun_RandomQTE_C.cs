using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Abilities.GA
{
	// Token: 0x02004186 RID: 16774
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_QiChiCun_RandomQTE.GA_WuYinQu_QiChiCun_RandomQTE_C")]
	[UnrealStructLayout(1520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1520)]
	public class GA_WuYinQu_QiChiCun_RandomQTE_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602B6FF RID: 177919 RVA: 0x00A00AC1 File Offset: 0x009FECC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_WuYinQu_QiChiCun_RandomQTE_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_QiChiCun_RandomQTE.GA_WuYinQu_QiChiCun_RandomQTE_C");
			}
			return GA_WuYinQu_QiChiCun_RandomQTE_C._ClassPtr;
		}

		// Token: 0x0602B700 RID: 177920 RVA: 0x00A00AE8 File Offset: 0x009FECE8
		public GA_WuYinQu_QiChiCun_RandomQTE_C() : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_QiChiCun_RandomQTE_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602B701 RID: 177921 RVA: 0x00A00B10 File Offset: 0x009FED10
		[NullableContext(1)]
		public GA_WuYinQu_QiChiCun_RandomQTE_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_WuYinQu_QiChiCun_RandomQTE_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B23 RID: 27427
		// (get) Token: 0x0602B702 RID: 177922 RVA: 0x00A00B43 File Offset: 0x009FED43
		// (set) Token: 0x0602B703 RID: 177923 RVA: 0x00A00B53 File Offset: 0x009FED53
		public unsafe float 随机左右
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_QiChiCun_RandomQTE_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_QiChiCun_RandomQTE_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006B24 RID: 27428
		// (get) Token: 0x0602B704 RID: 177924 RVA: 0x00A00B64 File Offset: 0x009FED64
		// (set) Token: 0x0602B705 RID: 177925 RVA: 0x00A00B74 File Offset: 0x009FED74
		public unsafe float 随机上下
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_WuYinQu_QiChiCun_RandomQTE_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_WuYinQu_QiChiCun_RandomQTE_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B706 RID: 177926 RVA: 0x00A00B85 File Offset: 0x009FED85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_WuYinQu_QiChiCun_RandomQTE_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602B707 RID: 177927 RVA: 0x00A00B99 File Offset: 0x009FED99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_WuYinQu_QiChiCun_RandomQTE_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602B708 RID: 177928 RVA: 0x00A00BAE File Offset: 0x009FEDAE
		protected GA_WuYinQu_QiChiCun_RandomQTE_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040169B9 RID: 92601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Abilities/GA/GA_WuYinQu_QiChiCun_RandomQTE.GA_WuYinQu_QiChiCun_RandomQTE_C";

		// Token: 0x040169BA RID: 92602
		private static IntPtr _ClassPtr;

		// Token: 0x040169BB RID: 92603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040169BC RID: 92604
		internal new static int __PropertyOffset_1;

		// Token: 0x040169BD RID: 92605
		internal new static int __PropertyOffset_2;

		// Token: 0x040169BE RID: 92606
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;
	}
}
