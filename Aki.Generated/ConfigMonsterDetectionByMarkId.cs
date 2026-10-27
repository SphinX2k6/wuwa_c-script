using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054A RID: 1354
	public class ConfigMonsterDetectionByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FC9 RID: 8137 RVA: 0x0010D084 File Offset: 0x0010B284
		static ConfigMonsterDetectionByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionByMarkId.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0010D0A4 File Offset: 0x0010B2A4
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDetectionByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDetectionByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDetection` where MarkId=?")
			});
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0010D123 File Offset: 0x0010B323
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionByMarkId.LogPair = null;
			ConfigMonsterDetectionByMarkId.HandleId = 0;
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0010D131 File Offset: 0x0010B331
		public static void Init()
		{
			ConfigMonsterDetectionByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionByMarkId.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection` where MarkId=?");
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0010D14C File Offset: 0x0010B34C
		public static MonsterDetection? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDetectionByMarkId.HandleId, ConfigMonsterDetectionByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterDetection?(MonsterDetection.GetRootAsMonsterDetection(configBuffer));
				}
			}
			ConfigMonsterDetectionByMarkId.LogPair.Clear();
			ConfigMonsterDetectionByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigMonsterDetectionByMarkId.HandleId, 1, p0MarkId, ConfigMonsterDetectionByMarkId.LogPair) || ConfigCommon.Step(ConfigMonsterDetectionByMarkId.HandleId, true, ConfigMonsterDetectionByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionByMarkId.HandleId, ConfigMonsterDetectionByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDetectionByMarkId.HandleId, 0, ConfigMonsterDetectionByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterDetectionByMarkId.HandleId, ConfigMonsterDetectionByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterDetection rootAsMonsterDetection = MonsterDetection.GetRootAsMonsterDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDetectionByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterDetectionByMarkId.HandleId, ConfigMonsterDetectionByMarkId.LogPair);
			return new MonsterDetection?(rootAsMonsterDetection);
		}

		// Token: 0x040024EA RID: 9450
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040024EB RID: 9451
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040024EC RID: 9452
		private const string TABLE = "MonsterDetection";

		// Token: 0x040024ED RID: 9453
		private const string COMMAND = "select BinData from `MonsterDetection` where MarkId=?";

		// Token: 0x040024EE RID: 9454
		private const string KEY_PREFIX = "MonsterDetectionByMarkId";

		// Token: 0x040024EF RID: 9455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024F0 RID: 9456
		private static int HandleId;
	}
}
