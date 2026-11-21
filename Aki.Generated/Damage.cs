using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C99 RID: 3225
	public struct Damage : IFlatbufferObject
	{
		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600610C RID: 24844 RVA: 0x002235C4 File Offset: 0x002217C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x002235D1 File Offset: 0x002217D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x002235D8 File Offset: 0x002217D8
		public static Damage GetRootAsDamage(ByteBuffer _bb)
		{
			return Damage.GetRootAsDamage(_bb, default(Damage));
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x002235F4 File Offset: 0x002217F4
		public static Damage GetRootAsDamage(ByteBuffer _bb, Damage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x00223611 File Offset: 0x00221811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x00223620 File Offset: 0x00221820
		public Damage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06006112 RID: 24850 RVA: 0x00223630 File Offset: 0x00221830
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06006113 RID: 24851 RVA: 0x00223678 File Offset: 0x00221878
		public string Condition
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

		// Token: 0x06006114 RID: 24852 RVA: 0x002236AF File Offset: 0x002218AF
		public Span<byte> GetConditionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x002236BE File Offset: 0x002218BE
		public byte[] GetConditionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x002236D8 File Offset: 0x002218D8
		public DicStringString? ConstVariables(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06006117 RID: 24855 RVA: 0x00223738 File Offset: 0x00221938
		public int ConstVariablesLength
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

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06006118 RID: 24856 RVA: 0x00223764 File Offset: 0x00221964
		public int ExecutionTiming
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

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06006119 RID: 24857 RVA: 0x002237A4 File Offset: 0x002219A4
		public int CalculateType
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x002237E4 File Offset: 0x002219E4
		public int Element
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

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x00223824 File Offset: 0x00221A24
		public int DamageTextType
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

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x0600611C RID: 24860 RVA: 0x00223864 File Offset: 0x00221A64
		public int DamageTextAreaId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600611D RID: 24861 RVA: 0x002238A4 File Offset: 0x00221AA4
		public long PayloadId
		{
			get
			{
				int num = this.__p.__offset(20);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x002238EC File Offset: 0x00221AEC
		public int Type
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

		// Token: 0x0600611F RID: 24863 RVA: 0x0022392C File Offset: 0x00221B2C
		public int SubType(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06006120 RID: 24864 RVA: 0x0022396C File Offset: 0x00221B6C
		public int SubTypeLength
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

		// Token: 0x06006121 RID: 24865 RVA: 0x00223998 File Offset: 0x00221B98
		public Span<int> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x002239A8 File Offset: 0x00221BA8
		public int[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06006123 RID: 24867 RVA: 0x002239C0 File Offset: 0x00221BC0
		public int SmashType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x00223A00 File Offset: 0x00221C00
		public int CureBaseValue(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06006125 RID: 24869 RVA: 0x00223A40 File Offset: 0x00221C40
		public int CureBaseValueLength
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

		// Token: 0x06006126 RID: 24870 RVA: 0x00223A6C File Offset: 0x00221C6C
		public Span<int> GetCureBaseValueBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x00223A7C File Offset: 0x00221C7C
		public int[] GetCureBaseValueArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06006128 RID: 24872 RVA: 0x00223A94 File Offset: 0x00221C94
		public int RelatedProperty
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x00223AD4 File Offset: 0x00221CD4
		public int RateLv(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x0600612A RID: 24874 RVA: 0x00223B14 File Offset: 0x00221D14
		public int RateLvLength
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

		// Token: 0x0600612B RID: 24875 RVA: 0x00223B40 File Offset: 0x00221D40
		public Span<int> GetRateLvBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x00223B50 File Offset: 0x00221D50
		public int[] GetRateLvArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x00223B68 File Offset: 0x00221D68
		public int HardnessLv(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x0600612E RID: 24878 RVA: 0x00223BA8 File Offset: 0x00221DA8
		public int HardnessLvLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x00223BD4 File Offset: 0x00221DD4
		public Span<int> GetHardnessLvBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x00223BE4 File Offset: 0x00221DE4
		public int[] GetHardnessLvArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x00223BFC File Offset: 0x00221DFC
		public int ToughLv(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06006132 RID: 24882 RVA: 0x00223C3C File Offset: 0x00221E3C
		public int ToughLvLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00223C68 File Offset: 0x00221E68
		public Span<int> GetToughLvBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x00223C78 File Offset: 0x00221E78
		public int[] GetToughLvArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x00223C90 File Offset: 0x00221E90
		public int Energy(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06006136 RID: 24886 RVA: 0x00223CD0 File Offset: 0x00221ED0
		public int EnergyLength
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

		// Token: 0x06006137 RID: 24887 RVA: 0x00223CFC File Offset: 0x00221EFC
		public Span<int> GetEnergyBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x00223D0C File Offset: 0x00221F0C
		public int[] GetEnergyArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x00223D24 File Offset: 0x00221F24
		public int SpecialEnergy1(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600613A RID: 24890 RVA: 0x00223D64 File Offset: 0x00221F64
		public int SpecialEnergy1Length
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

		// Token: 0x0600613B RID: 24891 RVA: 0x00223D90 File Offset: 0x00221F90
		public Span<int> GetSpecialEnergy1Bytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x00223DA0 File Offset: 0x00221FA0
		public int[] GetSpecialEnergy1Array()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x00223DB8 File Offset: 0x00221FB8
		public int SpecialEnergy2(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600613E RID: 24894 RVA: 0x00223DF8 File Offset: 0x00221FF8
		public int SpecialEnergy2Length
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

		// Token: 0x0600613F RID: 24895 RVA: 0x00223E24 File Offset: 0x00222024
		public Span<int> GetSpecialEnergy2Bytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x00223E34 File Offset: 0x00222034
		public int[] GetSpecialEnergy2Array()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x00223E4C File Offset: 0x0022204C
		public int SpecialEnergy3(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06006142 RID: 24898 RVA: 0x00223E8C File Offset: 0x0022208C
		public int SpecialEnergy3Length
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

		// Token: 0x06006143 RID: 24899 RVA: 0x00223EB8 File Offset: 0x002220B8
		public Span<int> GetSpecialEnergy3Bytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x00223EC8 File Offset: 0x002220C8
		public int[] GetSpecialEnergy3Array()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x00223EE0 File Offset: 0x002220E0
		public int SpecialEnergy4(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06006146 RID: 24902 RVA: 0x00223F20 File Offset: 0x00222120
		public int SpecialEnergy4Length
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x00223F4C File Offset: 0x0022214C
		public Span<int> GetSpecialEnergy4Bytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x00223F5C File Offset: 0x0022215C
		public int[] GetSpecialEnergy4Array()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x00223F74 File Offset: 0x00222174
		public int SpecialEnergy5(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x00223FB4 File Offset: 0x002221B4
		public int SpecialEnergy5Length
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

		// Token: 0x0600614B RID: 24907 RVA: 0x00223FE0 File Offset: 0x002221E0
		public Span<int> GetSpecialEnergy5Bytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x00223FF0 File Offset: 0x002221F0
		public int[] GetSpecialEnergy5Array()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x0600614D RID: 24909 RVA: 0x00224008 File Offset: 0x00222208
		public int ElementPowerType
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

		// Token: 0x0600614E RID: 24910 RVA: 0x00224048 File Offset: 0x00222248
		public int ElementPower(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600614F RID: 24911 RVA: 0x00224088 File Offset: 0x00222288
		public int ElementPowerLength
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

		// Token: 0x06006150 RID: 24912 RVA: 0x002240B4 File Offset: 0x002222B4
		public Span<int> GetElementPowerBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x002240C4 File Offset: 0x002222C4
		public int[] GetElementPowerArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x002240DC File Offset: 0x002222DC
		public int Dying(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06006153 RID: 24915 RVA: 0x0022411C File Offset: 0x0022231C
		public int DyingLength
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

		// Token: 0x06006154 RID: 24916 RVA: 0x00224148 File Offset: 0x00222348
		public Span<int> GetDyingBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x00224158 File Offset: 0x00222358
		public int[] GetDyingArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06006156 RID: 24918 RVA: 0x00224170 File Offset: 0x00222370
		public int FormulaType
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

		// Token: 0x06006157 RID: 24919 RVA: 0x002241B0 File Offset: 0x002223B0
		public int FormulaParam1(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06006158 RID: 24920 RVA: 0x002241F0 File Offset: 0x002223F0
		public int FormulaParam1Length
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x0022421C File Offset: 0x0022241C
		public Span<int> GetFormulaParam1Bytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x0022422C File Offset: 0x0022242C
		public int[] GetFormulaParam1Array()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x00224244 File Offset: 0x00222444
		public int FormulaParam2(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600615C RID: 24924 RVA: 0x00224284 File Offset: 0x00222484
		public int FormulaParam2Length
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x002242B0 File Offset: 0x002224B0
		public Span<int> GetFormulaParam2Bytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x002242C0 File Offset: 0x002224C0
		public int[] GetFormulaParam2Array()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x002242D8 File Offset: 0x002224D8
		public int FormulaParam3(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x00224318 File Offset: 0x00222518
		public int FormulaParam3Length
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

		// Token: 0x06006161 RID: 24929 RVA: 0x00224344 File Offset: 0x00222544
		public Span<int> GetFormulaParam3Bytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x00224354 File Offset: 0x00222554
		public int[] GetFormulaParam3Array()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x0022436C File Offset: 0x0022256C
		public int FormulaParam4(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06006164 RID: 24932 RVA: 0x002243AC File Offset: 0x002225AC
		public int FormulaParam4Length
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

		// Token: 0x06006165 RID: 24933 RVA: 0x002243D8 File Offset: 0x002225D8
		public Span<int> GetFormulaParam4Bytes()
		{
			return this.__p.__vector_as_span<int>(64, 4);
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x002243E8 File Offset: 0x002225E8
		public int[] GetFormulaParam4Array()
		{
			return this.__p.__vector_as_array<int>(64) ?? Array.Empty<int>();
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x00224400 File Offset: 0x00222600
		public int FormulaParam5(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06006168 RID: 24936 RVA: 0x00224440 File Offset: 0x00222640
		public int FormulaParam5Length
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

		// Token: 0x06006169 RID: 24937 RVA: 0x0022446C File Offset: 0x0022266C
		public Span<int> GetFormulaParam5Bytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x0022447C File Offset: 0x0022267C
		public int[] GetFormulaParam5Array()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x00224494 File Offset: 0x00222694
		public int FormulaParam6(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600616C RID: 24940 RVA: 0x002244D4 File Offset: 0x002226D4
		public int FormulaParam6Length
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00224500 File Offset: 0x00222700
		public Span<int> GetFormulaParam6Bytes()
		{
			return this.__p.__vector_as_span<int>(68, 4);
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00224510 File Offset: 0x00222710
		public int[] GetFormulaParam6Array()
		{
			return this.__p.__vector_as_array<int>(68) ?? Array.Empty<int>();
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00224528 File Offset: 0x00222728
		public int FormulaParam7(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x00224568 File Offset: 0x00222768
		public int FormulaParam7Length
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00224594 File Offset: 0x00222794
		public Span<int> GetFormulaParam7Bytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x002245A4 File Offset: 0x002227A4
		public int[] GetFormulaParam7Array()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x002245BC File Offset: 0x002227BC
		public int FormulaParam8(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x002245FC File Offset: 0x002227FC
		public int FormulaParam8Length
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x00224628 File Offset: 0x00222828
		public Span<int> GetFormulaParam8Bytes()
		{
			return this.__p.__vector_as_span<int>(72, 4);
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00224638 File Offset: 0x00222838
		public int[] GetFormulaParam8Array()
		{
			return this.__p.__vector_as_array<int>(72) ?? Array.Empty<int>();
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x00224650 File Offset: 0x00222850
		public int FormulaParam9(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x00224690 File Offset: 0x00222890
		public int FormulaParam9Length
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x002246BC File Offset: 0x002228BC
		public Span<int> GetFormulaParam9Bytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x002246CC File Offset: 0x002228CC
		public int[] GetFormulaParam9Array()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x002246E4 File Offset: 0x002228E4
		public int FormulaParam10(int j)
		{
			int num = this.__p.__offset(76);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x0600617C RID: 24956 RVA: 0x00224724 File Offset: 0x00222924
		public int FormulaParam10Length
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x00224750 File Offset: 0x00222950
		public Span<int> GetFormulaParam10Bytes()
		{
			return this.__p.__vector_as_span<int>(76, 4);
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00224760 File Offset: 0x00222960
		public int[] GetFormulaParam10Array()
		{
			return this.__p.__vector_as_array<int>(76) ?? Array.Empty<int>();
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x0600617F RID: 24959 RVA: 0x00224778 File Offset: 0x00222978
		public int ImmuneType
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

		// Token: 0x06006180 RID: 24960 RVA: 0x002247B8 File Offset: 0x002229B8
		public int Percent0(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06006181 RID: 24961 RVA: 0x002247F8 File Offset: 0x002229F8
		public int Percent0Length
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x00224824 File Offset: 0x00222A24
		public Span<int> GetPercent0Bytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x00224834 File Offset: 0x00222A34
		public int[] GetPercent0Array()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x0022484C File Offset: 0x00222A4C
		public int Percent1(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06006185 RID: 24965 RVA: 0x0022488C File Offset: 0x00222A8C
		public int Percent1Length
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x002248B8 File Offset: 0x00222AB8
		public Span<int> GetPercent1Bytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x002248C8 File Offset: 0x00222AC8
		public int[] GetPercent1Array()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x002248E0 File Offset: 0x00222AE0
		public int FluctuationLower(int j)
		{
			int num = this.__p.__offset(84);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06006189 RID: 24969 RVA: 0x00224920 File Offset: 0x00222B20
		public int FluctuationLowerLength
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x0022494C File Offset: 0x00222B4C
		public Span<int> GetFluctuationLowerBytes()
		{
			return this.__p.__vector_as_span<int>(84, 4);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x0022495C File Offset: 0x00222B5C
		public int[] GetFluctuationLowerArray()
		{
			return this.__p.__vector_as_array<int>(84) ?? Array.Empty<int>();
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x00224974 File Offset: 0x00222B74
		public int FluctuationUpper(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600618D RID: 24973 RVA: 0x002249B4 File Offset: 0x00222BB4
		public int FluctuationUpperLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x002249E0 File Offset: 0x00222BE0
		public Span<int> GetFluctuationUpperBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x002249F0 File Offset: 0x00222BF0
		public int[] GetFluctuationUpperArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x00224A08 File Offset: 0x00222C08
		public int WeaknessLvl(int j)
		{
			int num = this.__p.__offset(88);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06006191 RID: 24977 RVA: 0x00224A48 File Offset: 0x00222C48
		public int WeaknessLvlLength
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x00224A74 File Offset: 0x00222C74
		public Span<int> GetWeaknessLvlBytes()
		{
			return this.__p.__vector_as_span<int>(88, 4);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00224A84 File Offset: 0x00222C84
		public int[] GetWeaknessLvlArray()
		{
			return this.__p.__vector_as_array<int>(88) ?? Array.Empty<int>();
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00224A9C File Offset: 0x00222C9C
		public DicIntInt? WeaknessRatio(int j)
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06006195 RID: 24981 RVA: 0x00224B00 File Offset: 0x00222D00
		public int WeaknessRatioLength
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06006196 RID: 24982 RVA: 0x00224B2C File Offset: 0x00222D2C
		public int SpecialWeaknessDamageRatio
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00224B6C File Offset: 0x00222D6C
		[NullableContext(1)]
		public Dictionary<string, string> ConstVariables()
		{
			return this.ConstVariablesIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00224BC2 File Offset: 0x00222DC2
		[NullableContext(1)]
		public IEnumerable<DicStringString> ConstVariablesIter()
		{
			Damage.<ConstVariablesIter>d__187 <ConstVariablesIter>d__ = new Damage.<ConstVariablesIter>d__187(-2);
			<ConstVariablesIter>d__.<>3__<>4__this = this;
			return <ConstVariablesIter>d__;
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x00224BD7 File Offset: 0x00222DD7
		[NullableContext(1)]
		public int[] CureBaseValue()
		{
			return this.GetCureBaseValueArray();
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x00224BDF File Offset: 0x00222DDF
		[NullableContext(1)]
		public IEnumerable<int> CureBaseValueIter()
		{
			Damage.<CureBaseValueIter>d__189 <CureBaseValueIter>d__ = new Damage.<CureBaseValueIter>d__189(-2);
			<CureBaseValueIter>d__.<>3__<>4__this = this;
			return <CureBaseValueIter>d__;
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x00224BF4 File Offset: 0x00222DF4
		[NullableContext(1)]
		public int[] Dying()
		{
			return this.GetDyingArray();
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x00224BFC File Offset: 0x00222DFC
		[NullableContext(1)]
		public IEnumerable<int> DyingIter()
		{
			Damage.<DyingIter>d__191 <DyingIter>d__ = new Damage.<DyingIter>d__191(-2);
			<DyingIter>d__.<>3__<>4__this = this;
			return <DyingIter>d__;
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x00224C11 File Offset: 0x00222E11
		[NullableContext(1)]
		public int[] ElementPower()
		{
			return this.GetElementPowerArray();
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x00224C19 File Offset: 0x00222E19
		[NullableContext(1)]
		public IEnumerable<int> ElementPowerIter()
		{
			Damage.<ElementPowerIter>d__193 <ElementPowerIter>d__ = new Damage.<ElementPowerIter>d__193(-2);
			<ElementPowerIter>d__.<>3__<>4__this = this;
			return <ElementPowerIter>d__;
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x00224C2E File Offset: 0x00222E2E
		[NullableContext(1)]
		public int[] Energy()
		{
			return this.GetEnergyArray();
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x00224C36 File Offset: 0x00222E36
		[NullableContext(1)]
		public IEnumerable<int> EnergyIter()
		{
			Damage.<EnergyIter>d__195 <EnergyIter>d__ = new Damage.<EnergyIter>d__195(-2);
			<EnergyIter>d__.<>3__<>4__this = this;
			return <EnergyIter>d__;
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x00224C4B File Offset: 0x00222E4B
		[NullableContext(1)]
		public int[] FluctuationLower()
		{
			return this.GetFluctuationLowerArray();
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x00224C53 File Offset: 0x00222E53
		[NullableContext(1)]
		public IEnumerable<int> FluctuationLowerIter()
		{
			Damage.<FluctuationLowerIter>d__197 <FluctuationLowerIter>d__ = new Damage.<FluctuationLowerIter>d__197(-2);
			<FluctuationLowerIter>d__.<>3__<>4__this = this;
			return <FluctuationLowerIter>d__;
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x00224C68 File Offset: 0x00222E68
		[NullableContext(1)]
		public int[] FluctuationUpper()
		{
			return this.GetFluctuationUpperArray();
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x00224C70 File Offset: 0x00222E70
		[NullableContext(1)]
		public IEnumerable<int> FluctuationUpperIter()
		{
			Damage.<FluctuationUpperIter>d__199 <FluctuationUpperIter>d__ = new Damage.<FluctuationUpperIter>d__199(-2);
			<FluctuationUpperIter>d__.<>3__<>4__this = this;
			return <FluctuationUpperIter>d__;
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00224C85 File Offset: 0x00222E85
		[NullableContext(1)]
		public int[] FormulaParam1()
		{
			return this.GetFormulaParam1Array();
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x00224C8D File Offset: 0x00222E8D
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam1Iter()
		{
			Damage.<FormulaParam1Iter>d__201 <FormulaParam1Iter>d__ = new Damage.<FormulaParam1Iter>d__201(-2);
			<FormulaParam1Iter>d__.<>3__<>4__this = this;
			return <FormulaParam1Iter>d__;
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x00224CA2 File Offset: 0x00222EA2
		[NullableContext(1)]
		public int[] FormulaParam10()
		{
			return this.GetFormulaParam10Array();
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00224CAA File Offset: 0x00222EAA
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam10Iter()
		{
			Damage.<FormulaParam10Iter>d__203 <FormulaParam10Iter>d__ = new Damage.<FormulaParam10Iter>d__203(-2);
			<FormulaParam10Iter>d__.<>3__<>4__this = this;
			return <FormulaParam10Iter>d__;
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00224CBF File Offset: 0x00222EBF
		[NullableContext(1)]
		public int[] FormulaParam2()
		{
			return this.GetFormulaParam2Array();
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00224CC7 File Offset: 0x00222EC7
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam2Iter()
		{
			Damage.<FormulaParam2Iter>d__205 <FormulaParam2Iter>d__ = new Damage.<FormulaParam2Iter>d__205(-2);
			<FormulaParam2Iter>d__.<>3__<>4__this = this;
			return <FormulaParam2Iter>d__;
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00224CDC File Offset: 0x00222EDC
		[NullableContext(1)]
		public int[] FormulaParam3()
		{
			return this.GetFormulaParam3Array();
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00224CE4 File Offset: 0x00222EE4
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam3Iter()
		{
			Damage.<FormulaParam3Iter>d__207 <FormulaParam3Iter>d__ = new Damage.<FormulaParam3Iter>d__207(-2);
			<FormulaParam3Iter>d__.<>3__<>4__this = this;
			return <FormulaParam3Iter>d__;
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x00224CF9 File Offset: 0x00222EF9
		[NullableContext(1)]
		public int[] FormulaParam4()
		{
			return this.GetFormulaParam4Array();
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x00224D01 File Offset: 0x00222F01
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam4Iter()
		{
			Damage.<FormulaParam4Iter>d__209 <FormulaParam4Iter>d__ = new Damage.<FormulaParam4Iter>d__209(-2);
			<FormulaParam4Iter>d__.<>3__<>4__this = this;
			return <FormulaParam4Iter>d__;
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x00224D16 File Offset: 0x00222F16
		[NullableContext(1)]
		public int[] FormulaParam5()
		{
			return this.GetFormulaParam5Array();
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00224D1E File Offset: 0x00222F1E
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam5Iter()
		{
			Damage.<FormulaParam5Iter>d__211 <FormulaParam5Iter>d__ = new Damage.<FormulaParam5Iter>d__211(-2);
			<FormulaParam5Iter>d__.<>3__<>4__this = this;
			return <FormulaParam5Iter>d__;
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00224D33 File Offset: 0x00222F33
		[NullableContext(1)]
		public int[] FormulaParam6()
		{
			return this.GetFormulaParam6Array();
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x00224D3B File Offset: 0x00222F3B
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam6Iter()
		{
			Damage.<FormulaParam6Iter>d__213 <FormulaParam6Iter>d__ = new Damage.<FormulaParam6Iter>d__213(-2);
			<FormulaParam6Iter>d__.<>3__<>4__this = this;
			return <FormulaParam6Iter>d__;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00224D50 File Offset: 0x00222F50
		[NullableContext(1)]
		public int[] FormulaParam7()
		{
			return this.GetFormulaParam7Array();
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00224D58 File Offset: 0x00222F58
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam7Iter()
		{
			Damage.<FormulaParam7Iter>d__215 <FormulaParam7Iter>d__ = new Damage.<FormulaParam7Iter>d__215(-2);
			<FormulaParam7Iter>d__.<>3__<>4__this = this;
			return <FormulaParam7Iter>d__;
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x00224D6D File Offset: 0x00222F6D
		[NullableContext(1)]
		public int[] FormulaParam8()
		{
			return this.GetFormulaParam8Array();
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x00224D75 File Offset: 0x00222F75
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam8Iter()
		{
			Damage.<FormulaParam8Iter>d__217 <FormulaParam8Iter>d__ = new Damage.<FormulaParam8Iter>d__217(-2);
			<FormulaParam8Iter>d__.<>3__<>4__this = this;
			return <FormulaParam8Iter>d__;
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x00224D8A File Offset: 0x00222F8A
		[NullableContext(1)]
		public int[] FormulaParam9()
		{
			return this.GetFormulaParam9Array();
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x00224D92 File Offset: 0x00222F92
		[NullableContext(1)]
		public IEnumerable<int> FormulaParam9Iter()
		{
			Damage.<FormulaParam9Iter>d__219 <FormulaParam9Iter>d__ = new Damage.<FormulaParam9Iter>d__219(-2);
			<FormulaParam9Iter>d__.<>3__<>4__this = this;
			return <FormulaParam9Iter>d__;
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00224DA7 File Offset: 0x00222FA7
		[NullableContext(1)]
		public int[] HardnessLv()
		{
			return this.GetHardnessLvArray();
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x00224DAF File Offset: 0x00222FAF
		[NullableContext(1)]
		public IEnumerable<int> HardnessLvIter()
		{
			Damage.<HardnessLvIter>d__221 <HardnessLvIter>d__ = new Damage.<HardnessLvIter>d__221(-2);
			<HardnessLvIter>d__.<>3__<>4__this = this;
			return <HardnessLvIter>d__;
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x00224DC4 File Offset: 0x00222FC4
		[NullableContext(1)]
		public int[] Percent0()
		{
			return this.GetPercent0Array();
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x00224DCC File Offset: 0x00222FCC
		[NullableContext(1)]
		public IEnumerable<int> Percent0Iter()
		{
			Damage.<Percent0Iter>d__223 <Percent0Iter>d__ = new Damage.<Percent0Iter>d__223(-2);
			<Percent0Iter>d__.<>3__<>4__this = this;
			return <Percent0Iter>d__;
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x00224DE1 File Offset: 0x00222FE1
		[NullableContext(1)]
		public int[] Percent1()
		{
			return this.GetPercent1Array();
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x00224DE9 File Offset: 0x00222FE9
		[NullableContext(1)]
		public IEnumerable<int> Percent1Iter()
		{
			Damage.<Percent1Iter>d__225 <Percent1Iter>d__ = new Damage.<Percent1Iter>d__225(-2);
			<Percent1Iter>d__.<>3__<>4__this = this;
			return <Percent1Iter>d__;
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x00224DFE File Offset: 0x00222FFE
		[NullableContext(1)]
		public int[] RateLv()
		{
			return this.GetRateLvArray();
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x00224E06 File Offset: 0x00223006
		[NullableContext(1)]
		public IEnumerable<int> RateLvIter()
		{
			Damage.<RateLvIter>d__227 <RateLvIter>d__ = new Damage.<RateLvIter>d__227(-2);
			<RateLvIter>d__.<>3__<>4__this = this;
			return <RateLvIter>d__;
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x00224E1B File Offset: 0x0022301B
		[NullableContext(1)]
		public int[] SpecialEnergy1()
		{
			return this.GetSpecialEnergy1Array();
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x00224E23 File Offset: 0x00223023
		[NullableContext(1)]
		public IEnumerable<int> SpecialEnergy1Iter()
		{
			Damage.<SpecialEnergy1Iter>d__229 <SpecialEnergy1Iter>d__ = new Damage.<SpecialEnergy1Iter>d__229(-2);
			<SpecialEnergy1Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy1Iter>d__;
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x00224E38 File Offset: 0x00223038
		[NullableContext(1)]
		public int[] SpecialEnergy2()
		{
			return this.GetSpecialEnergy2Array();
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x00224E40 File Offset: 0x00223040
		[NullableContext(1)]
		public IEnumerable<int> SpecialEnergy2Iter()
		{
			Damage.<SpecialEnergy2Iter>d__231 <SpecialEnergy2Iter>d__ = new Damage.<SpecialEnergy2Iter>d__231(-2);
			<SpecialEnergy2Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy2Iter>d__;
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x00224E55 File Offset: 0x00223055
		[NullableContext(1)]
		public int[] SpecialEnergy3()
		{
			return this.GetSpecialEnergy3Array();
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x00224E5D File Offset: 0x0022305D
		[NullableContext(1)]
		public IEnumerable<int> SpecialEnergy3Iter()
		{
			Damage.<SpecialEnergy3Iter>d__233 <SpecialEnergy3Iter>d__ = new Damage.<SpecialEnergy3Iter>d__233(-2);
			<SpecialEnergy3Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy3Iter>d__;
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x00224E72 File Offset: 0x00223072
		[NullableContext(1)]
		public int[] SpecialEnergy4()
		{
			return this.GetSpecialEnergy4Array();
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x00224E7A File Offset: 0x0022307A
		[NullableContext(1)]
		public IEnumerable<int> SpecialEnergy4Iter()
		{
			Damage.<SpecialEnergy4Iter>d__235 <SpecialEnergy4Iter>d__ = new Damage.<SpecialEnergy4Iter>d__235(-2);
			<SpecialEnergy4Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy4Iter>d__;
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x00224E8F File Offset: 0x0022308F
		[NullableContext(1)]
		public int[] SpecialEnergy5()
		{
			return this.GetSpecialEnergy5Array();
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x00224E97 File Offset: 0x00223097
		[NullableContext(1)]
		public IEnumerable<int> SpecialEnergy5Iter()
		{
			Damage.<SpecialEnergy5Iter>d__237 <SpecialEnergy5Iter>d__ = new Damage.<SpecialEnergy5Iter>d__237(-2);
			<SpecialEnergy5Iter>d__.<>3__<>4__this = this;
			return <SpecialEnergy5Iter>d__;
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x00224EAC File Offset: 0x002230AC
		[NullableContext(1)]
		public int[] SubType()
		{
			return this.GetSubTypeArray();
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x00224EB4 File Offset: 0x002230B4
		[NullableContext(1)]
		public IEnumerable<int> SubTypeIter()
		{
			Damage.<SubTypeIter>d__239 <SubTypeIter>d__ = new Damage.<SubTypeIter>d__239(-2);
			<SubTypeIter>d__.<>3__<>4__this = this;
			return <SubTypeIter>d__;
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x00224EC9 File Offset: 0x002230C9
		[NullableContext(1)]
		public int[] ToughLv()
		{
			return this.GetToughLvArray();
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x00224ED1 File Offset: 0x002230D1
		[NullableContext(1)]
		public IEnumerable<int> ToughLvIter()
		{
			Damage.<ToughLvIter>d__241 <ToughLvIter>d__ = new Damage.<ToughLvIter>d__241(-2);
			<ToughLvIter>d__.<>3__<>4__this = this;
			return <ToughLvIter>d__;
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x00224EE6 File Offset: 0x002230E6
		[NullableContext(1)]
		public int[] WeaknessLvl()
		{
			return this.GetWeaknessLvlArray();
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00224EEE File Offset: 0x002230EE
		[NullableContext(1)]
		public IEnumerable<int> WeaknessLvlIter()
		{
			Damage.<WeaknessLvlIter>d__243 <WeaknessLvlIter>d__ = new Damage.<WeaknessLvlIter>d__243(-2);
			<WeaknessLvlIter>d__.<>3__<>4__this = this;
			return <WeaknessLvlIter>d__;
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x00224F04 File Offset: 0x00223104
		[NullableContext(1)]
		public Dictionary<int, int> WeaknessRatio()
		{
			return this.WeaknessRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x00224F5A File Offset: 0x0022315A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> WeaknessRatioIter()
		{
			Damage.<WeaknessRatioIter>d__245 <WeaknessRatioIter>d__ = new Damage.<WeaknessRatioIter>d__245(-2);
			<WeaknessRatioIter>d__.<>3__<>4__this = this;
			return <WeaknessRatioIter>d__;
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x00224F70 File Offset: 0x00223170
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetConstVariables(string key)
		{
			this.EnsureConstVariablesCacheIfNeeded();
			string result;
			if (!this.ConstVariablesCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x00224F98 File Offset: 0x00223198
		public int? GetWeaknessRatio(int key)
		{
			this.EnsureWeaknessRatioCacheIfNeeded();
			int value;
			if (!this.WeaknessRatioCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x00224FCC File Offset: 0x002231CC
		private void EnsureConstVariablesCacheIfNeeded()
		{
			if (this.ConstVariablesCache != null)
			{
				return;
			}
			this.ConstVariablesCache = this.ConstVariablesIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x00225034 File Offset: 0x00223234
		private void EnsureWeaknessRatioCacheIfNeeded()
		{
			if (this.WeaknessRatioCache != null)
			{
				return;
			}
			this.WeaknessRatioCache = this.WeaknessRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x0022509A File Offset: 0x0022329A
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetConstVariablesFrozenDict()
		{
			this.EnsureConstVariablesCacheIfNeeded();
			return this.ConstVariablesCache;
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x002250A8 File Offset: 0x002232A8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetWeaknessRatioFrozenDict()
		{
			this.EnsureWeaknessRatioCacheIfNeeded();
			return this.WeaknessRatioCache;
		}

		// Token: 0x040051BD RID: 20925
		private Table __p;

		// Token: 0x040051BE RID: 20926
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> ConstVariablesCache;

		// Token: 0x040051BF RID: 20927
		[Nullable(2)]
		private FrozenDictionary<int, int> WeaknessRatioCache;
	}
}
