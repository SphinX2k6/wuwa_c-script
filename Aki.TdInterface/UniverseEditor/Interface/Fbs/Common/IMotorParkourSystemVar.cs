using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0C RID: 24076
	public struct IMotorParkourSystemVar : IFlatbufferObject
	{
		// Token: 0x1700B428 RID: 46120
		// (get) Token: 0x06029374 RID: 168820 RVA: 0x005A764D File Offset: 0x005A584D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029375 RID: 168821 RVA: 0x005A765A File Offset: 0x005A585A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029376 RID: 168822 RVA: 0x005A7664 File Offset: 0x005A5864
		public static IMotorParkourSystemVar GetRootAsIMotorParkourSystemVar(ByteBuffer _bb)
		{
			return IMotorParkourSystemVar.GetRootAsIMotorParkourSystemVar(_bb, default(IMotorParkourSystemVar));
		}

		// Token: 0x06029377 RID: 168823 RVA: 0x005A7680 File Offset: 0x005A5880
		public static IMotorParkourSystemVar GetRootAsIMotorParkourSystemVar(ByteBuffer _bb, IMotorParkourSystemVar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029378 RID: 168824 RVA: 0x005A769D File Offset: 0x005A589D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029379 RID: 168825 RVA: 0x005A76AC File Offset: 0x005A58AC
		public IMotorParkourSystemVar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B429 RID: 46121
		// (get) Token: 0x0602937A RID: 168826 RVA: 0x005A76BC File Offset: 0x005A58BC
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

		// Token: 0x1700B42A RID: 46122
		// (get) Token: 0x0602937B RID: 168827 RVA: 0x005A76F8 File Offset: 0x005A58F8
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

		// Token: 0x0602937C RID: 168828 RVA: 0x005A7734 File Offset: 0x005A5934
		public TTable? VarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602937D RID: 168829 RVA: 0x005A7778 File Offset: 0x005A5978
		public IConstVarRef VarRefAsIConstVarRef()
		{
			return this.VarRef<IConstVarRef>().Value;
		}

		// Token: 0x0602937E RID: 168830 RVA: 0x005A7794 File Offset: 0x005A5994
		public IGlobalVarRef VarRefAsIGlobalVarRef()
		{
			return this.VarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0602937F RID: 168831 RVA: 0x005A77B0 File Offset: 0x005A59B0
		public IOtherVarRef VarRefAsIOtherVarRef()
		{
			return this.VarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06029380 RID: 168832 RVA: 0x005A77CC File Offset: 0x005A59CC
		public ISelfVarRef VarRefAsISelfVarRef()
		{
			return this.VarRef<ISelfVarRef>().Value;
		}

		// Token: 0x06029381 RID: 168833 RVA: 0x005A77E8 File Offset: 0x005A59E8
		public ISystemVarRef VarRefAsISystemVarRef()
		{
			return this.VarRef<ISystemVarRef>().Value;
		}

		// Token: 0x06029382 RID: 168834 RVA: 0x005A7803 File Offset: 0x005A5A03
		public static Offset<IMotorParkourSystemVar> CreateIMotorParkourSystemVar(FlatBufferBuilder builder, EMotorParkourSystemVarType VarType = EMotorParkourSystemVarType.CurLap, TVarRef VarRef_type = TVarRef.NONE, int VarRefOffset = 0)
		{
			builder.StartTable(3);
			IMotorParkourSystemVar.AddVarRef(builder, VarRefOffset);
			IMotorParkourSystemVar.AddVarRefType(builder, VarRef_type);
			IMotorParkourSystemVar.AddVarType(builder, VarType);
			return IMotorParkourSystemVar.EndIMotorParkourSystemVar(builder);
		}

		// Token: 0x06029383 RID: 168835 RVA: 0x005A7827 File Offset: 0x005A5A27
		public static void StartIMotorParkourSystemVar(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06029384 RID: 168836 RVA: 0x005A7830 File Offset: 0x005A5A30
		public static void AddVarType(FlatBufferBuilder builder, EMotorParkourSystemVarType varType)
		{
			builder.AddByte(0, (byte)varType, 0);
		}

		// Token: 0x06029385 RID: 168837 RVA: 0x005A783B File Offset: 0x005A5A3B
		public static void AddVarRefType(FlatBufferBuilder builder, TVarRef varRefType)
		{
			builder.AddByte(1, (byte)varRefType, 0);
		}

		// Token: 0x06029386 RID: 168838 RVA: 0x005A7846 File Offset: 0x005A5A46
		public static void AddVarRef(FlatBufferBuilder builder, int varRefOffset)
		{
			builder.AddOffset(2, varRefOffset, 0);
		}

		// Token: 0x06029387 RID: 168839 RVA: 0x005A7851 File Offset: 0x005A5A51
		public static Offset<IMotorParkourSystemVar> EndIMotorParkourSystemVar(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParkourSystemVar>(builder.EndTable());
		}

		// Token: 0x06029388 RID: 168840 RVA: 0x005A7860 File Offset: 0x005A5A60
		public IMotorParkourSystemVarT UnPack()
		{
			IMotorParkourSystemVarT motorParkourSystemVarT = new IMotorParkourSystemVarT();
			this.UnPackTo(motorParkourSystemVarT);
			return motorParkourSystemVarT;
		}

		// Token: 0x06029389 RID: 168841 RVA: 0x005A787C File Offset: 0x005A5A7C
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

		// Token: 0x0602938A RID: 168842 RVA: 0x005A79E8 File Offset: 0x005A5BE8
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

		// Token: 0x0400F802 RID: 63490
		private Table __p;
	}
}
