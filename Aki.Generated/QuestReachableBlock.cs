using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F6D RID: 3949
	public struct QuestReachableBlock : IFlatbufferObject
	{
		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x0600B57F RID: 46463 RVA: 0x002CFA29 File Offset: 0x002CDC29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x002CFA36 File Offset: 0x002CDC36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x002CFA40 File Offset: 0x002CDC40
		public static QuestReachableBlock GetRootAsQuestReachableBlock(ByteBuffer _bb)
		{
			return QuestReachableBlock.GetRootAsQuestReachableBlock(_bb, default(QuestReachableBlock));
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x002CFA5C File Offset: 0x002CDC5C
		public static QuestReachableBlock GetRootAsQuestReachableBlock(ByteBuffer _bb, QuestReachableBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x002CFA79 File Offset: 0x002CDC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x002CFA88 File Offset: 0x002CDC88
		public QuestReachableBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x0600B585 RID: 46469 RVA: 0x002CFA98 File Offset: 0x002CDC98
		public int QuestId
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

		// Token: 0x0600B586 RID: 46470 RVA: 0x002CFAD4 File Offset: 0x002CDCD4
		public int ReachableBlockIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x0600B587 RID: 46471 RVA: 0x002CFB14 File Offset: 0x002CDD14
		public int ReachableBlockIdsLength
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

		// Token: 0x0600B588 RID: 46472 RVA: 0x002CFB3F File Offset: 0x002CDD3F
		public Span<int> GetReachableBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x002CFB4E File Offset: 0x002CDD4E
		public int[] GetReachableBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x0600B58A RID: 46474 RVA: 0x002CFB68 File Offset: 0x002CDD68
		public string OnlineBranch
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B58B RID: 46475 RVA: 0x002CFB9F File Offset: 0x002CDD9F
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x002CFBAE File Offset: 0x002CDDAE
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x002CFBC8 File Offset: 0x002CDDC8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReachableBlockIdsIter()或GetReachableBlockIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReachableBlockIds()
		{
			QuestReachableBlock questReachableBlock = this;
			return questReachableBlock.GetReachableBlockIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x002CFBEC File Offset: 0x002CDDEC
		[NullableContext(1)]
		public readonly IEnumerable<int> ReachableBlockIdsIter()
		{
			QuestReachableBlock.<ReachableBlockIdsIter>d__20 <ReachableBlockIdsIter>d__ = new QuestReachableBlock.<ReachableBlockIdsIter>d__20(-2);
			<ReachableBlockIdsIter>d__.<>3__<>4__this = this;
			return <ReachableBlockIdsIter>d__;
		}

		// Token: 0x0400503B RID: 20539
		private Table __p;
	}
}
