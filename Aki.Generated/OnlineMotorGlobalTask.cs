using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA2 RID: 3746
	public struct OnlineMotorGlobalTask : IFlatbufferObject
	{
		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x0600A137 RID: 41271 RVA: 0x002A24C4 File Offset: 0x002A06C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x002A24D1 File Offset: 0x002A06D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x002A24D8 File Offset: 0x002A06D8
		public static OnlineMotorGlobalTask GetRootAsOnlineMotorGlobalTask(ByteBuffer _bb)
		{
			return OnlineMotorGlobalTask.GetRootAsOnlineMotorGlobalTask(_bb, default(OnlineMotorGlobalTask));
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x002A24F4 File Offset: 0x002A06F4
		public static OnlineMotorGlobalTask GetRootAsOnlineMotorGlobalTask(ByteBuffer _bb, OnlineMotorGlobalTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x002A2511 File Offset: 0x002A0711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x002A2520 File Offset: 0x002A0720
		public OnlineMotorGlobalTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x0600A13D RID: 41277 RVA: 0x002A2530 File Offset: 0x002A0730
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

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x0600A13E RID: 41278 RVA: 0x002A256C File Offset: 0x002A076C
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

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x002A25A8 File Offset: 0x002A07A8
		public int DropId
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

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600A140 RID: 41280 RVA: 0x002A25E4 File Offset: 0x002A07E4
		public int PlayCount
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

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x0600A141 RID: 41281 RVA: 0x002A2624 File Offset: 0x002A0824
		public string PlayCountDes
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

		// Token: 0x0600A142 RID: 41282 RVA: 0x002A265C File Offset: 0x002A085C
		public Span<byte> GetPlayCountDesBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x002A266C File Offset: 0x002A086C
		public byte[] GetPlayCountDesArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x0600A144 RID: 41284 RVA: 0x002A2684 File Offset: 0x002A0884
		public int Champion
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x002A26C4 File Offset: 0x002A08C4
		public string ChampionDes
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x002A26FC File Offset: 0x002A08FC
		public Span<byte> GetChampionDesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x002A270C File Offset: 0x002A090C
		public byte[] GetChampionDesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600A148 RID: 41288 RVA: 0x002A2724 File Offset: 0x002A0924
		public int SpeedLap
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x002A2764 File Offset: 0x002A0964
		public string SpeedLapDes
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x002A279C File Offset: 0x002A099C
		public Span<byte> GetSpeedLapDesBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x002A27AC File Offset: 0x002A09AC
		public byte[] GetSpeedLapDesArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600A14C RID: 41292 RVA: 0x002A27C4 File Offset: 0x002A09C4
		public int FirstRunner
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x002A2804 File Offset: 0x002A0A04
		public string FirstRunnerDes
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x002A283C File Offset: 0x002A0A3C
		public Span<byte> GetFirstRunnerDesBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x002A284C File Offset: 0x002A0A4C
		public byte[] GetFirstRunnerDesArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F56 RID: 20310
		private Table __p;
	}
}
