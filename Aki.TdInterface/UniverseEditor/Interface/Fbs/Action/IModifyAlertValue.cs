using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABB RID: 27323
	public struct IModifyAlertValue : IFlatbufferObject
	{
		// Token: 0x1700CABB RID: 51899
		// (get) Token: 0x0602FE18 RID: 196120 RVA: 0x006835AF File Offset: 0x006817AF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FE19 RID: 196121 RVA: 0x006835BC File Offset: 0x006817BC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FE1A RID: 196122 RVA: 0x006835C4 File Offset: 0x006817C4
		public static IModifyAlertValue GetRootAsIModifyAlertValue(ByteBuffer _bb)
		{
			return IModifyAlertValue.GetRootAsIModifyAlertValue(_bb, default(IModifyAlertValue));
		}

		// Token: 0x0602FE1B RID: 196123 RVA: 0x006835E0 File Offset: 0x006817E0
		public static IModifyAlertValue GetRootAsIModifyAlertValue(ByteBuffer _bb, IModifyAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FE1C RID: 196124 RVA: 0x006835FD File Offset: 0x006817FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FE1D RID: 196125 RVA: 0x0068360C File Offset: 0x0068180C
		public IModifyAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CABC RID: 51900
		// (get) Token: 0x0602FE1E RID: 196126 RVA: 0x0068361C File Offset: 0x0068181C
		public EAlertSystemOption Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return (EAlertSystemOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CABD RID: 51901
		// (get) Token: 0x0602FE1F RID: 196127 RVA: 0x00683658 File Offset: 0x00681858
		public int AreaId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CABE RID: 51902
		// (get) Token: 0x0602FE20 RID: 196128 RVA: 0x00683694 File Offset: 0x00681894
		public TSetAlertValueType SetTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TSetAlertValueType.NONE;
				}
				return (TSetAlertValueType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE21 RID: 196129 RVA: 0x006836D0 File Offset: 0x006818D0
		public TTable? SetType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FE22 RID: 196130 RVA: 0x00683718 File Offset: 0x00681918
		public IAddOrSubAlertValue SetTypeAsIAddOrSubAlertValue()
		{
			return this.SetType<IAddOrSubAlertValue>().Value;
		}

		// Token: 0x0602FE23 RID: 196131 RVA: 0x00683734 File Offset: 0x00681934
		public ICustomAlertValue SetTypeAsICustomAlertValue()
		{
			return this.SetType<ICustomAlertValue>().Value;
		}

		// Token: 0x0602FE24 RID: 196132 RVA: 0x00683750 File Offset: 0x00681950
		public IMaxAlertValue SetTypeAsIMaxAlertValue()
		{
			return this.SetType<IMaxAlertValue>().Value;
		}

		// Token: 0x0602FE25 RID: 196133 RVA: 0x0068376C File Offset: 0x0068196C
		public IMinAlertValue SetTypeAsIMinAlertValue()
		{
			return this.SetType<IMinAlertValue>().Value;
		}

		// Token: 0x1700CABF RID: 51903
		// (get) Token: 0x0602FE26 RID: 196134 RVA: 0x00683788 File Offset: 0x00681988
		public TAlertValueChangeSpeed ChangeSpeedType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TAlertValueChangeSpeed.NONE;
				}
				return (TAlertValueChangeSpeed)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FE27 RID: 196135 RVA: 0x006837C8 File Offset: 0x006819C8
		public TTable? ChangeSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602FE28 RID: 196136 RVA: 0x00683810 File Offset: 0x00681A10
		public IAddOrSubAlertValueChangeSpeed ChangeSpeedAsIAddOrSubAlertValueChangeSpeed()
		{
			return this.ChangeSpeed<IAddOrSubAlertValueChangeSpeed>().Value;
		}

		// Token: 0x0602FE29 RID: 196137 RVA: 0x0068382C File Offset: 0x00681A2C
		public ICustomAlertValueChangeSpeed ChangeSpeedAsICustomAlertValueChangeSpeed()
		{
			return this.ChangeSpeed<ICustomAlertValueChangeSpeed>().Value;
		}

		// Token: 0x0602FE2A RID: 196138 RVA: 0x00683847 File Offset: 0x00681A47
		public static Offset<IModifyAlertValue> CreateIModifyAlertValue(FlatBufferBuilder builder, EAlertSystemOption Type = EAlertSystemOption.EnableAlertArea, int AreaId = 0, TSetAlertValueType SetType_type = TSetAlertValueType.NONE, int SetTypeOffset = 0, TAlertValueChangeSpeed ChangeSpeed_type = TAlertValueChangeSpeed.NONE, int ChangeSpeedOffset = 0)
		{
			builder.StartTable(6);
			IModifyAlertValue.AddChangeSpeed(builder, ChangeSpeedOffset);
			IModifyAlertValue.AddSetType(builder, SetTypeOffset);
			IModifyAlertValue.AddAreaId(builder, AreaId);
			IModifyAlertValue.AddChangeSpeedType(builder, ChangeSpeed_type);
			IModifyAlertValue.AddSetTypeType(builder, SetType_type);
			IModifyAlertValue.AddType(builder, Type);
			return IModifyAlertValue.EndIModifyAlertValue(builder);
		}

		// Token: 0x0602FE2B RID: 196139 RVA: 0x00683883 File Offset: 0x00681A83
		public static void StartIModifyAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602FE2C RID: 196140 RVA: 0x0068388C File Offset: 0x00681A8C
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FE2D RID: 196141 RVA: 0x00683897 File Offset: 0x00681A97
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x0602FE2E RID: 196142 RVA: 0x006838A2 File Offset: 0x00681AA2
		public static void AddSetTypeType(FlatBufferBuilder builder, TSetAlertValueType setTypeType)
		{
			builder.AddByte(2, (byte)setTypeType, 0);
		}

		// Token: 0x0602FE2F RID: 196143 RVA: 0x006838AD File Offset: 0x00681AAD
		public static void AddSetType(FlatBufferBuilder builder, int setTypeOffset)
		{
			builder.AddOffset(3, setTypeOffset, 0);
		}

		// Token: 0x0602FE30 RID: 196144 RVA: 0x006838B8 File Offset: 0x00681AB8
		public static void AddChangeSpeedType(FlatBufferBuilder builder, TAlertValueChangeSpeed changeSpeedType)
		{
			builder.AddByte(4, (byte)changeSpeedType, 0);
		}

		// Token: 0x0602FE31 RID: 196145 RVA: 0x006838C3 File Offset: 0x00681AC3
		public static void AddChangeSpeed(FlatBufferBuilder builder, int changeSpeedOffset)
		{
			builder.AddOffset(5, changeSpeedOffset, 0);
		}

		// Token: 0x0602FE32 RID: 196146 RVA: 0x006838CE File Offset: 0x00681ACE
		public static Offset<IModifyAlertValue> EndIModifyAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IModifyAlertValue>(builder.EndTable());
		}

		// Token: 0x0602FE33 RID: 196147 RVA: 0x006838DC File Offset: 0x00681ADC
		public IModifyAlertValueT UnPack()
		{
			IModifyAlertValueT modifyAlertValueT = new IModifyAlertValueT();
			this.UnPackTo(modifyAlertValueT);
			return modifyAlertValueT;
		}

		// Token: 0x0602FE34 RID: 196148 RVA: 0x006838F8 File Offset: 0x00681AF8
		public void UnPackTo(IModifyAlertValueT _o)
		{
			_o.Type = this.Type;
			_o.AreaId = this.AreaId;
			_o.SetType = new TSetAlertValueTypeUnion();
			_o.SetType.Type = this.SetTypeType;
			switch (this.SetTypeType)
			{
			case TSetAlertValueType.IAddOrSubAlertValue:
				_o.SetType.Value = ((this.SetType<IAddOrSubAlertValue>() != null) ? this.SetType<IAddOrSubAlertValue>().Value.UnPack() : null);
				break;
			case TSetAlertValueType.ICustomAlertValue:
				_o.SetType.Value = ((this.SetType<ICustomAlertValue>() != null) ? this.SetType<ICustomAlertValue>().Value.UnPack() : null);
				break;
			case TSetAlertValueType.IMaxAlertValue:
				_o.SetType.Value = ((this.SetType<IMaxAlertValue>() != null) ? this.SetType<IMaxAlertValue>().Value.UnPack() : null);
				break;
			case TSetAlertValueType.IMinAlertValue:
				_o.SetType.Value = ((this.SetType<IMinAlertValue>() != null) ? this.SetType<IMinAlertValue>().Value.UnPack() : null);
				break;
			}
			_o.ChangeSpeed = new TAlertValueChangeSpeedUnion();
			_o.ChangeSpeed.Type = this.ChangeSpeedType;
			TAlertValueChangeSpeed changeSpeedType = this.ChangeSpeedType;
			if (changeSpeedType == TAlertValueChangeSpeed.IAddOrSubAlertValueChangeSpeed)
			{
				_o.ChangeSpeed.Value = ((this.ChangeSpeed<IAddOrSubAlertValueChangeSpeed>() != null) ? this.ChangeSpeed<IAddOrSubAlertValueChangeSpeed>().Value.UnPack() : null);
				return;
			}
			if (changeSpeedType != TAlertValueChangeSpeed.ICustomAlertValueChangeSpeed)
			{
				return;
			}
			_o.ChangeSpeed.Value = ((this.ChangeSpeed<ICustomAlertValueChangeSpeed>() != null) ? this.ChangeSpeed<ICustomAlertValueChangeSpeed>().Value.UnPack() : null);
		}

		// Token: 0x0602FE35 RID: 196149 RVA: 0x00683ADC File Offset: 0x00681CDC
		public static Offset<IModifyAlertValue> Pack(FlatBufferBuilder builder, IModifyAlertValueT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyAlertValue>);
			}
			TSetAlertValueType setType_type = (_o.SetType == null) ? TSetAlertValueType.NONE : _o.SetType.Type;
			int setTypeOffset = (_o.SetType == null) ? 0 : TSetAlertValueTypeUnion.Pack(builder, _o.SetType);
			TAlertValueChangeSpeed changeSpeed_type = (_o.ChangeSpeed == null) ? TAlertValueChangeSpeed.NONE : _o.ChangeSpeed.Type;
			int changeSpeedOffset = (_o.ChangeSpeed == null) ? 0 : TAlertValueChangeSpeedUnion.Pack(builder, _o.ChangeSpeed);
			return IModifyAlertValue.CreateIModifyAlertValue(builder, _o.Type, _o.AreaId, setType_type, setTypeOffset, changeSpeed_type, changeSpeedOffset);
		}

		// Token: 0x040112FA RID: 70394
		private Table __p;
	}
}
