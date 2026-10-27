using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200446D RID: 17517
	public struct IDartCompetitorSkills : IFlatbufferObject
	{
		// Token: 0x17007B9E RID: 31646
		// (get) Token: 0x0601A1B6 RID: 106934 RVA: 0x003BAEAB File Offset: 0x003B90AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A1B7 RID: 106935 RVA: 0x003BAEB8 File Offset: 0x003B90B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A1B8 RID: 106936 RVA: 0x003BAEC0 File Offset: 0x003B90C0
		public static IDartCompetitorSkills GetRootAsIDartCompetitorSkills(ByteBuffer _bb)
		{
			return IDartCompetitorSkills.GetRootAsIDartCompetitorSkills(_bb, default(IDartCompetitorSkills));
		}

		// Token: 0x0601A1B9 RID: 106937 RVA: 0x003BAEDC File Offset: 0x003B90DC
		public static IDartCompetitorSkills GetRootAsIDartCompetitorSkills(ByteBuffer _bb, IDartCompetitorSkills obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A1BA RID: 106938 RVA: 0x003BAEF9 File Offset: 0x003B90F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A1BB RID: 106939 RVA: 0x003BAF08 File Offset: 0x003B9108
		public IDartCompetitorSkills __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B9F RID: 31647
		// (get) Token: 0x0601A1BC RID: 106940 RVA: 0x003BAF18 File Offset: 0x003B9118
		public int Mode301Skill
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

		// Token: 0x17007BA0 RID: 31648
		// (get) Token: 0x0601A1BD RID: 106941 RVA: 0x003BAF54 File Offset: 0x003B9154
		public int Mode501Skill
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

		// Token: 0x17007BA1 RID: 31649
		// (get) Token: 0x0601A1BE RID: 106942 RVA: 0x003BAF90 File Offset: 0x003B9190
		public int Mode701Skill
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

		// Token: 0x0601A1BF RID: 106943 RVA: 0x003BAFCC File Offset: 0x003B91CC
		public static Offset<IDartCompetitorSkills> CreateIDartCompetitorSkills(FlatBufferBuilder builder, int Mode301Skill = 0, int Mode501Skill = 0, int Mode701Skill = 0)
		{
			builder.StartTable(3);
			IDartCompetitorSkills.AddMode701Skill(builder, Mode701Skill);
			IDartCompetitorSkills.AddMode501Skill(builder, Mode501Skill);
			IDartCompetitorSkills.AddMode301Skill(builder, Mode301Skill);
			return IDartCompetitorSkills.EndIDartCompetitorSkills(builder);
		}

		// Token: 0x0601A1C0 RID: 106944 RVA: 0x003BAFF0 File Offset: 0x003B91F0
		public static void StartIDartCompetitorSkills(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A1C1 RID: 106945 RVA: 0x003BAFF9 File Offset: 0x003B91F9
		public static void AddMode301Skill(FlatBufferBuilder builder, int mode301Skill)
		{
			builder.AddInt(0, mode301Skill, 0);
		}

		// Token: 0x0601A1C2 RID: 106946 RVA: 0x003BB004 File Offset: 0x003B9204
		public static void AddMode501Skill(FlatBufferBuilder builder, int mode501Skill)
		{
			builder.AddInt(1, mode501Skill, 0);
		}

		// Token: 0x0601A1C3 RID: 106947 RVA: 0x003BB00F File Offset: 0x003B920F
		public static void AddMode701Skill(FlatBufferBuilder builder, int mode701Skill)
		{
			builder.AddInt(2, mode701Skill, 0);
		}

		// Token: 0x0601A1C4 RID: 106948 RVA: 0x003BB01A File Offset: 0x003B921A
		public static Offset<IDartCompetitorSkills> EndIDartCompetitorSkills(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorSkills>(builder.EndTable());
		}

		// Token: 0x0601A1C5 RID: 106949 RVA: 0x003BB028 File Offset: 0x003B9228
		public IDartCompetitorSkillsT UnPack()
		{
			IDartCompetitorSkillsT dartCompetitorSkillsT = new IDartCompetitorSkillsT();
			this.UnPackTo(dartCompetitorSkillsT);
			return dartCompetitorSkillsT;
		}

		// Token: 0x0601A1C6 RID: 106950 RVA: 0x003BB043 File Offset: 0x003B9243
		public void UnPackTo(IDartCompetitorSkillsT _o)
		{
			_o.Mode301Skill = this.Mode301Skill;
			_o.Mode501Skill = this.Mode501Skill;
			_o.Mode701Skill = this.Mode701Skill;
		}

		// Token: 0x0601A1C7 RID: 106951 RVA: 0x003BB06C File Offset: 0x003B926C
		public static Offset<IDartCompetitorSkills> Pack(FlatBufferBuilder builder, IDartCompetitorSkillsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartCompetitorSkills>);
			}
			return IDartCompetitorSkills.CreateIDartCompetitorSkills(builder, _o.Mode301Skill, _o.Mode501Skill, _o.Mode701Skill);
		}

		// Token: 0x0400C460 RID: 50272
		private Table __p;
	}
}
