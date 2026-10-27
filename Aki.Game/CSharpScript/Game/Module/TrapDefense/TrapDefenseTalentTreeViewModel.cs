using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A8C RID: 19084
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeViewModel
	{
		// Token: 0x06031777 RID: 202615 RVA: 0x00B771BB File Offset: 0x00B753BB
		public static TrapDefenseTalentTreeViewModel Create()
		{
			return new TrapDefenseTalentTreeViewModel();
		}

		// Token: 0x06031778 RID: 202616 RVA: 0x00B771C2 File Offset: 0x00B753C2
		public void AddDelegateOnNodeSelect(Action<TrapDefenseTalentTreeNodeData, bool> @delegate)
		{
			this.DelegatesOnNodeSelect.Add(@delegate);
		}

		// Token: 0x06031779 RID: 202617 RVA: 0x00B771D0 File Offset: 0x00B753D0
		public void RemoveDelegateOnNodeSelect(Action<TrapDefenseTalentTreeNodeData, bool> @delegate)
		{
			int num = this.DelegatesOnNodeSelect.IndexOf(@delegate);
			if (num != -1)
			{
				this.DelegatesOnNodeSelect.RemoveAt(num);
			}
		}

		// Token: 0x0603177A RID: 202618 RVA: 0x00B771FA File Offset: 0x00B753FA
		public void SelectNode(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			if (node == null || (this.SelectedNode != null && this.SelectedNode.Id == node.Id))
			{
				return;
			}
			this.SelectedNode = node;
			this.NotifyNodeSelect(node, shouldScroll);
		}

		// Token: 0x0603177B RID: 202619 RVA: 0x00B7722C File Offset: 0x00B7542C
		private void NotifyNodeSelect(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			foreach (Action<TrapDefenseTalentTreeNodeData, bool> action in this.DelegatesOnNodeSelect)
			{
				action(node, shouldScroll);
			}
		}

		// Token: 0x0603177C RID: 202620 RVA: 0x00B77280 File Offset: 0x00B75480
		public void OnViewClose()
		{
			this.DelegatesOnNodeSelect = new List<Action<TrapDefenseTalentTreeNodeData, bool>>();
			this.SelectedNode = null;
		}

		// Token: 0x0401A73C RID: 108348
		public List<Action<TrapDefenseTalentTreeNodeData, bool>> DelegatesOnNodeSelect = new List<Action<TrapDefenseTalentTreeNodeData, bool>>();

		// Token: 0x0401A73D RID: 108349
		[Nullable(2)]
		public TrapDefenseTalentTreeNodeData SelectedNode;
	}
}
