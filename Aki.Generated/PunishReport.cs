using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001047 RID: 4167
	public struct PunishReport : IFlatbufferObject
	{
		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x0600BA16 RID: 47638 RVA: 0x002E92B1 File Offset: 0x002E74B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x002E92BE File Offset: 0x002E74BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x002E92C8 File Offset: 0x002E74C8
		public static PunishReport GetRootAsPunishReport(ByteBuffer _bb)
		{
			return PunishReport.GetRootAsPunishReport(_bb, default(PunishReport));
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x002E92E4 File Offset: 0x002E74E4
		public static PunishReport GetRootAsPunishReport(ByteBuffer _bb, PunishReport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x002E9301 File Offset: 0x002E7501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x002E9310 File Offset: 0x002E7510
		public PunishReport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x002E9320 File Offset: 0x002E7520
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

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x0600BA1D RID: 47645 RVA: 0x002E935C File Offset: 0x002E755C
		public string CondDescription1
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x002E9393 File Offset: 0x002E7593
		public Span<byte> GetCondDescription1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x002E93A2 File Offset: 0x002E75A2
		public byte[] GetCondDescription1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x002E93BC File Offset: 0x002E75BC
		public string CondDescription2
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

		// Token: 0x0600BA21 RID: 47649 RVA: 0x002E93F3 File Offset: 0x002E75F3
		public Span<byte> GetCondDescription2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x002E9402 File Offset: 0x002E7602
		public byte[] GetCondDescription2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600BA23 RID: 47651 RVA: 0x002E941C File Offset: 0x002E761C
		public string CondDescription3
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x002E9454 File Offset: 0x002E7654
		public Span<byte> GetCondDescription3Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x002E9464 File Offset: 0x002E7664
		public byte[] GetCondDescription3Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002E947C File Offset: 0x002E767C
		public string Cond1Key
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

		// Token: 0x0600BA27 RID: 47655 RVA: 0x002E94B4 File Offset: 0x002E76B4
		public Span<byte> GetCond1KeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x002E94C4 File Offset: 0x002E76C4
		public byte[] GetCond1KeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x0600BA29 RID: 47657 RVA: 0x002E94DC File Offset: 0x002E76DC
		public string Cond2ey
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

		// Token: 0x0600BA2A RID: 47658 RVA: 0x002E9514 File Offset: 0x002E7714
		public Span<byte> GetCond2eyBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x002E9524 File Offset: 0x002E7724
		public byte[] GetCond2eyArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002E953C File Offset: 0x002E773C
		public string Cond3Key
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

		// Token: 0x0600BA2D RID: 47661 RVA: 0x002E9574 File Offset: 0x002E7774
		public Span<byte> GetCond3KeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x002E9584 File Offset: 0x002E7784
		public byte[] GetCond3KeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x0600BA2F RID: 47663 RVA: 0x002E959C File Offset: 0x002E779C
		public string GetBoxKey
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

		// Token: 0x0600BA30 RID: 47664 RVA: 0x002E95D4 File Offset: 0x002E77D4
		public Span<byte> GetGetBoxKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x002E95E4 File Offset: 0x002E77E4
		public byte[] GetGetBoxKeyArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005615 RID: 22037
		private Table __p;
	}
}
