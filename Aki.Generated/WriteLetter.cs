using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A8 RID: 4520
	public struct WriteLetter : IFlatbufferObject
	{
		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600E959 RID: 59737 RVA: 0x00345F45 File Offset: 0x00344145
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00345F52 File Offset: 0x00344152
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00345F5C File Offset: 0x0034415C
		public static WriteLetter GetRootAsWriteLetter(ByteBuffer _bb)
		{
			return WriteLetter.GetRootAsWriteLetter(_bb, default(WriteLetter));
		}

		// Token: 0x0600E95C RID: 59740 RVA: 0x00345F78 File Offset: 0x00344178
		public static WriteLetter GetRootAsWriteLetter(ByteBuffer _bb, WriteLetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E95D RID: 59741 RVA: 0x00345F95 File Offset: 0x00344195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E95E RID: 59742 RVA: 0x00345FA4 File Offset: 0x003441A4
		public WriteLetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600E95F RID: 59743 RVA: 0x00345FB4 File Offset: 0x003441B4
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

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600E960 RID: 59744 RVA: 0x00345FF0 File Offset: 0x003441F0
		public string Style
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

		// Token: 0x0600E961 RID: 59745 RVA: 0x00346027 File Offset: 0x00344227
		public Span<byte> GetStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E962 RID: 59746 RVA: 0x00346036 File Offset: 0x00344236
		public byte[] GetStyleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E963 RID: 59747 RVA: 0x00346050 File Offset: 0x00344250
		public string Flow(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600E964 RID: 59748 RVA: 0x0034608C File Offset: 0x0034428C
		public int FlowLength
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

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0600E965 RID: 59749 RVA: 0x003460B8 File Offset: 0x003442B8
		public string Title
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E966 RID: 59750 RVA: 0x003460F0 File Offset: 0x003442F0
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E967 RID: 59751 RVA: 0x00346100 File Offset: 0x00344300
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E968 RID: 59752 RVA: 0x00346118 File Offset: 0x00344318
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FlowIter()或GetFlowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Flow()
		{
			return this.FlowIter().ToArray<string>();
		}

		// Token: 0x0600E969 RID: 59753 RVA: 0x00346125 File Offset: 0x00344325
		[NullableContext(1)]
		public readonly IEnumerable<string> FlowIter()
		{
			WriteLetter.<FlowIter>d__22 <FlowIter>d__ = new WriteLetter.<FlowIter>d__22(-2);
			<FlowIter>d__.<>3__<>4__this = this;
			return <FlowIter>d__;
		}

		// Token: 0x040052F5 RID: 21237
		private Table __p;
	}
}
