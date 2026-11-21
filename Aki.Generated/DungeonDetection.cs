using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF8 RID: 3320
	public struct DungeonDetection : IFlatbufferObject
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06006C28 RID: 27688 RVA: 0x0023C2BE File Offset: 0x0023A4BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x0023C2CB File Offset: 0x0023A4CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C2A RID: 27690 RVA: 0x0023C2D4 File Offset: 0x0023A4D4
		public static DungeonDetection GetRootAsDungeonDetection(ByteBuffer _bb)
		{
			return DungeonDetection.GetRootAsDungeonDetection(_bb, default(DungeonDetection));
		}

		// Token: 0x06006C2B RID: 27691 RVA: 0x0023C2F0 File Offset: 0x0023A4F0
		public static DungeonDetection GetRootAsDungeonDetection(ByteBuffer _bb, DungeonDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C2C RID: 27692 RVA: 0x0023C30D File Offset: 0x0023A50D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C2D RID: 27693 RVA: 0x0023C31C File Offset: 0x0023A51C
		public DungeonDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06006C2E RID: 27694 RVA: 0x0023C32C File Offset: 0x0023A52C
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06006C2F RID: 27695 RVA: 0x0023C368 File Offset: 0x0023A568
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06006C30 RID: 27696 RVA: 0x0023C3A4 File Offset: 0x0023A5A4
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

		// Token: 0x06006C31 RID: 27697 RVA: 0x0023C3DB File Offset: 0x0023A5DB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006C32 RID: 27698 RVA: 0x0023C3EA File Offset: 0x0023A5EA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06006C33 RID: 27699 RVA: 0x0023C404 File Offset: 0x0023A604
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06006C34 RID: 27700 RVA: 0x0023C444 File Offset: 0x0023A644
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

		// Token: 0x06006C35 RID: 27701 RVA: 0x0023C484 File Offset: 0x0023A684
		public int LevelPlayList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06006C36 RID: 27702 RVA: 0x0023C4C4 File Offset: 0x0023A6C4
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

		// Token: 0x06006C37 RID: 27703 RVA: 0x0023C4F0 File Offset: 0x0023A6F0
		public Span<int> GetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006C38 RID: 27704 RVA: 0x0023C500 File Offset: 0x0023A700
		public int[] GetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06006C39 RID: 27705 RVA: 0x0023C518 File Offset: 0x0023A718
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

		// Token: 0x06006C3A RID: 27706 RVA: 0x0023C550 File Offset: 0x0023A750
		public Span<byte> GetInstanceSubTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006C3B RID: 27707 RVA: 0x0023C560 File Offset: 0x0023A760
		public byte[] GetInstanceSubTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06006C3C RID: 27708 RVA: 0x0023C578 File Offset: 0x0023A778
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

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x06006C3D RID: 27709 RVA: 0x0023C5B8 File Offset: 0x0023A7B8
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

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06006C3E RID: 27710 RVA: 0x0023C5F8 File Offset: 0x0023A7F8
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

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06006C3F RID: 27711 RVA: 0x0023C638 File Offset: 0x0023A838
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

		// Token: 0x06006C40 RID: 27712 RVA: 0x0023C670 File Offset: 0x0023A870
		public Span<byte> GetTypeDescription2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x0023C680 File Offset: 0x0023A880
		public byte[] GetTypeDescription2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06006C42 RID: 27714 RVA: 0x0023C698 File Offset: 0x0023A898
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

		// Token: 0x06006C43 RID: 27715 RVA: 0x0023C6D0 File Offset: 0x0023A8D0
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x0023C6E0 File Offset: 0x0023A8E0
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x0023C6F8 File Offset: 0x0023A8F8
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

		// Token: 0x06006C46 RID: 27718 RVA: 0x0023C730 File Offset: 0x0023A930
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006C47 RID: 27719 RVA: 0x0023C740 File Offset: 0x0023A940
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06006C48 RID: 27720 RVA: 0x0023C758 File Offset: 0x0023A958
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

		// Token: 0x06006C49 RID: 27721 RVA: 0x0023C790 File Offset: 0x0023A990
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006C4A RID: 27722 RVA: 0x0023C7A0 File Offset: 0x0023A9A0
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06006C4B RID: 27723 RVA: 0x0023C7B8 File Offset: 0x0023A9B8
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

		// Token: 0x06006C4C RID: 27724 RVA: 0x0023C7F0 File Offset: 0x0023A9F0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006C4D RID: 27725 RVA: 0x0023C800 File Offset: 0x0023AA00
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x0023C818 File Offset: 0x0023AA18
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

		// Token: 0x06006C4F RID: 27727 RVA: 0x0023C850 File Offset: 0x0023AA50
		public Span<byte> GetLockBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x0023C860 File Offset: 0x0023AA60
		public byte[] GetLockBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x0023C878 File Offset: 0x0023AA78
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

		// Token: 0x06006C52 RID: 27730 RVA: 0x0023C8B0 File Offset: 0x0023AAB0
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x0023C8C0 File Offset: 0x0023AAC0
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x0023C8D8 File Offset: 0x0023AAD8
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

		// Token: 0x06006C55 RID: 27733 RVA: 0x0023C910 File Offset: 0x0023AB10
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x0023C920 File Offset: 0x0023AB20
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06006C57 RID: 27735 RVA: 0x0023C938 File Offset: 0x0023AB38
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

		// Token: 0x06006C58 RID: 27736 RVA: 0x0023C978 File Offset: 0x0023AB78
		public DicIntInt? ShowRewardMap(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06006C59 RID: 27737 RVA: 0x0023C9DC File Offset: 0x0023ABDC
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

		// Token: 0x06006C5A RID: 27738 RVA: 0x0023CA08 File Offset: 0x0023AC08
		public DicIntInt? ShowRewardMapCalabash(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x0023CA6C File Offset: 0x0023AC6C
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

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x06006C5C RID: 27740 RVA: 0x0023CA98 File Offset: 0x0023AC98
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

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x0023CAD8 File Offset: 0x0023ACD8
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

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06006C5E RID: 27742 RVA: 0x0023CB18 File Offset: 0x0023AD18
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

		// Token: 0x06006C5F RID: 27743 RVA: 0x0023CB58 File Offset: 0x0023AD58
		public int PhantomId(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x0023CB98 File Offset: 0x0023AD98
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

		// Token: 0x06006C61 RID: 27745 RVA: 0x0023CBC4 File Offset: 0x0023ADC4
		public Span<int> GetPhantomIdBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x0023CBD4 File Offset: 0x0023ADD4
		public int[] GetPhantomIdArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x0023CBEC File Offset: 0x0023ADEC
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

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x06006C64 RID: 27748 RVA: 0x0023CC2C File Offset: 0x0023AE2C
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

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06006C65 RID: 27749 RVA: 0x0023CC6C File Offset: 0x0023AE6C
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

		// Token: 0x06006C66 RID: 27750 RVA: 0x0023CCA4 File Offset: 0x0023AEA4
		public Span<byte> GetNewContentBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x0023CCB4 File Offset: 0x0023AEB4
		public byte[] GetNewContentArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06006C68 RID: 27752 RVA: 0x0023CCCC File Offset: 0x0023AECC
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

		// Token: 0x06006C69 RID: 27753 RVA: 0x0023CD0C File Offset: 0x0023AF0C
		public int PhantomFetterGroup(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06006C6A RID: 27754 RVA: 0x0023CD4C File Offset: 0x0023AF4C
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

		// Token: 0x06006C6B RID: 27755 RVA: 0x0023CD78 File Offset: 0x0023AF78
		public Span<int> GetPhantomFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x0023CD88 File Offset: 0x0023AF88
		public int[] GetPhantomFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x0023CDA0 File Offset: 0x0023AFA0
		public int WeaponFetterGroup(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06006C6E RID: 27758 RVA: 0x0023CDE0 File Offset: 0x0023AFE0
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

		// Token: 0x06006C6F RID: 27759 RVA: 0x0023CE0C File Offset: 0x0023B00C
		public Span<int> GetWeaponFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x0023CE1C File Offset: 0x0023B01C
		public int[] GetWeaponFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x0023CE34 File Offset: 0x0023B034
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

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x06006C72 RID: 27762 RVA: 0x0023CE74 File Offset: 0x0023B074
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

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x0023CEB4 File Offset: 0x0023B0B4
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

		// Token: 0x06006C74 RID: 27764 RVA: 0x0023CEEC File Offset: 0x0023B0EC
		public Span<byte> GetLeftBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x0023CEFC File Offset: 0x0023B0FC
		public byte[] GetLeftBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06006C76 RID: 27766 RVA: 0x0023CF14 File Offset: 0x0023B114
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

		// Token: 0x06006C77 RID: 27767 RVA: 0x0023CF4C File Offset: 0x0023B14C
		public Span<byte> GetRightBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x0023CF5C File Offset: 0x0023B15C
		public byte[] GetRightBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06006C79 RID: 27769 RVA: 0x0023CF74 File Offset: 0x0023B174
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

		// Token: 0x06006C7A RID: 27770 RVA: 0x0023CFAC File Offset: 0x0023B1AC
		public Span<byte> GetLeftBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x0023CFBC File Offset: 0x0023B1BC
		public byte[] GetLeftBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06006C7C RID: 27772 RVA: 0x0023CFD4 File Offset: 0x0023B1D4
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x0023D014 File Offset: 0x0023B214
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

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06006C7E RID: 27774 RVA: 0x0023D054 File Offset: 0x0023B254
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

		// Token: 0x06006C7F RID: 27775 RVA: 0x0023D091 File Offset: 0x0023B291
		[NullableContext(1)]
		public int[] LevelPlayList()
		{
			return this.GetLevelPlayListArray();
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x0023D099 File Offset: 0x0023B299
		[NullableContext(1)]
		public IEnumerable<int> LevelPlayListIter()
		{
			DungeonDetection.<LevelPlayListIter>d__129 <LevelPlayListIter>d__ = new DungeonDetection.<LevelPlayListIter>d__129(-2);
			<LevelPlayListIter>d__.<>3__<>4__this = this;
			return <LevelPlayListIter>d__;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x0023D0AE File Offset: 0x0023B2AE
		[NullableContext(1)]
		public int[] PhantomFetterGroup()
		{
			return this.GetPhantomFetterGroupArray();
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x0023D0B6 File Offset: 0x0023B2B6
		[NullableContext(1)]
		public IEnumerable<int> PhantomFetterGroupIter()
		{
			DungeonDetection.<PhantomFetterGroupIter>d__131 <PhantomFetterGroupIter>d__ = new DungeonDetection.<PhantomFetterGroupIter>d__131(-2);
			<PhantomFetterGroupIter>d__.<>3__<>4__this = this;
			return <PhantomFetterGroupIter>d__;
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x0023D0CB File Offset: 0x0023B2CB
		[NullableContext(1)]
		public int[] PhantomId()
		{
			return this.GetPhantomIdArray();
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x0023D0D3 File Offset: 0x0023B2D3
		[NullableContext(1)]
		public IEnumerable<int> PhantomIdIter()
		{
			DungeonDetection.<PhantomIdIter>d__133 <PhantomIdIter>d__ = new DungeonDetection.<PhantomIdIter>d__133(-2);
			<PhantomIdIter>d__.<>3__<>4__this = this;
			return <PhantomIdIter>d__;
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x0023D0E8 File Offset: 0x0023B2E8
		[NullableContext(1)]
		public Dictionary<int, int> ShowRewardMap()
		{
			return this.ShowRewardMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0023D13E File Offset: 0x0023B33E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShowRewardMapIter()
		{
			DungeonDetection.<ShowRewardMapIter>d__135 <ShowRewardMapIter>d__ = new DungeonDetection.<ShowRewardMapIter>d__135(-2);
			<ShowRewardMapIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapIter>d__;
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x0023D154 File Offset: 0x0023B354
		[NullableContext(1)]
		public Dictionary<int, int> ShowRewardMapCalabash()
		{
			return this.ShowRewardMapCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x0023D1AA File Offset: 0x0023B3AA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShowRewardMapCalabashIter()
		{
			DungeonDetection.<ShowRewardMapCalabashIter>d__137 <ShowRewardMapCalabashIter>d__ = new DungeonDetection.<ShowRewardMapCalabashIter>d__137(-2);
			<ShowRewardMapCalabashIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapCalabashIter>d__;
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x0023D1BF File Offset: 0x0023B3BF
		[NullableContext(1)]
		public int[] WeaponFetterGroup()
		{
			return this.GetWeaponFetterGroupArray();
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x0023D1C7 File Offset: 0x0023B3C7
		[NullableContext(1)]
		public IEnumerable<int> WeaponFetterGroupIter()
		{
			DungeonDetection.<WeaponFetterGroupIter>d__139 <WeaponFetterGroupIter>d__ = new DungeonDetection.<WeaponFetterGroupIter>d__139(-2);
			<WeaponFetterGroupIter>d__.<>3__<>4__this = this;
			return <WeaponFetterGroupIter>d__;
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x0023D1DC File Offset: 0x0023B3DC
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

		// Token: 0x06006C8C RID: 27788 RVA: 0x0023D210 File Offset: 0x0023B410
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

		// Token: 0x06006C8D RID: 27789 RVA: 0x0023D244 File Offset: 0x0023B444
		private void EnsureShowRewardMapCacheIfNeeded()
		{
			if (this.ShowRewardMapCache != null)
			{
				return;
			}
			this.ShowRewardMapCache = this.ShowRewardMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0023D2AC File Offset: 0x0023B4AC
		private void EnsureShowRewardMapCalabashCacheIfNeeded()
		{
			if (this.ShowRewardMapCalabashCache != null)
			{
				return;
			}
			this.ShowRewardMapCalabashCache = this.ShowRewardMapCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x0023D312 File Offset: 0x0023B512
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShowRewardMapFrozenDict()
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			return this.ShowRewardMapCache;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x0023D320 File Offset: 0x0023B520
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShowRewardMapCalabashFrozenDict()
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			return this.ShowRewardMapCalabashCache;
		}

		// Token: 0x04005236 RID: 21046
		private Table __p;

		// Token: 0x04005237 RID: 21047
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCache;

		// Token: 0x04005238 RID: 21048
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCalabashCache;
	}
}
