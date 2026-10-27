using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200515C RID: 20828
	public struct IEntityBatchRefreshMode : IFlatbufferObject
	{
		// Token: 0x170097F3 RID: 38899
		// (get) Token: 0x06021A10 RID: 137744 RVA: 0x004AADED File Offset: 0x004A8FED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A11 RID: 137745 RVA: 0x004AADFA File Offset: 0x004A8FFA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A12 RID: 137746 RVA: 0x004AAE04 File Offset: 0x004A9004
		public static IEntityBatchRefreshMode GetRootAsIEntityBatchRefreshMode(ByteBuffer _bb)
		{
			return IEntityBatchRefreshMode.GetRootAsIEntityBatchRefreshMode(_bb, default(IEntityBatchRefreshMode));
		}

		// Token: 0x06021A13 RID: 137747 RVA: 0x004AAE20 File Offset: 0x004A9020
		public static IEntityBatchRefreshMode GetRootAsIEntityBatchRefreshMode(ByteBuffer _bb, IEntityBatchRefreshMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A14 RID: 137748 RVA: 0x004AAE3D File Offset: 0x004A903D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A15 RID: 137749 RVA: 0x004AAE4C File Offset: 0x004A904C
		public IEntityBatchRefreshMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097F4 RID: 38900
		// (get) Token: 0x06021A16 RID: 137750 RVA: 0x004AAE5C File Offset: 0x004A905C
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

		// Token: 0x06021A17 RID: 137751 RVA: 0x004AAE98 File Offset: 0x004A9098
		public IEntityListBatch? EntityBatches(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityListBatch?(default(IEntityListBatch).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170097F5 RID: 38901
		// (get) Token: 0x06021A18 RID: 137752 RVA: 0x004AAEF8 File Offset: 0x004A90F8
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

		// Token: 0x06021A19 RID: 137753 RVA: 0x004AAF23 File Offset: 0x004A9123
		public static Offset<IEntityBatchRefreshMode> CreateIEntityBatchRefreshMode(FlatBufferBuilder builder, EEntityBatchRefreshMode Type = EEntityBatchRefreshMode.SequenceBatch, VectorOffset EntityBatchesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityBatchRefreshMode.AddEntityBatches(builder, EntityBatchesOffset);
			IEntityBatchRefreshMode.AddType(builder, Type);
			return IEntityBatchRefreshMode.EndIEntityBatchRefreshMode(builder);
		}

		// Token: 0x06021A1A RID: 137754 RVA: 0x004AAF40 File Offset: 0x004A9140
		public static void StartIEntityBatchRefreshMode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021A1B RID: 137755 RVA: 0x004AAF49 File Offset: 0x004A9149
		public static void AddType(FlatBufferBuilder builder, EEntityBatchRefreshMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021A1C RID: 137756 RVA: 0x004AAF54 File Offset: 0x004A9154
		public static void AddEntityBatches(FlatBufferBuilder builder, VectorOffset entityBatchesOffset)
		{
			builder.AddOffset(1, entityBatchesOffset.Value, 0);
		}

		// Token: 0x06021A1D RID: 137757 RVA: 0x004AAF64 File Offset: 0x004A9164
		public static VectorOffset CreateEntityBatchesVector(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021A1E RID: 137758 RVA: 0x004AAFA4 File Offset: 0x004A91A4
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, Offset<IEntityListBatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021A1F RID: 137759 RVA: 0x004AAFBE File Offset: 0x004A91BE
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityListBatch>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityListBatch>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021A20 RID: 137760 RVA: 0x004AAFDC File Offset: 0x004A91DC
		public static VectorOffset CreateEntityBatchesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityListBatch>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021A21 RID: 137761 RVA: 0x004AAFF5 File Offset: 0x004A91F5
		public static void StartEntityBatchesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021A22 RID: 137762 RVA: 0x004AB000 File Offset: 0x004A9200
		public static Offset<IEntityBatchRefreshMode> EndIEntityBatchRefreshMode(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBatchRefreshMode>(builder.EndTable());
		}

		// Token: 0x06021A23 RID: 137763 RVA: 0x004AB010 File Offset: 0x004A9210
		public IEntityBatchRefreshModeT UnPack()
		{
			IEntityBatchRefreshModeT entityBatchRefreshModeT = new IEntityBatchRefreshModeT();
			this.UnPackTo(entityBatchRefreshModeT);
			return entityBatchRefreshModeT;
		}

		// Token: 0x06021A24 RID: 137764 RVA: 0x004AB02C File Offset: 0x004A922C
		public void UnPackTo(IEntityBatchRefreshModeT _o)
		{
			_o.Type = this.Type;
			_o.EntityBatches = new List<IEntityListBatchT>();
			for (int i = 0; i < this.EntityBatchesLength; i++)
			{
				_o.EntityBatches.Add((this.EntityBatches(i) != null) ? this.EntityBatches(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021A25 RID: 137765 RVA: 0x004AB098 File Offset: 0x004A9298
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

		// Token: 0x0400E1FF RID: 57855
		private Table __p;
	}
}
