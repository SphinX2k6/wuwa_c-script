using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200611C RID: 24860
	public struct IAddBuffToEntity : IFlatbufferObject
	{
		// Token: 0x1700B730 RID: 46896
		// (get) Token: 0x0602A795 RID: 173973 RVA: 0x005D995A File Offset: 0x005D7B5A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A796 RID: 173974 RVA: 0x005D9967 File Offset: 0x005D7B67
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A797 RID: 173975 RVA: 0x005D9970 File Offset: 0x005D7B70
		public static IAddBuffToEntity GetRootAsIAddBuffToEntity(ByteBuffer _bb)
		{
			return IAddBuffToEntity.GetRootAsIAddBuffToEntity(_bb, default(IAddBuffToEntity));
		}

		// Token: 0x0602A798 RID: 173976 RVA: 0x005D998C File Offset: 0x005D7B8C
		public static IAddBuffToEntity GetRootAsIAddBuffToEntity(ByteBuffer _bb, IAddBuffToEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A799 RID: 173977 RVA: 0x005D99A9 File Offset: 0x005D7BA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A79A RID: 173978 RVA: 0x005D99B8 File Offset: 0x005D7BB8
		public IAddBuffToEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B731 RID: 46897
		// (get) Token: 0x0602A79B RID: 173979 RVA: 0x005D99C8 File Offset: 0x005D7BC8
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

		// Token: 0x0602A79C RID: 173980 RVA: 0x005D9A04 File Offset: 0x005D7C04
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B732 RID: 46898
		// (get) Token: 0x0602A79D RID: 173981 RVA: 0x005D9A44 File Offset: 0x005D7C44
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

		// Token: 0x0602A79E RID: 173982 RVA: 0x005D9A6F File Offset: 0x005D7C6F
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602A79F RID: 173983 RVA: 0x005D9A7E File Offset: 0x005D7C7E
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602A7A0 RID: 173984 RVA: 0x005D9A8C File Offset: 0x005D7C8C
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B733 RID: 46899
		// (get) Token: 0x0602A7A1 RID: 173985 RVA: 0x005D9ACC File Offset: 0x005D7CCC
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

		// Token: 0x0602A7A2 RID: 173986 RVA: 0x005D9AF7 File Offset: 0x005D7CF7
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(8, 8);
		}

		// Token: 0x0602A7A3 RID: 173987 RVA: 0x005D9B06 File Offset: 0x005D7D06
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(8);
		}

		// Token: 0x0602A7A4 RID: 173988 RVA: 0x005D9B14 File Offset: 0x005D7D14
		public long PersistOnOfflineBuffIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700B734 RID: 46900
		// (get) Token: 0x0602A7A5 RID: 173989 RVA: 0x005D9B58 File Offset: 0x005D7D58
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

		// Token: 0x0602A7A6 RID: 173990 RVA: 0x005D9B84 File Offset: 0x005D7D84
		public Span<long> GetPersistOnOfflineBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(10, 8);
		}

		// Token: 0x0602A7A7 RID: 173991 RVA: 0x005D9B94 File Offset: 0x005D7D94
		public long[] GetPersistOnOfflineBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(10);
		}

		// Token: 0x1700B735 RID: 46901
		// (get) Token: 0x0602A7A8 RID: 173992 RVA: 0x005D9BA4 File Offset: 0x005D7DA4
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

		// Token: 0x0602A7A9 RID: 173993 RVA: 0x005D9BE1 File Offset: 0x005D7DE1
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

		// Token: 0x0602A7AA RID: 173994 RVA: 0x005D9C15 File Offset: 0x005D7E15
		public static void StartIAddBuffToEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A7AB RID: 173995 RVA: 0x005D9C1E File Offset: 0x005D7E1E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0602A7AC RID: 173996 RVA: 0x005D9C29 File Offset: 0x005D7E29
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602A7AD RID: 173997 RVA: 0x005D9C3C File Offset: 0x005D7E3C
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A7AE RID: 173998 RVA: 0x005D9C73 File Offset: 0x005D7E73
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7AF RID: 173999 RVA: 0x005D9C8D File Offset: 0x005D7E8D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7B0 RID: 174000 RVA: 0x005D9CAB File Offset: 0x005D7EAB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A7B1 RID: 174001 RVA: 0x005D9CC4 File Offset: 0x005D7EC4
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A7B2 RID: 174002 RVA: 0x005D9CCF File Offset: 0x005D7ECF
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(2, buffIdsOffset.Value, 0);
		}

		// Token: 0x0602A7B3 RID: 174003 RVA: 0x005D9CE0 File Offset: 0x005D7EE0
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A7B4 RID: 174004 RVA: 0x005D9D17 File Offset: 0x005D7F17
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7B5 RID: 174005 RVA: 0x005D9D31 File Offset: 0x005D7F31
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7B6 RID: 174006 RVA: 0x005D9D4F File Offset: 0x005D7F4F
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A7B7 RID: 174007 RVA: 0x005D9D68 File Offset: 0x005D7F68
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A7B8 RID: 174008 RVA: 0x005D9D73 File Offset: 0x005D7F73
		public static void AddPersistOnOfflineBuffIds(FlatBufferBuilder builder, VectorOffset persistOnOfflineBuffIdsOffset)
		{
			builder.AddOffset(3, persistOnOfflineBuffIdsOffset.Value, 0);
		}

		// Token: 0x0602A7B9 RID: 174009 RVA: 0x005D9D84 File Offset: 0x005D7F84
		public static VectorOffset CreatePersistOnOfflineBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A7BA RID: 174010 RVA: 0x005D9DBB File Offset: 0x005D7FBB
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7BB RID: 174011 RVA: 0x005D9DD5 File Offset: 0x005D7FD5
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A7BC RID: 174012 RVA: 0x005D9DF3 File Offset: 0x005D7FF3
		public static VectorOffset CreatePersistOnOfflineBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A7BD RID: 174013 RVA: 0x005D9E0C File Offset: 0x005D800C
		public static void StartPersistOnOfflineBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x0602A7BE RID: 174014 RVA: 0x005D9E17 File Offset: 0x005D8017
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A7BF RID: 174015 RVA: 0x005D9E22 File Offset: 0x005D8022
		public static Offset<IAddBuffToEntity> EndIAddBuffToEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAddBuffToEntity>(builder.EndTable());
		}

		// Token: 0x0602A7C0 RID: 174016 RVA: 0x005D9E30 File Offset: 0x005D8030
		public IAddBuffToEntityT UnPack()
		{
			IAddBuffToEntityT addBuffToEntityT = new IAddBuffToEntityT();
			this.UnPackTo(addBuffToEntityT);
			return addBuffToEntityT;
		}

		// Token: 0x0602A7C1 RID: 174017 RVA: 0x005D9E4C File Offset: 0x005D804C
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

		// Token: 0x0602A7C2 RID: 174018 RVA: 0x005D9EFC File Offset: 0x005D80FC
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

		// Token: 0x040104EA RID: 66794
		private Table __p;
	}
}
