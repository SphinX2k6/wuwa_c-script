using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEA RID: 3562
	public struct MapBlockInfo : IFlatbufferObject
	{
		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x0027D8D4 File Offset: 0x0027BAD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x0027D8E1 File Offset: 0x0027BAE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x0027D8E8 File Offset: 0x0027BAE8
		public static MapBlockInfo GetRootAsMapBlockInfo(ByteBuffer _bb)
		{
			return MapBlockInfo.GetRootAsMapBlockInfo(_bb, default(MapBlockInfo));
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x0027D904 File Offset: 0x0027BB04
		public static MapBlockInfo GetRootAsMapBlockInfo(ByteBuffer _bb, MapBlockInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x0027D921 File Offset: 0x0027BB21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x0027D930 File Offset: 0x0027BB30
		public MapBlockInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x0027D940 File Offset: 0x0027BB40
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

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x060090BF RID: 37055 RVA: 0x0027D97C File Offset: 0x0027BB7C
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x0027D9B8 File Offset: 0x0027BBB8
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

		// Token: 0x060090C1 RID: 37057 RVA: 0x0027D9EF File Offset: 0x0027BBEF
		public Span<byte> GetPakNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x0027D9FE File Offset: 0x0027BBFE
		public byte[] GetPakNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x060090C3 RID: 37059 RVA: 0x0027DA18 File Offset: 0x0027BC18
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

		// Token: 0x060090C4 RID: 37060 RVA: 0x0027DA50 File Offset: 0x0027BC50
		public Span<byte> GetBlockDatalayerBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x0027DA60 File Offset: 0x0027BC60
		public byte[] GetBlockDatalayerArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0027DA78 File Offset: 0x0027BC78
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

		// Token: 0x060090C7 RID: 37063 RVA: 0x0027DAB0 File Offset: 0x0027BCB0
		public Span<byte> GetRegionNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x0027DAC0 File Offset: 0x0027BCC0
		public byte[] GetRegionNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x0027DAD8 File Offset: 0x0027BCD8
		public IntVector2D? RegionBoxes(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IntVector2D?(default(IntVector2D).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x0027DB3C File Offset: 0x0027BD3C
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

		// Token: 0x060090CB RID: 37067 RVA: 0x0027DB68 File Offset: 0x0027BD68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RegionBoxesIter()或GetRegionBoxesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntVector2D[] RegionBoxes()
		{
			return this.RegionBoxesIter().ToArray<IntVector2D>();
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x0027DB75 File Offset: 0x0027BD75
		[NullableContext(1)]
		public readonly IEnumerable<IntVector2D> RegionBoxesIter()
		{
			MapBlockInfo.<RegionBoxesIter>d__28 <RegionBoxesIter>d__ = new MapBlockInfo.<RegionBoxesIter>d__28(-2);
			<RegionBoxesIter>d__.<>3__<>4__this = this;
			return <RegionBoxesIter>d__;
		}

		// Token: 0x04004E86 RID: 20102
		private Table __p;
	}
}
