using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A22 RID: 18978
	public struct ITrapDefenseSpawnMonster : IFlatbufferObject
	{
		// Token: 0x1700851E RID: 34078
		// (get) Token: 0x0601C7B4 RID: 116660 RVA: 0x004055F9 File Offset: 0x004037F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7B5 RID: 116661 RVA: 0x00405606 File Offset: 0x00403806
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7B6 RID: 116662 RVA: 0x00405610 File Offset: 0x00403810
		public static ITrapDefenseSpawnMonster GetRootAsITrapDefenseSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonster.GetRootAsITrapDefenseSpawnMonster(_bb, default(ITrapDefenseSpawnMonster));
		}

		// Token: 0x0601C7B7 RID: 116663 RVA: 0x0040562C File Offset: 0x0040382C
		public static ITrapDefenseSpawnMonster GetRootAsITrapDefenseSpawnMonster(ByteBuffer _bb, ITrapDefenseSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7B8 RID: 116664 RVA: 0x00405649 File Offset: 0x00403849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7B9 RID: 116665 RVA: 0x00405658 File Offset: 0x00403858
		public ITrapDefenseSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700851F RID: 34079
		// (get) Token: 0x0601C7BA RID: 116666 RVA: 0x00405668 File Offset: 0x00403868
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

		// Token: 0x17008520 RID: 34080
		// (get) Token: 0x0601C7BB RID: 116667 RVA: 0x004056A4 File Offset: 0x004038A4
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

		// Token: 0x17008521 RID: 34081
		// (get) Token: 0x0601C7BC RID: 116668 RVA: 0x00405704 File Offset: 0x00403904
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

		// Token: 0x17008522 RID: 34082
		// (get) Token: 0x0601C7BD RID: 116669 RVA: 0x00405764 File Offset: 0x00403964
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

		// Token: 0x0601C7BE RID: 116670 RVA: 0x0040579C File Offset: 0x0040399C
		public Span<byte> GetSplineEntityIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601C7BF RID: 116671 RVA: 0x004057AC File Offset: 0x004039AC
		public byte[] GetSplineEntityIdArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008523 RID: 34083
		// (get) Token: 0x0601C7C0 RID: 116672 RVA: 0x004057BC File Offset: 0x004039BC
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

		// Token: 0x17008524 RID: 34084
		// (get) Token: 0x0601C7C1 RID: 116673 RVA: 0x00405800 File Offset: 0x00403A00
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

		// Token: 0x17008525 RID: 34085
		// (get) Token: 0x0601C7C2 RID: 116674 RVA: 0x00405840 File Offset: 0x00403A40
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

		// Token: 0x0601C7C3 RID: 116675 RVA: 0x00405878 File Offset: 0x00403A78
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601C7C4 RID: 116676 RVA: 0x00405888 File Offset: 0x00403A88
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x0601C7C5 RID: 116677 RVA: 0x00405898 File Offset: 0x00403A98
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

		// Token: 0x0601C7C6 RID: 116678 RVA: 0x004058E7 File Offset: 0x00403AE7
		public static void StartITrapDefenseSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601C7C7 RID: 116679 RVA: 0x004058F0 File Offset: 0x00403AF0
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C7C8 RID: 116680 RVA: 0x004058FB File Offset: 0x00403AFB
		public static void AddMonsterGroup(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonsterGroup> monsterGroupOffset)
		{
			builder.AddOffset(1, monsterGroupOffset.Value, 0);
		}

		// Token: 0x0601C7C9 RID: 116681 RVA: 0x0040590B File Offset: 0x00403B0B
		public static void AddCondition(FlatBufferBuilder builder, Offset<ITrapDefenseSpawnMonsterConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x0601C7CA RID: 116682 RVA: 0x0040591B File Offset: 0x00403B1B
		public static void AddSplineEntityId(FlatBufferBuilder builder, StringOffset splineEntityIdOffset)
		{
			builder.AddOffset(3, splineEntityIdOffset.Value, 0);
		}

		// Token: 0x0601C7CB RID: 116683 RVA: 0x0040592B File Offset: 0x00403B2B
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(4, delayTime, 0.0);
		}

		// Token: 0x0601C7CC RID: 116684 RVA: 0x0040593E File Offset: 0x00403B3E
		public static void AddEndingCountdown(FlatBufferBuilder builder, int endingCountdown)
		{
			builder.AddInt(5, endingCountdown, 0);
		}

		// Token: 0x0601C7CD RID: 116685 RVA: 0x00405949 File Offset: 0x00403B49
		public static void AddDesc(FlatBufferBuilder builder, StringOffset descOffset)
		{
			builder.AddOffset(6, descOffset.Value, 0);
		}

		// Token: 0x0601C7CE RID: 116686 RVA: 0x00405959 File Offset: 0x00403B59
		public static Offset<ITrapDefenseSpawnMonster> EndITrapDefenseSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonster>(builder.EndTable());
		}

		// Token: 0x0601C7CF RID: 116687 RVA: 0x00405968 File Offset: 0x00403B68
		public ITrapDefenseSpawnMonsterT UnPack()
		{
			ITrapDefenseSpawnMonsterT trapDefenseSpawnMonsterT = new ITrapDefenseSpawnMonsterT();
			this.UnPackTo(trapDefenseSpawnMonsterT);
			return trapDefenseSpawnMonsterT;
		}

		// Token: 0x0601C7D0 RID: 116688 RVA: 0x00405984 File Offset: 0x00403B84
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

		// Token: 0x0601C7D1 RID: 116689 RVA: 0x00405A2C File Offset: 0x00403C2C
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

		// Token: 0x0400D0B2 RID: 53426
		private Table __p;
	}
}
