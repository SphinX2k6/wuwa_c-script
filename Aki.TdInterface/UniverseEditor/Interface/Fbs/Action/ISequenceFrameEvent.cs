using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007747 RID: 30535
	public struct ISequenceFrameEvent : IFlatbufferObject
	{
		// Token: 0x1700DFD0 RID: 57296
		// (get) Token: 0x06035934 RID: 219444 RVA: 0x0072E33E File Offset: 0x0072C53E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035935 RID: 219445 RVA: 0x0072E34B File Offset: 0x0072C54B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035936 RID: 219446 RVA: 0x0072E354 File Offset: 0x0072C554
		public static ISequenceFrameEvent GetRootAsISequenceFrameEvent(ByteBuffer _bb)
		{
			return ISequenceFrameEvent.GetRootAsISequenceFrameEvent(_bb, default(ISequenceFrameEvent));
		}

		// Token: 0x06035937 RID: 219447 RVA: 0x0072E370 File Offset: 0x0072C570
		public static ISequenceFrameEvent GetRootAsISequenceFrameEvent(ByteBuffer _bb, ISequenceFrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035938 RID: 219448 RVA: 0x0072E38D File Offset: 0x0072C58D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035939 RID: 219449 RVA: 0x0072E39C File Offset: 0x0072C59C
		public ISequenceFrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFD1 RID: 57297
		// (get) Token: 0x0603593A RID: 219450 RVA: 0x0072E3AC File Offset: 0x0072C5AC
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

		// Token: 0x0603593B RID: 219451 RVA: 0x0072E3E3 File Offset: 0x0072C5E3
		public Span<byte> GetEventKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603593C RID: 219452 RVA: 0x0072E3F2 File Offset: 0x0072C5F2
		public byte[] GetEventKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0603593D RID: 219453 RVA: 0x0072E400 File Offset: 0x0072C600
		public IActionInfo? EventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DFD2 RID: 57298
		// (get) Token: 0x0603593E RID: 219454 RVA: 0x0072E460 File Offset: 0x0072C660
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

		// Token: 0x0603593F RID: 219455 RVA: 0x0072E48B File Offset: 0x0072C68B
		public static Offset<ISequenceFrameEvent> CreateISequenceFrameEvent(FlatBufferBuilder builder, StringOffset EventKeyOffset = default(StringOffset), VectorOffset EventActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISequenceFrameEvent.AddEventActions(builder, EventActionsOffset);
			ISequenceFrameEvent.AddEventKey(builder, EventKeyOffset);
			return ISequenceFrameEvent.EndISequenceFrameEvent(builder);
		}

		// Token: 0x06035940 RID: 219456 RVA: 0x0072E4A8 File Offset: 0x0072C6A8
		public static void StartISequenceFrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035941 RID: 219457 RVA: 0x0072E4B1 File Offset: 0x0072C6B1
		public static void AddEventKey(FlatBufferBuilder builder, StringOffset eventKeyOffset)
		{
			builder.AddOffset(0, eventKeyOffset.Value, 0);
		}

		// Token: 0x06035942 RID: 219458 RVA: 0x0072E4C1 File Offset: 0x0072C6C1
		public static void AddEventActions(FlatBufferBuilder builder, VectorOffset eventActionsOffset)
		{
			builder.AddOffset(1, eventActionsOffset.Value, 0);
		}

		// Token: 0x06035943 RID: 219459 RVA: 0x0072E4D4 File Offset: 0x0072C6D4
		public static VectorOffset CreateEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035944 RID: 219460 RVA: 0x0072E514 File Offset: 0x0072C714
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035945 RID: 219461 RVA: 0x0072E52E File Offset: 0x0072C72E
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06035946 RID: 219462 RVA: 0x0072E54C File Offset: 0x0072C74C
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035947 RID: 219463 RVA: 0x0072E565 File Offset: 0x0072C765
		public static void StartEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035948 RID: 219464 RVA: 0x0072E570 File Offset: 0x0072C770
		public static Offset<ISequenceFrameEvent> EndISequenceFrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISequenceFrameEvent>(builder.EndTable());
		}

		// Token: 0x06035949 RID: 219465 RVA: 0x0072E580 File Offset: 0x0072C780
		public ISequenceFrameEventT UnPack()
		{
			ISequenceFrameEventT sequenceFrameEventT = new ISequenceFrameEventT();
			this.UnPackTo(sequenceFrameEventT);
			return sequenceFrameEventT;
		}

		// Token: 0x0603594A RID: 219466 RVA: 0x0072E59C File Offset: 0x0072C79C
		public void UnPackTo(ISequenceFrameEventT _o)
		{
			_o.EventKey = this.EventKey;
			_o.EventActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EventActionsLength; i++)
			{
				_o.EventActions.Add((this.EventActions(i) != null) ? this.EventActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603594B RID: 219467 RVA: 0x0072E608 File Offset: 0x0072C808
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

		// Token: 0x0401295D RID: 76125
		private Table __p;
	}
}
