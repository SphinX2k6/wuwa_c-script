using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E5 RID: 16613
	public struct IRoleTowerSystemVar : IFlatbufferObject
	{
		// Token: 0x1700751B RID: 29979
		// (get) Token: 0x06018350 RID: 99152 RVA: 0x0037C620 File Offset: 0x0037A820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018351 RID: 99153 RVA: 0x0037C62D File Offset: 0x0037A82D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x0037C634 File Offset: 0x0037A834
		public static IRoleTowerSystemVar GetRootAsIRoleTowerSystemVar(ByteBuffer _bb)
		{
			return IRoleTowerSystemVar.GetRootAsIRoleTowerSystemVar(_bb, default(IRoleTowerSystemVar));
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x0037C650 File Offset: 0x0037A850
		public static IRoleTowerSystemVar GetRootAsIRoleTowerSystemVar(ByteBuffer _bb, IRoleTowerSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018354 RID: 99156 RVA: 0x0037C66D File Offset: 0x0037A86D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x0037C67C File Offset: 0x0037A87C
		public IRoleTowerSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700751C RID: 29980
		// (get) Token: 0x06018356 RID: 99158 RVA: 0x0037C68C File Offset: 0x0037A88C
		public ERoleTowerSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerSystemVarType.Batch;
				}
				return (ERoleTowerSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700751D RID: 29981
		// (get) Token: 0x06018357 RID: 99159 RVA: 0x0037C6C8 File Offset: 0x0037A8C8
		public TVarRef VarRefType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018358 RID: 99160 RVA: 0x0037C704 File Offset: 0x0037A904
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x0037C748 File Offset: 0x0037A948
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0601835A RID: 99162 RVA: 0x0037C764 File Offset: 0x0037A964
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0601835B RID: 99163 RVA: 0x0037C780 File Offset: 0x0037A980
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601835C RID: 99164 RVA: 0x0037C79C File Offset: 0x0037A99C
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601835D RID: 99165 RVA: 0x0037C7B8 File Offset: 0x0037A9B8
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601835E RID: 99166 RVA: 0x0037C7D3 File Offset: 0x0037A9D3
		public static Offset<IRoleTowerSystemVar> CreateIRoleTowerSystemVar(FlatBufferBuilder builder, ERoleTowerSystemVarType VarType = ERoleTowerSystemVarType.Batch, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IRoleTowerSystemVar.AddVarRef(builder, VarRefOffset);
			IRoleTowerSystemVar.AddVarRefType(builder, VarRef_type);
			IRoleTowerSystemVar.AddVarType(builder, VarType);
			return IRoleTowerSystemVar.EndIRoleTowerSystemVar(builder);
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x0037C7F7 File Offset: 0x0037A9F7
		public static void StartIRoleTowerSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018360 RID: 99168 RVA: 0x0037C800 File Offset: 0x0037AA00
		public static void AddVarType(FlatBufferBuilder builder, ERoleTowerSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06018361 RID: 99169 RVA: 0x0037C80B File Offset: 0x0037AA0B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06018362 RID: 99170 RVA: 0x0037C816 File Offset: 0x0037AA16
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06018363 RID: 99171 RVA: 0x0037C821 File Offset: 0x0037AA21
		public static Offset<IRoleTowerSystemVar> EndIRoleTowerSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerSystemVar>(builder.EndTable());
		}

		// Token: 0x06018364 RID: 99172 RVA: 0x0037C830 File Offset: 0x0037AA30
		public IRoleTowerSystemVarT UnPack()
		{
			IRoleTowerSystemVarT roleTowerSystemVarT = new IRoleTowerSystemVarT();
			this.UnPackTo(roleTowerSystemVarT);
			return roleTowerSystemVarT;
		}

		// Token: 0x06018365 RID: 99173 RVA: 0x0037C84C File Offset: 0x0037AA4C
		public void UnPackTo(IRoleTowerSystemVarT _o)
		{
			_o.VarType = this.VarType;
			_o.VarRef = new TVarRefUnion();
			_o.VarRef.Type = this.VarRefType;
			switch (this.VarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.VarRef.Value = ((this.VarRef<IConstVarRef>() != null) ? this.VarRef<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.VarRef.Value = ((this.VarRef<IGlobalVarRef>() != null) ? this.VarRef<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.VarRef.Value = ((this.VarRef<IOtherVarRef>() != null) ? this.VarRef<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.VarRef.Value = ((this.VarRef<ISelfVarRef>() != null) ? this.VarRef<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.VarRef.Value = ((this.VarRef<ISystemVarRef>() != null) ? this.VarRef<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x0037C9B8 File Offset: 0x0037ABB8
		public static Offset<IRoleTowerSystemVar> Pack(FlatBufferBuilder builder, IRoleTowerSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IRoleTowerSystemVar.CreateIRoleTowerSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400BC7D RID: 48253
		private Table __p;
	}
}
