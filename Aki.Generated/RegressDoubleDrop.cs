using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAC RID: 4012
	public struct RegressDoubleDrop : IFlatbufferObject
	{
		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x0600BAD6 RID: 47830 RVA: 0x002DBA11 File Offset: 0x002D9C11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BAD7 RID: 47831 RVA: 0x002DBA1E File Offset: 0x002D9C1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BAD8 RID: 47832 RVA: 0x002DBA28 File Offset: 0x002D9C28
		public static RegressDoubleDrop GetRootAsRegressDoubleDrop(ByteBuffer _bb)
		{
			return RegressDoubleDrop.GetRootAsRegressDoubleDrop(_bb, default(RegressDoubleDrop));
		}

		// Token: 0x0600BAD9 RID: 47833 RVA: 0x002DBA44 File Offset: 0x002D9C44
		public static RegressDoubleDrop GetRootAsRegressDoubleDrop(ByteBuffer _bb, RegressDoubleDrop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BADA RID: 47834 RVA: 0x002DBA61 File Offset: 0x002D9C61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BADB RID: 47835 RVA: 0x002DBA70 File Offset: 0x002D9C70
		public RegressDoubleDrop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600BADC RID: 47836 RVA: 0x002DBA80 File Offset: 0x002D9C80
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

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600BADD RID: 47837 RVA: 0x002DBABC File Offset: 0x002D9CBC
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600BADE RID: 47838 RVA: 0x002DBAF8 File Offset: 0x002D9CF8
		public int BossDoubleTimes
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

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600BADF RID: 47839 RVA: 0x002DBB34 File Offset: 0x002D9D34
		public int WeekDoubleTimes
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

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x0600BAE0 RID: 47840 RVA: 0x002DBB74 File Offset: 0x002D9D74
		public int BossUnLock
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

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x002DBBB4 File Offset: 0x002D9DB4
		public int WeekUnLock
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

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600BAE2 RID: 47842 RVA: 0x002DBBF4 File Offset: 0x002D9DF4
		public string Tips
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

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x002DBC2C File Offset: 0x002D9E2C
		public Span<byte> GetTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x002DBC3C File Offset: 0x002D9E3C
		public byte[] GetTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600BAE5 RID: 47845 RVA: 0x002DBC54 File Offset: 0x002D9E54
		public int WorldBossAccessPathId
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

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600BAE6 RID: 47846 RVA: 0x002DBC94 File Offset: 0x002D9E94
		public int WeekAccessPathId
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

		// Token: 0x04005085 RID: 20613
		private Table __p;
	}
}
