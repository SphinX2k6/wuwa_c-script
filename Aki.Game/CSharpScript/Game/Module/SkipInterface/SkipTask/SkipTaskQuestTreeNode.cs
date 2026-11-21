using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B5F RID: 15199
	public class SkipTaskQuestTreeNode : SkipTask
	{
		// Token: 0x06027089 RID: 159881 RVA: 0x00AED784 File Offset: 0x00AEB984
		protected unsafe override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			object obj = data[0];
			string text = (string)data[1];
			int nodeId = 0;
			if (obj is int)
			{
				int num = (int)obj;
				nodeId = num;
			}
			else
			{
				string text2 = obj as string;
				if (text2 != null)
				{
					nodeId = (string.IsNullOrEmpty(text2) ? 0 : int.Parse(text2));
				}
			}
			bool flag = false;
			int num2 = 0;
			QuestTreeNodeData nodeDataFromNodeId = QuestTreeModel.Instance.GetNodeDataFromNodeId(nodeId);
			if (nodeDataFromNodeId != null)
			{
				Span<int> questArrayBytes = nodeDataFromNodeId.Config.GetQuestArrayBytes();
				for (int i = questArrayBytes.Length - 1; i >= 0; i--)
				{
					int num3 = *questArrayBytes[i];
					Quest quest = QuestNewModel.Instance.GetQuest(num3);
					if (quest != null && quest.CanShowInUiPanel())
					{
						flag = true;
						num2 = num3;
						break;
					}
				}
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, num2, null);
			if (!flag && text != "0")
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(text, Array.Empty<object>());
			}
			base.Finish();
		}

		// Token: 0x040154E2 RID: 87266
		[Nullable(1)]
		private const string DEFAULT_PARAM = "0";
	}
}
