using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F87 RID: 3975
	public struct OnlineMotorGlobalTask : IFlatbufferObject
	{
		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x002BF9AC File Offset: 0x002BDBAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x002BF9B9 File Offset: 0x002BDBB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x002BF9C0 File Offset: 0x002BDBC0
		public static OnlineMotorGlobalTask GetRootAsOnlineMotorGlobalTask(ByteBuffer _bb)
		{
			return OnlineMotorGlobalTask.GetRootAsOnlineMotorGlobalTask(_bb, default(OnlineMotorGlobalTask));
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x002BF9DC File Offset: 0x002BDBDC
		public static OnlineMotorGlobalTask GetRootAsOnlineMotorGlobalTask(ByteBuffer _bb, OnlineMotorGlobalTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x002BF9F9 File Offset: 0x002BDBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x002BFA08 File Offset: 0x002BDC08
		public OnlineMotorGlobalTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x0600A75D RID: 42845 RVA: 0x002BFA18 File Offset: 0x002BDC18
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

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x0600A75E RID: 42846 RVA: 0x002BFA54 File Offset: 0x002BDC54
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

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x0600A75F RID: 42847 RVA: 0x002BFA90 File Offset: 0x002BDC90
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

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x0600A760 RID: 42848 RVA: 0x002BFACC File Offset: 0x002BDCCC
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

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x0600A761 RID: 42849 RVA: 0x002BFB0C File Offset: 0x002BDD0C
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

		// Token: 0x0600A762 RID: 42850 RVA: 0x002BFB44 File Offset: 0x002BDD44
		public Span<byte> GetPlayCountDesBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x002BFB54 File Offset: 0x002BDD54
		public byte[] GetPlayCountDesArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x0600A764 RID: 42852 RVA: 0x002BFB6C File Offset: 0x002BDD6C
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

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x002BFBAC File Offset: 0x002BDDAC
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

		// Token: 0x0600A766 RID: 42854 RVA: 0x002BFBE4 File Offset: 0x002BDDE4
		public Span<byte> GetChampionDesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x002BFBF4 File Offset: 0x002BDDF4
		public byte[] GetChampionDesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x0600A768 RID: 42856 RVA: 0x002BFC0C File Offset: 0x002BDE0C
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

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x002BFC4C File Offset: 0x002BDE4C
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

		// Token: 0x0600A76A RID: 42858 RVA: 0x002BFC84 File Offset: 0x002BDE84
		public Span<byte> GetSpeedLapDesBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x002BFC94 File Offset: 0x002BDE94
		public byte[] GetSpeedLapDesArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x002BFCAC File Offset: 0x002BDEAC
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

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x0600A76D RID: 42861 RVA: 0x002BFCEC File Offset: 0x002BDEEC
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

		// Token: 0x0600A76E RID: 42862 RVA: 0x002BFD24 File Offset: 0x002BDF24
		public Span<byte> GetFirstRunnerDesBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x002BFD34 File Offset: 0x002BDF34
		public byte[] GetFirstRunnerDesArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0400553B RID: 21819
		private Table __p;
	}
}
