using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200480F RID: 18447
	public struct IOccupationConfig : IFlatbufferObject
	{
		// Token: 0x170080AA RID: 32938
		// (get) Token: 0x0601B448 RID: 111688 RVA: 0x003DCEC5 File Offset: 0x003DB0C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B449 RID: 111689 RVA: 0x003DCED2 File Offset: 0x003DB0D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B44A RID: 111690 RVA: 0x003DCEDC File Offset: 0x003DB0DC
		public static IOccupationConfig GetRootAsIOccupationConfig(ByteBuffer _bb)
		{
			return IOccupationConfig.GetRootAsIOccupationConfig(_bb, default(IOccupationConfig));
		}

		// Token: 0x0601B44B RID: 111691 RVA: 0x003DCEF8 File Offset: 0x003DB0F8
		public static IOccupationConfig GetRootAsIOccupationConfig(ByteBuffer _bb, IOccupationConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B44C RID: 111692 RVA: 0x003DCF15 File Offset: 0x003DB115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B44D RID: 111693 RVA: 0x003DCF24 File Offset: 0x003DB124
		public IOccupationConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080AB RID: 32939
		// (get) Token: 0x0601B44E RID: 111694 RVA: 0x003DCF34 File Offset: 0x003DB134
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

		// Token: 0x0601B44F RID: 111695 RVA: 0x003DCF6B File Offset: 0x003DB16B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B450 RID: 111696 RVA: 0x003DCF7A File Offset: 0x003DB17A
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170080AC RID: 32940
		// (get) Token: 0x0601B451 RID: 111697 RVA: 0x003DCF88 File Offset: 0x003DB188
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

		// Token: 0x170080AD RID: 32941
		// (get) Token: 0x0601B452 RID: 111698 RVA: 0x003DCFC4 File Offset: 0x003DB1C4
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

		// Token: 0x0601B453 RID: 111699 RVA: 0x003DCFFB File Offset: 0x003DB1FB
		public Span<byte> GetNameStringKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B454 RID: 111700 RVA: 0x003DD00A File Offset: 0x003DB20A
		public byte[] GetNameStringKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170080AE RID: 32942
		// (get) Token: 0x0601B455 RID: 111701 RVA: 0x003DD018 File Offset: 0x003DB218
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

		// Token: 0x0601B456 RID: 111702 RVA: 0x003DD050 File Offset: 0x003DB250
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601B457 RID: 111703 RVA: 0x003DD060 File Offset: 0x003DB260
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170080AF RID: 32943
		// (get) Token: 0x0601B458 RID: 111704 RVA: 0x003DD070 File Offset: 0x003DB270
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

		// Token: 0x0601B459 RID: 111705 RVA: 0x003DD0B0 File Offset: 0x003DB2B0
		public TTable? OccupationData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601B45A RID: 111706 RVA: 0x003DD0F8 File Offset: 0x003DB2F8
		public IAreaOccupationData OccupationDataAsIAreaOccupationData()
		{
			return this.OccupationData<IAreaOccupationData>().Value;
		}

		// Token: 0x0601B45B RID: 111707 RVA: 0x003DD114 File Offset: 0x003DB314
		public IClosedSegmentOccupationData OccupationDataAsIClosedSegmentOccupationData()
		{
			return this.OccupationData<IClosedSegmentOccupationData>().Value;
		}

		// Token: 0x0601B45C RID: 111708 RVA: 0x003DD130 File Offset: 0x003DB330
		public INpcOccupationData OccupationDataAsINpcOccupationData()
		{
			return this.OccupationData<INpcOccupationData>().Value;
		}

		// Token: 0x0601B45D RID: 111709 RVA: 0x003DD14C File Offset: 0x003DB34C
		public IScreenResourceOccupationData OccupationDataAsIScreenResourceOccupationData()
		{
			return this.OccupationData<IScreenResourceOccupationData>().Value;
		}

		// Token: 0x0601B45E RID: 111710 RVA: 0x003DD168 File Offset: 0x003DB368
		public ISeasonRotationOccupationData OccupationDataAsISeasonRotationOccupationData()
		{
			return this.OccupationData<ISeasonRotationOccupationData>().Value;
		}

		// Token: 0x0601B45F RID: 111711 RVA: 0x003DD184 File Offset: 0x003DB384
		public ISilentAreaOccupationData OccupationDataAsISilentAreaOccupationData()
		{
			return this.OccupationData<ISilentAreaOccupationData>().Value;
		}

		// Token: 0x0601B460 RID: 111712 RVA: 0x003DD1A0 File Offset: 0x003DB3A0
		public ITimeOccupationData OccupationDataAsITimeOccupationData()
		{
			return this.OccupationData<ITimeOccupationData>().Value;
		}

		// Token: 0x0601B461 RID: 111713 RVA: 0x003DD1BB File Offset: 0x003DB3BB
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

		// Token: 0x0601B462 RID: 111714 RVA: 0x003DD1F7 File Offset: 0x003DB3F7
		public static void StartIOccupationConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B463 RID: 111715 RVA: 0x003DD200 File Offset: 0x003DB400
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
			builder.AddOffset(0, idOffset.Value, 0);
		}

		// Token: 0x0601B464 RID: 111716 RVA: 0x003DD210 File Offset: 0x003DB410
		public static void AddOccupationType(FlatBufferBuilder builder, EOccupationType occupationType)
		{
			builder.AddByte(1, (byte)occupationType, 0);
		}

		// Token: 0x0601B465 RID: 111717 RVA: 0x003DD21B File Offset: 0x003DB41B
		public static void AddNameStringKey(FlatBufferBuilder builder, StringOffset nameStringKeyOffset)
		{
			builder.AddOffset(2, nameStringKeyOffset.Value, 0);
		}

		// Token: 0x0601B466 RID: 111718 RVA: 0x003DD22B File Offset: 0x003DB42B
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(3, nameOffset.Value, 0);
		}

		// Token: 0x0601B467 RID: 111719 RVA: 0x003DD23B File Offset: 0x003DB43B
		public static void AddOccupationDataType(FlatBufferBuilder builder, TOccupationData occupationDataType)
		{
			builder.AddByte(4, (byte)occupationDataType, 0);
		}

		// Token: 0x0601B468 RID: 111720 RVA: 0x003DD246 File Offset: 0x003DB446
		public static void AddOccupationData(FlatBufferBuilder builder, int occupationDataOffset)
		{
			builder.AddOffset(5, occupationDataOffset, 0);
		}

		// Token: 0x0601B469 RID: 111721 RVA: 0x003DD251 File Offset: 0x003DB451
		public static Offset<IOccupationConfig> EndIOccupationConfig(FlatBufferBuilder builder)
		{
			return new Offset<IOccupationConfig>(builder.EndTable());
		}

		// Token: 0x0601B46A RID: 111722 RVA: 0x003DD260 File Offset: 0x003DB460
		public IOccupationConfigT UnPack()
		{
			IOccupationConfigT occupationConfigT = new IOccupationConfigT();
			this.UnPackTo(occupationConfigT);
			return occupationConfigT;
		}

		// Token: 0x0601B46B RID: 111723 RVA: 0x003DD27C File Offset: 0x003DB47C
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
			case TOccupationData.ISeasonRotationOccupationData:
				_o.OccupationData.Value = ((this.OccupationData<ISeasonRotationOccupationData>() != null) ? this.OccupationData<ISeasonRotationOccupationData>().Value.UnPack() : null);
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

		// Token: 0x0601B46C RID: 111724 RVA: 0x003DD484 File Offset: 0x003DB684
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

		// Token: 0x0400CC01 RID: 52225
		private Table __p;
	}
}
