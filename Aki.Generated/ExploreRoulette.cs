using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D34 RID: 3380
	public struct ExploreRoulette : IFlatbufferObject
	{
		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060071B0 RID: 29104 RVA: 0x00248018 File Offset: 0x00246218
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x00248025 File Offset: 0x00246225
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x0024802C File Offset: 0x0024622C
		public static ExploreRoulette GetRootAsExploreRoulette(ByteBuffer _bb)
		{
			return ExploreRoulette.GetRootAsExploreRoulette(_bb, default(ExploreRoulette));
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x00248048 File Offset: 0x00246248
		public static ExploreRoulette GetRootAsExploreRoulette(ByteBuffer _bb, ExploreRoulette obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x00248065 File Offset: 0x00246265
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071B5 RID: 29109 RVA: 0x00248074 File Offset: 0x00246274
		public ExploreRoulette __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060071B6 RID: 29110 RVA: 0x00248084 File Offset: 0x00246284
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

		// Token: 0x060071B7 RID: 29111 RVA: 0x002480C0 File Offset: 0x002462C0
		public string BanTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060071B8 RID: 29112 RVA: 0x002480FC File Offset: 0x002462FC
		public int BanTagsLength
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

		// Token: 0x060071B9 RID: 29113 RVA: 0x00248127 File Offset: 0x00246327
		[NullableContext(1)]
		public string[] BanTags()
		{
			return this.BanTagsIter().ToArray<string>();
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00248134 File Offset: 0x00246334
		[NullableContext(1)]
		public IEnumerable<string> BanTagsIter()
		{
			ExploreRoulette.<BanTagsIter>d__14 <BanTagsIter>d__ = new ExploreRoulette.<BanTagsIter>d__14(-2);
			<BanTagsIter>d__.<>3__<>4__this = this;
			return <BanTagsIter>d__;
		}

		// Token: 0x0400527B RID: 21115
		private Table __p;
	}
}
