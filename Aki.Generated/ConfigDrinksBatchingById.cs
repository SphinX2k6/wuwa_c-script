using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000235 RID: 565
	public class ConfigDrinksBatchingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x000A81AF File Offset: 0x000A63AF
		static ConfigDrinksBatchingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksBatchingById.CreateStaticDefaultValue), new Action(ConfigDrinksBatchingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000A81D0 File Offset: 0x000A63D0
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

		// Token: 0x06000D44 RID: 3396 RVA: 0x000A824F File Offset: 0x000A644F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksBatchingById.LogPair = null;
			ConfigDrinksBatchingById.HandleId = 0;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000A825D File Offset: 0x000A645D
		public static void Init()
		{
			ConfigDrinksBatchingById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksBatchingById.HandleId, "db_drinks.db", "select BinData from `DrinksBatching` where Id=?");
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000A8278 File Offset: 0x000A6478
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

		// Token: 0x04000F57 RID: 3927
		private const string DB = "db_drinks.db";

		// Token: 0x04000F58 RID: 3928
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F59 RID: 3929
		private const string TABLE = "DrinksBatching";

		// Token: 0x04000F5A RID: 3930
		private const string COMMAND = "select BinData from `DrinksBatching` where Id=?";

		// Token: 0x04000F5B RID: 3931
		private const string KEY_PREFIX = "DrinksBatchingById";

		// Token: 0x04000F5C RID: 3932
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F5D RID: 3933
		private static int HandleId;
	}
}
