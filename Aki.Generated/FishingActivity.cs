using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D58 RID: 3416
	public struct FishingActivity : IFlatbufferObject
	{
		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x060074A8 RID: 29864 RVA: 0x0024E7A1 File Offset: 0x0024C9A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x0024E7AE File Offset: 0x0024C9AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x0024E7B8 File Offset: 0x0024C9B8
		public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb)
		{
			return FishingActivity.GetRootAsFishingActivity(_bb, default(FishingActivity));
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x0024E7D4 File Offset: 0x0024C9D4
		public static FishingActivity GetRootAsFishingActivity(ByteBuffer _bb, FishingActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x0024E7F1 File Offset: 0x0024C9F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x0024E800 File Offset: 0x0024CA00
		public FishingActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x060074AE RID: 29870 RVA: 0x0024E810 File Offset: 0x0024CA10
		public int ActivityId
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x060074AF RID: 29871 RVA: 0x0024E84C File Offset: 0x0024CA4C
		public int TimeQuantumId
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

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060074B0 RID: 29872 RVA: 0x0024E888 File Offset: 0x0024CA88
		public int MilestonItemId
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

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060074B1 RID: 29873 RVA: 0x0024E8C4 File Offset: 0x0024CAC4
		public int PreviewWeaponId
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

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060074B2 RID: 29874 RVA: 0x0024E904 File Offset: 0x0024CB04
		public int RecommendQuestId
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

		// Token: 0x060074B3 RID: 29875 RVA: 0x0024E944 File Offset: 0x0024CB44
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060074B4 RID: 29876 RVA: 0x0024E984 File Offset: 0x0024CB84
		public int RecommendQuestLinkListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x0024E9B0 File Offset: 0x0024CBB0
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x0024E9C0 File Offset: 0x0024CBC0
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x0024E9D8 File Offset: 0x0024CBD8
		public string RecommendQuestLabel
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x0024EA10 File Offset: 0x0024CC10
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0024EA20 File Offset: 0x0024CC20
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x0024EA38 File Offset: 0x0024CC38
		[NullableContext(1)]
		public int[] RecommendQuestLinkList()
		{
			return this.GetRecommendQuestLinkListArray();
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0024EA40 File Offset: 0x0024CC40
		[NullableContext(1)]
		public IEnumerable<int> RecommendQuestLinkListIter()
		{
			FishingActivity.<RecommendQuestLinkListIter>d__28 <RecommendQuestLinkListIter>d__ = new FishingActivity.<RecommendQuestLinkListIter>d__28(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x040052A3 RID: 21155
		private Table __p;
	}
}
