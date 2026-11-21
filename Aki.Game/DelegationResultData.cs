using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020007D4 RID: 2004
[NullableContext(1)]
[Nullable(0)]
public class DelegationResultData
{
	// Token: 0x06005B73 RID: 23411 RVA: 0x001D8A39 File Offset: 0x001D6C39
	public DelegationResultData(int entrustId)
	{
		this.EntrustId = entrustId;
	}

	// Token: 0x06005B74 RID: 23412 RVA: 0x001D8A74 File Offset: 0x001D6C74
	public void SetRoleResultData(IReadOnlyList<RoleGood> resultList, IReadOnlyList<RoleProperSettle> dataList)
	{
		for (int i = 0; i < dataList.Count; i++)
		{
			RoleProperSettle roleProperSettle = dataList[i];
			List<int> list = new List<int>();
			list.Add(roleProperSettle.PropertyA);
			list.Add(roleProperSettle.PropertyB);
			list.Add(roleProperSettle.PropertyC);
			RoleResultData value = new RoleResultData
			{
				SuccessResult = RoleSettleResult.Normal,
				CharacterValueList = list
			};
			this.RoleResultDataMap[roleProperSettle.RoleId] = value;
		}
		for (int j = 0; j < resultList.Count; j++)
		{
			RoleGood roleGood = resultList[j];
			this.RoleResultDataMap[roleGood.RoleId].SuccessResult = roleGood.Result;
		}
	}

	// Token: 0x06005B75 RID: 23413 RVA: 0x001D8B28 File Offset: 0x001D6D28
	public void SaveInvestProperData(IReadOnlyList<RoleProperSettle> dataList)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < dataList.Count; i++)
		{
			RoleProperSettle roleProperSettle = dataList[i];
			num += roleProperSettle.PropertyA;
			num2 += roleProperSettle.PropertyB;
			num3 += roleProperSettle.PropertyC;
		}
		this.RoleInvestDataList.Add(num);
		this.RoleInvestDataList.Add(num2);
		this.RoleInvestDataList.Add(num3);
	}

	// Token: 0x06005B76 RID: 23414 RVA: 0x001D8B98 File Offset: 0x001D6D98
	public void UseInvestProperData()
	{
		this.ResultCharacterList[0].SetCurrentValue(this.RoleInvestDataList[0]);
		this.ResultCharacterList[1].SetCurrentValue(this.RoleInvestDataList[1]);
		this.ResultCharacterList[2].SetCurrentValue(this.RoleInvestDataList[2]);
	}

	// Token: 0x06005B77 RID: 23415 RVA: 0x001D8BFC File Offset: 0x001D6DFC
	public void SetRoleIdList(List<int> roleIdList)
	{
		this.RoleIdList = roleIdList;
	}

	// Token: 0x06005B78 RID: 23416 RVA: 0x001D8C05 File Offset: 0x001D6E05
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x06005B79 RID: 23417 RVA: 0x001D8C0D File Offset: 0x001D6E0D
	public IRoleResultData GetRoleResultDataById(int roleId)
	{
		return this.RoleResultDataMap[roleId];
	}

	// Token: 0x06005B7A RID: 23418 RVA: 0x001D8C1B File Offset: 0x001D6E1B
	public void SetResultCharacterList(List<CharacterData> dataList)
	{
		this.ResultCharacterList = dataList;
	}

	// Token: 0x06005B7B RID: 23419 RVA: 0x001D8C24 File Offset: 0x001D6E24
	public List<CharacterData> GetResultCharacterList()
	{
		return this.ResultCharacterList;
	}

	// Token: 0x06005B7C RID: 23420 RVA: 0x001D8C2C File Offset: 0x001D6E2C
	public void SetEvaluationLevel(int level)
	{
		if (this.EvaluationLevelInternal > level)
		{
			return;
		}
		this.EvaluationLevelInternal = level;
	}

	// Token: 0x17000BB4 RID: 2996
	// (get) Token: 0x06005B7D RID: 23421 RVA: 0x001D8C3F File Offset: 0x001D6E3F
	public int EvaluationLevel
	{
		get
		{
			return this.EvaluationLevelInternal;
		}
	}

	// Token: 0x06005B7E RID: 23422 RVA: 0x001D8C48 File Offset: 0x001D6E48
	public string GetRoleDialog()
	{
		EntrustFinishDialog valueOrDefault = ConfigEntrustFinishDialogByEntrustIdAndLevel.GetConfig(this.EntrustId, this.EvaluationLevelInternal, true).GetValueOrDefault();
		int num = MoonChasingModel.Instance.GetPopularityValue() - this.LastPopularity;
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
		if (num > 0)
		{
			if (!flag)
			{
				return valueOrDefault.UpDialogGirl;
			}
			return valueOrDefault.UpDialog;
		}
		else
		{
			if (!flag)
			{
				return valueOrDefault.UnchangedDialogGirl;
			}
			return valueOrDefault.UnchangedDialog;
		}
	}

	// Token: 0x04003D28 RID: 15656
	public bool IsTriggerEvent;

	// Token: 0x04003D29 RID: 15657
	public int TriggerEventRoleId;

	// Token: 0x04003D2A RID: 15658
	private int EvaluationLevelInternal;

	// Token: 0x04003D2B RID: 15659
	public int Gold;

	// Token: 0x04003D2C RID: 15660
	public int BaseGold;

	// Token: 0x04003D2D RID: 15661
	public int CostGold;

	// Token: 0x04003D2E RID: 15662
	public int OriginGold;

	// Token: 0x04003D2F RID: 15663
	public int Wish;

	// Token: 0x04003D30 RID: 15664
	public int BaseWish;

	// Token: 0x04003D31 RID: 15665
	public int Ratio;

	// Token: 0x04003D32 RID: 15666
	public bool IsInvestSuccess;

	// Token: 0x04003D33 RID: 15667
	public bool IsBest;

	// Token: 0x04003D34 RID: 15668
	private readonly Dictionary<int, IRoleResultData> RoleResultDataMap = new Dictionary<int, IRoleResultData>();

	// Token: 0x04003D35 RID: 15669
	private readonly List<int> RoleInvestDataList = new List<int>();

	// Token: 0x04003D36 RID: 15670
	private List<int> RoleIdList = new List<int>();

	// Token: 0x04003D37 RID: 15671
	private List<CharacterData> ResultCharacterList = new List<CharacterData>();

	// Token: 0x04003D38 RID: 15672
	public int LastPopularity;

	// Token: 0x04003D39 RID: 15673
	public readonly int EntrustId;
}
