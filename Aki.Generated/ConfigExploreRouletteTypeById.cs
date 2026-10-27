using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A1 RID: 673
	public class ConfigExploreRouletteTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FCB RID: 4043 RVA: 0x000B2BB7 File Offset: 0x000B0DB7
		static ConfigExploreRouletteTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteTypeById.CreateStaticDefaultValue), new Action(ConfigExploreRouletteTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000B2BD8 File Offset: 0x000B0DD8
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRouletteTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRouletteTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRouletteType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRouletteType` where Id=?")
			});
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000B2C57 File Offset: 0x000B0E57
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteTypeById.LogPair = null;
			ConfigExploreRouletteTypeById.HandleId = 0;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000B2C65 File Offset: 0x000B0E65
		public static void Init()
		{
			ConfigExploreRouletteTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteTypeById.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteType` where Id=?");
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000B2C80 File Offset: 0x000B0E80
		public static ExploreRouletteType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRouletteTypeById.HandleId, ConfigExploreRouletteTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRouletteTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreRouletteType?(ExploreRouletteType.GetRootAsExploreRouletteType(configBuffer));
				}
			}
			ConfigExploreRouletteTypeById.LogPair.Clear();
			ConfigExploreRouletteTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreRouletteTypeById.HandleId, 1, p0Id, ConfigExploreRouletteTypeById.LogPair) || ConfigCommon.Step(ConfigExploreRouletteTypeById.HandleId, true, ConfigExploreRouletteTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreRouletteTypeById.HandleId, ConfigExploreRouletteTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRouletteTypeById.HandleId, 0, ConfigExploreRouletteTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreRouletteTypeById.HandleId, ConfigExploreRouletteTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreRouletteType rootAsExploreRouletteType = ExploreRouletteType.GetRootAsExploreRouletteType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRouletteTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreRouletteTypeById.HandleId, ConfigExploreRouletteTypeById.LogPair);
			return new ExploreRouletteType?(rootAsExploreRouletteType);
		}

		// Token: 0x0400124B RID: 4683
		private const string DB = "db_explore_skill.db";

		// Token: 0x0400124C RID: 4684
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x0400124D RID: 4685
		private const string TABLE = "ExploreRouletteType";

		// Token: 0x0400124E RID: 4686
		private const string COMMAND = "select BinData from `ExploreRouletteType` where Id=?";

		// Token: 0x0400124F RID: 4687
		private const string KEY_PREFIX = "ExploreRouletteTypeById";

		// Token: 0x04001250 RID: 4688
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001251 RID: 4689
		private static int HandleId;
	}
}
