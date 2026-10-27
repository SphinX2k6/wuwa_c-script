using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AF RID: 29871
	public class IUiStyleBaseOfLevelD_UnionUnion
	{
		// Token: 0x1700E2BB RID: 58043
		// (get) Token: 0x060364E0 RID: 222432 RVA: 0x007617E1 File Offset: 0x0075F9E1
		// (set) Token: 0x060364E1 RID: 222433 RVA: 0x007617E9 File Offset: 0x0075F9E9
		public IUiStyleBaseOfLevelD_Union Type { get; set; }

		// Token: 0x1700E2BC RID: 58044
		// (get) Token: 0x060364E2 RID: 222434 RVA: 0x007617F2 File Offset: 0x0075F9F2
		// (set) Token: 0x060364E3 RID: 222435 RVA: 0x007617FA File Offset: 0x0075F9FA
		public object Value { get; set; }

		// Token: 0x060364E4 RID: 222436 RVA: 0x00761803 File Offset: 0x0075FA03
		public IUiStyleBaseOfLevelD_UnionUnion()
		{
			this.Type = IUiStyleBaseOfLevelD_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060364E5 RID: 222437 RVA: 0x00761819 File Offset: 0x0075FA19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060364E6 RID: 222438 RVA: 0x0076182B File Offset: 0x0075FA2B
		public IUiStyleBaseOfLevelDT AsIUiStyleBaseOfLevelD()
		{
			return this.As<IUiStyleBaseOfLevelDT>();
		}

		// Token: 0x060364E7 RID: 222439 RVA: 0x00761833 File Offset: 0x0075FA33
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStyleBaseOfLevelD(IUiStyleBaseOfLevelDT _iuistylebaseofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStyleBaseOfLevelD,
				Value = _iuistylebaseofleveld
			};
		}

		// Token: 0x060364E8 RID: 222440 RVA: 0x00761848 File Offset: 0x0075FA48
		public IUiStyleGiantSubtitleOfLevelDT AsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.As<IUiStyleGiantSubtitleOfLevelDT>();
		}

		// Token: 0x060364E9 RID: 222441 RVA: 0x00761850 File Offset: 0x0075FA50
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStyleGiantSubtitleOfLevelD(IUiStyleGiantSubtitleOfLevelDT _iuistylegiantsubtitleofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStyleGiantSubtitleOfLevelD,
				Value = _iuistylegiantsubtitleofleveld
			};
		}

		// Token: 0x060364EA RID: 222442 RVA: 0x00761865 File Offset: 0x0075FA65
		public IUiStylePlayPianoOfLevelDT AsIUiStylePlayPianoOfLevelD()
		{
			return this.As<IUiStylePlayPianoOfLevelDT>();
		}

		// Token: 0x060364EB RID: 222443 RVA: 0x0076186D File Offset: 0x0075FA6D
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStylePlayPianoOfLevelD(IUiStylePlayPianoOfLevelDT _iuistyleplaypianoofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStylePlayPianoOfLevelD,
				Value = _iuistyleplaypianoofleveld
			};
		}

		// Token: 0x060364EC RID: 222444 RVA: 0x00761884 File Offset: 0x0075FA84
		public static int Pack(FlatBufferBuilder builder, IUiStyleBaseOfLevelD_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUiStyleBaseOfLevelD_Union.IUiStyleBaseOfLevelD:
				return IUiStyleBaseOfLevelD.Pack(builder, _o.AsIUiStyleBaseOfLevelD()).Value;
			case IUiStyleBaseOfLevelD_Union.IUiStyleGiantSubtitleOfLevelD:
				return IUiStyleGiantSubtitleOfLevelD.Pack(builder, _o.AsIUiStyleGiantSubtitleOfLevelD()).Value;
			case IUiStyleBaseOfLevelD_Union.IUiStylePlayPianoOfLevelD:
				return IUiStylePlayPianoOfLevelD.Pack(builder, _o.AsIUiStylePlayPianoOfLevelD()).Value;
			default:
				return 0;
			}
		}
	}
}
