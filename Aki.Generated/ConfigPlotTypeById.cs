using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000767 RID: 1895
	public class ConfigPlotTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C7B RID: 11387 RVA: 0x00158567 File Offset: 0x00156767
		static ConfigPlotTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotTypeById.CreateStaticDefaultValue), new Action(ConfigPlotTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00158588 File Offset: 0x00156788
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

		// Token: 0x06002C7D RID: 11389 RVA: 0x00158607 File Offset: 0x00156807
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotTypeById.LogPair = null;
			ConfigPlotTypeById.HandleId = 0;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00158615 File Offset: 0x00156815
		public static void Init()
		{
			ConfigPlotTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotTypeById.HandleId, "db_handbook.db", "select BinData from `PlotType` where Id=?");
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00158630 File Offset: 0x00156830
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

		// Token: 0x040033B7 RID: 13239
		private const string DB = "db_handbook.db";

		// Token: 0x040033B8 RID: 13240
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040033B9 RID: 13241
		private const string TABLE = "PlotType";

		// Token: 0x040033BA RID: 13242
		private const string COMMAND = "select BinData from `PlotType` where Id=?";

		// Token: 0x040033BB RID: 13243
		private const string KEY_PREFIX = "PlotTypeById";

		// Token: 0x040033BC RID: 13244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033BD RID: 13245
		private static int HandleId;
	}
}
