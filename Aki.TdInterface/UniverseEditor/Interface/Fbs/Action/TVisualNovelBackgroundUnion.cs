using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780B RID: 30731
	public class TVisualNovelBackgroundUnion
	{
		// Token: 0x1700E6F5 RID: 59125
		// (get) Token: 0x06037B94 RID: 228244 RVA: 0x007887D6 File Offset: 0x007869D6
		// (set) Token: 0x06037B95 RID: 228245 RVA: 0x007887DE File Offset: 0x007869DE
		public TVisualNovelBackground Type { get; set; }

		// Token: 0x1700E6F6 RID: 59126
		// (get) Token: 0x06037B96 RID: 228246 RVA: 0x007887E7 File Offset: 0x007869E7
		// (set) Token: 0x06037B97 RID: 228247 RVA: 0x007887EF File Offset: 0x007869EF
		public object Value { get; set; }

		// Token: 0x06037B98 RID: 228248 RVA: 0x007887F8 File Offset: 0x007869F8
		public TVisualNovelBackgroundUnion()
		{
			this.Type = TVisualNovelBackground.NONE;
			this.Value = null;
		}

		// Token: 0x06037B99 RID: 228249 RVA: 0x0078880E File Offset: 0x00786A0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B9A RID: 228250 RVA: 0x00788820 File Offset: 0x00786A20
		public IVisualNovelBackgroundCleanT AsIVisualNovelBackgroundClean()
		{
			return this.As<IVisualNovelBackgroundCleanT>();
		}

		// Token: 0x06037B9B RID: 228251 RVA: 0x00788828 File Offset: 0x00786A28
		public static TVisualNovelBackgroundUnion FromIVisualNovelBackgroundClean(IVisualNovelBackgroundCleanT _ivisualnovelbackgroundclean)
		{
			return new TVisualNovelBackgroundUnion
			{
				Type = TVisualNovelBackground.IVisualNovelBackgroundClean,
				Value = _ivisualnovelbackgroundclean
			};
		}

		// Token: 0x06037B9C RID: 228252 RVA: 0x0078883D File Offset: 0x00786A3D
		public IVisualNovelBackgroundLoadT AsIVisualNovelBackgroundLoad()
		{
			return this.As<IVisualNovelBackgroundLoadT>();
		}

		// Token: 0x06037B9D RID: 228253 RVA: 0x00788845 File Offset: 0x00786A45
		public static TVisualNovelBackgroundUnion FromIVisualNovelBackgroundLoad(IVisualNovelBackgroundLoadT _ivisualnovelbackgroundload)
		{
			return new TVisualNovelBackgroundUnion
			{
				Type = TVisualNovelBackground.IVisualNovelBackgroundLoad,
				Value = _ivisualnovelbackgroundload
			};
		}

		// Token: 0x06037B9E RID: 228254 RVA: 0x0078885C File Offset: 0x00786A5C
		public static int Pack(FlatBufferBuilder builder, TVisualNovelBackgroundUnion _o)
		{
			TVisualNovelBackground type = _o.Type;
			if (type == TVisualNovelBackground.IVisualNovelBackgroundClean)
			{
				return IVisualNovelBackgroundClean.Pack(builder, _o.AsIVisualNovelBackgroundClean()).Value;
			}
			if (type != TVisualNovelBackground.IVisualNovelBackgroundLoad)
			{
				return 0;
			}
			return IVisualNovelBackgroundLoad.Pack(builder, _o.AsIVisualNovelBackgroundLoad()).Value;
		}
	}
}
