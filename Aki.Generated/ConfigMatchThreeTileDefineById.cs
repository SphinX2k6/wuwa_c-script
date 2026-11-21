using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054E RID: 1358
	public class ConfigMatchThreeTileDefineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FDF RID: 8159 RVA: 0x0011101C File Offset: 0x0010F21C
		static ConfigMatchThreeTileDefineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeTileDefineById.CreateStaticDefaultValue), new Action(ConfigMatchThreeTileDefineById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0011103C File Offset: 0x0010F23C
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

		// Token: 0x06001FE1 RID: 8161 RVA: 0x001110BB File Offset: 0x0010F2BB
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeTileDefineById.LogPair = null;
			ConfigMatchThreeTileDefineById.HandleId = 0;
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x001110C9 File Offset: 0x0010F2C9
		public static void Init()
		{
			ConfigMatchThreeTileDefineById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeTileDefineById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeTileDefine` where Id=?");
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x001110E4 File Offset: 0x0010F2E4
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

		// Token: 0x04002506 RID: 9478
		private const string DB = "db_matchthree.db";

		// Token: 0x04002507 RID: 9479
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002508 RID: 9480
		private const string TABLE = "MatchThreeTileDefine";

		// Token: 0x04002509 RID: 9481
		private const string COMMAND = "select BinData from `MatchThreeTileDefine` where Id=?";

		// Token: 0x0400250A RID: 9482
		private const string KEY_PREFIX = "MatchThreeTileDefineById";

		// Token: 0x0400250B RID: 9483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400250C RID: 9484
		private static int HandleId;
	}
}
