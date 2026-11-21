using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000936 RID: 2358
	public class ConfigRoverRogueLootById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003757 RID: 14167 RVA: 0x00195573 File Offset: 0x00193773
		static ConfigRoverRogueLootById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueLootById.CreateStaticDefaultValue), new Action(ConfigRoverRogueLootById.ResetStaticDefaultValue));
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x00195594 File Offset: 0x00193794
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueLootById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueLootById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueLoot"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueLoot` where Id=?")
			});
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x00195613 File Offset: 0x00193813
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueLootById.LogPair = null;
			ConfigRoverRogueLootById.HandleId = 0;
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x00195621 File Offset: 0x00193821
		public static void Init()
		{
			ConfigRoverRogueLootById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueLootById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueLoot` where Id=?");
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0019563C File Offset: 0x0019383C
		public static RoverRogueLoot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueLootById.HandleId, ConfigRoverRogueLootById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueLootById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueLoot?(RoverRogueLoot.GetRootAsRoverRogueLoot(configBuffer));
				}
			}
			ConfigRoverRogueLootById.LogPair.Clear();
			ConfigRoverRogueLootById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueLootById.HandleId, 1, p0Id, ConfigRoverRogueLootById.LogPair) || ConfigCommon.Step(ConfigRoverRogueLootById.HandleId, true, ConfigRoverRogueLootById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueLootById.HandleId, ConfigRoverRogueLootById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueLootById.HandleId, 0, ConfigRoverRogueLootById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueLootById.HandleId, ConfigRoverRogueLootById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueLoot rootAsRoverRogueLoot = RoverRogueLoot.GetRootAsRoverRogueLoot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueLootById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueLootById.HandleId, ConfigRoverRogueLootById.LogPair);
			return new RoverRogueLoot?(rootAsRoverRogueLoot);
		}

		// Token: 0x04004060 RID: 16480
		private const string DB = "db_roverlike.db";

		// Token: 0x04004061 RID: 16481
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04004062 RID: 16482
		private const string TABLE = "RoverRogueLoot";

		// Token: 0x04004063 RID: 16483
		private const string COMMAND = "select BinData from `RoverRogueLoot` where Id=?";

		// Token: 0x04004064 RID: 16484
		private const string KEY_PREFIX = "RoverRogueLootById";

		// Token: 0x04004065 RID: 16485
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004066 RID: 16486
		private static int HandleId;
	}
}
