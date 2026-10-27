using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B47 RID: 23367
	public struct IWalkingPatternComponent : IFlatbufferObject
	{
		// Token: 0x1700B063 RID: 45155
		// (get) Token: 0x06027F22 RID: 163618 RVA: 0x0057DF0A File Offset: 0x0057C10A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027F23 RID: 163619 RVA: 0x0057DF17 File Offset: 0x0057C117
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027F24 RID: 163620 RVA: 0x0057DF20 File Offset: 0x0057C120
		public static IWalkingPatternComponent GetRootAsIWalkingPatternComponent(ByteBuffer _bb)
		{
			return IWalkingPatternComponent.GetRootAsIWalkingPatternComponent(_bb, default(IWalkingPatternComponent));
		}

		// Token: 0x06027F25 RID: 163621 RVA: 0x0057DF3C File Offset: 0x0057C13C
		public static IWalkingPatternComponent GetRootAsIWalkingPatternComponent(ByteBuffer _bb, IWalkingPatternComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027F26 RID: 163622 RVA: 0x0057DF59 File Offset: 0x0057C159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027F27 RID: 163623 RVA: 0x0057DF68 File Offset: 0x0057C168
		public IWalkingPatternComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B064 RID: 45156
		// (get) Token: 0x06027F28 RID: 163624 RVA: 0x0057DF78 File Offset: 0x0057C178
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B065 RID: 45157
		// (get) Token: 0x06027F29 RID: 163625 RVA: 0x0057DFB8 File Offset: 0x0057C1B8
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B066 RID: 45158
		// (get) Token: 0x06027F2A RID: 163626 RVA: 0x0057DFF4 File Offset: 0x0057C1F4
		public int EndEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B067 RID: 45159
		// (get) Token: 0x06027F2B RID: 163627 RVA: 0x0057E030 File Offset: 0x0057C230
		public TVarRef ScoreVarType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027F2C RID: 163628 RVA: 0x0057E070 File Offset: 0x0057C270
		public TTable? ScoreVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027F2D RID: 163629 RVA: 0x0057E0B8 File Offset: 0x0057C2B8
		public IConstVarRef ScoreVarAsIConstVarRef()
		{
			return this.ScoreVar<IConstVarRef>().Value;
		}

		// Token: 0x06027F2E RID: 163630 RVA: 0x0057E0D4 File Offset: 0x0057C2D4
		public IGlobalVarRef ScoreVarAsIGlobalVarRef()
		{
			return this.ScoreVar<IGlobalVarRef>().Value;
		}

		// Token: 0x06027F2F RID: 163631 RVA: 0x0057E0F0 File Offset: 0x0057C2F0
		public IOtherVarRef ScoreVarAsIOtherVarRef()
		{
			return this.ScoreVar<IOtherVarRef>().Value;
		}

		// Token: 0x06027F30 RID: 163632 RVA: 0x0057E10C File Offset: 0x0057C30C
		public ISelfVarRef ScoreVarAsISelfVarRef()
		{
			return this.ScoreVar<ISelfVarRef>().Value;
		}

		// Token: 0x06027F31 RID: 163633 RVA: 0x0057E128 File Offset: 0x0057C328
		public ISystemVarRef ScoreVarAsISystemVarRef()
		{
			return this.ScoreVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700B068 RID: 45160
		// (get) Token: 0x06027F32 RID: 163634 RVA: 0x0057E144 File Offset: 0x0057C344
		public float SpineEffectExistDuration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B069 RID: 45161
		// (get) Token: 0x06027F33 RID: 163635 RVA: 0x0057E188 File Offset: 0x0057C388
		public string ReplaySpineEffect
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027F34 RID: 163636 RVA: 0x0057E1C0 File Offset: 0x0057C3C0
		public Span<byte> GetReplaySpineEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06027F35 RID: 163637 RVA: 0x0057E1D0 File Offset: 0x0057C3D0
		public byte[] GetReplaySpineEffectArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B06A RID: 45162
		// (get) Token: 0x06027F36 RID: 163638 RVA: 0x0057E1E0 File Offset: 0x0057C3E0
		public IWalkingPatternStayAwayConfig? StayAwayFailConfig
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IWalkingPatternStayAwayConfig?(default(IWalkingPatternStayAwayConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B06B RID: 45163
		// (get) Token: 0x06027F37 RID: 163639 RVA: 0x0057E240 File Offset: 0x0057C440
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027F38 RID: 163640 RVA: 0x0057E280 File Offset: 0x0057C480
		public static Offset<IWalkingPatternComponent> CreateIWalkingPatternComponent(FlatBufferBuilder builder, bool Disabled = false, int SplineEntityId = 0, int EndEntityId = 0, TVarRef ScoreVar_type = TVarRef.NONE, int ScoreVarOffset = 0, float SpineEffectExistDuration = 0f, StringOffset ReplaySpineEffectOffset = default(StringOffset), Offset<IWalkingPatternStayAwayConfig> StayAwayFailConfigOffset = default(Offset<IWalkingPatternStayAwayConfig>), byte NullMask = 0)
		{
			builder.StartTable(9);
			IWalkingPatternComponent.AddStayAwayFailConfig(builder, StayAwayFailConfigOffset);
			IWalkingPatternComponent.AddReplaySpineEffect(builder, ReplaySpineEffectOffset);
			IWalkingPatternComponent.AddSpineEffectExistDuration(builder, SpineEffectExistDuration);
			IWalkingPatternComponent.AddScoreVar(builder, ScoreVarOffset);
			IWalkingPatternComponent.AddEndEntityId(builder, EndEntityId);
			IWalkingPatternComponent.AddSplineEntityId(builder, SplineEntityId);
			IWalkingPatternComponent.AddNullMask(builder, NullMask);
			IWalkingPatternComponent.AddScoreVarType(builder, ScoreVar_type);
			IWalkingPatternComponent.AddDisabled(builder, Disabled);
			return IWalkingPatternComponent.EndIWalkingPatternComponent(builder);
		}

		// Token: 0x06027F39 RID: 163641 RVA: 0x0057E2E0 File Offset: 0x0057C4E0
		public static void StartIWalkingPatternComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06027F3A RID: 163642 RVA: 0x0057E2EA File Offset: 0x0057C4EA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027F3B RID: 163643 RVA: 0x0057E2F5 File Offset: 0x0057C4F5
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x06027F3C RID: 163644 RVA: 0x0057E300 File Offset: 0x0057C500
		public static void AddEndEntityId(FlatBufferBuilder builder, int endEntityId)
		{
			builder.AddInt(2, endEntityId, 0);
		}

		// Token: 0x06027F3D RID: 163645 RVA: 0x0057E30B File Offset: 0x0057C50B
		public static void AddScoreVarType(FlatBufferBuilder builder, TVarRef scoreVarType)
		{
			builder.AddByte(3, (byte)scoreVarType, 0);
		}

		// Token: 0x06027F3E RID: 163646 RVA: 0x0057E316 File Offset: 0x0057C516
		public static void AddScoreVar(FlatBufferBuilder builder, int scoreVarOffset)
		{
			builder.AddOffset(4, scoreVarOffset, 0);
		}

		// Token: 0x06027F3F RID: 163647 RVA: 0x0057E321 File Offset: 0x0057C521
		public static void AddSpineEffectExistDuration(FlatBufferBuilder builder, float spineEffectExistDuration)
		{
			builder.AddFloat(5, spineEffectExistDuration, 0.0);
		}

		// Token: 0x06027F40 RID: 163648 RVA: 0x0057E334 File Offset: 0x0057C534
		public static void AddReplaySpineEffect(FlatBufferBuilder builder, StringOffset replaySpineEffectOffset)
		{
			builder.AddOffset(6, replaySpineEffectOffset.Value, 0);
		}

		// Token: 0x06027F41 RID: 163649 RVA: 0x0057E344 File Offset: 0x0057C544
		public static void AddStayAwayFailConfig(FlatBufferBuilder builder, Offset<IWalkingPatternStayAwayConfig> stayAwayFailConfigOffset)
		{
			builder.AddOffset(7, stayAwayFailConfigOffset.Value, 0);
		}

		// Token: 0x06027F42 RID: 163650 RVA: 0x0057E354 File Offset: 0x0057C554
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06027F43 RID: 163651 RVA: 0x0057E35F File Offset: 0x0057C55F
		public static Offset<IWalkingPatternComponent> EndIWalkingPatternComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternComponent>(builder.EndTable());
		}

		// Token: 0x06027F44 RID: 163652 RVA: 0x0057E36C File Offset: 0x0057C56C
		public IWalkingPatternComponentT UnPack()
		{
			IWalkingPatternComponentT walkingPatternComponentT = new IWalkingPatternComponentT();
			this.UnPackTo(walkingPatternComponentT);
			return walkingPatternComponentT;
		}

		// Token: 0x06027F45 RID: 163653 RVA: 0x0057E388 File Offset: 0x0057C588
		public void UnPackTo(IWalkingPatternComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SplineEntityId = this.SplineEntityId;
			_o.EndEntityId = this.EndEntityId;
			_o.ScoreVar = new TVarRefUnion();
			_o.ScoreVar.Type = this.ScoreVarType;
			switch (this.ScoreVarType)
			{
			case TVarRef.IConstVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IConstVarRef>() != null) ? this.ScoreVar<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IGlobalVarRef>() != null) ? this.ScoreVar<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<IOtherVarRef>() != null) ? this.ScoreVar<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<ISelfVarRef>() != null) ? this.ScoreVar<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.ScoreVar.Value = ((this.ScoreVar<ISystemVarRef>() != null) ? this.ScoreVar<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.SpineEffectExistDuration = this.SpineEffectExistDuration;
			_o.ReplaySpineEffect = this.ReplaySpineEffect;
			_o.StayAwayFailConfig = ((this.StayAwayFailConfig != null) ? this.StayAwayFailConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027F46 RID: 163654 RVA: 0x0057E570 File Offset: 0x0057C770
		public static Offset<IWalkingPatternComponent> Pack(FlatBufferBuilder builder, IWalkingPatternComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWalkingPatternComponent>);
			}
			TVarRef scoreVar_type = (_o.ScoreVar == null) ? TVarRef.NONE : _o.ScoreVar.Type;
			int scoreVarOffset = (_o.ScoreVar == null) ? 0 : TVarRefUnion.Pack(builder, _o.ScoreVar);
			StringOffset replaySpineEffectOffset = (_o.ReplaySpineEffect == null) ? default(StringOffset) : builder.CreateString(_o.ReplaySpineEffect);
			Offset<IWalkingPatternStayAwayConfig> stayAwayFailConfigOffset = (_o.StayAwayFailConfig == null) ? default(Offset<IWalkingPatternStayAwayConfig>) : IWalkingPatternStayAwayConfig.Pack(builder, _o.StayAwayFailConfig);
			return IWalkingPatternComponent.CreateIWalkingPatternComponent(builder, _o.Disabled, _o.SplineEntityId, _o.EndEntityId, scoreVar_type, scoreVarOffset, _o.SpineEffectExistDuration, replaySpineEffectOffset, stayAwayFailConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F279 RID: 62073
		private Table __p;
	}
}
