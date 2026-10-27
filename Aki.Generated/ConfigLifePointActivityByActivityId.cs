using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D3 RID: 1235
	public class ConfigLifePointActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CFD RID: 7421 RVA: 0x000FCF98 File Offset: 0x000FB198
		static ConfigLifePointActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigLifePointActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x000FCFB8 File Offset: 0x000FB1B8
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointActivity` where ActivityId=?")
			});
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x000FD037 File Offset: 0x000FB237
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointActivityByActivityId.LogPair = null;
			ConfigLifePointActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x000FD045 File Offset: 0x000FB245
		public static void Init()
		{
			ConfigLifePointActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointActivityByActivityId.HandleId, "db_lifepoint.db", "select BinData from `LifePointActivity` where ActivityId=?");
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x000FD060 File Offset: 0x000FB260
		public static LifePointActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointActivityByActivityId.HandleId, ConfigLifePointActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointActivity?(LifePointActivity.GetRootAsLifePointActivity(configBuffer));
				}
			}
			ConfigLifePointActivityByActivityId.LogPair.Clear();
			ConfigLifePointActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLifePointActivityByActivityId.HandleId, 1, p0ActivityId, ConfigLifePointActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigLifePointActivityByActivityId.HandleId, true, ConfigLifePointActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointActivityByActivityId.HandleId, ConfigLifePointActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointActivityByActivityId.HandleId, 0, ConfigLifePointActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointActivityByActivityId.HandleId, ConfigLifePointActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointActivity rootAsLifePointActivity = LifePointActivity.GetRootAsLifePointActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointActivityByActivityId.HandleId, ConfigLifePointActivityByActivityId.LogPair);
			return new LifePointActivity?(rootAsLifePointActivity);
		}

		// Token: 0x040021A9 RID: 8617
		private const string DB = "db_lifepoint.db";

		// Token: 0x040021AA RID: 8618
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x040021AB RID: 8619
		private const string TABLE = "LifePointActivity";

		// Token: 0x040021AC RID: 8620
		private const string COMMAND = "select BinData from `LifePointActivity` where ActivityId=?";

		// Token: 0x040021AD RID: 8621
		private const string KEY_PREFIX = "LifePointActivityByActivityId";

		// Token: 0x040021AE RID: 8622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021AF RID: 8623
		private static int HandleId;
	}
}
