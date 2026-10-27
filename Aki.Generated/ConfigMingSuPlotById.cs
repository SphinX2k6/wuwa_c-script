using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000540 RID: 1344
	public class ConfigMingSuPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F8D RID: 8077 RVA: 0x0010BBE0 File Offset: 0x00109DE0
		static ConfigMingSuPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMingSuPlotById.CreateStaticDefaultValue), new Action(ConfigMingSuPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0010BC00 File Offset: 0x00109E00
		public static void CreateStaticDefaultValue()
		{
			ConfigMingSuPlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMingSuPlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "MingSuPlot"),
				new ValueTuple<string, object>("语句", "select BinData from `MingSuPlot` where Id=?")
			});
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0010BC7F File Offset: 0x00109E7F
		public static void ResetStaticDefaultValue()
		{
			ConfigMingSuPlotById.LogPair = null;
			ConfigMingSuPlotById.HandleId = 0;
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0010BC8D File Offset: 0x00109E8D
		public static void Init()
		{
			ConfigMingSuPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigMingSuPlotById.HandleId, "db_dragon_ball.db", "select BinData from `MingSuPlot` where Id=?");
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0010BCA8 File Offset: 0x00109EA8
		public static MingSuPlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMingSuPlotById.HandleId, ConfigMingSuPlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MingSuPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MingSuPlot?(MingSuPlot.GetRootAsMingSuPlot(configBuffer));
				}
			}
			ConfigMingSuPlotById.LogPair.Clear();
			ConfigMingSuPlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMingSuPlotById.HandleId, 1, p0Id, ConfigMingSuPlotById.LogPair) || ConfigCommon.Step(ConfigMingSuPlotById.HandleId, true, ConfigMingSuPlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMingSuPlotById.HandleId, ConfigMingSuPlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMingSuPlotById.HandleId, 0, ConfigMingSuPlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMingSuPlotById.HandleId, ConfigMingSuPlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MingSuPlot rootAsMingSuPlot = MingSuPlot.GetRootAsMingSuPlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MingSuPlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMingSuPlotById.HandleId, ConfigMingSuPlotById.LogPair);
			return new MingSuPlot?(rootAsMingSuPlot);
		}

		// Token: 0x040024A4 RID: 9380
		private const string DB = "db_dragon_ball.db";

		// Token: 0x040024A5 RID: 9381
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x040024A6 RID: 9382
		private const string TABLE = "MingSuPlot";

		// Token: 0x040024A7 RID: 9383
		private const string COMMAND = "select BinData from `MingSuPlot` where Id=?";

		// Token: 0x040024A8 RID: 9384
		private const string KEY_PREFIX = "MingSuPlotById";

		// Token: 0x040024A9 RID: 9385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024AA RID: 9386
		private static int HandleId;
	}
}
