using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683B RID: 26683
	public struct IAwakeEntity : IFlatbufferObject
	{
		// Token: 0x1700C433 RID: 50227
		// (get) Token: 0x0602D9A7 RID: 186791 RVA: 0x0063D57A File Offset: 0x0063B77A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D9A8 RID: 186792 RVA: 0x0063D587 File Offset: 0x0063B787
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D9A9 RID: 186793 RVA: 0x0063D590 File Offset: 0x0063B790
		public static IAwakeEntity GetRootAsIAwakeEntity(ByteBuffer _bb)
		{
			return IAwakeEntity.GetRootAsIAwakeEntity(_bb, default(IAwakeEntity));
		}

		// Token: 0x0602D9AA RID: 186794 RVA: 0x0063D5AC File Offset: 0x0063B7AC
		public static IAwakeEntity GetRootAsIAwakeEntity(ByteBuffer _bb, IAwakeEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D9AB RID: 186795 RVA: 0x0063D5C9 File Offset: 0x0063B7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D9AC RID: 186796 RVA: 0x0063D5D8 File Offset: 0x0063B7D8
		public IAwakeEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C434 RID: 50228
		// (get) Token: 0x0602D9AD RID: 186797 RVA: 0x0063D5E8 File Offset: 0x0063B7E8
		public IAwakeWithTransformVar? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IAwakeWithTransformVar?(default(IAwakeWithTransformVar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C435 RID: 50229
		// (get) Token: 0x0602D9AE RID: 186798 RVA: 0x0063D648 File Offset: 0x0063B848
		public bool IsSnap
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D9AF RID: 186799 RVA: 0x0063D688 File Offset: 0x0063B888
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C436 RID: 50230
		// (get) Token: 0x0602D9B0 RID: 186800 RVA: 0x0063D6C8 File Offset: 0x0063B8C8
		public int EntityIdsLength
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

		// Token: 0x0602D9B1 RID: 186801 RVA: 0x0063D6F3 File Offset: 0x0063B8F3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0602D9B2 RID: 186802 RVA: 0x0063D702 File Offset: 0x0063B902
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700C437 RID: 50231
		// (get) Token: 0x0602D9B3 RID: 186803 RVA: 0x0063D710 File Offset: 0x0063B910
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D9B4 RID: 186804 RVA: 0x0063D74D File Offset: 0x0063B94D
		public static Offset<IAwakeEntity> CreateIAwakeEntity(FlatBufferBuilder builder, Offset<IAwakeWithTransformVar> PositionOffset = default(Offset<IAwakeWithTransformVar>), bool IsSnap = false, VectorOffset EntityIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IAwakeEntity.AddEntityIds(builder, EntityIdsOffset);
			IAwakeEntity.AddPosition(builder, PositionOffset);
			IAwakeEntity.AddNullMask(builder, NullMask);
			IAwakeEntity.AddIsSnap(builder, IsSnap);
			return IAwakeEntity.EndIAwakeEntity(builder);
		}

		// Token: 0x0602D9B5 RID: 186805 RVA: 0x0063D779 File Offset: 0x0063B979
		public static void StartIAwakeEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D9B6 RID: 186806 RVA: 0x0063D782 File Offset: 0x0063B982
		public static void AddPosition(FlatBufferBuilder builder, Offset<IAwakeWithTransformVar> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0602D9B7 RID: 186807 RVA: 0x0063D792 File Offset: 0x0063B992
		public static void AddIsSnap(FlatBufferBuilder builder, bool isSnap)
		{
			builder.AddBool(1, isSnap, false);
		}

		// Token: 0x0602D9B8 RID: 186808 RVA: 0x0063D79D File Offset: 0x0063B99D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602D9B9 RID: 186809 RVA: 0x0063D7B0 File Offset: 0x0063B9B0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602D9BA RID: 186810 RVA: 0x0063D7E7 File Offset: 0x0063B9E7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D9BB RID: 186811 RVA: 0x0063D801 File Offset: 0x0063BA01
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602D9BC RID: 186812 RVA: 0x0063D81F File Offset: 0x0063BA1F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602D9BD RID: 186813 RVA: 0x0063D838 File Offset: 0x0063BA38
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602D9BE RID: 186814 RVA: 0x0063D843 File Offset: 0x0063BA43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D9BF RID: 186815 RVA: 0x0063D84E File Offset: 0x0063BA4E
		public static Offset<IAwakeEntity> EndIAwakeEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAwakeEntity>(builder.EndTable());
		}

		// Token: 0x0602D9C0 RID: 186816 RVA: 0x0063D85C File Offset: 0x0063BA5C
		public IAwakeEntityT UnPack()
		{
			IAwakeEntityT awakeEntityT = new IAwakeEntityT();
			this.UnPackTo(awakeEntityT);
			return awakeEntityT;
		}

		// Token: 0x0602D9C1 RID: 186817 RVA: 0x0063D878 File Offset: 0x0063BA78
		public void UnPackTo(IAwakeEntityT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.IsSnap = this.IsSnap;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D9C2 RID: 186818 RVA: 0x0063D8FC File Offset: 0x0063BAFC
		public static Offset<IAwakeEntity> Pack(FlatBufferBuilder builder, IAwakeEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakeEntity>);
			}
			Offset<IAwakeWithTransformVar> positionOffset = (_o.Position == null) ? default(Offset<IAwakeWithTransformVar>) : IAwakeWithTransformVar.Pack(builder, _o.Position);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAwakeEntity.CreateEntityIdsVector(builder, data);
			}
			return IAwakeEntity.CreateIAwakeEntity(builder, positionOffset, _o.IsSnap, entityIdsOffset, _o.NullMask);
		}

		// Token: 0x04011506 RID: 70918
		private Table __p;
	}
}
