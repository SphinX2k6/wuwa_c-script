using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020043AC RID: 17324
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CollectItemConfig : ConfigBase
	{
		// Token: 0x0602BC56 RID: 179286 RVA: 0x00C4AD5F File Offset: 0x00C48F5F
		[NullableContext(2)]
		public IReadOnlyList<DragonPool> GetAllDragonPoolConfigList()
		{
			return ConfigDragonPoolAll.GetConfigList(true);
		}

		// Token: 0x0602BC57 RID: 179287 RVA: 0x00C4AD67 File Offset: 0x00C48F67
		public DragonPool? GetDragonPoolConfigById(int id)
		{
			return ConfigDragonPoolById.GetConfig(id, true);
		}

		// Token: 0x0602BC58 RID: 179288 RVA: 0x00C4AD70 File Offset: 0x00C48F70
		public DragonPool? GetDragonPoolConfigByCoreId(int coreId)
		{
			return ConfigDragonPoolByCoreId.GetConfig(coreId, true);
		}

		// Token: 0x0602BC59 RID: 179289 RVA: 0x00C4AD79 File Offset: 0x00C48F79
		public MingSuPlot? GetMingSuPlotConfigById(int id)
		{
			return ConfigMingSuPlotById.GetConfig(id, true);
		}

		// Token: 0x0602BC5A RID: 179290 RVA: 0x00C4AD84 File Offset: 0x00C48F84
		[NullableContext(2)]
		public List<int> GetIsDragonPoolCompositeRewardIdList()
		{
			IReadOnlyList<CompositeRewardDisplay> configList = ConfigCompositeRewardDisplayAll.GetConfigList(true);
			if (configList == null)
			{
				Log.Instance.Error(ELogModule.MingSuTi, ELogAuthor.BB, "CompositeRewardDisplay表无配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			List<int> list = new List<int>();
			for (int i = 0; i < configList.Count; i++)
			{
				CompositeRewardDisplay compositeRewardDisplay = configList[i];
				if (compositeRewardDisplay.IsDragonPool)
				{
					list.Add(compositeRewardDisplay.Id);
				}
			}
			return list;
		}

		// Token: 0x0602BC5B RID: 179291 RVA: 0x00C4ADF0 File Offset: 0x00C48FF0
		public DarkCoastDelivery? GetDarkCoastDeliveryById(int id)
		{
			DarkCoastDelivery? config = ConfigDarkCoastDeliveryById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MingSuTi;
				ELogAuthor author = ELogAuthor.BB;
				string message = "DarkCoastDelivery表无当前id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x1700578C RID: 22412
		// (get) Token: 0x0602BC5C RID: 179292 RVA: 0x00C4AE46 File Offset: 0x00C49046
		public static CollectItemConfig Instance
		{
			get
			{
				return CollectItemConfig._Instance;
			}
		}

		// Token: 0x0602BC5D RID: 179293 RVA: 0x00C4AE4D File Offset: 0x00C4904D
		public static CollectItemConfig GetOrCreateInstance()
		{
			if (CollectItemConfig._Instance == null)
			{
				CollectItemConfig.CreateInstance();
			}
			return CollectItemConfig._Instance;
		}

		// Token: 0x0602BC5E RID: 179294 RVA: 0x00C4AE61 File Offset: 0x00C49061
		public static bool CreateInstance()
		{
			if (CollectItemConfig._Instance != null)
			{
				return true;
			}
			CollectItemConfig._Instance = new CollectItemConfig();
			return true;
		}

		// Token: 0x0602BC5F RID: 179295 RVA: 0x00C4AE77 File Offset: 0x00C49077
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602BC60 RID: 179296 RVA: 0x00C4AE79 File Offset: 0x00C49079
		public static void ResetStaticDefaultValue()
		{
			CollectItemConfig._Instance = null;
		}

		// Token: 0x0602BC61 RID: 179297 RVA: 0x00C4AE81 File Offset: 0x00C49081
		static CollectItemConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CollectItemConfig.CreateStaticDefaultValue), new Action(CollectItemConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04017998 RID: 96664
		[Nullable(2)]
		private static CollectItemConfig _Instance;
	}
}
