using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000553 RID: 1363
	public class ConfigMenuConfigByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FFE RID: 8190 RVA: 0x00111AF3 File Offset: 0x0010FCF3
		static ConfigMenuConfigByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuConfigByFunctionId.CreateStaticDefaultValue), new Action(ConfigMenuConfigByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x00111B14 File Offset: 0x0010FD14
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

		// Token: 0x06002000 RID: 8192 RVA: 0x00111B93 File Offset: 0x0010FD93
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuConfigByFunctionId.LogPair = null;
			ConfigMenuConfigByFunctionId.HandleId = 0;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00111BA1 File Offset: 0x0010FDA1
		public static void Init()
		{
			ConfigMenuConfigByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigMenuConfigByFunctionId.HandleId, "db_menu.db", "select BinData from `MenuConfig` where FunctionId=?");
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00111BBC File Offset: 0x0010FDBC
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

		// Token: 0x06002003 RID: 8195 RVA: 0x00111D34 File Offset: 0x0010FF34
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

		// Token: 0x04002529 RID: 9513
		private const string DB = "db_menu.db";

		// Token: 0x0400252A RID: 9514
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400252B RID: 9515
		private const string TABLE = "MenuConfig";

		// Token: 0x0400252C RID: 9516
		private const string COMMAND = "select BinData from `MenuConfig` where FunctionId=?";

		// Token: 0x0400252D RID: 9517
		private const string KEY_PREFIX = "MenuConfigByFunctionId";

		// Token: 0x0400252E RID: 9518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400252F RID: 9519
		private static int HandleId;
	}
}
