using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAC RID: 3500
	public struct FogTextureConfig : IFlatbufferObject
	{
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x06007C01 RID: 31745 RVA: 0x0025FE09 File Offset: 0x0025E009
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x0025FE16 File Offset: 0x0025E016
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C03 RID: 31747 RVA: 0x0025FE20 File Offset: 0x0025E020
		public static FogTextureConfig GetRootAsFogTextureConfig(ByteBuffer _bb)
		{
			return FogTextureConfig.GetRootAsFogTextureConfig(_bb, default(FogTextureConfig));
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x0025FE3C File Offset: 0x0025E03C
		public static FogTextureConfig GetRootAsFogTextureConfig(ByteBuffer _bb, FogTextureConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x0025FE59 File Offset: 0x0025E059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x0025FE68 File Offset: 0x0025E068
		public FogTextureConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x0025FE78 File Offset: 0x0025E078
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x0025FEAF File Offset: 0x0025E0AF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x0025FEBE File Offset: 0x0025E0BE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x06007C0A RID: 31754 RVA: 0x0025FED8 File Offset: 0x0025E0D8
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

		// Token: 0x06007C0B RID: 31755 RVA: 0x0025FF0F File Offset: 0x0025E10F
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007C0C RID: 31756 RVA: 0x0025FF1E File Offset: 0x0025E11E
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06007C0D RID: 31757 RVA: 0x0025FF38 File Offset: 0x0025E138
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06007C0E RID: 31758 RVA: 0x0025FF74 File Offset: 0x0025E174
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06007C0F RID: 31759 RVA: 0x0025FFB4 File Offset: 0x0025E1B4
		public string MapTilePath
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

		// Token: 0x06007C10 RID: 31760 RVA: 0x0025FFEC File Offset: 0x0025E1EC
		public Span<byte> GetMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x0025FFFC File Offset: 0x0025E1FC
		public byte[] GetMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06007C12 RID: 31762 RVA: 0x00260014 File Offset: 0x0025E214
		public string MiniMapTilePath
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

		// Token: 0x06007C13 RID: 31763 RVA: 0x0026004C File Offset: 0x0025E24C
		public Span<byte> GetMiniMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x0026005C File Offset: 0x0025E25C
		public byte[] GetMiniMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06007C15 RID: 31765 RVA: 0x00260074 File Offset: 0x0025E274
		public string HdMapTilePath
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x002600AC File Offset: 0x0025E2AC
		public Span<byte> GetHdMapTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x002600BC File Offset: 0x0025E2BC
		public byte[] GetHdMapTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x002600D4 File Offset: 0x0025E2D4
		public string FogTilePath
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

		// Token: 0x06007C19 RID: 31769 RVA: 0x0026010C File Offset: 0x0025E30C
		public Span<byte> GetFogTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x0026011C File Offset: 0x0025E31C
		public byte[] GetFogTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001438 RID: 5176
		// (get) Token: 0x06007C1B RID: 31771 RVA: 0x00260134 File Offset: 0x0025E334
		public string MiniFogTilePath
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

		// Token: 0x06007C1C RID: 31772 RVA: 0x0026016C File Offset: 0x0025E36C
		public Span<byte> GetMiniFogTilePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x0026017C File Offset: 0x0025E37C
		public byte[] GetMiniFogTilePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x06007C1E RID: 31774 RVA: 0x00260194 File Offset: 0x0025E394
		public int SubMapGroupId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x002601D4 File Offset: 0x0025E3D4
		public int TileLoadFilterByArea(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x06007C20 RID: 31776 RVA: 0x00260214 File Offset: 0x0025E414
		public int TileLoadFilterByAreaLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x00260240 File Offset: 0x0025E440
		public Span<int> GetTileLoadFilterByAreaBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007C22 RID: 31778 RVA: 0x00260250 File Offset: 0x0025E450
		public int[] GetTileLoadFilterByAreaArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06007C23 RID: 31779 RVA: 0x00260268 File Offset: 0x0025E468
		[NullableContext(1)]
		public int[] TileLoadFilterByArea()
		{
			return this.GetTileLoadFilterByAreaArray();
		}

		// Token: 0x06007C24 RID: 31780 RVA: 0x00260270 File Offset: 0x0025E470
		[NullableContext(1)]
		public IEnumerable<int> TileLoadFilterByAreaIter()
		{
			FogTextureConfig.<TileLoadFilterByAreaIter>d__48 <TileLoadFilterByAreaIter>d__ = new FogTextureConfig.<TileLoadFilterByAreaIter>d__48(-2);
			<TileLoadFilterByAreaIter>d__.<>3__<>4__this = this;
			return <TileLoadFilterByAreaIter>d__;
		}

		// Token: 0x0400531C RID: 21276
		private Table __p;
	}
}
