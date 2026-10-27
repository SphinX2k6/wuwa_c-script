using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AD RID: 1453
	public class ConfigMotorLinkageQuestByQuestId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600221B RID: 8731 RVA: 0x0011A68F File Offset: 0x0011888F
		static ConfigMotorLinkageQuestByQuestId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLinkageQuestByQuestId.CreateStaticDefaultValue), new Action(ConfigMotorLinkageQuestByQuestId.ResetStaticDefaultValue));
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0011A6B0 File Offset: 0x001188B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByQuestId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLinkageQuestByQuestId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorlinkage.db"),
				new ValueTuple<string, object>("文件", "m.摩托车IP联动活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLinkageQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLinkageQuest` where TaskId=?")
			});
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0011A72F File Offset: 0x0011892F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLinkageQuestByQuestId.LogPair = null;
			ConfigMotorLinkageQuestByQuestId.HandleId = 0;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0011A73D File Offset: 0x0011893D
		public static void Init()
		{
			ConfigMotorLinkageQuestByQuestId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLinkageQuestByQuestId.HandleId, "db_motorlinkage.db", "select BinData from `MotorLinkageQuest` where TaskId=?");
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0011A758 File Offset: 0x00118958
		public static MotorLinkageQuest? GetConfig(int p0TaskId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLinkageQuest?(MotorLinkageQuest.GetRootAsMotorLinkageQuest(configBuffer));
				}
			}
			ConfigMotorLinkageQuestByQuestId.LogPair.Clear();
			ConfigMotorLinkageQuestByQuestId.LogPair.Add(new ValueTuple<string, object>("TaskId", p0TaskId));
			if (!ConfigCommon.BindInt(ConfigMotorLinkageQuestByQuestId.HandleId, 1, p0TaskId, ConfigMotorLinkageQuestByQuestId.LogPair) || ConfigCommon.Step(ConfigMotorLinkageQuestByQuestId.HandleId, true, ConfigMotorLinkageQuestByQuestId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLinkageQuestByQuestId.HandleId, 0, ConfigMotorLinkageQuestByQuestId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLinkageQuest rootAsMotorLinkageQuest = MotorLinkageQuest.GetRootAsMotorLinkageQuest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLinkageQuestByQuestId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TaskId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLinkageQuestByQuestId.HandleId, ConfigMotorLinkageQuestByQuestId.LogPair);
			return new MotorLinkageQuest?(rootAsMotorLinkageQuest);
		}

		// Token: 0x0400279F RID: 10143
		private const string DB = "db_motorlinkage.db";

		// Token: 0x040027A0 RID: 10144
		private const string FILE = "m.摩托车IP联动活动.xlsx";

		// Token: 0x040027A1 RID: 10145
		private const string TABLE = "MotorLinkageQuest";

		// Token: 0x040027A2 RID: 10146
		private const string COMMAND = "select BinData from `MotorLinkageQuest` where TaskId=?";

		// Token: 0x040027A3 RID: 10147
		private const string KEY_PREFIX = "MotorLinkageQuestByQuestId";

		// Token: 0x040027A4 RID: 10148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027A5 RID: 10149
		private static int HandleId;
	}
}
