using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ECF RID: 3791
	public struct MapBlockInfo : IFlatbufferObject
	{
		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x060096D4 RID: 38612 RVA: 0x0029BB54 File Offset: 0x00299D54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x0029BB61 File Offset: 0x00299D61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x0029BB68 File Offset: 0x00299D68
		public static MapBlockInfo GetRootAsMapBlockInfo(ByteBuffer _bb)
		{
			return MapBlockInfo.GetRootAsMapBlockInfo(_bb, default(MapBlockInfo));
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x0029BB84 File Offset: 0x00299D84
		public static MapBlockInfo GetRootAsMapBlockInfo(ByteBuffer _bb, MapBlockInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x0029BBA1 File Offset: 0x00299DA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x0029BBB0 File Offset: 0x00299DB0
		public MapBlockInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060096DA RID: 38618 RVA: 0x0029BBC0 File Offset: 0x00299DC0
		public int BlockId
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

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060096DB RID: 38619 RVA: 0x0029BBFC File Offset: 0x00299DFC
		public int MapId
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

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x0029BC38 File Offset: 0x00299E38
		public string PakName
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

		// Token: 0x060096DD RID: 38621 RVA: 0x0029BC6F File Offset: 0x00299E6F
		public Span<byte> GetPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x0029BC7E File Offset: 0x00299E7E
		public byte[] GetPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x0029BC98 File Offset: 0x00299E98
		public string BlockDatalayer
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

		// Token: 0x060096E0 RID: 38624 RVA: 0x0029BCD0 File Offset: 0x00299ED0
		public Span<byte> GetBlockDatalayerBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0029BCE0 File Offset: 0x00299EE0
		public byte[] GetBlockDatalayerArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x0029BCF8 File Offset: 0x00299EF8
		public string RegionName
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

		// Token: 0x060096E3 RID: 38627 RVA: 0x0029BD30 File Offset: 0x00299F30
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x0029BD40 File Offset: 0x00299F40
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x0029BD58 File Offset: 0x00299F58
		public IntVector2D? RegionBoxes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x060096E6 RID: 38630 RVA: 0x0029BDBC File Offset: 0x00299FBC
		public int RegionBoxesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060096E7 RID: 38631 RVA: 0x0029BDE8 File Offset: 0x00299FE8
		[NullableContext(1)]
		public IntVector2D[] RegionBoxes()
		{
			return this.RegionBoxesIter().ToArray<IntVector2D>();
		}

		// Token: 0x060096E8 RID: 38632 RVA: 0x0029BDF5 File Offset: 0x00299FF5
		[NullableContext(1)]
		public IEnumerable<IntVector2D> RegionBoxesIter()
		{
			MapBlockInfo.<RegionBoxesIter>d__28 <RegionBoxesIter>d__ = new MapBlockInfo.<RegionBoxesIter>d__28(-2);
			<RegionBoxesIter>d__.<>3__<>4__this = this;
			return <RegionBoxesIter>d__;
		}

		// Token: 0x0400546B RID: 21611
		private Table __p;
	}
}
