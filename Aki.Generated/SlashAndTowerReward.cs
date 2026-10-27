using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010CD RID: 4301
	public struct SlashAndTowerReward : IFlatbufferObject
	{
		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x0031AF5D File Offset: 0x0031915D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D68B RID: 54923 RVA: 0x0031AF6A File Offset: 0x0031916A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D68C RID: 54924 RVA: 0x0031AF74 File Offset: 0x00319174
		public static SlashAndTowerReward GetRootAsSlashAndTowerReward(ByteBuffer _bb)
		{
			return SlashAndTowerReward.GetRootAsSlashAndTowerReward(_bb, default(SlashAndTowerReward));
		}

		// Token: 0x0600D68D RID: 54925 RVA: 0x0031AF90 File Offset: 0x00319190
		public static SlashAndTowerReward GetRootAsSlashAndTowerReward(ByteBuffer _bb, SlashAndTowerReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D68E RID: 54926 RVA: 0x0031AFAD File Offset: 0x003191AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D68F RID: 54927 RVA: 0x0031AFBC File Offset: 0x003191BC
		public SlashAndTowerReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600D690 RID: 54928 RVA: 0x0031AFCC File Offset: 0x003191CC
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

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600D691 RID: 54929 RVA: 0x0031B008 File Offset: 0x00319208
		public int BelongToSeason
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

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600D692 RID: 54930 RVA: 0x0031B044 File Offset: 0x00319244
		public int SumScore
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

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600D693 RID: 54931 RVA: 0x0031B080 File Offset: 0x00319280
		public int RewardId
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

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600D694 RID: 54932 RVA: 0x0031B0C0 File Offset: 0x003192C0
		public string Desc
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

		// Token: 0x0600D695 RID: 54933 RVA: 0x0031B0F8 File Offset: 0x003192F8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D696 RID: 54934 RVA: 0x0031B108 File Offset: 0x00319308
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600D697 RID: 54935 RVA: 0x0031B120 File Offset: 0x00319320
		public bool EndLessReward
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051FF RID: 20991
		private Table __p;
	}
}
