using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F1 RID: 2033
	public class ConfigRhythmRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FB8 RID: 12216 RVA: 0x00166FFB File Offset: 0x001651FB
		static ConfigRhythmRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmRoleById.CreateStaticDefaultValue), new Action(ConfigRhythmRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x0016701C File Offset: 0x0016521C
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmRole` where Id=?")
			});
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x0016709B File Offset: 0x0016529B
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmRoleById.LogPair = null;
			ConfigRhythmRoleById.HandleId = 0;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x001670A9 File Offset: 0x001652A9
		public static void Init()
		{
			ConfigRhythmRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmRoleById.HandleId, "db_rhythmship.db", "select BinData from `RhythmRole` where Id=?");
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x001670C4 File Offset: 0x001652C4
		public static RhythmRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmRoleById.HandleId, ConfigRhythmRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmRole?(RhythmRole.GetRootAsRhythmRole(configBuffer));
				}
			}
			ConfigRhythmRoleById.LogPair.Clear();
			ConfigRhythmRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmRoleById.HandleId, 1, p0Id, ConfigRhythmRoleById.LogPair) || ConfigCommon.Step(ConfigRhythmRoleById.HandleId, true, ConfigRhythmRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmRoleById.HandleId, ConfigRhythmRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmRoleById.HandleId, 0, ConfigRhythmRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmRoleById.HandleId, ConfigRhythmRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmRole rootAsRhythmRole = RhythmRole.GetRootAsRhythmRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmRoleById.HandleId, ConfigRhythmRoleById.LogPair);
			return new RhythmRole?(rootAsRhythmRole);
		}

		// Token: 0x0400377D RID: 14205
		private const string DB = "db_rhythmship.db";

		// Token: 0x0400377E RID: 14206
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x0400377F RID: 14207
		private const string TABLE = "RhythmRole";

		// Token: 0x04003780 RID: 14208
		private const string COMMAND = "select BinData from `RhythmRole` where Id=?";

		// Token: 0x04003781 RID: 14209
		private const string KEY_PREFIX = "RhythmRoleById";

		// Token: 0x04003782 RID: 14210
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003783 RID: 14211
		private static int HandleId;
	}
}
