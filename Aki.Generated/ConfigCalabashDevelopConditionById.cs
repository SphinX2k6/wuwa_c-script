using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000132 RID: 306
	public class ConfigCalabashDevelopConditionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x000823FC File Offset: 0x000805FC
		static ConfigCalabashDevelopConditionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashDevelopConditionById.CreateStaticDefaultValue), new Action(ConfigCalabashDevelopConditionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0008241C File Offset: 0x0008061C
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

		// Token: 0x0600072F RID: 1839 RVA: 0x0008249B File Offset: 0x0008069B
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashDevelopConditionById.LogPair = null;
			ConfigCalabashDevelopConditionById.HandleId = 0;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000824A9 File Offset: 0x000806A9
		public static void Init()
		{
			ConfigCalabashDevelopConditionById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashDevelopConditionById.HandleId, "db_calabash.db", "select BinData from `CalabashDevelopCondition` where Id=?");
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000824C4 File Offset: 0x000806C4
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

		// Token: 0x04000842 RID: 2114
		private const string DB = "db_calabash.db";

		// Token: 0x04000843 RID: 2115
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000844 RID: 2116
		private const string TABLE = "CalabashDevelopCondition";

		// Token: 0x04000845 RID: 2117
		private const string COMMAND = "select BinData from `CalabashDevelopCondition` where Id=?";

		// Token: 0x04000846 RID: 2118
		private const string KEY_PREFIX = "CalabashDevelopConditionById";

		// Token: 0x04000847 RID: 2119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000848 RID: 2120
		private static int HandleId;
	}
}
