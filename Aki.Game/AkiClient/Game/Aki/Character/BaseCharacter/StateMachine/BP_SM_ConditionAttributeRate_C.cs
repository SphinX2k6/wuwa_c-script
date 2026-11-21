using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003398 RID: 13208
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionAttributeRate_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021834 RID: 137268 RVA: 0x00962A49 File Offset: 0x00960C49
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionAttributeRate_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C");
			}
			return BP_SM_ConditionAttributeRate_C._ClassPtr;
		}

		// Token: 0x06021835 RID: 137269 RVA: 0x00962A70 File Offset: 0x00960C70
		public BP_SM_ConditionAttributeRate_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttributeRate_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021836 RID: 137270 RVA: 0x00962A98 File Offset: 0x00960C98
		[NullableContext(1)]
		public BP_SM_ConditionAttributeRate_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttributeRate_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x06021837 RID: 137271 RVA: 0x00962ACB File Offset: 0x00960CCB
		// (set) Token: 0x06021838 RID: 137272 RVA: 0x00962ADF File Offset: 0x00960CDF
		public unsafe TEnumAsByte<EAttributeType> 分子
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_分子);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_分子) = value;
			}
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x06021839 RID: 137273 RVA: 0x00962AF4 File Offset: 0x00960CF4
		// (set) Token: 0x0602183A RID: 137274 RVA: 0x00962B08 File Offset: 0x00960D08
		public unsafe TEnumAsByte<EAttributeType> 分母
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_分母);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_分母) = value;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x0602183B RID: 137275 RVA: 0x00962B1D File Offset: 0x00960D1D
		// (set) Token: 0x0602183C RID: 137276 RVA: 0x00962B2D File Offset: 0x00960D2D
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x0602183D RID: 137277 RVA: 0x00962B3E File Offset: 0x00960D3E
		// (set) Token: 0x0602183E RID: 137278 RVA: 0x00962B4E File Offset: 0x00960D4E
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttributeRate_C.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x0602183F RID: 137279 RVA: 0x00962B5F File Offset: 0x00960D5F
		protected BP_SM_ConditionAttributeRate_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401252E RID: 75054
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttributeRate.BP_SM_ConditionAttributeRate_C";

		// Token: 0x0401252F RID: 75055
		private static IntPtr _ClassPtr;

		// Token: 0x04012530 RID: 75056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012531 RID: 75057
		internal static int __PropertyOffset_分子;

		// Token: 0x04012532 RID: 75058
		internal static int __PropertyOffset_分母;

		// Token: 0x04012533 RID: 75059
		internal static int __PropertyOffset_Min;

		// Token: 0x04012534 RID: 75060
		internal static int __PropertyOffset_Max;
	}
}
