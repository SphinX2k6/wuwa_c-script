using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC8 RID: 16328
	[NullableContext(1)]
	[Nullable(0)]
	internal class OptionReadGraph
	{
		// Token: 0x06029498 RID: 169112 RVA: 0x00B99488 File Offset: 0x00B97688
		[NullableContext(2)]
		public OptionReadGraph(ShowTalk config)
		{
			this.ShowTalk = config;
		}

		// Token: 0x06029499 RID: 169113 RVA: 0x00B994E4 File Offset: 0x00B976E4
		public void Init()
		{
			this.InitNodes();
			this.BuildGraph();
		}

		// Token: 0x0602949A RID: 169114 RVA: 0x00B994F4 File Offset: 0x00B976F4
		public bool IsOptionEntryFullyRead(int talkId, int optionIndex, Dictionary<int, HashSet<int>> grayOptionMap, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition)
		{
			int? optionNodeIndex = this.GetOptionNodeIndex(talkId, optionIndex);
			return optionNodeIndex != null && this.IsOptionNodeFullyRead(optionNodeIndex.Value, grayOptionMap, checkOptionCondition, new HashSet<int>());
		}

		// Token: 0x0602949B RID: 169115 RVA: 0x00B9952C File Offset: 0x00B9772C
		private void InitNodes()
		{
			ShowTalk showTalk = this.ShowTalk;
			if (((showTalk != null) ? showTalk.TalkItems : null) == null)
			{
				return;
			}
			for (int i = 0; i < showTalk.TalkItems.Count; i++)
			{
				ITalkItem talkItem = showTalk.TalkItems[i];
				this.TalkItemIndexById[talkItem.Id] = i;
				if (talkItem.Options != null && talkItem.Options.Count != 0)
				{
					int count = this.Groups.Count;
					OptionReadGroup optionReadGroup = new OptionReadGroup(talkItem, i);
					this.Groups.Add(optionReadGroup);
					this.GroupIndexByTalkItemId[talkItem.Id] = count;
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					this.OptionNodeIndexByTalkItemId[talkItem.Id] = dictionary;
					for (int j = 0; j < talkItem.Options.Count; j++)
					{
						OptionReadNode item = new OptionReadNode(talkItem.Id, j);
						int count2 = this.Options.Count;
						this.Options.Add(item);
						optionReadGroup.OptionNodeIndices.Add(count2);
						dictionary[j] = count2;
					}
				}
			}
		}

		// Token: 0x0602949C RID: 169116 RVA: 0x00B99650 File Offset: 0x00B97850
		private void BuildGraph()
		{
			ShowTalk showTalk = this.ShowTalk;
			if (((showTalk != null) ? showTalk.TalkItems : null) == null || this.ShowTalk.TalkItems.Count == 0)
			{
				return;
			}
			foreach (int groupIndex in this.GetNextOptionGroupIndices(new List<int>
			{
				0
			}, new HashSet<int>()))
			{
				this.BuildGroup(groupIndex, new HashSet<int>());
			}
			for (int i = 0; i < this.Groups.Count; i++)
			{
				this.BuildGroup(i, new HashSet<int>());
			}
		}

		// Token: 0x0602949D RID: 169117 RVA: 0x00B99704 File Offset: 0x00B97904
		private void BuildGroup(int groupIndex, HashSet<int> groupStack)
		{
			if (groupStack.Contains(groupIndex) || this.BuiltGroupIndices.Contains(groupIndex))
			{
				return;
			}
			if (groupIndex < 0 || groupIndex >= this.Groups.Count)
			{
				return;
			}
			OptionReadGroup optionReadGroup = this.Groups[groupIndex];
			groupStack.Add(groupIndex);
			foreach (int optionNodeIndex in optionReadGroup.OptionNodeIndices)
			{
				this.BuildOptionNode(optionNodeIndex, optionReadGroup, groupStack);
			}
			groupStack.Remove(groupIndex);
			this.BuiltGroupIndices.Add(groupIndex);
		}

		// Token: 0x0602949E RID: 169118 RVA: 0x00B997B0 File Offset: 0x00B979B0
		private void BuildOptionNode(int optionNodeIndex, OptionReadGroup group, HashSet<int> groupStack)
		{
			if (optionNodeIndex < 0 || optionNodeIndex >= this.Options.Count)
			{
				return;
			}
			OptionReadNode optionReadNode = this.Options[optionNodeIndex];
			List<ITalkOption> options = group.TalkItem.Options;
			ITalkOption talkOption = null;
			if (options != null && optionReadNode.OptionIndex >= 0 && optionReadNode.OptionIndex < options.Count)
			{
				talkOption = options[optionReadNode.OptionIndex];
			}
			if (talkOption == null)
			{
				return;
			}
			List<int> nextTalkIndicesAfterSubActions = this.GetNextTalkIndicesAfterSubActions(group.TalkItemIndex, talkOption.Actions);
			foreach (int num in this.GetNextOptionGroupIndices(nextTalkIndicesAfterSubActions, groupStack))
			{
				if (!optionReadNode.DependencyGroupIndices.Contains(num))
				{
					optionReadNode.DependencyGroupIndices.Add(num);
				}
				this.BuildGroup(num, groupStack);
			}
		}

		// Token: 0x0602949F RID: 169119 RVA: 0x00B99894 File Offset: 0x00B97A94
		private List<int> GetNextOptionGroupIndices(List<int> startTalkItemIndices, HashSet<int> groupStack)
		{
			List<int> list = new List<int>();
			HashSet<int> hashSet = new HashSet<int>();
			Queue<int> queue = new Queue<int>(startTalkItemIndices);
			while (queue.Count > 0)
			{
				int num = queue.Dequeue();
				if (this.ShowTalk != null && num >= 0 && num < this.ShowTalk.TalkItems.Count && !hashSet.Contains(num))
				{
					hashSet.Add(num);
					ITalkItem talkItem = this.ShowTalk.TalkItems[num];
					int item;
					if (this.GroupIndexByTalkItemId.TryGetValue(talkItem.Id, out item))
					{
						if (!groupStack.Contains(item) && !list.Contains(item))
						{
							list.Add(item);
						}
					}
					else
					{
						List<int> talkIndicesByBreakAction = this.GetTalkIndicesByBreakAction(talkItem.Actions);
						if (talkIndicesByBreakAction != null)
						{
							using (List<int>.Enumerator enumerator = talkIndicesByBreakAction.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									int item2 = enumerator.Current;
									queue.Enqueue(item2);
								}
								continue;
							}
						}
						foreach (int item3 in this.GetNextSequentialTalkIndices(num))
						{
							queue.Enqueue(item3);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060294A0 RID: 169120 RVA: 0x00B999F8 File Offset: 0x00B97BF8
		private List<int> GetNextTalkIndicesAfterSubActions(int talkItemIndex, [Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions)
		{
			return this.GetTalkIndicesByBreakAction(actions) ?? this.GetNextSequentialTalkIndices(talkItemIndex);
		}

		// Token: 0x060294A1 RID: 169121 RVA: 0x00B99A0C File Offset: 0x00B97C0C
		[NullableContext(2)]
		private List<int> GetTalkIndicesByBreakAction([Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions)
		{
			if (actions == null)
			{
				return null;
			}
			foreach (ActionInfo actionInfo in actions)
			{
				if (!actionInfo.Disabled.GetValueOrDefault() && !actionInfo.EdLocalDisabled.GetValueOrDefault())
				{
					EAction name = actionInfo.Name;
					if (name == EAction.ChangeState || name - EAction.FinishState <= 1)
					{
						return new List<int>();
					}
					if (name == EAction.JumpTalk)
					{
						int talkId = ((JumpTalk)actionInfo.Params).TalkId;
						int item;
						List<int> result;
						if (!this.TalkItemIndexById.TryGetValue(talkId, out item))
						{
							result = new List<int>();
						}
						else
						{
							(result = new List<int>()).Add(item);
						}
						return result;
					}
				}
			}
			return null;
		}

		// Token: 0x060294A2 RID: 169122 RVA: 0x00B99AE0 File Offset: 0x00B97CE0
		private List<int> GetNextSequentialTalkIndices(int talkItemIndex)
		{
			if (this.ShowTalk == null)
			{
				return new List<int>();
			}
			int num = talkItemIndex + 1;
			if (num >= this.ShowTalk.TalkItems.Count)
			{
				return new List<int>();
			}
			return new List<int>
			{
				num
			};
		}

		// Token: 0x060294A3 RID: 169123 RVA: 0x00B99B24 File Offset: 0x00B97D24
		private bool IsOptionNodeFullyRead(int optionNodeIndex, Dictionary<int, HashSet<int>> grayOptionMap, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition, HashSet<int> checkingOptionNodeIndices)
		{
			if (checkingOptionNodeIndices.Contains(optionNodeIndex))
			{
				return true;
			}
			if (optionNodeIndex < 0 || optionNodeIndex >= this.Options.Count)
			{
				return false;
			}
			OptionReadNode optionReadNode = this.Options[optionNodeIndex];
			checkingOptionNodeIndices.Add(optionNodeIndex);
			foreach (int groupIndex in optionReadNode.DependencyGroupIndices)
			{
				if (!this.IsOptionGroupFullyRead(groupIndex, grayOptionMap, checkOptionCondition, checkingOptionNodeIndices))
				{
					checkingOptionNodeIndices.Remove(optionNodeIndex);
					return false;
				}
			}
			checkingOptionNodeIndices.Remove(optionNodeIndex);
			return true;
		}

		// Token: 0x060294A4 RID: 169124 RVA: 0x00B99BCC File Offset: 0x00B97DCC
		private bool IsOptionGroupFullyRead(int groupIndex, Dictionary<int, HashSet<int>> grayOptionMap, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition, HashSet<int> checkingOptionNodeIndices)
		{
			if (groupIndex < 0 || groupIndex >= this.Groups.Count)
			{
				return true;
			}
			OptionReadGroup optionReadGroup = this.Groups[groupIndex];
			foreach (int num in optionReadGroup.OptionNodeIndices)
			{
				if (num >= 0 && num < this.Options.Count)
				{
					OptionReadNode optionReadNode = this.Options[num];
					List<ITalkOption> options = optionReadGroup.TalkItem.Options;
					ITalkOption option = null;
					if (options != null && optionReadNode.OptionIndex >= 0 && optionReadNode.OptionIndex < options.Count)
					{
						option = options[optionReadNode.OptionIndex];
					}
					if (this.IsOptionVisibleForReadCheck(option, optionReadNode.OptionIndex, optionReadGroup.TalkItem, checkOptionCondition))
					{
						HashSet<int> hashSet;
						if (!grayOptionMap.TryGetValue(optionReadNode.TalkItemId, out hashSet) || !hashSet.Contains(optionReadNode.OptionIndex))
						{
							return false;
						}
						if (!this.IsOptionNodeFullyRead(num, grayOptionMap, checkOptionCondition, checkingOptionNodeIndices))
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060294A5 RID: 169125 RVA: 0x00B99CF0 File Offset: 0x00B97EF0
		private bool IsOptionVisibleForReadCheck([Nullable(2)] ITalkOption option, int index, ITalkItem talkItem, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition)
		{
			return option != null && !option.HiddenOption.GetValueOrDefault() && (checkOptionCondition(option, index, talkItem) || option.OptionLockTip != null);
		}

		// Token: 0x060294A6 RID: 169126 RVA: 0x00B99D2C File Offset: 0x00B97F2C
		private int? GetOptionNodeIndex(int talkId, int optionIndex)
		{
			Dictionary<int, int> dictionary;
			if (!this.OptionNodeIndexByTalkItemId.TryGetValue(talkId, out dictionary))
			{
				return null;
			}
			int value;
			if (!dictionary.TryGetValue(optionIndex, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x040167FC RID: 92156
		[Nullable(2)]
		private readonly ShowTalk ShowTalk;

		// Token: 0x040167FD RID: 92157
		private readonly List<OptionReadGroup> Groups = new List<OptionReadGroup>();

		// Token: 0x040167FE RID: 92158
		private readonly List<OptionReadNode> Options = new List<OptionReadNode>();

		// Token: 0x040167FF RID: 92159
		private readonly Dictionary<int, int> GroupIndexByTalkItemId = new Dictionary<int, int>();

		// Token: 0x04016800 RID: 92160
		private readonly Dictionary<int, Dictionary<int, int>> OptionNodeIndexByTalkItemId = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x04016801 RID: 92161
		private readonly Dictionary<int, int> TalkItemIndexById = new Dictionary<int, int>();

		// Token: 0x04016802 RID: 92162
		private readonly HashSet<int> BuiltGroupIndices = new HashSet<int>();
	}
}
