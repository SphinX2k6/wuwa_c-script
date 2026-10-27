using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.HonamiStory.Data
{
	// Token: 0x02005952 RID: 22866
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryPlayerData
	{
		// Token: 0x0603A05B RID: 237659 RVA: 0x00DCAA39 File Offset: 0x00DC8C39
		public static HonamiStoryPlayerData Create()
		{
			return new HonamiStoryPlayerData();
		}

		// Token: 0x0603A05C RID: 237660 RVA: 0x00DCAA40 File Offset: 0x00DC8C40
		public void SetLifeSupportLevel(int value)
		{
			if (this.LifeSupportLevelMap.Count == 0)
			{
				int activityId = HonamiStoryModel.Instance.ActivityId;
				IReadOnlyList<HonamiStoryLifeSupport> lifeSupportList = HonamiStoryConfig.Instance.GetLifeSupportList(activityId);
				if (lifeSupportList == null)
				{
					return;
				}
				foreach (HonamiStoryLifeSupport honamiStoryLifeSupport in lifeSupportList)
				{
					this.LifeSupportLevelMap[honamiStoryLifeSupport.Level] = honamiStoryLifeSupport.Id;
				}
			}
			int id;
			if (!this.LifeSupportLevelMap.TryGetValue(value, out id))
			{
				return;
			}
			HonamiStoryLifeSupport? lifeSupport = HonamiStoryConfig.Instance.GetLifeSupport(id);
			if (lifeSupport == null)
			{
				return;
			}
			this.LifeSupportLevel = value;
			this.LifeSupportId = lifeSupport.Value.Id;
		}

		// Token: 0x0603A05D RID: 237661 RVA: 0x00DCAB0C File Offset: 0x00DC8D0C
		public int GetCurLevelId(int level)
		{
			return this.LifeSupportLevelMap.GetValueOrDefault(level, 0);
		}

		// Token: 0x0603A05E RID: 237662 RVA: 0x00DCAB1C File Offset: 0x00DC8D1C
		public int GetCurMaxValue()
		{
			int id;
			if (!this.LifeSupportLevelMap.TryGetValue(this.LifeSupportLevel, out id))
			{
				return 0;
			}
			return HonamiStoryConfig.Instance.GetLifeSupport(id).Value.SteadyValue;
		}

		// Token: 0x0603A05F RID: 237663 RVA: 0x00DCAB5B File Offset: 0x00DC8D5B
		public void UpdatePowerLevel()
		{
			this.PowerLevel = HonamiStoryModel.Instance.GetPlayerBackpackData().GetPowerLevel(true);
		}

		// Token: 0x0603A060 RID: 237664 RVA: 0x00DCAB74 File Offset: 0x00DC8D74
		public int GetLifeSupportMaxLevel()
		{
			int num = 0;
			foreach (KeyValuePair<int, int> keyValuePair in this.LifeSupportLevelMap)
			{
				int val;
				int num2;
				keyValuePair.Deconstruct(out val, out num2);
				num = Math.Max(val, num);
			}
			return num;
		}

		// Token: 0x0603A061 RID: 237665 RVA: 0x00DCABD8 File Offset: 0x00DC8DD8
		public string GetLifeSupportIcon()
		{
			if (!FunctionModel.Instance.IsOpen(10105))
			{
				if (string.IsNullOrEmpty(this.MainInstPath))
				{
					this.MainInstPath = UiResourceConfig.Instance.GetResourcePath("SP_MainBarIconFirst");
				}
				return this.MainInstPath;
			}
			EFormationAttributeId attrId = EFormationAttributeId.HonamiStoryLifeSupport;
			float value = FormationAttributeController.Instance.GetValue(attrId);
			float max = FormationAttributeController.Instance.GetMax(attrId);
			if (value > max / 2f)
			{
				if (string.IsNullOrEmpty(this.NormalIconPath))
				{
					this.NormalIconPath = UiResourceConfig.Instance.GetResourcePath("SP_MainBarIcon");
				}
				return this.NormalIconPath;
			}
			if (string.IsNullOrEmpty(this.NormalDangerPath))
			{
				this.NormalDangerPath = UiResourceConfig.Instance.GetResourcePath("SP_MainBarIconDanger");
			}
			return this.NormalDangerPath;
		}

		// Token: 0x0401E446 RID: 123974
		private const int INVALID_NUM = -1;

		// Token: 0x0401E447 RID: 123975
		public int PowerLevel = -1;

		// Token: 0x0401E448 RID: 123976
		public int LifeSupportLevel = -1;

		// Token: 0x0401E449 RID: 123977
		public int LifeSupportId = -1;

		// Token: 0x0401E44A RID: 123978
		private string NormalIconPath = string.Empty;

		// Token: 0x0401E44B RID: 123979
		private string NormalDangerPath = string.Empty;

		// Token: 0x0401E44C RID: 123980
		private string MainInstPath = string.Empty;

		// Token: 0x0401E44D RID: 123981
		private readonly Dictionary<int, int> LifeSupportLevelMap = new Dictionary<int, int>();
	}
}
