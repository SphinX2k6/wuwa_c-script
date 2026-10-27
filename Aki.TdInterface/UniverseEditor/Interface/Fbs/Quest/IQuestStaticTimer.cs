using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004049 RID: 16457
	public struct IQuestStaticTimer : IFlatbufferObject
	{
		// Token: 0x170073D2 RID: 29650
		// (get) Token: 0x06017D4C RID: 97612 RVA: 0x003700A8 File Offset: 0x0036E2A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D4D RID: 97613 RVA: 0x003700B5 File Offset: 0x0036E2B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D4E RID: 97614 RVA: 0x003700BC File Offset: 0x0036E2BC
		public static IQuestStaticTimer GetRootAsIQuestStaticTimer(ByteBuffer _bb)
		{
			return IQuestStaticTimer.GetRootAsIQuestStaticTimer(_bb, default(IQuestStaticTimer));
		}

		// Token: 0x06017D4F RID: 97615 RVA: 0x003700D8 File Offset: 0x0036E2D8
		public static IQuestStaticTimer GetRootAsIQuestStaticTimer(ByteBuffer _bb, IQuestStaticTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D50 RID: 97616 RVA: 0x003700F5 File Offset: 0x0036E2F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D51 RID: 97617 RVA: 0x00370104 File Offset: 0x0036E304
		public IQuestStaticTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073D3 RID: 29651
		// (get) Token: 0x06017D52 RID: 97618 RVA: 0x00370114 File Offset: 0x0036E314
		public EStatisticsEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStatisticsEventType.Collect;
				}
				return (EStatisticsEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073D4 RID: 29652
		// (get) Token: 0x06017D53 RID: 97619 RVA: 0x00370150 File Offset: 0x0036E350
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

		// Token: 0x06017D54 RID: 97620 RVA: 0x0037018C File Offset: 0x0036E38C
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017D55 RID: 97621 RVA: 0x003701D0 File Offset: 0x0036E3D0
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x06017D56 RID: 97622 RVA: 0x003701EC File Offset: 0x0036E3EC
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x06017D57 RID: 97623 RVA: 0x00370208 File Offset: 0x0036E408
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x06017D58 RID: 97624 RVA: 0x00370224 File Offset: 0x0036E424
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x06017D59 RID: 97625 RVA: 0x00370240 File Offset: 0x0036E440
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170073D5 RID: 29653
		// (get) Token: 0x06017D5A RID: 97626 RVA: 0x0037025C File Offset: 0x0036E45C
		public ETimerType TimerType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETimerType.CountDownChallenge;
				}
				return (ETimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017D5B RID: 97627 RVA: 0x00370299 File Offset: 0x0036E499
		public static Offset<IQuestStaticTimer> CreateIQuestStaticTimer(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, ETimerType TimerType = ETimerType.CountDownChallenge)
		{
			builder.StartTable(4);
			IQuestStaticTimer.AddVar(builder, VarOffset);
			IQuestStaticTimer.AddTimerType(builder, TimerType);
			IQuestStaticTimer.AddVarType(builder, Var_type);
			IQuestStaticTimer.AddType(builder, Type);
			return IQuestStaticTimer.EndIQuestStaticTimer(builder);
		}

		// Token: 0x06017D5C RID: 97628 RVA: 0x003702C5 File Offset: 0x0036E4C5
		public static void StartIQuestStaticTimer(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017D5D RID: 97629 RVA: 0x003702CE File Offset: 0x0036E4CE
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D5E RID: 97630 RVA: 0x003702D9 File Offset: 0x0036E4D9
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x06017D5F RID: 97631 RVA: 0x003702E4 File Offset: 0x0036E4E4
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x06017D60 RID: 97632 RVA: 0x003702EF File Offset: 0x0036E4EF
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(3, (byte)timerType, 0);
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x003702FA File Offset: 0x0036E4FA
		public static Offset<IQuestStaticTimer> EndIQuestStaticTimer(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStaticTimer>(builder.EndTable());
		}

		// Token: 0x06017D62 RID: 97634 RVA: 0x00370308 File Offset: 0x0036E508
		public IQuestStaticTimerT UnPack()
		{
			IQuestStaticTimerT questStaticTimerT = new IQuestStaticTimerT();
			this.UnPackTo(questStaticTimerT);
			return questStaticTimerT;
		}

		// Token: 0x06017D63 RID: 97635 RVA: 0x00370324 File Offset: 0x0036E524
		public void UnPackTo(IQuestStaticTimerT _o)
		{
			_o.Type = this.Type;
			_o.Var = new TVarRefUnion();
			_o.Var.Type = this.VarType;
			switch (this.VarType)
			{
			case TVarRef.IConstVarRef:
				_o.Var.Value = ((this.Var<IConstVarRef>() != null) ? this.Var<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.Var.Value = ((this.Var<IGlobalVarRef>() != null) ? this.Var<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.Var.Value = ((this.Var<IOtherVarRef>() != null) ? this.Var<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.Var.Value = ((this.Var<ISelfVarRef>() != null) ? this.Var<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.Var.Value = ((this.Var<ISystemVarRef>() != null) ? this.Var<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.TimerType = this.TimerType;
		}

		// Token: 0x06017D64 RID: 97636 RVA: 0x003704AC File Offset: 0x0036E6AC
		public static Offset<IQuestStaticTimer> Pack(FlatBufferBuilder builder, IQuestStaticTimerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestStaticTimer>);
			}
			TVarRef var_type = (_o.Var == null) ? TVarRef.NONE : _o.Var.Type;
			int varOffset = (_o.Var == null) ? 0 : TVarRefUnion.Pack(builder, _o.Var);
			return IQuestStaticTimer.CreateIQuestStaticTimer(builder, _o.Type, var_type, varOffset, _o.TimerType);
		}

		// Token: 0x0400BB8E RID: 48014
		private Table __p;
	}
}
