using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000334 RID: 820
	public class ConfigFloroRanchRaceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x000C9B3B File Offset: 0x000C7D3B
		static ConfigFloroRanchRaceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRaceById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRaceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000C9B5C File Offset: 0x000C7D5C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRaceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRaceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchRace"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchRace` where Id=?")
			});
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000C9BDB File Offset: 0x000C7DDB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRaceById.LogPair = null;
			ConfigFloroRanchRaceById.HandleId = 0;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000C9BE9 File Offset: 0x000C7DE9
		public static void Init()
		{
			ConfigFloroRanchRaceById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRaceById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRace` where Id=?");
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000C9C04 File Offset: 0x000C7E04
		public static FloroRanchRace? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRaceById.HandleId, ConfigFloroRanchRaceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRaceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchRace?(FloroRanchRace.GetRootAsFloroRanchRace(configBuffer));
				}
			}
			ConfigFloroRanchRaceById.LogPair.Clear();
			ConfigFloroRanchRaceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRaceById.HandleId, 1, p0Id, ConfigFloroRanchRaceById.LogPair) || ConfigCommon.Step(ConfigFloroRanchRaceById.HandleId, true, ConfigFloroRanchRaceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchRaceById.HandleId, ConfigFloroRanchRaceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRaceById.HandleId, 0, ConfigFloroRanchRaceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchRaceById.HandleId, ConfigFloroRanchRaceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchRace rootAsFloroRanchRace = FloroRanchRace.GetRootAsFloroRanchRace(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRaceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchRaceById.HandleId, ConfigFloroRanchRaceById.LogPair);
			return new FloroRanchRace?(rootAsFloroRanchRace);
		}

		// Token: 0x04001650 RID: 5712
		private const string DB = "db_flororanch.db";

		// Token: 0x04001651 RID: 5713
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001652 RID: 5714
		private const string TABLE = "FloroRanchRace";

		// Token: 0x04001653 RID: 5715
		private const string COMMAND = "select BinData from `FloroRanchRace` where Id=?";

		// Token: 0x04001654 RID: 5716
		private const string KEY_PREFIX = "FloroRanchRaceById";

		// Token: 0x04001655 RID: 5717
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001656 RID: 5718
		private static int HandleId;
	}
}
