using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F1 RID: 24817
	public struct ITriggeredConfig : IFlatbufferObject
	{
		// Token: 0x1700B8AE RID: 47278
		// (get) Token: 0x0602A0C4 RID: 172228 RVA: 0x005BD5E2 File Offset: 0x005BB7E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A0C5 RID: 172229 RVA: 0x005BD5EF File Offset: 0x005BB7EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A0C6 RID: 172230 RVA: 0x005BD5F8 File Offset: 0x005BB7F8
		public static ITriggeredConfig GetRootAsITriggeredConfig(ByteBuffer _bb)
		{
			return ITriggeredConfig.GetRootAsITriggeredConfig(_bb, default(ITriggeredConfig));
		}

		// Token: 0x0602A0C7 RID: 172231 RVA: 0x005BD614 File Offset: 0x005BB814
		public static ITriggeredConfig GetRootAsITriggeredConfig(ByteBuffer _bb, ITriggeredConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A0C8 RID: 172232 RVA: 0x005BD631 File Offset: 0x005BB831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A0C9 RID: 172233 RVA: 0x005BD640 File Offset: 0x005BB840
		public ITriggeredConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8AF RID: 47279
		// (get) Token: 0x0602A0CA RID: 172234 RVA: 0x005BD650 File Offset: 0x005BB850
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

		// Token: 0x1700B8B0 RID: 47280
		// (get) Token: 0x0602A0CB RID: 172235 RVA: 0x005BD6B0 File Offset: 0x005BB8B0
		public int MaxTriggerTimes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A0CC RID: 172236 RVA: 0x005BD6EC File Offset: 0x005BB8EC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B8B1 RID: 47281
		// (get) Token: 0x0602A0CD RID: 172237 RVA: 0x005BD74C File Offset: 0x005BB94C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B8B2 RID: 47282
		// (get) Token: 0x0602A0CE RID: 172238 RVA: 0x005BD778 File Offset: 0x005BB978
		public bool OnlineDisableTip
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8B3 RID: 47283
		// (get) Token: 0x0602A0CF RID: 172239 RVA: 0x005BD7B8 File Offset: 0x005BB9B8
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

		// Token: 0x0602A0D0 RID: 172240 RVA: 0x005BD7F5 File Offset: 0x005BB9F5
		public static Offset<ITriggeredConfig> CreateITriggeredConfig(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int MaxTriggerTimes = 0, VectorOffset ActionsOffset = default(VectorOffset), bool OnlineDisableTip = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggeredConfig.AddActions(builder, ActionsOffset);
			ITriggeredConfig.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			ITriggeredConfig.AddCondition(builder, ConditionOffset);
			ITriggeredConfig.AddNullMask(builder, NullMask);
			ITriggeredConfig.AddOnlineDisableTip(builder, OnlineDisableTip);
			return ITriggeredConfig.EndITriggeredConfig(builder);
		}

		// Token: 0x0602A0D1 RID: 172241 RVA: 0x005BD829 File Offset: 0x005BBA29
		public static void StartITriggeredConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A0D2 RID: 172242 RVA: 0x005BD832 File Offset: 0x005BBA32
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0602A0D3 RID: 172243 RVA: 0x005BD842 File Offset: 0x005BBA42
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x0602A0D4 RID: 172244 RVA: 0x005BD84D File Offset: 0x005BBA4D
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(2, actionsOffset.Value, 0);
		}

		// Token: 0x0602A0D5 RID: 172245 RVA: 0x005BD860 File Offset: 0x005BBA60
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A0D6 RID: 172246 RVA: 0x005BD8A0 File Offset: 0x005BBAA0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A0D7 RID: 172247 RVA: 0x005BD8BA File Offset: 0x005BBABA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A0D8 RID: 172248 RVA: 0x005BD8D8 File Offset: 0x005BBAD8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A0D9 RID: 172249 RVA: 0x005BD8F1 File Offset: 0x005BBAF1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A0DA RID: 172250 RVA: 0x005BD8FC File Offset: 0x005BBAFC
		public static void AddOnlineDisableTip(FlatBufferBuilder builder, bool onlineDisableTip)
		{
			builder.AddBool(3, onlineDisableTip, false);
		}

		// Token: 0x0602A0DB RID: 172251 RVA: 0x005BD907 File Offset: 0x005BBB07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A0DC RID: 172252 RVA: 0x005BD912 File Offset: 0x005BBB12
		public static Offset<ITriggeredConfig> EndITriggeredConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggeredConfig>(builder.EndTable());
		}

		// Token: 0x0602A0DD RID: 172253 RVA: 0x005BD920 File Offset: 0x005BBB20
		public ITriggeredConfigT UnPack()
		{
			ITriggeredConfigT triggeredConfigT = new ITriggeredConfigT();
			this.UnPackTo(triggeredConfigT);
			return triggeredConfigT;
		}

		// Token: 0x0602A0DE RID: 172254 RVA: 0x005BD93C File Offset: 0x005BBB3C
		public void UnPackTo(ITriggeredConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.OnlineDisableTip = this.OnlineDisableTip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A0DF RID: 172255 RVA: 0x005BD9F0 File Offset: 0x005BBBF0
		public static Offset<ITriggeredConfig> Pack(FlatBufferBuilder builder, ITriggeredConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggeredConfig>);
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
				actionsOffset = ITriggeredConfig.CreateActionsVector(builder, array);
			}
			return ITriggeredConfig.CreateITriggeredConfig(builder, conditionOffset, _o.MaxTriggerTimes, actionsOffset, _o.OnlineDisableTip, _o.NullMask);
		}

		// Token: 0x0400FECB RID: 65227
		private Table __p;
	}
}
