using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C48 RID: 27720
	public struct IOpenVillageInfrDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CE6F RID: 52847
		// (get) Token: 0x06030D42 RID: 200002 RVA: 0x006A1FC4 File Offset: 0x006A01C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030D43 RID: 200003 RVA: 0x006A1FD1 File Offset: 0x006A01D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030D44 RID: 200004 RVA: 0x006A1FD8 File Offset: 0x006A01D8
		public static IOpenVillageInfrDeliveryWithReturn GetRootAsIOpenVillageInfrDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenVillageInfrDeliveryWithReturn.GetRootAsIOpenVillageInfrDeliveryWithReturn(_bb, default(IOpenVillageInfrDeliveryWithReturn));
		}

		// Token: 0x06030D45 RID: 200005 RVA: 0x006A1FF4 File Offset: 0x006A01F4
		public static IOpenVillageInfrDeliveryWithReturn GetRootAsIOpenVillageInfrDeliveryWithReturn(ByteBuffer _bb, IOpenVillageInfrDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030D46 RID: 200006 RVA: 0x006A2011 File Offset: 0x006A0211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030D47 RID: 200007 RVA: 0x006A2020 File Offset: 0x006A0220
		public IOpenVillageInfrDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE70 RID: 52848
		// (get) Token: 0x06030D48 RID: 200008 RVA: 0x006A2030 File Offset: 0x006A0230
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

		// Token: 0x1700CE71 RID: 52849
		// (get) Token: 0x06030D49 RID: 200009 RVA: 0x006A206C File Offset: 0x006A026C
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

		// Token: 0x06030D4A RID: 200010 RVA: 0x006A20A8 File Offset: 0x006A02A8
		public TTable? DeliveryType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030D4B RID: 200011 RVA: 0x006A20EC File Offset: 0x006A02EC
		public IVillageInfrTreeProcess DeliveryTypeAsIVillageInfrTreeProcess()
		{
			return this.DeliveryType<IVillageInfrTreeProcess>().Value;
		}

		// Token: 0x06030D4C RID: 200012 RVA: 0x006A2108 File Offset: 0x006A0308
		public IVillageInfrVillageLevel DeliveryTypeAsIVillageInfrVillageLevel()
		{
			return this.DeliveryType<IVillageInfrVillageLevel>().Value;
		}

		// Token: 0x1700CE72 RID: 52850
		// (get) Token: 0x06030D4D RID: 200013 RVA: 0x006A2124 File Offset: 0x006A0324
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

		// Token: 0x06030D4E RID: 200014 RVA: 0x006A2164 File Offset: 0x006A0364
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030D4F RID: 200015 RVA: 0x006A21AC File Offset: 0x006A03AC
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030D50 RID: 200016 RVA: 0x006A21C8 File Offset: 0x006A03C8
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030D51 RID: 200017 RVA: 0x006A21E4 File Offset: 0x006A03E4
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030D52 RID: 200018 RVA: 0x006A2200 File Offset: 0x006A0400
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030D53 RID: 200019 RVA: 0x006A221C File Offset: 0x006A041C
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030D54 RID: 200020 RVA: 0x006A2237 File Offset: 0x006A0437
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

		// Token: 0x06030D55 RID: 200021 RVA: 0x006A226B File Offset: 0x006A046B
		public static void StartIOpenVillageInfrDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030D56 RID: 200022 RVA: 0x006A2274 File Offset: 0x006A0474
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030D57 RID: 200023 RVA: 0x006A227F File Offset: 0x006A047F
		public static void AddDeliveryTypeType(FlatBufferBuilder builder, TVillageInfrBuildType deliveryTypeType)
		{
			builder.AddByte(1, (byte)deliveryTypeType, 0);
		}

		// Token: 0x06030D58 RID: 200024 RVA: 0x006A228A File Offset: 0x006A048A
		public static void AddDeliveryType(FlatBufferBuilder builder, int deliveryTypeOffset)
		{
			builder.AddOffset(2, deliveryTypeOffset, 0);
		}

		// Token: 0x06030D59 RID: 200025 RVA: 0x006A2295 File Offset: 0x006A0495
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(3, (byte)returnVarType, 0);
		}

		// Token: 0x06030D5A RID: 200026 RVA: 0x006A22A0 File Offset: 0x006A04A0
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(4, returnVarOffset, 0);
		}

		// Token: 0x06030D5B RID: 200027 RVA: 0x006A22AB File Offset: 0x006A04AB
		public static Offset<IOpenVillageInfrDeliveryWithReturn> EndIOpenVillageInfrDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenVillageInfrDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x06030D5C RID: 200028 RVA: 0x006A22B8 File Offset: 0x006A04B8
		public IOpenVillageInfrDeliveryWithReturnT UnPack()
		{
			IOpenVillageInfrDeliveryWithReturnT openVillageInfrDeliveryWithReturnT = new IOpenVillageInfrDeliveryWithReturnT();
			this.UnPackTo(openVillageInfrDeliveryWithReturnT);
			return openVillageInfrDeliveryWithReturnT;
		}

		// Token: 0x06030D5D RID: 200029 RVA: 0x006A22D4 File Offset: 0x006A04D4
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

		// Token: 0x06030D5E RID: 200030 RVA: 0x006A24E0 File Offset: 0x006A06E0
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

		// Token: 0x04011585 RID: 71045
		private Table __p;
	}
}
