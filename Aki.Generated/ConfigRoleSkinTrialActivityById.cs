using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E6 RID: 2278
	public class ConfigRoleSkinTrialActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003577 RID: 13687 RVA: 0x0018B001 File Offset: 0x00189201
		static ConfigRoleSkinTrialActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialActivityById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0018B020 File Offset: 0x00189220
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinTrialActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinTrialActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleskintrial.db"),
				new ValueTuple<string, object>("文件", "j.角色皮肤试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinTrialActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinTrialActivity` where Id=?")
			});
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0018B09F File Offset: 0x0018929F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialActivityById.LogPair = null;
			ConfigRoleSkinTrialActivityById.HandleId = 0;
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0018B0AD File Offset: 0x001892AD
		public static void Init()
		{
			ConfigRoleSkinTrialActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialActivityById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialActivity` where Id=?");
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x0018B0C8 File Offset: 0x001892C8
		public static RoleSkinTrialActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinTrialActivityById.HandleId, ConfigRoleSkinTrialActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinTrialActivity?(RoleSkinTrialActivity.GetRootAsRoleSkinTrialActivity(configBuffer));
				}
			}
			ConfigRoleSkinTrialActivityById.LogPair.Clear();
			ConfigRoleSkinTrialActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinTrialActivityById.HandleId, 1, p0Id, ConfigRoleSkinTrialActivityById.LogPair) || ConfigCommon.Step(ConfigRoleSkinTrialActivityById.HandleId, true, ConfigRoleSkinTrialActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialActivityById.HandleId, ConfigRoleSkinTrialActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinTrialActivityById.HandleId, 0, ConfigRoleSkinTrialActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialActivityById.HandleId, ConfigRoleSkinTrialActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinTrialActivity rootAsRoleSkinTrialActivity = RoleSkinTrialActivity.GetRootAsRoleSkinTrialActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinTrialActivityById.HandleId, ConfigRoleSkinTrialActivityById.LogPair);
			return new RoleSkinTrialActivity?(rootAsRoleSkinTrialActivity);
		}

		// Token: 0x04003E30 RID: 15920
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003E31 RID: 15921
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003E32 RID: 15922
		private const string TABLE = "RoleSkinTrialActivity";

		// Token: 0x04003E33 RID: 15923
		private const string COMMAND = "select BinData from `RoleSkinTrialActivity` where Id=?";

		// Token: 0x04003E34 RID: 15924
		private const string KEY_PREFIX = "RoleSkinTrialActivityById";

		// Token: 0x04003E35 RID: 15925
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E36 RID: 15926
		private static int HandleId;
	}
}
