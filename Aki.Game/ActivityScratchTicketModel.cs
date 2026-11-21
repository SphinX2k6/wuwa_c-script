using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020009A2 RID: 2466
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityScratchTicketModel : ModelBase
{
	// Token: 0x06006C3B RID: 27707 RVA: 0x002186A1 File Offset: 0x002168A1
	[NullableContext(2)]
	public ScratchTicketData GetScratchTicketData()
	{
		return this.ScratchTicketData;
	}

	// Token: 0x06006C3C RID: 27708 RVA: 0x002186A9 File Offset: 0x002168A9
	public void SetScratchTicketData(ScratchTicketData data)
	{
		this.ScratchTicketData = data;
	}

	// Token: 0x06006C3D RID: 27709 RVA: 0x002186B2 File Offset: 0x002168B2
	[NullableContext(2)]
	public ScratchTicketRoundData GetScratchRoundData(int roundId)
	{
		if (this.ScratchTicketData == null)
		{
			return null;
		}
		return this.ScratchTicketData.GetRoundDataById(roundId);
	}

	// Token: 0x06006C3E RID: 27710 RVA: 0x002186CA File Offset: 0x002168CA
	public void OnScratchCardCountInfoNotify(ScratchCardCountInfoNotify message)
	{
		if (this.ScratchTicketData == null)
		{
			return;
		}
		this.ScratchTicketData.UpdateAllRoundState();
		this.ScratchTicketData.RefreshConditionData(new List<ScratchCardTimeInfo>(message.ScratchTimeInfos));
		EventSystem.Instance.Emit(EEventName.OnScratchTicketConditionRefresh);
	}

	// Token: 0x06006C3F RID: 27711 RVA: 0x00218708 File Offset: 0x00216908
	public void OnScratchCardRewardResponse(int index, int roundId, ScratchCardRewardResponse message, Action<EScratchTicketRewardType, int, List<ScratchTicketRoundResult>, List<RewardItemData>> callback)
	{
		if (this.ScratchTicketData == null)
		{
			return;
		}
		ScratchTicketRoundData roundDataById = this.ScratchTicketData.GetRoundDataById(roundId);
		if (roundDataById == null)
		{
			return;
		}
		List<ScratchTicketRoundResult> rewardResultList = roundDataById.GetRewardResultList(index, (EScratchTicketRewardType)message.OpenType);
		this.ScratchTicketData.UpdateCellReward(roundId, message);
		List<RewardItemData> rewardDataList = roundDataById.GetRewardDataList(message.ItemMap);
		callback((EScratchTicketRewardType)message.OpenType, roundId, rewardResultList, rewardDataList);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ScratchTicketData.Id);
	}

	// Token: 0x17000D4B RID: 3403
	// (get) Token: 0x06006C40 RID: 27712 RVA: 0x00218782 File Offset: 0x00216982
	public static ActivityScratchTicketModel Instance
	{
		get
		{
			return ActivityScratchTicketModel._Instance;
		}
	}

	// Token: 0x06006C41 RID: 27713 RVA: 0x00218789 File Offset: 0x00216989
	public static ActivityScratchTicketModel GetOrCreateInstance()
	{
		if (ActivityScratchTicketModel._Instance == null)
		{
			ActivityScratchTicketModel.CreateInstance();
		}
		return ActivityScratchTicketModel._Instance;
	}

	// Token: 0x06006C42 RID: 27714 RVA: 0x0021879D File Offset: 0x0021699D
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketModel._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketModel._Instance = new ActivityScratchTicketModel();
		return true;
	}

	// Token: 0x06006C43 RID: 27715 RVA: 0x002187B3 File Offset: 0x002169B3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006C44 RID: 27716 RVA: 0x002187B5 File Offset: 0x002169B5
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketModel._Instance = null;
	}

	// Token: 0x06006C45 RID: 27717 RVA: 0x002187BD File Offset: 0x002169BD
	static ActivityScratchTicketModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketModel.CreateStaticDefaultValue), new Action(ActivityScratchTicketModel.ResetStaticDefaultValue));
	}

	// Token: 0x040043C3 RID: 17347
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x040043C4 RID: 17348
	[Nullable(2)]
	private static ActivityScratchTicketModel _Instance;
}
