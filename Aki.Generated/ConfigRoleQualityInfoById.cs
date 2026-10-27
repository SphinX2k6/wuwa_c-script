using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BC RID: 2236
	public class ConfigRoleQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600347B RID: 13435 RVA: 0x00181DC9 File Offset: 0x0017FFC9
		static ConfigRoleQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQualityInfoById.CreateStaticDefaultValue), new Action(ConfigRoleQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00181DE8 File Offset: 0x0017FFE8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleQualityInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleQualityInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleQualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleQualityInfo` where Id=?")
			});
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00181E67 File Offset: 0x00180067
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQualityInfoById.LogPair = null;
			ConfigRoleQualityInfoById.HandleId = 0;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00181E75 File Offset: 0x00180075
		public static void Init()
		{
			ConfigRoleQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQualityInfoById.HandleId, "db_role.db", "select BinData from `RoleQualityInfo` where Id=?");
		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00181E90 File Offset: 0x00180090
		public static RoleQualityInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleQualityInfo?(RoleQualityInfo.GetRootAsRoleQualityInfo(configBuffer));
				}
			}
			ConfigRoleQualityInfoById.LogPair.Clear();
			ConfigRoleQualityInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleQualityInfoById.HandleId, 1, p0Id, ConfigRoleQualityInfoById.LogPair) || ConfigCommon.Step(ConfigRoleQualityInfoById.HandleId, true, ConfigRoleQualityInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleQualityInfoById.HandleId, 0, ConfigRoleQualityInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleQualityInfo rootAsRoleQualityInfo = RoleQualityInfo.GetRootAsRoleQualityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleQualityInfoById.HandleId, ConfigRoleQualityInfoById.LogPair);
			return new RoleQualityInfo?(rootAsRoleQualityInfo);
		}

		// Token: 0x04003D0A RID: 15626
		private const string DB = "db_role.db";

		// Token: 0x04003D0B RID: 15627
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D0C RID: 15628
		private const string TABLE = "RoleQualityInfo";

		// Token: 0x04003D0D RID: 15629
		private const string COMMAND = "select BinData from `RoleQualityInfo` where Id=?";

		// Token: 0x04003D0E RID: 15630
		private const string KEY_PREFIX = "RoleQualityInfoById";

		// Token: 0x04003D0F RID: 15631
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D10 RID: 15632
		private static int HandleId;
	}
}
