using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006787 RID: 26503
	public struct IAddBuffToTriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700C0B4 RID: 49332
		// (get) Token: 0x0602CEFC RID: 184060 RVA: 0x006248BF File Offset: 0x00622ABF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CEFD RID: 184061 RVA: 0x006248CC File Offset: 0x00622ACC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CEFE RID: 184062 RVA: 0x006248D4 File Offset: 0x00622AD4
		public static IAddBuffToTriggeredEntity GetRootAsIAddBuffToTriggeredEntity(ByteBuffer _bb)
		{
			return IAddBuffToTriggeredEntity.GetRootAsIAddBuffToTriggeredEntity(_bb, default(IAddBuffToTriggeredEntity));
		}

		// Token: 0x0602CEFF RID: 184063 RVA: 0x006248F0 File Offset: 0x00622AF0
		public static IAddBuffToTriggeredEntity GetRootAsIAddBuffToTriggeredEntity(ByteBuffer _bb, IAddBuffToTriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF00 RID: 184064 RVA: 0x0062490D File Offset: 0x00622B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF01 RID: 184065 RVA: 0x0062491C File Offset: 0x00622B1C
		public IAddBuffToTriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CF02 RID: 184066 RVA: 0x0062492C File Offset: 0x00622B2C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C0B5 RID: 49333
		// (get) Token: 0x0602CF03 RID: 184067 RVA: 0x0062496C File Offset: 0x00622B6C
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602CF04 RID: 184068 RVA: 0x00624997 File Offset: 0x00622B97
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x0602CF05 RID: 184069 RVA: 0x006249A6 File Offset: 0x00622BA6
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x0602CF06 RID: 184070 RVA: 0x006249B4 File Offset: 0x00622BB4
		public static Offset<IAddBuffToTriggeredEntity> CreateIAddBuffToTriggeredEntity(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IAddBuffToTriggeredEntity.AddBuffIds(builder, BuffIdsOffset);
			return IAddBuffToTriggeredEntity.EndIAddBuffToTriggeredEntity(builder);
		}

		// Token: 0x0602CF07 RID: 184071 RVA: 0x006249CA File Offset: 0x00622BCA
		public static void StartIAddBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CF08 RID: 184072 RVA: 0x006249D3 File Offset: 0x00622BD3
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602CF09 RID: 184073 RVA: 0x006249E4 File Offset: 0x00622BE4
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CF0A RID: 184074 RVA: 0x00624A1B File Offset: 0x00622C1B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CF0B RID: 184075 RVA: 0x00624A35 File Offset: 0x00622C35
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CF0C RID: 184076 RVA: 0x00624A53 File Offset: 0x00622C53
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CF0D RID: 184077 RVA: 0x00624A6C File Offset: 0x00622C6C
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CF0E RID: 184078 RVA: 0x00624A77 File Offset: 0x00622C77
		public static Offset<IAddBuffToTriggeredEntity> EndIAddBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToTriggeredEntity>(builder.EndTable());
		}

		// Token: 0x0602CF0F RID: 184079 RVA: 0x00624A84 File Offset: 0x00622C84
		public IAddBuffToTriggeredEntityT UnPack()
		{
			IAddBuffToTriggeredEntityT addBuffToTriggeredEntityT = new IAddBuffToTriggeredEntityT();
			this.UnPackTo(addBuffToTriggeredEntityT);
			return addBuffToTriggeredEntityT;
		}

		// Token: 0x0602CF10 RID: 184080 RVA: 0x00624AA0 File Offset: 0x00622CA0
		public void UnPackTo(IAddBuffToTriggeredEntityT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x0602CF11 RID: 184081 RVA: 0x00624ADC File Offset: 0x00622CDC
		public static Offset<IAddBuffToTriggeredEntity> Pack(FlatBufferBuilder builder, IAddBuffToTriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToTriggeredEntity>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToTriggeredEntity.CreateBuffIdsVector(builder, data);
			}
			return IAddBuffToTriggeredEntity.CreateIAddBuffToTriggeredEntity(builder, buffIdsOffset);
		}

		// Token: 0x040112FC RID: 70396
		private Table __p;
	}
}
