using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000141 RID: 321
	public class ConfigCalabashDevelopConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x00087D60 File Offset: 0x00085F60
		static ConfigCalabashDevelopConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopConditionById.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00087D80 File Offset: 0x00085F80
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashDevelopConditionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashDevelopConditionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashDevelopCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashDevelopCondition` where Id=?")
			});
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00087DFF File Offset: 0x00085FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopConditionById.LogPair = null;
			ConfigCalabashDevelopConditionById.HandleId = 0;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00087E0D File Offset: 0x0008600D
		public static void Init()
		{
			ConfigCalabashDevelopConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopConditionById.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopCondition` where Id=?");
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00087E28 File Offset: 0x00086028
		public static CalabashDevelopCondition? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashDevelopConditionById.HandleId, ConfigCalabashDevelopConditionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashDevelopCondition?(CalabashDevelopCondition.GetRootAsCalabashDevelopCondition(configBuffer));
				}
			}
			ConfigCalabashDevelopConditionById.LogPair.Clear();
			ConfigCalabashDevelopConditionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCalabashDevelopConditionById.HandleId, 1, p0Id, ConfigCalabashDevelopConditionById.LogPair) || ConfigCommon.Step(ConfigCalabashDevelopConditionById.HandleId, true, ConfigCalabashDevelopConditionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashDevelopConditionById.HandleId, ConfigCalabashDevelopConditionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashDevelopConditionById.HandleId, 0, ConfigCalabashDevelopConditionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashDevelopConditionById.HandleId, ConfigCalabashDevelopConditionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashDevelopCondition rootAsCalabashDevelopCondition = CalabashDevelopCondition.GetRootAsCalabashDevelopCondition(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashDevelopConditionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashDevelopConditionById.HandleId, ConfigCalabashDevelopConditionById.LogPair);
			return new CalabashDevelopCondition?(rootAsCalabashDevelopCondition);
		}

		// Token: 0x040008AB RID: 2219
		private const string DB = "db_calabash.db";

		// Token: 0x040008AC RID: 2220
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008AD RID: 2221
		private const string TABLE = "CalabashDevelopCondition";

		// Token: 0x040008AE RID: 2222
		private const string COMMAND = "select BinData from `CalabashDevelopCondition` where Id=?";

		// Token: 0x040008AF RID: 2223
		private const string KEY_PREFIX = "CalabashDevelopConditionById";

		// Token: 0x040008B0 RID: 2224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008B1 RID: 2225
		private static int HandleId;
	}
}
