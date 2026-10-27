using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D97 RID: 15767
	public struct ICommonEventVarValueChange : IFlatbufferObject
	{
		// Token: 0x17006C6F RID: 27759
		// (get) Token: 0x06015E5C RID: 89692 RVA: 0x0032965E File Offset: 0x0032785E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015E5D RID: 89693 RVA: 0x0032966B File Offset: 0x0032786B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015E5E RID: 89694 RVA: 0x00329674 File Offset: 0x00327874
		public static ICommonEventVarValueChange GetRootAsICommonEventVarValueChange(ByteBuffer _bb)
		{
			return ICommonEventVarValueChange.GetRootAsICommonEventVarValueChange(_bb, default(ICommonEventVarValueChange));
		}

		// Token: 0x06015E5F RID: 89695 RVA: 0x00329690 File Offset: 0x00327890
		public static ICommonEventVarValueChange GetRootAsICommonEventVarValueChange(ByteBuffer _bb, ICommonEventVarValueChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015E60 RID: 89696 RVA: 0x003296AD File Offset: 0x003278AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015E61 RID: 89697 RVA: 0x003296BC File Offset: 0x003278BC
		public ICommonEventVarValueChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C70 RID: 27760
		// (get) Token: 0x06015E62 RID: 89698 RVA: 0x003296CC File Offset: 0x003278CC
		public ECommonEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonEventType.VarValueChange;
				}
				return (ECommonEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C71 RID: 27761
		// (get) Token: 0x06015E63 RID: 89699 RVA: 0x00329708 File Offset: 0x00327908
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

		// Token: 0x06015E64 RID: 89700 RVA: 0x00329744 File Offset: 0x00327944
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015E65 RID: 89701 RVA: 0x00329788 File Offset: 0x00327988
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06015E66 RID: 89702 RVA: 0x003297A4 File Offset: 0x003279A4
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06015E67 RID: 89703 RVA: 0x003297C0 File Offset: 0x003279C0
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06015E68 RID: 89704 RVA: 0x003297DC File Offset: 0x003279DC
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06015E69 RID: 89705 RVA: 0x003297F8 File Offset: 0x003279F8
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06015E6A RID: 89706 RVA: 0x00329813 File Offset: 0x00327A13
		public static Offset<ICommonEventVarValueChange> CreateICommonEventVarValueChange(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			ICommonEventVarValueChange.AddVar(builder, VarOffset);
			ICommonEventVarValueChange.AddVarType(builder, Var_type);
			ICommonEventVarValueChange.AddType(builder, Type);
			return ICommonEventVarValueChange.EndICommonEventVarValueChange(builder);
		}

		// Token: 0x06015E6B RID: 89707 RVA: 0x00329837 File Offset: 0x00327A37
		public static void StartICommonEventVarValueChange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015E6C RID: 89708 RVA: 0x00329840 File Offset: 0x00327A40
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015E6D RID: 89709 RVA: 0x0032984B File Offset: 0x00327A4B
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06015E6E RID: 89710 RVA: 0x00329856 File Offset: 0x00327A56
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06015E6F RID: 89711 RVA: 0x00329861 File Offset: 0x00327A61
		public static Offset<ICommonEventVarValueChange> EndICommonEventVarValueChange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonEventVarValueChange>(builder.EndTable());
		}

		// Token: 0x06015E70 RID: 89712 RVA: 0x00329870 File Offset: 0x00327A70
		public ICommonEventVarValueChangeT UnPack()
		{
			ICommonEventVarValueChangeT commonEventVarValueChangeT = new ICommonEventVarValueChangeT();
			this.UnPackTo(commonEventVarValueChangeT);
			return commonEventVarValueChangeT;
		}

		// Token: 0x06015E71 RID: 89713 RVA: 0x0032988C File Offset: 0x00327A8C
		public void UnPackTo(ICommonEventVarValueChangeT _o)
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

		// Token: 0x06015E72 RID: 89714 RVA: 0x003299F8 File Offset: 0x00327BF8
		public static Offset<ICommonEventVarValueChange> Pack(FlatBufferBuilder builder, ICommonEventVarValueChangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonEventVarValueChange>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return ICommonEventVarValueChange.CreateICommonEventVarValueChange(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400B6A2 RID: 46754
		private Table __p;
	}
}
