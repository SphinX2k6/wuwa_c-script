using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106B RID: 4203
	public struct RougeMiraclecreation : IFlatbufferObject
	{
		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x0030221C File Offset: 0x0030041C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC12 RID: 52242 RVA: 0x00302229 File Offset: 0x00300429
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC13 RID: 52243 RVA: 0x00302230 File Offset: 0x00300430
		public static RougeMiraclecreation GetRootAsRougeMiraclecreation(ByteBuffer _bb)
		{
			return RougeMiraclecreation.GetRootAsRougeMiraclecreation(_bb, default(RougeMiraclecreation));
		}

		// Token: 0x0600CC14 RID: 52244 RVA: 0x0030224C File Offset: 0x0030044C
		public static RougeMiraclecreation GetRootAsRougeMiraclecreation(ByteBuffer _bb, RougeMiraclecreation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC15 RID: 52245 RVA: 0x00302269 File Offset: 0x00300469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC16 RID: 52246 RVA: 0x00302278 File Offset: 0x00300478
		public RougeMiraclecreation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600CC17 RID: 52247 RVA: 0x00302288 File Offset: 0x00300488
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

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600CC18 RID: 52248 RVA: 0x003022C4 File Offset: 0x003004C4
		public int Category
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

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600CC19 RID: 52249 RVA: 0x00302300 File Offset: 0x00300500
		public int DefaultLevel
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

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600CC1A RID: 52250 RVA: 0x0030233C File Offset: 0x0030053C
		public int Level
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

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600CC1B RID: 52251 RVA: 0x0030237C File Offset: 0x0030057C
		public int MaxLevel
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

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600CC1C RID: 52252 RVA: 0x003023BC File Offset: 0x003005BC
		public string Icon
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

		// Token: 0x0600CC1D RID: 52253 RVA: 0x003023F4 File Offset: 0x003005F4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC1E RID: 52254 RVA: 0x00302404 File Offset: 0x00300604
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600CC1F RID: 52255 RVA: 0x0030241C File Offset: 0x0030061C
		public string Name
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

		// Token: 0x0600CC20 RID: 52256 RVA: 0x00302454 File Offset: 0x00300654
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC21 RID: 52257 RVA: 0x00302464 File Offset: 0x00300664
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600CC22 RID: 52258 RVA: 0x0030247C File Offset: 0x0030067C
		public string BriefDescribe
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC23 RID: 52259 RVA: 0x003024B4 File Offset: 0x003006B4
		public Span<byte> GetBriefDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CC24 RID: 52260 RVA: 0x003024C4 File Offset: 0x003006C4
		public byte[] GetBriefDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC25 RID: 52261 RVA: 0x003024DC File Offset: 0x003006DC
		public string BriefDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00302518 File Offset: 0x00300718
		public int BriefDescParamLength
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

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600CC27 RID: 52263 RVA: 0x00302544 File Offset: 0x00300744
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC28 RID: 52264 RVA: 0x0030257C File Offset: 0x0030077C
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CC29 RID: 52265 RVA: 0x0030258C File Offset: 0x0030078C
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC2A RID: 52266 RVA: 0x003025A4 File Offset: 0x003007A4
		public string DescParam(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600CC2B RID: 52267 RVA: 0x003025E0 File Offset: 0x003007E0
		public int DescParamLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600CC2C RID: 52268 RVA: 0x0030260C File Offset: 0x0030080C
		public string StoryDescribe
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x00302644 File Offset: 0x00300844
		public Span<byte> GetStoryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x00302654 File Offset: 0x00300854
		public byte[] GetStoryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600CC2F RID: 52271 RVA: 0x0030266C File Offset: 0x0030086C
		public int ColorType
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x003026A9 File Offset: 0x003008A9
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BriefDescParamIter()或GetBriefDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BriefDescParam()
		{
			return this.BriefDescParamIter().ToArray<string>();
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x003026B6 File Offset: 0x003008B6
		[NullableContext(1)]
		public readonly IEnumerable<string> BriefDescParamIter()
		{
			RougeMiraclecreation.<BriefDescParamIter>d__47 <BriefDescParamIter>d__ = new RougeMiraclecreation.<BriefDescParamIter>d__47(-2);
			<BriefDescParamIter>d__.<>3__<>4__this = this;
			return <BriefDescParamIter>d__;
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x003026CB File Offset: 0x003008CB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamIter()或GetDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x003026D8 File Offset: 0x003008D8
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamIter()
		{
			RougeMiraclecreation.<DescParamIter>d__49 <DescParamIter>d__ = new RougeMiraclecreation.<DescParamIter>d__49(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x04005170 RID: 20848
		private Table __p;
	}
}
