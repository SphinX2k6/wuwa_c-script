using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FFE RID: 20478
	[NullableContext(1)]
	[Nullable(0)]
	internal class OptionReadGraph
	{
		// Token: 0x0603460D RID: 214541 RVA: 0x00C4F414 File Offset: 0x00C4D614
		[NullableContext(2)]
		public OptionReadGraph(ShowTalk config)
		{
			this.ShowTalk = config;
		}

		// Token: 0x0603460E RID: 214542 RVA: 0x00C4F470 File Offset: 0x00C4D670
		public void Init()
		{
			this.InitNodes();
			this.BuildGraph();
		}

		// Token: 0x0603460F RID: 214543 RVA: 0x00C4F480 File Offset: 0x00C4D680
		public bool IsOptionEntryFullyRead(int talkId, int optionIndex, Dictionary<int, HashSet<int>> grayOptionMap, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition)
		{
			int? optionNodeIndex = this.GetOptionNodeIndex(talkId, optionIndex);
			return optionNodeIndex != null && this.IsOptionNodeFullyRead(optionNodeIndex.Value, grayOptionMap, checkOptionCondition, new HashSet<int>());
		}

		// Token: 0x06034610 RID: 214544 RVA: 0x00C4F4B8 File Offset: 0x00C4D6B8
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

		// Token: 0x06034611 RID: 214545 RVA: 0x00C4F5DC File Offset: 0x00C4D7DC
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

		// Token: 0x06034612 RID: 214546 RVA: 0x00C4F690 File Offset: 0x00C4D890
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

		// Token: 0x06034613 RID: 214547 RVA: 0x00C4F73C File Offset: 0x00C4D93C
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

		// Token: 0x06034614 RID: 214548 RVA: 0x00C4F820 File Offset: 0x00C4DA20
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

		// Token: 0x06034615 RID: 214549 RVA: 0x00C4F984 File Offset: 0x00C4DB84
		private List<int> GetNextTalkIndicesAfterSubActions(int talkItemIndex, [Nullable(new byte[]
		{
			2,
			1
		})] List<ActionInfo> actions)
		{
			return this.GetTalkIndicesByBreakAction(actions) ?? this.GetNextSequentialTalkIndices(talkItemIndex);
		}

		// Token: 0x06034616 RID: 214550 RVA: 0x00C4F998 File Offset: 0x00C4DB98
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

		// Token: 0x06034617 RID: 214551 RVA: 0x00C4FA6C File Offset: 0x00C4DC6C
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

		// Token: 0x06034618 RID: 214552 RVA: 0x00C4FAB0 File Offset: 0x00C4DCB0
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

		// Token: 0x06034619 RID: 214553 RVA: 0x00C4FB58 File Offset: 0x00C4DD58
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

		// Token: 0x0603461A RID: 214554 RVA: 0x00C4FC7C File Offset: 0x00C4DE7C
		private bool IsOptionVisibleForReadCheck([Nullable(2)] ITalkOption option, int index, ITalkItem talkItem, Func<ITalkOption, int, ITalkItem, bool> checkOptionCondition)
		{
			return option != null && !option.HiddenOption.GetValueOrDefault() && (checkOptionCondition(option, index, talkItem) || option.OptionLockTip != null);
		}

		// Token: 0x0603461B RID: 214555 RVA: 0x00C4FCB8 File Offset: 0x00C4DEB8
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

		// Token: 0x0401BE1F RID: 114207
		[Nullable(2)]
		private readonly ShowTalk ShowTalk;

		// Token: 0x0401BE20 RID: 114208
		private readonly List<OptionReadGroup> Groups = new List<OptionReadGroup>();

		// Token: 0x0401BE21 RID: 114209
		private readonly List<OptionReadNode> Options = new List<OptionReadNode>();

		// Token: 0x0401BE22 RID: 114210
		private readonly Dictionary<int, int> GroupIndexByTalkItemId = new Dictionary<int, int>();

		// Token: 0x0401BE23 RID: 114211
		private readonly Dictionary<int, Dictionary<int, int>> OptionNodeIndexByTalkItemId = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401BE24 RID: 114212
		private readonly Dictionary<int, int> TalkItemIndexById = new Dictionary<int, int>();

		// Token: 0x0401BE25 RID: 114213
		private readonly HashSet<int> BuiltGroupIndices = new HashSet<int>();
	}
}
