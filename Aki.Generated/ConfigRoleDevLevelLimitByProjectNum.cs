using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B5 RID: 2229
	public class ConfigRoleDevLevelLimitByProjectNum : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003450 RID: 13392 RVA: 0x0018485B File Offset: 0x00182A5B
		static ConfigRoleDevLevelLimitByProjectNum()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevLevelLimitByProjectNum.CreateStaticDefaultValue), new Action(ConfigRoleDevLevelLimitByProjectNum.ResetStaticDefaultValue));
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x0018487C File Offset: 0x00182A7C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitByProjectNum.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevLevelLimitByProjectNum.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevLevelLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevLevelLimit` where ProjectNum=?")
			});
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x001848FB File Offset: 0x00182AFB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitByProjectNum.LogPair = null;
			ConfigRoleDevLevelLimitByProjectNum.HandleId = 0;
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00184909 File Offset: 0x00182B09
		public static void Init()
		{
			ConfigRoleDevLevelLimitByProjectNum.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevLevelLimitByProjectNum.HandleId, "db_roledev.db", "select BinData from `RoleDevLevelLimit` where ProjectNum=?");
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00184924 File Offset: 0x00182B24
		public static RoleDevLevelLimit? GetConfig(int p0ProjectNum, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevLevelLimitByProjectNum.HandleId, ConfigRoleDevLevelLimitByProjectNum.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevLevelLimitByProjectNum");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectNum);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevLevelLimit?(RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(configBuffer));
				}
			}
			ConfigRoleDevLevelLimitByProjectNum.LogPair.Clear();
			ConfigRoleDevLevelLimitByProjectNum.LogPair.Add(new ValueTuple<string, object>("ProjectNum", p0ProjectNum));
			if (!ConfigCommon.BindInt(ConfigRoleDevLevelLimitByProjectNum.HandleId, 1, p0ProjectNum, ConfigRoleDevLevelLimitByProjectNum.LogPair) || ConfigCommon.Step(ConfigRoleDevLevelLimitByProjectNum.HandleId, true, ConfigRoleDevLevelLimitByProjectNum.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevLevelLimitByProjectNum.HandleId, ConfigRoleDevLevelLimitByProjectNum.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevLevelLimitByProjectNum.HandleId, 0, ConfigRoleDevLevelLimitByProjectNum.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevLevelLimitByProjectNum.HandleId, ConfigRoleDevLevelLimitByProjectNum.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevLevelLimit rootAsRoleDevLevelLimit = RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevLevelLimitByProjectNum");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectNum);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevLevelLimitByProjectNum.HandleId, ConfigRoleDevLevelLimitByProjectNum.LogPair);
			return new RoleDevLevelLimit?(rootAsRoleDevLevelLimit);
		}

		// Token: 0x04003CD9 RID: 15577
		private const string DB = "db_roledev.db";

		// Token: 0x04003CDA RID: 15578
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CDB RID: 15579
		private const string TABLE = "RoleDevLevelLimit";

		// Token: 0x04003CDC RID: 15580
		private const string COMMAND = "select BinData from `RoleDevLevelLimit` where ProjectNum=?";

		// Token: 0x04003CDD RID: 15581
		private const string KEY_PREFIX = "RoleDevLevelLimitByProjectNum";

		// Token: 0x04003CDE RID: 15582
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CDF RID: 15583
		private static int HandleId;
	}
}
