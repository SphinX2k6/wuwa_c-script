using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008F0 RID: 2288
	public class ConfigRoverRogueRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035B3 RID: 13747 RVA: 0x00188DF7 File Offset: 0x00186FF7
		static ConfigRoverRogueRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoleById.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00188E18 File Offset: 0x00187018
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

		// Token: 0x060035B5 RID: 13749 RVA: 0x00188E97 File Offset: 0x00187097
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoleById.LogPair = null;
			ConfigRoverRogueRoleById.HandleId = 0;
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00188EA5 File Offset: 0x001870A5
		public static void Init()
		{
			ConfigRoverRogueRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoleById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRole` where Id=?");
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00188EC0 File Offset: 0x001870C0
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

		// Token: 0x04003E76 RID: 15990
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E77 RID: 15991
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E78 RID: 15992
		private const string TABLE = "RoverRogueRole";

		// Token: 0x04003E79 RID: 15993
		private const string COMMAND = "select BinData from `RoverRogueRole` where Id=?";

		// Token: 0x04003E7A RID: 15994
		private const string KEY_PREFIX = "RoverRogueRoleById";

		// Token: 0x04003E7B RID: 15995
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E7C RID: 15996
		private static int HandleId;
	}
}
