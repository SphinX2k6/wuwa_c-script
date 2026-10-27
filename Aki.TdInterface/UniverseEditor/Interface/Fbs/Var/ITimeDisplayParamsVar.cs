using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF6 RID: 15094
	public struct ITimeDisplayParamsVar : IFlatbufferObject
	{
		// Token: 0x17006782 RID: 26498
		// (get) Token: 0x06014916 RID: 84246 RVA: 0x002FE8DA File Offset: 0x002FCADA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014917 RID: 84247 RVA: 0x002FE8E7 File Offset: 0x002FCAE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014918 RID: 84248 RVA: 0x002FE8F0 File Offset: 0x002FCAF0
		public static ITimeDisplayParamsVar GetRootAsITimeDisplayParamsVar(ByteBuffer _bb)
		{
			return ITimeDisplayParamsVar.GetRootAsITimeDisplayParamsVar(_bb, default(ITimeDisplayParamsVar));
		}

		// Token: 0x06014919 RID: 84249 RVA: 0x002FE90C File Offset: 0x002FCB0C
		public static ITimeDisplayParamsVar GetRootAsITimeDisplayParamsVar(ByteBuffer _bb, ITimeDisplayParamsVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601491A RID: 84250 RVA: 0x002FE929 File Offset: 0x002FCB29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601491B RID: 84251 RVA: 0x002FE938 File Offset: 0x002FCB38
		public ITimeDisplayParamsVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006783 RID: 26499
		// (get) Token: 0x0601491C RID: 84252 RVA: 0x002FE948 File Offset: 0x002FCB48
		public ETimeDisplayDataSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeDisplayDataSource.Constant;
				}
				return (ETimeDisplayDataSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006784 RID: 26500
		// (get) Token: 0x0601491D RID: 84253 RVA: 0x002FE984 File Offset: 0x002FCB84
		public TVarRef VarType
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

		// Token: 0x0601491E RID: 84254 RVA: 0x002FE9C0 File Offset: 0x002FCBC0
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601491F RID: 84255 RVA: 0x002FEA04 File Offset: 0x002FCC04
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06014920 RID: 84256 RVA: 0x002FEA20 File Offset: 0x002FCC20
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06014921 RID: 84257 RVA: 0x002FEA3C File Offset: 0x002FCC3C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06014922 RID: 84258 RVA: 0x002FEA58 File Offset: 0x002FCC58
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06014923 RID: 84259 RVA: 0x002FEA74 File Offset: 0x002FCC74
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06014924 RID: 84260 RVA: 0x002FEA8F File Offset: 0x002FCC8F
		public static Offset<ITimeDisplayParamsVar> CreateITimeDisplayParamsVar(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			ITimeDisplayParamsVar.AddVar(builder, VarOffset);
			ITimeDisplayParamsVar.AddVarType(builder, Var_type);
			ITimeDisplayParamsVar.AddType(builder, Type);
			return ITimeDisplayParamsVar.EndITimeDisplayParamsVar(builder);
		}

		// Token: 0x06014925 RID: 84261 RVA: 0x002FEAB3 File Offset: 0x002FCCB3
		public static void StartITimeDisplayParamsVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014926 RID: 84262 RVA: 0x002FEABC File Offset: 0x002FCCBC
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014927 RID: 84263 RVA: 0x002FEAC7 File Offset: 0x002FCCC7
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06014928 RID: 84264 RVA: 0x002FEAD2 File Offset: 0x002FCCD2
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06014929 RID: 84265 RVA: 0x002FEADD File Offset: 0x002FCCDD
		public static Offset<ITimeDisplayParamsVar> EndITimeDisplayParamsVar(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParamsVar>(builder.EndTable());
		}

		// Token: 0x0601492A RID: 84266 RVA: 0x002FEAEC File Offset: 0x002FCCEC
		public ITimeDisplayParamsVarT UnPack()
		{
			ITimeDisplayParamsVarT timeDisplayParamsVarT = new ITimeDisplayParamsVarT();
			this.UnPackTo(timeDisplayParamsVarT);
			return timeDisplayParamsVarT;
		}

		// Token: 0x0601492B RID: 84267 RVA: 0x002FEB08 File Offset: 0x002FCD08
		public void UnPackTo(ITimeDisplayParamsVarT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601492C RID: 84268 RVA: 0x002FEC74 File Offset: 0x002FCE74
		public static Offset<ITimeDisplayParamsVar> Pack(FlatBufferBuilder builder, ITimeDisplayParamsVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeDisplayParamsVar>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return ITimeDisplayParamsVar.CreateITimeDisplayParamsVar(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400AFB8 RID: 44984
		private Table __p;
	}
}
