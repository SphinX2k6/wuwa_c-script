using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C1 RID: 22209
	public struct IEntityBatchRefreshMode : IFlatbufferObject
	{
		// Token: 0x17009FE0 RID: 40928
		// (get) Token: 0x06023964 RID: 145764 RVA: 0x004E4D79 File Offset: 0x004E2F79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023965 RID: 145765 RVA: 0x004E4D86 File Offset: 0x004E2F86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023966 RID: 145766 RVA: 0x004E4D90 File Offset: 0x004E2F90
		public static IEntityBatchRefreshMode GetRootAsIEntityBatchRefreshMode(ByteBuffer _bb)
		{
			return IEntityBatchRefreshMode.GetRootAsIEntityBatchRefreshMode(_bb, default(IEntityBatchRefreshMode));
		}

		// Token: 0x06023967 RID: 145767 RVA: 0x004E4DAC File Offset: 0x004E2FAC
		public static IEntityBatchRefreshMode GetRootAsIEntityBatchRefreshMode(ByteBuffer _bb, IEntityBatchRefreshMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023968 RID: 145768 RVA: 0x004E4DC9 File Offset: 0x004E2FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023969 RID: 145769 RVA: 0x004E4DD8 File Offset: 0x004E2FD8
		public IEntityBatchRefreshMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FE1 RID: 40929
		// (get) Token: 0x0602396A RID: 145770 RVA: 0x004E4DE8 File Offset: 0x004E2FE8
		public EEntityBatchRefreshMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityBatchRefreshMode.SequenceBatch;
				}
				return (EEntityBatchRefreshMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602396B RID: 145771 RVA: 0x004E4E24 File Offset: 0x004E3024
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FE2 RID: 40930
		// (get) Token: 0x0602396C RID: 145772 RVA: 0x004E4E84 File Offset: 0x004E3084
		public int EntityBatchesLength
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

		// Token: 0x0602396D RID: 145773 RVA: 0x004E4EAF File Offset: 0x004E30AF
		public static Offset<IEntityBatchRefreshMode> CreateIEntityBatchRefreshMode(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityBatchRefreshMode.AddEntityBatches(builder, EntityBatchesOffset);
			IEntityBatchRefreshMode.AddType(builder, Type);
			return IEntityBatchRefreshMode.EndIEntityBatchRefreshMode(builder);
		}

		// Token: 0x0602396E RID: 145774 RVA: 0x004E4ECC File Offset: 0x004E30CC
		public static void StartIEntityBatchRefreshMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602396F RID: 145775 RVA: 0x004E4ED5 File Offset: 0x004E30D5
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023970 RID: 145776 RVA: 0x004E4EE0 File Offset: 0x004E30E0
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x06023971 RID: 145777 RVA: 0x004E4EF0 File Offset: 0x004E30F0
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023972 RID: 145778 RVA: 0x004E4F30 File Offset: 0x004E3130
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023973 RID: 145779 RVA: 0x004E4F4A File Offset: 0x004E314A
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023974 RID: 145780 RVA: 0x004E4F68 File Offset: 0x004E3168
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023975 RID: 145781 RVA: 0x004E4F81 File Offset: 0x004E3181
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023976 RID: 145782 RVA: 0x004E4F8C File Offset: 0x004E318C
		public static Offset<IEntityBatchRefreshMode> EndIEntityBatchRefreshMode(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchRefreshMode>(builder.EndTable());
		}

		// Token: 0x06023977 RID: 145783 RVA: 0x004E4F9C File Offset: 0x004E319C
		public IEntityBatchRefreshModeT UnPack()
		{
			IEntityBatchRefreshModeT entityBatchRefreshModeT = new IEntityBatchRefreshModeT();
			this.UnPackTo(entityBatchRefreshModeT);
			return entityBatchRefreshModeT;
		}

		// Token: 0x06023978 RID: 145784 RVA: 0x004E4FB8 File Offset: 0x004E31B8
		public void UnPackTo(IEntityBatchRefreshModeT _o)
		{
			_o.Type = this.Type;
			_o.EntityBatches = new List<IEntityListBatchT>();
			for (int i = 0; i < this.EntityBatchesLength; i++)
			{
				_o.EntityBatches.Add((this.EntityBatches(i) != null) ? this.EntityBatches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023979 RID: 145785 RVA: 0x004E5024 File Offset: 0x004E3224
		public static Offset<IEntityBatchRefreshMode> Pack(FlatBufferBuilder builder, IEntityBatchRefreshModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBatchRefreshMode>);
			}
			VectorOffset entityBatchesOffset = default(VectorOffset);
			if (_o.EntityBatches != null)
			{
				Offset<IEntityListBatch>[] array = new Offset<IEntityListBatch>[_o.EntityBatches.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityListBatch.Pack(builder, _o.EntityBatches[i]);
				}
				entityBatchesOffset = IEntityBatchRefreshMode.CreateEntityBatchesVector(builder, array);
			}
			return IEntityBatchRefreshMode.CreateIEntityBatchRefreshMode(builder, _o.Type, entityBatchesOffset);
		}

		// Token: 0x0400EDFC RID: 60924
		private Table __p;
	}
}
