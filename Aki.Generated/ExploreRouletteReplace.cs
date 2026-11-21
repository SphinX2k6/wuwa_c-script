using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D35 RID: 3381
	public struct ExploreRouletteReplace : IFlatbufferObject
	{
		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x00248149 File Offset: 0x00246349
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x00248156 File Offset: 0x00246356
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x00248160 File Offset: 0x00246360
		public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb)
		{
			return ExploreRouletteReplace.GetRootAsExploreRouletteReplace(_bb, default(ExploreRouletteReplace));
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x0024817C File Offset: 0x0024637C
		public static ExploreRouletteReplace GetRootAsExploreRouletteReplace(ByteBuffer _bb, ExploreRouletteReplace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00248199 File Offset: 0x00246399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x002481A8 File Offset: 0x002463A8
		public ExploreRouletteReplace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x002481B8 File Offset: 0x002463B8
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

		// Token: 0x060071C2 RID: 29122 RVA: 0x002481F4 File Offset: 0x002463F4
		public string TagsInForce(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00248230 File Offset: 0x00246430
		public int TagsInForceLength
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

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x060071C4 RID: 29124 RVA: 0x0024825C File Offset: 0x0024645C
		public int Priority
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

		// Token: 0x060071C5 RID: 29125 RVA: 0x00248298 File Offset: 0x00246498
		public int RouletteSkillIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x060071C6 RID: 29126 RVA: 0x002482D8 File Offset: 0x002464D8
		public int RouletteSkillIdListLength
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

		// Token: 0x060071C7 RID: 29127 RVA: 0x00248304 File Offset: 0x00246504
		public Span<int> GetRouletteSkillIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00248314 File Offset: 0x00246514
		public int[] GetRouletteSkillIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x0024832C File Offset: 0x0024652C
		public int RouletteItemId
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

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x060071CA RID: 29130 RVA: 0x0024836C File Offset: 0x0024656C
		public int ReplaceSkillId
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

		// Token: 0x060071CB RID: 29131 RVA: 0x002483A9 File Offset: 0x002465A9
		[NullableContext(1)]
		public int[] RouletteSkillIdList()
		{
			return this.GetRouletteSkillIdListArray();
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x002483B1 File Offset: 0x002465B1
		[NullableContext(1)]
		public IEnumerable<int> RouletteSkillIdListIter()
		{
			ExploreRouletteReplace.<RouletteSkillIdListIter>d__25 <RouletteSkillIdListIter>d__ = new ExploreRouletteReplace.<RouletteSkillIdListIter>d__25(-2);
			<RouletteSkillIdListIter>d__.<>3__<>4__this = this;
			return <RouletteSkillIdListIter>d__;
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x002483C6 File Offset: 0x002465C6
		[NullableContext(1)]
		public string[] TagsInForce()
		{
			return this.TagsInForceIter().ToArray<string>();
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x002483D3 File Offset: 0x002465D3
		[NullableContext(1)]
		public IEnumerable<string> TagsInForceIter()
		{
			ExploreRouletteReplace.<TagsInForceIter>d__27 <TagsInForceIter>d__ = new ExploreRouletteReplace.<TagsInForceIter>d__27(-2);
			<TagsInForceIter>d__.<>3__<>4__this = this;
			return <TagsInForceIter>d__;
		}

		// Token: 0x0400527C RID: 21116
		private Table __p;
	}
}
