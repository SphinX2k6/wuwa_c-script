using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004385 RID: 17285
	public struct IMotorFightSystemVar : IFlatbufferObject
	{
		// Token: 0x17007697 RID: 30359
		// (get) Token: 0x060186CF RID: 100047 RVA: 0x0037B520 File Offset: 0x00379720
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060186D0 RID: 100048 RVA: 0x0037B52D File Offset: 0x0037972D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060186D1 RID: 100049 RVA: 0x0037B534 File Offset: 0x00379734
		public static IMotorFightSystemVar GetRootAsIMotorFightSystemVar(ByteBuffer _bb)
		{
			return IMotorFightSystemVar.GetRootAsIMotorFightSystemVar(_bb, default(IMotorFightSystemVar));
		}

		// Token: 0x060186D2 RID: 100050 RVA: 0x0037B550 File Offset: 0x00379750
		public static IMotorFightSystemVar GetRootAsIMotorFightSystemVar(ByteBuffer _bb, IMotorFightSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186D3 RID: 100051 RVA: 0x0037B56D File Offset: 0x0037976D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186D4 RID: 100052 RVA: 0x0037B57C File Offset: 0x0037977C
		public IMotorFightSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007698 RID: 30360
		// (get) Token: 0x060186D5 RID: 100053 RVA: 0x0037B58C File Offset: 0x0037978C
		public EMotorFightSystemVar VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorFightSystemVar.LevelProgress;
				}
				return (EMotorFightSystemVar)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007699 RID: 30361
		// (get) Token: 0x060186D6 RID: 100054 RVA: 0x0037B5C8 File Offset: 0x003797C8
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

		// Token: 0x060186D7 RID: 100055 RVA: 0x0037B604 File Offset: 0x00379804
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060186D8 RID: 100056 RVA: 0x0037B648 File Offset: 0x00379848
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060186D9 RID: 100057 RVA: 0x0037B664 File Offset: 0x00379864
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060186DA RID: 100058 RVA: 0x0037B680 File Offset: 0x00379880
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060186DB RID: 100059 RVA: 0x0037B69C File Offset: 0x0037989C
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060186DC RID: 100060 RVA: 0x0037B6B8 File Offset: 0x003798B8
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060186DD RID: 100061 RVA: 0x0037B6D3 File Offset: 0x003798D3
		public static Offset<IMotorFightSystemVar> CreateIMotorFightSystemVar(FlatBufferBuilder builder, EMotorFightSystemVar VarType = EMotorFightSystemVar.LevelProgress, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IMotorFightSystemVar.AddVarRef(builder, VarRefOffset);
			IMotorFightSystemVar.AddVarRefType(builder, VarRef_type);
			IMotorFightSystemVar.AddVarType(builder, VarType);
			return IMotorFightSystemVar.EndIMotorFightSystemVar(builder);
		}

		// Token: 0x060186DE RID: 100062 RVA: 0x0037B6F7 File Offset: 0x003798F7
		public static void StartIMotorFightSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060186DF RID: 100063 RVA: 0x0037B700 File Offset: 0x00379900
		public static void AddVarType(FlatBufferBuilder builder, EMotorFightSystemVar varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060186E0 RID: 100064 RVA: 0x0037B70B File Offset: 0x0037990B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060186E1 RID: 100065 RVA: 0x0037B716 File Offset: 0x00379916
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060186E2 RID: 100066 RVA: 0x0037B721 File Offset: 0x00379921
		public static Offset<IMotorFightSystemVar> EndIMotorFightSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IMotorFightSystemVar>(builder.EndTable());
		}

		// Token: 0x060186E3 RID: 100067 RVA: 0x0037B730 File Offset: 0x00379930
		public IMotorFightSystemVarT UnPack()
		{
			IMotorFightSystemVarT motorFightSystemVarT = new IMotorFightSystemVarT();
			this.UnPackTo(motorFightSystemVarT);
			return motorFightSystemVarT;
		}

		// Token: 0x060186E4 RID: 100068 RVA: 0x0037B74C File Offset: 0x0037994C
		public void UnPackTo(IMotorFightSystemVarT _o)
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

		// Token: 0x060186E5 RID: 100069 RVA: 0x0037B8B8 File Offset: 0x00379AB8
		public static Offset<IMotorFightSystemVar> Pack(FlatBufferBuilder builder, IMotorFightSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorFightSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IMotorFightSystemVar.CreateIMotorFightSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400C335 RID: 49973
		private Table __p;
	}
}
