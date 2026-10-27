using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDF RID: 3551
	public struct LordGym : IFlatbufferObject
	{
		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06008FC6 RID: 36806 RVA: 0x0027B8A0 File Offset: 0x00279AA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x0027B8AD File Offset: 0x00279AAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FC8 RID: 36808 RVA: 0x0027B8B4 File Offset: 0x00279AB4
		public static LordGym GetRootAsLordGym(ByteBuffer _bb)
		{
			return LordGym.GetRootAsLordGym(_bb, default(LordGym));
		}

		// Token: 0x06008FC9 RID: 36809 RVA: 0x0027B8D0 File Offset: 0x00279AD0
		public static LordGym GetRootAsLordGym(ByteBuffer _bb, LordGym obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FCA RID: 36810 RVA: 0x0027B8ED File Offset: 0x00279AED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FCB RID: 36811 RVA: 0x0027B8FC File Offset: 0x00279AFC
		public LordGym __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x0027B90C File Offset: 0x00279B0C
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

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06008FCD RID: 36813 RVA: 0x0027B948 File Offset: 0x00279B48
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06008FCE RID: 36814 RVA: 0x0027B984 File Offset: 0x00279B84
		public int Version
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06008FCF RID: 36815 RVA: 0x0027B9C0 File Offset: 0x00279BC0
		public int RewardId
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

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06008FD0 RID: 36816 RVA: 0x0027BA00 File Offset: 0x00279C00
		public int PlayId
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

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06008FD1 RID: 36817 RVA: 0x0027BA40 File Offset: 0x00279C40
		public int GuidePlayId
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

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x0027BA80 File Offset: 0x00279C80
		public string GymTitle
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

		// Token: 0x06008FD3 RID: 36819 RVA: 0x0027BAB8 File Offset: 0x00279CB8
		public Span<byte> GetGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x0027BAC8 File Offset: 0x00279CC8
		public byte[] GetGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06008FD5 RID: 36821 RVA: 0x0027BAE0 File Offset: 0x00279CE0
		public string FirstGuideGymTitle
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

		// Token: 0x06008FD6 RID: 36822 RVA: 0x0027BB18 File Offset: 0x00279D18
		public Span<byte> GetFirstGuideGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x0027BB28 File Offset: 0x00279D28
		public byte[] GetFirstGuideGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x0027BB40 File Offset: 0x00279D40
		public string NewGymTitle
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

		// Token: 0x06008FD9 RID: 36825 RVA: 0x0027BB78 File Offset: 0x00279D78
		public Span<byte> GetNewGymTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0027BB88 File Offset: 0x00279D88
		public byte[] GetNewGymTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06008FDB RID: 36827 RVA: 0x0027BBA0 File Offset: 0x00279DA0
		public string IconPath
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

		// Token: 0x06008FDC RID: 36828 RVA: 0x0027BBD8 File Offset: 0x00279DD8
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0027BBE8 File Offset: 0x00279DE8
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x0027BC00 File Offset: 0x00279E00
		public string PlayDescription
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

		// Token: 0x06008FDF RID: 36831 RVA: 0x0027BC38 File Offset: 0x00279E38
		public Span<byte> GetPlayDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0027BC48 File Offset: 0x00279E48
		public byte[] GetPlayDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06008FE1 RID: 36833 RVA: 0x0027BC60 File Offset: 0x00279E60
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0027BCA0 File Offset: 0x00279EA0
		public int MonsterList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06008FE3 RID: 36835 RVA: 0x0027BCE0 File Offset: 0x00279EE0
		public int MonsterListLength
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

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0027BD0C File Offset: 0x00279F0C
		public Span<int> GetMonsterListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0027BD1C File Offset: 0x00279F1C
		public int[] GetMonsterListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06008FE6 RID: 36838 RVA: 0x0027BD34 File Offset: 0x00279F34
		public int MonsterLevel
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06008FE7 RID: 36839 RVA: 0x0027BD74 File Offset: 0x00279F74
		public int LockCon
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06008FE8 RID: 36840 RVA: 0x0027BDB4 File Offset: 0x00279FB4
		public string LockDescription
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0027BDEC File Offset: 0x00279FEC
		public Span<byte> GetLockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0027BDFC File Offset: 0x00279FFC
		public byte[] GetLockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06008FEB RID: 36843 RVA: 0x0027BE14 File Offset: 0x0027A014
		public int FilterType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x0027BE54 File Offset: 0x0027A054
		public bool IsNew
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x0027BE94 File Offset: 0x0027A094
		public bool IsDebug
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0027BED4 File Offset: 0x0027A0D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterListIter()或GetMonsterListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterList()
		{
			LordGym lordGym = this;
			return lordGym.GetMonsterListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0027BEF8 File Offset: 0x0027A0F8
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterListIter()
		{
			LordGym.<MonsterListIter>d__62 <MonsterListIter>d__ = new LordGym.<MonsterListIter>d__62(-2);
			<MonsterListIter>d__.<>3__<>4__this = this;
			return <MonsterListIter>d__;
		}

		// Token: 0x04004E7B RID: 20091
		private Table __p;
	}
}
