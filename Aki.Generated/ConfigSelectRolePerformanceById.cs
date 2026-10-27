using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000902 RID: 2306
	public class ConfigSelectRolePerformanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600361F RID: 13855 RVA: 0x0018B4DC File Offset: 0x001896DC
		static ConfigSelectRolePerformanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSelectRolePerformanceById.CreateStaticDefaultValue), new Action(ConfigSelectRolePerformanceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0018B4FC File Offset: 0x001896FC
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

		// Token: 0x06003621 RID: 13857 RVA: 0x0018B57B File Offset: 0x0018977B
		public static void ResetStaticDefaultValue()
		{
			ConfigSelectRolePerformanceById.LogPair = null;
			ConfigSelectRolePerformanceById.HandleId = 0;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0018B589 File Offset: 0x00189789
		public static void Init()
		{
			ConfigSelectRolePerformanceById.HandleId = ConfigCommon.InitDataStatement(ConfigSelectRolePerformanceById.HandleId, "db_roleselectperformance.db", "select BinData from `SelectRolePerformance` where Id=?");
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0018B5A4 File Offset: 0x001897A4
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

		// Token: 0x04003EF4 RID: 16116
		private const string DB = "db_roleselectperformance.db";

		// Token: 0x04003EF5 RID: 16117
		private const string FILE = "z.自选道具表现.xlsx";

		// Token: 0x04003EF6 RID: 16118
		private const string TABLE = "SelectRolePerformance";

		// Token: 0x04003EF7 RID: 16119
		private const string COMMAND = "select BinData from `SelectRolePerformance` where Id=?";

		// Token: 0x04003EF8 RID: 16120
		private const string KEY_PREFIX = "SelectRolePerformanceById";

		// Token: 0x04003EF9 RID: 16121
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EFA RID: 16122
		private static int HandleId;
	}
}
