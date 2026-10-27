using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200769B RID: 30363
	public struct TCsvTeleportTransitionData : IFlatbufferObject
	{
		// Token: 0x1700E5FE RID: 58878
		// (get) Token: 0x060373EE RID: 226286 RVA: 0x0077C978 File Offset: 0x0077AB78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060373EF RID: 226287 RVA: 0x0077C985 File Offset: 0x0077AB85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060373F0 RID: 226288 RVA: 0x0077C98C File Offset: 0x0077AB8C
		public static TCsvTeleportTransitionData GetRootAsTCsvTeleportTransitionData(ByteBuffer _bb)
		{
			return TCsvTeleportTransitionData.GetRootAsTCsvTeleportTransitionData(_bb, default(TCsvTeleportTransitionData));
		}

		// Token: 0x060373F1 RID: 226289 RVA: 0x0077C9A8 File Offset: 0x0077ABA8
		public static TCsvTeleportTransitionData GetRootAsTCsvTeleportTransitionData(ByteBuffer _bb, TCsvTeleportTransitionData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060373F2 RID: 226290 RVA: 0x0077C9C5 File Offset: 0x0077ABC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060373F3 RID: 226291 RVA: 0x0077C9D4 File Offset: 0x0077ABD4
		public TCsvTeleportTransitionData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5FF RID: 58879
		// (get) Token: 0x060373F4 RID: 226292 RVA: 0x0077C9E4 File Offset: 0x0077ABE4
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

		// Token: 0x1700E600 RID: 58880
		// (get) Token: 0x060373F5 RID: 226293 RVA: 0x0077CA20 File Offset: 0x0077AC20
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

		// Token: 0x060373F6 RID: 226294 RVA: 0x0077CA5C File Offset: 0x0077AC5C
		public TTable? Data<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060373F7 RID: 226295 RVA: 0x0077CAA0 File Offset: 0x0077ACA0
		public ITeleportTransitionType DataAsITeleportTransitionType()
		{
			return this.Data<ITeleportTransitionType>().Value;
		}

		// Token: 0x060373F8 RID: 226296 RVA: 0x0077CABC File Offset: 0x0077ACBC
		public ITeleportTransitionWithMp4 DataAsITeleportTransitionWithMp4()
		{
			return this.Data<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x060373F9 RID: 226297 RVA: 0x0077CAD8 File Offset: 0x0077ACD8
		public ITeleportTransitionWithEffect DataAsITeleportTransitionWithEffect()
		{
			return this.Data<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x060373FA RID: 226298 RVA: 0x0077CAF4 File Offset: 0x0077ACF4
		public ITeleportTransitionWithCenterText DataAsITeleportTransitionWithCenterText()
		{
			return this.Data<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x060373FB RID: 226299 RVA: 0x0077CB10 File Offset: 0x0077AD10
		public ITeleportTransitionWithFadeInScreen DataAsITeleportTransitionWithFadeInScreen()
		{
			return this.Data<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x060373FC RID: 226300 RVA: 0x0077CB2C File Offset: 0x0077AD2C
		public ITeleportTransitionInDigitalScreen DataAsITeleportTransitionInDigitalScreen()
		{
			return this.Data<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x060373FD RID: 226301 RVA: 0x0077CB48 File Offset: 0x0077AD48
		public ITeleportTransitionWithCustomLoading DataAsITeleportTransitionWithCustomLoading()
		{
			return this.Data<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x060373FE RID: 226302 RVA: 0x0077CB64 File Offset: 0x0077AD64
		public ITeleportTransitionWithSpecialCustomLoading DataAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.Data<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x060373FF RID: 226303 RVA: 0x0077CB80 File Offset: 0x0077AD80
		public ITeleportTransitionWithPlayFlow DataAsITeleportTransitionWithPlayFlow()
		{
			return this.Data<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06037400 RID: 226304 RVA: 0x0077CB9C File Offset: 0x0077AD9C
		public ITeleportTransitionWithCustomScreen DataAsITeleportTransitionWithCustomScreen()
		{
			return this.Data<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06037401 RID: 226305 RVA: 0x0077CBB8 File Offset: 0x0077ADB8
		public ITeleportTransitionInSeamlessType DataAsITeleportTransitionInSeamlessType()
		{
			return this.Data<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06037402 RID: 226306 RVA: 0x0077CBD4 File Offset: 0x0077ADD4
		public ITeleportTransitionWithCharacterDisplay DataAsITeleportTransitionWithCharacterDisplay()
		{
			return this.Data<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06037403 RID: 226307 RVA: 0x0077CBEF File Offset: 0x0077ADEF
		public static Offset<TCsvTeleportTransitionData> CreateTCsvTeleportTransitionData(FlatBufferBuilder builder, int Id = 0, ITeleportTransitionType_Union Data_type = ITeleportTransitionType_Union.NONE, int DataOffset = 0)
		{
			builder.StartTable(3);
			TCsvTeleportTransitionData.AddData(builder, DataOffset);
			TCsvTeleportTransitionData.AddId(builder, Id);
			TCsvTeleportTransitionData.AddDataType(builder, Data_type);
			return TCsvTeleportTransitionData.EndTCsvTeleportTransitionData(builder);
		}

		// Token: 0x06037404 RID: 226308 RVA: 0x0077CC13 File Offset: 0x0077AE13
		public static void StartTCsvTeleportTransitionData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06037405 RID: 226309 RVA: 0x0077CC1C File Offset: 0x0077AE1C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06037406 RID: 226310 RVA: 0x0077CC27 File Offset: 0x0077AE27
		public static void AddDataType(FlatBufferBuilder builder, ITeleportTransitionType_Union dataType)
		{
			builder.AddByte(1, (byte)dataType, 0);
		}

		// Token: 0x06037407 RID: 226311 RVA: 0x0077CC32 File Offset: 0x0077AE32
		public static void AddData(FlatBufferBuilder builder, int dataOffset)
		{
			builder.AddOffset(2, dataOffset, 0);
		}

		// Token: 0x06037408 RID: 226312 RVA: 0x0077CC3D File Offset: 0x0077AE3D
		public static Offset<TCsvTeleportTransitionData> EndTCsvTeleportTransitionData(FlatBufferBuilder builder)
		{
			return new Offset<TCsvTeleportTransitionData>(builder.EndTable());
		}

		// Token: 0x06037409 RID: 226313 RVA: 0x0077CC4C File Offset: 0x0077AE4C
		public TCsvTeleportTransitionDataT UnPack()
		{
			TCsvTeleportTransitionDataT tcsvTeleportTransitionDataT = new TCsvTeleportTransitionDataT();
			this.UnPackTo(tcsvTeleportTransitionDataT);
			return tcsvTeleportTransitionDataT;
		}

		// Token: 0x0603740A RID: 226314 RVA: 0x0077CC68 File Offset: 0x0077AE68
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

		// Token: 0x0603740B RID: 226315 RVA: 0x0077CF78 File Offset: 0x0077B178
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

		// Token: 0x040126C7 RID: 75463
		private Table __p;
	}
}
