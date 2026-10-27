using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000507 RID: 1287
	public class ConfigMainRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x00103EAF File Offset: 0x001020AF
		static ConfigMainRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigById.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00103ED0 File Offset: 0x001020D0
		public static void CreateStaticDefaultValue()
		{
			ConfigMainRoleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainRoleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_main_role_change.db"),
				new ValueTuple<string, object>("文件", "z.主角切换.xlsx"),
				new ValueTuple<string, object>("表名", "MainRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MainRoleConfig` where Id = ?")
			});
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00103F4F File Offset: 0x0010214F
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigById.LogPair = null;
			ConfigMainRoleConfigById.HandleId = 0;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00103F5D File Offset: 0x0010215D
		public static void Init()
		{
			ConfigMainRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigById.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig` where Id = ?");
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00103F78 File Offset: 0x00102178
		public static MainRoleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MainRoleConfig?(MainRoleConfig.GetRootAsMainRoleConfig(configBuffer));
				}
			}
			ConfigMainRoleConfigById.LogPair.Clear();
			ConfigMainRoleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMainRoleConfigById.HandleId, 1, p0Id, ConfigMainRoleConfigById.LogPair) || ConfigCommon.Step(ConfigMainRoleConfigById.HandleId, true, ConfigMainRoleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainRoleConfigById.HandleId, 0, ConfigMainRoleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MainRoleConfig rootAsMainRoleConfig = MainRoleConfig.GetRootAsMainRoleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMainRoleConfigById.HandleId, ConfigMainRoleConfigById.LogPair);
			return new MainRoleConfig?(rootAsMainRoleConfig);
		}

		// Token: 0x04002315 RID: 8981
		private const string DB = "db_main_role_change.db";

		// Token: 0x04002316 RID: 8982
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x04002317 RID: 8983
		private const string TABLE = "MainRoleConfig";

		// Token: 0x04002318 RID: 8984
		private const string COMMAND = "select BinData from `MainRoleConfig` where Id = ?";

		// Token: 0x04002319 RID: 8985
		private const string KEY_PREFIX = "MainRoleConfigById";

		// Token: 0x0400231A RID: 8986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400231B RID: 8987
		private static int HandleId;
	}
}
