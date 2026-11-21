using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048D5 RID: 18645
	public struct IDartCompetitorSkills : IFlatbufferObject
	{
		// Token: 0x170081DD RID: 33245
		// (get) Token: 0x0601B987 RID: 113031 RVA: 0x003E70B7 File Offset: 0x003E52B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B988 RID: 113032 RVA: 0x003E70C4 File Offset: 0x003E52C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B989 RID: 113033 RVA: 0x003E70CC File Offset: 0x003E52CC
		public static IDartCompetitorSkills GetRootAsIDartCompetitorSkills(ByteBuffer _bb)
		{
			return IDartCompetitorSkills.GetRootAsIDartCompetitorSkills(_bb, default(IDartCompetitorSkills));
		}

		// Token: 0x0601B98A RID: 113034 RVA: 0x003E70E8 File Offset: 0x003E52E8
		public static IDartCompetitorSkills GetRootAsIDartCompetitorSkills(ByteBuffer _bb, IDartCompetitorSkills obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x003E7105 File Offset: 0x003E5305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B98C RID: 113036 RVA: 0x003E7114 File Offset: 0x003E5314
		public IDartCompetitorSkills __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081DE RID: 33246
		// (get) Token: 0x0601B98D RID: 113037 RVA: 0x003E7124 File Offset: 0x003E5324
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

		// Token: 0x170081DF RID: 33247
		// (get) Token: 0x0601B98E RID: 113038 RVA: 0x003E7160 File Offset: 0x003E5360
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

		// Token: 0x170081E0 RID: 33248
		// (get) Token: 0x0601B98F RID: 113039 RVA: 0x003E719C File Offset: 0x003E539C
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

		// Token: 0x0601B990 RID: 113040 RVA: 0x003E71D8 File Offset: 0x003E53D8
		public static Offset<IDartCompetitorSkills> CreateIDartCompetitorSkills(FlatBufferBuilder builder, int Mode301Skill = 0, int Mode501Skill = 0, int Mode701Skill = 0)
		{
			builder.StartTable(3);
			IDartCompetitorSkills.AddMode701Skill(builder, Mode701Skill);
			IDartCompetitorSkills.AddMode501Skill(builder, Mode501Skill);
			IDartCompetitorSkills.AddMode301Skill(builder, Mode301Skill);
			return IDartCompetitorSkills.EndIDartCompetitorSkills(builder);
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x003E71FC File Offset: 0x003E53FC
		public static void StartIDartCompetitorSkills(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B992 RID: 113042 RVA: 0x003E7205 File Offset: 0x003E5405
		public static void AddMode301Skill(FlatBufferBuilder builder, int mode301Skill)
		{
			builder.AddInt(0, mode301Skill, 0);
		}

		// Token: 0x0601B993 RID: 113043 RVA: 0x003E7210 File Offset: 0x003E5410
		public static void AddMode501Skill(FlatBufferBuilder builder, int mode501Skill)
		{
			builder.AddInt(1, mode501Skill, 0);
		}

		// Token: 0x0601B994 RID: 113044 RVA: 0x003E721B File Offset: 0x003E541B
		public static void AddMode701Skill(FlatBufferBuilder builder, int mode701Skill)
		{
			builder.AddInt(2, mode701Skill, 0);
		}

		// Token: 0x0601B995 RID: 113045 RVA: 0x003E7226 File Offset: 0x003E5426
		public static Offset<IDartCompetitorSkills> EndIDartCompetitorSkills(FlatBufferBuilder builder)
		{
			return new Offset<IDartCompetitorSkills>(builder.EndTable());
		}

		// Token: 0x0601B996 RID: 113046 RVA: 0x003E7234 File Offset: 0x003E5434
		public IDartCompetitorSkillsT UnPack()
		{
			IDartCompetitorSkillsT dartCompetitorSkillsT = new IDartCompetitorSkillsT();
			this.UnPackTo(dartCompetitorSkillsT);
			return dartCompetitorSkillsT;
		}

		// Token: 0x0601B997 RID: 113047 RVA: 0x003E724F File Offset: 0x003E544F
		public void UnPackTo(IDartCompetitorSkillsT _o)
		{
			_o.Mode301Skill = this.Mode301Skill;
			_o.Mode501Skill = this.Mode501Skill;
			_o.Mode701Skill = this.Mode701Skill;
		}

		// Token: 0x0601B998 RID: 113048 RVA: 0x003E7278 File Offset: 0x003E5478
		public static Offset<IDartCompetitorSkills> Pack(FlatBufferBuilder builder, IDartCompetitorSkillsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartCompetitorSkills>);
			}
			return IDartCompetitorSkills.CreateIDartCompetitorSkills(builder, _o.Mode301Skill, _o.Mode501Skill, _o.Mode701Skill);
		}

		// Token: 0x0400CE8E RID: 52878
		private Table __p;
	}
}
