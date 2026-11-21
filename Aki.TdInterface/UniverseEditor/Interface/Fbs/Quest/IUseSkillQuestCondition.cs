using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B5 RID: 18101
	public struct IUseSkillQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007EC2 RID: 32450
		// (get) Token: 0x0601A96B RID: 108907 RVA: 0x003C7EE6 File Offset: 0x003C60E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A96C RID: 108908 RVA: 0x003C7EF3 File Offset: 0x003C60F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A96D RID: 108909 RVA: 0x003C7EFC File Offset: 0x003C60FC
		public static IUseSkillQuestCondition GetRootAsIUseSkillQuestCondition(ByteBuffer _bb)
		{
			return IUseSkillQuestCondition.GetRootAsIUseSkillQuestCondition(_bb, default(IUseSkillQuestCondition));
		}

		// Token: 0x0601A96E RID: 108910 RVA: 0x003C7F18 File Offset: 0x003C6118
		public static IUseSkillQuestCondition GetRootAsIUseSkillQuestCondition(ByteBuffer _bb, IUseSkillQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A96F RID: 108911 RVA: 0x003C7F35 File Offset: 0x003C6135
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A970 RID: 108912 RVA: 0x003C7F44 File Offset: 0x003C6144
		public IUseSkillQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EC3 RID: 32451
		// (get) Token: 0x0601A971 RID: 108913 RVA: 0x003C7F54 File Offset: 0x003C6154
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EC4 RID: 32452
		// (get) Token: 0x0601A972 RID: 108914 RVA: 0x003C7F90 File Offset: 0x003C6190
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007EC5 RID: 32453
		// (get) Token: 0x0601A973 RID: 108915 RVA: 0x003C7FF0 File Offset: 0x003C61F0
		public ESkillType SkillType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESkillType.NormalSkill;
				}
				return (ESkillType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EC6 RID: 32454
		// (get) Token: 0x0601A974 RID: 108916 RVA: 0x003C802C File Offset: 0x003C622C
		public int SkillId
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

		// Token: 0x17007EC7 RID: 32455
		// (get) Token: 0x0601A975 RID: 108917 RVA: 0x003C806C File Offset: 0x003C626C
		public TUseSkillCheck CheckType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TUseSkillCheck.NONE;
				}
				return (TUseSkillCheck)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A976 RID: 108918 RVA: 0x003C80AC File Offset: 0x003C62AC
		public TTable? Check<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A977 RID: 108919 RVA: 0x003C80F4 File Offset: 0x003C62F4
		public IUseSkillCheckByFollowShooterSkillId CheckAsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.Check<IUseSkillCheckByFollowShooterSkillId>().Value;
		}

		// Token: 0x0601A978 RID: 108920 RVA: 0x003C8110 File Offset: 0x003C6310
		public IUseSkillCheckBySkillGenre CheckAsIUseSkillCheckBySkillGenre()
		{
			return this.Check<IUseSkillCheckBySkillGenre>().Value;
		}

		// Token: 0x0601A979 RID: 108921 RVA: 0x003C812C File Offset: 0x003C632C
		public IUseSkillCheckBySkillId CheckAsIUseSkillCheckBySkillId()
		{
			return this.Check<IUseSkillCheckBySkillId>().Value;
		}

		// Token: 0x0601A97A RID: 108922 RVA: 0x003C8148 File Offset: 0x003C6348
		public IUseSkillCheckByVisionShowId CheckAsIUseSkillCheckByVisionShowId()
		{
			return this.Check<IUseSkillCheckByVisionShowId>().Value;
		}

		// Token: 0x0601A97B RID: 108923 RVA: 0x003C8164 File Offset: 0x003C6364
		public IUseSkillCheckByVisionSummonId CheckAsIUseSkillCheckByVisionSummonId()
		{
			return this.Check<IUseSkillCheckByVisionSummonId>().Value;
		}

		// Token: 0x17007EC8 RID: 32456
		// (get) Token: 0x0601A97C RID: 108924 RVA: 0x003C8180 File Offset: 0x003C6380
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007EC9 RID: 32457
		// (get) Token: 0x0601A97D RID: 108925 RVA: 0x003C81C0 File Offset: 0x003C63C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A97E RID: 108926 RVA: 0x003C8200 File Offset: 0x003C6400
		public static Offset<IUseSkillQuestCondition> CreateIUseSkillQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), ESkillType SkillType = ESkillType.NormalSkill, int SkillId = 0, TUseSkillCheck Check_type = TUseSkillCheck.NONE, int CheckOffset = 0, bool IsWaitFinish = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IUseSkillQuestCondition.AddCheck(builder, CheckOffset);
			IUseSkillQuestCondition.AddSkillId(builder, SkillId);
			IUseSkillQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IUseSkillQuestCondition.AddNullMask(builder, NullMask);
			IUseSkillQuestCondition.AddIsWaitFinish(builder, IsWaitFinish);
			IUseSkillQuestCondition.AddCheckType(builder, Check_type);
			IUseSkillQuestCondition.AddSkillType(builder, SkillType);
			IUseSkillQuestCondition.AddType(builder, Type);
			return IUseSkillQuestCondition.EndIUseSkillQuestCondition(builder);
		}

		// Token: 0x0601A97F RID: 108927 RVA: 0x003C8257 File Offset: 0x003C6457
		public static void StartIUseSkillQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601A980 RID: 108928 RVA: 0x003C8260 File Offset: 0x003C6460
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A981 RID: 108929 RVA: 0x003C826B File Offset: 0x003C646B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A982 RID: 108930 RVA: 0x003C827B File Offset: 0x003C647B
		public static void AddSkillType(FlatBufferBuilder builder, ESkillType skillType)
		{
			builder.AddByte(2, (byte)skillType, 0);
		}

		// Token: 0x0601A983 RID: 108931 RVA: 0x003C8286 File Offset: 0x003C6486
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x0601A984 RID: 108932 RVA: 0x003C8291 File Offset: 0x003C6491
		public static void AddCheckType(FlatBufferBuilder builder, TUseSkillCheck checkType)
		{
			builder.AddByte(4, (byte)checkType, 0);
		}

		// Token: 0x0601A985 RID: 108933 RVA: 0x003C829C File Offset: 0x003C649C
		public static void AddCheck(FlatBufferBuilder builder, int checkOffset)
		{
			builder.AddOffset(5, checkOffset, 0);
		}

		// Token: 0x0601A986 RID: 108934 RVA: 0x003C82A7 File Offset: 0x003C64A7
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(6, isWaitFinish, false);
		}

		// Token: 0x0601A987 RID: 108935 RVA: 0x003C82B2 File Offset: 0x003C64B2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601A988 RID: 108936 RVA: 0x003C82BD File Offset: 0x003C64BD
		public static Offset<IUseSkillQuestCondition> EndIUseSkillQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601A989 RID: 108937 RVA: 0x003C82CC File Offset: 0x003C64CC
		public IUseSkillQuestConditionT UnPack()
		{
			IUseSkillQuestConditionT useSkillQuestConditionT = new IUseSkillQuestConditionT();
			this.UnPackTo(useSkillQuestConditionT);
			return useSkillQuestConditionT;
		}

		// Token: 0x0601A98A RID: 108938 RVA: 0x003C82E8 File Offset: 0x003C64E8
		public void UnPackTo(IUseSkillQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SkillType = this.SkillType;
			_o.SkillId = this.SkillId;
			_o.Check = new TUseSkillCheckUnion();
			_o.Check.Type = this.CheckType;
			switch (this.CheckType)
			{
			case TUseSkillCheck.IUseSkillCheckByFollowShooterSkillId:
				_o.Check.Value = ((this.Check<IUseSkillCheckByFollowShooterSkillId>() != null) ? this.Check<IUseSkillCheckByFollowShooterSkillId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckBySkillGenre:
				_o.Check.Value = ((this.Check<IUseSkillCheckBySkillGenre>() != null) ? this.Check<IUseSkillCheckBySkillGenre>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckBySkillId:
				_o.Check.Value = ((this.Check<IUseSkillCheckBySkillId>() != null) ? this.Check<IUseSkillCheckBySkillId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckByVisionShowId:
				_o.Check.Value = ((this.Check<IUseSkillCheckByVisionShowId>() != null) ? this.Check<IUseSkillCheckByVisionShowId>().Value.UnPack() : null);
				break;
			case TUseSkillCheck.IUseSkillCheckByVisionSummonId:
				_o.Check.Value = ((this.Check<IUseSkillCheckByVisionSummonId>() != null) ? this.Check<IUseSkillCheckByVisionSummonId>().Value.UnPack() : null);
				break;
			}
			_o.IsWaitFinish = this.IsWaitFinish;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A98B RID: 108939 RVA: 0x003C84C4 File Offset: 0x003C66C4
		public static Offset<IUseSkillQuestCondition> Pack(FlatBufferBuilder builder, IUseSkillQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TUseSkillCheck check_type = (_o.Check == null) ? TUseSkillCheck.NONE : _o.Check.Type;
			int checkOffset = (_o.Check == null) ? 0 : TUseSkillCheckUnion.Pack(builder, _o.Check);
			return IUseSkillQuestCondition.CreateIUseSkillQuestCondition(builder, _o.Type, preConditionsOffset, _o.SkillType, _o.SkillId, check_type, checkOffset, _o.IsWaitFinish, _o.NullMask);
		}

		// Token: 0x0400C8F0 RID: 51440
		private Table __p;
	}
}
