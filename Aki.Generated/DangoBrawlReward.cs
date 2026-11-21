using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAF RID: 3247
	public struct DangoBrawlReward : IFlatbufferObject
	{
		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x0022BCAD File Offset: 0x00229EAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x0022BCBA File Offset: 0x00229EBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x0022BCC4 File Offset: 0x00229EC4
		public static DangoBrawlReward GetRootAsDangoBrawlReward(ByteBuffer _bb)
		{
			return DangoBrawlReward.GetRootAsDangoBrawlReward(_bb, default(DangoBrawlReward));
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x0022BCE0 File Offset: 0x00229EE0
		public static DangoBrawlReward GetRootAsDangoBrawlReward(ByteBuffer _bb, DangoBrawlReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x0022BCFD File Offset: 0x00229EFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064DA RID: 25818 RVA: 0x0022BD0C File Offset: 0x00229F0C
		public DangoBrawlReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060064DB RID: 25819 RVA: 0x0022BD1C File Offset: 0x00229F1C
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060064DC RID: 25820 RVA: 0x0022BD58 File Offset: 0x00229F58
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

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060064DD RID: 25821 RVA: 0x0022BD94 File Offset: 0x00229F94
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

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060064DE RID: 25822 RVA: 0x0022BDD0 File Offset: 0x00229FD0
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

		// Token: 0x060064DF RID: 25823 RVA: 0x0022BE08 File Offset: 0x0022A008
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x0022BE18 File Offset: 0x0022A018
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060064E1 RID: 25825 RVA: 0x0022BE30 File Offset: 0x0022A030
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060064E2 RID: 25826 RVA: 0x0022BE70 File Offset: 0x0022A070
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

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060064E3 RID: 25827 RVA: 0x0022BEB0 File Offset: 0x0022A0B0
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

		// Token: 0x040051D9 RID: 20953
		private Table __p;
	}
}
