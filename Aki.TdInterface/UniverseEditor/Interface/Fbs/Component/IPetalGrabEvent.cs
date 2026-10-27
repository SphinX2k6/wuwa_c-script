using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005724 RID: 22308
	public struct IPetalGrabEvent : IFlatbufferObject
	{
		// Token: 0x1700A631 RID: 42545
		// (get) Token: 0x0602552A RID: 152874 RVA: 0x005265CD File Offset: 0x005247CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x005265DA File Offset: 0x005247DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602552C RID: 152876 RVA: 0x005265E4 File Offset: 0x005247E4
		public static IPetalGrabEvent GetRootAsIPetalGrabEvent(ByteBuffer _bb)
		{
			return IPetalGrabEvent.GetRootAsIPetalGrabEvent(_bb, default(IPetalGrabEvent));
		}

		// Token: 0x0602552D RID: 152877 RVA: 0x00526600 File Offset: 0x00524800
		public static IPetalGrabEvent GetRootAsIPetalGrabEvent(ByteBuffer _bb, IPetalGrabEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x0052661D File Offset: 0x0052481D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602552F RID: 152879 RVA: 0x0052662C File Offset: 0x0052482C
		public IPetalGrabEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A632 RID: 42546
		// (get) Token: 0x06025530 RID: 152880 RVA: 0x0052663C File Offset: 0x0052483C
		public EPetalGrabEventType EventType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPetalGrabEventType.Grabbed;
				}
				return (EPetalGrabEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A633 RID: 42547
		// (get) Token: 0x06025531 RID: 152881 RVA: 0x00526678 File Offset: 0x00524878
		public string State
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

		// Token: 0x06025532 RID: 152882 RVA: 0x005266AF File Offset: 0x005248AF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025533 RID: 152883 RVA: 0x005266BE File Offset: 0x005248BE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06025534 RID: 152884 RVA: 0x005266CC File Offset: 0x005248CC
		public static Offset<IPetalGrabEvent> CreateIPetalGrabEvent(FlatBufferBuilder builder, EPetalGrabEventType EventType = EPetalGrabEventType.Grabbed, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPetalGrabEvent.AddState(builder, StateOffset);
			IPetalGrabEvent.AddEventType(builder, EventType);
			return IPetalGrabEvent.EndIPetalGrabEvent(builder);
		}

		// Token: 0x06025535 RID: 152885 RVA: 0x005266E9 File Offset: 0x005248E9
		public static void StartIPetalGrabEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025536 RID: 152886 RVA: 0x005266F2 File Offset: 0x005248F2
		public static void AddEventType(FlatBufferBuilder builder, EPetalGrabEventType eventType)
		{
			builder.AddByte(0, (byte)eventType, 0);
		}

		// Token: 0x06025537 RID: 152887 RVA: 0x005266FD File Offset: 0x005248FD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06025538 RID: 152888 RVA: 0x0052670D File Offset: 0x0052490D
		public static Offset<IPetalGrabEvent> EndIPetalGrabEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabEvent>(builder.EndTable());
		}

		// Token: 0x06025539 RID: 152889 RVA: 0x0052671C File Offset: 0x0052491C
		public IPetalGrabEventT UnPack()
		{
			IPetalGrabEventT petalGrabEventT = new IPetalGrabEventT();
			this.UnPackTo(petalGrabEventT);
			return petalGrabEventT;
		}

		// Token: 0x0602553A RID: 152890 RVA: 0x00526737 File Offset: 0x00524937
		public void UnPackTo(IPetalGrabEventT _o)
		{
			_o.EventType = this.EventType;
			_o.State = this.State;
		}

		// Token: 0x0602553B RID: 152891 RVA: 0x00526754 File Offset: 0x00524954
		public static Offset<IPetalGrabEvent> Pack(FlatBufferBuilder builder, IPetalGrabEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabEvent>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IPetalGrabEvent.CreateIPetalGrabEvent(builder, _o.EventType, stateOffset);
		}

		// Token: 0x0400EB99 RID: 60313
		private Table __p;
	}
}
