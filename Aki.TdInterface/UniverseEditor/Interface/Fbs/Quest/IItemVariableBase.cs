using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FE RID: 17150
	public struct IItemVariableBase : IFlatbufferObject
	{
		// Token: 0x1700756F RID: 30063
		// (get) Token: 0x06018182 RID: 98690 RVA: 0x0037001C File Offset: 0x0036E21C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018183 RID: 98691 RVA: 0x00370029 File Offset: 0x0036E229
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018184 RID: 98692 RVA: 0x00370030 File Offset: 0x0036E230
		public static IItemVariableBase GetRootAsIItemVariableBase(ByteBuffer _bb)
		{
			return IItemVariableBase.GetRootAsIItemVariableBase(_bb, default(IItemVariableBase));
		}

		// Token: 0x06018185 RID: 98693 RVA: 0x0037004C File Offset: 0x0036E24C
		public static IItemVariableBase GetRootAsIItemVariableBase(ByteBuffer _bb, IItemVariableBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018186 RID: 98694 RVA: 0x00370069 File Offset: 0x0036E269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018187 RID: 98695 RVA: 0x00370078 File Offset: 0x0036E278
		public IItemVariableBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007570 RID: 30064
		// (get) Token: 0x06018188 RID: 98696 RVA: 0x00370088 File Offset: 0x0036E288
		public EHandInItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInItemType.ItemIds;
				}
				return (EHandInItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007571 RID: 30065
		// (get) Token: 0x06018189 RID: 98697 RVA: 0x003700C4 File Offset: 0x0036E2C4
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

		// Token: 0x0601818A RID: 98698 RVA: 0x00370100 File Offset: 0x0036E300
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601818B RID: 98699 RVA: 0x00370144 File Offset: 0x0036E344
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601818C RID: 98700 RVA: 0x00370160 File Offset: 0x0036E360
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601818D RID: 98701 RVA: 0x0037017C File Offset: 0x0036E37C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601818E RID: 98702 RVA: 0x00370198 File Offset: 0x0036E398
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601818F RID: 98703 RVA: 0x003701B4 File Offset: 0x0036E3B4
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06018190 RID: 98704 RVA: 0x003701CF File Offset: 0x0036E3CF
		public static Offset<IItemVariableBase> CreateIItemVariableBase(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IItemVariableBase.AddVar(builder, VarOffset);
			IItemVariableBase.AddVarType(builder, Var_type);
			IItemVariableBase.AddType(builder, Type);
			return IItemVariableBase.EndIItemVariableBase(builder);
		}

		// Token: 0x06018191 RID: 98705 RVA: 0x003701F3 File Offset: 0x0036E3F3
		public static void StartIItemVariableBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018192 RID: 98706 RVA: 0x003701FC File Offset: 0x0036E3FC
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018193 RID: 98707 RVA: 0x00370207 File Offset: 0x0036E407
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06018194 RID: 98708 RVA: 0x00370212 File Offset: 0x0036E412
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06018195 RID: 98709 RVA: 0x0037021D File Offset: 0x0036E41D
		public static Offset<IItemVariableBase> EndIItemVariableBase(FlatBufferBuilder builder)
		{
			return new Offset<IItemVariableBase>(builder.EndTable());
		}

		// Token: 0x06018196 RID: 98710 RVA: 0x0037022C File Offset: 0x0036E42C
		public IItemVariableBaseT UnPack()
		{
			IItemVariableBaseT itemVariableBaseT = new IItemVariableBaseT();
			this.UnPackTo(itemVariableBaseT);
			return itemVariableBaseT;
		}

		// Token: 0x06018197 RID: 98711 RVA: 0x00370248 File Offset: 0x0036E448
		public void UnPackTo(IItemVariableBaseT _o)
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

		// Token: 0x06018198 RID: 98712 RVA: 0x003703B4 File Offset: 0x0036E5B4
		public static Offset<IItemVariableBase> Pack(FlatBufferBuilder builder, IItemVariableBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemVariableBase>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IItemVariableBase.CreateIItemVariableBase(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400C26F RID: 49775
		private Table __p;
	}
}
