using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031F RID: 799
	public class ConfigFloroRanchRaceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012BF RID: 4799 RVA: 0x000C362F File Offset: 0x000C182F
		static ConfigFloroRanchRaceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRaceById.CreateStaticDefaultValue), new Action(ConfigFloroRanchRaceById.ResetStaticDefaultValue));
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000C3650 File Offset: 0x000C1850
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

		// Token: 0x060012C1 RID: 4801 RVA: 0x000C36CF File Offset: 0x000C18CF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRaceById.LogPair = null;
			ConfigFloroRanchRaceById.HandleId = 0;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000C36DD File Offset: 0x000C18DD
		public static void Init()
		{
			ConfigFloroRanchRaceById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRaceById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRace` where Id=?");
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000C36F8 File Offset: 0x000C18F8
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

		// Token: 0x040015BD RID: 5565
		private const string DB = "db_flororanch.db";

		// Token: 0x040015BE RID: 5566
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015BF RID: 5567
		private const string TABLE = "FloroRanchRace";

		// Token: 0x040015C0 RID: 5568
		private const string COMMAND = "select BinData from `FloroRanchRace` where Id=?";

		// Token: 0x040015C1 RID: 5569
		private const string KEY_PREFIX = "FloroRanchRaceById";

		// Token: 0x040015C2 RID: 5570
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015C3 RID: 5571
		private static int HandleId;
	}
}
