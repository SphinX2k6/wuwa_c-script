using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A9C RID: 23196
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRunTaskData
	{
		// Token: 0x0603AC21 RID: 240673 RVA: 0x00DFEF16 File Offset: 0x00DFD116
		public DreamLinkRunTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0603AC22 RID: 240674 RVA: 0x00DFEF4C File Offset: 0x00DFD14C
		public string GetLockTxt()
		{
			string result = "";
			if ((double)this.UnlockTime <= TimeUtil.Instance.GetServerTime())
			{
				if (this.ConditionGroupId != 0)
				{
					result = ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(this.ConditionGroupId) ?? "", null);
				}
			}
			else
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DreamLinkWorldRunLockText", null);
				result = ActivityModel.Instance.GetRemainTimeText(this.UnlockTime, localTextNew ?? "");
			}
			return result;
		}

		// Token: 0x0603AC23 RID: 240675 RVA: 0x00DFEFBF File Offset: 0x00DFD1BF
		public bool IsTimeLock()
		{
			return (double)this.UnlockTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603AC24 RID: 240676 RVA: 0x00DFEFD4 File Offset: 0x00DFD1D4
		public List<IItemGridData> GetRewardData()
		{
			List<IItemGridData> list = new List<IItemGridData>();
			foreach (TItem item in this.RewardList)
			{
				ItemGridData item2 = new ItemGridData
				{
					Item = item,
					HasClaimed = (this.Status == EDreamLinkRunTaskState.FinishedAndClaimed)
				};
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x0603AC25 RID: 240677 RVA: 0x00DFF04C File Offset: 0x00DFD24C
		public void JumpDelegate()
		{
			WorldMapController.Instance.OpenView(EOpenMapType.Mouse, false, null, delegate(bool success, int viewId)
			{
				if (success)
				{
					MapModel.Instance.CreateTempMapMark(this.MarkId);
					WorldMapController.Instance.FocalMarkItem(EMarkType.DreamLinkRun, this.MarkId);
				}
			});
		}

		// Token: 0x0603AC26 RID: 240678 RVA: 0x00DFF067 File Offset: 0x00DFD267
		public void ReceiveDelegate()
		{
			DreamLinkController.Instance.RunTaskRewardRequest(this.Id);
		}

		// Token: 0x0401EA97 RID: 125591
		public int Id;

		// Token: 0x0401EA98 RID: 125592
		public EDreamLinkRunTaskState Status = EDreamLinkRunTaskState.Active;

		// Token: 0x0401EA99 RID: 125593
		public int ConditionGroupId;

		// Token: 0x0401EA9A RID: 125594
		public string TitleTextId = "";

		// Token: 0x0401EA9B RID: 125595
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401EA9C RID: 125596
		public long UnlockTime;

		// Token: 0x0401EA9D RID: 125597
		public int MarkId;

		// Token: 0x0401EA9E RID: 125598
		public int PlayTime = -1;
	}
}
