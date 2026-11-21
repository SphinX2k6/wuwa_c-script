using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED2 RID: 20178
	public struct ICheckEntityPrefabPerformanceType : IFlatbufferObject
	{
		// Token: 0x17009012 RID: 36882
		// (get) Token: 0x0601F514 RID: 128276 RVA: 0x0045D620 File Offset: 0x0045B820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F515 RID: 128277 RVA: 0x0045D62D File Offset: 0x0045B82D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F516 RID: 128278 RVA: 0x0045D634 File Offset: 0x0045B834
		public static ICheckEntityPrefabPerformanceType GetRootAsICheckEntityPrefabPerformanceType(ByteBuffer _bb)
		{
			return ICheckEntityPrefabPerformanceType.GetRootAsICheckEntityPrefabPerformanceType(_bb, default(ICheckEntityPrefabPerformanceType));
		}

		// Token: 0x0601F517 RID: 128279 RVA: 0x0045D650 File Offset: 0x0045B850
		public static ICheckEntityPrefabPerformanceType GetRootAsICheckEntityPrefabPerformanceType(ByteBuffer _bb, ICheckEntityPrefabPerformanceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F518 RID: 128280 RVA: 0x0045D66D File Offset: 0x0045B86D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F519 RID: 128281 RVA: 0x0045D67C File Offset: 0x0045B87C
		public ICheckEntityPrefabPerformanceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009013 RID: 36883
		// (get) Token: 0x0601F51A RID: 128282 RVA: 0x0045D68C File Offset: 0x0045B88C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009014 RID: 36884
		// (get) Token: 0x0601F51B RID: 128283 RVA: 0x0045D6C8 File Offset: 0x0045B8C8
		public int EntityId
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

		// Token: 0x17009015 RID: 36885
		// (get) Token: 0x0601F51C RID: 128284 RVA: 0x0045D704 File Offset: 0x0045B904
		public string PerformanceTag
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F51D RID: 128285 RVA: 0x0045D73B File Offset: 0x0045B93B
		public Span<byte> GetPerformanceTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601F51E RID: 128286 RVA: 0x0045D74A File Offset: 0x0045B94A
		public byte[] GetPerformanceTagArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009016 RID: 36886
		// (get) Token: 0x0601F51F RID: 128287 RVA: 0x0045D758 File Offset: 0x0045B958
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F520 RID: 128288 RVA: 0x0045D795 File Offset: 0x0045B995
		public static Offset<ICheckEntityPrefabPerformanceType> CreateICheckEntityPrefabPerformanceType(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, StringOffset PerformanceTagOffset = default(StringOffset), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			ICheckEntityPrefabPerformanceType.AddPerformanceTag(builder, PerformanceTagOffset);
			ICheckEntityPrefabPerformanceType.AddEntityId(builder, EntityId);
			ICheckEntityPrefabPerformanceType.AddCompare(builder, Compare);
			ICheckEntityPrefabPerformanceType.AddType(builder, Type);
			return ICheckEntityPrefabPerformanceType.EndICheckEntityPrefabPerformanceType(builder);
		}

		// Token: 0x0601F521 RID: 128289 RVA: 0x0045D7C1 File Offset: 0x0045B9C1
		public static void StartICheckEntityPrefabPerformanceType(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F522 RID: 128290 RVA: 0x0045D7CA File Offset: 0x0045B9CA
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F523 RID: 128291 RVA: 0x0045D7D5 File Offset: 0x0045B9D5
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F524 RID: 128292 RVA: 0x0045D7E0 File Offset: 0x0045B9E0
		public static void AddPerformanceTag(FlatBufferBuilder builder, StringOffset performanceTagOffset)
		{
			builder.AddOffset(2, performanceTagOffset.Value, 0);
		}

		// Token: 0x0601F525 RID: 128293 RVA: 0x0045D7F0 File Offset: 0x0045B9F0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x0601F526 RID: 128294 RVA: 0x0045D7FB File Offset: 0x0045B9FB
		public static Offset<ICheckEntityPrefabPerformanceType> EndICheckEntityPrefabPerformanceType(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityPrefabPerformanceType>(builder.EndTable());
		}

		// Token: 0x0601F527 RID: 128295 RVA: 0x0045D808 File Offset: 0x0045BA08
		public ICheckEntityPrefabPerformanceTypeT UnPack()
		{
			ICheckEntityPrefabPerformanceTypeT checkEntityPrefabPerformanceTypeT = new ICheckEntityPrefabPerformanceTypeT();
			this.UnPackTo(checkEntityPrefabPerformanceTypeT);
			return checkEntityPrefabPerformanceTypeT;
		}

		// Token: 0x0601F528 RID: 128296 RVA: 0x0045D823 File Offset: 0x0045BA23
		public void UnPackTo(ICheckEntityPrefabPerformanceTypeT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.PerformanceTag = this.PerformanceTag;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601F529 RID: 128297 RVA: 0x0045D858 File Offset: 0x0045BA58
		public static Offset<ICheckEntityPrefabPerformanceType> Pack(FlatBufferBuilder builder, ICheckEntityPrefabPerformanceTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityPrefabPerformanceType>);
			}
			StringOffset performanceTagOffset = (_o.PerformanceTag == null) ? default(StringOffset) : builder.CreateString(_o.PerformanceTag);
			return ICheckEntityPrefabPerformanceType.CreateICheckEntityPrefabPerformanceType(builder, _o.Type, _o.EntityId, performanceTagOffset, _o.Compare);
		}

		// Token: 0x0400DD30 RID: 56624
		private Table __p;
	}
}
