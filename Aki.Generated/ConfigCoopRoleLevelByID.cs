using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A5 RID: 421
	public class ConfigCoopRoleLevelByID : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x000915A7 File Offset: 0x0008F7A7
		static ConfigCoopRoleLevelByID()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleLevelByID.CreateStaticDefaultValue), new Action(ConfigCoopRoleLevelByID.ResetStaticDefaultValue));
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000915C8 File Offset: 0x0008F7C8
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

		// Token: 0x060009E3 RID: 2531 RVA: 0x00091647 File Offset: 0x0008F847
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleLevelByID.LogPair = null;
			ConfigCoopRoleLevelByID.HandleId = 0;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00091655 File Offset: 0x0008F855
		public static void Init()
		{
			ConfigCoopRoleLevelByID.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleLevelByID.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRoleLevel` where Id=?");
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00091670 File Offset: 0x0008F870
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

		// Token: 0x04000B67 RID: 2919
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B68 RID: 2920
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B69 RID: 2921
		private const string TABLE = "CoopRoleLevel";

		// Token: 0x04000B6A RID: 2922
		private const string COMMAND = "select BinData from `CoopRoleLevel` where Id=?";

		// Token: 0x04000B6B RID: 2923
		private const string KEY_PREFIX = "CoopRoleLevelByID";

		// Token: 0x04000B6C RID: 2924
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B6D RID: 2925
		private static int HandleId;
	}
}
