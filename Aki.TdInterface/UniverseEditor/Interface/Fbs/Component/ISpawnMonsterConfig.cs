using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005950 RID: 22864
	public struct ISpawnMonsterConfig : IFlatbufferObject
	{
		// Token: 0x1700AB9A RID: 43930
		// (get) Token: 0x06026B14 RID: 158484 RVA: 0x005540CB File Offset: 0x005522CB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026B15 RID: 158485 RVA: 0x005540D8 File Offset: 0x005522D8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026B16 RID: 158486 RVA: 0x005540E0 File Offset: 0x005522E0
		public static ISpawnMonsterConfig GetRootAsISpawnMonsterConfig(ByteBuffer _bb)
		{
			return ISpawnMonsterConfig.GetRootAsISpawnMonsterConfig(_bb, default(ISpawnMonsterConfig));
		}

		// Token: 0x06026B17 RID: 158487 RVA: 0x005540FC File Offset: 0x005522FC
		public static ISpawnMonsterConfig GetRootAsISpawnMonsterConfig(ByteBuffer _bb, ISpawnMonsterConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026B18 RID: 158488 RVA: 0x00554119 File Offset: 0x00552319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026B19 RID: 158489 RVA: 0x00554128 File Offset: 0x00552328
		public ISpawnMonsterConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AB9B RID: 43931
		// (get) Token: 0x06026B1A RID: 158490 RVA: 0x00554138 File Offset: 0x00552338
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

		// Token: 0x1700AB9C RID: 43932
		// (get) Token: 0x06026B1B RID: 158491 RVA: 0x00554174 File Offset: 0x00552374
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

		// Token: 0x06026B1C RID: 158492 RVA: 0x005541B4 File Offset: 0x005523B4
		public int TargetsToAwake(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AB9D RID: 43933
		// (get) Token: 0x06026B1D RID: 158493 RVA: 0x005541F4 File Offset: 0x005523F4
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

		// Token: 0x06026B1E RID: 158494 RVA: 0x0055421F File Offset: 0x0055241F
		public Span<int> GetTargetsToAwakeBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06026B1F RID: 158495 RVA: 0x0055422E File Offset: 0x0055242E
		public int[] GetTargetsToAwakeArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700AB9E RID: 43934
		// (get) Token: 0x06026B20 RID: 158496 RVA: 0x0055423C File Offset: 0x0055243C
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

		// Token: 0x06026B21 RID: 158497 RVA: 0x0055427C File Offset: 0x0055247C
		public TTable? CompleteCondition<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026B22 RID: 158498 RVA: 0x005542C4 File Offset: 0x005524C4
		public IAllKillCondition CompleteConditionAsIAllKillCondition()
		{
			return this.CompleteCondition<IAllKillCondition>().Value;
		}

		// Token: 0x06026B23 RID: 158499 RVA: 0x005542E0 File Offset: 0x005524E0
		public IDurationCondition CompleteConditionAsIDurationCondition()
		{
			return this.CompleteCondition<IDurationCondition>().Value;
		}

		// Token: 0x06026B24 RID: 158500 RVA: 0x005542FC File Offset: 0x005524FC
		public IQuantityRefillCondition CompleteConditionAsIQuantityRefillCondition()
		{
			return this.CompleteCondition<IQuantityRefillCondition>().Value;
		}

		// Token: 0x1700AB9F RID: 43935
		// (get) Token: 0x06026B25 RID: 158501 RVA: 0x00554318 File Offset: 0x00552518
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

		// Token: 0x1700ABA0 RID: 43936
		// (get) Token: 0x06026B26 RID: 158502 RVA: 0x00554378 File Offset: 0x00552578
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

		// Token: 0x06026B27 RID: 158503 RVA: 0x005543B8 File Offset: 0x005525B8
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

		// Token: 0x06026B28 RID: 158504 RVA: 0x00554407 File Offset: 0x00552607
		public static void StartISpawnMonsterConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026B29 RID: 158505 RVA: 0x00554410 File Offset: 0x00552610
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06026B2A RID: 158506 RVA: 0x0055441B File Offset: 0x0055261B
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(1, delayTime, 0.0);
		}

		// Token: 0x06026B2B RID: 158507 RVA: 0x0055442E File Offset: 0x0055262E
		public static void AddTargetsToAwake(FlatBufferBuilder builder, VectorOffset targetsToAwakeOffset)
		{
			builder.AddOffset(2, targetsToAwakeOffset.Value, 0);
		}

		// Token: 0x06026B2C RID: 158508 RVA: 0x00554440 File Offset: 0x00552640
		public static VectorOffset CreateTargetsToAwakeVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026B2D RID: 158509 RVA: 0x00554477 File Offset: 0x00552677
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026B2E RID: 158510 RVA: 0x00554491 File Offset: 0x00552691
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026B2F RID: 158511 RVA: 0x005544AF File Offset: 0x005526AF
		public static VectorOffset CreateTargetsToAwakeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026B30 RID: 158512 RVA: 0x005544C8 File Offset: 0x005526C8
		public static void StartTargetsToAwakeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026B31 RID: 158513 RVA: 0x005544D3 File Offset: 0x005526D3
		public static void AddCompleteConditionType(FlatBufferBuilder builder, TSpawnMonsterCompleteCondition completeConditionType)
		{
			builder.AddByte(3, (byte)completeConditionType, 0);
		}

		// Token: 0x06026B32 RID: 158514 RVA: 0x005544DE File Offset: 0x005526DE
		public static void AddCompleteCondition(FlatBufferBuilder builder, int completeConditionOffset)
		{
			builder.AddOffset(4, completeConditionOffset, 0);
		}

		// Token: 0x06026B33 RID: 158515 RVA: 0x005544E9 File Offset: 0x005526E9
		public static void AddPreCondition(FlatBufferBuilder builder, Offset<ISpawnMonsterPreDependOnPreceding> preConditionOffset)
		{
			builder.AddOffset(5, preConditionOffset.Value, 0);
		}

		// Token: 0x06026B34 RID: 158516 RVA: 0x005544F9 File Offset: 0x005526F9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026B35 RID: 158517 RVA: 0x00554504 File Offset: 0x00552704
		public static Offset<ISpawnMonsterConfig> EndISpawnMonsterConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISpawnMonsterConfig>(builder.EndTable());
		}

		// Token: 0x06026B36 RID: 158518 RVA: 0x00554514 File Offset: 0x00552714
		public ISpawnMonsterConfigT UnPack()
		{
			ISpawnMonsterConfigT spawnMonsterConfigT = new ISpawnMonsterConfigT();
			this.UnPackTo(spawnMonsterConfigT);
			return spawnMonsterConfigT;
		}

		// Token: 0x06026B37 RID: 158519 RVA: 0x00554530 File Offset: 0x00552730
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

		// Token: 0x06026B38 RID: 158520 RVA: 0x005546A4 File Offset: 0x005528A4
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

		// Token: 0x0400EF2C RID: 61228
		private Table __p;
	}
}
