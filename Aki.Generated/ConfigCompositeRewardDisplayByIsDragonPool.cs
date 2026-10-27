using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000191 RID: 401
	public class ConfigCompositeRewardDisplayByIsDragonPool : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000968 RID: 2408 RVA: 0x0008EB10 File Offset: 0x0008CD10
		static ConfigCompositeRewardDisplayByIsDragonPool()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayByIsDragonPool.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayByIsDragonPool.ResetStaticDefaultValue));
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0008EB30 File Offset: 0x0008CD30
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

		// Token: 0x0600096A RID: 2410 RVA: 0x0008EBAF File Offset: 0x0008CDAF
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayByIsDragonPool.LogPair = null;
			ConfigCompositeRewardDisplayByIsDragonPool.HandleId = 0;
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0008EBBD File Offset: 0x0008CDBD
		public static void Init()
		{
			ConfigCompositeRewardDisplayByIsDragonPool.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayByIsDragonPool.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay` where IsDragonPool=TRUE");
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
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

		// Token: 0x0600096D RID: 2413 RVA: 0x0008ECC0 File Offset: 0x0008CEC0
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

		// Token: 0x04000ADB RID: 2779
		private const string DB = "db_rewardui.db";

		// Token: 0x04000ADC RID: 2780
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000ADD RID: 2781
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000ADE RID: 2782
		private const string COMMAND = "select BinData from `CompositeRewardDisplay` where IsDragonPool=TRUE";

		// Token: 0x04000ADF RID: 2783
		private const string KEY_PREFIX = "CompositeRewardDisplayByIsDragonPool";

		// Token: 0x04000AE0 RID: 2784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AE1 RID: 2785
		private static int HandleId;
	}
}
