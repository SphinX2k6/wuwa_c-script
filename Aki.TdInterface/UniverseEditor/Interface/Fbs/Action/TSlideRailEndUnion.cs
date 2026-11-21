using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FCE RID: 32718
	public class TSlideRailEndUnion
	{
		// Token: 0x1700F301 RID: 62209
		// (get) Token: 0x0603AE99 RID: 241305 RVA: 0x007EA068 File Offset: 0x007E8268
		// (set) Token: 0x0603AE9A RID: 241306 RVA: 0x007EA070 File Offset: 0x007E8270
		public TSlideRailEnd Type { get; set; }

		// Token: 0x1700F302 RID: 62210
		// (get) Token: 0x0603AE9B RID: 241307 RVA: 0x007EA079 File Offset: 0x007E8279
		// (set) Token: 0x0603AE9C RID: 241308 RVA: 0x007EA081 File Offset: 0x007E8281
		public object Value { get; set; }

		// Token: 0x0603AE9D RID: 241309 RVA: 0x007EA08A File Offset: 0x007E828A
		public TSlideRailEndUnion()
		{
			this.Type = TSlideRailEnd.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE9E RID: 241310 RVA: 0x007EA0A0 File Offset: 0x007E82A0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE9F RID: 241311 RVA: 0x007EA0B2 File Offset: 0x007E82B2
		public IAiFollowerSlideRailEndT AsIAiFollowerSlideRailEnd()
		{
			return this.As<IAiFollowerSlideRailEndT>();
		}

		// Token: 0x0603AEA0 RID: 241312 RVA: 0x007EA0BA File Offset: 0x007E82BA
		public static TSlideRailEndUnion FromIAiFollowerSlideRailEnd(IAiFollowerSlideRailEndT _iaifollowersliderailend)
		{
			return new TSlideRailEndUnion
			{
				Type = TSlideRailEnd.IAiFollowerSlideRailEnd,
				Value = _iaifollowersliderailend
			};
		}

		// Token: 0x0603AEA1 RID: 241313 RVA: 0x007EA0CF File Offset: 0x007E82CF
		public IPlayerSlideRailEndT AsIPlayerSlideRailEnd()
		{
			return this.As<IPlayerSlideRailEndT>();
		}

		// Token: 0x0603AEA2 RID: 241314 RVA: 0x007EA0D7 File Offset: 0x007E82D7
		public static TSlideRailEndUnion FromIPlayerSlideRailEnd(IPlayerSlideRailEndT _iplayersliderailend)
		{
			return new TSlideRailEndUnion
			{
				Type = TSlideRailEnd.IPlayerSlideRailEnd,
				Value = _iplayersliderailend
			};
		}

		// Token: 0x0603AEA3 RID: 241315 RVA: 0x007EA0EC File Offset: 0x007E82EC
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
