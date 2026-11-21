using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AC RID: 1452
	public class ConfigMotorFightQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002215 RID: 8725 RVA: 0x0011DBD8 File Offset: 0x0011BDD8
		static ConfigMotorFightQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightQualityById.CreateStaticDefaultValue), new Action(ConfigMotorFightQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0011DBF8 File Offset: 0x0011BDF8
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightQuality` where Id=?")
			});
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0011DC77 File Offset: 0x0011BE77
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightQualityById.LogPair = null;
			ConfigMotorFightQualityById.HandleId = 0;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0011DC85 File Offset: 0x0011BE85
		public static void Init()
		{
			ConfigMotorFightQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightQualityById.HandleId, "db_motorfight.db", "select BinData from `MotorFightQuality` where Id=?");
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0011DCA0 File Offset: 0x0011BEA0
		public static MotorFightQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightQuality?(MotorFightQuality.GetRootAsMotorFightQuality(configBuffer));
				}
			}
			ConfigMotorFightQualityById.LogPair.Clear();
			ConfigMotorFightQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightQualityById.HandleId, 1, p0Id, ConfigMotorFightQualityById.LogPair) || ConfigCommon.Step(ConfigMotorFightQualityById.HandleId, true, ConfigMotorFightQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightQualityById.HandleId, 0, ConfigMotorFightQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightQuality rootAsMotorFightQuality = MotorFightQuality.GetRootAsMotorFightQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightQualityById.HandleId, ConfigMotorFightQualityById.LogPair);
			return new MotorFightQuality?(rootAsMotorFightQuality);
		}

		// Token: 0x04002798 RID: 10136
		private const string DB = "db_motorfight.db";

		// Token: 0x04002799 RID: 10137
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400279A RID: 10138
		private const string TABLE = "MotorFightQuality";

		// Token: 0x0400279B RID: 10139
		private const string COMMAND = "select BinData from `MotorFightQuality` where Id=?";

		// Token: 0x0400279C RID: 10140
		private const string KEY_PREFIX = "MotorFightQualityById";

		// Token: 0x0400279D RID: 10141
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400279E RID: 10142
		private static int HandleId;
	}
}
