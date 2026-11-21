using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000876 RID: 2166
public class ActivityNewPlayerSupportStartupView : UiViewBase
{
	// Token: 0x0600623B RID: 25147 RVA: 0x001F520E File Offset: 0x001F340E
	[NullableContext(1)]
	public ActivityNewPlayerSupportStartupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x001F5218 File Offset: 0x001F3418
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick))
		};
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x001F5269 File Offset: 0x001F3469
	protected override void OnBeforeShow()
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.NewPlayerSupport);
		activityData.RecordActivityFirstShow();
		activityData.AlreadyStartView = true;
	}

	// Token: 0x0600623E RID: 25150 RVA: 0x001F528C File Offset: 0x001F348C
	private void OnCloseBtnClick()
	{
		this.GotoActivityViewAndCloseSelf();
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x001F5294 File Offset: 0x001F3494
	private void GotoActivityViewAndCloseSelf()
	{
		base.CloseMe(null);
		int id = ActivityNewPlayerSupportController.Instance.ActivityData.Id;
		if (id != 0)
		{
			ActivityController.Instance.OpenActivityById(id, EActivityViewOpenType.Other, null, null);
		}
	}

	// Token: 0x02006BBC RID: 27580
	private static class EComponentType
	{
		// Token: 0x040236C3 RID: 145091
		public const int CloseBtn = 0;
	}
}
