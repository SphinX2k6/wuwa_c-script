using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F33 RID: 3891
	public struct PinballMonsterType : IFlatbufferObject
	{
		// Token: 0x17002993 RID: 10643
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x002C35D0 File Offset: 0x002C17D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AFA5 RID: 44965 RVA: 0x002C35DD File Offset: 0x002C17DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AFA6 RID: 44966 RVA: 0x002C35E4 File Offset: 0x002C17E4
		public static PinballMonsterType GetRootAsPinballMonsterType(ByteBuffer _bb)
		{
			return PinballMonsterType.GetRootAsPinballMonsterType(_bb, default(PinballMonsterType));
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x002C3600 File Offset: 0x002C1800
		public static PinballMonsterType GetRootAsPinballMonsterType(ByteBuffer _bb, PinballMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AFA8 RID: 44968 RVA: 0x002C361D File Offset: 0x002C181D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AFA9 RID: 44969 RVA: 0x002C362C File Offset: 0x002C182C
		public PinballMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002994 RID: 10644
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x002C363C File Offset: 0x002C183C
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

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600AFAB RID: 44971 RVA: 0x002C3678 File Offset: 0x002C1878
		public int TemplateId
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

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x002C36B4 File Offset: 0x002C18B4
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

		// Token: 0x0600AFAD RID: 44973 RVA: 0x002C36EB File Offset: 0x002C18EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AFAE RID: 44974 RVA: 0x002C36FA File Offset: 0x002C18FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x0600AFAF RID: 44975 RVA: 0x002C3714 File Offset: 0x002C1914
		public int RiskType
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

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x002C3754 File Offset: 0x002C1954
		public int BodyType
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

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x0600AFB1 RID: 44977 RVA: 0x002C3794 File Offset: 0x002C1994
		public string Icon
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

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x002C37CC File Offset: 0x002C19CC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x002C37DC File Offset: 0x002C19DC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x0600AFB4 RID: 44980 RVA: 0x002C37F4 File Offset: 0x002C19F4
		public string BigIcon
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

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x002C382C File Offset: 0x002C1A2C
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x002C383C File Offset: 0x002C1A3C
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600AFB7 RID: 44983 RVA: 0x002C3854 File Offset: 0x002C1A54
		public string Desc
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

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x002C388C File Offset: 0x002C1A8C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x002C389C File Offset: 0x002C1A9C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600AFBA RID: 44986 RVA: 0x002C38B4 File Offset: 0x002C1AB4
		public int RecommendBd
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

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x0600AFBB RID: 44987 RVA: 0x002C38F4 File Offset: 0x002C1AF4
		public string SpineBg
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

		// Token: 0x0600AFBC RID: 44988 RVA: 0x002C392C File Offset: 0x002C1B2C
		public Span<byte> GetSpineBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x002C393C File Offset: 0x002C1B3C
		public byte[] GetSpineBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0600AFBE RID: 44990 RVA: 0x002C3954 File Offset: 0x002C1B54
		public string SpineAtlasPath
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

		// Token: 0x0600AFBF RID: 44991 RVA: 0x002C398C File Offset: 0x002C1B8C
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x002C399C File Offset: 0x002C1B9C
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x002C39B4 File Offset: 0x002C1BB4
		public string SpineSkeletonDataPath
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AFC2 RID: 44994 RVA: 0x002C39EC File Offset: 0x002C1BEC
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600AFC3 RID: 44995 RVA: 0x002C39FC File Offset: 0x002C1BFC
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AFC4 RID: 44996 RVA: 0x002C3A14 File Offset: 0x002C1C14
		public int DisplayedSkillList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600AFC5 RID: 44997 RVA: 0x002C3A54 File Offset: 0x002C1C54
		public int DisplayedSkillListLength
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

		// Token: 0x0600AFC6 RID: 44998 RVA: 0x002C3A80 File Offset: 0x002C1C80
		public Span<int> GetDisplayedSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600AFC7 RID: 44999 RVA: 0x002C3A90 File Offset: 0x002C1C90
		public int[] GetDisplayedSkillListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600AFC8 RID: 45000 RVA: 0x002C3AA8 File Offset: 0x002C1CA8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisplayedSkillListIter()或GetDisplayedSkillListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisplayedSkillList()
		{
			PinballMonsterType pinballMonsterType = this;
			return pinballMonsterType.GetDisplayedSkillListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AFC9 RID: 45001 RVA: 0x002C3ACC File Offset: 0x002C1CCC
		[NullableContext(1)]
		public readonly IEnumerable<int> DisplayedSkillListIter()
		{
			PinballMonsterType.<DisplayedSkillListIter>d__52 <DisplayedSkillListIter>d__ = new PinballMonsterType.<DisplayedSkillListIter>d__52(-2);
			<DisplayedSkillListIter>d__.<>3__<>4__this = this;
			return <DisplayedSkillListIter>d__;
		}

		// Token: 0x04004FFD RID: 20477
		private Table __p;
	}
}
