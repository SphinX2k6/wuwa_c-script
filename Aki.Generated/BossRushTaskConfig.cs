using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C28 RID: 3112
	public struct BossRushTaskConfig : IFlatbufferObject
	{
		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600550A RID: 21770 RVA: 0x00208004 File Offset: 0x00206204
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00208011 File Offset: 0x00206211
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00208018 File Offset: 0x00206218
		public static BossRushTaskConfig GetRootAsBossRushTaskConfig(ByteBuffer _bb)
		{
			return BossRushTaskConfig.GetRootAsBossRushTaskConfig(_bb, default(BossRushTaskConfig));
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00208034 File Offset: 0x00206234
		public static BossRushTaskConfig GetRootAsBossRushTaskConfig(ByteBuffer _bb, BossRushTaskConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00208051 File Offset: 0x00206251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00208060 File Offset: 0x00206260
		public BossRushTaskConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06005510 RID: 21776 RVA: 0x00208070 File Offset: 0x00206270
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

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06005511 RID: 21777 RVA: 0x002080AC File Offset: 0x002062AC
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

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x002080E8 File Offset: 0x002062E8
		public int TabId
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

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x00208124 File Offset: 0x00206324
		public string Title
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

		// Token: 0x06005514 RID: 21780 RVA: 0x0020815C File Offset: 0x0020635C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x0020816C File Offset: 0x0020636C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x00208184 File Offset: 0x00206384
		public int DropId
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

		// Token: 0x04005123 RID: 20771
		private Table __p;
	}
}
