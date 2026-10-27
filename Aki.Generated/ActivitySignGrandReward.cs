using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACC RID: 2764
	public struct ActivitySignGrandReward : IFlatbufferObject
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060043DE RID: 17374 RVA: 0x001CD41B File Offset: 0x001CB61B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x001CD428 File Offset: 0x001CB628
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x001CD430 File Offset: 0x001CB630
		public static ActivitySignGrandReward GetRootAsActivitySignGrandReward(ByteBuffer _bb)
		{
			return ActivitySignGrandReward.GetRootAsActivitySignGrandReward(_bb, default(ActivitySignGrandReward));
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x001CD44C File Offset: 0x001CB64C
		public static ActivitySignGrandReward GetRootAsActivitySignGrandReward(ByteBuffer _bb, ActivitySignGrandReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x001CD469 File Offset: 0x001CB669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x001CD478 File Offset: 0x001CB678
		public ActivitySignGrandReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060043E4 RID: 17380 RVA: 0x001CD488 File Offset: 0x001CB688
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

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x001CD4C4 File Offset: 0x001CB6C4
		public int GrandRewardIndex
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x001CD500 File Offset: 0x001CB700
		public string GrandSourcePath
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

		// Token: 0x060043E7 RID: 17383 RVA: 0x001CD537 File Offset: 0x001CB737
		public Span<byte> GetGrandSourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x001CD546 File Offset: 0x001CB746
		public byte[] GetGrandSourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x001CD560 File Offset: 0x001CB760
		public int PreviewType
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

		// Token: 0x060043EA RID: 17386 RVA: 0x001CD5A0 File Offset: 0x001CB7A0
		public int PreviewList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x001CD5E0 File Offset: 0x001CB7E0
		public int PreviewListLength
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

		// Token: 0x060043EC RID: 17388 RVA: 0x001CD60C File Offset: 0x001CB80C
		public Span<int> GetPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x001CD61C File Offset: 0x001CB81C
		public int[] GetPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060043EE RID: 17390 RVA: 0x001CD634 File Offset: 0x001CB834
		public string GrandTitle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x001CD66C File Offset: 0x001CB86C
		public Span<byte> GetGrandTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x001CD67C File Offset: 0x001CB87C
		public byte[] GetGrandTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x001CD694 File Offset: 0x001CB894
		public string GrandDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x001CD6CC File Offset: 0x001CB8CC
		public Span<byte> GetGrandDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x001CD6DC File Offset: 0x001CB8DC
		public byte[] GetGrandDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x001CD6F4 File Offset: 0x001CB8F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreviewListIter()或GetPreviewListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreviewList()
		{
			ActivitySignGrandReward activitySignGrandReward = this;
			return activitySignGrandReward.GetPreviewListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x001CD718 File Offset: 0x001CB918
		[NullableContext(1)]
		public readonly IEnumerable<int> PreviewListIter()
		{
			ActivitySignGrandReward.<PreviewListIter>d__32 <PreviewListIter>d__ = new ActivitySignGrandReward.<PreviewListIter>d__32(-2);
			<PreviewListIter>d__.<>3__<>4__this = this;
			return <PreviewListIter>d__;
		}

		// Token: 0x04004AA9 RID: 19113
		private Table __p;
	}
}
