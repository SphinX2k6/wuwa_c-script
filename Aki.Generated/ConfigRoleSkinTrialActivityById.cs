using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CA RID: 2250
	public class ConfigRoleSkinTrialActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034CF RID: 13519 RVA: 0x00183D19 File Offset: 0x00181F19
		static ConfigRoleSkinTrialActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialActivityById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00183D38 File Offset: 0x00181F38
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

		// Token: 0x060034D1 RID: 13521 RVA: 0x00183DB7 File Offset: 0x00181FB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialActivityById.LogPair = null;
			ConfigRoleSkinTrialActivityById.HandleId = 0;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00183DC5 File Offset: 0x00181FC5
		public static void Init()
		{
			ConfigRoleSkinTrialActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialActivityById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialActivity` where Id=?");
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00183DE0 File Offset: 0x00181FE0
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

		// Token: 0x04003D6C RID: 15724
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003D6D RID: 15725
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003D6E RID: 15726
		private const string TABLE = "RoleSkinTrialActivity";

		// Token: 0x04003D6F RID: 15727
		private const string COMMAND = "select BinData from `RoleSkinTrialActivity` where Id=?";

		// Token: 0x04003D70 RID: 15728
		private const string KEY_PREFIX = "RoleSkinTrialActivityById";

		// Token: 0x04003D71 RID: 15729
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D72 RID: 15730
		private static int HandleId;
	}
}
