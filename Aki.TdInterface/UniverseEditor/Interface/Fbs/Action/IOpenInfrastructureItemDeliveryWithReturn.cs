using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736D RID: 29549
	public struct IOpenInfrastructureItemDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D8BD RID: 55485
		// (get) Token: 0x06033925 RID: 211237 RVA: 0x006F35D4 File Offset: 0x006F17D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033926 RID: 211238 RVA: 0x006F35E1 File Offset: 0x006F17E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033927 RID: 211239 RVA: 0x006F35E8 File Offset: 0x006F17E8
		public static IOpenInfrastructureItemDeliveryWithReturn GetRootAsIOpenInfrastructureItemDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenInfrastructureItemDeliveryWithReturn.GetRootAsIOpenInfrastructureItemDeliveryWithReturn(_bb, default(IOpenInfrastructureItemDeliveryWithReturn));
		}

		// Token: 0x06033928 RID: 211240 RVA: 0x006F3604 File Offset: 0x006F1804
		public static IOpenInfrastructureItemDeliveryWithReturn GetRootAsIOpenInfrastructureItemDeliveryWithReturn(ByteBuffer _bb, IOpenInfrastructureItemDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033929 RID: 211241 RVA: 0x006F3621 File Offset: 0x006F1821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603392A RID: 211242 RVA: 0x006F3630 File Offset: 0x006F1830
		public IOpenInfrastructureItemDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8BE RID: 55486
		// (get) Token: 0x0603392B RID: 211243 RVA: 0x006F3640 File Offset: 0x006F1840
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

		// Token: 0x1700D8BF RID: 55487
		// (get) Token: 0x0603392C RID: 211244 RVA: 0x006F367C File Offset: 0x006F187C
		public TInfrastructureItemDeliveryOption DeliveryTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TInfrastructureItemDeliveryOption.NONE;
				}
				return (TInfrastructureItemDeliveryOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603392D RID: 211245 RVA: 0x006F36B8 File Offset: 0x006F18B8
		public TTable? DeliveryType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603392E RID: 211246 RVA: 0x006F36FC File Offset: 0x006F18FC
		public IInfrastructureItemDeliveryObservatory DeliveryTypeAsIInfrastructureItemDeliveryObservatory()
		{
			return this.DeliveryType<IInfrastructureItemDeliveryObservatory>().Value;
		}

		// Token: 0x0603392F RID: 211247 RVA: 0x006F3718 File Offset: 0x006F1918
		public IInfrastructureItemDeliveryRoadBuild DeliveryTypeAsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.DeliveryType<IInfrastructureItemDeliveryRoadBuild>().Value;
		}

		// Token: 0x1700D8C0 RID: 55488
		// (get) Token: 0x06033930 RID: 211248 RVA: 0x006F3734 File Offset: 0x006F1934
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

		// Token: 0x06033931 RID: 211249 RVA: 0x006F3774 File Offset: 0x006F1974
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033932 RID: 211250 RVA: 0x006F37BC File Offset: 0x006F19BC
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033933 RID: 211251 RVA: 0x006F37D8 File Offset: 0x006F19D8
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033934 RID: 211252 RVA: 0x006F37F4 File Offset: 0x006F19F4
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033935 RID: 211253 RVA: 0x006F3810 File Offset: 0x006F1A10
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033936 RID: 211254 RVA: 0x006F382C File Offset: 0x006F1A2C
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033937 RID: 211255 RVA: 0x006F3847 File Offset: 0x006F1A47
		public static Offset<IOpenInfrastructureItemDeliveryWithReturn> CreateIOpenInfrastructureItemDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, TInfrastructureItemDeliveryOption DeliveryType_type = TInfrastructureItemDeliveryOption.NONE, int DeliveryTypeOffset = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(5);
			IOpenInfrastructureItemDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenInfrastructureItemDeliveryWithReturn.AddDeliveryType(builder, DeliveryTypeOffset);
			IOpenInfrastructureItemDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenInfrastructureItemDeliveryWithReturn.AddDeliveryTypeType(builder, DeliveryType_type);
			IOpenInfrastructureItemDeliveryWithReturn.AddType(builder, Type);
			return IOpenInfrastructureItemDeliveryWithReturn.EndIOpenInfrastructureItemDeliveryWithReturn(builder);
		}

		// Token: 0x06033938 RID: 211256 RVA: 0x006F387B File Offset: 0x006F1A7B
		public static void StartIOpenInfrastructureItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033939 RID: 211257 RVA: 0x006F3884 File Offset: 0x006F1A84
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603393A RID: 211258 RVA: 0x006F388F File Offset: 0x006F1A8F
		public static void AddDeliveryTypeType(FlatBufferBuilder builder, TInfrastructureItemDeliveryOption deliveryTypeType)
		{
			builder.AddByte(1, (byte)deliveryTypeType, 0);
		}

		// Token: 0x0603393B RID: 211259 RVA: 0x006F389A File Offset: 0x006F1A9A
		public static void AddDeliveryType(FlatBufferBuilder builder, int deliveryTypeOffset)
		{
			builder.AddOffset(2, deliveryTypeOffset, 0);
		}

		// Token: 0x0603393C RID: 211260 RVA: 0x006F38A5 File Offset: 0x006F1AA5
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(3, (byte)returnVarType, 0);
		}

		// Token: 0x0603393D RID: 211261 RVA: 0x006F38B0 File Offset: 0x006F1AB0
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(4, returnVarOffset, 0);
		}

		// Token: 0x0603393E RID: 211262 RVA: 0x006F38BB File Offset: 0x006F1ABB
		public static Offset<IOpenInfrastructureItemDeliveryWithReturn> EndIOpenInfrastructureItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenInfrastructureItemDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x0603393F RID: 211263 RVA: 0x006F38C8 File Offset: 0x006F1AC8
		public IOpenInfrastructureItemDeliveryWithReturnT UnPack()
		{
			IOpenInfrastructureItemDeliveryWithReturnT openInfrastructureItemDeliveryWithReturnT = new IOpenInfrastructureItemDeliveryWithReturnT();
			this.UnPackTo(openInfrastructureItemDeliveryWithReturnT);
			return openInfrastructureItemDeliveryWithReturnT;
		}

		// Token: 0x06033940 RID: 211264 RVA: 0x006F38E4 File Offset: 0x006F1AE4
		public void UnPackTo(IOpenInfrastructureItemDeliveryWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.DeliveryType = new TInfrastructureItemDeliveryOptionUnion();
			_o.DeliveryType.Type = this.DeliveryTypeType;
			TInfrastructureItemDeliveryOption deliveryTypeType = this.DeliveryTypeType;
			if (deliveryTypeType != TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryObservatory)
			{
				if (deliveryTypeType == TInfrastructureItemDeliveryOption.IInfrastructureItemDeliveryRoadBuild)
				{
					_o.DeliveryType.Value = ((this.DeliveryType<IInfrastructureItemDeliveryRoadBuild>() != null) ? this.DeliveryType<IInfrastructureItemDeliveryRoadBuild>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DeliveryType.Value = ((this.DeliveryType<IInfrastructureItemDeliveryObservatory>() != null) ? this.DeliveryType<IInfrastructureItemDeliveryObservatory>().Value.UnPack() : null);
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

		// Token: 0x06033941 RID: 211265 RVA: 0x006F3AF0 File Offset: 0x006F1CF0
		public static Offset<IOpenInfrastructureItemDeliveryWithReturn> Pack(FlatBufferBuilder builder, IOpenInfrastructureItemDeliveryWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenInfrastructureItemDeliveryWithReturn>);
			}
			TInfrastructureItemDeliveryOption deliveryType_type = (_o.DeliveryType == null) ? TInfrastructureItemDeliveryOption.NONE : _o.DeliveryType.Type;
			int deliveryTypeOffset = (_o.DeliveryType == null) ? 0 : TInfrastructureItemDeliveryOptionUnion.Pack(builder, _o.DeliveryType);
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenInfrastructureItemDeliveryWithReturn.CreateIOpenInfrastructureItemDeliveryWithReturn(builder, _o.Type, deliveryType_type, deliveryTypeOffset, returnVar_type, returnVarOffset);
		}

		// Token: 0x04012459 RID: 74841
		private Table __p;
	}
}
