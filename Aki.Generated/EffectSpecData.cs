using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C23 RID: 3107
	public struct EffectSpecData : IFlatbufferObject
	{
		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x002203D5 File Offset: 0x0021E5D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067AD RID: 26541 RVA: 0x002203E2 File Offset: 0x0021E5E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x002203EC File Offset: 0x0021E5EC
		public static EffectSpecData GetRootAsEffectSpecData(ByteBuffer _bb)
		{
			return EffectSpecData.GetRootAsEffectSpecData(_bb, default(EffectSpecData));
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00220408 File Offset: 0x0021E608
		public static EffectSpecData GetRootAsEffectSpecData(ByteBuffer _bb, EffectSpecData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00220425 File Offset: 0x0021E625
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067B1 RID: 26545 RVA: 0x00220434 File Offset: 0x0021E634
		public EffectSpecData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x060067B2 RID: 26546 RVA: 0x00220444 File Offset: 0x0021E644
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

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x00220480 File Offset: 0x0021E680
		public int SpecType
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x060067B4 RID: 26548 RVA: 0x002204BC File Offset: 0x0021E6BC
		public int EffectRegularType
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

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x060067B5 RID: 26549 RVA: 0x002204F8 File Offset: 0x0021E6F8
		public int LifeTime
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

		// Token: 0x060067B6 RID: 26550 RVA: 0x00220538 File Offset: 0x0021E738
		public int Children(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x060067B7 RID: 26551 RVA: 0x00220578 File Offset: 0x0021E778
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x002205A4 File Offset: 0x0021E7A4
		public Span<int> GetChildrenBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x002205B4 File Offset: 0x0021E7B4
		public int[] GetChildrenArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x002205CC File Offset: 0x0021E7CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChildrenIter()或GetChildrenBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Children()
		{
			EffectSpecData effectSpecData = this;
			return effectSpecData.GetChildrenArray() ?? Array.Empty<int>();
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x002205F0 File Offset: 0x0021E7F0
		[NullableContext(1)]
		public readonly IEnumerable<int> ChildrenIter()
		{
			EffectSpecData.<ChildrenIter>d__22 <ChildrenIter>d__ = new EffectSpecData.<ChildrenIter>d__22(-2);
			<ChildrenIter>d__.<>3__<>4__this = this;
			return <ChildrenIter>d__;
		}

		// Token: 0x04004C63 RID: 19555
		private Table __p;
	}
}
