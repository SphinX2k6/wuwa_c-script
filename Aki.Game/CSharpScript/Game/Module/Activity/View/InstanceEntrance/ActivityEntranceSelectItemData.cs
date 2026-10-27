using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F09 RID: 24329
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceSelectItemData
	{
		// Token: 0x0603DD16 RID: 253206 RVA: 0x00EF13C2 File Offset: 0x00EEF5C2
		public static ActivityEntranceSelectItemData Create(List<ActivityEntranceSelectItemBaseData> mainDataList)
		{
			ActivityEntranceSelectItemData activityEntranceSelectItemData = new ActivityEntranceSelectItemData();
			activityEntranceSelectItemData.MainDataList = mainDataList;
			activityEntranceSelectItemData.InitEntranceData();
			return activityEntranceSelectItemData;
		}

		// Token: 0x0603DD17 RID: 253207 RVA: 0x00EF13D8 File Offset: 0x00EEF5D8
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

		// Token: 0x0603DD18 RID: 253208 RVA: 0x00EF1468 File Offset: 0x00EEF668
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

		// Token: 0x0603DD19 RID: 253209 RVA: 0x00EF1508 File Offset: 0x00EEF708
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

		// Token: 0x040204A7 RID: 132263
		private List<ActivityEntranceSelectItemBaseData> MainDataList;

		// Token: 0x040204A8 RID: 132264
		private List<ActivityEntranceItemData> CurrentEntranceData;
	}
}
