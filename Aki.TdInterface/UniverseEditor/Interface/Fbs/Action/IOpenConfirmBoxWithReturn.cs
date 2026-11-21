using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735B RID: 29531
	public struct IOpenConfirmBoxWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D891 RID: 55441
		// (get) Token: 0x06033869 RID: 211049 RVA: 0x006F1B9C File Offset: 0x006EFD9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603386A RID: 211050 RVA: 0x006F1BA9 File Offset: 0x006EFDA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603386B RID: 211051 RVA: 0x006F1BB0 File Offset: 0x006EFDB0
		public static IOpenConfirmBoxWithReturn GetRootAsIOpenConfirmBoxWithReturn(ByteBuffer _bb)
		{
			return IOpenConfirmBoxWithReturn.GetRootAsIOpenConfirmBoxWithReturn(_bb, default(IOpenConfirmBoxWithReturn));
		}

		// Token: 0x0603386C RID: 211052 RVA: 0x006F1BCC File Offset: 0x006EFDCC
		public static IOpenConfirmBoxWithReturn GetRootAsIOpenConfirmBoxWithReturn(ByteBuffer _bb, IOpenConfirmBoxWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603386D RID: 211053 RVA: 0x006F1BE9 File Offset: 0x006EFDE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603386E RID: 211054 RVA: 0x006F1BF8 File Offset: 0x006EFDF8
		public IOpenConfirmBoxWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D892 RID: 55442
		// (get) Token: 0x0603386F RID: 211055 RVA: 0x006F1C08 File Offset: 0x006EFE08
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

		// Token: 0x1700D893 RID: 55443
		// (get) Token: 0x06033870 RID: 211056 RVA: 0x006F1C44 File Offset: 0x006EFE44
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

		// Token: 0x1700D894 RID: 55444
		// (get) Token: 0x06033871 RID: 211057 RVA: 0x006F1C80 File Offset: 0x006EFE80
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

		// Token: 0x06033872 RID: 211058 RVA: 0x006F1CBC File Offset: 0x006EFEBC
		public TTable? ReturnVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033873 RID: 211059 RVA: 0x006F1D04 File Offset: 0x006EFF04
		public IConstVarRef ReturnVarAsIConstVarRef()
		{
			return this.ReturnVar<IConstVarRef>().Value;
		}

		// Token: 0x06033874 RID: 211060 RVA: 0x006F1D20 File Offset: 0x006EFF20
		public IGlobalVarRef ReturnVarAsIGlobalVarRef()
		{
			return this.ReturnVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06033875 RID: 211061 RVA: 0x006F1D3C File Offset: 0x006EFF3C
		public IOtherVarRef ReturnVarAsIOtherVarRef()
		{
			return this.ReturnVar<IOtherVarRef>().Value;
		}

		// Token: 0x06033876 RID: 211062 RVA: 0x006F1D58 File Offset: 0x006EFF58
		public ISelfVarRef ReturnVarAsISelfVarRef()
		{
			return this.ReturnVar<ISelfVarRef>().Value;
		}

		// Token: 0x06033877 RID: 211063 RVA: 0x006F1D74 File Offset: 0x006EFF74
		public ISystemVarRef ReturnVarAsISystemVarRef()
		{
			return this.ReturnVar<ISystemVarRef>().Value;
		}

		// Token: 0x06033878 RID: 211064 RVA: 0x006F1D8F File Offset: 0x006EFF8F
		public static Offset<IOpenConfirmBoxWithReturn> CreateIOpenConfirmBoxWithReturn(FlatBufferBuilder builder, ESystemType Type = ESystemType.Shop, int Id = 0, TVarRef ReturnVar_type = TVarRef.NONE, int ReturnVarOffset = 0)
		{
			builder.StartTable(4);
			IOpenConfirmBoxWithReturn.AddReturnVar(builder, ReturnVarOffset);
			IOpenConfirmBoxWithReturn.AddId(builder, Id);
			IOpenConfirmBoxWithReturn.AddReturnVarType(builder, ReturnVar_type);
			IOpenConfirmBoxWithReturn.AddType(builder, Type);
			return IOpenConfirmBoxWithReturn.EndIOpenConfirmBoxWithReturn(builder);
		}

		// Token: 0x06033879 RID: 211065 RVA: 0x006F1DBB File Offset: 0x006EFFBB
		public static void StartIOpenConfirmBoxWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603387A RID: 211066 RVA: 0x006F1DC4 File Offset: 0x006EFFC4
		public static void AddType(FlatBufferBuilder builder, ESystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603387B RID: 211067 RVA: 0x006F1DCF File Offset: 0x006EFFCF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0603387C RID: 211068 RVA: 0x006F1DDA File Offset: 0x006EFFDA
		public static void AddReturnVarType(FlatBufferBuilder builder, TVarRef returnVarType)
		{
			builder.AddByte(2, (byte)returnVarType, 0);
		}

		// Token: 0x0603387D RID: 211069 RVA: 0x006F1DE5 File Offset: 0x006EFFE5
		public static void AddReturnVar(FlatBufferBuilder builder, int returnVarOffset)
		{
			builder.AddOffset(3, returnVarOffset, 0);
		}

		// Token: 0x0603387E RID: 211070 RVA: 0x006F1DF0 File Offset: 0x006EFFF0
		public static Offset<IOpenConfirmBoxWithReturn> EndIOpenConfirmBoxWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenConfirmBoxWithReturn>(builder.EndTable());
		}

		// Token: 0x0603387F RID: 211071 RVA: 0x006F1E00 File Offset: 0x006F0000
		public IOpenConfirmBoxWithReturnT UnPack()
		{
			IOpenConfirmBoxWithReturnT openConfirmBoxWithReturnT = new IOpenConfirmBoxWithReturnT();
			this.UnPackTo(openConfirmBoxWithReturnT);
			return openConfirmBoxWithReturnT;
		}

		// Token: 0x06033880 RID: 211072 RVA: 0x006F1E1C File Offset: 0x006F001C
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

		// Token: 0x06033881 RID: 211073 RVA: 0x006F1F94 File Offset: 0x006F0194
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

		// Token: 0x04012440 RID: 74816
		private Table __p;
	}
}
