using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADE RID: 23262
	public struct ITriggerComponent : IFlatbufferObject
	{
		// Token: 0x1700AF51 RID: 44881
		// (get) Token: 0x06027ACA RID: 162506 RVA: 0x00574FCC File Offset: 0x005731CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027ACB RID: 162507 RVA: 0x00574FD9 File Offset: 0x005731D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027ACC RID: 162508 RVA: 0x00574FE0 File Offset: 0x005731E0
		public static ITriggerComponent GetRootAsITriggerComponent(ByteBuffer _bb)
		{
			return ITriggerComponent.GetRootAsITriggerComponent(_bb, default(ITriggerComponent));
		}

		// Token: 0x06027ACD RID: 162509 RVA: 0x00574FFC File Offset: 0x005731FC
		public static ITriggerComponent GetRootAsITriggerComponent(ByteBuffer _bb, ITriggerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027ACE RID: 162510 RVA: 0x00575019 File Offset: 0x00573219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027ACF RID: 162511 RVA: 0x00575028 File Offset: 0x00573228
		public ITriggerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF52 RID: 44882
		// (get) Token: 0x06027AD0 RID: 162512 RVA: 0x00575038 File Offset: 0x00573238
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF53 RID: 44883
		// (get) Token: 0x06027AD1 RID: 162513 RVA: 0x00575078 File Offset: 0x00573278
		public IEntityMatch? Match
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF54 RID: 44884
		// (get) Token: 0x06027AD2 RID: 162514 RVA: 0x005750D8 File Offset: 0x005732D8
		public int MaxTriggerTimes
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF55 RID: 44885
		// (get) Token: 0x06027AD3 RID: 162515 RVA: 0x00575114 File Offset: 0x00573314
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

		// Token: 0x1700AF56 RID: 44886
		// (get) Token: 0x06027AD4 RID: 162516 RVA: 0x00575154 File Offset: 0x00573354
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027AD5 RID: 162517 RVA: 0x005751B4 File Offset: 0x005733B4
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF57 RID: 44887
		// (get) Token: 0x06027AD6 RID: 162518 RVA: 0x00575218 File Offset: 0x00573418
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

		// Token: 0x1700AF58 RID: 44888
		// (get) Token: 0x06027AD7 RID: 162519 RVA: 0x00575244 File Offset: 0x00573444
		public ITriggerExitConfig? ExitConfig
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new ITriggerExitConfig?(default(ITriggerExitConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027AD8 RID: 162520 RVA: 0x005752A4 File Offset: 0x005734A4
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700AF59 RID: 44889
		// (get) Token: 0x06027AD9 RID: 162521 RVA: 0x005752E4 File Offset: 0x005734E4
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027ADA RID: 162522 RVA: 0x00575310 File Offset: 0x00573510
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(18, 1);
		}

		// Token: 0x06027ADB RID: 162523 RVA: 0x00575320 File Offset: 0x00573520
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06027ADC RID: 162524 RVA: 0x0057538C File Offset: 0x0057358C
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700AF5A RID: 44890
		// (get) Token: 0x06027ADD RID: 162525 RVA: 0x005753D4 File Offset: 0x005735D4
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700AF5B RID: 44891
		// (get) Token: 0x06027ADE RID: 162526 RVA: 0x00575400 File Offset: 0x00573600
		public bool ChangeRoleTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF5C RID: 44892
		// (get) Token: 0x06027ADF RID: 162527 RVA: 0x00575440 File Offset: 0x00573640
		public bool ClientPrePerformance
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF5D RID: 44893
		// (get) Token: 0x06027AE0 RID: 162528 RVA: 0x00575480 File Offset: 0x00573680
		public bool OnlineDisableTip
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF5E RID: 44894
		// (get) Token: 0x06027AE1 RID: 162529 RVA: 0x005754C0 File Offset: 0x005736C0
		public bool OnlineAutoExit
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF5F RID: 44895
		// (get) Token: 0x06027AE2 RID: 162530 RVA: 0x00575500 File Offset: 0x00573700
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027AE3 RID: 162531 RVA: 0x00575540 File Offset: 0x00573740
		public static Offset<ITriggerComponent> CreateITriggerComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), int MaxTriggerTimes = 0, int MatchTypeCount = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), Offset<ITriggerExitConfig> ExitConfigOffset = default(Offset<ITriggerExitConfig>), VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), bool ChangeRoleTrigger = false, bool ClientPrePerformance = false, bool OnlineDisableTip = false, bool OnlineAutoExit = false, byte NullMask = 0)
		{
			builder.StartTable(14);
			ITriggerComponent.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			ITriggerComponent.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			ITriggerComponent.AddExitConfig(builder, ExitConfigOffset);
			ITriggerComponent.AddActions(builder, ActionsOffset);
			ITriggerComponent.AddCondition(builder, ConditionOffset);
			ITriggerComponent.AddMatchTypeCount(builder, MatchTypeCount);
			ITriggerComponent.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			ITriggerComponent.AddMatch(builder, MatchOffset);
			ITriggerComponent.AddNullMask(builder, NullMask);
			ITriggerComponent.AddOnlineAutoExit(builder, OnlineAutoExit);
			ITriggerComponent.AddOnlineDisableTip(builder, OnlineDisableTip);
			ITriggerComponent.AddClientPrePerformance(builder, ClientPrePerformance);
			ITriggerComponent.AddChangeRoleTrigger(builder, ChangeRoleTrigger);
			ITriggerComponent.AddDisabled(builder, Disabled);
			return ITriggerComponent.EndITriggerComponent(builder);
		}

		// Token: 0x06027AE4 RID: 162532 RVA: 0x005755C8 File Offset: 0x005737C8
		public static void StartITriggerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06027AE5 RID: 162533 RVA: 0x005755D2 File Offset: 0x005737D2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027AE6 RID: 162534 RVA: 0x005755DD File Offset: 0x005737DD
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(1, matchOffset.Value, 0);
		}

		// Token: 0x06027AE7 RID: 162535 RVA: 0x005755ED File Offset: 0x005737ED
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(2, maxTriggerTimes, 0);
		}

		// Token: 0x06027AE8 RID: 162536 RVA: 0x005755F8 File Offset: 0x005737F8
		public static void AddMatchTypeCount(FlatBufferBuilder builder, int matchTypeCount)
		{
			builder.AddInt(3, matchTypeCount, 0);
		}

		// Token: 0x06027AE9 RID: 162537 RVA: 0x00575603 File Offset: 0x00573803
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(4, conditionOffset.Value, 0);
		}

		// Token: 0x06027AEA RID: 162538 RVA: 0x00575613 File Offset: 0x00573813
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x06027AEB RID: 162539 RVA: 0x00575624 File Offset: 0x00573824
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027AEC RID: 162540 RVA: 0x00575664 File Offset: 0x00573864
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AED RID: 162541 RVA: 0x0057567E File Offset: 0x0057387E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AEE RID: 162542 RVA: 0x0057569C File Offset: 0x0057389C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027AEF RID: 162543 RVA: 0x005756B5 File Offset: 0x005738B5
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027AF0 RID: 162544 RVA: 0x005756C0 File Offset: 0x005738C0
		public static void AddExitConfig(FlatBufferBuilder builder, Offset<ITriggerExitConfig> exitConfigOffset)
		{
			builder.AddOffset(6, exitConfigOffset.Value, 0);
		}

		// Token: 0x06027AF1 RID: 162545 RVA: 0x005756D0 File Offset: 0x005738D0
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(7, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06027AF2 RID: 162546 RVA: 0x005756E0 File Offset: 0x005738E0
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027AF3 RID: 162547 RVA: 0x00575717 File Offset: 0x00573917
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AF4 RID: 162548 RVA: 0x00575731 File Offset: 0x00573931
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AF5 RID: 162549 RVA: 0x0057574F File Offset: 0x0057394F
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027AF6 RID: 162550 RVA: 0x00575768 File Offset: 0x00573968
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06027AF7 RID: 162551 RVA: 0x00575773 File Offset: 0x00573973
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(8, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x06027AF8 RID: 162552 RVA: 0x00575784 File Offset: 0x00573984
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027AF9 RID: 162553 RVA: 0x005757BB File Offset: 0x005739BB
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AFA RID: 162554 RVA: 0x005757D5 File Offset: 0x005739D5
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027AFB RID: 162555 RVA: 0x005757F3 File Offset: 0x005739F3
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027AFC RID: 162556 RVA: 0x0057580C File Offset: 0x00573A0C
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027AFD RID: 162557 RVA: 0x00575817 File Offset: 0x00573A17
		public static void AddChangeRoleTrigger(FlatBufferBuilder builder, bool changeRoleTrigger)
		{
			builder.AddBool(9, changeRoleTrigger, false);
		}

		// Token: 0x06027AFE RID: 162558 RVA: 0x00575823 File Offset: 0x00573A23
		public static void AddClientPrePerformance(FlatBufferBuilder builder, bool clientPrePerformance)
		{
			builder.AddBool(10, clientPrePerformance, false);
		}

		// Token: 0x06027AFF RID: 162559 RVA: 0x0057582F File Offset: 0x00573A2F
		public static void AddOnlineDisableTip(FlatBufferBuilder builder, bool onlineDisableTip)
		{
			builder.AddBool(11, onlineDisableTip, false);
		}

		// Token: 0x06027B00 RID: 162560 RVA: 0x0057583B File Offset: 0x00573A3B
		public static void AddOnlineAutoExit(FlatBufferBuilder builder, bool onlineAutoExit)
		{
			builder.AddBool(12, onlineAutoExit, false);
		}

		// Token: 0x06027B01 RID: 162561 RVA: 0x00575847 File Offset: 0x00573A47
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x06027B02 RID: 162562 RVA: 0x00575853 File Offset: 0x00573A53
		public static Offset<ITriggerComponent> EndITriggerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerComponent>(builder.EndTable());
		}

		// Token: 0x06027B03 RID: 162563 RVA: 0x00575860 File Offset: 0x00573A60
		public ITriggerComponentT UnPack()
		{
			ITriggerComponentT triggerComponentT = new ITriggerComponentT();
			this.UnPackTo(triggerComponentT);
			return triggerComponentT;
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x0057587C File Offset: 0x00573A7C
		public void UnPackTo(ITriggerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Match = ((this.Match != null) ? this.Match.Value.UnPack() : null);
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.MatchTypeCount = this.MatchTypeCount;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.ExitConfig = ((this.ExitConfig != null) ? this.ExitConfig.Value.UnPack() : null);
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int j = 0; j < this.MatchRoleOptionLength; j++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(j);
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(j);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(j) != null) ? this.MatchRoleOption<IMatchPlayerRole>(j).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(j) != null) ? this.MatchRoleOption<IMatchPhantomRole>(j).Value.UnPack() : null);
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.ChangeRoleTrigger = this.ChangeRoleTrigger;
			_o.ClientPrePerformance = this.ClientPrePerformance;
			_o.OnlineDisableTip = this.OnlineDisableTip;
			_o.OnlineAutoExit = this.OnlineAutoExit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027B05 RID: 162565 RVA: 0x00575AA4 File Offset: 0x00573CA4
		public static Offset<ITriggerComponent> Pack(FlatBufferBuilder builder, ITriggerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerComponent>);
			}
			Offset<IEntityMatch> matchOffset = (_o.Match == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.Match);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITriggerComponent.CreateActionsVector(builder, array);
			}
			Offset<ITriggerExitConfig> exitConfigOffset = (_o.ExitConfig == null) ? default(Offset<ITriggerExitConfig>) : ITriggerExitConfig.Pack(builder, _o.ExitConfig);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array2 = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = _o.MatchRoleOption[j].Type;
				}
				matchRoleOption_typeOffset = ITriggerComponent.CreateMatchRoleOptionTypeVector(builder, array2);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array3 = new int[_o.MatchRoleOption.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[k]);
				}
				matchRoleOptionOffset = ITriggerComponent.CreateMatchRoleOptionVector(builder, array3);
			}
			return ITriggerComponent.CreateITriggerComponent(builder, _o.Disabled, matchOffset, _o.MaxTriggerTimes, _o.MatchTypeCount, conditionOffset, actionsOffset, exitConfigOffset, matchRoleOption_typeOffset, matchRoleOptionOffset, _o.ChangeRoleTrigger, _o.ClientPrePerformance, _o.OnlineDisableTip, _o.OnlineAutoExit, _o.NullMask);
		}

		// Token: 0x0400F1C0 RID: 61888
		private Table __p;
	}
}
