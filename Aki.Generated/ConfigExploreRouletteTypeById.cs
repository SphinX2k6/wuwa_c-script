using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B5 RID: 693
	public class ConfigExploreRouletteTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001043 RID: 4163 RVA: 0x000B8E7B File Offset: 0x000B707B
		static ConfigExploreRouletteTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteTypeById.CreateStaticDefaultValue), new Action(ConfigExploreRouletteTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000B8E9C File Offset: 0x000B709C
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

		// Token: 0x06001045 RID: 4165 RVA: 0x000B8F1B File Offset: 0x000B711B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteTypeById.LogPair = null;
			ConfigExploreRouletteTypeById.HandleId = 0;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000B8F29 File Offset: 0x000B7129
		public static void Init()
		{
			ConfigExploreRouletteTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteTypeById.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteType` where Id=?");
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000B8F44 File Offset: 0x000B7144
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

		// Token: 0x040012D7 RID: 4823
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012D8 RID: 4824
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012D9 RID: 4825
		private const string TABLE = "ExploreRouletteType";

		// Token: 0x040012DA RID: 4826
		private const string COMMAND = "select BinData from `ExploreRouletteType` where Id=?";

		// Token: 0x040012DB RID: 4827
		private const string KEY_PREFIX = "ExploreRouletteTypeById";

		// Token: 0x040012DC RID: 4828
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012DD RID: 4829
		private static int HandleId;
	}
}
