using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000240 RID: 576
	public class ConfigDropShowPlanById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D84 RID: 3460 RVA: 0x000A5F34 File Offset: 0x000A4134
		static ConfigDropShowPlanById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropShowPlanById.CreateStaticDefaultValue), new Action(ConfigDropShowPlanById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000A5F54 File Offset: 0x000A4154
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

		// Token: 0x06000D86 RID: 3462 RVA: 0x000A5FD3 File Offset: 0x000A41D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropShowPlanById.LogPair = null;
			ConfigDropShowPlanById.HandleId = 0;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000A5FE1 File Offset: 0x000A41E1
		public static void Init()
		{
			ConfigDropShowPlanById.HandleId = ConfigCommon.InitDataStatement(ConfigDropShowPlanById.HandleId, "db_drop.db", "select BinData from `DropShowPlan` where Id=?");
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000A5FFC File Offset: 0x000A41FC
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

		// Token: 0x04000FA4 RID: 4004
		private const string DB = "db_drop.db";

		// Token: 0x04000FA5 RID: 4005
		private const string FILE = "d.掉落.xlsx";

		// Token: 0x04000FA6 RID: 4006
		private const string TABLE = "DropShowPlan";

		// Token: 0x04000FA7 RID: 4007
		private const string COMMAND = "select BinData from `DropShowPlan` where Id=?";

		// Token: 0x04000FA8 RID: 4008
		private const string KEY_PREFIX = "DropShowPlanById";

		// Token: 0x04000FA9 RID: 4009
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FAA RID: 4010
		private static int HandleId;
	}
}
