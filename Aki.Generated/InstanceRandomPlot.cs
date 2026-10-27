using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D74 RID: 3444
	public struct InstanceRandomPlot : IFlatbufferObject
	{
		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x0026447D File Offset: 0x0026267D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600859A RID: 34202 RVA: 0x0026448A File Offset: 0x0026268A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x00264494 File Offset: 0x00262694
		public static InstanceRandomPlot GetRootAsInstanceRandomPlot(ByteBuffer _bb)
		{
			return InstanceRandomPlot.GetRootAsInstanceRandomPlot(_bb, default(InstanceRandomPlot));
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x002644B0 File Offset: 0x002626B0
		public static InstanceRandomPlot GetRootAsInstanceRandomPlot(ByteBuffer _bb, InstanceRandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x002644CD File Offset: 0x002626CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x002644DC File Offset: 0x002626DC
		public InstanceRandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600859F RID: 34207 RVA: 0x002644EC File Offset: 0x002626EC
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

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x060085A0 RID: 34208 RVA: 0x00264528 File Offset: 0x00262728
		public int InstId
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

		// Token: 0x060085A1 RID: 34209 RVA: 0x00264564 File Offset: 0x00262764
		public int ActiveTriggerGroupIdList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x060085A2 RID: 34210 RVA: 0x002645A4 File Offset: 0x002627A4
		public int ActiveTriggerGroupIdListLength
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

		// Token: 0x060085A3 RID: 34211 RVA: 0x002645CF File Offset: 0x002627CF
		public Span<int> GetActiveTriggerGroupIdListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x002645DE File Offset: 0x002627DE
		public int[] GetActiveTriggerGroupIdListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x002645F8 File Offset: 0x002627F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ActiveTriggerGroupIdListIter()或GetActiveTriggerGroupIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ActiveTriggerGroupIdList()
		{
			InstanceRandomPlot instanceRandomPlot = this;
			return instanceRandomPlot.GetActiveTriggerGroupIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x0026461C File Offset: 0x0026281C
		[NullableContext(1)]
		public readonly IEnumerable<int> ActiveTriggerGroupIdListIter()
		{
			InstanceRandomPlot.<ActiveTriggerGroupIdListIter>d__18 <ActiveTriggerGroupIdListIter>d__ = new InstanceRandomPlot.<ActiveTriggerGroupIdListIter>d__18(-2);
			<ActiveTriggerGroupIdListIter>d__.<>3__<>4__this = this;
			return <ActiveTriggerGroupIdListIter>d__;
		}

		// Token: 0x04004DFC RID: 19964
		private Table __p;
	}
}
