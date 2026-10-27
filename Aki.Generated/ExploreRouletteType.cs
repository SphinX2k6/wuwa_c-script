using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C53 RID: 3155
	public struct ExploreRouletteType : IFlatbufferObject
	{
		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06006BCD RID: 27597 RVA: 0x0022915B File Offset: 0x0022735B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BCE RID: 27598 RVA: 0x00229168 File Offset: 0x00227368
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BCF RID: 27599 RVA: 0x00229170 File Offset: 0x00227370
		public static ExploreRouletteType GetRootAsExploreRouletteType(ByteBuffer _bb)
		{
			return ExploreRouletteType.GetRootAsExploreRouletteType(_bb, default(ExploreRouletteType));
		}

		// Token: 0x06006BD0 RID: 27600 RVA: 0x0022918C File Offset: 0x0022738C
		public static ExploreRouletteType GetRootAsExploreRouletteType(ByteBuffer _bb, ExploreRouletteType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BD1 RID: 27601 RVA: 0x002291A9 File Offset: 0x002273A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BD2 RID: 27602 RVA: 0x002291B8 File Offset: 0x002273B8
		public ExploreRouletteType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x002291C8 File Offset: 0x002273C8
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x00229204 File Offset: 0x00227404
		public int SortId
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x00229240 File Offset: 0x00227440
		public bool ShowInPad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x00229280 File Offset: 0x00227480
		public int UnlockFuncId
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

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x002292C0 File Offset: 0x002274C0
		public string TabName
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

		// Token: 0x06006BD8 RID: 27608 RVA: 0x002292F8 File Offset: 0x002274F8
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x00229308 File Offset: 0x00227508
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x00229320 File Offset: 0x00227520
		public string TabIcon
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

		// Token: 0x06006BDB RID: 27611 RVA: 0x00229358 File Offset: 0x00227558
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00229368 File Offset: 0x00227568
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C9A RID: 19610
		private Table __p;
	}
}
