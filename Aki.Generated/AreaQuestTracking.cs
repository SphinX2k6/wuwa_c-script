using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B06 RID: 2822
	public struct AreaQuestTracking : IFlatbufferObject
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x001D8135 File Offset: 0x001D6335
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x001D8142 File Offset: 0x001D6342
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x001D814C File Offset: 0x001D634C
		public static AreaQuestTracking GetRootAsAreaQuestTracking(ByteBuffer _bb)
		{
			return AreaQuestTracking.GetRootAsAreaQuestTracking(_bb, default(AreaQuestTracking));
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x001D8168 File Offset: 0x001D6368
		public static AreaQuestTracking GetRootAsAreaQuestTracking(ByteBuffer _bb, AreaQuestTracking obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x001D8185 File Offset: 0x001D6385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x001D8194 File Offset: 0x001D6394
		public AreaQuestTracking __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x001D81A4 File Offset: 0x001D63A4
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x001D81DB File Offset: 0x001D63DB
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x001D81EA File Offset: 0x001D63EA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x001D8204 File Offset: 0x001D6404
		public int AreaList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x001D8244 File Offset: 0x001D6444
		public int AreaListLength
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

		// Token: 0x060048C1 RID: 18625 RVA: 0x001D826F File Offset: 0x001D646F
		public Span<int> GetAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x001D827E File Offset: 0x001D647E
		public int[] GetAreaListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x001D8298 File Offset: 0x001D6498
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaListIter()或GetAreaListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaList()
		{
			AreaQuestTracking areaQuestTracking = this;
			return areaQuestTracking.GetAreaListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x001D82BC File Offset: 0x001D64BC
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaListIter()
		{
			AreaQuestTracking.<AreaListIter>d__18 <AreaListIter>d__ = new AreaQuestTracking.<AreaListIter>d__18(-2);
			<AreaListIter>d__.<>3__<>4__this = this;
			return <AreaListIter>d__;
		}

		// Token: 0x04004AEB RID: 19179
		private Table __p;
	}
}
