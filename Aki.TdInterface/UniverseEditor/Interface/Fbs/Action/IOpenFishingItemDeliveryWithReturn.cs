using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735E RID: 29534
	public struct IOpenFishingItemDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D898 RID: 55448
		// (get) Token: 0x0603388A RID: 211082 RVA: 0x006F20B8 File Offset: 0x006F02B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603388B RID: 211083 RVA: 0x006F20C5 File Offset: 0x006F02C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603388C RID: 211084 RVA: 0x006F20CC File Offset: 0x006F02CC
		public static IOpenFishingItemDeliveryWithReturn GetRootAsIOpenFishingItemDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenFishingItemDeliveryWithReturn.GetRootAsIOpenFishingItemDeliveryWithReturn(_bb, default(IOpenFishingItemDeliveryWithReturn));
		}

		// Token: 0x0603388D RID: 211085 RVA: 0x006F20E8 File Offset: 0x006F02E8
		public static IOpenFishingItemDeliveryWithReturn GetRootAsIOpenFishingItemDeliveryWithReturn(ByteBuffer _bb, IOpenFishingItemDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603388E RID: 211086 RVA: 0x006F2105 File Offset: 0x006F0305
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603388F RID: 211087 RVA: 0x006F2114 File Offset: 0x006F0314
		public IOpenFishingItemDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D899 RID: 55449
		// (get) Token: 0x06033890 RID: 211088 RVA: 0x006F2124 File Offset: 0x006F0324
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

		// Token: 0x1700D89A RID: 55450
		// (get) Token: 0x06033891 RID: 211089 RVA: 0x006F2160 File Offset: 0x006F0360
		public int PresetId
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

		// Token: 0x1700D89B RID: 55451
		// (get) Token: 0x06033892 RID: 211090 RVA: 0x006F219C File Offset: 0x006F039C
		public TVarRef ReturnVarType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033893 RID: 211091 RVA: 0x006F21D8 File Offset: 0x006F03D8
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033894 RID: 211092 RVA: 0x006F2220 File Offset: 0x006F0420
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033895 RID: 211093 RVA: 0x006F223C File Offset: 0x006F043C
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033896 RID: 211094 RVA: 0x006F2258 File Offset: 0x006F0458
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033897 RID: 211095 RVA: 0x006F2274 File Offset: 0x006F0474
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033898 RID: 211096 RVA: 0x006F2290 File Offset: 0x006F0490
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033899 RID: 211097 RVA: 0x006F22AB File Offset: 0x006F04AB
		public static Offset<IOpenFishingItemDeliveryWithReturn> CreateIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int PresetId = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenFishingItemDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenFishingItemDeliveryWithReturn.AddPresetId(builder, PresetId);
			IOpenFishingItemDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenFishingItemDeliveryWithReturn.AddType(builder, Type);
			return IOpenFishingItemDeliveryWithReturn.EndIOpenFishingItemDeliveryWithReturn(builder);
		}

		// Token: 0x0603389A RID: 211098 RVA: 0x006F22D7 File Offset: 0x006F04D7
		public static void StartIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603389B RID: 211099 RVA: 0x006F22E0 File Offset: 0x006F04E0
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603389C RID: 211100 RVA: 0x006F22EB File Offset: 0x006F04EB
		public static void AddPresetId(FlatBufferBuilder builder, int presetId)
		{
			builder.AddInt(1, presetId, 0);
		}

		// Token: 0x0603389D RID: 211101 RVA: 0x006F22F6 File Offset: 0x006F04F6
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603389E RID: 211102 RVA: 0x006F2301 File Offset: 0x006F0501
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603389F RID: 211103 RVA: 0x006F230C File Offset: 0x006F050C
		public static Offset<IOpenFishingItemDeliveryWithReturn> EndIOpenFishingItemDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenFishingItemDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x060338A0 RID: 211104 RVA: 0x006F231C File Offset: 0x006F051C
		public IOpenFishingItemDeliveryWithReturnT UnPack()
		{
			IOpenFishingItemDeliveryWithReturnT openFishingItemDeliveryWithReturnT = new IOpenFishingItemDeliveryWithReturnT();
			this.UnPackTo(openFishingItemDeliveryWithReturnT);
			return openFishingItemDeliveryWithReturnT;
		}

		// Token: 0x060338A1 RID: 211105 RVA: 0x006F2338 File Offset: 0x006F0538
		public void UnPackTo(IOpenFishingItemDeliveryWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.PresetId = this.PresetId;
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

		// Token: 0x060338A2 RID: 211106 RVA: 0x006F24B0 File Offset: 0x006F06B0
		public static Offset<IOpenFishingItemDeliveryWithReturn> Pack(FlatBufferBuilder builder, IOpenFishingItemDeliveryWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenFishingItemDeliveryWithReturn>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenFishingItemDeliveryWithReturn.CreateIOpenFishingItemDeliveryWithReturn(builder, _o.Type, _o.PresetId, returnVar_type, returnVarOffset);
		}

		// Token: 0x04012444 RID: 74820
		private Table __p;
	}
}
