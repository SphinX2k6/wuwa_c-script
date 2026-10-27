using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02002C25 RID: 11301
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class TutorialController : UiControllerBase
{
	// Token: 0x060178BE RID: 96446 RVA: 0x005FCA34 File Offset: 0x005FAC34
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060178BF RID: 96447 RVA: 0x005FCA52 File Offset: 0x005FAC52
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060178C0 RID: 96448 RVA: 0x005FCA70 File Offset: 0x005FAC70
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TutorialUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTutorialUnlockedIdsNotify));
	}

	// Token: 0x060178C1 RID: 96449 RVA: 0x005FCA8E File Offset: 0x005FAC8E
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TutorialUnlockNotify);
	}

	// Token: 0x060178C2 RID: 96450 RVA: 0x005FCAA0 File Offset: 0x005FACA0
	public void OpenExclusiveTutorial(EExclusiveTutorialType type)
	{
		TutorialViewParam param = new TutorialViewParam
		{
			ExclusiveType = new EExclusiveTutorialType?(type)
		};
		UiManager.Instance.OpenView(EUiViewName.TutorialPopView, param, null);
	}

	// Token: 0x060178C3 RID: 96451 RVA: 0x005FCAD0 File Offset: 0x005FACD0
	[NullableContext(2)]
	private void OnTutorialUnlockedIdsNotify(IMessage msg, Net.CallbackStatus _)
	{
		foreach (TutorialInfo tutorialInfo in ((TutorialUnlockNotify)msg).UnLockList)
		{
			TutorialModel.Instance.UpdateUnlockTutorials(tutorialInfo);
		}
	}

	// Token: 0x060178C4 RID: 96452 RVA: 0x005FCB28 File Offset: 0x005FAD28
	private void OnDataDone()
	{
		TutorialModel.Instance.InitDefaultUnlockTutorials();
		TutorialInfoRequest message = TutorialInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.TutorialInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TutorialInfoResponse tutorialInfoResponse = (TutorialInfoResponse)msg;
			if (tutorialInfoResponse == null)
			{
				return;
			}
			TutorialModel.Instance.InitUnlockTutorials(tutorialInfoResponse.UnLockList);
			List<TutorialItemData> unlockedTutorialDataByType = TutorialModel.Instance.GetUnlockedTutorialDataByType(ETutorialType.All, EExclusiveTutorialType.None);
			if (unlockedTutorialDataByType != null && unlockedTutorialDataByType.Count > 0)
			{
				TutorialModel.Instance.InvokeTutorialRedDot(unlockedTutorialDataByType[0].SavedData);
			}
			TutorialModel.Instance.InitTutorialTotalData();
		}, 0);
	}

	// Token: 0x060178C5 RID: 96453 RVA: 0x005FCB75 File Offset: 0x005FAD75
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TutorialView, new Func<EUiViewName, object, bool>(this.CanOpenView), "TutorialController.CanOpenView");
	}

	// Token: 0x060178C6 RID: 96454 RVA: 0x005FCB97 File Offset: 0x005FAD97
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TutorialView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x060178C7 RID: 96455 RVA: 0x005FCBB4 File Offset: 0x005FADB4
	public void OnTutorialTipExistChanged(bool isExist)
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnTutorialTipExistChanged, isExist);
	}

	// Token: 0x060178C8 RID: 96456 RVA: 0x005FCBC8 File Offset: 0x005FADC8
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10022) && (!UiManager.Instance.IsViewOpen(EUiViewName.GuideTutorialTipsView) || UiManager.Instance.IsViewOpen(EUiViewName.FunctionView) || GuideModel.Instance.HaveCurrentTutorial());
	}

	// Token: 0x060178C9 RID: 96457 RVA: 0x005FCC19 File Offset: 0x005FAE19
	public void OpenTutorialView()
	{
		UiManager.Instance.OpenView(EUiViewName.TutorialView, null, null);
	}

	// Token: 0x060178CA RID: 96458 RVA: 0x005FCC2C File Offset: 0x005FAE2C
	public void GmUnlockOneTutorial(int tutorialId)
	{
		TutorialUnlockRequest tutorialUnlockRequest = TutorialUnlockRequest.Create();
		tutorialUnlockRequest.Id = tutorialId;
		Net.Instance.Call(ERequestMessageId.TutorialUnlockRequest, tutorialUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TutorialUnlockResponse tutorialUnlockResponse = (TutorialUnlockResponse)msg;
			if (tutorialUnlockResponse == null)
			{
				return;
			}
			if (tutorialUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				return;
			}
			TutorialModel.Instance.UpdateUnlockTutorials(tutorialUnlockResponse.UnLockInfo);
		}, 0);
	}

	// Token: 0x060178CB RID: 96459 RVA: 0x005FCC78 File Offset: 0x005FAE78
	public void RemoveRedDotTutorialId(int tutorialId)
	{
		TutorialModel.Instance.RemoveRedDotTutorialId(tutorialId);
		GuideTutorial? guideTutorial = GuideConfig.Instance.GetGuideTutorial(tutorialId);
		if (guideTutorial != null && guideTutorial.GetValueOrDefault().DefaultUnlock)
		{
			this.TryUnlockAndOpenTutorialTip(tutorialId, delegate(bool success)
			{
				if (success)
				{
					this.SendGetAwardRequest(tutorialId);
				}
			});
			return;
		}
		this.SendGetAwardRequest(tutorialId);
	}

	// Token: 0x060178CC RID: 96460 RVA: 0x005FCCFC File Offset: 0x005FAEFC
	private void SendGetAwardRequest(int tutorialId)
	{
		if (!TutorialConfig.Instance.HasUnlockReward(tutorialId))
		{
			return;
		}
		TutorialReceiveRequest tutorialReceiveRequest = TutorialReceiveRequest.Create();
		tutorialReceiveRequest.Id = tutorialId;
		Net.Instance.Call(ERequestMessageId.TutorialReceiveRequest, tutorialReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TutorialReceiveResponse tutorialReceiveResponse = (TutorialReceiveResponse)msg;
			if (tutorialReceiveResponse == null)
			{
				return;
			}
			if (tutorialReceiveResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				return;
			}
			int num = tutorialReceiveResponse.ItemMap.Keys.First<int>();
			int num2 = tutorialReceiveResponse.ItemMap[num];
			List<ValueTuple<int, int>> rewardList = TutorialModel.Instance.RewardList;
			if (rewardList.Count > 0)
			{
				for (int i = 0; i < rewardList.Count; i++)
				{
					int item = rewardList[i].Item1;
					int item2 = rewardList[i].Item2;
					if (item == num)
					{
						rewardList[i] = new ValueTuple<int, int>(item, item2 + num2);
						return;
					}
				}
				return;
			}
			rewardList.Add(new ValueTuple<int, int>(num, num2));
		}, 0);
	}

	// Token: 0x060178CD RID: 96461 RVA: 0x005FCD54 File Offset: 0x005FAF54
	public void TryOpenAwardUiViewPending()
	{
		if (TutorialModel.Instance.RewardList.Count > 0)
		{
			ItemHintController.Instance.AddItemRewardInfoList(TutorialModel.Instance.RewardList);
			TutorialModel.Instance.RewardList.Clear();
		}
	}

	// Token: 0x060178CE RID: 96462 RVA: 0x005FCD8C File Offset: 0x005FAF8C
	[NullableContext(2)]
	public void TryUnlockAndOpenTutorialTip(int tutorialId, Action<bool> finishCallback = null)
	{
		TutorialController.<>c__DisplayClass16_0 CS$<>8__locals1 = new TutorialController.<>c__DisplayClass16_0();
		CS$<>8__locals1.finishCallback = finishCallback;
		CS$<>8__locals1.tutorialCfg = GuideConfig.Instance.GetGuideTutorial(tutorialId);
		TutorialController.<>c__DisplayClass16_0 CS$<>8__locals2 = CS$<>8__locals1;
		int num = (CS$<>8__locals2.tutorialCfg != null && CS$<>8__locals2.tutorialCfg.GetValueOrDefault().CopiedFrom != 0) ? CS$<>8__locals1.tutorialCfg.Value.CopiedFrom : tutorialId;
		GuideTutorial? guideTutorial = GuideConfig.Instance.GetGuideTutorial(num);
		TutorialController.<>c__DisplayClass16_0 CS$<>8__locals3 = CS$<>8__locals1;
		int? num2 = (CS$<>8__locals3.tutorialCfg != null) ? new int?(CS$<>8__locals3.tutorialCfg.GetValueOrDefault().PageId().Length) : null;
		int? num3;
		if (guideTutorial == null)
		{
			num3 = null;
		}
		else
		{
			int[] array = guideTutorial.GetValueOrDefault().PageId();
			num3 = ((array != null) ? new int?(array.Length) : null);
		}
		int? num4 = num3;
		if (num2.GetValueOrDefault() == num4.GetValueOrDefault() & num2 != null == (num4 != null))
		{
			TutorialController.<>c__DisplayClass16_0 CS$<>8__locals4 = CS$<>8__locals1;
			int? num5 = (CS$<>8__locals4.tutorialCfg != null) ? new int?(CS$<>8__locals4.tutorialCfg.GetValueOrDefault().PageId().Length) : null;
			int num6 = 0;
			for (;;)
			{
				int num7 = num6;
				num2 = num5;
				if (!(num7 < num2.GetValueOrDefault() & num2 != null))
				{
					goto Block_13;
				}
				TutorialController.<>c__DisplayClass16_0 CS$<>8__locals5 = CS$<>8__locals1;
				int? num8 = (CS$<>8__locals5.tutorialCfg != null) ? new int?(CS$<>8__locals5.tutorialCfg.GetValueOrDefault().PageId()[num6]) : null;
				int? num9 = (guideTutorial != null) ? new int?(guideTutorial.GetValueOrDefault().PageId()[num6]) : null;
				num4 = num8;
				num2 = num9;
				if (!(num4.GetValueOrDefault() == num2.GetValueOrDefault() & num4 != null == (num2 != null)))
				{
					break;
				}
				num6++;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Tutorial;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "复制图文引导和源图文引导内容不一致";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", tutorialId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action<bool> finishCallback2 = CS$<>8__locals1.finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2(false);
			return;
			Block_13:
			if (TutorialModel.Instance.GetSavedDataById(num) != null)
			{
				TutorialController.<>c__DisplayClass16_0 CS$<>8__locals6 = CS$<>8__locals1;
				if (CS$<>8__locals6.tutorialCfg == null || !CS$<>8__locals6.tutorialCfg.GetValueOrDefault().DefaultUnlock)
				{
					Action<bool> finishCallback3 = CS$<>8__locals1.finishCallback;
					if (finishCallback3 == null)
					{
						return;
					}
					finishCallback3(true);
					return;
				}
			}
			TutorialUnlockRequest tutorialUnlockRequest = TutorialUnlockRequest.Create();
			tutorialUnlockRequest.Id = num;
			Net.Instance.Call(ERequestMessageId.TutorialUnlockRequest, tutorialUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				TutorialUnlockResponse tutorialUnlockResponse = (TutorialUnlockResponse)msg;
				if (tutorialUnlockResponse == null)
				{
					Action<bool> finishCallback5 = CS$<>8__locals1.finishCallback;
					if (finishCallback5 == null)
					{
						return;
					}
					finishCallback5(false);
					return;
				}
				else if (tutorialUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					Action<bool> finishCallback6 = CS$<>8__locals1.finishCallback;
					if (finishCallback6 == null)
					{
						return;
					}
					finishCallback6(false);
					return;
				}
				else
				{
					if (CS$<>8__locals1.tutorialCfg == null || !CS$<>8__locals1.tutorialCfg.GetValueOrDefault().DefaultUnlock)
					{
						TutorialModel.Instance.UpdateUnlockTutorials(tutorialUnlockResponse.UnLockInfo);
					}
					Action<bool> finishCallback7 = CS$<>8__locals1.finishCallback;
					if (finishCallback7 == null)
					{
						return;
					}
					finishCallback7(true);
					return;
				}
			}, 0);
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Tutorial;
		ELogAuthor author2 = ELogAuthor.HYF;
		string message2 = "复制图文引导和源图文引导内容不一致";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", tutorialId);
		instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		Action<bool> finishCallback4 = CS$<>8__locals1.finishCallback;
		if (finishCallback4 == null)
		{
			return;
		}
		finishCallback4(false);
	}

	// Token: 0x17001FB5 RID: 8117
	// (get) Token: 0x060178CF RID: 96463 RVA: 0x005FD066 File Offset: 0x005FB266
	public static TutorialController Instance
	{
		get
		{
			return TutorialController._Instance;
		}
	}

	// Token: 0x060178D0 RID: 96464 RVA: 0x005FD06D File Offset: 0x005FB26D
	public static TutorialController GetOrCreateInstance()
	{
		if (TutorialController._Instance == null)
		{
			TutorialController.CreateInstance();
		}
		return TutorialController._Instance;
	}

	// Token: 0x060178D1 RID: 96465 RVA: 0x005FD081 File Offset: 0x005FB281
	public static bool CreateInstance()
	{
		if (TutorialController._Instance != null)
		{
			return true;
		}
		TutorialController._Instance = new TutorialController();
		return true;
	}

	// Token: 0x060178D2 RID: 96466 RVA: 0x005FD097 File Offset: 0x005FB297
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060178D3 RID: 96467 RVA: 0x005FD099 File Offset: 0x005FB299
	public static void ResetStaticDefaultValue()
	{
		TutorialController._Instance = null;
	}

	// Token: 0x060178D4 RID: 96468 RVA: 0x005FD0A1 File Offset: 0x005FB2A1
	static TutorialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialController.CreateStaticDefaultValue), new Action(TutorialController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AFA4 RID: 44964
	[Nullable(2)]
	private static TutorialController _Instance;
}
