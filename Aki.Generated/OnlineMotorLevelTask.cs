using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA4 RID: 3748
	public struct OnlineMotorLevelTask : IFlatbufferObject
	{
		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600A185 RID: 41349 RVA: 0x002A303D File Offset: 0x002A123D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x002A304A File Offset: 0x002A124A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x002A3054 File Offset: 0x002A1254
		public static OnlineMotorLevelTask GetRootAsOnlineMotorLevelTask(ByteBuffer _bb)
		{
			return OnlineMotorLevelTask.GetRootAsOnlineMotorLevelTask(_bb, default(OnlineMotorLevelTask));
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x002A3070 File Offset: 0x002A1270
		public static OnlineMotorLevelTask GetRootAsOnlineMotorLevelTask(ByteBuffer _bb, OnlineMotorLevelTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x002A308D File Offset: 0x002A128D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x002A309C File Offset: 0x002A129C
		public OnlineMotorLevelTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x002A30AC File Offset: 0x002A12AC
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

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600A18C RID: 41356 RVA: 0x002A30E8 File Offset: 0x002A12E8
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

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600A18D RID: 41357 RVA: 0x002A3124 File Offset: 0x002A1324
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

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600A18E RID: 41358 RVA: 0x002A3160 File Offset: 0x002A1360
		public int LevelId
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

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600A18F RID: 41359 RVA: 0x002A31A0 File Offset: 0x002A13A0
		public int PlayCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600A190 RID: 41360 RVA: 0x002A31E0 File Offset: 0x002A13E0
		public string PlayCountDes
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

		// Token: 0x0600A191 RID: 41361 RVA: 0x002A3218 File Offset: 0x002A1418
		public Span<byte> GetPlayCountDesBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x002A3228 File Offset: 0x002A1428
		public byte[] GetPlayCountDesArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600A193 RID: 41363 RVA: 0x002A3240 File Offset: 0x002A1440
		public int Champion
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x002A3280 File Offset: 0x002A1480
		public string ChampionDes
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x002A32B8 File Offset: 0x002A14B8
		public Span<byte> GetChampionDesBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x002A32C8 File Offset: 0x002A14C8
		public byte[] GetChampionDesArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x0600A197 RID: 41367 RVA: 0x002A32E0 File Offset: 0x002A14E0
		public int SpeedLap
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x0600A198 RID: 41368 RVA: 0x002A3320 File Offset: 0x002A1520
		public string SpeedLapDes
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x002A3358 File Offset: 0x002A1558
		public Span<byte> GetSpeedLapDesBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x002A3368 File Offset: 0x002A1568
		public byte[] GetSpeedLapDesArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x0600A19B RID: 41371 RVA: 0x002A3380 File Offset: 0x002A1580
		public int FirstRunner
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x0600A19C RID: 41372 RVA: 0x002A33C0 File Offset: 0x002A15C0
		public string FirstRunnerDes
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x002A33F8 File Offset: 0x002A15F8
		public Span<byte> GetFirstRunnerDesBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x002A3408 File Offset: 0x002A1608
		public byte[] GetFirstRunnerDesArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F58 RID: 20312
		private Table __p;
	}
}
