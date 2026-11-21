using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C7A RID: 31866
	public struct ITriggerMotorSkill : IFlatbufferObject
	{
		// Token: 0x1700EE97 RID: 61079
		// (get) Token: 0x06039753 RID: 235347 RVA: 0x007C1AC8 File Offset: 0x007BFCC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039754 RID: 235348 RVA: 0x007C1AD5 File Offset: 0x007BFCD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039755 RID: 235349 RVA: 0x007C1ADC File Offset: 0x007BFCDC
		public static ITriggerMotorSkill GetRootAsITriggerMotorSkill(ByteBuffer _bb)
		{
			return ITriggerMotorSkill.GetRootAsITriggerMotorSkill(_bb, default(ITriggerMotorSkill));
		}

		// Token: 0x06039756 RID: 235350 RVA: 0x007C1AF8 File Offset: 0x007BFCF8
		public static ITriggerMotorSkill GetRootAsITriggerMotorSkill(ByteBuffer _bb, ITriggerMotorSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039757 RID: 235351 RVA: 0x007C1B15 File Offset: 0x007BFD15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039758 RID: 235352 RVA: 0x007C1B24 File Offset: 0x007BFD24
		public ITriggerMotorSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE98 RID: 61080
		// (get) Token: 0x06039759 RID: 235353 RVA: 0x007C1B34 File Offset: 0x007BFD34
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

		// Token: 0x1700EE99 RID: 61081
		// (get) Token: 0x0603975A RID: 235354 RVA: 0x007C1B70 File Offset: 0x007BFD70
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

		// Token: 0x0603975B RID: 235355 RVA: 0x007C1BAC File Offset: 0x007BFDAC
		public static Offset<ITriggerMotorSkill> CreateITriggerMotorSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int MotorSkillId = 0)
		{
			builder.StartTable(2);
			ITriggerMotorSkill.AddMotorSkillId(builder, MotorSkillId);
			ITriggerMotorSkill.AddType(builder, Type);
			return ITriggerMotorSkill.EndITriggerMotorSkill(builder);
		}

		// Token: 0x0603975C RID: 235356 RVA: 0x007C1BC9 File Offset: 0x007BFDC9
		public static void StartITriggerMotorSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603975D RID: 235357 RVA: 0x007C1BD2 File Offset: 0x007BFDD2
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603975E RID: 235358 RVA: 0x007C1BDD File Offset: 0x007BFDDD
		public static void AddMotorSkillId(FlatBufferBuilder builder, int motorSkillId)
		{
			builder.AddInt(1, motorSkillId, 0);
		}

		// Token: 0x0603975F RID: 235359 RVA: 0x007C1BE8 File Offset: 0x007BFDE8
		public static Offset<ITriggerMotorSkill> EndITriggerMotorSkill(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerMotorSkill>(builder.EndTable());
		}

		// Token: 0x06039760 RID: 235360 RVA: 0x007C1BF8 File Offset: 0x007BFDF8
		public ITriggerMotorSkillT UnPack()
		{
			ITriggerMotorSkillT triggerMotorSkillT = new ITriggerMotorSkillT();
			this.UnPackTo(triggerMotorSkillT);
			return triggerMotorSkillT;
		}

		// Token: 0x06039761 RID: 235361 RVA: 0x007C1C13 File Offset: 0x007BFE13
		public void UnPackTo(ITriggerMotorSkillT _o)
		{
			_o.Type = this.Type;
			_o.MotorSkillId = this.MotorSkillId;
		}

		// Token: 0x06039762 RID: 235362 RVA: 0x007C1C30 File Offset: 0x007BFE30
		public static Offset<ITriggerMotorSkill> Pack(FlatBufferBuilder builder, ITriggerMotorSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerMotorSkill>);
			}
			return ITriggerMotorSkill.CreateITriggerMotorSkill(builder, _o.Type, _o.MotorSkillId);
		}

		// Token: 0x04013346 RID: 78662
		private Table __p;
	}
}
