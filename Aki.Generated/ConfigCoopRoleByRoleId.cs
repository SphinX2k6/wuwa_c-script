using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B5 RID: 437
	public class ConfigCoopRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x00097008 File Offset: 0x00095208
		static ConfigCoopRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigCoopRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00097028 File Offset: 0x00095228
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopRole"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopRole` where Id=?")
			});
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000970A7 File Offset: 0x000952A7
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleByRoleId.LogPair = null;
			ConfigCoopRoleByRoleId.HandleId = 0;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000970B5 File Offset: 0x000952B5
		public static void Init()
		{
			ConfigCoopRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleByRoleId.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRole` where Id=?");
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000970D0 File Offset: 0x000952D0
		public static CoopRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopRoleByRoleId.HandleId, ConfigCoopRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CoopRole?(CoopRole.GetRootAsCoopRole(configBuffer));
				}
			}
			ConfigCoopRoleByRoleId.LogPair.Clear();
			ConfigCoopRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCoopRoleByRoleId.HandleId, 1, p0Id, ConfigCoopRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigCoopRoleByRoleId.HandleId, true, ConfigCoopRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCoopRoleByRoleId.HandleId, ConfigCoopRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopRoleByRoleId.HandleId, 0, ConfigCoopRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCoopRoleByRoleId.HandleId, ConfigCoopRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CoopRole rootAsCoopRole = CoopRole.GetRootAsCoopRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCoopRoleByRoleId.HandleId, ConfigCoopRoleByRoleId.LogPair);
			return new CoopRole?(rootAsCoopRole);
		}

		// Token: 0x04000BD7 RID: 3031
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BD8 RID: 3032
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BD9 RID: 3033
		private const string TABLE = "CoopRole";

		// Token: 0x04000BDA RID: 3034
		private const string COMMAND = "select BinData from `CoopRole` where Id=?";

		// Token: 0x04000BDB RID: 3035
		private const string KEY_PREFIX = "CoopRoleByRoleId";

		// Token: 0x04000BDC RID: 3036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BDD RID: 3037
		private static int HandleId;
	}
}
