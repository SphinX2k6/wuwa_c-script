using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052F RID: 1327
	public class ConfigMatchThreeEnviromentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F25 RID: 7973 RVA: 0x001094F4 File Offset: 0x001076F4
		static ConfigMatchThreeEnviromentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeEnviromentById.CreateStaticDefaultValue), new Action(ConfigMatchThreeEnviromentById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00109514 File Offset: 0x00107714
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeEnviromentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeEnviromentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeEnviroment"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeEnviroment` where Id=?")
			});
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00109593 File Offset: 0x00107793
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeEnviromentById.LogPair = null;
			ConfigMatchThreeEnviromentById.HandleId = 0;
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x001095A1 File Offset: 0x001077A1
		public static void Init()
		{
			ConfigMatchThreeEnviromentById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeEnviromentById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeEnviroment` where Id=?");
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x001095BC File Offset: 0x001077BC
		public static MatchThreeEnviroment? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEnviromentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeEnviroment?(MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(configBuffer));
				}
			}
			ConfigMatchThreeEnviromentById.LogPair.Clear();
			ConfigMatchThreeEnviromentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeEnviromentById.HandleId, 1, p0Id, ConfigMatchThreeEnviromentById.LogPair) || ConfigCommon.Step(ConfigMatchThreeEnviromentById.HandleId, true, ConfigMatchThreeEnviromentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeEnviromentById.HandleId, 0, ConfigMatchThreeEnviromentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeEnviroment rootAsMatchThreeEnviroment = MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEnviromentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
			return new MatchThreeEnviroment?(rootAsMatchThreeEnviroment);
		}

		// Token: 0x0400242D RID: 9261
		private const string DB = "db_matchthree.db";

		// Token: 0x0400242E RID: 9262
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x0400242F RID: 9263
		private const string TABLE = "MatchThreeEnviroment";

		// Token: 0x04002430 RID: 9264
		private const string COMMAND = "select BinData from `MatchThreeEnviroment` where Id=?";

		// Token: 0x04002431 RID: 9265
		private const string KEY_PREFIX = "MatchThreeEnviromentById";

		// Token: 0x04002432 RID: 9266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002433 RID: 9267
		private static int HandleId;
	}
}
