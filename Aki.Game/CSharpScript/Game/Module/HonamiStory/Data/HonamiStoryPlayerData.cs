using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.HonamiStory.Data
{
	// Token: 0x0200492B RID: 18731
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryPlayerData
	{
		// Token: 0x0602EF7E RID: 192382 RVA: 0x00D19CED File Offset: 0x00D17EED
		public static HonamiStoryPlayerData Create()
		{
			return new HonamiStoryPlayerData();
		}

		// Token: 0x0602EF7F RID: 192383 RVA: 0x00D19CF4 File Offset: 0x00D17EF4
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

		// Token: 0x0602EF80 RID: 192384 RVA: 0x00D19DC0 File Offset: 0x00D17FC0
		public int GetCurLevelId(int level)
		{
			return this.LifeSupportLevelMap.GetValueOrDefault(level, 0);
		}

		// Token: 0x0602EF81 RID: 192385 RVA: 0x00D19DD0 File Offset: 0x00D17FD0
		public int GetCurMaxValue()
		{
			int id;
			if (!this.LifeSupportLevelMap.TryGetValue(this.LifeSupportLevel, out id))
			{
				return 0;
			}
			return HonamiStoryConfig.Instance.GetLifeSupport(id).Value.SteadyValue;
		}

		// Token: 0x0602EF82 RID: 192386 RVA: 0x00D19E0F File Offset: 0x00D1800F
		public void UpdatePowerLevel()
		{
			this.PowerLevel = HonamiStoryModel.Instance.GetPlayerBackpackData().GetPowerLevel(true);
		}

		// Token: 0x0602EF83 RID: 192387 RVA: 0x00D19E28 File Offset: 0x00D18028
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

		// Token: 0x0602EF84 RID: 192388 RVA: 0x00D19E8C File Offset: 0x00D1808C
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

		// Token: 0x04018EE3 RID: 102115
		private const int INVALID_NUM = -1;

		// Token: 0x04018EE4 RID: 102116
		public int PowerLevel = -1;

		// Token: 0x04018EE5 RID: 102117
		public int LifeSupportLevel = -1;

		// Token: 0x04018EE6 RID: 102118
		public int LifeSupportId = -1;

		// Token: 0x04018EE7 RID: 102119
		private string NormalIconPath = string.Empty;

		// Token: 0x04018EE8 RID: 102120
		private string NormalDangerPath = string.Empty;

		// Token: 0x04018EE9 RID: 102121
		private string MainInstPath = string.Empty;

		// Token: 0x04018EEA RID: 102122
		private readonly Dictionary<int, int> LifeSupportLevelMap = new Dictionary<int, int>();
	}
}
