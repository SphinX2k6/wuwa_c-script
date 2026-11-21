using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B16 RID: 23318
	public struct IMonsterGachaBaseComponent : IFlatbufferObject
	{
		// Token: 0x1700AA35 RID: 43573
		// (get) Token: 0x0602655E RID: 157022 RVA: 0x005407C2 File Offset: 0x0053E9C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602655F RID: 157023 RVA: 0x005407CF File Offset: 0x0053E9CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026560 RID: 157024 RVA: 0x005407D8 File Offset: 0x0053E9D8
		public static IMonsterGachaBaseComponent GetRootAsIMonsterGachaBaseComponent(ByteBuffer _bb)
		{
			return IMonsterGachaBaseComponent.GetRootAsIMonsterGachaBaseComponent(_bb, default(IMonsterGachaBaseComponent));
		}

		// Token: 0x06026561 RID: 157025 RVA: 0x005407F4 File Offset: 0x0053E9F4
		public static IMonsterGachaBaseComponent GetRootAsIMonsterGachaBaseComponent(ByteBuffer _bb, IMonsterGachaBaseComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026562 RID: 157026 RVA: 0x00540811 File Offset: 0x0053EA11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026563 RID: 157027 RVA: 0x00540820 File Offset: 0x0053EA20
		public IMonsterGachaBaseComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA36 RID: 43574
		// (get) Token: 0x06026564 RID: 157028 RVA: 0x00540830 File Offset: 0x0053EA30
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026565 RID: 157029 RVA: 0x00540870 File Offset: 0x0053EA70
		public int MonsterEntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AA37 RID: 43575
		// (get) Token: 0x06026566 RID: 157030 RVA: 0x005408B0 File Offset: 0x0053EAB0
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

		// Token: 0x06026567 RID: 157031 RVA: 0x005408DB File Offset: 0x0053EADB
		public Span<int> GetMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06026568 RID: 157032 RVA: 0x005408EA File Offset: 0x0053EAEA
		public int[] GetMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06026569 RID: 157033 RVA: 0x005408F8 File Offset: 0x0053EAF8
		public IMonsterGachaSlot? Config(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterGachaSlot?(default(IMonsterGachaSlot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA38 RID: 43576
		// (get) Token: 0x0602656A RID: 157034 RVA: 0x00540958 File Offset: 0x0053EB58
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

		// Token: 0x0602656B RID: 157035 RVA: 0x00540984 File Offset: 0x0053EB84
		public IMonsterFormation? Formation(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IMonsterFormation?(default(IMonsterFormation).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AA39 RID: 43577
		// (get) Token: 0x0602656C RID: 157036 RVA: 0x005409E8 File Offset: 0x0053EBE8
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

		// Token: 0x1700AA3A RID: 43578
		// (get) Token: 0x0602656D RID: 157037 RVA: 0x00540A14 File Offset: 0x0053EC14
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

		// Token: 0x0602656E RID: 157038 RVA: 0x00540A51 File Offset: 0x0053EC51
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

		// Token: 0x0602656F RID: 157039 RVA: 0x00540A85 File Offset: 0x0053EC85
		public static void StartIMonsterGachaBaseComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06026570 RID: 157040 RVA: 0x00540A8E File Offset: 0x0053EC8E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026571 RID: 157041 RVA: 0x00540A99 File Offset: 0x0053EC99
		public static void AddMonsterEntityIds(FlatBufferBuilder builder, VectorOffset monsterEntityIdsOffset)
		{
			builder.AddOffset(1, monsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x06026572 RID: 157042 RVA: 0x00540AAC File Offset: 0x0053ECAC
		public static VectorOffset CreateMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026573 RID: 157043 RVA: 0x00540AE3 File Offset: 0x0053ECE3
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026574 RID: 157044 RVA: 0x00540AFD File Offset: 0x0053ECFD
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026575 RID: 157045 RVA: 0x00540B1B File Offset: 0x0053ED1B
		public static VectorOffset CreateMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026576 RID: 157046 RVA: 0x00540B34 File Offset: 0x0053ED34
		public static void StartMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026577 RID: 157047 RVA: 0x00540B3F File Offset: 0x0053ED3F
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(2, configOffset.Value, 0);
		}

		// Token: 0x06026578 RID: 157048 RVA: 0x00540B50 File Offset: 0x0053ED50
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IMonsterGachaSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026579 RID: 157049 RVA: 0x00540B90 File Offset: 0x0053ED90
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IMonsterGachaSlot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterGachaSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602657A RID: 157050 RVA: 0x00540BAA File Offset: 0x0053EDAA
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterGachaSlot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterGachaSlot>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602657B RID: 157051 RVA: 0x00540BC8 File Offset: 0x0053EDC8
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterGachaSlot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602657C RID: 157052 RVA: 0x00540BE1 File Offset: 0x0053EDE1
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602657D RID: 157053 RVA: 0x00540BEC File Offset: 0x0053EDEC
		public static void AddFormation(FlatBufferBuilder builder, VectorOffset formationOffset)
		{
			builder.AddOffset(3, formationOffset.Value, 0);
		}

		// Token: 0x0602657E RID: 157054 RVA: 0x00540BFC File Offset: 0x0053EDFC
		public static VectorOffset CreateFormationVector(FlatBufferBuilder builder, Offset<IMonsterFormation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602657F RID: 157055 RVA: 0x00540C3C File Offset: 0x0053EE3C
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, Offset<IMonsterFormation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMonsterFormation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026580 RID: 157056 RVA: 0x00540C56 File Offset: 0x0053EE56
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMonsterFormation>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMonsterFormation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026581 RID: 157057 RVA: 0x00540C74 File Offset: 0x0053EE74
		public static VectorOffset CreateFormationVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMonsterFormation>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026582 RID: 157058 RVA: 0x00540C8D File Offset: 0x0053EE8D
		public static void StartFormationVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026583 RID: 157059 RVA: 0x00540C98 File Offset: 0x0053EE98
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026584 RID: 157060 RVA: 0x00540CA3 File Offset: 0x0053EEA3
		public static Offset<IMonsterGachaBaseComponent> EndIMonsterGachaBaseComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterGachaBaseComponent>(builder.EndTable());
		}

		// Token: 0x06026585 RID: 157061 RVA: 0x00540CB0 File Offset: 0x0053EEB0
		public IMonsterGachaBaseComponentT UnPack()
		{
			IMonsterGachaBaseComponentT monsterGachaBaseComponentT = new IMonsterGachaBaseComponentT();
			this.UnPackTo(monsterGachaBaseComponentT);
			return monsterGachaBaseComponentT;
		}

		// Token: 0x06026586 RID: 157062 RVA: 0x00540CCC File Offset: 0x0053EECC
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

		// Token: 0x06026587 RID: 157063 RVA: 0x00540DCC File Offset: 0x0053EFCC
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

		// Token: 0x0400F504 RID: 62724
		private Table __p;
	}
}
