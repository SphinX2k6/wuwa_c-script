using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E53 RID: 20051
	public struct IActorAttachTarget : IFlatbufferObject
	{
		// Token: 0x17008F81 RID: 36737
		// (get) Token: 0x0601F79C RID: 128924 RVA: 0x004628F6 File Offset: 0x00460AF6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F79D RID: 128925 RVA: 0x00462903 File Offset: 0x00460B03
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F79E RID: 128926 RVA: 0x0046290C File Offset: 0x00460B0C
		public static IActorAttachTarget GetRootAsIActorAttachTarget(ByteBuffer _bb)
		{
			return IActorAttachTarget.GetRootAsIActorAttachTarget(_bb, default(IActorAttachTarget));
		}

		// Token: 0x0601F79F RID: 128927 RVA: 0x00462928 File Offset: 0x00460B28
		public static IActorAttachTarget GetRootAsIActorAttachTarget(ByteBuffer _bb, IActorAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x00462945 File Offset: 0x00460B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7A1 RID: 128929 RVA: 0x00462954 File Offset: 0x00460B54
		public IActorAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F82 RID: 36738
		// (get) Token: 0x0601F7A2 RID: 128930 RVA: 0x00462964 File Offset: 0x00460B64
		public EAttachType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAttachType.Actor;
				}
				return (EAttachType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F83 RID: 36739
		// (get) Token: 0x0601F7A3 RID: 128931 RVA: 0x004629A0 File Offset: 0x00460BA0
		public IActorRef? ActorRef
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

		// Token: 0x0601F7A4 RID: 128932 RVA: 0x004629FD File Offset: 0x00460BFD
		public static Offset<IActorAttachTarget> CreateIActorAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorAttachTarget.AddActorRef(builder, ActorRefOffset);
			IActorAttachTarget.AddType(builder, Type);
			return IActorAttachTarget.EndIActorAttachTarget(builder);
		}

		// Token: 0x0601F7A5 RID: 128933 RVA: 0x00462A1A File Offset: 0x00460C1A
		public static void StartIActorAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F7A6 RID: 128934 RVA: 0x00462A23 File Offset: 0x00460C23
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7A7 RID: 128935 RVA: 0x00462A2E File Offset: 0x00460C2E
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x0601F7A8 RID: 128936 RVA: 0x00462A3E File Offset: 0x00460C3E
		public static Offset<IActorAttachTarget> EndIActorAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IActorAttachTarget>(builder.EndTable());
		}

		// Token: 0x0601F7A9 RID: 128937 RVA: 0x00462A4C File Offset: 0x00460C4C
		public IActorAttachTargetT UnPack()
		{
			IActorAttachTargetT actorAttachTargetT = new IActorAttachTargetT();
			this.UnPackTo(actorAttachTargetT);
			return actorAttachTargetT;
		}

		// Token: 0x0601F7AA RID: 128938 RVA: 0x00462A68 File Offset: 0x00460C68
		public void UnPackTo(IActorAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x0601F7AB RID: 128939 RVA: 0x00462AB0 File Offset: 0x00460CB0
		public static Offset<IActorAttachTarget> Pack(FlatBufferBuilder builder, IActorAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorAttachTarget>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IActorAttachTarget.CreateIActorAttachTarget(builder, _o.Type, actorRefOffset);
		}

		// Token: 0x0400DBF0 RID: 56304
		private Table __p;
	}
}
