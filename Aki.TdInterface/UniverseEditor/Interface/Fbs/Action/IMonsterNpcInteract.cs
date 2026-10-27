using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADF RID: 27359
	public struct IMonsterNpcInteract : IFlatbufferObject
	{
		// Token: 0x1700CAF8 RID: 51960
		// (get) Token: 0x0602FF46 RID: 196422 RVA: 0x006856B6 File Offset: 0x006838B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF47 RID: 196423 RVA: 0x006856C3 File Offset: 0x006838C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF48 RID: 196424 RVA: 0x006856CC File Offset: 0x006838CC
		public static IMonsterNpcInteract GetRootAsIMonsterNpcInteract(ByteBuffer _bb)
		{
			return IMonsterNpcInteract.GetRootAsIMonsterNpcInteract(_bb, default(IMonsterNpcInteract));
		}

		// Token: 0x0602FF49 RID: 196425 RVA: 0x006856E8 File Offset: 0x006838E8
		public static IMonsterNpcInteract GetRootAsIMonsterNpcInteract(ByteBuffer _bb, IMonsterNpcInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF4A RID: 196426 RVA: 0x00685705 File Offset: 0x00683905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF4B RID: 196427 RVA: 0x00685714 File Offset: 0x00683914
		public IMonsterNpcInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAF9 RID: 51961
		// (get) Token: 0x0602FF4C RID: 196428 RVA: 0x00685724 File Offset: 0x00683924
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

		// Token: 0x1700CAFA RID: 51962
		// (get) Token: 0x0602FF4D RID: 196429 RVA: 0x00685760 File Offset: 0x00683960
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

		// Token: 0x1700CAFB RID: 51963
		// (get) Token: 0x0602FF4E RID: 196430 RVA: 0x0068579C File Offset: 0x0068399C
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

		// Token: 0x0602FF4F RID: 196431 RVA: 0x006857F9 File Offset: 0x006839F9
		public static Offset<IMonsterNpcInteract> CreateIMonsterNpcInteract(FlatBufferBuilder builder, EExecClientBattleActionType Type = EExecClientBattleActionType.SendTagEventToControlCharacter, int MonsterNpcEntityId = 0, Offset<IMonsterNpcInteractTriggerHook> ConfigOffset = default(Offset<IMonsterNpcInteractTriggerHook>))
		{
			builder.StartTable(3);
			IMonsterNpcInteract.AddConfig(builder, ConfigOffset);
			IMonsterNpcInteract.AddMonsterNpcEntityId(builder, MonsterNpcEntityId);
			IMonsterNpcInteract.AddType(builder, Type);
			return IMonsterNpcInteract.EndIMonsterNpcInteract(builder);
		}

		// Token: 0x0602FF50 RID: 196432 RVA: 0x0068581D File Offset: 0x00683A1D
		public static void StartIMonsterNpcInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FF51 RID: 196433 RVA: 0x00685826 File Offset: 0x00683A26
		public static void AddType(FlatBufferBuilder builder, EExecClientBattleActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FF52 RID: 196434 RVA: 0x00685831 File Offset: 0x00683A31
		public static void AddMonsterNpcEntityId(FlatBufferBuilder builder, int monsterNpcEntityId)
		{
			builder.AddInt(1, monsterNpcEntityId, 0);
		}

		// Token: 0x0602FF53 RID: 196435 RVA: 0x0068583C File Offset: 0x00683A3C
		public static void AddConfig(FlatBufferBuilder builder, Offset<IMonsterNpcInteractTriggerHook> configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x0602FF54 RID: 196436 RVA: 0x0068584C File Offset: 0x00683A4C
		public static Offset<IMonsterNpcInteract> EndIMonsterNpcInteract(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteract>(builder.EndTable());
		}

		// Token: 0x0602FF55 RID: 196437 RVA: 0x0068585C File Offset: 0x00683A5C
		public IMonsterNpcInteractT UnPack()
		{
			IMonsterNpcInteractT monsterNpcInteractT = new IMonsterNpcInteractT();
			this.UnPackTo(monsterNpcInteractT);
			return monsterNpcInteractT;
		}

		// Token: 0x0602FF56 RID: 196438 RVA: 0x00685878 File Offset: 0x00683A78
		public void UnPackTo(IMonsterNpcInteractT _o)
		{
			_o.Type = this.Type;
			_o.MonsterNpcEntityId = this.MonsterNpcEntityId;
			_o.Config = ((this.Config != null) ? this.Config.Value.UnPack() : null);
		}

		// Token: 0x0602FF57 RID: 196439 RVA: 0x006858CC File Offset: 0x00683ACC
		public static Offset<IMonsterNpcInteract> Pack(FlatBufferBuilder builder, IMonsterNpcInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteract>);
			}
			Offset<IMonsterNpcInteractTriggerHook> configOffset = (_o.Config == null) ? default(Offset<IMonsterNpcInteractTriggerHook>) : IMonsterNpcInteractTriggerHook.Pack(builder, _o.Config);
			return IMonsterNpcInteract.CreateIMonsterNpcInteract(builder, _o.Type, _o.MonsterNpcEntityId, configOffset);
		}

		// Token: 0x0401132E RID: 70446
		private Table __p;
	}
}
