using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FF RID: 21759
	public struct IClientConditionListener : IFlatbufferObject
	{
		// Token: 0x17009B70 RID: 39792
		// (get) Token: 0x060225CF RID: 140751 RVA: 0x004BC3E5 File Offset: 0x004BA5E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060225D0 RID: 140752 RVA: 0x004BC3F2 File Offset: 0x004BA5F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060225D1 RID: 140753 RVA: 0x004BC3FC File Offset: 0x004BA5FC
		public static IClientConditionListener GetRootAsIClientConditionListener(ByteBuffer _bb)
		{
			return IClientConditionListener.GetRootAsIClientConditionListener(_bb, default(IClientConditionListener));
		}

		// Token: 0x060225D2 RID: 140754 RVA: 0x004BC418 File Offset: 0x004BA618
		public static IClientConditionListener GetRootAsIClientConditionListener(ByteBuffer _bb, IClientConditionListener obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225D3 RID: 140755 RVA: 0x004BC435 File Offset: 0x004BA635
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225D4 RID: 140756 RVA: 0x004BC444 File Offset: 0x004BA644
		public IClientConditionListener __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B71 RID: 39793
		// (get) Token: 0x060225D5 RID: 140757 RVA: 0x004BC454 File Offset: 0x004BA654
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060225D6 RID: 140758 RVA: 0x004BC4B4 File Offset: 0x004BA6B4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B72 RID: 39794
		// (get) Token: 0x060225D7 RID: 140759 RVA: 0x004BC514 File Offset: 0x004BA714
		public int ActionsLength
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

		// Token: 0x17009B73 RID: 39795
		// (get) Token: 0x060225D8 RID: 140760 RVA: 0x004BC540 File Offset: 0x004BA740
		public string SendSelfEvent
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

		// Token: 0x060225D9 RID: 140761 RVA: 0x004BC577 File Offset: 0x004BA777
		public Span<byte> GetSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060225DA RID: 140762 RVA: 0x004BC586 File Offset: 0x004BA786
		public byte[] GetSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009B74 RID: 39796
		// (get) Token: 0x060225DB RID: 140763 RVA: 0x004BC594 File Offset: 0x004BA794
		public bool OnlyTriggerWhenConditionBecomesTrue
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009B75 RID: 39797
		// (get) Token: 0x060225DC RID: 140764 RVA: 0x004BC5D4 File Offset: 0x004BA7D4
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

		// Token: 0x060225DD RID: 140765 RVA: 0x004BC611 File Offset: 0x004BA811
		public static Offset<IClientConditionListener> CreateIClientConditionListener(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), StringOffset SendSelfEventOffset = default(StringOffset), bool OnlyTriggerWhenConditionBecomesTrue = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IClientConditionListener.AddSendSelfEvent(builder, SendSelfEventOffset);
			IClientConditionListener.AddActions(builder, ActionsOffset);
			IClientConditionListener.AddCondition(builder, ConditionOffset);
			IClientConditionListener.AddNullMask(builder, NullMask);
			IClientConditionListener.AddOnlyTriggerWhenConditionBecomesTrue(builder, OnlyTriggerWhenConditionBecomesTrue);
			return IClientConditionListener.EndIClientConditionListener(builder);
		}

		// Token: 0x060225DE RID: 140766 RVA: 0x004BC645 File Offset: 0x004BA845
		public static void StartIClientConditionListener(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060225DF RID: 140767 RVA: 0x004BC64E File Offset: 0x004BA84E
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060225E0 RID: 140768 RVA: 0x004BC65E File Offset: 0x004BA85E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060225E1 RID: 140769 RVA: 0x004BC670 File Offset: 0x004BA870
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060225E2 RID: 140770 RVA: 0x004BC6B0 File Offset: 0x004BA8B0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225E3 RID: 140771 RVA: 0x004BC6CA File Offset: 0x004BA8CA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060225E4 RID: 140772 RVA: 0x004BC6E8 File Offset: 0x004BA8E8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060225E5 RID: 140773 RVA: 0x004BC701 File Offset: 0x004BA901
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060225E6 RID: 140774 RVA: 0x004BC70C File Offset: 0x004BA90C
		public static void AddSendSelfEvent(FlatBufferBuilder builder, StringOffset sendSelfEventOffset)
		{
			builder.AddOffset(2, sendSelfEventOffset.Value, 0);
		}

		// Token: 0x060225E7 RID: 140775 RVA: 0x004BC71C File Offset: 0x004BA91C
		public static void AddOnlyTriggerWhenConditionBecomesTrue(FlatBufferBuilder builder, bool onlyTriggerWhenConditionBecomesTrue)
		{
			builder.AddBool(3, onlyTriggerWhenConditionBecomesTrue, false);
		}

		// Token: 0x060225E8 RID: 140776 RVA: 0x004BC727 File Offset: 0x004BA927
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060225E9 RID: 140777 RVA: 0x004BC732 File Offset: 0x004BA932
		public static Offset<IClientConditionListener> EndIClientConditionListener(FlatBufferBuilder builder)
		{
			return new Offset<IClientConditionListener>(builder.EndTable());
		}

		// Token: 0x060225EA RID: 140778 RVA: 0x004BC740 File Offset: 0x004BA940
		public IClientConditionListenerT UnPack()
		{
			IClientConditionListenerT clientConditionListenerT = new IClientConditionListenerT();
			this.UnPackTo(clientConditionListenerT);
			return clientConditionListenerT;
		}

		// Token: 0x060225EB RID: 140779 RVA: 0x004BC75C File Offset: 0x004BA95C
		public void UnPackTo(IClientConditionListenerT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.SendSelfEvent = this.SendSelfEvent;
			_o.OnlyTriggerWhenConditionBecomesTrue = this.OnlyTriggerWhenConditionBecomesTrue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060225EC RID: 140780 RVA: 0x004BC810 File Offset: 0x004BAA10
		public static Offset<IClientConditionListener> Pack(FlatBufferBuilder builder, IClientConditionListenerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientConditionListener>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IClientConditionListener.CreateActionsVector(builder, array);
			}
			StringOffset sendSelfEventOffset = (_o.SendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.SendSelfEvent);
			return IClientConditionListener.CreateIClientConditionListener(builder, conditionOffset, actionsOffset, sendSelfEventOffset, _o.OnlyTriggerWhenConditionBecomesTrue, _o.NullMask);
		}

		// Token: 0x0400EA61 RID: 60001
		private Table __p;
	}
}
