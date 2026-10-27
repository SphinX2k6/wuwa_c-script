using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B55 RID: 2901
	public struct BuffGroup : IFlatbufferObject
	{
		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600510A RID: 20746 RVA: 0x001EC141 File Offset: 0x001EA341
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x001EC14E File Offset: 0x001EA34E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x001EC158 File Offset: 0x001EA358
		public static BuffGroup GetRootAsBuffGroup(ByteBuffer _bb)
		{
			return BuffGroup.GetRootAsBuffGroup(_bb, default(BuffGroup));
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x001EC174 File Offset: 0x001EA374
		public static BuffGroup GetRootAsBuffGroup(ByteBuffer _bb, BuffGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x001EC191 File Offset: 0x001EA391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x001EC1A0 File Offset: 0x001EA3A0
		public BuffGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x001EC1B0 File Offset: 0x001EA3B0
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

		// Token: 0x06005111 RID: 20753 RVA: 0x001EC1EC File Offset: 0x001EA3EC
		public long Buffs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x001EC22C File Offset: 0x001EA42C
		public int BuffsLength
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

		// Token: 0x06005113 RID: 20755 RVA: 0x001EC257 File Offset: 0x001EA457
		public Span<long> GetBuffsBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x001EC266 File Offset: 0x001EA466
		public long[] GetBuffsArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x001EC280 File Offset: 0x001EA480
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffsIter()或GetBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Buffs()
		{
			BuffGroup buffGroup = this;
			return buffGroup.GetBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x001EC2A4 File Offset: 0x001EA4A4
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffsIter()
		{
			BuffGroup.<BuffsIter>d__16 <BuffsIter>d__ = new BuffGroup.<BuffsIter>d__16(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04004B52 RID: 19282
		private Table __p;
	}
}
