using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02005F0A RID: 24330
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceItemData
	{
		// Token: 0x0603DD1B RID: 253211 RVA: 0x00EF1604 File Offset: 0x00EEF804
		public int GetSelectDataIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDataIndex();
			}
			return 0;
		}

		// Token: 0x0603DD1C RID: 253212 RVA: 0x00EF1634 File Offset: 0x00EEF834
		public int GetSelectUiLogicIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetUiLogicIndex();
			}
			return 0;
		}

		// Token: 0x0603DD1D RID: 253213 RVA: 0x00EF1664 File Offset: 0x00EEF864
		public bool GetLockState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetLockState();
		}

		// Token: 0x0603DD1E RID: 253214 RVA: 0x00EF1694 File Offset: 0x00EEF894
		public string GetUnLockDesc()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetUnlockDesc();
			}
			return string.Empty;
		}

		// Token: 0x0603DD1F RID: 253215 RVA: 0x00EF16C7 File Offset: 0x00EEF8C7
		public int GetStyle()
		{
			if (this.MainData != null)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0603DD20 RID: 253216 RVA: 0x00EF16D4 File Offset: 0x00EEF8D4
		public bool GetSelectState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetSelectState();
		}

		// Token: 0x0603DD21 RID: 253217 RVA: 0x00EF1704 File Offset: 0x00EEF904
		public bool GetFinishState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetFinishState();
		}

		// Token: 0x0603DD22 RID: 253218 RVA: 0x00EF1734 File Offset: 0x00EEF934
		public int GetInstanceDungeonId()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetInstanceDungeonId();
			}
			return 0;
		}

		// Token: 0x0603DD23 RID: 253219 RVA: 0x00EF1764 File Offset: 0x00EEF964
		public string GetDesc()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDesc();
			}
			return string.Empty;
		}

		// Token: 0x0603DD24 RID: 253220 RVA: 0x00EF1798 File Offset: 0x00EEF998
		public bool HaveChildData()
		{
			if (this.MainData != null)
			{
				ActivityEntranceSelectItemSubData[] subDataList = this.MainData.GetSubDataList();
				return subDataList != null && subDataList.Length != 0;
			}
			return false;
		}

		// Token: 0x0603DD25 RID: 253221 RVA: 0x00EF17C8 File Offset: 0x00EEF9C8
		public InstanceDungeon? GetInstanceConfig()
		{
			int instanceDungeonId = this.GetInstanceDungeonId();
			if (instanceDungeonId == 0)
			{
				return null;
			}
			return InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId);
		}

		// Token: 0x0603DD26 RID: 253222 RVA: 0x00EF17F4 File Offset: 0x00EEF9F4
		public string GetInstanceDifficultIconPath()
		{
			InstanceDungeon? instanceDungeon;
			return ((this.GetInstanceConfig() != null) ? instanceDungeon.GetValueOrDefault().DifficultyIcon : null) ?? string.Empty;
		}

		// Token: 0x0603DD27 RID: 253223 RVA: 0x00EF182C File Offset: 0x00EEFA2C
		public string GetInstanceName()
		{
			InstanceDungeon? instanceDungeon;
			string text = (this.GetInstanceConfig() != null) ? instanceDungeon.GetValueOrDefault().MapName : null;
			if (!string.IsNullOrEmpty(text))
			{
				return ConfigMultiTextLang.GetLocalTextNew(text, null);
			}
			return string.Empty;
		}

		// Token: 0x0603DD28 RID: 253224 RVA: 0x00EF1874 File Offset: 0x00EEFA74
		[NullableContext(2)]
		public Action<int> GetSelectCallBack()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetClickCallBack();
			}
			return null;
		}

		// Token: 0x0603DD29 RID: 253225 RVA: 0x00EF18A4 File Offset: 0x00EEFAA4
		public bool GetRedDotState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetRedDotState();
		}

		// Token: 0x0603DD2A RID: 253226 RVA: 0x00EF18D4 File Offset: 0x00EEFAD4
		public int GetRecommendLevel()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetRecommendLevel();
			}
			return 0;
		}

		// Token: 0x0603DD2B RID: 253227 RVA: 0x00EF1904 File Offset: 0x00EEFB04
		public string GetSubTitle()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetSubTitle();
			}
			return string.Empty;
		}

		// Token: 0x0603DD2C RID: 253228 RVA: 0x00EF1938 File Offset: 0x00EEFB38
		public int GetDefaultDifficultIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDefaultDifficultIndex();
			}
			return 0;
		}

		// Token: 0x0603DD2D RID: 253229 RVA: 0x00EF1968 File Offset: 0x00EEFB68
		public string GetBgPath()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetBgPath();
			}
			return string.Empty;
		}

		// Token: 0x040204A9 RID: 132265
		[Nullable(2)]
		public ActivityEntranceSelectItemBaseData MainData;

		// Token: 0x040204AA RID: 132266
		[Nullable(2)]
		public ActivityEntranceSelectItemSubData SubData;
	}
}
