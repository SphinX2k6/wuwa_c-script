using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001018 RID: 4120
	public struct PinballMonsterType : IFlatbufferObject
	{
		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600B5C5 RID: 46533 RVA: 0x002DFFC0 File Offset: 0x002DE1C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x002DFFCD File Offset: 0x002DE1CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x002DFFD4 File Offset: 0x002DE1D4
		public static PinballMonsterType GetRootAsPinballMonsterType(ByteBuffer _bb)
		{
			return PinballMonsterType.GetRootAsPinballMonsterType(_bb, default(PinballMonsterType));
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x002DFFF0 File Offset: 0x002DE1F0
		public static PinballMonsterType GetRootAsPinballMonsterType(ByteBuffer _bb, PinballMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x002E000D File Offset: 0x002DE20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x002E001C File Offset: 0x002DE21C
		public PinballMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600B5CB RID: 46539 RVA: 0x002E002C File Offset: 0x002DE22C
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

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x002E0068 File Offset: 0x002DE268
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

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600B5CD RID: 46541 RVA: 0x002E00A4 File Offset: 0x002DE2A4
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

		// Token: 0x0600B5CE RID: 46542 RVA: 0x002E00DB File Offset: 0x002DE2DB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x002E00EA File Offset: 0x002DE2EA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x002E0104 File Offset: 0x002DE304
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

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600B5D1 RID: 46545 RVA: 0x002E0144 File Offset: 0x002DE344
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

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600B5D2 RID: 46546 RVA: 0x002E0184 File Offset: 0x002DE384
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

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x002E01BC File Offset: 0x002DE3BC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x002E01CC File Offset: 0x002DE3CC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600B5D5 RID: 46549 RVA: 0x002E01E4 File Offset: 0x002DE3E4
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

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x002E021C File Offset: 0x002DE41C
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x002E022C File Offset: 0x002DE42C
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600B5D8 RID: 46552 RVA: 0x002E0244 File Offset: 0x002DE444
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

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x002E027C File Offset: 0x002DE47C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x002E028C File Offset: 0x002DE48C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600B5DB RID: 46555 RVA: 0x002E02A4 File Offset: 0x002DE4A4
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

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600B5DC RID: 46556 RVA: 0x002E02E4 File Offset: 0x002DE4E4
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

		// Token: 0x0600B5DD RID: 46557 RVA: 0x002E031C File Offset: 0x002DE51C
		public Span<byte> GetSpineBgBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B5DE RID: 46558 RVA: 0x002E032C File Offset: 0x002DE52C
		public byte[] GetSpineBgArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600B5DF RID: 46559 RVA: 0x002E0344 File Offset: 0x002DE544
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

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x002E037C File Offset: 0x002DE57C
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x002E038C File Offset: 0x002DE58C
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600B5E2 RID: 46562 RVA: 0x002E03A4 File Offset: 0x002DE5A4
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

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x002E03DC File Offset: 0x002DE5DC
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x002E03EC File Offset: 0x002DE5EC
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x002E0404 File Offset: 0x002DE604
		public int DisplayedSkillList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600B5E6 RID: 46566 RVA: 0x002E0444 File Offset: 0x002DE644
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

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x002E0470 File Offset: 0x002DE670
		public Span<int> GetDisplayedSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x002E0480 File Offset: 0x002DE680
		public int[] GetDisplayedSkillListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x002E0498 File Offset: 0x002DE698
		[NullableContext(1)]
		public int[] DisplayedSkillList()
		{
			return this.GetDisplayedSkillListArray();
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x002E04A0 File Offset: 0x002DE6A0
		[NullableContext(1)]
		public IEnumerable<int> DisplayedSkillListIter()
		{
			PinballMonsterType.<DisplayedSkillListIter>d__52 <DisplayedSkillListIter>d__ = new PinballMonsterType.<DisplayedSkillListIter>d__52(-2);
			<DisplayedSkillListIter>d__.<>3__<>4__this = this;
			return <DisplayedSkillListIter>d__;
		}

		// Token: 0x040055E2 RID: 21986
		private Table __p;
	}
}
