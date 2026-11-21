using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448A RID: 17546
	public struct IQuestStaticTimer : IFlatbufferObject
	{
		// Token: 0x170079D4 RID: 31188
		// (get) Token: 0x060193E5 RID: 103397 RVA: 0x00399E9C File Offset: 0x0039809C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060193E6 RID: 103398 RVA: 0x00399EA9 File Offset: 0x003980A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060193E7 RID: 103399 RVA: 0x00399EB0 File Offset: 0x003980B0
		public static IQuestStaticTimer GetRootAsIQuestStaticTimer(ByteBuffer _bb)
		{
			return IQuestStaticTimer.GetRootAsIQuestStaticTimer(_bb, default(IQuestStaticTimer));
		}

		// Token: 0x060193E8 RID: 103400 RVA: 0x00399ECC File Offset: 0x003980CC
		public static IQuestStaticTimer GetRootAsIQuestStaticTimer(ByteBuffer _bb, IQuestStaticTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193E9 RID: 103401 RVA: 0x00399EE9 File Offset: 0x003980E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193EA RID: 103402 RVA: 0x00399EF8 File Offset: 0x003980F8
		public IQuestStaticTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079D5 RID: 31189
		// (get) Token: 0x060193EB RID: 103403 RVA: 0x00399F08 File Offset: 0x00398108
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

		// Token: 0x170079D6 RID: 31190
		// (get) Token: 0x060193EC RID: 103404 RVA: 0x00399F44 File Offset: 0x00398144
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

		// Token: 0x060193ED RID: 103405 RVA: 0x00399F80 File Offset: 0x00398180
		public TTable? Var<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060193EE RID: 103406 RVA: 0x00399FC4 File Offset: 0x003981C4
		public IConstVarRef VarAsIConstVarRef()
		{
			return this.Var<IConstVarRef>().Value;
		}

		// Token: 0x060193EF RID: 103407 RVA: 0x00399FE0 File Offset: 0x003981E0
		public IGlobalVarRef VarAsIGlobalVarRef()
		{
			return this.Var<IGlobalVarRef>().Value;
		}

		// Token: 0x060193F0 RID: 103408 RVA: 0x00399FFC File Offset: 0x003981FC
		public IOtherVarRef VarAsIOtherVarRef()
		{
			return this.Var<IOtherVarRef>().Value;
		}

		// Token: 0x060193F1 RID: 103409 RVA: 0x0039A018 File Offset: 0x00398218
		public ISelfVarRef VarAsISelfVarRef()
		{
			return this.Var<ISelfVarRef>().Value;
		}

		// Token: 0x060193F2 RID: 103410 RVA: 0x0039A034 File Offset: 0x00398234
		public ISystemVarRef VarAsISystemVarRef()
		{
			return this.Var<ISystemVarRef>().Value;
		}

		// Token: 0x170079D7 RID: 31191
		// (get) Token: 0x060193F3 RID: 103411 RVA: 0x0039A050 File Offset: 0x00398250
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

		// Token: 0x060193F4 RID: 103412 RVA: 0x0039A08D File Offset: 0x0039828D
		public static Offset<IQuestStaticTimer> CreateIQuestStaticTimer(FlatBufferBuilder builder, EStatisticsEventType Type = EStatisticsEventType.Collect, TVarRef Var_type = TVarRef.NONE, int VarOffset = 0, ETimerType TimerType = ETimerType.CountDownChallenge)
		{
			builder.StartTable(4);
			IQuestStaticTimer.AddVar(builder, VarOffset);
			IQuestStaticTimer.AddTimerType(builder, TimerType);
			IQuestStaticTimer.AddVarType(builder, Var_type);
			IQuestStaticTimer.AddType(builder, Type);
			return IQuestStaticTimer.EndIQuestStaticTimer(builder);
		}

		// Token: 0x060193F5 RID: 103413 RVA: 0x0039A0B9 File Offset: 0x003982B9
		public static void StartIQuestStaticTimer(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060193F6 RID: 103414 RVA: 0x0039A0C2 File Offset: 0x003982C2
		public static void AddType(FlatBufferBuilder builder, EStatisticsEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060193F7 RID: 103415 RVA: 0x0039A0CD File Offset: 0x003982CD
		public static void AddVarType(FlatBufferBuilder builder, TVarRef varType)
		{
			builder.AddByte(1, (byte)varType, 0);
		}

		// Token: 0x060193F8 RID: 103416 RVA: 0x0039A0D8 File Offset: 0x003982D8
		public static void AddVar(FlatBufferBuilder builder, int varOffset)
		{
			builder.AddOffset(2, varOffset, 0);
		}

		// Token: 0x060193F9 RID: 103417 RVA: 0x0039A0E3 File Offset: 0x003982E3
		public static void AddTimerType(FlatBufferBuilder builder, ETimerType timerType)
		{
			builder.AddByte(3, (byte)timerType, 0);
		}

		// Token: 0x060193FA RID: 103418 RVA: 0x0039A0EE File Offset: 0x003982EE
		public static Offset<IQuestStaticTimer> EndIQuestStaticTimer(FlatBufferBuilder builder)
		{
			return new Offset<IQuestStaticTimer>(builder.EndTable());
		}

		// Token: 0x060193FB RID: 103419 RVA: 0x0039A0FC File Offset: 0x003982FC
		public IQuestStaticTimerT UnPack()
		{
			IQuestStaticTimerT questStaticTimerT = new IQuestStaticTimerT();
			this.UnPackTo(questStaticTimerT);
			return questStaticTimerT;
		}

		// Token: 0x060193FC RID: 103420 RVA: 0x0039A118 File Offset: 0x00398318
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

		// Token: 0x060193FD RID: 103421 RVA: 0x0039A2A0 File Offset: 0x003984A0
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

		// Token: 0x0400C575 RID: 50549
		private Table __p;
	}
}
