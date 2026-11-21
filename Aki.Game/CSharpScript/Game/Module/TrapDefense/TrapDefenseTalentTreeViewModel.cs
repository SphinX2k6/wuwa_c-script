using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A34 RID: 14900
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeViewModel
	{
		// Token: 0x06026507 RID: 156935 RVA: 0x00ABB16F File Offset: 0x00AB936F
		public static TrapDefenseTalentTreeViewModel Create()
		{
			return new TrapDefenseTalentTreeViewModel();
		}

		// Token: 0x06026508 RID: 156936 RVA: 0x00ABB176 File Offset: 0x00AB9376
		public void AddDelegateOnNodeSelect(Action<TrapDefenseTalentTreeNodeData, bool> @delegate)
		{
			this.DelegatesOnNodeSelect.Add(@delegate);
		}

		// Token: 0x06026509 RID: 156937 RVA: 0x00ABB184 File Offset: 0x00AB9384
		public void RemoveDelegateOnNodeSelect(Action<TrapDefenseTalentTreeNodeData, bool> @delegate)
		{
			int num = this.DelegatesOnNodeSelect.IndexOf(@delegate);
			if (num != -1)
			{
				this.DelegatesOnNodeSelect.RemoveAt(num);
			}
		}

		// Token: 0x0602650A RID: 156938 RVA: 0x00ABB1AE File Offset: 0x00AB93AE
		public void SelectNode(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			if (node == null || (this.SelectedNode != null && this.SelectedNode.Id == node.Id))
			{
				return;
			}
			this.SelectedNode = node;
			this.NotifyNodeSelect(node, shouldScroll);
		}

		// Token: 0x0602650B RID: 156939 RVA: 0x00ABB1E0 File Offset: 0x00AB93E0
		private void NotifyNodeSelect(TrapDefenseTalentTreeNodeData node, bool shouldScroll)
		{
			foreach (Action<TrapDefenseTalentTreeNodeData, bool> action in this.DelegatesOnNodeSelect)
			{
				action(node, shouldScroll);
			}
		}

		// Token: 0x0602650C RID: 156940 RVA: 0x00ABB234 File Offset: 0x00AB9434
		public void OnViewClose()
		{
			this.DelegatesOnNodeSelect = new List<Action<TrapDefenseTalentTreeNodeData, bool>>();
			this.SelectedNode = null;
		}

		// Token: 0x0401508E RID: 86158
		public List<Action<TrapDefenseTalentTreeNodeData, bool>> DelegatesOnNodeSelect = new List<Action<TrapDefenseTalentTreeNodeData, bool>>();

		// Token: 0x0401508F RID: 86159
		[Nullable(2)]
		public TrapDefenseTalentTreeNodeData SelectedNode;
	}
}
