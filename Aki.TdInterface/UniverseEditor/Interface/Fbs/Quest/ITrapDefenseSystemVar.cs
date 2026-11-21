using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004697 RID: 18071
	public struct ITrapDefenseSystemVar : IFlatbufferObject
	{
		// Token: 0x17007E93 RID: 32403
		// (get) Token: 0x0601A88A RID: 108682 RVA: 0x003C67BB File Offset: 0x003C49BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A88B RID: 108683 RVA: 0x003C67C8 File Offset: 0x003C49C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A88C RID: 108684 RVA: 0x003C67D0 File Offset: 0x003C49D0
		public static ITrapDefenseSystemVar GetRootAsITrapDefenseSystemVar(ByteBuffer _bb)
		{
			return ITrapDefenseSystemVar.GetRootAsITrapDefenseSystemVar(_bb, default(ITrapDefenseSystemVar));
		}

		// Token: 0x0601A88D RID: 108685 RVA: 0x003C67EC File Offset: 0x003C49EC
		public static ITrapDefenseSystemVar GetRootAsITrapDefenseSystemVar(ByteBuffer _bb, ITrapDefenseSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A88E RID: 108686 RVA: 0x003C6809 File Offset: 0x003C4A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A88F RID: 108687 RVA: 0x003C6818 File Offset: 0x003C4A18
		public ITrapDefenseSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E94 RID: 32404
		// (get) Token: 0x0601A890 RID: 108688 RVA: 0x003C6828 File Offset: 0x003C4A28
		public ETrapDefenseSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSystemVarType.Health;
				}
				return (ETrapDefenseSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E95 RID: 32405
		// (get) Token: 0x0601A891 RID: 108689 RVA: 0x003C6864 File Offset: 0x003C4A64
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

		// Token: 0x0601A892 RID: 108690 RVA: 0x003C68A0 File Offset: 0x003C4AA0
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A893 RID: 108691 RVA: 0x003C68E4 File Offset: 0x003C4AE4
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0601A894 RID: 108692 RVA: 0x003C6900 File Offset: 0x003C4B00
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0601A895 RID: 108693 RVA: 0x003C691C File Offset: 0x003C4B1C
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0601A896 RID: 108694 RVA: 0x003C6938 File Offset: 0x003C4B38
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601A897 RID: 108695 RVA: 0x003C6954 File Offset: 0x003C4B54
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601A898 RID: 108696 RVA: 0x003C696F File Offset: 0x003C4B6F
		public static Offset<ITrapDefenseSystemVar> CreateITrapDefenseSystemVar(FlatBufferBuilder builder, ETrapDefenseSystemVarType VarType = ETrapDefenseSystemVarType.Health, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			ITrapDefenseSystemVar.AddVarRef(builder, VarRefOffset);
			ITrapDefenseSystemVar.AddVarRefType(builder, VarRef_type);
			ITrapDefenseSystemVar.AddVarType(builder, VarType);
			return ITrapDefenseSystemVar.EndITrapDefenseSystemVar(builder);
		}

		// Token: 0x0601A899 RID: 108697 RVA: 0x003C6993 File Offset: 0x003C4B93
		public static void StartITrapDefenseSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A89A RID: 108698 RVA: 0x003C699C File Offset: 0x003C4B9C
		public static void AddVarType(FlatBufferBuilder builder, ETrapDefenseSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601A89B RID: 108699 RVA: 0x003C69A7 File Offset: 0x003C4BA7
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0601A89C RID: 108700 RVA: 0x003C69B2 File Offset: 0x003C4BB2
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x0601A89D RID: 108701 RVA: 0x003C69BD File Offset: 0x003C4BBD
		public static Offset<ITrapDefenseSystemVar> EndITrapDefenseSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSystemVar>(builder.EndTable());
		}

		// Token: 0x0601A89E RID: 108702 RVA: 0x003C69CC File Offset: 0x003C4BCC
		public ITrapDefenseSystemVarT UnPack()
		{
			ITrapDefenseSystemVarT trapDefenseSystemVarT = new ITrapDefenseSystemVarT();
			this.UnPackTo(trapDefenseSystemVarT);
			return trapDefenseSystemVarT;
		}

		// Token: 0x0601A89F RID: 108703 RVA: 0x003C69E8 File Offset: 0x003C4BE8
		public void UnPackTo(ITrapDefenseSystemVarT _o)
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

		// Token: 0x0601A8A0 RID: 108704 RVA: 0x003C6B54 File Offset: 0x003C4D54
		public static Offset<ITrapDefenseSystemVar> Pack(FlatBufferBuilder builder, ITrapDefenseSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return ITrapDefenseSystemVar.CreateITrapDefenseSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C8CB RID: 51403
		private Table __p;
	}
}
