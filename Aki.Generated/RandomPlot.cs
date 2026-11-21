using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200107C RID: 4220
	public struct RandomPlot : IFlatbufferObject
	{
		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x0600BF3E RID: 48958 RVA: 0x002F3D65 File Offset: 0x002F1F65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x002F3D72 File Offset: 0x002F1F72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x002F3D7C File Offset: 0x002F1F7C
		public static RandomPlot GetRootAsRandomPlot(ByteBuffer _bb)
		{
			return RandomPlot.GetRootAsRandomPlot(_bb, default(RandomPlot));
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x002F3D98 File Offset: 0x002F1F98
		public static RandomPlot GetRootAsRandomPlot(ByteBuffer _bb, RandomPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x002F3DB5 File Offset: 0x002F1FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x002F3DC4 File Offset: 0x002F1FC4
		public RandomPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x002F3DD4 File Offset: 0x002F1FD4
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

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x002F3E10 File Offset: 0x002F2010
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

		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x002F3E50 File Offset: 0x002F2050
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

		// Token: 0x0600BF47 RID: 48967 RVA: 0x002F3E8C File Offset: 0x002F208C
		public int ClientPlotReferenceList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600BF48 RID: 48968 RVA: 0x002F3ECC File Offset: 0x002F20CC
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

		// Token: 0x0600BF49 RID: 48969 RVA: 0x002F3EF8 File Offset: 0x002F20F8
		public Span<int> GetClientPlotReferenceListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x002F3F08 File Offset: 0x002F2108
		public int[] GetClientPlotReferenceListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x002F3F20 File Offset: 0x002F2120
		[NullableContext(1)]
		public int[] ClientPlotReferenceList()
		{
			return this.GetClientPlotReferenceListArray();
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x002F3F28 File Offset: 0x002F2128
		[NullableContext(1)]
		public IEnumerable<int> ClientPlotReferenceListIter()
		{
			RandomPlot.<ClientPlotReferenceListIter>d__20 <ClientPlotReferenceListIter>d__ = new RandomPlot.<ClientPlotReferenceListIter>d__20(-2);
			<ClientPlotReferenceListIter>d__.<>3__<>4__this = this;
			return <ClientPlotReferenceListIter>d__;
		}

		// Token: 0x0400564C RID: 22092
		private Table __p;
	}
}
