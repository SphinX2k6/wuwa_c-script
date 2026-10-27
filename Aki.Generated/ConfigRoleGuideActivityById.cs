using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AA RID: 2218
	public class ConfigRoleGuideActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600340F RID: 13327 RVA: 0x0017F8B8 File Offset: 0x0017DAB8
		static ConfigRoleGuideActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGuideActivityById.CreateStaticDefaultValue), new Action(ConfigRoleGuideActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x0017F8D8 File Offset: 0x0017DAD8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleGuideActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleGuideActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleguideactivity.db"),
				new ValueTuple<string, object>("文件", "j.角色引导活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleGuideActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleGuideActivity` where Id=?")
			});
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0017F957 File Offset: 0x0017DB57
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGuideActivityById.LogPair = null;
			ConfigRoleGuideActivityById.HandleId = 0;
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x0017F965 File Offset: 0x0017DB65
		public static void Init()
		{
			ConfigRoleGuideActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGuideActivityById.HandleId, "db_roleguideactivity.db", "select BinData from `RoleGuideActivity` where Id=?");
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0017F980 File Offset: 0x0017DB80
		public static RoleGuideActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleGuideActivityById.HandleId, ConfigRoleGuideActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGuideActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleGuideActivity?(RoleGuideActivity.GetRootAsRoleGuideActivity(configBuffer));
				}
			}
			ConfigRoleGuideActivityById.LogPair.Clear();
			ConfigRoleGuideActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleGuideActivityById.HandleId, 1, p0Id, ConfigRoleGuideActivityById.LogPair) || ConfigCommon.Step(ConfigRoleGuideActivityById.HandleId, true, ConfigRoleGuideActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleGuideActivityById.HandleId, ConfigRoleGuideActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleGuideActivityById.HandleId, 0, ConfigRoleGuideActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleGuideActivityById.HandleId, ConfigRoleGuideActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleGuideActivity rootAsRoleGuideActivity = RoleGuideActivity.GetRootAsRoleGuideActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleGuideActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleGuideActivityById.HandleId, ConfigRoleGuideActivityById.LogPair);
			return new RoleGuideActivity?(rootAsRoleGuideActivity);
		}

		// Token: 0x04003C8C RID: 15500
		private const string DB = "db_roleguideactivity.db";

		// Token: 0x04003C8D RID: 15501
		private const string FILE = "j.角色引导活动.xlsx";

		// Token: 0x04003C8E RID: 15502
		private const string TABLE = "RoleGuideActivity";

		// Token: 0x04003C8F RID: 15503
		private const string COMMAND = "select BinData from `RoleGuideActivity` where Id=?";

		// Token: 0x04003C90 RID: 15504
		private const string KEY_PREFIX = "RoleGuideActivityById";

		// Token: 0x04003C91 RID: 15505
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C92 RID: 15506
		private static int HandleId;
	}
}
