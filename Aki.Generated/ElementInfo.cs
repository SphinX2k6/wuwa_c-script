using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C27 RID: 3111
	public struct ElementInfo : IFlatbufferObject
	{
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x00220C19 File Offset: 0x0021EE19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x00220C26 File Offset: 0x0021EE26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x00220C30 File Offset: 0x0021EE30
		public static ElementInfo GetRootAsElementInfo(ByteBuffer _bb)
		{
			return ElementInfo.GetRootAsElementInfo(_bb, default(ElementInfo));
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x00220C4C File Offset: 0x0021EE4C
		public static ElementInfo GetRootAsElementInfo(ByteBuffer _bb, ElementInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x00220C69 File Offset: 0x0021EE69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x00220C78 File Offset: 0x0021EE78
		public ElementInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060067F5 RID: 26613 RVA: 0x00220C88 File Offset: 0x0021EE88
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

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060067F6 RID: 26614 RVA: 0x00220CC4 File Offset: 0x0021EEC4
		public string Describe
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

		// Token: 0x060067F7 RID: 26615 RVA: 0x00220CFB File Offset: 0x0021EEFB
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x00220D0A File Offset: 0x0021EF0A
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x00220D24 File Offset: 0x0021EF24
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

		// Token: 0x060067FA RID: 26618 RVA: 0x00220D5B File Offset: 0x0021EF5B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x00220D6A File Offset: 0x0021EF6A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060067FC RID: 26620 RVA: 0x00220D84 File Offset: 0x0021EF84
		public string Icon
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

		// Token: 0x060067FD RID: 26621 RVA: 0x00220DBC File Offset: 0x0021EFBC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x00220DCC File Offset: 0x0021EFCC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060067FF RID: 26623 RVA: 0x00220DE4 File Offset: 0x0021EFE4
		public string Icon2
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

		// Token: 0x06006800 RID: 26624 RVA: 0x00220E1C File Offset: 0x0021F01C
		public Span<byte> GetIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x00220E2C File Offset: 0x0021F02C
		public byte[] GetIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06006802 RID: 26626 RVA: 0x00220E44 File Offset: 0x0021F044
		public string Icon3
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

		// Token: 0x06006803 RID: 26627 RVA: 0x00220E7C File Offset: 0x0021F07C
		public Span<byte> GetIcon3Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x00220E8C File Offset: 0x0021F08C
		public byte[] GetIcon3Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00220EA4 File Offset: 0x0021F0A4
		public string Icon4
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

		// Token: 0x06006806 RID: 26630 RVA: 0x00220EDC File Offset: 0x0021F0DC
		public Span<byte> GetIcon4Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x00220EEC File Offset: 0x0021F0EC
		public byte[] GetIcon4Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06006808 RID: 26632 RVA: 0x00220F04 File Offset: 0x0021F104
		public string Icon4Pure
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

		// Token: 0x06006809 RID: 26633 RVA: 0x00220F3C File Offset: 0x0021F13C
		public Span<byte> GetIcon4PureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00220F4C File Offset: 0x0021F14C
		public byte[] GetIcon4PureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x00220F64 File Offset: 0x0021F164
		public string Icon5
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

		// Token: 0x0600680C RID: 26636 RVA: 0x00220F9C File Offset: 0x0021F19C
		public Span<byte> GetIcon5Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x00220FAC File Offset: 0x0021F1AC
		public byte[] GetIcon5Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600680E RID: 26638 RVA: 0x00220FC4 File Offset: 0x0021F1C4
		public string Icon6
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

		// Token: 0x0600680F RID: 26639 RVA: 0x00220FFC File Offset: 0x0021F1FC
		public Span<byte> GetIcon6Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x0022100C File Offset: 0x0021F20C
		public byte[] GetIcon6Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x00221024 File Offset: 0x0021F224
		public string Icon7
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

		// Token: 0x06006812 RID: 26642 RVA: 0x0022105C File Offset: 0x0021F25C
		public Span<byte> GetIcon7Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x0022106C File Offset: 0x0021F26C
		public byte[] GetIcon7Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06006814 RID: 26644 RVA: 0x00221084 File Offset: 0x0021F284
		public string ElementChangeTexture
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

		// Token: 0x06006815 RID: 26645 RVA: 0x002210BC File Offset: 0x0021F2BC
		public Span<byte> GetElementChangeTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x002210CC File Offset: 0x0021F2CC
		public byte[] GetElementChangeTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x002210E4 File Offset: 0x0021F2E4
		public string ElementEffectColor
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x0022111C File Offset: 0x0021F31C
		public Span<byte> GetElementEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x0022112C File Offset: 0x0021F32C
		public byte[] GetElementEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x0600681A RID: 26650 RVA: 0x00221144 File Offset: 0x0021F344
		public string ElementColor
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x0022117C File Offset: 0x0021F37C
		public Span<byte> GetElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x0022118C File Offset: 0x0021F38C
		public byte[] GetElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x0600681D RID: 26653 RVA: 0x002211A4 File Offset: 0x0021F3A4
		public string SkillTreeEffectColor
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x002211DC File Offset: 0x0021F3DC
		public Span<byte> GetSkillTreeEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x002211EC File Offset: 0x0021F3EC
		public byte[] GetSkillTreeEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x00221204 File Offset: 0x0021F404
		public string SkillTreeIconColor
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

		// Token: 0x06006821 RID: 26657 RVA: 0x0022123C File Offset: 0x0021F43C
		public Span<byte> GetSkillTreeIconColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x0022124C File Offset: 0x0021F44C
		public byte[] GetSkillTreeIconColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06006823 RID: 26659 RVA: 0x00221264 File Offset: 0x0021F464
		public string SkillTreeLineColor
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

		// Token: 0x06006824 RID: 26660 RVA: 0x0022129C File Offset: 0x0021F49C
		public Span<byte> GetSkillTreeLineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x002212AC File Offset: 0x0021F4AC
		public byte[] GetSkillTreeLineColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x002212C4 File Offset: 0x0021F4C4
		public string Effect
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

		// Token: 0x06006827 RID: 26663 RVA: 0x002212FC File Offset: 0x0021F4FC
		public Span<byte> GetEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x0022130C File Offset: 0x0021F50C
		public byte[] GetEffectArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x06006829 RID: 26665 RVA: 0x00221324 File Offset: 0x0021F524
		public string EffectTexturePath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x0022135C File Offset: 0x0021F55C
		public Span<byte> GetEffectTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x0022136C File Offset: 0x0021F56C
		public byte[] GetEffectTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x0600682C RID: 26668 RVA: 0x00221384 File Offset: 0x0021F584
		public string GachaElementBgSpritePath
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x002213BC File Offset: 0x0021F5BC
		public Span<byte> GetGachaElementBgSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x002213CC File Offset: 0x0021F5CC
		public byte[] GetGachaElementBgSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x0600682F RID: 26671 RVA: 0x002213E4 File Offset: 0x0021F5E4
		public string GachaSpritePath
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x0022141C File Offset: 0x0021F61C
		public Span<byte> GetGachaSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x0022142C File Offset: 0x0021F62C
		public byte[] GetGachaSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x06006832 RID: 26674 RVA: 0x00221444 File Offset: 0x0021F644
		public string UltimateSkillColor
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x0022147C File Offset: 0x0021F67C
		public Span<byte> GetUltimateSkillColorBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x0022148C File Offset: 0x0021F68C
		public byte[] GetUltimateSkillColorArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x002214A4 File Offset: 0x0021F6A4
		public string SkillEffectColor
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x002214DC File Offset: 0x0021F6DC
		public Span<byte> GetSkillEffectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x002214EC File Offset: 0x0021F6EC
		public byte[] GetSkillEffectColorArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06006838 RID: 26680 RVA: 0x00221504 File Offset: 0x0021F704
		public string SkillButtonEffectPath
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x0022153C File Offset: 0x0021F73C
		public Span<byte> GetSkillButtonEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x0022154C File Offset: 0x0021F74C
		public byte[] GetSkillButtonEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x00221564 File Offset: 0x0021F764
		public string ElementBallEffectPath
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x0022159C File Offset: 0x0021F79C
		public Span<byte> GetElementBallEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600683D RID: 26685 RVA: 0x002215AC File Offset: 0x0021F7AC
		public byte[] GetElementBallEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x002215C4 File Offset: 0x0021F7C4
		public string SpriteIcon1
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600683F RID: 26687 RVA: 0x002215FC File Offset: 0x0021F7FC
		public Span<byte> GetSpriteIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06006840 RID: 26688 RVA: 0x0022160C File Offset: 0x0021F80C
		public byte[] GetSpriteIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06006841 RID: 26689 RVA: 0x00221624 File Offset: 0x0021F824
		public string AudioEvent
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x0022165C File Offset: 0x0021F85C
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x0022166C File Offset: 0x0021F86C
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C67 RID: 19559
		private Table __p;
	}
}
