using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02000B29 RID: 2857
[NullableContext(1)]
public interface IActivityControllerBase
{
	// Token: 0x060075FA RID: 30202
	bool Init();

	// Token: 0x060075FB RID: 30203
	bool Clear();

	// Token: 0x060075FC RID: 30204
	string GetActivityResource(ActivityBaseData data);

	// Token: 0x060075FD RID: 30205
	ActivitySubViewBase CreateSubPageComponent(ActivityBaseData data);

	// Token: 0x060075FE RID: 30206
	void OpenView(ActivityBaseData data);

	// Token: 0x060075FF RID: 30207
	[NullableContext(0)]
	UniTask<bool> OpenViewByViewName(EUiViewName viewName, int activityId = 0);

	// Token: 0x06007600 RID: 30208
	ActivityBaseData CreateActivityData(ActivityData data);

	// Token: 0x06007601 RID: 30209
	bool GetIsOpeningActivityRelativeView();

	// Token: 0x06007602 RID: 30210
	bool GetActivityLevelUnlockState(int levelId);

	// Token: 0x06007603 RID: 30211
	bool GetActivityMapMarkState(int markId);

	// Token: 0x06007604 RID: 30212
	void OnActivityFirstUnlock(ActivityBaseData data);

	// Token: 0x06007605 RID: 30213
	void OnShowActivityFirstUnlockView(ActivityBaseData data);
}
