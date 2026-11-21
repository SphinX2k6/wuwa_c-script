using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001054 RID: 4180
	public struct QuestReachableBlock : IFlatbufferObject
	{
		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x0600BBBC RID: 48060 RVA: 0x002EC645 File Offset: 0x002EA845
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x002EC652 File Offset: 0x002EA852
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x002EC65C File Offset: 0x002EA85C
		public static QuestReachableBlock GetRootAsQuestReachableBlock(ByteBuffer _bb)
		{
			return QuestReachableBlock.GetRootAsQuestReachableBlock(_bb, default(QuestReachableBlock));
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x002EC678 File Offset: 0x002EA878
		public static QuestReachableBlock GetRootAsQuestReachableBlock(ByteBuffer _bb, QuestReachableBlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x002EC695 File Offset: 0x002EA895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x002EC6A4 File Offset: 0x002EA8A4
		public QuestReachableBlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600BBC2 RID: 48066 RVA: 0x002EC6B4 File Offset: 0x002EA8B4
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

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x002EC6F0 File Offset: 0x002EA8F0
		public int ReachableBlockIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x002EC730 File Offset: 0x002EA930
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

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x002EC75B File Offset: 0x002EA95B
		public Span<int> GetReachableBlockIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x002EC76A File Offset: 0x002EA96A
		public int[] GetReachableBlockIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0600BBC7 RID: 48071 RVA: 0x002EC784 File Offset: 0x002EA984
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

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x002EC7BB File Offset: 0x002EA9BB
		public Span<byte> GetOnlineBranchBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x002EC7CA File Offset: 0x002EA9CA
		public byte[] GetOnlineBranchArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x002EC7E1 File Offset: 0x002EA9E1
		[NullableContext(1)]
		public int[] ReachableBlockIds()
		{
			return this.GetReachableBlockIdsArray();
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x002EC7E9 File Offset: 0x002EA9E9
		[NullableContext(1)]
		public IEnumerable<int> ReachableBlockIdsIter()
		{
			QuestReachableBlock.<ReachableBlockIdsIter>d__20 <ReachableBlockIdsIter>d__ = new QuestReachableBlock.<ReachableBlockIdsIter>d__20(-2);
			<ReachableBlockIdsIter>d__.<>3__<>4__this = this;
			return <ReachableBlockIdsIter>d__;
		}

		// Token: 0x04005622 RID: 22050
		private Table __p;
	}
}
