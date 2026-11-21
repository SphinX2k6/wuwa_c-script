using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F4C RID: 32588
	public class TMotorRadioOperationRestrictionUnion
	{
		// Token: 0x1700F2AB RID: 62123
		// (get) Token: 0x0603AC2B RID: 240683 RVA: 0x007E6758 File Offset: 0x007E4958
		// (set) Token: 0x0603AC2C RID: 240684 RVA: 0x007E6760 File Offset: 0x007E4960
		public TMotorRadioOperationRestriction Type { get; set; }

		// Token: 0x1700F2AC RID: 62124
		// (get) Token: 0x0603AC2D RID: 240685 RVA: 0x007E6769 File Offset: 0x007E4969
		// (set) Token: 0x0603AC2E RID: 240686 RVA: 0x007E6771 File Offset: 0x007E4971
		public object Value { get; set; }

		// Token: 0x0603AC2F RID: 240687 RVA: 0x007E677A File Offset: 0x007E497A
		public TMotorRadioOperationRestrictionUnion()
		{
			this.Type = TMotorRadioOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC30 RID: 240688 RVA: 0x007E6790 File Offset: 0x007E4990
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC31 RID: 240689 RVA: 0x007E67A2 File Offset: 0x007E49A2
		public IDisableAllMotorRadioOperationT AsIDisableAllMotorRadioOperation()
		{
			return this.As<IDisableAllMotorRadioOperationT>();
		}

		// Token: 0x0603AC32 RID: 240690 RVA: 0x007E67AA File Offset: 0x007E49AA
		public static TMotorRadioOperationRestrictionUnion FromIDisableAllMotorRadioOperation(IDisableAllMotorRadioOperationT _idisableallmotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation,
				Value = _idisableallmotorradiooperation
			};
		}

		// Token: 0x0603AC33 RID: 240691 RVA: 0x007E67BF File Offset: 0x007E49BF
		public IDisableInRangeMotorRadioOperationT AsIDisableInRangeMotorRadioOperation()
		{
			return this.As<IDisableInRangeMotorRadioOperationT>();
		}

		// Token: 0x0603AC34 RID: 240692 RVA: 0x007E67C7 File Offset: 0x007E49C7
		public static TMotorRadioOperationRestrictionUnion FromIDisableInRangeMotorRadioOperation(IDisableInRangeMotorRadioOperationT _idisableinrangemotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IDisableInRangeMotorRadioOperation,
				Value = _idisableinrangemotorradiooperation
			};
		}

		// Token: 0x0603AC35 RID: 240693 RVA: 0x007E67DC File Offset: 0x007E49DC
		public IEnableAllMotorRadioOperationT AsIEnableAllMotorRadioOperation()
		{
			return this.As<IEnableAllMotorRadioOperationT>();
		}

		// Token: 0x0603AC36 RID: 240694 RVA: 0x007E67E4 File Offset: 0x007E49E4
		public static TMotorRadioOperationRestrictionUnion FromIEnableAllMotorRadioOperation(IEnableAllMotorRadioOperationT _ienableallmotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation,
				Value = _ienableallmotorradiooperation
			};
		}

		// Token: 0x0603AC37 RID: 240695 RVA: 0x007E67F9 File Offset: 0x007E49F9
		public IEnableInRangeMotorRadioOperationT AsIEnableInRangeMotorRadioOperation()
		{
			return this.As<IEnableInRangeMotorRadioOperationT>();
		}

		// Token: 0x0603AC38 RID: 240696 RVA: 0x007E6801 File Offset: 0x007E4A01
		public static TMotorRadioOperationRestrictionUnion FromIEnableInRangeMotorRadioOperation(IEnableInRangeMotorRadioOperationT _ienableinrangemotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IEnableInRangeMotorRadioOperation,
				Value = _ienableinrangemotorradiooperation
			};
		}

		// Token: 0x0603AC39 RID: 240697 RVA: 0x007E6818 File Offset: 0x007E4A18
		public static int Pack(FlatBufferBuilder builder, TMotorRadioOperationRestrictionUnion _o)
		{
			switch (_o.Type)
			{
			case TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation:
				return IDisableAllMotorRadioOperation.Pack(builder, _o.AsIDisableAllMotorRadioOperation()).Value;
			case TMotorRadioOperationRestriction.IDisableInRangeMotorRadioOperation:
				return IDisableInRangeMotorRadioOperation.Pack(builder, _o.AsIDisableInRangeMotorRadioOperation()).Value;
			case TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation:
				return IEnableAllMotorRadioOperation.Pack(builder, _o.AsIEnableAllMotorRadioOperation()).Value;
			case TMotorRadioOperationRestriction.IEnableInRangeMotorRadioOperation:
				return IEnableInRangeMotorRadioOperation.Pack(builder, _o.AsIEnableInRangeMotorRadioOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
