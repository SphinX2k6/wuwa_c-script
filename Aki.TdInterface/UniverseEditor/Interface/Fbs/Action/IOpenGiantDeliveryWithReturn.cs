using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BFD RID: 27645
	public struct IOpenGiantDeliveryWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CD91 RID: 52625
		// (get) Token: 0x0603098B RID: 199051 RVA: 0x00698C40 File Offset: 0x00696E40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603098C RID: 199052 RVA: 0x00698C4D File Offset: 0x00696E4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603098D RID: 199053 RVA: 0x00698C54 File Offset: 0x00696E54
		public static IOpenGiantDeliveryWithReturn GetRootAsIOpenGiantDeliveryWithReturn(ByteBuffer _bb)
		{
			return IOpenGiantDeliveryWithReturn.GetRootAsIOpenGiantDeliveryWithReturn(_bb, default(IOpenGiantDeliveryWithReturn));
		}

		// Token: 0x0603098E RID: 199054 RVA: 0x00698C70 File Offset: 0x00696E70
		public static IOpenGiantDeliveryWithReturn GetRootAsIOpenGiantDeliveryWithReturn(ByteBuffer _bb, IOpenGiantDeliveryWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603098F RID: 199055 RVA: 0x00698C8D File Offset: 0x00696E8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030990 RID: 199056 RVA: 0x00698C9C File Offset: 0x00696E9C
		public IOpenGiantDeliveryWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD92 RID: 52626
		// (get) Token: 0x06030991 RID: 199057 RVA: 0x00698CAC File Offset: 0x00696EAC
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

		// Token: 0x1700CD93 RID: 52627
		// (get) Token: 0x06030992 RID: 199058 RVA: 0x00698CE8 File Offset: 0x00696EE8
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

		// Token: 0x1700CD94 RID: 52628
		// (get) Token: 0x06030993 RID: 199059 RVA: 0x00698D24 File Offset: 0x00696F24
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

		// Token: 0x06030994 RID: 199060 RVA: 0x00698D60 File Offset: 0x00696F60
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030995 RID: 199061 RVA: 0x00698DA8 File Offset: 0x00696FA8
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030996 RID: 199062 RVA: 0x00698DC4 File Offset: 0x00696FC4
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030997 RID: 199063 RVA: 0x00698DE0 File Offset: 0x00696FE0
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030998 RID: 199064 RVA: 0x00698DFC File Offset: 0x00696FFC
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030999 RID: 199065 RVA: 0x00698E18 File Offset: 0x00697018
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x0603099A RID: 199066 RVA: 0x00698E33 File Offset: 0x00697033
		public static Offset<IOpenGiantDeliveryWithReturn> CreateIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, EGiantEcoType EcoType = EGiantEcoType.Fire, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenGiantDeliveryWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenGiantDeliveryWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenGiantDeliveryWithReturn.AddEcoType(builder, EcoType);
			IOpenGiantDeliveryWithReturn.AddType(builder, Type);
			return IOpenGiantDeliveryWithReturn.EndIOpenGiantDeliveryWithReturn(builder);
		}

		// Token: 0x0603099B RID: 199067 RVA: 0x00698E5F File Offset: 0x0069705F
		public static void StartIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603099C RID: 199068 RVA: 0x00698E68 File Offset: 0x00697068
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603099D RID: 199069 RVA: 0x00698E73 File Offset: 0x00697073
		public static void AddEcoType(FlatBufferBuilder builder, EGiantEcoType ecoType)
		{
			builder.AddByte(1, (byte)ecoType, 0);
		}

		// Token: 0x0603099E RID: 199070 RVA: 0x00698E7E File Offset: 0x0069707E
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603099F RID: 199071 RVA: 0x00698E89 File Offset: 0x00697089
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x060309A0 RID: 199072 RVA: 0x00698E94 File Offset: 0x00697094
		public static Offset<IOpenGiantDeliveryWithReturn> EndIOpenGiantDeliveryWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenGiantDeliveryWithReturn>(builder.EndTable());
		}

		// Token: 0x060309A1 RID: 199073 RVA: 0x00698EA4 File Offset: 0x006970A4
		public IOpenGiantDeliveryWithReturnT UnPack()
		{
			IOpenGiantDeliveryWithReturnT openGiantDeliveryWithReturnT = new IOpenGiantDeliveryWithReturnT();
			this.UnPackTo(openGiantDeliveryWithReturnT);
			return openGiantDeliveryWithReturnT;
		}

		// Token: 0x060309A2 RID: 199074 RVA: 0x00698EC0 File Offset: 0x006970C0
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

		// Token: 0x060309A3 RID: 199075 RVA: 0x00699038 File Offset: 0x00697238
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

		// Token: 0x040114F8 RID: 70904
		private Table __p;
	}
}
