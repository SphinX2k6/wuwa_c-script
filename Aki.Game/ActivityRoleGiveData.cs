using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000973 RID: 2419
public class ActivityRoleGiveData : ActivityBaseData
{
	// Token: 0x06006A2A RID: 27178 RVA: 0x00211420 File Offset: 0x0020F620
	[NullableContext(1)]
	protected unsafe override void PhraseEx(ActivityData data)
	{
		TraceMoonPhaseData traceMoonPhaseData = data.TraceMoonPhaseData;
		ActivityRoleGiveController.Instance.CurrentActivityId = data.Id;
		if (traceMoonPhaseData == null)
		{
			Log.Instance.Error(ELogModule.MoonChasing, ELogAuthor.LPH, "ActivityRoleGiveData无数据", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.MoonChasing;
		ELogAuthor author = ELogAuthor.LPH;
		string message = "ActivityRoleGiveData Refresh:";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsGetReward:", traceMoonPhaseData.Reward);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActivityId:", data.Id);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.IsGetReward = traceMoonPhaseData.Reward;
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x002114DD File Offset: 0x0020F6DD
	public TrackMoonPhaseActivity? GetExtraConfig()
	{
		return ConfigTrackMoonPhaseActivityById.GetConfig(ActivityRoleGiveController.Instance.CurrentActivityId, true);
	}

	// Token: 0x06006A2C RID: 27180 RVA: 0x002114F0 File Offset: 0x0020F6F0
	public override bool GetExDataRedPointShowState()
	{
		TrackMoonPhaseActivity? extraConfig = this.GetExtraConfig();
		MoonChasingModel instance = MoonChasingModel.Instance;
		int? num = (instance != null) ? new int?(instance.GetPopularityValue()) : null;
		return num != null && extraConfig != null && !this.IsGetReward && num.Value >= extraConfig.Value.PopularityNeed;
	}

	// Token: 0x04004307 RID: 17159
	public bool IsGetReward;
}
