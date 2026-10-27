using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C09 RID: 27657
	public struct IOpenInfrastructureItemDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CDAF RID: 52655
		// (get) Token: 0x06030A05 RID: 199173 RVA: 0x00699C40 File Offset: 0x00697E40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030A06 RID: 199174 RVA: 0x00699C4D File Offset: 0x00697E4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030A07 RID: 199175 RVA: 0x00699C54 File Offset: 0x00697E54
		public static IOpenInfrastructureItemDeliveryWithReturn GetRootAsIOpenInfrastructureItemDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenInfrastructureItemDeliveryWithReturn.GetRootAsIOpenInfrastructureItemDeliveryWithReturn(_bb, default(IOpenInfrastructureItemDeliveryWithReturn));
		}

		// Token: 0x06030A08 RID: 199176 RVA: 0x00699C70 File Offset: 0x00697E70
		public static IOpenInfrastructureItemDeliveryWithReturn GetRootAsIOpenInfrastructureItemDeliveryWithReturn(ByteBuffer _bb, IOpenInfrastructureItemDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030A09 RID: 199177 RVA: 0x00699C8D File Offset: 0x00697E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030A0A RID: 199178 RVA: 0x00699C9C File Offset: 0x00697E9C
		public IOpenInfrastructureItemDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDB0 RID: 52656
		// (get) Token: 0x06030A0B RID: 199179 RVA: 0x00699CAC File Offset: 0x00697EAC
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

		// Token: 0x1700CDB1 RID: 52657
		// (get) Token: 0x06030A0C RID: 199180 RVA: 0x00699CE8 File Offset: 0x00697EE8
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

		// Token: 0x06030A0D RID: 199181 RVA: 0x00699D24 File Offset: 0x00697F24
		public TTable? DeliveryType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A0E RID: 199182 RVA: 0x00699D68 File Offset: 0x00697F68
		public IInfrastructureItemDeliveryObservatory DeliveryTypeAsIInfrastructureItemDeliveryObservatory()
		{
			return this.DeliveryType<IInfrastructureItemDeliveryObservatory>().Value;
		}

		// Token: 0x06030A0F RID: 199183 RVA: 0x00699D84 File Offset: 0x00697F84
		public IInfrastructureItemDeliveryRoadBuild DeliveryTypeAsIInfrastructureItemDeliveryRoadBuild()
		{
			return this.DeliveryType<IInfrastructureItemDeliveryRoadBuild>().Value;
		}

		// Token: 0x1700CDB2 RID: 52658
		// (get) Token: 0x06030A10 RID: 199184 RVA: 0x00699DA0 File Offset: 0x00697FA0
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

		// Token: 0x06030A11 RID: 199185 RVA: 0x00699DE0 File Offset: 0x00697FE0
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030A12 RID: 199186 RVA: 0x00699E28 File Offset: 0x00698028
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030A13 RID: 199187 RVA: 0x00699E44 File Offset: 0x00698044
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030A14 RID: 199188 RVA: 0x00699E60 File Offset: 0x00698060
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030A15 RID: 199189 RVA: 0x00699E7C File Offset: 0x0069807C
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030A16 RID: 199190 RVA: 0x00699E98 File Offset: 0x00698098
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030A17 RID: 199191 RVA: 0x00699EB3 File Offset: 0x006980B3
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

		// Token: 0x06030A18 RID: 199192 RVA: 0x00699EE7 File Offset: 0x006980E7
		public static void StartIOpenInfrastructureItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030A19 RID: 199193 RVA: 0x00699EF0 File Offset: 0x006980F0
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030A1A RID: 199194 RVA: 0x00699EFB File Offset: 0x006980FB
		public static void AddDeliveryTypeType(FlatBufferBuilder builder, TInfrastructureItemDeliveryOption deliveryTypeType)
		{
			builder.AddByte(1, (byte)deliveryTypeType, 0);
		}

		// Token: 0x06030A1B RID: 199195 RVA: 0x00699F06 File Offset: 0x00698106
		public static void AddDeliveryType(FlatBufferBuilder builder, int deliveryTypeOffset)
		{
			builder.AddOffset(2, deliveryTypeOffset, 0);
		}

		// Token: 0x06030A1C RID: 199196 RVA: 0x00699F11 File Offset: 0x00698111
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(3, (byte)returnVarType, 0);
		}

		// Token: 0x06030A1D RID: 199197 RVA: 0x00699F1C File Offset: 0x0069811C
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(4, returnVarOffset, 0);
		}

		// Token: 0x06030A1E RID: 199198 RVA: 0x00699F27 File Offset: 0x00698127
		public static Offset<IOpenInfrastructureItemDeliveryWithReturn> EndIOpenInfrastructureItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenInfrastructureItemDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x06030A1F RID: 199199 RVA: 0x00699F34 File Offset: 0x00698134
		public IOpenInfrastructureItemDeliveryWithReturnT UnPack()
		{
			IOpenInfrastructureItemDeliveryWithReturnT openInfrastructureItemDeliveryWithReturnT = new IOpenInfrastructureItemDeliveryWithReturnT();
			this.UnPackTo(openInfrastructureItemDeliveryWithReturnT);
			return openInfrastructureItemDeliveryWithReturnT;
		}

		// Token: 0x06030A20 RID: 199200 RVA: 0x00699F50 File Offset: 0x00698150
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

		// Token: 0x06030A21 RID: 199201 RVA: 0x0069A15C File Offset: 0x0069835C
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

		// Token: 0x04011509 RID: 70921
		private Table __p;
	}
}
