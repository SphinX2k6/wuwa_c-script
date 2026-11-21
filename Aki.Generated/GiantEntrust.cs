using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDF RID: 3551
	public struct GiantEntrust : IFlatbufferObject
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x00269898 File Offset: 0x00267A98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600806F RID: 32879 RVA: 0x002698A5 File Offset: 0x00267AA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008070 RID: 32880 RVA: 0x002698AC File Offset: 0x00267AAC
		public static GiantEntrust GetRootAsGiantEntrust(ByteBuffer _bb)
		{
			return GiantEntrust.GetRootAsGiantEntrust(_bb, default(GiantEntrust));
		}

		// Token: 0x06008071 RID: 32881 RVA: 0x002698C8 File Offset: 0x00267AC8
		public static GiantEntrust GetRootAsGiantEntrust(ByteBuffer _bb, GiantEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008072 RID: 32882 RVA: 0x002698E5 File Offset: 0x00267AE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x002698F4 File Offset: 0x00267AF4
		public GiantEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06008074 RID: 32884 RVA: 0x00269904 File Offset: 0x00267B04
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

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06008075 RID: 32885 RVA: 0x00269940 File Offset: 0x00267B40
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

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x0026997C File Offset: 0x00267B7C
		public int QuestId
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

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06008077 RID: 32887 RVA: 0x002699B8 File Offset: 0x00267BB8
		public int UnlockCondition
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

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06008078 RID: 32888 RVA: 0x002699F8 File Offset: 0x00267BF8
		public int AddValue
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

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x06008079 RID: 32889 RVA: 0x00269A38 File Offset: 0x00267C38
		public int ItemId
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

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x00269A78 File Offset: 0x00267C78
		public int ItemId2
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600807B RID: 32891 RVA: 0x00269AB8 File Offset: 0x00267CB8
		public string EntrustDesc
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

		// Token: 0x0600807C RID: 32892 RVA: 0x00269AF0 File Offset: 0x00267CF0
		public Span<byte> GetEntrustDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x00269B00 File Offset: 0x00267D00
		public byte[] GetEntrustDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005352 RID: 21330
		private Table __p;
	}
}
