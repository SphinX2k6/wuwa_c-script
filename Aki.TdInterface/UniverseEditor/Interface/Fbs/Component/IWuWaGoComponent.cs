using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061B4 RID: 25012
	public struct IWuWaGoComponent : IFlatbufferObject
	{
		// Token: 0x1700BA83 RID: 47747
		// (get) Token: 0x0602A835 RID: 174133 RVA: 0x005CC48D File Offset: 0x005CA68D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A836 RID: 174134 RVA: 0x005CC49A File Offset: 0x005CA69A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A837 RID: 174135 RVA: 0x005CC4A4 File Offset: 0x005CA6A4
		public static IWuWaGoComponent GetRootAsIWuWaGoComponent(ByteBuffer _bb)
		{
			return IWuWaGoComponent.GetRootAsIWuWaGoComponent(_bb, default(IWuWaGoComponent));
		}

		// Token: 0x0602A838 RID: 174136 RVA: 0x005CC4C0 File Offset: 0x005CA6C0
		public static IWuWaGoComponent GetRootAsIWuWaGoComponent(ByteBuffer _bb, IWuWaGoComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A839 RID: 174137 RVA: 0x005CC4DD File Offset: 0x005CA6DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A83A RID: 174138 RVA: 0x005CC4EC File Offset: 0x005CA6EC
		public IWuWaGoComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA84 RID: 47748
		// (get) Token: 0x0602A83B RID: 174139 RVA: 0x005CC4FC File Offset: 0x005CA6FC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA85 RID: 47749
		// (get) Token: 0x0602A83C RID: 174140 RVA: 0x005CC53C File Offset: 0x005CA73C
		public TWuWaGoEntityData WuWaGoEntityType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TWuWaGoEntityData.NONE;
				}
				return (TWuWaGoEntityData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A83D RID: 174141 RVA: 0x005CC578 File Offset: 0x005CA778
		public TTable? WuWaGoEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A83E RID: 174142 RVA: 0x005CC5BC File Offset: 0x005CA7BC
		public IWuWaGoBowTrap WuWaGoEntityAsIWuWaGoBowTrap()
		{
			return this.WuWaGoEntity<IWuWaGoBowTrap>().Value;
		}

		// Token: 0x0602A83F RID: 174143 RVA: 0x005CC5D8 File Offset: 0x005CA7D8
		public IWuWaGoEndGrid WuWaGoEntityAsIWuWaGoEndGrid()
		{
			return this.WuWaGoEntity<IWuWaGoEndGrid>().Value;
		}

		// Token: 0x0602A840 RID: 174144 RVA: 0x005CC5F4 File Offset: 0x005CA7F4
		public IWuWaGoGear WuWaGoEntityAsIWuWaGoGear()
		{
			return this.WuWaGoEntity<IWuWaGoGear>().Value;
		}

		// Token: 0x0602A841 RID: 174145 RVA: 0x005CC610 File Offset: 0x005CA810
		public IWuWaGoLevelCenter WuWaGoEntityAsIWuWaGoLevelCenter()
		{
			return this.WuWaGoEntity<IWuWaGoLevelCenter>().Value;
		}

		// Token: 0x0602A842 RID: 174146 RVA: 0x005CC62C File Offset: 0x005CA82C
		public IWuWaGoMovableFloor WuWaGoEntityAsIWuWaGoMovableFloor()
		{
			return this.WuWaGoEntity<IWuWaGoMovableFloor>().Value;
		}

		// Token: 0x0602A843 RID: 174147 RVA: 0x005CC648 File Offset: 0x005CA848
		public IWuWaGoPressureTrigger WuWaGoEntityAsIWuWaGoPressureTrigger()
		{
			return this.WuWaGoEntity<IWuWaGoPressureTrigger>().Value;
		}

		// Token: 0x0602A844 RID: 174148 RVA: 0x005CC664 File Offset: 0x005CA864
		public IWuWaGoPullRod WuWaGoEntityAsIWuWaGoPullRod()
		{
			return this.WuWaGoEntity<IWuWaGoPullRod>().Value;
		}

		// Token: 0x0602A845 RID: 174149 RVA: 0x005CC680 File Offset: 0x005CA880
		public IWuWaGoSaveGrid WuWaGoEntityAsIWuWaGoSaveGrid()
		{
			return this.WuWaGoEntity<IWuWaGoSaveGrid>().Value;
		}

		// Token: 0x0602A846 RID: 174150 RVA: 0x005CC69C File Offset: 0x005CA89C
		public IWuWaGoSpikeTrap WuWaGoEntityAsIWuWaGoSpikeTrap()
		{
			return this.WuWaGoEntity<IWuWaGoSpikeTrap>().Value;
		}

		// Token: 0x0602A847 RID: 174151 RVA: 0x005CC6B8 File Offset: 0x005CA8B8
		public IWuWaGoStartGrid WuWaGoEntityAsIWuWaGoStartGrid()
		{
			return this.WuWaGoEntity<IWuWaGoStartGrid>().Value;
		}

		// Token: 0x0602A848 RID: 174152 RVA: 0x005CC6D4 File Offset: 0x005CA8D4
		public int OpenAddClientTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BA86 RID: 47750
		// (get) Token: 0x0602A849 RID: 174153 RVA: 0x005CC714 File Offset: 0x005CA914
		public int OpenAddClientTagsLength
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

		// Token: 0x0602A84A RID: 174154 RVA: 0x005CC740 File Offset: 0x005CA940
		public Span<int> GetOpenAddClientTagsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602A84B RID: 174155 RVA: 0x005CC750 File Offset: 0x005CA950
		public int[] GetOpenAddClientTagsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700BA87 RID: 47751
		// (get) Token: 0x0602A84C RID: 174156 RVA: 0x005CC760 File Offset: 0x005CA960
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

		// Token: 0x0602A84D RID: 174157 RVA: 0x005CC79D File Offset: 0x005CA99D
		public static Offset<IWuWaGoComponent> CreateIWuWaGoComponent(FlatBufferBuilder builder, bool Disabled = false, TWuWaGoEntityData WuWaGoEntity_type = TWuWaGoEntityData.NONE, int WuWaGoEntityOffset = 0, VectorOffset OpenAddClientTagsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IWuWaGoComponent.AddOpenAddClientTags(builder, OpenAddClientTagsOffset);
			IWuWaGoComponent.AddWuWaGoEntity(builder, WuWaGoEntityOffset);
			IWuWaGoComponent.AddNullMask(builder, NullMask);
			IWuWaGoComponent.AddWuWaGoEntityType(builder, WuWaGoEntity_type);
			IWuWaGoComponent.AddDisabled(builder, Disabled);
			return IWuWaGoComponent.EndIWuWaGoComponent(builder);
		}

		// Token: 0x0602A84E RID: 174158 RVA: 0x005CC7D1 File Offset: 0x005CA9D1
		public static void StartIWuWaGoComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A84F RID: 174159 RVA: 0x005CC7DA File Offset: 0x005CA9DA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A850 RID: 174160 RVA: 0x005CC7E5 File Offset: 0x005CA9E5
		public static void AddWuWaGoEntityType(FlatBufferBuilder builder, TWuWaGoEntityData wuWaGoEntityType)
		{
			builder.AddByte(1, (byte)wuWaGoEntityType, 0);
		}

		// Token: 0x0602A851 RID: 174161 RVA: 0x005CC7F0 File Offset: 0x005CA9F0
		public static void AddWuWaGoEntity(FlatBufferBuilder builder, int wuWaGoEntityOffset)
		{
			builder.AddOffset(2, wuWaGoEntityOffset, 0);
		}

		// Token: 0x0602A852 RID: 174162 RVA: 0x005CC7FB File Offset: 0x005CA9FB
		public static void AddOpenAddClientTags(FlatBufferBuilder builder, VectorOffset openAddClientTagsOffset)
		{
			builder.AddOffset(3, openAddClientTagsOffset.Value, 0);
		}

		// Token: 0x0602A853 RID: 174163 RVA: 0x005CC80C File Offset: 0x005CAA0C
		public static VectorOffset CreateOpenAddClientTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A854 RID: 174164 RVA: 0x005CC843 File Offset: 0x005CAA43
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A855 RID: 174165 RVA: 0x005CC85D File Offset: 0x005CAA5D
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A856 RID: 174166 RVA: 0x005CC87B File Offset: 0x005CAA7B
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A857 RID: 174167 RVA: 0x005CC894 File Offset: 0x005CAA94
		public static void StartOpenAddClientTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A858 RID: 174168 RVA: 0x005CC89F File Offset: 0x005CAA9F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A859 RID: 174169 RVA: 0x005CC8AA File Offset: 0x005CAAAA
		public static Offset<IWuWaGoComponent> EndIWuWaGoComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoComponent>(builder.EndTable());
		}

		// Token: 0x0602A85A RID: 174170 RVA: 0x005CC8B8 File Offset: 0x005CAAB8
		public IWuWaGoComponentT UnPack()
		{
			IWuWaGoComponentT wuWaGoComponentT = new IWuWaGoComponentT();
			this.UnPackTo(wuWaGoComponentT);
			return wuWaGoComponentT;
		}

		// Token: 0x0602A85B RID: 174171 RVA: 0x005CC8D4 File Offset: 0x005CAAD4
		public void UnPackTo(IWuWaGoComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WuWaGoEntity = new TWuWaGoEntityDataUnion();
			_o.WuWaGoEntity.Type = this.WuWaGoEntityType;
			switch (this.WuWaGoEntityType)
			{
			case TWuWaGoEntityData.IWuWaGoBowTrap:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoBowTrap>() != null) ? this.WuWaGoEntity<IWuWaGoBowTrap>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoEndGrid:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoEndGrid>() != null) ? this.WuWaGoEntity<IWuWaGoEndGrid>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoGear:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoGear>() != null) ? this.WuWaGoEntity<IWuWaGoGear>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoLevelCenter:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoLevelCenter>() != null) ? this.WuWaGoEntity<IWuWaGoLevelCenter>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoMovableFloor:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoMovableFloor>() != null) ? this.WuWaGoEntity<IWuWaGoMovableFloor>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoPressureTrigger:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoPressureTrigger>() != null) ? this.WuWaGoEntity<IWuWaGoPressureTrigger>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoPullRod:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoPullRod>() != null) ? this.WuWaGoEntity<IWuWaGoPullRod>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoSaveGrid:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoSaveGrid>() != null) ? this.WuWaGoEntity<IWuWaGoSaveGrid>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoSpikeTrap:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoSpikeTrap>() != null) ? this.WuWaGoEntity<IWuWaGoSpikeTrap>().Value.UnPack() : null);
				break;
			case TWuWaGoEntityData.IWuWaGoStartGrid:
				_o.WuWaGoEntity.Value = ((this.WuWaGoEntity<IWuWaGoStartGrid>() != null) ? this.WuWaGoEntity<IWuWaGoStartGrid>().Value.UnPack() : null);
				break;
			}
			_o.OpenAddClientTags = new List<int>();
			for (int i = 0; i < this.OpenAddClientTagsLength; i++)
			{
				_o.OpenAddClientTags.Add(this.OpenAddClientTags(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A85C RID: 174172 RVA: 0x005CCBCC File Offset: 0x005CADCC
		public static Offset<IWuWaGoComponent> Pack(FlatBufferBuilder builder, IWuWaGoComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWuWaGoComponent>);
			}
			TWuWaGoEntityData wuWaGoEntity_type = (_o.WuWaGoEntity == null) ? TWuWaGoEntityData.NONE : _o.WuWaGoEntity.Type;
			int wuWaGoEntityOffset = (_o.WuWaGoEntity == null) ? 0 : TWuWaGoEntityDataUnion.Pack(builder, _o.WuWaGoEntity);
			VectorOffset openAddClientTagsOffset = default(VectorOffset);
			if (_o.OpenAddClientTags != null)
			{
				int[] data = _o.OpenAddClientTags.ToArray();
				openAddClientTagsOffset = IWuWaGoComponent.CreateOpenAddClientTagsVector(builder, data);
			}
			return IWuWaGoComponent.CreateIWuWaGoComponent(builder, _o.Disabled, wuWaGoEntity_type, wuWaGoEntityOffset, openAddClientTagsOffset, _o.NullMask);
		}

		// Token: 0x04010009 RID: 65545
		private Table __p;
	}
}
