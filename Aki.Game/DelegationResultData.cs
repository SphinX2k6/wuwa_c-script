using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001320 RID: 4896
[NullableContext(1)]
[Nullable(0)]
public class DelegationResultData
{
	// Token: 0x060087D8 RID: 34776 RVA: 0x001CFBCD File Offset: 0x001CDDCD
	public DelegationResultData(int entrustId)
	{
		this.EntrustId = entrustId;
	}

	// Token: 0x060087D9 RID: 34777 RVA: 0x001CFC08 File Offset: 0x001CDE08
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

	// Token: 0x060087DA RID: 34778 RVA: 0x001CFCBC File Offset: 0x001CDEBC
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

	// Token: 0x060087DB RID: 34779 RVA: 0x001CFD2C File Offset: 0x001CDF2C
	public void UseInvestProperData()
	{
		this.ResultCharacterList[0].SetCurrentValue(this.RoleInvestDataList[0]);
		this.ResultCharacterList[1].SetCurrentValue(this.RoleInvestDataList[1]);
		this.ResultCharacterList[2].SetCurrentValue(this.RoleInvestDataList[2]);
	}

	// Token: 0x060087DC RID: 34780 RVA: 0x001CFD90 File Offset: 0x001CDF90
	public void SetRoleIdList(List<int> roleIdList)
	{
		this.RoleIdList = roleIdList;
	}

	// Token: 0x060087DD RID: 34781 RVA: 0x001CFD99 File Offset: 0x001CDF99
	public List<int> GetRoleIdList()
	{
		return this.RoleIdList;
	}

	// Token: 0x060087DE RID: 34782 RVA: 0x001CFDA1 File Offset: 0x001CDFA1
	public IRoleResultData GetRoleResultDataById(int roleId)
	{
		return this.RoleResultDataMap[roleId];
	}

	// Token: 0x060087DF RID: 34783 RVA: 0x001CFDAF File Offset: 0x001CDFAF
	public void SetResultCharacterList(List<CharacterData> dataList)
	{
		this.ResultCharacterList = dataList;
	}

	// Token: 0x060087E0 RID: 34784 RVA: 0x001CFDB8 File Offset: 0x001CDFB8
	public List<CharacterData> GetResultCharacterList()
	{
		return this.ResultCharacterList;
	}

	// Token: 0x060087E1 RID: 34785 RVA: 0x001CFDC0 File Offset: 0x001CDFC0
	public void SetEvaluationLevel(int level)
	{
		if (this.EvaluationLevelInternal > level)
		{
			return;
		}
		this.EvaluationLevelInternal = level;
	}

	// Token: 0x17000B94 RID: 2964
	// (get) Token: 0x060087E2 RID: 34786 RVA: 0x001CFDD3 File Offset: 0x001CDFD3
	public int EvaluationLevel
	{
		get
		{
			return this.EvaluationLevelInternal;
		}
	}

	// Token: 0x060087E3 RID: 34787 RVA: 0x001CFDDC File Offset: 0x001CDFDC
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

	// Token: 0x04003C90 RID: 15504
	public bool IsTriggerEvent;

	// Token: 0x04003C91 RID: 15505
	public int TriggerEventRoleId;

	// Token: 0x04003C92 RID: 15506
	private int EvaluationLevelInternal;

	// Token: 0x04003C93 RID: 15507
	public int Gold;

	// Token: 0x04003C94 RID: 15508
	public int BaseGold;

	// Token: 0x04003C95 RID: 15509
	public int CostGold;

	// Token: 0x04003C96 RID: 15510
	public int OriginGold;

	// Token: 0x04003C97 RID: 15511
	public int Wish;

	// Token: 0x04003C98 RID: 15512
	public int BaseWish;

	// Token: 0x04003C99 RID: 15513
	public int Ratio;

	// Token: 0x04003C9A RID: 15514
	public bool IsInvestSuccess;

	// Token: 0x04003C9B RID: 15515
	public bool IsBest;

	// Token: 0x04003C9C RID: 15516
	private readonly Dictionary<int, IRoleResultData> RoleResultDataMap = new Dictionary<int, IRoleResultData>();

	// Token: 0x04003C9D RID: 15517
	private readonly List<int> RoleInvestDataList = new List<int>();

	// Token: 0x04003C9E RID: 15518
	private List<int> RoleIdList = new List<int>();

	// Token: 0x04003C9F RID: 15519
	private List<CharacterData> ResultCharacterList = new List<CharacterData>();

	// Token: 0x04003CA0 RID: 15520
	public int LastPopularity;

	// Token: 0x04003CA1 RID: 15521
	public readonly int EntrustId;
}
