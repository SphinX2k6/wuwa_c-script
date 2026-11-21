using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A3 RID: 419
	public class ConfigCompositeRewardDisplayByIsDragonPool : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x00094A48 File Offset: 0x00092C48
		static ConfigCompositeRewardDisplayByIsDragonPool()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayByIsDragonPool.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayByIsDragonPool.ResetStaticDefaultValue));
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00094A68 File Offset: 0x00092C68
		public static void CreateStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayByIsDragonPool.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCompositeRewardDisplayByIsDragonPool.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "CompositeRewardDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CompositeRewardDisplay` where IsDragonPool=TRUE")
			});
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00094AE7 File Offset: 0x00092CE7
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayByIsDragonPool.LogPair = null;
			ConfigCompositeRewardDisplayByIsDragonPool.HandleId = 0;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00094AF5 File Offset: 0x00092CF5
		public static void Init()
		{
			ConfigCompositeRewardDisplayByIsDragonPool.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay` where IsDragonPool=TRUE");
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00094B10 File Offset: 0x00092D10
		public static CompositeRewardDisplay? GetConfig(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("CompositeRewardDisplayByIsDragonPool");
				if (configBuffer != null)
				{
					return new CompositeRewardDisplay?(CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(configBuffer));
				}
			}
			if (ConfigCommon.Step(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, true, ConfigCompositeRewardDisplayByIsDragonPool.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, 0, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CompositeRewardDisplay rootAsCompositeRewardDisplay = CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("CompositeRewardDisplayByIsDragonPool", byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
			return new CompositeRewardDisplay?(rootAsCompositeRewardDisplay);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00094BF8 File Offset: 0x00092DF8
		[NullableContext(2)]
		public static IReadOnlyList<CompositeRewardDisplay> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CompositeRewardDisplay> readOnlyList = (IReadOnlyList<CompositeRewardDisplay>)ConfigCommon.GetConfig("CompositeRewardDisplayByIsDragonPool");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CompositeRewardDisplay> list = new List<CompositeRewardDisplay>();
			while (ConfigCommon.Step(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, false, ConfigCompositeRewardDisplayByIsDragonPool.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, 0, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
					return null;
				}
				CompositeRewardDisplay rootAsCompositeRewardDisplay = CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(new ByteBuffer(item2));
				list.Add(rootAsCompositeRewardDisplay);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CompositeRewardDisplayByIsDragonPool", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, ConfigCompositeRewardDisplayByIsDragonPool.LogPair);
			return list;
		}

		// Token: 0x04000B59 RID: 2905
		private const string DB = "db_rewardui.db";

		// Token: 0x04000B5A RID: 2906
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000B5B RID: 2907
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000B5C RID: 2908
		private const string COMMAND = "select BinData from `CompositeRewardDisplay` where IsDragonPool=TRUE";

		// Token: 0x04000B5D RID: 2909
		private const string KEY_PREFIX = "CompositeRewardDisplayByIsDragonPool";

		// Token: 0x04000B5E RID: 2910
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B5F RID: 2911
		private static int HandleId;
	}
}
