using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000428 RID: 1064
	public class ConfigInfrAutoPilotCircleByAutoPilotCirclePathId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018F9 RID: 6393 RVA: 0x000E6D17 File Offset: 0x000E4F17
		static ConfigInfrAutoPilotCircleByAutoPilotCirclePathId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.CreateStaticDefaultValue), new Action(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.ResetStaticDefaultValue));
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x000E6D38 File Offset: 0x000E4F38
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

		// Token: 0x060018FB RID: 6395 RVA: 0x000E6DB7 File Offset: 0x000E4FB7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.LogPair = null;
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId = 0;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000E6DC5 File Offset: 0x000E4FC5
		public static void Init()
		{
			ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId = ConfigCommon.InitDataStatement(ConfigInfrAutoPilotCircleByAutoPilotCirclePathId.HandleId, "db_infrastructure.db", "select BinData from `InfrAutoPilotCircle` where AutoPilotCirclePathId=?");
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000E6DE0 File Offset: 0x000E4FE0
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

		// Token: 0x04001CFC RID: 7420
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CFD RID: 7421
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001CFE RID: 7422
		private const string TABLE = "InfrAutoPilotCircle";

		// Token: 0x04001CFF RID: 7423
		private const string COMMAND = "select BinData from `InfrAutoPilotCircle` where AutoPilotCirclePathId=?";

		// Token: 0x04001D00 RID: 7424
		private const string KEY_PREFIX = "InfrAutoPilotCircleByAutoPilotCirclePathId";

		// Token: 0x04001D01 RID: 7425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D02 RID: 7426
		private static int HandleId;
	}
}
