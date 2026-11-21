using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000934 RID: 2356
	public class ConfigRoverRogueItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x001950F3 File Offset: 0x001932F3
		static ConfigRoverRogueItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueItemById.CreateStaticDefaultValue), new Action(ConfigRoverRogueItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00195114 File Offset: 0x00193314
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueItem` where Id=?")
			});
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00195193 File Offset: 0x00193393
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueItemById.LogPair = null;
			ConfigRoverRogueItemById.HandleId = 0;
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x001951A1 File Offset: 0x001933A1
		public static void Init()
		{
			ConfigRoverRogueItemById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueItemById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueItem` where Id=?");
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x001951BC File Offset: 0x001933BC
		public static RoverRogueItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueItem?(RoverRogueItem.GetRootAsRoverRogueItem(configBuffer));
				}
			}
			ConfigRoverRogueItemById.LogPair.Clear();
			ConfigRoverRogueItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueItemById.HandleId, 1, p0Id, ConfigRoverRogueItemById.LogPair) || ConfigCommon.Step(ConfigRoverRogueItemById.HandleId, true, ConfigRoverRogueItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueItemById.HandleId, 0, ConfigRoverRogueItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueItem rootAsRoverRogueItem = RoverRogueItem.GetRootAsRoverRogueItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
			return new RoverRogueItem?(rootAsRoverRogueItem);
		}

		// Token: 0x04004052 RID: 16466
		private const string DB = "db_roverlike.db";

		// Token: 0x04004053 RID: 16467
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04004054 RID: 16468
		private const string TABLE = "RoverRogueItem";

		// Token: 0x04004055 RID: 16469
		private const string COMMAND = "select BinData from `RoverRogueItem` where Id=?";

		// Token: 0x04004056 RID: 16470
		private const string KEY_PREFIX = "RoverRogueItemById";

		// Token: 0x04004057 RID: 16471
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004058 RID: 16472
		private static int HandleId;
	}
}
