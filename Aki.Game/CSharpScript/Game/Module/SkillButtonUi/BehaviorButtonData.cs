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
	// Token: 0x02004BF9 RID: 19449
	[NullableContext(2)]
	[Nullable(0)]
	public class BehaviorButtonData
	{
		// Token: 0x060324B2 RID: 206002 RVA: 0x00BAF898 File Offset: 0x00BADA98
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

		// Token: 0x060324B3 RID: 206003 RVA: 0x00BAF9C8 File Offset: 0x00BADBC8
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

		// Token: 0x060324B4 RID: 206004 RVA: 0x00BAFC78 File Offset: 0x00BADE78
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

		// Token: 0x060324B5 RID: 206005 RVA: 0x00BAFD18 File Offset: 0x00BADF18
		private void RefreshSkillInfo()
		{
			if (this.SkillId == 0)
			{
				this.SkillConfig = null;
				return;
			}
			this.SkillConfig = this.CharacterSkillComponent.GetSkillInfo(this.SkillId);
		}

		// Token: 0x060324B6 RID: 206006 RVA: 0x00BAFD44 File Offset: 0x00BADF44
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

		// Token: 0x060324B7 RID: 206007 RVA: 0x00BAFE24 File Offset: 0x00BAE024
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

		// Token: 0x060324B8 RID: 206008 RVA: 0x00BAFF38 File Offset: 0x00BAE138
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

		// Token: 0x060324B9 RID: 206009 RVA: 0x00BB001C File Offset: 0x00BAE21C
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

		// Token: 0x060324BA RID: 206010 RVA: 0x00BB0094 File Offset: 0x00BAE294
		private bool ContainTagId(int tagId)
		{
			return this.GameplayTagComponent != null && this.GameplayTagComponent.HasTag(tagId);
		}

		// Token: 0x060324BB RID: 206011 RVA: 0x00BB00AC File Offset: 0x00BAE2AC
		public void RefreshSkillTexturePathBySkillIconTag(int tagId)
		{
			if (this.SkillIconTagId != 0)
			{
				this.RefreshSkillTexturePath();
				return;
			}
			this.RefreshSkillTexturePathBySkillIconTagInner(tagId);
		}

		// Token: 0x060324BC RID: 206012 RVA: 0x00BB00C8 File Offset: 0x00BAE2C8
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

		// Token: 0x060324BD RID: 206013 RVA: 0x00BB012A File Offset: 0x00BAE32A
		public bool IsEnable()
		{
			return this.IsEnableInternal;
		}

		// Token: 0x060324BE RID: 206014 RVA: 0x00BB0132 File Offset: 0x00BAE332
		public int? GetSkillId()
		{
			return new int?(this.SkillId);
		}

		// Token: 0x060324BF RID: 206015 RVA: 0x00BB013F File Offset: 0x00BAE33F
		[NullableContext(1)]
		public Dictionary<int, HashSet<int>> GetDisableSkillIdTagIds()
		{
			return this.DisableSkillIdTagIds;
		}

		// Token: 0x060324C0 RID: 206016 RVA: 0x00BB0147 File Offset: 0x00BAE347
		public void SetEnable(bool bEnable)
		{
			this.IsEnableInternal = bEnable;
		}

		// Token: 0x060324C1 RID: 206017 RVA: 0x00BB0150 File Offset: 0x00BAE350
		public int GetButtonType()
		{
			return this.ButtonType;
		}

		// Token: 0x060324C2 RID: 206018 RVA: 0x00BB0158 File Offset: 0x00BAE358
		public bool IsVisible()
		{
			return this.IsVisibleInternal;
		}

		// Token: 0x060324C3 RID: 206019 RVA: 0x00BB0160 File Offset: 0x00BAE360
		public string GetSkillTexturePath()
		{
			return this.SkillTexturePath;
		}

		// Token: 0x060324C4 RID: 206020 RVA: 0x00BB0168 File Offset: 0x00BAE368
		public bool IsSkillIdChangeByTag()
		{
			return this.SkillIdTagId != 0;
		}

		// Token: 0x060324C5 RID: 206021 RVA: 0x00BB0174 File Offset: 0x00BAE374
		public SkillButtonEffect? GetDynamicEffectConfig()
		{
			if (this.DynamicEffectId == 0)
			{
				return null;
			}
			return SkillButtonConfig.Instance.GetSkillButtonEffectConfig(this.DynamicEffectId);
		}

		// Token: 0x060324C6 RID: 206022 RVA: 0x00BB01A4 File Offset: 0x00BAE3A4
		public string GetActionName()
		{
			string text;
			if (BattleUiModel.Instance.MotorcycleData.IsDriving && BehaviorButtonData.MotorcycleActionNames.TryGetValue((EBehaviorType)this.ButtonType, out text) && !string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.ActionName;
		}

		// Token: 0x060324C8 RID: 206024 RVA: 0x00BB0269 File Offset: 0x00BAE469
		// Note: this type is marked as 'beforefieldinit'.
		static BehaviorButtonData()
		{
			Dictionary<EBehaviorType, string> dictionary = new Dictionary<EBehaviorType, string>();
			dictionary[EBehaviorType.Aim] = "载具视角切换";
			dictionary[EBehaviorType.LockTarget] = "载具锁定目标";
			BehaviorButtonData.MotorcycleActionNames = dictionary;
		}

		// Token: 0x0401ABF8 RID: 109560
		[Nullable(1)]
		private static readonly IReadOnlyDictionary<EBehaviorType, string> MotorcycleActionNames;

		// Token: 0x0401ABF9 RID: 109561
		public EntityHandle EntityHandle;

		// Token: 0x0401ABFA RID: 109562
		public BehaviorCommonButton? Config;

		// Token: 0x0401ABFB RID: 109563
		private CreatureDataComponent CreatureDataComponent;

		// Token: 0x0401ABFC RID: 109564
		private BaseTagComponent GameplayTagComponent;

		// Token: 0x0401ABFD RID: 109565
		private BaseSkillComponent CharacterSkillComponent;

		// Token: 0x0401ABFE RID: 109566
		public bool IsCurEntity;

		// Token: 0x0401ABFF RID: 109567
		public int ButtonType;

		// Token: 0x0401AC00 RID: 109568
		[Nullable(1)]
		public string ActionName = "";

		// Token: 0x0401AC01 RID: 109569
		public EInputAction InputAction = EInputAction.None;

		// Token: 0x0401AC02 RID: 109570
		public RoleInfo? RoleConfig;

		// Token: 0x0401AC03 RID: 109571
		private SSkillInfo SkillConfig;

		// Token: 0x0401AC04 RID: 109572
		public int SkillId;

		// Token: 0x0401AC05 RID: 109573
		public int DefaultSkillId;

		// Token: 0x0401AC06 RID: 109574
		public Dictionary<int, int> SkillIdTagMap = new Dictionary<int, int>();

		// Token: 0x0401AC07 RID: 109575
		private int SkillIdTagId;

		// Token: 0x0401AC08 RID: 109576
		public int[] SkillIconTagIds;

		// Token: 0x0401AC09 RID: 109577
		private int SkillIconTagId;

		// Token: 0x0401AC0A RID: 109578
		public string SkillTexturePath = "";

		// Token: 0x0401AC0B RID: 109579
		public string SkillIconName = "";

		// Token: 0x0401AC0C RID: 109580
		[Nullable(1)]
		public Dictionary<int, int> DynamicEffectTagIdMap = new Dictionary<int, int>();

		// Token: 0x0401AC0D RID: 109581
		public int DynamicEffectId;

		// Token: 0x0401AC0E RID: 109582
		public int State;

		// Token: 0x0401AC0F RID: 109583
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> SkillIconPathList;

		// Token: 0x0401AC10 RID: 109584
		[Nullable(1)]
		public readonly List<int> DisableTagIds = new List<int>();

		// Token: 0x0401AC11 RID: 109585
		[Nullable(1)]
		public readonly Dictionary<int, HashSet<int>> DisableSkillIdTagIds = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401AC12 RID: 109586
		[Nullable(1)]
		public readonly List<int> VisibleTagIds = new List<int>();

		// Token: 0x0401AC13 RID: 109587
		[Nullable(1)]
		public readonly List<int> HiddenTagIds = new List<int>();

		// Token: 0x0401AC14 RID: 109588
		public bool IsEnableInternal;

		// Token: 0x0401AC15 RID: 109589
		public bool IsVisibleInternal;
	}
}
