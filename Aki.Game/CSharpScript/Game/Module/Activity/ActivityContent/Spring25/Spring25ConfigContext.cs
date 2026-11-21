using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005016 RID: 20502
	[NullableContext(1)]
	[Nullable(0)]
	public class Spring25ConfigContext
	{
		// Token: 0x170063DF RID: 25567
		// (get) Token: 0x060334CA RID: 210122 RVA: 0x00E62448 File Offset: 0x00E60648
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

		// Token: 0x170063E0 RID: 25568
		// (get) Token: 0x060334CB RID: 210123 RVA: 0x00E624D8 File Offset: 0x00E606D8
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

		// Token: 0x060334CC RID: 210124 RVA: 0x00E62568 File Offset: 0x00E60768
		public Spring25ConfigContext(Spring25Model model)
		{
			this.AttachedModel = model;
		}

		// Token: 0x060334CD RID: 210125 RVA: 0x00E62577 File Offset: 0x00E60777
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

		// Token: 0x060334CE RID: 210126 RVA: 0x00E625AC File Offset: 0x00E607AC
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

		// Token: 0x170063E1 RID: 25569
		// (get) Token: 0x060334CF RID: 210127 RVA: 0x00E62608 File Offset: 0x00E60808
		public Dictionary<int, SpringReward> TaskCfgMap
		{
			get
			{
				return this.TaskCfgCache;
			}
		}

		// Token: 0x170063E2 RID: 25570
		// (get) Token: 0x060334D0 RID: 210128 RVA: 0x00E62610 File Offset: 0x00E60810
		public Dictionary<int, SpringSign> SignCfgMap
		{
			get
			{
				return this.SignCfgCache;
			}
		}

		// Token: 0x170063E3 RID: 25571
		// (get) Token: 0x060334D1 RID: 210129 RVA: 0x00E62618 File Offset: 0x00E60818
		public int TaskCount
		{
			get
			{
				return this.TaskCfgMap.Count;
			}
		}

		// Token: 0x170063E4 RID: 25572
		// (get) Token: 0x060334D2 RID: 210130 RVA: 0x00E62625 File Offset: 0x00E60825
		public int SignCount
		{
			get
			{
				return this.SignCfgCache.Count;
			}
		}

		// Token: 0x060334D3 RID: 210131 RVA: 0x00E62632 File Offset: 0x00E60832
		public SpringChat? StartChatCfgByGender(EPlayerGender gender)
		{
			if (gender == EPlayerGender.Male)
			{
				return ConfigSpringChatById.GetConfig(99, true);
			}
			return ConfigSpringChatById.GetConfig(100, true);
		}

		// Token: 0x060334D4 RID: 210132 RVA: 0x00E6264C File Offset: 0x00E6084C
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

		// Token: 0x060334D5 RID: 210133 RVA: 0x00E626AC File Offset: 0x00E608AC
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

		// Token: 0x060334D6 RID: 210134 RVA: 0x00E626DC File Offset: 0x00E608DC
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

		// Token: 0x060334D7 RID: 210135 RVA: 0x00E6270C File Offset: 0x00E6090C
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

		// Token: 0x060334D8 RID: 210136 RVA: 0x00E6273C File Offset: 0x00E6093C
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

		// Token: 0x060334D9 RID: 210137 RVA: 0x00E6276C File Offset: 0x00E6096C
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

		// Token: 0x060334DA RID: 210138 RVA: 0x00E6279C File Offset: 0x00E6099C
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

		// Token: 0x060334DB RID: 210139 RVA: 0x00E627F8 File Offset: 0x00E609F8
		[NullableContext(2)]
		public string GetTaskNameTextIdByTaskId(int id)
		{
			SpringReward springReward;
			this.TaskCfgCache.TryGetValue(id, out springReward);
			return springReward.TaskTitle;
		}

		// Token: 0x060334DC RID: 210140 RVA: 0x00E6281C File Offset: 0x00E60A1C
		public int GetTaskThresholdByTaskId(int id)
		{
			SpringReward springReward;
			this.TaskCfgCache.TryGetValue(id, out springReward);
			return springReward.TaskThreshold;
		}

		// Token: 0x0401B490 RID: 111760
		private readonly Spring25Model AttachedModel;

		// Token: 0x0401B491 RID: 111761
		[Nullable(2)]
		private Dictionary<int, SpringSign> SignCfgCacheInternal;

		// Token: 0x0401B492 RID: 111762
		[Nullable(2)]
		private Dictionary<int, SpringReward> TaskCfgCacheInternal;
	}
}
