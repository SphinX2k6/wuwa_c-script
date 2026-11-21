using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004526 RID: 17702
	public struct IRoleTowerSystemVar : IFlatbufferObject
	{
		// Token: 0x17007B21 RID: 31521
		// (get) Token: 0x060199F1 RID: 104945 RVA: 0x003A6570 File Offset: 0x003A4770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060199F2 RID: 104946 RVA: 0x003A657D File Offset: 0x003A477D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060199F3 RID: 104947 RVA: 0x003A6584 File Offset: 0x003A4784
		public static IRoleTowerSystemVar GetRootAsIRoleTowerSystemVar(ByteBuffer _bb)
		{
			return IRoleTowerSystemVar.GetRootAsIRoleTowerSystemVar(_bb, default(IRoleTowerSystemVar));
		}

		// Token: 0x060199F4 RID: 104948 RVA: 0x003A65A0 File Offset: 0x003A47A0
		public static IRoleTowerSystemVar GetRootAsIRoleTowerSystemVar(ByteBuffer _bb, IRoleTowerSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060199F5 RID: 104949 RVA: 0x003A65BD File Offset: 0x003A47BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060199F6 RID: 104950 RVA: 0x003A65CC File Offset: 0x003A47CC
		public IRoleTowerSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B22 RID: 31522
		// (get) Token: 0x060199F7 RID: 104951 RVA: 0x003A65DC File Offset: 0x003A47DC
		public ERoleTowerSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERoleTowerSystemVarType.Batch;
				}
				return (ERoleTowerSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B23 RID: 31523
		// (get) Token: 0x060199F8 RID: 104952 RVA: 0x003A6618 File Offset: 0x003A4818
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

		// Token: 0x060199F9 RID: 104953 RVA: 0x003A6654 File Offset: 0x003A4854
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060199FA RID: 104954 RVA: 0x003A6698 File Offset: 0x003A4898
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060199FB RID: 104955 RVA: 0x003A66B4 File Offset: 0x003A48B4
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060199FC RID: 104956 RVA: 0x003A66D0 File Offset: 0x003A48D0
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060199FD RID: 104957 RVA: 0x003A66EC File Offset: 0x003A48EC
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060199FE RID: 104958 RVA: 0x003A6708 File Offset: 0x003A4908
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060199FF RID: 104959 RVA: 0x003A6723 File Offset: 0x003A4923
		public static Offset<IRoleTowerSystemVar> CreateIRoleTowerSystemVar(FlatBufferBuilder builder, ERoleTowerSystemVarType VarType = ERoleTowerSystemVarType.Batch, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IRoleTowerSystemVar.AddVarRef(builder, VarRefOffset);
			IRoleTowerSystemVar.AddVarRefType(builder, VarRef_type);
			IRoleTowerSystemVar.AddVarType(builder, VarType);
			return IRoleTowerSystemVar.EndIRoleTowerSystemVar(builder);
		}

		// Token: 0x06019A00 RID: 104960 RVA: 0x003A6747 File Offset: 0x003A4947
		public static void StartIRoleTowerSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019A01 RID: 104961 RVA: 0x003A6750 File Offset: 0x003A4950
		public static void AddVarType(FlatBufferBuilder builder, ERoleTowerSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06019A02 RID: 104962 RVA: 0x003A675B File Offset: 0x003A495B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06019A03 RID: 104963 RVA: 0x003A6766 File Offset: 0x003A4966
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06019A04 RID: 104964 RVA: 0x003A6771 File Offset: 0x003A4971
		public static Offset<IRoleTowerSystemVar> EndIRoleTowerSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IRoleTowerSystemVar>(builder.EndTable());
		}

		// Token: 0x06019A05 RID: 104965 RVA: 0x003A6780 File Offset: 0x003A4980
		public IRoleTowerSystemVarT UnPack()
		{
			IRoleTowerSystemVarT roleTowerSystemVarT = new IRoleTowerSystemVarT();
			this.UnPackTo(roleTowerSystemVarT);
			return roleTowerSystemVarT;
		}

		// Token: 0x06019A06 RID: 104966 RVA: 0x003A679C File Offset: 0x003A499C
		public void UnPackTo(IRoleTowerSystemVarT _o)
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

		// Token: 0x06019A07 RID: 104967 RVA: 0x003A6908 File Offset: 0x003A4B08
		public static Offset<IRoleTowerSystemVar> Pack(FlatBufferBuilder builder, IRoleTowerSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRoleTowerSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IRoleTowerSystemVar.CreateIRoleTowerSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C666 RID: 50790
		private Table __p;
	}
}
