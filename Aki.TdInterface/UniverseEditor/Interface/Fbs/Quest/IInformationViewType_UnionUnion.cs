using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB2 RID: 16050
	public class IInformationViewType_UnionUnion
	{
		// Token: 0x17006F66 RID: 28518
		// (get) Token: 0x06016AA5 RID: 92837 RVA: 0x00345CCD File Offset: 0x00343ECD
		// (set) Token: 0x06016AA6 RID: 92838 RVA: 0x00345CD5 File Offset: 0x00343ED5
		public IInformationViewType_Union Type { get; set; }

		// Token: 0x17006F67 RID: 28519
		// (get) Token: 0x06016AA7 RID: 92839 RVA: 0x00345CDE File Offset: 0x00343EDE
		// (set) Token: 0x06016AA8 RID: 92840 RVA: 0x00345CE6 File Offset: 0x00343EE6
		public object Value { get; set; }

		// Token: 0x06016AA9 RID: 92841 RVA: 0x00345CEF File Offset: 0x00343EEF
		public IInformationViewType_UnionUnion()
		{
			this.Type = IInformationViewType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016AAA RID: 92842 RVA: 0x00345D05 File Offset: 0x00343F05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016AAB RID: 92843 RVA: 0x00345D17 File Offset: 0x00343F17
		public IInformationViewTypeT AsIInformationViewType()
		{
			return this.As<IInformationViewTypeT>();
		}

		// Token: 0x06016AAC RID: 92844 RVA: 0x00345D1F File Offset: 0x00343F1F
		public static IInformationViewType_UnionUnion FromIInformationViewType(IInformationViewTypeT _iinformationviewtype)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IInformationViewType,
				Value = _iinformationviewtype
			};
		}

		// Token: 0x06016AAD RID: 92845 RVA: 0x00345D34 File Offset: 0x00343F34
		public ILevelPlayInformationViewT AsILevelPlayInformationView()
		{
			return this.As<ILevelPlayInformationViewT>();
		}

		// Token: 0x06016AAE RID: 92846 RVA: 0x00345D3C File Offset: 0x00343F3C
		public static IInformationViewType_UnionUnion FromILevelPlayInformationView(ILevelPlayInformationViewT _ilevelplayinformationview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.ILevelPlayInformationView,
				Value = _ilevelplayinformationview
			};
		}

		// Token: 0x06016AAF RID: 92847 RVA: 0x00345D51 File Offset: 0x00343F51
		public IBossRushBuffInfoViewT AsIBossRushBuffInfoView()
		{
			return this.As<IBossRushBuffInfoViewT>();
		}

		// Token: 0x06016AB0 RID: 92848 RVA: 0x00345D59 File Offset: 0x00343F59
		public static IInformationViewType_UnionUnion FromIBossRushBuffInfoView(IBossRushBuffInfoViewT _ibossrushbuffinfoview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IBossRushBuffInfoView,
				Value = _ibossrushbuffinfoview
			};
		}

		// Token: 0x06016AB1 RID: 92849 RVA: 0x00345D6E File Offset: 0x00343F6E
		public IDangoAbyssInformationViewT AsIDangoAbyssInformationView()
		{
			return this.As<IDangoAbyssInformationViewT>();
		}

		// Token: 0x06016AB2 RID: 92850 RVA: 0x00345D76 File Offset: 0x00343F76
		public static IInformationViewType_UnionUnion FromIDangoAbyssInformationView(IDangoAbyssInformationViewT _idangoabyssinformationview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IDangoAbyssInformationView,
				Value = _idangoabyssinformationview
			};
		}

		// Token: 0x06016AB3 RID: 92851 RVA: 0x00345D8C File Offset: 0x00343F8C
		public static int Pack(FlatBufferBuilder builder, IInformationViewType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInformationViewType_Union.IInformationViewType:
				return IInformationViewType.Pack(builder, _o.AsIInformationViewType()).Value;
			case IInformationViewType_Union.ILevelPlayInformationView:
				return ILevelPlayInformationView.Pack(builder, _o.AsILevelPlayInformationView()).Value;
			case IInformationViewType_Union.IBossRushBuffInfoView:
				return IBossRushBuffInfoView.Pack(builder, _o.AsIBossRushBuffInfoView()).Value;
			case IInformationViewType_Union.IDangoAbyssInformationView:
				return IDangoAbyssInformationView.Pack(builder, _o.AsIDangoAbyssInformationView()).Value;
			default:
				return 0;
			}
		}
	}
}
