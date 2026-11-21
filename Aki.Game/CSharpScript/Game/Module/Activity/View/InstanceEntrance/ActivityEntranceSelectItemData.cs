using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF0 RID: 20208
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceSelectItemData
	{
		// Token: 0x06032CB1 RID: 208049 RVA: 0x00E430CA File Offset: 0x00E412CA
		public static ActivityEntranceSelectItemData Create(List<ActivityEntranceSelectItemBaseData> mainDataList)
		{
			ActivityEntranceSelectItemData activityEntranceSelectItemData = new ActivityEntranceSelectItemData();
			activityEntranceSelectItemData.MainDataList = mainDataList;
			activityEntranceSelectItemData.InitEntranceData();
			return activityEntranceSelectItemData;
		}

		// Token: 0x06032CB2 RID: 208050 RVA: 0x00E430E0 File Offset: 0x00E412E0
		public ActivityEntranceItemData GetCurrentSelectData()
		{
			ActivityEntranceItemData activityEntranceItemData = null;
			foreach (ActivityEntranceItemData activityEntranceItemData2 in this.CurrentEntranceData)
			{
				if (activityEntranceItemData2.MainData != null)
				{
					if (activityEntranceItemData2.MainData.GetSelectState())
					{
						activityEntranceItemData = activityEntranceItemData2;
					}
				}
				else if (activityEntranceItemData2.SubData != null && activityEntranceItemData2.SubData.GetSelectState())
				{
					activityEntranceItemData = activityEntranceItemData2;
				}
			}
			if (activityEntranceItemData == null)
			{
				activityEntranceItemData = this.CurrentEntranceData[0];
			}
			return activityEntranceItemData;
		}

		// Token: 0x06032CB3 RID: 208051 RVA: 0x00E43170 File Offset: 0x00E41370
		private void InitEntranceData()
		{
			this.CurrentEntranceData = new List<ActivityEntranceItemData>(this.MainDataList.Count * 2);
			for (int i = 0; i < this.MainDataList.Count; i++)
			{
				ActivityEntranceItemData activityEntranceItemData = new ActivityEntranceItemData();
				activityEntranceItemData.MainData = this.MainDataList[i];
				this.CurrentEntranceData.Add(activityEntranceItemData);
				ActivityEntranceSelectItemSubData[] subDataList = this.MainDataList[i].GetSubDataList();
				if (subDataList != null)
				{
					for (int j = 0; j < subDataList.Length; j++)
					{
						ActivityEntranceItemData activityEntranceItemData2 = new ActivityEntranceItemData();
						activityEntranceItemData2.SubData = subDataList[j];
						this.CurrentEntranceData.Add(activityEntranceItemData2);
					}
				}
			}
		}

		// Token: 0x06032CB4 RID: 208052 RVA: 0x00E43210 File Offset: 0x00E41410
		public IReadOnlyList<ActivityEntranceItemData> GetShowDataBySelectElement(int selectMainLogicIndex, int selectSubLogicIndex)
		{
			this.CurrentEntranceData = new List<ActivityEntranceItemData>(this.MainDataList.Count * 2);
			for (int i = 0; i < this.MainDataList.Count; i++)
			{
				bool flag = this.MainDataList[i].GetUiLogicIndex() == selectMainLogicIndex;
				this.MainDataList[i].SetSelectState(flag);
				ActivityEntranceItemData activityEntranceItemData = new ActivityEntranceItemData();
				activityEntranceItemData.MainData = this.MainDataList[i];
				this.CurrentEntranceData.Add(activityEntranceItemData);
				if (flag)
				{
					ActivityEntranceSelectItemSubData[] subDataList = this.MainDataList[i].GetSubDataList();
					if (subDataList != null)
					{
						for (int j = 0; j < subDataList.Length; j++)
						{
							bool selectState = subDataList[j].GetUiLogicIndex() == selectSubLogicIndex;
							subDataList[j].SetSelectState(selectState);
							ActivityEntranceItemData activityEntranceItemData2 = new ActivityEntranceItemData();
							activityEntranceItemData2.SubData = subDataList[j];
							this.CurrentEntranceData.Add(activityEntranceItemData2);
						}
					}
				}
			}
			return this.CurrentEntranceData;
		}

		// Token: 0x0401AF79 RID: 110457
		private List<ActivityEntranceSelectItemBaseData> MainDataList;

		// Token: 0x0401AF7A RID: 110458
		private List<ActivityEntranceItemData> CurrentEntranceData;
	}
}
