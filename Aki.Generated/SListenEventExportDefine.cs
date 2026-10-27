using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E2 RID: 4578
	public struct SListenEventExportDefine : IFlatbufferObject
	{
		// Token: 0x17003F30 RID: 16176
		// (get) Token: 0x0600EB81 RID: 60289 RVA: 0x0034A63C File Offset: 0x0034883C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x0034A649 File Offset: 0x00348849
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB83 RID: 60291 RVA: 0x0034A650 File Offset: 0x00348850
		public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb)
		{
			return SListenEventExportDefine.GetRootAsSListenEventExportDefine(_bb, default(SListenEventExportDefine));
		}

		// Token: 0x0600EB84 RID: 60292 RVA: 0x0034A66C File Offset: 0x0034886C
		public static SListenEventExportDefine GetRootAsSListenEventExportDefine(ByteBuffer _bb, SListenEventExportDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x0034A689 File Offset: 0x00348889
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x0034A698 File Offset: 0x00348898
		public SListenEventExportDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x0034A6A8 File Offset: 0x003488A8
		public int ListenConfigIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x0600EB88 RID: 60296 RVA: 0x0034A6E8 File Offset: 0x003488E8
		public int ListenConfigIdsLength
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

		// Token: 0x0600EB89 RID: 60297 RVA: 0x0034A713 File Offset: 0x00348913
		public Span<int> GetListenConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x0034A722 File Offset: 0x00348922
		public int[] GetListenConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(4) ?? Array.Empty<int>();
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x0600EB8B RID: 60299 RVA: 0x0034A73C File Offset: 0x0034893C
		public float ListenRange
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x0034A77C File Offset: 0x0034897C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ListenConfigIdsIter()或GetListenConfigIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ListenConfigIds()
		{
			SListenEventExportDefine slistenEventExportDefine = this;
			return slistenEventExportDefine.GetListenConfigIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x0034A7A0 File Offset: 0x003489A0
		[NullableContext(1)]
		public readonly IEnumerable<int> ListenConfigIdsIter()
		{
			SListenEventExportDefine.<ListenConfigIdsIter>d__16 <ListenConfigIdsIter>d__ = new SListenEventExportDefine.<ListenConfigIdsIter>d__16(-2);
			<ListenConfigIdsIter>d__.<>3__<>4__this = this;
			return <ListenConfigIdsIter>d__;
		}

		// Token: 0x0400535B RID: 21339
		private Table __p;
	}
}
