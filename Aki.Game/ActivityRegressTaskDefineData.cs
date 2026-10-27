using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014A9 RID: 5289
public class ActivityRegressTaskDefineData : IStaticVariableResetter
{
	// Token: 0x060095C3 RID: 38339 RVA: 0x00204BE3 File Offset: 0x00202DE3
	static ActivityRegressTaskDefineData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRegressTaskDefineData.CreateStaticDefaultValue), new Action(ActivityRegressTaskDefineData.ResetStaticDefaultValue));
	}

	// Token: 0x060095C4 RID: 38340 RVA: 0x00204C04 File Offset: 0x00202E04
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

	// Token: 0x060095C5 RID: 38341 RVA: 0x00204CDE File Offset: 0x00202EDE
	public static void ResetStaticDefaultValue()
	{
		ActivityRegressTaskDefineData.taskSubViewTabDataMap = null;
	}

	// Token: 0x04004239 RID: 16953
	[Nullable(2)]
	public static Dictionary<EActivityRegressTaskSubViewType, ITaskSubViewTabData> taskSubViewTabDataMap;
}
