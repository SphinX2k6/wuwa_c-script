using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074F RID: 1871
	public class ConfigPlotTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BEB RID: 11243 RVA: 0x00151AEB File Offset: 0x0014FCEB
		static ConfigPlotTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotTypeById.CreateStaticDefaultValue), new Action(ConfigPlotTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00151B0C File Offset: 0x0014FD0C
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PlotType"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotType` where Id=?")
			});
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00151B8B File Offset: 0x0014FD8B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotTypeById.LogPair = null;
			ConfigPlotTypeById.HandleId = 0;
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00151B99 File Offset: 0x0014FD99
		public static void Init()
		{
			ConfigPlotTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotTypeById.HandleId, "db_handbook.db", "select BinData from `PlotType` where Id=?");
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x00151BB4 File Offset: 0x0014FDB4
		public static PlotType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotTypeById.HandleId, ConfigPlotTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlotType?(PlotType.GetRootAsPlotType(configBuffer));
				}
			}
			ConfigPlotTypeById.LogPair.Clear();
			ConfigPlotTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlotTypeById.HandleId, 1, p0Id, ConfigPlotTypeById.LogPair) || ConfigCommon.Step(ConfigPlotTypeById.HandleId, true, ConfigPlotTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlotTypeById.HandleId, ConfigPlotTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotTypeById.HandleId, 0, ConfigPlotTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlotTypeById.HandleId, ConfigPlotTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlotType rootAsPlotType = PlotType.GetRootAsPlotType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlotTypeById.HandleId, ConfigPlotTypeById.LogPair);
			return new PlotType?(rootAsPlotType);
		}

		// Token: 0x0400330F RID: 13071
		private const string DB = "db_handbook.db";

		// Token: 0x04003310 RID: 13072
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04003311 RID: 13073
		private const string TABLE = "PlotType";

		// Token: 0x04003312 RID: 13074
		private const string COMMAND = "select BinData from `PlotType` where Id=?";

		// Token: 0x04003313 RID: 13075
		private const string KEY_PREFIX = "PlotTypeById";

		// Token: 0x04003314 RID: 13076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003315 RID: 13077
		private static int HandleId;
	}
}
