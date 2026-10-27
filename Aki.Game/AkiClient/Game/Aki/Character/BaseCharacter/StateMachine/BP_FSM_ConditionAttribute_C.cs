using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.StateMachine
{
	// Token: 0x0200434E RID: 17230
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttribute.BP_FSM_ConditionAttribute_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_FSM_ConditionAttribute_C : UKuroStateMachineConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CAE8 RID: 183016 RVA: 0x00A25A70 File Offset: 0x00A23C70
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FSM_ConditionAttribute_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttribute.BP_FSM_ConditionAttribute_C");
			}
			return BP_FSM_ConditionAttribute_C._ClassPtr;
		}

		// Token: 0x0602CAE9 RID: 183017 RVA: 0x00A25A94 File Offset: 0x00A23C94
		public BP_FSM_ConditionAttribute_C() : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionAttribute_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CAEA RID: 183018 RVA: 0x00A25ABC File Offset: 0x00A23CBC
		[NullableContext(1)]
		public BP_FSM_ConditionAttribute_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FSM_ConditionAttribute_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007070 RID: 28784
		// (get) Token: 0x0602CAEB RID: 183019 RVA: 0x00A25AF0 File Offset: 0x00A23CF0
		// (set) Token: 0x0602CAEC RID: 183020 RVA: 0x00A25B29 File Offset: 0x00A23D29
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<EAttributeType>, FFloatRange> Attributes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EAttributeType>, FFloatRange> result;
				if ((result = this._Attributes) == null)
				{
					result = (this._Attributes = new TMap<TEnumAsByte<EAttributeType>, FFloatRange>(base.NativePtr + (IntPtr)BP_FSM_ConditionAttribute_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Attributes.CopyAssign(value);
			}
		}

		// Token: 0x0602CAED RID: 183021 RVA: 0x00A25B37 File Offset: 0x00A23D37
		protected BP_FSM_ConditionAttribute_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178E1 RID: 96481
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/StateMachine/BP_FSM_ConditionAttribute.BP_FSM_ConditionAttribute_C";

		// Token: 0x040178E2 RID: 96482
		private static IntPtr _ClassPtr;

		// Token: 0x040178E3 RID: 96483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178E4 RID: 96484
		internal static int __PropertyOffset_0;

		// Token: 0x040178E5 RID: 96485
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<EAttributeType>, FFloatRange> _Attributes;
	}
}
