using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023A RID: 570
	public class ConfigDrinksDrinkMixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x000A8B5F File Offset: 0x000A6D5F
		static ConfigDrinksDrinkMixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkMixById.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkMixById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000A8B80 File Offset: 0x000A6D80
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksDrinkMixById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksDrinkMixById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksDrinkMix"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksDrinkMix` where Id=?")
			});
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000A8BFF File Offset: 0x000A6DFF
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkMixById.LogPair = null;
			ConfigDrinksDrinkMixById.HandleId = 0;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000A8C0D File Offset: 0x000A6E0D
		public static void Init()
		{
			ConfigDrinksDrinkMixById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkMixById.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkMix` where Id=?");
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000A8C28 File Offset: 0x000A6E28
		public static DrinksDrinkMix? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksDrinkMixById.HandleId, ConfigDrinksDrinkMixById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksDrinkMixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DrinksDrinkMix?(DrinksDrinkMix.GetRootAsDrinksDrinkMix(configBuffer));
				}
			}
			ConfigDrinksDrinkMixById.LogPair.Clear();
			ConfigDrinksDrinkMixById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDrinksDrinkMixById.HandleId, 1, p0Id, ConfigDrinksDrinkMixById.LogPair) || ConfigCommon.Step(ConfigDrinksDrinkMixById.HandleId, true, ConfigDrinksDrinkMixById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksDrinkMixById.HandleId, ConfigDrinksDrinkMixById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksDrinkMixById.HandleId, 0, ConfigDrinksDrinkMixById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksDrinkMixById.HandleId, ConfigDrinksDrinkMixById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksDrinkMix rootAsDrinksDrinkMix = DrinksDrinkMix.GetRootAsDrinksDrinkMix(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksDrinkMixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksDrinkMixById.HandleId, ConfigDrinksDrinkMixById.LogPair);
			return new DrinksDrinkMix?(rootAsDrinksDrinkMix);
		}

		// Token: 0x04000F7A RID: 3962
		private const string DB = "db_drinks.db";

		// Token: 0x04000F7B RID: 3963
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F7C RID: 3964
		private const string TABLE = "DrinksDrinkMix";

		// Token: 0x04000F7D RID: 3965
		private const string COMMAND = "select BinData from `DrinksDrinkMix` where Id=?";

		// Token: 0x04000F7E RID: 3966
		private const string KEY_PREFIX = "DrinksDrinkMixById";

		// Token: 0x04000F7F RID: 3967
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F80 RID: 3968
		private static int HandleId;
	}
}
