using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004377 RID: 17271
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionAttributeRate_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC16 RID: 183318 RVA: 0x00A27BF5 File Offset: 0x00A25DF5
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionAttributeRate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C");
			}
			return BP_SM_ConditionAttributeRate_C._ClassPtr;
		}

		// Token: 0x0602CC17 RID: 183319 RVA: 0x00A27C1C File Offset: 0x00A25E1C
		public BP_SM_ConditionAttributeRate_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttributeRate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC18 RID: 183320 RVA: 0x00A27C44 File Offset: 0x00A25E44
		[NullableContext(1)]
		public BP_SM_ConditionAttributeRate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttributeRate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070B5 RID: 28853
		// (get) Token: 0x0602CC19 RID: 183321 RVA: 0x00A27C77 File Offset: 0x00A25E77
		// (set) Token: 0x0602CC1A RID: 183322 RVA: 0x00A27C8B File Offset: 0x00A25E8B
		public unsafe TEnumAsByte<EAttributeType> 分子
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070B6 RID: 28854
		// (get) Token: 0x0602CC1B RID: 183323 RVA: 0x00A27CA0 File Offset: 0x00A25EA0
		// (set) Token: 0x0602CC1C RID: 183324 RVA: 0x00A27CB4 File Offset: 0x00A25EB4
		public unsafe TEnumAsByte<EAttributeType> 分母
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070B7 RID: 28855
		// (get) Token: 0x0602CC1D RID: 183325 RVA: 0x00A27CC9 File Offset: 0x00A25EC9
		// (set) Token: 0x0602CC1E RID: 183326 RVA: 0x00A27CD9 File Offset: 0x00A25ED9
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170070B8 RID: 28856
		// (get) Token: 0x0602CC1F RID: 183327 RVA: 0x00A27CEA File Offset: 0x00A25EEA
		// (set) Token: 0x0602CC20 RID: 183328 RVA: 0x00A27CFA File Offset: 0x00A25EFA
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x0602CC21 RID: 183329 RVA: 0x00A27D0B File Offset: 0x00A25F0B
		protected BP_SM_ConditionAttributeRate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179AD RID: 96685
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C";

		// Token: 0x040179AE RID: 96686
		private static IntPtr _ClassPtr;

		// Token: 0x040179AF RID: 96687
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179B0 RID: 96688
		internal static int __PropertyOffset_0;

		// Token: 0x040179B1 RID: 96689
		internal static int __PropertyOffset_1;

		// Token: 0x040179B2 RID: 96690
		internal static int __PropertyOffset_2;

		// Token: 0x040179B3 RID: 96691
		internal static int __PropertyOffset_3;
	}
}
