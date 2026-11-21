using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000839 RID: 2105
	public class ConfigRogueBossInstanceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003168 RID: 12648 RVA: 0x001740E0 File Offset: 0x001722E0
		static ConfigRogueBossInstanceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueBossInstanceById.CreateStaticDefaultValue), new Action(ConfigRogueBossInstanceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00174100 File Offset: 0x00172300
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueBossInstanceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueBossInstanceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueBossInstance"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueBossInstance` where Id=?")
			});
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0017417F File Offset: 0x0017237F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueBossInstanceById.LogPair = null;
			ConfigRogueBossInstanceById.HandleId = 0;
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x0017418D File Offset: 0x0017238D
		public static void Init()
		{
			ConfigRogueBossInstanceById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueBossInstanceById.HandleId, "db_dreamlink.db", "select BinData from `RogueBossInstance` where Id=?");
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x001741A8 File Offset: 0x001723A8
		public static RogueBossInstance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBossInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueBossInstance?(RogueBossInstance.GetRootAsRogueBossInstance(configBuffer));
				}
			}
			ConfigRogueBossInstanceById.LogPair.Clear();
			ConfigRogueBossInstanceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueBossInstanceById.HandleId, 1, p0Id, ConfigRogueBossInstanceById.LogPair) || ConfigCommon.Step(ConfigRogueBossInstanceById.HandleId, true, ConfigRogueBossInstanceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueBossInstanceById.HandleId, 0, ConfigRogueBossInstanceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueBossInstance rootAsRogueBossInstance = RogueBossInstance.GetRootAsRogueBossInstance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueBossInstanceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueBossInstanceById.HandleId, ConfigRogueBossInstanceById.LogPair);
			return new RogueBossInstance?(rootAsRogueBossInstance);
		}

		// Token: 0x04003975 RID: 14709
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003976 RID: 14710
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003977 RID: 14711
		private const string TABLE = "RogueBossInstance";

		// Token: 0x04003978 RID: 14712
		private const string COMMAND = "select BinData from `RogueBossInstance` where Id=?";

		// Token: 0x04003979 RID: 14713
		private const string KEY_PREFIX = "RogueBossInstanceById";

		// Token: 0x0400397A RID: 14714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400397B RID: 14715
		private static int HandleId;
	}
}
