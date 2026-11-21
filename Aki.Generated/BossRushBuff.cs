using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C24 RID: 3108
	public struct BossRushBuff : IFlatbufferObject
	{
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060054C1 RID: 21697 RVA: 0x0020776A File Offset: 0x0020596A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00207777 File Offset: 0x00205977
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054C3 RID: 21699 RVA: 0x00207780 File Offset: 0x00205980
		public static BossRushBuff GetRootAsBossRushBuff(ByteBuffer _bb)
		{
			return BossRushBuff.GetRootAsBossRushBuff(_bb, default(BossRushBuff));
		}

		// Token: 0x060054C4 RID: 21700 RVA: 0x0020779C File Offset: 0x0020599C
		public static BossRushBuff GetRootAsBossRushBuff(ByteBuffer _bb, BossRushBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054C5 RID: 21701 RVA: 0x002077B9 File Offset: 0x002059B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x002077C8 File Offset: 0x002059C8
		public BossRushBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x002077D8 File Offset: 0x002059D8
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

		// Token: 0x060054C8 RID: 21704 RVA: 0x00207814 File Offset: 0x00205A14
		public long BuffId(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x00207854 File Offset: 0x00205A54
		public int BuffIdLength
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

		// Token: 0x060054CA RID: 21706 RVA: 0x0020787F File Offset: 0x00205A7F
		public Span<long> GetBuffIdBytes()
		{
			return this.__p.__vector_as_span<long>(6, 8);
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x0020788E File Offset: 0x00205A8E
		public long[] GetBuffIdArray()
		{
			return this.__p.__vector_as_array<long>(6) ?? Array.Empty<long>();
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x002078A8 File Offset: 0x00205AA8
		public long PassiveSkill(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x002078E8 File Offset: 0x00205AE8
		public int PassiveSkillLength
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

		// Token: 0x060054CE RID: 21710 RVA: 0x00207913 File Offset: 0x00205B13
		public Span<long> GetPassiveSkillBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x060054CF RID: 21711 RVA: 0x00207922 File Offset: 0x00205B22
		public long[] GetPassiveSkillArray()
		{
			return this.__p.__vector_as_array<long>(8) ?? Array.Empty<long>();
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x0020793C File Offset: 0x00205B3C
		public string Texture
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

		// Token: 0x060054D1 RID: 21713 RVA: 0x00207974 File Offset: 0x00205B74
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x00207984 File Offset: 0x00205B84
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060054D3 RID: 21715 RVA: 0x0020799C File Offset: 0x00205B9C
		public string Name
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

		// Token: 0x060054D4 RID: 21716 RVA: 0x002079D4 File Offset: 0x00205BD4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x002079E4 File Offset: 0x00205BE4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x002079FC File Offset: 0x00205BFC
		public int PopDescIdList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060054D7 RID: 21719 RVA: 0x00207A3C File Offset: 0x00205C3C
		public int PopDescIdListLength
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

		// Token: 0x060054D8 RID: 21720 RVA: 0x00207A68 File Offset: 0x00205C68
		public Span<int> GetPopDescIdListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x00207A78 File Offset: 0x00205C78
		public int[] GetPopDescIdListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x00207A90 File Offset: 0x00205C90
		public string BuffTitle
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

		// Token: 0x060054DB RID: 21723 RVA: 0x00207AC8 File Offset: 0x00205CC8
		public Span<byte> GetBuffTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060054DC RID: 21724 RVA: 0x00207AD8 File Offset: 0x00205CD8
		public byte[] GetBuffTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x00207AF0 File Offset: 0x00205CF0
		public string BuffDesc
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

		// Token: 0x060054DE RID: 21726 RVA: 0x00207B28 File Offset: 0x00205D28
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x00207B38 File Offset: 0x00205D38
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00207B50 File Offset: 0x00205D50
		public string BuffDescParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x00207B8C File Offset: 0x00205D8C
		public int BuffDescParamLength
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x00207BB8 File Offset: 0x00205DB8
		public string Description
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

		// Token: 0x060054E3 RID: 21731 RVA: 0x00207BF0 File Offset: 0x00205DF0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00207C00 File Offset: 0x00205E00
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00207C18 File Offset: 0x00205E18
		public string DescriptionParam(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060054E6 RID: 21734 RVA: 0x00207C54 File Offset: 0x00205E54
		public int DescriptionParamLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00207C80 File Offset: 0x00205E80
		[NullableContext(1)]
		public string[] BuffDescParam()
		{
			return this.BuffDescParamIter().ToArray<string>();
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00207C8D File Offset: 0x00205E8D
		[NullableContext(1)]
		public IEnumerable<string> BuffDescParamIter()
		{
			BossRushBuff.<BuffDescParamIter>d__52 <BuffDescParamIter>d__ = new BossRushBuff.<BuffDescParamIter>d__52(-2);
			<BuffDescParamIter>d__.<>3__<>4__this = this;
			return <BuffDescParamIter>d__;
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00207CA2 File Offset: 0x00205EA2
		[NullableContext(1)]
		public long[] BuffId()
		{
			return this.GetBuffIdArray();
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x00207CAA File Offset: 0x00205EAA
		[NullableContext(1)]
		public IEnumerable<long> BuffIdIter()
		{
			BossRushBuff.<BuffIdIter>d__54 <BuffIdIter>d__ = new BossRushBuff.<BuffIdIter>d__54(-2);
			<BuffIdIter>d__.<>3__<>4__this = this;
			return <BuffIdIter>d__;
		}

		// Token: 0x060054EB RID: 21739 RVA: 0x00207CBF File Offset: 0x00205EBF
		[NullableContext(1)]
		public string[] DescriptionParam()
		{
			return this.DescriptionParamIter().ToArray<string>();
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x00207CCC File Offset: 0x00205ECC
		[NullableContext(1)]
		public IEnumerable<string> DescriptionParamIter()
		{
			BossRushBuff.<DescriptionParamIter>d__56 <DescriptionParamIter>d__ = new BossRushBuff.<DescriptionParamIter>d__56(-2);
			<DescriptionParamIter>d__.<>3__<>4__this = this;
			return <DescriptionParamIter>d__;
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x00207CE1 File Offset: 0x00205EE1
		[NullableContext(1)]
		public long[] PassiveSkill()
		{
			return this.GetPassiveSkillArray();
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00207CE9 File Offset: 0x00205EE9
		[NullableContext(1)]
		public IEnumerable<long> PassiveSkillIter()
		{
			BossRushBuff.<PassiveSkillIter>d__58 <PassiveSkillIter>d__ = new BossRushBuff.<PassiveSkillIter>d__58(-2);
			<PassiveSkillIter>d__.<>3__<>4__this = this;
			return <PassiveSkillIter>d__;
		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00207CFE File Offset: 0x00205EFE
		[NullableContext(1)]
		public int[] PopDescIdList()
		{
			return this.GetPopDescIdListArray();
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00207D06 File Offset: 0x00205F06
		[NullableContext(1)]
		public IEnumerable<int> PopDescIdListIter()
		{
			BossRushBuff.<PopDescIdListIter>d__60 <PopDescIdListIter>d__ = new BossRushBuff.<PopDescIdListIter>d__60(-2);
			<PopDescIdListIter>d__.<>3__<>4__this = this;
			return <PopDescIdListIter>d__;
		}

		// Token: 0x0400511F RID: 20767
		private Table __p;
	}
}
