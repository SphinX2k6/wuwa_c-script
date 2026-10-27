using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B94 RID: 27540
	public struct INearestEntity : IFlatbufferObject
	{
		// Token: 0x1700CCB1 RID: 52401
		// (get) Token: 0x060305D1 RID: 198097 RVA: 0x00691D7D File Offset: 0x0068FF7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305D2 RID: 198098 RVA: 0x00691D8A File Offset: 0x0068FF8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305D3 RID: 198099 RVA: 0x00691D94 File Offset: 0x0068FF94
		public static INearestEntity GetRootAsINearestEntity(ByteBuffer _bb)
		{
			return INearestEntity.GetRootAsINearestEntity(_bb, default(INearestEntity));
		}

		// Token: 0x060305D4 RID: 198100 RVA: 0x00691DB0 File Offset: 0x0068FFB0
		public static INearestEntity GetRootAsINearestEntity(ByteBuffer _bb, INearestEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305D5 RID: 198101 RVA: 0x00691DCD File Offset: 0x0068FFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305D6 RID: 198102 RVA: 0x00691DDC File Offset: 0x0068FFDC
		public INearestEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CCB2 RID: 52402
		// (get) Token: 0x060305D7 RID: 198103 RVA: 0x00691DEC File Offset: 0x0068FFEC
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

		// Token: 0x060305D8 RID: 198104 RVA: 0x00691E28 File Offset: 0x00690028
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CCB3 RID: 52403
		// (get) Token: 0x060305D9 RID: 198105 RVA: 0x00691E68 File Offset: 0x00690068
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

		// Token: 0x060305DA RID: 198106 RVA: 0x00691E93 File Offset: 0x00690093
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060305DB RID: 198107 RVA: 0x00691EA2 File Offset: 0x006900A2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060305DC RID: 198108 RVA: 0x00691EB0 File Offset: 0x006900B0
		public static Offset<INearestEntity> CreateINearestEntity(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			INearestEntity.AddEntityIds(builder, EntityIdsOffset);
			INearestEntity.AddType(builder, Type);
			return INearestEntity.EndINearestEntity(builder);
		}

		// Token: 0x060305DD RID: 198109 RVA: 0x00691ECD File Offset: 0x006900CD
		public static void StartINearestEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060305DE RID: 198110 RVA: 0x00691ED6 File Offset: 0x006900D6
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060305DF RID: 198111 RVA: 0x00691EE1 File Offset: 0x006900E1
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x060305E0 RID: 198112 RVA: 0x00691EF4 File Offset: 0x006900F4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060305E1 RID: 198113 RVA: 0x00691F2B File Offset: 0x0069012B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060305E2 RID: 198114 RVA: 0x00691F45 File Offset: 0x00690145
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060305E3 RID: 198115 RVA: 0x00691F63 File Offset: 0x00690163
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060305E4 RID: 198116 RVA: 0x00691F7C File Offset: 0x0069017C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060305E5 RID: 198117 RVA: 0x00691F87 File Offset: 0x00690187
		public static Offset<INearestEntity> EndINearestEntity(FlatBufferBuilder builder)
		{
			return new Offset<INearestEntity>(builder.EndTable());
		}

		// Token: 0x060305E6 RID: 198118 RVA: 0x00691F94 File Offset: 0x00690194
		public INearestEntityT UnPack()
		{
			INearestEntityT nearestEntityT = new INearestEntityT();
			this.UnPackTo(nearestEntityT);
			return nearestEntityT;
		}

		// Token: 0x060305E7 RID: 198119 RVA: 0x00691FB0 File Offset: 0x006901B0
		public void UnPackTo(INearestEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x060305E8 RID: 198120 RVA: 0x00691FF8 File Offset: 0x006901F8
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

		// Token: 0x04011455 RID: 70741
		private Table __p;
	}
}
