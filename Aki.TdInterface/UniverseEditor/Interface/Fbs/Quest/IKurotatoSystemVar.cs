using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004331 RID: 17201
	public struct IKurotatoSystemVar : IFlatbufferObject
	{
		// Token: 0x170075B8 RID: 30136
		// (get) Token: 0x0601831E RID: 99102 RVA: 0x00372F94 File Offset: 0x00371194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601831F RID: 99103 RVA: 0x00372FA1 File Offset: 0x003711A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018320 RID: 99104 RVA: 0x00372FA8 File Offset: 0x003711A8
		public static IKurotatoSystemVar GetRootAsIKurotatoSystemVar(ByteBuffer _bb)
		{
			return IKurotatoSystemVar.GetRootAsIKurotatoSystemVar(_bb, default(IKurotatoSystemVar));
		}

		// Token: 0x06018321 RID: 99105 RVA: 0x00372FC4 File Offset: 0x003711C4
		public static IKurotatoSystemVar GetRootAsIKurotatoSystemVar(ByteBuffer _bb, IKurotatoSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018322 RID: 99106 RVA: 0x00372FE1 File Offset: 0x003711E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018323 RID: 99107 RVA: 0x00372FF0 File Offset: 0x003711F0
		public IKurotatoSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075B9 RID: 30137
		// (get) Token: 0x06018324 RID: 99108 RVA: 0x00373000 File Offset: 0x00371200
		public EKurotatoSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoSystemVarType.Gold;
				}
				return (EKurotatoSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170075BA RID: 30138
		// (get) Token: 0x06018325 RID: 99109 RVA: 0x0037303C File Offset: 0x0037123C
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

		// Token: 0x06018326 RID: 99110 RVA: 0x00373078 File Offset: 0x00371278
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018327 RID: 99111 RVA: 0x003730BC File Offset: 0x003712BC
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06018328 RID: 99112 RVA: 0x003730D8 File Offset: 0x003712D8
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06018329 RID: 99113 RVA: 0x003730F4 File Offset: 0x003712F4
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601832A RID: 99114 RVA: 0x00373110 File Offset: 0x00371310
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601832B RID: 99115 RVA: 0x0037312C File Offset: 0x0037132C
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601832C RID: 99116 RVA: 0x00373147 File Offset: 0x00371347
		public static Offset<IKurotatoSystemVar> CreateIKurotatoSystemVar(FlatBufferBuilder builder, EKurotatoSystemVarType VarType = EKurotatoSystemVarType.Gold, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IKurotatoSystemVar.AddVarRef(builder, VarRefOffset);
			IKurotatoSystemVar.AddVarRefType(builder, VarRef_type);
			IKurotatoSystemVar.AddVarType(builder, VarType);
			return IKurotatoSystemVar.EndIKurotatoSystemVar(builder);
		}

		// Token: 0x0601832D RID: 99117 RVA: 0x0037316B File Offset: 0x0037136B
		public static void StartIKurotatoSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601832E RID: 99118 RVA: 0x00373174 File Offset: 0x00371374
		public static void AddVarType(FlatBufferBuilder builder, EKurotatoSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601832F RID: 99119 RVA: 0x0037317F File Offset: 0x0037137F
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06018330 RID: 99120 RVA: 0x0037318A File Offset: 0x0037138A
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06018331 RID: 99121 RVA: 0x00373195 File Offset: 0x00371395
		public static Offset<IKurotatoSystemVar> EndIKurotatoSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoSystemVar>(builder.EndTable());
		}

		// Token: 0x06018332 RID: 99122 RVA: 0x003731A4 File Offset: 0x003713A4
		public IKurotatoSystemVarT UnPack()
		{
			IKurotatoSystemVarT kurotatoSystemVarT = new IKurotatoSystemVarT();
			this.UnPackTo(kurotatoSystemVarT);
			return kurotatoSystemVarT;
		}

		// Token: 0x06018333 RID: 99123 RVA: 0x003731C0 File Offset: 0x003713C0
		public void UnPackTo(IKurotatoSystemVarT _o)
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

		// Token: 0x06018334 RID: 99124 RVA: 0x0037332C File Offset: 0x0037152C
		public static Offset<IKurotatoSystemVar> Pack(FlatBufferBuilder builder, IKurotatoSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IKurotatoSystemVar.CreateIKurotatoSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C2AD RID: 49837
		private Table __p;
	}
}
