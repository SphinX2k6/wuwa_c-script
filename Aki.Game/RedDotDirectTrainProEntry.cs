using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain;
using CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity;

// Token: 0x02003336 RID: 13110
public class RedDotDirectTrainProEntry : RedDotBase
{
	// Token: 0x0601C948 RID: 117064 RVA: 0x0080413C File Offset: 0x0080233C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C949 RID: 117065 RVA: 0x0080415A File Offset: 0x0080235A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.ActivityDirectTrainRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C94A RID: 117066 RVA: 0x00804178 File Offset: 0x00802378
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601C94B RID: 117067 RVA: 0x0080417B File Offset: 0x0080237B
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
