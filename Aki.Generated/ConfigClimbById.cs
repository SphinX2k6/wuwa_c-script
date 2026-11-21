using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000184 RID: 388
	public class ConfigClimbById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x0009078C File Offset: 0x0008E98C
		static ConfigClimbById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClimbById.CreateStaticDefaultValue), new Action(ConfigClimbById.ResetStaticDefaultValue));
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000907AC File Offset: 0x0008E9AC
		public static void CreateStaticDefaultValue()
		{
			ConfigClimbById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigClimbById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_climb.db"),
				new ValueTuple<string, object>("文件", "p.攀爬.xlsx"),
				new ValueTuple<string, object>("表名", "Climb"),
				new ValueTuple<string, object>("语句", "select BinData from `Climb` where Id=?")
			});
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0009082B File Offset: 0x0008EA2B
		public static void ResetStaticDefaultValue()
		{
			ConfigClimbById.LogPair = null;
			ConfigClimbById.HandleId = 0;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00090839 File Offset: 0x0008EA39
		public static void Init()
		{
			ConfigClimbById.HandleId = ConfigCommon.InitDataStatement(ConfigClimbById.HandleId, "db_climb.db", "select BinData from `Climb` where Id=?");
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00090854 File Offset: 0x0008EA54
		public static Climb? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigClimbById.HandleId, ConfigClimbById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ClimbById#" + p0Id);
				if (configBuffer != null)
				{
					return new Climb?(Climb.GetRootAsClimb(configBuffer));
				}
			}
			ConfigClimbById.LogPair.Clear();
			ConfigClimbById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigClimbById.HandleId, 1, p0Id, ConfigClimbById.LogPair) || ConfigCommon.Step(ConfigClimbById.HandleId, true, ConfigClimbById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigClimbById.HandleId, ConfigClimbById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigClimbById.HandleId, 0, ConfigClimbById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigClimbById.HandleId, ConfigClimbById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Climb rootAsClimb = Climb.GetRootAsClimb(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ClimbById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigClimbById.HandleId, ConfigClimbById.LogPair);
			return new Climb?(rootAsClimb);
		}

		// Token: 0x04000A80 RID: 2688
		private const string DB = "db_climb.db";

		// Token: 0x04000A81 RID: 2689
		private const string FILE = "p.攀爬.xlsx";

		// Token: 0x04000A82 RID: 2690
		private const string TABLE = "Climb";

		// Token: 0x04000A83 RID: 2691
		private const string COMMAND = "select BinData from `Climb` where Id=?";

		// Token: 0x04000A84 RID: 2692
		private const string KEY_PREFIX = "ClimbById";

		// Token: 0x04000A85 RID: 2693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A86 RID: 2694
		private static int HandleId;
	}
}
