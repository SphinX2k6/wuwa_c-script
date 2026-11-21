using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093F RID: 2367
	public class ConfigRoverRogueRoleTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600378D RID: 14221 RVA: 0x001967CF File Offset: 0x001949CF
		static ConfigRoverRogueRoleTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleTypeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x001967F0 File Offset: 0x001949F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoleTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoleType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoleType` where Id=?")
			});
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0019686F File Offset: 0x00194A6F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeById.LogPair = null;
			ConfigRoverRogueRoleTypeById.HandleId = 0;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x0019687D File Offset: 0x00194A7D
		public static void Init()
		{
			ConfigRoverRogueRoleTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleTypeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleType` where Id=?");
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00196898 File Offset: 0x00194A98
		public static RoverRogueRoleType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoleTypeById.HandleId, ConfigRoverRogueRoleTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoleType?(RoverRogueRoleType.GetRootAsRoverRogueRoleType(configBuffer));
				}
			}
			ConfigRoverRogueRoleTypeById.LogPair.Clear();
			ConfigRoverRogueRoleTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoleTypeById.HandleId, 1, p0Id, ConfigRoverRogueRoleTypeById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoleTypeById.HandleId, true, ConfigRoverRogueRoleTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleTypeById.HandleId, ConfigRoverRogueRoleTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoleTypeById.HandleId, 0, ConfigRoverRogueRoleTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleTypeById.HandleId, ConfigRoverRogueRoleTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoleType rootAsRoverRogueRoleType = RoverRogueRoleType.GetRootAsRoverRogueRoleType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoleTypeById.HandleId, ConfigRoverRogueRoleTypeById.LogPair);
			return new RoverRogueRoleType?(rootAsRoverRogueRoleType);
		}

		// Token: 0x0400409F RID: 16543
		private const string DB = "db_roverlike.db";

		// Token: 0x040040A0 RID: 16544
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x040040A1 RID: 16545
		private const string TABLE = "RoverRogueRoleType";

		// Token: 0x040040A2 RID: 16546
		private const string COMMAND = "select BinData from `RoverRogueRoleType` where Id=?";

		// Token: 0x040040A3 RID: 16547
		private const string KEY_PREFIX = "RoverRogueRoleTypeById";

		// Token: 0x040040A4 RID: 16548
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040A5 RID: 16549
		private static int HandleId;
	}
}
