using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074A RID: 1866
	public class ConfigPlotGuestByGuestID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BCD RID: 11213 RVA: 0x001510ED File Offset: 0x0014F2ED
		static ConfigPlotGuestByGuestID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotGuestByGuestID.CreateStaticDefaultValue), new Action(ConfigPlotGuestByGuestID.ResetStaticDefaultValue));
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x0015110C File Offset: 0x0014F30C
		public static void CreateStaticDefaultValue()
		{
			ConfigPlotGuestByGuestID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlotGuestByGuestID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_plotguest.db"),
				new ValueTuple<string, object>("文件", "j.剧情Guest.xlsx"),
				new ValueTuple<string, object>("表名", "PlotGuest"),
				new ValueTuple<string, object>("语句", "select BinData from `PlotGuest` where GuestID=?")
			});
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x0015118B File Offset: 0x0014F38B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotGuestByGuestID.LogPair = null;
			ConfigPlotGuestByGuestID.HandleId = 0;
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00151199 File Offset: 0x0014F399
		public static void Init()
		{
			ConfigPlotGuestByGuestID.HandleId = ConfigCommon.InitDataStatement(ConfigPlotGuestByGuestID.HandleId, "db_plotguest.db", "select BinData from `PlotGuest` where GuestID=?");
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x001511B4 File Offset: 0x0014F3B4
		public static PlotGuest? GetConfig(int p0GuestID, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlotGuestByGuestID.HandleId, ConfigPlotGuestByGuestID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotGuestByGuestID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuestID);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlotGuest?(PlotGuest.GetRootAsPlotGuest(configBuffer));
				}
			}
			ConfigPlotGuestByGuestID.LogPair.Clear();
			ConfigPlotGuestByGuestID.LogPair.Add(new ValueTuple<string, object>("GuestID", p0GuestID));
			if (!ConfigCommon.BindInt(ConfigPlotGuestByGuestID.HandleId, 1, p0GuestID, ConfigPlotGuestByGuestID.LogPair) || ConfigCommon.Step(ConfigPlotGuestByGuestID.HandleId, true, ConfigPlotGuestByGuestID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlotGuestByGuestID.HandleId, ConfigPlotGuestByGuestID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlotGuestByGuestID.HandleId, 0, ConfigPlotGuestByGuestID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlotGuestByGuestID.HandleId, ConfigPlotGuestByGuestID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlotGuest rootAsPlotGuest = PlotGuest.GetRootAsPlotGuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlotGuestByGuestID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GuestID);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlotGuestByGuestID.HandleId, ConfigPlotGuestByGuestID.LogPair);
			return new PlotGuest?(rootAsPlotGuest);
		}

		// Token: 0x040032EC RID: 13036
		private const string DB = "db_plotguest.db";

		// Token: 0x040032ED RID: 13037
		private const string FILE = "j.剧情Guest.xlsx";

		// Token: 0x040032EE RID: 13038
		private const string TABLE = "PlotGuest";

		// Token: 0x040032EF RID: 13039
		private const string COMMAND = "select BinData from `PlotGuest` where GuestID=?";

		// Token: 0x040032F0 RID: 13040
		private const string KEY_PREFIX = "PlotGuestByGuestID";

		// Token: 0x040032F1 RID: 13041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032F2 RID: 13042
		private static int HandleId;
	}
}
