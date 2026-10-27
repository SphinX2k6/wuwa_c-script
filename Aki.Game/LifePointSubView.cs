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

// Token: 0x0200129E RID: 4766
[NullableContext(2)]
[Nullable(0)]
public class LifePointSubView : ActivitySubViewBase
{
	// Token: 0x06008290 RID: 33424 RVA: 0x001BB4CC File Offset: 0x001B96CC
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

	// Token: 0x06008291 RID: 33425 RVA: 0x001BB538 File Offset: 0x001B9738
	protected override UniTask OnBeforeStartAsync()
	{
		LifePointSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LifePointSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008292 RID: 33426 RVA: 0x001BB57B File Offset: 0x001B977B
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

	// Token: 0x06008293 RID: 33427 RVA: 0x001BB599 File Offset: 0x001B9799
	protected override void OnStart()
	{
		this.LifePointActivityData = (this.ActivityBaseData as LifePointDrawActivityData);
	}

	// Token: 0x06008294 RID: 33428 RVA: 0x001BB5AC File Offset: 0x001B97AC
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

	// Token: 0x06008295 RID: 33429 RVA: 0x001BB600 File Offset: 0x001B9800
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

	// Token: 0x06008296 RID: 33430 RVA: 0x001BB63C File Offset: 0x001B983C
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

	// Token: 0x04003AED RID: 15085
	private LifePointDrawActivityData LifePointActivityData;

	// Token: 0x04003AEE RID: 15086
	private ActivitySubViewGeneralInfo InfoComponent;

	// Token: 0x020078B3 RID: 30899
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027C4D RID: 162893
		public const int InfoItem = 0;

		// Token: 0x04027C4E RID: 162894
		public const int ProgressText = 1;
	}
}
