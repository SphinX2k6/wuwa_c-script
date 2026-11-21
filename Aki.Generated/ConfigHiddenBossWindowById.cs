using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EB RID: 1003
	public class ConfigHiddenBossWindowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x000E2184 File Offset: 0x000E0384
		static ConfigHiddenBossWindowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHiddenBossWindowById.CreateStaticDefaultValue), new Action(ConfigHiddenBossWindowById.ResetStaticDefaultValue));
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000E21A4 File Offset: 0x000E03A4
		public static void CreateStaticDefaultValue()
		{
			ConfigHiddenBossWindowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHiddenBossWindowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_punishreport.db"),
				new ValueTuple<string, object>("文件", "t.讨伐报告.xlsx"),
				new ValueTuple<string, object>("表名", "HiddenBossWindow"),
				new ValueTuple<string, object>("语句", "select BinData from `HiddenBossWindow` where Id=?")
			});
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000E2223 File Offset: 0x000E0423
		public static void ResetStaticDefaultValue()
		{
			ConfigHiddenBossWindowById.LogPair = null;
			ConfigHiddenBossWindowById.HandleId = 0;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000E2231 File Offset: 0x000E0431
		public static void Init()
		{
			ConfigHiddenBossWindowById.HandleId = ConfigCommon.InitDataStatement(ConfigHiddenBossWindowById.HandleId, "db_punishreport.db", "select BinData from `HiddenBossWindow` where Id=?");
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000E224C File Offset: 0x000E044C
		public static HiddenBossWindow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHiddenBossWindowById.HandleId, ConfigHiddenBossWindowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HiddenBossWindowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HiddenBossWindow?(HiddenBossWindow.GetRootAsHiddenBossWindow(configBuffer));
				}
			}
			ConfigHiddenBossWindowById.LogPair.Clear();
			ConfigHiddenBossWindowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHiddenBossWindowById.HandleId, 1, p0Id, ConfigHiddenBossWindowById.LogPair) || ConfigCommon.Step(ConfigHiddenBossWindowById.HandleId, true, ConfigHiddenBossWindowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHiddenBossWindowById.HandleId, ConfigHiddenBossWindowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHiddenBossWindowById.HandleId, 0, ConfigHiddenBossWindowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHiddenBossWindowById.HandleId, ConfigHiddenBossWindowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HiddenBossWindow rootAsHiddenBossWindow = HiddenBossWindow.GetRootAsHiddenBossWindow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HiddenBossWindowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHiddenBossWindowById.HandleId, ConfigHiddenBossWindowById.LogPair);
			return new HiddenBossWindow?(rootAsHiddenBossWindow);
		}

		// Token: 0x04001B51 RID: 6993
		private const string DB = "db_punishreport.db";

		// Token: 0x04001B52 RID: 6994
		private const string FILE = "t.讨伐报告.xlsx";

		// Token: 0x04001B53 RID: 6995
		private const string TABLE = "HiddenBossWindow";

		// Token: 0x04001B54 RID: 6996
		private const string COMMAND = "select BinData from `HiddenBossWindow` where Id=?";

		// Token: 0x04001B55 RID: 6997
		private const string KEY_PREFIX = "HiddenBossWindowById";

		// Token: 0x04001B56 RID: 6998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B57 RID: 6999
		private static int HandleId;
	}
}
