using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000932 RID: 2354
	public class ConfigRoverRogueInsByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600373F RID: 14143 RVA: 0x00194D17 File Offset: 0x00192F17
		static ConfigRoverRogueInsByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueInsByInstId.CreateStaticDefaultValue), new Action(ConfigRoverRogueInsByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00194D38 File Offset: 0x00192F38
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueInsByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueInsByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueIns"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueIns` where InstId=?")
			});
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00194DB7 File Offset: 0x00192FB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueInsByInstId.LogPair = null;
			ConfigRoverRogueInsByInstId.HandleId = 0;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00194DC5 File Offset: 0x00192FC5
		public static void Init()
		{
			ConfigRoverRogueInsByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueInsByInstId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueIns` where InstId=?");
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00194DE0 File Offset: 0x00192FE0
		public static RoverRogueIns? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueInsByInstId.HandleId, ConfigRoverRogueInsByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueInsByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueIns?(RoverRogueIns.GetRootAsRoverRogueIns(configBuffer));
				}
			}
			ConfigRoverRogueInsByInstId.LogPair.Clear();
			ConfigRoverRogueInsByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigRoverRogueInsByInstId.HandleId, 1, p0InstId, ConfigRoverRogueInsByInstId.LogPair) || ConfigCommon.Step(ConfigRoverRogueInsByInstId.HandleId, true, ConfigRoverRogueInsByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueInsByInstId.HandleId, ConfigRoverRogueInsByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueInsByInstId.HandleId, 0, ConfigRoverRogueInsByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueInsByInstId.HandleId, ConfigRoverRogueInsByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueIns rootAsRoverRogueIns = RoverRogueIns.GetRootAsRoverRogueIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueInsByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueInsByInstId.HandleId, ConfigRoverRogueInsByInstId.LogPair);
			return new RoverRogueIns?(rootAsRoverRogueIns);
		}

		// Token: 0x04004044 RID: 16452
		private const string DB = "db_roverlike.db";

		// Token: 0x04004045 RID: 16453
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04004046 RID: 16454
		private const string TABLE = "RoverRogueIns";

		// Token: 0x04004047 RID: 16455
		private const string COMMAND = "select BinData from `RoverRogueIns` where InstId=?";

		// Token: 0x04004048 RID: 16456
		private const string KEY_PREFIX = "RoverRogueInsByInstId";

		// Token: 0x04004049 RID: 16457
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400404A RID: 16458
		private static int HandleId;
	}
}
