using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007361 RID: 29537
	public struct IOpenGiantDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D89F RID: 55455
		// (get) Token: 0x060338AB RID: 211115 RVA: 0x006F25D4 File Offset: 0x006F07D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060338AC RID: 211116 RVA: 0x006F25E1 File Offset: 0x006F07E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060338AD RID: 211117 RVA: 0x006F25E8 File Offset: 0x006F07E8
		public static IOpenGiantDeliveryWithReturn GetRootAsIOpenGiantDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenGiantDeliveryWithReturn.GetRootAsIOpenGiantDeliveryWithReturn(_bb, default(IOpenGiantDeliveryWithReturn));
		}

		// Token: 0x060338AE RID: 211118 RVA: 0x006F2604 File Offset: 0x006F0804
		public static IOpenGiantDeliveryWithReturn GetRootAsIOpenGiantDeliveryWithReturn(ByteBuffer _bb, IOpenGiantDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060338AF RID: 211119 RVA: 0x006F2621 File Offset: 0x006F0821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060338B0 RID: 211120 RVA: 0x006F2630 File Offset: 0x006F0830
		public IOpenGiantDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8A0 RID: 55456
		// (get) Token: 0x060338B1 RID: 211121 RVA: 0x006F2640 File Offset: 0x006F0840
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

		// Token: 0x1700D8A1 RID: 55457
		// (get) Token: 0x060338B2 RID: 211122 RVA: 0x006F267C File Offset: 0x006F087C
		public EGiantEcoType EcoType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGiantEcoType.Fire;
				}
				return (EGiantEcoType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8A2 RID: 55458
		// (get) Token: 0x060338B3 RID: 211123 RVA: 0x006F26B8 File Offset: 0x006F08B8
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

		// Token: 0x060338B4 RID: 211124 RVA: 0x006F26F4 File Offset: 0x006F08F4
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060338B5 RID: 211125 RVA: 0x006F273C File Offset: 0x006F093C
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x060338B6 RID: 211126 RVA: 0x006F2758 File Offset: 0x006F0958
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x060338B7 RID: 211127 RVA: 0x006F2774 File Offset: 0x006F0974
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x060338B8 RID: 211128 RVA: 0x006F2790 File Offset: 0x006F0990
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x060338B9 RID: 211129 RVA: 0x006F27AC File Offset: 0x006F09AC
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x060338BA RID: 211130 RVA: 0x006F27C7 File Offset: 0x006F09C7
		public static Offset<IOpenGiantDeliveryWithReturn> CreateIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, EGiantEcoType EcoType = EGiantEcoType.Fire, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenGiantDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenGiantDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenGiantDeliveryWithReturn.AddEcoType(builder, EcoType);
			IOpenGiantDeliveryWithReturn.AddType(builder, Type);
			return IOpenGiantDeliveryWithReturn.EndIOpenGiantDeliveryWithReturn(builder);
		}

		// Token: 0x060338BB RID: 211131 RVA: 0x006F27F3 File Offset: 0x006F09F3
		public static void StartIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060338BC RID: 211132 RVA: 0x006F27FC File Offset: 0x006F09FC
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060338BD RID: 211133 RVA: 0x006F2807 File Offset: 0x006F0A07
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x060338BE RID: 211134 RVA: 0x006F2812 File Offset: 0x006F0A12
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x060338BF RID: 211135 RVA: 0x006F281D File Offset: 0x006F0A1D
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x060338C0 RID: 211136 RVA: 0x006F2828 File Offset: 0x006F0A28
		public static Offset<IOpenGiantDeliveryWithReturn> EndIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGiantDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x060338C1 RID: 211137 RVA: 0x006F2838 File Offset: 0x006F0A38
		public IOpenGiantDeliveryWithReturnT UnPack()
		{
			IOpenGiantDeliveryWithReturnT openGiantDeliveryWithReturnT = new IOpenGiantDeliveryWithReturnT();
			this.UnPackTo(openGiantDeliveryWithReturnT);
			return openGiantDeliveryWithReturnT;
		}

		// Token: 0x060338C2 RID: 211138 RVA: 0x006F2854 File Offset: 0x006F0A54
		public void UnPackTo(IOpenGiantDeliveryWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.EcoType = this.EcoType;
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

		// Token: 0x060338C3 RID: 211139 RVA: 0x006F29CC File Offset: 0x006F0BCC
		public static Offset<IOpenGiantDeliveryWithReturn> Pack(FlatBufferBuilder builder, IOpenGiantDeliveryWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenGiantDeliveryWithReturn>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenGiantDeliveryWithReturn.CreateIOpenGiantDeliveryWithReturn(builder, _o.Type, _o.EcoType, returnVar_type, returnVarOffset);
		}

		// Token: 0x04012448 RID: 74824
		private Table __p;
	}
}
