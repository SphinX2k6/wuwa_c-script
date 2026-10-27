using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCB RID: 3531
	public struct LineCrossEntrance : IFlatbufferObject
	{
		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06008E31 RID: 36401 RVA: 0x00277F18 File Offset: 0x00276118
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x00277F25 File Offset: 0x00276125
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x00277F2C File Offset: 0x0027612C
		public static LineCrossEntrance GetRootAsLineCrossEntrance(ByteBuffer _bb)
		{
			return LineCrossEntrance.GetRootAsLineCrossEntrance(_bb, default(LineCrossEntrance));
		}

		// Token: 0x06008E34 RID: 36404 RVA: 0x00277F48 File Offset: 0x00276148
		public static LineCrossEntrance GetRootAsLineCrossEntrance(ByteBuffer _bb, LineCrossEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E35 RID: 36405 RVA: 0x00277F65 File Offset: 0x00276165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x00277F74 File Offset: 0x00276174
		public LineCrossEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x00277F84 File Offset: 0x00276184
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

		// Token: 0x06008E38 RID: 36408 RVA: 0x00277FC0 File Offset: 0x002761C0
		public int GroupList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00278000 File Offset: 0x00276200
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

		// Token: 0x06008E3A RID: 36410 RVA: 0x0027802B File Offset: 0x0027622B
		public Span<int> GetGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x0027803A File Offset: 0x0027623A
		public int[] GetGroupListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x00278054 File Offset: 0x00276254
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupListIter()或GetGroupListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupList()
		{
			LineCrossEntrance lineCrossEntrance = this;
			return lineCrossEntrance.GetGroupListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00278078 File Offset: 0x00276278
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupListIter()
		{
			LineCrossEntrance.<GroupListIter>d__16 <GroupListIter>d__ = new LineCrossEntrance.<GroupListIter>d__16(-2);
			<GroupListIter>d__.<>3__<>4__this = this;
			return <GroupListIter>d__;
		}

		// Token: 0x04004E61 RID: 20065
		private Table __p;
	}
}
