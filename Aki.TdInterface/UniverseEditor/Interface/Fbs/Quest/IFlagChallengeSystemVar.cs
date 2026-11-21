using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004295 RID: 17045
	public struct IFlagChallengeSystemVar : IFlatbufferObject
	{
		// Token: 0x17007494 RID: 29844
		// (get) Token: 0x06017DA4 RID: 97700 RVA: 0x0036845C File Offset: 0x0036665C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DA5 RID: 97701 RVA: 0x00368469 File Offset: 0x00366669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DA6 RID: 97702 RVA: 0x00368470 File Offset: 0x00366670
		public static IFlagChallengeSystemVar GetRootAsIFlagChallengeSystemVar(ByteBuffer _bb)
		{
			return IFlagChallengeSystemVar.GetRootAsIFlagChallengeSystemVar(_bb, default(IFlagChallengeSystemVar));
		}

		// Token: 0x06017DA7 RID: 97703 RVA: 0x0036848C File Offset: 0x0036668C
		public static IFlagChallengeSystemVar GetRootAsIFlagChallengeSystemVar(ByteBuffer _bb, IFlagChallengeSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DA8 RID: 97704 RVA: 0x003684A9 File Offset: 0x003666A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DA9 RID: 97705 RVA: 0x003684B8 File Offset: 0x003666B8
		public IFlagChallengeSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007495 RID: 29845
		// (get) Token: 0x06017DAA RID: 97706 RVA: 0x003684C8 File Offset: 0x003666C8
		public EFlagChallengeSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlagChallengeSystemVarType.IsCompleted;
				}
				return (EFlagChallengeSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007496 RID: 29846
		// (get) Token: 0x06017DAB RID: 97707 RVA: 0x00368504 File Offset: 0x00366704
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

		// Token: 0x06017DAC RID: 97708 RVA: 0x00368540 File Offset: 0x00366740
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017DAD RID: 97709 RVA: 0x00368584 File Offset: 0x00366784
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017DAE RID: 97710 RVA: 0x003685A0 File Offset: 0x003667A0
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017DAF RID: 97711 RVA: 0x003685BC File Offset: 0x003667BC
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017DB0 RID: 97712 RVA: 0x003685D8 File Offset: 0x003667D8
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06017DB1 RID: 97713 RVA: 0x003685F4 File Offset: 0x003667F4
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06017DB2 RID: 97714 RVA: 0x0036860F File Offset: 0x0036680F
		public static Offset<IFlagChallengeSystemVar> CreateIFlagChallengeSystemVar(FlatBufferBuilder builder, EFlagChallengeSystemVarType VarType = EFlagChallengeSystemVarType.IsCompleted, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IFlagChallengeSystemVar.AddVarRef(builder, VarRefOffset);
			IFlagChallengeSystemVar.AddVarRefType(builder, VarRef_type);
			IFlagChallengeSystemVar.AddVarType(builder, VarType);
			return IFlagChallengeSystemVar.EndIFlagChallengeSystemVar(builder);
		}

		// Token: 0x06017DB3 RID: 97715 RVA: 0x00368633 File Offset: 0x00366833
		public static void StartIFlagChallengeSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017DB4 RID: 97716 RVA: 0x0036863C File Offset: 0x0036683C
		public static void AddVarType(FlatBufferBuilder builder, EFlagChallengeSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06017DB5 RID: 97717 RVA: 0x00368647 File Offset: 0x00366847
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06017DB6 RID: 97718 RVA: 0x00368652 File Offset: 0x00366852
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06017DB7 RID: 97719 RVA: 0x0036865D File Offset: 0x0036685D
		public static Offset<IFlagChallengeSystemVar> EndIFlagChallengeSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IFlagChallengeSystemVar>(builder.EndTable());
		}

		// Token: 0x06017DB8 RID: 97720 RVA: 0x0036866C File Offset: 0x0036686C
		public IFlagChallengeSystemVarT UnPack()
		{
			IFlagChallengeSystemVarT flagChallengeSystemVarT = new IFlagChallengeSystemVarT();
			this.UnPackTo(flagChallengeSystemVarT);
			return flagChallengeSystemVarT;
		}

		// Token: 0x06017DB9 RID: 97721 RVA: 0x00368688 File Offset: 0x00366888
		public void UnPackTo(IFlagChallengeSystemVarT _o)
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

		// Token: 0x06017DBA RID: 97722 RVA: 0x003687F4 File Offset: 0x003669F4
		public static Offset<IFlagChallengeSystemVar> Pack(FlatBufferBuilder builder, IFlagChallengeSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlagChallengeSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IFlagChallengeSystemVar.CreateIFlagChallengeSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C1E1 RID: 49633
		private Table __p;
	}
}
