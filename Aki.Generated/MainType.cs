using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE8 RID: 3560
	public struct MainType : IFlatbufferObject
	{
		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x0600908A RID: 37002 RVA: 0x0027D2E8 File Offset: 0x0027B4E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x0027D2F5 File Offset: 0x0027B4F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x0027D2FC File Offset: 0x0027B4FC
		public static MainType GetRootAsMainType(ByteBuffer _bb)
		{
			return MainType.GetRootAsMainType(_bb, default(MainType));
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x0027D318 File Offset: 0x0027B518
		public static MainType GetRootAsMainType(ByteBuffer _bb, MainType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x0027D335 File Offset: 0x0027B535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x0027D344 File Offset: 0x0027B544
		public MainType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x06009090 RID: 37008 RVA: 0x0027D354 File Offset: 0x0027B554
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

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x06009091 RID: 37009 RVA: 0x0027D390 File Offset: 0x0027B590
		public int MainSort
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

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x06009092 RID: 37010 RVA: 0x0027D3CC File Offset: 0x0027B5CC
		public string MainName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x0027D403 File Offset: 0x0027B603
		public Span<byte> GetMainNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x0027D412 File Offset: 0x0027B612
		public byte[] GetMainNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x06009095 RID: 37013 RVA: 0x0027D42C File Offset: 0x0027B62C
		public string MainIcon
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

		// Token: 0x06009096 RID: 37014 RVA: 0x0027D464 File Offset: 0x0027B664
		public Span<byte> GetMainIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0027D474 File Offset: 0x0027B674
		public byte[] GetMainIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x06009098 RID: 37016 RVA: 0x0027D48C File Offset: 0x0027B68C
		public int TabPanelType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x06009099 RID: 37017 RVA: 0x0027D4CC File Offset: 0x0027B6CC
		public int PcTabPanelType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x0027D50C File Offset: 0x0027B70C
		public int XboxTabPanelType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x0600909B RID: 37019 RVA: 0x0027D54C File Offset: 0x0027B74C
		public int PsTabPanelType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x0027D58C File Offset: 0x0027B78C
		public string MainSmallIcon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x0027D5C4 File Offset: 0x0027B7C4
		public Span<byte> GetMainSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x0027D5D4 File Offset: 0x0027B7D4
		public byte[] GetMainSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E84 RID: 20100
		private Table __p;
	}
}
