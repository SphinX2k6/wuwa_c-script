using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E41 RID: 3649
	public struct Influence : IFlatbufferObject
	{
		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060088C0 RID: 35008 RVA: 0x0027BA7C File Offset: 0x00279C7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x0027BA89 File Offset: 0x00279C89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x0027BA90 File Offset: 0x00279C90
		public static Influence GetRootAsInfluence(ByteBuffer _bb)
		{
			return Influence.GetRootAsInfluence(_bb, default(Influence));
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x0027BAAC File Offset: 0x00279CAC
		public static Influence GetRootAsInfluence(ByteBuffer _bb, Influence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x0027BAC9 File Offset: 0x00279CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x0027BAD8 File Offset: 0x00279CD8
		public Influence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060088C6 RID: 35014 RVA: 0x0027BAE8 File Offset: 0x00279CE8
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

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060088C7 RID: 35015 RVA: 0x0027BB24 File Offset: 0x00279D24
		public string Title
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

		// Token: 0x060088C8 RID: 35016 RVA: 0x0027BB5B File Offset: 0x00279D5B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x0027BB6A File Offset: 0x00279D6A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060088CA RID: 35018 RVA: 0x0027BB84 File Offset: 0x00279D84
		public string Introduction
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

		// Token: 0x060088CB RID: 35019 RVA: 0x0027BBBB File Offset: 0x00279DBB
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060088CC RID: 35020 RVA: 0x0027BBCA File Offset: 0x00279DCA
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x0027BBE4 File Offset: 0x00279DE4
		public string ExtraDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088CE RID: 35022 RVA: 0x0027BC1C File Offset: 0x00279E1C
		public Span<byte> GetExtraDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060088CF RID: 35023 RVA: 0x0027BC2C File Offset: 0x00279E2C
		public byte[] GetExtraDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060088D0 RID: 35024 RVA: 0x0027BC44 File Offset: 0x00279E44
		public int ShowIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x0027BC84 File Offset: 0x00279E84
		public string Logo
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

		// Token: 0x060088D2 RID: 35026 RVA: 0x0027BCBC File Offset: 0x00279EBC
		public Span<byte> GetLogoBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060088D3 RID: 35027 RVA: 0x0027BCCC File Offset: 0x00279ECC
		public byte[] GetLogoArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060088D4 RID: 35028 RVA: 0x0027BCE4 File Offset: 0x00279EE4
		public int DailyTaskShow
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x0027BD24 File Offset: 0x00279F24
		public int RawRelation
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

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x0027BD64 File Offset: 0x00279F64
		public int RelationCondition
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

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060088D7 RID: 35031 RVA: 0x0027BDA4 File Offset: 0x00279FA4
		public int LastRelation
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

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060088D8 RID: 35032 RVA: 0x0027BDE4 File Offset: 0x00279FE4
		public int ReputationMax
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x0027BE28 File Offset: 0x0027A028
		public IntPair? ReputationItem(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060088DA RID: 35034 RVA: 0x0027BE8C File Offset: 0x0027A08C
		public int ReputationItemLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x0027BEB8 File Offset: 0x0027A0B8
		public IntPair? ReputationReward(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x060088DC RID: 35036 RVA: 0x0027BF1C File Offset: 0x0027A11C
		public int ReputationRewardLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x0027BF48 File Offset: 0x0027A148
		public int PartyTags(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x060088DE RID: 35038 RVA: 0x0027BF88 File Offset: 0x0027A188
		public int PartyTagsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x0027BFB4 File Offset: 0x0027A1B4
		public Span<int> GetPartyTagsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x0027BFC4 File Offset: 0x0027A1C4
		public int[] GetPartyTagsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x0027BFDC File Offset: 0x0027A1DC
		[NullableContext(1)]
		public int[] PartyTags()
		{
			return this.GetPartyTagsArray();
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x0027BFE4 File Offset: 0x0027A1E4
		[NullableContext(1)]
		public IEnumerable<int> PartyTagsIter()
		{
			Influence.<PartyTagsIter>d__50 <PartyTagsIter>d__ = new Influence.<PartyTagsIter>d__50(-2);
			<PartyTagsIter>d__.<>3__<>4__this = this;
			return <PartyTagsIter>d__;
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x0027BFF9 File Offset: 0x0027A1F9
		[NullableContext(1)]
		public IntPair[] ReputationItem()
		{
			return this.ReputationItemIter().ToArray<IntPair>();
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x0027C006 File Offset: 0x0027A206
		[NullableContext(1)]
		public IEnumerable<IntPair> ReputationItemIter()
		{
			Influence.<ReputationItemIter>d__52 <ReputationItemIter>d__ = new Influence.<ReputationItemIter>d__52(-2);
			<ReputationItemIter>d__.<>3__<>4__this = this;
			return <ReputationItemIter>d__;
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x0027C01B File Offset: 0x0027A21B
		[NullableContext(1)]
		public IntPair[] ReputationReward()
		{
			return this.ReputationRewardIter().ToArray<IntPair>();
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x0027C028 File Offset: 0x0027A228
		[NullableContext(1)]
		public IEnumerable<IntPair> ReputationRewardIter()
		{
			Influence.<ReputationRewardIter>d__54 <ReputationRewardIter>d__ = new Influence.<ReputationRewardIter>d__54(-2);
			<ReputationRewardIter>d__.<>3__<>4__this = this;
			return <ReputationRewardIter>d__;
		}

		// Token: 0x040053C0 RID: 21440
		private Table __p;
	}
}
