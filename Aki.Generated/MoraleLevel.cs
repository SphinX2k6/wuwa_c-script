using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E26 RID: 3622
	public struct MoraleLevel : IFlatbufferObject
	{
		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06009625 RID: 38437 RVA: 0x00289CC1 File Offset: 0x00287EC1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x00289CCE File Offset: 0x00287ECE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x00289CD8 File Offset: 0x00287ED8
		public static MoraleLevel GetRootAsMoraleLevel(ByteBuffer _bb)
		{
			return MoraleLevel.GetRootAsMoraleLevel(_bb, default(MoraleLevel));
		}

		// Token: 0x06009628 RID: 38440 RVA: 0x00289CF4 File Offset: 0x00287EF4
		public static MoraleLevel GetRootAsMoraleLevel(ByteBuffer _bb, MoraleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009629 RID: 38441 RVA: 0x00289D11 File Offset: 0x00287F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x00289D20 File Offset: 0x00287F20
		public MoraleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x0600962B RID: 38443 RVA: 0x00289D30 File Offset: 0x00287F30
		public int Level
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

		// Token: 0x0600962C RID: 38444 RVA: 0x00289D6C File Offset: 0x00287F6C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x0600962D RID: 38445 RVA: 0x00289DAC File Offset: 0x00287FAC
		public int BuffIdsLength
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

		// Token: 0x0600962E RID: 38446 RVA: 0x00289DD7 File Offset: 0x00287FD7
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x00289DE6 File Offset: 0x00287FE6
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x00289E00 File Offset: 0x00288000
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			MoraleLevel moraleLevel = this;
			return moraleLevel.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x00289E24 File Offset: 0x00288024
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			MoraleLevel.<BuffIdsIter>d__16 <BuffIdsIter>d__ = new MoraleLevel.<BuffIdsIter>d__16(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x04004ECB RID: 20171
		private Table __p;
	}
}
