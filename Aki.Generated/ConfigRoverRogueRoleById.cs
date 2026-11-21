using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093B RID: 2363
	public class ConfigRoverRogueRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003775 RID: 14197 RVA: 0x00196017 File Offset: 0x00194217
		static ConfigRoverRogueRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00196038 File Offset: 0x00194238
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRole` where Id=?")
			});
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x001960B7 File Offset: 0x001942B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleById.LogPair = null;
			ConfigRoverRogueRoleById.HandleId = 0;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x001960C5 File Offset: 0x001942C5
		public static void Init()
		{
			ConfigRoverRogueRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRole` where Id=?");
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x001960E0 File Offset: 0x001942E0
		public static RoverRogueRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoleById.HandleId, ConfigRoverRogueRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRole?(RoverRogueRole.GetRootAsRoverRogueRole(configBuffer));
				}
			}
			ConfigRoverRogueRoleById.LogPair.Clear();
			ConfigRoverRogueRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoleById.HandleId, 1, p0Id, ConfigRoverRogueRoleById.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoleById.HandleId, true, ConfigRoverRogueRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleById.HandleId, ConfigRoverRogueRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoleById.HandleId, 0, ConfigRoverRogueRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoleById.HandleId, ConfigRoverRogueRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRole rootAsRoverRogueRole = RoverRogueRole.GetRootAsRoverRogueRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoleById.HandleId, ConfigRoverRogueRoleById.LogPair);
			return new RoverRogueRole?(rootAsRoverRogueRole);
		}

		// Token: 0x04004083 RID: 16515
		private const string DB = "db_roverlike.db";

		// Token: 0x04004084 RID: 16516
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04004085 RID: 16517
		private const string TABLE = "RoverRogueRole";

		// Token: 0x04004086 RID: 16518
		private const string COMMAND = "select BinData from `RoverRogueRole` where Id=?";

		// Token: 0x04004087 RID: 16519
		private const string KEY_PREFIX = "RoverRogueRoleById";

		// Token: 0x04004088 RID: 16520
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004089 RID: 16521
		private static int HandleId;
	}
}
