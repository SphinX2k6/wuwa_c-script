using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004583 RID: 17795
	public struct ISpecificMonsterDeadPosition : IFlatbufferObject
	{
		// Token: 0x17007C51 RID: 31825
		// (get) Token: 0x06019EA3 RID: 106147 RVA: 0x003B2012 File Offset: 0x003B0212
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019EA4 RID: 106148 RVA: 0x003B201F File Offset: 0x003B021F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019EA5 RID: 106149 RVA: 0x003B2028 File Offset: 0x003B0228
		public static ISpecificMonsterDeadPosition GetRootAsISpecificMonsterDeadPosition(ByteBuffer _bb)
		{
			return ISpecificMonsterDeadPosition.GetRootAsISpecificMonsterDeadPosition(_bb, default(ISpecificMonsterDeadPosition));
		}

		// Token: 0x06019EA6 RID: 106150 RVA: 0x003B2044 File Offset: 0x003B0244
		public static ISpecificMonsterDeadPosition GetRootAsISpecificMonsterDeadPosition(ByteBuffer _bb, ISpecificMonsterDeadPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019EA7 RID: 106151 RVA: 0x003B2061 File Offset: 0x003B0261
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019EA8 RID: 106152 RVA: 0x003B2070 File Offset: 0x003B0270
		public ISpecificMonsterDeadPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C52 RID: 31826
		// (get) Token: 0x06019EA9 RID: 106153 RVA: 0x003B2080 File Offset: 0x003B0280
		public ESpecificDeadMonsterType MonsterType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecificDeadMonsterType.LastDead;
				}
				return (ESpecificDeadMonsterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007C53 RID: 31827
		// (get) Token: 0x06019EAA RID: 106154 RVA: 0x003B20BC File Offset: 0x003B02BC
		public TVarRef VarType
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

		// Token: 0x06019EAB RID: 106155 RVA: 0x003B20F8 File Offset: 0x003B02F8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019EAC RID: 106156 RVA: 0x003B213C File Offset: 0x003B033C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06019EAD RID: 106157 RVA: 0x003B2158 File Offset: 0x003B0358
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06019EAE RID: 106158 RVA: 0x003B2174 File Offset: 0x003B0374
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06019EAF RID: 106159 RVA: 0x003B2190 File Offset: 0x003B0390
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06019EB0 RID: 106160 RVA: 0x003B21AC File Offset: 0x003B03AC
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17007C54 RID: 31828
		// (get) Token: 0x06019EB1 RID: 106161 RVA: 0x003B21C8 File Offset: 0x003B03C8
		public bool IsIgnoreRot
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007C55 RID: 31829
		// (get) Token: 0x06019EB2 RID: 106162 RVA: 0x003B2208 File Offset: 0x003B0408
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019EB3 RID: 106163 RVA: 0x003B2245 File Offset: 0x003B0445
		public static Offset<ISpecificMonsterDeadPosition> CreateISpecificMonsterDeadPosition(FlatBufferBuilder builder, ESpecificDeadMonsterType MonsterType = ESpecificDeadMonsterType.LastDead, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, bool IsIgnoreRot = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISpecificMonsterDeadPosition.AddVar(builder, VarOffset);
			ISpecificMonsterDeadPosition.AddNullMask(builder, NullMask);
			ISpecificMonsterDeadPosition.AddIsIgnoreRot(builder, IsIgnoreRot);
			ISpecificMonsterDeadPosition.AddVarType(builder, Var_type);
			ISpecificMonsterDeadPosition.AddMonsterType(builder, MonsterType);
			return ISpecificMonsterDeadPosition.EndISpecificMonsterDeadPosition(builder);
		}

		// Token: 0x06019EB4 RID: 106164 RVA: 0x003B2279 File Offset: 0x003B0479
		public static void StartISpecificMonsterDeadPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06019EB5 RID: 106165 RVA: 0x003B2282 File Offset: 0x003B0482
		public static void AddMonsterType(FlatBufferBuilder builder, ESpecificDeadMonsterType monsterType)
		{
			builder.AddByte(0, (byte)monsterType, 0);
		}

		// Token: 0x06019EB6 RID: 106166 RVA: 0x003B228D File Offset: 0x003B048D
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06019EB7 RID: 106167 RVA: 0x003B2298 File Offset: 0x003B0498
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06019EB8 RID: 106168 RVA: 0x003B22A3 File Offset: 0x003B04A3
		public static void AddIsIgnoreRot(FlatBufferBuilder builder, bool isIgnoreRot)
		{
			builder.AddBool(3, isIgnoreRot, false);
		}

		// Token: 0x06019EB9 RID: 106169 RVA: 0x003B22AE File Offset: 0x003B04AE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06019EBA RID: 106170 RVA: 0x003B22B9 File Offset: 0x003B04B9
		public static Offset<ISpecificMonsterDeadPosition> EndISpecificMonsterDeadPosition(FlatBufferBuilder builder)
		{
			return new Offset<ISpecificMonsterDeadPosition>(builder.EndTable());
		}

		// Token: 0x06019EBB RID: 106171 RVA: 0x003B22C8 File Offset: 0x003B04C8
		public ISpecificMonsterDeadPositionT UnPack()
		{
			ISpecificMonsterDeadPositionT specificMonsterDeadPositionT = new ISpecificMonsterDeadPositionT();
			this.UnPackTo(specificMonsterDeadPositionT);
			return specificMonsterDeadPositionT;
		}

		// Token: 0x06019EBC RID: 106172 RVA: 0x003B22E4 File Offset: 0x003B04E4
		public void UnPackTo(ISpecificMonsterDeadPositionT _o)
		{
			_o.MonsterType = this.MonsterType;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.IsIgnoreRot = this.IsIgnoreRot;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019EBD RID: 106173 RVA: 0x003B2478 File Offset: 0x003B0678
		public static Offset<ISpecificMonsterDeadPosition> Pack(FlatBufferBuilder builder, ISpecificMonsterDeadPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecificMonsterDeadPosition>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return ISpecificMonsterDeadPosition.CreateISpecificMonsterDeadPosition(builder, _o.MonsterType, var_type, varOffset, _o.IsIgnoreRot, _o.NullMask);
		}

		// Token: 0x0400C735 RID: 50997
		private Table __p;
	}
}
