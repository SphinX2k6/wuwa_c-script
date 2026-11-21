using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000765 RID: 1893
	public class ConfigPlotReferenceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C6F RID: 11375 RVA: 0x0015818C File Offset: 0x0015638C
		static ConfigPlotReferenceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotReferenceById.CreateStaticDefaultValue), new Action(ConfigPlotReferenceById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x001581AC File Offset: 0x001563AC
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

		// Token: 0x06002C71 RID: 11377 RVA: 0x0015822B File Offset: 0x0015642B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotReferenceById.LogPair = null;
			ConfigPlotReferenceById.HandleId = 0;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00158239 File Offset: 0x00156439
		public static void Init()
		{
			ConfigPlotReferenceById.HandleId = ConfigCommon.InitDataStatement(ConfigPlotReferenceById.HandleId, "db_randomplot.db", "select BinData from `PlotReference` where Id=?");
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00158254 File Offset: 0x00156454
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

		// Token: 0x040033A9 RID: 13225
		private const string DB = "db_randomplot.db";

		// Token: 0x040033AA RID: 13226
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x040033AB RID: 13227
		private const string TABLE = "PlotReference";

		// Token: 0x040033AC RID: 13228
		private const string COMMAND = "select BinData from `PlotReference` where Id=?";

		// Token: 0x040033AD RID: 13229
		private const string KEY_PREFIX = "PlotReferenceById";

		// Token: 0x040033AE RID: 13230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033AF RID: 13231
		private static int HandleId;
	}
}
