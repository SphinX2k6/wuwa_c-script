using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E81 RID: 16001
	public struct IGradingSystemVar : IFlatbufferObject
	{
		// Token: 0x17006EFE RID: 28414
		// (get) Token: 0x060168D9 RID: 92377 RVA: 0x00342403 File Offset: 0x00340603
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168DA RID: 92378 RVA: 0x00342410 File Offset: 0x00340610
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168DB RID: 92379 RVA: 0x00342418 File Offset: 0x00340618
		public static IGradingSystemVar GetRootAsIGradingSystemVar(ByteBuffer _bb)
		{
			return IGradingSystemVar.GetRootAsIGradingSystemVar(_bb, default(IGradingSystemVar));
		}

		// Token: 0x060168DC RID: 92380 RVA: 0x00342434 File Offset: 0x00340634
		public static IGradingSystemVar GetRootAsIGradingSystemVar(ByteBuffer _bb, IGradingSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168DD RID: 92381 RVA: 0x00342451 File Offset: 0x00340651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168DE RID: 92382 RVA: 0x00342460 File Offset: 0x00340660
		public IGradingSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EFF RID: 28415
		// (get) Token: 0x060168DF RID: 92383 RVA: 0x00342470 File Offset: 0x00340670
		public EGradingSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGradingSystemVarType.Score;
				}
				return (EGradingSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F00 RID: 28416
		// (get) Token: 0x060168E0 RID: 92384 RVA: 0x003424AC File Offset: 0x003406AC
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

		// Token: 0x060168E1 RID: 92385 RVA: 0x003424E8 File Offset: 0x003406E8
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060168E2 RID: 92386 RVA: 0x0034252C File Offset: 0x0034072C
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x060168E3 RID: 92387 RVA: 0x00342548 File Offset: 0x00340748
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x060168E4 RID: 92388 RVA: 0x00342564 File Offset: 0x00340764
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x060168E5 RID: 92389 RVA: 0x00342580 File Offset: 0x00340780
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x060168E6 RID: 92390 RVA: 0x0034259C File Offset: 0x0034079C
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x060168E7 RID: 92391 RVA: 0x003425B7 File Offset: 0x003407B7
		public static Offset<IGradingSystemVar> CreateIGradingSystemVar(FlatBufferBuilder builder, EGradingSystemVarType VarType = EGradingSystemVarType.Score, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IGradingSystemVar.AddVarRef(builder, VarRefOffset);
			IGradingSystemVar.AddVarRefType(builder, VarRef_type);
			IGradingSystemVar.AddVarType(builder, VarType);
			return IGradingSystemVar.EndIGradingSystemVar(builder);
		}

		// Token: 0x060168E8 RID: 92392 RVA: 0x003425DB File Offset: 0x003407DB
		public static void StartIGradingSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060168E9 RID: 92393 RVA: 0x003425E4 File Offset: 0x003407E4
		public static void AddVarType(FlatBufferBuilder builder, EGradingSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x060168EA RID: 92394 RVA: 0x003425EF File Offset: 0x003407EF
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x060168EB RID: 92395 RVA: 0x003425FA File Offset: 0x003407FA
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x060168EC RID: 92396 RVA: 0x00342605 File Offset: 0x00340805
		public static Offset<IGradingSystemVar> EndIGradingSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IGradingSystemVar>(builder.EndTable());
		}

		// Token: 0x060168ED RID: 92397 RVA: 0x00342614 File Offset: 0x00340814
		public IGradingSystemVarT UnPack()
		{
			IGradingSystemVarT gradingSystemVarT = new IGradingSystemVarT();
			this.UnPackTo(gradingSystemVarT);
			return gradingSystemVarT;
		}

		// Token: 0x060168EE RID: 92398 RVA: 0x00342630 File Offset: 0x00340830
		public void UnPackTo(IGradingSystemVarT _o)
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

		// Token: 0x060168EF RID: 92399 RVA: 0x0034279C File Offset: 0x0034099C
		public static Offset<IGradingSystemVar> Pack(FlatBufferBuilder builder, IGradingSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGradingSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IGradingSystemVar.CreateIGradingSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0400B83C RID: 47164
		private Table __p;
	}
}
