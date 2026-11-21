using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CCE RID: 31950
	public struct IUnlockEntity : IFlatbufferObject
	{
		// Token: 0x1700EF25 RID: 61221
		// (get) Token: 0x06039A1C RID: 236060 RVA: 0x007C686D File Offset: 0x007C4A6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039A1D RID: 236061 RVA: 0x007C687A File Offset: 0x007C4A7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039A1E RID: 236062 RVA: 0x007C6884 File Offset: 0x007C4A84
		public static IUnlockEntity GetRootAsIUnlockEntity(ByteBuffer _bb)
		{
			return IUnlockEntity.GetRootAsIUnlockEntity(_bb, default(IUnlockEntity));
		}

		// Token: 0x06039A1F RID: 236063 RVA: 0x007C68A0 File Offset: 0x007C4AA0
		public static IUnlockEntity GetRootAsIUnlockEntity(ByteBuffer _bb, IUnlockEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039A20 RID: 236064 RVA: 0x007C68BD File Offset: 0x007C4ABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039A21 RID: 236065 RVA: 0x007C68CC File Offset: 0x007C4ACC
		public IUnlockEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06039A22 RID: 236066 RVA: 0x007C68DC File Offset: 0x007C4ADC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700EF26 RID: 61222
		// (get) Token: 0x06039A23 RID: 236067 RVA: 0x007C691C File Offset: 0x007C4B1C
		public int EntityIdsLength
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

		// Token: 0x06039A24 RID: 236068 RVA: 0x007C6947 File Offset: 0x007C4B47
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06039A25 RID: 236069 RVA: 0x007C6956 File Offset: 0x007C4B56
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06039A26 RID: 236070 RVA: 0x007C6964 File Offset: 0x007C4B64
		public static Offset<IUnlockEntity> CreateIUnlockEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IUnlockEntity.AddEntityIds(builder, EntityIdsOffset);
			return IUnlockEntity.EndIUnlockEntity(builder);
		}

		// Token: 0x06039A27 RID: 236071 RVA: 0x007C697A File Offset: 0x007C4B7A
		public static void StartIUnlockEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039A28 RID: 236072 RVA: 0x007C6983 File Offset: 0x007C4B83
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06039A29 RID: 236073 RVA: 0x007C6994 File Offset: 0x007C4B94
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06039A2A RID: 236074 RVA: 0x007C69CB File Offset: 0x007C4BCB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039A2B RID: 236075 RVA: 0x007C69E5 File Offset: 0x007C4BE5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06039A2C RID: 236076 RVA: 0x007C6A03 File Offset: 0x007C4C03
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039A2D RID: 236077 RVA: 0x007C6A1C File Offset: 0x007C4C1C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039A2E RID: 236078 RVA: 0x007C6A27 File Offset: 0x007C4C27
		public static Offset<IUnlockEntity> EndIUnlockEntity(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockEntity>(builder.EndTable());
		}

		// Token: 0x06039A2F RID: 236079 RVA: 0x007C6A34 File Offset: 0x007C4C34
		public IUnlockEntityT UnPack()
		{
			IUnlockEntityT unlockEntityT = new IUnlockEntityT();
			this.UnPackTo(unlockEntityT);
			return unlockEntityT;
		}

		// Token: 0x06039A30 RID: 236080 RVA: 0x007C6A50 File Offset: 0x007C4C50
		public void UnPackTo(IUnlockEntityT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06039A31 RID: 236081 RVA: 0x007C6A8C File Offset: 0x007C4C8C
		public static Offset<IUnlockEntity> Pack(FlatBufferBuilder builder, IUnlockEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IUnlockEntity.CreateEntityIdsVector(builder, data);
			}
			return IUnlockEntity.CreateIUnlockEntity(builder, entityIdsOffset);
		}

		// Token: 0x040133D2 RID: 78802
		private Table __p;
	}
}
