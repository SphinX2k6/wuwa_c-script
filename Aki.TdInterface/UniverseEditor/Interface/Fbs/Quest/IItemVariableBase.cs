using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC0 RID: 16064
	public struct IItemVariableBase : IFlatbufferObject
	{
		// Token: 0x17006F82 RID: 28546
		// (get) Token: 0x06016B35 RID: 92981 RVA: 0x00347094 File Offset: 0x00345294
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016B36 RID: 92982 RVA: 0x003470A1 File Offset: 0x003452A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016B37 RID: 92983 RVA: 0x003470A8 File Offset: 0x003452A8
		public static IItemVariableBase GetRootAsIItemVariableBase(ByteBuffer _bb)
		{
			return IItemVariableBase.GetRootAsIItemVariableBase(_bb, default(IItemVariableBase));
		}

		// Token: 0x06016B38 RID: 92984 RVA: 0x003470C4 File Offset: 0x003452C4
		public static IItemVariableBase GetRootAsIItemVariableBase(ByteBuffer _bb, IItemVariableBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016B39 RID: 92985 RVA: 0x003470E1 File Offset: 0x003452E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016B3A RID: 92986 RVA: 0x003470F0 File Offset: 0x003452F0
		public IItemVariableBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F83 RID: 28547
		// (get) Token: 0x06016B3B RID: 92987 RVA: 0x00347100 File Offset: 0x00345300
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

		// Token: 0x17006F84 RID: 28548
		// (get) Token: 0x06016B3C RID: 92988 RVA: 0x0034713C File Offset: 0x0034533C
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

		// Token: 0x06016B3D RID: 92989 RVA: 0x00347178 File Offset: 0x00345378
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016B3E RID: 92990 RVA: 0x003471BC File Offset: 0x003453BC
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06016B3F RID: 92991 RVA: 0x003471D8 File Offset: 0x003453D8
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06016B40 RID: 92992 RVA: 0x003471F4 File Offset: 0x003453F4
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06016B41 RID: 92993 RVA: 0x00347210 File Offset: 0x00345410
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06016B42 RID: 92994 RVA: 0x0034722C File Offset: 0x0034542C
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x06016B43 RID: 92995 RVA: 0x00347247 File Offset: 0x00345447
		public static Offset<IItemVariableBase> CreateIItemVariableBase(FlatBufferBuilder builder, EHandInItemType Type = EHandInItemType.ItemIds, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IItemVariableBase.AddVar(builder, VarOffset);
			IItemVariableBase.AddVarType(builder, Var_type);
			IItemVariableBase.AddType(builder, Type);
			return IItemVariableBase.EndIItemVariableBase(builder);
		}

		// Token: 0x06016B44 RID: 92996 RVA: 0x0034726B File Offset: 0x0034546B
		public static void StartIItemVariableBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016B45 RID: 92997 RVA: 0x00347274 File Offset: 0x00345474
		public static void AddType(FlatBufferBuilder builder, EHandInItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B46 RID: 92998 RVA: 0x0034727F File Offset: 0x0034547F
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06016B47 RID: 92999 RVA: 0x0034728A File Offset: 0x0034548A
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06016B48 RID: 93000 RVA: 0x00347295 File Offset: 0x00345495
		public static Offset<IItemVariableBase> EndIItemVariableBase(FlatBufferBuilder builder)
		{
			return new Offset<IItemVariableBase>(builder.EndTable());
		}

		// Token: 0x06016B49 RID: 93001 RVA: 0x003472A4 File Offset: 0x003454A4
		public IItemVariableBaseT UnPack()
		{
			IItemVariableBaseT itemVariableBaseT = new IItemVariableBaseT();
			this.UnPackTo(itemVariableBaseT);
			return itemVariableBaseT;
		}

		// Token: 0x06016B4A RID: 93002 RVA: 0x003472C0 File Offset: 0x003454C0
		public void UnPackTo(IItemVariableBaseT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06016B4B RID: 93003 RVA: 0x0034742C File Offset: 0x0034562C
		public static Offset<IItemVariableBase> Pack(FlatBufferBuilder builder, IItemVariableBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemVariableBase>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IItemVariableBase.CreateIItemVariableBase(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400B893 RID: 47251
		private Table __p;
	}
}
