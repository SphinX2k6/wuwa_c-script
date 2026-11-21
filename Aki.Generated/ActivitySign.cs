using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA5 RID: 2981
	public struct ActivitySign : IFlatbufferObject
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x001ECB48 File Offset: 0x001EAD48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x001ECB55 File Offset: 0x001EAD55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x001ECB5C File Offset: 0x001EAD5C
		public static ActivitySign GetRootAsActivitySign(ByteBuffer _bb)
		{
			return ActivitySign.GetRootAsActivitySign(_bb, default(ActivitySign));
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x001ECB78 File Offset: 0x001EAD78
		public static ActivitySign GetRootAsActivitySign(ByteBuffer _bb, ActivitySign obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x001ECB95 File Offset: 0x001EAD95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001ECBA4 File Offset: 0x001EADA4
		public ActivitySign __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x001ECBB4 File Offset: 0x001EADB4
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600490B RID: 18699 RVA: 0x001ECBF0 File Offset: 0x001EADF0
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

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600490C RID: 18700 RVA: 0x001ECC2C File Offset: 0x001EAE2C
		public string PrefabResource
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

		// Token: 0x0600490D RID: 18701 RVA: 0x001ECC63 File Offset: 0x001EAE63
		public Span<byte> GetPrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x001ECC72 File Offset: 0x001EAE72
		public byte[] GetPrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x001ECC8C File Offset: 0x001EAE8C
		public OneItemConfig? SignRewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x001ECCF0 File Offset: 0x001EAEF0
		public int SignRewardsLength
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

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x001ECD1C File Offset: 0x001EAF1C
		public int ImportantRewardIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x001ECD5C File Offset: 0x001EAF5C
		public string ImportantRewardIcon
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

		// Token: 0x06004913 RID: 18707 RVA: 0x001ECD94 File Offset: 0x001EAF94
		public Span<byte> GetImportantRewardIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x001ECDA4 File Offset: 0x001EAFA4
		public byte[] GetImportantRewardIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x001ECDBC File Offset: 0x001EAFBC
		public int ImportantRewardType
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

		// Token: 0x06004916 RID: 18710 RVA: 0x001ECDFC File Offset: 0x001EAFFC
		public int PreviewList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x001ECE3C File Offset: 0x001EB03C
		public int PreviewListLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x001ECE68 File Offset: 0x001EB068
		public Span<int> GetPreviewListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x001ECE78 File Offset: 0x001EB078
		public int[] GetPreviewListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x001ECE90 File Offset: 0x001EB090
		public int FreeDropId
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

		// Token: 0x0600491B RID: 18715 RVA: 0x001ECED0 File Offset: 0x001EB0D0
		public int GrandRewardId(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x001ECF10 File Offset: 0x001EB110
		public int GrandRewardIdLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x001ECF3C File Offset: 0x001EB13C
		public Span<int> GetGrandRewardIdBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x001ECF4C File Offset: 0x001EB14C
		public int[] GetGrandRewardIdArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x001ECF64 File Offset: 0x001EB164
		[NullableContext(1)]
		public int[] GrandRewardId()
		{
			return this.GetGrandRewardIdArray();
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x001ECF6C File Offset: 0x001EB16C
		[NullableContext(1)]
		public IEnumerable<int> GrandRewardIdIter()
		{
			ActivitySign.<GrandRewardIdIter>d__40 <GrandRewardIdIter>d__ = new ActivitySign.<GrandRewardIdIter>d__40(-2);
			<GrandRewardIdIter>d__.<>3__<>4__this = this;
			return <GrandRewardIdIter>d__;
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x001ECF81 File Offset: 0x001EB181
		[NullableContext(1)]
		public int[] PreviewList()
		{
			return this.GetPreviewListArray();
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x001ECF89 File Offset: 0x001EB189
		[NullableContext(1)]
		public IEnumerable<int> PreviewListIter()
		{
			ActivitySign.<PreviewListIter>d__42 <PreviewListIter>d__ = new ActivitySign.<PreviewListIter>d__42(-2);
			<PreviewListIter>d__.<>3__<>4__this = this;
			return <PreviewListIter>d__;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x001ECF9E File Offset: 0x001EB19E
		[NullableContext(1)]
		public OneItemConfig[] SignRewards()
		{
			return this.SignRewardsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x001ECFAB File Offset: 0x001EB1AB
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> SignRewardsIter()
		{
			ActivitySign.<SignRewardsIter>d__44 <SignRewardsIter>d__ = new ActivitySign.<SignRewardsIter>d__44(-2);
			<SignRewardsIter>d__.<>3__<>4__this = this;
			return <SignRewardsIter>d__;
		}

		// Token: 0x04005082 RID: 20610
		private Table __p;
	}
}
