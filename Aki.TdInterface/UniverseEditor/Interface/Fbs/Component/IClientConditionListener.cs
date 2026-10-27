using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA3 RID: 20387
	public struct IClientConditionListener : IFlatbufferObject
	{
		// Token: 0x17009398 RID: 37784
		// (get) Token: 0x060206DB RID: 132827 RVA: 0x00482F01 File Offset: 0x00481101
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060206DC RID: 132828 RVA: 0x00482F0E File Offset: 0x0048110E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060206DD RID: 132829 RVA: 0x00482F18 File Offset: 0x00481118
		public static IClientConditionListener GetRootAsIClientConditionListener(ByteBuffer _bb)
		{
			return IClientConditionListener.GetRootAsIClientConditionListener(_bb, default(IClientConditionListener));
		}

		// Token: 0x060206DE RID: 132830 RVA: 0x00482F34 File Offset: 0x00481134
		public static IClientConditionListener GetRootAsIClientConditionListener(ByteBuffer _bb, IClientConditionListener obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060206DF RID: 132831 RVA: 0x00482F51 File Offset: 0x00481151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060206E0 RID: 132832 RVA: 0x00482F60 File Offset: 0x00481160
		public IClientConditionListener __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009399 RID: 37785
		// (get) Token: 0x060206E1 RID: 132833 RVA: 0x00482F70 File Offset: 0x00481170
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

		// Token: 0x060206E2 RID: 132834 RVA: 0x00482FD0 File Offset: 0x004811D0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700939A RID: 37786
		// (get) Token: 0x060206E3 RID: 132835 RVA: 0x00483030 File Offset: 0x00481230
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

		// Token: 0x1700939B RID: 37787
		// (get) Token: 0x060206E4 RID: 132836 RVA: 0x0048305C File Offset: 0x0048125C
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

		// Token: 0x060206E5 RID: 132837 RVA: 0x00483093 File Offset: 0x00481293
		public Span<byte> GetSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060206E6 RID: 132838 RVA: 0x004830A2 File Offset: 0x004812A2
		public byte[] GetSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700939C RID: 37788
		// (get) Token: 0x060206E7 RID: 132839 RVA: 0x004830B0 File Offset: 0x004812B0
		public bool OnlyTriggerWhenConditionBecomesTrue
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700939D RID: 37789
		// (get) Token: 0x060206E8 RID: 132840 RVA: 0x004830F0 File Offset: 0x004812F0
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

		// Token: 0x060206E9 RID: 132841 RVA: 0x0048312D File Offset: 0x0048132D
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

		// Token: 0x060206EA RID: 132842 RVA: 0x00483161 File Offset: 0x00481361
		public static void StartIClientConditionListener(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060206EB RID: 132843 RVA: 0x0048316A File Offset: 0x0048136A
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060206EC RID: 132844 RVA: 0x0048317A File Offset: 0x0048137A
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x060206ED RID: 132845 RVA: 0x0048318C File Offset: 0x0048138C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060206EE RID: 132846 RVA: 0x004831CC File Offset: 0x004813CC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060206EF RID: 132847 RVA: 0x004831E6 File Offset: 0x004813E6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060206F0 RID: 132848 RVA: 0x00483204 File Offset: 0x00481404
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060206F1 RID: 132849 RVA: 0x0048321D File Offset: 0x0048141D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060206F2 RID: 132850 RVA: 0x00483228 File Offset: 0x00481428
		public static void AddSendSelfEvent(FlatBufferBuilder builder, StringOffset sendSelfEventOffset)
		{
			builder.AddOffset(2, sendSelfEventOffset.Value, 0);
		}

		// Token: 0x060206F3 RID: 132851 RVA: 0x00483238 File Offset: 0x00481438
		public static void AddOnlyTriggerWhenConditionBecomesTrue(FlatBufferBuilder builder, bool onlyTriggerWhenConditionBecomesTrue)
		{
			builder.AddBool(3, onlyTriggerWhenConditionBecomesTrue, false);
		}

		// Token: 0x060206F4 RID: 132852 RVA: 0x00483243 File Offset: 0x00481443
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060206F5 RID: 132853 RVA: 0x0048324E File Offset: 0x0048144E
		public static Offset<IClientConditionListener> EndIClientConditionListener(FlatBufferBuilder builder)
		{
			return new Offset<IClientConditionListener>(builder.EndTable());
		}

		// Token: 0x060206F6 RID: 132854 RVA: 0x0048325C File Offset: 0x0048145C
		public IClientConditionListenerT UnPack()
		{
			IClientConditionListenerT clientConditionListenerT = new IClientConditionListenerT();
			this.UnPackTo(clientConditionListenerT);
			return clientConditionListenerT;
		}

		// Token: 0x060206F7 RID: 132855 RVA: 0x00483278 File Offset: 0x00481478
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

		// Token: 0x060206F8 RID: 132856 RVA: 0x0048332C File Offset: 0x0048152C
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

		// Token: 0x0400DE73 RID: 56947
		private Table __p;
	}
}
