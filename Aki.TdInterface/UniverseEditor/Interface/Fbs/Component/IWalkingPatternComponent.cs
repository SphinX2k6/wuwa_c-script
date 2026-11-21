using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200615D RID: 24925
	public struct IWalkingPatternComponent : IFlatbufferObject
	{
		// Token: 0x1700B9AB RID: 47531
		// (get) Token: 0x0602A4E6 RID: 173286 RVA: 0x005C599A File Offset: 0x005C3B9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A4E7 RID: 173287 RVA: 0x005C59A7 File Offset: 0x005C3BA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A4E8 RID: 173288 RVA: 0x005C59B0 File Offset: 0x005C3BB0
		public static IWalkingPatternComponent GetRootAsIWalkingPatternComponent(ByteBuffer _bb)
		{
			return IWalkingPatternComponent.GetRootAsIWalkingPatternComponent(_bb, default(IWalkingPatternComponent));
		}

		// Token: 0x0602A4E9 RID: 173289 RVA: 0x005C59CC File Offset: 0x005C3BCC
		public static IWalkingPatternComponent GetRootAsIWalkingPatternComponent(ByteBuffer _bb, IWalkingPatternComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A4EA RID: 173290 RVA: 0x005C59E9 File Offset: 0x005C3BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A4EB RID: 173291 RVA: 0x005C59F8 File Offset: 0x005C3BF8
		public IWalkingPatternComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B9AC RID: 47532
		// (get) Token: 0x0602A4EC RID: 173292 RVA: 0x005C5A08 File Offset: 0x005C3C08
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B9AD RID: 47533
		// (get) Token: 0x0602A4ED RID: 173293 RVA: 0x005C5A48 File Offset: 0x005C3C48
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

		// Token: 0x1700B9AE RID: 47534
		// (get) Token: 0x0602A4EE RID: 173294 RVA: 0x005C5A84 File Offset: 0x005C3C84
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

		// Token: 0x1700B9AF RID: 47535
		// (get) Token: 0x0602A4EF RID: 173295 RVA: 0x005C5AC0 File Offset: 0x005C3CC0
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

		// Token: 0x0602A4F0 RID: 173296 RVA: 0x005C5B00 File Offset: 0x005C3D00
		public TTable? ScoreVar<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A4F1 RID: 173297 RVA: 0x005C5B48 File Offset: 0x005C3D48
		public IConstVarRef ScoreVarAsIConstVarRef()
		{
			return this.ScoreVar<IConstVarRef>().Value;
		}

		// Token: 0x0602A4F2 RID: 173298 RVA: 0x005C5B64 File Offset: 0x005C3D64
		public IGlobalVarRef ScoreVarAsIGlobalVarRef()
		{
			return this.ScoreVar<IGlobalVarRef>().Value;
		}

		// Token: 0x0602A4F3 RID: 173299 RVA: 0x005C5B80 File Offset: 0x005C3D80
		public IOtherVarRef ScoreVarAsIOtherVarRef()
		{
			return this.ScoreVar<IOtherVarRef>().Value;
		}

		// Token: 0x0602A4F4 RID: 173300 RVA: 0x005C5B9C File Offset: 0x005C3D9C
		public ISelfVarRef ScoreVarAsISelfVarRef()
		{
			return this.ScoreVar<ISelfVarRef>().Value;
		}

		// Token: 0x0602A4F5 RID: 173301 RVA: 0x005C5BB8 File Offset: 0x005C3DB8
		public ISystemVarRef ScoreVarAsISystemVarRef()
		{
			return this.ScoreVar<ISystemVarRef>().Value;
		}

		// Token: 0x1700B9B0 RID: 47536
		// (get) Token: 0x0602A4F6 RID: 173302 RVA: 0x005C5BD4 File Offset: 0x005C3DD4
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

		// Token: 0x1700B9B1 RID: 47537
		// (get) Token: 0x0602A4F7 RID: 173303 RVA: 0x005C5C18 File Offset: 0x005C3E18
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

		// Token: 0x0602A4F8 RID: 173304 RVA: 0x005C5C50 File Offset: 0x005C3E50
		public Span<byte> GetReplaySpineEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0602A4F9 RID: 173305 RVA: 0x005C5C60 File Offset: 0x005C3E60
		public byte[] GetReplaySpineEffectArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x1700B9B2 RID: 47538
		// (get) Token: 0x0602A4FA RID: 173306 RVA: 0x005C5C70 File Offset: 0x005C3E70
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

		// Token: 0x1700B9B3 RID: 47539
		// (get) Token: 0x0602A4FB RID: 173307 RVA: 0x005C5CD0 File Offset: 0x005C3ED0
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

		// Token: 0x0602A4FC RID: 173308 RVA: 0x005C5D10 File Offset: 0x005C3F10
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

		// Token: 0x0602A4FD RID: 173309 RVA: 0x005C5D70 File Offset: 0x005C3F70
		public static void StartIWalkingPatternComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x0602A4FE RID: 173310 RVA: 0x005C5D7A File Offset: 0x005C3F7A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A4FF RID: 173311 RVA: 0x005C5D85 File Offset: 0x005C3F85
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602A500 RID: 173312 RVA: 0x005C5D90 File Offset: 0x005C3F90
		public static void AddEndEntityId(FlatBufferBuilder builder, int endEntityId)
		{
			builder.AddInt(2, endEntityId, 0);
		}

		// Token: 0x0602A501 RID: 173313 RVA: 0x005C5D9B File Offset: 0x005C3F9B
		public static void AddScoreVarType(FlatBufferBuilder builder, TVarRef scoreVarType)
		{
			builder.AddByte(3, (byte)scoreVarType, 0);
		}

		// Token: 0x0602A502 RID: 173314 RVA: 0x005C5DA6 File Offset: 0x005C3FA6
		public static void AddScoreVar(FlatBufferBuilder builder, int scoreVarOffset)
		{
			builder.AddOffset(4, scoreVarOffset, 0);
		}

		// Token: 0x0602A503 RID: 173315 RVA: 0x005C5DB1 File Offset: 0x005C3FB1
		public static void AddSpineEffectExistDuration(FlatBufferBuilder builder, float spineEffectExistDuration)
		{
			builder.AddFloat(5, spineEffectExistDuration, 0.0);
		}

		// Token: 0x0602A504 RID: 173316 RVA: 0x005C5DC4 File Offset: 0x005C3FC4
		public static void AddReplaySpineEffect(FlatBufferBuilder builder, StringOffset replaySpineEffectOffset)
		{
			builder.AddOffset(6, replaySpineEffectOffset.Value, 0);
		}

		// Token: 0x0602A505 RID: 173317 RVA: 0x005C5DD4 File Offset: 0x005C3FD4
		public static void AddStayAwayFailConfig(FlatBufferBuilder builder, Offset<IWalkingPatternStayAwayConfig> stayAwayFailConfigOffset)
		{
			builder.AddOffset(7, stayAwayFailConfigOffset.Value, 0);
		}

		// Token: 0x0602A506 RID: 173318 RVA: 0x005C5DE4 File Offset: 0x005C3FE4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x0602A507 RID: 173319 RVA: 0x005C5DEF File Offset: 0x005C3FEF
		public static Offset<IWalkingPatternComponent> EndIWalkingPatternComponent(FlatBufferBuilder builder)
		{
			return new Offset<IWalkingPatternComponent>(builder.EndTable());
		}

		// Token: 0x0602A508 RID: 173320 RVA: 0x005C5DFC File Offset: 0x005C3FFC
		public IWalkingPatternComponentT UnPack()
		{
			IWalkingPatternComponentT walkingPatternComponentT = new IWalkingPatternComponentT();
			this.UnPackTo(walkingPatternComponentT);
			return walkingPatternComponentT;
		}

		// Token: 0x0602A509 RID: 173321 RVA: 0x005C5E18 File Offset: 0x005C4018
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

		// Token: 0x0602A50A RID: 173322 RVA: 0x005C6000 File Offset: 0x005C4200
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

		// Token: 0x0400FF7F RID: 65407
		private Table __p;
	}
}
