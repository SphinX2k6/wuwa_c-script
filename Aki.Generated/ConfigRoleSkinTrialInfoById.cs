using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E7 RID: 2279
	public class ConfigRoleSkinTrialInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600357D RID: 13693 RVA: 0x0018B248 File Offset: 0x00189448
		static ConfigRoleSkinTrialInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialInfoById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x0018B268 File Offset: 0x00189468
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinTrialInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleskintrial.db"),
				new ValueTuple<string, object>("文件", "j.角色皮肤试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinTrialInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinTrialInfo` where Id=?")
			});
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x0018B2E7 File Offset: 0x001894E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoById.LogPair = null;
			ConfigRoleSkinTrialInfoById.HandleId = 0;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x0018B2F5 File Offset: 0x001894F5
		public static void Init()
		{
			ConfigRoleSkinTrialInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialInfoById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialInfo` where Id=?");
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x0018B310 File Offset: 0x00189510
		public static RoleSkinTrialInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinTrialInfo?(RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(configBuffer));
				}
			}
			ConfigRoleSkinTrialInfoById.LogPair.Clear();
			ConfigRoleSkinTrialInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinTrialInfoById.HandleId, 1, p0Id, ConfigRoleSkinTrialInfoById.LogPair) || ConfigCommon.Step(ConfigRoleSkinTrialInfoById.HandleId, true, ConfigRoleSkinTrialInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinTrialInfoById.HandleId, 0, ConfigRoleSkinTrialInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinTrialInfo rootAsRoleSkinTrialInfo = RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
			return new RoleSkinTrialInfo?(rootAsRoleSkinTrialInfo);
		}

		// Token: 0x04003E37 RID: 15927
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003E38 RID: 15928
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003E39 RID: 15929
		private const string TABLE = "RoleSkinTrialInfo";

		// Token: 0x04003E3A RID: 15930
		private const string COMMAND = "select BinData from `RoleSkinTrialInfo` where Id=?";

		// Token: 0x04003E3B RID: 15931
		private const string KEY_PREFIX = "RoleSkinTrialInfoById";

		// Token: 0x04003E3C RID: 15932
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E3D RID: 15933
		private static int HandleId;
	}
}
