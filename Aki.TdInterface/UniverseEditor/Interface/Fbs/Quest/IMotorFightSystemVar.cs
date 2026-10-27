using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F47 RID: 16199
	public struct IMotorFightSystemVar : IFlatbufferObject
	{
		// Token: 0x170070A6 RID: 28838
		// (get) Token: 0x0601706D RID: 94317 RVA: 0x003520AC File Offset: 0x003502AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601706E RID: 94318 RVA: 0x003520B9 File Offset: 0x003502B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601706F RID: 94319 RVA: 0x003520C0 File Offset: 0x003502C0
		public static IMotorFightSystemVar GetRootAsIMotorFightSystemVar(ByteBuffer _bb)
		{
			return IMotorFightSystemVar.GetRootAsIMotorFightSystemVar(_bb, default(IMotorFightSystemVar));
		}

		// Token: 0x06017070 RID: 94320 RVA: 0x003520DC File Offset: 0x003502DC
		public static IMotorFightSystemVar GetRootAsIMotorFightSystemVar(ByteBuffer _bb, IMotorFightSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017071 RID: 94321 RVA: 0x003520F9 File Offset: 0x003502F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017072 RID: 94322 RVA: 0x00352108 File Offset: 0x00350308
		public IMotorFightSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070A7 RID: 28839
		// (get) Token: 0x06017073 RID: 94323 RVA: 0x00352118 File Offset: 0x00350318
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

		// Token: 0x170070A8 RID: 28840
		// (get) Token: 0x06017074 RID: 94324 RVA: 0x00352154 File Offset: 0x00350354
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

		// Token: 0x06017075 RID: 94325 RVA: 0x00352190 File Offset: 0x00350390
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017076 RID: 94326 RVA: 0x003521D4 File Offset: 0x003503D4
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x06017077 RID: 94327 RVA: 0x003521F0 File Offset: 0x003503F0
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06017078 RID: 94328 RVA: 0x0035220C File Offset: 0x0035040C
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06017079 RID: 94329 RVA: 0x00352228 File Offset: 0x00350428
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0601707A RID: 94330 RVA: 0x00352244 File Offset: 0x00350444
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0601707B RID: 94331 RVA: 0x0035225F File Offset: 0x0035045F
		public static Offset<IMotorFightSystemVar> CreateIMotorFightSystemVar(FlatBufferBuilder builder, EMotorFightSystemVar VarType = EMotorFightSystemVar.LevelProgress, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IMotorFightSystemVar.AddVarRef(builder, VarRefOffset);
			IMotorFightSystemVar.AddVarRefType(builder, VarRef_type);
			IMotorFightSystemVar.AddVarType(builder, VarType);
			return IMotorFightSystemVar.EndIMotorFightSystemVar(builder);
		}

		// Token: 0x0601707C RID: 94332 RVA: 0x00352283 File Offset: 0x00350483
		public static void StartIMotorFightSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601707D RID: 94333 RVA: 0x0035228C File Offset: 0x0035048C
		public static void AddVarType(FlatBufferBuilder builder, EMotorFightSystemVar varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0601707E RID: 94334 RVA: 0x00352297 File Offset: 0x00350497
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0601707F RID: 94335 RVA: 0x003522A2 File Offset: 0x003504A2
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06017080 RID: 94336 RVA: 0x003522AD File Offset: 0x003504AD
		public static Offset<IMotorFightSystemVar> EndIMotorFightSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IMotorFightSystemVar>(builder.EndTable());
		}

		// Token: 0x06017081 RID: 94337 RVA: 0x003522BC File Offset: 0x003504BC
		public IMotorFightSystemVarT UnPack()
		{
			IMotorFightSystemVarT motorFightSystemVarT = new IMotorFightSystemVarT();
			this.UnPackTo(motorFightSystemVarT);
			return motorFightSystemVarT;
		}

		// Token: 0x06017082 RID: 94338 RVA: 0x003522D8 File Offset: 0x003504D8
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

		// Token: 0x06017083 RID: 94339 RVA: 0x00352444 File Offset: 0x00350644
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

		// Token: 0x0400B957 RID: 47447
		private Table __p;
	}
}
