using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCD RID: 3021
	public struct DangoBrawlReward : IFlatbufferObject
	{
		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06005EFC RID: 24316 RVA: 0x0020C551 File Offset: 0x0020A751
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0020C55E File Offset: 0x0020A75E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0020C568 File Offset: 0x0020A768
		public static DangoBrawlReward GetRootAsDangoBrawlReward(ByteBuffer _bb)
		{
			return DangoBrawlReward.GetRootAsDangoBrawlReward(_bb, default(DangoBrawlReward));
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0020C584 File Offset: 0x0020A784
		public static DangoBrawlReward GetRootAsDangoBrawlReward(ByteBuffer _bb, DangoBrawlReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0020C5A1 File Offset: 0x0020A7A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x0020C5B0 File Offset: 0x0020A7B0
		public DangoBrawlReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06005F02 RID: 24322 RVA: 0x0020C5C0 File Offset: 0x0020A7C0
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

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x0020C5FC File Offset: 0x0020A7FC
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

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06005F04 RID: 24324 RVA: 0x0020C638 File Offset: 0x0020A838
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

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x0020C674 File Offset: 0x0020A874
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

		// Token: 0x06005F06 RID: 24326 RVA: 0x0020C6AC File Offset: 0x0020A8AC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x0020C6BC File Offset: 0x0020A8BC
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06005F08 RID: 24328 RVA: 0x0020C6D4 File Offset: 0x0020A8D4
		public int ConditionGroup
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

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x0020C714 File Offset: 0x0020A914
		public int DropId
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

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06005F0A RID: 24330 RVA: 0x0020C754 File Offset: 0x0020A954
		public int CoinCnt
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

		// Token: 0x04004BF7 RID: 19447
		private Table __p;
	}
}
