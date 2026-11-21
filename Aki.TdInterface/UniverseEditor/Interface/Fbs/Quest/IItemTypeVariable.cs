using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FB RID: 17147
	public struct IItemTypeVariable : IFlatbufferObject
	{
		// Token: 0x17007568 RID: 30056
		// (get) Token: 0x06018161 RID: 98657 RVA: 0x0036FAF4 File Offset: 0x0036DCF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018162 RID: 98658 RVA: 0x0036FB01 File Offset: 0x0036DD01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018163 RID: 98659 RVA: 0x0036FB08 File Offset: 0x0036DD08
		public static IItemTypeVariable GetRootAsIItemTypeVariable(ByteBuffer _bb)
		{
			return IItemTypeVariable.GetRootAsIItemTypeVariable(_bb, default(IItemTypeVariable));
		}

		// Token: 0x06018164 RID: 98660 RVA: 0x0036FB24 File Offset: 0x0036DD24
		public static IItemTypeVariable GetRootAsIItemTypeVariable(ByteBuffer _bb, IItemTypeVariable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018165 RID: 98661 RVA: 0x0036FB41 File Offset: 0x0036DD41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018166 RID: 98662 RVA: 0x0036FB50 File Offset: 0x0036DD50
		public IItemTypeVariable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007569 RID: 30057
		// (get) Token: 0x06018167 RID: 98663 RVA: 0x0036FB60 File Offset: 0x0036DD60
		public EHandInItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInItemType.ItemIds;
				}
				return (EHandInItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700756A RID: 30058
		// (get) Token: 0x06018168 RID: 98664 RVA: 0x0036FB9C File Offset: 0x0036DD9C
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

		// Token: 0x06018169 RID: 98665 RVA: 0x0036FBD8 File Offset: 0x0036DDD8
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601816A RID: 98666 RVA: 0x0036FC1C File Offset: 0x0036DE1C
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601816B RID: 98667 RVA: 0x0036FC38 File Offset: 0x0036DE38
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601816C RID: 98668 RVA: 0x0036FC54 File Offset: 0x0036DE54
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601816D RID: 98669 RVA: 0x0036FC70 File Offset: 0x0036DE70
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601816E RID: 98670 RVA: 0x0036FC8C File Offset: 0x0036DE8C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700756B RID: 30059
		// (get) Token: 0x0601816F RID: 98671 RVA: 0x0036FCA8 File Offset: 0x0036DEA8
		public int ItemType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018170 RID: 98672 RVA: 0x0036FCE5 File Offset: 0x0036DEE5
		public static Offset<IItemTypeVariable> CreateIItemTypeVariable(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int ItemType = 0)
		{
			builder.StartTable(4);
			IItemTypeVariable.AddItemType(builder, ItemType);
			IItemTypeVariable.AddVar(builder, VarOffset);
			IItemTypeVariable.AddVarType(builder, Var_type);
			IItemTypeVariable.AddType(builder, Type);
			return IItemTypeVariable.EndIItemTypeVariable(builder);
		}

		// Token: 0x06018171 RID: 98673 RVA: 0x0036FD11 File Offset: 0x0036DF11
		public static void StartIItemTypeVariable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018172 RID: 98674 RVA: 0x0036FD1A File Offset: 0x0036DF1A
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018173 RID: 98675 RVA: 0x0036FD25 File Offset: 0x0036DF25
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06018174 RID: 98676 RVA: 0x0036FD30 File Offset: 0x0036DF30
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06018175 RID: 98677 RVA: 0x0036FD3B File Offset: 0x0036DF3B
		public static void AddItemType(FlatBufferBuilder builder, int itemType)
		{
			builder.AddInt(3, itemType, 0);
		}

		// Token: 0x06018176 RID: 98678 RVA: 0x0036FD46 File Offset: 0x0036DF46
		public static Offset<IItemTypeVariable> EndIItemTypeVariable(FlatBufferBuilder builder)
		{
			return new Offset<IItemTypeVariable>(builder.EndTable());
		}

		// Token: 0x06018177 RID: 98679 RVA: 0x0036FD54 File Offset: 0x0036DF54
		public IItemTypeVariableT UnPack()
		{
			IItemTypeVariableT itemTypeVariableT = new IItemTypeVariableT();
			this.UnPackTo(itemTypeVariableT);
			return itemTypeVariableT;
		}

		// Token: 0x06018178 RID: 98680 RVA: 0x0036FD70 File Offset: 0x0036DF70
		public void UnPackTo(IItemTypeVariableT _o)
		{
			_o.Type = this.Type;
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
			_o.ItemType = this.ItemType;
		}

		// Token: 0x06018179 RID: 98681 RVA: 0x0036FEF8 File Offset: 0x0036E0F8
		public static Offset<IItemTypeVariable> Pack(FlatBufferBuilder builder, IItemTypeVariableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemTypeVariable>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IItemTypeVariable.CreateIItemTypeVariable(builder, _o.Type, var_type, varOffset, _o.ItemType);
		}

		// Token: 0x0400C26B RID: 49771
		private Table __p;
	}
}
