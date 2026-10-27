using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DF RID: 4575
	public struct SCreatureGenNavAssistFileExportDefine : IFlatbufferObject
	{
		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0600EB63 RID: 60259 RVA: 0x0034A30D File Offset: 0x0034850D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x0034A31A File Offset: 0x0034851A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x0034A324 File Offset: 0x00348524
		public static SCreatureGenNavAssistFileExportDefine GetRootAsSCreatureGenNavAssistFileExportDefine(ByteBuffer _bb)
		{
			return SCreatureGenNavAssistFileExportDefine.GetRootAsSCreatureGenNavAssistFileExportDefine(_bb, default(SCreatureGenNavAssistFileExportDefine));
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x0034A340 File Offset: 0x00348540
		public static SCreatureGenNavAssistFileExportDefine GetRootAsSCreatureGenNavAssistFileExportDefine(ByteBuffer _bb, SCreatureGenNavAssistFileExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB67 RID: 60263 RVA: 0x0034A35D File Offset: 0x0034855D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x0034A36C File Offset: 0x0034856C
		public SCreatureGenNavAssistFileExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB69 RID: 60265 RVA: 0x0034A37C File Offset: 0x0034857C
		public SCreatureGenNavAssistAreaExportDefine? Areas(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new SCreatureGenNavAssistAreaExportDefine?(default(SCreatureGenNavAssistAreaExportDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x0600EB6A RID: 60266 RVA: 0x0034A3DC File Offset: 0x003485DC
		public int AreasLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB6B RID: 60267 RVA: 0x0034A407 File Offset: 0x00348607
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreasIter()或GetAreasBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly SCreatureGenNavAssistAreaExportDefine[] Areas()
		{
			return this.AreasIter().ToArray<SCreatureGenNavAssistAreaExportDefine>();
		}

		// Token: 0x0600EB6C RID: 60268 RVA: 0x0034A414 File Offset: 0x00348614
		[NullableContext(1)]
		public readonly IEnumerable<SCreatureGenNavAssistAreaExportDefine> AreasIter()
		{
			SCreatureGenNavAssistFileExportDefine.<AreasIter>d__12 <AreasIter>d__ = new SCreatureGenNavAssistFileExportDefine.<AreasIter>d__12(-2);
			<AreasIter>d__.<>3__<>4__this = this;
			return <AreasIter>d__;
		}

		// Token: 0x04005358 RID: 21336
		private Table __p;
	}
}
