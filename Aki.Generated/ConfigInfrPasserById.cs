using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000444 RID: 1092
	public class ConfigInfrPasserById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019A1 RID: 6561 RVA: 0x000EE0A3 File Offset: 0x000EC2A3
		static ConfigInfrPasserById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPasserById.CreateStaticDefaultValue), new Action(ConfigInfrPasserById.ResetStaticDefaultValue));
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x000EE0C4 File Offset: 0x000EC2C4
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPasserById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPasserById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPasser"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPasser` where Id=?")
			});
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000EE143 File Offset: 0x000EC343
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPasserById.LogPair = null;
			ConfigInfrPasserById.HandleId = 0;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000EE151 File Offset: 0x000EC351
		public static void Init()
		{
			ConfigInfrPasserById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPasserById.HandleId, "db_infrastructure.db", "select BinData from `InfrPasser` where Id=?");
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000EE16C File Offset: 0x000EC36C
		public static InfrPasser? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPasserById.HandleId, ConfigInfrPasserById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPasserById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrPasser?(InfrPasser.GetRootAsInfrPasser(configBuffer));
				}
			}
			ConfigInfrPasserById.LogPair.Clear();
			ConfigInfrPasserById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrPasserById.HandleId, 1, p0Id, ConfigInfrPasserById.LogPair) || ConfigCommon.Step(ConfigInfrPasserById.HandleId, true, ConfigInfrPasserById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrPasserById.HandleId, ConfigInfrPasserById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPasserById.HandleId, 0, ConfigInfrPasserById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrPasserById.HandleId, ConfigInfrPasserById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrPasser rootAsInfrPasser = InfrPasser.GetRootAsInfrPasser(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPasserById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrPasserById.HandleId, ConfigInfrPasserById.LogPair);
			return new InfrPasser?(rootAsInfrPasser);
		}

		// Token: 0x04001DC0 RID: 7616
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DC1 RID: 7617
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DC2 RID: 7618
		private const string TABLE = "InfrPasser";

		// Token: 0x04001DC3 RID: 7619
		private const string COMMAND = "select BinData from `InfrPasser` where Id=?";

		// Token: 0x04001DC4 RID: 7620
		private const string KEY_PREFIX = "InfrPasserById";

		// Token: 0x04001DC5 RID: 7621
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DC6 RID: 7622
		private static int HandleId;
	}
}
