using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101B RID: 4123
	public struct PinballRoleConfig : IFlatbufferObject
	{
		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600B612 RID: 46610 RVA: 0x002E09EA File Offset: 0x002DEBEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x002E09F7 File Offset: 0x002DEBF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x002E0A00 File Offset: 0x002DEC00
		public static PinballRoleConfig GetRootAsPinballRoleConfig(ByteBuffer _bb)
		{
			return PinballRoleConfig.GetRootAsPinballRoleConfig(_bb, default(PinballRoleConfig));
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x002E0A1C File Offset: 0x002DEC1C
		public static PinballRoleConfig GetRootAsPinballRoleConfig(ByteBuffer _bb, PinballRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x002E0A39 File Offset: 0x002DEC39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x002E0A48 File Offset: 0x002DEC48
		public PinballRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600B618 RID: 46616 RVA: 0x002E0A58 File Offset: 0x002DEC58
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

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600B619 RID: 46617 RVA: 0x002E0A94 File Offset: 0x002DEC94
		public int SubId
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

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600B61A RID: 46618 RVA: 0x002E0AD0 File Offset: 0x002DECD0
		public int ActivityId
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

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600B61B RID: 46619 RVA: 0x002E0B0C File Offset: 0x002DED0C
		public int InitLevelId
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

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600B61C RID: 46620 RVA: 0x002E0B4C File Offset: 0x002DED4C
		public int GradeUpGroup
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

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0600B61D RID: 46621 RVA: 0x002E0B8C File Offset: 0x002DED8C
		public int RoleId
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

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600B61E RID: 46622 RVA: 0x002E0BCC File Offset: 0x002DEDCC
		public int QualityId
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

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600B61F RID: 46623 RVA: 0x002E0C0C File Offset: 0x002DEE0C
		public string AttributesDescription
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

		// Token: 0x0600B620 RID: 46624 RVA: 0x002E0C44 File Offset: 0x002DEE44
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x002E0C54 File Offset: 0x002DEE54
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600B622 RID: 46626 RVA: 0x002E0C6C File Offset: 0x002DEE6C
		public int WeaponType
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

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x002E0CAC File Offset: 0x002DEEAC
		public int InitWeapon
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

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0600B624 RID: 46628 RVA: 0x002E0CEC File Offset: 0x002DEEEC
		public int PersonWeaponType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600B625 RID: 46629 RVA: 0x002E0D2C File Offset: 0x002DEF2C
		public int Bd
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

		// Token: 0x0600B626 RID: 46630 RVA: 0x002E0D6C File Offset: 0x002DEF6C
		public int PinballClass(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600B627 RID: 46631 RVA: 0x002E0DAC File Offset: 0x002DEFAC
		public int PinballClassLength
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

		// Token: 0x0600B628 RID: 46632 RVA: 0x002E0DD8 File Offset: 0x002DEFD8
		public Span<int> GetPinballClassBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x002E0DE8 File Offset: 0x002DEFE8
		public int[] GetPinballClassArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x002E0E00 File Offset: 0x002DF000
		public int SkillDisplayList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600B62B RID: 46635 RVA: 0x002E0E40 File Offset: 0x002DF040
		public int SkillDisplayListLength
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

		// Token: 0x0600B62C RID: 46636 RVA: 0x002E0E6C File Offset: 0x002DF06C
		public Span<int> GetSkillDisplayListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x002E0E7C File Offset: 0x002DF07C
		public int[] GetSkillDisplayListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600B62E RID: 46638 RVA: 0x002E0E94 File Offset: 0x002DF094
		public bool IsTrail
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600B62F RID: 46639 RVA: 0x002E0ED4 File Offset: 0x002DF0D4
		public string SpineAtlasPath
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

		// Token: 0x0600B630 RID: 46640 RVA: 0x002E0F0C File Offset: 0x002DF10C
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x002E0F1C File Offset: 0x002DF11C
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600B632 RID: 46642 RVA: 0x002E0F34 File Offset: 0x002DF134
		public string SpineSkeletonDataPath
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

		// Token: 0x0600B633 RID: 46643 RVA: 0x002E0F6C File Offset: 0x002DF16C
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x002E0F7C File Offset: 0x002DF17C
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x002E0F94 File Offset: 0x002DF194
		public string SmallIcon
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

		// Token: 0x0600B636 RID: 46646 RVA: 0x002E0FCC File Offset: 0x002DF1CC
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x002E0FDC File Offset: 0x002DF1DC
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600B638 RID: 46648 RVA: 0x002E0FF4 File Offset: 0x002DF1F4
		public string MiddleIcon
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

		// Token: 0x0600B639 RID: 46649 RVA: 0x002E102C File Offset: 0x002DF22C
		public Span<byte> GetMiddleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600B63A RID: 46650 RVA: 0x002E103C File Offset: 0x002DF23C
		public byte[] GetMiddleIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x002E1054 File Offset: 0x002DF254
		public string Icon
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

		// Token: 0x0600B63C RID: 46652 RVA: 0x002E108C File Offset: 0x002DF28C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x002E109C File Offset: 0x002DF29C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600B63E RID: 46654 RVA: 0x002E10B4 File Offset: 0x002DF2B4
		public string BigIcon
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

		// Token: 0x0600B63F RID: 46655 RVA: 0x002E10EC File Offset: 0x002DF2EC
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x002E10FC File Offset: 0x002DF2FC
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600B641 RID: 46657 RVA: 0x002E1114 File Offset: 0x002DF314
		public string CircleIcon
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

		// Token: 0x0600B642 RID: 46658 RVA: 0x002E114C File Offset: 0x002DF34C
		public Span<byte> GetCircleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x002E115C File Offset: 0x002DF35C
		public byte[] GetCircleIconArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600B644 RID: 46660 RVA: 0x002E1174 File Offset: 0x002DF374
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600B645 RID: 46661 RVA: 0x002E11B4 File Offset: 0x002DF3B4
		public int TemplateId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600B646 RID: 46662 RVA: 0x002E11F4 File Offset: 0x002DF3F4
		public int SimpleCombatSubtypeId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x002E1234 File Offset: 0x002DF434
		public string FailBubbleTxts(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600B648 RID: 46664 RVA: 0x002E1270 File Offset: 0x002DF470
		public int FailBubbleTxtsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x002E129C File Offset: 0x002DF49C
		public string RoleSkillIcon
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

		// Token: 0x0600B64A RID: 46666 RVA: 0x002E12D4 File Offset: 0x002DF4D4
		public Span<byte> GetRoleSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x002E12E4 File Offset: 0x002DF4E4
		public byte[] GetRoleSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x002E12FC File Offset: 0x002DF4FC
		public string RoleSkillReleaseIcon
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x002E1334 File Offset: 0x002DF534
		public Span<byte> GetRoleSkillReleaseIconBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x002E1344 File Offset: 0x002DF544
		public byte[] GetRoleSkillReleaseIconArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600B64F RID: 46671 RVA: 0x002E135C File Offset: 0x002DF55C
		public string RoleSkillReleaseDesc
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x002E1394 File Offset: 0x002DF594
		public Span<byte> GetRoleSkillReleaseDescBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x002E13A4 File Offset: 0x002DF5A4
		public byte[] GetRoleSkillReleaseDescArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0600B652 RID: 46674 RVA: 0x002E13BC File Offset: 0x002DF5BC
		public int KscEntityId
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x002E13FC File Offset: 0x002DF5FC
		public int BornBuff(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0600B654 RID: 46676 RVA: 0x002E143C File Offset: 0x002DF63C
		public int BornBuffLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x002E1468 File Offset: 0x002DF668
		public Span<int> GetBornBuffBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x002E1478 File Offset: 0x002DF678
		public int[] GetBornBuffArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x002E1490 File Offset: 0x002DF690
		public int LeaderBuff(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0600B658 RID: 46680 RVA: 0x002E14D0 File Offset: 0x002DF6D0
		public int LeaderBuffLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x002E14FC File Offset: 0x002DF6FC
		public Span<int> GetLeaderBuffBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x002E150C File Offset: 0x002DF70C
		public int[] GetLeaderBuffArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x002E1524 File Offset: 0x002DF724
		[NullableContext(1)]
		public int[] BornBuff()
		{
			return this.GetBornBuffArray();
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x002E152C File Offset: 0x002DF72C
		[NullableContext(1)]
		public IEnumerable<int> BornBuffIter()
		{
			PinballRoleConfig.<BornBuffIter>d__108 <BornBuffIter>d__ = new PinballRoleConfig.<BornBuffIter>d__108(-2);
			<BornBuffIter>d__.<>3__<>4__this = this;
			return <BornBuffIter>d__;
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x002E1541 File Offset: 0x002DF741
		[NullableContext(1)]
		public string[] FailBubbleTxts()
		{
			return this.FailBubbleTxtsIter().ToArray<string>();
		}

		// Token: 0x0600B65E RID: 46686 RVA: 0x002E154E File Offset: 0x002DF74E
		[NullableContext(1)]
		public IEnumerable<string> FailBubbleTxtsIter()
		{
			PinballRoleConfig.<FailBubbleTxtsIter>d__110 <FailBubbleTxtsIter>d__ = new PinballRoleConfig.<FailBubbleTxtsIter>d__110(-2);
			<FailBubbleTxtsIter>d__.<>3__<>4__this = this;
			return <FailBubbleTxtsIter>d__;
		}

		// Token: 0x0600B65F RID: 46687 RVA: 0x002E1563 File Offset: 0x002DF763
		[NullableContext(1)]
		public int[] LeaderBuff()
		{
			return this.GetLeaderBuffArray();
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x002E156B File Offset: 0x002DF76B
		[NullableContext(1)]
		public IEnumerable<int> LeaderBuffIter()
		{
			PinballRoleConfig.<LeaderBuffIter>d__112 <LeaderBuffIter>d__ = new PinballRoleConfig.<LeaderBuffIter>d__112(-2);
			<LeaderBuffIter>d__.<>3__<>4__this = this;
			return <LeaderBuffIter>d__;
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x002E1580 File Offset: 0x002DF780
		[NullableContext(1)]
		public int[] PinballClass()
		{
			return this.GetPinballClassArray();
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x002E1588 File Offset: 0x002DF788
		[NullableContext(1)]
		public IEnumerable<int> PinballClassIter()
		{
			PinballRoleConfig.<PinballClassIter>d__114 <PinballClassIter>d__ = new PinballRoleConfig.<PinballClassIter>d__114(-2);
			<PinballClassIter>d__.<>3__<>4__this = this;
			return <PinballClassIter>d__;
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x002E159D File Offset: 0x002DF79D
		[NullableContext(1)]
		public int[] SkillDisplayList()
		{
			return this.GetSkillDisplayListArray();
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x002E15A5 File Offset: 0x002DF7A5
		[NullableContext(1)]
		public IEnumerable<int> SkillDisplayListIter()
		{
			PinballRoleConfig.<SkillDisplayListIter>d__116 <SkillDisplayListIter>d__ = new PinballRoleConfig.<SkillDisplayListIter>d__116(-2);
			<SkillDisplayListIter>d__.<>3__<>4__this = this;
			return <SkillDisplayListIter>d__;
		}

		// Token: 0x040055E5 RID: 21989
		private Table __p;
	}
}
