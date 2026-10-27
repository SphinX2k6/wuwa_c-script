using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B56 RID: 2902
	public struct BuffItem : IFlatbufferObject
	{
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x001EC2B9 File Offset: 0x001EA4B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x001EC2C6 File Offset: 0x001EA4C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x001EC2D0 File Offset: 0x001EA4D0
		public static BuffItem GetRootAsBuffItem(ByteBuffer _bb)
		{
			return BuffItem.GetRootAsBuffItem(_bb, default(BuffItem));
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x001EC2EC File Offset: 0x001EA4EC
		public static BuffItem GetRootAsBuffItem(ByteBuffer _bb, BuffItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x001EC309 File Offset: 0x001EA509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x001EC318 File Offset: 0x001EA518
		public BuffItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600511D RID: 20765 RVA: 0x001EC328 File Offset: 0x001EA528
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x001EC364 File Offset: 0x001EA564
		public int PublicCdGroup
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

		// Token: 0x0600511F RID: 20767 RVA: 0x001EC3A0 File Offset: 0x001EA5A0
		public long Buffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06005120 RID: 20768 RVA: 0x001EC3EC File Offset: 0x001EA5EC
		public int BuffsLength
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

		// Token: 0x06005121 RID: 20769 RVA: 0x001EC417 File Offset: 0x001EA617
		public Span<long> GetBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x001EC42B File Offset: 0x001EA62B
		public long[] GetBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x001EC468 File Offset: 0x001EA668
		public int Cd
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06005124 RID: 20772 RVA: 0x001EC4A8 File Offset: 0x001EA6A8
		public bool Share
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x001EC4E8 File Offset: 0x001EA6E8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffsIter()或GetBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Buffs()
		{
			BuffItem buffItem = this;
			return buffItem.GetBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x001EC50C File Offset: 0x001EA70C
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffsIter()
		{
			BuffItem.<BuffsIter>d__22 <BuffsIter>d__ = new BuffItem.<BuffsIter>d__22(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04004B53 RID: 19283
		private Table __p;
	}
}
