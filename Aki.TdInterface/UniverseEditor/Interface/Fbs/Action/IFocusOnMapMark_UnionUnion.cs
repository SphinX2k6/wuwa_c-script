using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684A RID: 26698
	public class IFocusOnMapMark_UnionUnion
	{
		// Token: 0x1700C64E RID: 50766
		// (get) Token: 0x0602E8C3 RID: 190659 RVA: 0x00659D25 File Offset: 0x00657F25
		// (set) Token: 0x0602E8C4 RID: 190660 RVA: 0x00659D2D File Offset: 0x00657F2D
		public IFocusOnMapMark_Union Type { get; set; }

		// Token: 0x1700C64F RID: 50767
		// (get) Token: 0x0602E8C5 RID: 190661 RVA: 0x00659D36 File Offset: 0x00657F36
		// (set) Token: 0x0602E8C6 RID: 190662 RVA: 0x00659D3E File Offset: 0x00657F3E
		public object Value { get; set; }

		// Token: 0x0602E8C7 RID: 190663 RVA: 0x00659D47 File Offset: 0x00657F47
		public IFocusOnMapMark_UnionUnion()
		{
			this.Type = IFocusOnMapMark_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E8C8 RID: 190664 RVA: 0x00659D5D File Offset: 0x00657F5D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E8C9 RID: 190665 RVA: 0x00659D6F File Offset: 0x00657F6F
		public IFocusOnMapMarkT AsIFocusOnMapMark()
		{
			return this.As<IFocusOnMapMarkT>();
		}

		// Token: 0x0602E8CA RID: 190666 RVA: 0x00659D77 File Offset: 0x00657F77
		public static IFocusOnMapMark_UnionUnion FromIFocusOnMapMark(IFocusOnMapMarkT _ifocusonmapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnMapMark,
				Value = _ifocusonmapmark
			};
		}

		// Token: 0x0602E8CB RID: 190667 RVA: 0x00659D8C File Offset: 0x00657F8C
		public IFocusOnCustomMapMarkT AsIFocusOnCustomMapMark()
		{
			return this.As<IFocusOnCustomMapMarkT>();
		}

		// Token: 0x0602E8CC RID: 190668 RVA: 0x00659D94 File Offset: 0x00657F94
		public static IFocusOnMapMark_UnionUnion FromIFocusOnCustomMapMark(IFocusOnCustomMapMarkT _ifocusoncustommapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnCustomMapMark,
				Value = _ifocusoncustommapmark
			};
		}

		// Token: 0x0602E8CD RID: 190669 RVA: 0x00659DA9 File Offset: 0x00657FA9
		public IFocusOnQuestMapMarkT AsIFocusOnQuestMapMark()
		{
			return this.As<IFocusOnQuestMapMarkT>();
		}

		// Token: 0x0602E8CE RID: 190670 RVA: 0x00659DB1 File Offset: 0x00657FB1
		public static IFocusOnMapMark_UnionUnion FromIFocusOnQuestMapMark(IFocusOnQuestMapMarkT _ifocusonquestmapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnQuestMapMark,
				Value = _ifocusonquestmapmark
			};
		}

		// Token: 0x0602E8CF RID: 190671 RVA: 0x00659DC8 File Offset: 0x00657FC8
		public static int Pack(FlatBufferBuilder builder, IFocusOnMapMark_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFocusOnMapMark_Union.IFocusOnMapMark:
				return IFocusOnMapMark.Pack(builder, _o.AsIFocusOnMapMark()).Value;
			case IFocusOnMapMark_Union.IFocusOnCustomMapMark:
				return IFocusOnCustomMapMark.Pack(builder, _o.AsIFocusOnCustomMapMark()).Value;
			case IFocusOnMapMark_Union.IFocusOnQuestMapMark:
				return IFocusOnQuestMapMark.Pack(builder, _o.AsIFocusOnQuestMapMark()).Value;
			default:
				return 0;
			}
		}
	}
}
