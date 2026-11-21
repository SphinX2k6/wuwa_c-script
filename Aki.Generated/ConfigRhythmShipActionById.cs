using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080F RID: 2063
	public class ConfigRhythmShipActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x0016E6BF File Offset: 0x0016C8BF
		static ConfigRhythmShipActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipActionById.CreateStaticDefaultValue), new Action(ConfigRhythmShipActionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0016E6E0 File Offset: 0x0016C8E0
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipActionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipActionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipAction"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipAction` where Id=?")
			});
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0016E75F File Offset: 0x0016C95F
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipActionById.LogPair = null;
			ConfigRhythmShipActionById.HandleId = 0;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0016E76D File Offset: 0x0016C96D
		public static void Init()
		{
			ConfigRhythmShipActionById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipActionById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipAction` where Id=?");
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0016E788 File Offset: 0x0016C988
		public static RhythmShipAction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipActionById.HandleId, ConfigRhythmShipActionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmShipAction?(RhythmShipAction.GetRootAsRhythmShipAction(configBuffer));
				}
			}
			ConfigRhythmShipActionById.LogPair.Clear();
			ConfigRhythmShipActionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmShipActionById.HandleId, 1, p0Id, ConfigRhythmShipActionById.LogPair) || ConfigCommon.Step(ConfigRhythmShipActionById.HandleId, true, ConfigRhythmShipActionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmShipActionById.HandleId, ConfigRhythmShipActionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipActionById.HandleId, 0, ConfigRhythmShipActionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmShipActionById.HandleId, ConfigRhythmShipActionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmShipAction rootAsRhythmShipAction = RhythmShipAction.GetRootAsRhythmShipAction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmShipActionById.HandleId, ConfigRhythmShipActionById.LogPair);
			return new RhythmShipAction?(rootAsRhythmShipAction);
		}

		// Token: 0x0400384F RID: 14415
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003850 RID: 14416
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003851 RID: 14417
		private const string TABLE = "RhythmShipAction";

		// Token: 0x04003852 RID: 14418
		private const string COMMAND = "select BinData from `RhythmShipAction` where Id=?";

		// Token: 0x04003853 RID: 14419
		private const string KEY_PREFIX = "RhythmShipActionById";

		// Token: 0x04003854 RID: 14420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003855 RID: 14421
		private static int HandleId;
	}
}
