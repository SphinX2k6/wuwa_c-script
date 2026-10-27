using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0F RID: 24079
	public struct INightmareSettlementSystemVar : IFlatbufferObject
	{
		// Token: 0x1700B42D RID: 46125
		// (get) Token: 0x06029391 RID: 168849 RVA: 0x005A7ADC File Offset: 0x005A5CDC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029392 RID: 168850 RVA: 0x005A7AE9 File Offset: 0x005A5CE9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029393 RID: 168851 RVA: 0x005A7AF0 File Offset: 0x005A5CF0
		public static INightmareSettlementSystemVar GetRootAsINightmareSettlementSystemVar(ByteBuffer _bb)
		{
			return INightmareSettlementSystemVar.GetRootAsINightmareSettlementSystemVar(_bb, default(INightmareSettlementSystemVar));
		}

		// Token: 0x06029394 RID: 168852 RVA: 0x005A7B0C File Offset: 0x005A5D0C
		public static INightmareSettlementSystemVar GetRootAsINightmareSettlementSystemVar(ByteBuffer _bb, INightmareSettlementSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029395 RID: 168853 RVA: 0x005A7B29 File Offset: 0x005A5D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029396 RID: 168854 RVA: 0x005A7B38 File Offset: 0x005A5D38
		public INightmareSettlementSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B42E RID: 46126
		// (get) Token: 0x06029397 RID: 168855 RVA: 0x005A7B48 File Offset: 0x005A5D48
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

		// Token: 0x1700B42F RID: 46127
		// (get) Token: 0x06029398 RID: 168856 RVA: 0x005A7B84 File Offset: 0x005A5D84
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

		// Token: 0x06029399 RID: 168857 RVA: 0x005A7BC0 File Offset: 0x005A5DC0
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602939A RID: 168858 RVA: 0x005A7C04 File Offset: 0x005A5E04
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0602939B RID: 168859 RVA: 0x005A7C20 File Offset: 0x005A5E20
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0602939C RID: 168860 RVA: 0x005A7C3C File Offset: 0x005A5E3C
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0602939D RID: 168861 RVA: 0x005A7C58 File Offset: 0x005A5E58
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0602939E RID: 168862 RVA: 0x005A7C74 File Offset: 0x005A5E74
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0602939F RID: 168863 RVA: 0x005A7C8F File Offset: 0x005A5E8F
		public static Offset<INightmareSettlementSystemVar> CreateINightmareSettlementSystemVar(FlatBufferBuilder builder, ENightmareSettlementSystemVarType VarType = ENightmareSettlementSystemVarType.MonsterKilled, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			INightmareSettlementSystemVar.AddVarRef(builder, VarRefOffset);
			INightmareSettlementSystemVar.AddVarRefType(builder, VarRef_type);
			INightmareSettlementSystemVar.AddVarType(builder, VarType);
			return INightmareSettlementSystemVar.EndINightmareSettlementSystemVar(builder);
		}

		// Token: 0x060293A0 RID: 168864 RVA: 0x005A7CB3 File Offset: 0x005A5EB3
		public static void StartINightmareSettlementSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060293A1 RID: 168865 RVA: 0x005A7CBC File Offset: 0x005A5EBC
		public static void AddVarType(FlatBufferBuilder builder, ENightmareSettlementSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060293A2 RID: 168866 RVA: 0x005A7CC7 File Offset: 0x005A5EC7
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060293A3 RID: 168867 RVA: 0x005A7CD2 File Offset: 0x005A5ED2
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060293A4 RID: 168868 RVA: 0x005A7CDD File Offset: 0x005A5EDD
		public static Offset<INightmareSettlementSystemVar> EndINightmareSettlementSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<INightmareSettlementSystemVar>(builder.EndTable());
		}

		// Token: 0x060293A5 RID: 168869 RVA: 0x005A7CEC File Offset: 0x005A5EEC
		public INightmareSettlementSystemVarT UnPack()
		{
			INightmareSettlementSystemVarT nightmareSettlementSystemVarT = new INightmareSettlementSystemVarT();
			this.UnPackTo(nightmareSettlementSystemVarT);
			return nightmareSettlementSystemVarT;
		}

		// Token: 0x060293A6 RID: 168870 RVA: 0x005A7D08 File Offset: 0x005A5F08
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

		// Token: 0x060293A7 RID: 168871 RVA: 0x005A7E74 File Offset: 0x005A6074
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

		// Token: 0x0400F805 RID: 63493
		private Table __p;
	}
}
