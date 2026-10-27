using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF5 RID: 3573
	public struct MapRoadWays : IFlatbufferObject
	{
		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x060091DB RID: 37339 RVA: 0x00280515 File Offset: 0x0027E715
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x00280522 File Offset: 0x0027E722
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x0028052C File Offset: 0x0027E72C
		public static MapRoadWays GetRootAsMapRoadWays(ByteBuffer _bb)
		{
			return MapRoadWays.GetRootAsMapRoadWays(_bb, default(MapRoadWays));
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x00280548 File Offset: 0x0027E748
		public static MapRoadWays GetRootAsMapRoadWays(ByteBuffer _bb, MapRoadWays obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00280565 File Offset: 0x0027E765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x00280574 File Offset: 0x0027E774
		public MapRoadWays __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x00280584 File Offset: 0x0027E784
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

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x002805C0 File Offset: 0x0027E7C0
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

		// Token: 0x060091E3 RID: 37347 RVA: 0x002805FC File Offset: 0x0027E7FC
		public int ShowDungeonList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060091E4 RID: 37348 RVA: 0x0028063C File Offset: 0x0027E83C
		public int ShowDungeonListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x00280667 File Offset: 0x0027E867
		public Span<int> GetShowDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x00280676 File Offset: 0x0027E876
		public int[] GetShowDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x00280690 File Offset: 0x0027E890
		public int RoadBuildId
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

		// Token: 0x060091E8 RID: 37352 RVA: 0x002806D0 File Offset: 0x0027E8D0
		public float UiPosition(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x00280714 File Offset: 0x0027E914
		public int UiPositionLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00280740 File Offset: 0x0027E940
		public Span<float> GetUiPositionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00280750 File Offset: 0x0027E950
		public float[] GetUiPositionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x060091EC RID: 37356 RVA: 0x00280768 File Offset: 0x0027E968
		public float UiScale
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x060091ED RID: 37357 RVA: 0x002807AC File Offset: 0x0027E9AC
		public string ResourcePath
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

		// Token: 0x060091EE RID: 37358 RVA: 0x002807E4 File Offset: 0x0027E9E4
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x002807F4 File Offset: 0x0027E9F4
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x0028080C File Offset: 0x0027EA0C
		public int FogIdArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x060091F1 RID: 37361 RVA: 0x0028084C File Offset: 0x0027EA4C
		public int FogIdArrayLength
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

		// Token: 0x060091F2 RID: 37362 RVA: 0x00280878 File Offset: 0x0027EA78
		public Span<int> GetFogIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x00280888 File Offset: 0x0027EA88
		public int[] GetFogIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x002808A0 File Offset: 0x0027EAA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FogIdArrayIter()或GetFogIdArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FogIdArray()
		{
			MapRoadWays mapRoadWays = this;
			return mapRoadWays.GetFogIdArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x002808C4 File Offset: 0x0027EAC4
		[NullableContext(1)]
		public readonly IEnumerable<int> FogIdArrayIter()
		{
			MapRoadWays.<FogIdArrayIter>d__36 <FogIdArrayIter>d__ = new MapRoadWays.<FogIdArrayIter>d__36(-2);
			<FogIdArrayIter>d__.<>3__<>4__this = this;
			return <FogIdArrayIter>d__;
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x002808DC File Offset: 0x0027EADC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowDungeonListIter()或GetShowDungeonListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowDungeonList()
		{
			MapRoadWays mapRoadWays = this;
			return mapRoadWays.GetShowDungeonListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x00280900 File Offset: 0x0027EB00
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowDungeonListIter()
		{
			MapRoadWays.<ShowDungeonListIter>d__38 <ShowDungeonListIter>d__ = new MapRoadWays.<ShowDungeonListIter>d__38(-2);
			<ShowDungeonListIter>d__.<>3__<>4__this = this;
			return <ShowDungeonListIter>d__;
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x00280918 File Offset: 0x0027EB18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiPositionIter()或GetUiPositionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] UiPosition()
		{
			MapRoadWays mapRoadWays = this;
			return mapRoadWays.GetUiPositionArray() ?? Array.Empty<float>();
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x0028093C File Offset: 0x0027EB3C
		[NullableContext(1)]
		public readonly IEnumerable<float> UiPositionIter()
		{
			MapRoadWays.<UiPositionIter>d__40 <UiPositionIter>d__ = new MapRoadWays.<UiPositionIter>d__40(-2);
			<UiPositionIter>d__.<>3__<>4__this = this;
			return <UiPositionIter>d__;
		}

		// Token: 0x04004E93 RID: 20115
		private Table __p;
	}
}
