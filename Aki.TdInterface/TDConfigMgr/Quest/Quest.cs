using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F63 RID: 3939
	[NullableContext(1)]
	[Nullable(0)]
	public class Quest
	{
		// Token: 0x0600584F RID: 22607 RVA: 0x000D7F38 File Offset: 0x000D6138
		public static Dictionary<int, IBtNode> FlatBehaviorTree(IBehaviorTree bt)
		{
			Dictionary<int, IBtNode> dictionary = new Dictionary<int, IBtNode>();
			Quest.FlatNode(bt.Root, dictionary, null);
			return dictionary;
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x000D7F5C File Offset: 0x000D615C
		private static void FlatNode(IBtNode node, Dictionary<int, IBtNode> idMap, [Nullable(2)] IBtNode parent = null)
		{
			node.ParentNodeId = ((parent != null) ? new int?(parent.Id) : null);
			idMap[node.Id] = node;
			IStartBtNode startBtNode = node as IStartBtNode;
			if (startBtNode != null)
			{
				if (startBtNode.Child != null && startBtNode.Child != null)
				{
					Quest.FlatNode(startBtNode.Child, idMap, node);
					return;
				}
			}
			else
			{
				IAlwaysTrueBtNode alwaysTrueBtNode = node as IAlwaysTrueBtNode;
				if (alwaysTrueBtNode != null)
				{
					if (alwaysTrueBtNode.Child != null && alwaysTrueBtNode.Child != null)
					{
						Quest.FlatNode(alwaysTrueBtNode.Child, idMap, node);
						return;
					}
				}
				else
				{
					IAlwaysFalseBtNode alwaysFalseBtNode = node as IAlwaysFalseBtNode;
					if (alwaysFalseBtNode != null)
					{
						if (alwaysFalseBtNode.Child != null && alwaysFalseBtNode.Child != null)
						{
							Quest.FlatNode(alwaysFalseBtNode.Child, idMap, node);
							return;
						}
					}
					else
					{
						IRepeaterBtNode repeaterBtNode = node as IRepeaterBtNode;
						if (repeaterBtNode == null)
						{
							if (!(node is IActionBtNode) && !(node is IActionWithResultBtNode) && !(node is IQuestSucceedBtNode) && !(node is IQuestFailedBtNode) && !(node is IConditionBtNode) && !(node is IChildQuestBtNode))
							{
								ISequenceBtNode sequenceBtNode = node as ISequenceBtNode;
								ISelectBtNode selectBtNode;
								IParallelSelectBtNode parallelSelectBtNode;
								IConditionSelectorBtNode conditionSelectorBtNode;
								if (sequenceBtNode == null)
								{
									selectBtNode = (node as ISelectBtNode);
									if (selectBtNode == null)
									{
										parallelSelectBtNode = (node as IParallelSelectBtNode);
										if (parallelSelectBtNode != null)
										{
											goto IL_1E2;
										}
										conditionSelectorBtNode = (node as IConditionSelectorBtNode);
										if (conditionSelectorBtNode == null)
										{
											return;
										}
										goto IL_219;
									}
								}
								else
								{
									using (List<IBtNode>.Enumerator enumerator = sequenceBtNode.Children.GetEnumerator())
									{
										while (enumerator.MoveNext())
										{
											IBtNode node2 = enumerator.Current;
											Quest.FlatNode(node2, idMap, node);
										}
										return;
									}
								}
								using (List<IBtNode>.Enumerator enumerator = selectBtNode.Children.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										IBtNode node3 = enumerator.Current;
										Quest.FlatNode(node3, idMap, node);
									}
									return;
								}
								IL_1E2:
								using (List<IBtNode>.Enumerator enumerator = parallelSelectBtNode.Children.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										IBtNode node4 = enumerator.Current;
										Quest.FlatNode(node4, idMap, node);
									}
									return;
								}
								IL_219:
								foreach (IConditionSelectorBtNodeSlot conditionSelectorBtNodeSlot in conditionSelectorBtNode.Slots)
								{
									Quest.FlatNode(conditionSelectorBtNodeSlot.Node, idMap, node);
								}
							}
						}
						else if (repeaterBtNode.Child != null)
						{
							Quest.FlatNode(repeaterBtNode.Child, idMap, node);
							return;
						}
					}
				}
			}
		}
	}
}
