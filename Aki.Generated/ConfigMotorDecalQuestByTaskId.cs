using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000592 RID: 1426
	public class ConfigMotorDecalQuestByTaskId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002179 RID: 8569 RVA: 0x0011A377 File Offset: 0x00118577
		static ConfigMotorDecalQuestByTaskId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalQuestByTaskId.CreateStaticDefaultValue), new Action(ConfigMotorDecalQuestByTaskId.ResetStaticDefaultValue));
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x0011A398 File Offset: 0x00118598
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalQuestByTaskId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalQuestByTaskId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalQuest` where TaskId=?")
			});
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0011A417 File Offset: 0x00118617
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalQuestByTaskId.LogPair = null;
			ConfigMotorDecalQuestByTaskId.HandleId = 0;
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x0011A425 File Offset: 0x00118625
		public static void Init()
		{
			ConfigMotorDecalQuestByTaskId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalQuestByTaskId.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalQuest` where TaskId=?");
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0011A440 File Offset: 0x00118640
		public static MotorDecalQuest? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecalQuest?(MotorDecalQuest.GetRootAsMotorDecalQuest(configBuffer));
				}
			}
			ConfigMotorDecalQuestByTaskId.LogPair.Clear();
			ConfigMotorDecalQuestByTaskId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigMotorDecalQuestByTaskId.HandleId, 1, p0TaskId, ConfigMotorDecalQuestByTaskId.LogPair) || ConfigCommon.Step(ConfigMotorDecalQuestByTaskId.HandleId, true, ConfigMotorDecalQuestByTaskId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalQuestByTaskId.HandleId, 0, ConfigMotorDecalQuestByTaskId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecalQuest rootAsMotorDecalQuest = MotorDecalQuest.GetRootAsMotorDecalQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalQuestByTaskId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecalQuestByTaskId.HandleId, ConfigMotorDecalQuestByTaskId.LogPair);
			return new MotorDecalQuest?(rootAsMotorDecalQuest);
		}

		// Token: 0x040026E2 RID: 9954
		private const string DB = "db_motorstickerip.db";

		// Token: 0x040026E3 RID: 9955
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x040026E4 RID: 9956
		private const string TABLE = "MotorDecalQuest";

		// Token: 0x040026E5 RID: 9957
		private const string COMMAND = "select BinData from `MotorDecalQuest` where TaskId=?";

		// Token: 0x040026E6 RID: 9958
		private const string KEY_PREFIX = "MotorDecalQuestByTaskId";

		// Token: 0x040026E7 RID: 9959
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026E8 RID: 9960
		private static int HandleId;
	}
}
