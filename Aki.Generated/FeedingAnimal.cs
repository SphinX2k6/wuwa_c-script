using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C65 RID: 3173
	public struct FeedingAnimal : IFlatbufferObject
	{
		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06006D63 RID: 28003 RVA: 0x0022C989 File Offset: 0x0022AB89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x0022C996 File Offset: 0x0022AB96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x0022C9A0 File Offset: 0x0022ABA0
		public static FeedingAnimal GetRootAsFeedingAnimal(ByteBuffer _bb)
		{
			return FeedingAnimal.GetRootAsFeedingAnimal(_bb, default(FeedingAnimal));
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0022C9BC File Offset: 0x0022ABBC
		public static FeedingAnimal GetRootAsFeedingAnimal(ByteBuffer _bb, FeedingAnimal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x0022C9D9 File Offset: 0x0022ABD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x0022C9E8 File Offset: 0x0022ABE8
		public FeedingAnimal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x0022C9F8 File Offset: 0x0022ABF8
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

		// Token: 0x06006D6A RID: 28010 RVA: 0x0022CA34 File Offset: 0x0022AC34
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x0022CA74 File Offset: 0x0022AC74
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

		// Token: 0x06006D6C RID: 28012 RVA: 0x0022CA9F File Offset: 0x0022AC9F
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x0022CAAE File Offset: 0x0022ACAE
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x0022CAC8 File Offset: 0x0022ACC8
		public string GameplayTags(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x0022CB04 File Offset: 0x0022AD04
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

		// Token: 0x06006D70 RID: 28016 RVA: 0x0022CB2F File Offset: 0x0022AD2F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GameplayTagsIter()或GetGameplayTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] GameplayTags()
		{
			return this.GameplayTagsIter().ToArray<string>();
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x0022CB3C File Offset: 0x0022AD3C
		[NullableContext(1)]
		public readonly IEnumerable<string> GameplayTagsIter()
		{
			FeedingAnimal.<GameplayTagsIter>d__19 <GameplayTagsIter>d__ = new FeedingAnimal.<GameplayTagsIter>d__19(-2);
			<GameplayTagsIter>d__.<>3__<>4__this = this;
			return <GameplayTagsIter>d__;
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x0022CB54 File Offset: 0x0022AD54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemIdsIter()或GetItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemIds()
		{
			FeedingAnimal feedingAnimal = this;
			return feedingAnimal.GetItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x0022CB78 File Offset: 0x0022AD78
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemIdsIter()
		{
			FeedingAnimal.<ItemIdsIter>d__21 <ItemIdsIter>d__ = new FeedingAnimal.<ItemIdsIter>d__21(-2);
			<ItemIdsIter>d__.<>3__<>4__this = this;
			return <ItemIdsIter>d__;
		}

		// Token: 0x04004CB0 RID: 19632
		private Table __p;
	}
}
