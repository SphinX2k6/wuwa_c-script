using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFA RID: 20474
	public struct IConditionSpawnMonster : IFlatbufferObject
	{
		// Token: 0x17009454 RID: 37972
		// (get) Token: 0x06020BA7 RID: 134055 RVA: 0x0048CFBF File Offset: 0x0048B1BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BA8 RID: 134056 RVA: 0x0048CFCC File Offset: 0x0048B1CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BA9 RID: 134057 RVA: 0x0048CFD4 File Offset: 0x0048B1D4
		public static IConditionSpawnMonster GetRootAsIConditionSpawnMonster(ByteBuffer _bb)
		{
			return IConditionSpawnMonster.GetRootAsIConditionSpawnMonster(_bb, default(IConditionSpawnMonster));
		}

		// Token: 0x06020BAA RID: 134058 RVA: 0x0048CFF0 File Offset: 0x0048B1F0
		public static IConditionSpawnMonster GetRootAsIConditionSpawnMonster(ByteBuffer _bb, IConditionSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BAB RID: 134059 RVA: 0x0048D00D File Offset: 0x0048B20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BAC RID: 134060 RVA: 0x0048D01C File Offset: 0x0048B21C
		public IConditionSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009455 RID: 37973
		// (get) Token: 0x06020BAD RID: 134061 RVA: 0x0048D02C File Offset: 0x0048B22C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009456 RID: 37974
		// (get) Token: 0x06020BAE RID: 134062 RVA: 0x0048D08C File Offset: 0x0048B28C
		public IConditionGroup? EndCondition
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

		// Token: 0x17009457 RID: 37975
		// (get) Token: 0x06020BAF RID: 134063 RVA: 0x0048D0EC File Offset: 0x0048B2EC
		public bool Loop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020BB0 RID: 134064 RVA: 0x0048D12C File Offset: 0x0048B32C
		public IDynamicSpawnMonsterConfig? BatchConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterConfig?(default(IDynamicSpawnMonsterConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009458 RID: 37976
		// (get) Token: 0x06020BB1 RID: 134065 RVA: 0x0048D190 File Offset: 0x0048B390
		public int BatchConfigsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009459 RID: 37977
		// (get) Token: 0x06020BB2 RID: 134066 RVA: 0x0048D1BC File Offset: 0x0048B3BC
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

		// Token: 0x06020BB3 RID: 134067 RVA: 0x0048D1F9 File Offset: 0x0048B3F9
		public static Offset<IConditionSpawnMonster> CreateIConditionSpawnMonster(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> EndConditionOffset = default(Offset<IConditionGroup>), bool Loop = false, VectorOffset BatchConfigsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IConditionSpawnMonster.AddBatchConfigs(builder, BatchConfigsOffset);
			IConditionSpawnMonster.AddEndCondition(builder, EndConditionOffset);
			IConditionSpawnMonster.AddCondition(builder, ConditionOffset);
			IConditionSpawnMonster.AddNullMask(builder, NullMask);
			IConditionSpawnMonster.AddLoop(builder, Loop);
			return IConditionSpawnMonster.EndIConditionSpawnMonster(builder);
		}

		// Token: 0x06020BB4 RID: 134068 RVA: 0x0048D22D File Offset: 0x0048B42D
		public static void StartIConditionSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020BB5 RID: 134069 RVA: 0x0048D236 File Offset: 0x0048B436
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020BB6 RID: 134070 RVA: 0x0048D246 File Offset: 0x0048B446
		public static void AddEndCondition(FlatBufferBuilder builder, Offset<IConditionGroup> endConditionOffset)
		{
			builder.AddOffset(1, endConditionOffset.Value, 0);
		}

		// Token: 0x06020BB7 RID: 134071 RVA: 0x0048D256 File Offset: 0x0048B456
		public static void AddLoop(FlatBufferBuilder builder, bool loop)
		{
			builder.AddBool(2, loop, false);
		}

		// Token: 0x06020BB8 RID: 134072 RVA: 0x0048D261 File Offset: 0x0048B461
		public static void AddBatchConfigs(FlatBufferBuilder builder, VectorOffset batchConfigsOffset)
		{
			builder.AddOffset(3, batchConfigsOffset.Value, 0);
		}

		// Token: 0x06020BB9 RID: 134073 RVA: 0x0048D274 File Offset: 0x0048B474
		public static VectorOffset CreateBatchConfigsVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020BBA RID: 134074 RVA: 0x0048D2B4 File Offset: 0x0048B4B4
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BBB RID: 134075 RVA: 0x0048D2CE File Offset: 0x0048B4CE
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06020BBC RID: 134076 RVA: 0x0048D2EC File Offset: 0x0048B4EC
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020BBD RID: 134077 RVA: 0x0048D305 File Offset: 0x0048B505
		public static void StartBatchConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020BBE RID: 134078 RVA: 0x0048D310 File Offset: 0x0048B510
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020BBF RID: 134079 RVA: 0x0048D31B File Offset: 0x0048B51B
		public static Offset<IConditionSpawnMonster> EndIConditionSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSpawnMonster>(builder.EndTable());
		}

		// Token: 0x06020BC0 RID: 134080 RVA: 0x0048D328 File Offset: 0x0048B528
		public IConditionSpawnMonsterT UnPack()
		{
			IConditionSpawnMonsterT conditionSpawnMonsterT = new IConditionSpawnMonsterT();
			this.UnPackTo(conditionSpawnMonsterT);
			return conditionSpawnMonsterT;
		}

		// Token: 0x06020BC1 RID: 134081 RVA: 0x0048D344 File Offset: 0x0048B544
		public void UnPackTo(IConditionSpawnMonsterT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.EndCondition = ((this.EndCondition != null) ? this.EndCondition.Value.UnPack() : null);
			_o.Loop = this.Loop;
			_o.BatchConfigs = new List<IDynamicSpawnMonsterConfigT>();
			for (int i = 0; i < this.BatchConfigsLength; i++)
			{
				_o.BatchConfigs.Add((this.BatchConfigs(i) != null) ? this.BatchConfigs(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020BC2 RID: 134082 RVA: 0x0048D41C File Offset: 0x0048B61C
		public static Offset<IConditionSpawnMonster> Pack(FlatBufferBuilder builder, IConditionSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionSpawnMonster>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IConditionGroup> endConditionOffset = (_o.EndCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EndCondition);
			VectorOffset batchConfigsOffset = default(VectorOffset);
			if (_o.BatchConfigs != null)
			{
				Offset<IDynamicSpawnMonsterConfig>[] array = new Offset<IDynamicSpawnMonsterConfig>[_o.BatchConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDynamicSpawnMonsterConfig.Pack(builder, _o.BatchConfigs[i]);
				}
				batchConfigsOffset = IConditionSpawnMonster.CreateBatchConfigsVector(builder, array);
			}
			return IConditionSpawnMonster.CreateIConditionSpawnMonster(builder, conditionOffset, endConditionOffset, _o.Loop, batchConfigsOffset, _o.NullMask);
		}

		// Token: 0x0400DFB4 RID: 57268
		private Table __p;
	}
}
