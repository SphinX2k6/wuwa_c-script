using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D30 RID: 3376
	public struct HonamiStoryBackPack : IFlatbufferObject
	{
		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x002559FB File Offset: 0x00253BFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x00255A08 File Offset: 0x00253C08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x00255A10 File Offset: 0x00253C10
		public static HonamiStoryBackPack GetRootAsHonamiStoryBackPack(ByteBuffer _bb)
		{
			return HonamiStoryBackPack.GetRootAsHonamiStoryBackPack(_bb, default(HonamiStoryBackPack));
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x00255A2C File Offset: 0x00253C2C
		public static HonamiStoryBackPack GetRootAsHonamiStoryBackPack(ByteBuffer _bb, HonamiStoryBackPack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x00255A49 File Offset: 0x00253C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x00255A58 File Offset: 0x00253C58
		public HonamiStoryBackPack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06007F20 RID: 32544 RVA: 0x00255A68 File Offset: 0x00253C68
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

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x00255AA4 File Offset: 0x00253CA4
		public int Type
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

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06007F22 RID: 32546 RVA: 0x00255AE0 File Offset: 0x00253CE0
		public int ActivityId
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

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00255B1C File Offset: 0x00253D1C
		public int Wide
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

		// Token: 0x06007F24 RID: 32548 RVA: 0x00255B5C File Offset: 0x00253D5C
		public int Size(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x00255B9C File Offset: 0x00253D9C
		public int SizeLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x00255BC8 File Offset: 0x00253DC8
		public Span<int> GetSizeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x00255BD8 File Offset: 0x00253DD8
		public int[] GetSizeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06007F28 RID: 32552 RVA: 0x00255BF0 File Offset: 0x00253DF0
		public int CanOrganize
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x00255C30 File Offset: 0x00253E30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SizeIter()或GetSizeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Size()
		{
			HonamiStoryBackPack honamiStoryBackPack = this;
			return honamiStoryBackPack.GetSizeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x00255C54 File Offset: 0x00253E54
		[NullableContext(1)]
		public readonly IEnumerable<int> SizeIter()
		{
			HonamiStoryBackPack.<SizeIter>d__24 <SizeIter>d__ = new HonamiStoryBackPack.<SizeIter>d__24(-2);
			<SizeIter>d__.<>3__<>4__this = this;
			return <SizeIter>d__;
		}

		// Token: 0x04004DA9 RID: 19881
		private Table __p;
	}
}
