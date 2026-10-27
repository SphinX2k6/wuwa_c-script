using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D8 RID: 30424
	public class TFocusOnMapMarkTypeConfigUnion
	{
		// Token: 0x1700E629 RID: 58921
		// (get) Token: 0x0603752C RID: 226604 RVA: 0x0077EA9C File Offset: 0x0077CC9C
		// (set) Token: 0x0603752D RID: 226605 RVA: 0x0077EAA4 File Offset: 0x0077CCA4
		public TFocusOnMapMarkTypeConfig Type { get; set; }

		// Token: 0x1700E62A RID: 58922
		// (get) Token: 0x0603752E RID: 226606 RVA: 0x0077EAAD File Offset: 0x0077CCAD
		// (set) Token: 0x0603752F RID: 226607 RVA: 0x0077EAB5 File Offset: 0x0077CCB5
		public object Value { get; set; }

		// Token: 0x06037530 RID: 226608 RVA: 0x0077EABE File Offset: 0x0077CCBE
		public TFocusOnMapMarkTypeConfigUnion()
		{
			this.Type = TFocusOnMapMarkTypeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037531 RID: 226609 RVA: 0x0077EAD4 File Offset: 0x0077CCD4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037532 RID: 226610 RVA: 0x0077EAE6 File Offset: 0x0077CCE6
		public IFocusOnCustomMapMarkT AsIFocusOnCustomMapMark()
		{
			return this.As<IFocusOnCustomMapMarkT>();
		}

		// Token: 0x06037533 RID: 226611 RVA: 0x0077EAEE File Offset: 0x0077CCEE
		public static TFocusOnMapMarkTypeConfigUnion FromIFocusOnCustomMapMark(IFocusOnCustomMapMarkT _ifocusoncustommapmark)
		{
			return new TFocusOnMapMarkTypeConfigUnion
			{
				Type = TFocusOnMapMarkTypeConfig.IFocusOnCustomMapMark,
				Value = _ifocusoncustommapmark
			};
		}

		// Token: 0x06037534 RID: 226612 RVA: 0x0077EB03 File Offset: 0x0077CD03
		public IFocusOnQuestMapMarkT AsIFocusOnQuestMapMark()
		{
			return this.As<IFocusOnQuestMapMarkT>();
		}

		// Token: 0x06037535 RID: 226613 RVA: 0x0077EB0B File Offset: 0x0077CD0B
		public static TFocusOnMapMarkTypeConfigUnion FromIFocusOnQuestMapMark(IFocusOnQuestMapMarkT _ifocusonquestmapmark)
		{
			return new TFocusOnMapMarkTypeConfigUnion
			{
				Type = TFocusOnMapMarkTypeConfig.IFocusOnQuestMapMark,
				Value = _ifocusonquestmapmark
			};
		}

		// Token: 0x06037536 RID: 226614 RVA: 0x0077EB20 File Offset: 0x0077CD20
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
