using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000285 RID: 645
	public class ConfigEntrustRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F23 RID: 3875 RVA: 0x000AF05F File Offset: 0x000AD25F
		static ConfigEntrustRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustRoleById.CreateStaticDefaultValue), new Action(ConfigEntrustRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000AF080 File Offset: 0x000AD280
		public static void CreateStaticDefaultValue()
		{
			ConfigEntrustRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntrustRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "EntrustRole"),
				new ValueTuple<string, object>("语句", "select BinData from `EntrustRole` where Id=?")
			});
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000AF0FF File Offset: 0x000AD2FF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustRoleById.LogPair = null;
			ConfigEntrustRoleById.HandleId = 0;
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x000AF10D File Offset: 0x000AD30D
		public static void Init()
		{
			ConfigEntrustRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustRoleById.HandleId, "db_moonchasing.db", "select BinData from `EntrustRole` where Id=?");
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000AF128 File Offset: 0x000AD328
		public static EntrustRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntrustRoleById.HandleId, ConfigEntrustRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntrustRole?(EntrustRole.GetRootAsEntrustRole(configBuffer));
				}
			}
			ConfigEntrustRoleById.LogPair.Clear();
			ConfigEntrustRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEntrustRoleById.HandleId, 1, p0Id, ConfigEntrustRoleById.LogPair) || ConfigCommon.Step(ConfigEntrustRoleById.HandleId, true, ConfigEntrustRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntrustRoleById.HandleId, ConfigEntrustRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntrustRoleById.HandleId, 0, ConfigEntrustRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntrustRoleById.HandleId, ConfigEntrustRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntrustRole rootAsEntrustRole = EntrustRole.GetRootAsEntrustRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntrustRoleById.HandleId, ConfigEntrustRoleById.LogPair);
			return new EntrustRole?(rootAsEntrustRole);
		}

		// Token: 0x04001187 RID: 4487
		private const string DB = "db_moonchasing.db";

		// Token: 0x04001188 RID: 4488
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04001189 RID: 4489
		private const string TABLE = "EntrustRole";

		// Token: 0x0400118A RID: 4490
		private const string COMMAND = "select BinData from `EntrustRole` where Id=?";

		// Token: 0x0400118B RID: 4491
		private const string KEY_PREFIX = "EntrustRoleById";

		// Token: 0x0400118C RID: 4492
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400118D RID: 4493
		private static int HandleId;
	}
}
