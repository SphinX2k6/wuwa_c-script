using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C77 RID: 31863
	public struct ITriggerHookPointSkill : IFlatbufferObject
	{
		// Token: 0x1700EE8C RID: 61068
		// (get) Token: 0x06039731 RID: 235313 RVA: 0x007C1720 File Offset: 0x007BF920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039732 RID: 235314 RVA: 0x007C172D File Offset: 0x007BF92D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039733 RID: 235315 RVA: 0x007C1734 File Offset: 0x007BF934
		public static ITriggerHookPointSkill GetRootAsITriggerHookPointSkill(ByteBuffer _bb)
		{
			return ITriggerHookPointSkill.GetRootAsITriggerHookPointSkill(_bb, default(ITriggerHookPointSkill));
		}

		// Token: 0x06039734 RID: 235316 RVA: 0x007C1750 File Offset: 0x007BF950
		public static ITriggerHookPointSkill GetRootAsITriggerHookPointSkill(ByteBuffer _bb, ITriggerHookPointSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039735 RID: 235317 RVA: 0x007C176D File Offset: 0x007BF96D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039736 RID: 235318 RVA: 0x007C177C File Offset: 0x007BF97C
		public ITriggerHookPointSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE8D RID: 61069
		// (get) Token: 0x06039737 RID: 235319 RVA: 0x007C178C File Offset: 0x007BF98C
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

		// Token: 0x1700EE8E RID: 61070
		// (get) Token: 0x06039738 RID: 235320 RVA: 0x007C17C8 File Offset: 0x007BF9C8
		public int AssistCharacterId
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

		// Token: 0x1700EE8F RID: 61071
		// (get) Token: 0x06039739 RID: 235321 RVA: 0x007C1804 File Offset: 0x007BFA04
		public int HookEntityId
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

		// Token: 0x1700EE90 RID: 61072
		// (get) Token: 0x0603973A RID: 235322 RVA: 0x007C1840 File Offset: 0x007BFA40
		public EHookTriggerType SpecTriggerType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EHookTriggerType.Motor;
				}
				return (EHookTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EE91 RID: 61073
		// (get) Token: 0x0603973B RID: 235323 RVA: 0x007C1880 File Offset: 0x007BFA80
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603973C RID: 235324 RVA: 0x007C18BD File Offset: 0x007BFABD
		public static Offset<ITriggerHookPointSkill> CreateITriggerHookPointSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int AssistCharacterId = 0, int HookEntityId = 0, EHookTriggerType SpecTriggerType = EHookTriggerType.Motor, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggerHookPointSkill.AddHookEntityId(builder, HookEntityId);
			ITriggerHookPointSkill.AddAssistCharacterId(builder, AssistCharacterId);
			ITriggerHookPointSkill.AddNullMask(builder, NullMask);
			ITriggerHookPointSkill.AddSpecTriggerType(builder, SpecTriggerType);
			ITriggerHookPointSkill.AddType(builder, Type);
			return ITriggerHookPointSkill.EndITriggerHookPointSkill(builder);
		}

		// Token: 0x0603973D RID: 235325 RVA: 0x007C18F1 File Offset: 0x007BFAF1
		public static void StartITriggerHookPointSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603973E RID: 235326 RVA: 0x007C18FA File Offset: 0x007BFAFA
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603973F RID: 235327 RVA: 0x007C1905 File Offset: 0x007BFB05
		public static void AddAssistCharacterId(FlatBufferBuilder builder, int assistCharacterId)
		{
			builder.AddInt(1, assistCharacterId, 0);
		}

		// Token: 0x06039740 RID: 235328 RVA: 0x007C1910 File Offset: 0x007BFB10
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(2, hookEntityId, 0);
		}

		// Token: 0x06039741 RID: 235329 RVA: 0x007C191B File Offset: 0x007BFB1B
		public static void AddSpecTriggerType(FlatBufferBuilder builder, EHookTriggerType specTriggerType)
		{
			builder.AddByte(3, (byte)specTriggerType, 0);
		}

		// Token: 0x06039742 RID: 235330 RVA: 0x007C1926 File Offset: 0x007BFB26
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06039743 RID: 235331 RVA: 0x007C1931 File Offset: 0x007BFB31
		public static Offset<ITriggerHookPointSkill> EndITriggerHookPointSkill(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerHookPointSkill>(builder.EndTable());
		}

		// Token: 0x06039744 RID: 235332 RVA: 0x007C1940 File Offset: 0x007BFB40
		public ITriggerHookPointSkillT UnPack()
		{
			ITriggerHookPointSkillT triggerHookPointSkillT = new ITriggerHookPointSkillT();
			this.UnPackTo(triggerHookPointSkillT);
			return triggerHookPointSkillT;
		}

		// Token: 0x06039745 RID: 235333 RVA: 0x007C195B File Offset: 0x007BFB5B
		public void UnPackTo(ITriggerHookPointSkillT _o)
		{
			_o.Type = this.Type;
			_o.AssistCharacterId = this.AssistCharacterId;
			_o.HookEntityId = this.HookEntityId;
			_o.SpecTriggerType = this.SpecTriggerType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039746 RID: 235334 RVA: 0x007C199C File Offset: 0x007BFB9C
		public static Offset<ITriggerHookPointSkill> Pack(FlatBufferBuilder builder, ITriggerHookPointSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerHookPointSkill>);
			}
			return ITriggerHookPointSkill.CreateITriggerHookPointSkill(builder, _o.Type, _o.AssistCharacterId, _o.HookEntityId, _o.SpecTriggerType, _o.NullMask);
		}

		// Token: 0x04013340 RID: 78656
		private Table __p;
	}
}
