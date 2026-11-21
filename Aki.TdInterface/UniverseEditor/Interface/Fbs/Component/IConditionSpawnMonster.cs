using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005559 RID: 21849
	public struct IConditionSpawnMonster : IFlatbufferObject
	{
		// Token: 0x17009C35 RID: 39989
		// (get) Token: 0x06022AC7 RID: 142023 RVA: 0x004C6A0F File Offset: 0x004C4C0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022AC8 RID: 142024 RVA: 0x004C6A1C File Offset: 0x004C4C1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022AC9 RID: 142025 RVA: 0x004C6A24 File Offset: 0x004C4C24
		public static IConditionSpawnMonster GetRootAsIConditionSpawnMonster(ByteBuffer _bb)
		{
			return IConditionSpawnMonster.GetRootAsIConditionSpawnMonster(_bb, default(IConditionSpawnMonster));
		}

		// Token: 0x06022ACA RID: 142026 RVA: 0x004C6A40 File Offset: 0x004C4C40
		public static IConditionSpawnMonster GetRootAsIConditionSpawnMonster(ByteBuffer _bb, IConditionSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022ACB RID: 142027 RVA: 0x004C6A5D File Offset: 0x004C4C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022ACC RID: 142028 RVA: 0x004C6A6C File Offset: 0x004C4C6C
		public IConditionSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C36 RID: 39990
		// (get) Token: 0x06022ACD RID: 142029 RVA: 0x004C6A7C File Offset: 0x004C4C7C
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

		// Token: 0x17009C37 RID: 39991
		// (get) Token: 0x06022ACE RID: 142030 RVA: 0x004C6ADC File Offset: 0x004C4CDC
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

		// Token: 0x17009C38 RID: 39992
		// (get) Token: 0x06022ACF RID: 142031 RVA: 0x004C6B3C File Offset: 0x004C4D3C
		public bool Loop
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022AD0 RID: 142032 RVA: 0x004C6B7C File Offset: 0x004C4D7C
		public IDynamicSpawnMonsterConfig? BatchConfigs(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IDynamicSpawnMonsterConfig?(default(IDynamicSpawnMonsterConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C39 RID: 39993
		// (get) Token: 0x06022AD1 RID: 142033 RVA: 0x004C6BE0 File Offset: 0x004C4DE0
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

		// Token: 0x17009C3A RID: 39994
		// (get) Token: 0x06022AD2 RID: 142034 RVA: 0x004C6C0C File Offset: 0x004C4E0C
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

		// Token: 0x06022AD3 RID: 142035 RVA: 0x004C6C49 File Offset: 0x004C4E49
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

		// Token: 0x06022AD4 RID: 142036 RVA: 0x004C6C7D File Offset: 0x004C4E7D
		public static void StartIConditionSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022AD5 RID: 142037 RVA: 0x004C6C86 File Offset: 0x004C4E86
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022AD6 RID: 142038 RVA: 0x004C6C96 File Offset: 0x004C4E96
		public static void AddEndCondition(FlatBufferBuilder builder, Offset<IConditionGroup> endConditionOffset)
		{
			builder.AddOffset(1, endConditionOffset.Value, 0);
		}

		// Token: 0x06022AD7 RID: 142039 RVA: 0x004C6CA6 File Offset: 0x004C4EA6
		public static void AddLoop(FlatBufferBuilder builder, bool loop)
		{
			builder.AddBool(2, loop, false);
		}

		// Token: 0x06022AD8 RID: 142040 RVA: 0x004C6CB1 File Offset: 0x004C4EB1
		public static void AddBatchConfigs(FlatBufferBuilder builder, VectorOffset batchConfigsOffset)
		{
			builder.AddOffset(3, batchConfigsOffset.Value, 0);
		}

		// Token: 0x06022AD9 RID: 142041 RVA: 0x004C6CC4 File Offset: 0x004C4EC4
		public static VectorOffset CreateBatchConfigsVector(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022ADA RID: 142042 RVA: 0x004C6D04 File Offset: 0x004C4F04
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDynamicSpawnMonsterConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022ADB RID: 142043 RVA: 0x004C6D1E File Offset: 0x004C4F1E
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDynamicSpawnMonsterConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022ADC RID: 142044 RVA: 0x004C6D3C File Offset: 0x004C4F3C
		public static VectorOffset CreateBatchConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDynamicSpawnMonsterConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022ADD RID: 142045 RVA: 0x004C6D55 File Offset: 0x004C4F55
		public static void StartBatchConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022ADE RID: 142046 RVA: 0x004C6D60 File Offset: 0x004C4F60
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022ADF RID: 142047 RVA: 0x004C6D6B File Offset: 0x004C4F6B
		public static Offset<IConditionSpawnMonster> EndIConditionSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<IConditionSpawnMonster>(builder.EndTable());
		}

		// Token: 0x06022AE0 RID: 142048 RVA: 0x004C6D78 File Offset: 0x004C4F78
		public IConditionSpawnMonsterT UnPack()
		{
			IConditionSpawnMonsterT conditionSpawnMonsterT = new IConditionSpawnMonsterT();
			this.UnPackTo(conditionSpawnMonsterT);
			return conditionSpawnMonsterT;
		}

		// Token: 0x06022AE1 RID: 142049 RVA: 0x004C6D94 File Offset: 0x004C4F94
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

		// Token: 0x06022AE2 RID: 142050 RVA: 0x004C6E6C File Offset: 0x004C506C
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

		// Token: 0x0400EBAA RID: 60330
		private Table __p;
	}
}
