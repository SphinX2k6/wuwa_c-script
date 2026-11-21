using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725B RID: 29275
	public struct IMotorParkourTrackingEvent : IFlatbufferObject
	{
		// Token: 0x1700D6A7 RID: 54951
		// (get) Token: 0x06033010 RID: 208912 RVA: 0x006E2848 File Offset: 0x006E0A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033011 RID: 208913 RVA: 0x006E2855 File Offset: 0x006E0A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033012 RID: 208914 RVA: 0x006E285C File Offset: 0x006E0A5C
		public static IMotorParkourTrackingEvent GetRootAsIMotorParkourTrackingEvent(ByteBuffer _bb)
		{
			return IMotorParkourTrackingEvent.GetRootAsIMotorParkourTrackingEvent(_bb, default(IMotorParkourTrackingEvent));
		}

		// Token: 0x06033013 RID: 208915 RVA: 0x006E2878 File Offset: 0x006E0A78
		public static IMotorParkourTrackingEvent GetRootAsIMotorParkourTrackingEvent(ByteBuffer _bb, IMotorParkourTrackingEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033014 RID: 208916 RVA: 0x006E2895 File Offset: 0x006E0A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033015 RID: 208917 RVA: 0x006E28A4 File Offset: 0x006E0AA4
		public IMotorParkourTrackingEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6A8 RID: 54952
		// (get) Token: 0x06033016 RID: 208918 RVA: 0x006E28B4 File Offset: 0x006E0AB4
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

		// Token: 0x1700D6A9 RID: 54953
		// (get) Token: 0x06033017 RID: 208919 RVA: 0x006E28F0 File Offset: 0x006E0AF0
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

		// Token: 0x1700D6AA RID: 54954
		// (get) Token: 0x06033018 RID: 208920 RVA: 0x006E292C File Offset: 0x006E0B2C
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

		// Token: 0x06033019 RID: 208921 RVA: 0x006E2968 File Offset: 0x006E0B68
		public TTable? MotorParkourScoreVarRef<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603301A RID: 208922 RVA: 0x006E29B0 File Offset: 0x006E0BB0
		public IConstVarRef MotorParkourScoreVarRefAsIConstVarRef()
		{
			return this.MotorParkourScoreVarRef<IConstVarRef>().Value;
		}

		// Token: 0x0603301B RID: 208923 RVA: 0x006E29CC File Offset: 0x006E0BCC
		public IGlobalVarRef MotorParkourScoreVarRefAsIGlobalVarRef()
		{
			return this.MotorParkourScoreVarRef<IGlobalVarRef>().Value;
		}

		// Token: 0x0603301C RID: 208924 RVA: 0x006E29E8 File Offset: 0x006E0BE8
		public IOtherVarRef MotorParkourScoreVarRefAsIOtherVarRef()
		{
			return this.MotorParkourScoreVarRef<IOtherVarRef>().Value;
		}

		// Token: 0x0603301D RID: 208925 RVA: 0x006E2A04 File Offset: 0x006E0C04
		public ISelfVarRef MotorParkourScoreVarRefAsISelfVarRef()
		{
			return this.MotorParkourScoreVarRef<ISelfVarRef>().Value;
		}

		// Token: 0x0603301E RID: 208926 RVA: 0x006E2A20 File Offset: 0x006E0C20
		public ISystemVarRef MotorParkourScoreVarRefAsISystemVarRef()
		{
			return this.MotorParkourScoreVarRef<ISystemVarRef>().Value;
		}

		// Token: 0x0603301F RID: 208927 RVA: 0x006E2A3B File Offset: 0x006E0C3B
		public static Offset<IMotorParkourTrackingEvent> CreateIMotorParkourTrackingEvent(FlatBufferBuilder builder, ETrackingEventType Type = ETrackingEventType.EasterEgg, EMotorParkourPhase MotorParkourPhase = EMotorParkourPhase.Start, TVarRef MotorParkourScoreVarRef_type = TVarRef.NONE, int MotorParkourScoreVarRefOffset = 0)
		{
			builder.StartTable(4);
			IMotorParkourTrackingEvent.AddMotorParkourScoreVarRef(builder, MotorParkourScoreVarRefOffset);
			IMotorParkourTrackingEvent.AddMotorParkourScoreVarRefType(builder, MotorParkourScoreVarRef_type);
			IMotorParkourTrackingEvent.AddMotorParkourPhase(builder, MotorParkourPhase);
			IMotorParkourTrackingEvent.AddType(builder, Type);
			return IMotorParkourTrackingEvent.EndIMotorParkourTrackingEvent(builder);
		}

		// Token: 0x06033020 RID: 208928 RVA: 0x006E2A67 File Offset: 0x006E0C67
		public static void StartIMotorParkourTrackingEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033021 RID: 208929 RVA: 0x006E2A70 File Offset: 0x006E0C70
		public static void AddType(FlatBufferBuilder builder, ETrackingEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033022 RID: 208930 RVA: 0x006E2A7B File Offset: 0x006E0C7B
		public static void AddMotorParkourPhase(FlatBufferBuilder builder, EMotorParkourPhase motorParkourPhase)
		{
			builder.AddByte(1, (byte)motorParkourPhase, 0);
		}

		// Token: 0x06033023 RID: 208931 RVA: 0x006E2A86 File Offset: 0x006E0C86
		public static void AddMotorParkourScoreVarRefType(FlatBufferBuilder builder, TVarRef motorParkourScoreVarRefType)
		{
			builder.AddByte(2, (byte)motorParkourScoreVarRefType, 0);
		}

		// Token: 0x06033024 RID: 208932 RVA: 0x006E2A91 File Offset: 0x006E0C91
		public static void AddMotorParkourScoreVarRef(FlatBufferBuilder builder, int motorParkourScoreVarRefOffset)
		{
			builder.AddOffset(3, motorParkourScoreVarRefOffset, 0);
		}

		// Token: 0x06033025 RID: 208933 RVA: 0x006E2A9C File Offset: 0x006E0C9C
		public static Offset<IMotorParkourTrackingEvent> EndIMotorParkourTrackingEvent(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParkourTrackingEvent>(builder.EndTable());
		}

		// Token: 0x06033026 RID: 208934 RVA: 0x006E2AAC File Offset: 0x006E0CAC
		public IMotorParkourTrackingEventT UnPack()
		{
			IMotorParkourTrackingEventT motorParkourTrackingEventT = new IMotorParkourTrackingEventT();
			this.UnPackTo(motorParkourTrackingEventT);
			return motorParkourTrackingEventT;
		}

		// Token: 0x06033027 RID: 208935 RVA: 0x006E2AC8 File Offset: 0x006E0CC8
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

		// Token: 0x06033028 RID: 208936 RVA: 0x006E2C40 File Offset: 0x006E0E40
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

		// Token: 0x040122CC RID: 74444
		private Table __p;
	}
}
