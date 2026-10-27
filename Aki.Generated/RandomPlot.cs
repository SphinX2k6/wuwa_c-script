using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F95 RID: 3989
	public struct RandomPlot : IFlatbufferObject
	{
		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600B901 RID: 47361 RVA: 0x002D7531 File Offset: 0x002D5731
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B902 RID: 47362 RVA: 0x002D753E File Offset: 0x002D573E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B903 RID: 47363 RVA: 0x002D7548 File Offset: 0x002D5748
		public static RandomPlot GetRootAsRandomPlot(ByteBuffer _bb)
		{
			return RandomPlot.GetRootAsRandomPlot(_bb, default(RandomPlot));
		}

		// Token: 0x0600B904 RID: 47364 RVA: 0x002D7564 File Offset: 0x002D5764
		public static RandomPlot GetRootAsRandomPlot(ByteBuffer _bb, RandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B905 RID: 47365 RVA: 0x002D7581 File Offset: 0x002D5781
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002D7590 File Offset: 0x002D5790
		public RandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0600B907 RID: 47367 RVA: 0x002D75A0 File Offset: 0x002D57A0
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

		// Token: 0x17002CFA RID: 11514
		// (get) Token: 0x0600B908 RID: 47368 RVA: 0x002D75DC File Offset: 0x002D57DC
		public int Probability
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CFB RID: 11515
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x002D761C File Offset: 0x002D581C
		public int Cooldown
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

		// Token: 0x0600B90A RID: 47370 RVA: 0x002D7658 File Offset: 0x002D5858
		public int ClientPlotReferenceList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x002D7698 File Offset: 0x002D5898
		public int ClientPlotReferenceListLength
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

		// Token: 0x0600B90C RID: 47372 RVA: 0x002D76C4 File Offset: 0x002D58C4
		public Span<int> GetClientPlotReferenceListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B90D RID: 47373 RVA: 0x002D76D4 File Offset: 0x002D58D4
		public int[] GetClientPlotReferenceListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600B90E RID: 47374 RVA: 0x002D76EC File Offset: 0x002D58EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ClientPlotReferenceListIter()或GetClientPlotReferenceListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ClientPlotReferenceList()
		{
			RandomPlot randomPlot = this;
			return randomPlot.GetClientPlotReferenceListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B90F RID: 47375 RVA: 0x002D7710 File Offset: 0x002D5910
		[NullableContext(1)]
		public readonly IEnumerable<int> ClientPlotReferenceListIter()
		{
			RandomPlot.<ClientPlotReferenceListIter>d__20 <ClientPlotReferenceListIter>d__ = new RandomPlot.<ClientPlotReferenceListIter>d__20(-2);
			<ClientPlotReferenceListIter>d__.<>3__<>4__this = this;
			return <ClientPlotReferenceListIter>d__;
		}

		// Token: 0x04005065 RID: 20581
		private Table __p;
	}
}
