using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFA RID: 3578
	public struct MatchThreeComponent : IFlatbufferObject
	{
		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06009265 RID: 37477 RVA: 0x00281858 File Offset: 0x0027FA58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x00281865 File Offset: 0x0027FA65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x0028186C File Offset: 0x0027FA6C
		public static MatchThreeComponent GetRootAsMatchThreeComponent(ByteBuffer _bb)
		{
			return MatchThreeComponent.GetRootAsMatchThreeComponent(_bb, default(MatchThreeComponent));
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x00281888 File Offset: 0x0027FA88
		public static MatchThreeComponent GetRootAsMatchThreeComponent(ByteBuffer _bb, MatchThreeComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x002818A5 File Offset: 0x0027FAA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x002818B4 File Offset: 0x0027FAB4
		public MatchThreeComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600926B RID: 37483 RVA: 0x002818C4 File Offset: 0x0027FAC4
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

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600926C RID: 37484 RVA: 0x00281900 File Offset: 0x0027FB00
		public int Type
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

		// Token: 0x0600926D RID: 37485 RVA: 0x0028193C File Offset: 0x0027FB3C
		public int Params(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600926E RID: 37486 RVA: 0x0028197C File Offset: 0x0027FB7C
		public int ParamsLength
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

		// Token: 0x0600926F RID: 37487 RVA: 0x002819A7 File Offset: 0x0027FBA7
		public Span<int> GetParamsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x002819B6 File Offset: 0x0027FBB6
		public int[] GetParamsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009271 RID: 37489 RVA: 0x002819D0 File Offset: 0x0027FBD0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParamsIter()或GetParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Params()
		{
			MatchThreeComponent matchThreeComponent = this;
			return matchThreeComponent.GetParamsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009272 RID: 37490 RVA: 0x002819F4 File Offset: 0x0027FBF4
		[NullableContext(1)]
		public readonly IEnumerable<int> ParamsIter()
		{
			MatchThreeComponent.<ParamsIter>d__18 <ParamsIter>d__ = new MatchThreeComponent.<ParamsIter>d__18(-2);
			<ParamsIter>d__.<>3__<>4__this = this;
			return <ParamsIter>d__;
		}

		// Token: 0x04004E9A RID: 20122
		private Table __p;
	}
}
