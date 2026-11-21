using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008E RID: 142
	public class ConfigAiHateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
		static ConfigAiHateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiHateById.CreateStaticDefaultValue), new Action(ConfigAiHateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0006FD00 File Offset: 0x0006DF00
		public static void CreateStaticDefaultValue()
		{
			ConfigAiHateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiHateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI仇恨.xlsx"),
				new ValueTuple<string, object>("表名", "AiHate"),
				new ValueTuple<string, object>("语句", "select BinData from `AiHate` where Id=?")
			});
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0006FD7F File Offset: 0x0006DF7F
		public static void ResetStaticDefaultValue()
		{
			ConfigAiHateById.LogPair = null;
			ConfigAiHateById.HandleId = 0;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0006FD8D File Offset: 0x0006DF8D
		public static void Init()
		{
			ConfigAiHateById.HandleId = ConfigCommon.InitDataStatement(ConfigAiHateById.HandleId, "db_ai.db", "select BinData from `AiHate` where Id=?");
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0006FDA8 File Offset: 0x0006DFA8
		public static AiHate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiHateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiHate?(AiHate.GetRootAsAiHate(configBuffer));
				}
			}
			ConfigAiHateById.LogPair.Clear();
			ConfigAiHateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiHateById.HandleId, 1, p0Id, ConfigAiHateById.LogPair) || ConfigCommon.Step(ConfigAiHateById.HandleId, true, ConfigAiHateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiHateById.HandleId, 0, ConfigAiHateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiHate rootAsAiHate = AiHate.GetRootAsAiHate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiHateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiHateById.HandleId, ConfigAiHateById.LogPair);
			return new AiHate?(rootAsAiHate);
		}

		// Token: 0x040003C6 RID: 966
		private const string DB = "db_ai.db";

		// Token: 0x040003C7 RID: 967
		private const string FILE = "a.AI仇恨.xlsx";

		// Token: 0x040003C8 RID: 968
		private const string TABLE = "AiHate";

		// Token: 0x040003C9 RID: 969
		private const string COMMAND = "select BinData from `AiHate` where Id=?";

		// Token: 0x040003CA RID: 970
		private const string KEY_PREFIX = "AiHateById";

		// Token: 0x040003CB RID: 971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003CC RID: 972
		private static int HandleId;
	}
}
