using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D71 RID: 3441
	public struct FishingTech : IFlatbufferObject
	{
		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x0025336D File Offset: 0x0025156D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x0025337A File Offset: 0x0025157A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00253384 File Offset: 0x00251584
		public static FishingTech GetRootAsFishingTech(ByteBuffer _bb)
		{
			return FishingTech.GetRootAsFishingTech(_bb, default(FishingTech));
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x002533A0 File Offset: 0x002515A0
		public static FishingTech GetRootAsFishingTech(ByteBuffer _bb, FishingTech obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x002533BD File Offset: 0x002515BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x002533CC File Offset: 0x002515CC
		public FishingTech __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x060076A4 RID: 30372 RVA: 0x002533DC File Offset: 0x002515DC
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

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060076A5 RID: 30373 RVA: 0x00253418 File Offset: 0x00251618
		public string Name
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

		// Token: 0x060076A6 RID: 30374 RVA: 0x0025344F File Offset: 0x0025164F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x0025345E File Offset: 0x0025165E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x00253478 File Offset: 0x00251678
		public int Type
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

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060076A9 RID: 30377 RVA: 0x002534B4 File Offset: 0x002516B4
		public int TreeLevel
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

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x002534F4 File Offset: 0x002516F4
		public int Area
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060076AB RID: 30379 RVA: 0x00253534 File Offset: 0x00251734
		public int IndexId
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

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x00253574 File Offset: 0x00251774
		public int PreNode
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

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060076AD RID: 30381 RVA: 0x002535B4 File Offset: 0x002517B4
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x002535F4 File Offset: 0x002517F4
		public int Effect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x060076AF RID: 30383 RVA: 0x00253634 File Offset: 0x00251834
		public int EffectLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00253660 File Offset: 0x00251860
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00253670 File Offset: 0x00251870
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00253688 File Offset: 0x00251888
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x002536C0 File Offset: 0x002518C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x002536D0 File Offset: 0x002518D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x060076B5 RID: 30389 RVA: 0x002536E8 File Offset: 0x002518E8
		public string TagName
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

		// Token: 0x060076B6 RID: 30390 RVA: 0x00253720 File Offset: 0x00251920
		public Span<byte> GetTagNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00253730 File Offset: 0x00251930
		public byte[] GetTagNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00253748 File Offset: 0x00251948
		[NullableContext(1)]
		public int[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00253750 File Offset: 0x00251950
		[NullableContext(1)]
		public IEnumerable<int> EffectIter()
		{
			FishingTech.<EffectIter>d__40 <EffectIter>d__ = new FishingTech.<EffectIter>d__40(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x040052C6 RID: 21190
		private Table __p;
	}
}
