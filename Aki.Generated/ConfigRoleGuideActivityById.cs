using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C6 RID: 2246
	public class ConfigRoleGuideActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034B7 RID: 13495 RVA: 0x00186BA0 File Offset: 0x00184DA0
		static ConfigRoleGuideActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleGuideActivityById.CreateStaticDefaultValue), new Action(ConfigRoleGuideActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00186BC0 File Offset: 0x00184DC0
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

		// Token: 0x060034B9 RID: 13497 RVA: 0x00186C3F File Offset: 0x00184E3F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleGuideActivityById.LogPair = null;
			ConfigRoleGuideActivityById.HandleId = 0;
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x00186C4D File Offset: 0x00184E4D
		public static void Init()
		{
			ConfigRoleGuideActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleGuideActivityById.HandleId, "db_roleguideactivity.db", "select BinData from `RoleGuideActivity` where Id=?");
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00186C68 File Offset: 0x00184E68
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

		// Token: 0x04003D50 RID: 15696
		private const string DB = "db_roleguideactivity.db";

		// Token: 0x04003D51 RID: 15697
		private const string FILE = "j.角色引导活动.xlsx";

		// Token: 0x04003D52 RID: 15698
		private const string TABLE = "RoleGuideActivity";

		// Token: 0x04003D53 RID: 15699
		private const string COMMAND = "select BinData from `RoleGuideActivity` where Id=?";

		// Token: 0x04003D54 RID: 15700
		private const string KEY_PREFIX = "RoleGuideActivityById";

		// Token: 0x04003D55 RID: 15701
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D56 RID: 15702
		private static int HandleId;
	}
}
