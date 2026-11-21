using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008034 RID: 32820
	public class TUiStyleOfLevelDUnion
	{
		// Token: 0x1700F345 RID: 62277
		// (get) Token: 0x0603B0D7 RID: 241879 RVA: 0x007ED888 File Offset: 0x007EBA88
		// (set) Token: 0x0603B0D8 RID: 241880 RVA: 0x007ED890 File Offset: 0x007EBA90
		public TUiStyleOfLevelD Type { get; set; }

		// Token: 0x1700F346 RID: 62278
		// (get) Token: 0x0603B0D9 RID: 241881 RVA: 0x007ED899 File Offset: 0x007EBA99
		// (set) Token: 0x0603B0DA RID: 241882 RVA: 0x007ED8A1 File Offset: 0x007EBAA1
		public object Value { get; set; }

		// Token: 0x0603B0DB RID: 241883 RVA: 0x007ED8AA File Offset: 0x007EBAAA
		public TUiStyleOfLevelDUnion()
		{
			this.Type = TUiStyleOfLevelD.NONE;
			this.Value = null;
		}

		// Token: 0x0603B0DC RID: 241884 RVA: 0x007ED8C0 File Offset: 0x007EBAC0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B0DD RID: 241885 RVA: 0x007ED8D2 File Offset: 0x007EBAD2
		public IUiStyleGiantSubtitleOfLevelDT AsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.As<IUiStyleGiantSubtitleOfLevelDT>();
		}

		// Token: 0x0603B0DE RID: 241886 RVA: 0x007ED8DA File Offset: 0x007EBADA
		public static TUiStyleOfLevelDUnion FromIUiStyleGiantSubtitleOfLevelD(IUiStyleGiantSubtitleOfLevelDT _iuistylegiantsubtitleofleveld)
		{
			return new TUiStyleOfLevelDUnion
			{
				Type = TUiStyleOfLevelD.IUiStyleGiantSubtitleOfLevelD,
				Value = _iuistylegiantsubtitleofleveld
			};
		}

		// Token: 0x0603B0DF RID: 241887 RVA: 0x007ED8EF File Offset: 0x007EBAEF
		public IUiStylePlayPianoOfLevelDT AsIUiStylePlayPianoOfLevelD()
		{
			return this.As<IUiStylePlayPianoOfLevelDT>();
		}

		// Token: 0x0603B0E0 RID: 241888 RVA: 0x007ED8F7 File Offset: 0x007EBAF7
		public static TUiStyleOfLevelDUnion FromIUiStylePlayPianoOfLevelD(IUiStylePlayPianoOfLevelDT _iuistyleplaypianoofleveld)
		{
			return new TUiStyleOfLevelDUnion
			{
				Type = TUiStyleOfLevelD.IUiStylePlayPianoOfLevelD,
				Value = _iuistyleplaypianoofleveld
			};
		}

		// Token: 0x0603B0E1 RID: 241889 RVA: 0x007ED90C File Offset: 0x007EBB0C
		public static int Pack(FlatBufferBuilder builder, TUiStyleOfLevelDUnion _o)
		{
			TUiStyleOfLevelD type = _o.Type;
			if (type == TUiStyleOfLevelD.IUiStyleGiantSubtitleOfLevelD)
			{
				return IUiStyleGiantSubtitleOfLevelD.Pack(builder, _o.AsIUiStyleGiantSubtitleOfLevelD()).Value;
			}
			if (type != TUiStyleOfLevelD.IUiStylePlayPianoOfLevelD)
			{
				return 0;
			}
			return IUiStylePlayPianoOfLevelD.Pack(builder, _o.AsIUiStylePlayPianoOfLevelD()).Value;
		}
	}
}
