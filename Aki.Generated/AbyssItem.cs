using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B83 RID: 2947
	public struct AbyssItem : IFlatbufferObject
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060045BE RID: 17854 RVA: 0x001E544A File Offset: 0x001E364A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001E5457 File Offset: 0x001E3657
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x001E5460 File Offset: 0x001E3660
		public static AbyssItem GetRootAsAbyssItem(ByteBuffer _bb)
		{
			return AbyssItem.GetRootAsAbyssItem(_bb, default(AbyssItem));
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x001E547C File Offset: 0x001E367C
		public static AbyssItem GetRootAsAbyssItem(ByteBuffer _bb, AbyssItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x001E5499 File Offset: 0x001E3699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x001E54A8 File Offset: 0x001E36A8
		public AbyssItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x001E54B8 File Offset: 0x001E36B8
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060045C5 RID: 17861 RVA: 0x001E54F4 File Offset: 0x001E36F4
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x001E5530 File Offset: 0x001E3730
		public int SlotType
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060045C7 RID: 17863 RVA: 0x001E556C File Offset: 0x001E376C
		public int QualityId
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x001E55AC File Offset: 0x001E37AC
		public int BelongLittleRole
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060045C9 RID: 17865 RVA: 0x001E55EC File Offset: 0x001E37EC
		public string PassiveBuffShowName
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

		// Token: 0x060045CA RID: 17866 RVA: 0x001E5624 File Offset: 0x001E3824
		public Span<byte> GetPassiveBuffShowNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x001E5634 File Offset: 0x001E3834
		public byte[] GetPassiveBuffShowNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060045CC RID: 17868 RVA: 0x001E564C File Offset: 0x001E384C
		public string PassiveBuffShowDesc
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

		// Token: 0x060045CD RID: 17869 RVA: 0x001E5684 File Offset: 0x001E3884
		public Span<byte> GetPassiveBuffShowDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x001E5694 File Offset: 0x001E3894
		public byte[] GetPassiveBuffShowDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x001E56AC File Offset: 0x001E38AC
		public StringArray? LevelDescStrArray(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001E5710 File Offset: 0x001E3910
		public int LevelDescStrArrayLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x001E573C File Offset: 0x001E393C
		public long AbyssBuff(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x001E5788 File Offset: 0x001E3988
		public int AbyssBuffLength
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

		// Token: 0x060045D3 RID: 17875 RVA: 0x001E57B4 File Offset: 0x001E39B4
		public Span<long> GetAbyssBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x001E57C9 File Offset: 0x001E39C9
		public long[] GetAbyssBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x001E5808 File Offset: 0x001E3A08
		public long AbyssPhantomBuff(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060045D6 RID: 17878 RVA: 0x001E5854 File Offset: 0x001E3A54
		public int AbyssPhantomBuffLength
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

		// Token: 0x060045D7 RID: 17879 RVA: 0x001E5880 File Offset: 0x001E3A80
		public Span<long> GetAbyssPhantomBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x001E5895 File Offset: 0x001E3A95
		public long[] GetAbyssPhantomBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x001E58D4 File Offset: 0x001E3AD4
		public ConfigPropValue? Prop(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x001E5938 File Offset: 0x001E3B38
		public int PropLength
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

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x001E5964 File Offset: 0x001E3B64
		public string AttributesDescription
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

		// Token: 0x060045DC RID: 17884 RVA: 0x001E599C File Offset: 0x001E3B9C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x001E59AC File Offset: 0x001E3BAC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x001E59C4 File Offset: 0x001E3BC4
		public DicIntInt? AddTag(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x001E5A28 File Offset: 0x001E3C28
		public int AddTagLength
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

		// Token: 0x060045E0 RID: 17888 RVA: 0x001E5A54 File Offset: 0x001E3C54
		public DicIntInt? CertainTag(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x001E5AB8 File Offset: 0x001E3CB8
		public int CertainTagLength
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

		// Token: 0x060045E2 RID: 17890 RVA: 0x001E5AE4 File Offset: 0x001E3CE4
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x001E5B48 File Offset: 0x001E3D48
		public int AddPropLength
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060045E4 RID: 17892 RVA: 0x001E5B74 File Offset: 0x001E3D74
		public string Name
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

		// Token: 0x060045E5 RID: 17893 RVA: 0x001E5BAC File Offset: 0x001E3DAC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x001E5BBC File Offset: 0x001E3DBC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x001E5BD4 File Offset: 0x001E3DD4
		public string TypeDescription
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

		// Token: 0x060045E8 RID: 17896 RVA: 0x001E5C0C File Offset: 0x001E3E0C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x001E5C1C File Offset: 0x001E3E1C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060045EA RID: 17898 RVA: 0x001E5C34 File Offset: 0x001E3E34
		public string BgDescription
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

		// Token: 0x060045EB RID: 17899 RVA: 0x001E5C6C File Offset: 0x001E3E6C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x001E5C7C File Offset: 0x001E3E7C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x001E5C94 File Offset: 0x001E3E94
		public string Icon
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

		// Token: 0x060045EE RID: 17902 RVA: 0x001E5CCC File Offset: 0x001E3ECC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x001E5CDC File Offset: 0x001E3EDC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060045F0 RID: 17904 RVA: 0x001E5CF4 File Offset: 0x001E3EF4
		public string IconMiddle
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

		// Token: 0x060045F1 RID: 17905 RVA: 0x001E5D2C File Offset: 0x001E3F2C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x001E5D3C File Offset: 0x001E3F3C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x001E5D54 File Offset: 0x001E3F54
		public string IconSmall
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

		// Token: 0x060045F4 RID: 17908 RVA: 0x001E5D8C File Offset: 0x001E3F8C
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x001E5D9C File Offset: 0x001E3F9C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x001E5DB4 File Offset: 0x001E3FB4
		public string Mesh
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

		// Token: 0x060045F7 RID: 17911 RVA: 0x001E5DEC File Offset: 0x001E3FEC
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x001E5DFC File Offset: 0x001E3FFC
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x001E5E14 File Offset: 0x001E4014
		[NullableContext(1)]
		public long[] AbyssBuff()
		{
			return this.GetAbyssBuffArray();
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x001E5E1C File Offset: 0x001E401C
		[NullableContext(1)]
		public IEnumerable<long> AbyssBuffIter()
		{
			AbyssItem.<AbyssBuffIter>d__84 <AbyssBuffIter>d__ = new AbyssItem.<AbyssBuffIter>d__84(-2);
			<AbyssBuffIter>d__.<>3__<>4__this = this;
			return <AbyssBuffIter>d__;
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x001E5E31 File Offset: 0x001E4031
		[NullableContext(1)]
		public long[] AbyssPhantomBuff()
		{
			return this.GetAbyssPhantomBuffArray();
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x001E5E39 File Offset: 0x001E4039
		[NullableContext(1)]
		public IEnumerable<long> AbyssPhantomBuffIter()
		{
			AbyssItem.<AbyssPhantomBuffIter>d__86 <AbyssPhantomBuffIter>d__ = new AbyssItem.<AbyssPhantomBuffIter>d__86(-2);
			<AbyssPhantomBuffIter>d__.<>3__<>4__this = this;
			return <AbyssPhantomBuffIter>d__;
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x001E5E4E File Offset: 0x001E404E
		[NullableContext(1)]
		public ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x001E5E5B File Offset: 0x001E405B
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> AddPropIter()
		{
			AbyssItem.<AddPropIter>d__88 <AddPropIter>d__ = new AbyssItem.<AddPropIter>d__88(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x001E5E70 File Offset: 0x001E4070
		[NullableContext(1)]
		public Dictionary<int, int> AddTag()
		{
			return this.AddTagIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x001E5EC6 File Offset: 0x001E40C6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AddTagIter()
		{
			AbyssItem.<AddTagIter>d__90 <AddTagIter>d__ = new AbyssItem.<AddTagIter>d__90(-2);
			<AddTagIter>d__.<>3__<>4__this = this;
			return <AddTagIter>d__;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x001E5EDC File Offset: 0x001E40DC
		[NullableContext(1)]
		public Dictionary<int, int> CertainTag()
		{
			return this.CertainTagIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x001E5F32 File Offset: 0x001E4132
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CertainTagIter()
		{
			AbyssItem.<CertainTagIter>d__92 <CertainTagIter>d__ = new AbyssItem.<CertainTagIter>d__92(-2);
			<CertainTagIter>d__.<>3__<>4__this = this;
			return <CertainTagIter>d__;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x001E5F47 File Offset: 0x001E4147
		[NullableContext(1)]
		public StringArray[] LevelDescStrArray()
		{
			return this.LevelDescStrArrayIter().ToArray<StringArray>();
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x001E5F54 File Offset: 0x001E4154
		[NullableContext(1)]
		public IEnumerable<StringArray> LevelDescStrArrayIter()
		{
			AbyssItem.<LevelDescStrArrayIter>d__94 <LevelDescStrArrayIter>d__ = new AbyssItem.<LevelDescStrArrayIter>d__94(-2);
			<LevelDescStrArrayIter>d__.<>3__<>4__this = this;
			return <LevelDescStrArrayIter>d__;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x001E5F69 File Offset: 0x001E4169
		[NullableContext(1)]
		public ConfigPropValue[] Prop()
		{
			return this.PropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x001E5F76 File Offset: 0x001E4176
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> PropIter()
		{
			AbyssItem.<PropIter>d__96 <PropIter>d__ = new AbyssItem.<PropIter>d__96(-2);
			<PropIter>d__.<>3__<>4__this = this;
			return <PropIter>d__;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x001E5F8C File Offset: 0x001E418C
		public int? GetAddTag(int key)
		{
			this.EnsureAddTagCacheIfNeeded();
			int value;
			if (!this.AddTagCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x001E5FC0 File Offset: 0x001E41C0
		public int? GetCertainTag(int key)
		{
			this.EnsureCertainTagCacheIfNeeded();
			int value;
			if (!this.CertainTagCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x001E5FF4 File Offset: 0x001E41F4
		private void EnsureAddTagCacheIfNeeded()
		{
			if (this.AddTagCache != null)
			{
				return;
			}
			this.AddTagCache = this.AddTagIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x001E605C File Offset: 0x001E425C
		private void EnsureCertainTagCacheIfNeeded()
		{
			if (this.CertainTagCache != null)
			{
				return;
			}
			this.CertainTagCache = this.CertainTagIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x001E60C2 File Offset: 0x001E42C2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAddTagFrozenDict()
		{
			this.EnsureAddTagCacheIfNeeded();
			return this.AddTagCache;
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001E60D0 File Offset: 0x001E42D0
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCertainTagFrozenDict()
		{
			this.EnsureCertainTagCacheIfNeeded();
			return this.CertainTagCache;
		}

		// Token: 0x04005055 RID: 20565
		private Table __p;

		// Token: 0x04005056 RID: 20566
		[Nullable(2)]
		private FrozenDictionary<int, int> AddTagCache;

		// Token: 0x04005057 RID: 20567
		[Nullable(2)]
		private FrozenDictionary<int, int> CertainTagCache;
	}
}
