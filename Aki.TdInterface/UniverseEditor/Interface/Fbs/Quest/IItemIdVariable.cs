using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB7 RID: 16055
	public struct IItemIdVariable : IFlatbufferObject
	{
		// Token: 0x17006F6D RID: 28525
		// (get) Token: 0x06016AD1 RID: 92881 RVA: 0x00346293 File Offset: 0x00344493
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AD2 RID: 92882 RVA: 0x003462A0 File Offset: 0x003444A0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AD3 RID: 92883 RVA: 0x003462A8 File Offset: 0x003444A8
		public static IItemIdVariable GetRootAsIItemIdVariable(ByteBuffer _bb)
		{
			return IItemIdVariable.GetRootAsIItemIdVariable(_bb, default(IItemIdVariable));
		}

		// Token: 0x06016AD4 RID: 92884 RVA: 0x003462C4 File Offset: 0x003444C4
		public static IItemIdVariable GetRootAsIItemIdVariable(ByteBuffer _bb, IItemIdVariable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AD5 RID: 92885 RVA: 0x003462E1 File Offset: 0x003444E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016AD6 RID: 92886 RVA: 0x003462F0 File Offset: 0x003444F0
		public IItemIdVariable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F6E RID: 28526
		// (get) Token: 0x06016AD7 RID: 92887 RVA: 0x00346300 File Offset: 0x00344500
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

		// Token: 0x17006F6F RID: 28527
		// (get) Token: 0x06016AD8 RID: 92888 RVA: 0x0034633C File Offset: 0x0034453C
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

		// Token: 0x06016AD9 RID: 92889 RVA: 0x00346378 File Offset: 0x00344578
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x003463BC File Offset: 0x003445BC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06016ADB RID: 92891 RVA: 0x003463D8 File Offset: 0x003445D8
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06016ADC RID: 92892 RVA: 0x003463F4 File Offset: 0x003445F4
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06016ADD RID: 92893 RVA: 0x00346410 File Offset: 0x00344610
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x0034642C File Offset: 0x0034462C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17006F70 RID: 28528
		// (get) Token: 0x06016ADF RID: 92895 RVA: 0x00346448 File Offset: 0x00344648
		public int ItemId
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

		// Token: 0x06016AE0 RID: 92896 RVA: 0x00346485 File Offset: 0x00344685
		public static Offset<IItemIdVariable> CreateIItemIdVariable(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int ItemId = 0)
		{
			builder.StartTable(4);
			IItemIdVariable.AddItemId(builder, ItemId);
			IItemIdVariable.AddVar(builder, VarOffset);
			IItemIdVariable.AddVarType(builder, Var_type);
			IItemIdVariable.AddType(builder, Type);
			return IItemIdVariable.EndIItemIdVariable(builder);
		}

		// Token: 0x06016AE1 RID: 92897 RVA: 0x003464B1 File Offset: 0x003446B1
		public static void StartIItemIdVariable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016AE2 RID: 92898 RVA: 0x003464BA File Offset: 0x003446BA
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016AE3 RID: 92899 RVA: 0x003464C5 File Offset: 0x003446C5
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06016AE4 RID: 92900 RVA: 0x003464D0 File Offset: 0x003446D0
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06016AE5 RID: 92901 RVA: 0x003464DB File Offset: 0x003446DB
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(3, itemId, 0);
		}

		// Token: 0x06016AE6 RID: 92902 RVA: 0x003464E6 File Offset: 0x003446E6
		public static Offset<IItemIdVariable> EndIItemIdVariable(FlatBufferBuilder builder)
		{
			return new Offset<IItemIdVariable>(builder.EndTable());
		}

		// Token: 0x06016AE7 RID: 92903 RVA: 0x003464F4 File Offset: 0x003446F4
		public IItemIdVariableT UnPack()
		{
			IItemIdVariableT itemIdVariableT = new IItemIdVariableT();
			this.UnPackTo(itemIdVariableT);
			return itemIdVariableT;
		}

		// Token: 0x06016AE8 RID: 92904 RVA: 0x00346510 File Offset: 0x00344710
		public void UnPackTo(IItemIdVariableT _o)
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
			_o.ItemId = this.ItemId;
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x00346698 File Offset: 0x00344898
		public static Offset<IItemIdVariable> Pack(FlatBufferBuilder builder, IItemIdVariableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemIdVariable>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IItemIdVariable.CreateIItemIdVariable(builder, _o.Type, var_type, varOffset, _o.ItemId);
		}

		// Token: 0x0400B887 RID: 47239
		private Table __p;
	}
}
