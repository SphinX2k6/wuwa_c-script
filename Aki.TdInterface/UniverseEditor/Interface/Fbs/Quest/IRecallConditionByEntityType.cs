using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044BA RID: 17594
	public struct IRecallConditionByEntityType : IFlatbufferObject
	{
		// Token: 0x17007A76 RID: 31350
		// (get) Token: 0x0601967A RID: 104058 RVA: 0x003A02A6 File Offset: 0x0039E4A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601967B RID: 104059 RVA: 0x003A02B3 File Offset: 0x0039E4B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601967C RID: 104060 RVA: 0x003A02BC File Offset: 0x0039E4BC
		public static IRecallConditionByEntityType GetRootAsIRecallConditionByEntityType(ByteBuffer _bb)
		{
			return IRecallConditionByEntityType.GetRootAsIRecallConditionByEntityType(_bb, default(IRecallConditionByEntityType));
		}

		// Token: 0x0601967D RID: 104061 RVA: 0x003A02D8 File Offset: 0x0039E4D8
		public static IRecallConditionByEntityType GetRootAsIRecallConditionByEntityType(ByteBuffer _bb, IRecallConditionByEntityType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601967E RID: 104062 RVA: 0x003A02F5 File Offset: 0x0039E4F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601967F RID: 104063 RVA: 0x003A0304 File Offset: 0x0039E504
		public IRecallConditionByEntityType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A77 RID: 31351
		// (get) Token: 0x06019680 RID: 104064 RVA: 0x003A0314 File Offset: 0x0039E514
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

		// Token: 0x17007A78 RID: 31352
		// (get) Token: 0x06019681 RID: 104065 RVA: 0x003A0350 File Offset: 0x0039E550
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

		// Token: 0x06019682 RID: 104066 RVA: 0x003A038C File Offset: 0x0039E58C
		public string EntityTypes(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A79 RID: 31353
		// (get) Token: 0x06019683 RID: 104067 RVA: 0x003A03C8 File Offset: 0x0039E5C8
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

		// Token: 0x06019684 RID: 104068 RVA: 0x003A03F4 File Offset: 0x0039E5F4
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007A7A RID: 31354
		// (get) Token: 0x06019685 RID: 104069 RVA: 0x003A0434 File Offset: 0x0039E634
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

		// Token: 0x06019686 RID: 104070 RVA: 0x003A0460 File Offset: 0x0039E660
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06019687 RID: 104071 RVA: 0x003A0470 File Offset: 0x0039E670
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06019688 RID: 104072 RVA: 0x003A047F File Offset: 0x0039E67F
		public static Offset<IRecallConditionByEntityType> CreateIRecallConditionByEntityType(FlatBufferBuilder builder, ERecallConditionType Type = ERecallConditionType.ByEntityType, ERecallOperation Operation = ERecallOperation.Include, VectorOffset EntityTypesOffset = default(VectorOffset), VectorOffset AreaIdsOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IRecallConditionByEntityType.AddAreaIds(builder, AreaIdsOffset);
			IRecallConditionByEntityType.AddEntityTypes(builder, EntityTypesOffset);
			IRecallConditionByEntityType.AddOperation(builder, Operation);
			IRecallConditionByEntityType.AddType(builder, Type);
			return IRecallConditionByEntityType.EndIRecallConditionByEntityType(builder);
		}

		// Token: 0x06019689 RID: 104073 RVA: 0x003A04AB File Offset: 0x0039E6AB
		public static void StartIRecallConditionByEntityType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601968A RID: 104074 RVA: 0x003A04B4 File Offset: 0x0039E6B4
		public static void AddType(FlatBufferBuilder builder, ERecallConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601968B RID: 104075 RVA: 0x003A04BF File Offset: 0x0039E6BF
		public static void AddOperation(FlatBufferBuilder builder, ERecallOperation operation)
		{
			builder.AddByte(1, (byte)operation, 0);
		}

		// Token: 0x0601968C RID: 104076 RVA: 0x003A04CA File Offset: 0x0039E6CA
		public static void AddEntityTypes(FlatBufferBuilder builder, VectorOffset entityTypesOffset)
		{
			builder.AddOffset(2, entityTypesOffset.Value, 0);
		}

		// Token: 0x0601968D RID: 104077 RVA: 0x003A04DC File Offset: 0x0039E6DC
		public static VectorOffset CreateEntityTypesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601968E RID: 104078 RVA: 0x003A051C File Offset: 0x0039E71C
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601968F RID: 104079 RVA: 0x003A0536 File Offset: 0x0039E736
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06019690 RID: 104080 RVA: 0x003A0554 File Offset: 0x0039E754
		public static VectorOffset CreateEntityTypesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019691 RID: 104081 RVA: 0x003A056D File Offset: 0x0039E76D
		public static void StartEntityTypesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019692 RID: 104082 RVA: 0x003A0578 File Offset: 0x0039E778
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(3, areaIdsOffset.Value, 0);
		}

		// Token: 0x06019693 RID: 104083 RVA: 0x003A0588 File Offset: 0x0039E788
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019694 RID: 104084 RVA: 0x003A05BF File Offset: 0x0039E7BF
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019695 RID: 104085 RVA: 0x003A05D9 File Offset: 0x0039E7D9
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019696 RID: 104086 RVA: 0x003A05F7 File Offset: 0x0039E7F7
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019697 RID: 104087 RVA: 0x003A0610 File Offset: 0x0039E810
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019698 RID: 104088 RVA: 0x003A061B File Offset: 0x0039E81B
		public static Offset<IRecallConditionByEntityType> EndIRecallConditionByEntityType(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConditionByEntityType>(builder.EndTable());
		}

		// Token: 0x06019699 RID: 104089 RVA: 0x003A0628 File Offset: 0x0039E828
		public IRecallConditionByEntityTypeT UnPack()
		{
			IRecallConditionByEntityTypeT recallConditionByEntityTypeT = new IRecallConditionByEntityTypeT();
			this.UnPackTo(recallConditionByEntityTypeT);
			return recallConditionByEntityTypeT;
		}

		// Token: 0x0601969A RID: 104090 RVA: 0x003A0644 File Offset: 0x0039E844
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

		// Token: 0x0601969B RID: 104091 RVA: 0x003A06C8 File Offset: 0x0039E8C8
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

		// Token: 0x0400C5E1 RID: 50657
		private Table __p;
	}
}
