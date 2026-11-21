using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FD RID: 26621
	public class IAlertValueSpeedChangeType_UnionUnion
	{
		// Token: 0x1700C3B1 RID: 50097
		// (get) Token: 0x0602D787 RID: 186247 RVA: 0x00639B61 File Offset: 0x00637D61
		// (set) Token: 0x0602D788 RID: 186248 RVA: 0x00639B69 File Offset: 0x00637D69
		public IAlertValueSpeedChangeType_Union Type { get; set; }

		// Token: 0x1700C3B2 RID: 50098
		// (get) Token: 0x0602D789 RID: 186249 RVA: 0x00639B72 File Offset: 0x00637D72
		// (set) Token: 0x0602D78A RID: 186250 RVA: 0x00639B7A File Offset: 0x00637D7A
		public object Value { get; set; }

		// Token: 0x0602D78B RID: 186251 RVA: 0x00639B83 File Offset: 0x00637D83
		public IAlertValueSpeedChangeType_UnionUnion()
		{
			this.Type = IAlertValueSpeedChangeType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D78C RID: 186252 RVA: 0x00639B99 File Offset: 0x00637D99
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D78D RID: 186253 RVA: 0x00639BAB File Offset: 0x00637DAB
		public IAlertValueSpeedChangeTypeT AsIAlertValueSpeedChangeType()
		{
			return this.As<IAlertValueSpeedChangeTypeT>();
		}

		// Token: 0x0602D78E RID: 186254 RVA: 0x00639BB3 File Offset: 0x00637DB3
		public static IAlertValueSpeedChangeType_UnionUnion FromIAlertValueSpeedChangeType(IAlertValueSpeedChangeTypeT _ialertvaluespeedchangetype)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.IAlertValueSpeedChangeType,
				Value = _ialertvaluespeedchangetype
			};
		}

		// Token: 0x0602D78F RID: 186255 RVA: 0x00639BC8 File Offset: 0x00637DC8
		public IAddOrSubAlertValueChangeSpeedT AsIAddOrSubAlertValueChangeSpeed()
		{
			return this.As<IAddOrSubAlertValueChangeSpeedT>();
		}

		// Token: 0x0602D790 RID: 186256 RVA: 0x00639BD0 File Offset: 0x00637DD0
		public static IAlertValueSpeedChangeType_UnionUnion FromIAddOrSubAlertValueChangeSpeed(IAddOrSubAlertValueChangeSpeedT _iaddorsubalertvaluechangespeed)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.IAddOrSubAlertValueChangeSpeed,
				Value = _iaddorsubalertvaluechangespeed
			};
		}

		// Token: 0x0602D791 RID: 186257 RVA: 0x00639BE5 File Offset: 0x00637DE5
		public ICustomAlertValueChangeSpeedT AsICustomAlertValueChangeSpeed()
		{
			return this.As<ICustomAlertValueChangeSpeedT>();
		}

		// Token: 0x0602D792 RID: 186258 RVA: 0x00639BED File Offset: 0x00637DED
		public static IAlertValueSpeedChangeType_UnionUnion FromICustomAlertValueChangeSpeed(ICustomAlertValueChangeSpeedT _icustomalertvaluechangespeed)
		{
			return new IAlertValueSpeedChangeType_UnionUnion
			{
				Type = IAlertValueSpeedChangeType_Union.ICustomAlertValueChangeSpeed,
				Value = _icustomalertvaluechangespeed
			};
		}

		// Token: 0x0602D793 RID: 186259 RVA: 0x00639C04 File Offset: 0x00637E04
		public static int Pack(FlatBufferBuilder builder, IAlertValueSpeedChangeType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAlertValueSpeedChangeType_Union.IAlertValueSpeedChangeType:
				return IAlertValueSpeedChangeType.Pack(builder, _o.AsIAlertValueSpeedChangeType()).Value;
			case IAlertValueSpeedChangeType_Union.IAddOrSubAlertValueChangeSpeed:
				return IAddOrSubAlertValueChangeSpeed.Pack(builder, _o.AsIAddOrSubAlertValueChangeSpeed()).Value;
			case IAlertValueSpeedChangeType_Union.ICustomAlertValueChangeSpeed:
				return ICustomAlertValueChangeSpeed.Pack(builder, _o.AsICustomAlertValueChangeSpeed()).Value;
			default:
				return 0;
			}
		}
	}
}
