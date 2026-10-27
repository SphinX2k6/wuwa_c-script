using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000228 RID: 552
	public class ConfigDrinksDrinkMixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x000A2C27 File Offset: 0x000A0E27
		static ConfigDrinksDrinkMixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkMixById.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkMixById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000A2C48 File Offset: 0x000A0E48
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

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000A2CC7 File Offset: 0x000A0EC7
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkMixById.LogPair = null;
			ConfigDrinksDrinkMixById.HandleId = 0;
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000A2CD5 File Offset: 0x000A0ED5
		public static void Init()
		{
			ConfigDrinksDrinkMixById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkMixById.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkMix` where Id=?");
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
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

		// Token: 0x04000EFC RID: 3836
		private const string DB = "db_drinks.db";

		// Token: 0x04000EFD RID: 3837
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EFE RID: 3838
		private const string TABLE = "DrinksDrinkMix";

		// Token: 0x04000EFF RID: 3839
		private const string COMMAND = "select BinData from `DrinksDrinkMix` where Id=?";

		// Token: 0x04000F00 RID: 3840
		private const string KEY_PREFIX = "DrinksDrinkMixById";

		// Token: 0x04000F01 RID: 3841
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F02 RID: 3842
		private static int HandleId;
	}
}
