using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB2 RID: 2738
	public struct AbyssReward : IFlatbufferObject
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x001C82CC File Offset: 0x001C64CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041AE RID: 16814 RVA: 0x001C82D9 File Offset: 0x001C64D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041AF RID: 16815 RVA: 0x001C82E0 File Offset: 0x001C64E0
		public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb)
		{
			return AbyssReward.GetRootAsAbyssReward(_bb, default(AbyssReward));
		}

		// Token: 0x060041B0 RID: 16816 RVA: 0x001C82FC File Offset: 0x001C64FC
		public static AbyssReward GetRootAsAbyssReward(ByteBuffer _bb, AbyssReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041B1 RID: 16817 RVA: 0x001C8319 File Offset: 0x001C6519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041B2 RID: 16818 RVA: 0x001C8328 File Offset: 0x001C6528
		public AbyssReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x001C8338 File Offset: 0x001C6538
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060041B4 RID: 16820 RVA: 0x001C8374 File Offset: 0x001C6574
		public int RewardType
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x001C83B0 File Offset: 0x001C65B0
		public int ConditionId
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x001C83EC File Offset: 0x001C65EC
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x001C842C File Offset: 0x001C662C
		public string Title
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

		// Token: 0x060041B8 RID: 16824 RVA: 0x001C8464 File Offset: 0x001C6664
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x001C8474 File Offset: 0x001C6674
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A88 RID: 19080
		private Table __p;
	}
}
