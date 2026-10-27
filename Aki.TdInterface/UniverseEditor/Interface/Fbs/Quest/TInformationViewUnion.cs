using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D6 RID: 17110
	public class TInformationViewUnion
	{
		// Token: 0x17007946 RID: 31046
		// (get) Token: 0x06019609 RID: 103945 RVA: 0x003A4046 File Offset: 0x003A2246
		// (set) Token: 0x0601960A RID: 103946 RVA: 0x003A404E File Offset: 0x003A224E
		public TInformationView Type { get; set; }

		// Token: 0x17007947 RID: 31047
		// (get) Token: 0x0601960B RID: 103947 RVA: 0x003A4057 File Offset: 0x003A2257
		// (set) Token: 0x0601960C RID: 103948 RVA: 0x003A405F File Offset: 0x003A225F
		public object Value { get; set; }

		// Token: 0x0601960D RID: 103949 RVA: 0x003A4068 File Offset: 0x003A2268
		public TInformationViewUnion()
		{
			this.Type = TInformationView.NONE;
			this.Value = null;
		}

		// Token: 0x0601960E RID: 103950 RVA: 0x003A407E File Offset: 0x003A227E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601960F RID: 103951 RVA: 0x003A4090 File Offset: 0x003A2290
		public IBossRushBuffInfoViewT AsIBossRushBuffInfoView()
		{
			return this.As<IBossRushBuffInfoViewT>();
		}

		// Token: 0x06019610 RID: 103952 RVA: 0x003A4098 File Offset: 0x003A2298
		public static TInformationViewUnion FromIBossRushBuffInfoView(IBossRushBuffInfoViewT _ibossrushbuffinfoview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.IBossRushBuffInfoView,
				Value = _ibossrushbuffinfoview
			};
		}

		// Token: 0x06019611 RID: 103953 RVA: 0x003A40AD File Offset: 0x003A22AD
		public IDangoAbyssInformationViewT AsIDangoAbyssInformationView()
		{
			return this.As<IDangoAbyssInformationViewT>();
		}

		// Token: 0x06019612 RID: 103954 RVA: 0x003A40B5 File Offset: 0x003A22B5
		public static TInformationViewUnion FromIDangoAbyssInformationView(IDangoAbyssInformationViewT _idangoabyssinformationview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.IDangoAbyssInformationView,
				Value = _idangoabyssinformationview
			};
		}

		// Token: 0x06019613 RID: 103955 RVA: 0x003A40CA File Offset: 0x003A22CA
		public ILevelPlayInformationViewT AsILevelPlayInformationView()
		{
			return this.As<ILevelPlayInformationViewT>();
		}

		// Token: 0x06019614 RID: 103956 RVA: 0x003A40D2 File Offset: 0x003A22D2
		public static TInformationViewUnion FromILevelPlayInformationView(ILevelPlayInformationViewT _ilevelplayinformationview)
		{
			return new TInformationViewUnion
			{
				Type = TInformationView.ILevelPlayInformationView,
				Value = _ilevelplayinformationview
			};
		}

		// Token: 0x06019615 RID: 103957 RVA: 0x003A40E8 File Offset: 0x003A22E8
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
