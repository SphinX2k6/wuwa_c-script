using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E9 RID: 1257
	public class ConfigLifePointActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D81 RID: 7553 RVA: 0x001036EC File Offset: 0x001018EC
		static ConfigLifePointActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigLifePointActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0010370C File Offset: 0x0010190C
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

		// Token: 0x06001D83 RID: 7555 RVA: 0x0010378B File Offset: 0x0010198B
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointActivityByActivityId.LogPair = null;
			ConfigLifePointActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00103799 File Offset: 0x00101999
		public static void Init()
		{
			ConfigLifePointActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointActivityByActivityId.HandleId, "db_lifepoint.db", "select BinData from `LifePointActivity` where ActivityId=?");
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x001037B4 File Offset: 0x001019B4
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

		// Token: 0x04002243 RID: 8771
		private const string DB = "db_lifepoint.db";

		// Token: 0x04002244 RID: 8772
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x04002245 RID: 8773
		private const string TABLE = "LifePointActivity";

		// Token: 0x04002246 RID: 8774
		private const string COMMAND = "select BinData from `LifePointActivity` where ActivityId=?";

		// Token: 0x04002247 RID: 8775
		private const string KEY_PREFIX = "LifePointActivityByActivityId";

		// Token: 0x04002248 RID: 8776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002249 RID: 8777
		private static int HandleId;
	}
}
