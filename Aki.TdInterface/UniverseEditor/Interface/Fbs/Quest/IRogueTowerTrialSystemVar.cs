using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F9 RID: 17657
	public struct IRogueTowerTrialSystemVar : IFlatbufferObject
	{
		// Token: 0x17007AF2 RID: 31474
		// (get) Token: 0x060198CE RID: 104654 RVA: 0x003A4974 File Offset: 0x003A2B74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060198CF RID: 104655 RVA: 0x003A4981 File Offset: 0x003A2B81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060198D0 RID: 104656 RVA: 0x003A4988 File Offset: 0x003A2B88
		public static IRogueTowerTrialSystemVar GetRootAsIRogueTowerTrialSystemVar(ByteBuffer _bb)
		{
			return IRogueTowerTrialSystemVar.GetRootAsIRogueTowerTrialSystemVar(_bb, default(IRogueTowerTrialSystemVar));
		}

		// Token: 0x060198D1 RID: 104657 RVA: 0x003A49A4 File Offset: 0x003A2BA4
		public static IRogueTowerTrialSystemVar GetRootAsIRogueTowerTrialSystemVar(ByteBuffer _bb, IRogueTowerTrialSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060198D2 RID: 104658 RVA: 0x003A49C1 File Offset: 0x003A2BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060198D3 RID: 104659 RVA: 0x003A49D0 File Offset: 0x003A2BD0
		public IRogueTowerTrialSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007AF3 RID: 31475
		// (get) Token: 0x060198D4 RID: 104660 RVA: 0x003A49E0 File Offset: 0x003A2BE0
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

		// Token: 0x17007AF4 RID: 31476
		// (get) Token: 0x060198D5 RID: 104661 RVA: 0x003A4A1C File Offset: 0x003A2C1C
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

		// Token: 0x060198D6 RID: 104662 RVA: 0x003A4A58 File Offset: 0x003A2C58
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060198D7 RID: 104663 RVA: 0x003A4A9C File Offset: 0x003A2C9C
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060198D8 RID: 104664 RVA: 0x003A4AB8 File Offset: 0x003A2CB8
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060198D9 RID: 104665 RVA: 0x003A4AD4 File Offset: 0x003A2CD4
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060198DA RID: 104666 RVA: 0x003A4AF0 File Offset: 0x003A2CF0
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060198DB RID: 104667 RVA: 0x003A4B0C File Offset: 0x003A2D0C
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060198DC RID: 104668 RVA: 0x003A4B27 File Offset: 0x003A2D27
		public static Offset<IRogueTowerTrialSystemVar> CreateIRogueTowerTrialSystemVar(FlatBufferBuilder builder, ERogueTowerTrialSystemVarType VarType = ERogueTowerTrialSystemVarType.KillBoss1, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IRogueTowerTrialSystemVar.AddVarRef(builder, VarRefOffset);
			IRogueTowerTrialSystemVar.AddVarRefType(builder, VarRef_type);
			IRogueTowerTrialSystemVar.AddVarType(builder, VarType);
			return IRogueTowerTrialSystemVar.EndIRogueTowerTrialSystemVar(builder);
		}

		// Token: 0x060198DD RID: 104669 RVA: 0x003A4B4B File Offset: 0x003A2D4B
		public static void StartIRogueTowerTrialSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060198DE RID: 104670 RVA: 0x003A4B54 File Offset: 0x003A2D54
		public static void AddVarType(FlatBufferBuilder builder, ERogueTowerTrialSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060198DF RID: 104671 RVA: 0x003A4B5F File Offset: 0x003A2D5F
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060198E0 RID: 104672 RVA: 0x003A4B6A File Offset: 0x003A2D6A
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060198E1 RID: 104673 RVA: 0x003A4B75 File Offset: 0x003A2D75
		public static Offset<IRogueTowerTrialSystemVar> EndIRogueTowerTrialSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IRogueTowerTrialSystemVar>(builder.EndTable());
		}

		// Token: 0x060198E2 RID: 104674 RVA: 0x003A4B84 File Offset: 0x003A2D84
		public IRogueTowerTrialSystemVarT UnPack()
		{
			IRogueTowerTrialSystemVarT rogueTowerTrialSystemVarT = new IRogueTowerTrialSystemVarT();
			this.UnPackTo(rogueTowerTrialSystemVarT);
			return rogueTowerTrialSystemVarT;
		}

		// Token: 0x060198E3 RID: 104675 RVA: 0x003A4BA0 File Offset: 0x003A2DA0
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

		// Token: 0x060198E4 RID: 104676 RVA: 0x003A4D0C File Offset: 0x003A2F0C
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

		// Token: 0x0400C638 RID: 50744
		private Table __p;
	}
}
