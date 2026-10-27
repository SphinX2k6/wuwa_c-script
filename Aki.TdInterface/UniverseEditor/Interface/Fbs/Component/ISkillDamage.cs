using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005917 RID: 22807
	public struct ISkillDamage : IFlatbufferObject
	{
		// Token: 0x1700AAF7 RID: 43767
		// (get) Token: 0x060268C4 RID: 157892 RVA: 0x0054F5B6 File Offset: 0x0054D7B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060268C5 RID: 157893 RVA: 0x0054F5C3 File Offset: 0x0054D7C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060268C6 RID: 157894 RVA: 0x0054F5CC File Offset: 0x0054D7CC
		public static ISkillDamage GetRootAsISkillDamage(ByteBuffer _bb)
		{
			return ISkillDamage.GetRootAsISkillDamage(_bb, default(ISkillDamage));
		}

		// Token: 0x060268C7 RID: 157895 RVA: 0x0054F5E8 File Offset: 0x0054D7E8
		public static ISkillDamage GetRootAsISkillDamage(ByteBuffer _bb, ISkillDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060268C8 RID: 157896 RVA: 0x0054F605 File Offset: 0x0054D805
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060268C9 RID: 157897 RVA: 0x0054F614 File Offset: 0x0054D814
		public ISkillDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAF8 RID: 43768
		// (get) Token: 0x060268CA RID: 157898 RVA: 0x0054F624 File Offset: 0x0054D824
		public int DefaultValue
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

		// Token: 0x1700AAF9 RID: 43769
		// (get) Token: 0x060268CB RID: 157899 RVA: 0x0054F660 File Offset: 0x0054D860
		public int NormalAttack
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

		// Token: 0x1700AAFA RID: 43770
		// (get) Token: 0x060268CC RID: 157900 RVA: 0x0054F69C File Offset: 0x0054D89C
		public int AccumulatorAttack
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

		// Token: 0x1700AAFB RID: 43771
		// (get) Token: 0x060268CD RID: 157901 RVA: 0x0054F6D8 File Offset: 0x0054D8D8
		public int SuperSkill
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

		// Token: 0x1700AAFC RID: 43772
		// (get) Token: 0x060268CE RID: 157902 RVA: 0x0054F718 File Offset: 0x0054D918
		public int QteAttack
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

		// Token: 0x1700AAFD RID: 43773
		// (get) Token: 0x060268CF RID: 157903 RVA: 0x0054F758 File Offset: 0x0054D958
		public int NormalSkill
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

		// Token: 0x1700AAFE RID: 43774
		// (get) Token: 0x060268D0 RID: 157904 RVA: 0x0054F798 File Offset: 0x0054D998
		public int FightVersion
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

		// Token: 0x1700AAFF RID: 43775
		// (get) Token: 0x060268D1 RID: 157905 RVA: 0x0054F7D8 File Offset: 0x0054D9D8
		public int ExploreVersion
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

		// Token: 0x1700AB00 RID: 43776
		// (get) Token: 0x060268D2 RID: 157906 RVA: 0x0054F818 File Offset: 0x0054DA18
		public int GearOrEnvironment
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

		// Token: 0x1700AB01 RID: 43777
		// (get) Token: 0x060268D3 RID: 157907 RVA: 0x0054F858 File Offset: 0x0054DA58
		public int DamageOverTime
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

		// Token: 0x1700AB02 RID: 43778
		// (get) Token: 0x060268D4 RID: 157908 RVA: 0x0054F898 File Offset: 0x0054DA98
		public ushort NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060268D5 RID: 157909 RVA: 0x0054F8D8 File Offset: 0x0054DAD8
		public static Offset<ISkillDamage> CreateISkillDamage(FlatBufferBuilder builder, int DefaultValue = 0, int NormalAttack = 0, int AccumulatorAttack = 0, int SuperSkill = 0, int QteAttack = 0, int NormalSkill = 0, int FightVersion = 0, int ExploreVersion = 0, int GearOrEnvironment = 0, int DamageOverTime = 0, ushort NullMask = 0)
		{
			builder.StartTable(11);
			ISkillDamage.AddDamageOverTime(builder, DamageOverTime);
			ISkillDamage.AddGearOrEnvironment(builder, GearOrEnvironment);
			ISkillDamage.AddExploreVersion(builder, ExploreVersion);
			ISkillDamage.AddFightVersion(builder, FightVersion);
			ISkillDamage.AddNormalSkill(builder, NormalSkill);
			ISkillDamage.AddQteAttack(builder, QteAttack);
			ISkillDamage.AddSuperSkill(builder, SuperSkill);
			ISkillDamage.AddAccumulatorAttack(builder, AccumulatorAttack);
			ISkillDamage.AddNormalAttack(builder, NormalAttack);
			ISkillDamage.AddDefaultValue(builder, DefaultValue);
			ISkillDamage.AddNullMask(builder, NullMask);
			return ISkillDamage.EndISkillDamage(builder);
		}

		// Token: 0x060268D6 RID: 157910 RVA: 0x0054F948 File Offset: 0x0054DB48
		public static void StartISkillDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060268D7 RID: 157911 RVA: 0x0054F952 File Offset: 0x0054DB52
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x060268D8 RID: 157912 RVA: 0x0054F95D File Offset: 0x0054DB5D
		public static void AddNormalAttack(FlatBufferBuilder builder, int normalAttack)
		{
			builder.AddInt(1, normalAttack, 0);
		}

		// Token: 0x060268D9 RID: 157913 RVA: 0x0054F968 File Offset: 0x0054DB68
		public static void AddAccumulatorAttack(FlatBufferBuilder builder, int accumulatorAttack)
		{
			builder.AddInt(2, accumulatorAttack, 0);
		}

		// Token: 0x060268DA RID: 157914 RVA: 0x0054F973 File Offset: 0x0054DB73
		public static void AddSuperSkill(FlatBufferBuilder builder, int superSkill)
		{
			builder.AddInt(3, superSkill, 0);
		}

		// Token: 0x060268DB RID: 157915 RVA: 0x0054F97E File Offset: 0x0054DB7E
		public static void AddQteAttack(FlatBufferBuilder builder, int qteAttack)
		{
			builder.AddInt(4, qteAttack, 0);
		}

		// Token: 0x060268DC RID: 157916 RVA: 0x0054F989 File Offset: 0x0054DB89
		public static void AddNormalSkill(FlatBufferBuilder builder, int normalSkill)
		{
			builder.AddInt(5, normalSkill, 0);
		}

		// Token: 0x060268DD RID: 157917 RVA: 0x0054F994 File Offset: 0x0054DB94
		public static void AddFightVersion(FlatBufferBuilder builder, int fightVersion)
		{
			builder.AddInt(6, fightVersion, 0);
		}

		// Token: 0x060268DE RID: 157918 RVA: 0x0054F99F File Offset: 0x0054DB9F
		public static void AddExploreVersion(FlatBufferBuilder builder, int exploreVersion)
		{
			builder.AddInt(7, exploreVersion, 0);
		}

		// Token: 0x060268DF RID: 157919 RVA: 0x0054F9AA File Offset: 0x0054DBAA
		public static void AddGearOrEnvironment(FlatBufferBuilder builder, int gearOrEnvironment)
		{
			builder.AddInt(8, gearOrEnvironment, 0);
		}

		// Token: 0x060268E0 RID: 157920 RVA: 0x0054F9B5 File Offset: 0x0054DBB5
		public static void AddDamageOverTime(FlatBufferBuilder builder, int damageOverTime)
		{
			builder.AddInt(9, damageOverTime, 0);
		}

		// Token: 0x060268E1 RID: 157921 RVA: 0x0054F9C1 File Offset: 0x0054DBC1
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(10, nullMask, 0);
		}

		// Token: 0x060268E2 RID: 157922 RVA: 0x0054F9CD File Offset: 0x0054DBCD
		public static Offset<ISkillDamage> EndISkillDamage(FlatBufferBuilder builder)
		{
			return new Offset<ISkillDamage>(builder.EndTable());
		}

		// Token: 0x060268E3 RID: 157923 RVA: 0x0054F9DC File Offset: 0x0054DBDC
		public ISkillDamageT UnPack()
		{
			ISkillDamageT skillDamageT = new ISkillDamageT();
			this.UnPackTo(skillDamageT);
			return skillDamageT;
		}

		// Token: 0x060268E4 RID: 157924 RVA: 0x0054F9F8 File Offset: 0x0054DBF8
		public void UnPackTo(ISkillDamageT _o)
		{
			_o.DefaultValue = this.DefaultValue;
			_o.NormalAttack = this.NormalAttack;
			_o.AccumulatorAttack = this.AccumulatorAttack;
			_o.SuperSkill = this.SuperSkill;
			_o.QteAttack = this.QteAttack;
			_o.NormalSkill = this.NormalSkill;
			_o.FightVersion = this.FightVersion;
			_o.ExploreVersion = this.ExploreVersion;
			_o.GearOrEnvironment = this.GearOrEnvironment;
			_o.DamageOverTime = this.DamageOverTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060268E5 RID: 157925 RVA: 0x0054FA8C File Offset: 0x0054DC8C
		public static Offset<ISkillDamage> Pack(FlatBufferBuilder builder, ISkillDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillDamage>);
			}
			return ISkillDamage.CreateISkillDamage(builder, _o.DefaultValue, _o.NormalAttack, _o.AccumulatorAttack, _o.SuperSkill, _o.QteAttack, _o.NormalSkill, _o.FightVersion, _o.ExploreVersion, _o.GearOrEnvironment, _o.DamageOverTime, _o.NullMask);
		}

		// Token: 0x0400EEBC RID: 61116
		private Table __p;
	}
}
