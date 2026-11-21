using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000091 RID: 145
	public class ConfigAiSenseGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000366 RID: 870 RVA: 0x000703B8 File Offset: 0x0006E5B8
		static ConfigAiSenseGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiSenseGroupById.CreateStaticDefaultValue), new Action(ConfigAiSenseGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000703D8 File Offset: 0x0006E5D8
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

		// Token: 0x06000368 RID: 872 RVA: 0x00070457 File Offset: 0x0006E657
		public static void ResetStaticDefaultValue()
		{
			ConfigAiSenseGroupById.LogPair = null;
			ConfigAiSenseGroupById.HandleId = 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00070465 File Offset: 0x0006E665
		public static void Init()
		{
			ConfigAiSenseGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigAiSenseGroupById.HandleId, "db_ai.db", "select BinData from `AiSenseGroup` where Id=?");
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00070480 File Offset: 0x0006E680
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

		// Token: 0x040003DB RID: 987
		private const string DB = "db_ai.db";

		// Token: 0x040003DC RID: 988
		private const string FILE = "a.AI感知.xlsx";

		// Token: 0x040003DD RID: 989
		private const string TABLE = "AiSenseGroup";

		// Token: 0x040003DE RID: 990
		private const string COMMAND = "select BinData from `AiSenseGroup` where Id=?";

		// Token: 0x040003DF RID: 991
		private const string KEY_PREFIX = "AiSenseGroupById";

		// Token: 0x040003E0 RID: 992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003E1 RID: 993
		private static int HandleId;
	}
}
