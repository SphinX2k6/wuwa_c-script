using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF5 RID: 15605
	public struct IAddTimeConfig : IFlatbufferObject
	{
		// Token: 0x17006AFB RID: 27387
		// (get) Token: 0x060157ED RID: 88045 RVA: 0x0031AE8B File Offset: 0x0031908B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157EE RID: 88046 RVA: 0x0031AE98 File Offset: 0x00319098
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157EF RID: 88047 RVA: 0x0031AEA0 File Offset: 0x003190A0
		public static IAddTimeConfig GetRootAsIAddTimeConfig(ByteBuffer _bb)
		{
			return IAddTimeConfig.GetRootAsIAddTimeConfig(_bb, default(IAddTimeConfig));
		}

		// Token: 0x060157F0 RID: 88048 RVA: 0x0031AEBC File Offset: 0x003190BC
		public static IAddTimeConfig GetRootAsIAddTimeConfig(ByteBuffer _bb, IAddTimeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157F1 RID: 88049 RVA: 0x0031AED9 File Offset: 0x003190D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157F2 RID: 88050 RVA: 0x0031AEE8 File Offset: 0x003190E8
		public IAddTimeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AFC RID: 27388
		// (get) Token: 0x060157F3 RID: 88051 RVA: 0x0031AEF8 File Offset: 0x003190F8
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

		// Token: 0x060157F4 RID: 88052 RVA: 0x0031AF58 File Offset: 0x00319158
		public IAddTimeStateCondition? StateConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IAddTimeStateCondition?(default(IAddTimeStateCondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006AFD RID: 27389
		// (get) Token: 0x060157F5 RID: 88053 RVA: 0x0031AFB8 File Offset: 0x003191B8
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

		// Token: 0x17006AFE RID: 27390
		// (get) Token: 0x060157F6 RID: 88054 RVA: 0x0031AFE4 File Offset: 0x003191E4
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

		// Token: 0x060157F7 RID: 88055 RVA: 0x0031B020 File Offset: 0x00319220
		public static Offset<IAddTimeConfig> CreateIAddTimeConfig(FlatBufferBuilder builder, Offset<IKillMonster> MonsterConfigOffset = default(Offset<IKillMonster>), VectorOffset StateConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IAddTimeConfig.AddStateConfig(builder, StateConfigOffset);
			IAddTimeConfig.AddMonsterConfig(builder, MonsterConfigOffset);
			IAddTimeConfig.AddNullMask(builder, NullMask);
			return IAddTimeConfig.EndIAddTimeConfig(builder);
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x0031B044 File Offset: 0x00319244
		public static void StartIAddTimeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060157F9 RID: 88057 RVA: 0x0031B04D File Offset: 0x0031924D
		public static void AddMonsterConfig(FlatBufferBuilder builder, Offset<IKillMonster> monsterConfigOffset)
		{
			builder.AddOffset(0, monsterConfigOffset.Value, 0);
		}

		// Token: 0x060157FA RID: 88058 RVA: 0x0031B05D File Offset: 0x0031925D
		public static void AddStateConfig(FlatBufferBuilder builder, VectorOffset stateConfigOffset)
		{
			builder.AddOffset(1, stateConfigOffset.Value, 0);
		}

		// Token: 0x060157FB RID: 88059 RVA: 0x0031B070 File Offset: 0x00319270
		public static VectorOffset CreateStateConfigVector(FlatBufferBuilder builder, Offset<IAddTimeStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060157FC RID: 88060 RVA: 0x0031B0B0 File Offset: 0x003192B0
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, Offset<IAddTimeStateCondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAddTimeStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060157FD RID: 88061 RVA: 0x0031B0CA File Offset: 0x003192CA
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAddTimeStateCondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAddTimeStateCondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x060157FE RID: 88062 RVA: 0x0031B0E8 File Offset: 0x003192E8
		public static VectorOffset CreateStateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAddTimeStateCondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060157FF RID: 88063 RVA: 0x0031B101 File Offset: 0x00319301
		public static void StartStateConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06015800 RID: 88064 RVA: 0x0031B10C File Offset: 0x0031930C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06015801 RID: 88065 RVA: 0x0031B117 File Offset: 0x00319317
		public static Offset<IAddTimeConfig> EndIAddTimeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAddTimeConfig>(builder.EndTable());
		}

		// Token: 0x06015802 RID: 88066 RVA: 0x0031B124 File Offset: 0x00319324
		public IAddTimeConfigT UnPack()
		{
			IAddTimeConfigT addTimeConfigT = new IAddTimeConfigT();
			this.UnPackTo(addTimeConfigT);
			return addTimeConfigT;
		}

		// Token: 0x06015803 RID: 88067 RVA: 0x0031B140 File Offset: 0x00319340
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

		// Token: 0x06015804 RID: 88068 RVA: 0x0031B1DC File Offset: 0x003193DC
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

		// Token: 0x0400B599 RID: 46489
		private Table __p;
	}
}
