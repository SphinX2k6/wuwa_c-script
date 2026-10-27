using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5C RID: 2908
	public struct CalabashDevelopReward : IFlatbufferObject
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x001ED89C File Offset: 0x001EBA9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x001ED8A9 File Offset: 0x001EBAA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x001ED8B0 File Offset: 0x001EBAB0
		public static CalabashDevelopReward GetRootAsCalabashDevelopReward(ByteBuffer _bb)
		{
			return CalabashDevelopReward.GetRootAsCalabashDevelopReward(_bb, default(CalabashDevelopReward));
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x001ED8CC File Offset: 0x001EBACC
		public static CalabashDevelopReward GetRootAsCalabashDevelopReward(ByteBuffer _bb, CalabashDevelopReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x001ED8E9 File Offset: 0x001EBAE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x001ED8F8 File Offset: 0x001EBAF8
		public CalabashDevelopReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060051AF RID: 20911 RVA: 0x001ED908 File Offset: 0x001EBB08
		public int MonsterId
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

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x001ED944 File Offset: 0x001EBB44
		public int InteractAreaId
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

		// Token: 0x060051B1 RID: 20913 RVA: 0x001ED980 File Offset: 0x001EBB80
		public int DevelopCondition(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x001ED9C0 File Offset: 0x001EBBC0
		public int DevelopConditionLength
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

		// Token: 0x060051B3 RID: 20915 RVA: 0x001ED9EB File Offset: 0x001EBBEB
		public Span<int> GetDevelopConditionBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x001ED9FA File Offset: 0x001EBBFA
		public int[] GetDevelopConditionArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060051B5 RID: 20917 RVA: 0x001EDA14 File Offset: 0x001EBC14
		public int MonsterInfoId
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

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x001EDA54 File Offset: 0x001EBC54
		public int AllExp
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

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060051B7 RID: 20919 RVA: 0x001EDA94 File Offset: 0x001EBC94
		public int SortId
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

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x001EDAD4 File Offset: 0x001EBCD4
		public int MonsterProbeId
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

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060051B9 RID: 20921 RVA: 0x001EDB14 File Offset: 0x001EBD14
		public string HandBookBp
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

		// Token: 0x060051BA RID: 20922 RVA: 0x001EDB4C File Offset: 0x001EBD4C
		public Span<byte> GetHandBookBpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060051BB RID: 20923 RVA: 0x001EDB5C File Offset: 0x001EBD5C
		public byte[] GetHandBookBpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x001EDB74 File Offset: 0x001EBD74
		public int MonsterBodyType
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

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x001EDBB4 File Offset: 0x001EBDB4
		public string HandBookCamera
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

		// Token: 0x060051BE RID: 20926 RVA: 0x001EDBEC File Offset: 0x001EBDEC
		public Span<byte> GetHandBookCameraBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x001EDBFC File Offset: 0x001EBDFC
		public byte[] GetHandBookCameraArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x001EDC14 File Offset: 0x001EBE14
		public string MonsterNumber
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

		// Token: 0x060051C1 RID: 20929 RVA: 0x001EDC4C File Offset: 0x001EBE4C
		public Span<byte> GetMonsterNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x001EDC5C File Offset: 0x001EBE5C
		public byte[] GetMonsterNumberArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x001EDC74 File Offset: 0x001EBE74
		public int InteractionRadius
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

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x001EDCB4 File Offset: 0x001EBEB4
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x001EDCF4 File Offset: 0x001EBEF4
		public bool AllowVision
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x001EDD34 File Offset: 0x001EBF34
		public bool IsWorldInteractable
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x001EDD74 File Offset: 0x001EBF74
		public string SpecialSkillName
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

		// Token: 0x060051C8 RID: 20936 RVA: 0x001EDDAC File Offset: 0x001EBFAC
		public Span<byte> GetSpecialSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x001EDDBC File Offset: 0x001EBFBC
		public byte[] GetSpecialSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x001EDDD4 File Offset: 0x001EBFD4
		public string SpecialSkillDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x001EDE0C File Offset: 0x001EC00C
		public Span<byte> GetSpecialSkillDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x001EDE1C File Offset: 0x001EC01C
		public byte[] GetSpecialSkillDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x001EDE34 File Offset: 0x001EC034
		public string SpecialSkillPicturePath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x001EDE6C File Offset: 0x001EC06C
		public Span<byte> GetSpecialSkillPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x001EDE7C File Offset: 0x001EC07C
		public byte[] GetSpecialSkillPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x001EDE94 File Offset: 0x001EC094
		public int VisionCoolDown
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x001EDED4 File Offset: 0x001EC0D4
		public int InteractAreaList(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x001EDF14 File Offset: 0x001EC114
		public int InteractAreaListLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x001EDF40 File Offset: 0x001EC140
		public Span<int> GetInteractAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x001EDF50 File Offset: 0x001EC150
		public int[] GetInteractAreaListArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060051D5 RID: 20949 RVA: 0x001EDF68 File Offset: 0x001EC168
		public int ItemAccess
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x001EDFA8 File Offset: 0x001EC1A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DevelopConditionIter()或GetDevelopConditionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DevelopCondition()
		{
			CalabashDevelopReward calabashDevelopReward = this;
			return calabashDevelopReward.GetDevelopConditionArray() ?? Array.Empty<int>();
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x001EDFCC File Offset: 0x001EC1CC
		[NullableContext(1)]
		public readonly IEnumerable<int> DevelopConditionIter()
		{
			CalabashDevelopReward.<DevelopConditionIter>d__69 <DevelopConditionIter>d__ = new CalabashDevelopReward.<DevelopConditionIter>d__69(-2);
			<DevelopConditionIter>d__.<>3__<>4__this = this;
			return <DevelopConditionIter>d__;
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x001EDFE4 File Offset: 0x001EC1E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InteractAreaListIter()或GetInteractAreaListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InteractAreaList()
		{
			CalabashDevelopReward calabashDevelopReward = this;
			return calabashDevelopReward.GetInteractAreaListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x001EE008 File Offset: 0x001EC208
		[NullableContext(1)]
		public readonly IEnumerable<int> InteractAreaListIter()
		{
			CalabashDevelopReward.<InteractAreaListIter>d__71 <InteractAreaListIter>d__ = new CalabashDevelopReward.<InteractAreaListIter>d__71(-2);
			<InteractAreaListIter>d__.<>3__<>4__this = this;
			return <InteractAreaListIter>d__;
		}

		// Token: 0x04004B5A RID: 19290
		private Table __p;
	}
}
