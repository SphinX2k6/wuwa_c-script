using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7D RID: 19069
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkBossInstanceData
	{
		// Token: 0x0602FB8B RID: 195467 RVA: 0x00D4F722 File Offset: 0x00D4D922
		public DreamLinkBossInstanceData(int typeId, int instId, int conditionGroupId)
		{
			this.TypeId = typeId;
			this.InstId = instId;
			this.ConditionGroupId = conditionGroupId;
		}

		// Token: 0x0602FB8C RID: 195468 RVA: 0x00D4F74C File Offset: 0x00D4D94C
		public string GetUnlockText()
		{
			string result = "";
			if ((double)this.UnlockTime <= TimeUtil.Instance.GetServerTime())
			{
				if (this.ConditionGroupId != 0)
				{
					result = (ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(this.ConditionGroupId) ?? "", null) ?? "");
				}
			}
			else
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DaMaoUnLockTime", null);
				result = ActivityModel.Instance.GetRemainTimeText(this.UnlockTime, localTextNew ?? "");
			}
			return result;
		}

		// Token: 0x0602FB8D RID: 195469 RVA: 0x00D4F7C8 File Offset: 0x00D4D9C8
		public bool GetTickState()
		{
			return !this.IsUnlock && (double)this.UnlockTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0602FB8E RID: 195470 RVA: 0x00D4F7EA File Offset: 0x00D4D9EA
		public void SetBossRoleIdByIndex(int index, int roleId)
		{
			this.EnterBossRoleIdList[index] = roleId;
		}

		// Token: 0x0602FB8F RID: 195471 RVA: 0x00D4F7F5 File Offset: 0x00D4D9F5
		public int GetBossRoleIdByIndex(int index)
		{
			return this.EnterBossRoleIdList[index];
		}

		// Token: 0x0602FB90 RID: 195472 RVA: 0x00D4F7FF File Offset: 0x00D4D9FF
		public int[] GetBossRoleIdList()
		{
			return this.EnterBossRoleIdList;
		}

		// Token: 0x04019553 RID: 103763
		public int TypeId;

		// Token: 0x04019554 RID: 103764
		public int InstId;

		// Token: 0x04019555 RID: 103765
		public int ConditionGroupId;

		// Token: 0x04019556 RID: 103766
		public int Score;

		// Token: 0x04019557 RID: 103767
		public bool IsUnlock;

		// Token: 0x04019558 RID: 103768
		public long UnlockTime;

		// Token: 0x04019559 RID: 103769
		public bool IsFinished;

		// Token: 0x0401955A RID: 103770
		private int[] EnterBossRoleIdList = new int[3];
	}
}
