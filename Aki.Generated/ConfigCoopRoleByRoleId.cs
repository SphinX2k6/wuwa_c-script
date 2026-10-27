using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A3 RID: 419
	public class ConfigCoopRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009D5 RID: 2517 RVA: 0x000910D0 File Offset: 0x0008F2D0
		static ConfigCoopRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigCoopRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000910F0 File Offset: 0x0008F2F0
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

		// Token: 0x060009D7 RID: 2519 RVA: 0x0009116F File Offset: 0x0008F36F
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleByRoleId.LogPair = null;
			ConfigCoopRoleByRoleId.HandleId = 0;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0009117D File Offset: 0x0008F37D
		public static void Init()
		{
			ConfigCoopRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleByRoleId.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRole` where Id=?");
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00091198 File Offset: 0x0008F398
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

		// Token: 0x04000B59 RID: 2905
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B5A RID: 2906
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B5B RID: 2907
		private const string TABLE = "CoopRole";

		// Token: 0x04000B5C RID: 2908
		private const string COMMAND = "select BinData from `CoopRole` where Id=?";

		// Token: 0x04000B5D RID: 2909
		private const string KEY_PREFIX = "CoopRoleByRoleId";

		// Token: 0x04000B5E RID: 2910
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B5F RID: 2911
		private static int HandleId;
	}
}
