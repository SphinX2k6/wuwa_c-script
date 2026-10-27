using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B0 RID: 176
	public class ConfigAreaTerminalGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000421 RID: 1057 RVA: 0x00071084 File Offset: 0x0006F284
		static ConfigAreaTerminalGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalGroupById.CreateStaticDefaultValue), new Action(ConfigAreaTerminalGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000710A4 File Offset: 0x0006F2A4
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTerminalGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTerminalGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTerminalGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTerminalGroup` where Id=?")
			});
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00071123 File Offset: 0x0006F323
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalGroupById.LogPair = null;
			ConfigAreaTerminalGroupById.HandleId = 0;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00071131 File Offset: 0x0006F331
		public static void Init()
		{
			ConfigAreaTerminalGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalGroupById.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminalGroup` where Id=?");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0007114C File Offset: 0x0006F34C
		public static AreaTerminalGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTerminalGroupById.HandleId, ConfigAreaTerminalGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaTerminalGroup?(AreaTerminalGroup.GetRootAsAreaTerminalGroup(configBuffer));
				}
			}
			ConfigAreaTerminalGroupById.LogPair.Clear();
			ConfigAreaTerminalGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaTerminalGroupById.HandleId, 1, p0Id, ConfigAreaTerminalGroupById.LogPair) || ConfigCommon.Step(ConfigAreaTerminalGroupById.HandleId, true, ConfigAreaTerminalGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaTerminalGroupById.HandleId, ConfigAreaTerminalGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTerminalGroupById.HandleId, 0, ConfigAreaTerminalGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaTerminalGroupById.HandleId, ConfigAreaTerminalGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaTerminalGroup rootAsAreaTerminalGroup = AreaTerminalGroup.GetRootAsAreaTerminalGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTerminalGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaTerminalGroupById.HandleId, ConfigAreaTerminalGroupById.LogPair);
			return new AreaTerminalGroup?(rootAsAreaTerminalGroup);
		}

		// Token: 0x040004B4 RID: 1204
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004B5 RID: 1205
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004B6 RID: 1206
		private const string TABLE = "AreaTerminalGroup";

		// Token: 0x040004B7 RID: 1207
		private const string COMMAND = "select BinData from `AreaTerminalGroup` where Id=?";

		// Token: 0x040004B8 RID: 1208
		private const string KEY_PREFIX = "AreaTerminalGroupById";

		// Token: 0x040004B9 RID: 1209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004BA RID: 1210
		private static int HandleId;
	}
}
