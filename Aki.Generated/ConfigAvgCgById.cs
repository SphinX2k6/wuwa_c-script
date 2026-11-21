using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C6 RID: 198
	public class ConfigAvgCgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x000777F8 File Offset: 0x000759F8
		static ConfigAvgCgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgCgById.CreateStaticDefaultValue), new Action(ConfigAvgCgById.ResetStaticDefaultValue));
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00077818 File Offset: 0x00075A18
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgCgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgCgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgcg.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.AvgCG/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgCg"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgCg` where Id=?")
			});
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00077897 File Offset: 0x00075A97
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgCgById.LogPair = null;
			ConfigAvgCgById.HandleId = 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000778A5 File Offset: 0x00075AA5
		public static void Init()
		{
			ConfigAvgCgById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgCgById.HandleId, "db_avgcg.db", "select BinData from `AvgCg` where Id=?");
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000778C0 File Offset: 0x00075AC0
		public static AvgCg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgCgById.HandleId, ConfigAvgCgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgCgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgCg?(AvgCg.GetRootAsAvgCg(configBuffer));
				}
			}
			ConfigAvgCgById.LogPair.Clear();
			ConfigAvgCgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgCgById.HandleId, 1, p0Id, ConfigAvgCgById.LogPair) || ConfigCommon.Step(ConfigAvgCgById.HandleId, true, ConfigAvgCgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgCgById.HandleId, ConfigAvgCgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgCgById.HandleId, 0, ConfigAvgCgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgCgById.HandleId, ConfigAvgCgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgCg rootAsAvgCg = AvgCg.GetRootAsAvgCg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgCgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgCgById.HandleId, ConfigAvgCgById.LogPair);
			return new AvgCg?(rootAsAvgCg);
		}

		// Token: 0x0400054E RID: 1358
		private const string DB = "db_avgcg.db";

		// Token: 0x0400054F RID: 1359
		private const string FILE = "k.可视化编辑/c.Csv/a.AvgCG/*.csv*";

		// Token: 0x04000550 RID: 1360
		private const string TABLE = "AvgCg";

		// Token: 0x04000551 RID: 1361
		private const string COMMAND = "select BinData from `AvgCg` where Id=?";

		// Token: 0x04000552 RID: 1362
		private const string KEY_PREFIX = "AvgCgById";

		// Token: 0x04000553 RID: 1363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000554 RID: 1364
		private static int HandleId;
	}
}
