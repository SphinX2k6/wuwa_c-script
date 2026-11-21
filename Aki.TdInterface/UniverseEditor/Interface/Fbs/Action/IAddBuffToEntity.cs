using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200677E RID: 26494
	public struct IAddBuffToEntity : IFlatbufferObject
	{
		// Token: 0x1700C09B RID: 49307
		// (get) Token: 0x0602CE76 RID: 183926 RVA: 0x00623902 File Offset: 0x00621B02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CE77 RID: 183927 RVA: 0x0062390F File Offset: 0x00621B0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CE78 RID: 183928 RVA: 0x00623918 File Offset: 0x00621B18
		public static IAddBuffToEntity GetRootAsIAddBuffToEntity(ByteBuffer _bb)
		{
			return IAddBuffToEntity.GetRootAsIAddBuffToEntity(_bb, default(IAddBuffToEntity));
		}

		// Token: 0x0602CE79 RID: 183929 RVA: 0x00623934 File Offset: 0x00621B34
		public static IAddBuffToEntity GetRootAsIAddBuffToEntity(ByteBuffer _bb, IAddBuffToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CE7A RID: 183930 RVA: 0x00623951 File Offset: 0x00621B51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CE7B RID: 183931 RVA: 0x00623960 File Offset: 0x00621B60
		public IAddBuffToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C09C RID: 49308
		// (get) Token: 0x0602CE7C RID: 183932 RVA: 0x00623970 File Offset: 0x00621B70
		public int EntityId
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

		// Token: 0x0602CE7D RID: 183933 RVA: 0x006239AC File Offset: 0x00621BAC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C09D RID: 49309
		// (get) Token: 0x0602CE7E RID: 183934 RVA: 0x006239EC File Offset: 0x00621BEC
		public int EntityIdsLength
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

		// Token: 0x0602CE7F RID: 183935 RVA: 0x00623A17 File Offset: 0x00621C17
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602CE80 RID: 183936 RVA: 0x00623A26 File Offset: 0x00621C26
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602CE81 RID: 183937 RVA: 0x00623A34 File Offset: 0x00621C34
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C09E RID: 49310
		// (get) Token: 0x0602CE82 RID: 183938 RVA: 0x00623A74 File Offset: 0x00621C74
		public int BuffIdsLength
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

		// Token: 0x0602CE83 RID: 183939 RVA: 0x00623A9F File Offset: 0x00621C9F
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x0602CE84 RID: 183940 RVA: 0x00623AAE File Offset: 0x00621CAE
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x0602CE85 RID: 183941 RVA: 0x00623ABC File Offset: 0x00621CBC
		public long PersistOnOfflineBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700C09F RID: 49311
		// (get) Token: 0x0602CE86 RID: 183942 RVA: 0x00623B00 File Offset: 0x00621D00
		public int PersistOnOfflineBuffIdsLength
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

		// Token: 0x0602CE87 RID: 183943 RVA: 0x00623B2C File Offset: 0x00621D2C
		public Span<long> GetPersistOnOfflineBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x0602CE88 RID: 183944 RVA: 0x00623B3C File Offset: 0x00621D3C
		public long[] GetPersistOnOfflineBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10);
		}

		// Token: 0x1700C0A0 RID: 49312
		// (get) Token: 0x0602CE89 RID: 183945 RVA: 0x00623B4C File Offset: 0x00621D4C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CE8A RID: 183946 RVA: 0x00623B89 File Offset: 0x00621D89
		public static Offset<IAddBuffToEntity> CreateIAddBuffToEntity(FlatBufferBuilder builder, int EntityId = 0, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset BuffIdsOffset = default(VectorOffset), VectorOffset PersistOnOfflineBuffIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IAddBuffToEntity.AddPersistOnOfflineBuffIds(builder, PersistOnOfflineBuffIdsOffset);
			IAddBuffToEntity.AddBuffIds(builder, BuffIdsOffset);
			IAddBuffToEntity.AddEntityIds(builder, EntityIdsOffset);
			IAddBuffToEntity.AddEntityId(builder, EntityId);
			IAddBuffToEntity.AddNullMask(builder, NullMask);
			return IAddBuffToEntity.EndIAddBuffToEntity(builder);
		}

		// Token: 0x0602CE8B RID: 183947 RVA: 0x00623BBD File Offset: 0x00621DBD
		public static void StartIAddBuffToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CE8C RID: 183948 RVA: 0x00623BC6 File Offset: 0x00621DC6
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602CE8D RID: 183949 RVA: 0x00623BD1 File Offset: 0x00621DD1
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602CE8E RID: 183950 RVA: 0x00623BE4 File Offset: 0x00621DE4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CE8F RID: 183951 RVA: 0x00623C1B File Offset: 0x00621E1B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE90 RID: 183952 RVA: 0x00623C35 File Offset: 0x00621E35
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE91 RID: 183953 RVA: 0x00623C53 File Offset: 0x00621E53
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CE92 RID: 183954 RVA: 0x00623C6C File Offset: 0x00621E6C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602CE93 RID: 183955 RVA: 0x00623C77 File Offset: 0x00621E77
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(2, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602CE94 RID: 183956 RVA: 0x00623C88 File Offset: 0x00621E88
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CE95 RID: 183957 RVA: 0x00623CBF File Offset: 0x00621EBF
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE96 RID: 183958 RVA: 0x00623CD9 File Offset: 0x00621ED9
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE97 RID: 183959 RVA: 0x00623CF7 File Offset: 0x00621EF7
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CE98 RID: 183960 RVA: 0x00623D10 File Offset: 0x00621F10
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CE99 RID: 183961 RVA: 0x00623D1B File Offset: 0x00621F1B
		public static void AddPersistOnOfflineBuffIds(FlatBufferBuilder builder, VectorOffset persistOnOfflineBuffIdsOffset)
		{
			builder.AddOffset(3, persistOnOfflineBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602CE9A RID: 183962 RVA: 0x00623D2C File Offset: 0x00621F2C
		public static VectorOffset CreatePersistOnOfflineBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602CE9B RID: 183963 RVA: 0x00623D63 File Offset: 0x00621F63
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE9C RID: 183964 RVA: 0x00623D7D File Offset: 0x00621F7D
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602CE9D RID: 183965 RVA: 0x00623D9B File Offset: 0x00621F9B
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602CE9E RID: 183966 RVA: 0x00623DB4 File Offset: 0x00621FB4
		public static void StartPersistOnOfflineBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602CE9F RID: 183967 RVA: 0x00623DBF File Offset: 0x00621FBF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602CEA0 RID: 183968 RVA: 0x00623DCA File Offset: 0x00621FCA
		public static Offset<IAddBuffToEntity> EndIAddBuffToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToEntity>(builder.EndTable());
		}

		// Token: 0x0602CEA1 RID: 183969 RVA: 0x00623DD8 File Offset: 0x00621FD8
		public IAddBuffToEntityT UnPack()
		{
			IAddBuffToEntityT addBuffToEntityT = new IAddBuffToEntityT();
			this.UnPackTo(addBuffToEntityT);
			return addBuffToEntityT;
		}

		// Token: 0x0602CEA2 RID: 183970 RVA: 0x00623DF4 File Offset: 0x00621FF4
		public void UnPackTo(IAddBuffToEntityT _o)
		{
			_o.EntityId = this.EntityId;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.BuffIds = new List<long>();
			for (int j = 0; j < this.BuffIdsLength; j++)
			{
				_o.BuffIds.Add(this.BuffIds(j));
			}
			_o.PersistOnOfflineBuffIds = new List<long>();
			for (int k = 0; k < this.PersistOnOfflineBuffIdsLength; k++)
			{
				_o.PersistOnOfflineBuffIds.Add(this.PersistOnOfflineBuffIds(k));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CEA3 RID: 183971 RVA: 0x00623EA4 File Offset: 0x006220A4
		public static Offset<IAddBuffToEntity> Pack(FlatBufferBuilder builder, IAddBuffToEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddBuffToEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAddBuffToEntity.CreateEntityIdsVector(builder, data);
			}
			VectorOffset buffIdsOffset = default(VectorOffset);
			if (_o.BuffIds != null)
			{
				long[] data2 = _o.BuffIds.ToArray();
				buffIdsOffset = IAddBuffToEntity.CreateBuffIdsVector(builder, data2);
			}
			VectorOffset persistOnOfflineBuffIdsOffset = default(VectorOffset);
			if (_o.PersistOnOfflineBuffIds != null)
			{
				long[] data3 = _o.PersistOnOfflineBuffIds.ToArray();
				persistOnOfflineBuffIdsOffset = IAddBuffToEntity.CreatePersistOnOfflineBuffIdsVector(builder, data3);
			}
			return IAddBuffToEntity.CreateIAddBuffToEntity(builder, _o.EntityId, entityIdsOffset, buffIdsOffset, persistOnOfflineBuffIdsOffset, _o.NullMask);
		}

		// Token: 0x040112EE RID: 70382
		private Table __p;
	}
}
