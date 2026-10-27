using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000729 RID: 1833
	public class ConfigPinballRankByTower : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B06 RID: 11014 RVA: 0x0014C99C File Offset: 0x0014AB9C
		static ConfigPinballRankByTower()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankByTower.CreateStaticDefaultValue), new Action(ConfigPinballRankByTower.ResetStaticDefaultValue));
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0014C9BC File Offset: 0x0014ABBC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRankByTower.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRankByTower.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRank"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRank` where Tower=?")
			});
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0014CA3B File Offset: 0x0014AC3B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankByTower.LogPair = null;
			ConfigPinballRankByTower.HandleId = 0;
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x0014CA49 File Offset: 0x0014AC49
		public static void Init()
		{
			ConfigPinballRankByTower.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankByTower.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank` where Tower=?");
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x0014CA64 File Offset: 0x0014AC64
		public static PinballRank? GetConfig(int p0Tower, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankByTower");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tower);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRank?(PinballRank.GetRootAsPinballRank(configBuffer));
				}
			}
			ConfigPinballRankByTower.LogPair.Clear();
			ConfigPinballRankByTower.LogPair.Add(new ValueTuple<string, object>("Tower", p0Tower));
			if (!ConfigCommon.BindInt(ConfigPinballRankByTower.HandleId, 1, p0Tower, ConfigPinballRankByTower.LogPair) || ConfigCommon.Step(ConfigPinballRankByTower.HandleId, true, ConfigPinballRankByTower.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRankByTower.HandleId, 0, ConfigPinballRankByTower.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRank rootAsPinballRank = PinballRank.GetRootAsPinballRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankByTower");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tower);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRankByTower.HandleId, ConfigPinballRankByTower.LogPair);
			return new PinballRank?(rootAsPinballRank);
		}

		// Token: 0x04003205 RID: 12805
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003206 RID: 12806
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x04003207 RID: 12807
		private const string TABLE = "PinballRank";

		// Token: 0x04003208 RID: 12808
		private const string COMMAND = "select BinData from `PinballRank` where Tower=?";

		// Token: 0x04003209 RID: 12809
		private const string KEY_PREFIX = "PinballRankByTower";

		// Token: 0x0400320A RID: 12810
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400320B RID: 12811
		private static int HandleId;
	}
}
