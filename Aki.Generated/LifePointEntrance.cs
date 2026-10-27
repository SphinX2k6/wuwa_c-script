using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC7 RID: 3527
	public struct LifePointEntrance : IFlatbufferObject
	{
		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x00277504 File Offset: 0x00275704
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x00277511 File Offset: 0x00275711
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x00277518 File Offset: 0x00275718
		public static LifePointEntrance GetRootAsLifePointEntrance(ByteBuffer _bb)
		{
			return LifePointEntrance.GetRootAsLifePointEntrance(_bb, default(LifePointEntrance));
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x00277534 File Offset: 0x00275734
		public static LifePointEntrance GetRootAsLifePointEntrance(ByteBuffer _bb, LifePointEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00277551 File Offset: 0x00275751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x00277560 File Offset: 0x00275760
		public LifePointEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06008DE7 RID: 36327 RVA: 0x00277570 File Offset: 0x00275770
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

		// Token: 0x06008DE8 RID: 36328 RVA: 0x002775AC File Offset: 0x002757AC
		public int GroupList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x002775EC File Offset: 0x002757EC
		public int GroupListLength
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

		// Token: 0x06008DEA RID: 36330 RVA: 0x00277617 File Offset: 0x00275817
		public Span<int> GetGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x00277626 File Offset: 0x00275826
		public int[] GetGroupListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x00277640 File Offset: 0x00275840
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupListIter()或GetGroupListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupList()
		{
			LifePointEntrance lifePointEntrance = this;
			return lifePointEntrance.GetGroupListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x00277664 File Offset: 0x00275864
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupListIter()
		{
			LifePointEntrance.<GroupListIter>d__16 <GroupListIter>d__ = new LifePointEntrance.<GroupListIter>d__16(-2);
			<GroupListIter>d__.<>3__<>4__this = this;
			return <GroupListIter>d__;
		}

		// Token: 0x04004E5D RID: 20061
		private Table __p;
	}
}
