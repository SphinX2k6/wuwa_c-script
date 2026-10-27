using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B24 RID: 27428
	public struct IMotorParkourTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700CBD8 RID: 52184
		// (get) Token: 0x0603023C RID: 197180 RVA: 0x0068B190 File Offset: 0x00689390
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603023D RID: 197181 RVA: 0x0068B19D File Offset: 0x0068939D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603023E RID: 197182 RVA: 0x0068B1A4 File Offset: 0x006893A4
		public static IMotorParkourTrackingEvent GetRootAsIMotorParkourTrackingEvent(ByteBuffer _bb)
		{
			return IMotorParkourTrackingEvent.GetRootAsIMotorParkourTrackingEvent(_bb, default(IMotorParkourTrackingEvent));
		}

		// Token: 0x0603023F RID: 197183 RVA: 0x0068B1C0 File Offset: 0x006893C0
		public static IMotorParkourTrackingEvent GetRootAsIMotorParkourTrackingEvent(ByteBuffer _bb, IMotorParkourTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030240 RID: 197184 RVA: 0x0068B1DD File Offset: 0x006893DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030241 RID: 197185 RVA: 0x0068B1EC File Offset: 0x006893EC
		public IMotorParkourTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBD9 RID: 52185
		// (get) Token: 0x06030242 RID: 197186 RVA: 0x0068B1FC File Offset: 0x006893FC
		public ETrackingEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackingEventType.EasterEgg;
				}
				return (ETrackingEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBDA RID: 52186
		// (get) Token: 0x06030243 RID: 197187 RVA: 0x0068B238 File Offset: 0x00689438
		public EMotorParkourPhase MotorParkourPhase
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMotorParkourPhase.Start;
				}
				return (EMotorParkourPhase)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBDB RID: 52187
		// (get) Token: 0x06030244 RID: 197188 RVA: 0x0068B274 File Offset: 0x00689474
		public TVarRef MotorParkourScoreVarRefType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030245 RID: 197189 RVA: 0x0068B2B0 File Offset: 0x006894B0
		public TTable? MotorParkourScoreVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030246 RID: 197190 RVA: 0x0068B2F8 File Offset: 0x006894F8
		public IConstVarRef MotorParkourScoreVarRefAsIConstVarRef()
		{
			return this.MotorParkourScoreVarRef<IConstVarRef>().Value;
		}

		// Token: 0x06030247 RID: 197191 RVA: 0x0068B314 File Offset: 0x00689514
		public IGlobalVarRef MotorParkourScoreVarRefAsIGlobalVarRef()
		{
			return this.MotorParkourScoreVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x06030248 RID: 197192 RVA: 0x0068B330 File Offset: 0x00689530
		public IOtherVarRef MotorParkourScoreVarRefAsIOtherVarRef()
		{
			return this.MotorParkourScoreVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x06030249 RID: 197193 RVA: 0x0068B34C File Offset: 0x0068954C
		public ISelfVarRef MotorParkourScoreVarRefAsISelfVarRef()
		{
			return this.MotorParkourScoreVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0603024A RID: 197194 RVA: 0x0068B368 File Offset: 0x00689568
		public ISystemVarRef MotorParkourScoreVarRefAsISystemVarRef()
		{
			return this.MotorParkourScoreVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0603024B RID: 197195 RVA: 0x0068B383 File Offset: 0x00689583
		public static Offset<IMotorParkourTrackingEvent> CreateIMotorParkourTrackingEvent(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg, EMotorParkourPhase MotorParkourPhase = EMotorParkourPhase.Start, TVarRef MotorParkourScoreVarRef_type = TVarRef.NONE, int MotorParkourScoreVarRefOffset = 0)
		{
			builder.StartTable(4);
			IMotorParkourTrackingEvent.AddMotorParkourScoreVarRef(builder, MotorParkourScoreVarRefOffset);
			IMotorParkourTrackingEvent.AddMotorParkourScoreVarRefType(builder, MotorParkourScoreVarRef_type);
			IMotorParkourTrackingEvent.AddMotorParkourPhase(builder, MotorParkourPhase);
			IMotorParkourTrackingEvent.AddType(builder, Type);
			return IMotorParkourTrackingEvent.EndIMotorParkourTrackingEvent(builder);
		}

		// Token: 0x0603024C RID: 197196 RVA: 0x0068B3AF File Offset: 0x006895AF
		public static void StartIMotorParkourTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603024D RID: 197197 RVA: 0x0068B3B8 File Offset: 0x006895B8
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603024E RID: 197198 RVA: 0x0068B3C3 File Offset: 0x006895C3
		public static void AddMotorParkourPhase(FlatBufferBuilder builder, EMotorParkourPhase motorParkourPhase)
		{
			builder.AddByte(1, (byte)motorParkourPhase, 0);
		}

		// Token: 0x0603024F RID: 197199 RVA: 0x0068B3CE File Offset: 0x006895CE
		public static void AddMotorParkourScoreVarRefType(FlatBufferBuilder builder, TVarRef motorParkourScoreVarRefType)
		{
			builder.AddByte(2, (byte)motorParkourScoreVarRefType, 0);
		}

		// Token: 0x06030250 RID: 197200 RVA: 0x0068B3D9 File Offset: 0x006895D9
		public static void AddMotorParkourScoreVarRef(FlatBufferBuilder builder, int motorParkourScoreVarRefOffset)
		{
			builder.AddOffset(3, motorParkourScoreVarRefOffset, 0);
		}

		// Token: 0x06030251 RID: 197201 RVA: 0x0068B3E4 File Offset: 0x006895E4
		public static Offset<IMotorParkourTrackingEvent> EndIMotorParkourTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParkourTrackingEvent>(builder.EndTable());
		}

		// Token: 0x06030252 RID: 197202 RVA: 0x0068B3F4 File Offset: 0x006895F4
		public IMotorParkourTrackingEventT UnPack()
		{
			IMotorParkourTrackingEventT motorParkourTrackingEventT = new IMotorParkourTrackingEventT();
			this.UnPackTo(motorParkourTrackingEventT);
			return motorParkourTrackingEventT;
		}

		// Token: 0x06030253 RID: 197203 RVA: 0x0068B410 File Offset: 0x00689610
		public void UnPackTo(IMotorParkourTrackingEventT _o)
		{
			_o.Type = this.Type;
			_o.MotorParkourPhase = this.MotorParkourPhase;
			_o.MotorParkourScoreVarRef = new TVarRefUnion();
			_o.MotorParkourScoreVarRef.Type = this.MotorParkourScoreVarRefType;
			switch (this.MotorParkourScoreVarRefType)
			{
			case TVarRef.IConstVarRef:
				_o.MotorParkourScoreVarRef.Value = ((this.MotorParkourScoreVarRef<IConstVarRef>() != null) ? this.MotorParkourScoreVarRef<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.MotorParkourScoreVarRef.Value = ((this.MotorParkourScoreVarRef<IGlobalVarRef>() != null) ? this.MotorParkourScoreVarRef<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.MotorParkourScoreVarRef.Value = ((this.MotorParkourScoreVarRef<IOtherVarRef>() != null) ? this.MotorParkourScoreVarRef<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.MotorParkourScoreVarRef.Value = ((this.MotorParkourScoreVarRef<ISelfVarRef>() != null) ? this.MotorParkourScoreVarRef<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.MotorParkourScoreVarRef.Value = ((this.MotorParkourScoreVarRef<ISystemVarRef>() != null) ? this.MotorParkourScoreVarRef<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06030254 RID: 197204 RVA: 0x0068B588 File Offset: 0x00689788
		public static Offset<IMotorParkourTrackingEvent> Pack(FlatBufferBuilder builder, IMotorParkourTrackingEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorParkourTrackingEvent>);
			}
			TVarRef motorParkourScoreVarRef_type = (_o.MotorParkourScoreVarRef == null) ? TVarRef.NONE : _o.MotorParkourScoreVarRef.Type;
			int motorParkourScoreVarRefOffset = (_o.MotorParkourScoreVarRef == null) ? 0 : TVarRefUnion.Pack(builder, _o.MotorParkourScoreVarRef);
			return IMotorParkourTrackingEvent.CreateIMotorParkourTrackingEvent(builder, _o.Type, _o.MotorParkourPhase, motorParkourScoreVarRef_type, motorParkourScoreVarRefOffset);
		}

		// Token: 0x040113B9 RID: 70585
		private Table __p;
	}
}
