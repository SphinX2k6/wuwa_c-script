using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2B RID: 27435
	public class IMotorRadioOperationRestriction_UnionUnion
	{
		// Token: 0x1700CBE2 RID: 52194
		// (get) Token: 0x0603026F RID: 197231 RVA: 0x0068B821 File Offset: 0x00689A21
		// (set) Token: 0x06030270 RID: 197232 RVA: 0x0068B829 File Offset: 0x00689A29
		public IMotorRadioOperationRestriction_Union Type { get; set; }

		// Token: 0x1700CBE3 RID: 52195
		// (get) Token: 0x06030271 RID: 197233 RVA: 0x0068B832 File Offset: 0x00689A32
		// (set) Token: 0x06030272 RID: 197234 RVA: 0x0068B83A File Offset: 0x00689A3A
		public object Value { get; set; }

		// Token: 0x06030273 RID: 197235 RVA: 0x0068B843 File Offset: 0x00689A43
		public IMotorRadioOperationRestriction_UnionUnion()
		{
			this.Type = IMotorRadioOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06030274 RID: 197236 RVA: 0x0068B859 File Offset: 0x00689A59
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06030275 RID: 197237 RVA: 0x0068B86B File Offset: 0x00689A6B
		public IMotorRadioOperationRestrictionT AsIMotorRadioOperationRestriction()
		{
			return this.As<IMotorRadioOperationRestrictionT>();
		}

		// Token: 0x06030276 RID: 197238 RVA: 0x0068B873 File Offset: 0x00689A73
		public static IMotorRadioOperationRestriction_UnionUnion FromIMotorRadioOperationRestriction(IMotorRadioOperationRestrictionT _imotorradiooperationrestriction)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IMotorRadioOperationRestriction,
				Value = _imotorradiooperationrestriction
			};
		}

		// Token: 0x06030277 RID: 197239 RVA: 0x0068B888 File Offset: 0x00689A88
		public IEnableAllMotorRadioOperationT AsIEnableAllMotorRadioOperation()
		{
			return this.As<IEnableAllMotorRadioOperationT>();
		}

		// Token: 0x06030278 RID: 197240 RVA: 0x0068B890 File Offset: 0x00689A90
		public static IMotorRadioOperationRestriction_UnionUnion FromIEnableAllMotorRadioOperation(IEnableAllMotorRadioOperationT _ienableallmotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IEnableAllMotorRadioOperation,
				Value = _ienableallmotorradiooperation
			};
		}

		// Token: 0x06030279 RID: 197241 RVA: 0x0068B8A5 File Offset: 0x00689AA5
		public IDisableAllMotorRadioOperationT AsIDisableAllMotorRadioOperation()
		{
			return this.As<IDisableAllMotorRadioOperationT>();
		}

		// Token: 0x0603027A RID: 197242 RVA: 0x0068B8AD File Offset: 0x00689AAD
		public static IMotorRadioOperationRestriction_UnionUnion FromIDisableAllMotorRadioOperation(IDisableAllMotorRadioOperationT _idisableallmotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IDisableAllMotorRadioOperation,
				Value = _idisableallmotorradiooperation
			};
		}

		// Token: 0x0603027B RID: 197243 RVA: 0x0068B8C4 File Offset: 0x00689AC4
		public static int Pack(FlatBufferBuilder builder, IMotorRadioOperationRestriction_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorRadioOperationRestriction_Union.IMotorRadioOperationRestriction:
				return IMotorRadioOperationRestriction.Pack(builder, _o.AsIMotorRadioOperationRestriction()).Value;
			case IMotorRadioOperationRestriction_Union.IEnableAllMotorRadioOperation:
				return IEnableAllMotorRadioOperation.Pack(builder, _o.AsIEnableAllMotorRadioOperation()).Value;
			case IMotorRadioOperationRestriction_Union.IDisableAllMotorRadioOperation:
				return IDisableAllMotorRadioOperation.Pack(builder, _o.AsIDisableAllMotorRadioOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
