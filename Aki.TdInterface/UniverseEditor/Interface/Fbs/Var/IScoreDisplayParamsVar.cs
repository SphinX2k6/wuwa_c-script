using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ECB RID: 16075
	public struct IScoreDisplayParamsVar : IFlatbufferObject
	{
		// Token: 0x17006CD9 RID: 27865
		// (get) Token: 0x06015C2A RID: 89130 RVA: 0x00321931 File Offset: 0x0031FB31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015C2B RID: 89131 RVA: 0x0032193E File Offset: 0x0031FB3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015C2C RID: 89132 RVA: 0x00321948 File Offset: 0x0031FB48
		public static IScoreDisplayParamsVar GetRootAsIScoreDisplayParamsVar(ByteBuffer _bb)
		{
			return IScoreDisplayParamsVar.GetRootAsIScoreDisplayParamsVar(_bb, default(IScoreDisplayParamsVar));
		}

		// Token: 0x06015C2D RID: 89133 RVA: 0x00321964 File Offset: 0x0031FB64
		public static IScoreDisplayParamsVar GetRootAsIScoreDisplayParamsVar(ByteBuffer _bb, IScoreDisplayParamsVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015C2E RID: 89134 RVA: 0x00321981 File Offset: 0x0031FB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015C2F RID: 89135 RVA: 0x00321990 File Offset: 0x0031FB90
		public IScoreDisplayParamsVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CDA RID: 27866
		// (get) Token: 0x06015C30 RID: 89136 RVA: 0x003219A0 File Offset: 0x0031FBA0
		public EScoreDisplayDataSource Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EScoreDisplayDataSource.Var;
				}
				return (EScoreDisplayDataSource)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006CDB RID: 27867
		// (get) Token: 0x06015C31 RID: 89137 RVA: 0x003219DC File Offset: 0x0031FBDC
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

		// Token: 0x06015C32 RID: 89138 RVA: 0x00321A18 File Offset: 0x0031FC18
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015C33 RID: 89139 RVA: 0x00321A5C File Offset: 0x0031FC5C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06015C34 RID: 89140 RVA: 0x00321A78 File Offset: 0x0031FC78
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06015C35 RID: 89141 RVA: 0x00321A94 File Offset: 0x0031FC94
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06015C36 RID: 89142 RVA: 0x00321AB0 File Offset: 0x0031FCB0
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06015C37 RID: 89143 RVA: 0x00321ACC File Offset: 0x0031FCCC
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06015C38 RID: 89144 RVA: 0x00321AE7 File Offset: 0x0031FCE7
		public static Offset<IScoreDisplayParamsVar> CreateIScoreDisplayParamsVar(FlatBufferBuilder builder, EScoreDisplayDataSource Type = EScoreDisplayDataSource.Var, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IScoreDisplayParamsVar.AddVar(builder, VarOffset);
			IScoreDisplayParamsVar.AddVarType(builder, Var_type);
			IScoreDisplayParamsVar.AddType(builder, Type);
			return IScoreDisplayParamsVar.EndIScoreDisplayParamsVar(builder);
		}

		// Token: 0x06015C39 RID: 89145 RVA: 0x00321B0B File Offset: 0x0031FD0B
		public static void StartIScoreDisplayParamsVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015C3A RID: 89146 RVA: 0x00321B14 File Offset: 0x0031FD14
		public static void AddType(FlatBufferBuilder builder, EScoreDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015C3B RID: 89147 RVA: 0x00321B1F File Offset: 0x0031FD1F
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06015C3C RID: 89148 RVA: 0x00321B2A File Offset: 0x0031FD2A
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06015C3D RID: 89149 RVA: 0x00321B35 File Offset: 0x0031FD35
		public static Offset<IScoreDisplayParamsVar> EndIScoreDisplayParamsVar(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayParamsVar>(builder.EndTable());
		}

		// Token: 0x06015C3E RID: 89150 RVA: 0x00321B44 File Offset: 0x0031FD44
		public IScoreDisplayParamsVarT UnPack()
		{
			IScoreDisplayParamsVarT scoreDisplayParamsVarT = new IScoreDisplayParamsVarT();
			this.UnPackTo(scoreDisplayParamsVarT);
			return scoreDisplayParamsVarT;
		}

		// Token: 0x06015C3F RID: 89151 RVA: 0x00321B60 File Offset: 0x0031FD60
		public void UnPackTo(IScoreDisplayParamsVarT _o)
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

		// Token: 0x06015C40 RID: 89152 RVA: 0x00321CCC File Offset: 0x0031FECC
		public static Offset<IScoreDisplayParamsVar> Pack(FlatBufferBuilder builder, IScoreDisplayParamsVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScoreDisplayParamsVar>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IScoreDisplayParamsVar.CreateIScoreDisplayParamsVar(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400B8D5 RID: 47317
		private Table __p;
	}
}
