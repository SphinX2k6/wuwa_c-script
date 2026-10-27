using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DF RID: 2271
	public class ConfigRoverRogueBlessGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600354D RID: 13645 RVA: 0x00186A30 File Offset: 0x00184C30
		static ConfigRoverRogueBlessGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessGroupById.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x00186A50 File Offset: 0x00184C50
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBlessGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBlessGroup` where Id=?")
			});
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x00186ACF File Offset: 0x00184CCF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessGroupById.LogPair = null;
			ConfigRoverRogueBlessGroupById.HandleId = 0;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x00186ADD File Offset: 0x00184CDD
		public static void Init()
		{
			ConfigRoverRogueBlessGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessGroupById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessGroup` where Id=?");
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00186AF8 File Offset: 0x00184CF8
		public static RoverRogueBlessGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueBlessGroup?(RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(configBuffer));
				}
			}
			ConfigRoverRogueBlessGroupById.LogPair.Clear();
			ConfigRoverRogueBlessGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessGroupById.HandleId, 1, p0Id, ConfigRoverRogueBlessGroupById.LogPair) || ConfigCommon.Step(ConfigRoverRogueBlessGroupById.HandleId, true, ConfigRoverRogueBlessGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessGroupById.HandleId, 0, ConfigRoverRogueBlessGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueBlessGroup rootAsRoverRogueBlessGroup = RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
			return new RoverRogueBlessGroup?(rootAsRoverRogueBlessGroup);
		}

		// Token: 0x04003DFF RID: 15871
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E00 RID: 15872
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E01 RID: 15873
		private const string TABLE = "RoverRogueBlessGroup";

		// Token: 0x04003E02 RID: 15874
		private const string COMMAND = "select BinData from `RoverRogueBlessGroup` where Id=?";

		// Token: 0x04003E03 RID: 15875
		private const string KEY_PREFIX = "RoverRogueBlessGroupById";

		// Token: 0x04003E04 RID: 15876
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E05 RID: 15877
		private static int HandleId;
	}
}
