using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000174 RID: 372
	public class ConfigClimbById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x0008AC30 File Offset: 0x00088E30
		static ConfigClimbById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigClimbById.CreateStaticDefaultValue), new Action(ConfigClimbById.ResetStaticDefaultValue));
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0008AC50 File Offset: 0x00088E50
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

		// Token: 0x060008BB RID: 2235 RVA: 0x0008ACCF File Offset: 0x00088ECF
		public static void ResetStaticDefaultValue()
		{
			ConfigClimbById.LogPair = null;
			ConfigClimbById.HandleId = 0;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0008ACDD File Offset: 0x00088EDD
		public static void Init()
		{
			ConfigClimbById.HandleId = ConfigCommon.InitDataStatement(ConfigClimbById.HandleId, "db_climb.db", "select BinData from `Climb` where Id=?");
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0008ACF8 File Offset: 0x00088EF8
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

		// Token: 0x04000A10 RID: 2576
		private const string DB = "db_climb.db";

		// Token: 0x04000A11 RID: 2577
		private const string FILE = "p.攀爬.xlsx";

		// Token: 0x04000A12 RID: 2578
		private const string TABLE = "Climb";

		// Token: 0x04000A13 RID: 2579
		private const string COMMAND = "select BinData from `Climb` where Id=?";

		// Token: 0x04000A14 RID: 2580
		private const string KEY_PREFIX = "ClimbById";

		// Token: 0x04000A15 RID: 2581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A16 RID: 2582
		private static int HandleId;
	}
}
