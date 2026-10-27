using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000583 RID: 1411
	public class ConfigMotorFightActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600211F RID: 8479 RVA: 0x00114C1C File Offset: 0x00112E1C
		static ConfigMotorFightActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightActivityById.CreateStaticDefaultValue), new Action(ConfigMotorFightActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00114C3C File Offset: 0x00112E3C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightActivity` where Id=?")
			});
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00114CBB File Offset: 0x00112EBB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightActivityById.LogPair = null;
			ConfigMotorFightActivityById.HandleId = 0;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00114CC9 File Offset: 0x00112EC9
		public static void Init()
		{
			ConfigMotorFightActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightActivityById.HandleId, "db_motorfight.db", "select BinData from `MotorFightActivity` where Id=?");
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00114CE4 File Offset: 0x00112EE4
		public static MotorFightActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightActivity?(MotorFightActivity.GetRootAsMotorFightActivity(configBuffer));
				}
			}
			ConfigMotorFightActivityById.LogPair.Clear();
			ConfigMotorFightActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightActivityById.HandleId, 1, p0Id, ConfigMotorFightActivityById.LogPair) || ConfigCommon.Step(ConfigMotorFightActivityById.HandleId, true, ConfigMotorFightActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightActivityById.HandleId, 0, ConfigMotorFightActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightActivity rootAsMotorFightActivity = MotorFightActivity.GetRootAsMotorFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightActivityById.HandleId, ConfigMotorFightActivityById.LogPair);
			return new MotorFightActivity?(rootAsMotorFightActivity);
		}

		// Token: 0x04002679 RID: 9849
		private const string DB = "db_motorfight.db";

		// Token: 0x0400267A RID: 9850
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400267B RID: 9851
		private const string TABLE = "MotorFightActivity";

		// Token: 0x0400267C RID: 9852
		private const string COMMAND = "select BinData from `MotorFightActivity` where Id=?";

		// Token: 0x0400267D RID: 9853
		private const string KEY_PREFIX = "MotorFightActivityById";

		// Token: 0x0400267E RID: 9854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400267F RID: 9855
		private static int HandleId;
	}
}
