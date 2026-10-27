using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020014EA RID: 5354
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ActivityScratchTicketModel : ModelBase
{
	// Token: 0x06009861 RID: 39009 RVA: 0x0020E961 File Offset: 0x0020CB61
	[NullableContext(2)]
	public ScratchTicketData GetScratchTicketData()
	{
		return this.ScratchTicketData;
	}

	// Token: 0x06009862 RID: 39010 RVA: 0x0020E969 File Offset: 0x0020CB69
	public void SetScratchTicketData(ScratchTicketData data)
	{
		this.ScratchTicketData = data;
	}

	// Token: 0x06009863 RID: 39011 RVA: 0x0020E972 File Offset: 0x0020CB72
	[NullableContext(2)]
	public ScratchTicketRoundData GetScratchRoundData(int roundId)
	{
		if (this.ScratchTicketData == null)
		{
			return null;
		}
		return this.ScratchTicketData.GetRoundDataById(roundId);
	}

	// Token: 0x06009864 RID: 39012 RVA: 0x0020E98A File Offset: 0x0020CB8A
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

	// Token: 0x06009865 RID: 39013 RVA: 0x0020E9C8 File Offset: 0x0020CBC8
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
		List<RewardItemData> rewardDataList = roundDataById.GetRewardDataList(message.ItemMap.ToDictionary<int, int>());
		callback((EScratchTicketRewardType)message.OpenType, roundId, rewardResultList, rewardDataList);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ScratchTicketData.Id);
	}

	// Token: 0x17000D2A RID: 3370
	// (get) Token: 0x06009866 RID: 39014 RVA: 0x0020EA47 File Offset: 0x0020CC47
	public static ActivityScratchTicketModel Instance
	{
		get
		{
			return ActivityScratchTicketModel._Instance;
		}
	}

	// Token: 0x06009867 RID: 39015 RVA: 0x0020EA4E File Offset: 0x0020CC4E
	public static ActivityScratchTicketModel GetOrCreateInstance()
	{
		if (ActivityScratchTicketModel._Instance == null)
		{
			ActivityScratchTicketModel.CreateInstance();
		}
		return ActivityScratchTicketModel._Instance;
	}

	// Token: 0x06009868 RID: 39016 RVA: 0x0020EA62 File Offset: 0x0020CC62
	public static bool CreateInstance()
	{
		if (ActivityScratchTicketModel._Instance != null)
		{
			return true;
		}
		ActivityScratchTicketModel._Instance = new ActivityScratchTicketModel();
		return true;
	}

	// Token: 0x06009869 RID: 39017 RVA: 0x0020EA78 File Offset: 0x0020CC78
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600986A RID: 39018 RVA: 0x0020EA7A File Offset: 0x0020CC7A
	public static void ResetStaticDefaultValue()
	{
		ActivityScratchTicketModel._Instance = null;
	}

	// Token: 0x0600986B RID: 39019 RVA: 0x0020EA82 File Offset: 0x0020CC82
	static ActivityScratchTicketModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityScratchTicketModel.CreateStaticDefaultValue), new Action(ActivityScratchTicketModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400431E RID: 17182
	[Nullable(2)]
	private ScratchTicketData ScratchTicketData;

	// Token: 0x0400431F RID: 17183
	[Nullable(2)]
	private static ActivityScratchTicketModel _Instance;
}
