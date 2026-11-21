using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007216 RID: 29206
	public struct IMonsterNpcInteract : IFlatbufferObject
	{
		// Token: 0x1700D5C7 RID: 54727
		// (get) Token: 0x06032D1A RID: 208154 RVA: 0x006DCD70 File Offset: 0x006DAF70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032D1B RID: 208155 RVA: 0x006DCD7D File Offset: 0x006DAF7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032D1C RID: 208156 RVA: 0x006DCD84 File Offset: 0x006DAF84
		public static IMonsterNpcInteract GetRootAsIMonsterNpcInteract(ByteBuffer _bb)
		{
			return IMonsterNpcInteract.GetRootAsIMonsterNpcInteract(_bb, default(IMonsterNpcInteract));
		}

		// Token: 0x06032D1D RID: 208157 RVA: 0x006DCDA0 File Offset: 0x006DAFA0
		public static IMonsterNpcInteract GetRootAsIMonsterNpcInteract(ByteBuffer _bb, IMonsterNpcInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032D1E RID: 208158 RVA: 0x006DCDBD File Offset: 0x006DAFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032D1F RID: 208159 RVA: 0x006DCDCC File Offset: 0x006DAFCC
		public IMonsterNpcInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D5C8 RID: 54728
		// (get) Token: 0x06032D20 RID: 208160 RVA: 0x006DCDDC File Offset: 0x006DAFDC
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

		// Token: 0x1700D5C9 RID: 54729
		// (get) Token: 0x06032D21 RID: 208161 RVA: 0x006DCE18 File Offset: 0x006DB018
		public int MonsterNpcEntityId
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

		// Token: 0x1700D5CA RID: 54730
		// (get) Token: 0x06032D22 RID: 208162 RVA: 0x006DCE54 File Offset: 0x006DB054
		public IMonsterNpcInteractTriggerHook? Config
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMonsterNpcInteractTriggerHook?(default(IMonsterNpcInteractTriggerHook).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032D23 RID: 208163 RVA: 0x006DCEB1 File Offset: 0x006DB0B1
		public static Offset<IMonsterNpcInteract> CreateIMonsterNpcInteract(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int MonsterNpcEntityId = 0, Offset<IMonsterNpcInteractTriggerHook> ConfigOffset = default(Offset<IMonsterNpcInteractTriggerHook>))
		{
			builder.StartTable(3);
			IMonsterNpcInteract.AddConfig(builder, ConfigOffset);
			IMonsterNpcInteract.AddMonsterNpcEntityId(builder, MonsterNpcEntityId);
			IMonsterNpcInteract.AddType(builder, Type);
			return IMonsterNpcInteract.EndIMonsterNpcInteract(builder);
		}

		// Token: 0x06032D24 RID: 208164 RVA: 0x006DCED5 File Offset: 0x006DB0D5
		public static void StartIMonsterNpcInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032D25 RID: 208165 RVA: 0x006DCEDE File Offset: 0x006DB0DE
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032D26 RID: 208166 RVA: 0x006DCEE9 File Offset: 0x006DB0E9
		public static void AddMonsterNpcEntityId(FlatBufferBuilder builder, int monsterNpcEntityId)
		{
			builder.AddInt(1, monsterNpcEntityId, 0);
		}

		// Token: 0x06032D27 RID: 208167 RVA: 0x006DCEF4 File Offset: 0x006DB0F4
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMonsterNpcInteractTriggerHook> configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x06032D28 RID: 208168 RVA: 0x006DCF04 File Offset: 0x006DB104
		public static Offset<IMonsterNpcInteract> EndIMonsterNpcInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteract>(builder.EndTable());
		}

		// Token: 0x06032D29 RID: 208169 RVA: 0x006DCF14 File Offset: 0x006DB114
		public IMonsterNpcInteractT UnPack()
		{
			IMonsterNpcInteractT monsterNpcInteractT = new IMonsterNpcInteractT();
			this.UnPackTo(monsterNpcInteractT);
			return monsterNpcInteractT;
		}

		// Token: 0x06032D2A RID: 208170 RVA: 0x006DCF30 File Offset: 0x006DB130
		public void UnPackTo(IMonsterNpcInteractT _o)
		{
			_o.Type = this.Type;
			_o.MonsterNpcEntityId = this.MonsterNpcEntityId;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x06032D2B RID: 208171 RVA: 0x006DCF84 File Offset: 0x006DB184
		public static Offset<IMonsterNpcInteract> Pack(FlatBufferBuilder builder, IMonsterNpcInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteract>);
			}
			Offset<IMonsterNpcInteractTriggerHook> configOffset = (_o.Config == null) ? default(Offset<IMonsterNpcInteractTriggerHook>) : IMonsterNpcInteractTriggerHook.Pack(builder, _o.Config);
			return IMonsterNpcInteract.CreateIMonsterNpcInteract(builder, _o.Type, _o.MonsterNpcEntityId, configOffset);
		}

		// Token: 0x04012241 RID: 74305
		private Table __p;
	}
}
