using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020021A0 RID: 8608
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class TutorialController : UiControllerBase
{
	// Token: 0x060152F0 RID: 86768 RVA: 0x00629458 File Offset: 0x00627658
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060152F1 RID: 86769 RVA: 0x00629476 File Offset: 0x00627676
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060152F2 RID: 86770 RVA: 0x00629494 File Offset: 0x00627694
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TutorialUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTutorialUnlockedIdsNotify));
	}

	// Token: 0x060152F3 RID: 86771 RVA: 0x006294B2 File Offset: 0x006276B2
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TutorialUnlockNotify);
	}

	// Token: 0x060152F4 RID: 86772 RVA: 0x006294C4 File Offset: 0x006276C4
	public void OpenExclusiveTutorial(EExclusiveTutorialType type)
	{
		TutorialViewParam param = new TutorialViewParam
		{
			ExclusiveType = new EExclusiveTutorialType?(type)
		};
		UiManager.Instance.OpenView(EUiViewName.TutorialPopView, param, null);
	}

	// Token: 0x060152F5 RID: 86773 RVA: 0x006294F4 File Offset: 0x006276F4
	[NullableContext(2)]
	private void OnTutorialUnlockedIdsNotify(IMessage msg, Net.CallbackStatus _)
	{
		foreach (TutorialInfo tutorialInfo in ((TutorialUnlockNotify)msg).UnLockList)
		{
			TutorialModel.Instance.UpdateUnlockTutorials(tutorialInfo);
		}
	}

	// Token: 0x060152F6 RID: 86774 RVA: 0x0062954C File Offset: 0x0062774C
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

	// Token: 0x060152F7 RID: 86775 RVA: 0x00629599 File Offset: 0x00627799
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TutorialView, new Func<EUiViewName, object, bool>(this.CanOpenView), "TutorialController.CanOpenView");
	}

	// Token: 0x060152F8 RID: 86776 RVA: 0x006295BB File Offset: 0x006277BB
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TutorialView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x060152F9 RID: 86777 RVA: 0x006295D8 File Offset: 0x006277D8
	public void OnTutorialTipExistChanged(bool isExist)
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnTutorialTipExistChanged, isExist);
	}

	// Token: 0x060152FA RID: 86778 RVA: 0x006295EC File Offset: 0x006277EC
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		return FunctionModel.Instance.IsOpen(10022) && (!UiManager.Instance.IsViewOpen(EUiViewName.GuideTutorialTipsView) || UiManager.Instance.IsViewOpen(EUiViewName.FunctionView) || GuideModel.Instance.HaveCurrentTutorial());
	}

	// Token: 0x060152FB RID: 86779 RVA: 0x0062963D File Offset: 0x0062783D
	public void OpenTutorialView()
	{
		UiManager.Instance.OpenView(EUiViewName.TutorialView, null, null);
	}

	// Token: 0x060152FC RID: 86780 RVA: 0x00629650 File Offset: 0x00627850
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

	// Token: 0x060152FD RID: 86781 RVA: 0x0062969C File Offset: 0x0062789C
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

	// Token: 0x060152FE RID: 86782 RVA: 0x00629720 File Offset: 0x00627920
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
			int num = 0;
			using (IEnumerator<int> enumerator = tutorialReceiveResponse.ItemMap.Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					num = enumerator.Current;
				}
			}
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

	// Token: 0x060152FF RID: 86783 RVA: 0x00629778 File Offset: 0x00627978
	public void TryOpenAwardUiViewPending()
	{
		if (TutorialModel.Instance.RewardList.Count > 0)
		{
			ItemHintController.Instance.AddItemRewardInfoList(TutorialModel.Instance.RewardList);
			TutorialModel.Instance.RewardList.Clear();
		}
	}

	// Token: 0x06015300 RID: 86784 RVA: 0x006297B0 File Offset: 0x006279B0
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

	// Token: 0x1700200D RID: 8205
	// (get) Token: 0x06015301 RID: 86785 RVA: 0x00629A8A File Offset: 0x00627C8A
	public static TutorialController Instance
	{
		get
		{
			return TutorialController._Instance;
		}
	}

	// Token: 0x06015302 RID: 86786 RVA: 0x00629A91 File Offset: 0x00627C91
	public static TutorialController GetOrCreateInstance()
	{
		if (TutorialController._Instance == null)
		{
			TutorialController.CreateInstance();
		}
		return TutorialController._Instance;
	}

	// Token: 0x06015303 RID: 86787 RVA: 0x00629AA5 File Offset: 0x00627CA5
	public static bool CreateInstance()
	{
		if (TutorialController._Instance != null)
		{
			return true;
		}
		TutorialController._Instance = new TutorialController();
		return true;
	}

	// Token: 0x06015304 RID: 86788 RVA: 0x00629ABB File Offset: 0x00627CBB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015305 RID: 86789 RVA: 0x00629ABD File Offset: 0x00627CBD
	public static void ResetStaticDefaultValue()
	{
		TutorialController._Instance = null;
	}

	// Token: 0x06015306 RID: 86790 RVA: 0x00629AC5 File Offset: 0x00627CC5
	static TutorialController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TutorialController.CreateStaticDefaultValue), new Action(TutorialController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B3A9 RID: 45993
	[Nullable(2)]
	private static TutorialController _Instance;
}
