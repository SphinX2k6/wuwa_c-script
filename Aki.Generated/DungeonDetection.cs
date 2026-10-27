using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C15 RID: 3093
	public struct DungeonDetection : IFlatbufferObject
	{
		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06006635 RID: 26165 RVA: 0x0021CD69 File Offset: 0x0021AF69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x0021CD76 File Offset: 0x0021AF76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0021CD80 File Offset: 0x0021AF80
		public static DungeonDetection GetRootAsDungeonDetection(ByteBuffer _bb)
		{
			return DungeonDetection.GetRootAsDungeonDetection(_bb, default(DungeonDetection));
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x0021CD9C File Offset: 0x0021AF9C
		public static DungeonDetection GetRootAsDungeonDetection(ByteBuffer _bb, DungeonDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x0021CDB9 File Offset: 0x0021AFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x0021CDC8 File Offset: 0x0021AFC8
		public DungeonDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x0600663B RID: 26171 RVA: 0x0021CDD8 File Offset: 0x0021AFD8
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

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x0021CE14 File Offset: 0x0021B014
		public int DungeonId
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

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x0600663D RID: 26173 RVA: 0x0021CE50 File Offset: 0x0021B050
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

		// Token: 0x0600663E RID: 26174 RVA: 0x0021CE87 File Offset: 0x0021B087
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x0021CE96 File Offset: 0x0021B096
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x0021CEB0 File Offset: 0x0021B0B0
		public int RoleId
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

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x0021CEF0 File Offset: 0x0021B0F0
		public int GuideId
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

		// Token: 0x06006642 RID: 26178 RVA: 0x0021CF30 File Offset: 0x0021B130
		public int LevelPlayList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x0021CF70 File Offset: 0x0021B170
		public int LevelPlayListLength
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

		// Token: 0x06006644 RID: 26180 RVA: 0x0021CF9C File Offset: 0x0021B19C
		public Span<int> GetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x0021CFAC File Offset: 0x0021B1AC
		public int[] GetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06006646 RID: 26182 RVA: 0x0021CFC4 File Offset: 0x0021B1C4
		public string InstanceSubTypeDescription
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

		// Token: 0x06006647 RID: 26183 RVA: 0x0021CFFC File Offset: 0x0021B1FC
		public Span<byte> GetInstanceSubTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0021D00C File Offset: 0x0021B20C
		public byte[] GetInstanceSubTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x0021D024 File Offset: 0x0021B224
		public int TypeDescription1
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600664A RID: 26186 RVA: 0x0021D064 File Offset: 0x0021B264
		public int Secondary
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

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x0021D0A4 File Offset: 0x0021B2A4
		public int MatType
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

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x0600664C RID: 26188 RVA: 0x0021D0E4 File Offset: 0x0021B2E4
		public string TypeDescription2
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

		// Token: 0x0600664D RID: 26189 RVA: 0x0021D11C File Offset: 0x0021B31C
		public Span<byte> GetTypeDescription2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x0021D12C File Offset: 0x0021B32C
		public byte[] GetTypeDescription2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x0021D144 File Offset: 0x0021B344
		public string AttributesDescriptionLock
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

		// Token: 0x06006650 RID: 26192 RVA: 0x0021D17C File Offset: 0x0021B37C
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x0021D18C File Offset: 0x0021B38C
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06006652 RID: 26194 RVA: 0x0021D1A4 File Offset: 0x0021B3A4
		public string AttributesDescriptionUnlock
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

		// Token: 0x06006653 RID: 26195 RVA: 0x0021D1DC File Offset: 0x0021B3DC
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x0021D1EC File Offset: 0x0021B3EC
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x0021D204 File Offset: 0x0021B404
		public string BigIcon
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

		// Token: 0x06006656 RID: 26198 RVA: 0x0021D23C File Offset: 0x0021B43C
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x0021D24C File Offset: 0x0021B44C
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06006658 RID: 26200 RVA: 0x0021D264 File Offset: 0x0021B464
		public string Icon
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

		// Token: 0x06006659 RID: 26201 RVA: 0x0021D29C File Offset: 0x0021B49C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x0021D2AC File Offset: 0x0021B4AC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x0021D2C4 File Offset: 0x0021B4C4
		public string LockBigIcon
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

		// Token: 0x0600665C RID: 26204 RVA: 0x0021D2FC File Offset: 0x0021B4FC
		public Span<byte> GetLockBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600665D RID: 26205 RVA: 0x0021D30C File Offset: 0x0021B50C
		public byte[] GetLockBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600665E RID: 26206 RVA: 0x0021D324 File Offset: 0x0021B524
		public string TemporaryIconUnLock
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

		// Token: 0x0600665F RID: 26207 RVA: 0x0021D35C File Offset: 0x0021B55C
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006660 RID: 26208 RVA: 0x0021D36C File Offset: 0x0021B56C
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x0021D384 File Offset: 0x0021B584
		public string TemporaryIconlock
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

		// Token: 0x06006662 RID: 26210 RVA: 0x0021D3BC File Offset: 0x0021B5BC
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x0021D3CC File Offset: 0x0021B5CC
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06006664 RID: 26212 RVA: 0x0021D3E4 File Offset: 0x0021B5E4
		public int ShowReward
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

		// Token: 0x06006665 RID: 26213 RVA: 0x0021D424 File Offset: 0x0021B624
		public DicIntInt? ShowRewardMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x0021D488 File Offset: 0x0021B688
		public int ShowRewardMapLength
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

		// Token: 0x06006667 RID: 26215 RVA: 0x0021D4B4 File Offset: 0x0021B6B4
		public DicIntInt? ShowRewardMapCalabash(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x0021D518 File Offset: 0x0021B718
		public int ShowRewardMapCalabashLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06006669 RID: 26217 RVA: 0x0021D544 File Offset: 0x0021B744
		public int BeginTimeStamp
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600666A RID: 26218 RVA: 0x0021D584 File Offset: 0x0021B784
		public int PreOpenId
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

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600666B RID: 26219 RVA: 0x0021D5C4 File Offset: 0x0021B7C4
		public int LockCon
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

		// Token: 0x0600666C RID: 26220 RVA: 0x0021D604 File Offset: 0x0021B804
		public int PhantomId(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600666D RID: 26221 RVA: 0x0021D644 File Offset: 0x0021B844
		public int PhantomIdLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x0021D670 File Offset: 0x0021B870
		public Span<int> GetPhantomIdBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x0021D680 File Offset: 0x0021B880
		public int[] GetPhantomIdArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06006670 RID: 26224 RVA: 0x0021D698 File Offset: 0x0021B898
		public int SubDungeonId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06006671 RID: 26225 RVA: 0x0021D6D8 File Offset: 0x0021B8D8
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06006672 RID: 26226 RVA: 0x0021D718 File Offset: 0x0021B918
		public string NewContent
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

		// Token: 0x06006673 RID: 26227 RVA: 0x0021D750 File Offset: 0x0021B950
		public Span<byte> GetNewContentBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x0021D760 File Offset: 0x0021B960
		public byte[] GetNewContentArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06006675 RID: 26229 RVA: 0x0021D778 File Offset: 0x0021B978
		public int DetectionTabType
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006676 RID: 26230 RVA: 0x0021D7B8 File Offset: 0x0021B9B8
		public int PhantomFetterGroup(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06006677 RID: 26231 RVA: 0x0021D7F8 File Offset: 0x0021B9F8
		public int PhantomFetterGroupLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006678 RID: 26232 RVA: 0x0021D824 File Offset: 0x0021BA24
		public Span<int> GetPhantomFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x06006679 RID: 26233 RVA: 0x0021D834 File Offset: 0x0021BA34
		public int[] GetPhantomFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x0021D84C File Offset: 0x0021BA4C
		public int WeaponFetterGroup(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600667B RID: 26235 RVA: 0x0021D88C File Offset: 0x0021BA8C
		public int WeaponFetterGroupLength
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

		// Token: 0x0600667C RID: 26236 RVA: 0x0021D8B8 File Offset: 0x0021BAB8
		public Span<int> GetWeaponFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0021D8C8 File Offset: 0x0021BAC8
		public int[] GetWeaponFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600667E RID: 26238 RVA: 0x0021D8E0 File Offset: 0x0021BAE0
		public int PeriodicityChallengeType
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600667F RID: 26239 RVA: 0x0021D920 File Offset: 0x0021BB20
		public int DetectionTitlePanel
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06006680 RID: 26240 RVA: 0x0021D960 File Offset: 0x0021BB60
		public string LeftBgSprite
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x0021D998 File Offset: 0x0021BB98
		public Span<byte> GetLeftBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x0021D9A8 File Offset: 0x0021BBA8
		public byte[] GetLeftBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x0021D9C0 File Offset: 0x0021BBC0
		public string RightBgSprite
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x0021D9F8 File Offset: 0x0021BBF8
		public Span<byte> GetRightBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x0021DA08 File Offset: 0x0021BC08
		public byte[] GetRightBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06006686 RID: 26246 RVA: 0x0021DA20 File Offset: 0x0021BC20
		public string LeftBgTexture
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x0021DA58 File Offset: 0x0021BC58
		public Span<byte> GetLeftBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x0021DA68 File Offset: 0x0021BC68
		public byte[] GetLeftBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x0021DA80 File Offset: 0x0021BC80
		public int JumpType
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x0600668A RID: 26250 RVA: 0x0021DAC0 File Offset: 0x0021BCC0
		public int InstanceDungeonEntranceId
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x0021DB00 File Offset: 0x0021BD00
		public int JumpWithSubDungeonId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x0021DB40 File Offset: 0x0021BD40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelPlayListIter()或GetLevelPlayListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelPlayList()
		{
			DungeonDetection dungeonDetection = this;
			return dungeonDetection.GetLevelPlayListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x0021DB64 File Offset: 0x0021BD64
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelPlayListIter()
		{
			DungeonDetection.<LevelPlayListIter>d__129 <LevelPlayListIter>d__ = new DungeonDetection.<LevelPlayListIter>d__129(-2);
			<LevelPlayListIter>d__.<>3__<>4__this = this;
			return <LevelPlayListIter>d__;
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x0021DB7C File Offset: 0x0021BD7C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomFetterGroupIter()或GetPhantomFetterGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomFetterGroup()
		{
			DungeonDetection dungeonDetection = this;
			return dungeonDetection.GetPhantomFetterGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x0021DBA0 File Offset: 0x0021BDA0
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomFetterGroupIter()
		{
			DungeonDetection.<PhantomFetterGroupIter>d__131 <PhantomFetterGroupIter>d__ = new DungeonDetection.<PhantomFetterGroupIter>d__131(-2);
			<PhantomFetterGroupIter>d__.<>3__<>4__this = this;
			return <PhantomFetterGroupIter>d__;
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x0021DBB8 File Offset: 0x0021BDB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomIdIter()或GetPhantomIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomId()
		{
			DungeonDetection dungeonDetection = this;
			return dungeonDetection.GetPhantomIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x0021DBDC File Offset: 0x0021BDDC
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomIdIter()
		{
			DungeonDetection.<PhantomIdIter>d__133 <PhantomIdIter>d__ = new DungeonDetection.<PhantomIdIter>d__133(-2);
			<PhantomIdIter>d__.<>3__<>4__this = this;
			return <PhantomIdIter>d__;
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x0021DBF4 File Offset: 0x0021BDF4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShowRewardMapFrozenDict()缓存字典，遍历请使用ShowRewardMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShowRewardMap()
		{
			return this.ShowRewardMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x0021DC4A File Offset: 0x0021BE4A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShowRewardMapIter()
		{
			DungeonDetection.<ShowRewardMapIter>d__135 <ShowRewardMapIter>d__ = new DungeonDetection.<ShowRewardMapIter>d__135(-2);
			<ShowRewardMapIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapIter>d__;
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x0021DC60 File Offset: 0x0021BE60
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShowRewardMapCalabashFrozenDict()缓存字典，遍历请使用ShowRewardMapCalabashIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShowRewardMapCalabash()
		{
			return this.ShowRewardMapCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x0021DCB6 File Offset: 0x0021BEB6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShowRewardMapCalabashIter()
		{
			DungeonDetection.<ShowRewardMapCalabashIter>d__137 <ShowRewardMapCalabashIter>d__ = new DungeonDetection.<ShowRewardMapCalabashIter>d__137(-2);
			<ShowRewardMapCalabashIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapCalabashIter>d__;
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x0021DCCC File Offset: 0x0021BECC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponFetterGroupIter()或GetWeaponFetterGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponFetterGroup()
		{
			DungeonDetection dungeonDetection = this;
			return dungeonDetection.GetWeaponFetterGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x0021DCF0 File Offset: 0x0021BEF0
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponFetterGroupIter()
		{
			DungeonDetection.<WeaponFetterGroupIter>d__139 <WeaponFetterGroupIter>d__ = new DungeonDetection.<WeaponFetterGroupIter>d__139(-2);
			<WeaponFetterGroupIter>d__.<>3__<>4__this = this;
			return <WeaponFetterGroupIter>d__;
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x0021DD08 File Offset: 0x0021BF08
		public int? GetShowRewardMap(int key)
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			int value;
			if (!this.ShowRewardMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006699 RID: 26265 RVA: 0x0021DD3C File Offset: 0x0021BF3C
		public int? GetShowRewardMapCalabash(int key)
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			int value;
			if (!this.ShowRewardMapCalabashCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x0021DD70 File Offset: 0x0021BF70
		private void EnsureShowRewardMapCacheIfNeeded()
		{
			if (this.ShowRewardMapCache != null)
			{
				return;
			}
			this.ShowRewardMapCache = this.ShowRewardMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600669B RID: 26267 RVA: 0x0021DDD8 File Offset: 0x0021BFD8
		private void EnsureShowRewardMapCalabashCacheIfNeeded()
		{
			if (this.ShowRewardMapCalabashCache != null)
			{
				return;
			}
			this.ShowRewardMapCalabashCache = this.ShowRewardMapCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600669C RID: 26268 RVA: 0x0021DE3E File Offset: 0x0021C03E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShowRewardMapFrozenDict(int key)
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			return this.ShowRewardMapCache;
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x0021DE4C File Offset: 0x0021C04C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShowRewardMapCalabashFrozenDict(int key)
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			return this.ShowRewardMapCalabashCache;
		}

		// Token: 0x04004C53 RID: 19539
		private Table __p;

		// Token: 0x04004C54 RID: 19540
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCache;

		// Token: 0x04004C55 RID: 19541
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCalabashCache;
	}
}
