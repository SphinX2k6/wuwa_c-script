using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF8 RID: 23288
	public struct IMonitorComponent : IFlatbufferObject
	{
		// Token: 0x1700A9F2 RID: 43506
		// (get) Token: 0x0602642E RID: 156718 RVA: 0x0053E14E File Offset: 0x0053C34E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602642F RID: 156719 RVA: 0x0053E15B File Offset: 0x0053C35B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026430 RID: 156720 RVA: 0x0053E164 File Offset: 0x0053C364
		public static IMonitorComponent GetRootAsIMonitorComponent(ByteBuffer _bb)
		{
			return IMonitorComponent.GetRootAsIMonitorComponent(_bb, default(IMonitorComponent));
		}

		// Token: 0x06026431 RID: 156721 RVA: 0x0053E180 File Offset: 0x0053C380
		public static IMonitorComponent GetRootAsIMonitorComponent(ByteBuffer _bb, IMonitorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026432 RID: 156722 RVA: 0x0053E19D File Offset: 0x0053C39D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026433 RID: 156723 RVA: 0x0053E1AC File Offset: 0x0053C3AC
		public IMonitorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9F3 RID: 43507
		// (get) Token: 0x06026434 RID: 156724 RVA: 0x0053E1BC File Offset: 0x0053C3BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9F4 RID: 43508
		// (get) Token: 0x06026435 RID: 156725 RVA: 0x0053E1FC File Offset: 0x0053C3FC
		public IConeTriggerShape? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConeTriggerShape?(default(IConeTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A9F5 RID: 43509
		// (get) Token: 0x06026436 RID: 156726 RVA: 0x0053E25C File Offset: 0x0053C45C
		public string AttachPoint
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026437 RID: 156727 RVA: 0x0053E293 File Offset: 0x0053C493
		public Span<byte> GetAttachPointBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026438 RID: 156728 RVA: 0x0053E2A2 File Offset: 0x0053C4A2
		public byte[] GetAttachPointArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06026439 RID: 156729 RVA: 0x0053E2B0 File Offset: 0x0053C4B0
		public string AvailableStates(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A9F6 RID: 43510
		// (get) Token: 0x0602643A RID: 156730 RVA: 0x0053E2EC File Offset: 0x0053C4EC
		public int AvailableStatesLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A9F7 RID: 43511
		// (get) Token: 0x0602643B RID: 156731 RVA: 0x0053E318 File Offset: 0x0053C518
		public string StateAfterTriggered
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602643C RID: 156732 RVA: 0x0053E350 File Offset: 0x0053C550
		public Span<byte> GetStateAfterTriggeredBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602643D RID: 156733 RVA: 0x0053E360 File Offset: 0x0053C560
		public byte[] GetStateAfterTriggeredArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700A9F8 RID: 43512
		// (get) Token: 0x0602643E RID: 156734 RVA: 0x0053E370 File Offset: 0x0053C570
		public string StateAfterLeaved
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602643F RID: 156735 RVA: 0x0053E3A8 File Offset: 0x0053C5A8
		public Span<byte> GetStateAfterLeavedBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06026440 RID: 156736 RVA: 0x0053E3B8 File Offset: 0x0053C5B8
		public byte[] GetStateAfterLeavedArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700A9F9 RID: 43513
		// (get) Token: 0x06026441 RID: 156737 RVA: 0x0053E3C8 File Offset: 0x0053C5C8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026442 RID: 156738 RVA: 0x0053E408 File Offset: 0x0053C608
		public static Offset<IMonitorComponent> CreateIMonitorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConeTriggerShape> RangeOffset = default(Offset<IConeTriggerShape>), StringOffset AttachPointOffset = default(StringOffset), VectorOffset AvailableStatesOffset = default(VectorOffset), StringOffset StateAfterTriggeredOffset = default(StringOffset), StringOffset StateAfterLeavedOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IMonitorComponent.AddStateAfterLeaved(builder, StateAfterLeavedOffset);
			IMonitorComponent.AddStateAfterTriggered(builder, StateAfterTriggeredOffset);
			IMonitorComponent.AddAvailableStates(builder, AvailableStatesOffset);
			IMonitorComponent.AddAttachPoint(builder, AttachPointOffset);
			IMonitorComponent.AddRange(builder, RangeOffset);
			IMonitorComponent.AddNullMask(builder, NullMask);
			IMonitorComponent.AddDisabled(builder, Disabled);
			return IMonitorComponent.EndIMonitorComponent(builder);
		}

		// Token: 0x06026443 RID: 156739 RVA: 0x0053E457 File Offset: 0x0053C657
		public static void StartIMonitorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06026444 RID: 156740 RVA: 0x0053E460 File Offset: 0x0053C660
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026445 RID: 156741 RVA: 0x0053E46B File Offset: 0x0053C66B
		public static void AddRange(FlatBufferBuilder builder, Offset<IConeTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x06026446 RID: 156742 RVA: 0x0053E47B File Offset: 0x0053C67B
		public static void AddAttachPoint(FlatBufferBuilder builder, StringOffset attachPointOffset)
		{
			builder.AddOffset(2, attachPointOffset.Value, 0);
		}

		// Token: 0x06026447 RID: 156743 RVA: 0x0053E48B File Offset: 0x0053C68B
		public static void AddAvailableStates(FlatBufferBuilder builder, VectorOffset availableStatesOffset)
		{
			builder.AddOffset(3, availableStatesOffset.Value, 0);
		}

		// Token: 0x06026448 RID: 156744 RVA: 0x0053E49C File Offset: 0x0053C69C
		public static VectorOffset CreateAvailableStatesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026449 RID: 156745 RVA: 0x0053E4DC File Offset: 0x0053C6DC
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602644A RID: 156746 RVA: 0x0053E4F6 File Offset: 0x0053C6F6
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602644B RID: 156747 RVA: 0x0053E514 File Offset: 0x0053C714
		public static VectorOffset CreateAvailableStatesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602644C RID: 156748 RVA: 0x0053E52D File Offset: 0x0053C72D
		public static void StartAvailableStatesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602644D RID: 156749 RVA: 0x0053E538 File Offset: 0x0053C738
		public static void AddStateAfterTriggered(FlatBufferBuilder builder, StringOffset stateAfterTriggeredOffset)
		{
			builder.AddOffset(4, stateAfterTriggeredOffset.Value, 0);
		}

		// Token: 0x0602644E RID: 156750 RVA: 0x0053E548 File Offset: 0x0053C748
		public static void AddStateAfterLeaved(FlatBufferBuilder builder, StringOffset stateAfterLeavedOffset)
		{
			builder.AddOffset(5, stateAfterLeavedOffset.Value, 0);
		}

		// Token: 0x0602644F RID: 156751 RVA: 0x0053E558 File Offset: 0x0053C758
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06026450 RID: 156752 RVA: 0x0053E563 File Offset: 0x0053C763
		public static Offset<IMonitorComponent> EndIMonitorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IMonitorComponent>(builder.EndTable());
		}

		// Token: 0x06026451 RID: 156753 RVA: 0x0053E570 File Offset: 0x0053C770
		public IMonitorComponentT UnPack()
		{
			IMonitorComponentT monitorComponentT = new IMonitorComponentT();
			this.UnPackTo(monitorComponentT);
			return monitorComponentT;
		}

		// Token: 0x06026452 RID: 156754 RVA: 0x0053E58C File Offset: 0x0053C78C
		public void UnPackTo(IMonitorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.AttachPoint = this.AttachPoint;
			_o.AvailableStates = new List<string>();
			for (int i = 0; i < this.AvailableStatesLength; i++)
			{
				_o.AvailableStates.Add(this.AvailableStates(i));
			}
			_o.StateAfterTriggered = this.StateAfterTriggered;
			_o.StateAfterLeaved = this.StateAfterLeaved;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026453 RID: 156755 RVA: 0x0053E634 File Offset: 0x0053C834
		public static Offset<IMonitorComponent> Pack(FlatBufferBuilder builder, IMonitorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonitorComponent>);
			}
			Offset<IConeTriggerShape> rangeOffset = (_o.Range == null) ? default(Offset<IConeTriggerShape>) : IConeTriggerShape.Pack(builder, _o.Range);
			StringOffset attachPointOffset = (_o.AttachPoint == null) ? default(StringOffset) : builder.CreateString(_o.AttachPoint);
			VectorOffset availableStatesOffset = default(VectorOffset);
			if (_o.AvailableStates != null)
			{
				StringOffset[] array = new StringOffset[_o.AvailableStates.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.AvailableStates[i]);
				}
				availableStatesOffset = IMonitorComponent.CreateAvailableStatesVector(builder, array);
			}
			StringOffset stateAfterTriggeredOffset = (_o.StateAfterTriggered == null) ? default(StringOffset) : builder.CreateString(_o.StateAfterTriggered);
			StringOffset stateAfterLeavedOffset = (_o.StateAfterLeaved == null) ? default(StringOffset) : builder.CreateString(_o.StateAfterLeaved);
			return IMonitorComponent.CreateIMonitorComponent(builder, _o.Disabled, rangeOffset, attachPointOffset, availableStatesOffset, stateAfterTriggeredOffset, stateAfterLeavedOffset, _o.NullMask);
		}

		// Token: 0x0400F4D4 RID: 62676
		private Table __p;
	}
}
