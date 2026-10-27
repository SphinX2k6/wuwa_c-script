using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D10 RID: 3344
	public struct GuessJokerAIPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06007BF5 RID: 31733 RVA: 0x0024E654 File Offset: 0x0024C854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x0024E661 File Offset: 0x0024C861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x0024E668 File Offset: 0x0024C868
		public static GuessJokerAIPlotConfig GetRootAsGuessJokerAIPlotConfig(ByteBuffer _bb)
		{
			return GuessJokerAIPlotConfig.GetRootAsGuessJokerAIPlotConfig(_bb, default(GuessJokerAIPlotConfig));
		}

		// Token: 0x06007BF8 RID: 31736 RVA: 0x0024E684 File Offset: 0x0024C884
		public static GuessJokerAIPlotConfig GetRootAsGuessJokerAIPlotConfig(ByteBuffer _bb, GuessJokerAIPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BF9 RID: 31737 RVA: 0x0024E6A1 File Offset: 0x0024C8A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BFA RID: 31738 RVA: 0x0024E6B0 File Offset: 0x0024C8B0
		public GuessJokerAIPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x0024E6C0 File Offset: 0x0024C8C0
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

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x0024E6FC File Offset: 0x0024C8FC
		public int RoleId
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

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x0024E738 File Offset: 0x0024C938
		public int State
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

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x0024E774 File Offset: 0x0024C974
		public int ExtraParam
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

		// Token: 0x06007BFF RID: 31743 RVA: 0x0024E7B4 File Offset: 0x0024C9B4
		public int PlotIdList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06007C00 RID: 31744 RVA: 0x0024E7F4 File Offset: 0x0024C9F4
		public int PlotIdListLength
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

		// Token: 0x06007C01 RID: 31745 RVA: 0x0024E820 File Offset: 0x0024CA20
		public Span<int> GetPlotIdListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x0024E830 File Offset: 0x0024CA30
		public int[] GetPlotIdListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06007C03 RID: 31747 RVA: 0x0024E848 File Offset: 0x0024CA48
		public int DelayTime
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x0024E888 File Offset: 0x0024CA88
		public int WaitDeleteTime
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06007C05 RID: 31749 RVA: 0x0024E8C8 File Offset: 0x0024CAC8
		public bool CanHardCut
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06007C06 RID: 31750 RVA: 0x0024E908 File Offset: 0x0024CB08
		public int Cd
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C07 RID: 31751 RVA: 0x0024E948 File Offset: 0x0024CB48
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlotIdListIter()或GetPlotIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlotIdList()
		{
			GuessJokerAIPlotConfig guessJokerAIPlotConfig = this;
			return guessJokerAIPlotConfig.GetPlotIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x0024E96C File Offset: 0x0024CB6C
		[NullableContext(1)]
		public readonly IEnumerable<int> PlotIdListIter()
		{
			GuessJokerAIPlotConfig.<PlotIdListIter>d__30 <PlotIdListIter>d__ = new GuessJokerAIPlotConfig.<PlotIdListIter>d__30(-2);
			<PlotIdListIter>d__.<>3__<>4__this = this;
			return <PlotIdListIter>d__;
		}

		// Token: 0x04004D86 RID: 19846
		private Table __p;
	}
}
