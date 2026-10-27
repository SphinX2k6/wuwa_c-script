using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E1 RID: 2273
	public class ConfigRoverRogueBlessRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003559 RID: 13657 RVA: 0x00186E0B File Offset: 0x0018500B
		static ConfigRoverRogueBlessRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessRoleById.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x00186E2C File Offset: 0x0018502C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBlessRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBlessRole` where Id=?")
			});
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00186EAB File Offset: 0x001850AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessRoleById.LogPair = null;
			ConfigRoverRogueBlessRoleById.HandleId = 0;
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x00186EB9 File Offset: 0x001850B9
		public static void Init()
		{
			ConfigRoverRogueBlessRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessRoleById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessRole` where Id=?");
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00186ED4 File Offset: 0x001850D4
		public static RoverRogueBlessRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessRoleById.HandleId, ConfigRoverRogueBlessRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueBlessRole?(RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(configBuffer));
				}
			}
			ConfigRoverRogueBlessRoleById.LogPair.Clear();
			ConfigRoverRogueBlessRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessRoleById.HandleId, 1, p0Id, ConfigRoverRogueBlessRoleById.LogPair) || ConfigCommon.Step(ConfigRoverRogueBlessRoleById.HandleId, true, ConfigRoverRogueBlessRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessRoleById.HandleId, ConfigRoverRogueBlessRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessRoleById.HandleId, 0, ConfigRoverRogueBlessRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessRoleById.HandleId, ConfigRoverRogueBlessRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueBlessRole rootAsRoverRogueBlessRole = RoverRogueBlessRole.GetRootAsRoverRogueBlessRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessRoleById.HandleId, ConfigRoverRogueBlessRoleById.LogPair);
			return new RoverRogueBlessRole?(rootAsRoverRogueBlessRole);
		}

		// Token: 0x04003E0D RID: 15885
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E0E RID: 15886
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003E0F RID: 15887
		private const string TABLE = "RoverRogueBlessRole";

		// Token: 0x04003E10 RID: 15888
		private const string COMMAND = "select BinData from `RoverRogueBlessRole` where Id=?";

		// Token: 0x04003E11 RID: 15889
		private const string KEY_PREFIX = "RoverRogueBlessRoleById";

		// Token: 0x04003E12 RID: 15890
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E13 RID: 15891
		private static int HandleId;
	}
}
