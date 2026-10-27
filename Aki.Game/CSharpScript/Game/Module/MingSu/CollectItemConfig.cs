using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MingSu
{
	// Token: 0x020053C9 RID: 21449
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CollectItemConfig : ConfigBase
	{
		// Token: 0x06036D10 RID: 224528 RVA: 0x00CFBCB7 File Offset: 0x00CF9EB7
		[NullableContext(2)]
		public IReadOnlyList<DragonPool> GetAllDragonPoolConfigList()
		{
			return ConfigDragonPoolAll.GetConfigList(true);
		}

		// Token: 0x06036D11 RID: 224529 RVA: 0x00CFBCBF File Offset: 0x00CF9EBF
		public DragonPool? GetDragonPoolConfigById(int id)
		{
			return ConfigDragonPoolById.GetConfig(id, true);
		}

		// Token: 0x06036D12 RID: 224530 RVA: 0x00CFBCC8 File Offset: 0x00CF9EC8
		public DragonPool? GetDragonPoolConfigByCoreId(int coreId)
		{
			return ConfigDragonPoolByCoreId.GetConfig(coreId, true);
		}

		// Token: 0x06036D13 RID: 224531 RVA: 0x00CFBCD1 File Offset: 0x00CF9ED1
		public MingSuPlot? GetMingSuPlotConfigById(int id)
		{
			return ConfigMingSuPlotById.GetConfig(id, true);
		}

		// Token: 0x06036D14 RID: 224532 RVA: 0x00CFBCDC File Offset: 0x00CF9EDC
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

		// Token: 0x06036D15 RID: 224533 RVA: 0x00CFBD48 File Offset: 0x00CF9F48
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

		// Token: 0x170083C0 RID: 33728
		// (get) Token: 0x06036D16 RID: 224534 RVA: 0x00CFBD9E File Offset: 0x00CF9F9E
		public static CollectItemConfig Instance
		{
			get
			{
				return CollectItemConfig._Instance;
			}
		}

		// Token: 0x06036D17 RID: 224535 RVA: 0x00CFBDA5 File Offset: 0x00CF9FA5
		public static CollectItemConfig GetOrCreateInstance()
		{
			if (CollectItemConfig._Instance == null)
			{
				CollectItemConfig.CreateInstance();
			}
			return CollectItemConfig._Instance;
		}

		// Token: 0x06036D18 RID: 224536 RVA: 0x00CFBDB9 File Offset: 0x00CF9FB9
		public static bool CreateInstance()
		{
			if (CollectItemConfig._Instance != null)
			{
				return true;
			}
			CollectItemConfig._Instance = new CollectItemConfig();
			return true;
		}

		// Token: 0x06036D19 RID: 224537 RVA: 0x00CFBDCF File Offset: 0x00CF9FCF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036D1A RID: 224538 RVA: 0x00CFBDD1 File Offset: 0x00CF9FD1
		public static void ResetStaticDefaultValue()
		{
			CollectItemConfig._Instance = null;
		}

		// Token: 0x06036D1B RID: 224539 RVA: 0x00CFBDD9 File Offset: 0x00CF9FD9
		static CollectItemConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CollectItemConfig.CreateStaticDefaultValue), new Action(CollectItemConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401CF00 RID: 118528
		[Nullable(2)]
		private static CollectItemConfig _Instance;
	}
}
