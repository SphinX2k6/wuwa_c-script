using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E9 RID: 4329
	public struct SpringFestivalReward : IFlatbufferObject
	{
		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600D8C6 RID: 55494 RVA: 0x0031FFC8 File Offset: 0x0031E1C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x0031FFD5 File Offset: 0x0031E1D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x0031FFDC File Offset: 0x0031E1DC
		public static SpringFestivalReward GetRootAsSpringFestivalReward(ByteBuffer _bb)
		{
			return SpringFestivalReward.GetRootAsSpringFestivalReward(_bb, default(SpringFestivalReward));
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x0031FFF8 File Offset: 0x0031E1F8
		public static SpringFestivalReward GetRootAsSpringFestivalReward(ByteBuffer _bb, SpringFestivalReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D8CA RID: 55498 RVA: 0x00320015 File Offset: 0x0031E215
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x00320024 File Offset: 0x0031E224
		public SpringFestivalReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x00320034 File Offset: 0x0031E234
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

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600D8CD RID: 55501 RVA: 0x00320070 File Offset: 0x0031E270
		public int ActivityId
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

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600D8CE RID: 55502 RVA: 0x003200AC File Offset: 0x0031E2AC
		public int TabId
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

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600D8CF RID: 55503 RVA: 0x003200E8 File Offset: 0x0031E2E8
		public int Sort
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

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x00320128 File Offset: 0x0031E328
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D8D1 RID: 55505 RVA: 0x00320160 File Offset: 0x0031E360
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D8D2 RID: 55506 RVA: 0x00320170 File Offset: 0x0031E370
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600D8D3 RID: 55507 RVA: 0x00320188 File Offset: 0x0031E388
		public int ConditionGroup
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

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600D8D4 RID: 55508 RVA: 0x003201C8 File Offset: 0x0031E3C8
		public int DropId
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

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600D8D5 RID: 55509 RVA: 0x00320208 File Offset: 0x0031E408
		public int SkipType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x00320248 File Offset: 0x0031E448
		public string SkipParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600D8D7 RID: 55511 RVA: 0x00320284 File Offset: 0x0031E484
		public int SkipParamLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x003202B0 File Offset: 0x0031E4B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkipParamIter()或GetSkipParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkipParam()
		{
			return this.SkipParamIter().ToArray<string>();
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x003202BD File Offset: 0x0031E4BD
		[NullableContext(1)]
		public readonly IEnumerable<string> SkipParamIter()
		{
			SpringFestivalReward.<SkipParamIter>d__30 <SkipParamIter>d__ = new SpringFestivalReward.<SkipParamIter>d__30(-2);
			<SkipParamIter>d__.<>3__<>4__this = this;
			return <SkipParamIter>d__;
		}

		// Token: 0x0400521D RID: 21021
		private Table __p;
	}
}
