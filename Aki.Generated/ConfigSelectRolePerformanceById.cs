using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094D RID: 2381
	public class ConfigSelectRolePerformanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037E1 RID: 14305 RVA: 0x001986FC File Offset: 0x001968FC
		static ConfigSelectRolePerformanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSelectRolePerformanceById.CreateStaticDefaultValue), new Action(ConfigSelectRolePerformanceById.ResetStaticDefaultValue));
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0019871C File Offset: 0x0019691C
		public static void CreateStaticDefaultValue()
		{
			ConfigSelectRolePerformanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSelectRolePerformanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleselectperformance.db"),
				new ValueTuple<string, object>("文件", "z.自选道具表现.xlsx"),
				new ValueTuple<string, object>("表名", "SelectRolePerformance"),
				new ValueTuple<string, object>("语句", "select BinData from `SelectRolePerformance` where Id=?")
			});
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x0019879B File Offset: 0x0019699B
		public static void ResetStaticDefaultValue()
		{
			ConfigSelectRolePerformanceById.LogPair = null;
			ConfigSelectRolePerformanceById.HandleId = 0;
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x001987A9 File Offset: 0x001969A9
		public static void Init()
		{
			ConfigSelectRolePerformanceById.HandleId = ConfigCommon.InitDataStatement(ConfigSelectRolePerformanceById.HandleId, "db_roleselectperformance.db", "select BinData from `SelectRolePerformance` where Id=?");
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x001987C4 File Offset: 0x001969C4
		public static SelectRolePerformance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSelectRolePerformanceById.HandleId, ConfigSelectRolePerformanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SelectRolePerformanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SelectRolePerformance?(SelectRolePerformance.GetRootAsSelectRolePerformance(configBuffer));
				}
			}
			ConfigSelectRolePerformanceById.LogPair.Clear();
			ConfigSelectRolePerformanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSelectRolePerformanceById.HandleId, 1, p0Id, ConfigSelectRolePerformanceById.LogPair) || ConfigCommon.Step(ConfigSelectRolePerformanceById.HandleId, true, ConfigSelectRolePerformanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSelectRolePerformanceById.HandleId, ConfigSelectRolePerformanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSelectRolePerformanceById.HandleId, 0, ConfigSelectRolePerformanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSelectRolePerformanceById.HandleId, ConfigSelectRolePerformanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SelectRolePerformance rootAsSelectRolePerformance = SelectRolePerformance.GetRootAsSelectRolePerformance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SelectRolePerformanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSelectRolePerformanceById.HandleId, ConfigSelectRolePerformanceById.LogPair);
			return new SelectRolePerformance?(rootAsSelectRolePerformance);
		}

		// Token: 0x04004101 RID: 16641
		private const string DB = "db_roleselectperformance.db";

		// Token: 0x04004102 RID: 16642
		private const string FILE = "z.自选道具表现.xlsx";

		// Token: 0x04004103 RID: 16643
		private const string TABLE = "SelectRolePerformance";

		// Token: 0x04004104 RID: 16644
		private const string COMMAND = "select BinData from `SelectRolePerformance` where Id=?";

		// Token: 0x04004105 RID: 16645
		private const string KEY_PREFIX = "SelectRolePerformanceById";

		// Token: 0x04004106 RID: 16646
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004107 RID: 16647
		private static int HandleId;
	}
}
