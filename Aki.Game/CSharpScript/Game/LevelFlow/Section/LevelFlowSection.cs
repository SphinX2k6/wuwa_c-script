using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelFlow.Node;

namespace CSharpScript.Game.LevelFlow.Section
{
	// Token: 0x020060F3 RID: 24819
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSection : IStaticVariableResetter
	{
		// Token: 0x0603B81E RID: 243742 RVA: 0x010DDE47 File Offset: 0x010DC047
		static LevelFlowSection()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowSection.CreateStaticDefaultValue), new Action(LevelFlowSection.ResetStaticDefaultValue));
		}

		// Token: 0x0603B81F RID: 243743 RVA: 0x010DDE68 File Offset: 0x010DC068
		public LevelFlowSection(List<LevelFlowNode> nodeList, List<LevelFlowNode> resetNodeList)
		{
			this.ResetNodeList = resetNodeList;
			this.SectionId = LevelFlowSection.SelfIncrementId++;
			this.NodeList = nodeList;
		}

		// Token: 0x0603B820 RID: 243744 RVA: 0x010DDEBD File Offset: 0x010DC0BD
		public void BindCompleteCallBack(Action<LevelFlowSection, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x0603B821 RID: 243745 RVA: 0x010DDEC6 File Offset: 0x010DC0C6
		public void BindResetCompleteCallBack(Action<LevelFlowSection, bool> completeCallBack)
		{
			this.ResetCompleteCallBack = completeCallBack;
		}

		// Token: 0x0603B822 RID: 243746 RVA: 0x010DDED0 File Offset: 0x010DC0D0
		public void Enter()
		{
			this.NodeSet.Clear();
			foreach (LevelFlowNode levelFlowNode in this.NodeList)
			{
				this.NodeSet.Add(levelFlowNode);
				levelFlowNode.BindCompleteCallBack(new Action<LevelFlowNode, bool>(this.OnNodeComplete));
			}
			foreach (LevelFlowNode levelFlowNode2 in this.NodeSet)
			{
				levelFlowNode2.Enter();
			}
		}

		// Token: 0x0603B823 RID: 243747 RVA: 0x010DDF88 File Offset: 0x010DC188
		public void Tick(float deltaTime)
		{
			foreach (LevelFlowNode levelFlowNode in this.NodeSet)
			{
				levelFlowNode.Tick(deltaTime);
			}
		}

		// Token: 0x0603B824 RID: 243748 RVA: 0x010DDFDC File Offset: 0x010DC1DC
		public void Exit()
		{
			foreach (LevelFlowNode levelFlowNode in this.NodeList)
			{
				levelFlowNode.Exit();
			}
			this.NodeSet.Clear();
			this.NodeList.Clear();
			this.CompleteCallBack = null;
		}

		// Token: 0x0603B825 RID: 243749 RVA: 0x010DE04C File Offset: 0x010DC24C
		public void Reset()
		{
			foreach (LevelFlowNode levelFlowNode in this.NodeList)
			{
				levelFlowNode.Reset();
			}
			this.NodeSet.Clear();
			foreach (LevelFlowNode item in this.ResetNodeList)
			{
				this.NodeSet.Add(item);
			}
			foreach (LevelFlowNode levelFlowNode2 in this.ResetNodeList)
			{
				levelFlowNode2.BindCompleteCallBack(new Action<LevelFlowNode, bool>(this.OnResetNodeComplete));
				levelFlowNode2.Enter();
			}
		}

		// Token: 0x0603B826 RID: 243750 RVA: 0x010DE140 File Offset: 0x010DC340
		private void OnNodeComplete(LevelFlowNode node, bool isSuccess)
		{
			if (isSuccess)
			{
				node.Exit();
				this.NodeSet.Remove(node);
				if (this.NodeSet.Count == 0)
				{
					Action<LevelFlowSection, bool> completeCallBack = this.CompleteCallBack;
					if (completeCallBack == null)
					{
						return;
					}
					completeCallBack(this, true);
				}
				return;
			}
			Action<LevelFlowSection, bool> completeCallBack2 = this.CompleteCallBack;
			if (completeCallBack2 == null)
			{
				return;
			}
			completeCallBack2(this, false);
		}

		// Token: 0x0603B827 RID: 243751 RVA: 0x010DE198 File Offset: 0x010DC398
		private void OnResetNodeComplete(LevelFlowNode node, bool isSuccess)
		{
			if (isSuccess)
			{
				node.Exit();
				this.NodeSet.Remove(node);
				if (this.NodeSet.Count == 0)
				{
					foreach (LevelFlowNode levelFlowNode in this.ResetNodeList)
					{
						levelFlowNode.Reset();
					}
					Action<LevelFlowSection, bool> resetCompleteCallBack = this.ResetCompleteCallBack;
					if (resetCompleteCallBack == null)
					{
						return;
					}
					resetCompleteCallBack(this, true);
				}
				return;
			}
			Action<LevelFlowSection, bool> resetCompleteCallBack2 = this.ResetCompleteCallBack;
			if (resetCompleteCallBack2 == null)
			{
				return;
			}
			resetCompleteCallBack2(this, false);
		}

		// Token: 0x0603B828 RID: 243752 RVA: 0x010DE230 File Offset: 0x010DC430
		public static void CreateStaticDefaultValue()
		{
			LevelFlowSection.SelfIncrementId = 0;
		}

		// Token: 0x0603B829 RID: 243753 RVA: 0x010DE238 File Offset: 0x010DC438
		public static void ResetStaticDefaultValue()
		{
			LevelFlowSection.SelfIncrementId = 0;
		}

		// Token: 0x0401F62B RID: 128555
		public readonly int SectionId;

		// Token: 0x0401F62C RID: 128556
		private static int SelfIncrementId;

		// Token: 0x0401F62D RID: 128557
		private readonly List<LevelFlowNode> NodeList = new List<LevelFlowNode>();

		// Token: 0x0401F62E RID: 128558
		private readonly List<LevelFlowNode> ResetNodeList = new List<LevelFlowNode>();

		// Token: 0x0401F62F RID: 128559
		private readonly HashSet<LevelFlowNode> NodeSet = new HashSet<LevelFlowNode>();

		// Token: 0x0401F630 RID: 128560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowSection, bool> CompleteCallBack;

		// Token: 0x0401F631 RID: 128561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowSection, bool> ResetCompleteCallBack;
	}
}
