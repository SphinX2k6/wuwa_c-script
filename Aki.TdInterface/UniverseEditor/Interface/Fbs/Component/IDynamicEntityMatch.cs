using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D8 RID: 20696
	public struct IDynamicEntityMatch : IFlatbufferObject
	{
		// Token: 0x1700969F RID: 38559
		// (get) Token: 0x060214C3 RID: 136387 RVA: 0x0049FCE2 File Offset: 0x0049DEE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060214C4 RID: 136388 RVA: 0x0049FCEF File Offset: 0x0049DEEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060214C5 RID: 136389 RVA: 0x0049FCF8 File Offset: 0x0049DEF8
		public static IDynamicEntityMatch GetRootAsIDynamicEntityMatch(ByteBuffer _bb)
		{
			return IDynamicEntityMatch.GetRootAsIDynamicEntityMatch(_bb, default(IDynamicEntityMatch));
		}

		// Token: 0x060214C6 RID: 136390 RVA: 0x0049FD14 File Offset: 0x0049DF14
		public static IDynamicEntityMatch GetRootAsIDynamicEntityMatch(ByteBuffer _bb, IDynamicEntityMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060214C7 RID: 136391 RVA: 0x0049FD31 File Offset: 0x0049DF31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060214C8 RID: 136392 RVA: 0x0049FD40 File Offset: 0x0049DF40
		public IDynamicEntityMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096A0 RID: 38560
		// (get) Token: 0x060214C9 RID: 136393 RVA: 0x0049FD50 File Offset: 0x0049DF50
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

		// Token: 0x170096A1 RID: 38561
		// (get) Token: 0x060214CA RID: 136394 RVA: 0x0049FDB0 File Offset: 0x0049DFB0
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

		// Token: 0x060214CB RID: 136395 RVA: 0x0049FDEC File Offset: 0x0049DFEC
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170096A2 RID: 38562
		// (get) Token: 0x060214CC RID: 136396 RVA: 0x0049FE2C File Offset: 0x0049E02C
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

		// Token: 0x060214CD RID: 136397 RVA: 0x0049FE57 File Offset: 0x0049E057
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060214CE RID: 136398 RVA: 0x0049FE66 File Offset: 0x0049E066
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x170096A3 RID: 38563
		// (get) Token: 0x060214CF RID: 136399 RVA: 0x0049FE74 File Offset: 0x0049E074
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

		// Token: 0x060214D0 RID: 136400 RVA: 0x0049FED4 File Offset: 0x0049E0D4
		public EEntityPropertyType HasProperty(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return EEntityPropertyType.Lock;
			}
			return (EEntityPropertyType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170096A4 RID: 38564
		// (get) Token: 0x060214D1 RID: 136401 RVA: 0x0049FF14 File Offset: 0x0049E114
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

		// Token: 0x060214D2 RID: 136402 RVA: 0x0049FF40 File Offset: 0x0049E140
		public Span<EEntityPropertyType> GetHasPropertyBytes()
		{
			return this.__p.__vector_as_span<EEntityPropertyType>(12, 1);
		}

		// Token: 0x060214D3 RID: 136403 RVA: 0x0049FF50 File Offset: 0x0049E150
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

		// Token: 0x060214D4 RID: 136404 RVA: 0x0049FFBC File Offset: 0x0049E1BC
		public EEntityPropertyType NoProperty(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return EEntityPropertyType.Lock;
			}
			return (EEntityPropertyType)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170096A5 RID: 38565
		// (get) Token: 0x060214D5 RID: 136405 RVA: 0x0049FFFC File Offset: 0x0049E1FC
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

		// Token: 0x060214D6 RID: 136406 RVA: 0x004A0028 File Offset: 0x0049E228
		public Span<EEntityPropertyType> GetNoPropertyBytes()
		{
			return this.__p.__vector_as_span<EEntityPropertyType>(14, 1);
		}

		// Token: 0x060214D7 RID: 136407 RVA: 0x004A0038 File Offset: 0x0049E238
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

		// Token: 0x170096A6 RID: 38566
		// (get) Token: 0x060214D8 RID: 136408 RVA: 0x004A00A4 File Offset: 0x0049E2A4
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

		// Token: 0x060214D9 RID: 136409 RVA: 0x004A00E4 File Offset: 0x0049E2E4
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

		// Token: 0x060214DA RID: 136410 RVA: 0x004A0133 File Offset: 0x0049E333
		public static void StartIDynamicEntityMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060214DB RID: 136411 RVA: 0x004A013C File Offset: 0x0049E33C
		public static void AddCategory(FlatBufferBuilder builder, Offset<IEntityCategory> categoryOffset)
		{
			builder.AddOffset(0, categoryOffset.Value, 0);
		}

		// Token: 0x060214DC RID: 136412 RVA: 0x004A014C File Offset: 0x0049E34C
		public static void AddCategoryType(FlatBufferBuilder builder, EEntityCategory categoryType)
		{
			builder.AddByte(1, (byte)categoryType, 0);
		}

		// Token: 0x060214DD RID: 136413 RVA: 0x004A0157 File Offset: 0x0049E357
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(2, entityIdsOffset.Value, 0);
		}

		// Token: 0x060214DE RID: 136414 RVA: 0x004A0168 File Offset: 0x0049E368
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060214DF RID: 136415 RVA: 0x004A019F File Offset: 0x0049E39F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E0 RID: 136416 RVA: 0x004A01B9 File Offset: 0x0049E3B9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E1 RID: 136417 RVA: 0x004A01D7 File Offset: 0x0049E3D7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060214E2 RID: 136418 RVA: 0x004A01F0 File Offset: 0x0049E3F0
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060214E3 RID: 136419 RVA: 0x004A01FB File Offset: 0x0049E3FB
		public static void AddState(FlatBufferBuilder builder, Offset<IEntityState> stateOffset)
		{
			builder.AddOffset(3, stateOffset.Value, 0);
		}

		// Token: 0x060214E4 RID: 136420 RVA: 0x004A020B File Offset: 0x0049E40B
		public static void AddHasProperty(FlatBufferBuilder builder, VectorOffset hasPropertyOffset)
		{
			builder.AddOffset(4, hasPropertyOffset.Value, 0);
		}

		// Token: 0x060214E5 RID: 136421 RVA: 0x004A021C File Offset: 0x0049E41C
		public static VectorOffset CreateHasPropertyVector(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060214E6 RID: 136422 RVA: 0x004A0253 File Offset: 0x0049E453
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E7 RID: 136423 RVA: 0x004A026D File Offset: 0x0049E46D
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityPropertyType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x060214E8 RID: 136424 RVA: 0x004A028B File Offset: 0x0049E48B
		public static VectorOffset CreateHasPropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityPropertyType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060214E9 RID: 136425 RVA: 0x004A02A4 File Offset: 0x0049E4A4
		public static void StartHasPropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060214EA RID: 136426 RVA: 0x004A02AF File Offset: 0x0049E4AF
		public static void AddNoProperty(FlatBufferBuilder builder, VectorOffset noPropertyOffset)
		{
			builder.AddOffset(5, noPropertyOffset.Value, 0);
		}

		// Token: 0x060214EB RID: 136427 RVA: 0x004A02C0 File Offset: 0x0049E4C0
		public static VectorOffset CreateNoPropertyVector(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060214EC RID: 136428 RVA: 0x004A02F7 File Offset: 0x0049E4F7
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, EEntityPropertyType[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x060214ED RID: 136429 RVA: 0x004A0311 File Offset: 0x0049E511
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, ArraySegment<EEntityPropertyType> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<EEntityPropertyType>(data);
			return builder.EndVector();
		}

		// Token: 0x060214EE RID: 136430 RVA: 0x004A032F File Offset: 0x0049E52F
		public static VectorOffset CreateNoPropertyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<EEntityPropertyType>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060214EF RID: 136431 RVA: 0x004A0348 File Offset: 0x0049E548
		public static void StartNoPropertyVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060214F0 RID: 136432 RVA: 0x004A0353 File Offset: 0x0049E553
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060214F1 RID: 136433 RVA: 0x004A035E File Offset: 0x0049E55E
		public static Offset<IDynamicEntityMatch> EndIDynamicEntityMatch(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicEntityMatch>(builder.EndTable());
		}

		// Token: 0x060214F2 RID: 136434 RVA: 0x004A036C File Offset: 0x0049E56C
		public IDynamicEntityMatchT UnPack()
		{
			IDynamicEntityMatchT dynamicEntityMatchT = new IDynamicEntityMatchT();
			this.UnPackTo(dynamicEntityMatchT);
			return dynamicEntityMatchT;
		}

		// Token: 0x060214F3 RID: 136435 RVA: 0x004A0388 File Offset: 0x0049E588
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

		// Token: 0x060214F4 RID: 136436 RVA: 0x004A04A0 File Offset: 0x0049E6A0
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

		// Token: 0x0400E120 RID: 57632
		private Table __p;
	}
}
