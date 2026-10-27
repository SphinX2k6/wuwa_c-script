using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F84 RID: 3972
	public struct RacingBetDynamicOdds : IFlatbufferObject
	{
		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x0600B7C0 RID: 47040 RVA: 0x002D4805 File Offset: 0x002D2A05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x002D4812 File Offset: 0x002D2A12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x002D481C File Offset: 0x002D2A1C
		public static RacingBetDynamicOdds GetRootAsRacingBetDynamicOdds(ByteBuffer _bb)
		{
			return RacingBetDynamicOdds.GetRootAsRacingBetDynamicOdds(_bb, default(RacingBetDynamicOdds));
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x002D4838 File Offset: 0x002D2A38
		public static RacingBetDynamicOdds GetRootAsRacingBetDynamicOdds(ByteBuffer _bb, RacingBetDynamicOdds obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x002D4855 File Offset: 0x002D2A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x002D4864 File Offset: 0x002D2A64
		public RacingBetDynamicOdds __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x0600B7C6 RID: 47046 RVA: 0x002D4874 File Offset: 0x002D2A74
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

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x0600B7C7 RID: 47047 RVA: 0x002D48B0 File Offset: 0x002D2AB0
		public int LegId
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

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x002D48EC File Offset: 0x002D2AEC
		public int Proportion(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x002D492C File Offset: 0x002D2B2C
		public int ProportionLength
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

		// Token: 0x0600B7CA RID: 47050 RVA: 0x002D4957 File Offset: 0x002D2B57
		public Span<int> GetProportionBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x002D4966 File Offset: 0x002D2B66
		public int[] GetProportionArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x0600B7CC RID: 47052 RVA: 0x002D4980 File Offset: 0x002D2B80
		public int DynamicOdds
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

		// Token: 0x0600B7CD RID: 47053 RVA: 0x002D49C0 File Offset: 0x002D2BC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ProportionIter()或GetProportionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Proportion()
		{
			RacingBetDynamicOdds racingBetDynamicOdds = this;
			return racingBetDynamicOdds.GetProportionArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x002D49E4 File Offset: 0x002D2BE4
		[NullableContext(1)]
		public readonly IEnumerable<int> ProportionIter()
		{
			RacingBetDynamicOdds.<ProportionIter>d__20 <ProportionIter>d__ = new RacingBetDynamicOdds.<ProportionIter>d__20(-2);
			<ProportionIter>d__.<>3__<>4__this = this;
			return <ProportionIter>d__;
		}

		// Token: 0x04005052 RID: 20562
		private Table __p;
	}
}
