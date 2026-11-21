using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E57 RID: 20055
	public struct ICheckClientEvent : IFlatbufferObject
	{
		// Token: 0x17008EEF RID: 36591
		// (get) Token: 0x0601F093 RID: 127123 RVA: 0x00455104 File Offset: 0x00453304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F094 RID: 127124 RVA: 0x00455111 File Offset: 0x00453311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F095 RID: 127125 RVA: 0x00455118 File Offset: 0x00453318
		public static ICheckClientEvent GetRootAsICheckClientEvent(ByteBuffer _bb)
		{
			return ICheckClientEvent.GetRootAsICheckClientEvent(_bb, default(ICheckClientEvent));
		}

		// Token: 0x0601F096 RID: 127126 RVA: 0x00455134 File Offset: 0x00453334
		public static ICheckClientEvent GetRootAsICheckClientEvent(ByteBuffer _bb, ICheckClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F097 RID: 127127 RVA: 0x00455151 File Offset: 0x00453351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F098 RID: 127128 RVA: 0x00455160 File Offset: 0x00453360
		public ICheckClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EF0 RID: 36592
		// (get) Token: 0x0601F099 RID: 127129 RVA: 0x00455170 File Offset: 0x00453370
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EF1 RID: 36593
		// (get) Token: 0x0601F09A RID: 127130 RVA: 0x004551AC File Offset: 0x004533AC
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

		// Token: 0x0601F09B RID: 127131 RVA: 0x004551E3 File Offset: 0x004533E3
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601F09C RID: 127132 RVA: 0x004551F2 File Offset: 0x004533F2
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008EF2 RID: 36594
		// (get) Token: 0x0601F09D RID: 127133 RVA: 0x00455200 File Offset: 0x00453400
		public ISelfClientEvent? ListenerTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISelfClientEvent?(default(ISelfClientEvent).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601F09E RID: 127134 RVA: 0x0045525D File Offset: 0x0045345D
		public static Offset<ICheckClientEvent> CreateICheckClientEvent(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset EventNameOffset = default(StringOffset), Offset<ISelfClientEvent> ListenerTargetOffset = default(Offset<ISelfClientEvent>))
		{
			builder.StartTable(3);
			ICheckClientEvent.AddListenerTarget(builder, ListenerTargetOffset);
			ICheckClientEvent.AddEventName(builder, EventNameOffset);
			ICheckClientEvent.AddType(builder, Type);
			return ICheckClientEvent.EndICheckClientEvent(builder);
		}

		// Token: 0x0601F09F RID: 127135 RVA: 0x00455281 File Offset: 0x00453481
		public static void StartICheckClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601F0A0 RID: 127136 RVA: 0x0045528A File Offset: 0x0045348A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F0A1 RID: 127137 RVA: 0x00455295 File Offset: 0x00453495
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x0601F0A2 RID: 127138 RVA: 0x004552A5 File Offset: 0x004534A5
		public static void AddListenerTarget(FlatBufferBuilder builder, Offset<ISelfClientEvent> listenerTargetOffset)
		{
			builder.AddOffset(2, listenerTargetOffset.Value, 0);
		}

		// Token: 0x0601F0A3 RID: 127139 RVA: 0x004552B5 File Offset: 0x004534B5
		public static Offset<ICheckClientEvent> EndICheckClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClientEvent>(builder.EndTable());
		}

		// Token: 0x0601F0A4 RID: 127140 RVA: 0x004552C4 File Offset: 0x004534C4
		public ICheckClientEventT UnPack()
		{
			ICheckClientEventT checkClientEventT = new ICheckClientEventT();
			this.UnPackTo(checkClientEventT);
			return checkClientEventT;
		}

		// Token: 0x0601F0A5 RID: 127141 RVA: 0x004552E0 File Offset: 0x004534E0
		public void UnPackTo(ICheckClientEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.ListenerTarget = ((this.ListenerTarget != null) ? this.ListenerTarget.Value.UnPack() : null);
		}

		// Token: 0x0601F0A6 RID: 127142 RVA: 0x00455334 File Offset: 0x00453534
		public static Offset<ICheckClientEvent> Pack(FlatBufferBuilder builder, ICheckClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClientEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<ISelfClientEvent> listenerTargetOffset = (_o.ListenerTarget == null) ? default(Offset<ISelfClientEvent>) : ISelfClientEvent.Pack(builder, _o.ListenerTarget);
			return ICheckClientEvent.CreateICheckClientEvent(builder, _o.Type, eventNameOffset, listenerTargetOffset);
		}

		// Token: 0x0400DC80 RID: 56448
		private Table __p;
	}
}
