using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001082 RID: 4226
	public struct RealmBetweenLevelExp : IFlatbufferObject
	{
		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x0600BF90 RID: 49040 RVA: 0x002F48F5 File Offset: 0x002F2AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF91 RID: 49041 RVA: 0x002F4902 File Offset: 0x002F2B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x002F490C File Offset: 0x002F2B0C
		public static RealmBetweenLevelExp GetRootAsRealmBetweenLevelExp(ByteBuffer _bb)
		{
			return RealmBetweenLevelExp.GetRootAsRealmBetweenLevelExp(_bb, default(RealmBetweenLevelExp));
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x002F4928 File Offset: 0x002F2B28
		public static RealmBetweenLevelExp GetRootAsRealmBetweenLevelExp(ByteBuffer _bb, RealmBetweenLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x002F4945 File Offset: 0x002F2B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x002F4954 File Offset: 0x002F2B54
		public RealmBetweenLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x0600BF96 RID: 49046 RVA: 0x002F4964 File Offset: 0x002F2B64
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

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600BF97 RID: 49047 RVA: 0x002F49A0 File Offset: 0x002F2BA0
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

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600BF98 RID: 49048 RVA: 0x002F49DC File Offset: 0x002F2BDC
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

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600BF99 RID: 49049 RVA: 0x002F4A18 File Offset: 0x002F2C18
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

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600BF9A RID: 49050 RVA: 0x002F4A58 File Offset: 0x002F2C58
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

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600BF9B RID: 49051 RVA: 0x002F4A98 File Offset: 0x002F2C98
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

		// Token: 0x0600BF9C RID: 49052 RVA: 0x002F4AD0 File Offset: 0x002F2CD0
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x002F4AE0 File Offset: 0x002F2CE0
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600BF9E RID: 49054 RVA: 0x002F4AF8 File Offset: 0x002F2CF8
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

		// Token: 0x0600BF9F RID: 49055 RVA: 0x002F4B30 File Offset: 0x002F2D30
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x002F4B40 File Offset: 0x002F2D40
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005652 RID: 22098
		private Table __p;
	}
}
