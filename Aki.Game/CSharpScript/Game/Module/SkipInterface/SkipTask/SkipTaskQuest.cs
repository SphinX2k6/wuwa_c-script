using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB3 RID: 19379
	public class SkipTaskQuest : SkipTask
	{
		// Token: 0x060322F4 RID: 205556 RVA: 0x00BA939C File Offset: 0x00BA759C
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

		// Token: 0x0401AB8C RID: 109452
		[Nullable(1)]
		private const string DEFAULT_PARAM = "0";
	}
}
