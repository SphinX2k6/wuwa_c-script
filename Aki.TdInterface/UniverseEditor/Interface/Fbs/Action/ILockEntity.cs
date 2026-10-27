using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A32 RID: 27186
	public struct ILockEntity : IFlatbufferObject
	{
		// Token: 0x1700C9A6 RID: 51622
		// (get) Token: 0x0602F936 RID: 194870 RVA: 0x00679DB0 File Offset: 0x00677FB0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F937 RID: 194871 RVA: 0x00679DBD File Offset: 0x00677FBD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F938 RID: 194872 RVA: 0x00679DC4 File Offset: 0x00677FC4
		public static ILockEntity GetRootAsILockEntity(ByteBuffer _bb)
		{
			return ILockEntity.GetRootAsILockEntity(_bb, default(ILockEntity));
		}

		// Token: 0x0602F939 RID: 194873 RVA: 0x00679DE0 File Offset: 0x00677FE0
		public static ILockEntity GetRootAsILockEntity(ByteBuffer _bb, ILockEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F93A RID: 194874 RVA: 0x00679DFD File Offset: 0x00677FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F93B RID: 194875 RVA: 0x00679E0C File Offset: 0x0067800C
		public ILockEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F93C RID: 194876 RVA: 0x00679E1C File Offset: 0x0067801C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C9A7 RID: 51623
		// (get) Token: 0x0602F93D RID: 194877 RVA: 0x00679E5C File Offset: 0x0067805C
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

		// Token: 0x0602F93E RID: 194878 RVA: 0x00679E87 File Offset: 0x00678087
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602F93F RID: 194879 RVA: 0x00679E96 File Offset: 0x00678096
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x0602F940 RID: 194880 RVA: 0x00679EA4 File Offset: 0x006780A4
		public static Offset<ILockEntity> CreateILockEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILockEntity.AddEntityIds(builder, EntityIdsOffset);
			return ILockEntity.EndILockEntity(builder);
		}

		// Token: 0x0602F941 RID: 194881 RVA: 0x00679EBA File Offset: 0x006780BA
		public static void StartILockEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F942 RID: 194882 RVA: 0x00679EC3 File Offset: 0x006780C3
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602F943 RID: 194883 RVA: 0x00679ED4 File Offset: 0x006780D4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F944 RID: 194884 RVA: 0x00679F0B File Offset: 0x0067810B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F945 RID: 194885 RVA: 0x00679F25 File Offset: 0x00678125
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F946 RID: 194886 RVA: 0x00679F43 File Offset: 0x00678143
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F947 RID: 194887 RVA: 0x00679F5C File Offset: 0x0067815C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F948 RID: 194888 RVA: 0x00679F67 File Offset: 0x00678167
		public static Offset<ILockEntity> EndILockEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILockEntity>(builder.EndTable());
		}

		// Token: 0x0602F949 RID: 194889 RVA: 0x00679F74 File Offset: 0x00678174
		public ILockEntityT UnPack()
		{
			ILockEntityT lockEntityT = new ILockEntityT();
			this.UnPackTo(lockEntityT);
			return lockEntityT;
		}

		// Token: 0x0602F94A RID: 194890 RVA: 0x00679F90 File Offset: 0x00678190
		public void UnPackTo(ILockEntityT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602F94B RID: 194891 RVA: 0x00679FCC File Offset: 0x006781CC
		public static Offset<ILockEntity> Pack(FlatBufferBuilder builder, ILockEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILockEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = ILockEntity.CreateEntityIdsVector(builder, data);
			}
			return ILockEntity.CreateILockEntity(builder, entityIdsOffset);
		}

		// Token: 0x04011242 RID: 70210
		private Table __p;
	}
}
