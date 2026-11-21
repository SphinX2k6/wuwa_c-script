using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE7 RID: 28391
	public struct IFollowShooterSkillSkill : IFlatbufferObject
	{
		// Token: 0x1700D02E RID: 53294
		// (get) Token: 0x060311E3 RID: 201187 RVA: 0x006A8ADD File Offset: 0x006A6CDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060311E4 RID: 201188 RVA: 0x006A8AEA File Offset: 0x006A6CEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060311E5 RID: 201189 RVA: 0x006A8AF4 File Offset: 0x006A6CF4
		public static IFollowShooterSkillSkill GetRootAsIFollowShooterSkillSkill(ByteBuffer _bb)
		{
			return IFollowShooterSkillSkill.GetRootAsIFollowShooterSkillSkill(_bb, default(IFollowShooterSkillSkill));
		}

		// Token: 0x060311E6 RID: 201190 RVA: 0x006A8B10 File Offset: 0x006A6D10
		public static IFollowShooterSkillSkill GetRootAsIFollowShooterSkillSkill(ByteBuffer _bb, IFollowShooterSkillSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060311E7 RID: 201191 RVA: 0x006A8B2D File Offset: 0x006A6D2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060311E8 RID: 201192 RVA: 0x006A8B3C File Offset: 0x006A6D3C
		public IFollowShooterSkillSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D02F RID: 53295
		// (get) Token: 0x060311E9 RID: 201193 RVA: 0x006A8B4C File Offset: 0x006A6D4C
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

		// Token: 0x1700D030 RID: 53296
		// (get) Token: 0x060311EA RID: 201194 RVA: 0x006A8B88 File Offset: 0x006A6D88
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

		// Token: 0x060311EB RID: 201195 RVA: 0x006A8BC4 File Offset: 0x006A6DC4
		public static Offset<IFollowShooterSkillSkill> CreateIFollowShooterSkillSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int SkillId = 0)
		{
			builder.StartTable(2);
			IFollowShooterSkillSkill.AddSkillId(builder, SkillId);
			IFollowShooterSkillSkill.AddType(builder, Type);
			return IFollowShooterSkillSkill.EndIFollowShooterSkillSkill(builder);
		}

		// Token: 0x060311EC RID: 201196 RVA: 0x006A8BE1 File Offset: 0x006A6DE1
		public static void StartIFollowShooterSkillSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060311ED RID: 201197 RVA: 0x006A8BEA File Offset: 0x006A6DEA
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060311EE RID: 201198 RVA: 0x006A8BF5 File Offset: 0x006A6DF5
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x060311EF RID: 201199 RVA: 0x006A8C00 File Offset: 0x006A6E00
		public static Offset<IFollowShooterSkillSkill> EndIFollowShooterSkillSkill(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterSkillSkill>(builder.EndTable());
		}

		// Token: 0x060311F0 RID: 201200 RVA: 0x006A8C10 File Offset: 0x006A6E10
		public IFollowShooterSkillSkillT UnPack()
		{
			IFollowShooterSkillSkillT followShooterSkillSkillT = new IFollowShooterSkillSkillT();
			this.UnPackTo(followShooterSkillSkillT);
			return followShooterSkillSkillT;
		}

		// Token: 0x060311F1 RID: 201201 RVA: 0x006A8C2B File Offset: 0x006A6E2B
		public void UnPackTo(IFollowShooterSkillSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x060311F2 RID: 201202 RVA: 0x006A8C48 File Offset: 0x006A6E48
		public static Offset<IFollowShooterSkillSkill> Pack(FlatBufferBuilder builder, IFollowShooterSkillSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterSkillSkill>);
			}
			return IFollowShooterSkillSkill.CreateIFollowShooterSkillSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x04011DE7 RID: 73191
		private Table __p;
	}
}
