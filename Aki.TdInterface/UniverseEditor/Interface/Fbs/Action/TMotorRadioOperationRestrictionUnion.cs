using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007723 RID: 30499
	public class TMotorRadioOperationRestrictionUnion
	{
		// Token: 0x1700E65B RID: 58971
		// (get) Token: 0x060376F4 RID: 227060 RVA: 0x0078185A File Offset: 0x0077FA5A
		// (set) Token: 0x060376F5 RID: 227061 RVA: 0x00781862 File Offset: 0x0077FA62
		public TMotorRadioOperationRestriction Type { get; set; }

		// Token: 0x1700E65C RID: 58972
		// (get) Token: 0x060376F6 RID: 227062 RVA: 0x0078186B File Offset: 0x0077FA6B
		// (set) Token: 0x060376F7 RID: 227063 RVA: 0x00781873 File Offset: 0x0077FA73
		public object Value { get; set; }

		// Token: 0x060376F8 RID: 227064 RVA: 0x0078187C File Offset: 0x0077FA7C
		public TMotorRadioOperationRestrictionUnion()
		{
			this.Type = TMotorRadioOperationRestriction.NONE;
			this.Value = null;
		}

		// Token: 0x060376F9 RID: 227065 RVA: 0x00781892 File Offset: 0x0077FA92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060376FA RID: 227066 RVA: 0x007818A4 File Offset: 0x0077FAA4
		public IDisableAllMotorRadioOperationT AsIDisableAllMotorRadioOperation()
		{
			return this.As<IDisableAllMotorRadioOperationT>();
		}

		// Token: 0x060376FB RID: 227067 RVA: 0x007818AC File Offset: 0x0077FAAC
		public static TMotorRadioOperationRestrictionUnion FromIDisableAllMotorRadioOperation(IDisableAllMotorRadioOperationT _idisableallmotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation,
				Value = _idisableallmotorradiooperation
			};
		}

		// Token: 0x060376FC RID: 227068 RVA: 0x007818C1 File Offset: 0x0077FAC1
		public IEnableAllMotorRadioOperationT AsIEnableAllMotorRadioOperation()
		{
			return this.As<IEnableAllMotorRadioOperationT>();
		}

		// Token: 0x060376FD RID: 227069 RVA: 0x007818C9 File Offset: 0x0077FAC9
		public static TMotorRadioOperationRestrictionUnion FromIEnableAllMotorRadioOperation(IEnableAllMotorRadioOperationT _ienableallmotorradiooperation)
		{
			return new TMotorRadioOperationRestrictionUnion
			{
				Type = TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation,
				Value = _ienableallmotorradiooperation
			};
		}

		// Token: 0x060376FE RID: 227070 RVA: 0x007818E0 File Offset: 0x0077FAE0
		public static int Pack(FlatBufferBuilder builder, TMotorRadioOperationRestrictionUnion _o)
		{
			TMotorRadioOperationRestriction type = _o.Type;
			if (type == TMotorRadioOperationRestriction.IDisableAllMotorRadioOperation)
			{
				return IDisableAllMotorRadioOperation.Pack(builder, _o.AsIDisableAllMotorRadioOperation()).Value;
			}
			if (type != TMotorRadioOperationRestriction.IEnableAllMotorRadioOperation)
			{
				return 0;
			}
			return IEnableAllMotorRadioOperation.Pack(builder, _o.AsIEnableAllMotorRadioOperation()).Value;
		}
	}
}
