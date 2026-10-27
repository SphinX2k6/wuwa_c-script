using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAD RID: 2989
	public struct CustomMark : IFlatbufferObject
	{
		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06005A9A RID: 23194 RVA: 0x0020257C File Offset: 0x0020077C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00202589 File Offset: 0x00200789
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00202590 File Offset: 0x00200790
		public static CustomMark GetRootAsCustomMark(ByteBuffer _bb)
		{
			return CustomMark.GetRootAsCustomMark(_bb, default(CustomMark));
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x002025AC File Offset: 0x002007AC
		public static CustomMark GetRootAsCustomMark(ByteBuffer _bb, CustomMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A9E RID: 23198 RVA: 0x002025C9 File Offset: 0x002007C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x002025D8 File Offset: 0x002007D8
		public CustomMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x002025E8 File Offset: 0x002007E8
		public int MarkId
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06005AA1 RID: 23201 RVA: 0x00202624 File Offset: 0x00200824
		public string MarkPic
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

		// Token: 0x06005AA2 RID: 23202 RVA: 0x0020265B File Offset: 0x0020085B
		public Span<byte> GetMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x0020266A File Offset: 0x0020086A
		public byte[] GetMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00202684 File Offset: 0x00200884
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x002026C4 File Offset: 0x002008C4
		public int ShowRangeLength
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

		// Token: 0x06005AA6 RID: 23206 RVA: 0x002026EF File Offset: 0x002008EF
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x002026FE File Offset: 0x002008FE
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x00202718 File Offset: 0x00200918
		public int ShowPriority
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

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x00202758 File Offset: 0x00200958
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0020279C File Offset: 0x0020099C
		public int TrackHudEnable
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x002027DC File Offset: 0x002009DC
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return -1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00202820 File Offset: 0x00200A20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			CustomMark customMark = this;
			return customMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00202844 File Offset: 0x00200A44
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			CustomMark.<ShowRangeIter>d__28 <ShowRangeIter>d__ = new CustomMark.<ShowRangeIter>d__28(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04004BD0 RID: 19408
		private Table __p;
	}
}
