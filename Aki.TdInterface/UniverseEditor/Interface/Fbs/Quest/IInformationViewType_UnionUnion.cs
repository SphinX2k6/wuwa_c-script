using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F0 RID: 17136
	public class IInformationViewType_UnionUnion
	{
		// Token: 0x17007553 RID: 30035
		// (get) Token: 0x060180F2 RID: 98546 RVA: 0x0036EC55 File Offset: 0x0036CE55
		// (set) Token: 0x060180F3 RID: 98547 RVA: 0x0036EC5D File Offset: 0x0036CE5D
		public IInformationViewType_Union Type { get; set; }

		// Token: 0x17007554 RID: 30036
		// (get) Token: 0x060180F4 RID: 98548 RVA: 0x0036EC66 File Offset: 0x0036CE66
		// (set) Token: 0x060180F5 RID: 98549 RVA: 0x0036EC6E File Offset: 0x0036CE6E
		public object Value { get; set; }

		// Token: 0x060180F6 RID: 98550 RVA: 0x0036EC77 File Offset: 0x0036CE77
		public IInformationViewType_UnionUnion()
		{
			this.Type = IInformationViewType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060180F7 RID: 98551 RVA: 0x0036EC8D File Offset: 0x0036CE8D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060180F8 RID: 98552 RVA: 0x0036EC9F File Offset: 0x0036CE9F
		public IInformationViewTypeT AsIInformationViewType()
		{
			return this.As<IInformationViewTypeT>();
		}

		// Token: 0x060180F9 RID: 98553 RVA: 0x0036ECA7 File Offset: 0x0036CEA7
		public static IInformationViewType_UnionUnion FromIInformationViewType(IInformationViewTypeT _iinformationviewtype)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IInformationViewType,
				Value = _iinformationviewtype
			};
		}

		// Token: 0x060180FA RID: 98554 RVA: 0x0036ECBC File Offset: 0x0036CEBC
		public ILevelPlayInformationViewT AsILevelPlayInformationView()
		{
			return this.As<ILevelPlayInformationViewT>();
		}

		// Token: 0x060180FB RID: 98555 RVA: 0x0036ECC4 File Offset: 0x0036CEC4
		public static IInformationViewType_UnionUnion FromILevelPlayInformationView(ILevelPlayInformationViewT _ilevelplayinformationview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.ILevelPlayInformationView,
				Value = _ilevelplayinformationview
			};
		}

		// Token: 0x060180FC RID: 98556 RVA: 0x0036ECD9 File Offset: 0x0036CED9
		public IBossRushBuffInfoViewT AsIBossRushBuffInfoView()
		{
			return this.As<IBossRushBuffInfoViewT>();
		}

		// Token: 0x060180FD RID: 98557 RVA: 0x0036ECE1 File Offset: 0x0036CEE1
		public static IInformationViewType_UnionUnion FromIBossRushBuffInfoView(IBossRushBuffInfoViewT _ibossrushbuffinfoview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IBossRushBuffInfoView,
				Value = _ibossrushbuffinfoview
			};
		}

		// Token: 0x060180FE RID: 98558 RVA: 0x0036ECF6 File Offset: 0x0036CEF6
		public IDangoAbyssInformationViewT AsIDangoAbyssInformationView()
		{
			return this.As<IDangoAbyssInformationViewT>();
		}

		// Token: 0x060180FF RID: 98559 RVA: 0x0036ECFE File Offset: 0x0036CEFE
		public static IInformationViewType_UnionUnion FromIDangoAbyssInformationView(IDangoAbyssInformationViewT _idangoabyssinformationview)
		{
			return new IInformationViewType_UnionUnion
			{
				Type = IInformationViewType_Union.IDangoAbyssInformationView,
				Value = _idangoabyssinformationview
			};
		}

		// Token: 0x06018100 RID: 98560 RVA: 0x0036ED14 File Offset: 0x0036CF14
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
