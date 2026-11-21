using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073AF RID: 29615
	public struct IOpenVillageInfrDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D98A RID: 55690
		// (get) Token: 0x06033C9D RID: 212125 RVA: 0x006FC4C4 File Offset: 0x006FA6C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C9E RID: 212126 RVA: 0x006FC4D1 File Offset: 0x006FA6D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C9F RID: 212127 RVA: 0x006FC4D8 File Offset: 0x006FA6D8
		public static IOpenVillageInfrDeliveryWithReturn GetRootAsIOpenVillageInfrDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenVillageInfrDeliveryWithReturn.GetRootAsIOpenVillageInfrDeliveryWithReturn(_bb, default(IOpenVillageInfrDeliveryWithReturn));
		}

		// Token: 0x06033CA0 RID: 212128 RVA: 0x006FC4F4 File Offset: 0x006FA6F4
		public static IOpenVillageInfrDeliveryWithReturn GetRootAsIOpenVillageInfrDeliveryWithReturn(ByteBuffer _bb, IOpenVillageInfrDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CA1 RID: 212129 RVA: 0x006FC511 File Offset: 0x006FA711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CA2 RID: 212130 RVA: 0x006FC520 File Offset: 0x006FA720
		public IOpenVillageInfrDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D98B RID: 55691
		// (get) Token: 0x06033CA3 RID: 212131 RVA: 0x006FC530 File Offset: 0x006FA730
		public ESystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemType.Shop;
				}
				return (ESystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D98C RID: 55692
		// (get) Token: 0x06033CA4 RID: 212132 RVA: 0x006FC56C File Offset: 0x006FA76C
		public TVillageInfrBuildType DeliveryTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVillageInfrBuildType.NONE;
				}
				return (TVillageInfrBuildType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CA5 RID: 212133 RVA: 0x006FC5A8 File Offset: 0x006FA7A8
		public TTable? DeliveryType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033CA6 RID: 212134 RVA: 0x006FC5EC File Offset: 0x006FA7EC
		public IVillageInfrTreeProcess DeliveryTypeAsIVillageInfrTreeProcess()
		{
			return this.DeliveryType<IVillageInfrTreeProcess>().Value;
		}

		// Token: 0x06033CA7 RID: 212135 RVA: 0x006FC608 File Offset: 0x006FA808
		public IVillageInfrVillageLevel DeliveryTypeAsIVillageInfrVillageLevel()
		{
			return this.DeliveryType<IVillageInfrVillageLevel>().Value;
		}

		// Token: 0x1700D98D RID: 55693
		// (get) Token: 0x06033CA8 RID: 212136 RVA: 0x006FC624 File Offset: 0x006FA824
		public TVarRef ReturnVarType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033CA9 RID: 212137 RVA: 0x006FC664 File Offset: 0x006FA864
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033CAA RID: 212138 RVA: 0x006FC6AC File Offset: 0x006FA8AC
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033CAB RID: 212139 RVA: 0x006FC6C8 File Offset: 0x006FA8C8
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033CAC RID: 212140 RVA: 0x006FC6E4 File Offset: 0x006FA8E4
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033CAD RID: 212141 RVA: 0x006FC700 File Offset: 0x006FA900
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033CAE RID: 212142 RVA: 0x006FC71C File Offset: 0x006FA91C
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033CAF RID: 212143 RVA: 0x006FC737 File Offset: 0x006FA937
		public static Offset<IOpenVillageInfrDeliveryWithReturn> CreateIOpenVillageInfrDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, TVillageInfrBuildType DeliveryType_type = TVillageInfrBuildType.NONE, int DeliveryTypeOffset = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(5);
			IOpenVillageInfrDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenVillageInfrDeliveryWithReturn.AddDeliveryType(builder, DeliveryTypeOffset);
			IOpenVillageInfrDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenVillageInfrDeliveryWithReturn.AddDeliveryTypeType(builder, DeliveryType_type);
			IOpenVillageInfrDeliveryWithReturn.AddType(builder, Type);
			return IOpenVillageInfrDeliveryWithReturn.EndIOpenVillageInfrDeliveryWithReturn(builder);
		}

		// Token: 0x06033CB0 RID: 212144 RVA: 0x006FC76B File Offset: 0x006FA96B
		public static void StartIOpenVillageInfrDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033CB1 RID: 212145 RVA: 0x006FC774 File Offset: 0x006FA974
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033CB2 RID: 212146 RVA: 0x006FC77F File Offset: 0x006FA97F
		public static void AddDeliveryTypeType(FlatBufferBuilder builder, TVillageInfrBuildType deliveryTypeType)
		{
			builder.AddByte(1, (byte)deliveryTypeType, 0);
		}

		// Token: 0x06033CB3 RID: 212147 RVA: 0x006FC78A File Offset: 0x006FA98A
		public static void AddDeliveryType(FlatBufferBuilder builder, int deliveryTypeOffset)
		{
			builder.AddOffset(2, deliveryTypeOffset, 0);
		}

		// Token: 0x06033CB4 RID: 212148 RVA: 0x006FC795 File Offset: 0x006FA995
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(3, (byte)returnVarType, 0);
		}

		// Token: 0x06033CB5 RID: 212149 RVA: 0x006FC7A0 File Offset: 0x006FA9A0
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(4, returnVarOffset, 0);
		}

		// Token: 0x06033CB6 RID: 212150 RVA: 0x006FC7AB File Offset: 0x006FA9AB
		public static Offset<IOpenVillageInfrDeliveryWithReturn> EndIOpenVillageInfrDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenVillageInfrDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x06033CB7 RID: 212151 RVA: 0x006FC7B8 File Offset: 0x006FA9B8
		public IOpenVillageInfrDeliveryWithReturnT UnPack()
		{
			IOpenVillageInfrDeliveryWithReturnT openVillageInfrDeliveryWithReturnT = new IOpenVillageInfrDeliveryWithReturnT();
			this.UnPackTo(openVillageInfrDeliveryWithReturnT);
			return openVillageInfrDeliveryWithReturnT;
		}

		// Token: 0x06033CB8 RID: 212152 RVA: 0x006FC7D4 File Offset: 0x006FA9D4
		public void UnPackTo(IOpenVillageInfrDeliveryWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.DeliveryType = new TVillageInfrBuildTypeUnion();
			_o.DeliveryType.Type = this.DeliveryTypeType;
			TVillageInfrBuildType deliveryTypeType = this.DeliveryTypeType;
			if (deliveryTypeType != TVillageInfrBuildType.IVillageInfrTreeProcess)
			{
				if (deliveryTypeType == TVillageInfrBuildType.IVillageInfrVillageLevel)
				{
					_o.DeliveryType.Value = ((this.DeliveryType<IVillageInfrVillageLevel>() != null) ? this.DeliveryType<IVillageInfrVillageLevel>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DeliveryType.Value = ((this.DeliveryType<IVillageInfrTreeProcess>() != null) ? this.DeliveryType<IVillageInfrTreeProcess>().Value.UnPack() : null);
			}
			_o.ReturnVar = new TVarRefUnion();
			_o.ReturnVar.Type = this.ReturnVarType;
			switch (this.ReturnVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IConstVarRef>() != null) ? this.ReturnVar<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IGlobalVarRef>() != null) ? this.ReturnVar<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<IOtherVarRef>() != null) ? this.ReturnVar<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISelfVarRef>() != null) ? this.ReturnVar<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ReturnVar.Value = ((this.ReturnVar<ISystemVarRef>() != null) ? this.ReturnVar<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06033CB9 RID: 212153 RVA: 0x006FC9E0 File Offset: 0x006FABE0
		public static Offset<IOpenVillageInfrDeliveryWithReturn> Pack(FlatBufferBuilder builder, IOpenVillageInfrDeliveryWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenVillageInfrDeliveryWithReturn>);
			}
			TVillageInfrBuildType deliveryType_type = (_o.DeliveryType == null) ? TVillageInfrBuildType.NONE : _o.DeliveryType.Type;
			int deliveryTypeOffset = (_o.DeliveryType == null) ? 0 : TVillageInfrBuildTypeUnion.Pack(builder, _o.DeliveryType);
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenVillageInfrDeliveryWithReturn.CreateIOpenVillageInfrDeliveryWithReturn(builder, _o.Type, deliveryType_type, deliveryTypeOffset, returnVar_type, returnVarOffset);
		}

		// Token: 0x040124DD RID: 74973
		private Table __p;
	}
}
