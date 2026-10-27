using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EBD RID: 16061
	public struct IItemTypeVariable : IFlatbufferObject
	{
		// Token: 0x17006F7B RID: 28539
		// (get) Token: 0x06016B14 RID: 92948 RVA: 0x00346B6C File Offset: 0x00344D6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B15 RID: 92949 RVA: 0x00346B79 File Offset: 0x00344D79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B16 RID: 92950 RVA: 0x00346B80 File Offset: 0x00344D80
		public static IItemTypeVariable GetRootAsIItemTypeVariable(ByteBuffer _bb)
		{
			return IItemTypeVariable.GetRootAsIItemTypeVariable(_bb, default(IItemTypeVariable));
		}

		// Token: 0x06016B17 RID: 92951 RVA: 0x00346B9C File Offset: 0x00344D9C
		public static IItemTypeVariable GetRootAsIItemTypeVariable(ByteBuffer _bb, IItemTypeVariable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B18 RID: 92952 RVA: 0x00346BB9 File Offset: 0x00344DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B19 RID: 92953 RVA: 0x00346BC8 File Offset: 0x00344DC8
		public IItemTypeVariable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F7C RID: 28540
		// (get) Token: 0x06016B1A RID: 92954 RVA: 0x00346BD8 File Offset: 0x00344DD8
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

		// Token: 0x17006F7D RID: 28541
		// (get) Token: 0x06016B1B RID: 92955 RVA: 0x00346C14 File Offset: 0x00344E14
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

		// Token: 0x06016B1C RID: 92956 RVA: 0x00346C50 File Offset: 0x00344E50
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016B1D RID: 92957 RVA: 0x00346C94 File Offset: 0x00344E94
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06016B1E RID: 92958 RVA: 0x00346CB0 File Offset: 0x00344EB0
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06016B1F RID: 92959 RVA: 0x00346CCC File Offset: 0x00344ECC
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06016B20 RID: 92960 RVA: 0x00346CE8 File Offset: 0x00344EE8
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06016B21 RID: 92961 RVA: 0x00346D04 File Offset: 0x00344F04
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x17006F7E RID: 28542
		// (get) Token: 0x06016B22 RID: 92962 RVA: 0x00346D20 File Offset: 0x00344F20
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

		// Token: 0x06016B23 RID: 92963 RVA: 0x00346D5D File Offset: 0x00344F5D
		public static Offset<IItemTypeVariable> CreateIItemTypeVariable(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, int ItemType = 0)
		{
			builder.StartTable(4);
			IItemTypeVariable.AddItemType(builder, ItemType);
			IItemTypeVariable.AddVar(builder, VarOffset);
			IItemTypeVariable.AddVarType(builder, Var_type);
			IItemTypeVariable.AddType(builder, Type);
			return IItemTypeVariable.EndIItemTypeVariable(builder);
		}

		// Token: 0x06016B24 RID: 92964 RVA: 0x00346D89 File Offset: 0x00344F89
		public static void StartIItemTypeVariable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016B25 RID: 92965 RVA: 0x00346D92 File Offset: 0x00344F92
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B26 RID: 92966 RVA: 0x00346D9D File Offset: 0x00344F9D
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06016B27 RID: 92967 RVA: 0x00346DA8 File Offset: 0x00344FA8
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06016B28 RID: 92968 RVA: 0x00346DB3 File Offset: 0x00344FB3
		public static void AddItemType(FlatBufferBuilder builder, int itemType)
		{
			builder.AddInt(3, itemType, 0);
		}

		// Token: 0x06016B29 RID: 92969 RVA: 0x00346DBE File Offset: 0x00344FBE
		public static Offset<IItemTypeVariable> EndIItemTypeVariable(FlatBufferBuilder builder)
		{
			return new Offset<IItemTypeVariable>(builder.EndTable());
		}

		// Token: 0x06016B2A RID: 92970 RVA: 0x00346DCC File Offset: 0x00344FCC
		public IItemTypeVariableT UnPack()
		{
			IItemTypeVariableT itemTypeVariableT = new IItemTypeVariableT();
			this.UnPackTo(itemTypeVariableT);
			return itemTypeVariableT;
		}

		// Token: 0x06016B2B RID: 92971 RVA: 0x00346DE8 File Offset: 0x00344FE8
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

		// Token: 0x06016B2C RID: 92972 RVA: 0x00346F70 File Offset: 0x00345170
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

		// Token: 0x0400B88F RID: 47247
		private Table __p;
	}
}
