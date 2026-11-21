using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060EB RID: 24811
	public struct ITriggerComponent : IFlatbufferObject
	{
		// Token: 0x1700B88D RID: 47245
		// (get) Token: 0x0602A056 RID: 172118 RVA: 0x005BC448 File Offset: 0x005BA648
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A057 RID: 172119 RVA: 0x005BC455 File Offset: 0x005BA655
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A058 RID: 172120 RVA: 0x005BC45C File Offset: 0x005BA65C
		public static ITriggerComponent GetRootAsITriggerComponent(ByteBuffer _bb)
		{
			return ITriggerComponent.GetRootAsITriggerComponent(_bb, default(ITriggerComponent));
		}

		// Token: 0x0602A059 RID: 172121 RVA: 0x005BC478 File Offset: 0x005BA678
		public static ITriggerComponent GetRootAsITriggerComponent(ByteBuffer _bb, ITriggerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A05A RID: 172122 RVA: 0x005BC495 File Offset: 0x005BA695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A05B RID: 172123 RVA: 0x005BC4A4 File Offset: 0x005BA6A4
		public ITriggerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B88E RID: 47246
		// (get) Token: 0x0602A05C RID: 172124 RVA: 0x005BC4B4 File Offset: 0x005BA6B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B88F RID: 47247
		// (get) Token: 0x0602A05D RID: 172125 RVA: 0x005BC4F4 File Offset: 0x005BA6F4
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

		// Token: 0x1700B890 RID: 47248
		// (get) Token: 0x0602A05E RID: 172126 RVA: 0x005BC554 File Offset: 0x005BA754
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

		// Token: 0x1700B891 RID: 47249
		// (get) Token: 0x0602A05F RID: 172127 RVA: 0x005BC590 File Offset: 0x005BA790
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

		// Token: 0x1700B892 RID: 47250
		// (get) Token: 0x0602A060 RID: 172128 RVA: 0x005BC5D0 File Offset: 0x005BA7D0
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

		// Token: 0x0602A061 RID: 172129 RVA: 0x005BC630 File Offset: 0x005BA830
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B893 RID: 47251
		// (get) Token: 0x0602A062 RID: 172130 RVA: 0x005BC694 File Offset: 0x005BA894
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

		// Token: 0x1700B894 RID: 47252
		// (get) Token: 0x0602A063 RID: 172131 RVA: 0x005BC6C0 File Offset: 0x005BA8C0
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

		// Token: 0x0602A064 RID: 172132 RVA: 0x005BC720 File Offset: 0x005BA920
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B895 RID: 47253
		// (get) Token: 0x0602A065 RID: 172133 RVA: 0x005BC760 File Offset: 0x005BA960
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

		// Token: 0x0602A066 RID: 172134 RVA: 0x005BC78C File Offset: 0x005BA98C
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(18, 1);
		}

		// Token: 0x0602A067 RID: 172135 RVA: 0x005BC79C File Offset: 0x005BA99C
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

		// Token: 0x0602A068 RID: 172136 RVA: 0x005BC808 File Offset: 0x005BAA08
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B896 RID: 47254
		// (get) Token: 0x0602A069 RID: 172137 RVA: 0x005BC850 File Offset: 0x005BAA50
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

		// Token: 0x1700B897 RID: 47255
		// (get) Token: 0x0602A06A RID: 172138 RVA: 0x005BC87C File Offset: 0x005BAA7C
		public bool ChangeRoleTrigger
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B898 RID: 47256
		// (get) Token: 0x0602A06B RID: 172139 RVA: 0x005BC8BC File Offset: 0x005BAABC
		public bool ClientPrePerformance
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B899 RID: 47257
		// (get) Token: 0x0602A06C RID: 172140 RVA: 0x005BC8FC File Offset: 0x005BAAFC
		public bool OnlineDisableTip
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B89A RID: 47258
		// (get) Token: 0x0602A06D RID: 172141 RVA: 0x005BC93C File Offset: 0x005BAB3C
		public bool OnlineAutoExit
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B89B RID: 47259
		// (get) Token: 0x0602A06E RID: 172142 RVA: 0x005BC97C File Offset: 0x005BAB7C
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

		// Token: 0x0602A06F RID: 172143 RVA: 0x005BC9BC File Offset: 0x005BABBC
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

		// Token: 0x0602A070 RID: 172144 RVA: 0x005BCA44 File Offset: 0x005BAC44
		public static void StartITriggerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x0602A071 RID: 172145 RVA: 0x005BCA4E File Offset: 0x005BAC4E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A072 RID: 172146 RVA: 0x005BCA59 File Offset: 0x005BAC59
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(1, matchOffset.Value, 0);
		}

		// Token: 0x0602A073 RID: 172147 RVA: 0x005BCA69 File Offset: 0x005BAC69
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(2, maxTriggerTimes, 0);
		}

		// Token: 0x0602A074 RID: 172148 RVA: 0x005BCA74 File Offset: 0x005BAC74
		public static void AddMatchTypeCount(FlatBufferBuilder builder, int matchTypeCount)
		{
			builder.AddInt(3, matchTypeCount, 0);
		}

		// Token: 0x0602A075 RID: 172149 RVA: 0x005BCA7F File Offset: 0x005BAC7F
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(4, conditionOffset.Value, 0);
		}

		// Token: 0x0602A076 RID: 172150 RVA: 0x005BCA8F File Offset: 0x005BAC8F
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0602A077 RID: 172151 RVA: 0x005BCAA0 File Offset: 0x005BACA0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A078 RID: 172152 RVA: 0x005BCAE0 File Offset: 0x005BACE0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A079 RID: 172153 RVA: 0x005BCAFA File Offset: 0x005BACFA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A07A RID: 172154 RVA: 0x005BCB18 File Offset: 0x005BAD18
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A07B RID: 172155 RVA: 0x005BCB31 File Offset: 0x005BAD31
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A07C RID: 172156 RVA: 0x005BCB3C File Offset: 0x005BAD3C
		public static void AddExitConfig(FlatBufferBuilder builder, Offset<ITriggerExitConfig> exitConfigOffset)
		{
			builder.AddOffset(6, exitConfigOffset.Value, 0);
		}

		// Token: 0x0602A07D RID: 172157 RVA: 0x005BCB4C File Offset: 0x005BAD4C
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(7, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x0602A07E RID: 172158 RVA: 0x005BCB5C File Offset: 0x005BAD5C
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A07F RID: 172159 RVA: 0x005BCB93 File Offset: 0x005BAD93
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A080 RID: 172160 RVA: 0x005BCBAD File Offset: 0x005BADAD
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A081 RID: 172161 RVA: 0x005BCBCB File Offset: 0x005BADCB
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A082 RID: 172162 RVA: 0x005BCBE4 File Offset: 0x005BADE4
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602A083 RID: 172163 RVA: 0x005BCBEF File Offset: 0x005BADEF
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(8, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602A084 RID: 172164 RVA: 0x005BCC00 File Offset: 0x005BAE00
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602A085 RID: 172165 RVA: 0x005BCC37 File Offset: 0x005BAE37
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A086 RID: 172166 RVA: 0x005BCC51 File Offset: 0x005BAE51
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602A087 RID: 172167 RVA: 0x005BCC6F File Offset: 0x005BAE6F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602A088 RID: 172168 RVA: 0x005BCC88 File Offset: 0x005BAE88
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602A089 RID: 172169 RVA: 0x005BCC93 File Offset: 0x005BAE93
		public static void AddChangeRoleTrigger(FlatBufferBuilder builder, bool changeRoleTrigger)
		{
			builder.AddBool(9, changeRoleTrigger, false);
		}

		// Token: 0x0602A08A RID: 172170 RVA: 0x005BCC9F File Offset: 0x005BAE9F
		public static void AddClientPrePerformance(FlatBufferBuilder builder, bool clientPrePerformance)
		{
			builder.AddBool(10, clientPrePerformance, false);
		}

		// Token: 0x0602A08B RID: 172171 RVA: 0x005BCCAB File Offset: 0x005BAEAB
		public static void AddOnlineDisableTip(FlatBufferBuilder builder, bool onlineDisableTip)
		{
			builder.AddBool(11, onlineDisableTip, false);
		}

		// Token: 0x0602A08C RID: 172172 RVA: 0x005BCCB7 File Offset: 0x005BAEB7
		public static void AddOnlineAutoExit(FlatBufferBuilder builder, bool onlineAutoExit)
		{
			builder.AddBool(12, onlineAutoExit, false);
		}

		// Token: 0x0602A08D RID: 172173 RVA: 0x005BCCC3 File Offset: 0x005BAEC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(13, nullMask, 0);
		}

		// Token: 0x0602A08E RID: 172174 RVA: 0x005BCCCF File Offset: 0x005BAECF
		public static Offset<ITriggerComponent> EndITriggerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerComponent>(builder.EndTable());
		}

		// Token: 0x0602A08F RID: 172175 RVA: 0x005BCCDC File Offset: 0x005BAEDC
		public ITriggerComponentT UnPack()
		{
			ITriggerComponentT triggerComponentT = new ITriggerComponentT();
			this.UnPackTo(triggerComponentT);
			return triggerComponentT;
		}

		// Token: 0x0602A090 RID: 172176 RVA: 0x005BCCF8 File Offset: 0x005BAEF8
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
				switch (this.MatchRoleOptionType(j))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(j) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(j).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(j) != null) ? this.MatchRoleOption<IMatchPhantomRole>(j).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(j) != null) ? this.MatchRoleOption<IMatchPlayerRole>(j).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.ChangeRoleTrigger = this.ChangeRoleTrigger;
			_o.ClientPrePerformance = this.ClientPrePerformance;
			_o.OnlineDisableTip = this.OnlineDisableTip;
			_o.OnlineAutoExit = this.OnlineAutoExit;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A091 RID: 172177 RVA: 0x005BCF68 File Offset: 0x005BB168
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

		// Token: 0x0400FEBA RID: 65210
		private Table __p;
	}
}
