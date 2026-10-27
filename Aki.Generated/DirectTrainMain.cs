using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF3 RID: 3059
	public struct DirectTrainMain : IFlatbufferObject
	{
		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x00214061 File Offset: 0x00212261
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x0021406E File Offset: 0x0021226E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00214078 File Offset: 0x00212278
		public static DirectTrainMain GetRootAsDirectTrainMain(ByteBuffer _bb)
		{
			return DirectTrainMain.GetRootAsDirectTrainMain(_bb, default(DirectTrainMain));
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x00214094 File Offset: 0x00212294
		public static DirectTrainMain GetRootAsDirectTrainMain(ByteBuffer _bb, DirectTrainMain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x002140B1 File Offset: 0x002122B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x002140C0 File Offset: 0x002122C0
		public DirectTrainMain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x002140D0 File Offset: 0x002122D0
		public int ActivityId
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

		// Token: 0x0600628A RID: 25226 RVA: 0x0021410C File Offset: 0x0021230C
		public int SubActivityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x0021414C File Offset: 0x0021234C
		public int SubActivityIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00214177 File Offset: 0x00212377
		public Span<int> GetSubActivityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00214186 File Offset: 0x00212386
		public int[] GetSubActivityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600628E RID: 25230 RVA: 0x002141A0 File Offset: 0x002123A0
		public string BottomTipText
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

		// Token: 0x0600628F RID: 25231 RVA: 0x002141D7 File Offset: 0x002123D7
		public Span<byte> GetBottomTipTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x002141E6 File Offset: 0x002123E6
		public byte[] GetBottomTipTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00214200 File Offset: 0x00212400
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubActivityIdsIter()或GetSubActivityIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubActivityIds()
		{
			DirectTrainMain directTrainMain = this;
			return directTrainMain.GetSubActivityIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00214224 File Offset: 0x00212424
		[NullableContext(1)]
		public readonly IEnumerable<int> SubActivityIdsIter()
		{
			DirectTrainMain.<SubActivityIdsIter>d__20 <SubActivityIdsIter>d__ = new DirectTrainMain.<SubActivityIdsIter>d__20(-2);
			<SubActivityIdsIter>d__.<>3__<>4__this = this;
			return <SubActivityIdsIter>d__;
		}

		// Token: 0x04004C20 RID: 19488
		private Table __p;
	}
}
