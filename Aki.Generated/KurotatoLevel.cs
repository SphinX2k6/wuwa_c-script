using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E87 RID: 3719
	public struct KurotatoLevel : IFlatbufferObject
	{
		// Token: 0x17001BF5 RID: 7157
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x0028D5AD File Offset: 0x0028B7AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0028D5BA File Offset: 0x0028B7BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0028D5C4 File Offset: 0x0028B7C4
		public static KurotatoLevel GetRootAsKurotatoLevel(ByteBuffer _bb)
		{
			return KurotatoLevel.GetRootAsKurotatoLevel(_bb, default(KurotatoLevel));
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0028D5E0 File Offset: 0x0028B7E0
		public static KurotatoLevel GetRootAsKurotatoLevel(ByteBuffer _bb, KurotatoLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0028D5FD File Offset: 0x0028B7FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x0028D60C File Offset: 0x0028B80C
		public KurotatoLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BF6 RID: 7158
		// (get) Token: 0x06009000 RID: 36864 RVA: 0x0028D61C File Offset: 0x0028B81C
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

		// Token: 0x17001BF7 RID: 7159
		// (get) Token: 0x06009001 RID: 36865 RVA: 0x0028D658 File Offset: 0x0028B858
		public int ActivityId
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

		// Token: 0x17001BF8 RID: 7160
		// (get) Token: 0x06009002 RID: 36866 RVA: 0x0028D694 File Offset: 0x0028B894
		public int Difficulty
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

		// Token: 0x17001BF9 RID: 7161
		// (get) Token: 0x06009003 RID: 36867 RVA: 0x0028D6D0 File Offset: 0x0028B8D0
		public int SecondGroup
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

		// Token: 0x17001BFA RID: 7162
		// (get) Token: 0x06009004 RID: 36868 RVA: 0x0028D710 File Offset: 0x0028B910
		public int InstId
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

		// Token: 0x17001BFB RID: 7163
		// (get) Token: 0x06009005 RID: 36869 RVA: 0x0028D750 File Offset: 0x0028B950
		public int LevelGroup
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

		// Token: 0x17001BFC RID: 7164
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x0028D790 File Offset: 0x0028B990
		public int SortId
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

		// Token: 0x17001BFD RID: 7165
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x0028D7D0 File Offset: 0x0028B9D0
		public int PerId
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

		// Token: 0x06009008 RID: 36872 RVA: 0x0028D810 File Offset: 0x0028BA10
		public int Characters(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BFE RID: 7166
		// (get) Token: 0x06009009 RID: 36873 RVA: 0x0028D850 File Offset: 0x0028BA50
		public int CharactersLength
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

		// Token: 0x0600900A RID: 36874 RVA: 0x0028D87C File Offset: 0x0028BA7C
		public Span<int> GetCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0028D88C File Offset: 0x0028BA8C
		public int[] GetCharactersArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x0028D8A4 File Offset: 0x0028BAA4
		public int RecommendCharacters(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x0600900D RID: 36877 RVA: 0x0028D8E4 File Offset: 0x0028BAE4
		public int RecommendCharactersLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0028D910 File Offset: 0x0028BB10
		public Span<int> GetRecommendCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0028D920 File Offset: 0x0028BB20
		public int[] GetRecommendCharactersArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0028D938 File Offset: 0x0028BB38
		public int SaveWaveIds(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x06009011 RID: 36881 RVA: 0x0028D978 File Offset: 0x0028BB78
		public int SaveWaveIdsLength
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

		// Token: 0x06009012 RID: 36882 RVA: 0x0028D9A4 File Offset: 0x0028BBA4
		public Span<int> GetSaveWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x0028D9B4 File Offset: 0x0028BBB4
		public int[] GetSaveWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0028D9CC File Offset: 0x0028BBCC
		public int TargetWaveIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x0028DA0C File Offset: 0x0028BC0C
		public int TargetWaveIdsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0028DA38 File Offset: 0x0028BC38
		public Span<int> GetTargetWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0028DA48 File Offset: 0x0028BC48
		public int[] GetTargetWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x0028DA60 File Offset: 0x0028BC60
		public int UnlockCharacters(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x0028DAA0 File Offset: 0x0028BCA0
		public int UnlockCharactersLength
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

		// Token: 0x0600901A RID: 36890 RVA: 0x0028DACC File Offset: 0x0028BCCC
		public Span<int> GetUnlockCharactersBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0028DADC File Offset: 0x0028BCDC
		public int[] GetUnlockCharactersArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0028DAF4 File Offset: 0x0028BCF4
		public int UnLockedItems(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x0028DB34 File Offset: 0x0028BD34
		public int UnLockedItemsLength
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

		// Token: 0x0600901E RID: 36894 RVA: 0x0028DB60 File Offset: 0x0028BD60
		public Span<int> GetUnLockedItemsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0028DB70 File Offset: 0x0028BD70
		public int[] GetUnLockedItemsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0028DB88 File Offset: 0x0028BD88
		public int UnLockedWeapons(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x06009021 RID: 36897 RVA: 0x0028DBC8 File Offset: 0x0028BDC8
		public int UnLockedWeaponsLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0028DBF4 File Offset: 0x0028BDF4
		public Span<int> GetUnLockedWeaponsBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0028DC04 File Offset: 0x0028BE04
		public int[] GetUnLockedWeaponsArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x06009024 RID: 36900 RVA: 0x0028DC1C File Offset: 0x0028BE1C
		public string Icon
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

		// Token: 0x06009025 RID: 36901 RVA: 0x0028DC54 File Offset: 0x0028BE54
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0028DC64 File Offset: 0x0028BE64
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x06009027 RID: 36903 RVA: 0x0028DC7C File Offset: 0x0028BE7C
		public string Name
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

		// Token: 0x06009028 RID: 36904 RVA: 0x0028DCB4 File Offset: 0x0028BEB4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0028DCC4 File Offset: 0x0028BEC4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x0600902A RID: 36906 RVA: 0x0028DCDC File Offset: 0x0028BEDC
		public string Picture
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

		// Token: 0x0600902B RID: 36907 RVA: 0x0028DD14 File Offset: 0x0028BF14
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0028DD24 File Offset: 0x0028BF24
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x0600902D RID: 36909 RVA: 0x0028DD3C File Offset: 0x0028BF3C
		public string Number
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

		// Token: 0x0600902E RID: 36910 RVA: 0x0028DD74 File Offset: 0x0028BF74
		public Span<byte> GetNumberBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x0028DD84 File Offset: 0x0028BF84
		public byte[] GetNumberArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x0028DD9C File Offset: 0x0028BF9C
		public int SpawnPoints(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06009031 RID: 36913 RVA: 0x0028DDDC File Offset: 0x0028BFDC
		public int SpawnPointsLength
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

		// Token: 0x06009032 RID: 36914 RVA: 0x0028DE08 File Offset: 0x0028C008
		public Span<int> GetSpawnPointsBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x0028DE18 File Offset: 0x0028C018
		public int[] GetSpawnPointsArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x0028DE30 File Offset: 0x0028C030
		public string LevelRange
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

		// Token: 0x06009035 RID: 36917 RVA: 0x0028DE68 File Offset: 0x0028C068
		public Span<byte> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x0028DE78 File Offset: 0x0028C078
		public byte[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06009037 RID: 36919 RVA: 0x0028DE90 File Offset: 0x0028C090
		public string DetailDesc
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

		// Token: 0x06009038 RID: 36920 RVA: 0x0028DEC8 File Offset: 0x0028C0C8
		public Span<byte> GetDetailDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0028DED8 File Offset: 0x0028C0D8
		public byte[] GetDetailDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x0028DEF0 File Offset: 0x0028C0F0
		public string DetailDescParams(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600903B RID: 36923 RVA: 0x0028DF2C File Offset: 0x0028C12C
		public int DetailDescParamsLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x0028DF58 File Offset: 0x0028C158
		public string TargetDesc(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x0600903D RID: 36925 RVA: 0x0028DF94 File Offset: 0x0028C194
		public int TargetDescLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600903E RID: 36926 RVA: 0x0028DFC0 File Offset: 0x0028C1C0
		public int TotalWave
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

		// Token: 0x0600903F RID: 36927 RVA: 0x0028E000 File Offset: 0x0028C200
		public float BoundCenter(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06009040 RID: 36928 RVA: 0x0028E044 File Offset: 0x0028C244
		public int BoundCenterLength
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

		// Token: 0x06009041 RID: 36929 RVA: 0x0028E070 File Offset: 0x0028C270
		public Span<float> GetBoundCenterBytes()
		{
			return this.__p.__vector_as_span<float>(54, 4);
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0028E080 File Offset: 0x0028C280
		public float[] GetBoundCenterArray()
		{
			return this.__p.__vector_as_array<float>(54) ?? Array.Empty<float>();
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06009043 RID: 36931 RVA: 0x0028E098 File Offset: 0x0028C298
		public float BoundRadius
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x0028E0D9 File Offset: 0x0028C2D9
		[NullableContext(1)]
		public float[] BoundCenter()
		{
			return this.GetBoundCenterArray();
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0028E0E1 File Offset: 0x0028C2E1
		[NullableContext(1)]
		public IEnumerable<float> BoundCenterIter()
		{
			KurotatoLevel.<BoundCenterIter>d__104 <BoundCenterIter>d__ = new KurotatoLevel.<BoundCenterIter>d__104(-2);
			<BoundCenterIter>d__.<>3__<>4__this = this;
			return <BoundCenterIter>d__;
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x0028E0F6 File Offset: 0x0028C2F6
		[NullableContext(1)]
		public int[] Characters()
		{
			return this.GetCharactersArray();
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x0028E0FE File Offset: 0x0028C2FE
		[NullableContext(1)]
		public IEnumerable<int> CharactersIter()
		{
			KurotatoLevel.<CharactersIter>d__106 <CharactersIter>d__ = new KurotatoLevel.<CharactersIter>d__106(-2);
			<CharactersIter>d__.<>3__<>4__this = this;
			return <CharactersIter>d__;
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x0028E113 File Offset: 0x0028C313
		[NullableContext(1)]
		public string[] DetailDescParams()
		{
			return this.DetailDescParamsIter().ToArray<string>();
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x0028E120 File Offset: 0x0028C320
		[NullableContext(1)]
		public IEnumerable<string> DetailDescParamsIter()
		{
			KurotatoLevel.<DetailDescParamsIter>d__108 <DetailDescParamsIter>d__ = new KurotatoLevel.<DetailDescParamsIter>d__108(-2);
			<DetailDescParamsIter>d__.<>3__<>4__this = this;
			return <DetailDescParamsIter>d__;
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x0028E135 File Offset: 0x0028C335
		[NullableContext(1)]
		public int[] RecommendCharacters()
		{
			return this.GetRecommendCharactersArray();
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x0028E13D File Offset: 0x0028C33D
		[NullableContext(1)]
		public IEnumerable<int> RecommendCharactersIter()
		{
			KurotatoLevel.<RecommendCharactersIter>d__110 <RecommendCharactersIter>d__ = new KurotatoLevel.<RecommendCharactersIter>d__110(-2);
			<RecommendCharactersIter>d__.<>3__<>4__this = this;
			return <RecommendCharactersIter>d__;
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x0028E152 File Offset: 0x0028C352
		[NullableContext(1)]
		public int[] SaveWaveIds()
		{
			return this.GetSaveWaveIdsArray();
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x0028E15A File Offset: 0x0028C35A
		[NullableContext(1)]
		public IEnumerable<int> SaveWaveIdsIter()
		{
			KurotatoLevel.<SaveWaveIdsIter>d__112 <SaveWaveIdsIter>d__ = new KurotatoLevel.<SaveWaveIdsIter>d__112(-2);
			<SaveWaveIdsIter>d__.<>3__<>4__this = this;
			return <SaveWaveIdsIter>d__;
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x0028E16F File Offset: 0x0028C36F
		[NullableContext(1)]
		public int[] SpawnPoints()
		{
			return this.GetSpawnPointsArray();
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x0028E177 File Offset: 0x0028C377
		[NullableContext(1)]
		public IEnumerable<int> SpawnPointsIter()
		{
			KurotatoLevel.<SpawnPointsIter>d__114 <SpawnPointsIter>d__ = new KurotatoLevel.<SpawnPointsIter>d__114(-2);
			<SpawnPointsIter>d__.<>3__<>4__this = this;
			return <SpawnPointsIter>d__;
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x0028E18C File Offset: 0x0028C38C
		[NullableContext(1)]
		public string[] TargetDesc()
		{
			return this.TargetDescIter().ToArray<string>();
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x0028E199 File Offset: 0x0028C399
		[NullableContext(1)]
		public IEnumerable<string> TargetDescIter()
		{
			KurotatoLevel.<TargetDescIter>d__116 <TargetDescIter>d__ = new KurotatoLevel.<TargetDescIter>d__116(-2);
			<TargetDescIter>d__.<>3__<>4__this = this;
			return <TargetDescIter>d__;
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x0028E1AE File Offset: 0x0028C3AE
		[NullableContext(1)]
		public int[] TargetWaveIds()
		{
			return this.GetTargetWaveIdsArray();
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x0028E1B6 File Offset: 0x0028C3B6
		[NullableContext(1)]
		public IEnumerable<int> TargetWaveIdsIter()
		{
			KurotatoLevel.<TargetWaveIdsIter>d__118 <TargetWaveIdsIter>d__ = new KurotatoLevel.<TargetWaveIdsIter>d__118(-2);
			<TargetWaveIdsIter>d__.<>3__<>4__this = this;
			return <TargetWaveIdsIter>d__;
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x0028E1CB File Offset: 0x0028C3CB
		[NullableContext(1)]
		public int[] UnLockedItems()
		{
			return this.GetUnLockedItemsArray();
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x0028E1D3 File Offset: 0x0028C3D3
		[NullableContext(1)]
		public IEnumerable<int> UnLockedItemsIter()
		{
			KurotatoLevel.<UnLockedItemsIter>d__120 <UnLockedItemsIter>d__ = new KurotatoLevel.<UnLockedItemsIter>d__120(-2);
			<UnLockedItemsIter>d__.<>3__<>4__this = this;
			return <UnLockedItemsIter>d__;
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x0028E1E8 File Offset: 0x0028C3E8
		[NullableContext(1)]
		public int[] UnLockedWeapons()
		{
			return this.GetUnLockedWeaponsArray();
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x0028E1F0 File Offset: 0x0028C3F0
		[NullableContext(1)]
		public IEnumerable<int> UnLockedWeaponsIter()
		{
			KurotatoLevel.<UnLockedWeaponsIter>d__122 <UnLockedWeaponsIter>d__ = new KurotatoLevel.<UnLockedWeaponsIter>d__122(-2);
			<UnLockedWeaponsIter>d__.<>3__<>4__this = this;
			return <UnLockedWeaponsIter>d__;
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0028E205 File Offset: 0x0028C405
		[NullableContext(1)]
		public int[] UnlockCharacters()
		{
			return this.GetUnlockCharactersArray();
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x0028E20D File Offset: 0x0028C40D
		[NullableContext(1)]
		public IEnumerable<int> UnlockCharactersIter()
		{
			KurotatoLevel.<UnlockCharactersIter>d__124 <UnlockCharactersIter>d__ = new KurotatoLevel.<UnlockCharactersIter>d__124(-2);
			<UnlockCharactersIter>d__.<>3__<>4__this = this;
			return <UnlockCharactersIter>d__;
		}

		// Token: 0x04005418 RID: 21528
		private Table __p;
	}
}
