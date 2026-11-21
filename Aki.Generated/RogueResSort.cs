using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FB RID: 4347
	public struct RogueResSort : IFlatbufferObject
	{
		// Token: 0x1700313F RID: 12607
		// (get) Token: 0x0600CA39 RID: 51769 RVA: 0x0030BCE0 File Offset: 0x00309EE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x0030BCED File Offset: 0x00309EED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA3B RID: 51771 RVA: 0x0030BCF4 File Offset: 0x00309EF4
		public static RogueResSort GetRootAsRogueResSort(ByteBuffer _bb)
		{
			return RogueResSort.GetRootAsRogueResSort(_bb, default(RogueResSort));
		}

		// Token: 0x0600CA3C RID: 51772 RVA: 0x0030BD10 File Offset: 0x00309F10
		public static RogueResSort GetRootAsRogueResSort(ByteBuffer _bb, RogueResSort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x0030BD2D File Offset: 0x00309F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA3E RID: 51774 RVA: 0x0030BD3C File Offset: 0x00309F3C
		public RogueResSort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003140 RID: 12608
		// (get) Token: 0x0600CA3F RID: 51775 RVA: 0x0030BD4C File Offset: 0x00309F4C
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

		// Token: 0x17003141 RID: 12609
		// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x0030BD88 File Offset: 0x00309F88
		public int Column
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

		// Token: 0x17003142 RID: 12610
		// (get) Token: 0x0600CA41 RID: 51777 RVA: 0x0030BDC4 File Offset: 0x00309FC4
		public int Row
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

		// Token: 0x0600CA42 RID: 51778 RVA: 0x0030BE00 File Offset: 0x0030A000
		public int PostId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003143 RID: 12611
		// (get) Token: 0x0600CA43 RID: 51779 RVA: 0x0030BE40 File Offset: 0x0030A040
		public int PostIdLength
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

		// Token: 0x0600CA44 RID: 51780 RVA: 0x0030BE6C File Offset: 0x0030A06C
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x0030BE7C File Offset: 0x0030A07C
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x0030BE94 File Offset: 0x0030A094
		[NullableContext(1)]
		public int[] PostId()
		{
			return this.GetPostIdArray();
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x0030BE9C File Offset: 0x0030A09C
		[NullableContext(1)]
		public IEnumerable<int> PostIdIter()
		{
			RogueResSort.<PostIdIter>d__20 <PostIdIter>d__ = new RogueResSort.<PostIdIter>d__20(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x040056E9 RID: 22249
		private Table __p;
	}
}
