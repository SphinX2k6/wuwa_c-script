using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBB RID: 3259
	public struct DangoMonopolyGrid : IFlatbufferObject
	{
		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x0022F04C File Offset: 0x0022D24C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x0022F059 File Offset: 0x0022D259
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x0022F060 File Offset: 0x0022D260
		public static DangoMonopolyGrid GetRootAsDangoMonopolyGrid(ByteBuffer _bb)
		{
			return DangoMonopolyGrid.GetRootAsDangoMonopolyGrid(_bb, default(DangoMonopolyGrid));
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x0022F07C File Offset: 0x0022D27C
		public static DangoMonopolyGrid GetRootAsDangoMonopolyGrid(ByteBuffer _bb, DangoMonopolyGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x0022F099 File Offset: 0x0022D299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x0022F0A8 File Offset: 0x0022D2A8
		public DangoMonopolyGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06006653 RID: 26195 RVA: 0x0022F0B8 File Offset: 0x0022D2B8
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

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06006654 RID: 26196 RVA: 0x0022F0F4 File Offset: 0x0022D2F4
		public int GridId
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

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x0022F130 File Offset: 0x0022D330
		public int GridGroupId
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

		// Token: 0x06006656 RID: 26198 RVA: 0x0022F16C File Offset: 0x0022D36C
		public int GridInfo(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06006657 RID: 26199 RVA: 0x0022F1AC File Offset: 0x0022D3AC
		public int GridInfoLength
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

		// Token: 0x06006658 RID: 26200 RVA: 0x0022F1D8 File Offset: 0x0022D3D8
		public Span<int> GetGridInfoBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x0022F1E8 File Offset: 0x0022D3E8
		public int[] GetGridInfoArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600665A RID: 26202 RVA: 0x0022F200 File Offset: 0x0022D400
		public int AddPropertyId
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

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x0022F240 File Offset: 0x0022D440
		public int RemovePropertyId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x0022F27D File Offset: 0x0022D47D
		[NullableContext(1)]
		public int[] GridInfo()
		{
			return this.GetGridInfoArray();
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0022F285 File Offset: 0x0022D485
		[NullableContext(1)]
		public IEnumerable<int> GridInfoIter()
		{
			DangoMonopolyGrid.<GridInfoIter>d__24 <GridInfoIter>d__ = new DangoMonopolyGrid.<GridInfoIter>d__24(-2);
			<GridInfoIter>d__.<>3__<>4__this = this;
			return <GridInfoIter>d__;
		}

		// Token: 0x040051E8 RID: 20968
		private Table __p;
	}
}
