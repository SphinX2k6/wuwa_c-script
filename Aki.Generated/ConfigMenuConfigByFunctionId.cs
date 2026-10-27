using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053D RID: 1341
	public class ConfigMenuConfigByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F7A RID: 8058 RVA: 0x0010B39F File Offset: 0x0010959F
		static ConfigMenuConfigByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuConfigByFunctionId.CreateStaticDefaultValue), new Action(ConfigMenuConfigByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0010B3C0 File Offset: 0x001095C0
		public static void CreateStaticDefaultValue()
		{
			ConfigMenuConfigByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMenuConfigByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MenuConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MenuConfig` where FunctionId=?")
			});
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0010B43F File Offset: 0x0010963F
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuConfigByFunctionId.LogPair = null;
			ConfigMenuConfigByFunctionId.HandleId = 0;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0010B44D File Offset: 0x0010964D
		public static void Init()
		{
			ConfigMenuConfigByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigMenuConfigByFunctionId.HandleId, "db_menu.db", "select BinData from `MenuConfig` where FunctionId=?");
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0010B468 File Offset: 0x00109668
		public static MenuConfig? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuConfigByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MenuConfig?(MenuConfig.GetRootAsMenuConfig(configBuffer));
				}
			}
			ConfigMenuConfigByFunctionId.LogPair.Clear();
			ConfigMenuConfigByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigMenuConfigByFunctionId.HandleId, 1, p0FunctionId, ConfigMenuConfigByFunctionId.LogPair) || ConfigCommon.Step(ConfigMenuConfigByFunctionId.HandleId, true, ConfigMenuConfigByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMenuConfigByFunctionId.HandleId, 0, ConfigMenuConfigByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MenuConfig rootAsMenuConfig = MenuConfig.GetRootAsMenuConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuConfigByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
			return new MenuConfig?(rootAsMenuConfig);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0010B5E0 File Offset: 0x001097E0
		[NullableContext(2)]
		public static IReadOnlyList<MenuConfig> GetConfigList(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuConfigByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				IReadOnlyList<MenuConfig> readOnlyList = (IReadOnlyList<MenuConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMenuConfigByFunctionId.LogPair.Clear();
			ConfigMenuConfigByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigMenuConfigByFunctionId.HandleId, 1, p0FunctionId, ConfigMenuConfigByFunctionId.LogPair))
			{
				ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
				return null;
			}
			List<MenuConfig> list = new List<MenuConfig>();
			while (ConfigCommon.Step(ConfigMenuConfigByFunctionId.HandleId, false, ConfigMenuConfigByFunctionId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMenuConfigByFunctionId.HandleId, 0, ConfigMenuConfigByFunctionId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
					return null;
				}
				MenuConfig rootAsMenuConfig = MenuConfig.GetRootAsMenuConfig(new ByteBuffer(item2));
				list.Add(rootAsMenuConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuConfigByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMenuConfigByFunctionId.HandleId, ConfigMenuConfigByFunctionId.LogPair);
			return list;
		}

		// Token: 0x0400248F RID: 9359
		private const string DB = "db_menu.db";

		// Token: 0x04002490 RID: 9360
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002491 RID: 9361
		private const string TABLE = "MenuConfig";

		// Token: 0x04002492 RID: 9362
		private const string COMMAND = "select BinData from `MenuConfig` where FunctionId=?";

		// Token: 0x04002493 RID: 9363
		private const string KEY_PREFIX = "MenuConfigByFunctionId";

		// Token: 0x04002494 RID: 9364
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002495 RID: 9365
		private static int HandleId;
	}
}
