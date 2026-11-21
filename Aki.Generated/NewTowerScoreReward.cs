using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F76 RID: 3958
	public struct NewTowerScoreReward : IFlatbufferObject
	{
		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x002BC9DC File Offset: 0x002BABDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x002BC9E9 File Offset: 0x002BABE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x002BC9F0 File Offset: 0x002BABF0
		public static NewTowerScoreReward GetRootAsNewTowerScoreReward(ByteBuffer _bb)
		{
			return NewTowerScoreReward.GetRootAsNewTowerScoreReward(_bb, default(NewTowerScoreReward));
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x002BCA0C File Offset: 0x002BAC0C
		public static NewTowerScoreReward GetRootAsNewTowerScoreReward(ByteBuffer _bb, NewTowerScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x002BCA29 File Offset: 0x002BAC29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x002BCA38 File Offset: 0x002BAC38
		public NewTowerScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x002BCA48 File Offset: 0x002BAC48
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

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x0600A5ED RID: 42477 RVA: 0x002BCA84 File Offset: 0x002BAC84
		public int Level
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

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x002BCAC0 File Offset: 0x002BACC0
		public int Index
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

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600A5EF RID: 42479 RVA: 0x002BCAFC File Offset: 0x002BACFC
		public int DropId
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

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x002BCB3C File Offset: 0x002BAD3C
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

		// Token: 0x0600A5F1 RID: 42481 RVA: 0x002BCB74 File Offset: 0x002BAD74
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A5F2 RID: 42482 RVA: 0x002BCB84 File Offset: 0x002BAD84
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005529 RID: 21801
		private Table __p;
	}
}
