using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094C RID: 2380
	public class ConfigSelectRoleItemPerformanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037DB RID: 14299 RVA: 0x001984B4 File Offset: 0x001966B4
		static ConfigSelectRoleItemPerformanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSelectRoleItemPerformanceById.CreateStaticDefaultValue), new Action(ConfigSelectRoleItemPerformanceById.ResetStaticDefaultValue));
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x001984D4 File Offset: 0x001966D4
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

		// Token: 0x060037DD RID: 14301 RVA: 0x00198553 File Offset: 0x00196753
		public static void ResetStaticDefaultValue()
		{
			ConfigSelectRoleItemPerformanceById.LogPair = null;
			ConfigSelectRoleItemPerformanceById.HandleId = 0;
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x00198561 File Offset: 0x00196761
		public static void Init()
		{
			ConfigSelectRoleItemPerformanceById.HandleId = ConfigCommon.InitDataStatement(ConfigSelectRoleItemPerformanceById.HandleId, "db_roleselectperformance.db", "select BinData from `SelectRoleItemPerformance` where Id=?");
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x0019857C File Offset: 0x0019677C
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

		// Token: 0x040040FA RID: 16634
		private const string DB = "db_roleselectperformance.db";

		// Token: 0x040040FB RID: 16635
		private const string FILE = "z.自选道具表现.xlsx";

		// Token: 0x040040FC RID: 16636
		private const string TABLE = "SelectRoleItemPerformance";

		// Token: 0x040040FD RID: 16637
		private const string COMMAND = "select BinData from `SelectRoleItemPerformance` where Id=?";

		// Token: 0x040040FE RID: 16638
		private const string KEY_PREFIX = "SelectRoleItemPerformanceById";

		// Token: 0x040040FF RID: 16639
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004100 RID: 16640
		private static int HandleId;
	}
}
