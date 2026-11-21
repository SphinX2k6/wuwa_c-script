using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B6 RID: 182
	public class ConfigAreaTerminalByCountry : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000445 RID: 1093 RVA: 0x000754B7 File Offset: 0x000736B7
		static ConfigAreaTerminalByCountry()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalByCountry.CreateStaticDefaultValue), new Action(ConfigAreaTerminalByCountry.ResetStaticDefaultValue));
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000754D8 File Offset: 0x000736D8
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTerminalByCountry.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTerminalByCountry.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTerminal"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTerminal` where Country=?")
			});
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00075557 File Offset: 0x00073757
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalByCountry.LogPair = null;
			ConfigAreaTerminalByCountry.HandleId = 0;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00075565 File Offset: 0x00073765
		public static void Init()
		{
			ConfigAreaTerminalByCountry.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalByCountry.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal` where Country=?");
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00075580 File Offset: 0x00073780
		[NullableContext(2)]
		public static IReadOnlyList<AreaTerminal> GetConfigList(int p0Country, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTerminalByCountry.HandleId, ConfigAreaTerminalByCountry.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalByCountry");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Country);
				IReadOnlyList<AreaTerminal> readOnlyList = (IReadOnlyList<AreaTerminal>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaTerminalByCountry.LogPair.Clear();
			ConfigAreaTerminalByCountry.LogPair.Add(new ValueTuple<string, object>("Country", p0Country));
			if (!ConfigCommon.BindInt(ConfigAreaTerminalByCountry.HandleId, 1, p0Country, ConfigAreaTerminalByCountry.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaTerminalByCountry.HandleId, ConfigAreaTerminalByCountry.LogPair);
				return null;
			}
			List<AreaTerminal> list = new List<AreaTerminal>();
			while (ConfigCommon.Step(ConfigAreaTerminalByCountry.HandleId, false, ConfigAreaTerminalByCountry.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTerminalByCountry.HandleId, 0, ConfigAreaTerminalByCountry.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaTerminalByCountry.HandleId, ConfigAreaTerminalByCountry.LogPair);
					return null;
				}
				AreaTerminal rootAsAreaTerminal = AreaTerminal.GetRootAsAreaTerminal(new ByteBuffer(item2));
				list.Add(rootAsAreaTerminal);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalByCountry");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Country);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaTerminalByCountry.HandleId, ConfigAreaTerminalByCountry.LogPair);
			return list;
		}

		// Token: 0x040004DE RID: 1246
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004DF RID: 1247
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004E0 RID: 1248
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004E1 RID: 1249
		private const string COMMAND = "select BinData from `AreaTerminal` where Country=?";

		// Token: 0x040004E2 RID: 1250
		private const string KEY_PREFIX = "AreaTerminalByCountry";

		// Token: 0x040004E3 RID: 1251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004E4 RID: 1252
		private static int HandleId;
	}
}
