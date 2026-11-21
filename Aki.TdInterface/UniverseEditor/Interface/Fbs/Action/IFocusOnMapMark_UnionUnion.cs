using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED0 RID: 28368
	public class IFocusOnMapMark_UnionUnion
	{
		// Token: 0x1700D012 RID: 53266
		// (get) Token: 0x0603114B RID: 201035 RVA: 0x006A7C65 File Offset: 0x006A5E65
		// (set) Token: 0x0603114C RID: 201036 RVA: 0x006A7C6D File Offset: 0x006A5E6D
		public IFocusOnMapMark_Union Type { get; set; }

		// Token: 0x1700D013 RID: 53267
		// (get) Token: 0x0603114D RID: 201037 RVA: 0x006A7C76 File Offset: 0x006A5E76
		// (set) Token: 0x0603114E RID: 201038 RVA: 0x006A7C7E File Offset: 0x006A5E7E
		public object Value { get; set; }

		// Token: 0x0603114F RID: 201039 RVA: 0x006A7C87 File Offset: 0x006A5E87
		public IFocusOnMapMark_UnionUnion()
		{
			this.Type = IFocusOnMapMark_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031150 RID: 201040 RVA: 0x006A7C9D File Offset: 0x006A5E9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031151 RID: 201041 RVA: 0x006A7CAF File Offset: 0x006A5EAF
		public IFocusOnMapMarkT AsIFocusOnMapMark()
		{
			return this.As<IFocusOnMapMarkT>();
		}

		// Token: 0x06031152 RID: 201042 RVA: 0x006A7CB7 File Offset: 0x006A5EB7
		public static IFocusOnMapMark_UnionUnion FromIFocusOnMapMark(IFocusOnMapMarkT _ifocusonmapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnMapMark,
				Value = _ifocusonmapmark
			};
		}

		// Token: 0x06031153 RID: 201043 RVA: 0x006A7CCC File Offset: 0x006A5ECC
		public IFocusOnCustomMapMarkT AsIFocusOnCustomMapMark()
		{
			return this.As<IFocusOnCustomMapMarkT>();
		}

		// Token: 0x06031154 RID: 201044 RVA: 0x006A7CD4 File Offset: 0x006A5ED4
		public static IFocusOnMapMark_UnionUnion FromIFocusOnCustomMapMark(IFocusOnCustomMapMarkT _ifocusoncustommapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnCustomMapMark,
				Value = _ifocusoncustommapmark
			};
		}

		// Token: 0x06031155 RID: 201045 RVA: 0x006A7CE9 File Offset: 0x006A5EE9
		public IFocusOnQuestMapMarkT AsIFocusOnQuestMapMark()
		{
			return this.As<IFocusOnQuestMapMarkT>();
		}

		// Token: 0x06031156 RID: 201046 RVA: 0x006A7CF1 File Offset: 0x006A5EF1
		public static IFocusOnMapMark_UnionUnion FromIFocusOnQuestMapMark(IFocusOnQuestMapMarkT _ifocusonquestmapmark)
		{
			return new IFocusOnMapMark_UnionUnion
			{
				Type = IFocusOnMapMark_Union.IFocusOnQuestMapMark,
				Value = _ifocusonquestmapmark
			};
		}

		// Token: 0x06031157 RID: 201047 RVA: 0x006A7D08 File Offset: 0x006A5F08
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
