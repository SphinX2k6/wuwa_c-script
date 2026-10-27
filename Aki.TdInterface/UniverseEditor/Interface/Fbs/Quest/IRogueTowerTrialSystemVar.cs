using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B8 RID: 16568
	public struct IRogueTowerTrialSystemVar : IFlatbufferObject
	{
		// Token: 0x170074EC RID: 29932
		// (get) Token: 0x0601822D RID: 98861 RVA: 0x0037AA24 File Offset: 0x00378C24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601822E RID: 98862 RVA: 0x0037AA31 File Offset: 0x00378C31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601822F RID: 98863 RVA: 0x0037AA38 File Offset: 0x00378C38
		public static IRogueTowerTrialSystemVar GetRootAsIRogueTowerTrialSystemVar(ByteBuffer _bb)
		{
			return IRogueTowerTrialSystemVar.GetRootAsIRogueTowerTrialSystemVar(_bb, default(IRogueTowerTrialSystemVar));
		}

		// Token: 0x06018230 RID: 98864 RVA: 0x0037AA54 File Offset: 0x00378C54
		public static IRogueTowerTrialSystemVar GetRootAsIRogueTowerTrialSystemVar(ByteBuffer _bb, IRogueTowerTrialSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018231 RID: 98865 RVA: 0x0037AA71 File Offset: 0x00378C71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018232 RID: 98866 RVA: 0x0037AA80 File Offset: 0x00378C80
		public IRogueTowerTrialSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074ED RID: 29933
		// (get) Token: 0x06018233 RID: 98867 RVA: 0x0037AA90 File Offset: 0x00378C90
		public ERogueTowerTrialSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERogueTowerTrialSystemVarType.KillBoss1;
				}
				return (ERogueTowerTrialSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074EE RID: 29934
		// (get) Token: 0x06018234 RID: 98868 RVA: 0x0037AACC File Offset: 0x00378CCC
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

		// Token: 0x06018235 RID: 98869 RVA: 0x0037AB08 File Offset: 0x00378D08
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018236 RID: 98870 RVA: 0x0037AB4C File Offset: 0x00378D4C
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06018237 RID: 98871 RVA: 0x0037AB68 File Offset: 0x00378D68
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06018238 RID: 98872 RVA: 0x0037AB84 File Offset: 0x00378D84
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06018239 RID: 98873 RVA: 0x0037ABA0 File Offset: 0x00378DA0
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601823A RID: 98874 RVA: 0x0037ABBC File Offset: 0x00378DBC
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601823B RID: 98875 RVA: 0x0037ABD7 File Offset: 0x00378DD7
		public static Offset<IRogueTowerTrialSystemVar> CreateIRogueTowerTrialSystemVar(FlatBufferBuilder builder, ERogueTowerTrialSystemVarType VarType = ERogueTowerTrialSystemVarType.KillBoss1, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IRogueTowerTrialSystemVar.AddVarRef(builder, VarRefOffset);
			IRogueTowerTrialSystemVar.AddVarRefType(builder, VarRef_type);
			IRogueTowerTrialSystemVar.AddVarType(builder, VarType);
			return IRogueTowerTrialSystemVar.EndIRogueTowerTrialSystemVar(builder);
		}

		// Token: 0x0601823C RID: 98876 RVA: 0x0037ABFB File Offset: 0x00378DFB
		public static void StartIRogueTowerTrialSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601823D RID: 98877 RVA: 0x0037AC04 File Offset: 0x00378E04
		public static void AddVarType(FlatBufferBuilder builder, ERogueTowerTrialSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601823E RID: 98878 RVA: 0x0037AC0F File Offset: 0x00378E0F
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0601823F RID: 98879 RVA: 0x0037AC1A File Offset: 0x00378E1A
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06018240 RID: 98880 RVA: 0x0037AC25 File Offset: 0x00378E25
		public static Offset<IRogueTowerTrialSystemVar> EndIRogueTowerTrialSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IRogueTowerTrialSystemVar>(builder.EndTable());
		}

		// Token: 0x06018241 RID: 98881 RVA: 0x0037AC34 File Offset: 0x00378E34
		public IRogueTowerTrialSystemVarT UnPack()
		{
			IRogueTowerTrialSystemVarT rogueTowerTrialSystemVarT = new IRogueTowerTrialSystemVarT();
			this.UnPackTo(rogueTowerTrialSystemVarT);
			return rogueTowerTrialSystemVarT;
		}

		// Token: 0x06018242 RID: 98882 RVA: 0x0037AC50 File Offset: 0x00378E50
		public void UnPackTo(IRogueTowerTrialSystemVarT _o)
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

		// Token: 0x06018243 RID: 98883 RVA: 0x0037ADBC File Offset: 0x00378FBC
		public static Offset<IRogueTowerTrialSystemVar> Pack(FlatBufferBuilder builder, IRogueTowerTrialSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRogueTowerTrialSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IRogueTowerTrialSystemVar.CreateIRogueTowerTrialSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400BC4F RID: 48207
		private Table __p;
	}
}
