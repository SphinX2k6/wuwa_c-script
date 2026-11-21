using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563D RID: 22077
	public struct IDynamicEntityMatch : IFlatbufferObject
	{
		// Token: 0x17009E8C RID: 40588
		// (get) Token: 0x06023417 RID: 144407 RVA: 0x004D9C6E File Offset: 0x004D7E6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023418 RID: 144408 RVA: 0x004D9C7B File Offset: 0x004D7E7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023419 RID: 144409 RVA: 0x004D9C84 File Offset: 0x004D7E84
		public static IDynamicEntityMatch GetRootAsIDynamicEntityMatch(ByteBuffer _bb)
		{
			return IDynamicEntityMatch.GetRootAsIDynamicEntityMatch(_bb, default(IDynamicEntityMatch));
		}

		// Token: 0x0602341A RID: 144410 RVA: 0x004D9CA0 File Offset: 0x004D7EA0
		public static IDynamicEntityMatch GetRootAsIDynamicEntityMatch(ByteBuffer _bb, IDynamicEntityMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602341B RID: 144411 RVA: 0x004D9CBD File Offset: 0x004D7EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602341C RID: 144412 RVA: 0x004D9CCC File Offset: 0x004D7ECC
		public IDynamicEntityMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E8D RID: 40589
		// (get) Token: 0x0602341D RID: 144413 RVA: 0x004D9CDC File Offset: 0x004D7EDC
		public IEntityCategory? Category
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009E8E RID: 40590
		// (get) Token: 0x0602341E RID: 144414 RVA: 0x004D9D3C File Offset: 0x004D7F3C
		public EEntityCategory CategoryType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEntityCategory.MonsterMatchType;
				}
				return (EEntityCategory)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602341F RID: 144415 RVA: 0x004D9D78 File Offset: 0x004D7F78
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009E8F RID: 40591
		// (get) Token: 0x06023420 RID: 144416 RVA: 0x004D9DB8 File Offset: 0x004D7FB8
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

		// Token: 0x06023421 RID: 144417 RVA: 0x004D9DE3 File Offset: 0x004D7FE3
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06023422 RID: 144418 RVA: 0x004D9DF2 File Offset: 0x004D7FF2
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17009E90 RID: 40592
		// (get) Token: 0x06023423 RID: 144419 RVA: 0x004D9E00 File Offset: 0x004D8000
		public IEntityState? State
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06023424 RID: 144420 RVA: 0x004D9E60 File Offset: 0x004D8060
		public EEntityPropertyType HasProperty(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return EEntityPropertyType.Lock;
			}
			return (EEntityPropertyType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009E91 RID: 40593
		// (get) Token: 0x06023425 RID: 144421 RVA: 0x004D9EA0 File Offset: 0x004D80A0
		public int HasPropertyLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023426 RID: 144422 RVA: 0x004D9ECC File Offset: 0x004D80CC
		public Span<EEntityPropertyType> GetHasPropertyBytes()
		{
			return this.__p.__vector_as_span<EEntityPropertyType>(12, 1);
		}

		// Token: 0x06023427 RID: 144423 RVA: 0x004D9EDC File Offset: 0x004D80DC
		public EEntityPropertyType[] GetHasPropertyArray()
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EEntityPropertyType[] array = new EEntityPropertyType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EEntityPropertyType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06023428 RID: 144424 RVA: 0x004D9F48 File Offset: 0x004D8148
		public EEntityPropertyType NoProperty(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return EEntityPropertyType.Lock;
			}
			return (EEntityPropertyType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009E92 RID: 40594
		// (get) Token: 0x06023429 RID: 144425 RVA: 0x004D9F88 File Offset: 0x004D8188
		public int NoPropertyLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602342A RID: 144426 RVA: 0x004D9FB4 File Offset: 0x004D81B4
		public Span<EEntityPropertyType> GetNoPropertyBytes()
		{
			return this.__p.__vector_as_span<EEntityPropertyType>(14, 1);
		}

		// Token: 0x0602342B RID: 144427 RVA: 0x004D9FC4 File Offset: 0x004D81C4
		public EEntityPropertyType[] GetNoPropertyArray()
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			EEntityPropertyType[] array = new EEntityPropertyType[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (EEntityPropertyType)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x17009E93 RID: 40595
		// (get) Token: 0x0602342C RID: 144428 RVA: 0x004DA030 File Offset: 0x004D8230
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602342D RID: 144429 RVA: 0x004DA070 File Offset: 0x004D8270
		public static Offset<IDynamicEntityMatch> CreateIDynamicEntityMatch(FlatBufferBuilder builder, Offset<IEntityCategory> CategoryOffset = default(Offset<IEntityCategory>), EEntityCategory CategoryType = EEntityCategory.MonsterMatchType, VectorOffset EntityIdsOffset = default(VectorOffset), Offset<IEntityState> StateOffset = default(Offset<IEntityState>), VectorOffset HasPropertyOffset = default(VectorOffset), VectorOffset NoPropertyOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IDynamicEntityMatch.AddNoProperty(builder, NoPropertyOffset);
			IDynamicEntityMatch.AddHasProperty(builder, HasPropertyOffset);
			IDynamicEntityMatch.AddState(builder, StateOffset);
			IDynamicEntityMatch.AddEntityIds(builder, EntityIdsOffset);
			IDynamicEntityMatch.AddCategory(builder, CategoryOffset);
			IDynamicEntityMatch.AddNullMask(builder, NullMask);
			IDynamicEntityMatch.AddCategoryType(builder, CategoryType);
			return IDynamicEntityMatch.EndIDynamicEntityMatch(builder);
		}

		// Token: 0x0602342E RID: 144430 RVA: 0x004DA0BF File Offset: 0x004D82BF
		public static void StartIDynamicEntityMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602342F RID: 144431 RVA: 0x004DA0C8 File Offset: 0x004D82C8
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x06023430 RID: 144432 RVA: 0x004DA0D8 File Offset: 0x004D82D8
		public static void AddCategoryType(FlatBufferBuilder builder, EEntityCategory categoryType)
		{
			builder.AddByte(1, (byte)categoryType, 0);
		}

		// Token: 0x06023431 RID: 144433 RVA: 0x004DA0E3 File Offset: 0x004D82E3
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x06023432 RID: 144434 RVA: 0x004DA0F4 File Offset: 0x004D82F4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023433 RID: 144435 RVA: 0x004DA12B File Offset: 0x004D832B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023434 RID: 144436 RVA: 0x004DA145 File Offset: 0x004D8345
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023435 RID: 144437 RVA: 0x004DA163 File Offset: 0x004D8363
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023436 RID: 144438 RVA: 0x004DA17C File Offset: 0x004D837C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023437 RID: 144439 RVA: 0x004DA187 File Offset: 0x004D8387
		public static void AddState(FlatBufferBuilder builder, Offset<IEntityState> stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x06023438 RID: 144440 RVA: 0x004DA197 File Offset: 0x004D8397
		public static void AddHasProperty(FlatBufferBuilder builder, VectorOffset hasPropertyOffset)
		{
			builder.AddOffset(4, hasPropertyOffset.Value, 0);
		}

		// Token: 0x06023439 RID: 144441 RVA: 0x004DA1A8 File Offset: 0x004D83A8
		public static VectorOffset CreateHasPropertyVector(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602343A RID: 144442 RVA: 0x004DA1DF File Offset: 0x004D83DF
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602343B RID: 144443 RVA: 0x004DA1F9 File Offset: 0x004D83F9
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityPropertyType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x0602343C RID: 144444 RVA: 0x004DA217 File Offset: 0x004D8417
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityPropertyType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602343D RID: 144445 RVA: 0x004DA230 File Offset: 0x004D8430
		public static void StartHasPropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602343E RID: 144446 RVA: 0x004DA23B File Offset: 0x004D843B
		public static void AddNoProperty(FlatBufferBuilder builder, VectorOffset noPropertyOffset)
		{
			builder.AddOffset(5, noPropertyOffset.Value, 0);
		}

		// Token: 0x0602343F RID: 144447 RVA: 0x004DA24C File Offset: 0x004D844C
		public static VectorOffset CreateNoPropertyVector(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023440 RID: 144448 RVA: 0x004DA283 File Offset: 0x004D8483
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x06023441 RID: 144449 RVA: 0x004DA29D File Offset: 0x004D849D
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityPropertyType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x06023442 RID: 144450 RVA: 0x004DA2BB File Offset: 0x004D84BB
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityPropertyType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023443 RID: 144451 RVA: 0x004DA2D4 File Offset: 0x004D84D4
		public static void StartNoPropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06023444 RID: 144452 RVA: 0x004DA2DF File Offset: 0x004D84DF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023445 RID: 144453 RVA: 0x004DA2EA File Offset: 0x004D84EA
		public static Offset<IDynamicEntityMatch> EndIDynamicEntityMatch(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityMatch>(builder.EndTable());
		}

		// Token: 0x06023446 RID: 144454 RVA: 0x004DA2F8 File Offset: 0x004D84F8
		public IDynamicEntityMatchT UnPack()
		{
			IDynamicEntityMatchT dynamicEntityMatchT = new IDynamicEntityMatchT();
			this.UnPackTo(dynamicEntityMatchT);
			return dynamicEntityMatchT;
		}

		// Token: 0x06023447 RID: 144455 RVA: 0x004DA314 File Offset: 0x004D8514
		public void UnPackTo(IDynamicEntityMatchT _o)
		{
			_o.Category = ((this.Category != null) ? this.Category.Value.UnPack() : null);
			_o.CategoryType = this.CategoryType;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.State = ((this.State != null) ? this.State.Value.UnPack() : null);
			_o.HasProperty = new List<EEntityPropertyType>();
			for (int j = 0; j < this.HasPropertyLength; j++)
			{
				_o.HasProperty.Add(this.HasProperty(j));
			}
			_o.NoProperty = new List<EEntityPropertyType>();
			for (int k = 0; k < this.NoPropertyLength; k++)
			{
				_o.NoProperty.Add(this.NoProperty(k));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023448 RID: 144456 RVA: 0x004DA42C File Offset: 0x004D862C
		public static Offset<IDynamicEntityMatch> Pack(FlatBufferBuilder builder, IDynamicEntityMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicEntityMatch>);
			}
			Offset<IEntityCategory> categoryOffset = (_o.Category == null) ? default(Offset<IEntityCategory>) : IEntityCategory.Pack(builder, _o.Category);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IDynamicEntityMatch.CreateEntityIdsVector(builder, data);
			}
			Offset<IEntityState> stateOffset = (_o.State == null) ? default(Offset<IEntityState>) : IEntityState.Pack(builder, _o.State);
			VectorOffset hasPropertyOffset = default(VectorOffset);
			if (_o.HasProperty != null)
			{
				EEntityPropertyType[] data2 = _o.HasProperty.ToArray();
				hasPropertyOffset = IDynamicEntityMatch.CreateHasPropertyVector(builder, data2);
			}
			VectorOffset noPropertyOffset = default(VectorOffset);
			if (_o.NoProperty != null)
			{
				EEntityPropertyType[] data3 = _o.NoProperty.ToArray();
				noPropertyOffset = IDynamicEntityMatch.CreateNoPropertyVector(builder, data3);
			}
			return IDynamicEntityMatch.CreateIDynamicEntityMatch(builder, categoryOffset, _o.CategoryType, entityIdsOffset, stateOffset, hasPropertyOffset, noPropertyOffset, _o.NullMask);
		}

		// Token: 0x0400ED1D RID: 60701
		private Table __p;
	}
}
