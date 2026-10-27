using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AE RID: 174
	public class ConfigAreaTerminalByCountry : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x00070C03 File Offset: 0x0006EE03
		static ConfigAreaTerminalByCountry()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalByCountry.CreateStaticDefaultValue), new Action(ConfigAreaTerminalByCountry.ResetStaticDefaultValue));
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00070C24 File Offset: 0x0006EE24
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

		// Token: 0x06000417 RID: 1047 RVA: 0x00070CA3 File Offset: 0x0006EEA3
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalByCountry.LogPair = null;
			ConfigAreaTerminalByCountry.HandleId = 0;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00070CB1 File Offset: 0x0006EEB1
		public static void Init()
		{
			ConfigAreaTerminalByCountry.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalByCountry.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal` where Country=?");
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00070CCC File Offset: 0x0006EECC
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

		// Token: 0x040004A6 RID: 1190
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004A7 RID: 1191
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004A8 RID: 1192
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004A9 RID: 1193
		private const string COMMAND = "select BinData from `AreaTerminal` where Country=?";

		// Token: 0x040004AA RID: 1194
		private const string KEY_PREFIX = "AreaTerminalByCountry";

		// Token: 0x040004AB RID: 1195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004AC RID: 1196
		private static int HandleId;
	}
}
