using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000625 RID: 1573
	public class ConfigOccupyScoreById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024EE RID: 9454 RVA: 0x0012A7D3 File Offset: 0x001289D3
		static ConfigOccupyScoreById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupyScoreById.CreateStaticDefaultValue), new Action(ConfigOccupyScoreById.ResetStaticDefaultValue));
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0012A7F4 File Offset: 0x001289F4
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

		// Token: 0x060024F0 RID: 9456 RVA: 0x0012A873 File Offset: 0x00128A73
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupyScoreById.LogPair = null;
			ConfigOccupyScoreById.HandleId = 0;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0012A881 File Offset: 0x00128A81
		public static void Init()
		{
			ConfigOccupyScoreById.HandleId = ConfigCommon.InitDataStatement(ConfigOccupyScoreById.HandleId, "db_moraleplay.db", "select BinData from `OccupyScore` where Id=?");
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0012A89C File Offset: 0x00128A9C
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

		// Token: 0x04002AE9 RID: 10985
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002AEA RID: 10986
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002AEB RID: 10987
		private const string TABLE = "OccupyScore";

		// Token: 0x04002AEC RID: 10988
		private const string COMMAND = "select BinData from `OccupyScore` where Id=?";

		// Token: 0x04002AED RID: 10989
		private const string KEY_PREFIX = "OccupyScoreById";

		// Token: 0x04002AEE RID: 10990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AEF RID: 10991
		private static int HandleId;
	}
}
