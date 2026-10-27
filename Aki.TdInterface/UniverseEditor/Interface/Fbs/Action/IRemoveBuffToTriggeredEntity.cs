using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E40 RID: 28224
	public struct IRemoveBuffToTriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700D24F RID: 53839
		// (get) Token: 0x06031DFC RID: 204284 RVA: 0x006BFDC6 File Offset: 0x006BDFC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031DFD RID: 204285 RVA: 0x006BFDD3 File Offset: 0x006BDFD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031DFE RID: 204286 RVA: 0x006BFDDC File Offset: 0x006BDFDC
		public static IRemoveBuffToTriggeredEntity GetRootAsIRemoveBuffToTriggeredEntity(ByteBuffer _bb)
		{
			return IRemoveBuffToTriggeredEntity.GetRootAsIRemoveBuffToTriggeredEntity(_bb, default(IRemoveBuffToTriggeredEntity));
		}

		// Token: 0x06031DFF RID: 204287 RVA: 0x006BFDF8 File Offset: 0x006BDFF8
		public static IRemoveBuffToTriggeredEntity GetRootAsIRemoveBuffToTriggeredEntity(ByteBuffer _bb, IRemoveBuffToTriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E00 RID: 204288 RVA: 0x006BFE15 File Offset: 0x006BE015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E01 RID: 204289 RVA: 0x006BFE24 File Offset: 0x006BE024
		public IRemoveBuffToTriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031E02 RID: 204290 RVA: 0x006BFE34 File Offset: 0x006BE034
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700D250 RID: 53840
		// (get) Token: 0x06031E03 RID: 204291 RVA: 0x006BFE74 File Offset: 0x006BE074
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

		// Token: 0x06031E04 RID: 204292 RVA: 0x006BFE9F File Offset: 0x006BE09F
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06031E05 RID: 204293 RVA: 0x006BFEAE File Offset: 0x006BE0AE
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x06031E06 RID: 204294 RVA: 0x006BFEBC File Offset: 0x006BE0BC
		public static Offset<IRemoveBuffToTriggeredEntity> CreateIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRemoveBuffToTriggeredEntity.AddBuffIds(builder, BuffIdsOffset);
			return IRemoveBuffToTriggeredEntity.EndIRemoveBuffToTriggeredEntity(builder);
		}

		// Token: 0x06031E07 RID: 204295 RVA: 0x006BFED2 File Offset: 0x006BE0D2
		public static void StartIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031E08 RID: 204296 RVA: 0x006BFEDB File Offset: 0x006BE0DB
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x06031E09 RID: 204297 RVA: 0x006BFEEC File Offset: 0x006BE0EC
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031E0A RID: 204298 RVA: 0x006BFF23 File Offset: 0x006BE123
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E0B RID: 204299 RVA: 0x006BFF3D File Offset: 0x006BE13D
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06031E0C RID: 204300 RVA: 0x006BFF5B File Offset: 0x006BE15B
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031E0D RID: 204301 RVA: 0x006BFF74 File Offset: 0x006BE174
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06031E0E RID: 204302 RVA: 0x006BFF7F File Offset: 0x006BE17F
		public static Offset<IRemoveBuffToTriggeredEntity> EndIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffToTriggeredEntity>(builder.EndTable());
		}

		// Token: 0x06031E0F RID: 204303 RVA: 0x006BFF8C File Offset: 0x006BE18C
		public IRemoveBuffToTriggeredEntityT UnPack()
		{
			IRemoveBuffToTriggeredEntityT removeBuffToTriggeredEntityT = new IRemoveBuffToTriggeredEntityT();
			this.UnPackTo(removeBuffToTriggeredEntityT);
			return removeBuffToTriggeredEntityT;
		}

		// Token: 0x06031E10 RID: 204304 RVA: 0x006BFFA8 File Offset: 0x006BE1A8
		public void UnPackTo(IRemoveBuffToTriggeredEntityT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x06031E11 RID: 204305 RVA: 0x006BFFE4 File Offset: 0x006BE1E4
		public static Offset<IRemoveBuffToTriggeredEntity> Pack(FlatBufferBuilder builder, IRemoveBuffToTriggeredEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemoveBuffToTriggeredEntity>);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data = _o.BuffIds.ToArray();
				buffIdsOffset = IRemoveBuffToTriggeredEntity.CreateBuffIdsVector(builder, data);
			}
			return IRemoveBuffToTriggeredEntity.CreateIRemoveBuffToTriggeredEntity(builder, buffIdsOffset);
		}

		// Token: 0x04011825 RID: 71717
		private Table __p;
	}
}
