using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007154 RID: 29012
	public struct ILockEntity : IFlatbufferObject
	{
		// Token: 0x1700D451 RID: 54353
		// (get) Token: 0x0603265C RID: 206428 RVA: 0x006CFE6E File Offset: 0x006CE06E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603265D RID: 206429 RVA: 0x006CFE7B File Offset: 0x006CE07B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603265E RID: 206430 RVA: 0x006CFE84 File Offset: 0x006CE084
		public static ILockEntity GetRootAsILockEntity(ByteBuffer _bb)
		{
			return ILockEntity.GetRootAsILockEntity(_bb, default(ILockEntity));
		}

		// Token: 0x0603265F RID: 206431 RVA: 0x006CFEA0 File Offset: 0x006CE0A0
		public static ILockEntity GetRootAsILockEntity(ByteBuffer _bb, ILockEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032660 RID: 206432 RVA: 0x006CFEBD File Offset: 0x006CE0BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032661 RID: 206433 RVA: 0x006CFECC File Offset: 0x006CE0CC
		public ILockEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06032662 RID: 206434 RVA: 0x006CFEDC File Offset: 0x006CE0DC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D452 RID: 54354
		// (get) Token: 0x06032663 RID: 206435 RVA: 0x006CFF1C File Offset: 0x006CE11C
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

		// Token: 0x06032664 RID: 206436 RVA: 0x006CFF47 File Offset: 0x006CE147
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06032665 RID: 206437 RVA: 0x006CFF56 File Offset: 0x006CE156
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06032666 RID: 206438 RVA: 0x006CFF64 File Offset: 0x006CE164
		public static Offset<ILockEntity> CreateILockEntity(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILockEntity.AddEntityIds(builder, EntityIdsOffset);
			return ILockEntity.EndILockEntity(builder);
		}

		// Token: 0x06032667 RID: 206439 RVA: 0x006CFF7A File Offset: 0x006CE17A
		public static void StartILockEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032668 RID: 206440 RVA: 0x006CFF83 File Offset: 0x006CE183
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06032669 RID: 206441 RVA: 0x006CFF94 File Offset: 0x006CE194
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603266A RID: 206442 RVA: 0x006CFFCB File Offset: 0x006CE1CB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603266B RID: 206443 RVA: 0x006CFFE5 File Offset: 0x006CE1E5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603266C RID: 206444 RVA: 0x006D0003 File Offset: 0x006CE203
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603266D RID: 206445 RVA: 0x006D001C File Offset: 0x006CE21C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603266E RID: 206446 RVA: 0x006D0027 File Offset: 0x006CE227
		public static Offset<ILockEntity> EndILockEntity(FlatBufferBuilder builder)
		{
			return new Offset<ILockEntity>(builder.EndTable());
		}

		// Token: 0x0603266F RID: 206447 RVA: 0x006D0034 File Offset: 0x006CE234
		public ILockEntityT UnPack()
		{
			ILockEntityT lockEntityT = new ILockEntityT();
			this.UnPackTo(lockEntityT);
			return lockEntityT;
		}

		// Token: 0x06032670 RID: 206448 RVA: 0x006D0050 File Offset: 0x006CE250
		public void UnPackTo(ILockEntityT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06032671 RID: 206449 RVA: 0x006D008C File Offset: 0x006CE28C
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

		// Token: 0x0401213A RID: 74042
		private Table __p;
	}
}
