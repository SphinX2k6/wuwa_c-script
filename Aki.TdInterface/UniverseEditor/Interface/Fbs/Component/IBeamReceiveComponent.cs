using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005442 RID: 21570
	public struct IBeamReceiveComponent : IFlatbufferObject
	{
		// Token: 0x17009935 RID: 39221
		// (get) Token: 0x06021D44 RID: 138564 RVA: 0x004A9D27 File Offset: 0x004A7F27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D45 RID: 138565 RVA: 0x004A9D34 File Offset: 0x004A7F34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D46 RID: 138566 RVA: 0x004A9D3C File Offset: 0x004A7F3C
		public static IBeamReceiveComponent GetRootAsIBeamReceiveComponent(ByteBuffer _bb)
		{
			return IBeamReceiveComponent.GetRootAsIBeamReceiveComponent(_bb, default(IBeamReceiveComponent));
		}

		// Token: 0x06021D47 RID: 138567 RVA: 0x004A9D58 File Offset: 0x004A7F58
		public static IBeamReceiveComponent GetRootAsIBeamReceiveComponent(ByteBuffer _bb, IBeamReceiveComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D48 RID: 138568 RVA: 0x004A9D75 File Offset: 0x004A7F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D49 RID: 138569 RVA: 0x004A9D84 File Offset: 0x004A7F84
		public IBeamReceiveComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009936 RID: 39222
		// (get) Token: 0x06021D4A RID: 138570 RVA: 0x004A9D94 File Offset: 0x004A7F94
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009937 RID: 39223
		// (get) Token: 0x06021D4B RID: 138571 RVA: 0x004A9DD4 File Offset: 0x004A7FD4
		public string ReceiveTarget
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

		// Token: 0x06021D4C RID: 138572 RVA: 0x004A9E0B File Offset: 0x004A800B
		public Span<byte> GetReceiveTargetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021D4D RID: 138573 RVA: 0x004A9E1A File Offset: 0x004A801A
		public byte[] GetReceiveTargetArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009938 RID: 39224
		// (get) Token: 0x06021D4E RID: 138574 RVA: 0x004A9E28 File Offset: 0x004A8028
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009939 RID: 39225
		// (get) Token: 0x06021D4F RID: 138575 RVA: 0x004A9E68 File Offset: 0x004A8068
		public IConditionGroup? ReceiveCondition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06021D50 RID: 138576 RVA: 0x004A9EC8 File Offset: 0x004A80C8
		public IActionInfo? BeginActions(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700993A RID: 39226
		// (get) Token: 0x06021D51 RID: 138577 RVA: 0x004A9F2C File Offset: 0x004A812C
		public int BeginActionsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021D52 RID: 138578 RVA: 0x004A9F58 File Offset: 0x004A8158
		public IActionInfo? CompleteActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700993B RID: 39227
		// (get) Token: 0x06021D53 RID: 138579 RVA: 0x004A9FBC File Offset: 0x004A81BC
		public int CompleteActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021D54 RID: 138580 RVA: 0x004A9FE8 File Offset: 0x004A81E8
		public IActionInfo? StopActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700993C RID: 39228
		// (get) Token: 0x06021D55 RID: 138581 RVA: 0x004AA04C File Offset: 0x004A824C
		public int StopActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700993D RID: 39229
		// (get) Token: 0x06021D56 RID: 138582 RVA: 0x004AA078 File Offset: 0x004A8278
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021D57 RID: 138583 RVA: 0x004AA0B8 File Offset: 0x004A82B8
		public static Offset<IBeamReceiveComponent> CreateIBeamReceiveComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ReceiveTargetOffset = default(StringOffset), float Duration = 0f, Offset<IConditionGroup> ReceiveConditionOffset = default(Offset<IConditionGroup>), VectorOffset BeginActionsOffset = default(VectorOffset), VectorOffset CompleteActionsOffset = default(VectorOffset), VectorOffset StopActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IBeamReceiveComponent.AddStopActions(builder, StopActionsOffset);
			IBeamReceiveComponent.AddCompleteActions(builder, CompleteActionsOffset);
			IBeamReceiveComponent.AddBeginActions(builder, BeginActionsOffset);
			IBeamReceiveComponent.AddReceiveCondition(builder, ReceiveConditionOffset);
			IBeamReceiveComponent.AddDuration(builder, Duration);
			IBeamReceiveComponent.AddReceiveTarget(builder, ReceiveTargetOffset);
			IBeamReceiveComponent.AddNullMask(builder, NullMask);
			IBeamReceiveComponent.AddDisabled(builder, Disabled);
			return IBeamReceiveComponent.EndIBeamReceiveComponent(builder);
		}

		// Token: 0x06021D58 RID: 138584 RVA: 0x004AA10F File Offset: 0x004A830F
		public static void StartIBeamReceiveComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021D59 RID: 138585 RVA: 0x004AA118 File Offset: 0x004A8318
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021D5A RID: 138586 RVA: 0x004AA123 File Offset: 0x004A8323
		public static void AddReceiveTarget(FlatBufferBuilder builder, StringOffset receiveTargetOffset)
		{
			builder.AddOffset(1, receiveTargetOffset.Value, 0);
		}

		// Token: 0x06021D5B RID: 138587 RVA: 0x004AA133 File Offset: 0x004A8333
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06021D5C RID: 138588 RVA: 0x004AA146 File Offset: 0x004A8346
		public static void AddReceiveCondition(FlatBufferBuilder builder, Offset<IConditionGroup> receiveConditionOffset)
		{
			builder.AddOffset(3, receiveConditionOffset.Value, 0);
		}

		// Token: 0x06021D5D RID: 138589 RVA: 0x004AA156 File Offset: 0x004A8356
		public static void AddBeginActions(FlatBufferBuilder builder, VectorOffset beginActionsOffset)
		{
			builder.AddOffset(4, beginActionsOffset.Value, 0);
		}

		// Token: 0x06021D5E RID: 138590 RVA: 0x004AA168 File Offset: 0x004A8368
		public static VectorOffset CreateBeginActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D5F RID: 138591 RVA: 0x004AA1A8 File Offset: 0x004A83A8
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D60 RID: 138592 RVA: 0x004AA1C2 File Offset: 0x004A83C2
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D61 RID: 138593 RVA: 0x004AA1E0 File Offset: 0x004A83E0
		public static VectorOffset CreateBeginActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D62 RID: 138594 RVA: 0x004AA1F9 File Offset: 0x004A83F9
		public static void StartBeginActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D63 RID: 138595 RVA: 0x004AA204 File Offset: 0x004A8404
		public static void AddCompleteActions(FlatBufferBuilder builder, VectorOffset completeActionsOffset)
		{
			builder.AddOffset(5, completeActionsOffset.Value, 0);
		}

		// Token: 0x06021D64 RID: 138596 RVA: 0x004AA214 File Offset: 0x004A8414
		public static VectorOffset CreateCompleteActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D65 RID: 138597 RVA: 0x004AA254 File Offset: 0x004A8454
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D66 RID: 138598 RVA: 0x004AA26E File Offset: 0x004A846E
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D67 RID: 138599 RVA: 0x004AA28C File Offset: 0x004A848C
		public static VectorOffset CreateCompleteActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D68 RID: 138600 RVA: 0x004AA2A5 File Offset: 0x004A84A5
		public static void StartCompleteActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D69 RID: 138601 RVA: 0x004AA2B0 File Offset: 0x004A84B0
		public static void AddStopActions(FlatBufferBuilder builder, VectorOffset stopActionsOffset)
		{
			builder.AddOffset(6, stopActionsOffset.Value, 0);
		}

		// Token: 0x06021D6A RID: 138602 RVA: 0x004AA2C0 File Offset: 0x004A84C0
		public static VectorOffset CreateStopActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D6B RID: 138603 RVA: 0x004AA300 File Offset: 0x004A8500
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D6C RID: 138604 RVA: 0x004AA31A File Offset: 0x004A851A
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D6D RID: 138605 RVA: 0x004AA338 File Offset: 0x004A8538
		public static VectorOffset CreateStopActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D6E RID: 138606 RVA: 0x004AA351 File Offset: 0x004A8551
		public static void StartStopActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D6F RID: 138607 RVA: 0x004AA35C File Offset: 0x004A855C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06021D70 RID: 138608 RVA: 0x004AA367 File Offset: 0x004A8567
		public static Offset<IBeamReceiveComponent> EndIBeamReceiveComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBeamReceiveComponent>(builder.EndTable());
		}

		// Token: 0x06021D71 RID: 138609 RVA: 0x004AA374 File Offset: 0x004A8574
		public IBeamReceiveComponentT UnPack()
		{
			IBeamReceiveComponentT beamReceiveComponentT = new IBeamReceiveComponentT();
			this.UnPackTo(beamReceiveComponentT);
			return beamReceiveComponentT;
		}

		// Token: 0x06021D72 RID: 138610 RVA: 0x004AA390 File Offset: 0x004A8590
		public void UnPackTo(IBeamReceiveComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ReceiveTarget = this.ReceiveTarget;
			_o.Duration = this.Duration;
			_o.ReceiveCondition = ((this.ReceiveCondition != null) ? this.ReceiveCondition.Value.UnPack() : null);
			_o.BeginActions = new List<IActionInfoT>();
			for (int i = 0; i < this.BeginActionsLength; i++)
			{
				_o.BeginActions.Add((this.BeginActions(i) != null) ? this.BeginActions(i).Value.UnPack() : null);
			}
			_o.CompleteActions = new List<IActionInfoT>();
			for (int j = 0; j < this.CompleteActionsLength; j++)
			{
				_o.CompleteActions.Add((this.CompleteActions(j) != null) ? this.CompleteActions(j).Value.UnPack() : null);
			}
			_o.StopActions = new List<IActionInfoT>();
			for (int k = 0; k < this.StopActionsLength; k++)
			{
				_o.StopActions.Add((this.StopActions(k) != null) ? this.StopActions(k).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021D73 RID: 138611 RVA: 0x004AA504 File Offset: 0x004A8704
		public static Offset<IBeamReceiveComponent> Pack(FlatBufferBuilder builder, IBeamReceiveComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamReceiveComponent>);
			}
			StringOffset receiveTargetOffset = (_o.ReceiveTarget == null) ? default(StringOffset) : builder.CreateString(_o.ReceiveTarget);
			Offset<IConditionGroup> receiveConditionOffset = (_o.ReceiveCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ReceiveCondition);
			VectorOffset beginActionsOffset = default(VectorOffset);
			if (_o.BeginActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.BeginActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.BeginActions[i]);
				}
				beginActionsOffset = IBeamReceiveComponent.CreateBeginActionsVector(builder, array);
			}
			VectorOffset completeActionsOffset = default(VectorOffset);
			if (_o.CompleteActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.CompleteActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.CompleteActions[j]);
				}
				completeActionsOffset = IBeamReceiveComponent.CreateCompleteActionsVector(builder, array2);
			}
			VectorOffset stopActionsOffset = default(VectorOffset);
			if (_o.StopActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.StopActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.StopActions[k]);
				}
				stopActionsOffset = IBeamReceiveComponent.CreateStopActionsVector(builder, array3);
			}
			return IBeamReceiveComponent.CreateIBeamReceiveComponent(builder, _o.Disabled, receiveTargetOffset, _o.Duration, receiveConditionOffset, beginActionsOffset, completeActionsOffset, stopActionsOffset, _o.NullMask);
		}

		// Token: 0x0400E906 RID: 59654
		private Table __p;
	}
}
