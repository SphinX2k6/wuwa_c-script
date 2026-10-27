using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106D RID: 4205
	public struct RougePopularEntrie : IFlatbufferObject
	{
		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600CC4B RID: 52299 RVA: 0x003029B5 File Offset: 0x00300BB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x003029C2 File Offset: 0x00300BC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x003029CC File Offset: 0x00300BCC
		public static RougePopularEntrie GetRootAsRougePopularEntrie(ByteBuffer _bb)
		{
			return RougePopularEntrie.GetRootAsRougePopularEntrie(_bb, default(RougePopularEntrie));
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x003029E8 File Offset: 0x00300BE8
		public static RougePopularEntrie GetRootAsRougePopularEntrie(ByteBuffer _bb, RougePopularEntrie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x00302A05 File Offset: 0x00300C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC50 RID: 52304 RVA: 0x00302A14 File Offset: 0x00300C14
		public RougePopularEntrie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600CC51 RID: 52305 RVA: 0x00302A24 File Offset: 0x00300C24
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

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600CC52 RID: 52306 RVA: 0x00302A60 File Offset: 0x00300C60
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

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600CC53 RID: 52307 RVA: 0x00302A9C File Offset: 0x00300C9C
		public int Rate
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

		// Token: 0x0600CC54 RID: 52308 RVA: 0x00302AD8 File Offset: 0x00300CD8
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600CC55 RID: 52309 RVA: 0x00302B18 File Offset: 0x00300D18
		public int InstsLength
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

		// Token: 0x0600CC56 RID: 52310 RVA: 0x00302B44 File Offset: 0x00300D44
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00302B54 File Offset: 0x00300D54
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600CC58 RID: 52312 RVA: 0x00302B6C File Offset: 0x00300D6C
		public string Icon
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

		// Token: 0x0600CC59 RID: 52313 RVA: 0x00302BA4 File Offset: 0x00300DA4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x00302BB4 File Offset: 0x00300DB4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600CC5B RID: 52315 RVA: 0x00302BCC File Offset: 0x00300DCC
		public string Title
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

		// Token: 0x0600CC5C RID: 52316 RVA: 0x00302C04 File Offset: 0x00300E04
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x00302C14 File Offset: 0x00300E14
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x00302C2C File Offset: 0x00300E2C
		public string Describe
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

		// Token: 0x0600CC5F RID: 52319 RVA: 0x00302C64 File Offset: 0x00300E64
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x00302C74 File Offset: 0x00300E74
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x00302C8C File Offset: 0x00300E8C
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600CC62 RID: 52322 RVA: 0x00302CC8 File Offset: 0x00300EC8
		public int DescriptionParamLength
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

		// Token: 0x0600CC63 RID: 52323 RVA: 0x00302CF4 File Offset: 0x00300EF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescriptionParamIter()或GetDescriptionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600CC64 RID: 52324 RVA: 0x00302D01 File Offset: 0x00300F01
		[NullableContext(1)]
		public readonly IEnumerable<string> DescriptionParamIter()
		{
			RougePopularEntrie.<DescriptionParamIter>d__35 <DescriptionParamIter>d__ = new RougePopularEntrie.<DescriptionParamIter>d__35(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x00302D18 File Offset: 0x00300F18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RougePopularEntrie rougePopularEntrie = this;
			return rougePopularEntrie.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CC66 RID: 52326 RVA: 0x00302D3C File Offset: 0x00300F3C
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RougePopularEntrie.<InstsIter>d__37 <InstsIter>d__ = new RougePopularEntrie.<InstsIter>d__37(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x04005172 RID: 20850
		private Table __p;
	}
}
