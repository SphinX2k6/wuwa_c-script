using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005578 RID: 21880
	public struct IMonsterGachaBaseComponent : IFlatbufferObject
	{
		// Token: 0x1700A1AD RID: 41389
		// (get) Token: 0x06024351 RID: 148305 RVA: 0x0050024A File Offset: 0x004FE44A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024352 RID: 148306 RVA: 0x00500257 File Offset: 0x004FE457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024353 RID: 148307 RVA: 0x00500260 File Offset: 0x004FE460
		public static IMonsterGachaBaseComponent GetRootAsIMonsterGachaBaseComponent(ByteBuffer _bb)
		{
			return IMonsterGachaBaseComponent.GetRootAsIMonsterGachaBaseComponent(_bb, default(IMonsterGachaBaseComponent));
		}

		// Token: 0x06024354 RID: 148308 RVA: 0x0050027C File Offset: 0x004FE47C
		public static IMonsterGachaBaseComponent GetRootAsIMonsterGachaBaseComponent(ByteBuffer _bb, IMonsterGachaBaseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024355 RID: 148309 RVA: 0x00500299 File Offset: 0x004FE499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024356 RID: 148310 RVA: 0x005002A8 File Offset: 0x004FE4A8
		public IMonsterGachaBaseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1AE RID: 41390
		// (get) Token: 0x06024357 RID: 148311 RVA: 0x005002B8 File Offset: 0x004FE4B8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024358 RID: 148312 RVA: 0x005002F8 File Offset: 0x004FE4F8
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A1AF RID: 41391
		// (get) Token: 0x06024359 RID: 148313 RVA: 0x00500338 File Offset: 0x004FE538
		public int MonsterEntityIdsLength
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

		// Token: 0x0602435A RID: 148314 RVA: 0x00500363 File Offset: 0x004FE563
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602435B RID: 148315 RVA: 0x00500372 File Offset: 0x004FE572
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602435C RID: 148316 RVA: 0x00500380 File Offset: 0x004FE580
		public IMonsterGachaSlot? Config(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterGachaSlot?(default(IMonsterGachaSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1B0 RID: 41392
		// (get) Token: 0x0602435D RID: 148317 RVA: 0x005003E0 File Offset: 0x004FE5E0
		public int ConfigLength
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

		// Token: 0x0602435E RID: 148318 RVA: 0x0050040C File Offset: 0x004FE60C
		public IMonsterFormation? Formation(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterFormation?(default(IMonsterFormation).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A1B1 RID: 41393
		// (get) Token: 0x0602435F RID: 148319 RVA: 0x00500470 File Offset: 0x004FE670
		public int FormationLength
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

		// Token: 0x1700A1B2 RID: 41394
		// (get) Token: 0x06024360 RID: 148320 RVA: 0x0050049C File Offset: 0x004FE69C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024361 RID: 148321 RVA: 0x005004D9 File Offset: 0x004FE6D9
		public static Offset<IMonsterGachaBaseComponent> CreateIMonsterGachaBaseComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset MonsterEntityIdsOffset = default(VectorOffset), VectorOffset ConfigOffset = default(VectorOffset), VectorOffset FormationOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IMonsterGachaBaseComponent.AddFormation(builder, FormationOffset);
			IMonsterGachaBaseComponent.AddConfig(builder, ConfigOffset);
			IMonsterGachaBaseComponent.AddMonsterEntityIds(builder, MonsterEntityIdsOffset);
			IMonsterGachaBaseComponent.AddNullMask(builder, NullMask);
			IMonsterGachaBaseComponent.AddDisabled(builder, Disabled);
			return IMonsterGachaBaseComponent.EndIMonsterGachaBaseComponent(builder);
		}

		// Token: 0x06024362 RID: 148322 RVA: 0x0050050D File Offset: 0x004FE70D
		public static void StartIMonsterGachaBaseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024363 RID: 148323 RVA: 0x00500516 File Offset: 0x004FE716
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024364 RID: 148324 RVA: 0x00500521 File Offset: 0x004FE721
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(1, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x06024365 RID: 148325 RVA: 0x00500534 File Offset: 0x004FE734
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024366 RID: 148326 RVA: 0x0050056B File Offset: 0x004FE76B
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024367 RID: 148327 RVA: 0x00500585 File Offset: 0x004FE785
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024368 RID: 148328 RVA: 0x005005A3 File Offset: 0x004FE7A3
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024369 RID: 148329 RVA: 0x005005BC File Offset: 0x004FE7BC
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602436A RID: 148330 RVA: 0x005005C7 File Offset: 0x004FE7C7
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x0602436B RID: 148331 RVA: 0x005005D8 File Offset: 0x004FE7D8
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IMonsterGachaSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602436C RID: 148332 RVA: 0x00500618 File Offset: 0x004FE818
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IMonsterGachaSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterGachaSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602436D RID: 148333 RVA: 0x00500632 File Offset: 0x004FE832
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterGachaSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterGachaSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602436E RID: 148334 RVA: 0x00500650 File Offset: 0x004FE850
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterGachaSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602436F RID: 148335 RVA: 0x00500669 File Offset: 0x004FE869
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024370 RID: 148336 RVA: 0x00500674 File Offset: 0x004FE874
		public static void AddFormation(FlatBufferBuilder builder, VectorOffset formationOffset)
		{
			builder.AddOffset(3, formationOffset.Value, 0);
		}

		// Token: 0x06024371 RID: 148337 RVA: 0x00500684 File Offset: 0x004FE884
		public static VectorOffset CreateFormationVector(FlatBufferBuilder builder, Offset<IMonsterFormation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024372 RID: 148338 RVA: 0x005006C4 File Offset: 0x004FE8C4
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, Offset<IMonsterFormation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterFormation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024373 RID: 148339 RVA: 0x005006DE File Offset: 0x004FE8DE
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterFormation>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterFormation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024374 RID: 148340 RVA: 0x005006FC File Offset: 0x004FE8FC
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterFormation>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024375 RID: 148341 RVA: 0x00500715 File Offset: 0x004FE915
		public static void StartFormationVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024376 RID: 148342 RVA: 0x00500720 File Offset: 0x004FE920
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024377 RID: 148343 RVA: 0x0050072B File Offset: 0x004FE92B
		public static Offset<IMonsterGachaBaseComponent> EndIMonsterGachaBaseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaBaseComponent>(builder.EndTable());
		}

		// Token: 0x06024378 RID: 148344 RVA: 0x00500738 File Offset: 0x004FE938
		public IMonsterGachaBaseComponentT UnPack()
		{
			IMonsterGachaBaseComponentT monsterGachaBaseComponentT = new IMonsterGachaBaseComponentT();
			this.UnPackTo(monsterGachaBaseComponentT);
			return monsterGachaBaseComponentT;
		}

		// Token: 0x06024379 RID: 148345 RVA: 0x00500754 File Offset: 0x004FE954
		public void UnPackTo(IMonsterGachaBaseComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MonsterEntityIds = new List<int>();
			for (int i = 0; i < this.MonsterEntityIdsLength; i++)
			{
				_o.MonsterEntityIds.Add(this.MonsterEntityIds(i));
			}
			_o.Config = new List<IMonsterGachaSlotT>();
			for (int j = 0; j < this.ConfigLength; j++)
			{
				_o.Config.Add((this.Config(j) != null) ? this.Config(j).Value.UnPack() : null);
			}
			_o.Formation = new List<IMonsterFormationT>();
			for (int k = 0; k < this.FormationLength; k++)
			{
				_o.Formation.Add((this.Formation(k) != null) ? this.Formation(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602437A RID: 148346 RVA: 0x00500854 File Offset: 0x004FEA54
		public static Offset<IMonsterGachaBaseComponent> Pack(FlatBufferBuilder builder, IMonsterGachaBaseComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterGachaBaseComponent>);
			}
			VectorOffset monsterEntityIdsOffset = default(VectorOffset);
			if (_o.MonsterEntityIds != null)
			{
				int[] data = _o.MonsterEntityIds.ToArray();
				monsterEntityIdsOffset = IMonsterGachaBaseComponent.CreateMonsterEntityIdsVector(builder, data);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IMonsterGachaSlot>[] array = new Offset<IMonsterGachaSlot>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMonsterGachaSlot.Pack(builder, _o.Config[i]);
				}
				configOffset = IMonsterGachaBaseComponent.CreateConfigVector(builder, array);
			}
			VectorOffset formationOffset = default(VectorOffset);
			if (_o.Formation != null)
			{
				Offset<IMonsterFormation>[] array2 = new Offset<IMonsterFormation>[_o.Formation.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IMonsterFormation.Pack(builder, _o.Formation[j]);
				}
				formationOffset = IMonsterGachaBaseComponent.CreateFormationVector(builder, array2);
			}
			return IMonsterGachaBaseComponent.CreateIMonsterGachaBaseComponent(builder, _o.Disabled, monsterEntityIdsOffset, configOffset, formationOffset, _o.NullMask);
		}

		// Token: 0x0400E8A2 RID: 59554
		private Table __p;
	}
}
