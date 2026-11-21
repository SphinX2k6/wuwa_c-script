using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042F5 RID: 17141
	public struct IItemIdVariable : IFlatbufferObject
	{
		// Token: 0x1700755A RID: 30042
		// (get) Token: 0x0601811E RID: 98590 RVA: 0x0036F21B File Offset: 0x0036D41B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601811F RID: 98591 RVA: 0x0036F228 File Offset: 0x0036D428
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018120 RID: 98592 RVA: 0x0036F230 File Offset: 0x0036D430
		public static IItemIdVariable GetRootAsIItemIdVariable(ByteBuffer _bb)
		{
			return IItemIdVariable.GetRootAsIItemIdVariable(_bb, default(IItemIdVariable));
		}

		// Token: 0x06018121 RID: 98593 RVA: 0x0036F24C File Offset: 0x0036D44C
		public static IItemIdVariable GetRootAsIItemIdVariable(ByteBuffer _bb, IItemIdVariable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018122 RID: 98594 RVA: 0x0036F269 File Offset: 0x0036D469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018123 RID: 98595 RVA: 0x0036F278 File Offset: 0x0036D478
		public IItemIdVariable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700755B RID: 30043
		// (get) Token: 0x06018124 RID: 98596 RVA: 0x0036F288 File Offset: 0x0036D488
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

		// Token: 0x1700755C RID: 30044
		// (get) Token: 0x06018125 RID: 98597 RVA: 0x0036F2C4 File Offset: 0x0036D4C4
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

		// Token: 0x06018126 RID: 98598 RVA: 0x0036F300 File Offset: 0x0036D500
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06018127 RID: 98599 RVA: 0x0036F344 File Offset: 0x0036D544
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06018128 RID: 98600 RVA: 0x0036F360 File Offset: 0x0036D560
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06018129 RID: 98601 RVA: 0x0036F37C File Offset: 0x0036D57C
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601812A RID: 98602 RVA: 0x0036F398 File Offset: 0x0036D598
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601812B RID: 98603 RVA: 0x0036F3B4 File Offset: 0x0036D5B4
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x1700755D RID: 30045
		// (get) Token: 0x0601812C RID: 98604 RVA: 0x0036F3D0 File Offset: 0x0036D5D0
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

		// Token: 0x0601812D RID: 98605 RVA: 0x0036F40D File Offset: 0x0036D60D
		public static Offset<IItemIdVariable> CreateIItemIdVariable(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int ItemId = 0)
		{
			builder.StartTable(4);
			IItemIdVariable.AddItemId(builder, ItemId);
			IItemIdVariable.AddVar(builder, VarOffset);
			IItemIdVariable.AddVarType(builder, Var_type);
			IItemIdVariable.AddType(builder, Type);
			return IItemIdVariable.EndIItemIdVariable(builder);
		}

		// Token: 0x0601812E RID: 98606 RVA: 0x0036F439 File Offset: 0x0036D639
		public static void StartIItemIdVariable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601812F RID: 98607 RVA: 0x0036F442 File Offset: 0x0036D642
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018130 RID: 98608 RVA: 0x0036F44D File Offset: 0x0036D64D
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06018131 RID: 98609 RVA: 0x0036F458 File Offset: 0x0036D658
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06018132 RID: 98610 RVA: 0x0036F463 File Offset: 0x0036D663
		public static void AddItemId(FlatBufferBuilder builder, int itemId)
		{
			builder.AddInt(3, itemId, 0);
		}

		// Token: 0x06018133 RID: 98611 RVA: 0x0036F46E File Offset: 0x0036D66E
		public static Offset<IItemIdVariable> EndIItemIdVariable(FlatBufferBuilder builder)
		{
			return new Offset<IItemIdVariable>(builder.EndTable());
		}

		// Token: 0x06018134 RID: 98612 RVA: 0x0036F47C File Offset: 0x0036D67C
		public IItemIdVariableT UnPack()
		{
			IItemIdVariableT itemIdVariableT = new IItemIdVariableT();
			this.UnPackTo(itemIdVariableT);
			return itemIdVariableT;
		}

		// Token: 0x06018135 RID: 98613 RVA: 0x0036F498 File Offset: 0x0036D698
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

		// Token: 0x06018136 RID: 98614 RVA: 0x0036F620 File Offset: 0x0036D820
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

		// Token: 0x0400C263 RID: 49763
		private Table __p;
	}
}
