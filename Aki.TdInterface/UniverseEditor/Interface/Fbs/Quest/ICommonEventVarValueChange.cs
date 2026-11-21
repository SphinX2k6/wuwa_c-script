using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041AE RID: 16814
	public struct ICommonEventVarValueChange : IFlatbufferObject
	{
		// Token: 0x17007229 RID: 29225
		// (get) Token: 0x06017394 RID: 95124 RVA: 0x0035098A File Offset: 0x0034EB8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017395 RID: 95125 RVA: 0x00350997 File Offset: 0x0034EB97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017396 RID: 95126 RVA: 0x003509A0 File Offset: 0x0034EBA0
		public static ICommonEventVarValueChange GetRootAsICommonEventVarValueChange(ByteBuffer _bb)
		{
			return ICommonEventVarValueChange.GetRootAsICommonEventVarValueChange(_bb, default(ICommonEventVarValueChange));
		}

		// Token: 0x06017397 RID: 95127 RVA: 0x003509BC File Offset: 0x0034EBBC
		public static ICommonEventVarValueChange GetRootAsICommonEventVarValueChange(ByteBuffer _bb, ICommonEventVarValueChange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017398 RID: 95128 RVA: 0x003509D9 File Offset: 0x0034EBD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017399 RID: 95129 RVA: 0x003509E8 File Offset: 0x0034EBE8
		public ICommonEventVarValueChange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700722A RID: 29226
		// (get) Token: 0x0601739A RID: 95130 RVA: 0x003509F8 File Offset: 0x0034EBF8
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

		// Token: 0x1700722B RID: 29227
		// (get) Token: 0x0601739B RID: 95131 RVA: 0x00350A34 File Offset: 0x0034EC34
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

		// Token: 0x0601739C RID: 95132 RVA: 0x00350A70 File Offset: 0x0034EC70
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601739D RID: 95133 RVA: 0x00350AB4 File Offset: 0x0034ECB4
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601739E RID: 95134 RVA: 0x00350AD0 File Offset: 0x0034ECD0
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601739F RID: 95135 RVA: 0x00350AEC File Offset: 0x0034ECEC
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060173A0 RID: 95136 RVA: 0x00350B08 File Offset: 0x0034ED08
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060173A1 RID: 95137 RVA: 0x00350B24 File Offset: 0x0034ED24
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x060173A2 RID: 95138 RVA: 0x00350B3F File Offset: 0x0034ED3F
		public static Offset<ICommonEventVarValueChange> CreateICommonEventVarValueChange(FlatBufferBuilder builder, ECommonEventType Type = ECommonEventType.VarValueChange, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			ICommonEventVarValueChange.AddVar(builder, VarOffset);
			ICommonEventVarValueChange.AddVarType(builder, Var_type);
			ICommonEventVarValueChange.AddType(builder, Type);
			return ICommonEventVarValueChange.EndICommonEventVarValueChange(builder);
		}

		// Token: 0x060173A3 RID: 95139 RVA: 0x00350B63 File Offset: 0x0034ED63
		public static void StartICommonEventVarValueChange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060173A4 RID: 95140 RVA: 0x00350B6C File Offset: 0x0034ED6C
		public static void AddType(FlatBufferBuilder builder, ECommonEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060173A5 RID: 95141 RVA: 0x00350B77 File Offset: 0x0034ED77
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x060173A6 RID: 95142 RVA: 0x00350B82 File Offset: 0x0034ED82
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x060173A7 RID: 95143 RVA: 0x00350B8D File Offset: 0x0034ED8D
		public static Offset<ICommonEventVarValueChange> EndICommonEventVarValueChange(FlatBufferBuilder builder)
		{
			return new Offset<ICommonEventVarValueChange>(builder.EndTable());
		}

		// Token: 0x060173A8 RID: 95144 RVA: 0x00350B9C File Offset: 0x0034ED9C
		public ICommonEventVarValueChangeT UnPack()
		{
			ICommonEventVarValueChangeT commonEventVarValueChangeT = new ICommonEventVarValueChangeT();
			this.UnPackTo(commonEventVarValueChangeT);
			return commonEventVarValueChangeT;
		}

		// Token: 0x060173A9 RID: 95145 RVA: 0x00350BB8 File Offset: 0x0034EDB8
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

		// Token: 0x060173AA RID: 95146 RVA: 0x00350D24 File Offset: 0x0034EF24
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

		// Token: 0x0400C04F RID: 49231
		private Table __p;
	}
}
