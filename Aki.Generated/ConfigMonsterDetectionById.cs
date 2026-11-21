using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055F RID: 1375
	public class ConfigMonsterDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x0011358F File Offset: 0x0011178F
		static ConfigMonsterDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionById.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x001135B0 File Offset: 0x001117B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDetection` where id=?")
			});
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0011362F File Offset: 0x0011182F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionById.LogPair = null;
			ConfigMonsterDetectionById.HandleId = 0;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0011363D File Offset: 0x0011183D
		public static void Init()
		{
			ConfigMonsterDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection` where id=?");
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00113658 File Offset: 0x00111858
		public static MonsterDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterDetection?(MonsterDetection.GetRootAsMonsterDetection(configBuffer));
				}
			}
			ConfigMonsterDetectionById.LogPair.Clear();
			ConfigMonsterDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterDetectionById.HandleId, 1, p0Id, ConfigMonsterDetectionById.LogPair) || ConfigCommon.Step(ConfigMonsterDetectionById.HandleId, true, ConfigMonsterDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDetectionById.HandleId, 0, ConfigMonsterDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterDetection rootAsMonsterDetection = MonsterDetection.GetRootAsMonsterDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterDetectionById.HandleId, ConfigMonsterDetectionById.LogPair);
			return new MonsterDetection?(rootAsMonsterDetection);
		}

		// Token: 0x0400257D RID: 9597
		private const string DB = "db_adventure_detect.db";

		// Token: 0x0400257E RID: 9598
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x0400257F RID: 9599
		private const string TABLE = "MonsterDetection";

		// Token: 0x04002580 RID: 9600
		private const string COMMAND = "select BinData from `MonsterDetection` where id=?";

		// Token: 0x04002581 RID: 9601
		private const string KEY_PREFIX = "MonsterDetectionById";

		// Token: 0x04002582 RID: 9602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002583 RID: 9603
		private static int HandleId;
	}
}
