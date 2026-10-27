using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001013 RID: 4115
	public struct RogueResSort : IFlatbufferObject
	{
		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x0600C3EF RID: 50159 RVA: 0x002EFC04 File Offset: 0x002EDE04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3F0 RID: 50160 RVA: 0x002EFC11 File Offset: 0x002EDE11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3F1 RID: 50161 RVA: 0x002EFC18 File Offset: 0x002EDE18
		public static RogueResSort GetRootAsRogueResSort(ByteBuffer _bb)
		{
			return RogueResSort.GetRootAsRogueResSort(_bb, default(RogueResSort));
		}

		// Token: 0x0600C3F2 RID: 50162 RVA: 0x002EFC34 File Offset: 0x002EDE34
		public static RogueResSort GetRootAsRogueResSort(ByteBuffer _bb, RogueResSort obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x002EFC51 File Offset: 0x002EDE51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x002EFC60 File Offset: 0x002EDE60
		public RogueResSort __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x0600C3F5 RID: 50165 RVA: 0x002EFC70 File Offset: 0x002EDE70
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

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x0600C3F6 RID: 50166 RVA: 0x002EFCAC File Offset: 0x002EDEAC
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

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600C3F7 RID: 50167 RVA: 0x002EFCE8 File Offset: 0x002EDEE8
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

		// Token: 0x0600C3F8 RID: 50168 RVA: 0x002EFD24 File Offset: 0x002EDF24
		public int PostId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600C3F9 RID: 50169 RVA: 0x002EFD64 File Offset: 0x002EDF64
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

		// Token: 0x0600C3FA RID: 50170 RVA: 0x002EFD90 File Offset: 0x002EDF90
		public Span<int> GetPostIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C3FB RID: 50171 RVA: 0x002EFDA0 File Offset: 0x002EDFA0
		public int[] GetPostIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x002EFDB8 File Offset: 0x002EDFB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PostIdIter()或GetPostIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PostId()
		{
			RogueResSort rogueResSort = this;
			return rogueResSort.GetPostIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C3FD RID: 50173 RVA: 0x002EFDDC File Offset: 0x002EDFDC
		[NullableContext(1)]
		public readonly IEnumerable<int> PostIdIter()
		{
			RogueResSort.<PostIdIter>d__20 <PostIdIter>d__ = new RogueResSort.<PostIdIter>d__20(-2);
			<PostIdIter>d__.<>3__<>4__this = this;
			return <PostIdIter>d__;
		}

		// Token: 0x04005101 RID: 20737
		private Table __p;
	}
}
