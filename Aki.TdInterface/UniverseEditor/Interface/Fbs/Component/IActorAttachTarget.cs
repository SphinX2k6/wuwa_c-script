using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005364 RID: 21348
	public struct IActorAttachTarget : IFlatbufferObject
	{
		// Token: 0x170096BA RID: 38586
		// (get) Token: 0x060213E7 RID: 136167 RVA: 0x0049690E File Offset: 0x00494B0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213E8 RID: 136168 RVA: 0x0049691B File Offset: 0x00494B1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213E9 RID: 136169 RVA: 0x00496924 File Offset: 0x00494B24
		public static IActorAttachTarget GetRootAsIActorAttachTarget(ByteBuffer _bb)
		{
			return IActorAttachTarget.GetRootAsIActorAttachTarget(_bb, default(IActorAttachTarget));
		}

		// Token: 0x060213EA RID: 136170 RVA: 0x00496940 File Offset: 0x00494B40
		public static IActorAttachTarget GetRootAsIActorAttachTarget(ByteBuffer _bb, IActorAttachTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060213EB RID: 136171 RVA: 0x0049695D File Offset: 0x00494B5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060213EC RID: 136172 RVA: 0x0049696C File Offset: 0x00494B6C
		public IActorAttachTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170096BB RID: 38587
		// (get) Token: 0x060213ED RID: 136173 RVA: 0x0049697C File Offset: 0x00494B7C
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

		// Token: 0x170096BC RID: 38588
		// (get) Token: 0x060213EE RID: 136174 RVA: 0x004969B8 File Offset: 0x00494BB8
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

		// Token: 0x060213EF RID: 136175 RVA: 0x00496A15 File Offset: 0x00494C15
		public static Offset<IActorAttachTarget> CreateIActorAttachTarget(FlatBufferBuilder builder, EAttachType Type = EAttachType.Actor, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>))
		{
			builder.StartTable(2);
			IActorAttachTarget.AddActorRef(builder, ActorRefOffset);
			IActorAttachTarget.AddType(builder, Type);
			return IActorAttachTarget.EndIActorAttachTarget(builder);
		}

		// Token: 0x060213F0 RID: 136176 RVA: 0x00496A32 File Offset: 0x00494C32
		public static void StartIActorAttachTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060213F1 RID: 136177 RVA: 0x00496A3B File Offset: 0x00494C3B
		public static void AddType(FlatBufferBuilder builder, EAttachType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060213F2 RID: 136178 RVA: 0x00496A46 File Offset: 0x00494C46
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(1, actorRefOffset.Value, 0);
		}

		// Token: 0x060213F3 RID: 136179 RVA: 0x00496A56 File Offset: 0x00494C56
		public static Offset<IActorAttachTarget> EndIActorAttachTarget(FlatBufferBuilder builder)
		{
			return new Offset<IActorAttachTarget>(builder.EndTable());
		}

		// Token: 0x060213F4 RID: 136180 RVA: 0x00496A64 File Offset: 0x00494C64
		public IActorAttachTargetT UnPack()
		{
			IActorAttachTargetT actorAttachTargetT = new IActorAttachTargetT();
			this.UnPackTo(actorAttachTargetT);
			return actorAttachTargetT;
		}

		// Token: 0x060213F5 RID: 136181 RVA: 0x00496A80 File Offset: 0x00494C80
		public void UnPackTo(IActorAttachTargetT _o)
		{
			_o.Type = this.Type;
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
		}

		// Token: 0x060213F6 RID: 136182 RVA: 0x00496AC8 File Offset: 0x00494CC8
		public static Offset<IActorAttachTarget> Pack(FlatBufferBuilder builder, IActorAttachTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorAttachTarget>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IActorAttachTarget.CreateIActorAttachTarget(builder, _o.Type, actorRefOffset);
		}

		// Token: 0x0400E76A RID: 59242
		private Table __p;
	}
}
