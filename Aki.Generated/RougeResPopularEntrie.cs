using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106F RID: 4207
	public struct RougeResPopularEntrie : IFlatbufferObject
	{
		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600CC81 RID: 52353 RVA: 0x003030D4 File Offset: 0x003012D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x003030E1 File Offset: 0x003012E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x003030E8 File Offset: 0x003012E8
		public static RougeResPopularEntrie GetRootAsRougeResPopularEntrie(ByteBuffer _bb)
		{
			return RougeResPopularEntrie.GetRootAsRougeResPopularEntrie(_bb, default(RougeResPopularEntrie));
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x00303104 File Offset: 0x00301304
		public static RougeResPopularEntrie GetRootAsRougeResPopularEntrie(ByteBuffer _bb, RougeResPopularEntrie obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00303121 File Offset: 0x00301321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x00303130 File Offset: 0x00301330
		public RougeResPopularEntrie __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600CC87 RID: 52359 RVA: 0x00303140 File Offset: 0x00301340
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

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600CC88 RID: 52360 RVA: 0x0030317C File Offset: 0x0030137C
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

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600CC89 RID: 52361 RVA: 0x003031B8 File Offset: 0x003013B8
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

		// Token: 0x0600CC8A RID: 52362 RVA: 0x003031F4 File Offset: 0x003013F4
		public int Insts(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600CC8B RID: 52363 RVA: 0x00303234 File Offset: 0x00301434
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

		// Token: 0x0600CC8C RID: 52364 RVA: 0x00303260 File Offset: 0x00301460
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x00303270 File Offset: 0x00301470
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600CC8E RID: 52366 RVA: 0x00303288 File Offset: 0x00301488
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

		// Token: 0x0600CC8F RID: 52367 RVA: 0x003032C0 File Offset: 0x003014C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x003032D0 File Offset: 0x003014D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600CC91 RID: 52369 RVA: 0x003032E8 File Offset: 0x003014E8
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

		// Token: 0x0600CC92 RID: 52370 RVA: 0x00303320 File Offset: 0x00301520
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00303330 File Offset: 0x00301530
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600CC94 RID: 52372 RVA: 0x00303348 File Offset: 0x00301548
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

		// Token: 0x0600CC95 RID: 52373 RVA: 0x00303380 File Offset: 0x00301580
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00303390 File Offset: 0x00301590
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x003033A8 File Offset: 0x003015A8
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600CC98 RID: 52376 RVA: 0x003033E4 File Offset: 0x003015E4
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

		// Token: 0x0600CC99 RID: 52377 RVA: 0x00303410 File Offset: 0x00301610
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescriptionParamIter()或GetDescriptionParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x0600CC9A RID: 52378 RVA: 0x0030341D File Offset: 0x0030161D
		[NullableContext(1)]
		public readonly IEnumerable<string> DescriptionParamIter()
		{
			RougeResPopularEntrie.<DescriptionParamIter>d__35 <DescriptionParamIter>d__ = new RougeResPopularEntrie.<DescriptionParamIter>d__35(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x0600CC9B RID: 52379 RVA: 0x00303434 File Offset: 0x00301634
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RougeResPopularEntrie rougeResPopularEntrie = this;
			return rougeResPopularEntrie.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CC9C RID: 52380 RVA: 0x00303458 File Offset: 0x00301658
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RougeResPopularEntrie.<InstsIter>d__37 <InstsIter>d__ = new RougeResPopularEntrie.<InstsIter>d__37(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x04005174 RID: 20852
		private Table __p;
	}
}
