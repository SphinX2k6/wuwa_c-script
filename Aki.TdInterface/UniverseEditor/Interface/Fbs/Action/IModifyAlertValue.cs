using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EC RID: 29164
	public struct IModifyAlertValue : IFlatbufferObject
	{
		// Token: 0x1700D57E RID: 54654
		// (get) Token: 0x06032BB4 RID: 207796 RVA: 0x006DA4D7 File Offset: 0x006D86D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032BB5 RID: 207797 RVA: 0x006DA4E4 File Offset: 0x006D86E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032BB6 RID: 207798 RVA: 0x006DA4EC File Offset: 0x006D86EC
		public static IModifyAlertValue GetRootAsIModifyAlertValue(ByteBuffer _bb)
		{
			return IModifyAlertValue.GetRootAsIModifyAlertValue(_bb, default(IModifyAlertValue));
		}

		// Token: 0x06032BB7 RID: 207799 RVA: 0x006DA508 File Offset: 0x006D8708
		public static IModifyAlertValue GetRootAsIModifyAlertValue(ByteBuffer _bb, IModifyAlertValue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032BB8 RID: 207800 RVA: 0x006DA525 File Offset: 0x006D8725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032BB9 RID: 207801 RVA: 0x006DA534 File Offset: 0x006D8734
		public IModifyAlertValue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D57F RID: 54655
		// (get) Token: 0x06032BBA RID: 207802 RVA: 0x006DA544 File Offset: 0x006D8744
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

		// Token: 0x1700D580 RID: 54656
		// (get) Token: 0x06032BBB RID: 207803 RVA: 0x006DA580 File Offset: 0x006D8780
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

		// Token: 0x1700D581 RID: 54657
		// (get) Token: 0x06032BBC RID: 207804 RVA: 0x006DA5BC File Offset: 0x006D87BC
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

		// Token: 0x06032BBD RID: 207805 RVA: 0x006DA5F8 File Offset: 0x006D87F8
		public TTable? SetType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032BBE RID: 207806 RVA: 0x006DA640 File Offset: 0x006D8840
		public IAddOrSubAlertValue SetTypeAsIAddOrSubAlertValue()
		{
			return this.SetType<IAddOrSubAlertValue>().Value;
		}

		// Token: 0x06032BBF RID: 207807 RVA: 0x006DA65C File Offset: 0x006D885C
		public ICustomAlertValue SetTypeAsICustomAlertValue()
		{
			return this.SetType<ICustomAlertValue>().Value;
		}

		// Token: 0x06032BC0 RID: 207808 RVA: 0x006DA678 File Offset: 0x006D8878
		public IMaxAlertValue SetTypeAsIMaxAlertValue()
		{
			return this.SetType<IMaxAlertValue>().Value;
		}

		// Token: 0x06032BC1 RID: 207809 RVA: 0x006DA694 File Offset: 0x006D8894
		public IMinAlertValue SetTypeAsIMinAlertValue()
		{
			return this.SetType<IMinAlertValue>().Value;
		}

		// Token: 0x1700D582 RID: 54658
		// (get) Token: 0x06032BC2 RID: 207810 RVA: 0x006DA6B0 File Offset: 0x006D88B0
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

		// Token: 0x06032BC3 RID: 207811 RVA: 0x006DA6F0 File Offset: 0x006D88F0
		public TTable? ChangeSpeed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032BC4 RID: 207812 RVA: 0x006DA738 File Offset: 0x006D8938
		public IAddOrSubAlertValueChangeSpeed ChangeSpeedAsIAddOrSubAlertValueChangeSpeed()
		{
			return this.ChangeSpeed<IAddOrSubAlertValueChangeSpeed>().Value;
		}

		// Token: 0x06032BC5 RID: 207813 RVA: 0x006DA754 File Offset: 0x006D8954
		public ICustomAlertValueChangeSpeed ChangeSpeedAsICustomAlertValueChangeSpeed()
		{
			return this.ChangeSpeed<ICustomAlertValueChangeSpeed>().Value;
		}

		// Token: 0x06032BC6 RID: 207814 RVA: 0x006DA76F File Offset: 0x006D896F
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

		// Token: 0x06032BC7 RID: 207815 RVA: 0x006DA7AB File Offset: 0x006D89AB
		public static void StartIModifyAlertValue(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06032BC8 RID: 207816 RVA: 0x006DA7B4 File Offset: 0x006D89B4
		public static void AddType(FlatBufferBuilder builder, EAlertSystemOption type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032BC9 RID: 207817 RVA: 0x006DA7BF File Offset: 0x006D89BF
		public static void AddAreaId(FlatBufferBuilder builder, int areaId)
		{
			builder.AddInt(1, areaId, 0);
		}

		// Token: 0x06032BCA RID: 207818 RVA: 0x006DA7CA File Offset: 0x006D89CA
		public static void AddSetTypeType(FlatBufferBuilder builder, TSetAlertValueType setTypeType)
		{
			builder.AddByte(2, (byte)setTypeType, 0);
		}

		// Token: 0x06032BCB RID: 207819 RVA: 0x006DA7D5 File Offset: 0x006D89D5
		public static void AddSetType(FlatBufferBuilder builder, int setTypeOffset)
		{
			builder.AddOffset(3, setTypeOffset, 0);
		}

		// Token: 0x06032BCC RID: 207820 RVA: 0x006DA7E0 File Offset: 0x006D89E0
		public static void AddChangeSpeedType(FlatBufferBuilder builder, TAlertValueChangeSpeed changeSpeedType)
		{
			builder.AddByte(4, (byte)changeSpeedType, 0);
		}

		// Token: 0x06032BCD RID: 207821 RVA: 0x006DA7EB File Offset: 0x006D89EB
		public static void AddChangeSpeed(FlatBufferBuilder builder, int changeSpeedOffset)
		{
			builder.AddOffset(5, changeSpeedOffset, 0);
		}

		// Token: 0x06032BCE RID: 207822 RVA: 0x006DA7F6 File Offset: 0x006D89F6
		public static Offset<IModifyAlertValue> EndIModifyAlertValue(FlatBufferBuilder builder)
		{
			return new Offset<IModifyAlertValue>(builder.EndTable());
		}

		// Token: 0x06032BCF RID: 207823 RVA: 0x006DA804 File Offset: 0x006D8A04
		public IModifyAlertValueT UnPack()
		{
			IModifyAlertValueT modifyAlertValueT = new IModifyAlertValueT();
			this.UnPackTo(modifyAlertValueT);
			return modifyAlertValueT;
		}

		// Token: 0x06032BD0 RID: 207824 RVA: 0x006DA820 File Offset: 0x006D8A20
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

		// Token: 0x06032BD1 RID: 207825 RVA: 0x006DAA04 File Offset: 0x006D8C04
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

		// Token: 0x04012206 RID: 74246
		private Table __p;
	}
}
