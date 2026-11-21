using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE6 RID: 32486
	public class TFocusOnMapMarkTypeConfigUnion
	{
		// Token: 0x1700F267 RID: 62055
		// (get) Token: 0x0603A9E1 RID: 240097 RVA: 0x007E2DB0 File Offset: 0x007E0FB0
		// (set) Token: 0x0603A9E2 RID: 240098 RVA: 0x007E2DB8 File Offset: 0x007E0FB8
		public TFocusOnMapMarkTypeConfig Type { get; set; }

		// Token: 0x1700F268 RID: 62056
		// (get) Token: 0x0603A9E3 RID: 240099 RVA: 0x007E2DC1 File Offset: 0x007E0FC1
		// (set) Token: 0x0603A9E4 RID: 240100 RVA: 0x007E2DC9 File Offset: 0x007E0FC9
		public object Value { get; set; }

		// Token: 0x0603A9E5 RID: 240101 RVA: 0x007E2DD2 File Offset: 0x007E0FD2
		public TFocusOnMapMarkTypeConfigUnion()
		{
			this.Type = TFocusOnMapMarkTypeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9E6 RID: 240102 RVA: 0x007E2DE8 File Offset: 0x007E0FE8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9E7 RID: 240103 RVA: 0x007E2DFA File Offset: 0x007E0FFA
		public IFocusOnCustomMapMarkT AsIFocusOnCustomMapMark()
		{
			return this.As<IFocusOnCustomMapMarkT>();
		}

		// Token: 0x0603A9E8 RID: 240104 RVA: 0x007E2E02 File Offset: 0x007E1002
		public static TFocusOnMapMarkTypeConfigUnion FromIFocusOnCustomMapMark(IFocusOnCustomMapMarkT _ifocusoncustommapmark)
		{
			return new TFocusOnMapMarkTypeConfigUnion
			{
				Type = TFocusOnMapMarkTypeConfig.IFocusOnCustomMapMark,
				Value = _ifocusoncustommapmark
			};
		}

		// Token: 0x0603A9E9 RID: 240105 RVA: 0x007E2E17 File Offset: 0x007E1017
		public IFocusOnQuestMapMarkT AsIFocusOnQuestMapMark()
		{
			return this.As<IFocusOnQuestMapMarkT>();
		}

		// Token: 0x0603A9EA RID: 240106 RVA: 0x007E2E1F File Offset: 0x007E101F
		public static TFocusOnMapMarkTypeConfigUnion FromIFocusOnQuestMapMark(IFocusOnQuestMapMarkT _ifocusonquestmapmark)
		{
			return new TFocusOnMapMarkTypeConfigUnion
			{
				Type = TFocusOnMapMarkTypeConfig.IFocusOnQuestMapMark,
				Value = _ifocusonquestmapmark
			};
		}

		// Token: 0x0603A9EB RID: 240107 RVA: 0x007E2E34 File Offset: 0x007E1034
		public static int Pack(FlatBufferBuilder builder, TFocusOnMapMarkTypeConfigUnion _o)
		{
			TFocusOnMapMarkTypeConfig type = _o.Type;
			if (type == TFocusOnMapMarkTypeConfig.IFocusOnCustomMapMark)
			{
				return IFocusOnCustomMapMark.Pack(builder, _o.AsIFocusOnCustomMapMark()).Value;
			}
			if (type != TFocusOnMapMarkTypeConfig.IFocusOnQuestMapMark)
			{
				return 0;
			}
			return IFocusOnQuestMapMark.Pack(builder, _o.AsIFocusOnQuestMapMark()).Value;
		}
	}
}
