using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C08 RID: 19464
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonFormationData
	{
		// Token: 0x06032603 RID: 206339 RVA: 0x00BB9AF5 File Offset: 0x00BB7CF5
		public void Init()
		{
		}

		// Token: 0x06032604 RID: 206340 RVA: 0x00BB9AF8 File Offset: 0x00BB7CF8
		public void Clear()
		{
			foreach (SkillButtonTypeFormationData skillButtonTypeFormationData in this.SkillButtonTypeDataMap.Values)
			{
				skillButtonTypeFormationData.Clear();
			}
		}

		// Token: 0x06032605 RID: 206341 RVA: 0x00BB9B50 File Offset: 0x00BB7D50
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

		// Token: 0x06032606 RID: 206342 RVA: 0x00BB9B84 File Offset: 0x00BB7D84
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

		// Token: 0x06032607 RID: 206343 RVA: 0x00BB9C38 File Offset: 0x00BB7E38
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

		// Token: 0x06032608 RID: 206344 RVA: 0x00BB9C90 File Offset: 0x00BB7E90
		private string GetIconPathByName(string iconName)
		{
			return UiResourceConfig.Instance.GetResourcePath(iconName);
		}

		// Token: 0x0401ACDF RID: 109791
		private const int FOLLOWER_ID = 658700001;

		// Token: 0x0401ACE0 RID: 109792
		private readonly Dictionary<ESkillButtonType, SkillButtonTypeFormationData> SkillButtonTypeDataMap = new Dictionary<ESkillButtonType, SkillButtonTypeFormationData>();

		// Token: 0x0401ACE1 RID: 109793
		private bool IsFollowerAiming;

		// Token: 0x0401ACE2 RID: 109794
		[Nullable(2)]
		private string FollowerAimIconPath;
	}
}
