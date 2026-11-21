using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF5 RID: 3573
	public struct GuessJokerAIPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x0600820D RID: 33293 RVA: 0x0026D094 File Offset: 0x0026B294
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x0026D0A1 File Offset: 0x0026B2A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0026D0A8 File Offset: 0x0026B2A8
		public static GuessJokerAIPlotConfig GetRootAsGuessJokerAIPlotConfig(ByteBuffer _bb)
		{
			return GuessJokerAIPlotConfig.GetRootAsGuessJokerAIPlotConfig(_bb, default(GuessJokerAIPlotConfig));
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x0026D0C4 File Offset: 0x0026B2C4
		public static GuessJokerAIPlotConfig GetRootAsGuessJokerAIPlotConfig(ByteBuffer _bb, GuessJokerAIPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x0026D0E1 File Offset: 0x0026B2E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x0026D0F0 File Offset: 0x0026B2F0
		public GuessJokerAIPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06008213 RID: 33299 RVA: 0x0026D100 File Offset: 0x0026B300
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06008214 RID: 33300 RVA: 0x0026D13C File Offset: 0x0026B33C
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

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x0026D178 File Offset: 0x0026B378
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

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06008216 RID: 33302 RVA: 0x0026D1B4 File Offset: 0x0026B3B4
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

		// Token: 0x06008217 RID: 33303 RVA: 0x0026D1F4 File Offset: 0x0026B3F4
		public int PlotIdList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06008218 RID: 33304 RVA: 0x0026D234 File Offset: 0x0026B434
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

		// Token: 0x06008219 RID: 33305 RVA: 0x0026D260 File Offset: 0x0026B460
		public Span<int> GetPlotIdListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x0026D270 File Offset: 0x0026B470
		public int[] GetPlotIdListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x0600821B RID: 33307 RVA: 0x0026D288 File Offset: 0x0026B488
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

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x0600821C RID: 33308 RVA: 0x0026D2C8 File Offset: 0x0026B4C8
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

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x0600821D RID: 33309 RVA: 0x0026D308 File Offset: 0x0026B508
		public bool CanHardCut
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x0600821E RID: 33310 RVA: 0x0026D348 File Offset: 0x0026B548
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

		// Token: 0x0600821F RID: 33311 RVA: 0x0026D385 File Offset: 0x0026B585
		[NullableContext(1)]
		public int[] PlotIdList()
		{
			return this.GetPlotIdListArray();
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x0026D38D File Offset: 0x0026B58D
		[NullableContext(1)]
		public IEnumerable<int> PlotIdListIter()
		{
			GuessJokerAIPlotConfig.<PlotIdListIter>d__30 <PlotIdListIter>d__ = new GuessJokerAIPlotConfig.<PlotIdListIter>d__30(-2);
			<PlotIdListIter>d__.<>3__<>4__this = this;
			return <PlotIdListIter>d__;
		}

		// Token: 0x0400536B RID: 21355
		private Table __p;
	}
}
