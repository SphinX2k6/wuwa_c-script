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

// Token: 0x0200064E RID: 1614
[NullableContext(1)]
[Nullable(0)]
public class BeginnerCarnivalMainView : UiViewBase
{
	// Token: 0x06004AF0 RID: 19184 RVA: 0x00197307 File Offset: 0x00195507
	public BeginnerCarnivalMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004AF1 RID: 19185 RVA: 0x00197328 File Offset: 0x00195528
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

	// Token: 0x06004AF2 RID: 19186 RVA: 0x0019746F File Offset: 0x0019566F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBeginnerCarnivalChoseRole, new Action(this.OnRefreshBeginnerCarnivalChoseRole));
		EventSystem.Instance.Add(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06004AF3 RID: 19187 RVA: 0x001974A9 File Offset: 0x001956A9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBeginnerCarnivalChoseRole, new Action(this.OnRefreshBeginnerCarnivalChoseRole));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x001974E3 File Offset: 0x001956E3
	private void OnRefreshBeginnerCarnivalChoseRole()
	{
		this.RefreshView();
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x001974EC File Offset: 0x001956EC
	protected override UniTask OnBeforeStartAsync()
	{
		BeginnerCarnivalMainView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BeginnerCarnivalMainView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x00197530 File Offset: 0x00195730
	protected override void OnStart()
	{
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		int choseRoleId = beginnerCarnivalData.ChoseRoleId;
		if (!beginnerCarnivalData.GetHaveChoseRoleViewEnter() && choseRoleId <= 0)
		{
			this.OnClickChoseRoleBtn();
		}
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x0019755F File Offset: 0x0019575F
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x00197568 File Offset: 0x00195768
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

	// Token: 0x06004AF9 RID: 19193 RVA: 0x001977C0 File Offset: 0x001959C0
	private void OnClickSelectRoleBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalRoleTaskView, null, null);
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x001977D3 File Offset: 0x001959D3
	private void OnClickChoseRoleBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.BeginnerCarnivalChoseRoleView, null, delegate(bool success, int viewId)
		{
			base.AddChildViewById(viewId);
		});
	}

	// Token: 0x06004AFB RID: 19195 RVA: 0x001977F4 File Offset: 0x001959F4
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

	// Token: 0x0400375F RID: 14175
	private const int ROLE_TAB_INDEX = 5;

	// Token: 0x04003760 RID: 14176
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003761 RID: 14177
	private readonly Dictionary<int, BeginnerCarnivalSpineItem> SpineItemMap = new Dictionary<int, BeginnerCarnivalSpineItem>();

	// Token: 0x04003762 RID: 14178
	private readonly List<BeginnerCarnivalTaskType> TaskTypeList = new List<BeginnerCarnivalTaskType>();
}
