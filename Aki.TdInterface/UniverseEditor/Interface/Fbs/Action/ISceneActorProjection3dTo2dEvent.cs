using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B1 RID: 30385
	public struct ISceneActorProjection3dTo2dEvent : IFlatbufferObject
	{
		// Token: 0x1700DEE0 RID: 57056
		// (get) Token: 0x060354BF RID: 218303 RVA: 0x0072658D File Offset: 0x0072478D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060354C0 RID: 218304 RVA: 0x0072659A File Offset: 0x0072479A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060354C1 RID: 218305 RVA: 0x007265A4 File Offset: 0x007247A4
		public static ISceneActorProjection3dTo2dEvent GetRootAsISceneActorProjection3dTo2dEvent(ByteBuffer _bb)
		{
			return ISceneActorProjection3dTo2dEvent.GetRootAsISceneActorProjection3dTo2dEvent(_bb, default(ISceneActorProjection3dTo2dEvent));
		}

		// Token: 0x060354C2 RID: 218306 RVA: 0x007265C0 File Offset: 0x007247C0
		public static ISceneActorProjection3dTo2dEvent GetRootAsISceneActorProjection3dTo2dEvent(ByteBuffer _bb, ISceneActorProjection3dTo2dEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060354C3 RID: 218307 RVA: 0x007265DD File Offset: 0x007247DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060354C4 RID: 218308 RVA: 0x007265EC File Offset: 0x007247EC
		public ISceneActorProjection3dTo2dEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEE1 RID: 57057
		// (get) Token: 0x060354C5 RID: 218309 RVA: 0x007265FC File Offset: 0x007247FC
		public ESceneActorEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneActorEventType.PlayMusicPlants;
				}
				return (ESceneActorEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DEE2 RID: 57058
		// (get) Token: 0x060354C6 RID: 218310 RVA: 0x00726638 File Offset: 0x00724838
		public IActorRef? BpActor
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DEE3 RID: 57059
		// (get) Token: 0x060354C7 RID: 218311 RVA: 0x00726698 File Offset: 0x00724898
		public IActorRef? PPVolume
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060354C8 RID: 218312 RVA: 0x007266F5 File Offset: 0x007248F5
		public static Offset<ISceneActorProjection3dTo2dEvent> CreateISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>), Offset<IActorRef> PPVolumeOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(3);
			ISceneActorProjection3dTo2dEvent.AddPPVolume(builder, PPVolumeOffset);
			ISceneActorProjection3dTo2dEvent.AddBpActor(builder, BpActorOffset);
			ISceneActorProjection3dTo2dEvent.AddType(builder, Type);
			return ISceneActorProjection3dTo2dEvent.EndISceneActorProjection3dTo2dEvent(builder);
		}

		// Token: 0x060354C9 RID: 218313 RVA: 0x00726719 File Offset: 0x00724919
		public static void StartISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060354CA RID: 218314 RVA: 0x00726722 File Offset: 0x00724922
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060354CB RID: 218315 RVA: 0x0072672D File Offset: 0x0072492D
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x060354CC RID: 218316 RVA: 0x0072673D File Offset: 0x0072493D
		public static void AddPPVolume(FlatBufferBuilder builder, Offset<IActorRef> pPVolumeOffset)
		{
			builder.AddOffset(2, pPVolumeOffset.Value, 0);
		}

		// Token: 0x060354CD RID: 218317 RVA: 0x0072674D File Offset: 0x0072494D
		public static Offset<ISceneActorProjection3dTo2dEvent> EndISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorProjection3dTo2dEvent>(builder.EndTable());
		}

		// Token: 0x060354CE RID: 218318 RVA: 0x0072675C File Offset: 0x0072495C
		public ISceneActorProjection3dTo2dEventT UnPack()
		{
			ISceneActorProjection3dTo2dEventT sceneActorProjection3dTo2dEventT = new ISceneActorProjection3dTo2dEventT();
			this.UnPackTo(sceneActorProjection3dTo2dEventT);
			return sceneActorProjection3dTo2dEventT;
		}

		// Token: 0x060354CF RID: 218319 RVA: 0x00726778 File Offset: 0x00724978
		public void UnPackTo(ISceneActorProjection3dTo2dEventT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
			_o.PPVolume = ((this.PPVolume != null) ? this.PPVolume.Value.UnPack() : null);
		}

		// Token: 0x060354D0 RID: 218320 RVA: 0x007267F0 File Offset: 0x007249F0
		public static Offset<ISceneActorProjection3dTo2dEvent> Pack(FlatBufferBuilder builder, ISceneActorProjection3dTo2dEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneActorProjection3dTo2dEvent>);
			}
			Offset<IActorRef> bpActorOffset = (_o.BpActor == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.BpActor);
			Offset<IActorRef> ppvolumeOffset = (_o.PPVolume == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.PPVolume);
			return ISceneActorProjection3dTo2dEvent.CreateISceneActorProjection3dTo2dEvent(builder, _o.Type, bpActorOffset, ppvolumeOffset);
		}

		// Token: 0x0401289F RID: 75935
		private Table __p;
	}
}
