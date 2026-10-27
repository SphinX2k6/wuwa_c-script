using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9E RID: 23454
	public struct IWuWaGoComponent : IFlatbufferObject
	{
		// Token: 0x1700B13B RID: 45371
		// (get) Token: 0x06028271 RID: 164465 RVA: 0x005849FD File Offset: 0x00582BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028272 RID: 164466 RVA: 0x00584A0A File Offset: 0x00582C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028273 RID: 164467 RVA: 0x00584A14 File Offset: 0x00582C14
		public static IWuWaGoComponent GetRootAsIWuWaGoComponent(ByteBuffer _bb)
		{
			return IWuWaGoComponent.GetRootAsIWuWaGoComponent(_bb, default(IWuWaGoComponent));
		}

		// Token: 0x06028274 RID: 164468 RVA: 0x00584A30 File Offset: 0x00582C30
		public static IWuWaGoComponent GetRootAsIWuWaGoComponent(ByteBuffer _bb, IWuWaGoComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028275 RID: 164469 RVA: 0x00584A4D File Offset: 0x00582C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028276 RID: 164470 RVA: 0x00584A5C File Offset: 0x00582C5C
		public IWuWaGoComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B13C RID: 45372
		// (get) Token: 0x06028277 RID: 164471 RVA: 0x00584A6C File Offset: 0x00582C6C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B13D RID: 45373
		// (get) Token: 0x06028278 RID: 164472 RVA: 0x00584AAC File Offset: 0x00582CAC
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

		// Token: 0x06028279 RID: 164473 RVA: 0x00584AE8 File Offset: 0x00582CE8
		public TTable? WuWaGoEntity<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602827A RID: 164474 RVA: 0x00584B2C File Offset: 0x00582D2C
		public IWuWaGoBowTrap WuWaGoEntityAsIWuWaGoBowTrap()
		{
			return this.WuWaGoEntity<IWuWaGoBowTrap>().Value;
		}

		// Token: 0x0602827B RID: 164475 RVA: 0x00584B48 File Offset: 0x00582D48
		public IWuWaGoEndGrid WuWaGoEntityAsIWuWaGoEndGrid()
		{
			return this.WuWaGoEntity<IWuWaGoEndGrid>().Value;
		}

		// Token: 0x0602827C RID: 164476 RVA: 0x00584B64 File Offset: 0x00582D64
		public IWuWaGoGear WuWaGoEntityAsIWuWaGoGear()
		{
			return this.WuWaGoEntity<IWuWaGoGear>().Value;
		}

		// Token: 0x0602827D RID: 164477 RVA: 0x00584B80 File Offset: 0x00582D80
		public IWuWaGoLevelCenter WuWaGoEntityAsIWuWaGoLevelCenter()
		{
			return this.WuWaGoEntity<IWuWaGoLevelCenter>().Value;
		}

		// Token: 0x0602827E RID: 164478 RVA: 0x00584B9C File Offset: 0x00582D9C
		public IWuWaGoMovableFloor WuWaGoEntityAsIWuWaGoMovableFloor()
		{
			return this.WuWaGoEntity<IWuWaGoMovableFloor>().Value;
		}

		// Token: 0x0602827F RID: 164479 RVA: 0x00584BB8 File Offset: 0x00582DB8
		public IWuWaGoPressureTrigger WuWaGoEntityAsIWuWaGoPressureTrigger()
		{
			return this.WuWaGoEntity<IWuWaGoPressureTrigger>().Value;
		}

		// Token: 0x06028280 RID: 164480 RVA: 0x00584BD4 File Offset: 0x00582DD4
		public IWuWaGoPullRod WuWaGoEntityAsIWuWaGoPullRod()
		{
			return this.WuWaGoEntity<IWuWaGoPullRod>().Value;
		}

		// Token: 0x06028281 RID: 164481 RVA: 0x00584BF0 File Offset: 0x00582DF0
		public IWuWaGoSaveGrid WuWaGoEntityAsIWuWaGoSaveGrid()
		{
			return this.WuWaGoEntity<IWuWaGoSaveGrid>().Value;
		}

		// Token: 0x06028282 RID: 164482 RVA: 0x00584C0C File Offset: 0x00582E0C
		public IWuWaGoSpikeTrap WuWaGoEntityAsIWuWaGoSpikeTrap()
		{
			return this.WuWaGoEntity<IWuWaGoSpikeTrap>().Value;
		}

		// Token: 0x06028283 RID: 164483 RVA: 0x00584C28 File Offset: 0x00582E28
		public IWuWaGoStartGrid WuWaGoEntityAsIWuWaGoStartGrid()
		{
			return this.WuWaGoEntity<IWuWaGoStartGrid>().Value;
		}

		// Token: 0x06028284 RID: 164484 RVA: 0x00584C44 File Offset: 0x00582E44
		public int OpenAddClientTags(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B13E RID: 45374
		// (get) Token: 0x06028285 RID: 164485 RVA: 0x00584C84 File Offset: 0x00582E84
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

		// Token: 0x06028286 RID: 164486 RVA: 0x00584CB0 File Offset: 0x00582EB0
		public Span<int> GetOpenAddClientTagsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06028287 RID: 164487 RVA: 0x00584CC0 File Offset: 0x00582EC0
		public int[] GetOpenAddClientTagsArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700B13F RID: 45375
		// (get) Token: 0x06028288 RID: 164488 RVA: 0x00584CD0 File Offset: 0x00582ED0
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

		// Token: 0x06028289 RID: 164489 RVA: 0x00584D0D File Offset: 0x00582F0D
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

		// Token: 0x0602828A RID: 164490 RVA: 0x00584D41 File Offset: 0x00582F41
		public static void StartIWuWaGoComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602828B RID: 164491 RVA: 0x00584D4A File Offset: 0x00582F4A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602828C RID: 164492 RVA: 0x00584D55 File Offset: 0x00582F55
		public static void AddWuWaGoEntityType(FlatBufferBuilder builder, TWuWaGoEntityData wuWaGoEntityType)
		{
			builder.AddByte(1, (byte)wuWaGoEntityType, 0);
		}

		// Token: 0x0602828D RID: 164493 RVA: 0x00584D60 File Offset: 0x00582F60
		public static void AddWuWaGoEntity(FlatBufferBuilder builder, int wuWaGoEntityOffset)
		{
			builder.AddOffset(2, wuWaGoEntityOffset, 0);
		}

		// Token: 0x0602828E RID: 164494 RVA: 0x00584D6B File Offset: 0x00582F6B
		public static void AddOpenAddClientTags(FlatBufferBuilder builder, VectorOffset openAddClientTagsOffset)
		{
			builder.AddOffset(3, openAddClientTagsOffset.Value, 0);
		}

		// Token: 0x0602828F RID: 164495 RVA: 0x00584D7C File Offset: 0x00582F7C
		public static VectorOffset CreateOpenAddClientTagsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028290 RID: 164496 RVA: 0x00584DB3 File Offset: 0x00582FB3
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028291 RID: 164497 RVA: 0x00584DCD File Offset: 0x00582FCD
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028292 RID: 164498 RVA: 0x00584DEB File Offset: 0x00582FEB
		public static VectorOffset CreateOpenAddClientTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028293 RID: 164499 RVA: 0x00584E04 File Offset: 0x00583004
		public static void StartOpenAddClientTagsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028294 RID: 164500 RVA: 0x00584E0F File Offset: 0x0058300F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06028295 RID: 164501 RVA: 0x00584E1A File Offset: 0x0058301A
		public static Offset<IWuWaGoComponent> EndIWuWaGoComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWuWaGoComponent>(builder.EndTable());
		}

		// Token: 0x06028296 RID: 164502 RVA: 0x00584E28 File Offset: 0x00583028
		public IWuWaGoComponentT UnPack()
		{
			IWuWaGoComponentT wuWaGoComponentT = new IWuWaGoComponentT();
			this.UnPackTo(wuWaGoComponentT);
			return wuWaGoComponentT;
		}

		// Token: 0x06028297 RID: 164503 RVA: 0x00584E44 File Offset: 0x00583044
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

		// Token: 0x06028298 RID: 164504 RVA: 0x0058513C File Offset: 0x0058333C
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

		// Token: 0x0400F303 RID: 62211
		private Table __p;
	}
}
