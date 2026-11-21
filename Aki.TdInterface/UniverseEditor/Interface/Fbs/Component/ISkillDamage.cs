using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F24 RID: 24356
	public struct ISkillDamage : IFlatbufferObject
	{
		// Token: 0x1700B42B RID: 46123
		// (get) Token: 0x06028E2E RID: 167470 RVA: 0x00596222 File Offset: 0x00594422
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028E2F RID: 167471 RVA: 0x0059622F File Offset: 0x0059442F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028E30 RID: 167472 RVA: 0x00596238 File Offset: 0x00594438
		public static ISkillDamage GetRootAsISkillDamage(ByteBuffer _bb)
		{
			return ISkillDamage.GetRootAsISkillDamage(_bb, default(ISkillDamage));
		}

		// Token: 0x06028E31 RID: 167473 RVA: 0x00596254 File Offset: 0x00594454
		public static ISkillDamage GetRootAsISkillDamage(ByteBuffer _bb, ISkillDamage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028E32 RID: 167474 RVA: 0x00596271 File Offset: 0x00594471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028E33 RID: 167475 RVA: 0x00596280 File Offset: 0x00594480
		public ISkillDamage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B42C RID: 46124
		// (get) Token: 0x06028E34 RID: 167476 RVA: 0x00596290 File Offset: 0x00594490
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

		// Token: 0x1700B42D RID: 46125
		// (get) Token: 0x06028E35 RID: 167477 RVA: 0x005962CC File Offset: 0x005944CC
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

		// Token: 0x1700B42E RID: 46126
		// (get) Token: 0x06028E36 RID: 167478 RVA: 0x00596308 File Offset: 0x00594508
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

		// Token: 0x1700B42F RID: 46127
		// (get) Token: 0x06028E37 RID: 167479 RVA: 0x00596344 File Offset: 0x00594544
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

		// Token: 0x1700B430 RID: 46128
		// (get) Token: 0x06028E38 RID: 167480 RVA: 0x00596384 File Offset: 0x00594584
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

		// Token: 0x1700B431 RID: 46129
		// (get) Token: 0x06028E39 RID: 167481 RVA: 0x005963C4 File Offset: 0x005945C4
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

		// Token: 0x1700B432 RID: 46130
		// (get) Token: 0x06028E3A RID: 167482 RVA: 0x00596404 File Offset: 0x00594604
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

		// Token: 0x1700B433 RID: 46131
		// (get) Token: 0x06028E3B RID: 167483 RVA: 0x00596444 File Offset: 0x00594644
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

		// Token: 0x1700B434 RID: 46132
		// (get) Token: 0x06028E3C RID: 167484 RVA: 0x00596484 File Offset: 0x00594684
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

		// Token: 0x1700B435 RID: 46133
		// (get) Token: 0x06028E3D RID: 167485 RVA: 0x005964C4 File Offset: 0x005946C4
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

		// Token: 0x1700B436 RID: 46134
		// (get) Token: 0x06028E3E RID: 167486 RVA: 0x00596504 File Offset: 0x00594704
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

		// Token: 0x06028E3F RID: 167487 RVA: 0x00596544 File Offset: 0x00594744
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

		// Token: 0x06028E40 RID: 167488 RVA: 0x005965B4 File Offset: 0x005947B4
		public static void StartISkillDamage(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06028E41 RID: 167489 RVA: 0x005965BE File Offset: 0x005947BE
		public static void AddDefaultValue(FlatBufferBuilder builder, int defaultValue)
		{
			builder.AddInt(0, defaultValue, 0);
		}

		// Token: 0x06028E42 RID: 167490 RVA: 0x005965C9 File Offset: 0x005947C9
		public static void AddNormalAttack(FlatBufferBuilder builder, int normalAttack)
		{
			builder.AddInt(1, normalAttack, 0);
		}

		// Token: 0x06028E43 RID: 167491 RVA: 0x005965D4 File Offset: 0x005947D4
		public static void AddAccumulatorAttack(FlatBufferBuilder builder, int accumulatorAttack)
		{
			builder.AddInt(2, accumulatorAttack, 0);
		}

		// Token: 0x06028E44 RID: 167492 RVA: 0x005965DF File Offset: 0x005947DF
		public static void AddSuperSkill(FlatBufferBuilder builder, int superSkill)
		{
			builder.AddInt(3, superSkill, 0);
		}

		// Token: 0x06028E45 RID: 167493 RVA: 0x005965EA File Offset: 0x005947EA
		public static void AddQteAttack(FlatBufferBuilder builder, int qteAttack)
		{
			builder.AddInt(4, qteAttack, 0);
		}

		// Token: 0x06028E46 RID: 167494 RVA: 0x005965F5 File Offset: 0x005947F5
		public static void AddNormalSkill(FlatBufferBuilder builder, int normalSkill)
		{
			builder.AddInt(5, normalSkill, 0);
		}

		// Token: 0x06028E47 RID: 167495 RVA: 0x00596600 File Offset: 0x00594800
		public static void AddFightVersion(FlatBufferBuilder builder, int fightVersion)
		{
			builder.AddInt(6, fightVersion, 0);
		}

		// Token: 0x06028E48 RID: 167496 RVA: 0x0059660B File Offset: 0x0059480B
		public static void AddExploreVersion(FlatBufferBuilder builder, int exploreVersion)
		{
			builder.AddInt(7, exploreVersion, 0);
		}

		// Token: 0x06028E49 RID: 167497 RVA: 0x00596616 File Offset: 0x00594816
		public static void AddGearOrEnvironment(FlatBufferBuilder builder, int gearOrEnvironment)
		{
			builder.AddInt(8, gearOrEnvironment, 0);
		}

		// Token: 0x06028E4A RID: 167498 RVA: 0x00596621 File Offset: 0x00594821
		public static void AddDamageOverTime(FlatBufferBuilder builder, int damageOverTime)
		{
			builder.AddInt(9, damageOverTime, 0);
		}

		// Token: 0x06028E4B RID: 167499 RVA: 0x0059662D File Offset: 0x0059482D
		public static void AddNullMask(FlatBufferBuilder builder, ushort nullMask)
		{
			builder.AddUshort(10, nullMask, 0);
		}

		// Token: 0x06028E4C RID: 167500 RVA: 0x00596639 File Offset: 0x00594839
		public static Offset<ISkillDamage> EndISkillDamage(FlatBufferBuilder builder)
		{
			return new Offset<ISkillDamage>(builder.EndTable());
		}

		// Token: 0x06028E4D RID: 167501 RVA: 0x00596648 File Offset: 0x00594848
		public ISkillDamageT UnPack()
		{
			ISkillDamageT skillDamageT = new ISkillDamageT();
			this.UnPackTo(skillDamageT);
			return skillDamageT;
		}

		// Token: 0x06028E4E RID: 167502 RVA: 0x00596664 File Offset: 0x00594864
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

		// Token: 0x06028E4F RID: 167503 RVA: 0x005966F8 File Offset: 0x005948F8
		public static Offset<ISkillDamage> Pack(FlatBufferBuilder builder, ISkillDamageT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISkillDamage>);
			}
			return ISkillDamage.CreateISkillDamage(builder, _o.DefaultValue, _o.NormalAttack, _o.AccumulatorAttack, _o.SuperSkill, _o.QteAttack, _o.NormalSkill, _o.FightVersion, _o.ExploreVersion, _o.GearOrEnvironment, _o.DamageOverTime, _o.NullMask);
		}

		// Token: 0x0400FBB1 RID: 64433
		private Table __p;
	}
}
