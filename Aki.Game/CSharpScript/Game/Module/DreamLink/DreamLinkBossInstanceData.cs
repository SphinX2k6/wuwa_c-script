using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA1 RID: 23201
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkBossInstanceData
	{
		// Token: 0x0603AC42 RID: 240706 RVA: 0x00DFF1BA File Offset: 0x00DFD3BA
		public DreamLinkBossInstanceData(int typeId, int instId, int conditionGroupId)
		{
			this.TypeId = typeId;
			this.InstId = instId;
			this.ConditionGroupId = conditionGroupId;
		}

		// Token: 0x0603AC43 RID: 240707 RVA: 0x00DFF1E4 File Offset: 0x00DFD3E4
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

		// Token: 0x0603AC44 RID: 240708 RVA: 0x00DFF260 File Offset: 0x00DFD460
		public bool GetTickState()
		{
			return !this.IsUnlock && (double)this.UnlockTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603AC45 RID: 240709 RVA: 0x00DFF282 File Offset: 0x00DFD482
		public void SetBossRoleIdByIndex(int index, int roleId)
		{
			this.EnterBossRoleIdList[index] = roleId;
		}

		// Token: 0x0603AC46 RID: 240710 RVA: 0x00DFF28D File Offset: 0x00DFD48D
		public int GetBossRoleIdByIndex(int index)
		{
			return this.EnterBossRoleIdList[index];
		}

		// Token: 0x0603AC47 RID: 240711 RVA: 0x00DFF297 File Offset: 0x00DFD497
		public int[] GetBossRoleIdList()
		{
			return this.EnterBossRoleIdList;
		}

		// Token: 0x0401EAAC RID: 125612
		public int TypeId;

		// Token: 0x0401EAAD RID: 125613
		public int InstId;

		// Token: 0x0401EAAE RID: 125614
		public int ConditionGroupId;

		// Token: 0x0401EAAF RID: 125615
		public int Score;

		// Token: 0x0401EAB0 RID: 125616
		public bool IsUnlock;

		// Token: 0x0401EAB1 RID: 125617
		public long UnlockTime;

		// Token: 0x0401EAB2 RID: 125618
		public bool IsFinished;

		// Token: 0x0401EAB3 RID: 125619
		private int[] EnterBossRoleIdList = new int[3];
	}
}
