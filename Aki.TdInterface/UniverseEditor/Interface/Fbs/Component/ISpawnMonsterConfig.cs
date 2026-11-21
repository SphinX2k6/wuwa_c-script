using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F5D RID: 24413
	public struct ISpawnMonsterConfig : IFlatbufferObject
	{
		// Token: 0x1700B4CE RID: 46286
		// (get) Token: 0x0602907E RID: 168062 RVA: 0x0059AD37 File Offset: 0x00598F37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602907F RID: 168063 RVA: 0x0059AD44 File Offset: 0x00598F44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029080 RID: 168064 RVA: 0x0059AD4C File Offset: 0x00598F4C
		public static ISpawnMonsterConfig GetRootAsISpawnMonsterConfig(ByteBuffer _bb)
		{
			return ISpawnMonsterConfig.GetRootAsISpawnMonsterConfig(_bb, default(ISpawnMonsterConfig));
		}

		// Token: 0x06029081 RID: 168065 RVA: 0x0059AD68 File Offset: 0x00598F68
		public static ISpawnMonsterConfig GetRootAsISpawnMonsterConfig(ByteBuffer _bb, ISpawnMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029082 RID: 168066 RVA: 0x0059AD85 File Offset: 0x00598F85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029083 RID: 168067 RVA: 0x0059AD94 File Offset: 0x00598F94
		public ISpawnMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B4CF RID: 46287
		// (get) Token: 0x06029084 RID: 168068 RVA: 0x0059ADA4 File Offset: 0x00598FA4
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

		// Token: 0x1700B4D0 RID: 46288
		// (get) Token: 0x06029085 RID: 168069 RVA: 0x0059ADE0 File Offset: 0x00598FE0
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029086 RID: 168070 RVA: 0x0059AE20 File Offset: 0x00599020
		public int TargetsToAwake(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B4D1 RID: 46289
		// (get) Token: 0x06029087 RID: 168071 RVA: 0x0059AE60 File Offset: 0x00599060
		public int TargetsToAwakeLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029088 RID: 168072 RVA: 0x0059AE8B File Offset: 0x0059908B
		public Span<int> GetTargetsToAwakeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06029089 RID: 168073 RVA: 0x0059AE9A File Offset: 0x0059909A
		public int[] GetTargetsToAwakeArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700B4D2 RID: 46290
		// (get) Token: 0x0602908A RID: 168074 RVA: 0x0059AEA8 File Offset: 0x005990A8
		public TSpawnMonsterCompleteCondition CompleteConditionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TSpawnMonsterCompleteCondition.NONE;
				}
				return (TSpawnMonsterCompleteCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602908B RID: 168075 RVA: 0x0059AEE8 File Offset: 0x005990E8
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602908C RID: 168076 RVA: 0x0059AF30 File Offset: 0x00599130
		public IAllKillCondition CompleteConditionAsIAllKillCondition()
		{
			return this.CompleteCondition<IAllKillCondition>().Value;
		}

		// Token: 0x0602908D RID: 168077 RVA: 0x0059AF4C File Offset: 0x0059914C
		public IDurationCondition CompleteConditionAsIDurationCondition()
		{
			return this.CompleteCondition<IDurationCondition>().Value;
		}

		// Token: 0x0602908E RID: 168078 RVA: 0x0059AF68 File Offset: 0x00599168
		public IQuantityRefillCondition CompleteConditionAsIQuantityRefillCondition()
		{
			return this.CompleteCondition<IQuantityRefillCondition>().Value;
		}

		// Token: 0x1700B4D3 RID: 46291
		// (get) Token: 0x0602908F RID: 168079 RVA: 0x0059AF84 File Offset: 0x00599184
		public ISpawnMonsterPreDependOnPreceding? PreCondition
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ISpawnMonsterPreDependOnPreceding?(default(ISpawnMonsterPreDependOnPreceding).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B4D4 RID: 46292
		// (get) Token: 0x06029090 RID: 168080 RVA: 0x0059AFE4 File Offset: 0x005991E4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029091 RID: 168081 RVA: 0x0059B024 File Offset: 0x00599224
		public static Offset<ISpawnMonsterConfig> CreateISpawnMonsterConfig(FlatBufferBuilder builder, int Id = 0, float DelayTime = 0f, VectorOffset TargetsToAwakeOffset = default(VectorOffset), TSpawnMonsterCompleteCondition CompleteCondition_type = TSpawnMonsterCompleteCondition.NONE, int CompleteConditionOffset = 0, Offset<ISpawnMonsterPreDependOnPreceding> PreConditionOffset = default(Offset<ISpawnMonsterPreDependOnPreceding>), byte NullMask = 0)
		{
			builder.StartTable(7);
			ISpawnMonsterConfig.AddPreCondition(builder, PreConditionOffset);
			ISpawnMonsterConfig.AddCompleteCondition(builder, CompleteConditionOffset);
			ISpawnMonsterConfig.AddTargetsToAwake(builder, TargetsToAwakeOffset);
			ISpawnMonsterConfig.AddDelayTime(builder, DelayTime);
			ISpawnMonsterConfig.AddId(builder, Id);
			ISpawnMonsterConfig.AddNullMask(builder, NullMask);
			ISpawnMonsterConfig.AddCompleteConditionType(builder, CompleteCondition_type);
			return ISpawnMonsterConfig.EndISpawnMonsterConfig(builder);
		}

		// Token: 0x06029092 RID: 168082 RVA: 0x0059B073 File Offset: 0x00599273
		public static void StartISpawnMonsterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06029093 RID: 168083 RVA: 0x0059B07C File Offset: 0x0059927C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06029094 RID: 168084 RVA: 0x0059B087 File Offset: 0x00599287
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x06029095 RID: 168085 RVA: 0x0059B09A File Offset: 0x0059929A
		public static void AddTargetsToAwake(FlatBufferBuilder builder, VectorOffset targetsToAwakeOffset)
		{
			builder.AddOffset(2, targetsToAwakeOffset.Value, 0);
		}

		// Token: 0x06029096 RID: 168086 RVA: 0x0059B0AC File Offset: 0x005992AC
		public static VectorOffset CreateTargetsToAwakeVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029097 RID: 168087 RVA: 0x0059B0E3 File Offset: 0x005992E3
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029098 RID: 168088 RVA: 0x0059B0FD File Offset: 0x005992FD
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029099 RID: 168089 RVA: 0x0059B11B File Offset: 0x0059931B
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602909A RID: 168090 RVA: 0x0059B134 File Offset: 0x00599334
		public static void StartTargetsToAwakeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602909B RID: 168091 RVA: 0x0059B13F File Offset: 0x0059933F
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TSpawnMonsterCompleteCondition completeConditionType)
		{
			builder.AddByte(3, (byte)completeConditionType, 0);
		}

		// Token: 0x0602909C RID: 168092 RVA: 0x0059B14A File Offset: 0x0059934A
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(4, completeConditionOffset, 0);
		}

		// Token: 0x0602909D RID: 168093 RVA: 0x0059B155 File Offset: 0x00599355
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset)
		{
			builder.AddOffset(5, preConditionOffset.Value, 0);
		}

		// Token: 0x0602909E RID: 168094 RVA: 0x0059B165 File Offset: 0x00599365
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602909F RID: 168095 RVA: 0x0059B170 File Offset: 0x00599370
		public static Offset<ISpawnMonsterConfig> EndISpawnMonsterConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterConfig>(builder.EndTable());
		}

		// Token: 0x060290A0 RID: 168096 RVA: 0x0059B180 File Offset: 0x00599380
		public ISpawnMonsterConfigT UnPack()
		{
			ISpawnMonsterConfigT spawnMonsterConfigT = new ISpawnMonsterConfigT();
			this.UnPackTo(spawnMonsterConfigT);
			return spawnMonsterConfigT;
		}

		// Token: 0x060290A1 RID: 168097 RVA: 0x0059B19C File Offset: 0x0059939C
		public void UnPackTo(ISpawnMonsterConfigT _o)
		{
			_o.Id = this.Id;
			_o.DelayTime = this.DelayTime;
			_o.TargetsToAwake = new List<int>();
			for (int i = 0; i < this.TargetsToAwakeLength; i++)
			{
				_o.TargetsToAwake.Add(this.TargetsToAwake(i));
			}
			_o.CompleteCondition = new TSpawnMonsterCompleteConditionUnion();
			_o.CompleteCondition.Type = this.CompleteConditionType;
			switch (this.CompleteConditionType)
			{
			case TSpawnMonsterCompleteCondition.IAllKillCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IAllKillCondition>() != null) ? this.CompleteCondition<IAllKillCondition>().Value.UnPack() : null);
				break;
			case TSpawnMonsterCompleteCondition.IDurationCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IDurationCondition>() != null) ? this.CompleteCondition<IDurationCondition>().Value.UnPack() : null);
				break;
			case TSpawnMonsterCompleteCondition.IQuantityRefillCondition:
				_o.CompleteCondition.Value = ((this.CompleteCondition<IQuantityRefillCondition>() != null) ? this.CompleteCondition<IQuantityRefillCondition>().Value.UnPack() : null);
				break;
			}
			_o.PreCondition = ((this.PreCondition != null) ? this.PreCondition.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060290A2 RID: 168098 RVA: 0x0059B310 File Offset: 0x00599510
		public static Offset<ISpawnMonsterConfig> Pack(FlatBufferBuilder builder, ISpawnMonsterConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpawnMonsterConfig>);
			}
			VectorOffset targetsToAwakeOffset = default(VectorOffset);
			if (_o.TargetsToAwake != null)
			{
				int[] data = _o.TargetsToAwake.ToArray();
				targetsToAwakeOffset = ISpawnMonsterConfig.CreateTargetsToAwakeVector(builder, data);
			}
			TSpawnMonsterCompleteCondition completeCondition_type = (_o.CompleteCondition == null) ? TSpawnMonsterCompleteCondition.NONE : _o.CompleteCondition.Type;
			int completeConditionOffset = (_o.CompleteCondition == null) ? 0 : TSpawnMonsterCompleteConditionUnion.Pack(builder, _o.CompleteCondition);
			Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset = (_o.PreCondition == null) ? default(Offset<ISpawnMonsterPreDependOnPreceding>) : ISpawnMonsterPreDependOnPreceding.Pack(builder, _o.PreCondition);
			return ISpawnMonsterConfig.CreateISpawnMonsterConfig(builder, _o.Id, _o.DelayTime, targetsToAwakeOffset, completeCondition_type, completeConditionOffset, preConditionOffset, _o.NullMask);
		}

		// Token: 0x0400FC21 RID: 64545
		private Table __p;
	}
}
