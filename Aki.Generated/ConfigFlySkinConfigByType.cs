using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033D RID: 829
	public class ConfigFlySkinConfigByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x000C7538 File Offset: 0x000C5738
		static ConfigFlySkinConfigByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlySkinConfigByType.CreateStaticDefaultValue), new Action(ConfigFlySkinConfigByType.ResetStaticDefaultValue));
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000C7558 File Offset: 0x000C5758
		public static void CreateStaticDefaultValue()
		{
			ConfigFlySkinConfigByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlySkinConfigByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skin.db"),
				new ValueTuple<string, object>("文件", "p.皮肤外观.xlsx"),
				new ValueTuple<string, object>("表名", "FlySkinConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FlySkinConfig` where SkinType=?")
			});
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x000C75D7 File Offset: 0x000C57D7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlySkinConfigByType.LogPair = null;
			ConfigFlySkinConfigByType.HandleId = 0;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000C75E5 File Offset: 0x000C57E5
		public static void Init()
		{
			ConfigFlySkinConfigByType.HandleId = ConfigCommon.InitDataStatement(ConfigFlySkinConfigByType.HandleId, "db_skin.db", "select BinData from `FlySkinConfig` where SkinType=?");
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000C7600 File Offset: 0x000C5800
		[NullableContext(2)]
		public static IReadOnlyList<FlySkinConfig> GetConfigList(int p0SkinType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlySkinConfigByType.HandleId, ConfigFlySkinConfigByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlySkinConfigByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinType);
				IReadOnlyList<FlySkinConfig> readOnlyList = (IReadOnlyList<FlySkinConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlySkinConfigByType.LogPair.Clear();
			ConfigFlySkinConfigByType.LogPair.Add(new ValueTuple<string, object>("SkinType", p0SkinType));
			if (!ConfigCommon.BindInt(ConfigFlySkinConfigByType.HandleId, 1, p0SkinType, ConfigFlySkinConfigByType.LogPair))
			{
				ConfigCommon.Reset(ConfigFlySkinConfigByType.HandleId, ConfigFlySkinConfigByType.LogPair);
				return null;
			}
			List<FlySkinConfig> list = new List<FlySkinConfig>();
			while (ConfigCommon.Step(ConfigFlySkinConfigByType.HandleId, false, ConfigFlySkinConfigByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlySkinConfigByType.HandleId, 0, ConfigFlySkinConfigByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlySkinConfigByType.HandleId, ConfigFlySkinConfigByType.LogPair);
					return null;
				}
				FlySkinConfig rootAsFlySkinConfig = FlySkinConfig.GetRootAsFlySkinConfig(new ByteBuffer(item2));
				list.Add(rootAsFlySkinConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlySkinConfigByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SkinType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlySkinConfigByType.HandleId, ConfigFlySkinConfigByType.LogPair);
			return list;
		}

		// Token: 0x0400168F RID: 5775
		private const string DB = "db_skin.db";

		// Token: 0x04001690 RID: 5776
		private const string FILE = "p.皮肤外观.xlsx";

		// Token: 0x04001691 RID: 5777
		private const string TABLE = "FlySkinConfig";

		// Token: 0x04001692 RID: 5778
		private const string COMMAND = "select BinData from `FlySkinConfig` where SkinType=?";

		// Token: 0x04001693 RID: 5779
		private const string KEY_PREFIX = "FlySkinConfigByType";

		// Token: 0x04001694 RID: 5780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001695 RID: 5781
		private static int HandleId;
	}
}
