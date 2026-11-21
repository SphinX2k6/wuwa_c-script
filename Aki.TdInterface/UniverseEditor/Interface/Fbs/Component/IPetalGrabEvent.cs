using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D2B RID: 23851
	public struct IPetalGrabEvent : IFlatbufferObject
	{
		// Token: 0x1700AF51 RID: 44881
		// (get) Token: 0x06027A39 RID: 162361 RVA: 0x0056C2D5 File Offset: 0x0056A4D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A3A RID: 162362 RVA: 0x0056C2E2 File Offset: 0x0056A4E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A3B RID: 162363 RVA: 0x0056C2EC File Offset: 0x0056A4EC
		public static IPetalGrabEvent GetRootAsIPetalGrabEvent(ByteBuffer _bb)
		{
			return IPetalGrabEvent.GetRootAsIPetalGrabEvent(_bb, default(IPetalGrabEvent));
		}

		// Token: 0x06027A3C RID: 162364 RVA: 0x0056C308 File Offset: 0x0056A508
		public static IPetalGrabEvent GetRootAsIPetalGrabEvent(ByteBuffer _bb, IPetalGrabEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A3D RID: 162365 RVA: 0x0056C325 File Offset: 0x0056A525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A3E RID: 162366 RVA: 0x0056C334 File Offset: 0x0056A534
		public IPetalGrabEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF52 RID: 44882
		// (get) Token: 0x06027A3F RID: 162367 RVA: 0x0056C344 File Offset: 0x0056A544
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

		// Token: 0x1700AF53 RID: 44883
		// (get) Token: 0x06027A40 RID: 162368 RVA: 0x0056C380 File Offset: 0x0056A580
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

		// Token: 0x06027A41 RID: 162369 RVA: 0x0056C3B7 File Offset: 0x0056A5B7
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027A42 RID: 162370 RVA: 0x0056C3C6 File Offset: 0x0056A5C6
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027A43 RID: 162371 RVA: 0x0056C3D4 File Offset: 0x0056A5D4
		public static Offset<IPetalGrabEvent> CreateIPetalGrabEvent(FlatBufferBuilder builder, EPetalGrabEventType EventType = EPetalGrabEventType.Grabbed, StringOffset StateOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPetalGrabEvent.AddState(builder, StateOffset);
			IPetalGrabEvent.AddEventType(builder, EventType);
			return IPetalGrabEvent.EndIPetalGrabEvent(builder);
		}

		// Token: 0x06027A44 RID: 162372 RVA: 0x0056C3F1 File Offset: 0x0056A5F1
		public static void StartIPetalGrabEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027A45 RID: 162373 RVA: 0x0056C3FA File Offset: 0x0056A5FA
		public static void AddEventType(FlatBufferBuilder builder, EPetalGrabEventType eventType)
		{
			builder.AddByte(0, (byte)eventType, 0);
		}

		// Token: 0x06027A46 RID: 162374 RVA: 0x0056C405 File Offset: 0x0056A605
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06027A47 RID: 162375 RVA: 0x0056C415 File Offset: 0x0056A615
		public static Offset<IPetalGrabEvent> EndIPetalGrabEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPetalGrabEvent>(builder.EndTable());
		}

		// Token: 0x06027A48 RID: 162376 RVA: 0x0056C424 File Offset: 0x0056A624
		public IPetalGrabEventT UnPack()
		{
			IPetalGrabEventT petalGrabEventT = new IPetalGrabEventT();
			this.UnPackTo(petalGrabEventT);
			return petalGrabEventT;
		}

		// Token: 0x06027A49 RID: 162377 RVA: 0x0056C43F File Offset: 0x0056A63F
		public void UnPackTo(IPetalGrabEventT _o)
		{
			_o.EventType = this.EventType;
			_o.State = this.State;
		}

		// Token: 0x06027A4A RID: 162378 RVA: 0x0056C45C File Offset: 0x0056A65C
		public static Offset<IPetalGrabEvent> Pack(FlatBufferBuilder builder, IPetalGrabEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPetalGrabEvent>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IPetalGrabEvent.CreateIPetalGrabEvent(builder, _o.EventType, stateOffset);
		}

		// Token: 0x0400F882 RID: 63618
		private Table __p;
	}
}
