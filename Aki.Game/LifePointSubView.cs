using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000752 RID: 1874
[NullableContext(2)]
[Nullable(0)]
public class LifePointSubView : ActivitySubViewBase
{
	// Token: 0x06005627 RID: 22055 RVA: 0x001C4198 File Offset: 0x001C2398
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x001C4204 File Offset: 0x001C2404
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005629 RID: 22057 RVA: 0x001C4247 File Offset: 0x001C2447
	private void FunctionExecute(ActivityBaseData data)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			if (unFinishPreGuideQuestId > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			WorldMapViewOpenParams data2 = new WorldMapViewOpenParams
			{
				MarkId = new int?(LifePointDrawConfig.Instance.GetLifePointDrawActivityById(this.ActivityBaseData.Id).Value.MarkId),
				MarkType = EMarkType.None,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data2, null);
		});
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x001C4265 File Offset: 0x001C2465
	protected override void OnStart()
	{
		this.LifePointActivityData = (this.ActivityBaseData as LifePointDrawActivityData);
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x001C4278 File Offset: 0x001C2478
	protected override void OnBeforeShow()
	{
		if (this.ActivityBaseData.GetUnFinishPreGuideQuestId() > 0)
		{
			this.InfoComponent.SetBtnText("LifePointQuestUnFinish", Array.Empty<object>());
		}
		else
		{
			this.InfoComponent.SetBtnText("LifePointQuestFinish", Array.Empty<object>());
		}
		this.RefreshProgressText();
		this.UpdateRedDotActivity();
	}

	// Token: 0x0600562C RID: 22060 RVA: 0x001C42CC File Offset: 0x001C24CC
	public void RefreshProgressText()
	{
		string progressByActivityId = LifePointDrawModel.Instance.GetProgressByActivityId(this.LifePointActivityData.Id, "Colorful_Finish_Progress_Activity");
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(progressByActivityId, true);
	}

	// Token: 0x0600562D RID: 22061 RVA: 0x001C4308 File Offset: 0x001C2508
	private void UpdateRedDotActivity()
	{
		bool redPointShowState = this.LifePointActivityData.RedPointShowState;
		ActivitySubViewGeneralInfo infoComponent = this.InfoComponent;
		if (infoComponent == null)
		{
			return;
		}
		infoComponent.SetFunctionRedDotVisible(redPointShowState);
	}

	// Token: 0x04003B85 RID: 15237
	private LifePointDrawActivityData LifePointActivityData;

	// Token: 0x04003B86 RID: 15238
	private ActivitySubViewGeneralInfo InfoComponent;

	// Token: 0x02006A3E RID: 27198
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022F7E RID: 143230
		public const int InfoItem = 0;

		// Token: 0x04022F7F RID: 143231
		public const int ProgressText = 1;
	}
}
