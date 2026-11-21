using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BC RID: 188
	public class ConfigArtemisQteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x0007629C File Offset: 0x0007449C
		static ConfigArtemisQteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisQteById.CreateStaticDefaultValue), new Action(ConfigArtemisQteById.ResetStaticDefaultValue));
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000762BC File Offset: 0x000744BC
		public static void CreateStaticDefaultValue()
		{
			ConfigArtemisQteById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigArtemisQteById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_artemis.db"),
				new ValueTuple<string, object>("文件", "a.爱弥斯预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "ArtemisQte"),
				new ValueTuple<string, object>("语句", "select BinData from `ArtemisQte` where Id=?")
			});
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0007633B File Offset: 0x0007453B
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisQteById.LogPair = null;
			ConfigArtemisQteById.HandleId = 0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00076349 File Offset: 0x00074549
		public static void Init()
		{
			ConfigArtemisQteById.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisQteById.HandleId, "db_artemis.db", "select BinData from `ArtemisQte` where Id=?");
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00076364 File Offset: 0x00074564
		public static ArtemisQte? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigArtemisQteById.HandleId, ConfigArtemisQteById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisQteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ArtemisQte?(ArtemisQte.GetRootAsArtemisQte(configBuffer));
				}
			}
			ConfigArtemisQteById.LogPair.Clear();
			ConfigArtemisQteById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigArtemisQteById.HandleId, 1, p0Id, ConfigArtemisQteById.LogPair) || ConfigCommon.Step(ConfigArtemisQteById.HandleId, true, ConfigArtemisQteById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigArtemisQteById.HandleId, ConfigArtemisQteById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigArtemisQteById.HandleId, 0, ConfigArtemisQteById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigArtemisQteById.HandleId, ConfigArtemisQteById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ArtemisQte rootAsArtemisQte = ArtemisQte.GetRootAsArtemisQte(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisQteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigArtemisQteById.HandleId, ConfigArtemisQteById.LogPair);
			return new ArtemisQte?(rootAsArtemisQte);
		}

		// Token: 0x04000508 RID: 1288
		private const string DB = "db_artemis.db";

		// Token: 0x04000509 RID: 1289
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x0400050A RID: 1290
		private const string TABLE = "ArtemisQte";

		// Token: 0x0400050B RID: 1291
		private const string COMMAND = "select BinData from `ArtemisQte` where Id=?";

		// Token: 0x0400050C RID: 1292
		private const string KEY_PREFIX = "ArtemisQteById";

		// Token: 0x0400050D RID: 1293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400050E RID: 1294
		private static int HandleId;
	}
}
