using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BA RID: 17850
	public struct ITrapDefenseSpawnMonster : IFlatbufferObject
	{
		// Token: 0x17007EDD RID: 32477
		// (get) Token: 0x0601AFDF RID: 110559 RVA: 0x003D935D File Offset: 0x003D755D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFE0 RID: 110560 RVA: 0x003D936A File Offset: 0x003D756A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFE1 RID: 110561 RVA: 0x003D9374 File Offset: 0x003D7574
		public static ITrapDefenseSpawnMonster GetRootAsITrapDefenseSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonster.GetRootAsITrapDefenseSpawnMonster(_bb, default(ITrapDefenseSpawnMonster));
		}

		// Token: 0x0601AFE2 RID: 110562 RVA: 0x003D9390 File Offset: 0x003D7590
		public static ITrapDefenseSpawnMonster GetRootAsITrapDefenseSpawnMonster(ByteBuffer _bb, ITrapDefenseSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AFE3 RID: 110563 RVA: 0x003D93AD File Offset: 0x003D75AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AFE4 RID: 110564 RVA: 0x003D93BC File Offset: 0x003D75BC
		public ITrapDefenseSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EDE RID: 32478
		// (get) Token: 0x0601AFE5 RID: 110565 RVA: 0x003D93CC File Offset: 0x003D75CC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EDF RID: 32479
		// (get) Token: 0x0601AFE6 RID: 110566 RVA: 0x003D9408 File Offset: 0x003D7608
		public ITrapDefenseSpawnMonsterGroup? MonsterGroup
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITrapDefenseSpawnMonsterGroup?(default(ITrapDefenseSpawnMonsterGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007EE0 RID: 32480
		// (get) Token: 0x0601AFE7 RID: 110567 RVA: 0x003D9468 File Offset: 0x003D7668
		public ITrapDefenseSpawnMonsterConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITrapDefenseSpawnMonsterConditionGroup?(default(ITrapDefenseSpawnMonsterConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007EE1 RID: 32481
		// (get) Token: 0x0601AFE8 RID: 110568 RVA: 0x003D94C8 File Offset: 0x003D76C8
		public string SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AFE9 RID: 110569 RVA: 0x003D9500 File Offset: 0x003D7700
		public Span<byte> GetSplineEntityIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601AFEA RID: 110570 RVA: 0x003D9510 File Offset: 0x003D7710
		public byte[] GetSplineEntityIdArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007EE2 RID: 32482
		// (get) Token: 0x0601AFEB RID: 110571 RVA: 0x003D9520 File Offset: 0x003D7720
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EE3 RID: 32483
		// (get) Token: 0x0601AFEC RID: 110572 RVA: 0x003D9564 File Offset: 0x003D7764
		public int EndingCountdown
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EE4 RID: 32484
		// (get) Token: 0x0601AFED RID: 110573 RVA: 0x003D95A4 File Offset: 0x003D77A4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AFEE RID: 110574 RVA: 0x003D95DC File Offset: 0x003D77DC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601AFEF RID: 110575 RVA: 0x003D95EC File Offset: 0x003D77EC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x0601AFF0 RID: 110576 RVA: 0x003D95FC File Offset: 0x003D77FC
		public static Offset<ITrapDefenseSpawnMonster> CreateITrapDefenseSpawnMonster(FlatBufferBuilder builder, int Id = 0, Offset<ITrapDefenseSpawnMonsterGroup> MonsterGroupOffset = default(Offset<ITrapDefenseSpawnMonsterGroup>), Offset<ITrapDefenseSpawnMonsterConditionGroup> ConditionOffset = default(Offset<ITrapDefenseSpawnMonsterConditionGroup>), StringOffset SplineEntityIdOffset = default(StringOffset), float DelayTime = 0f, int EndingCountdown = 0, StringOffset DescOffset = default(StringOffset))
		{
			builder.StartTable(7);
			ITrapDefenseSpawnMonster.AddDesc(builder, DescOffset);
			ITrapDefenseSpawnMonster.AddEndingCountdown(builder, EndingCountdown);
			ITrapDefenseSpawnMonster.AddDelayTime(builder, DelayTime);
			ITrapDefenseSpawnMonster.AddSplineEntityId(builder, SplineEntityIdOffset);
			ITrapDefenseSpawnMonster.AddCondition(builder, ConditionOffset);
			ITrapDefenseSpawnMonster.AddMonsterGroup(builder, MonsterGroupOffset);
			ITrapDefenseSpawnMonster.AddId(builder, Id);
			return ITrapDefenseSpawnMonster.EndITrapDefenseSpawnMonster(builder);
		}

		// Token: 0x0601AFF1 RID: 110577 RVA: 0x003D964B File Offset: 0x003D784B
		public static void StartITrapDefenseSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601AFF2 RID: 110578 RVA: 0x003D9654 File Offset: 0x003D7854
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601AFF3 RID: 110579 RVA: 0x003D965F File Offset: 0x003D785F
		public static void AddMonsterGroup(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonsterGroup> monsterGroupOffset)
		{
			builder.AddOffset(1, monsterGroupOffset.Value, 0);
		}

		// Token: 0x0601AFF4 RID: 110580 RVA: 0x003D966F File Offset: 0x003D786F
		public static void AddCondition(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonsterConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x0601AFF5 RID: 110581 RVA: 0x003D967F File Offset: 0x003D787F
		public static void AddSplineEntityId(FlatBufferBuilder builder, StringOffset splineEntityIdOffset)
		{
			builder.AddOffset(3, splineEntityIdOffset.Value, 0);
		}

		// Token: 0x0601AFF6 RID: 110582 RVA: 0x003D968F File Offset: 0x003D788F
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x0601AFF7 RID: 110583 RVA: 0x003D96A2 File Offset: 0x003D78A2
		public static void AddEndingCountdown(FlatBufferBuilder builder, int endingCountdown)
		{
			builder.AddInt(5, endingCountdown, 0);
		}

		// Token: 0x0601AFF8 RID: 110584 RVA: 0x003D96AD File Offset: 0x003D78AD
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(6, descOffset.Value, 0);
		}

		// Token: 0x0601AFF9 RID: 110585 RVA: 0x003D96BD File Offset: 0x003D78BD
		public static Offset<ITrapDefenseSpawnMonster> EndITrapDefenseSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonster>(builder.EndTable());
		}

		// Token: 0x0601AFFA RID: 110586 RVA: 0x003D96CC File Offset: 0x003D78CC
		public ITrapDefenseSpawnMonsterT UnPack()
		{
			ITrapDefenseSpawnMonsterT trapDefenseSpawnMonsterT = new ITrapDefenseSpawnMonsterT();
			this.UnPackTo(trapDefenseSpawnMonsterT);
			return trapDefenseSpawnMonsterT;
		}

		// Token: 0x0601AFFB RID: 110587 RVA: 0x003D96E8 File Offset: 0x003D78E8
		public void UnPackTo(ITrapDefenseSpawnMonsterT _o)
		{
			_o.Id = this.Id;
			_o.MonsterGroup = ((this.MonsterGroup != null) ? this.MonsterGroup.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.DelayTime = this.DelayTime;
			_o.EndingCountdown = this.EndingCountdown;
			_o.Desc = this.Desc;
		}

		// Token: 0x0601AFFC RID: 110588 RVA: 0x003D9790 File Offset: 0x003D7990
		public static Offset<ITrapDefenseSpawnMonster> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonster>);
			}
			Offset<ITrapDefenseSpawnMonsterGroup> monsterGroupOffset = (_o.MonsterGroup == null) ? default(Offset<ITrapDefenseSpawnMonsterGroup>) : ITrapDefenseSpawnMonsterGroup.Pack(builder, _o.MonsterGroup);
			Offset<ITrapDefenseSpawnMonsterConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<ITrapDefenseSpawnMonsterConditionGroup>) : ITrapDefenseSpawnMonsterConditionGroup.Pack(builder, _o.Condition);
			StringOffset splineEntityIdOffset = (_o.SplineEntityId == null) ? default(StringOffset) : builder.CreateString(_o.SplineEntityId);
			StringOffset descOffset = (_o.Desc == null) ? default(StringOffset) : builder.CreateString(_o.Desc);
			return ITrapDefenseSpawnMonster.CreateITrapDefenseSpawnMonster(builder, _o.Id, monsterGroupOffset, conditionOffset, splineEntityIdOffset, _o.DelayTime, _o.EndingCountdown, descOffset);
		}

		// Token: 0x0400C683 RID: 50819
		private Table __p;
	}
}
