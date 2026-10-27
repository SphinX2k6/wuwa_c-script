using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043AD RID: 17325
	public struct IOccupationConfig : IFlatbufferObject
	{
		// Token: 0x17007A75 RID: 31349
		// (get) Token: 0x06019CBA RID: 105658 RVA: 0x003B149D File Offset: 0x003AF69D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019CBB RID: 105659 RVA: 0x003B14AA File Offset: 0x003AF6AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019CBC RID: 105660 RVA: 0x003B14B4 File Offset: 0x003AF6B4
		public static IOccupationConfig GetRootAsIOccupationConfig(ByteBuffer _bb)
		{
			return IOccupationConfig.GetRootAsIOccupationConfig(_bb, default(IOccupationConfig));
		}

		// Token: 0x06019CBD RID: 105661 RVA: 0x003B14D0 File Offset: 0x003AF6D0
		public static IOccupationConfig GetRootAsIOccupationConfig(ByteBuffer _bb, IOccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019CBE RID: 105662 RVA: 0x003B14ED File Offset: 0x003AF6ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019CBF RID: 105663 RVA: 0x003B14FC File Offset: 0x003AF6FC
		public IOccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007A76 RID: 31350
		// (get) Token: 0x06019CC0 RID: 105664 RVA: 0x003B150C File Offset: 0x003AF70C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019CC1 RID: 105665 RVA: 0x003B1543 File Offset: 0x003AF743
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019CC2 RID: 105666 RVA: 0x003B1552 File Offset: 0x003AF752
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007A77 RID: 31351
		// (get) Token: 0x06019CC3 RID: 105667 RVA: 0x003B1560 File Offset: 0x003AF760
		public EOccupationType OccupationType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EOccupationType.Npc;
				}
				return (EOccupationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007A78 RID: 31352
		// (get) Token: 0x06019CC4 RID: 105668 RVA: 0x003B159C File Offset: 0x003AF79C
		public string NameStringKey
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

		// Token: 0x06019CC5 RID: 105669 RVA: 0x003B15D3 File Offset: 0x003AF7D3
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06019CC6 RID: 105670 RVA: 0x003B15E2 File Offset: 0x003AF7E2
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17007A79 RID: 31353
		// (get) Token: 0x06019CC7 RID: 105671 RVA: 0x003B15F0 File Offset: 0x003AF7F0
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019CC8 RID: 105672 RVA: 0x003B1628 File Offset: 0x003AF828
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06019CC9 RID: 105673 RVA: 0x003B1638 File Offset: 0x003AF838
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17007A7A RID: 31354
		// (get) Token: 0x06019CCA RID: 105674 RVA: 0x003B1648 File Offset: 0x003AF848
		public TOccupationData OccupationDataType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TOccupationData.NONE;
				}
				return (TOccupationData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019CCB RID: 105675 RVA: 0x003B1688 File Offset: 0x003AF888
		public TTable? OccupationData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019CCC RID: 105676 RVA: 0x003B16D0 File Offset: 0x003AF8D0
		public IAreaOccupationData OccupationDataAsIAreaOccupationData()
		{
			return this.OccupationData<IAreaOccupationData>().Value;
		}

		// Token: 0x06019CCD RID: 105677 RVA: 0x003B16EC File Offset: 0x003AF8EC
		public IClosedSegmentOccupationData OccupationDataAsIClosedSegmentOccupationData()
		{
			return this.OccupationData<IClosedSegmentOccupationData>().Value;
		}

		// Token: 0x06019CCE RID: 105678 RVA: 0x003B1708 File Offset: 0x003AF908
		public INpcOccupationData OccupationDataAsINpcOccupationData()
		{
			return this.OccupationData<INpcOccupationData>().Value;
		}

		// Token: 0x06019CCF RID: 105679 RVA: 0x003B1724 File Offset: 0x003AF924
		public IScreenResourceOccupationData OccupationDataAsIScreenResourceOccupationData()
		{
			return this.OccupationData<IScreenResourceOccupationData>().Value;
		}

		// Token: 0x06019CD0 RID: 105680 RVA: 0x003B1740 File Offset: 0x003AF940
		public ISilentAreaOccupationData OccupationDataAsISilentAreaOccupationData()
		{
			return this.OccupationData<ISilentAreaOccupationData>().Value;
		}

		// Token: 0x06019CD1 RID: 105681 RVA: 0x003B175C File Offset: 0x003AF95C
		public ITimeOccupationData OccupationDataAsITimeOccupationData()
		{
			return this.OccupationData<ITimeOccupationData>().Value;
		}

		// Token: 0x06019CD2 RID: 105682 RVA: 0x003B1777 File Offset: 0x003AF977
		public static Offset<IOccupationConfig> CreateIOccupationConfig(FlatBufferBuilder builder, StringOffset IdOffset = default(StringOffset), EOccupationType OccupationType = EOccupationType.Npc, StringOffset NameStringKeyOffset = default(StringOffset), StringOffset NameOffset = default(StringOffset), TOccupationData OccupationData_type = TOccupationData.NONE, int OccupationDataOffset = 0)
		{
			builder.StartTable(6);
			IOccupationConfig.AddOccupationData(builder, OccupationDataOffset);
			IOccupationConfig.AddName(builder, NameOffset);
			IOccupationConfig.AddNameStringKey(builder, NameStringKeyOffset);
			IOccupationConfig.AddId(builder, IdOffset);
			IOccupationConfig.AddOccupationDataType(builder, OccupationData_type);
			IOccupationConfig.AddOccupationType(builder, OccupationType);
			return IOccupationConfig.EndIOccupationConfig(builder);
		}

		// Token: 0x06019CD3 RID: 105683 RVA: 0x003B17B3 File Offset: 0x003AF9B3
		public static void StartIOccupationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06019CD4 RID: 105684 RVA: 0x003B17BC File Offset: 0x003AF9BC
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x06019CD5 RID: 105685 RVA: 0x003B17CC File Offset: 0x003AF9CC
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationType occupationType)
		{
			builder.AddByte(1, (byte)occupationType, 0);
		}

		// Token: 0x06019CD6 RID: 105686 RVA: 0x003B17D7 File Offset: 0x003AF9D7
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(2, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x06019CD7 RID: 105687 RVA: 0x003B17E7 File Offset: 0x003AF9E7
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(3, nameOffset.Value, 0);
		}

		// Token: 0x06019CD8 RID: 105688 RVA: 0x003B17F7 File Offset: 0x003AF9F7
		public static void AddOccupationDataType(FlatBufferBuilder builder, TOccupationData occupationDataType)
		{
			builder.AddByte(4, (byte)occupationDataType, 0);
		}

		// Token: 0x06019CD9 RID: 105689 RVA: 0x003B1802 File Offset: 0x003AFA02
		public static void AddOccupationData(FlatBufferBuilder builder, int occupationDataOffset)
		{
			builder.AddOffset(5, occupationDataOffset, 0);
		}

		// Token: 0x06019CDA RID: 105690 RVA: 0x003B180D File Offset: 0x003AFA0D
		public static Offset<IOccupationConfig> EndIOccupationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationConfig>(builder.EndTable());
		}

		// Token: 0x06019CDB RID: 105691 RVA: 0x003B181C File Offset: 0x003AFA1C
		public IOccupationConfigT UnPack()
		{
			IOccupationConfigT occupationConfigT = new IOccupationConfigT();
			this.UnPackTo(occupationConfigT);
			return occupationConfigT;
		}

		// Token: 0x06019CDC RID: 105692 RVA: 0x003B1838 File Offset: 0x003AFA38
		public void UnPackTo(IOccupationConfigT _o)
		{
			_o.Id = this.Id;
			_o.OccupationType = this.OccupationType;
			_o.NameStringKey = this.NameStringKey;
			_o.Name = this.Name;
			_o.OccupationData = new TOccupationDataUnion();
			_o.OccupationData.Type = this.OccupationDataType;
			switch (this.OccupationDataType)
			{
			case TOccupationData.IAreaOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<IAreaOccupationData>() != null) ? this.OccupationData<IAreaOccupationData>().Value.UnPack() : null);
				return;
			case TOccupationData.IClosedSegmentOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<IClosedSegmentOccupationData>() != null) ? this.OccupationData<IClosedSegmentOccupationData>().Value.UnPack() : null);
				return;
			case TOccupationData.INpcOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<INpcOccupationData>() != null) ? this.OccupationData<INpcOccupationData>().Value.UnPack() : null);
				return;
			case TOccupationData.IScreenResourceOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<IScreenResourceOccupationData>() != null) ? this.OccupationData<IScreenResourceOccupationData>().Value.UnPack() : null);
				return;
			case TOccupationData.ISilentAreaOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<ISilentAreaOccupationData>() != null) ? this.OccupationData<ISilentAreaOccupationData>().Value.UnPack() : null);
				return;
			case TOccupationData.ITimeOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<ITimeOccupationData>() != null) ? this.OccupationData<ITimeOccupationData>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06019CDD RID: 105693 RVA: 0x003B1A04 File Offset: 0x003AFC04
		public static Offset<IOccupationConfig> Pack(FlatBufferBuilder builder, IOccupationConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOccupationConfig>);
			}
			StringOffset idOffset = (_o.Id == null) ? default(StringOffset) : builder.CreateString(_o.Id);
			StringOffset nameStringKeyOffset = (_o.NameStringKey == null) ? default(StringOffset) : builder.CreateString(_o.NameStringKey);
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			TOccupationData occupationData_type = (_o.OccupationData == null) ? TOccupationData.NONE : _o.OccupationData.Type;
			int occupationDataOffset = (_o.OccupationData == null) ? 0 : TOccupationDataUnion.Pack(builder, _o.OccupationData);
			return IOccupationConfig.CreateIOccupationConfig(builder, idOffset, _o.OccupationType, nameStringKeyOffset, nameOffset, occupationData_type, occupationDataOffset);
		}

		// Token: 0x0400C1E2 RID: 49634
		private Table __p;
	}
}
