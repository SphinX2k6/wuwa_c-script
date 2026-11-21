using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008049 RID: 32841
	public class TVisualNovelBackgroundUnion
	{
		// Token: 0x1700F353 RID: 62291
		// (get) Token: 0x0603B139 RID: 241977 RVA: 0x007EE14E File Offset: 0x007EC34E
		// (set) Token: 0x0603B13A RID: 241978 RVA: 0x007EE156 File Offset: 0x007EC356
		public TVisualNovelBackground Type { get; set; }

		// Token: 0x1700F354 RID: 62292
		// (get) Token: 0x0603B13B RID: 241979 RVA: 0x007EE15F File Offset: 0x007EC35F
		// (set) Token: 0x0603B13C RID: 241980 RVA: 0x007EE167 File Offset: 0x007EC367
		public object Value { get; set; }

		// Token: 0x0603B13D RID: 241981 RVA: 0x007EE170 File Offset: 0x007EC370
		public TVisualNovelBackgroundUnion()
		{
			this.Type = TVisualNovelBackground.NONE;
			this.Value = null;
		}

		// Token: 0x0603B13E RID: 241982 RVA: 0x007EE186 File Offset: 0x007EC386
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B13F RID: 241983 RVA: 0x007EE198 File Offset: 0x007EC398
		public IVisualNovelBackgroundCleanT AsIVisualNovelBackgroundClean()
		{
			return this.As<IVisualNovelBackgroundCleanT>();
		}

		// Token: 0x0603B140 RID: 241984 RVA: 0x007EE1A0 File Offset: 0x007EC3A0
		public static TVisualNovelBackgroundUnion FromIVisualNovelBackgroundClean(IVisualNovelBackgroundCleanT _ivisualnovelbackgroundclean)
		{
			return new TVisualNovelBackgroundUnion
			{
				Type = TVisualNovelBackground.IVisualNovelBackgroundClean,
				Value = _ivisualnovelbackgroundclean
			};
		}

		// Token: 0x0603B141 RID: 241985 RVA: 0x007EE1B5 File Offset: 0x007EC3B5
		public IVisualNovelBackgroundLoadT AsIVisualNovelBackgroundLoad()
		{
			return this.As<IVisualNovelBackgroundLoadT>();
		}

		// Token: 0x0603B142 RID: 241986 RVA: 0x007EE1BD File Offset: 0x007EC3BD
		public static TVisualNovelBackgroundUnion FromIVisualNovelBackgroundLoad(IVisualNovelBackgroundLoadT _ivisualnovelbackgroundload)
		{
			return new TVisualNovelBackgroundUnion
			{
				Type = TVisualNovelBackground.IVisualNovelBackgroundLoad,
				Value = _ivisualnovelbackgroundload
			};
		}

		// Token: 0x0603B143 RID: 241987 RVA: 0x007EE1D4 File Offset: 0x007EC3D4
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
