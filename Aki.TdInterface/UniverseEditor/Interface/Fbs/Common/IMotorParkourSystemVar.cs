using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006449 RID: 25673
	public struct IMotorParkourSystemVar : IFlatbufferObject
	{
		// Token: 0x1700BD8E RID: 48526
		// (get) Token: 0x0602B9FE RID: 178686 RVA: 0x005F037D File Offset: 0x005EE57D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9FF RID: 178687 RVA: 0x005F038A File Offset: 0x005EE58A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA00 RID: 178688 RVA: 0x005F0394 File Offset: 0x005EE594
		public static IMotorParkourSystemVar GetRootAsIMotorParkourSystemVar(ByteBuffer _bb)
		{
			return IMotorParkourSystemVar.GetRootAsIMotorParkourSystemVar(_bb, default(IMotorParkourSystemVar));
		}

		// Token: 0x0602BA01 RID: 178689 RVA: 0x005F03B0 File Offset: 0x005EE5B0
		public static IMotorParkourSystemVar GetRootAsIMotorParkourSystemVar(ByteBuffer _bb, IMotorParkourSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA02 RID: 178690 RVA: 0x005F03CD File Offset: 0x005EE5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA03 RID: 178691 RVA: 0x005F03DC File Offset: 0x005EE5DC
		public IMotorParkourSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD8F RID: 48527
		// (get) Token: 0x0602BA04 RID: 178692 RVA: 0x005F03EC File Offset: 0x005EE5EC
		public EMotorParkourSystemVarType VarType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorParkourSystemVarType.CurLap;
				}
				return (EMotorParkourSystemVarType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD90 RID: 48528
		// (get) Token: 0x0602BA05 RID: 178693 RVA: 0x005F0428 File Offset: 0x005EE628
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

		// Token: 0x0602BA06 RID: 178694 RVA: 0x005F0464 File Offset: 0x005EE664
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BA07 RID: 178695 RVA: 0x005F04A8 File Offset: 0x005EE6A8
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0602BA08 RID: 178696 RVA: 0x005F04C4 File Offset: 0x005EE6C4
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0602BA09 RID: 178697 RVA: 0x005F04E0 File Offset: 0x005EE6E0
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0602BA0A RID: 178698 RVA: 0x005F04FC File Offset: 0x005EE6FC
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0602BA0B RID: 178699 RVA: 0x005F0518 File Offset: 0x005EE718
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0602BA0C RID: 178700 RVA: 0x005F0533 File Offset: 0x005EE733
		public static Offset<IMotorParkourSystemVar> CreateIMotorParkourSystemVar(FlatBufferBuilder builder, EMotorParkourSystemVarType VarType = EMotorParkourSystemVarType.CurLap, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IMotorParkourSystemVar.AddVarRef(builder, VarRefOffset);
			IMotorParkourSystemVar.AddVarRefType(builder, VarRef_type);
			IMotorParkourSystemVar.AddVarType(builder, VarType);
			return IMotorParkourSystemVar.EndIMotorParkourSystemVar(builder);
		}

		// Token: 0x0602BA0D RID: 178701 RVA: 0x005F0557 File Offset: 0x005EE757
		public static void StartIMotorParkourSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BA0E RID: 178702 RVA: 0x005F0560 File Offset: 0x005EE760
		public static void AddVarType(FlatBufferBuilder builder, EMotorParkourSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x0602BA0F RID: 178703 RVA: 0x005F056B File Offset: 0x005EE76B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x0602BA10 RID: 178704 RVA: 0x005F0576 File Offset: 0x005EE776
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x0602BA11 RID: 178705 RVA: 0x005F0581 File Offset: 0x005EE781
		public static Offset<IMotorParkourSystemVar> EndIMotorParkourSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParkourSystemVar>(builder.EndTable());
		}

		// Token: 0x0602BA12 RID: 178706 RVA: 0x005F0590 File Offset: 0x005EE790
		public IMotorParkourSystemVarT UnPack()
		{
			IMotorParkourSystemVarT motorParkourSystemVarT = new IMotorParkourSystemVarT();
			this.UnPackTo(motorParkourSystemVarT);
			return motorParkourSystemVarT;
		}

		// Token: 0x0602BA13 RID: 178707 RVA: 0x005F05AC File Offset: 0x005EE7AC
		public void UnPackTo(IMotorParkourSystemVarT _o)
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

		// Token: 0x0602BA14 RID: 178708 RVA: 0x005F0718 File Offset: 0x005EE918
		public static Offset<IMotorParkourSystemVar> Pack(FlatBufferBuilder builder, IMotorParkourSystemVarT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorParkourSystemVar>);
			}
			TVarRef varRef_type = (_o.VarRef == null) ? TVarRef.NONE : _o.VarRef.Type;
			int varRefOffset = (_o.VarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.VarRef);
			return IMotorParkourSystemVar.CreateIMotorParkourSystemVar(builder, _o.VarType, varRef_type, varRefOffset);
		}

		// Token: 0x0401055D RID: 66909
		private Table __p;
	}
}
