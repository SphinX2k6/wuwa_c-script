using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B2 RID: 4274
	public struct SilentAreaDetection : IFlatbufferObject
	{
		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600D265 RID: 53861 RVA: 0x003104F8 File Offset: 0x0030E6F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D266 RID: 53862 RVA: 0x00310505 File Offset: 0x0030E705
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D267 RID: 53863 RVA: 0x0031050C File Offset: 0x0030E70C
		public static SilentAreaDetection GetRootAsSilentAreaDetection(ByteBuffer _bb)
		{
			return SilentAreaDetection.GetRootAsSilentAreaDetection(_bb, default(SilentAreaDetection));
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x00310528 File Offset: 0x0030E728
		public static SilentAreaDetection GetRootAsSilentAreaDetection(ByteBuffer _bb, SilentAreaDetection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x00310545 File Offset: 0x0030E745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x00310554 File Offset: 0x0030E754
		public SilentAreaDetection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600D26B RID: 53867 RVA: 0x00310564 File Offset: 0x0030E764
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

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600D26C RID: 53868 RVA: 0x003105A0 File Offset: 0x0030E7A0
		public string Name
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

		// Token: 0x0600D26D RID: 53869 RVA: 0x003105D7 File Offset: 0x0030E7D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x003105E6 File Offset: 0x0030E7E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600D26F RID: 53871 RVA: 0x00310600 File Offset: 0x0030E800
		public int GuideId
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

		// Token: 0x0600D270 RID: 53872 RVA: 0x0031063C File Offset: 0x0030E83C
		public int LevelPlayList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600D271 RID: 53873 RVA: 0x0031067C File Offset: 0x0030E87C
		public int LevelPlayListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D272 RID: 53874 RVA: 0x003106A8 File Offset: 0x0030E8A8
		public Span<int> GetLevelPlayListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600D273 RID: 53875 RVA: 0x003106B8 File Offset: 0x0030E8B8
		public int[] GetLevelPlayListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600D274 RID: 53876 RVA: 0x003106D0 File Offset: 0x0030E8D0
		public string InstanceSubTypeDescription
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

		// Token: 0x0600D275 RID: 53877 RVA: 0x00310708 File Offset: 0x0030E908
		public Span<byte> GetInstanceSubTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x00310718 File Offset: 0x0030E918
		public byte[] GetInstanceSubTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600D277 RID: 53879 RVA: 0x00310730 File Offset: 0x0030E930
		public int DangerType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600D278 RID: 53880 RVA: 0x00310770 File Offset: 0x0030E970
		public int Secondary
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

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600D279 RID: 53881 RVA: 0x003107B0 File Offset: 0x0030E9B0
		public int TypeDescription2
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

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600D27A RID: 53882 RVA: 0x003107F0 File Offset: 0x0030E9F0
		public int MatType
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

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600D27B RID: 53883 RVA: 0x00310830 File Offset: 0x0030EA30
		public string AttributesDescriptionLock
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

		// Token: 0x0600D27C RID: 53884 RVA: 0x00310868 File Offset: 0x0030EA68
		public Span<byte> GetAttributesDescriptionLockBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D27D RID: 53885 RVA: 0x00310878 File Offset: 0x0030EA78
		public byte[] GetAttributesDescriptionLockArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600D27E RID: 53886 RVA: 0x00310890 File Offset: 0x0030EA90
		public string AttributesDescriptionUnlock
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

		// Token: 0x0600D27F RID: 53887 RVA: 0x003108C8 File Offset: 0x0030EAC8
		public Span<byte> GetAttributesDescriptionUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x003108D8 File Offset: 0x0030EAD8
		public byte[] GetAttributesDescriptionUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x003108F0 File Offset: 0x0030EAF0
		public string BigIcon
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

		// Token: 0x0600D282 RID: 53890 RVA: 0x00310928 File Offset: 0x0030EB28
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x00310938 File Offset: 0x0030EB38
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600D284 RID: 53892 RVA: 0x00310950 File Offset: 0x0030EB50
		public string Icon
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

		// Token: 0x0600D285 RID: 53893 RVA: 0x00310988 File Offset: 0x0030EB88
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00310998 File Offset: 0x0030EB98
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600D287 RID: 53895 RVA: 0x003109B0 File Offset: 0x0030EBB0
		public string LockBigIcon
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

		// Token: 0x0600D288 RID: 53896 RVA: 0x003109E8 File Offset: 0x0030EBE8
		public Span<byte> GetLockBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x003109F8 File Offset: 0x0030EBF8
		public byte[] GetLockBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600D28A RID: 53898 RVA: 0x00310A10 File Offset: 0x0030EC10
		public string TemporaryIconUnLock
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

		// Token: 0x0600D28B RID: 53899 RVA: 0x00310A48 File Offset: 0x0030EC48
		public Span<byte> GetTemporaryIconUnLockBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x00310A58 File Offset: 0x0030EC58
		public byte[] GetTemporaryIconUnLockArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600D28D RID: 53901 RVA: 0x00310A70 File Offset: 0x0030EC70
		public string TemporaryIconlock
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

		// Token: 0x0600D28E RID: 53902 RVA: 0x00310AA8 File Offset: 0x0030ECA8
		public Span<byte> GetTemporaryIconlockBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600D28F RID: 53903 RVA: 0x00310AB8 File Offset: 0x0030ECB8
		public byte[] GetTemporaryIconlockArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600D290 RID: 53904 RVA: 0x00310AD0 File Offset: 0x0030ECD0
		public int ShowReward
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D291 RID: 53905 RVA: 0x00310B10 File Offset: 0x0030ED10
		public DicIntInt? ShowRewardMap(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600D292 RID: 53906 RVA: 0x00310B74 File Offset: 0x0030ED74
		public int ShowRewardMapLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x00310BA0 File Offset: 0x0030EDA0
		public DicIntInt? ShowRewardMapCalabash(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600D294 RID: 53908 RVA: 0x00310C04 File Offset: 0x0030EE04
		public int ShowRewardMapCalabashLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600D295 RID: 53909 RVA: 0x00310C30 File Offset: 0x0030EE30
		public int BeginTimeStamp
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600D296 RID: 53910 RVA: 0x00310C70 File Offset: 0x0030EE70
		public int PreOpenId
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

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600D297 RID: 53911 RVA: 0x00310CB0 File Offset: 0x0030EEB0
		public int MarkId
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

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600D298 RID: 53912 RVA: 0x00310CF0 File Offset: 0x0030EEF0
		public int LockCon
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

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600D299 RID: 53913 RVA: 0x00310D30 File Offset: 0x0030EF30
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x00310D70 File Offset: 0x0030EF70
		public int PhantomId(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600D29B RID: 53915 RVA: 0x00310DB0 File Offset: 0x0030EFB0
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

		// Token: 0x0600D29C RID: 53916 RVA: 0x00310DDC File Offset: 0x0030EFDC
		public Span<int> GetPhantomIdBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x00310DEC File Offset: 0x0030EFEC
		public int[] GetPhantomIdArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600D29E RID: 53918 RVA: 0x00310E04 File Offset: 0x0030F004
		public int FirstDropId
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

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600D29F RID: 53919 RVA: 0x00310E44 File Offset: 0x0030F044
		public int AdditionalId
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

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600D2A0 RID: 53920 RVA: 0x00310E84 File Offset: 0x0030F084
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600D2A1 RID: 53921 RVA: 0x00310EC4 File Offset: 0x0030F0C4
		public string NewContent
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

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x00310EFC File Offset: 0x0030F0FC
		public Span<byte> GetNewContentBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x00310F0C File Offset: 0x0030F10C
		public byte[] GetNewContentArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600D2A4 RID: 53924 RVA: 0x00310F24 File Offset: 0x0030F124
		public int DetectionTabType
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

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x00310F64 File Offset: 0x0030F164
		public int PhantomFetterGroup(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600D2A6 RID: 53926 RVA: 0x00310FA4 File Offset: 0x0030F1A4
		public int PhantomFetterGroupLength
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

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x00310FD0 File Offset: 0x0030F1D0
		public Span<int> GetPhantomFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00310FE0 File Offset: 0x0030F1E0
		public int[] GetPhantomFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x0600D2A9 RID: 53929 RVA: 0x00310FF8 File Offset: 0x0030F1F8
		public int WeaponFetterGroup(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x00311038 File Offset: 0x0030F238
		public int WeaponFetterGroupLength
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

		// Token: 0x0600D2AB RID: 53931 RVA: 0x00311064 File Offset: 0x0030F264
		public Span<int> GetWeaponFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x00311074 File Offset: 0x0030F274
		public int[] GetWeaponFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600D2AD RID: 53933 RVA: 0x0031108C File Offset: 0x0030F28C
		public int PeriodicityChallengeType
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

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600D2AE RID: 53934 RVA: 0x003110CC File Offset: 0x0030F2CC
		public int DetectionTitlePanel
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600D2AF RID: 53935 RVA: 0x0031110C File Offset: 0x0030F30C
		public string LeftBgSprite
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

		// Token: 0x0600D2B0 RID: 53936 RVA: 0x00311144 File Offset: 0x0030F344
		public Span<byte> GetLeftBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600D2B1 RID: 53937 RVA: 0x00311154 File Offset: 0x0030F354
		public byte[] GetLeftBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x0031116C File Offset: 0x0030F36C
		public string RightBgSprite
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

		// Token: 0x0600D2B3 RID: 53939 RVA: 0x003111A4 File Offset: 0x0030F3A4
		public Span<byte> GetRightBgSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600D2B4 RID: 53940 RVA: 0x003111B4 File Offset: 0x0030F3B4
		public byte[] GetRightBgSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600D2B5 RID: 53941 RVA: 0x003111CC File Offset: 0x0030F3CC
		public string LeftBgTexture
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2B6 RID: 53942 RVA: 0x00311204 File Offset: 0x0030F404
		public Span<byte> GetLeftBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600D2B7 RID: 53943 RVA: 0x00311214 File Offset: 0x0030F414
		public byte[] GetLeftBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600D2B8 RID: 53944 RVA: 0x0031122C File Offset: 0x0030F42C
		public int DungeonId
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

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600D2B9 RID: 53945 RVA: 0x0031126C File Offset: 0x0030F46C
		public int JumpType
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

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600D2BA RID: 53946 RVA: 0x003112AC File Offset: 0x0030F4AC
		public int InstanceDungeonEntranceId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600D2BB RID: 53947 RVA: 0x003112EC File Offset: 0x0030F4EC
		public int JumpWithSubDungeonId
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D2BC RID: 53948 RVA: 0x0031132C File Offset: 0x0030F52C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelPlayListIter()或GetLevelPlayListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelPlayList()
		{
			SilentAreaDetection silentAreaDetection = this;
			return silentAreaDetection.GetLevelPlayListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D2BD RID: 53949 RVA: 0x00311350 File Offset: 0x0030F550
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelPlayListIter()
		{
			SilentAreaDetection.<LevelPlayListIter>d__131 <LevelPlayListIter>d__ = new SilentAreaDetection.<LevelPlayListIter>d__131(-2);
			<LevelPlayListIter>d__.<>3__<>4__this = this;
			return <LevelPlayListIter>d__;
		}

		// Token: 0x0600D2BE RID: 53950 RVA: 0x00311368 File Offset: 0x0030F568
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomFetterGroupIter()或GetPhantomFetterGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomFetterGroup()
		{
			SilentAreaDetection silentAreaDetection = this;
			return silentAreaDetection.GetPhantomFetterGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D2BF RID: 53951 RVA: 0x0031138C File Offset: 0x0030F58C
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomFetterGroupIter()
		{
			SilentAreaDetection.<PhantomFetterGroupIter>d__133 <PhantomFetterGroupIter>d__ = new SilentAreaDetection.<PhantomFetterGroupIter>d__133(-2);
			<PhantomFetterGroupIter>d__.<>3__<>4__this = this;
			return <PhantomFetterGroupIter>d__;
		}

		// Token: 0x0600D2C0 RID: 53952 RVA: 0x003113A4 File Offset: 0x0030F5A4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomIdIter()或GetPhantomIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomId()
		{
			SilentAreaDetection silentAreaDetection = this;
			return silentAreaDetection.GetPhantomIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D2C1 RID: 53953 RVA: 0x003113C8 File Offset: 0x0030F5C8
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomIdIter()
		{
			SilentAreaDetection.<PhantomIdIter>d__135 <PhantomIdIter>d__ = new SilentAreaDetection.<PhantomIdIter>d__135(-2);
			<PhantomIdIter>d__.<>3__<>4__this = this;
			return <PhantomIdIter>d__;
		}

		// Token: 0x0600D2C2 RID: 53954 RVA: 0x003113E0 File Offset: 0x0030F5E0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShowRewardMapFrozenDict()缓存字典，遍历请使用ShowRewardMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShowRewardMap()
		{
			return this.ShowRewardMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D2C3 RID: 53955 RVA: 0x00311436 File Offset: 0x0030F636
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShowRewardMapIter()
		{
			SilentAreaDetection.<ShowRewardMapIter>d__137 <ShowRewardMapIter>d__ = new SilentAreaDetection.<ShowRewardMapIter>d__137(-2);
			<ShowRewardMapIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapIter>d__;
		}

		// Token: 0x0600D2C4 RID: 53956 RVA: 0x0031144C File Offset: 0x0030F64C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShowRewardMapCalabashFrozenDict()缓存字典，遍历请使用ShowRewardMapCalabashIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShowRewardMapCalabash()
		{
			return this.ShowRewardMapCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D2C5 RID: 53957 RVA: 0x003114A2 File Offset: 0x0030F6A2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShowRewardMapCalabashIter()
		{
			SilentAreaDetection.<ShowRewardMapCalabashIter>d__139 <ShowRewardMapCalabashIter>d__ = new SilentAreaDetection.<ShowRewardMapCalabashIter>d__139(-2);
			<ShowRewardMapCalabashIter>d__.<>3__<>4__this = this;
			return <ShowRewardMapCalabashIter>d__;
		}

		// Token: 0x0600D2C6 RID: 53958 RVA: 0x003114B8 File Offset: 0x0030F6B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponFetterGroupIter()或GetWeaponFetterGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponFetterGroup()
		{
			SilentAreaDetection silentAreaDetection = this;
			return silentAreaDetection.GetWeaponFetterGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x003114DC File Offset: 0x0030F6DC
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponFetterGroupIter()
		{
			SilentAreaDetection.<WeaponFetterGroupIter>d__141 <WeaponFetterGroupIter>d__ = new SilentAreaDetection.<WeaponFetterGroupIter>d__141(-2);
			<WeaponFetterGroupIter>d__.<>3__<>4__this = this;
			return <WeaponFetterGroupIter>d__;
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x003114F4 File Offset: 0x0030F6F4
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

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x00311528 File Offset: 0x0030F728
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

		// Token: 0x0600D2CA RID: 53962 RVA: 0x0031155C File Offset: 0x0030F75C
		private void EnsureShowRewardMapCacheIfNeeded()
		{
			if (this.ShowRewardMapCache != null)
			{
				return;
			}
			this.ShowRewardMapCache = this.ShowRewardMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x003115C4 File Offset: 0x0030F7C4
		private void EnsureShowRewardMapCalabashCacheIfNeeded()
		{
			if (this.ShowRewardMapCalabashCache != null)
			{
				return;
			}
			this.ShowRewardMapCalabashCache = this.ShowRewardMapCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D2CC RID: 53964 RVA: 0x0031162A File Offset: 0x0030F82A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShowRewardMapFrozenDict(int key)
		{
			this.EnsureShowRewardMapCacheIfNeeded();
			return this.ShowRewardMapCache;
		}

		// Token: 0x0600D2CD RID: 53965 RVA: 0x00311638 File Offset: 0x0030F838
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShowRewardMapCalabashFrozenDict(int key)
		{
			this.EnsureShowRewardMapCalabashCacheIfNeeded();
			return this.ShowRewardMapCalabashCache;
		}

		// Token: 0x040051C5 RID: 20933
		private Table __p;

		// Token: 0x040051C6 RID: 20934
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCache;

		// Token: 0x040051C7 RID: 20935
		[Nullable(2)]
		private FrozenDictionary<int, int> ShowRewardMapCalabashCache;
	}
}
