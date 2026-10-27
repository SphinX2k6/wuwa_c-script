using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BA RID: 186
	public class ConfigAutoPilotCirclesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x000726D9 File Offset: 0x000708D9
		static ConfigAutoPilotCirclesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoPilotCirclesById.CreateStaticDefaultValue), new Action(ConfigAutoPilotCirclesById.ResetStaticDefaultValue));
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000726F8 File Offset: 0x000708F8
		public static void CreateStaticDefaultValue()
		{
			ConfigAutoPilotCirclesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAutoPilotCirclesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_autopilotcircles.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/h.环路/*.csv*"),
				new ValueTuple<string, object>("表名", "AutoPilotCircles"),
				new ValueTuple<string, object>("语句", "select BinData from `AutoPilotCircles` where Id=?")
			});
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00072777 File Offset: 0x00070977
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoPilotCirclesById.LogPair = null;
			ConfigAutoPilotCirclesById.HandleId = 0;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00072785 File Offset: 0x00070985
		public static void Init()
		{
			ConfigAutoPilotCirclesById.HandleId = ConfigCommon.InitDataStatement(ConfigAutoPilotCirclesById.HandleId, "db_autopilotcircles.db", "select BinData from `AutoPilotCircles` where Id=?");
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000727A0 File Offset: 0x000709A0
		public static AutoPilotCircles? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAutoPilotCirclesById.HandleId, ConfigAutoPilotCirclesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AutoPilotCirclesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AutoPilotCircles?(AutoPilotCircles.GetRootAsAutoPilotCircles(configBuffer));
				}
			}
			ConfigAutoPilotCirclesById.LogPair.Clear();
			ConfigAutoPilotCirclesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAutoPilotCirclesById.HandleId, 1, p0Id, ConfigAutoPilotCirclesById.LogPair) || ConfigCommon.Step(ConfigAutoPilotCirclesById.HandleId, true, ConfigAutoPilotCirclesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAutoPilotCirclesById.HandleId, ConfigAutoPilotCirclesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAutoPilotCirclesById.HandleId, 0, ConfigAutoPilotCirclesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAutoPilotCirclesById.HandleId, ConfigAutoPilotCirclesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AutoPilotCircles rootAsAutoPilotCircles = AutoPilotCircles.GetRootAsAutoPilotCircles(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AutoPilotCirclesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAutoPilotCirclesById.HandleId, ConfigAutoPilotCirclesById.LogPair);
			return new AutoPilotCircles?(rootAsAutoPilotCircles);
		}

		// Token: 0x040004FA RID: 1274
		private const string DB = "db_autopilotcircles.db";

		// Token: 0x040004FB RID: 1275
		private const string FILE = "k.可视化编辑/c.Csv/h.环路/*.csv*";

		// Token: 0x040004FC RID: 1276
		private const string TABLE = "AutoPilotCircles";

		// Token: 0x040004FD RID: 1277
		private const string COMMAND = "select BinData from `AutoPilotCircles` where Id=?";

		// Token: 0x040004FE RID: 1278
		private const string KEY_PREFIX = "AutoPilotCirclesById";

		// Token: 0x040004FF RID: 1279
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000500 RID: 1280
		private static int HandleId;
	}
}
