using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E25 RID: 24101
	public class IOutAreaBorderTipType_UnionUnion
	{
		// Token: 0x1700B44D RID: 46157
		// (get) Token: 0x06029430 RID: 169008 RVA: 0x005A8CB5 File Offset: 0x005A6EB5
		// (set) Token: 0x06029431 RID: 169009 RVA: 0x005A8CBD File Offset: 0x005A6EBD
		public IOutAreaBorderTipType_Union Type { get; set; }

		// Token: 0x1700B44E RID: 46158
		// (get) Token: 0x06029432 RID: 169010 RVA: 0x005A8CC6 File Offset: 0x005A6EC6
		// (set) Token: 0x06029433 RID: 169011 RVA: 0x005A8CCE File Offset: 0x005A6ECE
		public object Value { get; set; }

		// Token: 0x06029434 RID: 169012 RVA: 0x005A8CD7 File Offset: 0x005A6ED7
		public IOutAreaBorderTipType_UnionUnion()
		{
			this.Type = IOutAreaBorderTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029435 RID: 169013 RVA: 0x005A8CED File Offset: 0x005A6EED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029436 RID: 169014 RVA: 0x005A8CFF File Offset: 0x005A6EFF
		public IOutAreaBorderTipTypeT AsIOutAreaBorderTipType()
		{
			return this.As<IOutAreaBorderTipTypeT>();
		}

		// Token: 0x06029437 RID: 169015 RVA: 0x005A8D07 File Offset: 0x005A6F07
		public static IOutAreaBorderTipType_UnionUnion FromIOutAreaBorderTipType(IOutAreaBorderTipTypeT _ioutareabordertiptype)
		{
			return new IOutAreaBorderTipType_UnionUnion
			{
				Type = IOutAreaBorderTipType_Union.IOutAreaBorderTipType,
				Value = _ioutareabordertiptype
			};
		}

		// Token: 0x06029438 RID: 169016 RVA: 0x005A8D1C File Offset: 0x005A6F1C
		public IOutAreaBorderDownTimeTextTipT AsIOutAreaBorderDownTimeTextTip()
		{
			return this.As<IOutAreaBorderDownTimeTextTipT>();
		}

		// Token: 0x06029439 RID: 169017 RVA: 0x005A8D24 File Offset: 0x005A6F24
		public static IOutAreaBorderTipType_UnionUnion FromIOutAreaBorderDownTimeTextTip(IOutAreaBorderDownTimeTextTipT _ioutareaborderdowntimetexttip)
		{
			return new IOutAreaBorderTipType_UnionUnion
			{
				Type = IOutAreaBorderTipType_Union.IOutAreaBorderDownTimeTextTip,
				Value = _ioutareaborderdowntimetexttip
			};
		}

		// Token: 0x0602943A RID: 169018 RVA: 0x005A8D3C File Offset: 0x005A6F3C
		public static int Pack(FlatBufferBuilder builder, IOutAreaBorderTipType_UnionUnion _o)
		{
			IOutAreaBorderTipType_Union type = _o.Type;
			if (type == IOutAreaBorderTipType_Union.IOutAreaBorderTipType)
			{
				return IOutAreaBorderTipType.Pack(builder, _o.AsIOutAreaBorderTipType()).Value;
			}
			if (type != IOutAreaBorderTipType_Union.IOutAreaBorderDownTimeTextTip)
			{
				return 0;
			}
			return IOutAreaBorderDownTimeTextTip.Pack(builder, _o.AsIOutAreaBorderDownTimeTextTip()).Value;
		}
	}
}
