using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000089 RID: 137
	public class ConfigAiSenseGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0006BB04 File Offset: 0x00069D04
		static ConfigAiSenseGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSenseGroupById.CreateStaticDefaultValue), new Action(ConfigAiSenseGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0006BB24 File Offset: 0x00069D24
		public static void CreateStaticDefaultValue()
		{
			ConfigAiSenseGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiSenseGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI感知.xlsx"),
				new ValueTuple<string, object>("表名", "AiSenseGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AiSenseGroup` where Id=?")
			});
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0006BBA3 File Offset: 0x00069DA3
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSenseGroupById.LogPair = null;
			ConfigAiSenseGroupById.HandleId = 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0006BBB1 File Offset: 0x00069DB1
		public static void Init()
		{
			ConfigAiSenseGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSenseGroupById.HandleId, "db_ai.db", "select BinData from `AiSenseGroup` where Id=?");
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0006BBCC File Offset: 0x00069DCC
		public static AiSenseGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiSenseGroupById.HandleId, ConfigAiSenseGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSenseGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiSenseGroup?(AiSenseGroup.GetRootAsAiSenseGroup(configBuffer));
				}
			}
			ConfigAiSenseGroupById.LogPair.Clear();
			ConfigAiSenseGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiSenseGroupById.HandleId, 1, p0Id, ConfigAiSenseGroupById.LogPair) || ConfigCommon.Step(ConfigAiSenseGroupById.HandleId, true, ConfigAiSenseGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiSenseGroupById.HandleId, ConfigAiSenseGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiSenseGroupById.HandleId, 0, ConfigAiSenseGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiSenseGroupById.HandleId, ConfigAiSenseGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiSenseGroup rootAsAiSenseGroup = AiSenseGroup.GetRootAsAiSenseGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiSenseGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiSenseGroupById.HandleId, ConfigAiSenseGroupById.LogPair);
			return new AiSenseGroup?(rootAsAiSenseGroup);
		}

		// Token: 0x040003A3 RID: 931
		private const string DB = "db_ai.db";

		// Token: 0x040003A4 RID: 932
		private const string FILE = "a.AI感知.xlsx";

		// Token: 0x040003A5 RID: 933
		private const string TABLE = "AiSenseGroup";

		// Token: 0x040003A6 RID: 934
		private const string COMMAND = "select BinData from `AiSenseGroup` where Id=?";

		// Token: 0x040003A7 RID: 935
		private const string KEY_PREFIX = "AiSenseGroupById";

		// Token: 0x040003A8 RID: 936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003A9 RID: 937
		private static int HandleId;
	}
}
