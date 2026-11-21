using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410C RID: 16652
	public struct IAddTimeConfig : IFlatbufferObject
	{
		// Token: 0x170070B5 RID: 28853
		// (get) Token: 0x06016D25 RID: 93477 RVA: 0x00342103 File Offset: 0x00340303
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x00342110 File Offset: 0x00340310
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D27 RID: 93479 RVA: 0x00342118 File Offset: 0x00340318
		public static IAddTimeConfig GetRootAsIAddTimeConfig(ByteBuffer _bb)
		{
			return IAddTimeConfig.GetRootAsIAddTimeConfig(_bb, default(IAddTimeConfig));
		}

		// Token: 0x06016D28 RID: 93480 RVA: 0x00342134 File Offset: 0x00340334
		public static IAddTimeConfig GetRootAsIAddTimeConfig(ByteBuffer _bb, IAddTimeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D29 RID: 93481 RVA: 0x00342151 File Offset: 0x00340351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D2A RID: 93482 RVA: 0x00342160 File Offset: 0x00340360
		public IAddTimeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070B6 RID: 28854
		// (get) Token: 0x06016D2B RID: 93483 RVA: 0x00342170 File Offset: 0x00340370
		public IKillMonster? MonsterConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IKillMonster?(default(IKillMonster).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06016D2C RID: 93484 RVA: 0x003421D0 File Offset: 0x003403D0
		public IAddTimeStateCondition? StateConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IAddTimeStateCondition?(default(IAddTimeStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170070B7 RID: 28855
		// (get) Token: 0x06016D2D RID: 93485 RVA: 0x00342230 File Offset: 0x00340430
		public int StateConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170070B8 RID: 28856
		// (get) Token: 0x06016D2E RID: 93486 RVA: 0x0034225C File Offset: 0x0034045C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D2F RID: 93487 RVA: 0x00342298 File Offset: 0x00340498
		public static Offset<IAddTimeConfig> CreateIAddTimeConfig(FlatBufferBuilder builder, Offset<IKillMonster> MonsterConfigOffset = default(Offset<IKillMonster>), VectorOffset StateConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddTimeConfig.AddStateConfig(builder, StateConfigOffset);
			IAddTimeConfig.AddMonsterConfig(builder, MonsterConfigOffset);
			IAddTimeConfig.AddNullMask(builder, NullMask);
			return IAddTimeConfig.EndIAddTimeConfig(builder);
		}

		// Token: 0x06016D30 RID: 93488 RVA: 0x003422BC File Offset: 0x003404BC
		public static void StartIAddTimeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016D31 RID: 93489 RVA: 0x003422C5 File Offset: 0x003404C5
		public static void AddMonsterConfig(FlatBufferBuilder builder, Offset<IKillMonster> monsterConfigOffset)
		{
			builder.AddOffset(0, monsterConfigOffset.Value, 0);
		}

		// Token: 0x06016D32 RID: 93490 RVA: 0x003422D5 File Offset: 0x003404D5
		public static void AddStateConfig(FlatBufferBuilder builder, VectorOffset stateConfigOffset)
		{
			builder.AddOffset(1, stateConfigOffset.Value, 0);
		}

		// Token: 0x06016D33 RID: 93491 RVA: 0x003422E8 File Offset: 0x003404E8
		public static VectorOffset CreateStateConfigVector(FlatBufferBuilder builder, Offset<IAddTimeStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016D34 RID: 93492 RVA: 0x00342328 File Offset: 0x00340528
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, Offset<IAddTimeStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAddTimeStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D35 RID: 93493 RVA: 0x00342342 File Offset: 0x00340542
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAddTimeStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAddTimeStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D36 RID: 93494 RVA: 0x00342360 File Offset: 0x00340560
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAddTimeStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x00342379 File Offset: 0x00340579
		public static void StartStateConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016D38 RID: 93496 RVA: 0x00342384 File Offset: 0x00340584
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x0034238F File Offset: 0x0034058F
		public static Offset<IAddTimeConfig> EndIAddTimeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAddTimeConfig>(builder.EndTable());
		}

		// Token: 0x06016D3A RID: 93498 RVA: 0x0034239C File Offset: 0x0034059C
		public IAddTimeConfigT UnPack()
		{
			IAddTimeConfigT addTimeConfigT = new IAddTimeConfigT();
			this.UnPackTo(addTimeConfigT);
			return addTimeConfigT;
		}

		// Token: 0x06016D3B RID: 93499 RVA: 0x003423B8 File Offset: 0x003405B8
		public void UnPackTo(IAddTimeConfigT _o)
		{
			_o.MonsterConfig = ((this.MonsterConfig != null) ? this.MonsterConfig.Value.UnPack() : null);
			_o.StateConfig = new List<IAddTimeStateConditionT>();
			for (int i = 0; i < this.StateConfigLength; i++)
			{
				_o.StateConfig.Add((this.StateConfig(i) != null) ? this.StateConfig(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016D3C RID: 93500 RVA: 0x00342454 File Offset: 0x00340654
		public static Offset<IAddTimeConfig> Pack(FlatBufferBuilder builder, IAddTimeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddTimeConfig>);
			}
			Offset<IKillMonster> monsterConfigOffset = (_o.MonsterConfig == null) ? default(Offset<IKillMonster>) : IKillMonster.Pack(builder, _o.MonsterConfig);
			VectorOffset stateConfigOffset = default(VectorOffset);
			if (_o.StateConfig != null)
			{
				Offset<IAddTimeStateCondition>[] array = new Offset<IAddTimeStateCondition>[_o.StateConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAddTimeStateCondition.Pack(builder, _o.StateConfig[i]);
				}
				stateConfigOffset = IAddTimeConfig.CreateStateConfigVector(builder, array);
			}
			return IAddTimeConfig.CreateIAddTimeConfig(builder, monsterConfigOffset, stateConfigOffset, _o.NullMask);
		}

		// Token: 0x0400BF46 RID: 48966
		private Table __p;
	}
}
