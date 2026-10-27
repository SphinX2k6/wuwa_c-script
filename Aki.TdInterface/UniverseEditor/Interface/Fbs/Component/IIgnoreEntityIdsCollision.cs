using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E3 RID: 21475
	public struct IIgnoreEntityIdsCollision : IFlatbufferObject
	{
		// Token: 0x17009E14 RID: 40468
		// (get) Token: 0x0602342D RID: 144429 RVA: 0x004E206B File Offset: 0x004E026B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602342E RID: 144430 RVA: 0x004E2078 File Offset: 0x004E0278
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602342F RID: 144431 RVA: 0x004E2080 File Offset: 0x004E0280
		public static IIgnoreEntityIdsCollision GetRootAsIIgnoreEntityIdsCollision(ByteBuffer _bb)
		{
			return IIgnoreEntityIdsCollision.GetRootAsIIgnoreEntityIdsCollision(_bb, default(IIgnoreEntityIdsCollision));
		}

		// Token: 0x06023430 RID: 144432 RVA: 0x004E209C File Offset: 0x004E029C
		public static IIgnoreEntityIdsCollision GetRootAsIIgnoreEntityIdsCollision(ByteBuffer _bb, IIgnoreEntityIdsCollision obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023431 RID: 144433 RVA: 0x004E20B9 File Offset: 0x004E02B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023432 RID: 144434 RVA: 0x004E20C8 File Offset: 0x004E02C8
		public IIgnoreEntityIdsCollision __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06023433 RID: 144435 RVA: 0x004E20D8 File Offset: 0x004E02D8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009E15 RID: 40469
		// (get) Token: 0x06023434 RID: 144436 RVA: 0x004E2118 File Offset: 0x004E0318
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

		// Token: 0x06023435 RID: 144437 RVA: 0x004E2143 File Offset: 0x004E0343
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06023436 RID: 144438 RVA: 0x004E2152 File Offset: 0x004E0352
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x06023437 RID: 144439 RVA: 0x004E2160 File Offset: 0x004E0360
		public static Offset<IIgnoreEntityIdsCollision> CreateIIgnoreEntityIdsCollision(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IIgnoreEntityIdsCollision.AddEntityIds(builder, EntityIdsOffset);
			return IIgnoreEntityIdsCollision.EndIIgnoreEntityIdsCollision(builder);
		}

		// Token: 0x06023438 RID: 144440 RVA: 0x004E2176 File Offset: 0x004E0376
		public static void StartIIgnoreEntityIdsCollision(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023439 RID: 144441 RVA: 0x004E217F File Offset: 0x004E037F
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602343A RID: 144442 RVA: 0x004E2190 File Offset: 0x004E0390
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602343B RID: 144443 RVA: 0x004E21C7 File Offset: 0x004E03C7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602343C RID: 144444 RVA: 0x004E21E1 File Offset: 0x004E03E1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602343D RID: 144445 RVA: 0x004E21FF File Offset: 0x004E03FF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602343E RID: 144446 RVA: 0x004E2218 File Offset: 0x004E0418
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602343F RID: 144447 RVA: 0x004E2223 File Offset: 0x004E0423
		public static Offset<IIgnoreEntityIdsCollision> EndIIgnoreEntityIdsCollision(FlatBufferBuilder builder)
		{
			return new Offset<IIgnoreEntityIdsCollision>(builder.EndTable());
		}

		// Token: 0x06023440 RID: 144448 RVA: 0x004E2230 File Offset: 0x004E0430
		public IIgnoreEntityIdsCollisionT UnPack()
		{
			IIgnoreEntityIdsCollisionT ignoreEntityIdsCollisionT = new IIgnoreEntityIdsCollisionT();
			this.UnPackTo(ignoreEntityIdsCollisionT);
			return ignoreEntityIdsCollisionT;
		}

		// Token: 0x06023441 RID: 144449 RVA: 0x004E224C File Offset: 0x004E044C
		public void UnPackTo(IIgnoreEntityIdsCollisionT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06023442 RID: 144450 RVA: 0x004E2288 File Offset: 0x004E0488
		public static Offset<IIgnoreEntityIdsCollision> Pack(FlatBufferBuilder builder, IIgnoreEntityIdsCollisionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IIgnoreEntityIdsCollision>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IIgnoreEntityIdsCollision.CreateEntityIdsVector(builder, data);
			}
			return IIgnoreEntityIdsCollision.CreateIIgnoreEntityIdsCollision(builder, entityIdsOffset);
		}

		// Token: 0x0400E626 RID: 58918
		private Table __p;
	}
}
