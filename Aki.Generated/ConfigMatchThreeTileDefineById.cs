using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000538 RID: 1336
	public class ConfigMatchThreeTileDefineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F5B RID: 8027 RVA: 0x0010A8C8 File Offset: 0x00108AC8
		static ConfigMatchThreeTileDefineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeTileDefineById.CreateStaticDefaultValue), new Action(ConfigMatchThreeTileDefineById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0010A8E8 File Offset: 0x00108AE8
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeTileDefineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeTileDefineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeTileDefine"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeTileDefine` where Id=?")
			});
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0010A967 File Offset: 0x00108B67
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeTileDefineById.LogPair = null;
			ConfigMatchThreeTileDefineById.HandleId = 0;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0010A975 File Offset: 0x00108B75
		public static void Init()
		{
			ConfigMatchThreeTileDefineById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeTileDefineById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeTileDefine` where Id=?");
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0010A990 File Offset: 0x00108B90
		public static MatchThreeTileDefine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeTileDefineById.HandleId, ConfigMatchThreeTileDefineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeTileDefineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeTileDefine?(MatchThreeTileDefine.GetRootAsMatchThreeTileDefine(configBuffer));
				}
			}
			ConfigMatchThreeTileDefineById.LogPair.Clear();
			ConfigMatchThreeTileDefineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeTileDefineById.HandleId, 1, p0Id, ConfigMatchThreeTileDefineById.LogPair) || ConfigCommon.Step(ConfigMatchThreeTileDefineById.HandleId, true, ConfigMatchThreeTileDefineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeTileDefineById.HandleId, ConfigMatchThreeTileDefineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeTileDefineById.HandleId, 0, ConfigMatchThreeTileDefineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeTileDefineById.HandleId, ConfigMatchThreeTileDefineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeTileDefine rootAsMatchThreeTileDefine = MatchThreeTileDefine.GetRootAsMatchThreeTileDefine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeTileDefineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeTileDefineById.HandleId, ConfigMatchThreeTileDefineById.LogPair);
			return new MatchThreeTileDefine?(rootAsMatchThreeTileDefine);
		}

		// Token: 0x0400246C RID: 9324
		private const string DB = "db_matchthree.db";

		// Token: 0x0400246D RID: 9325
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x0400246E RID: 9326
		private const string TABLE = "MatchThreeTileDefine";

		// Token: 0x0400246F RID: 9327
		private const string COMMAND = "select BinData from `MatchThreeTileDefine` where Id=?";

		// Token: 0x04002470 RID: 9328
		private const string KEY_PREFIX = "MatchThreeTileDefineById";

		// Token: 0x04002471 RID: 9329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002472 RID: 9330
		private static int HandleId;
	}
}
