using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B7 RID: 439
	public class ConfigCoopRoleLevelByID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x000974DF File Offset: 0x000956DF
		static ConfigCoopRoleLevelByID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleLevelByID.CreateStaticDefaultValue), new Action(ConfigCoopRoleLevelByID.ResetStaticDefaultValue));
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00097500 File Offset: 0x00095700
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopRoleLevelByID.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopRoleLevelByID.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopRoleLevel` where Id=?")
			});
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0009757F File Offset: 0x0009577F
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleLevelByID.LogPair = null;
			ConfigCoopRoleLevelByID.HandleId = 0;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0009758D File Offset: 0x0009578D
		public static void Init()
		{
			ConfigCoopRoleLevelByID.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleLevelByID.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRoleLevel` where Id=?");
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000975A8 File Offset: 0x000957A8
		public static CoopRoleLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopRoleLevelByID.HandleId, ConfigCoopRoleLevelByID.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleLevelByID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CoopRoleLevel?(CoopRoleLevel.GetRootAsCoopRoleLevel(configBuffer));
				}
			}
			ConfigCoopRoleLevelByID.LogPair.Clear();
			ConfigCoopRoleLevelByID.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCoopRoleLevelByID.HandleId, 1, p0Id, ConfigCoopRoleLevelByID.LogPair) || ConfigCommon.Step(ConfigCoopRoleLevelByID.HandleId, true, ConfigCoopRoleLevelByID.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCoopRoleLevelByID.HandleId, ConfigCoopRoleLevelByID.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopRoleLevelByID.HandleId, 0, ConfigCoopRoleLevelByID.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCoopRoleLevelByID.HandleId, ConfigCoopRoleLevelByID.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CoopRoleLevel rootAsCoopRoleLevel = CoopRoleLevel.GetRootAsCoopRoleLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleLevelByID");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCoopRoleLevelByID.HandleId, ConfigCoopRoleLevelByID.LogPair);
			return new CoopRoleLevel?(rootAsCoopRoleLevel);
		}

		// Token: 0x04000BE5 RID: 3045
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BE6 RID: 3046
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BE7 RID: 3047
		private const string TABLE = "CoopRoleLevel";

		// Token: 0x04000BE8 RID: 3048
		private const string COMMAND = "select BinData from `CoopRoleLevel` where Id=?";

		// Token: 0x04000BE9 RID: 3049
		private const string KEY_PREFIX = "CoopRoleLevelByID";

		// Token: 0x04000BEA RID: 3050
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BEB RID: 3051
		private static int HandleId;
	}
}
