using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Flow;

namespace CSharpScript.Game.Module.Dialogue
{
	// Token: 0x02004AA0 RID: 19104
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DialogueScript
	{
		// Token: 0x0602FCCE RID: 195790 RVA: 0x00D56114 File Offset: 0x00D54314
		public static DialogueScript Load(string flowListName, int flowId, int stateId)
		{
			SetPlotMode setPlotMode = null;
			List<ActionInfo> list = new List<ActionInfo>();
			List<ActionInfo> flowStateActions = FlowConfig.Instance.GetFlowStateActions(flowListName, flowId, stateId);
			if (flowStateActions != null)
			{
				foreach (ActionInfo actionInfo in flowStateActions)
				{
					if (setPlotMode == null && actionInfo.Name == EAction.SetPlotMode)
					{
						setPlotMode = (actionInfo.Params as SetPlotMode);
					}
					if (actionInfo.Name == EAction.ShowTalk && actionInfo.Params is ShowTalk)
					{
						list.Add(actionInfo);
					}
					if (actionInfo.Name == EAction.PlayMovie && actionInfo.Params is PlayMovie)
					{
						list.Add(actionInfo);
					}
				}
			}
			return new DialogueScript(setPlotMode, list);
		}

		// Token: 0x0602FCCF RID: 195791 RVA: 0x00D561DC File Offset: 0x00D543DC
		private DialogueScript([Nullable(2)] SetPlotMode plotMode, IReadOnlyList<ActionInfo> playbackActions)
		{
			this.PlotMode = plotMode;
			this.PlaybackActionList.AddRange(playbackActions);
			foreach (ActionInfo actionInfo in playbackActions)
			{
				ShowTalk showTalk = actionInfo.Params as ShowTalk;
				if (showTalk != null && showTalk.TalkItems != null)
				{
					List<DialogueItem> list = new List<DialogueItem>();
					foreach (ITalkItem talkItem in showTalk.TalkItems)
					{
						if (talkItem != null)
						{
							DialogueItem item = new DialogueItem(this.ItemList.Count, talkItem);
							this.ItemList.Add(item);
							list.Add(item);
						}
					}
					this.ItemsByShowTalk[showTalk] = list;
				}
			}
		}

		// Token: 0x0602FCD0 RID: 195792 RVA: 0x00D5631C File Offset: 0x00D5451C
		public int GetCount()
		{
			return this.ItemList.Count;
		}

		// Token: 0x0602FCD1 RID: 195793 RVA: 0x00D56329 File Offset: 0x00D54529
		public IReadOnlyList<DialogueItem> GetItems()
		{
			return this.ItemList;
		}

		// Token: 0x0602FCD2 RID: 195794 RVA: 0x00D56331 File Offset: 0x00D54531
		public IReadOnlyList<DialogueChoice> GetChoiceHistory()
		{
			return this.ChoiceHistoryList;
		}

		// Token: 0x0602FCD3 RID: 195795 RVA: 0x00D56339 File Offset: 0x00D54539
		public IReadOnlyList<DialogueItem> GetDialogueHistory()
		{
			return this.DialogueHistoryList;
		}

		// Token: 0x0602FCD4 RID: 195796 RVA: 0x00D56341 File Offset: 0x00D54541
		public IReadOnlyList<ActionInfo> GetPlaybackActions()
		{
			return this.PlaybackActionList;
		}

		// Token: 0x0602FCD5 RID: 195797 RVA: 0x00D56349 File Offset: 0x00D54549
		[NullableContext(2)]
		public SetPlotMode GetPlotMode()
		{
			return this.PlotMode;
		}

		// Token: 0x0602FCD6 RID: 195798 RVA: 0x00D56351 File Offset: 0x00D54551
		[NullableContext(2)]
		public DialogueItem GetCurrentItem()
		{
			return this.CurrentItem;
		}

		// Token: 0x0602FCD7 RID: 195799 RVA: 0x00D5635C File Offset: 0x00D5455C
		public DialogueJump? GetCurrentJump()
		{
			DialogueItem currentItem = this.CurrentItem;
			if (currentItem == null)
			{
				return null;
			}
			return currentItem.Jump;
		}

		// Token: 0x0602FCD8 RID: 195800 RVA: 0x00D56384 File Offset: 0x00D54584
		public IReadOnlyList<DialogueItem> GetItems(ShowTalk showTalk)
		{
			List<DialogueItem> result;
			if (!this.ItemsByShowTalk.TryGetValue(showTalk, out result))
			{
				return Array.Empty<DialogueItem>();
			}
			return result;
		}

		// Token: 0x0602FCD9 RID: 195801 RVA: 0x00D563AC File Offset: 0x00D545AC
		[return: Nullable(2)]
		public DialogueItem Select(ShowTalk showTalk)
		{
			this.ItemById.Clear();
			this.NextItemById.Clear();
			this.CurrentItem = null;
			List<DialogueItem> list;
			if (!this.ItemsByShowTalk.TryGetValue(showTalk, out list) || list.Count == 0)
			{
				return null;
			}
			for (int i = 0; i < list.Count; i++)
			{
				DialogueItem dialogueItem = list[i];
				this.ItemById.TryAdd(dialogueItem.Id, dialogueItem);
				this.NextItemById[dialogueItem.Id] = ((i + 1 < list.Count) ? list[i + 1] : null);
			}
			this.CurrentItem = list[0];
			return this.CurrentItem;
		}

		// Token: 0x0602FCDA RID: 195802 RVA: 0x00D56457 File Offset: 0x00D54657
		public bool TryGetItem(int id, out DialogueItem item)
		{
			return this.ItemById.TryGetValue(id, out item);
		}

		// Token: 0x0602FCDB RID: 195803 RVA: 0x00D56468 File Offset: 0x00D54668
		[NullableContext(2)]
		public DialogueItem GetNextItem(int id)
		{
			DialogueItem result;
			if (!this.NextItemById.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602FCDC RID: 195804 RVA: 0x00D56488 File Offset: 0x00D54688
		public bool Select(int itemId)
		{
			DialogueItem currentItem;
			if (!this.ItemById.TryGetValue(itemId, out currentItem))
			{
				return false;
			}
			this.CurrentItem = currentItem;
			return true;
		}

		// Token: 0x0602FCDD RID: 195805 RVA: 0x00D564B0 File Offset: 0x00D546B0
		[NullableContext(2)]
		public DialogueOption SelectOption(int itemId, int optionIndex)
		{
			DialogueItem dialogueItem;
			if (!this.ItemById.TryGetValue(itemId, out dialogueItem))
			{
				return null;
			}
			foreach (DialogueOption dialogueOption in dialogueItem.Options)
			{
				if (dialogueOption.Index == optionIndex)
				{
					this.ChoiceHistoryList.Add(new DialogueChoice(dialogueItem, dialogueOption));
					return dialogueOption;
				}
			}
			return null;
		}

		// Token: 0x0602FCDE RID: 195806 RVA: 0x00D5652C File Offset: 0x00D5472C
		[NullableContext(2)]
		public DialogueOption SelectOption(int optionIndex)
		{
			if (this.CurrentItem != null)
			{
				return this.SelectOption(this.CurrentItem.Id, optionIndex);
			}
			return null;
		}

		// Token: 0x0602FCDF RID: 195807 RVA: 0x00D5654C File Offset: 0x00D5474C
		[NullableContext(2)]
		public DialogueItem Jump(DialogueJump? jump)
		{
			if (jump == null)
			{
				return this.MoveNext();
			}
			if (jump.Value.EndsDialogue)
			{
				this.CurrentItem = null;
				return null;
			}
			if (!this.Select(jump.Value.TargetId))
			{
				return null;
			}
			return this.CurrentItem;
		}

		// Token: 0x0602FCE0 RID: 195808 RVA: 0x00D565A4 File Offset: 0x00D547A4
		[NullableContext(2)]
		public DialogueItem MoveNext()
		{
			if (this.CurrentItem == null)
			{
				return null;
			}
			DialogueItem dialogueItem;
			this.CurrentItem = (this.NextItemById.TryGetValue(this.CurrentItem.Id, out dialogueItem) ? dialogueItem : null);
			return this.CurrentItem;
		}

		// Token: 0x0602FCE1 RID: 195809 RVA: 0x00D565E8 File Offset: 0x00D547E8
		public void RecordDialogue(int itemId)
		{
			DialogueItem item;
			if (this.ItemById.TryGetValue(itemId, out item))
			{
				this.DialogueHistoryList.Add(item);
			}
		}

		// Token: 0x040195F1 RID: 103921
		private readonly List<DialogueItem> ItemList = new List<DialogueItem>();

		// Token: 0x040195F2 RID: 103922
		private readonly Dictionary<ShowTalk, List<DialogueItem>> ItemsByShowTalk = new Dictionary<ShowTalk, List<DialogueItem>>();

		// Token: 0x040195F3 RID: 103923
		private readonly Dictionary<int, DialogueItem> ItemById = new Dictionary<int, DialogueItem>();

		// Token: 0x040195F4 RID: 103924
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Dictionary<int, DialogueItem> NextItemById = new Dictionary<int, DialogueItem>();

		// Token: 0x040195F5 RID: 103925
		private readonly List<DialogueChoice> ChoiceHistoryList = new List<DialogueChoice>();

		// Token: 0x040195F6 RID: 103926
		private readonly List<DialogueItem> DialogueHistoryList = new List<DialogueItem>();

		// Token: 0x040195F7 RID: 103927
		private readonly List<ActionInfo> PlaybackActionList = new List<ActionInfo>();

		// Token: 0x040195F8 RID: 103928
		[Nullable(2)]
		private readonly SetPlotMode PlotMode;

		// Token: 0x040195F9 RID: 103929
		[Nullable(2)]
		private DialogueItem CurrentItem;
	}
}
