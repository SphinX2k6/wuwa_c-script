using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E7 RID: 2279
	public class ConfigRoverRogueInsByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600357D RID: 13693 RVA: 0x00187AF7 File Offset: 0x00185CF7
		static ConfigRoverRogueInsByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueInsByInstId.CreateStaticDefaultValue), new Action(ConfigRoverRogueInsByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x00187B18 File Offset: 0x00185D18
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

		// Token: 0x0600357F RID: 13695 RVA: 0x00187B97 File Offset: 0x00185D97
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueInsByInstId.LogPair = null;
			ConfigRoverRogueInsByInstId.HandleId = 0;
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00187BA5 File Offset: 0x00185DA5
		public static void Init()
		{
			ConfigRoverRogueInsByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueInsByInstId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueIns` where InstId=?");
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x00187BC0 File Offset: 0x00185DC0
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

		// Token: 0x04003E37 RID: 15927
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E38 RID: 15928
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003E39 RID: 15929
		private const string TABLE = "RoverRogueIns";

		// Token: 0x04003E3A RID: 15930
		private const string COMMAND = "select BinData from `RoverRogueIns` where InstId=?";

		// Token: 0x04003E3B RID: 15931
		private const string KEY_PREFIX = "RoverRogueInsByInstId";

		// Token: 0x04003E3C RID: 15932
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E3D RID: 15933
		private static int HandleId;
	}
}
