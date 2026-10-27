using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02001526 RID: 5414
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivityTowerGuideController : ActivityControllerBase
{
	// Token: 0x06009A6F RID: 39535 RVA: 0x00216DF2 File Offset: 0x00214FF2
	public void SetCurrentActivityId(int id)
	{
		this.CurrentActivityId = id;
	}

	// Token: 0x06009A70 RID: 39536 RVA: 0x00216DFB File Offset: 0x00214FFB
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x06009A71 RID: 39537 RVA: 0x00216DFE File Offset: 0x00214FFE
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06009A72 RID: 39538 RVA: 0x00216E00 File Offset: 0x00215000
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_TowerGuide";
	}

	// Token: 0x06009A73 RID: 39539 RVA: 0x00216E07 File Offset: 0x00215007
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySubViewTowerGuide();
	}

	// Token: 0x06009A74 RID: 39540 RVA: 0x00216E0E File Offset: 0x0021500E
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new ActivityTowerGuideData();
	}

	// Token: 0x06009A75 RID: 39541 RVA: 0x00216E15 File Offset: 0x00215015
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRecordUpdate, new Action<int, int>(this.OnTowerRecordChange));
	}

	// Token: 0x06009A76 RID: 39542 RVA: 0x00216E33 File Offset: 0x00215033
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRecordUpdate, new Action<int, int>(this.OnTowerRecordChange));
	}

	// Token: 0x06009A77 RID: 39543 RVA: 0x00216E51 File Offset: 0x00215051
	[NullableContext(2)]
	private ActivityTowerGuideData GetTowerGuideData()
	{
		return ActivityModel.Instance.GetActivityById(this.CurrentActivityId) as ActivityTowerGuideData;
	}

	// Token: 0x06009A78 RID: 39544 RVA: 0x00216E68 File Offset: 0x00215068
	private void OnTowerRecordChange(int towerId, int difficultId)
	{
		ActivityTowerGuideData towerGuideData = this.GetTowerGuideData();
		if (towerGuideData == null)
		{
			return;
		}
		towerGuideData.RefreshRewardState((ETowerDifficultId)difficultId);
	}

	// Token: 0x06009A79 RID: 39545 RVA: 0x00216E88 File Offset: 0x00215088
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(towerGuideActivityRewardResponse.ErrorCode, 18982, null, true, true);
				return;
			}
			this.RequestTowerRewardInfo();
		}, 0);
	}

	// Token: 0x06009A7A RID: 39546 RVA: 0x00216EC0 File Offset: 0x002150C0
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

	// Token: 0x17000D45 RID: 3397
	// (get) Token: 0x06009A7B RID: 39547 RVA: 0x00216EF0 File Offset: 0x002150F0
	public static ActivityTowerGuideController Instance
	{
		get
		{
			return ActivityTowerGuideController._Instance;
		}
	}

	// Token: 0x06009A7C RID: 39548 RVA: 0x00216EF7 File Offset: 0x002150F7
	public static ActivityTowerGuideController GetOrCreateInstance()
	{
		if (ActivityTowerGuideController._Instance == null)
		{
			ActivityTowerGuideController.CreateInstance();
		}
		return ActivityTowerGuideController._Instance;
	}

	// Token: 0x06009A7D RID: 39549 RVA: 0x00216F0B File Offset: 0x0021510B
	public static bool CreateInstance()
	{
		if (ActivityTowerGuideController._Instance != null)
		{
			return true;
		}
		ActivityTowerGuideController._Instance = new ActivityTowerGuideController();
		return true;
	}

	// Token: 0x06009A7E RID: 39550 RVA: 0x00216F21 File Offset: 0x00215121
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009A7F RID: 39551 RVA: 0x00216F23 File Offset: 0x00215123
	public static void ResetStaticDefaultValue()
	{
		ActivityTowerGuideController._Instance = null;
	}

	// Token: 0x06009A80 RID: 39552 RVA: 0x00216F2B File Offset: 0x0021512B
	static ActivityTowerGuideController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTowerGuideController.CreateStaticDefaultValue), new Action(ActivityTowerGuideController.ResetStaticDefaultValue));
	}

	// Token: 0x040043F4 RID: 17396
	public int CurrentActivityId;

	// Token: 0x040043F5 RID: 17397
	[Nullable(2)]
	private static ActivityTowerGuideController _Instance;
}
