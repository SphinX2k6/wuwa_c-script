using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFF RID: 3583
	public struct MatchThreeGoal : IFlatbufferObject
	{
		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060092D8 RID: 37592 RVA: 0x002828C4 File Offset: 0x00280AC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x002828D1 File Offset: 0x00280AD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x002828D8 File Offset: 0x00280AD8
		public static MatchThreeGoal GetRootAsMatchThreeGoal(ByteBuffer _bb)
		{
			return MatchThreeGoal.GetRootAsMatchThreeGoal(_bb, default(MatchThreeGoal));
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x002828F4 File Offset: 0x00280AF4
		public static MatchThreeGoal GetRootAsMatchThreeGoal(ByteBuffer _bb, MatchThreeGoal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x00282911 File Offset: 0x00280B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x00282920 File Offset: 0x00280B20
		public MatchThreeGoal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060092DE RID: 37598 RVA: 0x00282930 File Offset: 0x00280B30
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

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060092DF RID: 37599 RVA: 0x0028296C File Offset: 0x00280B6C
		public int CondType
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

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060092E0 RID: 37600 RVA: 0x002829A8 File Offset: 0x00280BA8
		public string CondDesc
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

		// Token: 0x060092E1 RID: 37601 RVA: 0x002829DF File Offset: 0x00280BDF
		public Span<byte> GetCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060092E2 RID: 37602 RVA: 0x002829EE File Offset: 0x00280BEE
		public byte[] GetCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060092E3 RID: 37603 RVA: 0x00282A08 File Offset: 0x00280C08
		public int Params(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x060092E4 RID: 37604 RVA: 0x00282A48 File Offset: 0x00280C48
		public int ParamsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x00282A74 File Offset: 0x00280C74
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x00282A84 File Offset: 0x00280C84
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x00282A9C File Offset: 0x00280C9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			MatchThreeGoal matchThreeGoal = this;
			return matchThreeGoal.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x00282AC0 File Offset: 0x00280CC0
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			MatchThreeGoal.<ParamsIter>d__22 <ParamsIter>d__ = new MatchThreeGoal.<ParamsIter>d__22(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004EA0 RID: 20128
		private Table __p;
	}
}
