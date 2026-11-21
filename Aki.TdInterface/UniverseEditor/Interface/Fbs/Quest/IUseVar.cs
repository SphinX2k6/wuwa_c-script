using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B8 RID: 18104
	public struct IUseVar : IFlatbufferObject
	{
		// Token: 0x17007ED1 RID: 32465
		// (get) Token: 0x0601A99C RID: 108956 RVA: 0x003C86DD File Offset: 0x003C68DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A99D RID: 108957 RVA: 0x003C86EA File Offset: 0x003C68EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A99E RID: 108958 RVA: 0x003C86F4 File Offset: 0x003C68F4
		public static IUseVar GetRootAsIUseVar(ByteBuffer _bb)
		{
			return IUseVar.GetRootAsIUseVar(_bb, default(IUseVar));
		}

		// Token: 0x0601A99F RID: 108959 RVA: 0x003C8710 File Offset: 0x003C6910
		public static IUseVar GetRootAsIUseVar(ByteBuffer _bb, IUseVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9A0 RID: 108960 RVA: 0x003C872D File Offset: 0x003C692D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9A1 RID: 108961 RVA: 0x003C873C File Offset: 0x003C693C
		public IUseVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ED2 RID: 32466
		// (get) Token: 0x0601A9A2 RID: 108962 RVA: 0x003C874C File Offset: 0x003C694C
		public EProgressBarLeftType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarLeftType.UseCount;
				}
				return (EProgressBarLeftType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007ED3 RID: 32467
		// (get) Token: 0x0601A9A3 RID: 108963 RVA: 0x003C8788 File Offset: 0x003C6988
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

		// Token: 0x0601A9A4 RID: 108964 RVA: 0x003C87C4 File Offset: 0x003C69C4
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A9A5 RID: 108965 RVA: 0x003C8808 File Offset: 0x003C6A08
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x0601A9A6 RID: 108966 RVA: 0x003C8824 File Offset: 0x003C6A24
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x0601A9A7 RID: 108967 RVA: 0x003C8840 File Offset: 0x003C6A40
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x0601A9A8 RID: 108968 RVA: 0x003C885C File Offset: 0x003C6A5C
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x0601A9A9 RID: 108969 RVA: 0x003C8878 File Offset: 0x003C6A78
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x0601A9AA RID: 108970 RVA: 0x003C8893 File Offset: 0x003C6A93
		public static Offset<IUseVar> CreateIUseVar(FlatBufferBuilder builder, EProgressBarLeftType Type = EProgressBarLeftType.UseCount, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0)
		{
			builder.StartTable(3);
			IUseVar.AddVar(builder, VarOffset);
			IUseVar.AddVarType(builder, Var_type);
			IUseVar.AddType(builder, Type);
			return IUseVar.EndIUseVar(builder);
		}

		// Token: 0x0601A9AB RID: 108971 RVA: 0x003C88B7 File Offset: 0x003C6AB7
		public static void StartIUseVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A9AC RID: 108972 RVA: 0x003C88C0 File Offset: 0x003C6AC0
		public static void AddType(FlatBufferBuilder builder, EProgressBarLeftType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A9AD RID: 108973 RVA: 0x003C88CB File Offset: 0x003C6ACB
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x0601A9AE RID: 108974 RVA: 0x003C88D6 File Offset: 0x003C6AD6
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x0601A9AF RID: 108975 RVA: 0x003C88E1 File Offset: 0x003C6AE1
		public static Offset<IUseVar> EndIUseVar(FlatBufferBuilder builder)
		{
			return new Offset<IUseVar>(builder.EndTable());
		}

		// Token: 0x0601A9B0 RID: 108976 RVA: 0x003C88F0 File Offset: 0x003C6AF0
		public IUseVarT UnPack()
		{
			IUseVarT useVarT = new IUseVarT();
			this.UnPackTo(useVarT);
			return useVarT;
		}

		// Token: 0x0601A9B1 RID: 108977 RVA: 0x003C890C File Offset: 0x003C6B0C
		public void UnPackTo(IUseVarT _o)
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

		// Token: 0x0601A9B2 RID: 108978 RVA: 0x003C8A78 File Offset: 0x003C6C78
		public static Offset<IUseVar> Pack(FlatBufferBuilder builder, IUseVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseVar>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IUseVar.CreateIUseVar(builder, _o.Type, var_type, varOffset);
		}

		// Token: 0x0400C8F8 RID: 51448
		private Table __p;
	}
}
