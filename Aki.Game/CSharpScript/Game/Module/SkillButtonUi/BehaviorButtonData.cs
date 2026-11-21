using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BAA RID: 15274
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorButtonData
	{
		// Token: 0x06027258 RID: 160344 RVA: 0x00AF3EAC File Offset: 0x00AF20AC
		[NullableContext(1)]
		public void Refresh(EntityHandle entityHandle, BehaviorCommonButton config)
		{
			this.EntityHandle = entityHandle;
			this.Config = new BehaviorCommonButton?(config);
			WorldEntity entity = entityHandle.Entity;
			this.InputAction = (EInputAction)((byte)config.ActionType);
			this.ButtonType = config.ButtonType;
			this.ActionName = this.InputAction.Name;
			this.DefaultSkillId = config.SkillId;
			this.GameplayTagComponent = entity.GetComponent<BaseTagComponent>();
			this.CreatureDataComponent = entity.GetComponent<CreatureDataComponent>();
			this.CharacterSkillComponent = entity.GetComponent<BaseSkillComponent>();
			this.State = 0;
			this.SkillIconPathList = new List<string>();
			if (config.SkillIconsLength > 0)
			{
				foreach (string item in config.SkillIconsIter())
				{
					this.SkillIconPathList.Add(item);
				}
			}
			CreatureDataComponent creatureDataComponent = this.CreatureDataComponent;
			this.RoleConfig = ((creatureDataComponent != null) ? creatureDataComponent.GetRoleConfig() : null);
			this.RefreshTag();
			this.RefreshSkillId();
			this.RefreshDynamicEffect();
			this.RefreshIsEnable();
			this.RefreshIsVisible();
			this.RefreshSkillTexturePath();
		}

		// Token: 0x06027259 RID: 160345 RVA: 0x00AF3FDC File Offset: 0x00AF21DC
		private void RefreshTag()
		{
			this.DisableTagIds.Clear();
			this.DisableSkillIdTagIds.Clear();
			this.VisibleTagIds.Clear();
			this.HiddenTagIds.Clear();
			foreach (int item in this.Config.Value.HiddenTags())
			{
				this.HiddenTagIds.Add(item);
			}
			foreach (int item2 in this.Config.Value.VisibleTags())
			{
				this.VisibleTagIds.Add(item2);
			}
			foreach (int item3 in this.Config.Value.DisableTags())
			{
				this.DisableTagIds.Add(item3);
			}
			foreach (KeyValuePair<int, IntArray> keyValuePair in this.Config.Value.DisableSkillIdTags())
			{
				int key = keyValuePair.Key;
				IntArray value = keyValuePair.Value;
				if (value.ArrayIntLength > 0)
				{
					HashSet<int> hashSet;
					if (!this.DisableSkillIdTagIds.TryGetValue(key, out hashSet))
					{
						hashSet = new HashSet<int>();
						this.DisableSkillIdTagIds[key] = hashSet;
					}
					for (int j = 0; j < value.ArrayIntLength; j++)
					{
						int item4 = value.ArrayInt(j);
						hashSet.Add(item4);
					}
				}
			}
			List<int> list = new List<int>();
			foreach (int item5 in this.Config.Value.SkillIconTags())
			{
				list.Add(item5);
			}
			this.SkillIconTagIds = list.ToArray();
			this.SkillIdTagMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair2 in this.Config.Value.SkillIdTagMap())
			{
				this.SkillIdTagMap[keyValuePair2.Key] = keyValuePair2.Value;
			}
			this.DynamicEffectTagIdMap.Clear();
			foreach (KeyValuePair<int, int> keyValuePair3 in this.Config.Value.DynamicEffectTagMap())
			{
				this.DynamicEffectTagIdMap[keyValuePair3.Key] = keyValuePair3.Value;
			}
		}

		// Token: 0x0602725A RID: 160346 RVA: 0x00AF428C File Offset: 0x00AF248C
		public void RefreshSkillId()
		{
			int skillId = this.SkillId;
			this.SkillId = this.DefaultSkillId;
			this.SkillIdTagId = 0;
			foreach (KeyValuePair<int, int> keyValuePair in this.SkillIdTagMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (this.ContainTagId(key))
				{
					this.SkillId = value;
					this.SkillIdTagId = key;
					break;
				}
			}
			if (skillId != this.SkillId)
			{
				this.RefreshSkillInfo();
			}
		}

		// Token: 0x0602725B RID: 160347 RVA: 0x00AF432C File Offset: 0x00AF252C
		private void RefreshSkillInfo()
		{
			if (this.SkillId == 0)
			{
				this.SkillConfig = null;
				return;
			}
			this.SkillConfig = this.CharacterSkillComponent.GetSkillInfo(this.SkillId);
		}

		// Token: 0x0602725C RID: 160348 RVA: 0x00AF4358 File Offset: 0x00AF2558
		public void RefreshIsEnable()
		{
			foreach (int tagId in this.DisableTagIds)
			{
				if (this.ContainTagId(tagId))
				{
					this.IsEnableInternal = false;
					return;
				}
			}
			if (this.SkillId != 0)
			{
				foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.DisableSkillIdTagIds)
				{
					int key = keyValuePair.Key;
					HashSet<int> value = keyValuePair.Value;
					if (this.ContainTagId(key) && value.Contains(this.SkillId))
					{
						this.IsEnableInternal = false;
						return;
					}
				}
			}
			this.IsEnableInternal = true;
		}

		// Token: 0x0602725D RID: 160349 RVA: 0x00AF4438 File Offset: 0x00AF2638
		public void RefreshIsVisible()
		{
			if (this.VisibleTagIds.Count > 0)
			{
				foreach (int tagId in this.VisibleTagIds)
				{
					if (this.ContainTagId(tagId))
					{
						this.IsVisibleInternal = true;
						return;
					}
				}
			}
			if (this.ButtonType == 101 && (this.RoleConfig == null || !this.RoleConfig.GetValueOrDefault().IsAim))
			{
				BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
				if (motorcycleData == null || !motorcycleData.IsDriving)
				{
					this.IsVisibleInternal = false;
					return;
				}
			}
			foreach (int tagId2 in this.HiddenTagIds)
			{
				if (this.ContainTagId(tagId2))
				{
					this.IsVisibleInternal = false;
					return;
				}
			}
			this.IsVisibleInternal = true;
		}

		// Token: 0x0602725E RID: 160350 RVA: 0x00AF454C File Offset: 0x00AF274C
		public void RefreshSkillTexturePath()
		{
			this.SkillIconTagId = 0;
			if (this.SkillIconTagIds != null && this.SkillIconTagIds.Length != 0)
			{
				foreach (int tagId in this.SkillIconTagIds)
				{
					if (this.ContainTagId(tagId) && this.RefreshSkillTexturePathBySkillIconTagInner(tagId))
					{
						return;
					}
				}
			}
			this.SkillIconName = null;
			if (this.SkillId == 0 && this.SkillIconPathList != null)
			{
				this.SkillTexturePath = this.SkillIconPathList.GetValueOrDefault(this.State);
				return;
			}
			SSkillInfo skillConfig = this.SkillConfig;
			if (skillConfig == null)
			{
				this.SkillTexturePath = null;
				return;
			}
			FSoftObjectPath skillIcon = skillConfig.SkillIcon;
			if (skillIcon == null)
			{
				this.SkillTexturePath = null;
				return;
			}
			FName assetPathName = skillIcon.AssetPathName;
			if (FNameUtil.IsNothing(assetPathName))
			{
				this.SkillTexturePath = null;
				return;
			}
			this.SkillTexturePath = assetPathName.ToString();
		}

		// Token: 0x0602725F RID: 160351 RVA: 0x00AF4630 File Offset: 0x00AF2830
		public void RefreshDynamicEffect()
		{
			foreach (KeyValuePair<int, int> keyValuePair in this.DynamicEffectTagIdMap)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (this.ContainTagId(key))
				{
					this.DynamicEffectId = value;
					return;
				}
			}
			this.DynamicEffectId = 0;
		}

		// Token: 0x06027260 RID: 160352 RVA: 0x00AF46A8 File Offset: 0x00AF28A8
		private bool ContainTagId(int tagId)
		{
			return this.GameplayTagComponent != null && this.GameplayTagComponent.HasTag(tagId);
		}

		// Token: 0x06027261 RID: 160353 RVA: 0x00AF46C0 File Offset: 0x00AF28C0
		public void RefreshSkillTexturePathBySkillIconTag(int tagId)
		{
			if (this.SkillIconTagId != 0)
			{
				this.RefreshSkillTexturePath();
				return;
			}
			this.RefreshSkillTexturePathBySkillIconTagInner(tagId);
		}

		// Token: 0x06027262 RID: 160354 RVA: 0x00AF46DC File Offset: 0x00AF28DC
		private bool RefreshSkillTexturePathBySkillIconTagInner(int tagId)
		{
			SkillIcon? skillIconConfigByTag = SkillButtonConfig.Instance.GetSkillIconConfigByTag(tagId);
			if (skillIconConfigByTag == null)
			{
				return false;
			}
			string iconPath = skillIconConfigByTag.Value.IconPath;
			this.SkillIconName = skillIconConfigByTag.Value.Name;
			if (StringUtils.IsEmpty(iconPath))
			{
				return false;
			}
			this.SkillTexturePath = iconPath;
			this.SkillIconTagId = tagId;
			return true;
		}

		// Token: 0x06027263 RID: 160355 RVA: 0x00AF473E File Offset: 0x00AF293E
		public bool IsEnable()
		{
			return this.IsEnableInternal;
		}

		// Token: 0x06027264 RID: 160356 RVA: 0x00AF4746 File Offset: 0x00AF2946
		public int? GetSkillId()
		{
			return new int?(this.SkillId);
		}

		// Token: 0x06027265 RID: 160357 RVA: 0x00AF4753 File Offset: 0x00AF2953
		[NullableContext(1)]
		public Dictionary<int, HashSet<int>> GetDisableSkillIdTagIds()
		{
			return this.DisableSkillIdTagIds;
		}

		// Token: 0x06027266 RID: 160358 RVA: 0x00AF475B File Offset: 0x00AF295B
		public void SetEnable(bool bEnable)
		{
			this.IsEnableInternal = bEnable;
		}

		// Token: 0x06027267 RID: 160359 RVA: 0x00AF4764 File Offset: 0x00AF2964
		public int GetButtonType()
		{
			return this.ButtonType;
		}

		// Token: 0x06027268 RID: 160360 RVA: 0x00AF476C File Offset: 0x00AF296C
		public bool IsVisible()
		{
			return this.IsVisibleInternal;
		}

		// Token: 0x06027269 RID: 160361 RVA: 0x00AF4774 File Offset: 0x00AF2974
		public string GetSkillTexturePath()
		{
			return this.SkillTexturePath;
		}

		// Token: 0x0602726A RID: 160362 RVA: 0x00AF477C File Offset: 0x00AF297C
		public bool IsSkillIdChangeByTag()
		{
			return this.SkillIdTagId != 0;
		}

		// Token: 0x0602726B RID: 160363 RVA: 0x00AF4788 File Offset: 0x00AF2988
		public SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.DynamicEffectId == 0)
			{
				return null;
			}
			return SkillButtonConfig.Instance.GetSkillButtonEffectConfig(this.DynamicEffectId);
		}

		// Token: 0x0602726C RID: 160364 RVA: 0x00AF47B8 File Offset: 0x00AF29B8
		public string GetActionName()
		{
			string text;
			if (BattleUiModel.Instance.MotorcycleData.IsDriving && BehaviorButtonData.MotorcycleActionNames.TryGetValue((EBehaviorType)this.ButtonType, out text) && !string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.ActionName;
		}

		// Token: 0x0602726E RID: 160366 RVA: 0x00AF487D File Offset: 0x00AF2A7D
		// Note: this type is marked as 'beforefieldinit'.
		static BehaviorButtonData()
		{
			Dictionary<EBehaviorType, string> dictionary = new Dictionary<EBehaviorType, string>();
			dictionary[EBehaviorType.Aim] = "载具视角切换";
			dictionary[EBehaviorType.LockTarget] = "载具锁定目标";
			BehaviorButtonData.MotorcycleActionNames = dictionary;
		}

		// Token: 0x04015552 RID: 87378
		[Nullable(1)]
		private static readonly IReadOnlyDictionary<EBehaviorType, string> MotorcycleActionNames;

		// Token: 0x04015553 RID: 87379
		public EntityHandle EntityHandle;

		// Token: 0x04015554 RID: 87380
		public BehaviorCommonButton? Config;

		// Token: 0x04015555 RID: 87381
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x04015556 RID: 87382
		private BaseTagComponent GameplayTagComponent;

		// Token: 0x04015557 RID: 87383
		private BaseSkillComponent CharacterSkillComponent;

		// Token: 0x04015558 RID: 87384
		public bool IsCurEntity;

		// Token: 0x04015559 RID: 87385
		public int ButtonType;

		// Token: 0x0401555A RID: 87386
		[Nullable(1)]
		public string ActionName = "";

		// Token: 0x0401555B RID: 87387
		public EInputAction InputAction = EInputAction.None;

		// Token: 0x0401555C RID: 87388
		public RoleInfo? RoleConfig;

		// Token: 0x0401555D RID: 87389
		private SSkillInfo SkillConfig;

		// Token: 0x0401555E RID: 87390
		public int SkillId;

		// Token: 0x0401555F RID: 87391
		public int DefaultSkillId;

		// Token: 0x04015560 RID: 87392
		public Dictionary<int, int> SkillIdTagMap = new Dictionary<int, int>();

		// Token: 0x04015561 RID: 87393
		private int SkillIdTagId;

		// Token: 0x04015562 RID: 87394
		public int[] SkillIconTagIds;

		// Token: 0x04015563 RID: 87395
		private int SkillIconTagId;

		// Token: 0x04015564 RID: 87396
		public string SkillTexturePath = "";

		// Token: 0x04015565 RID: 87397
		public string SkillIconName = "";

		// Token: 0x04015566 RID: 87398
		[Nullable(1)]
		public Dictionary<int, int> DynamicEffectTagIdMap = new Dictionary<int, int>();

		// Token: 0x04015567 RID: 87399
		public int DynamicEffectId;

		// Token: 0x04015568 RID: 87400
		public int State;

		// Token: 0x04015569 RID: 87401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> SkillIconPathList;

		// Token: 0x0401556A RID: 87402
		[Nullable(1)]
		public readonly List<int> DisableTagIds = new List<int>();

		// Token: 0x0401556B RID: 87403
		[Nullable(1)]
		public readonly Dictionary<int, HashSet<int>> DisableSkillIdTagIds = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401556C RID: 87404
		[Nullable(1)]
		public readonly List<int> VisibleTagIds = new List<int>();

		// Token: 0x0401556D RID: 87405
		[Nullable(1)]
		public readonly List<int> HiddenTagIds = new List<int>();

		// Token: 0x0401556E RID: 87406
		public bool IsEnableInternal;

		// Token: 0x0401556F RID: 87407
		public bool IsVisibleInternal;
	}
}
