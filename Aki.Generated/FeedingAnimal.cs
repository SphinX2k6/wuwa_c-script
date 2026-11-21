using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D49 RID: 3401
	public struct FeedingAnimal : IFlatbufferObject
	{
		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600736E RID: 29550 RVA: 0x0024BCD9 File Offset: 0x00249ED9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0024BCE6 File Offset: 0x00249EE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x0024BCF0 File Offset: 0x00249EF0
		public static FeedingAnimal GetRootAsFeedingAnimal(ByteBuffer _bb)
		{
			return FeedingAnimal.GetRootAsFeedingAnimal(_bb, default(FeedingAnimal));
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x0024BD0C File Offset: 0x00249F0C
		public static FeedingAnimal GetRootAsFeedingAnimal(ByteBuffer _bb, FeedingAnimal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0024BD29 File Offset: 0x00249F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x0024BD38 File Offset: 0x00249F38
		public FeedingAnimal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06007374 RID: 29556 RVA: 0x0024BD48 File Offset: 0x00249F48
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

		// Token: 0x06007375 RID: 29557 RVA: 0x0024BD84 File Offset: 0x00249F84
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06007376 RID: 29558 RVA: 0x0024BDC4 File Offset: 0x00249FC4
		public int ItemIdsLength
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

		// Token: 0x06007377 RID: 29559 RVA: 0x0024BDEF File Offset: 0x00249FEF
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x0024BDFE File Offset: 0x00249FFE
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x0024BE18 File Offset: 0x0024A018
		public string GameplayTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600737A RID: 29562 RVA: 0x0024BE54 File Offset: 0x0024A054
		public int GameplayTagsLength
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

		// Token: 0x0600737B RID: 29563 RVA: 0x0024BE7F File Offset: 0x0024A07F
		[NullableContext(1)]
		public string[] GameplayTags()
		{
			return this.GameplayTagsIter().ToArray<string>();
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0024BE8C File Offset: 0x0024A08C
		[NullableContext(1)]
		public IEnumerable<string> GameplayTagsIter()
		{
			FeedingAnimal.<GameplayTagsIter>d__19 <GameplayTagsIter>d__ = new FeedingAnimal.<GameplayTagsIter>d__19(-2);
			<GameplayTagsIter>d__.<>3__<>4__this = this;
			return <GameplayTagsIter>d__;
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x0024BEA1 File Offset: 0x0024A0A1
		[NullableContext(1)]
		public int[] ItemIds()
		{
			return this.GetItemIdsArray();
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x0024BEA9 File Offset: 0x0024A0A9
		[NullableContext(1)]
		public IEnumerable<int> ItemIdsIter()
		{
			FeedingAnimal.<ItemIdsIter>d__21 <ItemIdsIter>d__ = new FeedingAnimal.<ItemIdsIter>d__21(-2);
			<ItemIdsIter>d__.<>3__<>4__this = this;
			return <ItemIdsIter>d__;
		}

		// Token: 0x04005294 RID: 21140
		private Table __p;
	}
}
