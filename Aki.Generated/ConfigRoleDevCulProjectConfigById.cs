using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AD RID: 2221
	public class ConfigRoleDevCulProjectConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003420 RID: 13344 RVA: 0x00183847 File Offset: 0x00181A47
		static ConfigRoleDevCulProjectConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCulProjectConfigById.CreateStaticDefaultValue), new Action(ConfigRoleDevCulProjectConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00183868 File Offset: 0x00181A68
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevCulProjectConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevCulProjectConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevCulProjectConfig` where Id=?")
			});
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x001838E7 File Offset: 0x00181AE7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigById.LogPair = null;
			ConfigRoleDevCulProjectConfigById.HandleId = 0;
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x001838F5 File Offset: 0x00181AF5
		public static void Init()
		{
			ConfigRoleDevCulProjectConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCulProjectConfigById.HandleId, "db_roledev.db", "select BinData from `RoleDevCulProjectConfig` where Id=?");
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x00183910 File Offset: 0x00181B10
		public static RoleDevCulProjectConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCulProjectConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevCulProjectConfig?(RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(configBuffer));
				}
			}
			ConfigRoleDevCulProjectConfigById.LogPair.Clear();
			ConfigRoleDevCulProjectConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleDevCulProjectConfigById.HandleId, 1, p0Id, ConfigRoleDevCulProjectConfigById.LogPair) || ConfigCommon.Step(ConfigRoleDevCulProjectConfigById.HandleId, true, ConfigRoleDevCulProjectConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevCulProjectConfigById.HandleId, 0, ConfigRoleDevCulProjectConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevCulProjectConfig rootAsRoleDevCulProjectConfig = RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCulProjectConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
			return new RoleDevCulProjectConfig?(rootAsRoleDevCulProjectConfig);
		}

		// Token: 0x04003CA1 RID: 15521
		private const string DB = "db_roledev.db";

		// Token: 0x04003CA2 RID: 15522
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CA3 RID: 15523
		private const string TABLE = "RoleDevCulProjectConfig";

		// Token: 0x04003CA4 RID: 15524
		private const string COMMAND = "select BinData from `RoleDevCulProjectConfig` where Id=?";

		// Token: 0x04003CA5 RID: 15525
		private const string KEY_PREFIX = "RoleDevCulProjectConfigById";

		// Token: 0x04003CA6 RID: 15526
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CA7 RID: 15527
		private static int HandleId;
	}
}
