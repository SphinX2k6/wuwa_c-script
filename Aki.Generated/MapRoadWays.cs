using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDA RID: 3802
	public struct MapRoadWays : IFlatbufferObject
	{
		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x060097F7 RID: 38903 RVA: 0x0029E665 File Offset: 0x0029C865
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x0029E672 File Offset: 0x0029C872
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x0029E67C File Offset: 0x0029C87C
		public static MapRoadWays GetRootAsMapRoadWays(ByteBuffer _bb)
		{
			return MapRoadWays.GetRootAsMapRoadWays(_bb, default(MapRoadWays));
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x0029E698 File Offset: 0x0029C898
		public static MapRoadWays GetRootAsMapRoadWays(ByteBuffer _bb, MapRoadWays obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x0029E6B5 File Offset: 0x0029C8B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x0029E6C4 File Offset: 0x0029C8C4
		public MapRoadWays __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x060097FD RID: 38909 RVA: 0x0029E6D4 File Offset: 0x0029C8D4
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x060097FE RID: 38910 RVA: 0x0029E710 File Offset: 0x0029C910
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

		// Token: 0x060097FF RID: 38911 RVA: 0x0029E74C File Offset: 0x0029C94C
		public int ShowDungeonList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x06009800 RID: 38912 RVA: 0x0029E78C File Offset: 0x0029C98C
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

		// Token: 0x06009801 RID: 38913 RVA: 0x0029E7B7 File Offset: 0x0029C9B7
		public Span<int> GetShowDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009802 RID: 38914 RVA: 0x0029E7C6 File Offset: 0x0029C9C6
		public int[] GetShowDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x06009803 RID: 38915 RVA: 0x0029E7E0 File Offset: 0x0029C9E0
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

		// Token: 0x06009804 RID: 38916 RVA: 0x0029E820 File Offset: 0x0029CA20
		public float UiPosition(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x06009805 RID: 38917 RVA: 0x0029E864 File Offset: 0x0029CA64
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

		// Token: 0x06009806 RID: 38918 RVA: 0x0029E890 File Offset: 0x0029CA90
		public Span<float> GetUiPositionBytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06009807 RID: 38919 RVA: 0x0029E8A0 File Offset: 0x0029CAA0
		public float[] GetUiPositionArray()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06009808 RID: 38920 RVA: 0x0029E8B8 File Offset: 0x0029CAB8
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

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06009809 RID: 38921 RVA: 0x0029E8FC File Offset: 0x0029CAFC
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

		// Token: 0x0600980A RID: 38922 RVA: 0x0029E934 File Offset: 0x0029CB34
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600980B RID: 38923 RVA: 0x0029E944 File Offset: 0x0029CB44
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600980C RID: 38924 RVA: 0x0029E95C File Offset: 0x0029CB5C
		public int FogIdArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x0600980D RID: 38925 RVA: 0x0029E99C File Offset: 0x0029CB9C
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

		// Token: 0x0600980E RID: 38926 RVA: 0x0029E9C8 File Offset: 0x0029CBC8
		public Span<int> GetFogIdArrayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600980F RID: 38927 RVA: 0x0029E9D8 File Offset: 0x0029CBD8
		public int[] GetFogIdArrayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06009810 RID: 38928 RVA: 0x0029E9F0 File Offset: 0x0029CBF0
		[NullableContext(1)]
		public int[] FogIdArray()
		{
			return this.GetFogIdArrayArray();
		}

		// Token: 0x06009811 RID: 38929 RVA: 0x0029E9F8 File Offset: 0x0029CBF8
		[NullableContext(1)]
		public IEnumerable<int> FogIdArrayIter()
		{
			MapRoadWays.<FogIdArrayIter>d__36 <FogIdArrayIter>d__ = new MapRoadWays.<FogIdArrayIter>d__36(-2);
			<FogIdArrayIter>d__.<>3__<>4__this = this;
			return <FogIdArrayIter>d__;
		}

		// Token: 0x06009812 RID: 38930 RVA: 0x0029EA0D File Offset: 0x0029CC0D
		[NullableContext(1)]
		public int[] ShowDungeonList()
		{
			return this.GetShowDungeonListArray();
		}

		// Token: 0x06009813 RID: 38931 RVA: 0x0029EA15 File Offset: 0x0029CC15
		[NullableContext(1)]
		public IEnumerable<int> ShowDungeonListIter()
		{
			MapRoadWays.<ShowDungeonListIter>d__38 <ShowDungeonListIter>d__ = new MapRoadWays.<ShowDungeonListIter>d__38(-2);
			<ShowDungeonListIter>d__.<>3__<>4__this = this;
			return <ShowDungeonListIter>d__;
		}

		// Token: 0x06009814 RID: 38932 RVA: 0x0029EA2A File Offset: 0x0029CC2A
		[NullableContext(1)]
		public float[] UiPosition()
		{
			return this.GetUiPositionArray();
		}

		// Token: 0x06009815 RID: 38933 RVA: 0x0029EA32 File Offset: 0x0029CC32
		[NullableContext(1)]
		public IEnumerable<float> UiPositionIter()
		{
			MapRoadWays.<UiPositionIter>d__40 <UiPositionIter>d__ = new MapRoadWays.<UiPositionIter>d__40(-2);
			<UiPositionIter>d__.<>3__<>4__this = this;
			return <UiPositionIter>d__;
		}

		// Token: 0x04005478 RID: 21624
		private Table __p;
	}
}
