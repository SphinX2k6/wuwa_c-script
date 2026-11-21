using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000252 RID: 594
	public class ConfigDropShowPlanById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DF0 RID: 3568 RVA: 0x000ABE6C File Offset: 0x000AA06C
		static ConfigDropShowPlanById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropShowPlanById.CreateStaticDefaultValue), new Action(ConfigDropShowPlanById.ResetStaticDefaultValue));
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000ABE8C File Offset: 0x000AA08C
		public static void CreateStaticDefaultValue()
		{
			ConfigDropShowPlanById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropShowPlanById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drop.db"),
				new ValueTuple<string, object>("文件", "d.掉落.xlsx"),
				new ValueTuple<string, object>("表名", "DropShowPlan"),
				new ValueTuple<string, object>("语句", "select BinData from `DropShowPlan` where Id=?")
			});
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000ABF0B File Offset: 0x000AA10B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropShowPlanById.LogPair = null;
			ConfigDropShowPlanById.HandleId = 0;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000ABF19 File Offset: 0x000AA119
		public static void Init()
		{
			ConfigDropShowPlanById.HandleId = ConfigCommon.InitDataStatement(ConfigDropShowPlanById.HandleId, "db_drop.db", "select BinData from `DropShowPlan` where Id=?");
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000ABF34 File Offset: 0x000AA134
		public static DropShowPlan? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropShowPlanById.HandleId, ConfigDropShowPlanById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropShowPlanById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropShowPlan?(DropShowPlan.GetRootAsDropShowPlan(configBuffer));
				}
			}
			ConfigDropShowPlanById.LogPair.Clear();
			ConfigDropShowPlanById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropShowPlanById.HandleId, 1, p0Id, ConfigDropShowPlanById.LogPair) || ConfigCommon.Step(ConfigDropShowPlanById.HandleId, true, ConfigDropShowPlanById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropShowPlanById.HandleId, ConfigDropShowPlanById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropShowPlanById.HandleId, 0, ConfigDropShowPlanById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropShowPlanById.HandleId, ConfigDropShowPlanById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropShowPlan rootAsDropShowPlan = DropShowPlan.GetRootAsDropShowPlan(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropShowPlanById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropShowPlanById.HandleId, ConfigDropShowPlanById.LogPair);
			return new DropShowPlan?(rootAsDropShowPlan);
		}

		// Token: 0x04001022 RID: 4130
		private const string DB = "db_drop.db";

		// Token: 0x04001023 RID: 4131
		private const string FILE = "d.掉落.xlsx";

		// Token: 0x04001024 RID: 4132
		private const string TABLE = "DropShowPlan";

		// Token: 0x04001025 RID: 4133
		private const string COMMAND = "select BinData from `DropShowPlan` where Id=?";

		// Token: 0x04001026 RID: 4134
		private const string KEY_PREFIX = "DropShowPlanById";

		// Token: 0x04001027 RID: 4135
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001028 RID: 4136
		private static int HandleId;
	}
}
