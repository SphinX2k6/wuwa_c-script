using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF8 RID: 16120
	public struct ITimeDisplayParamsVar : IFlatbufferObject
	{
		// Token: 0x17006D1D RID: 27933
		// (get) Token: 0x06015DC0 RID: 89536 RVA: 0x00324B6A File Offset: 0x00322D6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015DC1 RID: 89537 RVA: 0x00324B77 File Offset: 0x00322D77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015DC2 RID: 89538 RVA: 0x00324B80 File Offset: 0x00322D80
		public static ITimeDisplayParamsVar GetRootAsITimeDisplayParamsVar(ByteBuffer _bb)
		{
			return ITimeDisplayParamsVar.GetRootAsITimeDisplayParamsVar(_bb, default(ITimeDisplayParamsVar));
		}

		// Token: 0x06015DC3 RID: 89539 RVA: 0x00324B9C File Offset: 0x00322D9C
		public static ITimeDisplayParamsVar GetRootAsITimeDisplayParamsVar(ByteBuffer _bb, ITimeDisplayParamsVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015DC4 RID: 89540 RVA: 0x00324BB9 File Offset: 0x00322DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015DC5 RID: 89541 RVA: 0x00324BC8 File Offset: 0x00322DC8
		public ITimeDisplayParamsVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D1E RID: 27934
		// (get) Token: 0x06015DC6 RID: 89542 RVA: 0x00324BD8 File Offset: 0x00322DD8
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

		// Token: 0x17006D1F RID: 27935
		// (get) Token: 0x06015DC7 RID: 89543 RVA: 0x00324C14 File Offset: 0x00322E14
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

		// Token: 0x06015DC8 RID: 89544 RVA: 0x00324C50 File Offset: 0x00322E50
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015DC9 RID: 89545 RVA: 0x00324C94 File Offset: 0x00322E94
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06015DCA RID: 89546 RVA: 0x00324CB0 File Offset: 0x00322EB0
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06015DCB RID: 89547 RVA: 0x00324CCC File Offset: 0x00322ECC
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06015DCC RID: 89548 RVA: 0x00324CE8 File Offset: 0x00322EE8
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06015DCD RID: 89549 RVA: 0x00324D04 File Offset: 0x00322F04
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06015DCE RID: 89550 RVA: 0x00324D1F File Offset: 0x00322F1F
		public static Offset<ITimeDisplayParamsVar> CreateITimeDisplayParamsVar(FlatBufferBuilder builder, ETimeDisplayDataSource Type = ETimeDisplayDataSource.Constant, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			ITimeDisplayParamsVar.AddVar(builder, VarOffset);
			ITimeDisplayParamsVar.AddVarType(builder, Var_type);
			ITimeDisplayParamsVar.AddType(builder, Type);
			return ITimeDisplayParamsVar.EndITimeDisplayParamsVar(builder);
		}

		// Token: 0x06015DCF RID: 89551 RVA: 0x00324D43 File Offset: 0x00322F43
		public static void StartITimeDisplayParamsVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015DD0 RID: 89552 RVA: 0x00324D4C File Offset: 0x00322F4C
		public static void AddType(FlatBufferBuilder builder, ETimeDisplayDataSource type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015DD1 RID: 89553 RVA: 0x00324D57 File Offset: 0x00322F57
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06015DD2 RID: 89554 RVA: 0x00324D62 File Offset: 0x00322F62
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06015DD3 RID: 89555 RVA: 0x00324D6D File Offset: 0x00322F6D
		public static Offset<ITimeDisplayParamsVar> EndITimeDisplayParamsVar(FlatBufferBuilder builder)
		{
			return new Offset<ITimeDisplayParamsVar>(builder.EndTable());
		}

		// Token: 0x06015DD4 RID: 89556 RVA: 0x00324D7C File Offset: 0x00322F7C
		public ITimeDisplayParamsVarT UnPack()
		{
			ITimeDisplayParamsVarT timeDisplayParamsVarT = new ITimeDisplayParamsVarT();
			this.UnPackTo(timeDisplayParamsVarT);
			return timeDisplayParamsVarT;
		}

		// Token: 0x06015DD5 RID: 89557 RVA: 0x00324D98 File Offset: 0x00322F98
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

		// Token: 0x06015DD6 RID: 89558 RVA: 0x00324F04 File Offset: 0x00323104
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

		// Token: 0x0400B925 RID: 47397
		private Table __p;
	}
}
