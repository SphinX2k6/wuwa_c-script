using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000352 RID: 850
	public class ConfigFlySkinConfigByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013F1 RID: 5105 RVA: 0x000CDA44 File Offset: 0x000CBC44
		static ConfigFlySkinConfigByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlySkinConfigByType.CreateStaticDefaultValue), new Action(ConfigFlySkinConfigByType.ResetStaticDefaultValue));
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x000CDA64 File Offset: 0x000CBC64
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

		// Token: 0x060013F3 RID: 5107 RVA: 0x000CDAE3 File Offset: 0x000CBCE3
		public static void ResetStaticDefaultValue()
		{
			ConfigFlySkinConfigByType.LogPair = null;
			ConfigFlySkinConfigByType.HandleId = 0;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x000CDAF1 File Offset: 0x000CBCF1
		public static void Init()
		{
			ConfigFlySkinConfigByType.HandleId = ConfigCommon.InitDataStatement(ConfigFlySkinConfigByType.HandleId, "db_skin.db", "select BinData from `FlySkinConfig` where SkinType=?");
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x000CDB0C File Offset: 0x000CBD0C
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

		// Token: 0x04001722 RID: 5922
		private const string DB = "db_skin.db";

		// Token: 0x04001723 RID: 5923
		private const string FILE = "p.皮肤外观.xlsx";

		// Token: 0x04001724 RID: 5924
		private const string TABLE = "FlySkinConfig";

		// Token: 0x04001725 RID: 5925
		private const string COMMAND = "select BinData from `FlySkinConfig` where SkinType=?";

		// Token: 0x04001726 RID: 5926
		private const string KEY_PREFIX = "FlySkinConfigByType";

		// Token: 0x04001727 RID: 5927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001728 RID: 5928
		private static int HandleId;
	}
}
