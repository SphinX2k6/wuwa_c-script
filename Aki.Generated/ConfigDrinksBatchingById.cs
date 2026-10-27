using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000223 RID: 547
	public class ConfigDrinksBatchingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CD6 RID: 3286 RVA: 0x000A2277 File Offset: 0x000A0477
		static ConfigDrinksBatchingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksBatchingById.CreateStaticDefaultValue), new Action(ConfigDrinksBatchingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000A2298 File Offset: 0x000A0498
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksBatchingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksBatchingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksBatching"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksBatching` where Id=?")
			});
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000A2317 File Offset: 0x000A0517
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksBatchingById.LogPair = null;
			ConfigDrinksBatchingById.HandleId = 0;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000A2325 File Offset: 0x000A0525
		public static void Init()
		{
			ConfigDrinksBatchingById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksBatchingById.HandleId, "db_drinks.db", "select BinData from `DrinksBatching` where Id=?");
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000A2340 File Offset: 0x000A0540
		public static DrinksBatching? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksBatchingById.HandleId, ConfigDrinksBatchingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksBatchingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksBatching?(DrinksBatching.GetRootAsDrinksBatching(configBuffer));
				}
			}
			ConfigDrinksBatchingById.LogPair.Clear();
			ConfigDrinksBatchingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksBatchingById.HandleId, 1, p0Id, ConfigDrinksBatchingById.LogPair) || ConfigCommon.Step(ConfigDrinksBatchingById.HandleId, true, ConfigDrinksBatchingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksBatchingById.HandleId, ConfigDrinksBatchingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksBatchingById.HandleId, 0, ConfigDrinksBatchingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksBatchingById.HandleId, ConfigDrinksBatchingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksBatching rootAsDrinksBatching = DrinksBatching.GetRootAsDrinksBatching(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksBatchingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksBatchingById.HandleId, ConfigDrinksBatchingById.LogPair);
			return new DrinksBatching?(rootAsDrinksBatching);
		}

		// Token: 0x04000ED9 RID: 3801
		private const string DB = "db_drinks.db";

		// Token: 0x04000EDA RID: 3802
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EDB RID: 3803
		private const string TABLE = "DrinksBatching";

		// Token: 0x04000EDC RID: 3804
		private const string COMMAND = "select BinData from `DrinksBatching` where Id=?";

		// Token: 0x04000EDD RID: 3805
		private const string KEY_PREFIX = "DrinksBatchingById";

		// Token: 0x04000EDE RID: 3806
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EDF RID: 3807
		private static int HandleId;
	}
}
