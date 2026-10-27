using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005824 RID: 22564
	public class IRefreshContent_UnionUnion
	{
		// Token: 0x1700A885 RID: 43141
		// (get) Token: 0x06025F00 RID: 155392 RVA: 0x0053B119 File Offset: 0x00539319
		// (set) Token: 0x06025F01 RID: 155393 RVA: 0x0053B121 File Offset: 0x00539321
		public IRefreshContent_Union Type { get; set; }

		// Token: 0x1700A886 RID: 43142
		// (get) Token: 0x06025F02 RID: 155394 RVA: 0x0053B12A File Offset: 0x0053932A
		// (set) Token: 0x06025F03 RID: 155395 RVA: 0x0053B132 File Offset: 0x00539332
		public object Value { get; set; }

		// Token: 0x06025F04 RID: 155396 RVA: 0x0053B13B File Offset: 0x0053933B
		public IRefreshContent_UnionUnion()
		{
			this.Type = IRefreshContent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025F05 RID: 155397 RVA: 0x0053B151 File Offset: 0x00539351
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025F06 RID: 155398 RVA: 0x0053B163 File Offset: 0x00539363
		public IRefreshContentT AsIRefreshContent()
		{
			return this.As<IRefreshContentT>();
		}

		// Token: 0x06025F07 RID: 155399 RVA: 0x0053B16B File Offset: 0x0053936B
		public static IRefreshContent_UnionUnion FromIRefreshContent(IRefreshContentT _irefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IRefreshContent,
				Value = _irefreshcontent
			};
		}

		// Token: 0x06025F08 RID: 155400 RVA: 0x0053B180 File Offset: 0x00539380
		public IAllRefreshContentT AsIAllRefreshContent()
		{
			return this.As<IAllRefreshContentT>();
		}

		// Token: 0x06025F09 RID: 155401 RVA: 0x0053B188 File Offset: 0x00539388
		public static IRefreshContent_UnionUnion FromIAllRefreshContent(IAllRefreshContentT _iallrefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IAllRefreshContent,
				Value = _iallrefreshcontent
			};
		}

		// Token: 0x06025F0A RID: 155402 RVA: 0x0053B19D File Offset: 0x0053939D
		public IRandomEntityRefreshContentT AsIRandomEntityRefreshContent()
		{
			return this.As<IRandomEntityRefreshContentT>();
		}

		// Token: 0x06025F0B RID: 155403 RVA: 0x0053B1A5 File Offset: 0x005393A5
		public static IRefreshContent_UnionUnion FromIRandomEntityRefreshContent(IRandomEntityRefreshContentT _irandomentityrefreshcontent)
		{
			return new IRefreshContent_UnionUnion
			{
				Type = IRefreshContent_Union.IRandomEntityRefreshContent,
				Value = _irandomentityrefreshcontent
			};
		}

		// Token: 0x06025F0C RID: 155404 RVA: 0x0053B1BC File Offset: 0x005393BC
		public static int Pack(FlatBufferBuilder builder, IRefreshContent_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IRefreshContent_Union.IRefreshContent:
				return IRefreshContent.Pack(builder, _o.AsIRefreshContent()).Value;
			case IRefreshContent_Union.IAllRefreshContent:
				return IAllRefreshContent.Pack(builder, _o.AsIAllRefreshContent()).Value;
			case IRefreshContent_Union.IRandomEntityRefreshContent:
				return IRandomEntityRefreshContent.Pack(builder, _o.AsIRandomEntityRefreshContent()).Value;
			default:
				return 0;
			}
		}
	}
}
