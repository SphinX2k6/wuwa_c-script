using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000929 RID: 2345
	public class ConfigRoverRogueBlessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003709 RID: 14089 RVA: 0x00193A07 File Offset: 0x00191C07
		static ConfigRoverRogueBlessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessById.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessById.ResetStaticDefaultValue));
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00193A28 File Offset: 0x00191C28
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBless"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBless` where Id=?")
			});
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00193AA7 File Offset: 0x00191CA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessById.LogPair = null;
			ConfigRoverRogueBlessById.HandleId = 0;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00193AB5 File Offset: 0x00191CB5
		public static void Init()
		{
			ConfigRoverRogueBlessById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBless` where Id=?");
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00193AD0 File Offset: 0x00191CD0
		public static RoverRogueBless? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueBless?(RoverRogueBless.GetRootAsRoverRogueBless(configBuffer));
				}
			}
			ConfigRoverRogueBlessById.LogPair.Clear();
			ConfigRoverRogueBlessById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessById.HandleId, 1, p0Id, ConfigRoverRogueBlessById.LogPair) || ConfigCommon.Step(ConfigRoverRogueBlessById.HandleId, true, ConfigRoverRogueBlessById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessById.HandleId, 0, ConfigRoverRogueBlessById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueBless rootAsRoverRogueBless = RoverRogueBless.GetRootAsRoverRogueBless(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
			return new RoverRogueBless?(rootAsRoverRogueBless);
		}

		// Token: 0x04004005 RID: 16389
		private const string DB = "db_roverlike.db";

		// Token: 0x04004006 RID: 16390
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04004007 RID: 16391
		private const string TABLE = "RoverRogueBless";

		// Token: 0x04004008 RID: 16392
		private const string COMMAND = "select BinData from `RoverRogueBless` where Id=?";

		// Token: 0x04004009 RID: 16393
		private const string KEY_PREFIX = "RoverRogueBlessById";

		// Token: 0x0400400A RID: 16394
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400400B RID: 16395
		private static int HandleId;
	}
}
