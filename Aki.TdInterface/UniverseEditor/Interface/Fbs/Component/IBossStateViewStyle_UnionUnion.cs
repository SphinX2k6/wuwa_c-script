using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005452 RID: 21586
	public class IBossStateViewStyle_UnionUnion
	{
		// Token: 0x17009968 RID: 39272
		// (get) Token: 0x06021DFE RID: 138750 RVA: 0x004AB665 File Offset: 0x004A9865
		// (set) Token: 0x06021DFF RID: 138751 RVA: 0x004AB66D File Offset: 0x004A986D
		public IBossStateViewStyle_Union Type { get; set; }

		// Token: 0x17009969 RID: 39273
		// (get) Token: 0x06021E00 RID: 138752 RVA: 0x004AB676 File Offset: 0x004A9876
		// (set) Token: 0x06021E01 RID: 138753 RVA: 0x004AB67E File Offset: 0x004A987E
		public object Value { get; set; }

		// Token: 0x06021E02 RID: 138754 RVA: 0x004AB687 File Offset: 0x004A9887
		public IBossStateViewStyle_UnionUnion()
		{
			this.Type = IBossStateViewStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021E03 RID: 138755 RVA: 0x004AB69D File Offset: 0x004A989D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021E04 RID: 138756 RVA: 0x004AB6AF File Offset: 0x004A98AF
		public IBossStateViewStyleT AsIBossStateViewStyle()
		{
			return this.As<IBossStateViewStyleT>();
		}

		// Token: 0x06021E05 RID: 138757 RVA: 0x004AB6B7 File Offset: 0x004A98B7
		public static IBossStateViewStyle_UnionUnion FromIBossStateViewStyle(IBossStateViewStyleT _ibossstateviewstyle)
		{
			return new IBossStateViewStyle_UnionUnion
			{
				Type = IBossStateViewStyle_Union.IBossStateViewStyle,
				Value = _ibossstateviewstyle
			};
		}

		// Token: 0x06021E06 RID: 138758 RVA: 0x004AB6CC File Offset: 0x004A98CC
		public IDoubleViewBossStateViewStyleT AsIDoubleViewBossStateViewStyle()
		{
			return this.As<IDoubleViewBossStateViewStyleT>();
		}

		// Token: 0x06021E07 RID: 138759 RVA: 0x004AB6D4 File Offset: 0x004A98D4
		public static IBossStateViewStyle_UnionUnion FromIDoubleViewBossStateViewStyle(IDoubleViewBossStateViewStyleT _idoubleviewbossstateviewstyle)
		{
			return new IBossStateViewStyle_UnionUnion
			{
				Type = IBossStateViewStyle_Union.IDoubleViewBossStateViewStyle,
				Value = _idoubleviewbossstateviewstyle
			};
		}

		// Token: 0x06021E08 RID: 138760 RVA: 0x004AB6EC File Offset: 0x004A98EC
		public static int Pack(FlatBufferBuilder builder, IBossStateViewStyle_UnionUnion _o)
		{
			IBossStateViewStyle_Union type = _o.Type;
			if (type == IBossStateViewStyle_Union.IBossStateViewStyle)
			{
				return IBossStateViewStyle.Pack(builder, _o.AsIBossStateViewStyle()).Value;
			}
			if (type != IBossStateViewStyle_Union.IDoubleViewBossStateViewStyle)
			{
				return 0;
			}
			return IDoubleViewBossStateViewStyle.Pack(builder, _o.AsIDoubleViewBossStateViewStyle()).Value;
		}
	}
}
