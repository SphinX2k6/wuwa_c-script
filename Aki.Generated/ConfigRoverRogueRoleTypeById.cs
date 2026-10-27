using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F4 RID: 2292
	public class ConfigRoverRogueRoleTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035CB RID: 13771 RVA: 0x001895AF File Offset: 0x001877AF
		static ConfigRoverRogueRoleTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleTypeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x001895D0 File Offset: 0x001877D0
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

		// Token: 0x060035CD RID: 13773 RVA: 0x0018964F File Offset: 0x0018784F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleTypeById.LogPair = null;
			ConfigRoverRogueRoleTypeById.HandleId = 0;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0018965D File Offset: 0x0018785D
		public static void Init()
		{
			ConfigRoverRogueRoleTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleTypeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoleType` where Id=?");
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x00189678 File Offset: 0x00187878
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

		// Token: 0x04003E92 RID: 16018
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E93 RID: 16019
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E94 RID: 16020
		private const string TABLE = "RoverRogueRoleType";

		// Token: 0x04003E95 RID: 16021
		private const string COMMAND = "select BinData from `RoverRogueRoleType` where Id=?";

		// Token: 0x04003E96 RID: 16022
		private const string KEY_PREFIX = "RoverRogueRoleTypeById";

		// Token: 0x04003E97 RID: 16023
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E98 RID: 16024
		private static int HandleId;
	}
}
