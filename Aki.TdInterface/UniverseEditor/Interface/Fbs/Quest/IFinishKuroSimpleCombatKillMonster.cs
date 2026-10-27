using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3C RID: 15932
	public struct IFinishKuroSimpleCombatKillMonster : IFlatbufferObject
	{
		// Token: 0x17006E39 RID: 28217
		// (get) Token: 0x06016585 RID: 91525 RVA: 0x00339C61 File Offset: 0x00337E61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016586 RID: 91526 RVA: 0x00339C6E File Offset: 0x00337E6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016587 RID: 91527 RVA: 0x00339C78 File Offset: 0x00337E78
		public static IFinishKuroSimpleCombatKillMonster GetRootAsIFinishKuroSimpleCombatKillMonster(ByteBuffer _bb)
		{
			return IFinishKuroSimpleCombatKillMonster.GetRootAsIFinishKuroSimpleCombatKillMonster(_bb, default(IFinishKuroSimpleCombatKillMonster));
		}

		// Token: 0x06016588 RID: 91528 RVA: 0x00339C94 File Offset: 0x00337E94
		public static IFinishKuroSimpleCombatKillMonster GetRootAsIFinishKuroSimpleCombatKillMonster(ByteBuffer _bb, IFinishKuroSimpleCombatKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016589 RID: 91529 RVA: 0x00339CB1 File Offset: 0x00337EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601658A RID: 91530 RVA: 0x00339CC0 File Offset: 0x00337EC0
		public IFinishKuroSimpleCombatKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E3A RID: 28218
		// (get) Token: 0x0601658B RID: 91531 RVA: 0x00339CD0 File Offset: 0x00337ED0
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

		// Token: 0x17006E3B RID: 28219
		// (get) Token: 0x0601658C RID: 91532 RVA: 0x00339D0C File Offset: 0x00337F0C
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

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x0601658D RID: 91533 RVA: 0x00339D6C File Offset: 0x00337F6C
		public int KuroSimpleCombatSpawnMonsterConfigId
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

		// Token: 0x17006E3D RID: 28221
		// (get) Token: 0x0601658E RID: 91534 RVA: 0x00339DA8 File Offset: 0x00337FA8
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

		// Token: 0x0601658F RID: 91535 RVA: 0x00339DE5 File Offset: 0x00337FE5
		public static Offset<IFinishKuroSimpleCombatKillMonster> CreateIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int KuroSimpleCombatSpawnMonsterConfigId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFinishKuroSimpleCombatKillMonster.AddKuroSimpleCombatSpawnMonsterConfigId(builder, KuroSimpleCombatSpawnMonsterConfigId);
			IFinishKuroSimpleCombatKillMonster.AddPreConditions(builder, PreConditionsOffset);
			IFinishKuroSimpleCombatKillMonster.AddNullMask(builder, NullMask);
			IFinishKuroSimpleCombatKillMonster.AddType(builder, Type);
			return IFinishKuroSimpleCombatKillMonster.EndIFinishKuroSimpleCombatKillMonster(builder);
		}

		// Token: 0x06016590 RID: 91536 RVA: 0x00339E11 File Offset: 0x00338011
		public static void StartIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016591 RID: 91537 RVA: 0x00339E1A File Offset: 0x0033801A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016592 RID: 91538 RVA: 0x00339E25 File Offset: 0x00338025
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016593 RID: 91539 RVA: 0x00339E35 File Offset: 0x00338035
		public static void AddKuroSimpleCombatSpawnMonsterConfigId(FlatBufferBuilder builder, int kuroSimpleCombatSpawnMonsterConfigId)
		{
			builder.AddInt(2, kuroSimpleCombatSpawnMonsterConfigId, 0);
		}

		// Token: 0x06016594 RID: 91540 RVA: 0x00339E40 File Offset: 0x00338040
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06016595 RID: 91541 RVA: 0x00339E4B File Offset: 0x0033804B
		public static Offset<IFinishKuroSimpleCombatKillMonster> EndIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IFinishKuroSimpleCombatKillMonster>(builder.EndTable());
		}

		// Token: 0x06016596 RID: 91542 RVA: 0x00339E58 File Offset: 0x00338058
		public IFinishKuroSimpleCombatKillMonsterT UnPack()
		{
			IFinishKuroSimpleCombatKillMonsterT finishKuroSimpleCombatKillMonsterT = new IFinishKuroSimpleCombatKillMonsterT();
			this.UnPackTo(finishKuroSimpleCombatKillMonsterT);
			return finishKuroSimpleCombatKillMonsterT;
		}

		// Token: 0x06016597 RID: 91543 RVA: 0x00339E74 File Offset: 0x00338074
		public void UnPackTo(IFinishKuroSimpleCombatKillMonsterT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.KuroSimpleCombatSpawnMonsterConfigId = this.KuroSimpleCombatSpawnMonsterConfigId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016598 RID: 91544 RVA: 0x00339ED4 File Offset: 0x003380D4
		public static Offset<IFinishKuroSimpleCombatKillMonster> Pack(FlatBufferBuilder builder, IFinishKuroSimpleCombatKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishKuroSimpleCombatKillMonster>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IFinishKuroSimpleCombatKillMonster.CreateIFinishKuroSimpleCombatKillMonster(builder, _o.Type, preConditionsOffset, _o.KuroSimpleCombatSpawnMonsterConfigId, _o.NullMask);
		}

		// Token: 0x0400B7CA RID: 47050
		private Table __p;
	}
}
