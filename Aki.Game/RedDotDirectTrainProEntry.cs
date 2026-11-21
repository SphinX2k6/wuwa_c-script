using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;

// Token: 0x020028A8 RID: 10408
public class RedDotDirectTrainProEntry : RedDotBase
{
	// Token: 0x0601A640 RID: 108096 RVA: 0x0082A700 File Offset: 0x00828900
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A641 RID: 108097 RVA: 0x0082A71E File Offset: 0x0082891E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A642 RID: 108098 RVA: 0x0082A73C File Offset: 0x0082893C
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A643 RID: 108099 RVA: 0x0082A73F File Offset: 0x0082893F
	protected override bool OnCheck(int uId = 0)
	{
		if (!ActivityDirectTrainHelper.IsProOpen)
		{
			return false;
		}
		DirectTrainModel instance = DirectTrainModel.Instance;
		return instance != null && instance.HasUnReadSubActivity();
	}
}
