using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007484 RID: 29828
	public struct ITriggerHookPointSkill : IFlatbufferObject
	{
		// Token: 0x1700E26F RID: 57967
		// (get) Token: 0x06036348 RID: 222024 RVA: 0x0075E9F4 File Offset: 0x0075CBF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036349 RID: 222025 RVA: 0x0075EA01 File Offset: 0x0075CC01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603634A RID: 222026 RVA: 0x0075EA08 File Offset: 0x0075CC08
		public static ITriggerHookPointSkill GetRootAsITriggerHookPointSkill(ByteBuffer _bb)
		{
			return ITriggerHookPointSkill.GetRootAsITriggerHookPointSkill(_bb, default(ITriggerHookPointSkill));
		}

		// Token: 0x0603634B RID: 222027 RVA: 0x0075EA24 File Offset: 0x0075CC24
		public static ITriggerHookPointSkill GetRootAsITriggerHookPointSkill(ByteBuffer _bb, ITriggerHookPointSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603634C RID: 222028 RVA: 0x0075EA41 File Offset: 0x0075CC41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603634D RID: 222029 RVA: 0x0075EA50 File Offset: 0x0075CC50
		public ITriggerHookPointSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E270 RID: 57968
		// (get) Token: 0x0603634E RID: 222030 RVA: 0x0075EA60 File Offset: 0x0075CC60
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

		// Token: 0x1700E271 RID: 57969
		// (get) Token: 0x0603634F RID: 222031 RVA: 0x0075EA9C File Offset: 0x0075CC9C
		public int HookEntityId
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

		// Token: 0x1700E272 RID: 57970
		// (get) Token: 0x06036350 RID: 222032 RVA: 0x0075EAD8 File Offset: 0x0075CCD8
		public EHookTriggerType SpecTriggerType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EHookTriggerType.Motor;
				}
				return (EHookTriggerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E273 RID: 57971
		// (get) Token: 0x06036351 RID: 222033 RVA: 0x0075EB14 File Offset: 0x0075CD14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036352 RID: 222034 RVA: 0x0075EB51 File Offset: 0x0075CD51
		public static Offset<ITriggerHookPointSkill> CreateITriggerHookPointSkill(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int HookEntityId = 0, EHookTriggerType SpecTriggerType = EHookTriggerType.Motor, byte NullMask = 0)
		{
			builder.StartTable(4);
			ITriggerHookPointSkill.AddHookEntityId(builder, HookEntityId);
			ITriggerHookPointSkill.AddNullMask(builder, NullMask);
			ITriggerHookPointSkill.AddSpecTriggerType(builder, SpecTriggerType);
			ITriggerHookPointSkill.AddType(builder, Type);
			return ITriggerHookPointSkill.EndITriggerHookPointSkill(builder);
		}

		// Token: 0x06036353 RID: 222035 RVA: 0x0075EB7D File Offset: 0x0075CD7D
		public static void StartITriggerHookPointSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036354 RID: 222036 RVA: 0x0075EB86 File Offset: 0x0075CD86
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036355 RID: 222037 RVA: 0x0075EB91 File Offset: 0x0075CD91
		public static void AddHookEntityId(FlatBufferBuilder builder, int hookEntityId)
		{
			builder.AddInt(1, hookEntityId, 0);
		}

		// Token: 0x06036356 RID: 222038 RVA: 0x0075EB9C File Offset: 0x0075CD9C
		public static void AddSpecTriggerType(FlatBufferBuilder builder, EHookTriggerType specTriggerType)
		{
			builder.AddByte(2, (byte)specTriggerType, 0);
		}

		// Token: 0x06036357 RID: 222039 RVA: 0x0075EBA7 File Offset: 0x0075CDA7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036358 RID: 222040 RVA: 0x0075EBB2 File Offset: 0x0075CDB2
		public static Offset<ITriggerHookPointSkill> EndITriggerHookPointSkill(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerHookPointSkill>(builder.EndTable());
		}

		// Token: 0x06036359 RID: 222041 RVA: 0x0075EBC0 File Offset: 0x0075CDC0
		public ITriggerHookPointSkillT UnPack()
		{
			ITriggerHookPointSkillT triggerHookPointSkillT = new ITriggerHookPointSkillT();
			this.UnPackTo(triggerHookPointSkillT);
			return triggerHookPointSkillT;
		}

		// Token: 0x0603635A RID: 222042 RVA: 0x0075EBDB File Offset: 0x0075CDDB
		public void UnPackTo(ITriggerHookPointSkillT _o)
		{
			_o.Type = this.Type;
			_o.HookEntityId = this.HookEntityId;
			_o.SpecTriggerType = this.SpecTriggerType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603635B RID: 222043 RVA: 0x0075EC10 File Offset: 0x0075CE10
		public static Offset<ITriggerHookPointSkill> Pack(FlatBufferBuilder builder, ITriggerHookPointSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerHookPointSkill>);
			}
			return ITriggerHookPointSkill.CreateITriggerHookPointSkill(builder, _o.Type, _o.HookEntityId, _o.SpecTriggerType, _o.NullMask);
		}

		// Token: 0x04012319 RID: 74521
		private Table __p;
	}
}
