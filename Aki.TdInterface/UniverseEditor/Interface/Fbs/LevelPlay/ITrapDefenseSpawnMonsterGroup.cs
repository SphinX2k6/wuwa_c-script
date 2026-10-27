using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CF RID: 17871
	public struct ITrapDefenseSpawnMonsterGroup : IFlatbufferObject
	{
		// Token: 0x17007F04 RID: 32516
		// (get) Token: 0x0601B093 RID: 110739 RVA: 0x003DA832 File Offset: 0x003D8A32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B094 RID: 110740 RVA: 0x003DA83F File Offset: 0x003D8A3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B095 RID: 110741 RVA: 0x003DA848 File Offset: 0x003D8A48
		public static ITrapDefenseSpawnMonsterGroup GetRootAsITrapDefenseSpawnMonsterGroup(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterGroup.GetRootAsITrapDefenseSpawnMonsterGroup(_bb, default(ITrapDefenseSpawnMonsterGroup));
		}

		// Token: 0x0601B096 RID: 110742 RVA: 0x003DA864 File Offset: 0x003D8A64
		public static ITrapDefenseSpawnMonsterGroup GetRootAsITrapDefenseSpawnMonsterGroup(ByteBuffer _bb, ITrapDefenseSpawnMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B097 RID: 110743 RVA: 0x003DA881 File Offset: 0x003D8A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B098 RID: 110744 RVA: 0x003DA890 File Offset: 0x003D8A90
		public ITrapDefenseSpawnMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F05 RID: 32517
		// (get) Token: 0x0601B099 RID: 110745 RVA: 0x003DA8A0 File Offset: 0x003D8AA0
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

		// Token: 0x17007F06 RID: 32518
		// (get) Token: 0x0601B09A RID: 110746 RVA: 0x003DA8DC File Offset: 0x003D8ADC
		public int RepeatTimes
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

		// Token: 0x17007F07 RID: 32519
		// (get) Token: 0x0601B09B RID: 110747 RVA: 0x003DA918 File Offset: 0x003D8B18
		public float RepeatDelayTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F08 RID: 32520
		// (get) Token: 0x0601B09C RID: 110748 RVA: 0x003DA958 File Offset: 0x003D8B58
		public float IntervalTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B09D RID: 110749 RVA: 0x003DA999 File Offset: 0x003D8B99
		public static Offset<ITrapDefenseSpawnMonsterGroup> CreateITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder, int Id = 0, int RepeatTimes = 0, float RepeatDelayTime = 0f, float IntervalTime = 0f)
		{
			builder.StartTable(4);
			ITrapDefenseSpawnMonsterGroup.AddIntervalTime(builder, IntervalTime);
			ITrapDefenseSpawnMonsterGroup.AddRepeatDelayTime(builder, RepeatDelayTime);
			ITrapDefenseSpawnMonsterGroup.AddRepeatTimes(builder, RepeatTimes);
			ITrapDefenseSpawnMonsterGroup.AddId(builder, Id);
			return ITrapDefenseSpawnMonsterGroup.EndITrapDefenseSpawnMonsterGroup(builder);
		}

		// Token: 0x0601B09E RID: 110750 RVA: 0x003DA9C5 File Offset: 0x003D8BC5
		public static void StartITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B09F RID: 110751 RVA: 0x003DA9CE File Offset: 0x003D8BCE
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601B0A0 RID: 110752 RVA: 0x003DA9D9 File Offset: 0x003D8BD9
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(1, repeatTimes, 0);
		}

		// Token: 0x0601B0A1 RID: 110753 RVA: 0x003DA9E4 File Offset: 0x003D8BE4
		public static void AddRepeatDelayTime(FlatBufferBuilder builder, float repeatDelayTime)
		{
			builder.AddFloat(2, repeatDelayTime, 0.0);
		}

		// Token: 0x0601B0A2 RID: 110754 RVA: 0x003DA9F7 File Offset: 0x003D8BF7
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(3, intervalTime, 0.0);
		}

		// Token: 0x0601B0A3 RID: 110755 RVA: 0x003DAA0A File Offset: 0x003D8C0A
		public static Offset<ITrapDefenseSpawnMonsterGroup> EndITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601B0A4 RID: 110756 RVA: 0x003DAA18 File Offset: 0x003D8C18
		public ITrapDefenseSpawnMonsterGroupT UnPack()
		{
			ITrapDefenseSpawnMonsterGroupT trapDefenseSpawnMonsterGroupT = new ITrapDefenseSpawnMonsterGroupT();
			this.UnPackTo(trapDefenseSpawnMonsterGroupT);
			return trapDefenseSpawnMonsterGroupT;
		}

		// Token: 0x0601B0A5 RID: 110757 RVA: 0x003DAA33 File Offset: 0x003D8C33
		public void UnPackTo(ITrapDefenseSpawnMonsterGroupT _o)
		{
			_o.Id = this.Id;
			_o.RepeatTimes = this.RepeatTimes;
			_o.RepeatDelayTime = this.RepeatDelayTime;
			_o.IntervalTime = this.IntervalTime;
		}

		// Token: 0x0601B0A6 RID: 110758 RVA: 0x003DAA68 File Offset: 0x003D8C68
		public static Offset<ITrapDefenseSpawnMonsterGroup> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterGroup>);
			}
			return ITrapDefenseSpawnMonsterGroup.CreateITrapDefenseSpawnMonsterGroup(builder, _o.Id, _o.RepeatTimes, _o.RepeatDelayTime, _o.IntervalTime);
		}

		// Token: 0x0400C6A0 RID: 50848
		private Table __p;
	}
}
