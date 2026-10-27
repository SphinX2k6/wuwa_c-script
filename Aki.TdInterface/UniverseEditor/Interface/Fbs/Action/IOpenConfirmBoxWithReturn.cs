using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF7 RID: 27639
	public struct IOpenConfirmBoxWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CD83 RID: 52611
		// (get) Token: 0x06030949 RID: 198985 RVA: 0x00698208 File Offset: 0x00696408
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603094A RID: 198986 RVA: 0x00698215 File Offset: 0x00696415
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603094B RID: 198987 RVA: 0x0069821C File Offset: 0x0069641C
		public static IOpenConfirmBoxWithReturn GetRootAsIOpenConfirmBoxWithReturn(ByteBuffer _bb)
		{
			return IOpenConfirmBoxWithReturn.GetRootAsIOpenConfirmBoxWithReturn(_bb, default(IOpenConfirmBoxWithReturn));
		}

		// Token: 0x0603094C RID: 198988 RVA: 0x00698238 File Offset: 0x00696438
		public static IOpenConfirmBoxWithReturn GetRootAsIOpenConfirmBoxWithReturn(ByteBuffer _bb, IOpenConfirmBoxWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603094D RID: 198989 RVA: 0x00698255 File Offset: 0x00696455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603094E RID: 198990 RVA: 0x00698264 File Offset: 0x00696464
		public IOpenConfirmBoxWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD84 RID: 52612
		// (get) Token: 0x0603094F RID: 198991 RVA: 0x00698274 File Offset: 0x00696474
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

		// Token: 0x1700CD85 RID: 52613
		// (get) Token: 0x06030950 RID: 198992 RVA: 0x006982B0 File Offset: 0x006964B0
		public int Id
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

		// Token: 0x1700CD86 RID: 52614
		// (get) Token: 0x06030951 RID: 198993 RVA: 0x006982EC File Offset: 0x006964EC
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

		// Token: 0x06030952 RID: 198994 RVA: 0x00698328 File Offset: 0x00696528
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030953 RID: 198995 RVA: 0x00698370 File Offset: 0x00696570
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06030954 RID: 198996 RVA: 0x0069838C File Offset: 0x0069658C
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06030955 RID: 198997 RVA: 0x006983A8 File Offset: 0x006965A8
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06030956 RID: 198998 RVA: 0x006983C4 File Offset: 0x006965C4
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06030957 RID: 198999 RVA: 0x006983E0 File Offset: 0x006965E0
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06030958 RID: 199000 RVA: 0x006983FB File Offset: 0x006965FB
		public static Offset<IOpenConfirmBoxWithReturn> CreateIOpenConfirmBoxWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenConfirmBoxWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenConfirmBoxWithReturn.AddId(builder, Id);
			IOpenConfirmBoxWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenConfirmBoxWithReturn.AddType(builder, Type);
			return IOpenConfirmBoxWithReturn.EndIOpenConfirmBoxWithReturn(builder);
		}

		// Token: 0x06030959 RID: 199001 RVA: 0x00698427 File Offset: 0x00696627
		public static void StartIOpenConfirmBoxWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603095A RID: 199002 RVA: 0x00698430 File Offset: 0x00696630
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603095B RID: 199003 RVA: 0x0069843B File Offset: 0x0069663B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603095C RID: 199004 RVA: 0x00698446 File Offset: 0x00696646
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603095D RID: 199005 RVA: 0x00698451 File Offset: 0x00696651
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603095E RID: 199006 RVA: 0x0069845C File Offset: 0x0069665C
		public static Offset<IOpenConfirmBoxWithReturn> EndIOpenConfirmBoxWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenConfirmBoxWithReturn>(builder.EndTable());
		}

		// Token: 0x0603095F RID: 199007 RVA: 0x0069846C File Offset: 0x0069666C
		public IOpenConfirmBoxWithReturnT UnPack()
		{
			IOpenConfirmBoxWithReturnT openConfirmBoxWithReturnT = new IOpenConfirmBoxWithReturnT();
			this.UnPackTo(openConfirmBoxWithReturnT);
			return openConfirmBoxWithReturnT;
		}

		// Token: 0x06030960 RID: 199008 RVA: 0x00698488 File Offset: 0x00696688
		public void UnPackTo(IOpenConfirmBoxWithReturnT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
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

		// Token: 0x06030961 RID: 199009 RVA: 0x00698600 File Offset: 0x00696800
		public static Offset<IOpenConfirmBoxWithReturn> Pack(FlatBufferBuilder builder, IOpenConfirmBoxWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenConfirmBoxWithReturn>);
			}
			TVarRef returnVar_type = (_o.ReturnVar == null) ? TVarRef.NONE : _o.ReturnVar.Type;
			int returnVarOffset = (_o.ReturnVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReturnVar);
			return IOpenConfirmBoxWithReturn.CreateIOpenConfirmBoxWithReturn(builder, _o.Type, _o.Id, returnVar_type, returnVarOffset);
		}

		// Token: 0x040114F0 RID: 70896
		private Table __p;
	}
}
