using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F59 RID: 3929
	public struct MultiMap : IFlatbufferObject
	{
		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x0600A377 RID: 41847 RVA: 0x002B7700 File Offset: 0x002B5900
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x002B770D File Offset: 0x002B590D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x002B7714 File Offset: 0x002B5914
		public static MultiMap GetRootAsMultiMap(ByteBuffer _bb)
		{
			return MultiMap.GetRootAsMultiMap(_bb, default(MultiMap));
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x002B7730 File Offset: 0x002B5930
		public static MultiMap GetRootAsMultiMap(ByteBuffer _bb, MultiMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x002B774D File Offset: 0x002B594D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x002B775C File Offset: 0x002B595C
		public MultiMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x0600A37D RID: 41853 RVA: 0x002B776C File Offset: 0x002B596C
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

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x0600A37E RID: 41854 RVA: 0x002B77A8 File Offset: 0x002B59A8
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

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x0600A37F RID: 41855 RVA: 0x002B77E4 File Offset: 0x002B59E4
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

		// Token: 0x17002309 RID: 8969
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x002B7820 File Offset: 0x002B5A20
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

		// Token: 0x1700230A RID: 8970
		// (get) Token: 0x0600A381 RID: 41857 RVA: 0x002B7860 File Offset: 0x002B5A60
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

		// Token: 0x0600A382 RID: 41858 RVA: 0x002B78A0 File Offset: 0x002B5AA0
		public string MapTilePath(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700230B RID: 8971
		// (get) Token: 0x0600A383 RID: 41859 RVA: 0x002B78DC File Offset: 0x002B5ADC
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

		// Token: 0x0600A384 RID: 41860 RVA: 0x002B7908 File Offset: 0x002B5B08
		public string MiniMapTilePath(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700230C RID: 8972
		// (get) Token: 0x0600A385 RID: 41861 RVA: 0x002B7944 File Offset: 0x002B5B44
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

		// Token: 0x0600A386 RID: 41862 RVA: 0x002B7970 File Offset: 0x002B5B70
		public int Area(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700230D RID: 8973
		// (get) Token: 0x0600A387 RID: 41863 RVA: 0x002B79B0 File Offset: 0x002B5BB0
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

		// Token: 0x0600A388 RID: 41864 RVA: 0x002B79DC File Offset: 0x002B5BDC
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x002B79EC File Offset: 0x002B5BEC
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600A38A RID: 41866 RVA: 0x002B7A04 File Offset: 0x002B5C04
		public int Mark(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700230E RID: 8974
		// (get) Token: 0x0600A38B RID: 41867 RVA: 0x002B7A44 File Offset: 0x002B5C44
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

		// Token: 0x0600A38C RID: 41868 RVA: 0x002B7A70 File Offset: 0x002B5C70
		public Span<int> GetMarkBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600A38D RID: 41869 RVA: 0x002B7A80 File Offset: 0x002B5C80
		public int[] GetMarkArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x1700230F RID: 8975
		// (get) Token: 0x0600A38E RID: 41870 RVA: 0x002B7A98 File Offset: 0x002B5C98
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

		// Token: 0x17002310 RID: 8976
		// (get) Token: 0x0600A38F RID: 41871 RVA: 0x002B7AD8 File Offset: 0x002B5CD8
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

		// Token: 0x0600A390 RID: 41872 RVA: 0x002B7B10 File Offset: 0x002B5D10
		public Span<byte> GetFloorNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x002B7B20 File Offset: 0x002B5D20
		public byte[] GetFloorNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002311 RID: 8977
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x002B7B38 File Offset: 0x002B5D38
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

		// Token: 0x0600A393 RID: 41875 RVA: 0x002B7B70 File Offset: 0x002B5D70
		public Span<byte> GetFloorIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x002B7B80 File Offset: 0x002B5D80
		public byte[] GetFloorIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x002B7B98 File Offset: 0x002B5D98
		[NullableContext(1)]
		public int[] Area()
		{
			return this.GetAreaArray();
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x002B7BA0 File Offset: 0x002B5DA0
		[NullableContext(1)]
		public IEnumerable<int> AreaIter()
		{
			MultiMap.<AreaIter>d__45 <AreaIter>d__ = new MultiMap.<AreaIter>d__45(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x002B7BB5 File Offset: 0x002B5DB5
		[NullableContext(1)]
		public string[] MapTilePath()
		{
			return this.MapTilePathIter().ToArray<string>();
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x002B7BC2 File Offset: 0x002B5DC2
		[NullableContext(1)]
		public IEnumerable<string> MapTilePathIter()
		{
			MultiMap.<MapTilePathIter>d__47 <MapTilePathIter>d__ = new MultiMap.<MapTilePathIter>d__47(-2);
			<MapTilePathIter>d__.<>3__<>4__this = this;
			return <MapTilePathIter>d__;
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x002B7BD7 File Offset: 0x002B5DD7
		[NullableContext(1)]
		public int[] Mark()
		{
			return this.GetMarkArray();
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x002B7BDF File Offset: 0x002B5DDF
		[NullableContext(1)]
		public IEnumerable<int> MarkIter()
		{
			MultiMap.<MarkIter>d__49 <MarkIter>d__ = new MultiMap.<MarkIter>d__49(-2);
			<MarkIter>d__.<>3__<>4__this = this;
			return <MarkIter>d__;
		}

		// Token: 0x0600A39B RID: 41883 RVA: 0x002B7BF4 File Offset: 0x002B5DF4
		[NullableContext(1)]
		public string[] MiniMapTilePath()
		{
			return this.MiniMapTilePathIter().ToArray<string>();
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x002B7C01 File Offset: 0x002B5E01
		[NullableContext(1)]
		public IEnumerable<string> MiniMapTilePathIter()
		{
			MultiMap.<MiniMapTilePathIter>d__51 <MiniMapTilePathIter>d__ = new MultiMap.<MiniMapTilePathIter>d__51(-2);
			<MiniMapTilePathIter>d__.<>3__<>4__this = this;
			return <MiniMapTilePathIter>d__;
		}

		// Token: 0x04005507 RID: 21767
		private Table __p;
	}
}
