using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D1 RID: 2257
	public class ConfigRoleTrialActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034F9 RID: 13561 RVA: 0x00184C5C File Offset: 0x00182E5C
		static ConfigRoleTrialActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialActivityById.CreateStaticDefaultValue), new Action(ConfigRoleTrialActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00184C7C File Offset: 0x00182E7C
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

		// Token: 0x060034FB RID: 13563 RVA: 0x00184CFB File Offset: 0x00182EFB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialActivityById.LogPair = null;
			ConfigRoleTrialActivityById.HandleId = 0;
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00184D09 File Offset: 0x00182F09
		public static void Init()
		{
			ConfigRoleTrialActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialActivityById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialActivity` where Id=?");
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00184D24 File Offset: 0x00182F24
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

		// Token: 0x04003D9D RID: 15773
		private const string DB = "db_roletrial.db";

		// Token: 0x04003D9E RID: 15774
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003D9F RID: 15775
		private const string TABLE = "RoleTrialActivity";

		// Token: 0x04003DA0 RID: 15776
		private const string COMMAND = "select BinData from `RoleTrialActivity` where Id=?";

		// Token: 0x04003DA1 RID: 15777
		private const string KEY_PREFIX = "RoleTrialActivityById";

		// Token: 0x04003DA2 RID: 15778
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DA3 RID: 15779
		private static int HandleId;
	}
}
