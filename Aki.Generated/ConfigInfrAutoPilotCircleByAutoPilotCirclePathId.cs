using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043E RID: 1086
	public class ConfigInfrAutoPilotCircleByAutoPilotCirclePathId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600197D RID: 6525 RVA: 0x000ED46B File Offset: 0x000EB66B
		static ConfigInfrAutoPilotCircleByAutoPilotCirclePathId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.ResetStaticDefaultValue));
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000ED48C File Offset: 0x000EB68C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrAutoPilotCircle"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrAutoPilotCircle` where AutoPilotCirclePathId=?")
			});
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000ED50B File Offset: 0x000EB70B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair = null;
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId = 0;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x000ED519 File Offset: 0x000EB719
		public static void Init()
		{
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle` where AutoPilotCirclePathId=?");
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000ED534 File Offset: 0x000EB734
		public static InfrAutoPilotCircle? GetConfig(int p0AutoPilotCirclePathId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrAutoPilotCircleByAutoPilotCirclePathId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AutoPilotCirclePathId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrAutoPilotCircle?(InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(configBuffer));
				}
			}
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair.Clear();
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair.Add(new ValueTuple<string, object>("AutoPilotCirclePathId", p0AutoPilotCirclePathId));
			if (!ConfigCommon.BindInt(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, 1, p0AutoPilotCirclePathId, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair) || ConfigCommon.Step(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, true, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, 0, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrAutoPilotCircle rootAsInfrAutoPilotCircle = InfrAutoPilotCircle.GetRootAsInfrAutoPilotCircle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrAutoPilotCircleByAutoPilotCirclePathId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AutoPilotCirclePathId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair);
			return new InfrAutoPilotCircle?(rootAsInfrAutoPilotCircle);
		}

		// Token: 0x04001D96 RID: 7574
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D97 RID: 7575
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D98 RID: 7576
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001D99 RID: 7577
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle` where AutoPilotCirclePathId=?";

		// Token: 0x04001D9A RID: 7578
		private const string KEY_PREFIX = "InfrAutoPilotCircleByAutoPilotCirclePathId";

		// Token: 0x04001D9B RID: 7579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D9C RID: 7580
		private static int HandleId;
	}
}
