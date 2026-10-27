using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE7 RID: 23271
	public struct ITriggerExitConfig : IFlatbufferObject
	{
		// Token: 0x1700AF7D RID: 44925
		// (get) Token: 0x06027B60 RID: 162656 RVA: 0x005766F9 File Offset: 0x005748F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027B61 RID: 162657 RVA: 0x00576706 File Offset: 0x00574906
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027B62 RID: 162658 RVA: 0x00576710 File Offset: 0x00574910
		public static ITriggerExitConfig GetRootAsITriggerExitConfig(ByteBuffer _bb)
		{
			return ITriggerExitConfig.GetRootAsITriggerExitConfig(_bb, default(ITriggerExitConfig));
		}

		// Token: 0x06027B63 RID: 162659 RVA: 0x0057672C File Offset: 0x0057492C
		public static ITriggerExitConfig GetRootAsITriggerExitConfig(ByteBuffer _bb, ITriggerExitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027B64 RID: 162660 RVA: 0x00576749 File Offset: 0x00574949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027B65 RID: 162661 RVA: 0x00576758 File Offset: 0x00574958
		public ITriggerExitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF7E RID: 44926
		// (get) Token: 0x06027B66 RID: 162662 RVA: 0x00576768 File Offset: 0x00574968
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

		// Token: 0x1700AF7F RID: 44927
		// (get) Token: 0x06027B67 RID: 162663 RVA: 0x005767A4 File Offset: 0x005749A4
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

		// Token: 0x1700AF80 RID: 44928
		// (get) Token: 0x06027B68 RID: 162664 RVA: 0x005767E0 File Offset: 0x005749E0
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

		// Token: 0x1700AF81 RID: 44929
		// (get) Token: 0x06027B69 RID: 162665 RVA: 0x00576840 File Offset: 0x00574A40
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

		// Token: 0x1700AF82 RID: 44930
		// (get) Token: 0x06027B6A RID: 162666 RVA: 0x00576880 File Offset: 0x00574A80
		public bool ExitByNotEnterCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027B6B RID: 162667 RVA: 0x005768C0 File Offset: 0x00574AC0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AF83 RID: 44931
		// (get) Token: 0x06027B6C RID: 162668 RVA: 0x00576924 File Offset: 0x00574B24
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

		// Token: 0x1700AF84 RID: 44932
		// (get) Token: 0x06027B6D RID: 162669 RVA: 0x00576950 File Offset: 0x00574B50
		public bool DisableExecuteActionsWhenDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF85 RID: 44933
		// (get) Token: 0x06027B6E RID: 162670 RVA: 0x00576990 File Offset: 0x00574B90
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

		// Token: 0x06027B6F RID: 162671 RVA: 0x005769D0 File Offset: 0x00574BD0
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

		// Token: 0x06027B70 RID: 162672 RVA: 0x00576A27 File Offset: 0x00574C27
		public static void StartITriggerExitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06027B71 RID: 162673 RVA: 0x00576A30 File Offset: 0x00574C30
		public static void AddExtraRange(FlatBufferBuilder builder, int extraRange)
		{
			builder.AddInt(0, extraRange, 0);
		}

		// Token: 0x06027B72 RID: 162674 RVA: 0x00576A3B File Offset: 0x00574C3B
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x06027B73 RID: 162675 RVA: 0x00576A46 File Offset: 0x00574C46
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06027B74 RID: 162676 RVA: 0x00576A56 File Offset: 0x00574C56
		public static void AddMatchTypeCount(FlatBufferBuilder builder, int matchTypeCount)
		{
			builder.AddInt(3, matchTypeCount, 0);
		}

		// Token: 0x06027B75 RID: 162677 RVA: 0x00576A61 File Offset: 0x00574C61
		public static void AddExitByNotEnterCondition(FlatBufferBuilder builder, bool exitByNotEnterCondition)
		{
			builder.AddBool(4, exitByNotEnterCondition, false);
		}

		// Token: 0x06027B76 RID: 162678 RVA: 0x00576A6C File Offset: 0x00574C6C
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x06027B77 RID: 162679 RVA: 0x00576A7C File Offset: 0x00574C7C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027B78 RID: 162680 RVA: 0x00576ABC File Offset: 0x00574CBC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B79 RID: 162681 RVA: 0x00576AD6 File Offset: 0x00574CD6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027B7A RID: 162682 RVA: 0x00576AF4 File Offset: 0x00574CF4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027B7B RID: 162683 RVA: 0x00576B0D File Offset: 0x00574D0D
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027B7C RID: 162684 RVA: 0x00576B18 File Offset: 0x00574D18
		public static void AddDisableExecuteActionsWhenDestroy(FlatBufferBuilder builder, bool disableExecuteActionsWhenDestroy)
		{
			builder.AddBool(6, disableExecuteActionsWhenDestroy, false);
		}

		// Token: 0x06027B7D RID: 162685 RVA: 0x00576B23 File Offset: 0x00574D23
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06027B7E RID: 162686 RVA: 0x00576B2E File Offset: 0x00574D2E
		public static Offset<ITriggerExitConfig> EndITriggerExitConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerExitConfig>(builder.EndTable());
		}

		// Token: 0x06027B7F RID: 162687 RVA: 0x00576B3C File Offset: 0x00574D3C
		public ITriggerExitConfigT UnPack()
		{
			ITriggerExitConfigT triggerExitConfigT = new ITriggerExitConfigT();
			this.UnPackTo(triggerExitConfigT);
			return triggerExitConfigT;
		}

		// Token: 0x06027B80 RID: 162688 RVA: 0x00576B58 File Offset: 0x00574D58
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

		// Token: 0x06027B81 RID: 162689 RVA: 0x00576C30 File Offset: 0x00574E30
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

		// Token: 0x0400F1D7 RID: 61911
		private Table __p;
	}
}
