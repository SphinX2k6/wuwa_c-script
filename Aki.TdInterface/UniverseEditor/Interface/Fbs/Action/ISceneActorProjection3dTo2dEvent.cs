using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2A RID: 28458
	public struct ISceneActorProjection3dTo2dEvent : IFlatbufferObject
	{
		// Token: 0x1700D384 RID: 54148
		// (get) Token: 0x06032467 RID: 205927 RVA: 0x006CA625 File Offset: 0x006C8825
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032468 RID: 205928 RVA: 0x006CA632 File Offset: 0x006C8832
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032469 RID: 205929 RVA: 0x006CA63C File Offset: 0x006C883C
		public static ISceneActorProjection3dTo2dEvent GetRootAsISceneActorProjection3dTo2dEvent(ByteBuffer _bb)
		{
			return ISceneActorProjection3dTo2dEvent.GetRootAsISceneActorProjection3dTo2dEvent(_bb, default(ISceneActorProjection3dTo2dEvent));
		}

		// Token: 0x0603246A RID: 205930 RVA: 0x006CA658 File Offset: 0x006C8858
		public static ISceneActorProjection3dTo2dEvent GetRootAsISceneActorProjection3dTo2dEvent(ByteBuffer _bb, ISceneActorProjection3dTo2dEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603246B RID: 205931 RVA: 0x006CA675 File Offset: 0x006C8875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603246C RID: 205932 RVA: 0x006CA684 File Offset: 0x006C8884
		public ISceneActorProjection3dTo2dEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D385 RID: 54149
		// (get) Token: 0x0603246D RID: 205933 RVA: 0x006CA694 File Offset: 0x006C8894
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

		// Token: 0x1700D386 RID: 54150
		// (get) Token: 0x0603246E RID: 205934 RVA: 0x006CA6D0 File Offset: 0x006C88D0
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

		// Token: 0x1700D387 RID: 54151
		// (get) Token: 0x0603246F RID: 205935 RVA: 0x006CA730 File Offset: 0x006C8930
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

		// Token: 0x06032470 RID: 205936 RVA: 0x006CA78D File Offset: 0x006C898D
		public static Offset<ISceneActorProjection3dTo2dEvent> CreateISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder, ESceneActorEventType Type = ESceneActorEventType.PlayMusicPlants, Offset<IActorRef> BpActorOffset = default(Offset<IActorRef>), Offset<IActorRef> PPVolumeOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(3);
			ISceneActorProjection3dTo2dEvent.AddPPVolume(builder, PPVolumeOffset);
			ISceneActorProjection3dTo2dEvent.AddBpActor(builder, BpActorOffset);
			ISceneActorProjection3dTo2dEvent.AddType(builder, Type);
			return ISceneActorProjection3dTo2dEvent.EndISceneActorProjection3dTo2dEvent(builder);
		}

		// Token: 0x06032471 RID: 205937 RVA: 0x006CA7B1 File Offset: 0x006C89B1
		public static void StartISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032472 RID: 205938 RVA: 0x006CA7BA File Offset: 0x006C89BA
		public static void AddType(FlatBufferBuilder builder, ESceneActorEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032473 RID: 205939 RVA: 0x006CA7C5 File Offset: 0x006C89C5
		public static void AddBpActor(FlatBufferBuilder builder, Offset<IActorRef> bpActorOffset)
		{
			builder.AddOffset(1, bpActorOffset.Value, 0);
		}

		// Token: 0x06032474 RID: 205940 RVA: 0x006CA7D5 File Offset: 0x006C89D5
		public static void AddPPVolume(FlatBufferBuilder builder, Offset<IActorRef> pPVolumeOffset)
		{
			builder.AddOffset(2, pPVolumeOffset.Value, 0);
		}

		// Token: 0x06032475 RID: 205941 RVA: 0x006CA7E5 File Offset: 0x006C89E5
		public static Offset<ISceneActorProjection3dTo2dEvent> EndISceneActorProjection3dTo2dEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneActorProjection3dTo2dEvent>(builder.EndTable());
		}

		// Token: 0x06032476 RID: 205942 RVA: 0x006CA7F4 File Offset: 0x006C89F4
		public ISceneActorProjection3dTo2dEventT UnPack()
		{
			ISceneActorProjection3dTo2dEventT sceneActorProjection3dTo2dEventT = new ISceneActorProjection3dTo2dEventT();
			this.UnPackTo(sceneActorProjection3dTo2dEventT);
			return sceneActorProjection3dTo2dEventT;
		}

		// Token: 0x06032477 RID: 205943 RVA: 0x006CA810 File Offset: 0x006C8A10
		public void UnPackTo(ISceneActorProjection3dTo2dEventT _o)
		{
			_o.Type = this.Type;
			_o.BpActor = ((this.BpActor != null) ? this.BpActor.Value.UnPack() : null);
			_o.PPVolume = ((this.PPVolume != null) ? this.PPVolume.Value.UnPack() : null);
		}

		// Token: 0x06032478 RID: 205944 RVA: 0x006CA888 File Offset: 0x006C8A88
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

		// Token: 0x04011917 RID: 71959
		private Table __p;
	}
}
