using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1C RID: 3100
	public struct BlockSwitch : IFlatbufferObject
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060053B0 RID: 21424 RVA: 0x0020538C File Offset: 0x0020358C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00205399 File Offset: 0x00203599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x002053A0 File Offset: 0x002035A0
		public static BlockSwitch GetRootAsBlockSwitch(ByteBuffer _bb)
		{
			return BlockSwitch.GetRootAsBlockSwitch(_bb, default(BlockSwitch));
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x002053BC File Offset: 0x002035BC
		public static BlockSwitch GetRootAsBlockSwitch(ByteBuffer _bb, BlockSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x002053D9 File Offset: 0x002035D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x002053E8 File Offset: 0x002035E8
		public BlockSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060053B6 RID: 21430 RVA: 0x002053F8 File Offset: 0x002035F8
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x00205434 File Offset: 0x00203634
		public string Block
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x0020546B File Offset: 0x0020366B
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x0020547A File Offset: 0x0020367A
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060053BA RID: 21434 RVA: 0x00205494 File Offset: 0x00203694
		public string MapTilePath
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

		// Token: 0x060053BB RID: 21435 RVA: 0x002054CB File Offset: 0x002036CB
		public Span<byte> GetMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x002054DA File Offset: 0x002036DA
		public byte[] GetMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060053BD RID: 21437 RVA: 0x002054F4 File Offset: 0x002036F4
		public string MiniMapTilePath
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

		// Token: 0x060053BE RID: 21438 RVA: 0x0020552C File Offset: 0x0020372C
		public Span<byte> GetMiniMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0020553C File Offset: 0x0020373C
		public byte[] GetMiniMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060053C0 RID: 21440 RVA: 0x00205554 File Offset: 0x00203754
		public int MapConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x00205594 File Offset: 0x00203794
		public int GravityFlip
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060053C2 RID: 21442 RVA: 0x002055D4 File Offset: 0x002037D4
		public int Priority
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

		// Token: 0x04005117 RID: 20759
		private Table __p;
	}
}
