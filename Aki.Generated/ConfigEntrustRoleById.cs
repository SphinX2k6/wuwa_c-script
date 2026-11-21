using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000299 RID: 665
	public class ConfigEntrustRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x000B5323 File Offset: 0x000B3523
		static ConfigEntrustRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustRoleById.CreateStaticDefaultValue), new Action(ConfigEntrustRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000B5344 File Offset: 0x000B3544
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

		// Token: 0x06000F9D RID: 3997 RVA: 0x000B53C3 File Offset: 0x000B35C3
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustRoleById.LogPair = null;
			ConfigEntrustRoleById.HandleId = 0;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000B53D1 File Offset: 0x000B35D1
		public static void Init()
		{
			ConfigEntrustRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustRoleById.HandleId, "db_moonchasing.db", "select BinData from `EntrustRole` where Id=?");
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000B53EC File Offset: 0x000B35EC
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

		// Token: 0x04001213 RID: 4627
		private const string DB = "db_moonchasing.db";

		// Token: 0x04001214 RID: 4628
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04001215 RID: 4629
		private const string TABLE = "EntrustRole";

		// Token: 0x04001216 RID: 4630
		private const string COMMAND = "select BinData from `EntrustRole` where Id=?";

		// Token: 0x04001217 RID: 4631
		private const string KEY_PREFIX = "EntrustRoleById";

		// Token: 0x04001218 RID: 4632
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001219 RID: 4633
		private static int HandleId;
	}
}
