using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C2 RID: 194
	public class ConfigAutoPilotCirclesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x00076F8D File Offset: 0x0007518D
		static ConfigAutoPilotCirclesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoPilotCirclesById.CreateStaticDefaultValue), new Action(ConfigAutoPilotCirclesById.ResetStaticDefaultValue));
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00076FAC File Offset: 0x000751AC
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

		// Token: 0x0600048F RID: 1167 RVA: 0x0007702B File Offset: 0x0007522B
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoPilotCirclesById.LogPair = null;
			ConfigAutoPilotCirclesById.HandleId = 0;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00077039 File Offset: 0x00075239
		public static void Init()
		{
			ConfigAutoPilotCirclesById.HandleId = ConfigCommon.InitDataStatement(ConfigAutoPilotCirclesById.HandleId, "db_autopilotcircles.db", "select BinData from `AutoPilotCircles` where Id=?");
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00077054 File Offset: 0x00075254
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

		// Token: 0x04000532 RID: 1330
		private const string DB = "db_autopilotcircles.db";

		// Token: 0x04000533 RID: 1331
		private const string FILE = "k.可视化编辑/c.Csv/h.环路/*.csv*";

		// Token: 0x04000534 RID: 1332
		private const string TABLE = "AutoPilotCircles";

		// Token: 0x04000535 RID: 1333
		private const string COMMAND = "select BinData from `AutoPilotCircles` where Id=?";

		// Token: 0x04000536 RID: 1334
		private const string KEY_PREFIX = "AutoPilotCirclesById";

		// Token: 0x04000537 RID: 1335
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000538 RID: 1336
		private static int HandleId;
	}
}
