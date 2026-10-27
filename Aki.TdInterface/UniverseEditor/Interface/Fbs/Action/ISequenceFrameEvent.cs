using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F81 RID: 28545
	public struct ISequenceFrameEvent : IFlatbufferObject
	{
		// Token: 0x1700D401 RID: 54273
		// (get) Token: 0x060326E4 RID: 206564 RVA: 0x006CE986 File Offset: 0x006CCB86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326E5 RID: 206565 RVA: 0x006CE993 File Offset: 0x006CCB93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326E6 RID: 206566 RVA: 0x006CE99C File Offset: 0x006CCB9C
		public static ISequenceFrameEvent GetRootAsISequenceFrameEvent(ByteBuffer _bb)
		{
			return ISequenceFrameEvent.GetRootAsISequenceFrameEvent(_bb, default(ISequenceFrameEvent));
		}

		// Token: 0x060326E7 RID: 206567 RVA: 0x006CE9B8 File Offset: 0x006CCBB8
		public static ISequenceFrameEvent GetRootAsISequenceFrameEvent(ByteBuffer _bb, ISequenceFrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326E8 RID: 206568 RVA: 0x006CE9D5 File Offset: 0x006CCBD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326E9 RID: 206569 RVA: 0x006CE9E4 File Offset: 0x006CCBE4
		public ISequenceFrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D402 RID: 54274
		// (get) Token: 0x060326EA RID: 206570 RVA: 0x006CE9F4 File Offset: 0x006CCBF4
		public string EventKey
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

		// Token: 0x060326EB RID: 206571 RVA: 0x006CEA2B File Offset: 0x006CCC2B
		public Span<byte> GetEventKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060326EC RID: 206572 RVA: 0x006CEA3A File Offset: 0x006CCC3A
		public byte[] GetEventKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060326ED RID: 206573 RVA: 0x006CEA48 File Offset: 0x006CCC48
		public IActionInfo? EventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D403 RID: 54275
		// (get) Token: 0x060326EE RID: 206574 RVA: 0x006CEAA8 File Offset: 0x006CCCA8
		public int EventActionsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060326EF RID: 206575 RVA: 0x006CEAD3 File Offset: 0x006CCCD3
		public static Offset<ISequenceFrameEvent> CreateISequenceFrameEvent(FlatBufferBuilder builder, StringOffset EventKeyOffset = default(StringOffset), VectorOffset EventActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISequenceFrameEvent.AddEventActions(builder, EventActionsOffset);
			ISequenceFrameEvent.AddEventKey(builder, EventKeyOffset);
			return ISequenceFrameEvent.EndISequenceFrameEvent(builder);
		}

		// Token: 0x060326F0 RID: 206576 RVA: 0x006CEAF0 File Offset: 0x006CCCF0
		public static void StartISequenceFrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060326F1 RID: 206577 RVA: 0x006CEAF9 File Offset: 0x006CCCF9
		public static void AddEventKey(FlatBufferBuilder builder, StringOffset eventKeyOffset)
		{
			builder.AddOffset(0, eventKeyOffset.Value, 0);
		}

		// Token: 0x060326F2 RID: 206578 RVA: 0x006CEB09 File Offset: 0x006CCD09
		public static void AddEventActions(FlatBufferBuilder builder, VectorOffset eventActionsOffset)
		{
			builder.AddOffset(1, eventActionsOffset.Value, 0);
		}

		// Token: 0x060326F3 RID: 206579 RVA: 0x006CEB1C File Offset: 0x006CCD1C
		public static VectorOffset CreateEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060326F4 RID: 206580 RVA: 0x006CEB5C File Offset: 0x006CCD5C
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060326F5 RID: 206581 RVA: 0x006CEB76 File Offset: 0x006CCD76
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060326F6 RID: 206582 RVA: 0x006CEB94 File Offset: 0x006CCD94
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060326F7 RID: 206583 RVA: 0x006CEBAD File Offset: 0x006CCDAD
		public static void StartEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060326F8 RID: 206584 RVA: 0x006CEBB8 File Offset: 0x006CCDB8
		public static Offset<ISequenceFrameEvent> EndISequenceFrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceFrameEvent>(builder.EndTable());
		}

		// Token: 0x060326F9 RID: 206585 RVA: 0x006CEBC8 File Offset: 0x006CCDC8
		public ISequenceFrameEventT UnPack()
		{
			ISequenceFrameEventT sequenceFrameEventT = new ISequenceFrameEventT();
			this.UnPackTo(sequenceFrameEventT);
			return sequenceFrameEventT;
		}

		// Token: 0x060326FA RID: 206586 RVA: 0x006CEBE4 File Offset: 0x006CCDE4
		public void UnPackTo(ISequenceFrameEventT _o)
		{
			_o.EventKey = this.EventKey;
			_o.EventActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EventActionsLength; i++)
			{
				_o.EventActions.Add((this.EventActions(i) != null) ? this.EventActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060326FB RID: 206587 RVA: 0x006CEC50 File Offset: 0x006CCE50
		public static Offset<ISequenceFrameEvent> Pack(FlatBufferBuilder builder, ISequenceFrameEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISequenceFrameEvent>);
			}
			StringOffset eventKeyOffset = (_o.EventKey == null) ? default(StringOffset) : builder.CreateString(_o.EventKey);
			VectorOffset eventActionsOffset = default(VectorOffset);
			if (_o.EventActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EventActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EventActions[i]);
				}
				eventActionsOffset = ISequenceFrameEvent.CreateEventActionsVector(builder, array);
			}
			return ISequenceFrameEvent.CreateISequenceFrameEvent(builder, eventKeyOffset, eventActionsOffset);
		}

		// Token: 0x0401197B RID: 72059
		private Table __p;
	}
}
