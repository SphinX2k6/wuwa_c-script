using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F4 RID: 24820
	public struct ITriggerExitConfig : IFlatbufferObject
	{
		// Token: 0x1700B8B9 RID: 47289
		// (get) Token: 0x0602A0EC RID: 172268 RVA: 0x005BDBBD File Offset: 0x005BBDBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A0ED RID: 172269 RVA: 0x005BDBCA File Offset: 0x005BBDCA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A0EE RID: 172270 RVA: 0x005BDBD4 File Offset: 0x005BBDD4
		public static ITriggerExitConfig GetRootAsITriggerExitConfig(ByteBuffer _bb)
		{
			return ITriggerExitConfig.GetRootAsITriggerExitConfig(_bb, default(ITriggerExitConfig));
		}

		// Token: 0x0602A0EF RID: 172271 RVA: 0x005BDBF0 File Offset: 0x005BBDF0
		public static ITriggerExitConfig GetRootAsITriggerExitConfig(ByteBuffer _bb, ITriggerExitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A0F0 RID: 172272 RVA: 0x005BDC0D File Offset: 0x005BBE0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A0F1 RID: 172273 RVA: 0x005BDC1C File Offset: 0x005BBE1C
		public ITriggerExitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8BA RID: 47290
		// (get) Token: 0x0602A0F2 RID: 172274 RVA: 0x005BDC2C File Offset: 0x005BBE2C
		public int ExtraRange
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8BB RID: 47291
		// (get) Token: 0x0602A0F3 RID: 172275 RVA: 0x005BDC68 File Offset: 0x005BBE68
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

		// Token: 0x1700B8BC RID: 47292
		// (get) Token: 0x0602A0F4 RID: 172276 RVA: 0x005BDCA4 File Offset: 0x005BBEA4
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B8BD RID: 47293
		// (get) Token: 0x0602A0F5 RID: 172277 RVA: 0x005BDD04 File Offset: 0x005BBF04
		public int MatchTypeCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B8BE RID: 47294
		// (get) Token: 0x0602A0F6 RID: 172278 RVA: 0x005BDD44 File Offset: 0x005BBF44
		public bool ExitByNotEnterCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602A0F7 RID: 172279 RVA: 0x005BDD84 File Offset: 0x005BBF84
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B8BF RID: 47295
		// (get) Token: 0x0602A0F8 RID: 172280 RVA: 0x005BDDE8 File Offset: 0x005BBFE8
		public int ActionsLength
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

		// Token: 0x1700B8C0 RID: 47296
		// (get) Token: 0x0602A0F9 RID: 172281 RVA: 0x005BDE14 File Offset: 0x005BC014
		public bool DisableExecuteActionsWhenDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8C1 RID: 47297
		// (get) Token: 0x0602A0FA RID: 172282 RVA: 0x005BDE54 File Offset: 0x005BC054
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

		// Token: 0x0602A0FB RID: 172283 RVA: 0x005BDE94 File Offset: 0x005BC094
		public static Offset<ITriggerExitConfig> CreateITriggerExitConfig(FlatBufferBuilder builder, int ExtraRange = 0, int MaxTriggerTimes = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int MatchTypeCount = 0, bool ExitByNotEnterCondition = false, VectorOffset ActionsOffset = default(VectorOffset), bool DisableExecuteActionsWhenDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			ITriggerExitConfig.AddActions(builder, ActionsOffset);
			ITriggerExitConfig.AddMatchTypeCount(builder, MatchTypeCount);
			ITriggerExitConfig.AddCondition(builder, ConditionOffset);
			ITriggerExitConfig.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			ITriggerExitConfig.AddExtraRange(builder, ExtraRange);
			ITriggerExitConfig.AddNullMask(builder, NullMask);
			ITriggerExitConfig.AddDisableExecuteActionsWhenDestroy(builder, DisableExecuteActionsWhenDestroy);
			ITriggerExitConfig.AddExitByNotEnterCondition(builder, ExitByNotEnterCondition);
			return ITriggerExitConfig.EndITriggerExitConfig(builder);
		}

		// Token: 0x0602A0FC RID: 172284 RVA: 0x005BDEEB File Offset: 0x005BC0EB
		public static void StartITriggerExitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602A0FD RID: 172285 RVA: 0x005BDEF4 File Offset: 0x005BC0F4
		public static void AddExtraRange(FlatBufferBuilder builder, int extraRange)
		{
			builder.AddInt(0, extraRange, 0);
		}

		// Token: 0x0602A0FE RID: 172286 RVA: 0x005BDEFF File Offset: 0x005BC0FF
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x0602A0FF RID: 172287 RVA: 0x005BDF0A File Offset: 0x005BC10A
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x0602A100 RID: 172288 RVA: 0x005BDF1A File Offset: 0x005BC11A
		public static void AddMatchTypeCount(FlatBufferBuilder builder, int matchTypeCount)
		{
			builder.AddInt(3, matchTypeCount, 0);
		}

		// Token: 0x0602A101 RID: 172289 RVA: 0x005BDF25 File Offset: 0x005BC125
		public static void AddExitByNotEnterCondition(FlatBufferBuilder builder, bool exitByNotEnterCondition)
		{
			builder.AddBool(4, exitByNotEnterCondition, false);
		}

		// Token: 0x0602A102 RID: 172290 RVA: 0x005BDF30 File Offset: 0x005BC130
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0602A103 RID: 172291 RVA: 0x005BDF40 File Offset: 0x005BC140
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A104 RID: 172292 RVA: 0x005BDF80 File Offset: 0x005BC180
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A105 RID: 172293 RVA: 0x005BDF9A File Offset: 0x005BC19A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A106 RID: 172294 RVA: 0x005BDFB8 File Offset: 0x005BC1B8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A107 RID: 172295 RVA: 0x005BDFD1 File Offset: 0x005BC1D1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A108 RID: 172296 RVA: 0x005BDFDC File Offset: 0x005BC1DC
		public static void AddDisableExecuteActionsWhenDestroy(FlatBufferBuilder builder, bool disableExecuteActionsWhenDestroy)
		{
			builder.AddBool(6, disableExecuteActionsWhenDestroy, false);
		}

		// Token: 0x0602A109 RID: 172297 RVA: 0x005BDFE7 File Offset: 0x005BC1E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602A10A RID: 172298 RVA: 0x005BDFF2 File Offset: 0x005BC1F2
		public static Offset<ITriggerExitConfig> EndITriggerExitConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerExitConfig>(builder.EndTable());
		}

		// Token: 0x0602A10B RID: 172299 RVA: 0x005BE000 File Offset: 0x005BC200
		public ITriggerExitConfigT UnPack()
		{
			ITriggerExitConfigT triggerExitConfigT = new ITriggerExitConfigT();
			this.UnPackTo(triggerExitConfigT);
			return triggerExitConfigT;
		}

		// Token: 0x0602A10C RID: 172300 RVA: 0x005BE01C File Offset: 0x005BC21C
		public void UnPackTo(ITriggerExitConfigT _o)
		{
			_o.ExtraRange = this.ExtraRange;
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.MatchTypeCount = this.MatchTypeCount;
			_o.ExitByNotEnterCondition = this.ExitByNotEnterCondition;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.DisableExecuteActionsWhenDestroy = this.DisableExecuteActionsWhenDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A10D RID: 172301 RVA: 0x005BE0F4 File Offset: 0x005BC2F4
		public static Offset<ITriggerExitConfig> Pack(FlatBufferBuilder builder, ITriggerExitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerExitConfig>);
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
				actionsOffset = ITriggerExitConfig.CreateActionsVector(builder, array);
			}
			return ITriggerExitConfig.CreateITriggerExitConfig(builder, _o.ExtraRange, _o.MaxTriggerTimes, conditionOffset, _o.MatchTypeCount, _o.ExitByNotEnterCondition, actionsOffset, _o.DisableExecuteActionsWhenDestroy, _o.NullMask);
		}

		// Token: 0x0400FED1 RID: 65233
		private Table __p;
	}
}
