using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02000B3C RID: 2876
public abstract class ActivityCaptionDecorationTagBase : UiPanelBase
{
	// Token: 0x060076EF RID: 30447
	public abstract UniTask OnCaptionTagRefresh(int activityId);
}
