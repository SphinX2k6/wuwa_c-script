using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelFlow.Node;

namespace CSharpScript.Game.LevelFlow.Section
{
	// Token: 0x02006F72 RID: 28530
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowSection : IStaticVariableResetter
	{
		// Token: 0x06045670 RID: 284272 RVA: 0x01134043 File Offset: 0x01132243
		static LevelFlowSection()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelFlowSection.CreateStaticDefaultValue), new Action(LevelFlowSection.ResetStaticDefaultValue));
		}

		// Token: 0x06045671 RID: 284273 RVA: 0x01134064 File Offset: 0x01132264
		public LevelFlowSection(List<LevelFlowNode> nodeList, List<LevelFlowNode> resetNodeList)
		{
			this.ResetNodeList = resetNodeList;
			this.SectionId = LevelFlowSection.SelfIncrementId++;
			this.NodeList = nodeList;
		}

		// Token: 0x06045672 RID: 284274 RVA: 0x011340B9 File Offset: 0x011322B9
		public void BindCompleteCallBack(Action<LevelFlowSection, bool> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x06045673 RID: 284275 RVA: 0x011340C2 File Offset: 0x011322C2
		public void BindResetCompleteCallBack(Action<LevelFlowSection, bool> completeCallBack)
		{
			this.ResetCompleteCallBack = completeCallBack;
		}

		// Token: 0x06045674 RID: 284276 RVA: 0x011340CC File Offset: 0x011322CC
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

		// Token: 0x06045675 RID: 284277 RVA: 0x01134184 File Offset: 0x01132384
		public void Tick(float deltaTime)
		{
			foreach (LevelFlowNode levelFlowNode in this.NodeSet)
			{
				levelFlowNode.Tick(deltaTime);
			}
		}

		// Token: 0x06045676 RID: 284278 RVA: 0x011341D8 File Offset: 0x011323D8
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

		// Token: 0x06045677 RID: 284279 RVA: 0x01134248 File Offset: 0x01132448
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

		// Token: 0x06045678 RID: 284280 RVA: 0x0113433C File Offset: 0x0113253C
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

		// Token: 0x06045679 RID: 284281 RVA: 0x01134394 File Offset: 0x01132594
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

		// Token: 0x0604567A RID: 284282 RVA: 0x0113442C File Offset: 0x0113262C
		public static void CreateStaticDefaultValue()
		{
			LevelFlowSection.SelfIncrementId = 0;
		}

		// Token: 0x0604567B RID: 284283 RVA: 0x01134434 File Offset: 0x01132634
		public static void ResetStaticDefaultValue()
		{
			LevelFlowSection.SelfIncrementId = 0;
		}

		// Token: 0x04024376 RID: 148342
		public readonly int SectionId;

		// Token: 0x04024377 RID: 148343
		private static int SelfIncrementId;

		// Token: 0x04024378 RID: 148344
		private readonly List<LevelFlowNode> NodeList = new List<LevelFlowNode>();

		// Token: 0x04024379 RID: 148345
		private readonly List<LevelFlowNode> ResetNodeList = new List<LevelFlowNode>();

		// Token: 0x0402437A RID: 148346
		private readonly HashSet<LevelFlowNode> NodeSet = new HashSet<LevelFlowNode>();

		// Token: 0x0402437B RID: 148347
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowSection, bool> CompleteCallBack;

		// Token: 0x0402437C RID: 148348
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<LevelFlowSection, bool> ResetCompleteCallBack;
	}
}
