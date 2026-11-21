using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000556 RID: 1366
	public class ConfigMingSuPlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x00112334 File Offset: 0x00110534
		static ConfigMingSuPlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMingSuPlotById.CreateStaticDefaultValue), new Action(ConfigMingSuPlotById.ResetStaticDefaultValue));
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00112354 File Offset: 0x00110554
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

		// Token: 0x06002013 RID: 8211 RVA: 0x001123D3 File Offset: 0x001105D3
		public static void ResetStaticDefaultValue()
		{
			ConfigMingSuPlotById.LogPair = null;
			ConfigMingSuPlotById.HandleId = 0;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x001123E1 File Offset: 0x001105E1
		public static void Init()
		{
			ConfigMingSuPlotById.HandleId = ConfigCommon.InitDataStatement(ConfigMingSuPlotById.HandleId, "db_dragon_ball.db", "select BinData from `MingSuPlot` where Id=?");
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x001123FC File Offset: 0x001105FC
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

		// Token: 0x0400253E RID: 9534
		private const string DB = "db_dragon_ball.db";

		// Token: 0x0400253F RID: 9535
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04002540 RID: 9536
		private const string TABLE = "MingSuPlot";

		// Token: 0x04002541 RID: 9537
		private const string COMMAND = "select BinData from `MingSuPlot` where Id=?";

		// Token: 0x04002542 RID: 9538
		private const string KEY_PREFIX = "MingSuPlotById";

		// Token: 0x04002543 RID: 9539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002544 RID: 9540
		private static int HandleId;
	}
}
