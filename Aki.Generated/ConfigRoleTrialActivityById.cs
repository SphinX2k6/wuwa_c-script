using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091C RID: 2332
	public class ConfigRoleTrialActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036BB RID: 14011 RVA: 0x00191E7C File Offset: 0x0019007C
		static ConfigRoleTrialActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialActivityById.CreateStaticDefaultValue), new Action(ConfigRoleTrialActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00191E9C File Offset: 0x0019009C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTrialActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTrialActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletrial.db"),
				new ValueTuple<string, object>("文件", "j.角色试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTrialActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTrialActivity` where Id=?")
			});
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00191F1B File Offset: 0x0019011B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialActivityById.LogPair = null;
			ConfigRoleTrialActivityById.HandleId = 0;
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00191F29 File Offset: 0x00190129
		public static void Init()
		{
			ConfigRoleTrialActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialActivityById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialActivity` where Id=?");
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00191F44 File Offset: 0x00190144
		public static RoleTrialActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTrialActivityById.HandleId, ConfigRoleTrialActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTrialActivity?(RoleTrialActivity.GetRootAsRoleTrialActivity(configBuffer));
				}
			}
			ConfigRoleTrialActivityById.LogPair.Clear();
			ConfigRoleTrialActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTrialActivityById.HandleId, 1, p0Id, ConfigRoleTrialActivityById.LogPair) || ConfigCommon.Step(ConfigRoleTrialActivityById.HandleId, true, ConfigRoleTrialActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTrialActivityById.HandleId, ConfigRoleTrialActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTrialActivityById.HandleId, 0, ConfigRoleTrialActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTrialActivityById.HandleId, ConfigRoleTrialActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTrialActivity rootAsRoleTrialActivity = RoleTrialActivity.GetRootAsRoleTrialActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTrialActivityById.HandleId, ConfigRoleTrialActivityById.LogPair);
			return new RoleTrialActivity?(rootAsRoleTrialActivity);
		}

		// Token: 0x04003FAA RID: 16298
		private const string DB = "db_roletrial.db";

		// Token: 0x04003FAB RID: 16299
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003FAC RID: 16300
		private const string TABLE = "RoleTrialActivity";

		// Token: 0x04003FAD RID: 16301
		private const string COMMAND = "select BinData from `RoleTrialActivity` where Id=?";

		// Token: 0x04003FAE RID: 16302
		private const string KEY_PREFIX = "RoleTrialActivityById";

		// Token: 0x04003FAF RID: 16303
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FB0 RID: 16304
		private static int HandleId;
	}
}
