using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BC RID: 17084
	public struct IGradingSystemVar : IFlatbufferObject
	{
		// Token: 0x170074E6 RID: 29926
		// (get) Token: 0x06017F10 RID: 98064 RVA: 0x0036B187 File Offset: 0x00369387
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F11 RID: 98065 RVA: 0x0036B194 File Offset: 0x00369394
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F12 RID: 98066 RVA: 0x0036B19C File Offset: 0x0036939C
		public static IGradingSystemVar GetRootAsIGradingSystemVar(ByteBuffer _bb)
		{
			return IGradingSystemVar.GetRootAsIGradingSystemVar(_bb, default(IGradingSystemVar));
		}

		// Token: 0x06017F13 RID: 98067 RVA: 0x0036B1B8 File Offset: 0x003693B8
		public static IGradingSystemVar GetRootAsIGradingSystemVar(ByteBuffer _bb, IGradingSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F14 RID: 98068 RVA: 0x0036B1D5 File Offset: 0x003693D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F15 RID: 98069 RVA: 0x0036B1E4 File Offset: 0x003693E4
		public IGradingSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074E7 RID: 29927
		// (get) Token: 0x06017F16 RID: 98070 RVA: 0x0036B1F4 File Offset: 0x003693F4
		public EGradingSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGradingSystemVarType.Score;
				}
				return (EGradingSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074E8 RID: 29928
		// (get) Token: 0x06017F17 RID: 98071 RVA: 0x0036B230 File Offset: 0x00369430
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

		// Token: 0x06017F18 RID: 98072 RVA: 0x0036B26C File Offset: 0x0036946C
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017F19 RID: 98073 RVA: 0x0036B2B0 File Offset: 0x003694B0
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017F1A RID: 98074 RVA: 0x0036B2CC File Offset: 0x003694CC
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017F1B RID: 98075 RVA: 0x0036B2E8 File Offset: 0x003694E8
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017F1C RID: 98076 RVA: 0x0036B304 File Offset: 0x00369504
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06017F1D RID: 98077 RVA: 0x0036B320 File Offset: 0x00369520
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06017F1E RID: 98078 RVA: 0x0036B33B File Offset: 0x0036953B
		public static Offset<IGradingSystemVar> CreateIGradingSystemVar(FlatBufferBuilder builder, EGradingSystemVarType VarType = EGradingSystemVarType.Score, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IGradingSystemVar.AddVarRef(builder, VarRefOffset);
			IGradingSystemVar.AddVarRefType(builder, VarRef_type);
			IGradingSystemVar.AddVarType(builder, VarType);
			return IGradingSystemVar.EndIGradingSystemVar(builder);
		}

		// Token: 0x06017F1F RID: 98079 RVA: 0x0036B35F File Offset: 0x0036955F
		public static void StartIGradingSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017F20 RID: 98080 RVA: 0x0036B368 File Offset: 0x00369568
		public static void AddVarType(FlatBufferBuilder builder, EGradingSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06017F21 RID: 98081 RVA: 0x0036B373 File Offset: 0x00369573
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06017F22 RID: 98082 RVA: 0x0036B37E File Offset: 0x0036957E
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06017F23 RID: 98083 RVA: 0x0036B389 File Offset: 0x00369589
		public static Offset<IGradingSystemVar> EndIGradingSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IGradingSystemVar>(builder.EndTable());
		}

		// Token: 0x06017F24 RID: 98084 RVA: 0x0036B398 File Offset: 0x00369598
		public IGradingSystemVarT UnPack()
		{
			IGradingSystemVarT gradingSystemVarT = new IGradingSystemVarT();
			this.UnPackTo(gradingSystemVarT);
			return gradingSystemVarT;
		}

		// Token: 0x06017F25 RID: 98085 RVA: 0x0036B3B4 File Offset: 0x003695B4
		public void UnPackTo(IGradingSystemVarT _o)
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

		// Token: 0x06017F26 RID: 98086 RVA: 0x0036B520 File Offset: 0x00369720
		public static Offset<IGradingSystemVar> Pack(FlatBufferBuilder builder, IGradingSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGradingSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IGradingSystemVar.CreateIGradingSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C215 RID: 49685
		private Table __p;
	}
}
