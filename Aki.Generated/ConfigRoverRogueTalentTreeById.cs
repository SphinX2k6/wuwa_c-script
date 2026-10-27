using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F9 RID: 2297
	public class ConfigRoverRogueTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035E9 RID: 13801 RVA: 0x0018A063 File Offset: 0x00188263
		static ConfigRoverRogueTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0018A084 File Offset: 0x00188284
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueTalentTree` where Id=?")
			});
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0018A103 File Offset: 0x00188303
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeById.LogPair = null;
			ConfigRoverRogueTalentTreeById.HandleId = 0;
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0018A111 File Offset: 0x00188311
		public static void Init()
		{
			ConfigRoverRogueTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueTalentTreeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueTalentTree` where Id=?");
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0018A12C File Offset: 0x0018832C
		public static RoverRogueTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueTalentTree?(RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(configBuffer));
				}
			}
			ConfigRoverRogueTalentTreeById.LogPair.Clear();
			ConfigRoverRogueTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueTalentTreeById.HandleId, 1, p0Id, ConfigRoverRogueTalentTreeById.LogPair) || ConfigCommon.Step(ConfigRoverRogueTalentTreeById.HandleId, true, ConfigRoverRogueTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueTalentTreeById.HandleId, 0, ConfigRoverRogueTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueTalentTree rootAsRoverRogueTalentTree = RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
			return new RoverRogueTalentTree?(rootAsRoverRogueTalentTree);
		}

		// Token: 0x04003EB5 RID: 16053
		private const string DB = "db_roverlike.db";

		// Token: 0x04003EB6 RID: 16054
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003EB7 RID: 16055
		private const string TABLE = "RoverRogueTalentTree";

		// Token: 0x04003EB8 RID: 16056
		private const string COMMAND = "select BinData from `RoverRogueTalentTree` where Id=?";

		// Token: 0x04003EB9 RID: 16057
		private const string KEY_PREFIX = "RoverRogueTalentTreeById";

		// Token: 0x04003EBA RID: 16058
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EBB RID: 16059
		private static int HandleId;
	}
}
