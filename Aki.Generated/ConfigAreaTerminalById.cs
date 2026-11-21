using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B7 RID: 183
	public class ConfigAreaTerminalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x000756EF File Offset: 0x000738EF
		static ConfigAreaTerminalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalById.CreateStaticDefaultValue), new Action(ConfigAreaTerminalById.ResetStaticDefaultValue));
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00075710 File Offset: 0x00073910
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTerminalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTerminalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTerminal"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTerminal` where Id=?")
			});
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0007578F File Offset: 0x0007398F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalById.LogPair = null;
			ConfigAreaTerminalById.HandleId = 0;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0007579D File Offset: 0x0007399D
		public static void Init()
		{
			ConfigAreaTerminalById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalById.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal` where Id=?");
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000757B8 File Offset: 0x000739B8
		public static AreaTerminal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaTerminal?(AreaTerminal.GetRootAsAreaTerminal(configBuffer));
				}
			}
			ConfigAreaTerminalById.LogPair.Clear();
			ConfigAreaTerminalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaTerminalById.HandleId, 1, p0Id, ConfigAreaTerminalById.LogPair) || ConfigCommon.Step(ConfigAreaTerminalById.HandleId, true, ConfigAreaTerminalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTerminalById.HandleId, 0, ConfigAreaTerminalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaTerminal rootAsAreaTerminal = AreaTerminal.GetRootAsAreaTerminal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaTerminalById.HandleId, ConfigAreaTerminalById.LogPair);
			return new AreaTerminal?(rootAsAreaTerminal);
		}

		// Token: 0x040004E5 RID: 1253
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004E6 RID: 1254
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004E7 RID: 1255
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004E8 RID: 1256
		private const string COMMAND = "select BinData from `AreaTerminal` where Id=?";

		// Token: 0x040004E9 RID: 1257
		private const string KEY_PREFIX = "AreaTerminalById";

		// Token: 0x040004EA RID: 1258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004EB RID: 1259
		private static int HandleId;
	}
}
