using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118A RID: 4490
	public struct UniversalActivity : IFlatbufferObject
	{
		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600E6E2 RID: 59106 RVA: 0x003401B9 File Offset: 0x0033E3B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x003401C6 File Offset: 0x0033E3C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6E4 RID: 59108 RVA: 0x003401D0 File Offset: 0x0033E3D0
		public static UniversalActivity GetRootAsUniversalActivity(ByteBuffer _bb)
		{
			return UniversalActivity.GetRootAsUniversalActivity(_bb, default(UniversalActivity));
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x003401EC File Offset: 0x0033E3EC
		public static UniversalActivity GetRootAsUniversalActivity(ByteBuffer _bb, UniversalActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x00340209 File Offset: 0x0033E409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x00340218 File Offset: 0x0033E418
		public UniversalActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600E6E8 RID: 59112 RVA: 0x00340228 File Offset: 0x0033E428
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

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x00340264 File Offset: 0x0033E464
		public string UiResource
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

		// Token: 0x0600E6EA RID: 59114 RVA: 0x0034029B File Offset: 0x0033E49B
		public Span<byte> GetUiResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x003402AA File Offset: 0x0033E4AA
		public byte[] GetUiResourceArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600E6EC RID: 59116 RVA: 0x003402C4 File Offset: 0x0033E4C4
		public int FunctionType
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

		// Token: 0x0600E6ED RID: 59117 RVA: 0x00340300 File Offset: 0x0033E500
		public string FunctionParams(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600E6EE RID: 59118 RVA: 0x0034033C File Offset: 0x0033E53C
		public int FunctionParamsLength
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

		// Token: 0x0600E6EF RID: 59119 RVA: 0x00340368 File Offset: 0x0033E568
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FunctionParamsIter()或GetFunctionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FunctionParams()
		{
			return this.FunctionParamsIter().ToArray<string>();
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00340375 File Offset: 0x0033E575
		[NullableContext(1)]
		public readonly IEnumerable<string> FunctionParamsIter()
		{
			UniversalActivity.<FunctionParamsIter>d__20 <FunctionParamsIter>d__ = new UniversalActivity.<FunctionParamsIter>d__20(-2);
			<FunctionParamsIter>d__.<>3__<>4__this = this;
			return <FunctionParamsIter>d__;
		}

		// Token: 0x040052D3 RID: 21203
		private Table __p;
	}
}
