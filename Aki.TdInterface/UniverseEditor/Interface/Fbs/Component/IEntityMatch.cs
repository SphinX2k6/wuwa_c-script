using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F4 RID: 22260
	public struct IEntityMatch : IFlatbufferObject
	{
		// Token: 0x1700A076 RID: 41078
		// (get) Token: 0x06023B91 RID: 146321 RVA: 0x004E92FA File Offset: 0x004E74FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023B92 RID: 146322 RVA: 0x004E9307 File Offset: 0x004E7507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023B93 RID: 146323 RVA: 0x004E9310 File Offset: 0x004E7510
		public static IEntityMatch GetRootAsIEntityMatch(ByteBuffer _bb)
		{
			return IEntityMatch.GetRootAsIEntityMatch(_bb, default(IEntityMatch));
		}

		// Token: 0x06023B94 RID: 146324 RVA: 0x004E932C File Offset: 0x004E752C
		public static IEntityMatch GetRootAsIEntityMatch(ByteBuffer _bb, IEntityMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023B95 RID: 146325 RVA: 0x004E9349 File Offset: 0x004E7549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023B96 RID: 146326 RVA: 0x004E9358 File Offset: 0x004E7558
		public IEntityMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A077 RID: 41079
		// (get) Token: 0x06023B97 RID: 146327 RVA: 0x004E9368 File Offset: 0x004E7568
		public bool AllCharacter
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A078 RID: 41080
		// (get) Token: 0x06023B98 RID: 146328 RVA: 0x004E93A8 File Offset: 0x004E75A8
		public bool OnlyPlayer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023B99 RID: 146329 RVA: 0x004E93E8 File Offset: 0x004E75E8
		public IEntityCategory? Categories(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A079 RID: 41081
		// (get) Token: 0x06023B9A RID: 146330 RVA: 0x004E9448 File Offset: 0x004E7648
		public int CategoriesLength
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

		// Token: 0x06023B9B RID: 146331 RVA: 0x004E9474 File Offset: 0x004E7674
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A07A RID: 41082
		// (get) Token: 0x06023B9C RID: 146332 RVA: 0x004E94B4 File Offset: 0x004E76B4
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06023B9D RID: 146333 RVA: 0x004E94E0 File Offset: 0x004E76E0
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06023B9E RID: 146334 RVA: 0x004E94F0 File Offset: 0x004E76F0
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06023B9F RID: 146335 RVA: 0x004E9500 File Offset: 0x004E7700
		public IEntityState? States(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A07B RID: 41083
		// (get) Token: 0x06023BA0 RID: 146336 RVA: 0x004E9564 File Offset: 0x004E7764
		public int StatesLength
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

		// Token: 0x06023BA1 RID: 146337 RVA: 0x004E9590 File Offset: 0x004E7790
		public string PerformanceStates(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A07C RID: 41084
		// (get) Token: 0x06023BA2 RID: 146338 RVA: 0x004E95CC File Offset: 0x004E77CC
		public int PerformanceStatesLength
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

		// Token: 0x1700A07D RID: 41085
		// (get) Token: 0x06023BA3 RID: 146339 RVA: 0x004E95F8 File Offset: 0x004E77F8
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

		// Token: 0x06023BA4 RID: 146340 RVA: 0x004E9638 File Offset: 0x004E7838
		public static Offset<IEntityMatch> CreateIEntityMatch(FlatBufferBuilder builder, bool AllCharacter = false, bool OnlyPlayer = false, VectorOffset CategoriesOffset = default(VectorOffset), VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset StatesOffset = default(VectorOffset), VectorOffset PerformanceStatesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IEntityMatch.AddPerformanceStates(builder, PerformanceStatesOffset);
			IEntityMatch.AddStates(builder, StatesOffset);
			IEntityMatch.AddEntityIds(builder, EntityIdsOffset);
			IEntityMatch.AddCategories(builder, CategoriesOffset);
			IEntityMatch.AddNullMask(builder, NullMask);
			IEntityMatch.AddOnlyPlayer(builder, OnlyPlayer);
			IEntityMatch.AddAllCharacter(builder, AllCharacter);
			return IEntityMatch.EndIEntityMatch(builder);
		}

		// Token: 0x06023BA5 RID: 146341 RVA: 0x004E9687 File Offset: 0x004E7887
		public static void StartIEntityMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06023BA6 RID: 146342 RVA: 0x004E9690 File Offset: 0x004E7890
		public static void AddAllCharacter(FlatBufferBuilder builder, bool allCharacter)
		{
			builder.AddBool(0, allCharacter, false);
		}

		// Token: 0x06023BA7 RID: 146343 RVA: 0x004E969B File Offset: 0x004E789B
		public static void AddOnlyPlayer(FlatBufferBuilder builder, bool onlyPlayer)
		{
			builder.AddBool(1, onlyPlayer, false);
		}

		// Token: 0x06023BA8 RID: 146344 RVA: 0x004E96A6 File Offset: 0x004E78A6
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
			builder.AddOffset(2, categoriesOffset.Value, 0);
		}

		// Token: 0x06023BA9 RID: 146345 RVA: 0x004E96B8 File Offset: 0x004E78B8
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BAA RID: 146346 RVA: 0x004E96F8 File Offset: 0x004E78F8
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BAB RID: 146347 RVA: 0x004E9712 File Offset: 0x004E7912
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BAC RID: 146348 RVA: 0x004E9730 File Offset: 0x004E7930
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BAD RID: 146349 RVA: 0x004E9749 File Offset: 0x004E7949
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BAE RID: 146350 RVA: 0x004E9754 File Offset: 0x004E7954
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06023BAF RID: 146351 RVA: 0x004E9764 File Offset: 0x004E7964
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BB0 RID: 146352 RVA: 0x004E979B File Offset: 0x004E799B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BB1 RID: 146353 RVA: 0x004E97B5 File Offset: 0x004E79B5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BB2 RID: 146354 RVA: 0x004E97D3 File Offset: 0x004E79D3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BB3 RID: 146355 RVA: 0x004E97EC File Offset: 0x004E79EC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BB4 RID: 146356 RVA: 0x004E97F7 File Offset: 0x004E79F7
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(4, statesOffset.Value, 0);
		}

		// Token: 0x06023BB5 RID: 146357 RVA: 0x004E9808 File Offset: 0x004E7A08
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BB6 RID: 146358 RVA: 0x004E9848 File Offset: 0x004E7A48
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BB7 RID: 146359 RVA: 0x004E9862 File Offset: 0x004E7A62
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BB8 RID: 146360 RVA: 0x004E9880 File Offset: 0x004E7A80
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BB9 RID: 146361 RVA: 0x004E9899 File Offset: 0x004E7A99
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BBA RID: 146362 RVA: 0x004E98A4 File Offset: 0x004E7AA4
		public static void AddPerformanceStates(FlatBufferBuilder builder, VectorOffset performanceStatesOffset)
		{
			builder.AddOffset(5, performanceStatesOffset.Value, 0);
		}

		// Token: 0x06023BBB RID: 146363 RVA: 0x004E98B4 File Offset: 0x004E7AB4
		public static VectorOffset CreatePerformanceStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023BBC RID: 146364 RVA: 0x004E98F4 File Offset: 0x004E7AF4
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BBD RID: 146365 RVA: 0x004E990E File Offset: 0x004E7B0E
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06023BBE RID: 146366 RVA: 0x004E992C File Offset: 0x004E7B2C
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023BBF RID: 146367 RVA: 0x004E9945 File Offset: 0x004E7B45
		public static void StartPerformanceStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023BC0 RID: 146368 RVA: 0x004E9950 File Offset: 0x004E7B50
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06023BC1 RID: 146369 RVA: 0x004E995B File Offset: 0x004E7B5B
		public static Offset<IEntityMatch> EndIEntityMatch(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatch>(builder.EndTable());
		}

		// Token: 0x06023BC2 RID: 146370 RVA: 0x004E9968 File Offset: 0x004E7B68
		public IEntityMatchT UnPack()
		{
			IEntityMatchT entityMatchT = new IEntityMatchT();
			this.UnPackTo(entityMatchT);
			return entityMatchT;
		}

		// Token: 0x06023BC3 RID: 146371 RVA: 0x004E9984 File Offset: 0x004E7B84
		public void UnPackTo(IEntityMatchT _o)
		{
			_o.AllCharacter = this.AllCharacter;
			_o.OnlyPlayer = this.OnlyPlayer;
			_o.Categories = new List<IEntityCategoryT>();
			for (int i = 0; i < this.CategoriesLength; i++)
			{
				_o.Categories.Add((this.Categories(i) != null) ? this.Categories(i).Value.UnPack() : null);
			}
			_o.EntityIds = new List<int>();
			for (int j = 0; j < this.EntityIdsLength; j++)
			{
				_o.EntityIds.Add(this.EntityIds(j));
			}
			_o.States = new List<IEntityStateT>();
			for (int k = 0; k < this.StatesLength; k++)
			{
				_o.States.Add((this.States(k) != null) ? this.States(k).Value.UnPack() : null);
			}
			_o.PerformanceStates = new List<string>();
			for (int l = 0; l < this.PerformanceStatesLength; l++)
			{
				_o.PerformanceStates.Add(this.PerformanceStates(l));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023BC4 RID: 146372 RVA: 0x004E9AC4 File Offset: 0x004E7CC4
		public static Offset<IEntityMatch> Pack(FlatBufferBuilder builder, IEntityMatchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityMatch>);
			}
			VectorOffset categoriesOffset = default(VectorOffset);
			if (_o.Categories != null)
			{
				Offset<IEntityCategory>[] array = new Offset<IEntityCategory>[_o.Categories.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityCategory.Pack(builder, _o.Categories[i]);
				}
				categoriesOffset = IEntityMatch.CreateCategoriesVector(builder, array);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEntityMatch.CreateEntityIdsVector(builder, data);
			}
			VectorOffset statesOffset = default(VectorOffset);
			if (_o.States != null)
			{
				Offset<IEntityState>[] array2 = new Offset<IEntityState>[_o.States.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IEntityState.Pack(builder, _o.States[j]);
				}
				statesOffset = IEntityMatch.CreateStatesVector(builder, array2);
			}
			VectorOffset performanceStatesOffset = default(VectorOffset);
			if (_o.PerformanceStates != null)
			{
				StringOffset[] array3 = new StringOffset[_o.PerformanceStates.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = builder.CreateString(_o.PerformanceStates[k]);
				}
				performanceStatesOffset = IEntityMatch.CreatePerformanceStatesVector(builder, array3);
			}
			return IEntityMatch.CreateIEntityMatch(builder, _o.AllCharacter, _o.OnlyPlayer, categoriesOffset, entityIdsOffset, statesOffset, performanceStatesOffset, _o.NullMask);
		}

		// Token: 0x0400EE60 RID: 61024
		private Table __p;
	}
}
