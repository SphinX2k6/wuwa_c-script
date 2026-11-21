using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BE0 RID: 19424
	public struct IAreaEntities : IFlatbufferObject
	{
		// Token: 0x1700896F RID: 35183
		// (get) Token: 0x0601DA58 RID: 121432 RVA: 0x004292C5 File Offset: 0x004274C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA59 RID: 121433 RVA: 0x004292D2 File Offset: 0x004274D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA5A RID: 121434 RVA: 0x004292DC File Offset: 0x004274DC
		public static IAreaEntities GetRootAsIAreaEntities(ByteBuffer _bb)
		{
			return IAreaEntities.GetRootAsIAreaEntities(_bb, default(IAreaEntities));
		}

		// Token: 0x0601DA5B RID: 121435 RVA: 0x004292F8 File Offset: 0x004274F8
		public static IAreaEntities GetRootAsIAreaEntities(ByteBuffer _bb, IAreaEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA5C RID: 121436 RVA: 0x00429315 File Offset: 0x00427515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA5D RID: 121437 RVA: 0x00429324 File Offset: 0x00427524
		public IAreaEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008970 RID: 35184
		// (get) Token: 0x0601DA5E RID: 121438 RVA: 0x00429334 File Offset: 0x00427534
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

		// Token: 0x17008971 RID: 35185
		// (get) Token: 0x0601DA5F RID: 121439 RVA: 0x00429370 File Offset: 0x00427570
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

		// Token: 0x0601DA60 RID: 121440 RVA: 0x004293AC File Offset: 0x004275AC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008972 RID: 35186
		// (get) Token: 0x0601DA61 RID: 121441 RVA: 0x004293EC File Offset: 0x004275EC
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

		// Token: 0x0601DA62 RID: 121442 RVA: 0x00429417 File Offset: 0x00427617
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601DA63 RID: 121443 RVA: 0x00429426 File Offset: 0x00427626
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x0601DA64 RID: 121444 RVA: 0x00429434 File Offset: 0x00427634
		public static Offset<IAreaEntities> CreateIAreaEntities(FlatBufferBuilder builder, int LevelId = 0, int AreaId = 0, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IAreaEntities.AddEntityIds(builder, EntityIdsOffset);
			IAreaEntities.AddAreaId(builder, AreaId);
			IAreaEntities.AddLevelId(builder, LevelId);
			return IAreaEntities.EndIAreaEntities(builder);
		}

		// Token: 0x0601DA65 RID: 121445 RVA: 0x00429458 File Offset: 0x00427658
		public static void StartIAreaEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DA66 RID: 121446 RVA: 0x00429461 File Offset: 0x00427661
		public static void AddLevelId(FlatBufferBuilder builder, int levelId)
		{
			builder.AddInt(0, levelId, 0);
		}

		// Token: 0x0601DA67 RID: 121447 RVA: 0x0042946C File Offset: 0x0042766C
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0601DA68 RID: 121448 RVA: 0x00429477 File Offset: 0x00427677
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601DA69 RID: 121449 RVA: 0x00429488 File Offset: 0x00427688
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DA6A RID: 121450 RVA: 0x004294BF File Offset: 0x004276BF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA6B RID: 121451 RVA: 0x004294D9 File Offset: 0x004276D9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DA6C RID: 121452 RVA: 0x004294F7 File Offset: 0x004276F7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DA6D RID: 121453 RVA: 0x00429510 File Offset: 0x00427710
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DA6E RID: 121454 RVA: 0x0042951B File Offset: 0x0042771B
		public static Offset<IAreaEntities> EndIAreaEntities(FlatBufferBuilder builder)
		{
			return new Offset<IAreaEntities>(builder.EndTable());
		}

		// Token: 0x0601DA6F RID: 121455 RVA: 0x00429528 File Offset: 0x00427728
		public IAreaEntitiesT UnPack()
		{
			IAreaEntitiesT areaEntitiesT = new IAreaEntitiesT();
			this.UnPackTo(areaEntitiesT);
			return areaEntitiesT;
		}

		// Token: 0x0601DA70 RID: 121456 RVA: 0x00429544 File Offset: 0x00427744
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

		// Token: 0x0601DA71 RID: 121457 RVA: 0x00429598 File Offset: 0x00427798
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

		// Token: 0x0400D608 RID: 54792
		private Table __p;
	}
}
