using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020009DE RID: 2526
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTowerGuideController : ActivityControllerBase
{
	// Token: 0x06006E4D RID: 28237 RVA: 0x00220B8E File Offset: 0x0021ED8E
	public void SetCurrentActivityId(int id)
	{
		this.CurrentActivityId = id;
	}

	// Token: 0x06006E4E RID: 28238 RVA: 0x00220B97 File Offset: 0x0021ED97
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06006E4F RID: 28239 RVA: 0x00220B9A File Offset: 0x0021ED9A
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006E50 RID: 28240 RVA: 0x00220B9C File Offset: 0x0021ED9C
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TowerGuide";
	}

	// Token: 0x06006E51 RID: 28241 RVA: 0x00220BA3 File Offset: 0x0021EDA3
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewTowerGuide();
	}

	// Token: 0x06006E52 RID: 28242 RVA: 0x00220BAA File Offset: 0x0021EDAA
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTowerGuideData();
	}

	// Token: 0x06006E53 RID: 28243 RVA: 0x00220BB1 File Offset: 0x0021EDB1
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRecordUpdate, new Action<int, int>(this.OnTowerRecordChange));
	}

	// Token: 0x06006E54 RID: 28244 RVA: 0x00220BCF File Offset: 0x0021EDCF
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRecordUpdate, new Action<int, int>(this.OnTowerRecordChange));
	}

	// Token: 0x06006E55 RID: 28245 RVA: 0x00220BED File Offset: 0x0021EDED
	[NullableContext(2)]
	private ActivityTowerGuideData GetTowerGuideData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityTowerGuideData;
	}

	// Token: 0x06006E56 RID: 28246 RVA: 0x00220C04 File Offset: 0x0021EE04
	private void OnTowerRecordChange(int towerId, int difficultId)
	{
		ActivityTowerGuideData towerGuideData = this.GetTowerGuideData();
		if (towerGuideData == null)
		{
			return;
		}
		towerGuideData.RefreshRewardState((ETowerDifficultId)difficultId);
	}

	// Token: 0x06006E57 RID: 28247 RVA: 0x00220C24 File Offset: 0x0021EE24
	public void RequestTowerReward(ETowerDifficultId id)
	{
		TowerGuideActivityRewardRequest towerGuideActivityRewardRequest = TowerGuideActivityRewardRequest.Create();
		towerGuideActivityRewardRequest.TowerGuideId = (int)id;
		Net.Instance.Call(ERequestMessageId.TowerGuideActivityRewardRequest, towerGuideActivityRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerGuideActivityRewardResponse towerGuideActivityRewardResponse = (TowerGuideActivityRewardResponse)msg;
			if (towerGuideActivityRewardResponse == null)
			{
				return;
			}
			if (towerGuideActivityRewardResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerGuideActivityRewardResponse.ErrorCode, 22907, null, true, true);
				return;
			}
			this.RequestTowerRewardInfo();
		}, 0);
	}

	// Token: 0x06006E58 RID: 28248 RVA: 0x00220C5C File Offset: 0x0021EE5C
	public void RequestTowerRewardInfo()
	{
		TowerGuideActivityInfoRequest message = TowerGuideActivityInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.TowerGuideActivityInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TowerGuideActivityInfoResponse towerGuideActivityInfoResponse = (TowerGuideActivityInfoResponse)msg;
			if (towerGuideActivityInfoResponse == null)
			{
				return;
			}
			ActivityTowerGuideData towerGuideData = this.GetTowerGuideData();
			if (towerGuideData == null)
			{
				return;
			}
			foreach (int id in towerGuideActivityInfoResponse.TowerGuideId)
			{
				towerGuideData.SetRewardClaimed(id, true);
			}
		}, 0);
	}

	// Token: 0x17000D66 RID: 3430
	// (get) Token: 0x06006E59 RID: 28249 RVA: 0x00220C8C File Offset: 0x0021EE8C
	public static ActivityTowerGuideController Instance
	{
		get
		{
			return ActivityTowerGuideController._Instance;
		}
	}

	// Token: 0x06006E5A RID: 28250 RVA: 0x00220C93 File Offset: 0x0021EE93
	public static ActivityTowerGuideController GetOrCreateInstance()
	{
		if (ActivityTowerGuideController._Instance == null)
		{
			ActivityTowerGuideController.CreateInstance();
		}
		return ActivityTowerGuideController._Instance;
	}

	// Token: 0x06006E5B RID: 28251 RVA: 0x00220CA7 File Offset: 0x0021EEA7
	public static bool CreateInstance()
	{
		if (ActivityTowerGuideController._Instance != null)
		{
			return true;
		}
		ActivityTowerGuideController._Instance = new ActivityTowerGuideController();
		return true;
	}

	// Token: 0x06006E5C RID: 28252 RVA: 0x00220CBD File Offset: 0x0021EEBD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006E5D RID: 28253 RVA: 0x00220CBF File Offset: 0x0021EEBF
	public static void ResetStaticDefaultValue()
	{
		ActivityTowerGuideController._Instance = null;
	}

	// Token: 0x06006E5E RID: 28254 RVA: 0x00220CC7 File Offset: 0x0021EEC7
	static ActivityTowerGuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTowerGuideController.CreateStaticDefaultValue), new Action(ActivityTowerGuideController.ResetStaticDefaultValue));
	}

	// Token: 0x0400449A RID: 17562
	public int CurrentActivityId;

	// Token: 0x0400449B RID: 17563
	[Nullable(2)]
	private static ActivityTowerGuideController _Instance;
}
