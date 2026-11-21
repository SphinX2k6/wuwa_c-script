using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CBB RID: 19643
	public struct IDisableEntities : IFlatbufferObject
	{
		// Token: 0x17008B43 RID: 35651
		// (get) Token: 0x0601E285 RID: 123525 RVA: 0x00439C7F File Offset: 0x00437E7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E286 RID: 123526 RVA: 0x00439C8C File Offset: 0x00437E8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E287 RID: 123527 RVA: 0x00439C94 File Offset: 0x00437E94
		public static IDisableEntities GetRootAsIDisableEntities(ByteBuffer _bb)
		{
			return IDisableEntities.GetRootAsIDisableEntities(_bb, default(IDisableEntities));
		}

		// Token: 0x0601E288 RID: 123528 RVA: 0x00439CB0 File Offset: 0x00437EB0
		public static IDisableEntities GetRootAsIDisableEntities(ByteBuffer _bb, IDisableEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E289 RID: 123529 RVA: 0x00439CCD File Offset: 0x00437ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E28A RID: 123530 RVA: 0x00439CDC File Offset: 0x00437EDC
		public IDisableEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B44 RID: 35652
		// (get) Token: 0x0601E28B RID: 123531 RVA: 0x00439CEC File Offset: 0x00437EEC
		public bool IsDisabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E28C RID: 123532 RVA: 0x00439D2C File Offset: 0x00437F2C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008B45 RID: 35653
		// (get) Token: 0x0601E28D RID: 123533 RVA: 0x00439D6C File Offset: 0x00437F6C
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

		// Token: 0x0601E28E RID: 123534 RVA: 0x00439D97 File Offset: 0x00437F97
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601E28F RID: 123535 RVA: 0x00439DA6 File Offset: 0x00437FA6
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601E290 RID: 123536 RVA: 0x00439DB4 File Offset: 0x00437FB4
		public static Offset<IDisableEntities> CreateIDisableEntities(FlatBufferBuilder builder, bool IsDisabled = false, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IDisableEntities.AddEntityIds(builder, EntityIdsOffset);
			IDisableEntities.AddIsDisabled(builder, IsDisabled);
			return IDisableEntities.EndIDisableEntities(builder);
		}

		// Token: 0x0601E291 RID: 123537 RVA: 0x00439DD1 File Offset: 0x00437FD1
		public static void StartIDisableEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E292 RID: 123538 RVA: 0x00439DDA File Offset: 0x00437FDA
		public static void AddIsDisabled(FlatBufferBuilder builder, bool isDisabled)
		{
			builder.AddBool(0, isDisabled, false);
		}

		// Token: 0x0601E293 RID: 123539 RVA: 0x00439DE5 File Offset: 0x00437FE5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601E294 RID: 123540 RVA: 0x00439DF8 File Offset: 0x00437FF8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E295 RID: 123541 RVA: 0x00439E2F File Offset: 0x0043802F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E296 RID: 123542 RVA: 0x00439E49 File Offset: 0x00438049
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E297 RID: 123543 RVA: 0x00439E67 File Offset: 0x00438067
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E298 RID: 123544 RVA: 0x00439E80 File Offset: 0x00438080
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E299 RID: 123545 RVA: 0x00439E8B File Offset: 0x0043808B
		public static Offset<IDisableEntities> EndIDisableEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDisableEntities>(builder.EndTable());
		}

		// Token: 0x0601E29A RID: 123546 RVA: 0x00439E98 File Offset: 0x00438098
		public IDisableEntitiesT UnPack()
		{
			IDisableEntitiesT disableEntitiesT = new IDisableEntitiesT();
			this.UnPackTo(disableEntitiesT);
			return disableEntitiesT;
		}

		// Token: 0x0601E29B RID: 123547 RVA: 0x00439EB4 File Offset: 0x004380B4
		public void UnPackTo(IDisableEntitiesT _o)
		{
			_o.IsDisabled = this.IsDisabled;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601E29C RID: 123548 RVA: 0x00439EFC File Offset: 0x004380FC
		public static Offset<IDisableEntities> Pack(FlatBufferBuilder builder, IDisableEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDisableEntities.CreateEntityIdsVector(builder, data);
			}
			return IDisableEntities.CreateIDisableEntities(builder, _o.IsDisabled, entityIdsOffset);
		}

		// Token: 0x0400D7C9 RID: 55241
		private Table __p;
	}
}
