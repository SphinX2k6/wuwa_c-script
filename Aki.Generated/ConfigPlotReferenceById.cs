using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074D RID: 1869
	public class ConfigPlotReferenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BDF RID: 11231 RVA: 0x00151710 File Offset: 0x0014F910
		static ConfigPlotReferenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotReferenceById.CreateStaticDefaultValue), new Action(ConfigPlotReferenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00151730 File Offset: 0x0014F930
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotReferenceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotReferenceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_randomplot.db"),
				new ValueTuple<string, object>("文件", "x.系统随机剧情.xlsx"),
				new ValueTuple<string, object>("表名", "PlotReference"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotReference` where Id=?")
			});
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x001517AF File Offset: 0x0014F9AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotReferenceById.LogPair = null;
			ConfigPlotReferenceById.HandleId = 0;
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x001517BD File Offset: 0x0014F9BD
		public static void Init()
		{
			ConfigPlotReferenceById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotReferenceById.HandleId, "db_randomplot.db", "select BinData from `PlotReference` where Id=?");
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x001517D8 File Offset: 0x0014F9D8
		public static PlotReference? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotReferenceById.HandleId, ConfigPlotReferenceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotReferenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlotReference?(PlotReference.GetRootAsPlotReference(configBuffer));
				}
			}
			ConfigPlotReferenceById.LogPair.Clear();
			ConfigPlotReferenceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlotReferenceById.HandleId, 1, p0Id, ConfigPlotReferenceById.LogPair) || ConfigCommon.Step(ConfigPlotReferenceById.HandleId, true, ConfigPlotReferenceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlotReferenceById.HandleId, ConfigPlotReferenceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotReferenceById.HandleId, 0, ConfigPlotReferenceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlotReferenceById.HandleId, ConfigPlotReferenceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlotReference rootAsPlotReference = PlotReference.GetRootAsPlotReference(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotReferenceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlotReferenceById.HandleId, ConfigPlotReferenceById.LogPair);
			return new PlotReference?(rootAsPlotReference);
		}

		// Token: 0x04003301 RID: 13057
		private const string DB = "db_randomplot.db";

		// Token: 0x04003302 RID: 13058
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x04003303 RID: 13059
		private const string TABLE = "PlotReference";

		// Token: 0x04003304 RID: 13060
		private const string COMMAND = "select BinData from `PlotReference` where Id=?";

		// Token: 0x04003305 RID: 13061
		private const string KEY_PREFIX = "PlotReferenceById";

		// Token: 0x04003306 RID: 13062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003307 RID: 13063
		private static int HandleId;
	}
}
