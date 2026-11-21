using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A78 RID: 19064
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRunTaskData
	{
		// Token: 0x0602FB6A RID: 195434 RVA: 0x00D4F47E File Offset: 0x00D4D67E
		public DreamLinkRunTaskData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0602FB6B RID: 195435 RVA: 0x00D4F4B4 File Offset: 0x00D4D6B4
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

		// Token: 0x0602FB6C RID: 195436 RVA: 0x00D4F527 File Offset: 0x00D4D727
		public bool IsTimeLock()
		{
			return (double)this.UnlockTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0602FB6D RID: 195437 RVA: 0x00D4F53C File Offset: 0x00D4D73C
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

		// Token: 0x0602FB6E RID: 195438 RVA: 0x00D4F5B4 File Offset: 0x00D4D7B4
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

		// Token: 0x0602FB6F RID: 195439 RVA: 0x00D4F5CF File Offset: 0x00D4D7CF
		public void ReceiveDelegate()
		{
			DreamLinkController.Instance.RunTaskRewardRequest(this.Id);
		}

		// Token: 0x0401953E RID: 103742
		public int Id;

		// Token: 0x0401953F RID: 103743
		public EDreamLinkRunTaskState Status = EDreamLinkRunTaskState.Active;

		// Token: 0x04019540 RID: 103744
		public int ConditionGroupId;

		// Token: 0x04019541 RID: 103745
		public string TitleTextId = "";

		// Token: 0x04019542 RID: 103746
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x04019543 RID: 103747
		public long UnlockTime;

		// Token: 0x04019544 RID: 103748
		public int MarkId;

		// Token: 0x04019545 RID: 103749
		public int PlayTime = -1;
	}
}
