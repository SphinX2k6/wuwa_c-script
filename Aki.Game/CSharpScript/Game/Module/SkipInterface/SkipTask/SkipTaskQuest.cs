using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B5D RID: 15197
	public class SkipTaskQuest : SkipTask
	{
		// Token: 0x06027085 RID: 159877 RVA: 0x00AED648 File Offset: 0x00AEB848
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			object obj = data[0];
			string text = (data.Length > 1) ? ((string)data[1]) : null;
			int num = 0;
			if (obj is int)
			{
				int num2 = (int)obj;
				num = num2;
			}
			else
			{
				string text2 = obj as string;
				if (text2 != null)
				{
					num = (string.IsNullOrEmpty(text2) ? 0 : int.Parse(text2));
				}
			}
			bool flag = false;
			if (num != 0)
			{
				Quest quest = QuestNewModel.Instance.GetQuest(num);
				if (quest != null && quest.CanShowInUiPanel())
				{
					flag = true;
				}
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, num, null);
			if (!flag && text != "0")
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(text, Array.Empty<object>());
			}
			base.Finish();
		}

		// Token: 0x040154E1 RID: 87265
		[Nullable(1)]
		private const string DEFAULT_PARAM = "0";
	}
}
