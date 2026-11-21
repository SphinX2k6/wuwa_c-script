using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000762 RID: 1890
	public class ConfigPlotGuestByGuestID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C5D RID: 11357 RVA: 0x00157B69 File Offset: 0x00155D69
		static ConfigPlotGuestByGuestID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlotGuestByGuestID.CreateStaticDefaultValue), new Action(ConfigPlotGuestByGuestID.ResetStaticDefaultValue));
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x00157B88 File Offset: 0x00155D88
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

		// Token: 0x06002C5F RID: 11359 RVA: 0x00157C07 File Offset: 0x00155E07
		public static void ResetStaticDefaultValue()
		{
			ConfigPlotGuestByGuestID.LogPair = null;
			ConfigPlotGuestByGuestID.HandleId = 0;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x00157C15 File Offset: 0x00155E15
		public static void Init()
		{
			ConfigPlotGuestByGuestID.HandleId = ConfigCommon.InitDataStatement(ConfigPlotGuestByGuestID.HandleId, "db_plotguest.db", "select BinData from `PlotGuest` where GuestID=?");
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x00157C30 File Offset: 0x00155E30
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

		// Token: 0x04003394 RID: 13204
		private const string DB = "db_plotguest.db";

		// Token: 0x04003395 RID: 13205
		private const string FILE = "j.剧情Guest.xlsx";

		// Token: 0x04003396 RID: 13206
		private const string TABLE = "PlotGuest";

		// Token: 0x04003397 RID: 13207
		private const string COMMAND = "select BinData from `PlotGuest` where GuestID=?";

		// Token: 0x04003398 RID: 13208
		private const string KEY_PREFIX = "PlotGuestByGuestID";

		// Token: 0x04003399 RID: 13209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400339A RID: 13210
		private static int HandleId;
	}
}
