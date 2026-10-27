using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004259 RID: 16985
	public struct IUseSkillQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007891 RID: 30865
		// (get) Token: 0x060191FF RID: 102911 RVA: 0x0039C80E File Offset: 0x0039AA0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019200 RID: 102912 RVA: 0x0039C81B File Offset: 0x0039AA1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019201 RID: 102913 RVA: 0x0039C824 File Offset: 0x0039AA24
		public static IUseSkillQuestCondition GetRootAsIUseSkillQuestCondition(ByteBuffer _bb)
		{
			return IUseSkillQuestCondition.GetRootAsIUseSkillQuestCondition(_bb, default(IUseSkillQuestCondition));
		}

		// Token: 0x06019202 RID: 102914 RVA: 0x0039C840 File Offset: 0x0039AA40
		public static IUseSkillQuestCondition GetRootAsIUseSkillQuestCondition(ByteBuffer _bb, IUseSkillQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019203 RID: 102915 RVA: 0x0039C85D File Offset: 0x0039AA5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019204 RID: 102916 RVA: 0x0039C86C File Offset: 0x0039AA6C
		public IUseSkillQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007892 RID: 30866
		// (get) Token: 0x06019205 RID: 102917 RVA: 0x0039C87C File Offset: 0x0039AA7C
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

		// Token: 0x17007893 RID: 30867
		// (get) Token: 0x06019206 RID: 102918 RVA: 0x0039C8B8 File Offset: 0x0039AAB8
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

		// Token: 0x17007894 RID: 30868
		// (get) Token: 0x06019207 RID: 102919 RVA: 0x0039C918 File Offset: 0x0039AB18
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

		// Token: 0x17007895 RID: 30869
		// (get) Token: 0x06019208 RID: 102920 RVA: 0x0039C954 File Offset: 0x0039AB54
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

		// Token: 0x17007896 RID: 30870
		// (get) Token: 0x06019209 RID: 102921 RVA: 0x0039C994 File Offset: 0x0039AB94
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

		// Token: 0x0601920A RID: 102922 RVA: 0x0039C9D4 File Offset: 0x0039ABD4
		public TTable? Check<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601920B RID: 102923 RVA: 0x0039CA1C File Offset: 0x0039AC1C
		public IUseSkillCheckByFollowShooterSkillId CheckAsIUseSkillCheckByFollowShooterSkillId()
		{
			return this.Check<IUseSkillCheckByFollowShooterSkillId>().Value;
		}

		// Token: 0x0601920C RID: 102924 RVA: 0x0039CA38 File Offset: 0x0039AC38
		public IUseSkillCheckBySkillGenre CheckAsIUseSkillCheckBySkillGenre()
		{
			return this.Check<IUseSkillCheckBySkillGenre>().Value;
		}

		// Token: 0x0601920D RID: 102925 RVA: 0x0039CA54 File Offset: 0x0039AC54
		public IUseSkillCheckBySkillId CheckAsIUseSkillCheckBySkillId()
		{
			return this.Check<IUseSkillCheckBySkillId>().Value;
		}

		// Token: 0x0601920E RID: 102926 RVA: 0x0039CA70 File Offset: 0x0039AC70
		public IUseSkillCheckByVisionShowId CheckAsIUseSkillCheckByVisionShowId()
		{
			return this.Check<IUseSkillCheckByVisionShowId>().Value;
		}

		// Token: 0x0601920F RID: 102927 RVA: 0x0039CA8C File Offset: 0x0039AC8C
		public IUseSkillCheckByVisionSummonId CheckAsIUseSkillCheckByVisionSummonId()
		{
			return this.Check<IUseSkillCheckByVisionSummonId>().Value;
		}

		// Token: 0x17007897 RID: 30871
		// (get) Token: 0x06019210 RID: 102928 RVA: 0x0039CAA8 File Offset: 0x0039ACA8
		public bool IsWaitFinish
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007898 RID: 30872
		// (get) Token: 0x06019211 RID: 102929 RVA: 0x0039CAE8 File Offset: 0x0039ACE8
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

		// Token: 0x06019212 RID: 102930 RVA: 0x0039CB28 File Offset: 0x0039AD28
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

		// Token: 0x06019213 RID: 102931 RVA: 0x0039CB7F File Offset: 0x0039AD7F
		public static void StartIUseSkillQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06019214 RID: 102932 RVA: 0x0039CB88 File Offset: 0x0039AD88
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019215 RID: 102933 RVA: 0x0039CB93 File Offset: 0x0039AD93
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019216 RID: 102934 RVA: 0x0039CBA3 File Offset: 0x0039ADA3
		public static void AddSkillType(FlatBufferBuilder builder, ESkillType skillType)
		{
			builder.AddByte(2, (byte)skillType, 0);
		}

		// Token: 0x06019217 RID: 102935 RVA: 0x0039CBAE File Offset: 0x0039ADAE
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x06019218 RID: 102936 RVA: 0x0039CBB9 File Offset: 0x0039ADB9
		public static void AddCheckType(FlatBufferBuilder builder, TUseSkillCheck checkType)
		{
			builder.AddByte(4, (byte)checkType, 0);
		}

		// Token: 0x06019219 RID: 102937 RVA: 0x0039CBC4 File Offset: 0x0039ADC4
		public static void AddCheck(FlatBufferBuilder builder, int checkOffset)
		{
			builder.AddOffset(5, checkOffset, 0);
		}

		// Token: 0x0601921A RID: 102938 RVA: 0x0039CBCF File Offset: 0x0039ADCF
		public static void AddIsWaitFinish(FlatBufferBuilder builder, bool isWaitFinish)
		{
			builder.AddBool(6, isWaitFinish, false);
		}

		// Token: 0x0601921B RID: 102939 RVA: 0x0039CBDA File Offset: 0x0039ADDA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601921C RID: 102940 RVA: 0x0039CBE5 File Offset: 0x0039ADE5
		public static Offset<IUseSkillQuestCondition> EndIUseSkillQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601921D RID: 102941 RVA: 0x0039CBF4 File Offset: 0x0039ADF4
		public IUseSkillQuestConditionT UnPack()
		{
			IUseSkillQuestConditionT useSkillQuestConditionT = new IUseSkillQuestConditionT();
			this.UnPackTo(useSkillQuestConditionT);
			return useSkillQuestConditionT;
		}

		// Token: 0x0601921E RID: 102942 RVA: 0x0039CC10 File Offset: 0x0039AE10
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

		// Token: 0x0601921F RID: 102943 RVA: 0x0039CDEC File Offset: 0x0039AFEC
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

		// Token: 0x0400BEE3 RID: 48867
		private Table __p;
	}
}
