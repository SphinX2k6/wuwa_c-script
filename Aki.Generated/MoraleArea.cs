using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F08 RID: 3848
	public struct MoraleArea : IFlatbufferObject
	{
		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06009BFC RID: 39932 RVA: 0x002A70F1 File Offset: 0x002A52F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BFD RID: 39933 RVA: 0x002A70FE File Offset: 0x002A52FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BFE RID: 39934 RVA: 0x002A7108 File Offset: 0x002A5308
		public static MoraleArea GetRootAsMoraleArea(ByteBuffer _bb)
		{
			return MoraleArea.GetRootAsMoraleArea(_bb, default(MoraleArea));
		}

		// Token: 0x06009BFF RID: 39935 RVA: 0x002A7124 File Offset: 0x002A5324
		public static MoraleArea GetRootAsMoraleArea(ByteBuffer _bb, MoraleArea obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C00 RID: 39936 RVA: 0x002A7141 File Offset: 0x002A5341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C01 RID: 39937 RVA: 0x002A7150 File Offset: 0x002A5350
		public MoraleArea __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06009C02 RID: 39938 RVA: 0x002A7160 File Offset: 0x002A5360
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

		// Token: 0x06009C03 RID: 39939 RVA: 0x002A719C File Offset: 0x002A539C
		public int ExploreBox(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06009C04 RID: 39940 RVA: 0x002A71DC File Offset: 0x002A53DC
		public int ExploreBoxLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x002A7207 File Offset: 0x002A5407
		public Span<int> GetExploreBoxBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x002A7216 File Offset: 0x002A5416
		public int[] GetExploreBoxArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06009C07 RID: 39943 RVA: 0x002A7230 File Offset: 0x002A5430
		public string Name
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

		// Token: 0x06009C08 RID: 39944 RVA: 0x002A7267 File Offset: 0x002A5467
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009C09 RID: 39945 RVA: 0x002A7276 File Offset: 0x002A5476
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x002A7290 File Offset: 0x002A5490
		public int PlotIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06009C0B RID: 39947 RVA: 0x002A72D0 File Offset: 0x002A54D0
		public int PlotIdListLength
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

		// Token: 0x06009C0C RID: 39948 RVA: 0x002A72FC File Offset: 0x002A54FC
		public Span<int> GetPlotIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009C0D RID: 39949 RVA: 0x002A730C File Offset: 0x002A550C
		public int[] GetPlotIdListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06009C0E RID: 39950 RVA: 0x002A7324 File Offset: 0x002A5524
		public string DescBigBgPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C0F RID: 39951 RVA: 0x002A735C File Offset: 0x002A555C
		public Span<byte> GetDescBigBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009C10 RID: 39952 RVA: 0x002A736C File Offset: 0x002A556C
		public byte[] GetDescBigBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06009C11 RID: 39953 RVA: 0x002A7384 File Offset: 0x002A5584
		public string DescGridBgPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x002A73BC File Offset: 0x002A55BC
		public Span<byte> GetDescGridBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x002A73CC File Offset: 0x002A55CC
		public byte[] GetDescGridBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06009C14 RID: 39956 RVA: 0x002A73E4 File Offset: 0x002A55E4
		public int DescGridBgAddX
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

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06009C15 RID: 39957 RVA: 0x002A7424 File Offset: 0x002A5624
		public string BuffLockDesc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x002A745C File Offset: 0x002A565C
		public Span<byte> GetBuffLockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x002A746C File Offset: 0x002A566C
		public byte[] GetBuffLockDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06009C18 RID: 39960 RVA: 0x002A7484 File Offset: 0x002A5684
		public string BuffActiveDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x002A74BC File Offset: 0x002A56BC
		public Span<byte> GetBuffActiveDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x002A74CC File Offset: 0x002A56CC
		public byte[] GetBuffActiveDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x002A74E4 File Offset: 0x002A56E4
		public int BuffId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06009C1C RID: 39964 RVA: 0x002A7524 File Offset: 0x002A5724
		public string MonsterIconPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C1D RID: 39965 RVA: 0x002A755C File Offset: 0x002A575C
		public Span<byte> GetMonsterIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009C1E RID: 39966 RVA: 0x002A756C File Offset: 0x002A576C
		public byte[] GetMonsterIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009C1F RID: 39967 RVA: 0x002A7584 File Offset: 0x002A5784
		[NullableContext(1)]
		public int[] ExploreBox()
		{
			return this.GetExploreBoxArray();
		}

		// Token: 0x06009C20 RID: 39968 RVA: 0x002A758C File Offset: 0x002A578C
		[NullableContext(1)]
		public IEnumerable<int> ExploreBoxIter()
		{
			MoraleArea.<ExploreBoxIter>d__49 <ExploreBoxIter>d__ = new MoraleArea.<ExploreBoxIter>d__49(-2);
			<ExploreBoxIter>d__.<>3__<>4__this = this;
			return <ExploreBoxIter>d__;
		}

		// Token: 0x06009C21 RID: 39969 RVA: 0x002A75A1 File Offset: 0x002A57A1
		[NullableContext(1)]
		public int[] PlotIdList()
		{
			return this.GetPlotIdListArray();
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x002A75A9 File Offset: 0x002A57A9
		[NullableContext(1)]
		public IEnumerable<int> PlotIdListIter()
		{
			MoraleArea.<PlotIdListIter>d__51 <PlotIdListIter>d__ = new MoraleArea.<PlotIdListIter>d__51(-2);
			<PlotIdListIter>d__.<>3__<>4__this = this;
			return <PlotIdListIter>d__;
		}

		// Token: 0x040054AD RID: 21677
		private Table __p;
	}
}
