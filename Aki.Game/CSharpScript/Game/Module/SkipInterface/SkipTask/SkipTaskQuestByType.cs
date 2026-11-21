using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B5E RID: 15198
	public class SkipTaskQuestByType : SkipTask
	{
		// Token: 0x06027087 RID: 159879 RVA: 0x00AED708 File Offset: 0x00AEB908
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			int num = int.Parse((string)data[0]);
			if (num < 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, null, null);
				return;
			}
			Quest firstShowQuestByType = QuestNewModel.Instance.GetFirstShowQuestByType(num);
			int? num2 = (firstShowQuestByType != null) ? new int?(firstShowQuestByType.Id) : null;
			UiManager.Instance.OpenView(EUiViewName.QuestView, num2, null);
			base.Finish();
		}
	}
}
