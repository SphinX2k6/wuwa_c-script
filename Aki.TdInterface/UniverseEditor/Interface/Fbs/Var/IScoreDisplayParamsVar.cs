using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AC9 RID: 15049
	public struct IScoreDisplayParamsVar : IFlatbufferObject
	{
		// Token: 0x1700673E RID: 26430
		// (get) Token: 0x06014780 RID: 83840 RVA: 0x002FB6A1 File Offset: 0x002F98A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014781 RID: 83841 RVA: 0x002FB6AE File Offset: 0x002F98AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014782 RID: 83842 RVA: 0x002FB6B8 File Offset: 0x002F98B8
		public static IScoreDisplayParamsVar GetRootAsIScoreDisplayParamsVar(ByteBuffer _bb)
		{
			return IScoreDisplayParamsVar.GetRootAsIScoreDisplayParamsVar(_bb, default(IScoreDisplayParamsVar));
		}

		// Token: 0x06014783 RID: 83843 RVA: 0x002FB6D4 File Offset: 0x002F98D4
		public static IScoreDisplayParamsVar GetRootAsIScoreDisplayParamsVar(ByteBuffer _bb, IScoreDisplayParamsVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014784 RID: 83844 RVA: 0x002FB6F1 File Offset: 0x002F98F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014785 RID: 83845 RVA: 0x002FB700 File Offset: 0x002F9900
		public IScoreDisplayParamsVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700673F RID: 26431
		// (get) Token: 0x06014786 RID: 83846 RVA: 0x002FB710 File Offset: 0x002F9910
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

		// Token: 0x17006740 RID: 26432
		// (get) Token: 0x06014787 RID: 83847 RVA: 0x002FB74C File Offset: 0x002F994C
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

		// Token: 0x06014788 RID: 83848 RVA: 0x002FB788 File Offset: 0x002F9988
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014789 RID: 83849 RVA: 0x002FB7CC File Offset: 0x002F99CC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601478A RID: 83850 RVA: 0x002FB7E8 File Offset: 0x002F99E8
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601478B RID: 83851 RVA: 0x002FB804 File Offset: 0x002F9A04
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601478C RID: 83852 RVA: 0x002FB820 File Offset: 0x002F9A20
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601478D RID: 83853 RVA: 0x002FB83C File Offset: 0x002F9A3C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x0601478E RID: 83854 RVA: 0x002FB857 File Offset: 0x002F9A57
		public static Offset<IScoreDisplayParamsVar> CreateIScoreDisplayParamsVar(FlatBufferBuilder builder, EScoreDisplayDataSource Type = EScoreDisplayDataSource.Var, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IScoreDisplayParamsVar.AddVar(builder, VarOffset);
			IScoreDisplayParamsVar.AddVarType(builder, Var_type);
			IScoreDisplayParamsVar.AddType(builder, Type);
			return IScoreDisplayParamsVar.EndIScoreDisplayParamsVar(builder);
		}

		// Token: 0x0601478F RID: 83855 RVA: 0x002FB87B File Offset: 0x002F9A7B
		public static void StartIScoreDisplayParamsVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014790 RID: 83856 RVA: 0x002FB884 File Offset: 0x002F9A84
		public static void AddType(FlatBufferBuilder builder, EScoreDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014791 RID: 83857 RVA: 0x002FB88F File Offset: 0x002F9A8F
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06014792 RID: 83858 RVA: 0x002FB89A File Offset: 0x002F9A9A
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06014793 RID: 83859 RVA: 0x002FB8A5 File Offset: 0x002F9AA5
		public static Offset<IScoreDisplayParamsVar> EndIScoreDisplayParamsVar(FlatBufferBuilder builder)
		{
			return new Offset<IScoreDisplayParamsVar>(builder.EndTable());
		}

		// Token: 0x06014794 RID: 83860 RVA: 0x002FB8B4 File Offset: 0x002F9AB4
		public IScoreDisplayParamsVarT UnPack()
		{
			IScoreDisplayParamsVarT scoreDisplayParamsVarT = new IScoreDisplayParamsVarT();
			this.UnPackTo(scoreDisplayParamsVarT);
			return scoreDisplayParamsVarT;
		}

		// Token: 0x06014795 RID: 83861 RVA: 0x002FB8D0 File Offset: 0x002F9AD0
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

		// Token: 0x06014796 RID: 83862 RVA: 0x002FBA3C File Offset: 0x002F9C3C
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

		// Token: 0x0400AF68 RID: 44904
		private Table __p;
	}
}
