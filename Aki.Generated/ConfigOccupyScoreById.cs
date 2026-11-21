using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200063D RID: 1597
	public class ConfigOccupyScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x0013124F File Offset: 0x0012F44F
		static ConfigOccupyScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupyScoreById.CreateStaticDefaultValue), new Action(ConfigOccupyScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x00131270 File Offset: 0x0012F470
		public static void CreateStaticDefaultValue()
		{
			ConfigOccupyScoreById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOccupyScoreById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "OccupyScore"),
				new ValueTuple<string, object>("语句", "select BinData from `OccupyScore` where Id=?")
			});
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x001312EF File Offset: 0x0012F4EF
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupyScoreById.LogPair = null;
			ConfigOccupyScoreById.HandleId = 0;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x001312FD File Offset: 0x0012F4FD
		public static void Init()
		{
			ConfigOccupyScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigOccupyScoreById.HandleId, "db_moraleplay.db", "select BinData from `OccupyScore` where Id=?");
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00131318 File Offset: 0x0012F518
		public static OccupyScore? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOccupyScoreById.HandleId, ConfigOccupyScoreById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OccupyScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OccupyScore?(OccupyScore.GetRootAsOccupyScore(configBuffer));
				}
			}
			ConfigOccupyScoreById.LogPair.Clear();
			ConfigOccupyScoreById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOccupyScoreById.HandleId, 1, p0Id, ConfigOccupyScoreById.LogPair) || ConfigCommon.Step(ConfigOccupyScoreById.HandleId, true, ConfigOccupyScoreById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOccupyScoreById.HandleId, ConfigOccupyScoreById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOccupyScoreById.HandleId, 0, ConfigOccupyScoreById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOccupyScoreById.HandleId, ConfigOccupyScoreById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OccupyScore rootAsOccupyScore = OccupyScore.GetRootAsOccupyScore(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OccupyScoreById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOccupyScoreById.HandleId, ConfigOccupyScoreById.LogPair);
			return new OccupyScore?(rootAsOccupyScore);
		}

		// Token: 0x04002B91 RID: 11153
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002B92 RID: 11154
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002B93 RID: 11155
		private const string TABLE = "OccupyScore";

		// Token: 0x04002B94 RID: 11156
		private const string COMMAND = "select BinData from `OccupyScore` where Id=?";

		// Token: 0x04002B95 RID: 11157
		private const string KEY_PREFIX = "OccupyScoreById";

		// Token: 0x04002B96 RID: 11158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B97 RID: 11159
		private static int HandleId;
	}
}
