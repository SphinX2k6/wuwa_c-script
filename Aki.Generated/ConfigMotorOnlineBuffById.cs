using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B3 RID: 1459
	public class ConfigMotorOnlineBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x0011B2D8 File Offset: 0x001194D8
		static ConfigMotorOnlineBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorOnlineBuffById.CreateStaticDefaultValue), new Action(ConfigMotorOnlineBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0011B2F8 File Offset: 0x001194F8
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

		// Token: 0x06002241 RID: 8769 RVA: 0x0011B377 File Offset: 0x00119577
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorOnlineBuffById.LogPair = null;
			ConfigMotorOnlineBuffById.HandleId = 0;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0011B385 File Offset: 0x00119585
		public static void Init()
		{
			ConfigMotorOnlineBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorOnlineBuffById.HandleId, "db.onlinemotor.db", "select BinData from `MotorOnlineBuff` where Id=?");
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0011B3A0 File Offset: 0x001195A0
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

		// Token: 0x040027C9 RID: 10185
		private const string DB = "db.onlinemotor.db";

		// Token: 0x040027CA RID: 10186
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x040027CB RID: 10187
		private const string TABLE = "MotorOnlineBuff";

		// Token: 0x040027CC RID: 10188
		private const string COMMAND = "select BinData from `MotorOnlineBuff` where Id=?";

		// Token: 0x040027CD RID: 10189
		private const string KEY_PREFIX = "MotorOnlineBuffById";

		// Token: 0x040027CE RID: 10190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027CF RID: 10191
		private static int HandleId;
	}
}
