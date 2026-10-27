using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416F RID: 16751
	public struct ISurvivorsRougeSystemVar : IFlatbufferObject
	{
		// Token: 0x170076A3 RID: 30371
		// (get) Token: 0x060189AA RID: 100778 RVA: 0x0038B404 File Offset: 0x00389604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060189AB RID: 100779 RVA: 0x0038B411 File Offset: 0x00389611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060189AC RID: 100780 RVA: 0x0038B418 File Offset: 0x00389618
		public static ISurvivorsRougeSystemVar GetRootAsISurvivorsRougeSystemVar(ByteBuffer _bb)
		{
			return ISurvivorsRougeSystemVar.GetRootAsISurvivorsRougeSystemVar(_bb, default(ISurvivorsRougeSystemVar));
		}

		// Token: 0x060189AD RID: 100781 RVA: 0x0038B434 File Offset: 0x00389634
		public static ISurvivorsRougeSystemVar GetRootAsISurvivorsRougeSystemVar(ByteBuffer _bb, ISurvivorsRougeSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060189AE RID: 100782 RVA: 0x0038B451 File Offset: 0x00389651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060189AF RID: 100783 RVA: 0x0038B460 File Offset: 0x00389660
		public ISurvivorsRougeSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076A4 RID: 30372
		// (get) Token: 0x060189B0 RID: 100784 RVA: 0x0038B470 File Offset: 0x00389670
		public ESurvivorsRougeSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESurvivorsRougeSystemVarType.Gold;
				}
				return (ESurvivorsRougeSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076A5 RID: 30373
		// (get) Token: 0x060189B1 RID: 100785 RVA: 0x0038B4AC File Offset: 0x003896AC
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

		// Token: 0x060189B2 RID: 100786 RVA: 0x0038B4E8 File Offset: 0x003896E8
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060189B3 RID: 100787 RVA: 0x0038B52C File Offset: 0x0038972C
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060189B4 RID: 100788 RVA: 0x0038B548 File Offset: 0x00389748
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060189B5 RID: 100789 RVA: 0x0038B564 File Offset: 0x00389764
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060189B6 RID: 100790 RVA: 0x0038B580 File Offset: 0x00389780
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060189B7 RID: 100791 RVA: 0x0038B59C File Offset: 0x0038979C
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060189B8 RID: 100792 RVA: 0x0038B5B7 File Offset: 0x003897B7
		public static Offset<ISurvivorsRougeSystemVar> CreateISurvivorsRougeSystemVar(FlatBufferBuilder builder, ESurvivorsRougeSystemVarType VarType = ESurvivorsRougeSystemVarType.Gold, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			ISurvivorsRougeSystemVar.AddVarRef(builder, VarRefOffset);
			ISurvivorsRougeSystemVar.AddVarRefType(builder, VarRef_type);
			ISurvivorsRougeSystemVar.AddVarType(builder, VarType);
			return ISurvivorsRougeSystemVar.EndISurvivorsRougeSystemVar(builder);
		}

		// Token: 0x060189B9 RID: 100793 RVA: 0x0038B5DB File Offset: 0x003897DB
		public static void StartISurvivorsRougeSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060189BA RID: 100794 RVA: 0x0038B5E4 File Offset: 0x003897E4
		public static void AddVarType(FlatBufferBuilder builder, ESurvivorsRougeSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060189BB RID: 100795 RVA: 0x0038B5EF File Offset: 0x003897EF
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060189BC RID: 100796 RVA: 0x0038B5FA File Offset: 0x003897FA
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060189BD RID: 100797 RVA: 0x0038B605 File Offset: 0x00389805
		public static Offset<ISurvivorsRougeSystemVar> EndISurvivorsRougeSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<ISurvivorsRougeSystemVar>(builder.EndTable());
		}

		// Token: 0x060189BE RID: 100798 RVA: 0x0038B614 File Offset: 0x00389814
		public ISurvivorsRougeSystemVarT UnPack()
		{
			ISurvivorsRougeSystemVarT survivorsRougeSystemVarT = new ISurvivorsRougeSystemVarT();
			this.UnPackTo(survivorsRougeSystemVarT);
			return survivorsRougeSystemVarT;
		}

		// Token: 0x060189BF RID: 100799 RVA: 0x0038B630 File Offset: 0x00389830
		public void UnPackTo(ISurvivorsRougeSystemVarT _o)
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

		// Token: 0x060189C0 RID: 100800 RVA: 0x0038B79C File Offset: 0x0038999C
		public static Offset<ISurvivorsRougeSystemVar> Pack(FlatBufferBuilder builder, ISurvivorsRougeSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISurvivorsRougeSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return ISurvivorsRougeSystemVar.CreateISurvivorsRougeSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400BD8A RID: 48522
		private Table __p;
	}
}
