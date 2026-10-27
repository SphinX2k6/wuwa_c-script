using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E74 RID: 3700
	public struct MultiMap : IFlatbufferObject
	{
		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x00299F1C File Offset: 0x0029811C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x00299F29 File Offset: 0x00298129
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x00299F30 File Offset: 0x00298130
		public static MultiMap GetRootAsMultiMap(ByteBuffer _bb)
		{
			return MultiMap.GetRootAsMultiMap(_bb, default(MultiMap));
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x00299F4C File Offset: 0x0029814C
		public static MultiMap GetRootAsMultiMap(ByteBuffer _bb, MultiMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x00299F69 File Offset: 0x00298169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x00299F78 File Offset: 0x00298178
		public MultiMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06009D5D RID: 40285 RVA: 0x00299F88 File Offset: 0x00298188
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

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06009D5E RID: 40286 RVA: 0x00299FC4 File Offset: 0x002981C4
		public int GroupId
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

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06009D5F RID: 40287 RVA: 0x0029A000 File Offset: 0x00298200
		public int MapId
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

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06009D60 RID: 40288 RVA: 0x0029A03C File Offset: 0x0029823C
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

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06009D61 RID: 40289 RVA: 0x0029A07C File Offset: 0x0029827C
		public int Floor
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

		// Token: 0x06009D62 RID: 40290 RVA: 0x0029A0BC File Offset: 0x002982BC
		public string MapTilePath(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06009D63 RID: 40291 RVA: 0x0029A0F8 File Offset: 0x002982F8
		public int MapTilePathLength
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

		// Token: 0x06009D64 RID: 40292 RVA: 0x0029A124 File Offset: 0x00298324
		public string MiniMapTilePath(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06009D65 RID: 40293 RVA: 0x0029A160 File Offset: 0x00298360
		public int MiniMapTilePathLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x0029A18C File Offset: 0x0029838C
		public int Area(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06009D67 RID: 40295 RVA: 0x0029A1CC File Offset: 0x002983CC
		public int AreaLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x0029A1F8 File Offset: 0x002983F8
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x0029A208 File Offset: 0x00298408
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x0029A220 File Offset: 0x00298420
		public int Mark(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06009D6B RID: 40299 RVA: 0x0029A260 File Offset: 0x00298460
		public int MarkLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x0029A28C File Offset: 0x0029848C
		public Span<int> GetMarkBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x0029A29C File Offset: 0x0029849C
		public int[] GetMarkArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06009D6E RID: 40302 RVA: 0x0029A2B4 File Offset: 0x002984B4
		public int ConditionId
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

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x06009D6F RID: 40303 RVA: 0x0029A2F4 File Offset: 0x002984F4
		public string FloorName
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D70 RID: 40304 RVA: 0x0029A32C File Offset: 0x0029852C
		public Span<byte> GetFloorNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x0029A33C File Offset: 0x0029853C
		public byte[] GetFloorNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x06009D72 RID: 40306 RVA: 0x0029A354 File Offset: 0x00298554
		public string FloorIcon
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x0029A38C File Offset: 0x0029858C
		public Span<byte> GetFloorIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x0029A39C File Offset: 0x0029859C
		public byte[] GetFloorIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x0029A3B4 File Offset: 0x002985B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIter()或GetAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Area()
		{
			MultiMap multiMap = this;
			return multiMap.GetAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x0029A3D8 File Offset: 0x002985D8
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaIter()
		{
			MultiMap.<AreaIter>d__45 <AreaIter>d__ = new MultiMap.<AreaIter>d__45(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x0029A3ED File Offset: 0x002985ED
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MapTilePathIter()或GetMapTilePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MapTilePath()
		{
			return this.MapTilePathIter().ToArray<string>();
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x0029A3FA File Offset: 0x002985FA
		[NullableContext(1)]
		public readonly IEnumerable<string> MapTilePathIter()
		{
			MultiMap.<MapTilePathIter>d__47 <MapTilePathIter>d__ = new MultiMap.<MapTilePathIter>d__47(-2);
			<MapTilePathIter>d__.<>3__<>4__this = this;
			return <MapTilePathIter>d__;
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x0029A410 File Offset: 0x00298610
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MarkIter()或GetMarkBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Mark()
		{
			MultiMap multiMap = this;
			return multiMap.GetMarkArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x0029A434 File Offset: 0x00298634
		[NullableContext(1)]
		public readonly IEnumerable<int> MarkIter()
		{
			MultiMap.<MarkIter>d__49 <MarkIter>d__ = new MultiMap.<MarkIter>d__49(-2);
			<MarkIter>d__.<>3__<>4__this = this;
			return <MarkIter>d__;
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x0029A449 File Offset: 0x00298649
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MiniMapTilePathIter()或GetMiniMapTilePathBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MiniMapTilePath()
		{
			return this.MiniMapTilePathIter().ToArray<string>();
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x0029A456 File Offset: 0x00298656
		[NullableContext(1)]
		public readonly IEnumerable<string> MiniMapTilePathIter()
		{
			MultiMap.<MiniMapTilePathIter>d__51 <MiniMapTilePathIter>d__ = new MultiMap.<MiniMapTilePathIter>d__51(-2);
			<MiniMapTilePathIter>d__.<>3__<>4__this = this;
			return <MiniMapTilePathIter>d__;
		}

		// Token: 0x04004F22 RID: 20258
		private Table __p;
	}
}
