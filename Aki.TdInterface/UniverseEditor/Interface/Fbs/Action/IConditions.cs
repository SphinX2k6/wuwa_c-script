using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064BF RID: 25791
	public struct IConditions : IFlatbufferObject
	{
		// Token: 0x1700BFEA RID: 49130
		// (get) Token: 0x0602CBB0 RID: 183216 RVA: 0x0062611F File Offset: 0x0062431F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CBB1 RID: 183217 RVA: 0x0062612C File Offset: 0x0062432C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CBB2 RID: 183218 RVA: 0x00626134 File Offset: 0x00624334
		public static IConditions GetRootAsIConditions(ByteBuffer _bb)
		{
			return IConditions.GetRootAsIConditions(_bb, default(IConditions));
		}

		// Token: 0x0602CBB3 RID: 183219 RVA: 0x00626150 File Offset: 0x00624350
		public static IConditions GetRootAsIConditions(ByteBuffer _bb, IConditions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CBB4 RID: 183220 RVA: 0x0062616D File Offset: 0x0062436D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CBB5 RID: 183221 RVA: 0x0062617C File Offset: 0x0062437C
		public IConditions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFEB RID: 49131
		// (get) Token: 0x0602CBB6 RID: 183222 RVA: 0x0062618C File Offset: 0x0062438C
		public string LogicOpType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CBB7 RID: 183223 RVA: 0x006261C3 File Offset: 0x006243C3
		public Span<byte> GetLogicOpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602CBB8 RID: 183224 RVA: 0x006261D2 File Offset: 0x006243D2
		public byte[] GetLogicOpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602CBB9 RID: 183225 RVA: 0x006261E0 File Offset: 0x006243E0
		public ICondition? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICondition?(default(ICondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BFEC RID: 49132
		// (get) Token: 0x0602CBBA RID: 183226 RVA: 0x00626240 File Offset: 0x00624440
		public int ConditionsLength
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

		// Token: 0x0602CBBB RID: 183227 RVA: 0x0062626B File Offset: 0x0062446B
		public static Offset<IConditions> CreateIConditions(FlatBufferBuilder builder, StringOffset LogicOpTypeOffset = default(StringOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditions.AddConditions(builder, ConditionsOffset);
			IConditions.AddLogicOpType(builder, LogicOpTypeOffset);
			return IConditions.EndIConditions(builder);
		}

		// Token: 0x0602CBBC RID: 183228 RVA: 0x00626288 File Offset: 0x00624488
		public static void StartIConditions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CBBD RID: 183229 RVA: 0x00626291 File Offset: 0x00624491
		public static void AddLogicOpType(FlatBufferBuilder builder, StringOffset logicOpTypeOffset)
		{
			builder.AddOffset(0, logicOpTypeOffset.Value, 0);
		}

		// Token: 0x0602CBBE RID: 183230 RVA: 0x006262A1 File Offset: 0x006244A1
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602CBBF RID: 183231 RVA: 0x006262B4 File Offset: 0x006244B4
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CBC0 RID: 183232 RVA: 0x006262F4 File Offset: 0x006244F4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBC1 RID: 183233 RVA: 0x0062630E File Offset: 0x0062450E
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CBC2 RID: 183234 RVA: 0x0062632C File Offset: 0x0062452C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CBC3 RID: 183235 RVA: 0x00626345 File Offset: 0x00624545
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CBC4 RID: 183236 RVA: 0x00626350 File Offset: 0x00624550
		public static Offset<IConditions> EndIConditions(FlatBufferBuilder builder)
		{
			return new Offset<IConditions>(builder.EndTable());
		}

		// Token: 0x0602CBC5 RID: 183237 RVA: 0x00626360 File Offset: 0x00624560
		public IConditionsT UnPack()
		{
			IConditionsT conditionsT = new IConditionsT();
			this.UnPackTo(conditionsT);
			return conditionsT;
		}

		// Token: 0x0602CBC6 RID: 183238 RVA: 0x0062637C File Offset: 0x0062457C
		public void UnPackTo(IConditionsT _o)
		{
			_o.LogicOpType = this.LogicOpType;
			_o.Conditions = new List<IConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602CBC7 RID: 183239 RVA: 0x006263E8 File Offset: 0x006245E8
		public static Offset<IConditions> Pack(FlatBufferBuilder builder, IConditionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditions>);
			}
			StringOffset logicOpTypeOffset = (_o.LogicOpType == null) ? default(StringOffset) : builder.CreateString(_o.LogicOpType);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICondition>[] array = new Offset<ICondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IConditions.CreateConditionsVector(builder, array);
			}
			return IConditions.CreateIConditions(builder, logicOpTypeOffset, conditionsOffset);
		}

		// Token: 0x04010AF2 RID: 68338
		private Table __p;
	}
}
