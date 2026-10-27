using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006852 RID: 26706
	public struct IFollowShooterSkillSkill : IFlatbufferObject
	{
		// Token: 0x1700C65A RID: 50778
		// (get) Token: 0x0602E8FD RID: 190717 RVA: 0x0065A272 File Offset: 0x00658472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8FE RID: 190718 RVA: 0x0065A27F File Offset: 0x0065847F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8FF RID: 190719 RVA: 0x0065A288 File Offset: 0x00658488
		public static IFollowShooterSkillSkill GetRootAsIFollowShooterSkillSkill(ByteBuffer _bb)
		{
			return IFollowShooterSkillSkill.GetRootAsIFollowShooterSkillSkill(_bb, default(IFollowShooterSkillSkill));
		}

		// Token: 0x0602E900 RID: 190720 RVA: 0x0065A2A4 File Offset: 0x006584A4
		public static IFollowShooterSkillSkill GetRootAsIFollowShooterSkillSkill(ByteBuffer _bb, IFollowShooterSkillSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E901 RID: 190721 RVA: 0x0065A2C1 File Offset: 0x006584C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E902 RID: 190722 RVA: 0x0065A2D0 File Offset: 0x006584D0
		public IFollowShooterSkillSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C65B RID: 50779
		// (get) Token: 0x0602E903 RID: 190723 RVA: 0x0065A2E0 File Offset: 0x006584E0
		public EExecClientBattleActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExecClientBattleActionType.SendTagEventToControlCharacter;
				}
				return (EExecClientBattleActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C65C RID: 50780
		// (get) Token: 0x0602E904 RID: 190724 RVA: 0x0065A31C File Offset: 0x0065851C
		public int SkillId
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

		// Token: 0x0602E905 RID: 190725 RVA: 0x0065A358 File Offset: 0x00658558
		public static Offset<IFollowShooterSkillSkill> CreateIFollowShooterSkillSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int SkillId = 0)
		{
			builder.StartTable(2);
			IFollowShooterSkillSkill.AddSkillId(builder, SkillId);
			IFollowShooterSkillSkill.AddType(builder, Type);
			return IFollowShooterSkillSkill.EndIFollowShooterSkillSkill(builder);
		}

		// Token: 0x0602E906 RID: 190726 RVA: 0x0065A375 File Offset: 0x00658575
		public static void StartIFollowShooterSkillSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E907 RID: 190727 RVA: 0x0065A37E File Offset: 0x0065857E
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E908 RID: 190728 RVA: 0x0065A389 File Offset: 0x00658589
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0602E909 RID: 190729 RVA: 0x0065A394 File Offset: 0x00658594
		public static Offset<IFollowShooterSkillSkill> EndIFollowShooterSkillSkill(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterSkillSkill>(builder.EndTable());
		}

		// Token: 0x0602E90A RID: 190730 RVA: 0x0065A3A4 File Offset: 0x006585A4
		public IFollowShooterSkillSkillT UnPack()
		{
			IFollowShooterSkillSkillT followShooterSkillSkillT = new IFollowShooterSkillSkillT();
			this.UnPackTo(followShooterSkillSkillT);
			return followShooterSkillSkillT;
		}

		// Token: 0x0602E90B RID: 190731 RVA: 0x0065A3BF File Offset: 0x006585BF
		public void UnPackTo(IFollowShooterSkillSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0602E90C RID: 190732 RVA: 0x0065A3DC File Offset: 0x006585DC
		public static Offset<IFollowShooterSkillSkill> Pack(FlatBufferBuilder builder, IFollowShooterSkillSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterSkillSkill>);
			}
			return IFollowShooterSkillSkill.CreateIFollowShooterSkillSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x04010F9D RID: 69533
		private Table __p;
	}
}
