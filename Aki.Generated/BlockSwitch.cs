using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B3C RID: 2876
	public struct BlockSwitch : IFlatbufferObject
	{
		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x001E5064 File Offset: 0x001E3264
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x001E5071 File Offset: 0x001E3271
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x001E5078 File Offset: 0x001E3278
		public static BlockSwitch GetRootAsBlockSwitch(ByteBuffer _bb)
		{
			return BlockSwitch.GetRootAsBlockSwitch(_bb, default(BlockSwitch));
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x001E5094 File Offset: 0x001E3294
		public static BlockSwitch GetRootAsBlockSwitch(ByteBuffer _bb, BlockSwitch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x001E50B1 File Offset: 0x001E32B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x001E50C0 File Offset: 0x001E32C0
		public BlockSwitch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x001E50D0 File Offset: 0x001E32D0
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06004DF5 RID: 19957 RVA: 0x001E510C File Offset: 0x001E330C
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

		// Token: 0x06004DF6 RID: 19958 RVA: 0x001E5143 File Offset: 0x001E3343
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x001E5152 File Offset: 0x001E3352
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x001E516C File Offset: 0x001E336C
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

		// Token: 0x06004DF9 RID: 19961 RVA: 0x001E51A3 File Offset: 0x001E33A3
		public Span<byte> GetMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x001E51B2 File Offset: 0x001E33B2
		public byte[] GetMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06004DFB RID: 19963 RVA: 0x001E51CC File Offset: 0x001E33CC
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

		// Token: 0x06004DFC RID: 19964 RVA: 0x001E5204 File Offset: 0x001E3404
		public Span<byte> GetMiniMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x001E5214 File Offset: 0x001E3414
		public byte[] GetMiniMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x001E522C File Offset: 0x001E342C
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x001E526C File Offset: 0x001E346C
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

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x001E52AC File Offset: 0x001E34AC
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

		// Token: 0x04004B37 RID: 19255
		private Table __p;
	}
}
