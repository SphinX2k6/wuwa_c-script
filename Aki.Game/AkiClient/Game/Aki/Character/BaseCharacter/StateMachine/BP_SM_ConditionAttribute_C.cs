using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02004378 RID: 17272
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionAttribute_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CC22 RID: 183330 RVA: 0x00A27D14 File Offset: 0x00A25F14
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C");
			}
			return BP_SM_ConditionAttribute_C._ClassPtr;
		}

		// Token: 0x0602CC23 RID: 183331 RVA: 0x00A27D38 File Offset: 0x00A25F38
		public BP_SM_ConditionAttribute_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CC24 RID: 183332 RVA: 0x00A27D60 File Offset: 0x00A25F60
		[NullableContext(1)]
		public BP_SM_ConditionAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170070B9 RID: 28857
		// (get) Token: 0x0602CC25 RID: 183333 RVA: 0x00A27D93 File Offset: 0x00A25F93
		// (set) Token: 0x0602CC26 RID: 183334 RVA: 0x00A27DA7 File Offset: 0x00A25FA7
		public unsafe TEnumAsByte<EAttributeType> 属性类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170070BA RID: 28858
		// (get) Token: 0x0602CC27 RID: 183335 RVA: 0x00A27DBC File Offset: 0x00A25FBC
		// (set) Token: 0x0602CC28 RID: 183336 RVA: 0x00A27DCC File Offset: 0x00A25FCC
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170070BB RID: 28859
		// (get) Token: 0x0602CC29 RID: 183337 RVA: 0x00A27DDD File Offset: 0x00A25FDD
		// (set) Token: 0x0602CC2A RID: 183338 RVA: 0x00A27DED File Offset: 0x00A25FED
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CC2B RID: 183339 RVA: 0x00A27DFE File Offset: 0x00A25FFE
		protected BP_SM_ConditionAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040179B4 RID: 96692
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C";

		// Token: 0x040179B5 RID: 96693
		private static IntPtr _ClassPtr;

		// Token: 0x040179B6 RID: 96694
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040179B7 RID: 96695
		internal static int __PropertyOffset_0;

		// Token: 0x040179B8 RID: 96696
		internal static int __PropertyOffset_1;

		// Token: 0x040179B9 RID: 96697
		internal static int __PropertyOffset_2;
	}
}
