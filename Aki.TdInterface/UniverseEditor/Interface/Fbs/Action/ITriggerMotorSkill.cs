using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007487 RID: 29831
	public struct ITriggerMotorSkill : IFlatbufferObject
	{
		// Token: 0x1700E278 RID: 57976
		// (get) Token: 0x06036366 RID: 222054 RVA: 0x0075ED0C File Offset: 0x0075CF0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036367 RID: 222055 RVA: 0x0075ED19 File Offset: 0x0075CF19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036368 RID: 222056 RVA: 0x0075ED20 File Offset: 0x0075CF20
		public static ITriggerMotorSkill GetRootAsITriggerMotorSkill(ByteBuffer _bb)
		{
			return ITriggerMotorSkill.GetRootAsITriggerMotorSkill(_bb, default(ITriggerMotorSkill));
		}

		// Token: 0x06036369 RID: 222057 RVA: 0x0075ED3C File Offset: 0x0075CF3C
		public static ITriggerMotorSkill GetRootAsITriggerMotorSkill(ByteBuffer _bb, ITriggerMotorSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603636A RID: 222058 RVA: 0x0075ED59 File Offset: 0x0075CF59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603636B RID: 222059 RVA: 0x0075ED68 File Offset: 0x0075CF68
		public ITriggerMotorSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E279 RID: 57977
		// (get) Token: 0x0603636C RID: 222060 RVA: 0x0075ED78 File Offset: 0x0075CF78
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

		// Token: 0x1700E27A RID: 57978
		// (get) Token: 0x0603636D RID: 222061 RVA: 0x0075EDB4 File Offset: 0x0075CFB4
		public int MotorSkillId
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

		// Token: 0x0603636E RID: 222062 RVA: 0x0075EDF0 File Offset: 0x0075CFF0
		public static Offset<ITriggerMotorSkill> CreateITriggerMotorSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int MotorSkillId = 0)
		{
			builder.StartTable(2);
			ITriggerMotorSkill.AddMotorSkillId(builder, MotorSkillId);
			ITriggerMotorSkill.AddType(builder, Type);
			return ITriggerMotorSkill.EndITriggerMotorSkill(builder);
		}

		// Token: 0x0603636F RID: 222063 RVA: 0x0075EE0D File Offset: 0x0075D00D
		public static void StartITriggerMotorSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036370 RID: 222064 RVA: 0x0075EE16 File Offset: 0x0075D016
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036371 RID: 222065 RVA: 0x0075EE21 File Offset: 0x0075D021
		public static void AddMotorSkillId(FlatBufferBuilder builder, int motorSkillId)
		{
			builder.AddInt(1, motorSkillId, 0);
		}

		// Token: 0x06036372 RID: 222066 RVA: 0x0075EE2C File Offset: 0x0075D02C
		public static Offset<ITriggerMotorSkill> EndITriggerMotorSkill(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerMotorSkill>(builder.EndTable());
		}

		// Token: 0x06036373 RID: 222067 RVA: 0x0075EE3C File Offset: 0x0075D03C
		public ITriggerMotorSkillT UnPack()
		{
			ITriggerMotorSkillT triggerMotorSkillT = new ITriggerMotorSkillT();
			this.UnPackTo(triggerMotorSkillT);
			return triggerMotorSkillT;
		}

		// Token: 0x06036374 RID: 222068 RVA: 0x0075EE57 File Offset: 0x0075D057
		public void UnPackTo(ITriggerMotorSkillT _o)
		{
			_o.Type = this.Type;
			_o.MotorSkillId = this.MotorSkillId;
		}

		// Token: 0x06036375 RID: 222069 RVA: 0x0075EE74 File Offset: 0x0075D074
		public static Offset<ITriggerMotorSkill> Pack(FlatBufferBuilder builder, ITriggerMotorSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerMotorSkill>);
			}
			return ITriggerMotorSkill.CreateITriggerMotorSkill(builder, _o.Type, _o.MotorSkillId);
		}

		// Token: 0x0401231E RID: 74526
		private Table __p;
	}
}
