using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004277 RID: 17015
	public struct IFinishKuroSimpleCombatKillMonster : IFlatbufferObject
	{
		// Token: 0x1700741D RID: 29725
		// (get) Token: 0x06017BAC RID: 97196 RVA: 0x00362792 File Offset: 0x00360992
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017BAD RID: 97197 RVA: 0x0036279F File Offset: 0x0036099F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017BAE RID: 97198 RVA: 0x003627A8 File Offset: 0x003609A8
		public static IFinishKuroSimpleCombatKillMonster GetRootAsIFinishKuroSimpleCombatKillMonster(ByteBuffer _bb)
		{
			return IFinishKuroSimpleCombatKillMonster.GetRootAsIFinishKuroSimpleCombatKillMonster(_bb, default(IFinishKuroSimpleCombatKillMonster));
		}

		// Token: 0x06017BAF RID: 97199 RVA: 0x003627C4 File Offset: 0x003609C4
		public static IFinishKuroSimpleCombatKillMonster GetRootAsIFinishKuroSimpleCombatKillMonster(ByteBuffer _bb, IFinishKuroSimpleCombatKillMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017BB0 RID: 97200 RVA: 0x003627E1 File Offset: 0x003609E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017BB1 RID: 97201 RVA: 0x003627F0 File Offset: 0x003609F0
		public IFinishKuroSimpleCombatKillMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700741E RID: 29726
		// (get) Token: 0x06017BB2 RID: 97202 RVA: 0x00362800 File Offset: 0x00360A00
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

		// Token: 0x1700741F RID: 29727
		// (get) Token: 0x06017BB3 RID: 97203 RVA: 0x0036283C File Offset: 0x00360A3C
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

		// Token: 0x17007420 RID: 29728
		// (get) Token: 0x06017BB4 RID: 97204 RVA: 0x0036289C File Offset: 0x00360A9C
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

		// Token: 0x17007421 RID: 29729
		// (get) Token: 0x06017BB5 RID: 97205 RVA: 0x003628D8 File Offset: 0x00360AD8
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

		// Token: 0x06017BB6 RID: 97206 RVA: 0x00362915 File Offset: 0x00360B15
		public static Offset<IFinishKuroSimpleCombatKillMonster> CreateIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int KuroSimpleCombatSpawnMonsterConfigId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFinishKuroSimpleCombatKillMonster.AddKuroSimpleCombatSpawnMonsterConfigId(builder, KuroSimpleCombatSpawnMonsterConfigId);
			IFinishKuroSimpleCombatKillMonster.AddPreConditions(builder, PreConditionsOffset);
			IFinishKuroSimpleCombatKillMonster.AddNullMask(builder, NullMask);
			IFinishKuroSimpleCombatKillMonster.AddType(builder, Type);
			return IFinishKuroSimpleCombatKillMonster.EndIFinishKuroSimpleCombatKillMonster(builder);
		}

		// Token: 0x06017BB7 RID: 97207 RVA: 0x00362941 File Offset: 0x00360B41
		public static void StartIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017BB8 RID: 97208 RVA: 0x0036294A File Offset: 0x00360B4A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017BB9 RID: 97209 RVA: 0x00362955 File Offset: 0x00360B55
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017BBA RID: 97210 RVA: 0x00362965 File Offset: 0x00360B65
		public static void AddKuroSimpleCombatSpawnMonsterConfigId(FlatBufferBuilder builder, int kuroSimpleCombatSpawnMonsterConfigId)
		{
			builder.AddInt(2, kuroSimpleCombatSpawnMonsterConfigId, 0);
		}

		// Token: 0x06017BBB RID: 97211 RVA: 0x00362970 File Offset: 0x00360B70
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06017BBC RID: 97212 RVA: 0x0036297B File Offset: 0x00360B7B
		public static Offset<IFinishKuroSimpleCombatKillMonster> EndIFinishKuroSimpleCombatKillMonster(FlatBufferBuilder builder)
		{
			return new Offset<IFinishKuroSimpleCombatKillMonster>(builder.EndTable());
		}

		// Token: 0x06017BBD RID: 97213 RVA: 0x00362988 File Offset: 0x00360B88
		public IFinishKuroSimpleCombatKillMonsterT UnPack()
		{
			IFinishKuroSimpleCombatKillMonsterT finishKuroSimpleCombatKillMonsterT = new IFinishKuroSimpleCombatKillMonsterT();
			this.UnPackTo(finishKuroSimpleCombatKillMonsterT);
			return finishKuroSimpleCombatKillMonsterT;
		}

		// Token: 0x06017BBE RID: 97214 RVA: 0x003629A4 File Offset: 0x00360BA4
		public void UnPackTo(IFinishKuroSimpleCombatKillMonsterT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.KuroSimpleCombatSpawnMonsterConfigId = this.KuroSimpleCombatSpawnMonsterConfigId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017BBF RID: 97215 RVA: 0x00362A04 File Offset: 0x00360C04
		public static Offset<IFinishKuroSimpleCombatKillMonster> Pack(FlatBufferBuilder builder, IFinishKuroSimpleCombatKillMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishKuroSimpleCombatKillMonster>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IFinishKuroSimpleCombatKillMonster.CreateIFinishKuroSimpleCombatKillMonster(builder, _o.Type, preConditionsOffset, _o.KuroSimpleCombatSpawnMonsterConfigId, _o.NullMask);
		}

		// Token: 0x0400C1A1 RID: 49569
		private Table __p;
	}
}
