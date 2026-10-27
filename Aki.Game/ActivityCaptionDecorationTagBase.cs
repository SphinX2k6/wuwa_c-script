using System;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001684 RID: 5764
public abstract class ActivityCaptionDecorationTagBase : UiPanelBase
{
	// Token: 0x0600A311 RID: 41745
	public abstract UniTask OnCaptionTagRefresh(int activityId);
}
