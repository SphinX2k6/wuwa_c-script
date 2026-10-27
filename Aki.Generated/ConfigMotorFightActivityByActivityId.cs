using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000582 RID: 1410
	public class ConfigMotorFightActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x001149D4 File Offset: 0x00112BD4
		static ConfigMotorFightActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigMotorFightActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x001149F4 File Offset: 0x00112BF4
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightActivity` where ActivityId=?")
			});
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00114A73 File Offset: 0x00112C73
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightActivityByActivityId.LogPair = null;
			ConfigMotorFightActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00114A81 File Offset: 0x00112C81
		public static void Init()
		{
			ConfigMotorFightActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightActivityByActivityId.HandleId, "db_motorfight.db", "select BinData from `MotorFightActivity` where ActivityId=?");
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00114A9C File Offset: 0x00112C9C
		public static MotorFightActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightActivity?(MotorFightActivity.GetRootAsMotorFightActivity(configBuffer));
				}
			}
			ConfigMotorFightActivityByActivityId.LogPair.Clear();
			ConfigMotorFightActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMotorFightActivityByActivityId.HandleId, 1, p0ActivityId, ConfigMotorFightActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigMotorFightActivityByActivityId.HandleId, true, ConfigMotorFightActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightActivityByActivityId.HandleId, 0, ConfigMotorFightActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightActivity rootAsMotorFightActivity = MotorFightActivity.GetRootAsMotorFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightActivityByActivityId.HandleId, ConfigMotorFightActivityByActivityId.LogPair);
			return new MotorFightActivity?(rootAsMotorFightActivity);
		}

		// Token: 0x04002672 RID: 9842
		private const string DB = "db_motorfight.db";

		// Token: 0x04002673 RID: 9843
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002674 RID: 9844
		private const string TABLE = "MotorFightActivity";

		// Token: 0x04002675 RID: 9845
		private const string COMMAND = "select BinData from `MotorFightActivity` where ActivityId=?";

		// Token: 0x04002676 RID: 9846
		private const string KEY_PREFIX = "MotorFightActivityByActivityId";

		// Token: 0x04002677 RID: 9847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002678 RID: 9848
		private static int HandleId;
	}
}
