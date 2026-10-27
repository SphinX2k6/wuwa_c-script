using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F3 RID: 2035
	public class ConfigRhythmShipActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FC4 RID: 12228 RVA: 0x001673D7 File Offset: 0x001655D7
		static ConfigRhythmShipActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipActionById.CreateStaticDefaultValue), new Action(ConfigRhythmShipActionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x001673F8 File Offset: 0x001655F8
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

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00167477 File Offset: 0x00165677
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipActionById.LogPair = null;
			ConfigRhythmShipActionById.HandleId = 0;
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00167485 File Offset: 0x00165685
		public static void Init()
		{
			ConfigRhythmShipActionById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipActionById.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipAction` where Id=?");
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x001674A0 File Offset: 0x001656A0
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

		// Token: 0x0400378B RID: 14219
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400378C RID: 14220
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400378D RID: 14221
		private const string TABLE = "RhythmShipAction";

		// Token: 0x0400378E RID: 14222
		private const string COMMAND = "select BinData from `RhythmShipAction` where Id=?";

		// Token: 0x0400378F RID: 14223
		private const string KEY_PREFIX = "RhythmShipActionById";

		// Token: 0x04003790 RID: 14224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003791 RID: 14225
		private static int HandleId;
	}
}
