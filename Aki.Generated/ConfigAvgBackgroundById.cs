using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C5 RID: 197
	public class ConfigAvgBackgroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x000775B0 File Offset: 0x000757B0
		static ConfigAvgBackgroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgBackgroundById.CreateStaticDefaultValue), new Action(ConfigAvgBackgroundById.ResetStaticDefaultValue));
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000775D0 File Offset: 0x000757D0
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgBackgroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgBackgroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgbackground.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.Avg背景/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgBackground"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgBackground` where Id=?")
			});
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0007764F File Offset: 0x0007584F
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgBackgroundById.LogPair = null;
			ConfigAvgBackgroundById.HandleId = 0;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0007765D File Offset: 0x0007585D
		public static void Init()
		{
			ConfigAvgBackgroundById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgBackgroundById.HandleId, "db_avgbackground.db", "select BinData from `AvgBackground` where Id=?");
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00077678 File Offset: 0x00075878
		public static AvgBackground? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgBackgroundById.HandleId, ConfigAvgBackgroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgBackground?(AvgBackground.GetRootAsAvgBackground(configBuffer));
				}
			}
			ConfigAvgBackgroundById.LogPair.Clear();
			ConfigAvgBackgroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgBackgroundById.HandleId, 1, p0Id, ConfigAvgBackgroundById.LogPair) || ConfigCommon.Step(ConfigAvgBackgroundById.HandleId, true, ConfigAvgBackgroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgBackgroundById.HandleId, ConfigAvgBackgroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgBackgroundById.HandleId, 0, ConfigAvgBackgroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgBackgroundById.HandleId, ConfigAvgBackgroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgBackground rootAsAvgBackground = AvgBackground.GetRootAsAvgBackground(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgBackgroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgBackgroundById.HandleId, ConfigAvgBackgroundById.LogPair);
			return new AvgBackground?(rootAsAvgBackground);
		}

		// Token: 0x04000547 RID: 1351
		private const string DB = "db_avgbackground.db";

		// Token: 0x04000548 RID: 1352
		private const string FILE = "k.可视化编辑/c.Csv/a.Avg背景/*.csv*";

		// Token: 0x04000549 RID: 1353
		private const string TABLE = "AvgBackground";

		// Token: 0x0400054A RID: 1354
		private const string COMMAND = "select BinData from `AvgBackground` where Id=?";

		// Token: 0x0400054B RID: 1355
		private const string KEY_PREFIX = "AvgBackgroundById";

		// Token: 0x0400054C RID: 1356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400054D RID: 1357
		private static int HandleId;
	}
}
