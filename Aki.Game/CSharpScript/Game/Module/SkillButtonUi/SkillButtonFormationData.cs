using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BB9 RID: 15289
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonFormationData
	{
		// Token: 0x060273B3 RID: 160691 RVA: 0x00AFE679 File Offset: 0x00AFC879
		public void Init()
		{
		}

		// Token: 0x060273B4 RID: 160692 RVA: 0x00AFE67C File Offset: 0x00AFC87C
		public void Clear()
		{
			foreach (SkillButtonTypeFormationData skillButtonTypeFormationData in this.SkillButtonTypeDataMap.Values)
			{
				skillButtonTypeFormationData.Clear();
			}
		}

		// Token: 0x060273B5 RID: 160693 RVA: 0x00AFE6D4 File Offset: 0x00AFC8D4
		public SkillButtonTypeFormationData GetSkillButtonTypeFormationData(ESkillButtonType skillButtonType)
		{
			SkillButtonTypeFormationData skillButtonTypeFormationData;
			if (!this.SkillButtonTypeDataMap.TryGetValue(skillButtonType, out skillButtonTypeFormationData))
			{
				skillButtonTypeFormationData = new SkillButtonTypeFormationData();
				this.SkillButtonTypeDataMap[skillButtonType] = skillButtonTypeFormationData;
			}
			return skillButtonTypeFormationData;
		}

		// Token: 0x060273B6 RID: 160694 RVA: 0x00AFE708 File Offset: 0x00AFC908
		public void RefreshOnFollowerAimStateChange(bool isAiming)
		{
			if (isAiming == this.IsFollowerAiming)
			{
				return;
			}
			this.IsFollowerAiming = isAiming;
			if (!isAiming)
			{
				this.SetSkillIconPath(ESkillButtonType.幻象1, null, 0);
			}
			else
			{
				BattleUiModel instance = BattleUiModel.Instance;
				object obj;
				if (instance == null)
				{
					obj = null;
				}
				else
				{
					BattleUiFormationData formationData = instance.FormationData;
					obj = ((formationData != null) ? formationData.GetFollowerEntityHandle() : null);
				}
				object obj2 = obj;
				if (obj2 != null && obj2.PbDataId == 658700001)
				{
					if (string.IsNullOrEmpty(this.FollowerAimIconPath))
					{
						this.FollowerAimIconPath = this.GetIconPathByName("SP_IconT35");
					}
					this.SetSkillIconPath(ESkillButtonType.幻象1, this.FollowerAimIconPath, 210020);
				}
				else
				{
					this.SetSkillIconPath(ESkillButtonType.幻象1, null, 0);
				}
			}
			SkillButtonUiModel instance2 = SkillButtonUiModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			SkillButtonFollowerEntityData curSkillButtonFollowerEntityData = instance2.GetCurSkillButtonFollowerEntityData();
			if (curSkillButtonFollowerEntityData == null)
			{
				return;
			}
			curSkillButtonFollowerEntityData.SetEnable(isAiming);
		}

		// Token: 0x060273B7 RID: 160695 RVA: 0x00AFE7BC File Offset: 0x00AFC9BC
		[NullableContext(2)]
		private void SetSkillIconPath(ESkillButtonType skillButtonType, string path, int skillId = 0)
		{
			SkillButtonTypeFormationData skillButtonTypeFormationData = this.GetSkillButtonTypeFormationData(skillButtonType);
			if (skillButtonTypeFormationData.SkillIconPath == path && skillButtonTypeFormationData.EnableSkillId == skillId)
			{
				return;
			}
			skillButtonTypeFormationData.SkillIconPath = path;
			skillButtonTypeFormationData.EnableSkillId = skillId;
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			SkillButtonEntityData skillButtonEntityData = (instance != null) ? instance.GetCurSkillButtonEntityData() : null;
			if (skillButtonEntityData == null)
			{
				return;
			}
			skillButtonEntityData.RefreshSkillTexturePath(skillButtonType);
		}

		// Token: 0x060273B8 RID: 160696 RVA: 0x00AFE814 File Offset: 0x00AFCA14
		private string GetIconPathByName(string iconName)
		{
			return UiResourceConfig.Instance.GetResourcePath(iconName);
		}

		// Token: 0x0401563B RID: 87611
		private const int FOLLOWER_ID = 658700001;

		// Token: 0x0401563C RID: 87612
		private readonly Dictionary<ESkillButtonType, SkillButtonTypeFormationData> SkillButtonTypeDataMap = new Dictionary<ESkillButtonType, SkillButtonTypeFormationData>();

		// Token: 0x0401563D RID: 87613
		private bool IsFollowerAiming;

		// Token: 0x0401563E RID: 87614
		[Nullable(2)]
		private string FollowerAimIconPath;
	}
}
