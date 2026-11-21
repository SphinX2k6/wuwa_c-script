using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EE RID: 21486
	public struct IAttachTimingEntityStateConfig : IFlatbufferObject
	{
		// Token: 0x1700980A RID: 38922
		// (get) Token: 0x06021933 RID: 137523 RVA: 0x004A1259 File Offset: 0x0049F459
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021934 RID: 137524 RVA: 0x004A1266 File Offset: 0x0049F466
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021935 RID: 137525 RVA: 0x004A1270 File Offset: 0x0049F470
		public static IAttachTimingEntityStateConfig GetRootAsIAttachTimingEntityStateConfig(ByteBuffer _bb)
		{
			return IAttachTimingEntityStateConfig.GetRootAsIAttachTimingEntityStateConfig(_bb, default(IAttachTimingEntityStateConfig));
		}

		// Token: 0x06021936 RID: 137526 RVA: 0x004A128C File Offset: 0x0049F48C
		public static IAttachTimingEntityStateConfig GetRootAsIAttachTimingEntityStateConfig(ByteBuffer _bb, IAttachTimingEntityStateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021937 RID: 137527 RVA: 0x004A12A9 File Offset: 0x0049F4A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021938 RID: 137528 RVA: 0x004A12B8 File Offset: 0x0049F4B8
		public IAttachTimingEntityStateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700980B RID: 38923
		// (get) Token: 0x06021939 RID: 137529 RVA: 0x004A12C8 File Offset: 0x0049F4C8
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602193A RID: 137530 RVA: 0x004A12FF File Offset: 0x0049F4FF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602193B RID: 137531 RVA: 0x004A130E File Offset: 0x0049F50E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700980C RID: 38924
		// (get) Token: 0x0602193C RID: 137532 RVA: 0x004A131C File Offset: 0x0049F51C
		public IAttachTimingLinkEffect? LinkEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IAttachTimingLinkEffect?(default(IAttachTimingLinkEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700980D RID: 38925
		// (get) Token: 0x0602193D RID: 137533 RVA: 0x004A137C File Offset: 0x0049F57C
		public int Entity
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

		// Token: 0x1700980E RID: 38926
		// (get) Token: 0x0602193E RID: 137534 RVA: 0x004A13B8 File Offset: 0x0049F5B8
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700980F RID: 38927
		// (get) Token: 0x0602193F RID: 137535 RVA: 0x004A1418 File Offset: 0x0049F618
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021940 RID: 137536 RVA: 0x004A1455 File Offset: 0x0049F655
		public static Offset<IAttachTimingEntityStateConfig> CreateIAttachTimingEntityStateConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), Offset<IAttachTimingLinkEffect> LinkEffectOffset = default(Offset<IAttachTimingLinkEffect>), int Entity = 0, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IAttachTimingEntityStateConfig.AddActorRef(builder, ActorRefOffset);
			IAttachTimingEntityStateConfig.AddEntity(builder, Entity);
			IAttachTimingEntityStateConfig.AddLinkEffect(builder, LinkEffectOffset);
			IAttachTimingEntityStateConfig.AddState(builder, StateOffset);
			IAttachTimingEntityStateConfig.AddNullMask(builder, NullMask);
			return IAttachTimingEntityStateConfig.EndIAttachTimingEntityStateConfig(builder);
		}

		// Token: 0x06021941 RID: 137537 RVA: 0x004A1489 File Offset: 0x0049F689
		public static void StartIAttachTimingEntityStateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021942 RID: 137538 RVA: 0x004A1492 File Offset: 0x0049F692
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06021943 RID: 137539 RVA: 0x004A14A2 File Offset: 0x0049F6A2
		public static void AddLinkEffect(FlatBufferBuilder builder, Offset<IAttachTimingLinkEffect> linkEffectOffset)
		{
			builder.AddOffset(1, linkEffectOffset.Value, 0);
		}

		// Token: 0x06021944 RID: 137540 RVA: 0x004A14B2 File Offset: 0x0049F6B2
		public static void AddEntity(FlatBufferBuilder builder, int entity)
		{
			builder.AddInt(2, entity, 0);
		}

		// Token: 0x06021945 RID: 137541 RVA: 0x004A14BD File Offset: 0x0049F6BD
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(3, actorRefOffset.Value, 0);
		}

		// Token: 0x06021946 RID: 137542 RVA: 0x004A14CD File Offset: 0x0049F6CD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021947 RID: 137543 RVA: 0x004A14D8 File Offset: 0x0049F6D8
		public static Offset<IAttachTimingEntityStateConfig> EndIAttachTimingEntityStateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAttachTimingEntityStateConfig>(builder.EndTable());
		}

		// Token: 0x06021948 RID: 137544 RVA: 0x004A14E8 File Offset: 0x0049F6E8
		public IAttachTimingEntityStateConfigT UnPack()
		{
			IAttachTimingEntityStateConfigT attachTimingEntityStateConfigT = new IAttachTimingEntityStateConfigT();
			this.UnPackTo(attachTimingEntityStateConfigT);
			return attachTimingEntityStateConfigT;
		}

		// Token: 0x06021949 RID: 137545 RVA: 0x004A1504 File Offset: 0x0049F704
		public void UnPackTo(IAttachTimingEntityStateConfigT _o)
		{
			_o.State = this.State;
			_o.LinkEffect = ((this.LinkEffect != null) ? this.LinkEffect.Value.UnPack() : null);
			_o.Entity = this.Entity;
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602194A RID: 137546 RVA: 0x004A1594 File Offset: 0x0049F794
		public static Offset<IAttachTimingEntityStateConfig> Pack(FlatBufferBuilder builder, IAttachTimingEntityStateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttachTimingEntityStateConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			Offset<IAttachTimingLinkEffect> linkEffectOffset = (_o.LinkEffect == null) ? default(Offset<IAttachTimingLinkEffect>) : IAttachTimingLinkEffect.Pack(builder, _o.LinkEffect);
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			return IAttachTimingEntityStateConfig.CreateIAttachTimingEntityStateConfig(builder, stateOffset, linkEffectOffset, _o.Entity, actorRefOffset, _o.NullMask);
		}

		// Token: 0x0400E852 RID: 59474
		private Table __p;
	}
}
