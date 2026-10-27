using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000901 RID: 2305
	public class ConfigSelectRoleItemPerformanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003619 RID: 13849 RVA: 0x0018B294 File Offset: 0x00189494
		static ConfigSelectRoleItemPerformanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSelectRoleItemPerformanceById.CreateStaticDefaultValue), new Action(ConfigSelectRoleItemPerformanceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0018B2B4 File Offset: 0x001894B4
		public static void CreateStaticDefaultValue()
		{
			ConfigSelectRoleItemPerformanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSelectRoleItemPerformanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleselectperformance.db"),
				new ValueTuple<string, object>("文件", "z.自选道具表现.xlsx"),
				new ValueTuple<string, object>("表名", "SelectRoleItemPerformance"),
				new ValueTuple<string, object>("语句", "select BinData from `SelectRoleItemPerformance` where Id=?")
			});
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0018B333 File Offset: 0x00189533
		public static void ResetStaticDefaultValue()
		{
			ConfigSelectRoleItemPerformanceById.LogPair = null;
			ConfigSelectRoleItemPerformanceById.HandleId = 0;
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0018B341 File Offset: 0x00189541
		public static void Init()
		{
			ConfigSelectRoleItemPerformanceById.HandleId = ConfigCommon.InitDataStatement(ConfigSelectRoleItemPerformanceById.HandleId, "db_roleselectperformance.db", "select BinData from `SelectRoleItemPerformance` where Id=?");
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0018B35C File Offset: 0x0018955C
		public static SelectRoleItemPerformance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSelectRoleItemPerformanceById.HandleId, ConfigSelectRoleItemPerformanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SelectRoleItemPerformanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SelectRoleItemPerformance?(SelectRoleItemPerformance.GetRootAsSelectRoleItemPerformance(configBuffer));
				}
			}
			ConfigSelectRoleItemPerformanceById.LogPair.Clear();
			ConfigSelectRoleItemPerformanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSelectRoleItemPerformanceById.HandleId, 1, p0Id, ConfigSelectRoleItemPerformanceById.LogPair) || ConfigCommon.Step(ConfigSelectRoleItemPerformanceById.HandleId, true, ConfigSelectRoleItemPerformanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSelectRoleItemPerformanceById.HandleId, ConfigSelectRoleItemPerformanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSelectRoleItemPerformanceById.HandleId, 0, ConfigSelectRoleItemPerformanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSelectRoleItemPerformanceById.HandleId, ConfigSelectRoleItemPerformanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SelectRoleItemPerformance rootAsSelectRoleItemPerformance = SelectRoleItemPerformance.GetRootAsSelectRoleItemPerformance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SelectRoleItemPerformanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSelectRoleItemPerformanceById.HandleId, ConfigSelectRoleItemPerformanceById.LogPair);
			return new SelectRoleItemPerformance?(rootAsSelectRoleItemPerformance);
		}

		// Token: 0x04003EED RID: 16109
		private const string DB = "db_roleselectperformance.db";

		// Token: 0x04003EEE RID: 16110
		private const string FILE = "z.自选道具表现.xlsx";

		// Token: 0x04003EEF RID: 16111
		private const string TABLE = "SelectRoleItemPerformance";

		// Token: 0x04003EF0 RID: 16112
		private const string COMMAND = "select BinData from `SelectRoleItemPerformance` where Id=?";

		// Token: 0x04003EF1 RID: 16113
		private const string KEY_PREFIX = "SelectRoleItemPerformanceById";

		// Token: 0x04003EF2 RID: 16114
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EF3 RID: 16115
		private static int HandleId;
	}
}
