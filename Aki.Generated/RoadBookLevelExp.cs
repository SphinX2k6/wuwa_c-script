using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD2 RID: 4050
	public struct RoadBookLevelExp : IFlatbufferObject
	{
		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x0600BDC4 RID: 48580 RVA: 0x002E2178 File Offset: 0x002E0378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x002E2185 File Offset: 0x002E0385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x002E218C File Offset: 0x002E038C
		public static RoadBookLevelExp GetRootAsRoadBookLevelExp(ByteBuffer _bb)
		{
			return RoadBookLevelExp.GetRootAsRoadBookLevelExp(_bb, default(RoadBookLevelExp));
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x002E21A8 File Offset: 0x002E03A8
		public static RoadBookLevelExp GetRootAsRoadBookLevelExp(ByteBuffer _bb, RoadBookLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x002E21C5 File Offset: 0x002E03C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDC9 RID: 48585 RVA: 0x002E21D4 File Offset: 0x002E03D4
		public RoadBookLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600BDCA RID: 48586 RVA: 0x002E21E4 File Offset: 0x002E03E4
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

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600BDCB RID: 48587 RVA: 0x002E2220 File Offset: 0x002E0420
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

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600BDCC RID: 48588 RVA: 0x002E225C File Offset: 0x002E045C
		public int Level
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

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600BDCD RID: 48589 RVA: 0x002E2298 File Offset: 0x002E0498
		public int NeedExp
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

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600BDCE RID: 48590 RVA: 0x002E22D8 File Offset: 0x002E04D8
		public int RewardDropId
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

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600BDCF RID: 48591 RVA: 0x002E2318 File Offset: 0x002E0518
		public string TipsLock
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

		// Token: 0x0600BDD0 RID: 48592 RVA: 0x002E2350 File Offset: 0x002E0550
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x002E2360 File Offset: 0x002E0560
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600BDD2 RID: 48594 RVA: 0x002E2378 File Offset: 0x002E0578
		public string TipsDone
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

		// Token: 0x0600BDD3 RID: 48595 RVA: 0x002E23B0 File Offset: 0x002E05B0
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BDD4 RID: 48596 RVA: 0x002E23C0 File Offset: 0x002E05C0
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050AE RID: 20654
		private Table __p;
	}
}
