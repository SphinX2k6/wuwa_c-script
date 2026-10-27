using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B4 RID: 180
	public class ConfigArtemisQteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x000719E8 File Offset: 0x0006FBE8
		static ConfigArtemisQteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisQteById.CreateStaticDefaultValue), new Action(ConfigArtemisQteById.ResetStaticDefaultValue));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00071A08 File Offset: 0x0006FC08
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

		// Token: 0x0600043B RID: 1083 RVA: 0x00071A87 File Offset: 0x0006FC87
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisQteById.LogPair = null;
			ConfigArtemisQteById.HandleId = 0;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00071A95 File Offset: 0x0006FC95
		public static void Init()
		{
			ConfigArtemisQteById.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisQteById.HandleId, "db_artemis.db", "select BinData from `ArtemisQte` where Id=?");
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00071AB0 File Offset: 0x0006FCB0
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

		// Token: 0x040004D0 RID: 1232
		private const string DB = "db_artemis.db";

		// Token: 0x040004D1 RID: 1233
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x040004D2 RID: 1234
		private const string TABLE = "ArtemisQte";

		// Token: 0x040004D3 RID: 1235
		private const string COMMAND = "select BinData from `ArtemisQte` where Id=?";

		// Token: 0x040004D4 RID: 1236
		private const string KEY_PREFIX = "ArtemisQteById";

		// Token: 0x040004D5 RID: 1237
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004D6 RID: 1238
		private static int HandleId;
	}
}
