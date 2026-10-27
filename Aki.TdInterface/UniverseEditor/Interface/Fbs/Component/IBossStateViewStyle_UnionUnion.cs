using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F20 RID: 20256
	public class IBossStateViewStyle_UnionUnion
	{
		// Token: 0x170091E6 RID: 37350
		// (get) Token: 0x0602008E RID: 131214 RVA: 0x004752D1 File Offset: 0x004734D1
		// (set) Token: 0x0602008F RID: 131215 RVA: 0x004752D9 File Offset: 0x004734D9
		public IBossStateViewStyle_Union Type { get; set; }

		// Token: 0x170091E7 RID: 37351
		// (get) Token: 0x06020090 RID: 131216 RVA: 0x004752E2 File Offset: 0x004734E2
		// (set) Token: 0x06020091 RID: 131217 RVA: 0x004752EA File Offset: 0x004734EA
		public object Value { get; set; }

		// Token: 0x06020092 RID: 131218 RVA: 0x004752F3 File Offset: 0x004734F3
		public IBossStateViewStyle_UnionUnion()
		{
			this.Type = IBossStateViewStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020093 RID: 131219 RVA: 0x00475309 File Offset: 0x00473509
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020094 RID: 131220 RVA: 0x0047531B File Offset: 0x0047351B
		public IBossStateViewStyleT AsIBossStateViewStyle()
		{
			return this.As<IBossStateViewStyleT>();
		}

		// Token: 0x06020095 RID: 131221 RVA: 0x00475323 File Offset: 0x00473523
		public static IBossStateViewStyle_UnionUnion FromIBossStateViewStyle(IBossStateViewStyleT _ibossstateviewstyle)
		{
			return new IBossStateViewStyle_UnionUnion
			{
				Type = IBossStateViewStyle_Union.IBossStateViewStyle,
				Value = _ibossstateviewstyle
			};
		}

		// Token: 0x06020096 RID: 131222 RVA: 0x00475338 File Offset: 0x00473538
		public IDoubleViewBossStateViewStyleT AsIDoubleViewBossStateViewStyle()
		{
			return this.As<IDoubleViewBossStateViewStyleT>();
		}

		// Token: 0x06020097 RID: 131223 RVA: 0x00475340 File Offset: 0x00473540
		public static IBossStateViewStyle_UnionUnion FromIDoubleViewBossStateViewStyle(IDoubleViewBossStateViewStyleT _idoubleviewbossstateviewstyle)
		{
			return new IBossStateViewStyle_UnionUnion
			{
				Type = IBossStateViewStyle_Union.IDoubleViewBossStateViewStyle,
				Value = _idoubleviewbossstateviewstyle
			};
		}

		// Token: 0x06020098 RID: 131224 RVA: 0x00475358 File Offset: 0x00473558
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
