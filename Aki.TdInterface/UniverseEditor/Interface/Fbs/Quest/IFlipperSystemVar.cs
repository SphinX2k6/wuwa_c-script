using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E69 RID: 15977
	public struct IFlipperSystemVar : IFlatbufferObject
	{
		// Token: 0x17006EC2 RID: 28354
		// (get) Token: 0x060167E6 RID: 92134 RVA: 0x00340550 File Offset: 0x0033E750
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167E7 RID: 92135 RVA: 0x0034055D File Offset: 0x0033E75D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167E8 RID: 92136 RVA: 0x00340564 File Offset: 0x0033E764
		public static IFlipperSystemVar GetRootAsIFlipperSystemVar(ByteBuffer _bb)
		{
			return IFlipperSystemVar.GetRootAsIFlipperSystemVar(_bb, default(IFlipperSystemVar));
		}

		// Token: 0x060167E9 RID: 92137 RVA: 0x00340580 File Offset: 0x0033E780
		public static IFlipperSystemVar GetRootAsIFlipperSystemVar(ByteBuffer _bb, IFlipperSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167EA RID: 92138 RVA: 0x0034059D File Offset: 0x0033E79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060167EB RID: 92139 RVA: 0x003405AC File Offset: 0x0033E7AC
		public IFlipperSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EC3 RID: 28355
		// (get) Token: 0x060167EC RID: 92140 RVA: 0x003405BC File Offset: 0x0033E7BC
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

		// Token: 0x17006EC4 RID: 28356
		// (get) Token: 0x060167ED RID: 92141 RVA: 0x003405F8 File Offset: 0x0033E7F8
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

		// Token: 0x060167EE RID: 92142 RVA: 0x00340634 File Offset: 0x0033E834
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060167EF RID: 92143 RVA: 0x00340678 File Offset: 0x0033E878
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060167F0 RID: 92144 RVA: 0x00340694 File Offset: 0x0033E894
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060167F1 RID: 92145 RVA: 0x003406B0 File Offset: 0x0033E8B0
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060167F2 RID: 92146 RVA: 0x003406CC File Offset: 0x0033E8CC
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060167F3 RID: 92147 RVA: 0x003406E8 File Offset: 0x0033E8E8
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060167F4 RID: 92148 RVA: 0x00340703 File Offset: 0x0033E903
		public static Offset<IFlipperSystemVar> CreateIFlipperSystemVar(FlatBufferBuilder builder, EFlipperSystemVar VarType = EFlipperSystemVar.LifeRemain, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IFlipperSystemVar.AddVarRef(builder, VarRefOffset);
			IFlipperSystemVar.AddVarRefType(builder, VarRef_type);
			IFlipperSystemVar.AddVarType(builder, VarType);
			return IFlipperSystemVar.EndIFlipperSystemVar(builder);
		}

		// Token: 0x060167F5 RID: 92149 RVA: 0x00340727 File Offset: 0x0033E927
		public static void StartIFlipperSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060167F6 RID: 92150 RVA: 0x00340730 File Offset: 0x0033E930
		public static void AddVarType(FlatBufferBuilder builder, EFlipperSystemVar varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060167F7 RID: 92151 RVA: 0x0034073B File Offset: 0x0033E93B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060167F8 RID: 92152 RVA: 0x00340746 File Offset: 0x0033E946
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060167F9 RID: 92153 RVA: 0x00340751 File Offset: 0x0033E951
		public static Offset<IFlipperSystemVar> EndIFlipperSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperSystemVar>(builder.EndTable());
		}

		// Token: 0x060167FA RID: 92154 RVA: 0x00340760 File Offset: 0x0033E960
		public IFlipperSystemVarT UnPack()
		{
			IFlipperSystemVarT flipperSystemVarT = new IFlipperSystemVarT();
			this.UnPackTo(flipperSystemVarT);
			return flipperSystemVarT;
		}

		// Token: 0x060167FB RID: 92155 RVA: 0x0034077C File Offset: 0x0033E97C
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

		// Token: 0x060167FC RID: 92156 RVA: 0x003408E8 File Offset: 0x0033EAE8
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

		// Token: 0x0400B81A RID: 47130
		private Table __p;
	}
}
