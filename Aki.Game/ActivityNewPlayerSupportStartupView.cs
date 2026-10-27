using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020013C2 RID: 5058
public class ActivityNewPlayerSupportStartupView : UiViewBase
{
	// Token: 0x06008EA6 RID: 36518 RVA: 0x001EC6EE File Offset: 0x001EA8EE
	[NullableContext(1)]
	public ActivityNewPlayerSupportStartupView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008EA7 RID: 36519 RVA: 0x001EC6F8 File Offset: 0x001EA8F8
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

	// Token: 0x06008EA8 RID: 36520 RVA: 0x001EC749 File Offset: 0x001EA949
	protected override void OnBeforeShow()
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.NewPlayerSupport);
		activityData.RecordActivityFirstShow();
		activityData.AlreadyStartView = true;
	}

	// Token: 0x06008EA9 RID: 36521 RVA: 0x001EC76C File Offset: 0x001EA96C
	private void OnCloseBtnClick()
	{
		this.GotoActivityViewAndCloseSelf();
	}

	// Token: 0x06008EAA RID: 36522 RVA: 0x001EC774 File Offset: 0x001EA974
	private void GotoActivityViewAndCloseSelf()
	{
		base.CloseMe(null);
		int id = ActivityNewPlayerSupportController.Instance.ActivityData.Id;
		if (id != 0)
		{
			ActivityController.Instance.OpenActivityById(id, EActivityViewOpenType.Other, null, null);
		}
	}

	// Token: 0x02007A36 RID: 31286
	private static class EComponentType
	{
		// Token: 0x040283A6 RID: 164774
		public const int CloseBtn = 0;
	}
}
