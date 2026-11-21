using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BE RID: 30142
	public struct IRemoveBuffToTriggeredEntity : IFlatbufferObject
	{
		// Token: 0x1700DD9E RID: 56734
		// (get) Token: 0x06034E12 RID: 216594 RVA: 0x0071B74E File Offset: 0x0071994E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034E13 RID: 216595 RVA: 0x0071B75B File Offset: 0x0071995B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034E14 RID: 216596 RVA: 0x0071B764 File Offset: 0x00719964
		public static IRemoveBuffToTriggeredEntity GetRootAsIRemoveBuffToTriggeredEntity(ByteBuffer _bb)
		{
			return IRemoveBuffToTriggeredEntity.GetRootAsIRemoveBuffToTriggeredEntity(_bb, default(IRemoveBuffToTriggeredEntity));
		}

		// Token: 0x06034E15 RID: 216597 RVA: 0x0071B780 File Offset: 0x00719980
		public static IRemoveBuffToTriggeredEntity GetRootAsIRemoveBuffToTriggeredEntity(ByteBuffer _bb, IRemoveBuffToTriggeredEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034E16 RID: 216598 RVA: 0x0071B79D File Offset: 0x0071999D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034E17 RID: 216599 RVA: 0x0071B7AC File Offset: 0x007199AC
		public IRemoveBuffToTriggeredEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06034E18 RID: 216600 RVA: 0x0071B7BC File Offset: 0x007199BC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0L;
			}
			return this.__p.bb.GetLong(this.__p.__vector(num) + j * 8);
		}

		// Token: 0x1700DD9F RID: 56735
		// (get) Token: 0x06034E19 RID: 216601 RVA: 0x0071B7FC File Offset: 0x007199FC
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

		// Token: 0x06034E1A RID: 216602 RVA: 0x0071B827 File Offset: 0x00719A27
		public Span<long> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<long>(4, 8);
		}

		// Token: 0x06034E1B RID: 216603 RVA: 0x0071B836 File Offset: 0x00719A36
		public long[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<long>(4);
		}

		// Token: 0x06034E1C RID: 216604 RVA: 0x0071B844 File Offset: 0x00719A44
		public static Offset<IRemoveBuffToTriggeredEntity> CreateIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder, VectorOffset BuffIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IRemoveBuffToTriggeredEntity.AddBuffIds(builder, BuffIdsOffset);
			return IRemoveBuffToTriggeredEntity.EndIRemoveBuffToTriggeredEntity(builder);
		}

		// Token: 0x06034E1D RID: 216605 RVA: 0x0071B85A File Offset: 0x00719A5A
		public static void StartIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06034E1E RID: 216606 RVA: 0x0071B863 File Offset: 0x00719A63
		public static void AddBuffIds(FlatBufferBuilder builder, VectorOffset buffIdsOffset)
		{
			builder.AddOffset(0, buffIdsOffset.Value, 0);
		}

		// Token: 0x06034E1F RID: 216607 RVA: 0x0071B874 File Offset: 0x00719A74
		public static VectorOffset CreateBuffIdsVector(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddLong(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06034E20 RID: 216608 RVA: 0x0071B8AB File Offset: 0x00719AAB
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			builder.StartVector(8, data.Length, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E21 RID: 216609 RVA: 0x0071B8C5 File Offset: 0x00719AC5
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			builder.StartVector(8, data.Count, 8);
			builder.Add<long>(data);
			return builder.EndVector();
		}

		// Token: 0x06034E22 RID: 216610 RVA: 0x0071B8E3 File Offset: 0x00719AE3
		public static VectorOffset CreateBuffIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<long>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034E23 RID: 216611 RVA: 0x0071B8FC File Offset: 0x00719AFC
		public static void StartBuffIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(8, numElems, 8);
		}

		// Token: 0x06034E24 RID: 216612 RVA: 0x0071B907 File Offset: 0x00719B07
		public static Offset<IRemoveBuffToTriggeredEntity> EndIRemoveBuffToTriggeredEntity(FlatBufferBuilder builder)
		{
			return new Offset<IRemoveBuffToTriggeredEntity>(builder.EndTable());
		}

		// Token: 0x06034E25 RID: 216613 RVA: 0x0071B914 File Offset: 0x00719B14
		public IRemoveBuffToTriggeredEntityT UnPack()
		{
			IRemoveBuffToTriggeredEntityT removeBuffToTriggeredEntityT = new IRemoveBuffToTriggeredEntityT();
			this.UnPackTo(removeBuffToTriggeredEntityT);
			return removeBuffToTriggeredEntityT;
		}

		// Token: 0x06034E26 RID: 216614 RVA: 0x0071B930 File Offset: 0x00719B30
		public void UnPackTo(IRemoveBuffToTriggeredEntityT _o)
		{
			_o.BuffIds = new List<long>();
			for (int i = 0; i < this.BuffIdsLength; i++)
			{
				_o.BuffIds.Add(this.BuffIds(i));
			}
		}

		// Token: 0x06034E27 RID: 216615 RVA: 0x0071B96C File Offset: 0x00719B6C
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

		// Token: 0x040127A5 RID: 75685
		private Table __p;
	}
}
