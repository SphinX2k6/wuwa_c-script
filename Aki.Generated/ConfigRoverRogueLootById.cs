using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EB RID: 2283
	public class ConfigRoverRogueLootById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003595 RID: 13717 RVA: 0x00188353 File Offset: 0x00186553
		static ConfigRoverRogueLootById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueLootById.CreateStaticDefaultValue), new Action(ConfigRoverRogueLootById.ResetStaticDefaultValue));
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00188374 File Offset: 0x00186574
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

		// Token: 0x06003597 RID: 13719 RVA: 0x001883F3 File Offset: 0x001865F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueLootById.LogPair = null;
			ConfigRoverRogueLootById.HandleId = 0;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00188401 File Offset: 0x00186601
		public static void Init()
		{
			ConfigRoverRogueLootById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueLootById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueLoot` where Id=?");
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0018841C File Offset: 0x0018661C
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

		// Token: 0x04003E53 RID: 15955
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E54 RID: 15956
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E55 RID: 15957
		private const string TABLE = "RoverRogueLoot";

		// Token: 0x04003E56 RID: 15958
		private const string COMMAND = "select BinData from `RoverRogueLoot` where Id=?";

		// Token: 0x04003E57 RID: 15959
		private const string KEY_PREFIX = "RoverRogueLootById";

		// Token: 0x04003E58 RID: 15960
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E59 RID: 15961
		private static int HandleId;
	}
}
