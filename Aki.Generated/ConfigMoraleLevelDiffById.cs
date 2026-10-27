using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000567 RID: 1383
	public class ConfigMoraleLevelDiffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x00110EBC File Offset: 0x0010F0BC
		static ConfigMoraleLevelDiffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffById.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffById.ResetStaticDefaultValue));
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00110EDC File Offset: 0x0010F0DC
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLevelDiffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLevelDiffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLevelDiff"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLevelDiff` where Level=?")
			});
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00110F5B File Offset: 0x0010F15B
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffById.LogPair = null;
			ConfigMoraleLevelDiffById.HandleId = 0;
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00110F69 File Offset: 0x0010F169
		public static void Init()
		{
			ConfigMoraleLevelDiffById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiff` where Level=?");
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00110F84 File Offset: 0x0010F184
		public static MoraleLevelDiff? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleLevelDiff?(MoraleLevelDiff.GetRootAsMoraleLevelDiff(configBuffer));
				}
			}
			ConfigMoraleLevelDiffById.LogPair.Clear();
			ConfigMoraleLevelDiffById.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMoraleLevelDiffById.HandleId, 1, p0Level, ConfigMoraleLevelDiffById.LogPair) || ConfigCommon.Step(ConfigMoraleLevelDiffById.HandleId, true, ConfigMoraleLevelDiffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLevelDiffById.HandleId, 0, ConfigMoraleLevelDiffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleLevelDiff rootAsMoraleLevelDiff = MoraleLevelDiff.GetRootAsMoraleLevelDiff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
			return new MoraleLevelDiff?(rootAsMoraleLevelDiff);
		}

		// Token: 0x040025B5 RID: 9653
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025B6 RID: 9654
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025B7 RID: 9655
		private const string TABLE = "MoraleLevelDiff";

		// Token: 0x040025B8 RID: 9656
		private const string COMMAND = "select BinData from `MoraleLevelDiff` where Level=?";

		// Token: 0x040025B9 RID: 9657
		private const string KEY_PREFIX = "MoraleLevelDiffById";

		// Token: 0x040025BA RID: 9658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025BB RID: 9659
		private static int HandleId;
	}
}
