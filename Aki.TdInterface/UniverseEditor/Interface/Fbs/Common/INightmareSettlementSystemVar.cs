using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644C RID: 25676
	public struct INightmareSettlementSystemVar : IFlatbufferObject
	{
		// Token: 0x1700BD93 RID: 48531
		// (get) Token: 0x0602BA1B RID: 178715 RVA: 0x005F080C File Offset: 0x005EEA0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA1C RID: 178716 RVA: 0x005F0819 File Offset: 0x005EEA19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA1D RID: 178717 RVA: 0x005F0820 File Offset: 0x005EEA20
		public static INightmareSettlementSystemVar GetRootAsINightmareSettlementSystemVar(ByteBuffer _bb)
		{
			return INightmareSettlementSystemVar.GetRootAsINightmareSettlementSystemVar(_bb, default(INightmareSettlementSystemVar));
		}

		// Token: 0x0602BA1E RID: 178718 RVA: 0x005F083C File Offset: 0x005EEA3C
		public static INightmareSettlementSystemVar GetRootAsINightmareSettlementSystemVar(ByteBuffer _bb, INightmareSettlementSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA1F RID: 178719 RVA: 0x005F0859 File Offset: 0x005EEA59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA20 RID: 178720 RVA: 0x005F0868 File Offset: 0x005EEA68
		public INightmareSettlementSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD94 RID: 48532
		// (get) Token: 0x0602BA21 RID: 178721 RVA: 0x005F0878 File Offset: 0x005EEA78
		public ENightmareSettlementSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENightmareSettlementSystemVarType.MonsterKilled;
				}
				return (ENightmareSettlementSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD95 RID: 48533
		// (get) Token: 0x0602BA22 RID: 178722 RVA: 0x005F08B4 File Offset: 0x005EEAB4
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

		// Token: 0x0602BA23 RID: 178723 RVA: 0x005F08F0 File Offset: 0x005EEAF0
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BA24 RID: 178724 RVA: 0x005F0934 File Offset: 0x005EEB34
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0602BA25 RID: 178725 RVA: 0x005F0950 File Offset: 0x005EEB50
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0602BA26 RID: 178726 RVA: 0x005F096C File Offset: 0x005EEB6C
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0602BA27 RID: 178727 RVA: 0x005F0988 File Offset: 0x005EEB88
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0602BA28 RID: 178728 RVA: 0x005F09A4 File Offset: 0x005EEBA4
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0602BA29 RID: 178729 RVA: 0x005F09BF File Offset: 0x005EEBBF
		public static Offset<INightmareSettlementSystemVar> CreateINightmareSettlementSystemVar(FlatBufferBuilder builder, ENightmareSettlementSystemVarType VarType = ENightmareSettlementSystemVarType.MonsterKilled, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			INightmareSettlementSystemVar.AddVarRef(builder, VarRefOffset);
			INightmareSettlementSystemVar.AddVarRefType(builder, VarRef_type);
			INightmareSettlementSystemVar.AddVarType(builder, VarType);
			return INightmareSettlementSystemVar.EndINightmareSettlementSystemVar(builder);
		}

		// Token: 0x0602BA2A RID: 178730 RVA: 0x005F09E3 File Offset: 0x005EEBE3
		public static void StartINightmareSettlementSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BA2B RID: 178731 RVA: 0x005F09EC File Offset: 0x005EEBEC
		public static void AddVarType(FlatBufferBuilder builder, ENightmareSettlementSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0602BA2C RID: 178732 RVA: 0x005F09F7 File Offset: 0x005EEBF7
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0602BA2D RID: 178733 RVA: 0x005F0A02 File Offset: 0x005EEC02
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x0602BA2E RID: 178734 RVA: 0x005F0A0D File Offset: 0x005EEC0D
		public static Offset<INightmareSettlementSystemVar> EndINightmareSettlementSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSettlementSystemVar>(builder.EndTable());
		}

		// Token: 0x0602BA2F RID: 178735 RVA: 0x005F0A1C File Offset: 0x005EEC1C
		public INightmareSettlementSystemVarT UnPack()
		{
			INightmareSettlementSystemVarT nightmareSettlementSystemVarT = new INightmareSettlementSystemVarT();
			this.UnPackTo(nightmareSettlementSystemVarT);
			return nightmareSettlementSystemVarT;
		}

		// Token: 0x0602BA30 RID: 178736 RVA: 0x005F0A38 File Offset: 0x005EEC38
		public void UnPackTo(INightmareSettlementSystemVarT _o)
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

		// Token: 0x0602BA31 RID: 178737 RVA: 0x005F0BA4 File Offset: 0x005EEDA4
		public static Offset<INightmareSettlementSystemVar> Pack(FlatBufferBuilder builder, INightmareSettlementSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<INightmareSettlementSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return INightmareSettlementSystemVar.CreateINightmareSettlementSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x04010560 RID: 66912
		private Table __p;
	}
}
