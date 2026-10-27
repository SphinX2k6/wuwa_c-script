using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5A RID: 15962
	public struct IFlagChallengeSystemVar : IFlatbufferObject
	{
		// Token: 0x17006EB0 RID: 28336
		// (get) Token: 0x0601677D RID: 92029 RVA: 0x0033F92C File Offset: 0x0033DB2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601677E RID: 92030 RVA: 0x0033F939 File Offset: 0x0033DB39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601677F RID: 92031 RVA: 0x0033F940 File Offset: 0x0033DB40
		public static IFlagChallengeSystemVar GetRootAsIFlagChallengeSystemVar(ByteBuffer _bb)
		{
			return IFlagChallengeSystemVar.GetRootAsIFlagChallengeSystemVar(_bb, default(IFlagChallengeSystemVar));
		}

		// Token: 0x06016780 RID: 92032 RVA: 0x0033F95C File Offset: 0x0033DB5C
		public static IFlagChallengeSystemVar GetRootAsIFlagChallengeSystemVar(ByteBuffer _bb, IFlagChallengeSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016781 RID: 92033 RVA: 0x0033F979 File Offset: 0x0033DB79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016782 RID: 92034 RVA: 0x0033F988 File Offset: 0x0033DB88
		public IFlagChallengeSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EB1 RID: 28337
		// (get) Token: 0x06016783 RID: 92035 RVA: 0x0033F998 File Offset: 0x0033DB98
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

		// Token: 0x17006EB2 RID: 28338
		// (get) Token: 0x06016784 RID: 92036 RVA: 0x0033F9D4 File Offset: 0x0033DBD4
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

		// Token: 0x06016785 RID: 92037 RVA: 0x0033FA10 File Offset: 0x0033DC10
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016786 RID: 92038 RVA: 0x0033FA54 File Offset: 0x0033DC54
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06016787 RID: 92039 RVA: 0x0033FA70 File Offset: 0x0033DC70
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06016788 RID: 92040 RVA: 0x0033FA8C File Offset: 0x0033DC8C
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06016789 RID: 92041 RVA: 0x0033FAA8 File Offset: 0x0033DCA8
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601678A RID: 92042 RVA: 0x0033FAC4 File Offset: 0x0033DCC4
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601678B RID: 92043 RVA: 0x0033FADF File Offset: 0x0033DCDF
		public static Offset<IFlagChallengeSystemVar> CreateIFlagChallengeSystemVar(FlatBufferBuilder builder, EFlagChallengeSystemVarType VarType = EFlagChallengeSystemVarType.IsCompleted, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IFlagChallengeSystemVar.AddVarRef(builder, VarRefOffset);
			IFlagChallengeSystemVar.AddVarRefType(builder, VarRef_type);
			IFlagChallengeSystemVar.AddVarType(builder, VarType);
			return IFlagChallengeSystemVar.EndIFlagChallengeSystemVar(builder);
		}

		// Token: 0x0601678C RID: 92044 RVA: 0x0033FB03 File Offset: 0x0033DD03
		public static void StartIFlagChallengeSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601678D RID: 92045 RVA: 0x0033FB0C File Offset: 0x0033DD0C
		public static void AddVarType(FlatBufferBuilder builder, EFlagChallengeSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601678E RID: 92046 RVA: 0x0033FB17 File Offset: 0x0033DD17
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0601678F RID: 92047 RVA: 0x0033FB22 File Offset: 0x0033DD22
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06016790 RID: 92048 RVA: 0x0033FB2D File Offset: 0x0033DD2D
		public static Offset<IFlagChallengeSystemVar> EndIFlagChallengeSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IFlagChallengeSystemVar>(builder.EndTable());
		}

		// Token: 0x06016791 RID: 92049 RVA: 0x0033FB3C File Offset: 0x0033DD3C
		public IFlagChallengeSystemVarT UnPack()
		{
			IFlagChallengeSystemVarT flagChallengeSystemVarT = new IFlagChallengeSystemVarT();
			this.UnPackTo(flagChallengeSystemVarT);
			return flagChallengeSystemVarT;
		}

		// Token: 0x06016792 RID: 92050 RVA: 0x0033FB58 File Offset: 0x0033DD58
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

		// Token: 0x06016793 RID: 92051 RVA: 0x0033FCC4 File Offset: 0x0033DEC4
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

		// Token: 0x0400B80A RID: 47114
		private Table __p;
	}
}
