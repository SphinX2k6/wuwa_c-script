using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CE RID: 4302
	public struct SlashAndTowerSeason : IFlatbufferObject
	{
		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600D698 RID: 54936 RVA: 0x0031B160 File Offset: 0x00319360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D699 RID: 54937 RVA: 0x0031B16D File Offset: 0x0031936D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x0031B174 File Offset: 0x00319374
		public static SlashAndTowerSeason GetRootAsSlashAndTowerSeason(ByteBuffer _bb)
		{
			return SlashAndTowerSeason.GetRootAsSlashAndTowerSeason(_bb, default(SlashAndTowerSeason));
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x0031B190 File Offset: 0x00319390
		public static SlashAndTowerSeason GetRootAsSlashAndTowerSeason(ByteBuffer _bb, SlashAndTowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x0031B1AD File Offset: 0x003193AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x0031B1BC File Offset: 0x003193BC
		public SlashAndTowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600D69E RID: 54942 RVA: 0x0031B1CC File Offset: 0x003193CC
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

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x0031B208 File Offset: 0x00319408
		public int BattleScoreId
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

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x0031B244 File Offset: 0x00319444
		public string BuringTideDesc
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

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x0031B27B File Offset: 0x0031947B
		public Span<byte> GetBuringTideDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x0031B28A File Offset: 0x0031948A
		public byte[] GetBuringTideDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x0031B2A4 File Offset: 0x003194A4
		public string HotDesc
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

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x0031B2DC File Offset: 0x003194DC
		public Span<byte> GetHotDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x0031B2EC File Offset: 0x003194EC
		public byte[] GetHotDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600D6A6 RID: 54950 RVA: 0x0031B304 File Offset: 0x00319504
		public bool IsOpenHot
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005200 RID: 20992
		private Table __p;
	}
}
