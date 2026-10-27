using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001023 RID: 4131
	public struct RogueTalentTree : IFlatbufferObject
	{
		// Token: 0x1700312C RID: 12588
		// (get) Token: 0x0600C521 RID: 50465 RVA: 0x002F26F8 File Offset: 0x002F08F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C522 RID: 50466 RVA: 0x002F2705 File Offset: 0x002F0905
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x002F270C File Offset: 0x002F090C
		public static RogueTalentTree GetRootAsRogueTalentTree(ByteBuffer _bb)
		{
			return RogueTalentTree.GetRootAsRogueTalentTree(_bb, default(RogueTalentTree));
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x002F2728 File Offset: 0x002F0928
		public static RogueTalentTree GetRootAsRogueTalentTree(ByteBuffer _bb, RogueTalentTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C525 RID: 50469 RVA: 0x002F2745 File Offset: 0x002F0945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C526 RID: 50470 RVA: 0x002F2754 File Offset: 0x002F0954
		public RogueTalentTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700312D RID: 12589
		// (get) Token: 0x0600C527 RID: 50471 RVA: 0x002F2764 File Offset: 0x002F0964
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

		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x0600C528 RID: 50472 RVA: 0x002F27A0 File Offset: 0x002F09A0
		public int SeasonId
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

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600C529 RID: 50473 RVA: 0x002F27DC File Offset: 0x002F09DC
		public int TalentType
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

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600C52A RID: 50474 RVA: 0x002F2818 File Offset: 0x002F0A18
		public int Column
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003131 RID: 12593
		// (get) Token: 0x0600C52B RID: 50475 RVA: 0x002F2858 File Offset: 0x002F0A58
		public int Row
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

		// Token: 0x0600C52C RID: 50476 RVA: 0x002F2898 File Offset: 0x002F0A98
		public int PostId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003132 RID: 12594
		// (get) Token: 0x0600C52D RID: 50477 RVA: 0x002F28D8 File Offset: 0x002F0AD8
		public int PostIdLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x002F2904 File Offset: 0x002F0B04
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x002F2914 File Offset: 0x002F0B14
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x0600C530 RID: 50480 RVA: 0x002F292C File Offset: 0x002F0B2C
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C531 RID: 50481 RVA: 0x002F296C File Offset: 0x002F0B6C
		public int Consule(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003134 RID: 12596
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x002F29AC File Offset: 0x002F0BAC
		public int ConsuleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C533 RID: 50483 RVA: 0x002F29D8 File Offset: 0x002F0BD8
		public Span<int> GetConsuleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C534 RID: 50484 RVA: 0x002F29E8 File Offset: 0x002F0BE8
		public int[] GetConsuleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003135 RID: 12597
		// (get) Token: 0x0600C535 RID: 50485 RVA: 0x002F2A00 File Offset: 0x002F0C00
		public int Describe
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C536 RID: 50486 RVA: 0x002F2A40 File Offset: 0x002F0C40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsuleIter()或GetConsuleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Consule()
		{
			RogueTalentTree rogueTalentTree = this;
			return rogueTalentTree.GetConsuleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x002F2A64 File Offset: 0x002F0C64
		[NullableContext(1)]
		public readonly IEnumerable<int> ConsuleIter()
		{
			RogueTalentTree.<ConsuleIter>d__33 <ConsuleIter>d__ = new RogueTalentTree.<ConsuleIter>d__33(-2);
			<ConsuleIter>d__.<>3__<>4__this = this;
			return <ConsuleIter>d__;
		}

		// Token: 0x0600C538 RID: 50488 RVA: 0x002F2A7C File Offset: 0x002F0C7C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PostIdIter()或GetPostIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PostId()
		{
			RogueTalentTree rogueTalentTree = this;
			return rogueTalentTree.GetPostIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x002F2AA0 File Offset: 0x002F0CA0
		[NullableContext(1)]
		public readonly IEnumerable<int> PostIdIter()
		{
			RogueTalentTree.<PostIdIter>d__35 <PostIdIter>d__ = new RogueTalentTree.<PostIdIter>d__35(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x04005116 RID: 20758
		private Table __p;
	}
}
