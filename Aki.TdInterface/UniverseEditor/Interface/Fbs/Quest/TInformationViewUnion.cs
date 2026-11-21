using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004735 RID: 18229
	public class TInformationViewUnion
	{
		// Token: 0x17007F79 RID: 32633
		// (get) Token: 0x0601AD8B RID: 109963 RVA: 0x003CF976 File Offset: 0x003CDB76
		// (set) Token: 0x0601AD8C RID: 109964 RVA: 0x003CF97E File Offset: 0x003CDB7E
		public TInformationView Type { get; set; }

		// Token: 0x17007F7A RID: 32634
		// (get) Token: 0x0601AD8D RID: 109965 RVA: 0x003CF987 File Offset: 0x003CDB87
		// (set) Token: 0x0601AD8E RID: 109966 RVA: 0x003CF98F File Offset: 0x003CDB8F
		public object Value { get; set; }

		// Token: 0x0601AD8F RID: 109967 RVA: 0x003CF998 File Offset: 0x003CDB98
		public TInformationViewUnion()
		{
			this.Type = TInformationView.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD90 RID: 109968 RVA: 0x003CF9AE File Offset: 0x003CDBAE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD91 RID: 109969 RVA: 0x003CF9C0 File Offset: 0x003CDBC0
		public IBossRushBuffInfoViewT AsIBossRushBuffInfoView()
		{
			return this.As<IBossRushBuffInfoViewT>();
		}

		// Token: 0x0601AD92 RID: 109970 RVA: 0x003CF9C8 File Offset: 0x003CDBC8
		public static TInformationViewUnion FromIBossRushBuffInfoView(IBossRushBuffInfoViewT _ibossrushbuffinfoview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.IBossRushBuffInfoView,
				Value = _ibossrushbuffinfoview
			};
		}

		// Token: 0x0601AD93 RID: 109971 RVA: 0x003CF9DD File Offset: 0x003CDBDD
		public IDangoAbyssInformationViewT AsIDangoAbyssInformationView()
		{
			return this.As<IDangoAbyssInformationViewT>();
		}

		// Token: 0x0601AD94 RID: 109972 RVA: 0x003CF9E5 File Offset: 0x003CDBE5
		public static TInformationViewUnion FromIDangoAbyssInformationView(IDangoAbyssInformationViewT _idangoabyssinformationview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.IDangoAbyssInformationView,
				Value = _idangoabyssinformationview
			};
		}

		// Token: 0x0601AD95 RID: 109973 RVA: 0x003CF9FA File Offset: 0x003CDBFA
		public ILevelPlayInformationViewT AsILevelPlayInformationView()
		{
			return this.As<ILevelPlayInformationViewT>();
		}

		// Token: 0x0601AD96 RID: 109974 RVA: 0x003CFA02 File Offset: 0x003CDC02
		public static TInformationViewUnion FromILevelPlayInformationView(ILevelPlayInformationViewT _ilevelplayinformationview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.ILevelPlayInformationView,
				Value = _ilevelplayinformationview
			};
		}

		// Token: 0x0601AD97 RID: 109975 RVA: 0x003CFA18 File Offset: 0x003CDC18
		public static int Pack(FlatBufferBuilder builder, TInformationViewUnion _o)
		{
			switch (_o.Type)
			{
			case TInformationView.IBossRushBuffInfoView:
				return IBossRushBuffInfoView.Pack(builder, _o.AsIBossRushBuffInfoView()).Value;
			case TInformationView.IDangoAbyssInformationView:
				return IDangoAbyssInformationView.Pack(builder, _o.AsIDangoAbyssInformationView()).Value;
			case TInformationView.ILevelPlayInformationView:
				return ILevelPlayInformationView.Pack(builder, _o.AsILevelPlayInformationView()).Value;
			default:
				return 0;
			}
		}
	}
}
