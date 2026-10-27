using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4F RID: 3407
	public struct HonamiStoryScoreReward : IFlatbufferObject
	{
		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x0025A444 File Offset: 0x00258644
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x0025A451 File Offset: 0x00258651
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x0025A458 File Offset: 0x00258658
		public static HonamiStoryScoreReward GetRootAsHonamiStoryScoreReward(ByteBuffer _bb)
		{
			return HonamiStoryScoreReward.GetRootAsHonamiStoryScoreReward(_bb, default(HonamiStoryScoreReward));
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x0025A474 File Offset: 0x00258674
		public static HonamiStoryScoreReward GetRootAsHonamiStoryScoreReward(ByteBuffer _bb, HonamiStoryScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x0025A491 File Offset: 0x00258691
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x0025A4A0 File Offset: 0x002586A0
		public HonamiStoryScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x0025A4B0 File Offset: 0x002586B0
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06008147 RID: 33095 RVA: 0x0025A4EC File Offset: 0x002586EC
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x0025A528 File Offset: 0x00258728
		public int Score
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06008149 RID: 33097 RVA: 0x0025A564 File Offset: 0x00258764
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x0025A5A4 File Offset: 0x002587A4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x0025A5DC File Offset: 0x002587DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x0025A5EC File Offset: 0x002587EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x0600814D RID: 33101 RVA: 0x0025A604 File Offset: 0x00258804
		public string LockTip
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x0025A63C File Offset: 0x0025883C
		public Span<byte> GetLockTipBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x0025A64C File Offset: 0x0025884C
		public byte[] GetLockTipArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DCC RID: 19916
		private Table __p;
	}
}
