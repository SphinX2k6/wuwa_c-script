using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000899 RID: 2201
	public class ConfigRoleDevLevelLimitByProjectNum : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033A8 RID: 13224 RVA: 0x0017D573 File Offset: 0x0017B773
		static ConfigRoleDevLevelLimitByProjectNum()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevLevelLimitByProjectNum.CreateStaticDefaultValue), new Action(ConfigRoleDevLevelLimitByProjectNum.ResetStaticDefaultValue));
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x0017D594 File Offset: 0x0017B794
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

		// Token: 0x060033AA RID: 13226 RVA: 0x0017D613 File Offset: 0x0017B813
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitByProjectNum.LogPair = null;
			ConfigRoleDevLevelLimitByProjectNum.HandleId = 0;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x0017D621 File Offset: 0x0017B821
		public static void Init()
		{
			ConfigRoleDevLevelLimitByProjectNum.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevLevelLimitByProjectNum.HandleId, "db_roledev.db", "select BinData from `RoleDevLevelLimit` where ProjectNum=?");
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x0017D63C File Offset: 0x0017B83C
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

		// Token: 0x04003C15 RID: 15381
		private const string DB = "db_roledev.db";

		// Token: 0x04003C16 RID: 15382
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C17 RID: 15383
		private const string TABLE = "RoleDevLevelLimit";

		// Token: 0x04003C18 RID: 15384
		private const string COMMAND = "select BinData from `RoleDevLevelLimit` where ProjectNum=?";

		// Token: 0x04003C19 RID: 15385
		private const string KEY_PREFIX = "RoleDevLevelLimitByProjectNum";

		// Token: 0x04003C1A RID: 15386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C1B RID: 15387
		private static int HandleId;
	}
}
