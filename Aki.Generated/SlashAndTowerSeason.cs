using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C9 RID: 4553
	public struct SlashAndTowerSeason : IFlatbufferObject
	{
		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600DE75 RID: 56949 RVA: 0x0033A0D8 File Offset: 0x003382D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE76 RID: 56950 RVA: 0x0033A0E5 File Offset: 0x003382E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE77 RID: 56951 RVA: 0x0033A0EC File Offset: 0x003382EC
		public static SlashAndTowerSeason GetRootAsSlashAndTowerSeason(ByteBuffer _bb)
		{
			return SlashAndTowerSeason.GetRootAsSlashAndTowerSeason(_bb, default(SlashAndTowerSeason));
		}

		// Token: 0x0600DE78 RID: 56952 RVA: 0x0033A108 File Offset: 0x00338308
		public static SlashAndTowerSeason GetRootAsSlashAndTowerSeason(ByteBuffer _bb, SlashAndTowerSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE79 RID: 56953 RVA: 0x0033A125 File Offset: 0x00338325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE7A RID: 56954 RVA: 0x0033A134 File Offset: 0x00338334
		public SlashAndTowerSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x0033A144 File Offset: 0x00338344
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

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x0033A180 File Offset: 0x00338380
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

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600DE7D RID: 56957 RVA: 0x0033A1BC File Offset: 0x003383BC
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

		// Token: 0x0600DE7E RID: 56958 RVA: 0x0033A1F3 File Offset: 0x003383F3
		public Span<byte> GetBuringTideDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DE7F RID: 56959 RVA: 0x0033A202 File Offset: 0x00338402
		public byte[] GetBuringTideDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600DE80 RID: 56960 RVA: 0x0033A21C File Offset: 0x0033841C
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

		// Token: 0x0600DE81 RID: 56961 RVA: 0x0033A254 File Offset: 0x00338454
		public Span<byte> GetHotDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DE82 RID: 56962 RVA: 0x0033A264 File Offset: 0x00338464
		public byte[] GetHotDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x0033A27C File Offset: 0x0033847C
		public bool IsOpenHot
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040057FF RID: 22527
		private Table __p;
	}
}
