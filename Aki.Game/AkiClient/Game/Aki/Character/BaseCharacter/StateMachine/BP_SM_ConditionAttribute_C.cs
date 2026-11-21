using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x02003399 RID: 13209
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 68)]
	public class BP_SM_ConditionAttribute_C : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021840 RID: 137280 RVA: 0x00962B68 File Offset: 0x00960D68
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SM_ConditionAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C");
			}
			return BP_SM_ConditionAttribute_C._ClassPtr;
		}

		// Token: 0x06021841 RID: 137281 RVA: 0x00962B8C File Offset: 0x00960D8C
		public BP_SM_ConditionAttribute_C() : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021842 RID: 137282 RVA: 0x00962BB4 File Offset: 0x00960DB4
		[NullableContext(1)]
		public BP_SM_ConditionAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SM_ConditionAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x06021843 RID: 137283 RVA: 0x00962BE7 File Offset: 0x00960DE7
		// (set) Token: 0x06021844 RID: 137284 RVA: 0x00962BFB File Offset: 0x00960DFB
		public unsafe TEnumAsByte<EAttributeType> 属性类型
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_属性类型);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_属性类型) = value;
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x06021845 RID: 137285 RVA: 0x00962C10 File Offset: 0x00960E10
		// (set) Token: 0x06021846 RID: 137286 RVA: 0x00962C20 File Offset: 0x00960E20
		public unsafe int Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x170044BD RID: 17597
		// (get) Token: 0x06021847 RID: 137287 RVA: 0x00962C31 File Offset: 0x00960E31
		// (set) Token: 0x06021848 RID: 137288 RVA: 0x00962C41 File Offset: 0x00960E41
		public unsafe int Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SM_ConditionAttribute_C.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06021849 RID: 137289 RVA: 0x00962C52 File Offset: 0x00960E52
		protected BP_SM_ConditionAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012535 RID: 75061
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_SM_ConditionAttribute.BP_SM_ConditionAttribute_C";

		// Token: 0x04012536 RID: 75062
		private static IntPtr _ClassPtr;

		// Token: 0x04012537 RID: 75063
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012538 RID: 75064
		internal static int __PropertyOffset_属性类型;

		// Token: 0x04012539 RID: 75065
		internal static int __PropertyOffset_Min;

		// Token: 0x0401253A RID: 75066
		internal static int __PropertyOffset_Max;
	}
}
