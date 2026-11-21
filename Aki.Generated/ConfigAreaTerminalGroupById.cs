using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B8 RID: 184
	public class ConfigAreaTerminalGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00075938 File Offset: 0x00073B38
		static ConfigAreaTerminalGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalGroupById.CreateStaticDefaultValue), new Action(ConfigAreaTerminalGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00075958 File Offset: 0x00073B58
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

		// Token: 0x06000453 RID: 1107 RVA: 0x000759D7 File Offset: 0x00073BD7
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalGroupById.LogPair = null;
			ConfigAreaTerminalGroupById.HandleId = 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000759E5 File Offset: 0x00073BE5
		public static void Init()
		{
			ConfigAreaTerminalGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalGroupById.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminalGroup` where Id=?");
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00075A00 File Offset: 0x00073C00
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

		// Token: 0x040004EC RID: 1260
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004ED RID: 1261
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004EE RID: 1262
		private const string TABLE = "AreaTerminalGroup";

		// Token: 0x040004EF RID: 1263
		private const string COMMAND = "select BinData from `AreaTerminalGroup` where Id=?";

		// Token: 0x040004F0 RID: 1264
		private const string KEY_PREFIX = "AreaTerminalGroupById";

		// Token: 0x040004F1 RID: 1265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004F2 RID: 1266
		private static int HandleId;
	}
}
