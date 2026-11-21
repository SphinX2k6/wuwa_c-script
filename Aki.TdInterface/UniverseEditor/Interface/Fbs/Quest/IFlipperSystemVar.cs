using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A4 RID: 17060
	public struct IFlipperSystemVar : IFlatbufferObject
	{
		// Token: 0x170074A6 RID: 29862
		// (get) Token: 0x06017E0D RID: 97805 RVA: 0x00369080 File Offset: 0x00367280
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017E0E RID: 97806 RVA: 0x0036908D File Offset: 0x0036728D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017E0F RID: 97807 RVA: 0x00369094 File Offset: 0x00367294
		public static IFlipperSystemVar GetRootAsIFlipperSystemVar(ByteBuffer _bb)
		{
			return IFlipperSystemVar.GetRootAsIFlipperSystemVar(_bb, default(IFlipperSystemVar));
		}

		// Token: 0x06017E10 RID: 97808 RVA: 0x003690B0 File Offset: 0x003672B0
		public static IFlipperSystemVar GetRootAsIFlipperSystemVar(ByteBuffer _bb, IFlipperSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017E11 RID: 97809 RVA: 0x003690CD File Offset: 0x003672CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017E12 RID: 97810 RVA: 0x003690DC File Offset: 0x003672DC
		public IFlipperSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074A7 RID: 29863
		// (get) Token: 0x06017E13 RID: 97811 RVA: 0x003690EC File Offset: 0x003672EC
		public EFlipperSystemVar VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlipperSystemVar.LifeRemain;
				}
				return (EFlipperSystemVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170074A8 RID: 29864
		// (get) Token: 0x06017E14 RID: 97812 RVA: 0x00369128 File Offset: 0x00367328
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

		// Token: 0x06017E15 RID: 97813 RVA: 0x00369164 File Offset: 0x00367364
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017E16 RID: 97814 RVA: 0x003691A8 File Offset: 0x003673A8
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017E17 RID: 97815 RVA: 0x003691C4 File Offset: 0x003673C4
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017E18 RID: 97816 RVA: 0x003691E0 File Offset: 0x003673E0
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017E19 RID: 97817 RVA: 0x003691FC File Offset: 0x003673FC
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06017E1A RID: 97818 RVA: 0x00369218 File Offset: 0x00367418
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06017E1B RID: 97819 RVA: 0x00369233 File Offset: 0x00367433
		public static Offset<IFlipperSystemVar> CreateIFlipperSystemVar(FlatBufferBuilder builder, EFlipperSystemVar VarType = EFlipperSystemVar.LifeRemain, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IFlipperSystemVar.AddVarRef(builder, VarRefOffset);
			IFlipperSystemVar.AddVarRefType(builder, VarRef_type);
			IFlipperSystemVar.AddVarType(builder, VarType);
			return IFlipperSystemVar.EndIFlipperSystemVar(builder);
		}

		// Token: 0x06017E1C RID: 97820 RVA: 0x00369257 File Offset: 0x00367457
		public static void StartIFlipperSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017E1D RID: 97821 RVA: 0x00369260 File Offset: 0x00367460
		public static void AddVarType(FlatBufferBuilder builder, EFlipperSystemVar varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06017E1E RID: 97822 RVA: 0x0036926B File Offset: 0x0036746B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06017E1F RID: 97823 RVA: 0x00369276 File Offset: 0x00367476
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06017E20 RID: 97824 RVA: 0x00369281 File Offset: 0x00367481
		public static Offset<IFlipperSystemVar> EndIFlipperSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperSystemVar>(builder.EndTable());
		}

		// Token: 0x06017E21 RID: 97825 RVA: 0x00369290 File Offset: 0x00367490
		public IFlipperSystemVarT UnPack()
		{
			IFlipperSystemVarT flipperSystemVarT = new IFlipperSystemVarT();
			this.UnPackTo(flipperSystemVarT);
			return flipperSystemVarT;
		}

		// Token: 0x06017E22 RID: 97826 RVA: 0x003692AC File Offset: 0x003674AC
		public void UnPackTo(IFlipperSystemVarT _o)
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

		// Token: 0x06017E23 RID: 97827 RVA: 0x00369418 File Offset: 0x00367618
		public static Offset<IFlipperSystemVar> Pack(FlatBufferBuilder builder, IFlipperSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IFlipperSystemVar.CreateIFlipperSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C1F1 RID: 49649
		private Table __p;
	}
}
