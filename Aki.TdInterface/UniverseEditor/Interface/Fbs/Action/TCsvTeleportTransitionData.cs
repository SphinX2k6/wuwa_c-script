using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA6 RID: 32422
	public struct TCsvTeleportTransitionData : IFlatbufferObject
	{
		// Token: 0x1700F23A RID: 62010
		// (get) Token: 0x0603A891 RID: 239761 RVA: 0x007E0ACC File Offset: 0x007DECCC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A892 RID: 239762 RVA: 0x007E0AD9 File Offset: 0x007DECD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A893 RID: 239763 RVA: 0x007E0AE0 File Offset: 0x007DECE0
		public static TCsvTeleportTransitionData GetRootAsTCsvTeleportTransitionData(ByteBuffer _bb)
		{
			return TCsvTeleportTransitionData.GetRootAsTCsvTeleportTransitionData(_bb, default(TCsvTeleportTransitionData));
		}

		// Token: 0x0603A894 RID: 239764 RVA: 0x007E0AFC File Offset: 0x007DECFC
		public static TCsvTeleportTransitionData GetRootAsTCsvTeleportTransitionData(ByteBuffer _bb, TCsvTeleportTransitionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A895 RID: 239765 RVA: 0x007E0B19 File Offset: 0x007DED19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A896 RID: 239766 RVA: 0x007E0B28 File Offset: 0x007DED28
		public TCsvTeleportTransitionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F23B RID: 62011
		// (get) Token: 0x0603A897 RID: 239767 RVA: 0x007E0B38 File Offset: 0x007DED38
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F23C RID: 62012
		// (get) Token: 0x0603A898 RID: 239768 RVA: 0x007E0B74 File Offset: 0x007DED74
		public ITeleportTransitionType_Union DataType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ITeleportTransitionType_Union.NONE;
				}
				return (ITeleportTransitionType_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A899 RID: 239769 RVA: 0x007E0BB0 File Offset: 0x007DEDB0
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603A89A RID: 239770 RVA: 0x007E0BF4 File Offset: 0x007DEDF4
		public ITeleportTransitionType DataAsITeleportTransitionType()
		{
			return this.Data<ITeleportTransitionType>().Value;
		}

		// Token: 0x0603A89B RID: 239771 RVA: 0x007E0C10 File Offset: 0x007DEE10
		public ITeleportTransitionWithMp4 DataAsITeleportTransitionWithMp4()
		{
			return this.Data<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x0603A89C RID: 239772 RVA: 0x007E0C2C File Offset: 0x007DEE2C
		public ITeleportTransitionWithEffect DataAsITeleportTransitionWithEffect()
		{
			return this.Data<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x0603A89D RID: 239773 RVA: 0x007E0C48 File Offset: 0x007DEE48
		public ITeleportTransitionWithCenterText DataAsITeleportTransitionWithCenterText()
		{
			return this.Data<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x0603A89E RID: 239774 RVA: 0x007E0C64 File Offset: 0x007DEE64
		public ITeleportTransitionWithFadeInScreen DataAsITeleportTransitionWithFadeInScreen()
		{
			return this.Data<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x0603A89F RID: 239775 RVA: 0x007E0C80 File Offset: 0x007DEE80
		public ITeleportTransitionInDigitalScreen DataAsITeleportTransitionInDigitalScreen()
		{
			return this.Data<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x0603A8A0 RID: 239776 RVA: 0x007E0C9C File Offset: 0x007DEE9C
		public ITeleportTransitionWithCustomLoading DataAsITeleportTransitionWithCustomLoading()
		{
			return this.Data<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x0603A8A1 RID: 239777 RVA: 0x007E0CB8 File Offset: 0x007DEEB8
		public ITeleportTransitionWithSpecialCustomLoading DataAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.Data<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x0603A8A2 RID: 239778 RVA: 0x007E0CD4 File Offset: 0x007DEED4
		public ITeleportTransitionWithPlayFlow DataAsITeleportTransitionWithPlayFlow()
		{
			return this.Data<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x0603A8A3 RID: 239779 RVA: 0x007E0CF0 File Offset: 0x007DEEF0
		public ITeleportTransitionWithCustomScreen DataAsITeleportTransitionWithCustomScreen()
		{
			return this.Data<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x0603A8A4 RID: 239780 RVA: 0x007E0D0C File Offset: 0x007DEF0C
		public ITeleportTransitionInSeamlessType DataAsITeleportTransitionInSeamlessType()
		{
			return this.Data<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x0603A8A5 RID: 239781 RVA: 0x007E0D28 File Offset: 0x007DEF28
		public ITeleportTransitionWithCharacterDisplay DataAsITeleportTransitionWithCharacterDisplay()
		{
			return this.Data<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x0603A8A6 RID: 239782 RVA: 0x007E0D43 File Offset: 0x007DEF43
		public static Offset<TCsvTeleportTransitionData> CreateTCsvTeleportTransitionData(FlatBufferBuilder builder, int Id = 0, ITeleportTransitionType_Union Data_type = ITeleportTransitionType_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvTeleportTransitionData.AddData(builder, DataOffset);
			TCsvTeleportTransitionData.AddId(builder, Id);
			TCsvTeleportTransitionData.AddDataType(builder, Data_type);
			return TCsvTeleportTransitionData.EndTCsvTeleportTransitionData(builder);
		}

		// Token: 0x0603A8A7 RID: 239783 RVA: 0x007E0D67 File Offset: 0x007DEF67
		public static void StartTCsvTeleportTransitionData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603A8A8 RID: 239784 RVA: 0x007E0D70 File Offset: 0x007DEF70
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0603A8A9 RID: 239785 RVA: 0x007E0D7B File Offset: 0x007DEF7B
		public static void AddDataType(FlatBufferBuilder builder, ITeleportTransitionType_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x0603A8AA RID: 239786 RVA: 0x007E0D86 File Offset: 0x007DEF86
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x0603A8AB RID: 239787 RVA: 0x007E0D91 File Offset: 0x007DEF91
		public static Offset<TCsvTeleportTransitionData> EndTCsvTeleportTransitionData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTeleportTransitionData>(builder.EndTable());
		}

		// Token: 0x0603A8AC RID: 239788 RVA: 0x007E0DA0 File Offset: 0x007DEFA0
		public TCsvTeleportTransitionDataT UnPack()
		{
			TCsvTeleportTransitionDataT tcsvTeleportTransitionDataT = new TCsvTeleportTransitionDataT();
			this.UnPackTo(tcsvTeleportTransitionDataT);
			return tcsvTeleportTransitionDataT;
		}

		// Token: 0x0603A8AD RID: 239789 RVA: 0x007E0DBC File Offset: 0x007DEFBC
		public void UnPackTo(TCsvTeleportTransitionDataT _o)
		{
			_o.Id = this.Id;
			_o.Data = new ITeleportTransitionType_UnionUnion();
			_o.Data.Type = this.DataType;
			switch (this.DataType)
			{
			case ITeleportTransitionType_Union.ITeleportTransitionType:
				_o.Data.Value = ((this.Data<ITeleportTransitionType>() != null) ? this.Data<ITeleportTransitionType>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithMp4:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithMp4>() != null) ? this.Data<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithEffect:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithEffect>() != null) ? this.Data<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCenterText:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithCenterText>() != null) ? this.Data<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithFadeInScreen:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithFadeInScreen>() != null) ? this.Data<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionInDigitalScreen:
				_o.Data.Value = ((this.Data<ITeleportTransitionInDigitalScreen>() != null) ? this.Data<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCustomLoading:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithCustomLoading>() != null) ? this.Data<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithSpecialCustomLoading:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.Data<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithPlayFlow:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithPlayFlow>() != null) ? this.Data<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCustomScreen:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithCustomScreen>() != null) ? this.Data<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionInSeamlessType:
				_o.Data.Value = ((this.Data<ITeleportTransitionInSeamlessType>() != null) ? this.Data<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				return;
			case ITeleportTransitionType_Union.ITeleportTransitionWithCharacterDisplay:
				_o.Data.Value = ((this.Data<ITeleportTransitionWithCharacterDisplay>() != null) ? this.Data<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603A8AE RID: 239790 RVA: 0x007E10CC File Offset: 0x007DF2CC
		public static Offset<TCsvTeleportTransitionData> Pack(FlatBufferBuilder builder, TCsvTeleportTransitionDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TCsvTeleportTransitionData>);
			}
			ITeleportTransitionType_Union data_type = (_o.Data == null) ? ITeleportTransitionType_Union.NONE : _o.Data.Type;
			int dataOffset = (_o.Data == null) ? 0 : ITeleportTransitionType_UnionUnion.Pack(builder, _o.Data);
			return TCsvTeleportTransitionData.CreateTCsvTeleportTransitionData(builder, _o.Id, data_type, dataOffset);
		}

		// Token: 0x04013710 RID: 79632
		private Table __p;
	}
}
