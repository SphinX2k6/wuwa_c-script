using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200518F RID: 20879
	public struct IEntityMatch : IFlatbufferObject
	{
		// Token: 0x17009887 RID: 39047
		// (get) Token: 0x06021C39 RID: 138297 RVA: 0x004AF2DA File Offset: 0x004AD4DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C3A RID: 138298 RVA: 0x004AF2E7 File Offset: 0x004AD4E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C3B RID: 138299 RVA: 0x004AF2F0 File Offset: 0x004AD4F0
		public static IEntityMatch GetRootAsIEntityMatch(ByteBuffer _bb)
		{
			return IEntityMatch.GetRootAsIEntityMatch(_bb, default(IEntityMatch));
		}

		// Token: 0x06021C3C RID: 138300 RVA: 0x004AF30C File Offset: 0x004AD50C
		public static IEntityMatch GetRootAsIEntityMatch(ByteBuffer _bb, IEntityMatch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C3D RID: 138301 RVA: 0x004AF329 File Offset: 0x004AD529
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C3E RID: 138302 RVA: 0x004AF338 File Offset: 0x004AD538
		public IEntityMatch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009888 RID: 39048
		// (get) Token: 0x06021C3F RID: 138303 RVA: 0x004AF348 File Offset: 0x004AD548
		public bool AllCharacter
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009889 RID: 39049
		// (get) Token: 0x06021C40 RID: 138304 RVA: 0x004AF388 File Offset: 0x004AD588
		public bool OnlyPlayer
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021C41 RID: 138305 RVA: 0x004AF3C8 File Offset: 0x004AD5C8
		public IEntityCategory? Categories(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700988A RID: 39050
		// (get) Token: 0x06021C42 RID: 138306 RVA: 0x004AF428 File Offset: 0x004AD628
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

		// Token: 0x06021C43 RID: 138307 RVA: 0x004AF454 File Offset: 0x004AD654
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700988B RID: 39051
		// (get) Token: 0x06021C44 RID: 138308 RVA: 0x004AF494 File Offset: 0x004AD694
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

		// Token: 0x06021C45 RID: 138309 RVA: 0x004AF4C0 File Offset: 0x004AD6C0
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06021C46 RID: 138310 RVA: 0x004AF4D0 File Offset: 0x004AD6D0
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x06021C47 RID: 138311 RVA: 0x004AF4E0 File Offset: 0x004AD6E0
		public IEntityState? States(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IEntityState?(default(IEntityState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700988C RID: 39052
		// (get) Token: 0x06021C48 RID: 138312 RVA: 0x004AF544 File Offset: 0x004AD744
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

		// Token: 0x06021C49 RID: 138313 RVA: 0x004AF570 File Offset: 0x004AD770
		public string PerformanceStates(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700988D RID: 39053
		// (get) Token: 0x06021C4A RID: 138314 RVA: 0x004AF5AC File Offset: 0x004AD7AC
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

		// Token: 0x1700988E RID: 39054
		// (get) Token: 0x06021C4B RID: 138315 RVA: 0x004AF5D8 File Offset: 0x004AD7D8
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

		// Token: 0x06021C4C RID: 138316 RVA: 0x004AF618 File Offset: 0x004AD818
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

		// Token: 0x06021C4D RID: 138317 RVA: 0x004AF667 File Offset: 0x004AD867
		public static void StartIEntityMatch(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06021C4E RID: 138318 RVA: 0x004AF670 File Offset: 0x004AD870
		public static void AddAllCharacter(FlatBufferBuilder builder, bool allCharacter)
		{
			builder.AddBool(0, allCharacter, false);
		}

		// Token: 0x06021C4F RID: 138319 RVA: 0x004AF67B File Offset: 0x004AD87B
		public static void AddOnlyPlayer(FlatBufferBuilder builder, bool onlyPlayer)
		{
			builder.AddBool(1, onlyPlayer, false);
		}

		// Token: 0x06021C50 RID: 138320 RVA: 0x004AF686 File Offset: 0x004AD886
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
			builder.AddOffset(2, categoriesOffset.Value, 0);
		}

		// Token: 0x06021C51 RID: 138321 RVA: 0x004AF698 File Offset: 0x004AD898
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C52 RID: 138322 RVA: 0x004AF6D8 File Offset: 0x004AD8D8
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C53 RID: 138323 RVA: 0x004AF6F2 File Offset: 0x004AD8F2
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C54 RID: 138324 RVA: 0x004AF710 File Offset: 0x004AD910
		public static VectorOffset CreateCategoriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C55 RID: 138325 RVA: 0x004AF729 File Offset: 0x004AD929
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C56 RID: 138326 RVA: 0x004AF734 File Offset: 0x004AD934
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(3, entityIdsOffset.Value, 0);
		}

		// Token: 0x06021C57 RID: 138327 RVA: 0x004AF744 File Offset: 0x004AD944
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C58 RID: 138328 RVA: 0x004AF77B File Offset: 0x004AD97B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C59 RID: 138329 RVA: 0x004AF795 File Offset: 0x004AD995
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C5A RID: 138330 RVA: 0x004AF7B3 File Offset: 0x004AD9B3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C5B RID: 138331 RVA: 0x004AF7CC File Offset: 0x004AD9CC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C5C RID: 138332 RVA: 0x004AF7D7 File Offset: 0x004AD9D7
		public static void AddStates(FlatBufferBuilder builder, VectorOffset statesOffset)
		{
			builder.AddOffset(4, statesOffset.Value, 0);
		}

		// Token: 0x06021C5D RID: 138333 RVA: 0x004AF7E8 File Offset: 0x004AD9E8
		public static VectorOffset CreateStatesVector(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C5E RID: 138334 RVA: 0x004AF828 File Offset: 0x004ADA28
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, Offset<IEntityState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C5F RID: 138335 RVA: 0x004AF842 File Offset: 0x004ADA42
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityState>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C60 RID: 138336 RVA: 0x004AF860 File Offset: 0x004ADA60
		public static VectorOffset CreateStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C61 RID: 138337 RVA: 0x004AF879 File Offset: 0x004ADA79
		public static void StartStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C62 RID: 138338 RVA: 0x004AF884 File Offset: 0x004ADA84
		public static void AddPerformanceStates(FlatBufferBuilder builder, VectorOffset performanceStatesOffset)
		{
			builder.AddOffset(5, performanceStatesOffset.Value, 0);
		}

		// Token: 0x06021C63 RID: 138339 RVA: 0x004AF894 File Offset: 0x004ADA94
		public static VectorOffset CreatePerformanceStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C64 RID: 138340 RVA: 0x004AF8D4 File Offset: 0x004ADAD4
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C65 RID: 138341 RVA: 0x004AF8EE File Offset: 0x004ADAEE
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C66 RID: 138342 RVA: 0x004AF90C File Offset: 0x004ADB0C
		public static VectorOffset CreatePerformanceStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C67 RID: 138343 RVA: 0x004AF925 File Offset: 0x004ADB25
		public static void StartPerformanceStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C68 RID: 138344 RVA: 0x004AF930 File Offset: 0x004ADB30
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06021C69 RID: 138345 RVA: 0x004AF93B File Offset: 0x004ADB3B
		public static Offset<IEntityMatch> EndIEntityMatch(FlatBufferBuilder builder)
		{
			return new Offset<IEntityMatch>(builder.EndTable());
		}

		// Token: 0x06021C6A RID: 138346 RVA: 0x004AF948 File Offset: 0x004ADB48
		public IEntityMatchT UnPack()
		{
			IEntityMatchT entityMatchT = new IEntityMatchT();
			this.UnPackTo(entityMatchT);
			return entityMatchT;
		}

		// Token: 0x06021C6B RID: 138347 RVA: 0x004AF964 File Offset: 0x004ADB64
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

		// Token: 0x06021C6C RID: 138348 RVA: 0x004AFAA4 File Offset: 0x004ADCA4
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

		// Token: 0x0400E262 RID: 57954
		private Table __p;
	}
}
