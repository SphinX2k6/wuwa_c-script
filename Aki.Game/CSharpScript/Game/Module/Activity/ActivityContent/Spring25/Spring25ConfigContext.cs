using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02006098 RID: 24728
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25ConfigContext
	{
		// Token: 0x1700907D RID: 36989
		// (get) Token: 0x0603E806 RID: 256006 RVA: 0x00F1B684 File Offset: 0x00F19884
		private Dictionary<int, SpringSign> SignCfgCache
		{
			get
			{
				if (this.SignCfgCacheInternal == null)
				{
					this.SignCfgCacheInternal = new Dictionary<int, SpringSign>();
					IReadOnlyList<SpringSign> configList = ConfigSpringSignAll.GetConfigList(true);
					if (configList != null)
					{
						int currentActivityId = this.AttachedModel.CurrentActivityId;
						foreach (SpringSign value in configList)
						{
							if (currentActivityId == value.ActivityId)
							{
								this.SignCfgCacheInternal[value.Id] = value;
							}
						}
					}
				}
				return this.SignCfgCacheInternal;
			}
		}

		// Token: 0x1700907E RID: 36990
		// (get) Token: 0x0603E807 RID: 256007 RVA: 0x00F1B714 File Offset: 0x00F19914
		private Dictionary<int, SpringReward> TaskCfgCache
		{
			get
			{
				if (this.TaskCfgCacheInternal == null)
				{
					this.TaskCfgCacheInternal = new Dictionary<int, SpringReward>();
					IReadOnlyList<SpringReward> configList = ConfigSpringRewardAll.GetConfigList(true);
					if (configList != null)
					{
						int currentActivityId = this.AttachedModel.CurrentActivityId;
						foreach (SpringReward value in configList)
						{
							if (currentActivityId == value.ActivityId)
							{
								this.TaskCfgCacheInternal[value.Id] = value;
							}
						}
					}
				}
				return this.TaskCfgCacheInternal;
			}
		}

		// Token: 0x0603E808 RID: 256008 RVA: 0x00F1B7A4 File Offset: 0x00F199A4
		public Spring25ConfigContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x0603E809 RID: 256009 RVA: 0x00F1B7B3 File Offset: 0x00F199B3
		public void Dispose()
		{
			Dictionary<int, SpringReward> taskCfgCacheInternal = this.TaskCfgCacheInternal;
			if (taskCfgCacheInternal != null)
			{
				taskCfgCacheInternal.Clear();
			}
			this.TaskCfgCacheInternal = null;
			Dictionary<int, SpringSign> signCfgCacheInternal = this.SignCfgCacheInternal;
			if (signCfgCacheInternal != null)
			{
				signCfgCacheInternal.Clear();
			}
			this.SignCfgCacheInternal = null;
		}

		// Token: 0x0603E80A RID: 256010 RVA: 0x00F1B7E8 File Offset: 0x00F199E8
		private SpringResource? GetResourceCfgBySignId(int id)
		{
			SpringSign springSign;
			int p0RoleType = this.SignCfgCache.TryGetValue(id, out springSign) ? springSign.ResourceTypeId : 0;
			IReadOnlyList<SpringResource> configList = ConfigSpringResourceByRoleType.GetConfigList(p0RoleType, true);
			if (configList == null)
			{
				return null;
			}
			if (configList.Count <= 0)
			{
				return null;
			}
			return new SpringResource?(configList[0]);
		}

		// Token: 0x1700907F RID: 36991
		// (get) Token: 0x0603E80B RID: 256011 RVA: 0x00F1B844 File Offset: 0x00F19A44
		public Dictionary<int, SpringReward> TaskCfgMap
		{
			get
			{
				return this.TaskCfgCache;
			}
		}

		// Token: 0x17009080 RID: 36992
		// (get) Token: 0x0603E80C RID: 256012 RVA: 0x00F1B84C File Offset: 0x00F19A4C
		public Dictionary<int, SpringSign> SignCfgMap
		{
			get
			{
				return this.SignCfgCache;
			}
		}

		// Token: 0x17009081 RID: 36993
		// (get) Token: 0x0603E80D RID: 256013 RVA: 0x00F1B854 File Offset: 0x00F19A54
		public int TaskCount
		{
			get
			{
				return this.TaskCfgMap.Count;
			}
		}

		// Token: 0x17009082 RID: 36994
		// (get) Token: 0x0603E80E RID: 256014 RVA: 0x00F1B861 File Offset: 0x00F19A61
		public int SignCount
		{
			get
			{
				return this.SignCfgCache.Count;
			}
		}

		// Token: 0x0603E80F RID: 256015 RVA: 0x00F1B86E File Offset: 0x00F19A6E
		public SpringChat? StartChatCfgByGender(EPlayerGender gender)
		{
			if (gender == EPlayerGender.Male)
			{
				return ConfigSpringChatById.GetConfig(99, true);
			}
			return ConfigSpringChatById.GetConfig(100, true);
		}

		// Token: 0x0603E810 RID: 256016 RVA: 0x00F1B888 File Offset: 0x00F19A88
		public SpringChat? GetChatConfigBySignId(int id, EPlayerGender gender)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			int[] array = resourceCfgBySignId.Value.DialogDataList();
			if (array.Length < 2)
			{
				return null;
			}
			int p0Id;
			if (gender == EPlayerGender.Male)
			{
				p0Id = array[0];
			}
			else
			{
				p0Id = array[1];
			}
			return ConfigSpringChatById.GetConfig(p0Id, true);
		}

		// Token: 0x0603E811 RID: 256017 RVA: 0x00F1B8E8 File Offset: 0x00F19AE8
		[NullableContext(2)]
		public string GetLetterContentTextIdBySignId(int id)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			return resourceCfgBySignId.GetValueOrDefault().LetterContent;
		}

		// Token: 0x0603E812 RID: 256018 RVA: 0x00F1B918 File Offset: 0x00F19B18
		[NullableContext(2)]
		public string GetLetterTitleTextIdBySignId(int id)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			return resourceCfgBySignId.GetValueOrDefault().LetterTitle;
		}

		// Token: 0x0603E813 RID: 256019 RVA: 0x00F1B948 File Offset: 0x00F19B48
		[NullableContext(2)]
		public string GetLetterTabTextIdBySignId(int id)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			return resourceCfgBySignId.GetValueOrDefault().LetterTab;
		}

		// Token: 0x0603E814 RID: 256020 RVA: 0x00F1B978 File Offset: 0x00F19B78
		[NullableContext(2)]
		public string GetLetterIconBySignId(int id)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			return resourceCfgBySignId.GetValueOrDefault().MailIcon;
		}

		// Token: 0x0603E815 RID: 256021 RVA: 0x00F1B9A8 File Offset: 0x00F19BA8
		[NullableContext(2)]
		public string GetRoleNameTextIdBySignId(int id)
		{
			SpringResource? resourceCfgBySignId = this.GetResourceCfgBySignId(id);
			if (resourceCfgBySignId == null)
			{
				return null;
			}
			return resourceCfgBySignId.GetValueOrDefault().RoleName;
		}

		// Token: 0x0603E816 RID: 256022 RVA: 0x00F1B9D8 File Offset: 0x00F19BD8
		public ESpring25RoleType? GetResourceTypeBySignId(int id)
		{
			SpringSign? config = ConfigSpringSignById.GetConfig(id, true);
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				int resourceTypeId = config.GetValueOrDefault().ResourceTypeId;
				flag = true;
			}
			if (!flag)
			{
				return null;
			}
			config = ConfigSpringSignById.GetConfig(id, true);
			return new ESpring25RoleType?((ESpring25RoleType)config.Value.ResourceTypeId);
		}

		// Token: 0x0603E817 RID: 256023 RVA: 0x00F1BA34 File Offset: 0x00F19C34
		[NullableContext(2)]
		public string GetTaskNameTextIdByTaskId(int id)
		{
			SpringReward springReward;
			this.TaskCfgCache.TryGetValue(id, out springReward);
			return springReward.TaskTitle;
		}

		// Token: 0x0603E818 RID: 256024 RVA: 0x00F1BA58 File Offset: 0x00F19C58
		public int GetTaskThresholdByTaskId(int id)
		{
			SpringReward springReward;
			this.TaskCfgCache.TryGetValue(id, out springReward);
			return springReward.TaskThreshold;
		}

		// Token: 0x04020B63 RID: 133987
		private readonly Spring25Model AttachedModel;

		// Token: 0x04020B64 RID: 133988
		[Nullable(2)]
		private Dictionary<int, SpringSign> SignCfgCacheInternal;

		// Token: 0x04020B65 RID: 133989
		[Nullable(2)]
		private Dictionary<int, SpringReward> TaskCfgCacheInternal;
	}
}
