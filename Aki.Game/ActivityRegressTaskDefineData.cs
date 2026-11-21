using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200095D RID: 2397
public class ActivityRegressTaskDefineData : IStaticVariableResetter
{
	// Token: 0x06006958 RID: 26968 RVA: 0x0020DB4B File Offset: 0x0020BD4B
	static ActivityRegressTaskDefineData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressTaskDefineData.CreateStaticDefaultValue), new Action(ActivityRegressTaskDefineData.ResetStaticDefaultValue));
	}

	// Token: 0x06006959 RID: 26969 RVA: 0x0020DB6C File Offset: 0x0020BD6C
	public static void CreateStaticDefaultValue()
	{
		ActivityRegressTaskDefineData.taskSubViewTabDataMap = new Dictionary<EActivityRegressTaskSubViewType, ITaskSubViewTabData>
		{
			{
				EActivityRegressTaskSubViewType.MainTask,
				new ITaskSubViewTabData
				{
					TitleKey = "RecallActivity_Task_Title",
					IconName = "SP_IconCircumfluence1",
					Type = EActivityRegressTaskSubViewType.MainTask,
					RedDotName = new ERedDotName?(ERedDotName.ActivityRegressConstantTask)
				}
			},
			{
				EActivityRegressTaskSubViewType.Cultivate,
				new ITaskSubViewTabData
				{
					TitleKey = "Recall_Cultivation_Task_Title",
					IconName = "SP_IconCircumfluence2",
					Type = EActivityRegressTaskSubViewType.Cultivate,
					RedDotName = new ERedDotName?(ERedDotName.ActivityRegressCultivate)
				}
			},
			{
				EActivityRegressTaskSubViewType.DoubleDrop,
				new ITaskSubViewTabData
				{
					TitleKey = "Recall_Double_Reward_Title",
					IconName = "SP_IconCircumfluence3",
					Type = EActivityRegressTaskSubViewType.DoubleDrop,
					RedDotName = new ERedDotName?(ERedDotName.ActivityRegressDoubleDrop)
				}
			}
		};
	}

	// Token: 0x0600695A RID: 26970 RVA: 0x0020DC46 File Offset: 0x0020BE46
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressTaskDefineData.taskSubViewTabDataMap = null;
	}

	// Token: 0x040042D1 RID: 17105
	[Nullable(2)]
	public static Dictionary<EActivityRegressTaskSubViewType, ITaskSubViewTabData> taskSubViewTabDataMap;
}
