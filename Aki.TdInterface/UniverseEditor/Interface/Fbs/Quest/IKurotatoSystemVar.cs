using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF3 RID: 16115
	public struct IKurotatoSystemVar : IFlatbufferObject
	{
		// Token: 0x17006FC9 RID: 28617
		// (get) Token: 0x06016CC7 RID: 93383 RVA: 0x00349DC8 File Offset: 0x00347FC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CC8 RID: 93384 RVA: 0x00349DD5 File Offset: 0x00347FD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CC9 RID: 93385 RVA: 0x00349DDC File Offset: 0x00347FDC
		public static IKurotatoSystemVar GetRootAsIKurotatoSystemVar(ByteBuffer _bb)
		{
			return IKurotatoSystemVar.GetRootAsIKurotatoSystemVar(_bb, default(IKurotatoSystemVar));
		}

		// Token: 0x06016CCA RID: 93386 RVA: 0x00349DF8 File Offset: 0x00347FF8
		public static IKurotatoSystemVar GetRootAsIKurotatoSystemVar(ByteBuffer _bb, IKurotatoSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016CCB RID: 93387 RVA: 0x00349E15 File Offset: 0x00348015
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016CCC RID: 93388 RVA: 0x00349E24 File Offset: 0x00348024
		public IKurotatoSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FCA RID: 28618
		// (get) Token: 0x06016CCD RID: 93389 RVA: 0x00349E34 File Offset: 0x00348034
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

		// Token: 0x17006FCB RID: 28619
		// (get) Token: 0x06016CCE RID: 93390 RVA: 0x00349E70 File Offset: 0x00348070
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

		// Token: 0x06016CCF RID: 93391 RVA: 0x00349EAC File Offset: 0x003480AC
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016CD0 RID: 93392 RVA: 0x00349EF0 File Offset: 0x003480F0
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06016CD1 RID: 93393 RVA: 0x00349F0C File Offset: 0x0034810C
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06016CD2 RID: 93394 RVA: 0x00349F28 File Offset: 0x00348128
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06016CD3 RID: 93395 RVA: 0x00349F44 File Offset: 0x00348144
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06016CD4 RID: 93396 RVA: 0x00349F60 File Offset: 0x00348160
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06016CD5 RID: 93397 RVA: 0x00349F7B File Offset: 0x0034817B
		public static Offset<IKurotatoSystemVar> CreateIKurotatoSystemVar(FlatBufferBuilder builder, EKurotatoSystemVarType VarType = EKurotatoSystemVarType.Gold, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IKurotatoSystemVar.AddVarRef(builder, VarRefOffset);
			IKurotatoSystemVar.AddVarRefType(builder, VarRef_type);
			IKurotatoSystemVar.AddVarType(builder, VarType);
			return IKurotatoSystemVar.EndIKurotatoSystemVar(builder);
		}

		// Token: 0x06016CD6 RID: 93398 RVA: 0x00349F9F File Offset: 0x0034819F
		public static void StartIKurotatoSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016CD7 RID: 93399 RVA: 0x00349FA8 File Offset: 0x003481A8
		public static void AddVarType(FlatBufferBuilder builder, EKurotatoSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06016CD8 RID: 93400 RVA: 0x00349FB3 File Offset: 0x003481B3
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06016CD9 RID: 93401 RVA: 0x00349FBE File Offset: 0x003481BE
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06016CDA RID: 93402 RVA: 0x00349FC9 File Offset: 0x003481C9
		public static Offset<IKurotatoSystemVar> EndIKurotatoSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoSystemVar>(builder.EndTable());
		}

		// Token: 0x06016CDB RID: 93403 RVA: 0x00349FD8 File Offset: 0x003481D8
		public IKurotatoSystemVarT UnPack()
		{
			IKurotatoSystemVarT kurotatoSystemVarT = new IKurotatoSystemVarT();
			this.UnPackTo(kurotatoSystemVarT);
			return kurotatoSystemVarT;
		}

		// Token: 0x06016CDC RID: 93404 RVA: 0x00349FF4 File Offset: 0x003481F4
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

		// Token: 0x06016CDD RID: 93405 RVA: 0x0034A160 File Offset: 0x00348360
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

		// Token: 0x0400B8D0 RID: 47312
		private Table __p;
	}
}
