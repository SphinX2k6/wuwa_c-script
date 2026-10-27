using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F12 RID: 28434
	public struct IRunActorCustomEvent : IFlatbufferObject
	{
		// Token: 0x1700D363 RID: 54115
		// (get) Token: 0x060323C1 RID: 205761 RVA: 0x006C969B File Offset: 0x006C789B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060323C2 RID: 205762 RVA: 0x006C96A8 File Offset: 0x006C78A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060323C3 RID: 205763 RVA: 0x006C96B0 File Offset: 0x006C78B0
		public static IRunActorCustomEvent GetRootAsIRunActorCustomEvent(ByteBuffer _bb)
		{
			return IRunActorCustomEvent.GetRootAsIRunActorCustomEvent(_bb, default(IRunActorCustomEvent));
		}

		// Token: 0x060323C4 RID: 205764 RVA: 0x006C96CC File Offset: 0x006C78CC
		public static IRunActorCustomEvent GetRootAsIRunActorCustomEvent(ByteBuffer _bb, IRunActorCustomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060323C5 RID: 205765 RVA: 0x006C96E9 File Offset: 0x006C78E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060323C6 RID: 205766 RVA: 0x006C96F8 File Offset: 0x006C78F8
		public IRunActorCustomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D364 RID: 54116
		// (get) Token: 0x060323C7 RID: 205767 RVA: 0x006C9708 File Offset: 0x006C7908
		public IActorRef? ActorRef
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IActorRef?(default(IActorRef).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D365 RID: 54117
		// (get) Token: 0x060323C8 RID: 205768 RVA: 0x006C9768 File Offset: 0x006C7968
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060323C9 RID: 205769 RVA: 0x006C979F File Offset: 0x006C799F
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060323CA RID: 205770 RVA: 0x006C97AE File Offset: 0x006C79AE
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060323CB RID: 205771 RVA: 0x006C97BC File Offset: 0x006C79BC
		public static Offset<IRunActorCustomEvent> CreateIRunActorCustomEvent(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset EventNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRunActorCustomEvent.AddEventName(builder, EventNameOffset);
			IRunActorCustomEvent.AddActorRef(builder, ActorRefOffset);
			return IRunActorCustomEvent.EndIRunActorCustomEvent(builder);
		}

		// Token: 0x060323CC RID: 205772 RVA: 0x006C97D9 File Offset: 0x006C79D9
		public static void StartIRunActorCustomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060323CD RID: 205773 RVA: 0x006C97E2 File Offset: 0x006C79E2
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x060323CE RID: 205774 RVA: 0x006C97F2 File Offset: 0x006C79F2
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x060323CF RID: 205775 RVA: 0x006C9802 File Offset: 0x006C7A02
		public static Offset<IRunActorCustomEvent> EndIRunActorCustomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRunActorCustomEvent>(builder.EndTable());
		}

		// Token: 0x060323D0 RID: 205776 RVA: 0x006C9810 File Offset: 0x006C7A10
		public IRunActorCustomEventT UnPack()
		{
			IRunActorCustomEventT runActorCustomEventT = new IRunActorCustomEventT();
			this.UnPackTo(runActorCustomEventT);
			return runActorCustomEventT;
		}

		// Token: 0x060323D1 RID: 205777 RVA: 0x006C982C File Offset: 0x006C7A2C
		public void UnPackTo(IRunActorCustomEventT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.EventName = this.EventName;
		}

		// Token: 0x060323D2 RID: 205778 RVA: 0x006C9874 File Offset: 0x006C7A74
		public static Offset<IRunActorCustomEvent> Pack(FlatBufferBuilder builder, IRunActorCustomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunActorCustomEvent>);
			}
			Offset<IActorRef> actorRefOffset = (_o.ActorRef == null) ? default(Offset<IActorRef>) : IActorRef.Pack(builder, _o.ActorRef);
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			return IRunActorCustomEvent.CreateIRunActorCustomEvent(builder, actorRefOffset, eventNameOffset);
		}

		// Token: 0x040118FC RID: 71932
		private Table __p;
	}
}
