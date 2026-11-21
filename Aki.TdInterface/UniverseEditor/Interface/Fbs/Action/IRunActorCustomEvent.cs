using System;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007699 RID: 30361
	public struct IRunActorCustomEvent : IFlatbufferObject
	{
		// Token: 0x1700DEBF RID: 57023
		// (get) Token: 0x06035419 RID: 218137 RVA: 0x00725603 File Offset: 0x00723803
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603541A RID: 218138 RVA: 0x00725610 File Offset: 0x00723810
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603541B RID: 218139 RVA: 0x00725618 File Offset: 0x00723818
		public static IRunActorCustomEvent GetRootAsIRunActorCustomEvent(ByteBuffer _bb)
		{
			return IRunActorCustomEvent.GetRootAsIRunActorCustomEvent(_bb, default(IRunActorCustomEvent));
		}

		// Token: 0x0603541C RID: 218140 RVA: 0x00725634 File Offset: 0x00723834
		public static IRunActorCustomEvent GetRootAsIRunActorCustomEvent(ByteBuffer _bb, IRunActorCustomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603541D RID: 218141 RVA: 0x00725651 File Offset: 0x00723851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603541E RID: 218142 RVA: 0x00725660 File Offset: 0x00723860
		public IRunActorCustomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEC0 RID: 57024
		// (get) Token: 0x0603541F RID: 218143 RVA: 0x00725670 File Offset: 0x00723870
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

		// Token: 0x1700DEC1 RID: 57025
		// (get) Token: 0x06035420 RID: 218144 RVA: 0x007256D0 File Offset: 0x007238D0
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

		// Token: 0x06035421 RID: 218145 RVA: 0x00725707 File Offset: 0x00723907
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06035422 RID: 218146 RVA: 0x00725716 File Offset: 0x00723916
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06035423 RID: 218147 RVA: 0x00725724 File Offset: 0x00723924
		public static Offset<IRunActorCustomEvent> CreateIRunActorCustomEvent(FlatBufferBuilder builder, Offset<IActorRef> ActorRefOffset = default(Offset<IActorRef>), StringOffset EventNameOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRunActorCustomEvent.AddEventName(builder, EventNameOffset);
			IRunActorCustomEvent.AddActorRef(builder, ActorRefOffset);
			return IRunActorCustomEvent.EndIRunActorCustomEvent(builder);
		}

		// Token: 0x06035424 RID: 218148 RVA: 0x00725741 File Offset: 0x00723941
		public static void StartIRunActorCustomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035425 RID: 218149 RVA: 0x0072574A File Offset: 0x0072394A
		public static void AddActorRef(FlatBufferBuilder builder, Offset<IActorRef> actorRefOffset)
		{
			builder.AddOffset(0, actorRefOffset.Value, 0);
		}

		// Token: 0x06035426 RID: 218150 RVA: 0x0072575A File Offset: 0x0072395A
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x06035427 RID: 218151 RVA: 0x0072576A File Offset: 0x0072396A
		public static Offset<IRunActorCustomEvent> EndIRunActorCustomEvent(FlatBufferBuilder builder)
		{
			return new Offset<IRunActorCustomEvent>(builder.EndTable());
		}

		// Token: 0x06035428 RID: 218152 RVA: 0x00725778 File Offset: 0x00723978
		public IRunActorCustomEventT UnPack()
		{
			IRunActorCustomEventT runActorCustomEventT = new IRunActorCustomEventT();
			this.UnPackTo(runActorCustomEventT);
			return runActorCustomEventT;
		}

		// Token: 0x06035429 RID: 218153 RVA: 0x00725794 File Offset: 0x00723994
		public void UnPackTo(IRunActorCustomEventT _o)
		{
			_o.ActorRef = ((this.ActorRef != null) ? this.ActorRef.Value.UnPack() : null);
			_o.EventName = this.EventName;
		}

		// Token: 0x0603542A RID: 218154 RVA: 0x007257DC File Offset: 0x007239DC
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

		// Token: 0x04012884 RID: 75908
		private Table __p;
	}
}
