using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBA RID: 3770
	public struct LoadingLevelArea : IFlatbufferObject
	{
		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600952C RID: 38188 RVA: 0x00298330 File Offset: 0x00296530
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600952D RID: 38189 RVA: 0x0029833D File Offset: 0x0029653D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600952E RID: 38190 RVA: 0x00298344 File Offset: 0x00296544
		public static LoadingLevelArea GetRootAsLoadingLevelArea(ByteBuffer _bb)
		{
			return LoadingLevelArea.GetRootAsLoadingLevelArea(_bb, default(LoadingLevelArea));
		}

		// Token: 0x0600952F RID: 38191 RVA: 0x00298360 File Offset: 0x00296560
		public static LoadingLevelArea GetRootAsLoadingLevelArea(ByteBuffer _bb, LoadingLevelArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009530 RID: 38192 RVA: 0x0029837D File Offset: 0x0029657D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009531 RID: 38193 RVA: 0x0029838C File Offset: 0x0029658C
		public LoadingLevelArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06009532 RID: 38194 RVA: 0x0029839C File Offset: 0x0029659C
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

		// Token: 0x06009533 RID: 38195 RVA: 0x002983D8 File Offset: 0x002965D8
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06009534 RID: 38196 RVA: 0x00298418 File Offset: 0x00296618
		public int LevelRangeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009535 RID: 38197 RVA: 0x00298443 File Offset: 0x00296643
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009536 RID: 38198 RVA: 0x00298452 File Offset: 0x00296652
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009537 RID: 38199 RVA: 0x0029846C File Offset: 0x0029666C
		public int AreaId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06009538 RID: 38200 RVA: 0x002984AC File Offset: 0x002966AC
		public int AreaIdLength
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

		// Token: 0x06009539 RID: 38201 RVA: 0x002984D7 File Offset: 0x002966D7
		public Span<int> GetAreaIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600953A RID: 38202 RVA: 0x002984E6 File Offset: 0x002966E6
		public int[] GetAreaIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x00298500 File Offset: 0x00296700
		public int MapId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x0600953C RID: 38204 RVA: 0x00298540 File Offset: 0x00296740
		public int MapIdLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x0029856C File Offset: 0x0029676C
		public Span<int> GetMapIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x0029857C File Offset: 0x0029677C
		public int[] GetMapIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x0600953F RID: 38207 RVA: 0x00298594 File Offset: 0x00296794
		public int ConditionGroup
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

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06009540 RID: 38208 RVA: 0x002985D4 File Offset: 0x002967D4
		public bool IsLimitShow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x06009541 RID: 38209 RVA: 0x00298614 File Offset: 0x00296814
		public int BeginTime
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

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x00298654 File Offset: 0x00296854
		public int EndTime
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06009543 RID: 38211 RVA: 0x00298694 File Offset: 0x00296894
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x002986D4 File Offset: 0x002968D4
		public int Type
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

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x00298714 File Offset: 0x00296914
		public int DuringTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00298751 File Offset: 0x00296951
		[NullableContext(1)]
		public int[] AreaId()
		{
			return this.GetAreaIdArray();
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x00298759 File Offset: 0x00296959
		[NullableContext(1)]
		public IEnumerable<int> AreaIdIter()
		{
			LoadingLevelArea.<AreaIdIter>d__40 <AreaIdIter>d__ = new LoadingLevelArea.<AreaIdIter>d__40(-2);
			<AreaIdIter>d__.<>3__<>4__this = this;
			return <AreaIdIter>d__;
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x0029876E File Offset: 0x0029696E
		[NullableContext(1)]
		public int[] LevelRange()
		{
			return this.GetLevelRangeArray();
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x00298776 File Offset: 0x00296976
		[NullableContext(1)]
		public IEnumerable<int> LevelRangeIter()
		{
			LoadingLevelArea.<LevelRangeIter>d__42 <LevelRangeIter>d__ = new LoadingLevelArea.<LevelRangeIter>d__42(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x0029878B File Offset: 0x0029698B
		[NullableContext(1)]
		public int[] MapId()
		{
			return this.GetMapIdArray();
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x00298793 File Offset: 0x00296993
		[NullableContext(1)]
		public IEnumerable<int> MapIdIter()
		{
			LoadingLevelArea.<MapIdIter>d__44 <MapIdIter>d__ = new LoadingLevelArea.<MapIdIter>d__44(-2);
			<MapIdIter>d__.<>3__<>4__this = this;
			return <MapIdIter>d__;
		}

		// Token: 0x04005455 RID: 21589
		private Table __p;
	}
}
