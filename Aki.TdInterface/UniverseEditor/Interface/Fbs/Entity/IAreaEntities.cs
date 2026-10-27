using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004778 RID: 18296
	public struct IAreaEntities : IFlatbufferObject
	{
		// Token: 0x1700832E RID: 33582
		// (get) Token: 0x0601C283 RID: 115331 RVA: 0x003FD029 File Offset: 0x003FB229
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C284 RID: 115332 RVA: 0x003FD036 File Offset: 0x003FB236
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C285 RID: 115333 RVA: 0x003FD040 File Offset: 0x003FB240
		public static IAreaEntities GetRootAsIAreaEntities(ByteBuffer _bb)
		{
			return IAreaEntities.GetRootAsIAreaEntities(_bb, default(IAreaEntities));
		}

		// Token: 0x0601C286 RID: 115334 RVA: 0x003FD05C File Offset: 0x003FB25C
		public static IAreaEntities GetRootAsIAreaEntities(ByteBuffer _bb, IAreaEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C287 RID: 115335 RVA: 0x003FD079 File Offset: 0x003FB279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C288 RID: 115336 RVA: 0x003FD088 File Offset: 0x003FB288
		public IAreaEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700832F RID: 33583
		// (get) Token: 0x0601C289 RID: 115337 RVA: 0x003FD098 File Offset: 0x003FB298
		public int LevelId
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

		// Token: 0x17008330 RID: 33584
		// (get) Token: 0x0601C28A RID: 115338 RVA: 0x003FD0D4 File Offset: 0x003FB2D4
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C28B RID: 115339 RVA: 0x003FD110 File Offset: 0x003FB310
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008331 RID: 33585
		// (get) Token: 0x0601C28C RID: 115340 RVA: 0x003FD150 File Offset: 0x003FB350
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

		// Token: 0x0601C28D RID: 115341 RVA: 0x003FD17B File Offset: 0x003FB37B
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601C28E RID: 115342 RVA: 0x003FD18A File Offset: 0x003FB38A
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601C28F RID: 115343 RVA: 0x003FD198 File Offset: 0x003FB398
		public static Offset<IAreaEntities> CreateIAreaEntities(FlatBufferBuilder builder, int LevelId = 0, int AreaId = 0, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IAreaEntities.AddEntityIds(builder, EntityIdsOffset);
			IAreaEntities.AddAreaId(builder, AreaId);
			IAreaEntities.AddLevelId(builder, LevelId);
			return IAreaEntities.EndIAreaEntities(builder);
		}

		// Token: 0x0601C290 RID: 115344 RVA: 0x003FD1BC File Offset: 0x003FB3BC
		public static void StartIAreaEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C291 RID: 115345 RVA: 0x003FD1C5 File Offset: 0x003FB3C5
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601C292 RID: 115346 RVA: 0x003FD1D0 File Offset: 0x003FB3D0
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601C293 RID: 115347 RVA: 0x003FD1DB File Offset: 0x003FB3DB
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601C294 RID: 115348 RVA: 0x003FD1EC File Offset: 0x003FB3EC
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C295 RID: 115349 RVA: 0x003FD223 File Offset: 0x003FB423
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C296 RID: 115350 RVA: 0x003FD23D File Offset: 0x003FB43D
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C297 RID: 115351 RVA: 0x003FD25B File Offset: 0x003FB45B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C298 RID: 115352 RVA: 0x003FD274 File Offset: 0x003FB474
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C299 RID: 115353 RVA: 0x003FD27F File Offset: 0x003FB47F
		public static Offset<IAreaEntities> EndIAreaEntities(FlatBufferBuilder builder)
		{
			return new Offset<IAreaEntities>(builder.EndTable());
		}

		// Token: 0x0601C29A RID: 115354 RVA: 0x003FD28C File Offset: 0x003FB48C
		public IAreaEntitiesT UnPack()
		{
			IAreaEntitiesT areaEntitiesT = new IAreaEntitiesT();
			this.UnPackTo(areaEntitiesT);
			return areaEntitiesT;
		}

		// Token: 0x0601C29B RID: 115355 RVA: 0x003FD2A8 File Offset: 0x003FB4A8
		public void UnPackTo(IAreaEntitiesT _o)
		{
			_o.LevelId = this.LevelId;
			_o.AreaId = this.AreaId;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601C29C RID: 115356 RVA: 0x003FD2FC File Offset: 0x003FB4FC
		public static Offset<IAreaEntities> Pack(FlatBufferBuilder builder, IAreaEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAreaEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAreaEntities.CreateEntityIdsVector(builder, data);
			}
			return IAreaEntities.CreateIAreaEntities(builder, _o.LevelId, _o.AreaId, entityIdsOffset);
		}

		// Token: 0x0400CBD2 RID: 52178
		private Table __p;
	}
}
