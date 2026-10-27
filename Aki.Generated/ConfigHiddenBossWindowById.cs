using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D5 RID: 981
	public class ConfigHiddenBossWindowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001705 RID: 5893 RVA: 0x000DBA30 File Offset: 0x000D9C30
		static ConfigHiddenBossWindowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHiddenBossWindowById.CreateStaticDefaultValue), new Action(ConfigHiddenBossWindowById.ResetStaticDefaultValue));
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000DBA50 File Offset: 0x000D9C50
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

		// Token: 0x06001707 RID: 5895 RVA: 0x000DBACF File Offset: 0x000D9CCF
		public static void ResetStaticDefaultValue()
		{
			ConfigHiddenBossWindowById.LogPair = null;
			ConfigHiddenBossWindowById.HandleId = 0;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x000DBADD File Offset: 0x000D9CDD
		public static void Init()
		{
			ConfigHiddenBossWindowById.HandleId = ConfigCommon.InitDataStatement(ConfigHiddenBossWindowById.HandleId, "db_punishreport.db", "select BinData from `HiddenBossWindow` where Id=?");
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000DBAF8 File Offset: 0x000D9CF8
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

		// Token: 0x04001AB7 RID: 6839
		private const string DB = "db_punishreport.db";

		// Token: 0x04001AB8 RID: 6840
		private const string FILE = "t.讨伐报告.xlsx";

		// Token: 0x04001AB9 RID: 6841
		private const string TABLE = "HiddenBossWindow";

		// Token: 0x04001ABA RID: 6842
		private const string COMMAND = "select BinData from `HiddenBossWindow` where Id=?";

		// Token: 0x04001ABB RID: 6843
		private const string KEY_PREFIX = "HiddenBossWindowById";

		// Token: 0x04001ABC RID: 6844
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ABD RID: 6845
		private static int HandleId;
	}
}
