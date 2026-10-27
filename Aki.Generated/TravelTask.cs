using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001173 RID: 4467
	public struct TravelTask : IFlatbufferObject
	{
		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600E50C RID: 58636 RVA: 0x0033BDD0 File Offset: 0x00339FD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E50D RID: 58637 RVA: 0x0033BDDD File Offset: 0x00339FDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E50E RID: 58638 RVA: 0x0033BDE4 File Offset: 0x00339FE4
		public static TravelTask GetRootAsTravelTask(ByteBuffer _bb)
		{
			return TravelTask.GetRootAsTravelTask(_bb, default(TravelTask));
		}

		// Token: 0x0600E50F RID: 58639 RVA: 0x0033BE00 File Offset: 0x0033A000
		public static TravelTask GetRootAsTravelTask(ByteBuffer _bb, TravelTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E510 RID: 58640 RVA: 0x0033BE1D File Offset: 0x0033A01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E511 RID: 58641 RVA: 0x0033BE2C File Offset: 0x0033A02C
		public TravelTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x0033BE3C File Offset: 0x0033A03C
		public int TaskId
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

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x0033BE78 File Offset: 0x0033A078
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

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x0033BEB4 File Offset: 0x0033A0B4
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x0033BEEB File Offset: 0x0033A0EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E516 RID: 58646 RVA: 0x0033BEFA File Offset: 0x0033A0FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600E517 RID: 58647 RVA: 0x0033BF14 File Offset: 0x0033A114
		public int TaskReward
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

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x0600E518 RID: 58648 RVA: 0x0033BF54 File Offset: 0x0033A154
		public int AreaId
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

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x0600E519 RID: 58649 RVA: 0x0033BF94 File Offset: 0x0033A194
		public int JumpId
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

		// Token: 0x040052B9 RID: 21177
		private Table __p;
	}
}
