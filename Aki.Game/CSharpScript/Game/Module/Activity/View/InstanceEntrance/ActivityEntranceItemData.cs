using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.View.InstanceEntrance
{
	// Token: 0x02004EF1 RID: 20209
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityEntranceItemData
	{
		// Token: 0x06032CB6 RID: 208054 RVA: 0x00E4330C File Offset: 0x00E4150C
		public int GetSelectDataIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDataIndex();
			}
			return 0;
		}

		// Token: 0x06032CB7 RID: 208055 RVA: 0x00E4333C File Offset: 0x00E4153C
		public int GetSelectUiLogicIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetUiLogicIndex();
			}
			return 0;
		}

		// Token: 0x06032CB8 RID: 208056 RVA: 0x00E4336C File Offset: 0x00E4156C
		public bool GetLockState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetLockState();
		}

		// Token: 0x06032CB9 RID: 208057 RVA: 0x00E4339C File Offset: 0x00E4159C
		public string GetUnLockDesc()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetUnlockDesc();
			}
			return string.Empty;
		}

		// Token: 0x06032CBA RID: 208058 RVA: 0x00E433CF File Offset: 0x00E415CF
		public int GetStyle()
		{
			if (this.MainData != null)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06032CBB RID: 208059 RVA: 0x00E433DC File Offset: 0x00E415DC
		public bool GetSelectState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetSelectState();
		}

		// Token: 0x06032CBC RID: 208060 RVA: 0x00E4340C File Offset: 0x00E4160C
		public bool GetFinishState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetFinishState();
		}

		// Token: 0x06032CBD RID: 208061 RVA: 0x00E4343C File Offset: 0x00E4163C
		public int GetInstanceDungeonId()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetInstanceDungeonId();
			}
			return 0;
		}

		// Token: 0x06032CBE RID: 208062 RVA: 0x00E4346C File Offset: 0x00E4166C
		public string GetDesc()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDesc();
			}
			return string.Empty;
		}

		// Token: 0x06032CBF RID: 208063 RVA: 0x00E434A0 File Offset: 0x00E416A0
		public bool HaveChildData()
		{
			if (this.MainData != null)
			{
				ActivityEntranceSelectItemSubData[] subDataList = this.MainData.GetSubDataList();
				return subDataList != null && subDataList.Length != 0;
			}
			return false;
		}

		// Token: 0x06032CC0 RID: 208064 RVA: 0x00E434D0 File Offset: 0x00E416D0
		public InstanceDungeon? GetInstanceConfig()
		{
			int instanceDungeonId = this.GetInstanceDungeonId();
			if (instanceDungeonId == 0)
			{
				return null;
			}
			return InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId);
		}

		// Token: 0x06032CC1 RID: 208065 RVA: 0x00E434FC File Offset: 0x00E416FC
		public string GetInstanceDifficultIconPath()
		{
			InstanceDungeon? instanceDungeon;
			return ((this.GetInstanceConfig() != null) ? instanceDungeon.GetValueOrDefault().DifficultyIcon : null) ?? string.Empty;
		}

		// Token: 0x06032CC2 RID: 208066 RVA: 0x00E43534 File Offset: 0x00E41734
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

		// Token: 0x06032CC3 RID: 208067 RVA: 0x00E4357C File Offset: 0x00E4177C
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

		// Token: 0x06032CC4 RID: 208068 RVA: 0x00E435AC File Offset: 0x00E417AC
		public bool GetRedDotState()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			return activityEntranceSelectItemBaseData != null && activityEntranceSelectItemBaseData.GetRedDotState();
		}

		// Token: 0x06032CC5 RID: 208069 RVA: 0x00E435DC File Offset: 0x00E417DC
		public int GetRecommendLevel()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetRecommendLevel();
			}
			return 0;
		}

		// Token: 0x06032CC6 RID: 208070 RVA: 0x00E4360C File Offset: 0x00E4180C
		public string GetSubTitle()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetSubTitle();
			}
			return string.Empty;
		}

		// Token: 0x06032CC7 RID: 208071 RVA: 0x00E43640 File Offset: 0x00E41840
		public int GetDefaultDifficultIndex()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetDefaultDifficultIndex();
			}
			return 0;
		}

		// Token: 0x06032CC8 RID: 208072 RVA: 0x00E43670 File Offset: 0x00E41870
		public string GetBgPath()
		{
			ActivityEntranceSelectItemBaseData activityEntranceSelectItemBaseData = (this.MainData != null) ? this.MainData : this.SubData;
			if (activityEntranceSelectItemBaseData != null)
			{
				return activityEntranceSelectItemBaseData.GetBgPath();
			}
			return string.Empty;
		}

		// Token: 0x0401AF7B RID: 110459
		[Nullable(2)]
		public ActivityEntranceSelectItemBaseData MainData;

		// Token: 0x0401AF7C RID: 110460
		[Nullable(2)]
		public ActivityEntranceSelectItemSubData SubData;
	}
}
