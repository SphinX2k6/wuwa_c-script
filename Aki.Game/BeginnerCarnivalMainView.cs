using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200119A RID: 4506
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalMainView : UiViewBase
{
	// Token: 0x06007759 RID: 30553 RVA: 0x0018E723 File Offset: 0x0018C923
	public BeginnerCarnivalMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600775A RID: 30554 RVA: 0x0018E744 File Offset: 0x0018C944
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickSelectRoleBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickChoseRoleBtn))
		};
	}

	// Token: 0x0600775B RID: 30555 RVA: 0x0018E88B File Offset: 0x0018CA8B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBeginnerCarnivalChoseRole, new Action(this.OnRefreshBeginnerCarnivalChoseRole));
		EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x0600775C RID: 30556 RVA: 0x0018E8C5 File Offset: 0x0018CAC5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBeginnerCarnivalChoseRole, new Action(this.OnRefreshBeginnerCarnivalChoseRole));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x0600775D RID: 30557 RVA: 0x0018E8FF File Offset: 0x0018CAFF
	private void OnRefreshBeginnerCarnivalChoseRole()
	{
		this.RefreshView();
	}

	// Token: 0x0600775E RID: 30558 RVA: 0x0018E908 File Offset: 0x0018CB08
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600775F RID: 30559 RVA: 0x0018E94C File Offset: 0x0018CB4C
	protected override void OnStart()
	{
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		int choseRoleId = beginnerCarnivalData.ChoseRoleId;
		if (!beginnerCarnivalData.GetHaveChoseRoleViewEnter() && choseRoleId <= 0)
		{
			this.OnClickChoseRoleBtn();
		}
	}

	// Token: 0x06007760 RID: 30560 RVA: 0x0018E97B File Offset: 0x0018CB7B
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06007761 RID: 30561 RVA: 0x0018E984 File Offset: 0x0018CB84
	private void RefreshView()
	{
		int num = 0;
		foreach (BeginnerCarnivalTaskType beginnerCarnivalTaskType in this.TaskTypeList)
		{
			num++;
			beginnerCarnivalTaskType.RefreshItem(num);
		}
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		ActivityTask taskDataById = beginnerCarnivalData.GetTaskDataById(beginnerCarnivalData.GetRoleTaskId);
		if (taskDataById == null)
		{
			return;
		}
		bool flag = taskDataById.Status == ActivityTaskState.ActivityTaskTaken;
		int choseRoleId = beginnerCarnivalData.ChoseRoleId;
		bool flag2 = choseRoleId > 0;
		base.GetItem(8).SetUIActive(!flag2);
		if (flag2)
		{
			NewbieCarnivalRole value = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalRole(choseRoleId).Value;
			foreach (KeyValuePair<int, BeginnerCarnivalSpineItem> keyValuePair in this.SpineItemMap)
			{
				keyValuePair.Value.SetUiActive(false);
			}
			BeginnerCarnivalSpineItem item;
			if (!this.SpineItemMap.TryGetValue(choseRoleId, out item) || item == null)
			{
				item = new BeginnerCarnivalSpineItem();
				item.CreateThenShowByResourceIdAsync(value.MainViewSpineItem, base.GetItem(7), false).ContinueWith(delegate()
				{
					item.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
				}).Forget();
				this.SpineItemMap[choseRoleId] = item;
			}
			else
			{
				item.SetUiActive(true);
				item.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			}
		}
		NewbieCarnivalParam? newbieCarnivalParam = BeginnerCarnivalConfig.Instance.GetNewbieCarnivalParam(BeginnerCarnivalController.Instance.ActivityId);
		base.GetText(10).SetText("<color=#f5cf47>" + beginnerCarnivalData.GetCurrentItemCount().ToString() + "</color>/" + ((newbieCarnivalParam != null) ? new int?(newbieCarnivalParam.GetValueOrDefault().AllCount) : null).ToString(), true);
		base.GetItem(9).SetUIActive(beginnerCarnivalData.GetRoleGetTaskTabRedDotShow(5));
		base.GetButton(5).RootUIComp.Get().SetUIActive(!flag);
	}

	// Token: 0x06007762 RID: 30562 RVA: 0x0018EBDC File Offset: 0x0018CDDC
	private void OnClickSelectRoleBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalRoleTaskView, null, null);
	}

	// Token: 0x06007763 RID: 30563 RVA: 0x0018EBEF File Offset: 0x0018CDEF
	private void OnClickChoseRoleBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalChoseRoleView, null, delegate(bool success, int viewId)
		{
			base.AddChildViewById(viewId);
		});
	}

	// Token: 0x06007764 RID: 30564 RVA: 0x0018EC10 File Offset: 0x0018CE10
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (closeActivities.Contains(BeginnerCarnivalController.Instance.ActivityId))
		{
			Action value = delegate()
			{
				UiManager.Instance.ResetToBattleView(null);
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
			confirmBoxDataNew.FunctionMap.Add(1, value);
			confirmBoxDataNew.FunctionMap.Add(0, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x040036C6 RID: 14022
	private const int ROLE_TAB_INDEX = 5;

	// Token: 0x040036C7 RID: 14023
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040036C8 RID: 14024
	private readonly Dictionary<int, BeginnerCarnivalSpineItem> SpineItemMap = new Dictionary<int, BeginnerCarnivalSpineItem>();

	// Token: 0x040036C9 RID: 14025
	private readonly List<BeginnerCarnivalTaskType> TaskTypeList = new List<BeginnerCarnivalTaskType>();
}
