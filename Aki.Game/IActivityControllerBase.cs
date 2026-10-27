using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001671 RID: 5745
[NullableContext(1)]
public interface IActivityControllerBase
{
	// Token: 0x0600A21C RID: 41500
	bool Init();

	// Token: 0x0600A21D RID: 41501
	bool Clear();

	// Token: 0x0600A21E RID: 41502
	string GetActivityResource(ActivityBaseData data);

	// Token: 0x0600A21F RID: 41503
	ActivitySubViewBase CreateSubPageComponent(ActivityBaseData data);

	// Token: 0x0600A220 RID: 41504
	void OpenView(ActivityBaseData data);

	// Token: 0x0600A221 RID: 41505
	[NullableContext(0)]
	UniTask<bool> OpenViewByViewName(EUiViewName viewName, int activityId = 0);

	// Token: 0x0600A222 RID: 41506
	ActivityBaseData CreateActivityData(ActivityData data);

	// Token: 0x0600A223 RID: 41507
	bool GetIsOpeningActivityRelativeView();

	// Token: 0x0600A224 RID: 41508
	bool GetActivityLevelUnlockState(int levelId);

	// Token: 0x0600A225 RID: 41509
	bool GetActivityMapMarkState(int markId);

	// Token: 0x0600A226 RID: 41510
	void OnActivityFirstUnlock(ActivityBaseData data);

	// Token: 0x0600A227 RID: 41511
	void OnShowActivityFirstUnlockView(ActivityBaseData data);
}
