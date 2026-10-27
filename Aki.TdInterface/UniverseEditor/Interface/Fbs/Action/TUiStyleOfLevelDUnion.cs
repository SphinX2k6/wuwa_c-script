using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F6 RID: 30710
	public class TUiStyleOfLevelDUnion
	{
		// Token: 0x1700E6E7 RID: 59111
		// (get) Token: 0x06037B32 RID: 228146 RVA: 0x00787F10 File Offset: 0x00786110
		// (set) Token: 0x06037B33 RID: 228147 RVA: 0x00787F18 File Offset: 0x00786118
		public TUiStyleOfLevelD Type { get; set; }

		// Token: 0x1700E6E8 RID: 59112
		// (get) Token: 0x06037B34 RID: 228148 RVA: 0x00787F21 File Offset: 0x00786121
		// (set) Token: 0x06037B35 RID: 228149 RVA: 0x00787F29 File Offset: 0x00786129
		public object Value { get; set; }

		// Token: 0x06037B36 RID: 228150 RVA: 0x00787F32 File Offset: 0x00786132
		public TUiStyleOfLevelDUnion()
		{
			this.Type = TUiStyleOfLevelD.NONE;
			this.Value = null;
		}

		// Token: 0x06037B37 RID: 228151 RVA: 0x00787F48 File Offset: 0x00786148
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037B38 RID: 228152 RVA: 0x00787F5A File Offset: 0x0078615A
		public IUiStyleGiantSubtitleOfLevelDT AsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.As<IUiStyleGiantSubtitleOfLevelDT>();
		}

		// Token: 0x06037B39 RID: 228153 RVA: 0x00787F62 File Offset: 0x00786162
		public static TUiStyleOfLevelDUnion FromIUiStyleGiantSubtitleOfLevelD(IUiStyleGiantSubtitleOfLevelDT _iuistylegiantsubtitleofleveld)
		{
			return new TUiStyleOfLevelDUnion
			{
				Type = TUiStyleOfLevelD.IUiStyleGiantSubtitleOfLevelD,
				Value = _iuistylegiantsubtitleofleveld
			};
		}

		// Token: 0x06037B3A RID: 228154 RVA: 0x00787F77 File Offset: 0x00786177
		public IUiStylePlayPianoOfLevelDT AsIUiStylePlayPianoOfLevelD()
		{
			return this.As<IUiStylePlayPianoOfLevelDT>();
		}

		// Token: 0x06037B3B RID: 228155 RVA: 0x00787F7F File Offset: 0x0078617F
		public static TUiStyleOfLevelDUnion FromIUiStylePlayPianoOfLevelD(IUiStylePlayPianoOfLevelDT _iuistyleplaypianoofleveld)
		{
			return new TUiStyleOfLevelDUnion
			{
				Type = TUiStyleOfLevelD.IUiStylePlayPianoOfLevelD,
				Value = _iuistyleplaypianoofleveld
			};
		}

		// Token: 0x06037B3C RID: 228156 RVA: 0x00787F94 File Offset: 0x00786194
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
