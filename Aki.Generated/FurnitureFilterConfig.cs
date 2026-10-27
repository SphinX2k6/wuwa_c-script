using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD9 RID: 3289
	public struct FurnitureFilterConfig : IFlatbufferObject
	{
		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060077B5 RID: 30645 RVA: 0x00244FF8 File Offset: 0x002431F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00245005 File Offset: 0x00243205
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x0024500C File Offset: 0x0024320C
		public static FurnitureFilterConfig GetRootAsFurnitureFilterConfig(ByteBuffer _bb)
		{
			return FurnitureFilterConfig.GetRootAsFurnitureFilterConfig(_bb, default(FurnitureFilterConfig));
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00245028 File Offset: 0x00243228
		public static FurnitureFilterConfig GetRootAsFurnitureFilterConfig(ByteBuffer _bb, FurnitureFilterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x00245045 File Offset: 0x00243245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00245054 File Offset: 0x00243254
		public FurnitureFilterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x00245064 File Offset: 0x00243264
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

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060077BC RID: 30652 RVA: 0x002450A0 File Offset: 0x002432A0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x002450D7 File Offset: 0x002432D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x002450E6 File Offset: 0x002432E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00245100 File Offset: 0x00243300
		public int TagList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x00245140 File Offset: 0x00243340
		public int TagListLength
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

		// Token: 0x060077C1 RID: 30657 RVA: 0x0024516B File Offset: 0x0024336B
		public Span<int> GetTagListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x0024517A File Offset: 0x0024337A
		public int[] GetTagListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00245194 File Offset: 0x00243394
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagListIter()或GetTagListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TagList()
		{
			FurnitureFilterConfig furnitureFilterConfig = this;
			return furnitureFilterConfig.GetTagListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x002451B8 File Offset: 0x002433B8
		[NullableContext(1)]
		public readonly IEnumerable<int> TagListIter()
		{
			FurnitureFilterConfig.<TagListIter>d__20 <TagListIter>d__ = new FurnitureFilterConfig.<TagListIter>d__20(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x04004D49 RID: 19785
		private Table __p;
	}
}
