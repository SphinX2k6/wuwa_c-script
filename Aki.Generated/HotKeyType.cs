using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D57 RID: 3415
	public struct HotKeyType : IFlatbufferObject
	{
		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x0600823E RID: 33342 RVA: 0x0025C77D File Offset: 0x0025A97D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600823F RID: 33343 RVA: 0x0025C78A File Offset: 0x0025A98A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008240 RID: 33344 RVA: 0x0025C794 File Offset: 0x0025A994
		public static HotKeyType GetRootAsHotKeyType(ByteBuffer _bb)
		{
			return HotKeyType.GetRootAsHotKeyType(_bb, default(HotKeyType));
		}

		// Token: 0x06008241 RID: 33345 RVA: 0x0025C7B0 File Offset: 0x0025A9B0
		public static HotKeyType GetRootAsHotKeyType(ByteBuffer _bb, HotKeyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008242 RID: 33346 RVA: 0x0025C7CD File Offset: 0x0025A9CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008243 RID: 33347 RVA: 0x0025C7DC File Offset: 0x0025A9DC
		public HotKeyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06008244 RID: 33348 RVA: 0x0025C7EC File Offset: 0x0025A9EC
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

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x0025C828 File Offset: 0x0025AA28
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

		// Token: 0x06008246 RID: 33350 RVA: 0x0025C864 File Offset: 0x0025AA64
		public int HotKeyList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06008247 RID: 33351 RVA: 0x0025C8A4 File Offset: 0x0025AAA4
		public int HotKeyListLength
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

		// Token: 0x06008248 RID: 33352 RVA: 0x0025C8CF File Offset: 0x0025AACF
		public Span<int> GetHotKeyListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008249 RID: 33353 RVA: 0x0025C8DE File Offset: 0x0025AADE
		public int[] GetHotKeyListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600824A RID: 33354 RVA: 0x0025C8F8 File Offset: 0x0025AAF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HotKeyListIter()或GetHotKeyListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HotKeyList()
		{
			HotKeyType hotKeyType = this;
			return hotKeyType.GetHotKeyListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600824B RID: 33355 RVA: 0x0025C91C File Offset: 0x0025AB1C
		[NullableContext(1)]
		public readonly IEnumerable<int> HotKeyListIter()
		{
			HotKeyType.<HotKeyListIter>d__18 <HotKeyListIter>d__ = new HotKeyType.<HotKeyListIter>d__18(-2);
			<HotKeyListIter>d__.<>3__<>4__this = this;
			return <HotKeyListIter>d__;
		}

		// Token: 0x04004DD6 RID: 19926
		private Table __p;
	}
}
