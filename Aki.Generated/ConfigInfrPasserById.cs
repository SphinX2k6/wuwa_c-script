using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042E RID: 1070
	public class ConfigInfrPasserById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600191D RID: 6429 RVA: 0x000E794F File Offset: 0x000E5B4F
		static ConfigInfrPasserById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPasserById.CreateStaticDefaultValue), new Action(ConfigInfrPasserById.ResetStaticDefaultValue));
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000E7970 File Offset: 0x000E5B70
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

		// Token: 0x0600191F RID: 6431 RVA: 0x000E79EF File Offset: 0x000E5BEF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPasserById.LogPair = null;
			ConfigInfrPasserById.HandleId = 0;
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x000E79FD File Offset: 0x000E5BFD
		public static void Init()
		{
			ConfigInfrPasserById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPasserById.HandleId, "db_infrastructure.db", "select BinData from `InfrPasser` where Id=?");
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000E7A18 File Offset: 0x000E5C18
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

		// Token: 0x04001D26 RID: 7462
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D27 RID: 7463
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D28 RID: 7464
		private const string TABLE = "InfrPasser";

		// Token: 0x04001D29 RID: 7465
		private const string COMMAND = "select BinData from `InfrPasser` where Id=?";

		// Token: 0x04001D2A RID: 7466
		private const string KEY_PREFIX = "InfrPasserById";

		// Token: 0x04001D2B RID: 7467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D2C RID: 7468
		private static int HandleId;
	}
}
