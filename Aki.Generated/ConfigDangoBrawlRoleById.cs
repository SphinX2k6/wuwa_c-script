using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DD RID: 477
	public class ConfigDangoBrawlRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x00098D6F File Offset: 0x00096F6F
		static ConfigDangoBrawlRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRoleById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00098D90 File Offset: 0x00096F90
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlRole"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlRole` where Id=?")
			});
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00098E0F File Offset: 0x0009700F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRoleById.LogPair = null;
			ConfigDangoBrawlRoleById.HandleId = 0;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00098E1D File Offset: 0x0009701D
		public static void Init()
		{
			ConfigDangoBrawlRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRoleById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlRole` where Id=?");
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00098E38 File Offset: 0x00097038
		public static DangoBrawlRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlRole?(DangoBrawlRole.GetRootAsDangoBrawlRole(configBuffer));
				}
			}
			ConfigDangoBrawlRoleById.LogPair.Clear();
			ConfigDangoBrawlRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRoleById.HandleId, 1, p0Id, ConfigDangoBrawlRoleById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRoleById.HandleId, true, ConfigDangoBrawlRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRoleById.HandleId, 0, ConfigDangoBrawlRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlRole rootAsDangoBrawlRole = DangoBrawlRole.GetRootAsDangoBrawlRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRoleById.HandleId, ConfigDangoBrawlRoleById.LogPair);
			return new DangoBrawlRole?(rootAsDangoBrawlRole);
		}

		// Token: 0x04000CEF RID: 3311
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CF0 RID: 3312
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CF1 RID: 3313
		private const string TABLE = "DangoBrawlRole";

		// Token: 0x04000CF2 RID: 3314
		private const string COMMAND = "select BinData from `DangoBrawlRole` where Id=?";

		// Token: 0x04000CF3 RID: 3315
		private const string KEY_PREFIX = "DangoBrawlRoleById";

		// Token: 0x04000CF4 RID: 3316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CF5 RID: 3317
		private static int HandleId;
	}
}
