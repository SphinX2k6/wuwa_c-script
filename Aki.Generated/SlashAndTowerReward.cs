using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C8 RID: 4552
	public struct SlashAndTowerReward : IFlatbufferObject
	{
		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x00339ED6 File Offset: 0x003380D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x00339EE3 File Offset: 0x003380E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x00339EEC File Offset: 0x003380EC
		public static SlashAndTowerReward GetRootAsSlashAndTowerReward(ByteBuffer _bb)
		{
			return SlashAndTowerReward.GetRootAsSlashAndTowerReward(_bb, default(SlashAndTowerReward));
		}

		// Token: 0x0600DE6A RID: 56938 RVA: 0x00339F08 File Offset: 0x00338108
		public static SlashAndTowerReward GetRootAsSlashAndTowerReward(ByteBuffer _bb, SlashAndTowerReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE6B RID: 56939 RVA: 0x00339F25 File Offset: 0x00338125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x00339F34 File Offset: 0x00338134
		public SlashAndTowerReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x00339F44 File Offset: 0x00338144
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

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600DE6E RID: 56942 RVA: 0x00339F80 File Offset: 0x00338180
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

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x00339FBC File Offset: 0x003381BC
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

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600DE70 RID: 56944 RVA: 0x00339FF8 File Offset: 0x003381F8
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

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600DE71 RID: 56945 RVA: 0x0033A038 File Offset: 0x00338238
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

		// Token: 0x0600DE72 RID: 56946 RVA: 0x0033A070 File Offset: 0x00338270
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DE73 RID: 56947 RVA: 0x0033A080 File Offset: 0x00338280
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600DE74 RID: 56948 RVA: 0x0033A098 File Offset: 0x00338298
		public bool EndLessReward
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040057FE RID: 22526
		private Table __p;
	}
}
