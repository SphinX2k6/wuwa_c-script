using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000560 RID: 1376
	public class ConfigMonsterDetectionByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x001137D8 File Offset: 0x001119D8
		static ConfigMonsterDetectionByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionByMarkId.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x001137F8 File Offset: 0x001119F8
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

		// Token: 0x0600204F RID: 8271 RVA: 0x00113877 File Offset: 0x00111A77
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionByMarkId.LogPair = null;
			ConfigMonsterDetectionByMarkId.HandleId = 0;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00113885 File Offset: 0x00111A85
		public static void Init()
		{
			ConfigMonsterDetectionByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionByMarkId.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection` where MarkId=?");
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x001138A0 File Offset: 0x00111AA0
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

		// Token: 0x04002584 RID: 9604
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04002585 RID: 9605
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04002586 RID: 9606
		private const string TABLE = "MonsterDetection";

		// Token: 0x04002587 RID: 9607
		private const string COMMAND = "select BinData from `MonsterDetection` where MarkId=?";

		// Token: 0x04002588 RID: 9608
		private const string KEY_PREFIX = "MonsterDetectionByMarkId";

		// Token: 0x04002589 RID: 9609
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400258A RID: 9610
		private static int HandleId;
	}
}
