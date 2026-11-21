using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080D RID: 2061
	public class ConfigRhythmRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003060 RID: 12384 RVA: 0x0016E2E3 File Offset: 0x0016C4E3
		static ConfigRhythmRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmRoleById.CreateStaticDefaultValue), new Action(ConfigRhythmRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x0016E304 File Offset: 0x0016C504
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

		// Token: 0x06003062 RID: 12386 RVA: 0x0016E383 File Offset: 0x0016C583
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmRoleById.LogPair = null;
			ConfigRhythmRoleById.HandleId = 0;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0016E391 File Offset: 0x0016C591
		public static void Init()
		{
			ConfigRhythmRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmRoleById.HandleId, "db_rhythmship.db", "select BinData from `RhythmRole` where Id=?");
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0016E3AC File Offset: 0x0016C5AC
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

		// Token: 0x04003841 RID: 14401
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003842 RID: 14402
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003843 RID: 14403
		private const string TABLE = "RhythmRole";

		// Token: 0x04003844 RID: 14404
		private const string COMMAND = "select BinData from `RhythmRole` where Id=?";

		// Token: 0x04003845 RID: 14405
		private const string KEY_PREFIX = "RhythmRoleById";

		// Token: 0x04003846 RID: 14406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003847 RID: 14407
		private static int HandleId;
	}
}
