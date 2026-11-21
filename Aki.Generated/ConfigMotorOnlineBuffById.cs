using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CA RID: 1482
	public class ConfigMotorOnlineBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022C9 RID: 8905 RVA: 0x00121BC0 File Offset: 0x0011FDC0
		static ConfigMotorOnlineBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorOnlineBuffById.CreateStaticDefaultValue), new Action(ConfigMotorOnlineBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00121BE0 File Offset: 0x0011FDE0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorOnlineBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorOnlineBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorOnlineBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorOnlineBuff` where Id=?")
			});
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00121C5F File Offset: 0x0011FE5F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorOnlineBuffById.LogPair = null;
			ConfigMotorOnlineBuffById.HandleId = 0;
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00121C6D File Offset: 0x0011FE6D
		public static void Init()
		{
			ConfigMotorOnlineBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorOnlineBuffById.HandleId, "db.onlinemotor.db", "select BinData from `MotorOnlineBuff` where Id=?");
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00121C88 File Offset: 0x0011FE88
		public static MotorOnlineBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorOnlineBuffById.HandleId, ConfigMotorOnlineBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorOnlineBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorOnlineBuff?(MotorOnlineBuff.GetRootAsMotorOnlineBuff(configBuffer));
				}
			}
			ConfigMotorOnlineBuffById.LogPair.Clear();
			ConfigMotorOnlineBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorOnlineBuffById.HandleId, 1, p0Id, ConfigMotorOnlineBuffById.LogPair) || ConfigCommon.Step(ConfigMotorOnlineBuffById.HandleId, true, ConfigMotorOnlineBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorOnlineBuffById.HandleId, ConfigMotorOnlineBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorOnlineBuffById.HandleId, 0, ConfigMotorOnlineBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorOnlineBuffById.HandleId, ConfigMotorOnlineBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorOnlineBuff rootAsMotorOnlineBuff = MotorOnlineBuff.GetRootAsMotorOnlineBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorOnlineBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorOnlineBuffById.HandleId, ConfigMotorOnlineBuffById.LogPair);
			return new MotorOnlineBuff?(rootAsMotorOnlineBuff);
		}

		// Token: 0x0400286A RID: 10346
		private const string DB = "db.onlinemotor.db";

		// Token: 0x0400286B RID: 10347
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x0400286C RID: 10348
		private const string TABLE = "MotorOnlineBuff";

		// Token: 0x0400286D RID: 10349
		private const string COMMAND = "select BinData from `MotorOnlineBuff` where Id=?";

		// Token: 0x0400286E RID: 10350
		private const string KEY_PREFIX = "MotorOnlineBuffById";

		// Token: 0x0400286F RID: 10351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002870 RID: 10352
		private static int HandleId;
	}
}
