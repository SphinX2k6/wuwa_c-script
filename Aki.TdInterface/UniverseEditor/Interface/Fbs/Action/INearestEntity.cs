using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DA RID: 29402
	public struct INearestEntity : IFlatbufferObject
	{
		// Token: 0x1700D796 RID: 55190
		// (get) Token: 0x06033429 RID: 209961 RVA: 0x006EA39D File Offset: 0x006E859D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603342A RID: 209962 RVA: 0x006EA3AA File Offset: 0x006E85AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603342B RID: 209963 RVA: 0x006EA3B4 File Offset: 0x006E85B4
		public static INearestEntity GetRootAsINearestEntity(ByteBuffer _bb)
		{
			return INearestEntity.GetRootAsINearestEntity(_bb, default(INearestEntity));
		}

		// Token: 0x0603342C RID: 209964 RVA: 0x006EA3D0 File Offset: 0x006E85D0
		public static INearestEntity GetRootAsINearestEntity(ByteBuffer _bb, INearestEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603342D RID: 209965 RVA: 0x006EA3ED File Offset: 0x006E85ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603342E RID: 209966 RVA: 0x006EA3FC File Offset: 0x006E85FC
		public INearestEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D797 RID: 55191
		// (get) Token: 0x0603342F RID: 209967 RVA: 0x006EA40C File Offset: 0x006E860C
		public ETeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportType.FixedPos;
				}
				return (ETeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033430 RID: 209968 RVA: 0x006EA448 File Offset: 0x006E8648
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D798 RID: 55192
		// (get) Token: 0x06033431 RID: 209969 RVA: 0x006EA488 File Offset: 0x006E8688
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

		// Token: 0x06033432 RID: 209970 RVA: 0x006EA4B3 File Offset: 0x006E86B3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06033433 RID: 209971 RVA: 0x006EA4C2 File Offset: 0x006E86C2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06033434 RID: 209972 RVA: 0x006EA4D0 File Offset: 0x006E86D0
		public static Offset<INearestEntity> CreateINearestEntity(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INearestEntity.AddEntityIds(builder, EntityIdsOffset);
			INearestEntity.AddType(builder, Type);
			return INearestEntity.EndINearestEntity(builder);
		}

		// Token: 0x06033435 RID: 209973 RVA: 0x006EA4ED File Offset: 0x006E86ED
		public static void StartINearestEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033436 RID: 209974 RVA: 0x006EA4F6 File Offset: 0x006E86F6
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033437 RID: 209975 RVA: 0x006EA501 File Offset: 0x006E8701
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06033438 RID: 209976 RVA: 0x006EA514 File Offset: 0x006E8714
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06033439 RID: 209977 RVA: 0x006EA54B File Offset: 0x006E874B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603343A RID: 209978 RVA: 0x006EA565 File Offset: 0x006E8765
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603343B RID: 209979 RVA: 0x006EA583 File Offset: 0x006E8783
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603343C RID: 209980 RVA: 0x006EA59C File Offset: 0x006E879C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603343D RID: 209981 RVA: 0x006EA5A7 File Offset: 0x006E87A7
		public static Offset<INearestEntity> EndINearestEntity(FlatBufferBuilder builder)
		{
			return new Offset<INearestEntity>(builder.EndTable());
		}

		// Token: 0x0603343E RID: 209982 RVA: 0x006EA5B4 File Offset: 0x006E87B4
		public INearestEntityT UnPack()
		{
			INearestEntityT nearestEntityT = new INearestEntityT();
			this.UnPackTo(nearestEntityT);
			return nearestEntityT;
		}

		// Token: 0x0603343F RID: 209983 RVA: 0x006EA5D0 File Offset: 0x006E87D0
		public void UnPackTo(INearestEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06033440 RID: 209984 RVA: 0x006EA618 File Offset: 0x006E8818
		public static Offset<INearestEntity> Pack(FlatBufferBuilder builder, INearestEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<INearestEntity>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = INearestEntity.CreateEntityIdsVector(builder, data);
			}
			return INearestEntity.CreateINearestEntity(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0401237E RID: 74622
		private Table __p;
	}
}
