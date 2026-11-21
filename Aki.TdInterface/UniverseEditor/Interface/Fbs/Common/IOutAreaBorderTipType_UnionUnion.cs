using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006462 RID: 25698
	public class IOutAreaBorderTipType_UnionUnion
	{
		// Token: 0x1700BDB3 RID: 48563
		// (get) Token: 0x0602BABA RID: 178874 RVA: 0x005F19E5 File Offset: 0x005EFBE5
		// (set) Token: 0x0602BABB RID: 178875 RVA: 0x005F19ED File Offset: 0x005EFBED
		public IOutAreaBorderTipType_Union Type { get; set; }

		// Token: 0x1700BDB4 RID: 48564
		// (get) Token: 0x0602BABC RID: 178876 RVA: 0x005F19F6 File Offset: 0x005EFBF6
		// (set) Token: 0x0602BABD RID: 178877 RVA: 0x005F19FE File Offset: 0x005EFBFE
		public object Value { get; set; }

		// Token: 0x0602BABE RID: 178878 RVA: 0x005F1A07 File Offset: 0x005EFC07
		public IOutAreaBorderTipType_UnionUnion()
		{
			this.Type = IOutAreaBorderTipType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BABF RID: 178879 RVA: 0x005F1A1D File Offset: 0x005EFC1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BAC0 RID: 178880 RVA: 0x005F1A2F File Offset: 0x005EFC2F
		public IOutAreaBorderTipTypeT AsIOutAreaBorderTipType()
		{
			return this.As<IOutAreaBorderTipTypeT>();
		}

		// Token: 0x0602BAC1 RID: 178881 RVA: 0x005F1A37 File Offset: 0x005EFC37
		public static IOutAreaBorderTipType_UnionUnion FromIOutAreaBorderTipType(IOutAreaBorderTipTypeT _ioutareabordertiptype)
		{
			return new IOutAreaBorderTipType_UnionUnion
			{
				Type = IOutAreaBorderTipType_Union.IOutAreaBorderTipType,
				Value = _ioutareabordertiptype
			};
		}

		// Token: 0x0602BAC2 RID: 178882 RVA: 0x005F1A4C File Offset: 0x005EFC4C
		public IOutAreaBorderDownTimeTextTipT AsIOutAreaBorderDownTimeTextTip()
		{
			return this.As<IOutAreaBorderDownTimeTextTipT>();
		}

		// Token: 0x0602BAC3 RID: 178883 RVA: 0x005F1A54 File Offset: 0x005EFC54
		public static IOutAreaBorderTipType_UnionUnion FromIOutAreaBorderDownTimeTextTip(IOutAreaBorderDownTimeTextTipT _ioutareaborderdowntimetexttip)
		{
			return new IOutAreaBorderTipType_UnionUnion
			{
				Type = IOutAreaBorderTipType_Union.IOutAreaBorderDownTimeTextTip,
				Value = _ioutareaborderdowntimetexttip
			};
		}

		// Token: 0x0602BAC4 RID: 178884 RVA: 0x005F1A6C File Offset: 0x005EFC6C
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
