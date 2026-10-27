using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004079 RID: 16505
	public struct IRecallConditionByEntityType : IFlatbufferObject
	{
		// Token: 0x17007474 RID: 29812
		// (get) Token: 0x06017FE1 RID: 98273 RVA: 0x0037646E File Offset: 0x0037466E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017FE2 RID: 98274 RVA: 0x0037647B File Offset: 0x0037467B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017FE3 RID: 98275 RVA: 0x00376484 File Offset: 0x00374684
		public static IRecallConditionByEntityType GetRootAsIRecallConditionByEntityType(ByteBuffer _bb)
		{
			return IRecallConditionByEntityType.GetRootAsIRecallConditionByEntityType(_bb, default(IRecallConditionByEntityType));
		}

		// Token: 0x06017FE4 RID: 98276 RVA: 0x003764A0 File Offset: 0x003746A0
		public static IRecallConditionByEntityType GetRootAsIRecallConditionByEntityType(ByteBuffer _bb, IRecallConditionByEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017FE5 RID: 98277 RVA: 0x003764BD File Offset: 0x003746BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017FE6 RID: 98278 RVA: 0x003764CC File Offset: 0x003746CC
		public IRecallConditionByEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007475 RID: 29813
		// (get) Token: 0x06017FE7 RID: 98279 RVA: 0x003764DC File Offset: 0x003746DC
		public ERecallConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERecallConditionType.ByEntityType;
				}
				return (ERecallConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007476 RID: 29814
		// (get) Token: 0x06017FE8 RID: 98280 RVA: 0x00376518 File Offset: 0x00374718
		public ERecallOperation Operation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ERecallOperation.Include;
				}
				return (ERecallOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017FE9 RID: 98281 RVA: 0x00376554 File Offset: 0x00374754
		public string EntityTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007477 RID: 29815
		// (get) Token: 0x06017FEA RID: 98282 RVA: 0x00376590 File Offset: 0x00374790
		public int EntityTypesLength
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

		// Token: 0x06017FEB RID: 98283 RVA: 0x003765BC File Offset: 0x003747BC
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007478 RID: 29816
		// (get) Token: 0x06017FEC RID: 98284 RVA: 0x003765FC File Offset: 0x003747FC
		public int AreaIdsLength
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

		// Token: 0x06017FED RID: 98285 RVA: 0x00376628 File Offset: 0x00374828
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06017FEE RID: 98286 RVA: 0x00376638 File Offset: 0x00374838
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06017FEF RID: 98287 RVA: 0x00376647 File Offset: 0x00374847
		public static Offset<IRecallConditionByEntityType> CreateIRecallConditionByEntityType(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset EntityTypesOffset = default(VectorOffset), VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallConditionByEntityType.AddAreaIds(builder, AreaIdsOffset);
			IRecallConditionByEntityType.AddEntityTypes(builder, EntityTypesOffset);
			IRecallConditionByEntityType.AddOperation(builder, Operation);
			IRecallConditionByEntityType.AddType(builder, Type);
			return IRecallConditionByEntityType.EndIRecallConditionByEntityType(builder);
		}

		// Token: 0x06017FF0 RID: 98288 RVA: 0x00376673 File Offset: 0x00374873
		public static void StartIRecallConditionByEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017FF1 RID: 98289 RVA: 0x0037667C File Offset: 0x0037487C
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017FF2 RID: 98290 RVA: 0x00376687 File Offset: 0x00374887
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x06017FF3 RID: 98291 RVA: 0x00376692 File Offset: 0x00374892
		public static void AddEntityTypes(FlatBufferBuilder builder, VectorOffset entityTypesOffset)
		{
			builder.AddOffset(2, entityTypesOffset.Value, 0);
		}

		// Token: 0x06017FF4 RID: 98292 RVA: 0x003766A4 File Offset: 0x003748A4
		public static VectorOffset CreateEntityTypesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FF5 RID: 98293 RVA: 0x003766E4 File Offset: 0x003748E4
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FF6 RID: 98294 RVA: 0x003766FE File Offset: 0x003748FE
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FF7 RID: 98295 RVA: 0x0037671C File Offset: 0x0037491C
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x00376735 File Offset: 0x00374935
		public static void StartEntityTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017FF9 RID: 98297 RVA: 0x00376740 File Offset: 0x00374940
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(3, areaIdsOffset.Value, 0);
		}

		// Token: 0x06017FFA RID: 98298 RVA: 0x00376750 File Offset: 0x00374950
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FFB RID: 98299 RVA: 0x00376787 File Offset: 0x00374987
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FFC RID: 98300 RVA: 0x003767A1 File Offset: 0x003749A1
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FFD RID: 98301 RVA: 0x003767BF File Offset: 0x003749BF
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017FFE RID: 98302 RVA: 0x003767D8 File Offset: 0x003749D8
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017FFF RID: 98303 RVA: 0x003767E3 File Offset: 0x003749E3
		public static Offset<IRecallConditionByEntityType> EndIRecallConditionByEntityType(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByEntityType>(builder.EndTable());
		}

		// Token: 0x06018000 RID: 98304 RVA: 0x003767F0 File Offset: 0x003749F0
		public IRecallConditionByEntityTypeT UnPack()
		{
			IRecallConditionByEntityTypeT recallConditionByEntityTypeT = new IRecallConditionByEntityTypeT();
			this.UnPackTo(recallConditionByEntityTypeT);
			return recallConditionByEntityTypeT;
		}

		// Token: 0x06018001 RID: 98305 RVA: 0x0037680C File Offset: 0x00374A0C
		public void UnPackTo(IRecallConditionByEntityTypeT _o)
		{
			_o.Type = this.Type;
			_o.Operation = this.Operation;
			_o.EntityTypes = new List<string>();
			for (int i = 0; i < this.EntityTypesLength; i++)
			{
				_o.EntityTypes.Add(this.EntityTypes(i));
			}
			_o.AreaIds = new List<int>();
			for (int j = 0; j < this.AreaIdsLength; j++)
			{
				_o.AreaIds.Add(this.AreaIds(j));
			}
		}

		// Token: 0x06018002 RID: 98306 RVA: 0x00376890 File Offset: 0x00374A90
		public static Offset<IRecallConditionByEntityType> Pack(FlatBufferBuilder builder, IRecallConditionByEntityTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConditionByEntityType>);
			}
			VectorOffset entityTypesOffset = default(VectorOffset);
			if (_o.EntityTypes != null)
			{
				StringOffset[] array = new StringOffset[_o.EntityTypes.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.EntityTypes[i]);
				}
				entityTypesOffset = IRecallConditionByEntityType.CreateEntityTypesVector(builder, array);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = IRecallConditionByEntityType.CreateAreaIdsVector(builder, data);
			}
			return IRecallConditionByEntityType.CreateIRecallConditionByEntityType(builder, _o.Type, _o.Operation, entityTypesOffset, areaIdsOffset);
		}

		// Token: 0x0400BBFA RID: 48122
		private Table __p;
	}
}
