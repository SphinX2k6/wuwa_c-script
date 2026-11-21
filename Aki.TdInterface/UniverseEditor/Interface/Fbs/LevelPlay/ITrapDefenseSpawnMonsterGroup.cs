using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A37 RID: 18999
	public struct ITrapDefenseSpawnMonsterGroup : IFlatbufferObject
	{
		// Token: 0x17008545 RID: 34117
		// (get) Token: 0x0601C868 RID: 116840 RVA: 0x00406ACE File Offset: 0x00404CCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C869 RID: 116841 RVA: 0x00406ADB File Offset: 0x00404CDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C86A RID: 116842 RVA: 0x00406AE4 File Offset: 0x00404CE4
		public static ITrapDefenseSpawnMonsterGroup GetRootAsITrapDefenseSpawnMonsterGroup(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterGroup.GetRootAsITrapDefenseSpawnMonsterGroup(_bb, default(ITrapDefenseSpawnMonsterGroup));
		}

		// Token: 0x0601C86B RID: 116843 RVA: 0x00406B00 File Offset: 0x00404D00
		public static ITrapDefenseSpawnMonsterGroup GetRootAsITrapDefenseSpawnMonsterGroup(ByteBuffer _bb, ITrapDefenseSpawnMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C86C RID: 116844 RVA: 0x00406B1D File Offset: 0x00404D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C86D RID: 116845 RVA: 0x00406B2C File Offset: 0x00404D2C
		public ITrapDefenseSpawnMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008546 RID: 34118
		// (get) Token: 0x0601C86E RID: 116846 RVA: 0x00406B3C File Offset: 0x00404D3C
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

		// Token: 0x17008547 RID: 34119
		// (get) Token: 0x0601C86F RID: 116847 RVA: 0x00406B78 File Offset: 0x00404D78
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

		// Token: 0x17008548 RID: 34120
		// (get) Token: 0x0601C870 RID: 116848 RVA: 0x00406BB4 File Offset: 0x00404DB4
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

		// Token: 0x17008549 RID: 34121
		// (get) Token: 0x0601C871 RID: 116849 RVA: 0x00406BF4 File Offset: 0x00404DF4
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

		// Token: 0x0601C872 RID: 116850 RVA: 0x00406C35 File Offset: 0x00404E35
		public static Offset<ITrapDefenseSpawnMonsterGroup> CreateITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder, int Id = 0, int RepeatTimes = 0, float RepeatDelayTime = 0f, float IntervalTime = 0f)
		{
			builder.StartTable(4);
			ITrapDefenseSpawnMonsterGroup.AddIntervalTime(builder, IntervalTime);
			ITrapDefenseSpawnMonsterGroup.AddRepeatDelayTime(builder, RepeatDelayTime);
			ITrapDefenseSpawnMonsterGroup.AddRepeatTimes(builder, RepeatTimes);
			ITrapDefenseSpawnMonsterGroup.AddId(builder, Id);
			return ITrapDefenseSpawnMonsterGroup.EndITrapDefenseSpawnMonsterGroup(builder);
		}

		// Token: 0x0601C873 RID: 116851 RVA: 0x00406C61 File Offset: 0x00404E61
		public static void StartITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601C874 RID: 116852 RVA: 0x00406C6A File Offset: 0x00404E6A
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C875 RID: 116853 RVA: 0x00406C75 File Offset: 0x00404E75
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(1, repeatTimes, 0);
		}

		// Token: 0x0601C876 RID: 116854 RVA: 0x00406C80 File Offset: 0x00404E80
		public static void AddRepeatDelayTime(FlatBufferBuilder builder, float repeatDelayTime)
		{
			builder.AddFloat(2, repeatDelayTime, 0.0);
		}

		// Token: 0x0601C877 RID: 116855 RVA: 0x00406C93 File Offset: 0x00404E93
		public static void AddIntervalTime(FlatBufferBuilder builder, float intervalTime)
		{
			builder.AddFloat(3, intervalTime, 0.0);
		}

		// Token: 0x0601C878 RID: 116856 RVA: 0x00406CA6 File Offset: 0x00404EA6
		public static Offset<ITrapDefenseSpawnMonsterGroup> EndITrapDefenseSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601C879 RID: 116857 RVA: 0x00406CB4 File Offset: 0x00404EB4
		public ITrapDefenseSpawnMonsterGroupT UnPack()
		{
			ITrapDefenseSpawnMonsterGroupT trapDefenseSpawnMonsterGroupT = new ITrapDefenseSpawnMonsterGroupT();
			this.UnPackTo(trapDefenseSpawnMonsterGroupT);
			return trapDefenseSpawnMonsterGroupT;
		}

		// Token: 0x0601C87A RID: 116858 RVA: 0x00406CCF File Offset: 0x00404ECF
		public void UnPackTo(ITrapDefenseSpawnMonsterGroupT _o)
		{
			_o.Id = this.Id;
			_o.RepeatTimes = this.RepeatTimes;
			_o.RepeatDelayTime = this.RepeatDelayTime;
			_o.IntervalTime = this.IntervalTime;
		}

		// Token: 0x0601C87B RID: 116859 RVA: 0x00406D04 File Offset: 0x00404F04
		public static Offset<ITrapDefenseSpawnMonsterGroup> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterGroup>);
			}
			return ITrapDefenseSpawnMonsterGroup.CreateITrapDefenseSpawnMonsterGroup(builder, _o.Id, _o.RepeatTimes, _o.RepeatDelayTime, _o.IntervalTime);
		}

		// Token: 0x0400D0CF RID: 53455
		private Table __p;
	}
}
