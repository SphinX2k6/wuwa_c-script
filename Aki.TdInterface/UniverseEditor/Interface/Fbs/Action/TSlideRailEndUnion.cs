using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007796 RID: 30614
	public class TSlideRailEndUnion
	{
		// Token: 0x1700E6A7 RID: 59047
		// (get) Token: 0x0603791E RID: 227614 RVA: 0x00784B68 File Offset: 0x00782D68
		// (set) Token: 0x0603791F RID: 227615 RVA: 0x00784B70 File Offset: 0x00782D70
		public TSlideRailEnd Type { get; set; }

		// Token: 0x1700E6A8 RID: 59048
		// (get) Token: 0x06037920 RID: 227616 RVA: 0x00784B79 File Offset: 0x00782D79
		// (set) Token: 0x06037921 RID: 227617 RVA: 0x00784B81 File Offset: 0x00782D81
		public object Value { get; set; }

		// Token: 0x06037922 RID: 227618 RVA: 0x00784B8A File Offset: 0x00782D8A
		public TSlideRailEndUnion()
		{
			this.Type = TSlideRailEnd.NONE;
			this.Value = null;
		}

		// Token: 0x06037923 RID: 227619 RVA: 0x00784BA0 File Offset: 0x00782DA0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037924 RID: 227620 RVA: 0x00784BB2 File Offset: 0x00782DB2
		public IAiFollowerSlideRailEndT AsIAiFollowerSlideRailEnd()
		{
			return this.As<IAiFollowerSlideRailEndT>();
		}

		// Token: 0x06037925 RID: 227621 RVA: 0x00784BBA File Offset: 0x00782DBA
		public static TSlideRailEndUnion FromIAiFollowerSlideRailEnd(IAiFollowerSlideRailEndT _iaifollowersliderailend)
		{
			return new TSlideRailEndUnion
			{
				Type = TSlideRailEnd.IAiFollowerSlideRailEnd,
				Value = _iaifollowersliderailend
			};
		}

		// Token: 0x06037926 RID: 227622 RVA: 0x00784BCF File Offset: 0x00782DCF
		public IPlayerSlideRailEndT AsIPlayerSlideRailEnd()
		{
			return this.As<IPlayerSlideRailEndT>();
		}

		// Token: 0x06037927 RID: 227623 RVA: 0x00784BD7 File Offset: 0x00782DD7
		public static TSlideRailEndUnion FromIPlayerSlideRailEnd(IPlayerSlideRailEndT _iplayersliderailend)
		{
			return new TSlideRailEndUnion
			{
				Type = TSlideRailEnd.IPlayerSlideRailEnd,
				Value = _iplayersliderailend
			};
		}

		// Token: 0x06037928 RID: 227624 RVA: 0x00784BEC File Offset: 0x00782DEC
		public static int Pack(FlatBufferBuilder builder, TSlideRailEndUnion _o)
		{
			TSlideRailEnd type = _o.Type;
			if (type == TSlideRailEnd.IAiFollowerSlideRailEnd)
			{
				return IAiFollowerSlideRailEnd.Pack(builder, _o.AsIAiFollowerSlideRailEnd()).Value;
			}
			if (type != TSlideRailEnd.IPlayerSlideRailEnd)
			{
				return 0;
			}
			return IPlayerSlideRailEnd.Pack(builder, _o.AsIPlayerSlideRailEnd()).Value;
		}
	}
}
